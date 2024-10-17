
@Imports Telerik.Reporting
@Imports Telerik.ReportViewer.Mvc
@Imports Telerik.Reporting.Examples.CSharp
@Code
    ViewBag.Title = "Telerik HTML5 Report Viewer MVC Demo"
End Code

@Section styles
    <link href="http://kendo.cdn.telerik.com/2022.3.913/styles/kendo.common.min.css" rel="stylesheet" id="common-css" />
    <link href="http://kendo.cdn.telerik.com/2022.3.913/styles/kendo.blueopal.min.css" rel="stylesheet" id="skin-css" />

    <style>
        body {
            margin: 5px;
            font-family: Verdana, Arial;
        }

        #reportViewer1 {
            position: absolute;
            left: 5px;
            right: 5px;
            top: 40px;
            bottom: 5px;
            overflow: hidden;
            clear: both;
        }

        #theme-switcher {
            float: right;
            width: 12em;
            height: 30px;
        }
    </style>
End Section

<select id="theme-switcher"></select>

@Code
    Dim reportSource As Telerik.Reporting.TypeReportSource = New Telerik.Reporting.TypeReportSource()
    reportSource.TypeName = GetType(ReportCatalog).AssemblyQualifiedName

    Dim sendEmail As SendEmail = New SendEmail()
    sendEmail.Enabled = True
    ' For a complete overview for all the parameters, check https://docs.telerik.com/reporting/html5-report-viewer-jquery-fn-telerik-reportviewer
    ' The list in the link above Is for the HTML5 Viewer which this one Is based on.
    ' To use a parameter from this list, add a dot in front And make the word Pascal case, Like you see below
    ' In this template there are examples included of the most common parameters
    '
    ' Each report viewer must have an id - it will be used by the initialization script
    ' to find the element and initialize the report viewer.
    ' .Id("reportViewer1") _
    '
    ' The URL of the service which will serve reports.
    ' The URL corresponds to the name of the controller class (ReportsController).
    ' For more information on how to configure the service please check https://docs.telerik.com/reporting/embedding-reports/host-the-report-engine-remotely/telerik-reporting-rest-services/overview.
    ' .ServiceUrl("/api/reports/") _
    '
    ' The url for the report viewer template. The template can be edited -
    ' new functionalities can be added and unneeded ones can be removed.
    ' For more information please check https://docs.telerik.com/reporting/embedding-reports/display-reports-in-applications/web-application/html5-report-viewer/customizing/styling-and-appearance/templates-structure.
    ' .TemplateUrl("/ReportViewer/templates/telerikReportViewerTemplate.html") _
    '
    ' Strongly typed ReportSource - TypeReportSource or UriReportSource.
    ' .ReportSource(reportSource) _
    '
    ' Report Server connection configuration
    ' If Report Server is used instead of hosting a REST Service, comment out existing '.ServiceUrl' and '.ReportSource' below
    ' uncomment and move '.ReportServer' and '.ReportSource' below
    ' .ReportServer(new ReportServer()
    ' {
    '    Url = "http://report-server-host:83",
    '    Username = "admin",
    '    Password = "adminpass"
    ' })
    ' For Report Server, use "[Category]/[ReportName]"
    ' .ReportSource("Samples/Dashboard")
    '
    ' Specifies whether the viewer is in interactive or print preview mode.
    ' PrintPreview - Displays the paginated report as if it is printed on paper. Interactivity is not enabled.
    ' Interactive - Displays the report in its original width and height witn no paging. Additionally interactivity is enabled.
    ' .ViewMode(ViewMode.Interactive) _
    '
    ' Sets the scale mode of the viewer.
    ' Three modes exist currently:
    ' FitPage - The whole report will fit on the page (will zoom in or out), regardless of its width and height.
    ' FitPageWidth - The report will be zoomed in or out so that the width of the screen and the width of the report match.
    ' Specific - Uses the scale to zoom in and out the report.
    ' .ScaleMode(ScaleMode.Specific) _
    '
    ' Zoom in and out the report using the scale
    ' 1.0 is equal to 100%, i.e. the original size of the report
    ' .Scale(1.0) _
    '
    ' Enables or disables the accessibility features of the report viewer and its contents.
    ' .EnableAccessibility(False) _
    '
    ' Sets whether the viewer’s client session to be persisted between the page’s refreshes(ex. postback).
    ' The session is stored in the browser’s sessionStorage and is available for the duration of the page session.
    ' .PersistSession(False)
    'If set to true shows the Send Mail Message toolbar button
    'Dim sendEmail As SendEmail = New SendEmail()
    'sendEmail.Enabled = True
    '.SendEmail(sendEmail) _

    Dim viewer = Html.TelerikReporting().ReportViewer() _
.Id("reportViewer1") _
.ServiceUrl(Url.Content("~/api/reports/")) _
.ReportSource(reportSource) _
.ViewMode(ViewMode.Interactive) _
.ScaleMode(ScaleMode.Specific) _
.Scale(1.0) _
.PersistSession(False) _
.PrintMode(PrintMode.AutoSelect) _
.EnableAccessibility(False) _
.SendEmail(sendEmail) _
.Deferred()
End Code

@viewer

@Section scripts
    <script src="@Url.Content("~/Scripts/themeSwitcher.js")"></script>

    <!--If Kendo is used it should be added before the report viewer.-->
    <!--The viewer’s JavaScript file can be referenced either with or without the product version.-->
    <!--<script src="@Url.Content("~/api/reports/resources/js/telerikReportViewer-18.2.24.806.min.js/")"></script>-->
    <script src="@Url.Content("~/api/reports/resources/js/telerikReportViewer")"></script>
    @Code
        'All deferred initialization statements will be rendered here
    End Code
    @Html.TelerikReporting().DeferredScripts()
End Section

<script type="text/javascript">
    $(document).ready(function () {
        //Theme switcher
        themeSwitcher(
            '#theme-switcher',
            '#common-css',
            '#skin-css');
    });
</script>