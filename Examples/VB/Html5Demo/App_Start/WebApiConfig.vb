Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http

Public Class WebApiConfig
    Public Shared Sub Register(ByVal config As HttpConfiguration)
        Telerik.Reporting.Services.WebApi.ReportsControllerConfiguration.RegisterRoutes(config)
    End Sub
End Class