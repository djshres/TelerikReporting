namespace CSharp.NetFramework.Html5IntegrationDemo.Controllers
{
    using System.IO;
    using System.Net;
    using System.Net.Mail;
    using System.Web;
    using Telerik.Reporting;
    using Telerik.Reporting.Cache.File;
    using Telerik.Reporting.Services;
    using Telerik.Reporting.Services.WebApi;

    public class ReportsController : ReportsControllerBase
    {
        static ReportServiceConfiguration configurationInstance;

        static ReportsController()
        {
            var appPath = HttpContext.Current.Server.MapPath("~/");
            var reportsPath = Path.Combine(appPath, @"..\..\..\..\Report Designer\Examples");
            IReportSourceResolver resolver = new UriReportSourceResolver(reportsPath)
                .AddFallbackResolver(new TypeReportSourceResolver());

            configurationInstance = new ReportServiceConfiguration
            {
                HostAppId = "Html5DemoApp",
                Storage = new FileStorage(),
                ReportSourceResolver = resolver,
                // ReportSharingTimeout = 0,
                // ClientSessionTimeout = 15,
                // ReportDocumentResolver = new CustomReportDocumentResolver(),
            };
        }

        public ReportsController()
        {
            this.ReportServiceConfiguration = configurationInstance;
        }

        protected override HttpStatusCode SendMailMessage(MailMessage mailMessage)
        {
            throw new System.NotImplementedException("This method should be implemented in order to send mail messages.");
            /*
            using (var smtpClient = new SmtpClient("smtp01.mycompany.com", 25))
            {
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = false;

                smtpClient.Send(mailMessage);
            }
            return HttpStatusCode.OK;
            */
        }

        class CustomReportDocumentResolver : IReportDocumentResolver
        {
            IReportDocument IReportDocumentResolver.Resolve(ReportSource input)
            {
                // Custom logic for retrieving an IReportDocument from the ReportSource
                // Used to affect the report document resolution for SubReport-s, etc.

                // Fall back to the built-in logic
                return null;
            }
        }
    }
}
