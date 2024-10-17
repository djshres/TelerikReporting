namespace CSharp.Net6.BlazorNativeIntegrationDemo
{
    using CSharp.Net6.BlazorNativeIntegrationDemo.Resources;
    using Telerik.ReportViewer.BlazorNative.Services;

    public class CustomStringLocalizer : ITelerikReportingStringLocalizer
    {
        public string this[string name]
        {
            get
            {
                return this.GetStringFromResource(name);
            }
        }

        public string GetStringFromResource(string key)
        {
            return ReportViewerMessages.ResourceManager.GetString(key, ReportViewerMessages.Culture);
        }
    }
}
