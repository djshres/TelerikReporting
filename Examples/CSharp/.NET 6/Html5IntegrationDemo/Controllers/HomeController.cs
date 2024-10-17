using Microsoft.AspNetCore.Mvc;

namespace CSharp.Net6.Html5IntegrationDemo.Controllers
{
    /// <summary>
    /// Used to ensure the default starting page from Docker container
    /// </summary>
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("/index.html");
        }
    }
}
