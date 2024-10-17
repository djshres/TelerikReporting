using Telerik.WebReportDesigner.Services.Models;
using Telerik.WebReportDesigner.Services;
using Telerik.Reporting.Cache.File;
using Telerik.Reporting.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.IO;
using CSharp.Net8.BlazorIntegrationDemo.Components;
using CSharp.Net8.BlazorIntegrationDemo;


EnableTracing();
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages().AddNewtonsoftJson();
builder.Services.AddControllers();

    var reportsPath = Path.Combine(builder.Environment.ContentRootPath, "..", "..", "..", "..", "Report Designer", "Examples");

// Configure dependencies for ReportsController.
builder.Services.TryAddSingleton<IReportServiceConfiguration>(sp =>
    new ReportServiceConfiguration
    {
        // The default ReportingEngineConfiguration will be initialized from appsettings.json or appsettings.{EnvironmentName}.json:
        ReportingEngineConfiguration = sp.GetService<IConfiguration>(),

        // In case the ReportingEngineConfiguration needs to be loaded from a specific configuration file, use the approach below:
        //ReportingEngineConfiguration = ResolveSpecificReportingConfiguration(sp.GetService<IWebHostEnvironment>()),
        HostAppId = "Net8BlazorDemo",
        Storage = new FileStorage(),
        ReportSourceResolver = new TypeReportSourceResolver()
            .AddFallbackResolver(
                new UriReportSourceResolver(reportsPath))
    });

// Configure dependencies for ReportDesignerController.
builder.Services.TryAddSingleton<IReportDesignerServiceConfiguration>(sp => new ReportDesignerServiceConfiguration
{
    DefinitionStorage = new FileDefinitionStorage(reportsPath, new[] { "Resources", "Shared Data Sources" }),
    ResourceStorage = new ResourceStorage(Path.Combine(reportsPath, "Resources")),
    SharedDataSourceStorage = new FileSharedDataSourceStorage(Path.Combine(reportsPath, "Shared Data Sources")),
    SettingsStorage = new FileSettingsStorage(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Telerik Reporting")),
    // In case you need to define custom permissions to deny, modify GetDeniedPermissions function based on your needs and use the approach below:
    //DeniedPermissions = GetDeniedPermissions(),
});

builder.Services.AddServerSideBlazor();


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

app.UseRouting();
app.UseAntiforgery();
app.UseEndpoints(endpoints =>
{
	endpoints.MapControllers();
	// ... 
});
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Initialize the paths for the custom resource resolver.            
// Shows how to initialize a custom IResourceResolver implementation with the folder used for report resources retrieval.
// This step is not mandatory and is added for demonstration purposes only.
CustomResourceResolver.Configuration.Instance.Init(reportsPath,
                                                   Path.Combine(reportsPath, "Resources"));

// Initialize the paths for the custom SharedDataSource resolver.            
// Shows how to initialize a custom ISharedDataSourceResolver implementation with the folder used for reports and shared data sources.
// This step is not mandatory and is added for demonstration purposes only.
CustomSharedDataSourceResolver.Configuration.Instance.Init(reportsPath,
                                                   Path.Combine(reportsPath, "Shared Data Sources"));

app.Run();

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

/// <summary>
/// Builds permissions which will be denied. Use ReportDesignerPermissionsBuilder for easy conversion between Permission enum to string.
/// In this example implementation the user can't create data sources, can't edit and delete shared data sources and can't access "Shared Data Sources" folder in the assets manager.
/// </summary>
/// <returns>String array with permissions to deny on application level.</returns>
static string[] GetDeniedPermissions()
{
    return ReportDesignerPermissionsBuilder.Build(
        Permission.Commands_DataSources,
        Permission.Commands_AssetsManager_SharedDataSources
    );
}