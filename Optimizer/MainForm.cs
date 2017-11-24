using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Threading;
using System.Reflection;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Net;
using Newtonsoft.Json;

namespace Optimizer
{
    public partial class MainForm : Form
    {
        ListViewColumnSorter _columnSorter;

        List<StartupItem> _startUpItems = new List<StartupItem>();
        List<string> _hostsEntries = new List<string>();
        List<string> _customCommands = new List<string>();
        List<string> _desktopItems = new List<string>();
        List<string> _modernApps = new List<string>();

        DesktopItemType _desktopItemType = DesktopItemType.Program;
        DesktopTypePosition _desktopItemPosition = DesktopTypePosition.Top;

        readonly string _blockedIP = "127.0.0.1";

        readonly string _restartMessage = "Restart to apply changes?";
        readonly string _removeStartupItemsMessage = "Are you sure you want to delete all startup items?";
        readonly string _removeHostsEntriesMessage = "Are you sure you want to delete all hosts entries?";
        readonly string _removeDesktopItemsMessage = "Are you sure you want to delete all desktop items?";
        readonly string _removeModernAppsMessage = "Are you sure you want to uninstall the following app(s)?";
        readonly string _errorModernAppsMessage = "The following app(s) couldn't be uninstalled:\n";
        readonly string _applyAllWindows7Message = "This will apply every option in Universal and Windows 7 tabs. Continue?";
        readonly string _applyAllWindows8Message = "This will apply every option in Universal and Windows 8.1 tabs. Continue?";
        readonly string _applyAllWindows10Message = "This will apply every option in Universal and Windows 10 tabs. Continue?";

        private void LoadSettings()
        {
            switch (Options.CurrentOptions.Color)
            {
                case Theme.Caramel:
                    radioCaramel.Checked = true;
                    break;
                case Theme.Lime:
                    radioLime.Checked = true;
                    break;
                case Theme.Magma:
                    radioMagma.Checked = true;
                    break;
                case Theme.Minimal:
                    radioMinimal.Checked = true;
                    break;
                case Theme.Ocean:
                    radioOcean.Checked = true;
                    break;
                case Theme.Zerg:
                    radioZerg.Checked = true;
                    break;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            Options.ApplyTheme(this);

            _columnSorter = new ListViewColumnSorter();
            listStartupItems.ListViewItemSorter = _columnSorter;
        }

        private void ApplyAll()
        {
            if (Utilities.CurrentWindowsVersion != WindowsVersion.Unsupported)
            {
                string message = string.Empty;

                if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows7)
                {
                    message = _applyAllWindows7Message;
                }
                if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows8)
                {
                    message = _applyAllWindows8Message;
                }
                if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows10)
                {
                    message = _applyAllWindows10Message;
                }

                HelperForm r = new HelperForm(this, MessageType.Optimize, message);
                r.ShowDialog(this);
            }
        }

        private void CleanPC()
        {
            try
            {
                if (checkTemp.Checked)
                {
                    CleanHelper.CleanTemporaries();
                }
                if (checkUTorrent.Checked)
                {
                    CleanHelper.CleanUTorrent();
                }
                if (checkFileZilla.Checked)
                {
                    CleanHelper.CleanFileZilla();
                }
                if (checkMiniDumps.Checked)
                {
                    CleanHelper.CleanMiniDumps();
                }
                if (checkPrefetch.Checked)
                {
                    CleanHelper.CleanPrefetch();
                }
                if (checkMediaCache.Checked)
                {
                    CleanHelper.CleanMediaPlayersCache();
                }
                if (checkLogs.Checked)
                {
                    CleanHelper.CleanLogs();
                }
                if (checkErrorReports.Checked)
                {
                    CleanHelper.CleanErrorReports();
                }
                if (checkBin.Checked)
                {
                    CleanHelper.EmptyRecycleBin();
                }
            }
            catch { }
            finally
            {
                CleaningAnimation(false);
            }
        }

        private void CleaningAnimation(bool start)
        {
            if (start == true)
            {
                Utilities.SetControlPropertyThreadSafe(cleaningpanel, "Visible", true);
                Utilities.SetControlPropertyThreadSafe(progress2, "Visible", true);
                Utilities.SetControlPropertyThreadSafe(progress2, "Style", ProgressBarStyle.Marquee);
                Utilities.SetControlPropertyThreadSafe(progress2, "MarqueeAnimationSpeed", 1);
                Utilities.SetControlPropertyThreadSafe(label4, "Visible", true);
                Utilities.SetControlPropertyThreadSafe(button20, "Enabled", false);
                Utilities.SetControlPropertyThreadSafe(panel1, "Enabled", false);
            }
            else
            {
                Utilities.SetControlPropertyThreadSafe(cleaningpanel, "Visible", false);
                Utilities.SetControlPropertyThreadSafe(progress2, "Visible", false);
                Utilities.SetControlPropertyThreadSafe(progress2, "Value", 0);
                Utilities.SetControlPropertyThreadSafe(progress2, "Style", ProgressBarStyle.Blocks);
                Utilities.SetControlPropertyThreadSafe(progress2, "MarqueeAnimationSpeed", 1);
                Utilities.SetControlPropertyThreadSafe(label4, "Visible", false);
                Utilities.SetControlPropertyThreadSafe(button20, "Enabled", true);
                Utilities.SetControlPropertyThreadSafe(panel1, "Enabled", true);
            }
        }

        private bool FixRegistry()
        {
            bool changeDetected = false;

            try
            {
                if (checkFirewall.Checked)
                {
                    Utilities.EnableFirewall();
                    changeDetected = true;
                }
                if (checkCommandPrompt.Checked)
                {
                    Utilities.EnableCommandPrompt();
                    changeDetected = true;
                }
                if (checkControlPanel.Checked)
                {
                    Utilities.EnableControlPanel();
                    changeDetected = true;
                }
                if (checkFolderOptions.Checked)
                {
                    Utilities.EnableFolderOptions();
                    changeDetected = true;
                }
                if (checkRunDialog.Checked)
                {
                    Utilities.EnableRunDialog();
                    changeDetected = true;
                }
                if (checkContextMenu.Checked)
                {
                    Utilities.EnableContextMenu();
                    changeDetected = true;
                }
                if (checkTaskManager.Checked)
                {
                    Utilities.EnableTaskManager();
                    changeDetected = true;
                }
                if (checkRegistryEditor.Checked)
                {
                    Utilities.EnableRegistryEditor();
                    changeDetected = true;
                }
            }
            catch { }

            return changeDetected;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            
            integratorTimer.Start();
            runDialogTime.Start();

            GetStartupItems();
            GetHostsEntries();
            GetDesktopItems();
            GetCustomCommands();
            GetModernApps();

            LoadSettings();

            radioProgram.Checked = true;
            radioTop.Checked = true;

            txtVersion.Text = "Version: " + Program.GetCurrentVersion();
            Program.MainForm = this;
            
            txtOS.Text = "Microsoft " + Utilities.GetOS();
            txtBitness.Text = Utilities.GetBitness();   
            
            if (Utilities.CurrentWindowsVersion == WindowsVersion.Unsupported)
            {
                tabCollection.TabPages.Remove(universalTab);
                tabCollection.TabPages.Remove(windowsVIITab);
                tabCollection.TabPages.Remove(windowsVIIITab);
                tabCollection.TabPages.Remove(windowsXTab);
                tabCollection.TabPages.Remove(modernAppsTab);
            }   

            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows7)
            {
                tabCollection.TabPages.Remove(windowsVIIITab);
                tabCollection.TabPages.Remove(windowsXTab);
                tabCollection.TabPages.Remove(modernAppsTab);
            }

            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows8)
            {
                tabCollection.TabPages.Remove(windowsVIITab);
                tabCollection.TabPages.Remove(windowsXTab);
            }

            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows10)
            {
                tabCollection.TabPages.Remove(windowsVIITab);
                tabCollection.TabPages.Remove(windowsVIIITab);
            }
        }

        private void GetDesktopItems()
        {
            _desktopItems = Integrator.GetDesktopItems();
            listDesktopItems.Items.Clear();

            for (int i = 0; i < _desktopItems.Count; i++)
            {
                if (!string.IsNullOrEmpty(_desktopItems[i]))
                {
                    listDesktopItems.Items.Add(_desktopItems[i]);
                }
            }
        }

        private void GetHostsEntries()
        {
            _hostsEntries = HostsHelper.GetHostsEntries();
            listHostEntries.Items.Clear();
           
            for (int i = 0; i < _hostsEntries.Count; i++)
            {
                if (!string.IsNullOrEmpty(_hostsEntries[i]))
                {
                    listHostEntries.Items.Add(_hostsEntries[i]);
                }
            }
        }

        private void GetStartupItems()
        {
            _startUpItems = Utilities.GetStartupItems();
            listStartupItems.Items.Clear();

            for (int i = 0; i < _startUpItems.Count; i++)
            {
                ListViewItem list = new ListViewItem(_startUpItems[i].Name);
                list.SubItems.Add(_startUpItems[i].FileLocation);
                list.SubItems.Add(_startUpItems[i].ToString());

                listStartupItems.Items.Add(list);
            }
        }

        private void GetModernApps()
        {
            button74.Enabled = false;
            button75.Enabled = false;
            listModernApps.Enabled = false;

            listModernApps.Items.Clear();
            _modernApps = Utilities.GetModernApps();

            foreach (string x in _modernApps)
            {
                listModernApps.Items.Add(x);
            }

            button74.Enabled = true;
            button75.Enabled = true;
            listModernApps.Enabled = true;
        }

        private async void UninstallModernApps()
        {
            string selectedApps = string.Empty;

            if (listModernApps.CheckedItems.Count > 0)
            {
                foreach (string x in listModernApps.CheckedItems)
                {
                    if (string.IsNullOrEmpty(selectedApps))
                    {
                        selectedApps = x;
                    }
                    else
                    {
                        selectedApps += Environment.NewLine + x;
                    }
                }

                if (MessageBox.Show(_removeModernAppsMessage + "\n\n" + selectedApps, "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    button74.Enabled = false;
                    button75.Enabled = false;
                    listModernApps.Enabled = false;

                    bool errorOccured = false;
                    string failedApps = string.Empty;

                    foreach (string app in listModernApps.CheckedItems)
                    {
                        await Task.Run(() => errorOccured = Utilities.UninstallModernApp(app));

                        if (errorOccured)
                        {
                            failedApps += Environment.NewLine + app;
                        }
                    }

                    if (!string.IsNullOrEmpty(failedApps))
                    {
                        MessageBox.Show(_errorModernAppsMessage + failedApps, "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    GetModernApps();
                }
            }
        }

        private void GetCustomCommands()
        {
            _customCommands = Integrator.GetCustomCommands();
            listCustomCommands.Items.Clear();

            foreach (string s in _customCommands)
            {
                listCustomCommands.Items.Add(s);
            }
        }

        private void Main_FormClosing(object sender, EventArgs e)
        {
            Options.SaveSettings();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            HelperForm f = new HelperForm(this, MessageType.Restart, _restartMessage);
            f.ShowDialog();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            HelperForm f = new HelperForm(this, MessageType.Restart, _restartMessage);
            f.ShowDialog();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            HelperForm f = new HelperForm(this, MessageType.Restart, _restartMessage);
            f.ShowDialog();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            HelperForm f = new HelperForm(this, MessageType.Restart, _restartMessage);
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Optimize.PerformanceTweaks();
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Optimize.DisableNetworkThrottling();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task t = new Task(() => Optimize.DisableDefender());
            t.Start();
            button1.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Task t = new Task(() => Optimize.DisableSystemRestore());
            t.Start();
            button17.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Optimize.DisableErrorReporting();
            button16.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Optimize.DisableHomeGroup();
            button13.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Optimize.DisableSuperfetch();
            button14.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Optimize.DisablePrintSpooler();
            button15.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Optimize.BlockSkypeAds();
            button10.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Optimize.RestoreLegacyVolumeSlider();
            button9.Enabled = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Task t = new Task(() => Optimize.UninstallOneDrive());
            t.Start();
            Utilities.ActivateMainForm();
            button29.Enabled = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Optimize.DisableCortana();
            button24.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Task t = new Task(() => Optimize.DisableXboxLive());
            t.Start();
            button21.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            EdgeForm f = new EdgeForm();
            f.ShowDialog();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Optimize.DisableAutomaticUpdates();
            button28.Enabled = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Optimize.DisableDiagnosticsTracking();
            button27.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Optimize.DisableWAPPush();
            button25.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Optimize.DisableDataTelemetry();
            button23.Enabled = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Optimize.DisableSensorServices();
            button30.Enabled = false;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Optimize.DisableOneDrive();
            button36.Enabled = false;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Optimize.RemoveWindows10Icon();
            button35.Enabled = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Optimize.RemoveWindows10Icon();
            button38.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Task t = new Task(() => Optimize.DisableTelemetryTasks());
            t.Start();
            Utilities.ActivateMainForm();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Task t = new Task(() => Optimize.DisableOfficeTelemetryTasks());
            t.Start();
            Utilities.ActivateMainForm();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ApplyAll();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ApplyAll();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ApplyAll();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ApplyAll();
        }

        private void checkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            checkTemp.Checked = checkSelectAll.Checked;
            checkUTorrent.Checked = checkSelectAll.Checked;
            checkFileZilla.Checked = checkSelectAll.Checked;
            checkMiniDumps.Checked = checkSelectAll.Checked;
            checkPrefetch.Checked = checkSelectAll.Checked;
            checkMediaCache.Checked = checkSelectAll.Checked;
            checkLogs.Checked = checkSelectAll.Checked;
            checkBin.Checked = checkSelectAll.Checked;
            checkErrorReports.Checked = checkSelectAll.Checked;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            CleaningAnimation(true);
            Task t = new Task(() => CleanPC());
            t.Start();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (listStartupItems.SelectedItems.Count == 1)
            {
                _startUpItems[listStartupItems.SelectedIndices[0]].Remove();
                GetStartupItems();
            }
        }

        internal void RemoveAllStartupItems()
        {
            foreach (ListViewItem i in listStartupItems.Items)
            {
                _startUpItems[i.Index].Remove();
            }

            GetStartupItems();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (listStartupItems.Items.Count > 0)
            {
                HelperForm r = new HelperForm(this, MessageType.Startup, _removeStartupItemsMessage);
                r.ShowDialog(this);
            } 
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (listStartupItems.SelectedItems.Count == 1)
            {
                _startUpItems[listStartupItems.SelectedIndices[0]].LocateFile();
            }
        }

        private void checkEnableAll_CheckedChanged(object sender, EventArgs e)
        {
            checkTaskManager.Checked = checkEnableAll.Checked;
            checkCommandPrompt.Checked = checkEnableAll.Checked;
            checkControlPanel.Checked = checkEnableAll.Checked;
            checkFolderOptions.Checked = checkEnableAll.Checked;
            checkRunDialog.Checked = checkEnableAll.Checked;
            checkContextMenu.Checked = checkEnableAll.Checked;
            checkFirewall.Checked = checkEnableAll.Checked;
            checkRegistryEditor.Checked = checkEnableAll.Checked;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            bool flag = FixRegistry();

            if (flag)
            {
                panel2.Enabled = false;
                button33.Enabled = false;

                if (checkRestartExplorer.Checked)
                {
                    Utilities.RestartExplorer();
                }

                panel2.Enabled = true;
                button33.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AboutForm f = new AboutForm();
            f.ShowDialog(this);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            GetStartupItems();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Optimize.DisablePrivacyOptions();
            button40.Enabled = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HostsHelper.LocateHosts();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HostsEditorForm f = new HostsEditorForm();
            f.ShowDialog(this);
            GetHostsEntries();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HostsHelper.RestoreDefaultHosts();
            GetHostsEntries();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if ((txtIP.Text != string.Empty) && (txtDomain.Text != string.Empty))
            {
                string ip = txtIP.Text.Trim();
                string domain = txtDomain.Text.Trim();
                string recommendedDomain = string.Empty;

                if (!domain.StartsWith("www."))
                {
                    recommendedDomain = "www." + domain;
                }
                else
                {
                    recommendedDomain = domain.Replace("www.", string.Empty);
                }

                HostsHelper.AddEntry(HostsHelper.SanitizeEntry(ip) + " " + HostsHelper.SanitizeEntry(domain));
                
                if (!string.IsNullOrEmpty(recommendedDomain))
                {
                    HostsHelper.AddEntry(HostsHelper.SanitizeEntry(ip) + " " + HostsHelper.SanitizeEntry(recommendedDomain));
                }

                GetHostsEntries();

                txtIP.Clear();
                txtDomain.Clear();

                chkBlock.Checked = false;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            GetHostsEntries();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (listHostEntries.SelectedItems.Count == 1)
            {
                HostsHelper.RemoveEntry(listHostEntries.SelectedItem.ToString().Replace(" : ", " "));
                GetHostsEntries();
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (listHostEntries.Items.Count > 0)
            {
                HelperForm r = new HelperForm(this, MessageType.Hosts, _removeHostsEntriesMessage);
                r.ShowDialog(this);
            }
        }

        internal void RemoveAllHostsEntries()
        {
            List<string> collection = new List<string>();

            foreach (string item in listHostEntries.Items)
            {
                collection.Add(item.Replace(" : ", " "));
            }

            HostsHelper.RemoveAllEntries(collection);
            GetHostsEntries();
        }

        private void aio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCollection.SelectedTab == hostsEditorTab)
            {
                txtIP.Focus();
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            defineCommandDialog.ShowDialog();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if ((txtRunFile.Text != string.Empty) && (txtRunKeyword.Text != string.Empty))
            {
                Integrator.CreateCustomCommand(txtRunFile.Text, txtRunKeyword.Text);

                txtRunFile.Clear();
                txtRunKeyword.Clear();

                GetCustomCommands();
            }
        }

        private void DefineCmd_FileOk(object sender, CancelEventArgs e)
        {
            txtRunFile.Text = defineCommandDialog.FileName;
            txtRunKeyword.Text = Path.GetFileNameWithoutExtension(txtRunFile.Text).ToLower();            
        }

        private void button58_Click(object sender, EventArgs e)
        {
            InfoForm r = new InfoForm(Integrator.powerinfo);
            r.ShowDialog(this);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            InfoForm r = new InfoForm(Integrator.systemtoolsinfo);
            r.ShowDialog(this);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            InfoForm r = new InfoForm(Integrator.windowsappsinfo);
            r.ShowDialog(this);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            InfoForm r = new InfoForm(Integrator.systemshortcutsinfo);
            r.ShowDialog(this);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            InfoForm r = new InfoForm(Integrator.desktopshortcutsinfo);
            r.ShowDialog(this);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            Utilities.ImportRegistryScript(Required.ReadyMadeMenus + "\\PowerMenu.reg");
            GetDesktopItems();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Utilities.ImportRegistryScript(Required.ReadyMadeMenus + "\\SystemTools.reg");
            GetDesktopItems();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Utilities.ImportRegistryScript(Required.ReadyMadeMenus + "\\WindowsApps.reg");
            GetDesktopItems();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            Utilities.ImportRegistryScript(Required.ReadyMadeMenus + "\\SystemShortcuts.reg");
            GetDesktopItems();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            Utilities.ImportRegistryScript(Required.ReadyMadeMenus + "\\DesktopShortcuts.reg");
            GetDesktopItems();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            GetDesktopItems();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (listDesktopItems.SelectedItems.Count == 1)
            {
                Integrator.RemoveItem(listDesktopItems.SelectedItem.ToString());
                GetDesktopItems();
            }
        }

        internal void RemoveAllDesktopItems()
        {
            List<string> collection = new List<string>();
            foreach (string item in listDesktopItems.Items)
            {
                collection.Add(item);
            }

            Integrator.RemoveAllItems(collection);

            GetDesktopItems();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (listDesktopItems.Items.Count > 0)
            {
                HelperForm r = new HelperForm(this, MessageType.Integrator, _removeDesktopItemsMessage);
                r.ShowDialog(this);
            }
        }

        private void radioProgram_CheckedChanged(object sender, EventArgs e)
        {
            if (radioProgram.Checked)
            {
                btnBrowseItem.Enabled = true;
                txtItem.Clear();
                checkDefaultIcon.Checked = true;
                txtIcon.Enabled = false;
                btnBrowseIcon.Enabled = false;
                itemtoaddgroup.Text = "Program to add:";
                checkDefaultIcon.Visible = true;
                checkDefaultIcon.Text = "Use program's icon";
                txtItemName.Clear();
                txtItem.ReadOnly = true;
                txtIcon.ReadOnly = true;
                _desktopItemType = DesktopItemType.Program;
            }
        }

        private void radioFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFolder.Checked)
            {
                checkDefaultIcon.Checked = true;
                btnBrowseItem.Enabled = true;
                txtItem.Clear();
                itemtoaddgroup.Text = "Folder to add:";
                checkDefaultIcon.Text = "Use default folder icon";
                txtItemName.Clear();
                txtItem.ReadOnly = true;
                txtIcon.ReadOnly = true;
                _desktopItemType = DesktopItemType.Folder;
            }
        }

        private void radioLink_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLink.Checked)
            {
                checkDefaultIcon.Checked = true;
                checkDefaultIcon.Text = "Download website icon (favicon)";
                btnBrowseItem.Enabled = false;
                itemtoaddgroup.Text = "Web address to add:";
                checkDefaultIcon.Visible = true;
                txtItem.Text = "http://";
                txtItemName.Clear();
                txtItem.ReadOnly = false;
                txtIcon.ReadOnly = true;
                _desktopItemType = DesktopItemType.Link;
            }
        }

        private void radioFile_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFile.Checked)
            {
                checkDefaultIcon.Checked = true;
                checkDefaultIcon.Text = "No icon";
                btnBrowseItem.Enabled = true;
                itemtoaddgroup.Text = "File to add:";
                checkDefaultIcon.Visible = true;
                txtItem.Clear();
                txtItemName.Clear();
                txtItem.ReadOnly = true;
                txtIcon.ReadOnly = true;
                _desktopItemType = DesktopItemType.File;
            }
        }

        private void radioCommand_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCommand.Checked)
            {
                btnBrowseItem.Enabled = false;
                txtItem.Clear();
                checkDefaultIcon.Checked = true;
                txtIcon.Enabled = false;
                btnBrowseIcon.Enabled = false;
                itemtoaddgroup.Text = "Command to add:";
                checkDefaultIcon.Visible = true;
                checkDefaultIcon.Text = "No icon";
                txtItemName.Clear();
                txtItem.ReadOnly = false;
                txtIcon.ReadOnly = true;
                _desktopItemType = DesktopItemType.Command;
            }
        }

        private void checkDefaultIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDefaultIcon.Checked)
            {
                txtIcon.Clear();
                txtIcon.Enabled = false;
                btnBrowseIcon.Enabled = false;
            }
            else
            {
                txtIcon.Clear();
                txtIcon.Enabled = true;
                btnBrowseIcon.Enabled = true;
            }
        }

        private void btnBrowseItem_Click(object sender, EventArgs e)
        {
            switch (_desktopItemType)
            {
                case DesktopItemType.Program:
                    defineProgramDialog.ShowDialog();
                    break;
                case DesktopItemType.Folder:
                    defineFolderDialog.ShowDialog();
                    txtItem.Text = defineFolderDialog.SelectedPath;
                    int i = defineFolderDialog.SelectedPath.LastIndexOf("\\");
                    txtItemName.Text = defineFolderDialog.SelectedPath.Remove(0, i + 1);
                    break;
                case DesktopItemType.File:
                    defineFileDialog.ShowDialog();
                    break;
            }
        }

        private void DefineProgramDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtItem.Text = defineProgramDialog.FileName;
            txtItemName.Text = defineProgramDialog.SafeFileName.Replace(".exe", string.Empty);
        }

        private void DefineFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtItem.Text = defineFileDialog.FileName;
            txtItemName.Text = defineFileDialog.SafeFileName;
        }

        private void btnBrowseIcon_Click(object sender, EventArgs e)
        {
            switch (_desktopItemType)
            {
                case DesktopItemType.Program:
                    DefineProgramIconDialog.ShowDialog();
                    break;
                case DesktopItemType.Folder:
                    DefineFolderIconDialog.ShowDialog();
                    break;
                case DesktopItemType.Link:
                    DefineURLIconDialog.ShowDialog();
                    break;
                case DesktopItemType.File:
                    DefineFileIconDialog.ShowDialog();
                    break;
                case DesktopItemType.Command:
                    DefineCommandIconDialog.ShowDialog();
                    break;
            }
        }

        private void DefineProgramIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtIcon.Text = DefineProgramIconDialog.FileName;

            if (txtIcon.Text.Contains(".exe"))
            {
                string iconpath = Integrator.ExtractIconFromExecutable(txtItemName.Text, DefineProgramIconDialog.FileName);
                txtIcon.Text = iconpath;
            }
        }

        private void DefineFolderIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtIcon.Text = DefineFolderIconDialog.FileName;

            if (txtIcon.Text.Contains(".exe"))
            {
                string iconpath = Integrator.ExtractIconFromExecutable(txtItemName.Text, DefineFolderIconDialog.FileName);
                txtIcon.Text = iconpath;
            }
        }

        private void DefineURLIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtIcon.Text = DefineURLIconDialog.FileName;

            if (txtIcon.Text.Contains(".exe"))
            {
                string iconpath = Integrator.ExtractIconFromExecutable(txtItemName.Text, DefineURLIconDialog.FileName);
                txtIcon.Text = iconpath;
            }
        }

        private void DefineFileIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtIcon.Text = DefineFileIconDialog.FileName;

            if (txtIcon.Text.Contains(".exe"))
            {
                string iconpath = Integrator.ExtractIconFromExecutable(txtItemName.Text, DefineFileIconDialog.FileName);
                txtIcon.Text = iconpath;
            }
        }

        private void DefineCommandIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtIcon.Text = DefineCommandIconDialog.FileName;

            if (txtIcon.Text.Contains(".exe"))
            {
                string iconpath = Integrator.ExtractIconFromExecutable(txtItemName.Text, DefineCommandIconDialog.FileName);
                txtIcon.Text = iconpath;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string icon = string.Empty;

            switch (_desktopItemType)
            {
                case DesktopItemType.Program:
                    if (checkDefaultIcon.Checked)
                    {
                        icon = txtItem.Text;
                    }
                    else
                    {
                        icon = txtIcon.Text;
                    }

                    Integrator.AddItem(txtItemName.Text, txtItem.Text, icon, _desktopItemPosition, checkShift.Checked, DesktopItemType.Program);

                    break;
                case DesktopItemType.Folder:
                    if (checkDefaultIcon.Checked)
                    {
                        icon = Integrator.FolderDefaultIcon;
                    }
                    else
                    {
                        icon = txtIcon.Text;
                    }

                    Integrator.AddItem(txtItemName.Text, txtItem.Text, icon, _desktopItemPosition, checkShift.Checked, DesktopItemType.Folder);

                    break;
                case DesktopItemType.Link:
                    if (checkDefaultIcon.Checked)
                    {
                        icon = Integrator.DownloadFavicon(txtItem.Text, txtItemName.Text);
                    }
                    else
                    {
                        icon = txtIcon.Text;
                    }

                    Integrator.AddItem(txtItemName.Text, txtItem.Text, icon, _desktopItemPosition, checkShift.Checked, DesktopItemType.Link);
                    
                    break;
                case DesktopItemType.File:
                    if (!checkDefaultIcon.Checked)
                    {
                        icon = txtIcon.Text;
                    }

                    Integrator.AddItem(txtItemName.Text, txtItem.Text, icon, _desktopItemPosition, checkShift.Checked, DesktopItemType.File);
                    
                    break;
                case DesktopItemType.Command:
                    if (!checkDefaultIcon.Checked)
                    {
                        icon = txtIcon.Text;
                    }

                    Integrator.AddItem(txtItemName.Text, txtItem.Text, icon, _desktopItemPosition, checkShift.Checked, DesktopItemType.Command);
                    
                    break;
            }

            GetDesktopItems();
            ResetIntegratorForm();
        }

        private void integratorTimer_Tick(object sender, EventArgs e)
        {
            if ((txtItem.Text != "") && (txtItemName.Text != "") && (txtIcon.Text != "") && (!checkDefaultIcon.Checked))
            {
                btnAddItem.Enabled = true;
            }
            else if ((txtItem.Text != "") && (txtItemName.Text != "") && (checkDefaultIcon.Checked))
            {
                btnAddItem.Enabled = true;
            }
            else
            {
                btnAddItem.Enabled = false;
            }
        }

        private void runDialogTimer_Tick(object sender, EventArgs e)
        {
            if ((txtRunFile.Text != "") && (txtRunKeyword.Text != ""))
            {
                btnCreateCustomCommand.Enabled = true;
            }
            else
            {
                btnCreateCustomCommand.Enabled = false;
            }
        }

        private void radioTop_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTop.Checked)
            {
                _desktopItemPosition = DesktopTypePosition.Top;
            }
        }

        private void radioMiddle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMiddle.Checked)
            {
                _desktopItemPosition = DesktopTypePosition.Middle;
            }
        }

        private void radioBottom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBottom.Checked)
            {
                _desktopItemPosition = DesktopTypePosition.Bottom;
            }
        }

        private void ResetIntegratorForm()
        {
            txtItem.Clear();
            txtIcon.Clear();
            checkDefaultIcon.Checked = true;
            txtItemName.Clear();

            if (radioLink.Checked)
            {
                txtItem.Text = "http://";
            }
        }

        private void radioOcean_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Ocean;
            Options.ApplyTheme(this);
        }

        private void radioMagma_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Magma;
            Options.ApplyTheme(this);
        }

        private void radioZerg_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Zerg;
            Options.ApplyTheme(this);
        }

        private void radioMinimal_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Minimal;
            Options.ApplyTheme(this);
        }

        private void radioCaramel_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Caramel;
            Options.ApplyTheme(this);
        }

        private void radioLime_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Lime;
            Options.ApplyTheme(this);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            Optimize.DisableGameBar();
            button63.Enabled = false;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (listStartupItems.SelectedItems.Count == 1)
            {
                _startUpItems[listStartupItems.SelectedIndices[0]].LocateKey();
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            Integrator.TakeOwnership(false);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            Integrator.TakeOwnership(true);
        }

        private void listStartupItems_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == _columnSorter.CurrentColumn)
            {
                if (_columnSorter.SortOrder == SortOrder.Ascending)
                {
                    _columnSorter.SortOrder = SortOrder.Descending;
                }
                else
                {
                    _columnSorter.SortOrder = SortOrder.Ascending;
                }
            }
            else
            {
                _columnSorter.CurrentColumn = e.Column;
                _columnSorter.SortOrder = SortOrder.Ascending;
            }

            listStartupItems.Sort();
        }

        private void chkBlock_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlock.Checked)
            {
                txtIP.Text = _blockedIP;
                txtIP.Enabled = false;
            }
            else
            {
                txtIP.Clear();
                txtIP.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Optimize.DisableQuickAccess();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GetCustomCommands();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (listCustomCommands.SelectedItems.Count == 1)
            {
                Integrator.DeleteCustomCommand(listCustomCommands.SelectedItem.ToString());
                GetCustomCommands();
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Optimize.DisableMediaPlayerSharing();
            button34.Enabled = false;
        }

        private void button68_Click(object sender, EventArgs e)
        {
            Optimize.DisableStartMenuAds();
            button68.Enabled = false;
        }

        private void button67_Click(object sender, EventArgs e)
        {
            Optimize.DisableSilentAppInstall();
            button67.Enabled = false;
        }

        private void button69_Click(object sender, EventArgs e)
        {
            Optimize.DisableMyPeople();
            button69.Enabled = false;
        }

        private void button70_Click(object sender, EventArgs e)
        {
            Optimize.ExcludeDrivers();
            button70.Enabled = false;
        }

        private void button71_Click(object sender, EventArgs e)
        {
            Optimize.DisableWindowsInk();
            button71.Enabled = false;
        }

        private void button72_Click(object sender, EventArgs e)
        {
            Optimize.DisableSpellingAndTypingFeatures();
            button72.Enabled = false;
        }

        private void button73_Click(object sender, EventArgs e)
        {
            Optimize.RestoreTaskbarColor();
            button73.Enabled = false;
        }

        private void button75_Click(object sender, EventArgs e)
        {
            GetModernApps();
        }

        private void button74_Click(object sender, EventArgs e)
        {
            UninstallModernApps();
        }
    }
}
