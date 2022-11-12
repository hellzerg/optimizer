using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed partial class HostsEditorForm : Form
    {
        string[] _toSave = null;

        public HostsEditorForm()
        {
            InitializeComponent();
            Options.ApplyTheme(this);

            if (HostsHelper.GetReadOnly())
            {
                savebtn.Enabled = false;
            }

            // translate UI elements
            if (Options.CurrentOptions.LanguageCode != LanguageCode.EN) Translate();
        }

        private void HostsEditor_Load(object sender, EventArgs e)
        {
            //foreach (string line in HostsHelper.ReadHosts())
            //{
            //    textBox1.Text += line + HostsHelper.NewLine;
            //}

            textBox1.Text = HostsHelper.ReadHostsFast();

            textBox1.Focus();
        }

        private void Translate()
        {
            this.Text = Options.TranslationList["HostsEditorForm"];
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _toSave = textBox1.Lines;
            HostsHelper.SaveHosts(_toSave);

            this.Close();
        }
    }
}
