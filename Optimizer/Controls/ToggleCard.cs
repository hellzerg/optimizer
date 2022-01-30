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
        }

        public string LabelText
        {
            get { return Label.Text; }
            set { Label.Text = value; }
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
    }
}
