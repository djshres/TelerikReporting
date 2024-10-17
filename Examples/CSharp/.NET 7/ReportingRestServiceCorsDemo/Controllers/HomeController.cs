using Microsoft.AspNetCore.Mvc;

namespace CSharp.Net7.ReportingRestServiceCorsDemo.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Used to ensure the default starting page from Docker container
        /// </summary>
        public IActionResult Index()
        {
            return Redirect("/index.html");
        }
    }
}
