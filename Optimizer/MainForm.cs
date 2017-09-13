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
        ListViewColumnSorter columnSorter;

        internal static WindowsVersion wv = WindowsVersion.Unsupported;
        List<StartupItem> items = new List<StartupItem>();
        List<string> entries = new List<string>();
        List<string> customCommands = new List<string>();
        List<string> synapses = new List<string>();
        DesktopItemType SynapseSelectedType = DesktopItemType.Program;
        DesktopTypePosition SynapseSelectedPosition = DesktopTypePosition.Top;

        readonly string blockip = "127.0.0.1";

        readonly string restartmsg = "Restart to apply changes?";
        readonly string removeallmsg = "Are you sure you want to delete all startup items?";
        readonly string removeentriesmsg = "Are you sure you want to delete all hosts entries?";
        readonly string removedesktopitemsmsg = "Are you sure you want to delete all desktop items?";

        private delegate void SetControlPropertyThreadSafeDelegate(
    Control control,
    string propertyName,
    object propertyValue);

        public static void SetControlPropertyThreadSafe(
            Control control,
            string propertyName,
            object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlPropertyThreadSafeDelegate
                (SetControlPropertyThreadSafe),
                new object[] { control, propertyName, propertyValue });
            }
            else
            {
                control.GetType().InvokeMember(
                    propertyName,
                    BindingFlags.SetProperty,
                    null,
                    control,
                    new object[] { propertyValue });
            }
        }

        private void LoadSettings()
        {
            switch (Options.CurrentOptions.Color)
            {
                case Theme.Caramel:
                    carameltheme.Checked = true;
                    break;
                case Theme.Lime:
                    limetheme.Checked = true;
                    break;
                case Theme.Magma:
                    magmatheme.Checked = true;
                    break;
                case Theme.Minimal:
                    minimaltheme.Checked = true;
                    break;
                case Theme.Ocean:
                    oceantheme.Checked = true;
                    break;
                case Theme.Zerg:
                    zergtheme.Checked = true;
                    break;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            Options.ApplyTheme(this);

            columnSorter = new ListViewColumnSorter();
            listStartupItems.ListViewItemSorter = columnSorter;
        }

        private void ApplyAll()
        {
            if (wv != WindowsVersion.Unsupported)
            {
                string msg = "";

                if (wv == WindowsVersion.Windows7)
                {
                    msg = "This will apply every option in Universal and Windows 7 tab. Continue?";
                }
                if (wv == WindowsVersion.Windows8)
                {
                    msg = "This will apply every option in Universal and Windows 8.1 tab. Continue?";
                }
                if (wv == WindowsVersion.Windows10)
                {
                    msg = "This will apply every option in Universal and Windows 10 tab. Continue?";
                }
                if (wv == WindowsVersion.WindowsServer2008)
                {
                    msg = "This will apply every option in Universal and Windows Server 2008 tab. Continue?";
                }
                if (wv == WindowsVersion.WindowsServer2012)
                {
                    msg = "This will apply every option in Universal and Windows Server 2012 tab. Continue?";
                }
                if (wv == WindowsVersion.WindowsServer2016)
                {
                    msg = "This will apply every option in Universal and Windows Server 2016 tab. Continue?";
                }

                MessagerForm r = new MessagerForm(this, MessagerType.Optimize, msg);
                r.ShowDialog(this);
            }
        }

        private void CleanPC()
        {
            try
            {
                if (tempfiles.Checked)
                {
                    CleanHelper.CleanTemp();
                }
                if (utorrentcache.Checked)
                {
                    CleanHelper.CleanUTorrent();
                }
                if (ftpservers.Checked)
                {
                    CleanHelper.CleanFileZilla();
                }
                if (bsoddumps.Checked)
                {
                    CleanHelper.CleanMiniDumps();
                }
                if (prefetchcache.Checked)
                {
                    CleanHelper.CleanPrefetch();
                }
                if (mediaplayercache.Checked)
                {
                    CleanHelper.CleanMediaPlayersCache();
                }
                if (logfiles.Checked)
                {
                    CleanHelper.CleanLogs();
                }
                if (emptytrash.Checked)
                {
                    CleanHelper.EmptyRecycleBin();
                }
                if (errorreports.Checked)
                {
                    CleanHelper.CleanErrorReports();
                }
            }
            catch { }
            finally
            {
                CleanAnimation(false);
            }
        }

        private void CleanAnimation(bool start)
        {
            if (start == true)
            {
                SetControlPropertyThreadSafe(cleaningpanel, "Visible", true);
                SetControlPropertyThreadSafe(progress2, "Visible", true);
                SetControlPropertyThreadSafe(progress2, "Style", ProgressBarStyle.Marquee);
                SetControlPropertyThreadSafe(progress2, "MarqueeAnimationSpeed", 1);
                SetControlPropertyThreadSafe(label4, "Visible", true);
                SetControlPropertyThreadSafe(button20, "Enabled", false);
                SetControlPropertyThreadSafe(panel1, "Enabled", false);
            }
            else
            {
                SetControlPropertyThreadSafe(cleaningpanel, "Visible", false);
                SetControlPropertyThreadSafe(progress2, "Visible", false);
                SetControlPropertyThreadSafe(progress2, "Value", 0);
                SetControlPropertyThreadSafe(progress2, "Style", ProgressBarStyle.Blocks);
                SetControlPropertyThreadSafe(progress2, "MarqueeAnimationSpeed", 1);
                SetControlPropertyThreadSafe(label4, "Visible", false);
                SetControlPropertyThreadSafe(button20, "Enabled", true);
                SetControlPropertyThreadSafe(panel1, "Enabled", true);
            }
        }

        private bool FixRegistry()
        {
            bool changeDetected = false;

            try
            {
                if (wfirewall.Checked)
                {
                    CleanHelper.EnableFirewall();
                    changeDetected = true;
                }
                if (cmdp.Checked)
                {
                    CleanHelper.EnableCommandPrompt();
                    changeDetected = true;
                }
                if (controlp.Checked)
                {
                    CleanHelper.EnableControlPanel();
                    changeDetected = true;
                }
                if (foldero.Checked)
                {
                    CleanHelper.EnableFolderOptions();
                    changeDetected = true;
                }
                if (rundialog.Checked)
                {
                    CleanHelper.EnableRunDialog();
                    changeDetected = true;
                }
                if (rightmenu.Checked)
                {
                    CleanHelper.EnableContextMenu();
                    changeDetected = true;
                }
                if (taskmgr.Checked)
                {
                    CleanHelper.EnableTaskManager();
                    changeDetected = true;
                }
                if (regeditor.Checked)
                {
                    CleanHelper.EnableRegistryEditor();
                    changeDetected = true;
                }
            }
            catch
            {
                changeDetected = false;
            }

            return changeDetected;
        }

        private string GetOS()
        {
            string os = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductName", "");

            if (os.Contains("Windows 7"))
            {
                wv = WindowsVersion.Windows7;
            }
            if ((os.Contains("Windows 8")) || (os.Contains("Windows 8.1")))
            {
                wv = WindowsVersion.Windows8;
            }
            if (os.Contains("Windows 10"))
            {
                wv = WindowsVersion.Windows10;
            }
            if (os.Contains("Windows Server 2008"))
            {
                wv = WindowsVersion.WindowsServer2008;
            }
            if (os.Contains("Windows Server 2012"))
            {
                wv = WindowsVersion.WindowsServer2012;
            }
            if (os.Contains("Windows Server 2016"))
            {
                wv = WindowsVersion.WindowsServer2016;
            }

            return os;
        }

        private string GetBitness()
        {
            string bitness = "";

            if (Environment.Is64BitOperatingSystem == true)
            {
                bitness = "You are working with 64-bit architecture";
            }
            else
            {
                bitness = "You are working with 32-bit architecture";
            }

            return bitness;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            
            SynapseValidator.Start();
            iRunValidator.Start();

            GetStartupItems();
            GetHostsEntries();
            GetDesktopItems();
            GetCustomCommands();

            LoadSettings();

            typeprogram.Checked = true;
            topposition.Checked = true;

            label1.Text = "Version: " + Program.GetCurrentVersionToString();
            Program.main = this;
            
            ostxt.Text = "Microsoft " + GetOS();
            bittxt.Text = GetBitness();   
            
            if (wv == WindowsVersion.Unsupported)
            {
                aio.TabPages.Remove(universaltab);
                aio.TabPages.Remove(tab7);
                aio.TabPages.Remove(tab8);
                aio.TabPages.Remove(tab10);
            }   

            if (wv == WindowsVersion.Windows7)
            {
                aio.TabPages.Remove(tab8);
                aio.TabPages.Remove(tab10);
            }

            if (wv == WindowsVersion.Windows8)
            {
                aio.TabPages.Remove(tab7);
                aio.TabPages.Remove(tab10);
            }

            if (wv == WindowsVersion.Windows10)
            {
                aio.TabPages.Remove(tab7);
                aio.TabPages.Remove(tab8);
            }

            if (wv == WindowsVersion.WindowsServer2008)
            {
                tab7.Text = "Windows Server 2008";
                aio.TabPages.Remove(tab8);
                aio.TabPages.Remove(tab10);
            }

            if (wv == WindowsVersion.WindowsServer2012)
            {
                tab8.Text = "Windows Server 2012";
                aio.TabPages.Remove(tab7);
                aio.TabPages.Remove(tab10);
            }

            if (wv == WindowsVersion.WindowsServer2016)
            {
                tab10.Text = "Windows Server 2016";
                aio.TabPages.Remove(tab7);
                aio.TabPages.Remove(tab8);
            }

            //foreach (string s in Integrator.GetCustomCommands())
            //{
            //    MessageBox.Show(s);
            //}
        }

        private void GetDesktopItems()
        {
            synapses = Integrator.GetDesktopItems();
            listDesktopItems.Items.Clear();

            for (int i = 0; i < synapses.Count; i++)
            {
                if (!string.IsNullOrEmpty(synapses[i]))
                {
                    listDesktopItems.Items.Add(synapses[i]);
                }
            }
        }

        private void GetHostsEntries()
        {
            entries = HostsHelper.GetEntries();
            hl.Items.Clear();
           
            for (int i = 0; i < entries.Count; i++)
            {
                if (!string.IsNullOrEmpty(entries[i]))
                {
                    hl.Items.Add(entries[i]);
                }
            }
        }

        private void GetStartupItems()
        {
            items = CleanHelper.GetStartupItems();
            listStartupItems.Items.Clear();

            for (int i = 0; i < items.Count; i++)
            {
                ListViewItem list = new ListViewItem(items[i].Name);
                list.SubItems.Add(items[i].Location);
                list.SubItems.Add(items[i].ToString());

                listStartupItems.Items.Add(list);
            }
        }

        private void GetCustomCommands()
        {
            customCommands = Integrator.GetCustomCommands();
            listCustomCommands.Items.Clear();

            foreach (string s in customCommands)
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
            MessagerForm f = new MessagerForm(this, MessagerType.Restart, restartmsg);
            f.ShowDialog();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            MessagerForm f = new MessagerForm(this, MessagerType.Restart, restartmsg);
            f.ShowDialog();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            MessagerForm f = new MessagerForm(this, MessagerType.Restart, restartmsg);
            f.ShowDialog();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            MessagerForm f = new MessagerForm(this, MessagerType.Restart, restartmsg);
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
            Optimize.ActivateMain();
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
            Optimize.ActivateMain();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Task t = new Task(() => Optimize.DisableOfficeTelemetryTasks());
            t.Start();
            Optimize.ActivateMain();
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

        private void selectall_CheckedChanged(object sender, EventArgs e)
        {
            tempfiles.Checked = selectall.Checked;
            utorrentcache.Checked = selectall.Checked;
            ftpservers.Checked = selectall.Checked;
            bsoddumps.Checked = selectall.Checked;
            prefetchcache.Checked = selectall.Checked;
            mediaplayercache.Checked = selectall.Checked;
            logfiles.Checked = selectall.Checked;
            emptytrash.Checked = selectall.Checked;
            errorreports.Checked = selectall.Checked;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            CleanAnimation(true);
            Task t = new Task(() => CleanPC());
            t.Start();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (listStartupItems.SelectedItems.Count == 1)
            {
                items[listStartupItems.SelectedIndices[0]].Remove();
                GetStartupItems();
            }
        }

        internal void RemoveAllStartupItems()
        {
            foreach (ListViewItem i in listStartupItems.Items)
            {
                items[i.Index].Remove();
            }

            GetStartupItems();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (listStartupItems.Items.Count > 0)
            {
                MessagerForm r = new MessagerForm(this, MessagerType.Startup, removeallmsg);
                r.ShowDialog(this);
            } 
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (listStartupItems.SelectedItems.Count == 1)
            {
                items[listStartupItems.SelectedIndices[0]].LocateFile();
            }
        }

        private void enableall_CheckedChanged(object sender, EventArgs e)
        {
            taskmgr.Checked = enableall.Checked;
            cmdp.Checked = enableall.Checked;
            controlp.Checked = enableall.Checked;
            foldero.Checked = enableall.Checked;
            rundialog.Checked = enableall.Checked;
            rightmenu.Checked = enableall.Checked;
            wfirewall.Checked = enableall.Checked;
            regeditor.Checked = enableall.Checked;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            bool flag = FixRegistry();
            panel2.Enabled = false;
            button33.Enabled = false;

            if (flag)
            {
                if (restartexplorer.Checked)
                {
                    CleanHelper.RestartExplorer();
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
                string recommendeddomain = string.Empty;

                if (!domain.StartsWith("www."))
                {
                    recommendeddomain = "www." + domain;
                }
                else
                {
                    recommendeddomain = domain.Replace("www.", string.Empty).Trim();
                }

                HostsHelper.AddEntry(HostsHelper.SanitizeEntry(ip) + " " + HostsHelper.SanitizeEntry(domain));
                
                if (!string.IsNullOrEmpty(recommendeddomain))
                {
                    HostsHelper.AddEntry(HostsHelper.SanitizeEntry(ip) + " " + HostsHelper.SanitizeEntry(recommendeddomain));
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
            if (hl.SelectedItems.Count == 1)
            {
                string temp = hl.SelectedItem.ToString().Replace(" : ", " ");
                HostsHelper.RemoveEntry(temp);

                GetHostsEntries();
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (hl.Items.Count > 0)
            {
                MessagerForm r = new MessagerForm(this, MessagerType.Hosts, removeentriesmsg);
                r.ShowDialog(this);
            }
        }

        internal void RemoveAllHostsEntries()
        {
            List<string> collection = new List<string>();

            foreach (string item in hl.Items)
            {
                collection.Add(item.Replace(" : ", " "));
            }

            HostsHelper.RemoveAllEntries(collection);
            GetHostsEntries();
        }

        private void aio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aio.SelectedTab == tabPage1)
            {
                txtIP.Focus();
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            DefineCmdDialog.ShowDialog();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if ((runfile.Text != string.Empty) && (runkey.Text != string.Empty))
            {
                Integrator.CreateCustomCommand(runfile.Text, runkey.Text);

                runfile.Clear();
                runkey.Clear();

                GetCustomCommands();
            }
        }

        private void DefineCmd_FileOk(object sender, CancelEventArgs e)
        {
            runfile.Text = DefineCmdDialog.FileName;
            runkey.Text = Path.GetFileNameWithoutExtension(runfile.Text).ToLower();            
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
            Optimize.ImportRegistryScript(Required.ReadyMadeMenus + "\\PowerMenu.reg");
            GetDesktopItems();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Optimize.ImportRegistryScript(Required.ReadyMadeMenus + "\\SystemTools.reg");
            GetDesktopItems();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Optimize.ImportRegistryScript(Required.ReadyMadeMenus + "\\WindowsApps.reg");
            GetDesktopItems();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            Optimize.ImportRegistryScript(Required.ReadyMadeMenus + "\\SystemShortcuts.reg");
            GetDesktopItems();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            Optimize.ImportRegistryScript(Required.ReadyMadeMenus + "\\DesktopShortcuts.reg");
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
                MessagerForm r = new MessagerForm(this, MessagerType.Integrator, removedesktopitemsmsg);
                r.ShowDialog(this);
            }
        }

        private void typeprogram_CheckedChanged(object sender, EventArgs e)
        {
            if (typeprogram.Checked)
            {
                browseitem.Enabled = true;
                itemtoadd.Clear();
                defaulticon.Checked = true;
                icontoadd.Enabled = false;
                browseicon.Enabled = false;
                itemtoaddgroup.Text = "Program to add:";
                defaulticon.Visible = true;
                defaulticon.Text = "Use program's icon";
                itemname.Clear();
                itemtoadd.ReadOnly = true;
                icontoadd.ReadOnly = true;
                SynapseSelectedType = DesktopItemType.Program;
            }
        }

        private void typefolder_CheckedChanged(object sender, EventArgs e)
        {
            if (typefolder.Checked)
            {
                defaulticon.Checked = true;
                browseitem.Enabled = true;
                itemtoadd.Clear();
                itemtoaddgroup.Text = "Folder to add:";
                defaulticon.Text = "Use default folder icon";
                itemname.Clear();
                itemtoadd.ReadOnly = true;
                icontoadd.ReadOnly = true;
                SynapseSelectedType = DesktopItemType.Folder;
            }
        }

        private void typeurl_CheckedChanged(object sender, EventArgs e)
        {
            if (typeurl.Checked)
            {
                defaulticon.Checked = true;
                defaulticon.Text = "Download website icon (favicon)";
                browseitem.Enabled = false;
                itemtoaddgroup.Text = "Web address to add:";
                defaulticon.Visible = true;
                itemtoadd.Text = "http://";
                itemname.Clear();
                itemtoadd.ReadOnly = false;
                icontoadd.ReadOnly = true;
                SynapseSelectedType = DesktopItemType.Link;
            }
        }

        private void typefile_CheckedChanged(object sender, EventArgs e)
        {
            if (typefile.Checked)
            {
                defaulticon.Checked = true;
                defaulticon.Text = "No icon";
                browseitem.Enabled = true;
                itemtoaddgroup.Text = "File to add:";
                defaulticon.Visible = true;
                itemtoadd.Clear();
                itemname.Clear();
                itemtoadd.ReadOnly = true;
                icontoadd.ReadOnly = true;
                SynapseSelectedType = DesktopItemType.File;
            }
        }

        private void typecmd_CheckedChanged(object sender, EventArgs e)
        {
            if (typecmd.Checked)
            {
                browseitem.Enabled = false;
                itemtoadd.Clear();
                defaulticon.Checked = true;
                icontoadd.Enabled = false;
                browseicon.Enabled = false;
                itemtoaddgroup.Text = "Command to add:";
                defaulticon.Visible = true;
                defaulticon.Text = "No icon";
                itemname.Clear();
                itemtoadd.ReadOnly = false;
                icontoadd.ReadOnly = true;
                SynapseSelectedType = DesktopItemType.Command;
            }
        }

        private void defaulticon_CheckedChanged(object sender, EventArgs e)
        {
            if (defaulticon.Checked)
            {
                icontoadd.Clear();
                icontoadd.Enabled = false;
                browseicon.Enabled = false;
            }
            else
            {
                icontoadd.Clear();
                icontoadd.Enabled = true;
                browseicon.Enabled = true;
            }
        }

        private void browseitem_Click(object sender, EventArgs e)
        {
            switch (SynapseSelectedType)
            {
                case DesktopItemType.Program:
                    DefineProgramDialog.ShowDialog();
                    break;
                case DesktopItemType.Folder:
                    DefineFolderDialog.ShowDialog();
                    itemtoadd.Text = DefineFolderDialog.SelectedPath;
                    int i = DefineFolderDialog.SelectedPath.LastIndexOf("\\");
                    itemname.Text = DefineFolderDialog.SelectedPath.Remove(0, i + 1);
                    break;
                case DesktopItemType.File:
                    DefineFileDialog.ShowDialog();
                    break;
            }
        }

        private void DefineProgramDialog_FileOk(object sender, CancelEventArgs e)
        {
            itemtoadd.Text = DefineProgramDialog.FileName;
            itemname.Text = DefineProgramDialog.SafeFileName.Replace(".exe", string.Empty);
        }

        private void DefineFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            itemtoadd.Text = DefineFileDialog.FileName;
            itemname.Text = DefineFileDialog.SafeFileName;
        }

        private void browseicon_Click(object sender, EventArgs e)
        {
            switch (SynapseSelectedType)
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
            icontoadd.Text = DefineProgramIconDialog.FileName;

            if (icontoadd.Text.Contains(".exe"))
            {
                string iconpath = Integrator.ExtractIconFromExecutable(itemname.Text, DefineProgramIconDialog.FileName);
                icontoadd.Text = iconpath;
            }
        }

        private void DefineFolderIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            icontoadd.Text = DefineFolderIconDialog.FileName;

            if (icontoadd.Text.Contains(".exe"))
            {
                string iconpath = Integrator.ExtractIconFromExecutable(itemname.Text, DefineFolderIconDialog.FileName);
                icontoadd.Text = iconpath;
            }
        }

        private void DefineURLIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            icontoadd.Text = DefineURLIconDialog.FileName;

            if (icontoadd.Text.Contains(".exe"))
            {
                string iconpath = Integrator.ExtractIconFromExecutable(itemname.Text, DefineURLIconDialog.FileName);
                icontoadd.Text = iconpath;
            }
        }

        private void DefineFileIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            icontoadd.Text = DefineFileIconDialog.FileName;

            if (icontoadd.Text.Contains(".exe"))
            {
                string iconpath = Integrator.ExtractIconFromExecutable(itemname.Text, DefineFileIconDialog.FileName);
                icontoadd.Text = iconpath;
            }
        }

        private void DefineCommandIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            icontoadd.Text = DefineCommandIconDialog.FileName;

            if (icontoadd.Text.Contains(".exe"))
            {
                string iconpath = Integrator.ExtractIconFromExecutable(itemname.Text, DefineCommandIconDialog.FileName);
                icontoadd.Text = iconpath;
            }
        }

        private void addmodifybtn_Click(object sender, EventArgs e)
        {
            switch (SynapseSelectedType)
            {
                case DesktopItemType.Program:
                    string program = itemtoadd.Text;
                    string icon = "";

                    if (defaulticon.Checked)
                    {
                        icon = program;
                    }
                    else
                    {
                        icon = icontoadd.Text;
                    }

                    bool shift = shiftkey.Checked;
                    string nick = itemname.Text;

                    Integrator.AddItem(nick, program, icon, SynapseSelectedPosition, shift, DesktopItemType.Program);
                    GetDesktopItems();
                    SynapseReset();
                    break;
                case DesktopItemType.Folder:
                    string folder = itemtoadd.Text;
                    string icon2 = "";

                    if (defaulticon.Checked)
                    {
                        icon2 = Integrator.FolderDefaultIcon;
                    }
                    else
                    {
                        icon2 = icontoadd.Text;
                    }

                    bool shift2 = shiftkey.Checked;
                    string nick2 = itemname.Text;

                    Integrator.AddItem(nick2, folder, icon2, SynapseSelectedPosition, shift2, DesktopItemType.Folder);
                    GetDesktopItems();
                    SynapseReset();
                    break;
                case DesktopItemType.Link:
                    string link = itemtoadd.Text;
                    string icon3 = "";
                    string nick3 = itemname.Text;

                    if (defaulticon.Checked)
                    {
                        icon3 = Integrator.DownloadFavicon(link, nick3);
                    }
                    else
                    {
                        icon3 = icontoadd.Text;
                    }

                    bool shift3 = shiftkey.Checked;

                    Integrator.AddItem(nick3, link, icon3, SynapseSelectedPosition, shift3, DesktopItemType.Link);
                    GetDesktopItems();
                    SynapseReset();
                    break;
                case DesktopItemType.File:
                    string file = itemtoadd.Text;
                    string icon4 = "";
                    string nick4 = itemname.Text;

                    if (defaulticon.Checked)
                    {
                        icon4 = "";
                    }
                    else
                    {
                        icon4 = icontoadd.Text;
                    }

                    bool shift4 = shiftkey.Checked;

                    Integrator.AddItem(nick4, file, icon4, SynapseSelectedPosition, shift4, DesktopItemType.File);
                    GetDesktopItems();
                    SynapseReset();
                    break;
                case DesktopItemType.Command:
                    string cmd = itemtoadd.Text;
                    string icon5 = "";
                    string nick5 = itemname.Text;

                    if (defaulticon.Checked)
                    {
                        icon5 = "";
                    }
                    else
                    {
                        icon5 = icontoadd.Text;
                    }

                    bool shift5 = shiftkey.Checked;

                    Integrator.AddItem(nick5, cmd, icon5, SynapseSelectedPosition, shift5, DesktopItemType.Command);
                    GetDesktopItems();
                    SynapseReset();
                    break;
            }
        }

        private void SynapseValidator_Tick(object sender, EventArgs e)
        {
            if ((itemtoadd.Text != "") && (itemname.Text != "") && (icontoadd.Text != "") && (!defaulticon.Checked))
            {
                addmodifybtn.Enabled = true;
            }
            else if ((itemtoadd.Text != "") && (itemname.Text != "") && (defaulticon.Checked))
            {
                addmodifybtn.Enabled = true;
            }
            else
            {
                addmodifybtn.Enabled = false;
            }
        }

        private void iRunValidator_Tick(object sender, EventArgs e)
        {
            if ((runfile.Text != "") && (runkey.Text != ""))
            {
                button50.Enabled = true;
            }
            else
            {
                button50.Enabled = false;
            }
        }

        private void topposition_CheckedChanged(object sender, EventArgs e)
        {
            if (topposition.Checked)
            {
                SynapseSelectedPosition = DesktopTypePosition.Top;
            }
        }

        private void midposition_CheckedChanged(object sender, EventArgs e)
        {
            if (midposition.Checked)
            {
                SynapseSelectedPosition = DesktopTypePosition.Middle;
            }
        }

        private void botposition_CheckedChanged(object sender, EventArgs e)
        {
            if (botposition.Checked)
            {
                SynapseSelectedPosition = DesktopTypePosition.Bottom;
            }
        }

        private void SynapseReset()
        {
            itemtoadd.Clear();
            icontoadd.Clear();
            defaulticon.Checked = true;
            itemname.Clear();

            if (typeurl.Checked)
            {
                itemtoadd.Text = "http://";
            }
        }

        private void oceantheme_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Ocean;
            Options.ApplyTheme(this);
        }

        private void magmatheme_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Magma;
            Options.ApplyTheme(this);
        }

        private void zergtheme_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Zerg;
            Options.ApplyTheme(this);
        }

        private void minimaltheme_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Minimal;
            Options.ApplyTheme(this);
        }

        private void carameltheme_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Caramel;
            Options.ApplyTheme(this);
        }

        private void limetheme_CheckedChanged(object sender, EventArgs e)
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
                items[listStartupItems.SelectedIndices[0]].LocateKey();
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
            if (e.Column == columnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (columnSorter.Order == SortOrder.Ascending)
                {
                    columnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    columnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                columnSorter.SortColumn = e.Column;
                columnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            listStartupItems.Sort();
        }

        private void chkBlock_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlock.Checked)
            {
                txtIP.Text = blockip;
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
            Optimize.DisableSyncProviderNotifications();
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
    }
}
