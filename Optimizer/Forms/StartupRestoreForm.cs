using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed partial class StartupRestoreForm : Form
    {
        string[] _backups;

        public StartupRestoreForm()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            Options.ApplyTheme(this);

            // translate UI elements
            if (Options.CurrentOptions.LanguageCode != LanguageCode.EN) Translate();

            RefreshBackups();
        }

        private void RefreshBackups()
        {
            _backups = Directory.GetFiles(Required.StartupItemsBackupFolder, "*.json");
            Array.Reverse(_backups);
            listRestoreItems.Items.Clear();

            txtNoBackups.Visible = _backups.Length == 0;

            foreach (string x in _backups)
            {
                listRestoreItems.Items.Add(Path.GetFileNameWithoutExtension(x));
            }

            if (_backups.Count() > 0) listRestoreItems.SelectedIndex = 0;
        }

        private void Translate()
        {
            this.Text = Options.TranslationList["StartupRestoreForm"];

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

        private void StartupRestoreForm_Load(object sender, EventArgs e)
        {

        }

        // DeleteStartupBackup
        private void button2_Click(object sender, EventArgs e)
        {
            if (listRestoreItems.SelectedIndex > -1)
            {
                if (MessageBox.Show("Do you really want to delete this backup?", "Delete Backup?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        File.Delete(_backups[listRestoreItems.SelectedIndex]);
                    }
                    catch (Exception ex)
                    {
                        ErrorLogger.LogError("StartupRestoreForm.DeleteStartupBackup", ex.Message, ex.StackTrace);
                    }

                    RefreshBackups();
                }
            }
        }

        private void ShowPreview()
        {
            if (listRestoreItems.SelectedIndex > -1)
            {
                List<StartupBackupItem> backup = JsonConvert.DeserializeObject<List<StartupBackupItem>>(File.ReadAllText(_backups[listRestoreItems.SelectedIndex]));
                StartupPreviewForm f = new StartupPreviewForm(backup);
                f.ShowDialog(this);
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            ShowPreview();
        }

        private void listRestoreItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowPreview();
        }

        // RestoreStartupBackup
        private void button1_Click(object sender, EventArgs e)
        {
            if (listRestoreItems.SelectedIndex > -1)
            {
                List<StartupBackupItem> backup = JsonConvert.DeserializeObject<List<StartupBackupItem>>(File.ReadAllText(_backups[listRestoreItems.SelectedIndex]));

                string keyPath = string.Empty;
                RegistryKey hive = null;

                foreach (StartupBackupItem x in backup)
                {
                    if (x.RegistryLocation == StartupItemLocation.HKLM.ToString())
                    {
                        hive = Registry.LocalMachine;

                        if (x.StartupType == StartupItemType.Run.ToString())
                        {
                            keyPath = StartupHelper.LocalMachineRun;
                        }
                        else if (x.StartupType == StartupItemType.RunOnce.ToString())
                        {
                            keyPath = StartupHelper.LocalMachineRunOnce;
                        }
                    }
                    else if (x.RegistryLocation == StartupItemLocation.HKLMWoW.ToString())
                    {
                        hive = Registry.LocalMachine;

                        if (x.StartupType == StartupItemType.Run.ToString())
                        {
                            keyPath = StartupHelper.LocalMachineRunWoW;
                        }
                        else if (x.StartupType == StartupItemType.RunOnce.ToString())
                        {
                            keyPath = StartupHelper.LocalMachineRunOnceWow;
                        }
                    }
                    else if (x.RegistryLocation == StartupItemLocation.HKCU.ToString())
                    {
                        hive = Registry.CurrentUser;

                        if (x.StartupType == StartupItemType.Run.ToString())
                        {
                            keyPath = StartupHelper.CurrentUserRun;
                        }
                        else if (x.StartupType == StartupItemType.RunOnce.ToString())
                        {
                            keyPath = StartupHelper.CurrentUserRunOnce;
                        }
                    }

                    if (hive != null)
                    {
                        try
                        {
                            RegistryKey key = hive.OpenSubKey(keyPath, true);
                            key.SetValue(x.Name, x.FileLocation, RegistryValueKind.String);

                        }
                        catch (Exception ex)
                        {
                            ErrorLogger.LogError("StartupRestoreForm.RestoreStartupBackup", ex.Message, ex.StackTrace);
                        }
                    }
                }

                this.Close();
            }
        }
    }
}
