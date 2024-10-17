﻿namespace CSharp.Net6.BlazorIntegrationDemo.Controllers
{
    using System;
    using System.Net;
    using System.Net.Mail;
    using Microsoft.AspNetCore.Mvc;
    using Telerik.Reporting.Services;
    using Telerik.Reporting.Services.AspNetCore;

    [Serializable]
    [Route("api/reports")]
    [ApiController]
    public class ReportsController : ReportsControllerBase
    {
        public ReportsController(IReportServiceConfiguration reportServiceConfiguration)
              : base(reportServiceConfiguration)
        {
        }

        protected override HttpStatusCode SendMailMessage(MailMessage mailMessage)
        {
            throw new System.NotImplementedException("This method should be implemented in order to send mail messages");

            // using (var smtpClient = new SmtpClient("smtp01.mycompany.com", 25))
            // {
            //    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            //    smtpClient.EnableSsl = false;

            // smtpClient.Send(mailMessage);
            // }
            // return HttpStatusCode.OK;
        }
    }
}
