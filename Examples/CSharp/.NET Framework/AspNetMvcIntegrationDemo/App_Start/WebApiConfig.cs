namespace CSharp.NetFramework.AspNetMvcIntegrationDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            Telerik.Reporting.Services.WebApi.ReportsControllerConfiguration.RegisterRoutes(config);
        }
    }
}
