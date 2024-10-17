using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telerik.ReportServer.HttpClient;

namespace CustomLoginApp.Models
{
    public class LoginSignInfo
    {
        public string CertificateName { get; set; }
        public CustomLoginData CustomLoginData { get; set; }
    }
}