namespace Telerik.Reporting.Examples.CSharp
{
    partial class ReportWithCheckboxes
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportWithCheckboxes));
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.detail = new Telerik.Reporting.DetailSection();
            this.checkBox1 = new Telerik.Reporting.CheckBox();
            this.checkBox2 = new Telerik.Reporting.CheckBox();
            this.checkBox3 = new Telerik.Reporting.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(5.2D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.checkBox1,
            this.checkBox2,
            this.checkBox3});
            this.detail.Name = "detail";
            // 
            // checkBox1
            // 
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.7D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.6D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.checkBox1.Text = "checkBox with MiddleLeft alignment";
            // 
            // checkBox2
            // 
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.7D), Telerik.Reporting.Drawing.Unit.Cm(1.5D));
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.6D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.checkBox2.Text = "checkBox with BottomRight alignment";
            // 
            // checkBox3
            // 
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.IndeterminateImage = ((object)(resources.GetObject("checkBox3.IndeterminateImage")));
            this.checkBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.7D), Telerik.Reporting.Drawing.Unit.Cm(3.1D));
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9D), Telerik.Reporting.Drawing.Unit.Cm(2.1D));
            this.checkBox3.Text = "checkBox with Image and MiddleCenter alignment";
            // 
            // ReportWithCheckboxes
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail});
            this.Name = "Report1";
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(17D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion
        private Telerik.Reporting.DetailSection detail;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
    }
}