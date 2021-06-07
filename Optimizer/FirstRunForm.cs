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
    public partial class FirstRunForm : Form
    {
        public FirstRunForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FirstRunForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox86_Click(object sender, EventArgs e)
        {
            radioEnglish.PerformClick();
        }

        private void pictureBox87_Click(object sender, EventArgs e)
        {
            radioRussian.PerformClick();
        }

        private void pictureBox88_Click(object sender, EventArgs e)
        {
            radioHellenic.PerformClick();
        }

        private void radioEnglish_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.LanguageCode = LanguageCode.EN;
            Options.SaveSettings();
            Options.LoadTranslation();
        }

        private void radioRussian_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.LanguageCode = LanguageCode.RU;
            Options.SaveSettings();
            Options.LoadTranslation();
        }

        private void radioHellenic_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.LanguageCode = LanguageCode.EL;
            Options.SaveSettings();
            Options.LoadTranslation();
        }
    }
}
