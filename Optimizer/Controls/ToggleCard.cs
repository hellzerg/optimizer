using System;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed partial class ToggleCard : UserControl
    {
        public event EventHandler ToggleClicked;

        SubForm _subForm;

        public ToggleCard()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            _subForm = new SubForm();

            this.IsAccessible = true;
            Label.IsAccessible = true;
            Toggle.IsAccessible = true;
            Panel.IsAccessible = true;

            //this.AccessibleRole = AccessibleRole.CheckButton;
            //Label.AccessibleRole = AccessibleRole.CheckButton;
            //Toggle.AccessibleRole = AccessibleRole.CheckButton;
            //Panel.AccessibleRole = AccessibleRole.CheckButton;

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

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label.Font = new System.Drawing.Font(Label.Font, System.Drawing.FontStyle.Regular);
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Label.Font = new System.Drawing.Font(Label.Font, System.Drawing.FontStyle.Underline);
        }

        private void Label_Click(object sender, EventArgs e)
        {
            if (Label.Tag == null) return;
            _subForm.SetTip(Label.Tag.ToString());
            _subForm.ShowDialog(this);
        }

        private void Label_MouseHover(object sender, EventArgs e)
        {
            Label.Font = new System.Drawing.Font(Label.Font, System.Drawing.FontStyle.Underline);
        }
    }
}
