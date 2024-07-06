using System;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed partial class FirstRunForm : Form
    {
        public FirstRunForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            OptionsHelper.ApplyTheme(this);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FirstRunForm_Load(object sender, EventArgs e)
        {
            radioArabic.Text = Constants.ARABIC;
            radioPortuguese.Text = Constants.PORTUGUESE;
            radioChinese.Text = Constants.CHINESE;
            radioCzech.Text = Constants.CZECH;
            radioDutch.Text = Constants.DUTCH;
            radioFrench.Text = Constants.FRENCH;
            radioGerman.Text = Constants.GERMAN;
            radioHellenic.Text = Constants.HELLENIC;
            radioHungarian.Text = Constants.HUNGARIAN;
            radioFarsi.Text = Constants.PERSIAN;
            radioItalian.Text = Constants.ITALIAN;
            radioJapanese.Text = Constants.JAPANESE;
            radioKorean.Text = Constants.KOREAN;
            radioKurdish.Text = Constants.KURDISH;
            radioNepali.Text = Constants.NEPALI;
            radioPolish.Text = Constants.POLISH;
            radioRomanian.Text = Constants.ROMANIAN;
            radioRussian.Text = Constants.RUSSIAN;
            radioSpanish.Text = Constants.SPANISH;
            radioTaiwan.Text = Constants.TAIWANESE;
            radioTurkish.Text = Constants.TURKISH;
            radioUkrainian.Text = Constants.UKRAINIAN;
            radioBulgarian.Text = Constants.BULGARIAN;
            radioEnglish.Text = Constants.ENGLISH;
            radioUrdu.Text = Constants.URDU;
            radioVietnam.Text = Constants.VIETNAMESE;
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
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.EN;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void radioRussian_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.RU;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void radioHellenic_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.EL;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            radioTurkish.PerformClick();
        }

        private void radioTurkish_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.TR;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void radioGerman_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.DE;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
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
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.ES;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void radioPortuguese_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.PT;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            radioPortuguese.PerformClick();
        }

        private void radioFrench_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.FR;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            radioFrench.PerformClick();
        }

        private void radioitalian_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.IT;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
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
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.CN;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            radioCzech.PerformClick();
        }

        private void radioCzech_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.CZ;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void radioTaiwan_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.TW;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            radioTaiwan.PerformClick();
        }

        private void radioKorean_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.KO;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
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
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.PL;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void radioArabic_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.AR;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            radioArabic.PerformClick();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            radioKurdish.PerformClick();
        }

        private void radioKurdish_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.KU;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            radioHungarian.PerformClick();
        }

        private void radioHungarian_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.HU;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void radioRomanian_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.RO;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            radioRomanian.PerformClick();
        }

        private void radioDutch_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.NL;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            radioDutch.PerformClick();
        }

        private void radioJapanese_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.JA;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            radioJapanese.PerformClick();
        }

        private void radioFarsi_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.FA;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            radioFarsi.PerformClick();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            radioNepali.PerformClick();
        }

        private void radioNepali_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.NE;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void radioBulgarian_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.BG;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void radioUkrainian_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.UA;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void radioVietnam_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.VN;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            radioVietnam.PerformClick();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            radioUrdu.PerformClick();
        }

        private void radioUrdu_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.UR;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            radioCroatian.PerformClick();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            radioIndonesian.PerformClick();
        }

        private void radioCroatian_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.HR;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }

        private void radioIndonesian_CheckedChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.ID;
            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
        }
    }
}
