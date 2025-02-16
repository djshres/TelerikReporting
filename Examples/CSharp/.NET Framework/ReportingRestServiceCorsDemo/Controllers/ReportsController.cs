namespace CSharp.NetFramework.ReportingRestServiceCorsDemo.Controllers
{
    using System.IO;
    using System.Web;
    using System.Web.Http.Cors;
    using Telerik.Reporting.Cache.File;
    using Telerik.Reporting.Services;
    using Telerik.Reporting.Services.WebApi;

    //The class name determines the service URL. 
    //ReportsController class name defines /api/report/ service URL.
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ReportsController : ReportsControllerBase
    {
        static ReportServiceConfiguration configurationInstance;

        static ReportsController()
        {
            //This is the folder that contains the report definitions
            //In this case this is the Reports folder
            var appPath = HttpContext.Current.Server.MapPath("~/");
            var reportsPath = Path.Combine(appPath, @"..\..\..\..\Report Designer\Examples");

            //Add resolver for trdx/trdp report definitions, 
            //then add resolver for class report definitions as fallback resolver; 
            //finally create the resolver and use it in the ReportServiceConfiguration instance.

            //The obsolete resolver
            //var resolver = new ReportFileResolver(reportsPath)
            //    .AddFallbackResolver(new ReportTypeResolver());

            var resolver = new UriReportSourceResolver(reportsPath)
               .AddFallbackResolver(new TypeReportSourceResolver());
            //Setup the ReportServiceConfiguration
            configurationInstance = new ReportServiceConfiguration
            {
                HostAppId = "Html5App",
                Storage = new FileStorage(),
                //ReportResolver is obsolete
                ReportSourceResolver = resolver,
                // ReportSharingTimeout = 0,
                // ClientSessionTimeout = 15,
            };
        }

        public ReportsController()
        {
			//Initialize the service configuration
            this.ReportServiceConfiguration = configurationInstance;
        }
    }
}