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
        bool _disablePrintServices = false;
        bool _disableSensorServices = false;

        public OptimizeForm(bool disablePrintServices, bool disableSensorServices)
        {
            InitializeComponent();

            _disablePrintServices = disablePrintServices;
            _disableSensorServices = disableSensorServices;
        }

        private void ApplyAll()
        {
            if (Utilities.CurrentWindowsVersion != WindowsVersion.Unsupported)
            {
                try
                {
                    // universal
                    Optimize.PerformanceTweaks();
                    Optimize.DisableNetworkThrottling();
                    Optimize.DisableDefender();
                    Optimize.DisableSystemRestore();

                    if (_disablePrintServices)
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

                    // Windows 7
                    if ((Utilities.CurrentWindowsVersion == WindowsVersion.Windows7))
                    {
                        Optimize.RemoveWindows10Icon();
                    }

                    // Windows 8 / 8.1
                    if ((Utilities.CurrentWindowsVersion == WindowsVersion.Windows8))
                    {
                        Optimize.RemoveWindows10Icon();
                        Optimize.DisableOneDrive();
                    }

                    // Windows 10
                    if ((Utilities.CurrentWindowsVersion == WindowsVersion.Windows10))
                    {
                        Optimize.RestoreLegacyVolumeSlider();
                        Optimize.DisableCortana();
                        Optimize.DisableXboxLive();
                        Optimize.DisableAutomaticUpdates();
                        Optimize.DisableDiagnosticsTracking();
                        Optimize.DisableWAPPush();
                        Optimize.DisableDataTelemetry();

                        if (_disableSensorServices)
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

            dotTimer.Start();

            Task t = new Task(() => ApplyAll());
            t.Start();
        }

        private void dotTimer_Tick(object sender, EventArgs e)
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
