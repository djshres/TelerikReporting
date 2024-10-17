namespace CSharp.Net7.BlazorNativeIntegrationDemo
{
    using CSharp.Net7.BlazorNativeIntegrationDemo.Resources;
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
