using System;
using System.Drawing;

namespace Optimizer {
    [Serializable]
    public sealed class Options {
        /// <summary>
        /// Represents the theme color in RGB
        /// </summary>
        public Color Theme { get; set; }

        /// <summary>
        /// The folder in which the apps are downloaded from Apps tool
        /// </summary>
        public string AppsFolder { get; set; }

        /// <summary>
        /// Configures if the app will appear in the taskbar icons
        /// </summary>
        public bool EnableTray { get; set; }

        /// <summary>
        /// Configures if the app will start with Windows
        /// </summary>
        public bool AutoStart { get; set; }

        /// <summary>
        /// The DNS that the app will use for checking the internet connectivity
        /// </summary>
        public string InternalDNS { get; set; }

        /// <summary>
        /// Configures if the app will check for updates automatically on each run
        /// </summary>
        public bool UpdateOnLaunch { get; set; }

        /// <summary>
        /// Each option from this section will completely disable the respective tool (useful for troubleshooting)
        /// </summary>
        public bool DisableIndicium { get; set; }
        public bool DisableAppsTool { get; set; }
        public bool DisableHostsEditor { get; set; }
        public bool DisableUWPApps { get; set; }
        public bool DisableStartupTool { get; set; }
        public bool DisableCleaner { get; set; }
        public bool DisableIntegrator { get; set; }
        public bool DisablePinger { get; set; }

        /// <summary>
        /// Telemetry-related info, unique to each instance
        /// </summary>
        //public string TelemetryClientID { get; set; }
        //public bool DisableOptimizerTelemetry { get; set; }

        /// <summary>
        /// The saved language of the app
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// The state of the general tweaks
        /// Changing them will not disable/enable the respective tweak
        /// </summary>
        public bool EnablePerformanceTweaks { get; set; }
        public bool DisableNetworkThrottling { get; set; }
        public bool DisableWindowsDefender { get; set; }
        public bool DisableSystemRestore { get; set; }
        public bool DisablePrintService { get; set; }
        public bool DisableMediaPlayerSharing { get; set; }
        public bool DisableErrorReporting { get; set; }
        public bool DisableHomeGroup { get; set; }
        public bool DisableSuperfetch { get; set; }
        public bool DisableTelemetryTasks { get; set; }
        public bool DisableCompatibilityAssistant { get; set; }
        public bool DisableFaxService { get; set; }
        public bool DisableSmartScreen { get; set; }
        public bool DisableCloudClipboard { get; set; }
        public bool DisableStickyKeys { get; set; }
        public bool DisableHibernation { get; set; }
        public bool DisableSMB1 { get; set; }
        public bool DisableSMB2 { get; set; }
        public bool DisableNTFSTimeStamp { get; set; }
        public bool DisableSearch { get; set; }

        /// <summary>
        /// The state of the apps telemetry tweaks
        /// Changing them will not disable/enable the respective tweak
        /// </summary>
        public bool DisableOffice2016Telemetry { get; set; }
        public bool DisableVisualStudioTelemetry { get; set; }
        public bool DisableFirefoxTemeletry { get; set; }
        public bool DisableChromeTelemetry { get; set; }
        public bool DisableNVIDIATelemetry { get; set; }

        /// <summary>
        /// The state of the Edge-related tweaks
        /// Changing them will not disable/enable the respective tweak
        /// </summary>
        public bool DisableEdgeDiscoverBar { get; set; }
        public bool DisableEdgeTelemetry { get; set; }

        /// <summary>
        /// The state of the Windows 8/8.1 tweaks
        /// Changing them will not disable/enable the respective tweak
        /// </summary>
        public bool DisableOneDrive { get; set; }

        /// <summary>
        /// The state of the Windows 10 tweaks
        /// Changing them will not disable/enable the respective tweak
        /// </summary>
        public bool EnableLegacyVolumeSlider { get; set; }
        public bool DisableQuickAccessHistory { get; set; }
        public bool DisableStartMenuAds { get; set; }
        public bool UninstallOneDrive { get; set; }
        public bool DisableMyPeople { get; set; }
        public bool DisableAutomaticUpdates { get; set; }
        public bool ExcludeDrivers { get; set; }
        public bool DisableTelemetryServices { get; set; }
        public bool DisablePrivacyOptions { get; set; }
        public bool DisableCortana { get; set; }
        public bool DisableSensorServices { get; set; }
        public bool DisableWindowsInk { get; set; }
        public bool DisableSpellingTyping { get; set; }
        public bool DisableXboxLive { get; set; }
        public bool DisableGameBar { get; set; }
        public bool DisableInsiderService { get; set; }
        public bool DisableStoreUpdates { get; set; }
        public bool EnableLongPaths { get; set; }
        public bool RemoveCastToDevice { get; set; }
        public bool EnableGamingMode { get; set; }
        public bool RestoreClassicPhotoViewer { get; set; }

        /// <summary>
        /// The state of the Windows 11 tweaks
        /// Changing them will not disable/enable the respective tweak
        /// </summary>
        public bool TaskbarToLeft { get; set; }
        public bool DisableSnapAssist { get; set; }
        public bool DisableWidgets { get; set; }
        public bool DisableChat { get; set; }
        public bool ClassicMenu { get; set; }
        public bool DisableTPMCheck { get; set; }
        public bool CompactMode { get; set; }
        public bool DisableStickers { get; set; }
        public bool DisableVBS { get; set; }
        public bool DisableCoPilotAI { get; set; }

        /// <summary>
        /// The state of the advanced tweaks
        /// Changing them will not disable/enable the respective tweak
        /// </summary>
        public bool DisableHPET { get; set; }
        public bool EnableLoginVerbose { get; set; }
    }
}
