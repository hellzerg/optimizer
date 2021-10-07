using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Optimizer
{
    public partial class CleanPreviewForm : Form
    {
        bool selectAll = true;

        public CleanPreviewForm(List<string> preview)
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            Options.ApplyTheme(this);

            if (Options.CurrentOptions.LanguageCode != LanguageCode.EN) Translate();

            preview.Sort();
            listPreview.Items.AddRange(preview.ToArray());

            for (int i = 0; i < listPreview.Items.Count; i++)
            {
                listPreview.SetItemChecked(i, true);
            }
        }

        private void CleanPreviewForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelBackup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cleanDriveB_Click(object sender, EventArgs e)
        {
            cleanDriveB.Enabled = false;

            CleanHelper.PreviewCleanList.Clear();
            for (int i = 0; i < listPreview.CheckedItems.Count; i++)
            {
                CleanHelper.PreviewCleanList.Add(listPreview.CheckedItems[i].ToString());
            }

            CleanHelper.Clean();
            this.Close();
        }

        private void Translate()
        {
            this.Text = Options.TranslationList["CleanPreviewForm"];

            Dictionary<string, string> translationList = Options.TranslationList.ToObject<Dictionary<string, string>>();

            Control element;

            foreach (var x in translationList)
            {
                if (x.Key == null || x.Key == string.Empty) continue;
                element = this.Controls.Find(x.Key, true).FirstOrDefault();

                if (element == null) continue;

                element.Text = x.Value;
            }
        }

        private void checkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            selectAll = !selectAll;
            for (int i = 0; i < listPreview.Items.Count; i++)
            {
                listPreview.SetItemChecked(i, selectAll);
            }
        }
    }
}
