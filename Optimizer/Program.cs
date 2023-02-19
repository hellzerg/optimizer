using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Optimizer
{
    static class Program
    {
        /* VERSION PROPERTIES */
        /* DO NOT LEAVE THEM EMPTY */

        internal readonly static float Major = 14;
        internal readonly static float Minor = 9;

        internal readonly static bool EXPERIMENTAL_BUILD = false;
        internal static int DPI_PREFERENCE;

        internal static string GetCurrentVersionTostring()
        {
            return Major.ToString() + "." + Minor.ToString();
        }

        internal static float GetCurrentVersion()
        {
            return float.Parse(GetCurrentVersionTostring());
        }

        /* END OF VERSION PROPERTIES */

        // Enables the corresponding Windows tab for Windows Server machines
        internal static bool UNSAFE_MODE = false;

        const string _jsonAssembly = @"Optimizer.Newtonsoft.Json.dll";

        internal static MainForm _MainForm;
        internal static SplashForm _SplashForm;

        static string _adminMissingMessage = "Optimizer needs to be run as administrator!\nApp will now close...";
        static string _unsupportedMessage = "Optimizer works with Windows 7 and higher!\nApp will now close...";

        //static string _renameAppMessage = "It's recommended to rename the app from '{0}' to 'Optimizer' for a better experience.\n\nApp will now close...";

        static string _confInvalidVersionMsg = "Windows version does not match!";
        static string _confInvalidFormatMsg = "Config file is in invalid format!";
        static string _confNotFoundMsg = "Config file does not exist!";
        static string _argInvalidMsg = "Invalid argument! Example: Optimizer.exe /silent.conf";
        static string _alreadyRunningMsg = "Optimizer is already running in the background!";

        const string MUTEX_GUID = @"{DEADMOON-0EFC7B8A-D1FC-467F-B4B1-0117C643FE19-OPTIMIZER}";
        internal static Mutex MUTEX;
        static bool _notRunning;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        [STAThread]
        static void Main(string[] switches)
        {
            EmbeddedAssembly.Load(_jsonAssembly, _jsonAssembly.Replace("Optimizer.", string.Empty));
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

            DPI_PREFERENCE = Convert.ToInt32(Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ThemeManager", "LastLoadedDPI", "96"));
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // single-instance mechanism
            MUTEX = new Mutex(true, MUTEX_GUID, out _notRunning);

            if (!_notRunning)
            {
                MessageBox.Show(_alreadyRunningMsg, "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
                return;
            }

            if (!Utilities.IsAdmin())
            {
                string file = Process.GetCurrentProcess().MainModule.FileName;
                ProcessStartInfo p = new ProcessStartInfo(file);
                p.Verb = "runas";
                p.Arguments = string.Join(" ", switches);
                Process.Start(p);
                Environment.Exit(0);
                return;
            }

            if (!Utilities.IsCompatible())
            {
                HelperForm f = new HelperForm(null, MessageType.Error, _unsupportedMessage);
                f.ShowDialog();
                Environment.Exit(0);
                return;
            }

            Required.Deploy();
            FontHelper.LoadFont();

            if (switches.Length == 1)
            {
                string arg = switches[0].Trim().ToLowerInvariant();

                // UNSAFE mode switch (allows running on Windows Server 2008+)
                if (arg == "/unsafe")
                {
                    UNSAFE_MODE = true;
                    StartMainForm();
                    return;
                }

                if (arg == "/disablehpet")
                {
                    Utilities.DisableHPET();
                    Environment.Exit(0);
                    return;
                }
                if (arg == "/enablehpet")
                {
                    Utilities.EnableHPET();
                    Environment.Exit(0);
                    return;
                }

                // [!!!] unlock all cores instruction 
                if (arg == "/unlockcores")
                {
                    Utilities.UnlockAllCores();
                    Environment.Exit(0);
                    return;
                }

                if (arg == "/repair")
                {
                    Utilities.Repair(true);
                    return;
                }

                if (arg == "/version")
                {
                    if (!EXPERIMENTAL_BUILD) MessageBox.Show($"Optimizer: {GetCurrentVersionTostring()}\n\nCoded by: deadmoon © ∞\n\nhttps://github.com/hellzerg/optimizer", "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Optimizer: EXPERIMENTAL BUILD. PLEASE DELETE AFTER TESTING.\n\nCoded by: deadmoon © ∞\n\nhttps://github.com/hellzerg/optimizer", "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Environment.Exit(0);
                    return;
                }

                // instruct to restart in safe-mode
                if (arg == "/restart=safemode")
                {
                    RestartInSafeMode();
                }

                // instruct to restart normally
                if (arg == "/restart=normal")
                {
                    RestartInNormalMode();
                }

                // disable defender automatically
                if (arg == "/restart=disabledefender")
                {
                    // set RunOnce instruction
                    Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\RunOnce", "*OptimizerDisableDefender", Assembly.GetExecutingAssembly().Location + " /silentdisabledefender", Microsoft.Win32.RegistryValueKind.String);
                    RestartInSafeMode();
                }

                // enable defender automatically
                if (arg == "/restart=enabledefender")
                {
                    // set RunOnce instruction
                    Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\RunOnce", "*OptimizerEnableDefender", Assembly.GetExecutingAssembly().Location + " /silentenabledefender", Microsoft.Win32.RegistryValueKind.String);
                    RestartInSafeMode();
                }

                // return from safe-mode automatically
                if (arg == "/silentdisabledefender")
                {
                    DisableDefenderInSafeMode();
                    RestartInNormalMode();
                }

                if (arg == "/silentenabledefender")
                {
                    EnableDefenderInSafeMode();
                    RestartInNormalMode();
                }

                // disables Defender in SAFE MODE (for Windows 10 1903+ / works in Windows 11 as well)
                if (arg == "/disabledefender")
                {
                    DisableDefenderInSafeMode();

                    MessageBox.Show("Windows Defender has been completely disabled successfully.", "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Environment.Exit(0);
                    return;
                }

                // other options for disabling specific tools
                if (arg.StartsWith("/disable="))
                {
                    string x = arg.Replace("/disable=", string.Empty);
                    string[] opts = x.Split(',');

                    bool[] codes =
                    {
                        opts.Contains("indicium"),
                        opts.Contains("uwp"),
                        opts.Contains("apps"),
                        opts.Contains("hosts"),
                        opts.Contains("startup"),
                        opts.Contains("cleaner"),
                        opts.Contains("integrator"),
                        opts.Contains("pinger")
                    };

                    StartMainForm(codes);
                    return;
                }

                if (arg.StartsWith("/config="))
                {
                    string fileName = arg.Replace("/config=", string.Empty);

                    if (!File.Exists(fileName))
                    {
                        MessageBox.Show(_confNotFoundMsg, "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Environment.Exit(0);
                        return;
                    }

                    SilentOps.GetSilentConfig(fileName);
                    if (SilentOps.CurrentSilentConfig == null)
                    {
                        MessageBox.Show(_confInvalidFormatMsg, "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Environment.Exit(0);
                        return;
                    }

                    if (SilentOps.CurrentSilentConfig.WindowsVersion == 7 && Utilities.CurrentWindowsVersion == WindowsVersion.Windows7)
                    {
                        LoadSettings();
                        SilentOps.ProcessSilentConfigGeneral();
                        SilentOps.SilentUpdateOptionsGeneral();
                        Options.SaveSettings();
                    }
                    else if (SilentOps.CurrentSilentConfig.WindowsVersion == 8 && Utilities.CurrentWindowsVersion == WindowsVersion.Windows8)
                    {
                        LoadSettings();
                        SilentOps.ProcessSilentConfigGeneral();
                        SilentOps.ProcessSilentConfigWindows8();
                        SilentOps.SilentUpdateOptionsGeneral();
                        SilentOps.SilentUpdateOptions8();
                        Options.SaveSettings();
                    }
                    else if (SilentOps.CurrentSilentConfig.WindowsVersion == 10 && Utilities.CurrentWindowsVersion == WindowsVersion.Windows10)
                    {
                        LoadSettings();
                        SilentOps.ProcessSilentConfigGeneral();
                        SilentOps.ProcessSilentConfigWindows10();
                        SilentOps.SilentUpdateOptionsGeneral();
                        SilentOps.SilentUpdateOptions10();
                        Options.SaveSettings();
                    }
                    else if (SilentOps.CurrentSilentConfig.WindowsVersion == 11 && Utilities.CurrentWindowsVersion == WindowsVersion.Windows11)
                    {
                        LoadSettings();
                        SilentOps.ProcessSilentConfigGeneral();
                        SilentOps.ProcessSilentConfigWindows10();
                        SilentOps.ProcessSilentConfigWindows11();
                        SilentOps.SilentUpdateOptionsGeneral();
                        SilentOps.SilentUpdateOptions10();
                        SilentOps.SilentUpdateOptions11();
                        Options.SaveSettings();
                    }
                    else
                    {
                        MessageBox.Show(_confInvalidVersionMsg, "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                StartMainForm();
            }
        }

        private static void LoadSettings()
        {
            // for backward compatibility (legacy)
            Options.LegacyCheck();

            // load settings, if there is no settings, load defaults
            try
            {
                // show FirstRunForm/Language Selector if app is running first time
                if (!File.Exists(Options.SettingsFile))
                {
                    Options.LoadSettings();
                    FirstRunForm frf = new FirstRunForm();
                    frf.ShowDialog();
                }
                else
                {
                    Options.LoadSettings();
                }

                if (!Options.CurrentOptions.DisableOptimizerTelemetry)
                {
                    TelemetryHelper.EnableTelemetryService();
                }

                // ideal place to replace internal messages from translation list
                _adminMissingMessage = Options.TranslationList["adminMissingMsg"];
                _unsupportedMessage = Options.TranslationList["unsupportedMsg"];
                _confInvalidFormatMsg = Options.TranslationList["confInvalidFormatMsg"];
                _confInvalidVersionMsg = Options.TranslationList["confInvalidVersionMsg"];
                _confNotFoundMsg = Options.TranslationList["confNotFoundMsg"];
                _argInvalidMsg = Options.TranslationList["argInvalidMsg"];
                _alreadyRunningMsg = Options.TranslationList["alreadyRunningMsg"];
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Program.Main-LoadSettings", ex.Message, ex.StackTrace);
                Environment.Exit(0);
            }
        }

        private static void RestartInSafeMode()
        {
            Utilities.RunCommand("bcdedit /set {current} safeboot Minimal");
            Thread.Sleep(500);
            Utilities.Reboot();

            Environment.Exit(0);
        }

        private static void RestartInNormalMode()
        {
            Utilities.RunCommand("bcdedit /deletevalue {current} safeboot");
            Thread.Sleep(500);
            Utilities.Reboot();

            Environment.Exit(0);
        }

        private static void DisableDefenderInSafeMode()
        {
            File.WriteAllText("DisableDefenderSafeMode.bat", Properties.Resources.DisableDefenderSafeMode1903Plus);

            Utilities.RunBatchFile("DisableDefenderSafeMode.bat");
            Thread.Sleep(1000);
            Utilities.RunBatchFile("DisableDefenderSafeMode.bat");
            Thread.Sleep(1000);

            File.Delete("DisableDefenderSafeMode.bat");
        }

        private static void EnableDefenderInSafeMode()
        {
            File.WriteAllText("EnableDefenderSafeMode.bat", Properties.Resources.EnableDefenderSafeMode1903Plus);

            Utilities.RunBatchFile("EnableDefenderSafeMode.bat");
            Thread.Sleep(1000);
            Utilities.RunBatchFile("EnableDefenderSafeMode.bat");
            Thread.Sleep(1000);

            File.Delete("EnableDefenderSafeMode.bat");
        }

        private static void StartMainForm()
        {
            LoadSettings();
            StartSplashForm();

            _MainForm = new MainForm(_SplashForm);
            _MainForm.Load += MainForm_Load;
            Application.Run(_MainForm);
        }

        private static void StartMainForm(bool[] codes)
        {
            LoadSettings();
            StartSplashForm();

            _MainForm = new MainForm(_SplashForm, codes[0], codes[1], codes[2], codes[3], codes[4], codes[5], codes[6], codes[7]);
            _MainForm.Load += MainForm_Load;
            Application.Run(_MainForm);
        }

        private static void StartSplashForm()
        {
            _SplashForm = new SplashForm();
            var splashThread = new Thread(new ThreadStart(
                () => Application.Run(_SplashForm)));

            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();
        }

        private static void MainForm_Load(object sender, EventArgs e)
        {
            if (_SplashForm != null && !_SplashForm.Disposing && !_SplashForm.IsDisposed)
                _SplashForm.Invoke(new Action(() => _SplashForm.Close()));

            _MainForm.TopMost = true;
            _MainForm.Activate();
            _MainForm.TopMost = false;
        }

        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }
    }
}
