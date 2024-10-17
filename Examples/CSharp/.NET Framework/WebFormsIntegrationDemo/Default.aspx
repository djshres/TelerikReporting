<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CSharp.NetFramework.WebFormsIntegrationDemo.Default" %>

<%@ Register TagPrefix="telerik" Assembly="Telerik.ReportViewer.Html5.WebForms" Namespace="Telerik.ReportViewer.Html5.WebForms" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Telerik HTML5 Web Forms Report Viewer Demo</title>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

    <script src="/Scripts/themeSwitcher.js"></script>

    <!--If Kendo is used the following line should be removed.-->
    <script src="/api/reports/resources/js/telerikReportViewer-kendo"></script>

    <link href="https://kendo.cdn.telerik.com/2022.3.913/styles/kendo.common.min.css" rel="stylesheet" id="commonCss" />
    <link href="https://kendo.cdn.telerik.com/2022.3.913/styles/kendo.blueopal.min.css" rel="stylesheet" id="skinCss" />

    <style>
        body {
            margin: 5px;
            font-family: Verdana, Arial, sans-serif;
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

    <script type="text/javascript">
        $(document).ready(function () {
            //Theme switcher
            themeSwitcher(
                '#theme-switcher',
                '#commonCss',
                '#skinCss');
        });
    </script>
</head>
<body>
    <form runat="server">
		<select id="theme-switcher"></select>

        <telerik:ReportViewer Width="" Height="" EnableAccessibility="false"
            ID="reportViewer1"
            runat="server">
            <ReportSource 
                IdentifierType="TypeReportSource" 
                Identifier="Telerik.Reporting.Examples.CSharp.ReportCatalog, CSharp.ReportLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null">
            </ReportSource>
            <%--<Parameters>
                <Editors SingleSelect="ComboBox" MultiSelect="ComboBox"></Editors>
            </Parameters>--%>
            <%-- If set to true shows the Send Mail Message toolbar button --%>
            <SendEmail Enabled = "true" />
        </telerik:ReportViewer>


    </form>
</body>
</html>
