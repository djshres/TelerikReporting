Progress® Telerik® Reporting Examples 

I. Database Setup 
	During installation, the Telerik Reporting installer will search for a running instance of SQL Server, 
	since it needs to install the AdventureWorks database required by our demos. Supported SQL Server instances 
	are SQL Server 2005 Standard/Express editions or later. In case the installer does not find running SQL instance, 
	the AdventureWorks database will not be installed and the connection string in the application configuration file 
	for all demo projects will be left invalid (connectionString="TELERIK_CONNECTION_STRING").

II. Demo projects dependencies
	The example projects targeting .NET Framework 4.6.2 resolve their Telerik Reporting dependencies through assembly references, locating assemblies in product installation folder.
	The example projects targeting .NET 6+ resolve their Telerik Reporting dependencies through NuGet packages, obtained from Telerik NuGet feed.
	Please ensure you have a valid NuGet package source to Telerik NuGet feed and have valid credentials to access it. 
	For more information please refer to the article 'Adding the Telerik Private NuGet Feed to VS' on https://docs.telerik.com/reporting/getting-started/installation/adding-private-nuget-feed.

	The example projects for Native Blazor report viewer require a valid license for Telerik UI for Blazor.
	The example projects for Native Angular report viewer require a valid license for Kendo UI for Angular.
	
III. Running examples on Docker
	The example projects in .\CSharp folder that demonstrate Blazor, BlazorNative, Html5, and RestServiceCors integrations can be run in Docker environment.
	In each example folder there is a Dockerfile configured to build a Docker image and run a Docker container.
	The examples resolve their Telerik Reporting dependencies through NuGet packages, obtained from Telerik NuGet feed. 
	To enable the package restore, please go to .\CSharp folder, rename the file 'nuget.config.template' to 'nuget.config' and enter your Telerik NuGet credentials in it.