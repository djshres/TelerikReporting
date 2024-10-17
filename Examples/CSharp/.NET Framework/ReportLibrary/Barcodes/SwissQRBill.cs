namespace Telerik.Reporting.Examples.CSharp.Barcodes
{
    using System.ComponentModel;

    /// <summary>
    /// Summary description for SwissQRBill.
    /// </summary>
    [Description("A new type of a payment slip used for financial transactions in Switzerland.")]
    [DisplayName("Swiss QR-bill")]
    public partial class SwissQRBill : Telerik.Reporting.Report
    {
        public SwissQRBill()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
    }
}