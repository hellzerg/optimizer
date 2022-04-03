using System;
using System.Windows.Forms;

namespace Optimizer
{
    public partial class FirstRunForm : Form
    {
        public FirstRunForm()
        {
            InitializeComponent();
            Options.ApplyTheme(this);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            radioTurkish.PerformClick();
        }

        private void radioTurkish_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.LanguageCode = LanguageCode.TR;
            Options.SaveSettings();
            Options.LoadTranslation();
        }

        private void radioGerman_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.LanguageCode = LanguageCode.DE;
            Options.SaveSettings();
            Options.LoadTranslation();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            radioGerman.PerformClick();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            radioSpanish.PerformClick();
        }

        private void radioSpanish_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.LanguageCode = LanguageCode.ES;
            Options.SaveSettings();
            Options.LoadTranslation();
        }

        private void radioPortuguese_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.LanguageCode = LanguageCode.PT;
            Options.SaveSettings();
            Options.LoadTranslation();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            radioPortuguese.PerformClick();
        }

        private void radioFrench_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.LanguageCode = LanguageCode.FR;
            Options.SaveSettings();
            Options.LoadTranslation();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            radioFrench.PerformClick();
        }

        private void radioitalian_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.LanguageCode = LanguageCode.IT;
            Options.SaveSettings();
            Options.LoadTranslation();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            radioItalian.PerformClick();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            radioChinese.PerformClick();
        }

        private void radioChinese_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.LanguageCode = LanguageCode.CN;
            Options.SaveSettings();
            Options.LoadTranslation();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            radioCzech.PerformClick();
        }

        private void radioCzech_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.LanguageCode = LanguageCode.CZ;
            Options.SaveSettings();
            Options.LoadTranslation();
        }

        private void radioTaiwan_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.LanguageCode = LanguageCode.TW;
            Options.SaveSettings();
            Options.LoadTranslation();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            radioTaiwan.PerformClick();
        }

        private void radioKorean_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.LanguageCode = LanguageCode.KO;
            Options.SaveSettings();
            Options.LoadTranslation();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            radioChinese.PerformClick();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            radioPolish.PerformClick();
        }

        private void radioPolish_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.LanguageCode = LanguageCode.PL;
            Options.SaveSettings();
            Options.LoadTranslation();
        }

        private void radioArabic_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.LanguageCode = LanguageCode.AR;
            Options.SaveSettings();
            Options.LoadTranslation();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            radioArabic.PerformClick();
        }
    }
}
