namespace CSharp.NetFramework.WebFormsIntegrationDemo.Controllers
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
        static readonly ReportServiceConfiguration configurationInstance;

        static ReportsController()
        {
            var appPath = HttpContext.Current.Server.MapPath("~/");
            var reportsPath = Path.Combine(appPath, @"..\..\..\..\Report Designer\Examples");
            var resolver = new UriReportSourceResolver(reportsPath)
                .AddFallbackResolver(new TypeReportSourceResolver());

            configurationInstance = new ReportServiceConfiguration
            {
                HostAppId = "Html5DemoApp",
                Storage = new FileStorage(),
                ReportSourceResolver = resolver,
                // ReportSharingTimeout = 0,
                // ClientSessionTimeout = 15,
            };
        }

        public ReportsController()
        {
            this.ReportServiceConfiguration = configurationInstance;
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
    }
}