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
    public partial class HostsEditorForm : Form
    {
        string[] toSave = null;

        public HostsEditorForm()
        {
            InitializeComponent();
            Options.ApplyTheme(this);
        }

        private void HostsEditor_Load(object sender, EventArgs e)
        {
            foreach (string line in HostsHelper.ReadHosts())
            {
                textBox1.Text += line + HostsHelper.nl;
            }

            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            toSave = textBox1.Lines;
            HostsHelper.SaveHosts(toSave);

            this.Close();
        }
    }
}
