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
    public partial class MessagerForm : System.Windows.Forms.Form
    {
        MainForm _main;
        MessagerType mode;

        private void Confirm()
        {
            if (mode == MessagerType.Error)
            {
                this.Close();
            }
            if (mode == MessagerType.Optimize)
            {
                this.Hide();
                OptimizeForm f = new OptimizeForm(!chkPrint.Checked, !chkSensors.Checked);
                f.ShowDialog();
                f.BringToFront();
            }
            if (mode == MessagerType.Startup)
            {
                _main.RemoveAllStartupItems();
            }
            if (mode == MessagerType.Restart)
            {
                Optimize.RebootPC();
            }
            if (mode == MessagerType.Hosts)
            {
                _main.RemoveAllHostsEntries();
            }
            if (mode == MessagerType.Integrator)
            {
                _main.RemoveAllDesktopItems();
            }
        }

        public MessagerForm(MainForm main, MessagerType m, string s)
        {
            InitializeComponent();
            Options.ApplyTheme(this);

            _main = main;
            mode = m;
            msg.Text = s;

            if (mode == MessagerType.Error)
            {
                nobtn.Visible = false;
                yesbtn.Text = "OK";

                this.AcceptButton = nobtn;
                this.AcceptButton = yesbtn;
                this.CancelButton = nobtn;
                this.CancelButton = yesbtn;
            }
            if (mode == MessagerType.Optimize)
            {
                chkPrint.Checked = true;
                chkPrint.Visible = true;
                chkSensors.Checked = false;
                chkSensors.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Confirm();
            this.Close();
        }

        private void Restarter_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.BringToFront();
        }
    }
}
