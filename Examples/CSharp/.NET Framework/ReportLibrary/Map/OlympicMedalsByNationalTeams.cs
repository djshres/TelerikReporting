namespace Telerik.Reporting.Examples.CSharp
{
    using System.ComponentModel;
    using System.Net;

    /// <summary>
    /// Summary description for OlympicMedalsByNationalTeams.
    /// </summary>    
    [Description("Map layout of the Olympic medals by national teams and associations.")]
    public partial class OlympicMedalsByNationalTeams : Telerik.Reporting.Report
    {
        static OlympicMedalsByNationalTeams()
        {
            try
            {
                // Try setting the SecurityProtocolType to TLS 1.2 and TLS 1.3 in attempt to allow the WebClient requests to pass without throwing System.Net exceptions.
                // This code should be used only when the running application uses .NET Framework 4.0. The newer versions of .NET Framework and .NET Core use the default system settings to set the value of ServicePointManager.SecurityProtocol.
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)(0xc00 | 0x3000); // TLS 1.2 | TLS 1.3
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Trace.TraceError("Cannot set the SecurityProtocolType: " + ex.Message);
            }
        }

        public OlympicMedalsByNationalTeams()
        {
            //
            // Required for Telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
    }
}