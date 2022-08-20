using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimizer
{
    public partial class SubForm : Form
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
