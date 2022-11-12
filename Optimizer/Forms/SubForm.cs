using System;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed partial class SubForm : Form
    {
        public SubForm()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            this.DoubleBuffered = true;
            Options.ApplyTheme(this);

            btnStart.Focus();
            btnStart.Select();
        }

        internal void SetTip(string tip)
        {
            txtInfo.Text = tip;
            btnStart.Focus();
            btnStart.Select();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubForm_Load(object sender, EventArgs e)
        {
            Options.ApplyTheme(this);
        }
    }
}
