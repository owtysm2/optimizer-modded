using System;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed partial class ToggleCard : UserControl
    {
        public event EventHandler ToggleClicked;

        public ToggleCard()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            Toggle.CheckedBackground = OptionsHelper.CurrentOptions.Theme;

            this.IsAccessible = true;
            Label.IsAccessible = true;
            Toggle.IsAccessible = true;
            Panel.IsAccessible = true;

            this.AccessibleName = LabelText;
            Label.AccessibleName = LabelText;
            Toggle.AccessibleName = LabelText;
            Panel.AccessibleName = LabelText;
        }

        public string LabelText
        {
            get { return Label.Text; }
            set
            {
                Label.Text = value;
                this.AccessibleName = value;
                Label.AccessibleName = value;
                Toggle.AccessibleName = value;
                Panel.AccessibleName = LabelText;
            }
        }

        public bool ToggleChecked
        {
            get { return Toggle.Checked; }
            set { Toggle.Checked = value; }
        }

        private void Toggle_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleClicked != null) ToggleClicked(sender, e);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            if (cuiTooltipHover1.Content == string.Empty)
            {
                cuiTooltipHover1.Content = Label.Text;
            }
            base.OnHandleCreated(e);
        }

        internal string LabelTag
        {
            get => Label.Tag?.ToString();
            set
            {
                Label.Tag = value;
                if (Label.Tag == null)
                {
                    return;
                }

                cuiTooltipHover1.Content = Label.Tag.ToString();
            }
        }
    }
}
