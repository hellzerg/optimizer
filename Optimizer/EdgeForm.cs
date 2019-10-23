using System;
using System.IO;

namespace Optimizer
{
    public partial class EdgeForm : System.Windows.Forms.Form
    {
        string _errorMessage = "This folder does not exist, choose a new one!";

        public EdgeForm()
        {
            InitializeComponent();
            Options.ApplyTheme(this);
        }

        private void EdgeFolder_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            textBox1.Text = Utilities.GetEdgeDownloadFolder();
            textBox1.Select(textBox1.Text.Length, 0);
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox1.Text))
            {
                Utilities.SetEdgeDownloadFolder(textBox1.Text);
                this.Close();
            }
            else
            {
                HelperForm f = new HelperForm(null, MessageType.Error, _errorMessage);
                f.ShowDialog();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
