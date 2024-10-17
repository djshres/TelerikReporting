using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Telerik.ReportServer.HttpClient;
using Telerik.ReportServer.Services.Models;
using Telerik.ReportServer.Services.Models.RecurrenceRules;

namespace ReportServerClientDemo
{
    class ReportServerAPIHelper
    {
        const string USER_ROLE_NAME = "ExampleUserRole";
        const string USER_NAME = "ExampleUser";
        const string PASSWORD = "ExamplePassword";
        const string CONNECTION_NAME = "ExampleConnection";
        const string CATEGORY_NAME = "ExampleCategory";
        const string REPORT_NAME = "ExampleReport1";
        const string SCHEDULED_TASK_NAME = "ExampleScheduledTask";
        const string DATA_ALERT_NAME = "ExampleDataAlert";
        const string EXTERNAL_EMAIL_SUBSCRIBER = "email.subscriber@somemailserver.com";

        static Action<string> log;

        public static void ExecuteSampleScenario(ClientSettingsModel model, Action<string> logCallback)
        {
            log = logCallback;
            var settings = new Settings()
            {
                BaseAddress = model.BaseAddress
            };

            using (var client = new ReportServerClient(settings))
            {
                client.Login(model.Username, model.Password);
                DoWithClient(Cleanup, client);
                CreateWithClient(CreateUserRole, client);
                CreateWithClient(CreateUserPermissions, client).ToList();
                var user = CreateWithClient(CreateUser, client);

                //Login with the newly created user
                client.Logout();
                client.Login(user.Username, PASSWORD);
                
                CreateWithClient(CreateConnection, client);
                CreateWithClient(UpdateConnection, client);
                CreateWithClient(CreateCategory, client);
                CreateWithClient(UpdateCategory, client);
                CreateWithClient(CreateReport, client);
                CreateWithClient(UpdateReport, client);
                var trdpReportRevision = CreateWithClient<ReportRevisionContent>(GetLatestReportRevision, client);
                System.Diagnostics.Debug.Assert(trdpReportRevision.Extension == ".trdp");

                DoWithClient(AddReportRevision, client);
                var trdxReportRevision = CreateWithClient<ReportRevisionContent>(GetLatestReportRevision, client);
                System.Diagnostics.Debug.Assert(trdxReportRevision.Extension == ".trdx");

                CreateWithClient<ScheduledTask>(CreateScheduledTask, client);                
                CreateWithClient<DataAlert>(CreateDataAlert, client);
                
                var documentBytes = CreateWithClient<byte[]>(ExportDocument, client);
                //File.WriteAllBytes($@"C:\temp\{REPORT_NAME}.pdf", documentBytes);
                //System.Diagnostics.Process.Start($@"C:\temp\{REPORT_NAME}.pdf");

                //switch to user with administrative rights so the cleanup could be completed.
                client.Logout();
                client.Login(model.Username, model.Password);
                DoWithClient(Cleanup, client);
                client.Logout();
            }
        }

        static void DoWithClient(Action<ReportServerClient> action, ReportServerClient client)
        {
            action(client);
            log(string.Format("Method {0}() completed.", action.Method.Name));
        }

        static T CreateWithClient<T>(Func<ReportServerClient, T> func, ReportServerClient client) where T : class
        {
            var obj = func(client);
            log(string.Format("Method {0}() completed. Instance of \"{1}\" created.", func.Method.Name, obj.GetType().Name));
            return obj;
        }

        /// <summary>
        /// Deletes previously added assets.
        /// </summary>
        /// <param name="client"></param>
        static void Cleanup(ReportServerClient client)
        {
            var userRole = client.GetUserRoles().FirstOrDefault(c => c.Name == USER_ROLE_NAME);
            if (null != userRole)
            {
                client.DeleteUserRole(userRole.Id);
            }

            var user = client.GetUsers().FirstOrDefault(c => c.Username == USER_NAME);
            if (null != user)
            {
                foreach(var permission in client.GetPermissions(user.Id, PermissionCategory.DataConnection)
                                  .Concat(client.GetPermissions(user.Id, PermissionCategory.Category))
                                  .Concat(client.GetPermissions(user.Id, PermissionCategory.Report))
                                  .Concat(client.GetPermissions(user.Id, PermissionCategory.ScheduledTask))
                                  .Concat(client.GetPermissions(user.Id, PermissionCategory.DataAlert)))
                {
                    client.DeletePermission(permission.PermissionCategory, permission.Id);
                }

                client.DeleteUser(user.Id);
            }

            var connection = client.GetDataConnections().FirstOrDefault(c => c.Name == CONNECTION_NAME);
            if (null != connection)
            {
                client.DeleteDataConnection(connection.Id);
            }

            var report = client.GetReportInfos().FirstOrDefault(r => r.Name == REPORT_NAME);
            if (null != report)
            {
                client.DeleteReport(report.Id);
            }

            var category = client.GetCategories().FirstOrDefault(c => c.Name == CATEGORY_NAME);
            if (null != category)
            {
                client.DeleteCategory(category.Id);
            }

            var task = client.GetScheduledTasks().FirstOrDefault(t => t.Name == SCHEDULED_TASK_NAME);
            if (null != task)
            {
                client.DeleteScheduledTask(task.Id);
            }

            var alert = client.GetDataAlerts().FirstOrDefault(t => t.Name == DATA_ALERT_NAME);
            if (null != alert)
            {
                client.DeleteDataAlert(alert.Id);
            }
        }

        static UserRole CreateUserRole(ReportServerClient client)
        {
            var roleData = new CreateUserRoleData()
            {
                Name = USER_ROLE_NAME,
                Description = "user role",
            };

            return client.CreateUserRole(roleData);
        }

        static User CreateUser(ReportServerClient client)
        {
            var userData = new CreateLocalUserData()
            {
                Username = USER_NAME,
                FirstName = "First",
                LastName = "Last",
                Email = "USER_NAME" + "@somemailserver.com",
                Enabled = true,
                Password = PASSWORD,
            };

            var role = client.GetUserRoles().Single(r => r.Name == USER_ROLE_NAME);
            userData.RoleIds = new[] { role.Id };

            return client.CreateLocalUser(userData);
        }

        static IEnumerable<Permission> CreateUserPermissions(ReportServerClient client)
        {
            var role = client.GetUserRoles().Single(r => r.Name == USER_ROLE_NAME);
            yield return client.AddUserRolePermission(role.Id, new CreatePermissionModel()
                                                            {
                                                                Access = AccessPermission.Unrestricted,
                                                                Scope = PermissionScope.AnyDataConnection,
                                                                ResourceId = PermissionScope.AnyDataConnection.ToString(),
                                                            });
            yield return client.AddUserRolePermission(role.Id, new CreatePermissionModel()
                                                            {
                                                                Access = AccessPermission.Unrestricted,
                                                                Scope = PermissionScope.AnyCategory,
                                                                ResourceId = PermissionScope.AnyCategory.ToString(),
                                                            });
            yield return client.AddUserRolePermission(role.Id, new CreatePermissionModel()
                                                            {
                                                                Access = AccessPermission.Unrestricted,
                                                                Scope = PermissionScope.AnyReport,
                                                                ResourceId = PermissionScope.AnyReport.ToString()
                                                            });
            yield return client.AddUserRolePermission(role.Id, new CreatePermissionModel()
                                                            {
                                                                Access = AccessPermission.Unrestricted,
                                                                Scope = PermissionScope.AnyScheduledTask,
                                                                ResourceId = PermissionScope.AnyScheduledTask.ToString(),
                                                            });
            yield return client.AddUserRolePermission(role.Id, new CreatePermissionModel()
                                                            {
                                                                Access = AccessPermission.Unrestricted,
                                                                Scope = PermissionScope.AnyDataAlert,
                                                                ResourceId = PermissionScope.AnyDataAlert.ToString(),
                                                            });
        }

        /// <summary>
        /// Creates a new data connection
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        static DataConnection CreateConnection(ReportServerClient client)
        {
            var connData = new CreateDataConnectionData()
            {
                Name = CONNECTION_NAME,
                Provider = "System.Data.SqlClient",
                ConnectionString = "conn",
                Description = "a new database connection to SQL Server"
            };

            return client.CreateDataConnection(connData);
        }

        /// <summary>
        /// Updates an existing data connection
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        static DataConnection UpdateConnection(ReportServerClient client)
        {
            var existingConnection = client.GetDataConnections().Single(c => c.Name == CONNECTION_NAME);
            existingConnection.ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=AdventureWorks; Integrated Security=true";
            existingConnection.Description = "This data connection has been updated.";

            return client.UpdateDataConnection(existingConnection);
        }

        /// <summary>
        /// Creates a new category
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        static Category CreateCategory(ReportServerClient client)
        {
            var categoryData = new CreateCategoryData()
            {
                Name = "sampleCategoryName"
            };

            return client.CreateCategory(categoryData);
        }

        /// <summary>
        /// Updates an existing category
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        static Category UpdateCategory(ReportServerClient client)
        {
            var existingCategory = client.GetCategories().Single(r => r.Name == "sampleCategoryName");
            existingCategory.Name = CATEGORY_NAME;

            return client.UpdateCategory(existingCategory);
        }

        /// <summary>
        /// Creates a new report from existing TRDP file
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        static ReportInfo CreateReport(ReportServerClient client)
        {
            var reportPath = @".\Reports\Report1.trdp";
            if (!File.Exists(reportPath))
            {
                throw new FileNotFoundException(string.Format("Report {0} not found.", reportPath));
            }

            var reportData = new CreateReportInfoData()
            {
                CategoryId = client.GetCategories().Single(c => c.Name == CATEGORY_NAME).Id,
                Name = REPORT_NAME,
                Extension = ".trdp",
                Content = File.ReadAllBytes(reportPath)
            };

            var reportInfo = client.CreateReport(reportData);
            var revs = client.GetReportRevisions(reportInfo.Id);
            System.Diagnostics.Debug.Assert(revs.Count() == 1);

            return reportInfo;
        }

        /// <summary>
        /// Updates an existing report
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        static ReportInfo UpdateReport(ReportServerClient client)
        {
            var existingReport = client.GetReportInfos().Single(r => r.Name == REPORT_NAME);
            var updateReportInfo = new UpdateReportInfo()
            {
                Name = REPORT_NAME,
                CategoryId = existingReport.CategoryId,
                Id = existingReport.Id,
                Description = "This report has been updated.",
            };

            return client.UpdateReport(updateReportInfo);
        }

        /// <summary>
        /// Adds TRDX report revision to existing report
        /// </summary>
        /// <param name="client"></param>
        /// <param name="reportInstance"></param>
        static void AddReportRevision(ReportServerClient client)
        {
            var reportPath = @".\Reports\Report2.trdx";
            if (!File.Exists(reportPath))
            {
                throw new FileNotFoundException(string.Format("Report {0} not found.", reportPath));
            }

            var revision = new CreateReportRevisionData()
            {
                Comment = "new trdx revision",
                Extension = ".trdx",
                Content = File.ReadAllBytes(reportPath)
            };

            var existingReport = client.GetReportInfos().Single(r => r.Name == REPORT_NAME);
            client.AddReportRevision(existingReport.Id, revision);
        }

        /// <summary>
        /// Gets the latest report revision for a report
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        static ReportRevisionContent GetLatestReportRevision(ReportServerClient client)
        {
            var reportInfo = client.GetReportInfos().Single(r => r.Name == REPORT_NAME);
            return client.GetLatestReportRevision(reportInfo.Id);
        }

        /// <summary>
        /// Creates a scheduled task using previously created report
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        static ScheduledTask CreateScheduledTask(ReportServerClient client)
        {
            var recurrenceRule = RecurrenceRule.CreateRule(RecurrenceType.Daily);
            recurrenceRule.Start = DateTime.Now;
            recurrenceRule.End = DateTime.Now.AddDays(1);
            recurrenceRule.Interval = 1;
            recurrenceRule.Count = 3;

            var mailTemplate = new TaskMailTemplateModel()
            {
                Subject = "A report generated by task {TaskName}",
                Body = "{ReportName} report has been generated."
            };

            var taskData = new ScheduledTaskCreateData()
            {
                Name = SCHEDULED_TASK_NAME,
                Enabled = true,
                StartDate = DateTime.Now,
                RecurrenceRule = recurrenceRule,
                ExternalEmails = new List<string>() { EXTERNAL_EMAIL_SUBSCRIBER },
                ExternalUsersMailTemplate = mailTemplate,
                LocalUsersMailTemplate = mailTemplate,
            };

            var existingReport = client.GetReportInfos().Single(r => r.Name == REPORT_NAME);
            taskData.Reports = new List<ScheduledTaskReport>()
            {
                new ScheduledTaskReport()
                {
                    ReportId = existingReport.Id,
                    DocumentFormat = "PDF",
                    Parameters = new Dictionary<string, object>()
                }
            };

            return client.CreateScheduledTask(taskData);
        }

        /// <summary>
        /// Creates a data alert using previously created report
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        static DataAlert CreateDataAlert(ReportServerClient client)
        {
            var recurrenceRule = RecurrenceRule.CreateRule(RecurrenceType.Daily);
            recurrenceRule.Start = DateTime.Now;
            recurrenceRule.End = DateTime.Now.AddDays(1);
            recurrenceRule.Interval = 1;
            recurrenceRule.Count = 3;

            var mailTemplate = new TaskMailTemplateModel()
            {
                Subject = "A report generated by dataAlert {AlertName}",
                Body = "{ReportName} report has been generated."
            };

            var alertData = new DataAlertCreateData()
            {
                Name = DATA_ALERT_NAME,
                Enabled = true,
                StartDate = DateTime.Now,
                RecurrenceRule = recurrenceRule,
                ExternalEmails = new List<string>() { EXTERNAL_EMAIL_SUBSCRIBER },
                ExternalUsersMailTemplate = mailTemplate,
                LocalUsersMailTemplate = mailTemplate,
            };

            alertData.Rules = new List<DataAlertRule>()
            {
                new DataAlertRule()
                {
                    Clauses = new List<Clause>()
                    {
                        new Clause()
                        {
                            Column = "textBoxProductCategoryId",
                            Operator = Telerik.ReportServer.Services.Models.FilterOperator.GreaterOrEqual,
                            Value = "4"
                        }
                    },
                    DataItemName = "table1",
                    Index = 0
                }
            };

            var existingReport = client.GetReportInfos().Single(r => r.Name == REPORT_NAME);
            alertData.Reports = new List<ScheduledTaskReport>()
            {
                new ScheduledTaskReport()
                {
                    ReportId = existingReport.Id,
                    DocumentFormat = "DOCX",
                    Parameters = new Dictionary<string, object>()
                }
            };

            return client.CreateDataAlert(alertData);
        }

        /// <summary>
        /// Creates a document in single-file format and gets its bytes
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        static byte[] ExportDocument(ReportServerClient client)
        {
            var existingReport = client.GetReportInfos().Single(r => r.Name == REPORT_NAME);

            var model = new CreateDocumentData
            {
                DeviceInfo = new Dictionary<string, object>(),
                Format = "PDF",
                ParameterValues = new Dictionary<string, object>(),
                ReportId = existingReport.Id,
            };

            // Long-running task; May be called in a thread and when ready use the next method
            var documentId = client.CreateDocument(model);

            return client.GetDocument(documentId);
        }
    }
}
