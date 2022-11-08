using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed partial class FileUnlockForm : Form
    {
        List<Process> _lockingProcesses;

        public FileUnlockForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Options.ApplyTheme(this);

            radioFile.Text = Options.TranslationList["radioFile"].ToString();
            btnKill.Text = Options.TranslationList["btnKill"].ToString();
        }

        private void FileUnlockForm_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFile.Text)) return;
            if (!File.Exists(txtFile.Text)) return;

            _lockingProcesses = FileHandleHelper.GetProcessesLockingFile(txtFile.Text);

            if (_lockingProcesses == null) return;

            listProcesses.Items.Clear();
            listProcesses.Items.AddRange(_lockingProcesses.Select(x => $"[{x.Id}] {x.ProcessName}").ToArray());
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            if (listProcesses.CheckedItems.Count <= 0) return;

            foreach (string x in listProcesses.CheckedItems)
            {
                IEnumerable<Process> prs = Process.GetProcesses().Where(pr => pr.ProcessName == x.Replace(x.Substring(0, x.IndexOf("]") + 1), string.Empty).Trim());
                foreach (Process z in prs)
                {
                    try
                    {
                        z.Kill();
                    }
                    catch { continue; }
                }
            }

            btnFind.PerformClick();
        }
    }
}
