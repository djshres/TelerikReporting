using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Globalization;
using Telerik.Blazor.Services;
using Telerik.Reporting.Cache.File;
using Telerik.Reporting.Services;
using Telerik.ReportViewer.BlazorNative.Services;

namespace CSharp.Net6.BlazorNativeIntegrationDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EnableTracing();
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages()
                            .AddNewtonsoftJson();
            builder.Services.AddServerSideBlazor();

    var reportsPath = Path.Combine(builder.Environment.ContentRootPath, "..", "..", "..", "..", "Report Designer", "Examples");

            // Configure dependencies for ReportsController.
            builder.Services.TryAddSingleton<IReportServiceConfiguration>(sp =>
                new ReportServiceConfiguration
                {
                    // The default ReportingEngineConfiguration will be initialized from appsettings.json or appsettings.{EnvironmentName}.json:
                    ReportingEngineConfiguration = sp.GetService<IConfiguration>(),

                    // In case the ReportingEngineConfiguration needs to be loaded from a specific configuration file, use the approach below:
                    //ReportingEngineConfiguration = ResolveSpecificReportingConfiguration(sp.GetService<IWebHostEnvironment>()),
                    HostAppId = "Net6BlazorNativeDemo",
                    Storage = new FileStorage(),
                    ReportSourceResolver = new TypeReportSourceResolver()
                                               .AddFallbackResolver(new UriReportSourceResolver(reportsPath))
                });

            builder.Services.AddSingleton(typeof(ITelerikReportingStringLocalizer), typeof(CustomStringLocalizer));
            builder.Services.AddSingleton(typeof(ITelerikStringLocalizer), typeof(TelerikCustomStringLocalizer));
            builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
            builder.Services.Configure<RequestLocalizationOptions>(options =>
            {
                // define the list of cultures your app will support
                var supportedCultures = new List<CultureInfo>()
                {
                    new CultureInfo("en-US"),
                    new CultureInfo("bg-BG")
                };

                options.DefaultRequestCulture = new RequestCulture("en-US");

                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

            app.Run();
        }

        /// <summary>
        /// Uncomment the lines to enable tracing in the current application.
        /// The trace log will be persisted in a file named log.txt in the application root directory.
        /// </summary>
        static void EnableTracing()
        {
            // System.Diagnostics.Trace.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(File.CreateText("log.txt")));
            // System.Diagnostics.Trace.AutoFlush = true;
        }

        /// <summary>
        /// Loads a reporting configuration from a specific JSON-based configuration file.
        /// </summary>
        /// <param name="environment">The current web hosting environment used to obtain the content root path</param>
        /// <returns>IConfiguration instance used to initialize the Reporting engine</returns>
        static IConfiguration ResolveSpecificReportingConfiguration(IWebHostEnvironment environment)
        {
            // If a specific configuration needs to be passed to the reporting engine, add it through a new IConfiguration instance.
            var reportingConfigFileName = Path.Combine(environment.ContentRootPath, "reportingAppSettings.json");
            return new ConfigurationBuilder()
                .AddJsonFile(reportingConfigFileName, true)
                .Build();
        }
    }
}