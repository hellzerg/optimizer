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
    public partial class InfoForm : System.Windows.Forms.Form
    {
        public InfoForm(string info)
        {
            InitializeComponent();
            Options.ApplyTheme(this);
            
            msg.Text = info;
        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Info_Load(object sender, EventArgs e)
        {

        }
    }
}
