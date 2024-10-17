using CustomLoginApp.Models;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Telerik.ReportServer.HttpClient;

namespace CustomLoginApp.Controllers
{
    public class DefaultController : Controller
    {        
        public ActionResult Index()
        {
            //The ReportServerLogin model contains the login data. Initialize it with the values for the current configuration.
            var model = new ReportServerLogin()
            {
                CertificateName = "myCertificate", //sets the actual name of the certificate used to sign the user claims
                Url = "http://reportserver.home.com:92/", //sets the actual URL of Telerik Report Server instance.
                Endpoint = "api/reportserver/customlogin",
                Username = "admin" //sets the actual name of the user that will be used for login
            };

            return View(model);
        }

        public ActionResult SignCustomLoginData(string serializedSignInfo)
        {
            var signInfo = JsonConvert.DeserializeObject<LoginSignInfo>(serializedSignInfo);

            SignHelper.Sign(signInfo.CustomLoginData, signInfo.CertificateName);

            return new JsonResult()
            {
                Data = JsonConvert.SerializeObject(signInfo.CustomLoginData)
            };
        }

        public ActionResult LoginServerSide(ReportServerLogin model)
        {
            var task = Login(model).Result;
            var result = task;

            if (result.IsSuccessStatusCode)
            {
                return new RedirectResult(model.Url + "Report/Index");
            }
            else
            {
                var error = string.Format("Status: {0}; Content: {1}", result.StatusCode, result.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                System.Diagnostics.Trace.TraceError(error);
                model.Error = error;

                return View("Index", model);
            }
        }

        async Task<HttpResponseMessage> Login(ReportServerLogin model)
        {
            string reason = "";
            var request = new Uri(new Uri(model.Url), model.Endpoint);
            var data = new CustomLoginData(ClaimTypes.NameIdentifier, model.Username);
            SignHelper.Sign(data, model.CertificateName);

            using (var client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync(request, data).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    //Get response Set-Cookie
                    var cookieKey = ".AspNet.ApplicationCookie";
                    var appCookie = response.Headers.GetValues("Set-Cookie")?.FirstOrDefault(c => c.StartsWith(cookieKey));
                    if (null != appCookie)
                    {
                        var cookieValue = appCookie.Substring(appCookie.IndexOf("=") + 1);
                        var newCookie = new HttpCookie(cookieKey, cookieValue);

                        newCookie.Shareable = true;
                        newCookie.Domain = "home.com";
                        newCookie.Expires = DateTime.Now.AddMonths(1);
                        newCookie.Path = "/";

                        HttpContext.Response.Cookies.Remove(cookieKey);
                        HttpContext.Response.SetCookie(newCookie);
                        return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
                    }
                }
                else
                {
                    reason = await response.Content.ReadAsStringAsync();
                    System.Diagnostics.Trace.TraceError(reason);
                }
            }

            return new HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized)
            {
                Content = new StringContent(reason)
            };
        }
    }
}