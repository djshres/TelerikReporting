namespace CSharp.Net6.WinFormsIntegrationDemo
{
    using System;
    using System.Windows.Forms;
    using Telerik.Drawing.Contract;
    using Telerik.Drawing.GDI;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
