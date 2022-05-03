using System;
using System.Windows.Forms;

namespace Optimizer
{
    public partial class ToggleCard : UserControl
    {
        public event EventHandler ToggleClicked;

        public ToggleCard()
        {
            InitializeComponent();

            this.IsAccessible = true;
            Label.IsAccessible = true;
            Toggle.IsAccessible = true;
            Panel.IsAccessible = true;

            this.AccessibleRole = AccessibleRole.StaticText;
            Label.AccessibleRole = AccessibleRole.StaticText;
            Toggle.AccessibleRole = AccessibleRole.StaticText;
            Panel.AccessibleRole = AccessibleRole.StaticText;

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

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            //Label.Focus();
            //Label.Select();
        }

        private void Label_MouseHover(object sender, EventArgs e)
        {
            //Label.Focus();
            //Label.Select();
        }

        private void Panel_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Panel_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
