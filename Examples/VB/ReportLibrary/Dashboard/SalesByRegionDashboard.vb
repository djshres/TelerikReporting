
Imports System
Imports System.ComponentModel
Imports System.Net

''' <summary>
''' Summary description for DashBoard.
''' </summary>
<Description("Sales distribution across the world.")> _
Partial Public Class SalesByRegionDashboard
    Inherits Telerik.Reporting.Report
    Shared Sub New()
        Try
            ServicePointManager.SecurityProtocol = CType((&HC00 Or &H3000), SecurityProtocolType)
        Catch ex As System.Exception
            System.Diagnostics.Trace.TraceError("Cannot set the SecurityProtocolType: " & ex.Message)
        End Try
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
End Class