namespace CSharp.Net6.BlazorIntegrationDemo.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using Telerik.Reporting.Services;
    using Telerik.WebReportDesigner.Services;
    using Telerik.WebReportDesigner.Services.Controllers;

    [Route("api/reportdesigner")]
    [ApiController]
    public class ReportDesignerController : ReportDesignerControllerBase
    {
        public ReportDesignerController(IReportDesignerServiceConfiguration reportDesignerServiceConfiguration, IReportServiceConfiguration reportServiceConfiguration)
            : base(reportDesignerServiceConfiguration, reportServiceConfiguration)
        {
        }

        /// <summary>
        /// Gets the denied permissions based on custom user role or business logic.
        /// </summary>
        /// <returns>Array with permissions serialized as JSON. Base implementation returns permissions denied in ReportDesignerServiceConfiguration. </returns>
        //public override IActionResult GetDeniedPermissions()
        //{
        //    return this.HttpContext.User.IsInRole("admin") ? this.Json(Array.Empty<string>()) : base.GetDeniedPermissions();
        //}
    }
}
