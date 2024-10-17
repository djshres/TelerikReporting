using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportServerClientDemo
{
    public partial class MainForm : Form
    {
        ClientSettingsModel model;
        public MainForm()
        {
            InitializeComponent();

            this.model = this.CreateModel();

            this.tbBaseAddress.DataBindings.Add("Text", this.model, "BaseAddress");
            this.tbUsername.DataBindings.Add("Text", this.model, "Username");
            this.tbPasword.DataBindings.Add("Text", this.model, "Password");
        }

        private void lnkCreateAndPreviewReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.listBoxLog.Items.Clear();
            lnkExecuteScenario.Enabled = false;

            var task = Task.Factory.StartNew(() =>
            {
                ReportServerAPIHelper.ExecuteSampleScenario(this.model, LogProgress);
            });

            task.ContinueWith((t) =>
            {
                this.LogProgress(Environment.NewLine + "Scenario completed successfully.");
                this.ResetUI();
            }, CancellationToken.None, TaskContinuationOptions.OnlyOnRanToCompletion, TaskScheduler.FromCurrentSynchronizationContext());

            task.ContinueWith((t) =>
            {
                var error = string.Join("; ", t.Exception.Flatten().InnerExceptions.Select(ex => ex.Message));
                System.Diagnostics.Trace.TraceError(error);
                this.LogProgress(string.Format("An error occurred while executing the scenario: {0}", error));
                this.ResetUI();
            }, CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Default);
        }

        void LogProgress(string line)
        {
            this.BeginInvoke(new Action(() =>
            {
                this.listBoxLog.Items.Insert(0, line);
                this.listBoxLog.Refresh();
            }));
        }

        ClientSettingsModel CreateModel()
        {
            return new ClientSettingsModel()
            {
                BaseAddress = "http://reportserver:83",
                Username = "admin",
                Password = "111111"
            };
        }

        void ResetUI()
        {
            this.BeginInvoke(new Action(() =>
            {
                lnkExecuteScenario.Enabled = true;
            }));
        }
    }
}
