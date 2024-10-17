namespace CSharp.NetFramework.AspNetMvcIntegrationDemo.Controllers
{
    using System.IO;
    using System.Net;
    using System.Net.Mail;
    using System.Web;
    using Telerik.Reporting.Cache.File;
    using Telerik.Reporting.Services;
    using Telerik.Reporting.Services.WebApi;

    public class ReportsController : ReportsControllerBase
    {
        static ReportServiceConfiguration preservedConfiguration;

        static IReportServiceConfiguration PreservedConfiguration
        {
            get
            {
                if (preservedConfiguration == null)
                {
                    preservedConfiguration = new ReportServiceConfiguration
                    {
                        HostAppId = "MvcDemoApp",
                        Storage = new FileStorage(),
                        ReportSourceResolver = CreateResolver(),

                        // ReportSharingTimeout = 0,
                        // ClientSessionTimeout = 15,
                    };
                }

                return preservedConfiguration;
            }
        }

        public ReportsController()
        {
            this.ReportServiceConfiguration = PreservedConfiguration;
        }

        protected override HttpStatusCode SendMailMessage(MailMessage mailMessage)
        {
            throw new System.NotImplementedException("This method should be implemented in order to send mail messages.");

            // using (var smtpClient = new SmtpClient("smtp01.mycompany.com", 25))
            // {
            //     smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            //     smtpClient.EnableSsl = false;
            //     smtpClient.Send(mailMessage);
            // }
            // return HttpStatusCode.OK;
        }

        static IReportSourceResolver CreateResolver()
        {
            var appPath = HttpContext.Current.Server.MapPath("~/");
            var reportsPath = Path.Combine(appPath, @"..\..\..\..\Report Designer\Examples");

            return new UriReportSourceResolver(reportsPath)
                .AddFallbackResolver(new TypeReportSourceResolver());
        }
    }
}
