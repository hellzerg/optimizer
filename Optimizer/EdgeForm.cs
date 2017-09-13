using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Optimizer
{
    public partial class EdgeForm : System.Windows.Forms.Form
    {
        string errormsg = "This folder does not exist, choose a new one!";

        public EdgeForm()
        {
            InitializeComponent();
            Options.ApplyTheme(this);
        }

        private void EdgeFolder_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            textBox1.Text = Optimize.GetEdgeDownloadFolder();
            textBox1.Select(textBox1.Text.Length, 0);
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox1.Text))
            {
                Optimize.SetEdgeDownloadFolder(textBox1.Text);
                this.Close();
            }
            else
            {
                MessagerForm f = new MessagerForm(null, MessagerType.Error, errormsg);
                f.ShowDialog();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
