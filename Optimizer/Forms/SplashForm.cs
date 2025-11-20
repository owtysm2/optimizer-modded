using System;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            progressTracker.CompletedColor = OptionsHelper.CurrentOptions.Theme;
            txtVersion.Text = $"{Program.CurrentVersionString}";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Show();
        }
    }
}
