using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimizer
{
    public partial class StartupPreviewForm : Form
    {
        string _token = string.Empty;

        public StartupPreviewForm(List<StartupBackupItem> items)
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            Options.ApplyTheme(this);

            foreach (StartupBackupItem x in items)
            {
                if (File.Exists(SanitizePath(x.FileLocation)))
                {
                    _token = "[✓] ";
                }
                else
                {
                    _token = "[⚠] ";
                }

                listPreview.Items.Add(_token + x.Name + " - " + x.FileLocation);
            }    
        }

        private void StartupPreviewForm_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        private string SanitizePath(string s)
        {
            s = s.Replace("\"", string.Empty);
            int i;

            while (s.Contains("/"))
            {
                i = s.LastIndexOf("/");
                s = s.Substring(0, i);
            }

            i = s.IndexOf(".exe");
            s = s.Substring(0, i + 4);

            return s.Trim();
        }
    }
}
