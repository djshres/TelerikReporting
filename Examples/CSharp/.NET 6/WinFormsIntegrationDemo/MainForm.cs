namespace CSharp.Net6.WinFormsIntegrationDemo
{
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
            this.Load += this.Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.reportViewer.RefreshReport();
        }
    }
}
