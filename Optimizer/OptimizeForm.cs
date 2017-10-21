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
    public partial class OptimizeForm : Form
    {
        bool DisablePrintServices = false;
        bool DisableSensorServices = false;

        public OptimizeForm(bool flag, bool flag2)
        {
            InitializeComponent();
            DisablePrintServices = flag;
            DisableSensorServices = flag;
        }

        private void ApplyAll()
        {
            if (MainForm.wv != WindowsVersion.Unsupported)
            {
                try
                {
                    // universal
                    Optimize.PerformanceTweaks();
                    Optimize.DisableNetworkThrottling();
                    Optimize.DisableDefender();
                    Optimize.DisableSystemRestore();

                    if (DisablePrintServices)
                    {
                        Optimize.DisablePrintSpooler();
                    }
                    else
                    {
                        Optimize.EnablePrintSpooler();
                    }

                    Optimize.DisableMediaPlayerSharing();
                    Optimize.BlockSkypeAds();
                    Optimize.DisableErrorReporting();
                    Optimize.DisableHomeGroup();
                    Optimize.DisableSuperfetch();
                    Optimize.DisableTelemetryTasks();
                    Optimize.DisableOfficeTelemetryTasks();

                    // Windows-specific
                    if ((MainForm.wv == WindowsVersion.Windows7) || (MainForm.wv == WindowsVersion.WindowsServer2008))
                    {
                        Optimize.RemoveWindows10Icon();
                    }

                    if ((MainForm.wv == WindowsVersion.Windows8) || (MainForm.wv == WindowsVersion.WindowsServer2012))
                    {
                        Optimize.RemoveWindows10Icon();
                        Optimize.DisableOneDrive();
                    }

                    if ((MainForm.wv == WindowsVersion.Windows10) || (MainForm.wv == WindowsVersion.WindowsServer2016))
                    {
                        Optimize.RestoreLegacyVolumeSlider();
                        Optimize.DisableCortana();
                        Optimize.DisableXboxLive();
                        Optimize.DisableAutomaticUpdates();
                        Optimize.DisableDiagnosticsTracking();
                        Optimize.DisableWAPPush();
                        Optimize.DisableDataTelemetry();

                        if (DisableSensorServices)
                        {
                            Optimize.DisableSensorServices();
                        }
                        else
                        {
                            Optimize.EnableSensorServices();
                        }

                        Optimize.UninstallOneDrive();
                        Optimize.DisablePrivacyOptions();
                        Optimize.DisableGameBar();
                        Optimize.DisableSyncProviderNotifications();
                        Optimize.DisableStartMenuAds();
                        Optimize.DisableSilentAppInstall();
                        Optimize.DisableMyPeople();
                        Optimize.ExcludeDrivers();
                        Optimize.DisableWindowsInk();
                        Optimize.DisableSpellingAndTypingFeatures();
                    }
                }
                catch //(Exception error)
                {
                    //MessageBox.Show(error.Message);
                }
                finally
                {
                    this.Close();
                }
            }

            this.Close();
        }

        private void Helper_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Options.ApplyTheme(this);

            dotter.Start();

            Task t = new Task(() => ApplyAll());
            t.Start();
        }

        private void dotter_Tick(object sender, EventArgs e)
        {
            switch (label2.Text)
            {
                case "":
                    label2.Text = ".";
                    break;
                case ".":
                    label2.Text = "..";
                    break;
                case "..":
                    label2.Text = "...";
                    break;
                case "...":
                    label2.Text = "";
                    break;
            }
        }
    }
}
