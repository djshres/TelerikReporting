namespace Telerik.Reporting.Examples.CSharp
{
    using System.ComponentModel;
    using System.Net;

    /// <summary>
    /// Summary description for ProductSales.
    /// </summary>
    [Description("Sales distribution across the world.")]
    public partial class SalesByRegionDashboard : Telerik.Reporting.Report
    {
        static SalesByRegionDashboard()
        {
            try
            {
                //Try setting the SecurityProtocolType to TLS 1.2 and TLS 1.3 in attempt to allow the WebClient requests to pass without throwing System.Net exceptions.
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)(0xc00 | 0x3000); // TLS 1.2 | TLS 1.3
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Trace.TraceError("Cannot set the SecurityProtocolType: " + ex.Message);
            }
        }

        public SalesByRegionDashboard()
        {            
            /// <summary>
            /// Required for Telerik Reporting designer support
            /// </summary>
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
    }
}