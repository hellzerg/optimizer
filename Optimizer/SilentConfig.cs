using System;

namespace Optimizer
{
    [Serializable]
    public sealed class SilentConfig
    {
        public int WindowsVersion { get; set; }

        public bool? EnablePerformanceTweaks { get; set; }
        public bool? DisableNetworkThrottling { get; set; }
        public bool? DisableWindowsDefender { get; set; }
        public bool? DisableSystemRestore { get; set; }
        public bool? DisablePrintService { get; set; }
        public bool? DisableMediaPlayerSharing { get; set; }
        public bool? DisableErrorReporting { get; set; }
        public bool? DisableHomeGroup { get; set; }
        public bool? DisableSuperfetch { get; set; }
        public bool? DisableTelemetryTasks { get; set; }
        public bool? DisableCompatibilityAssistant { get; set; }
        public bool? DisableFaxService { get; set; }
        public bool? DisableSmartScreen { get; set; }
        public bool? DisableCloudClipboard { get; set; }
        public bool? DisableStickyKeys { get; set; }
        public bool? DisableHibernation { get; set; }
        public bool? DisableSMB1 { get; set; }
        public bool? DisableSMB2 { get; set; }
        public bool? DisableNTFSTimeStamp { get; set; }
        public bool? DisableSearch { get; set; }

        public bool? DisableOffice2016Telemetry { get; set; }
        public bool? DisableVisualStudioTelemetry { get; set; }
        public bool? DisableFirefoxTemeletry { get; set; }
        public bool? DisableChromeTelemetry { get; set; }
        public bool? DisableNVIDIATelemetry { get; set; }

        public bool? EnableLegacyVolumeSlider { get; set; }
        public bool? DisableQuickAccessHistory { get; set; }
        public bool? DisableStartMenuAds { get; set; }
        public bool? UninstallOneDrive { get; set; }
        public bool? DisableMyPeople { get; set; }
        public bool? DisableAutomaticUpdates { get; set; }
        public bool? ExcludeDrivers { get; set; }
        public bool? DisableTelemetryServices { get; set; }
        public bool? DisablePrivacyOptions { get; set; }
        public bool? DisableCortana { get; set; }
        public bool? DisableSensorServices { get; set; }
        public bool? DisableWindowsInk { get; set; }
        public bool? DisableSpellingTyping { get; set; }
        public bool? DisableXboxLive { get; set; }
        public bool? DisableGameBar { get; set; }
        public bool? DisableInsiderService { get; set; }
        public bool? DisableStoreUpdates { get; set; }
        public bool? EnableLongPaths { get; set; }
        public bool? RemoveCastToDevice { get; set; }
        public bool? EnableGamingMode { get; set; }

        public bool? DisableOneDrive { get; set; }

        public bool? TaskbarToLeft { get; set; }
        public bool? DisableSnapAssist { get; set; }
        public bool? DisableWidgets { get; set; }
        public bool? DisableChat { get; set; }
        public bool? TaskbarSmaller { get; set; }
        public bool? ClassicRibbon { get; set; }
        public bool? ClassicMenu { get; set; }
        public bool? DisableTPMCheck { get; set; }
        public bool? CompactMode { get; set; }
        public bool? DisableStickers { get; set; }
        public bool? DisableVBS { get; set; }
    }
}
