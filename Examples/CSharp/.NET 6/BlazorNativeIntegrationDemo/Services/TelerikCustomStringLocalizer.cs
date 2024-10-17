namespace CSharp.Net6.BlazorNativeIntegrationDemo
{
    using CSharp.Net6.BlazorNativeIntegrationDemo.Resources;
    using Telerik.Blazor.Services;

    public class TelerikCustomStringLocalizer : ITelerikStringLocalizer
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
            return TelerikMessages.ResourceManager.GetString(key, TelerikMessages.Culture);
        }
    }
}
