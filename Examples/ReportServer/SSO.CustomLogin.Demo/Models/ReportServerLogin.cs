using System.ComponentModel.DataAnnotations;

namespace CustomLoginApp.Models
{
    public class ReportServerLogin
    {
        [Display(Name = "Certificate name")]
        public string CertificateName { get; set; }
        public string Url { get; set; }
        public string Endpoint { get; set; }
        public string Username { get; set; }
        public string Error { get; set; }
    }
}