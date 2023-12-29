using Newtonsoft.Json;
using System;

namespace Optimizer {
    [Serializable]
    public sealed class SilentConfig {
        [JsonProperty("WindowsVersion", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        public int WindowsVersion { get; set; }

        [JsonProperty("PostAction", NullValueHandling = NullValueHandling.Ignore)]
        public PostAction PostAction { get; set; }

        [JsonProperty("Cleaner", NullValueHandling = NullValueHandling.Ignore)]
        public Cleaner Cleaner { get; set; }

        [JsonProperty("Pinger", NullValueHandling = NullValueHandling.Ignore)]
        public Pinger Pinger { get; set; }

        [JsonProperty("ProcessControl", NullValueHandling = NullValueHandling.Ignore)]
        public ProcessControl ProcessControl { get; set; }

        [JsonProperty("HostsEditor", NullValueHandling = NullValueHandling.Ignore)]
        public HostsEditor HostsEditor { get; set; }

        [JsonProperty("RegistryFix", NullValueHandling = NullValueHandling.Ignore)]
        public RegistryFix RegistryFix { get; set; }

        [JsonProperty("Integrator", NullValueHandling = NullValueHandling.Ignore)]
        public Integrator Integrator { get; set; }

        [JsonProperty("Tweaks", NullValueHandling = NullValueHandling.Ignore)]
        public Tweaks Tweaks { get; set; }

        [JsonProperty("AdvancedTweaks", NullValueHandling = NullValueHandling.Ignore)]
        public AdvancedTweaks AdvancedTweaks { get; set; }
    }

    [Serializable]
    public sealed class AdvancedTweaks {
        [JsonProperty("DisableHPET", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableHPET { get; set; }

        [JsonProperty("EnableLoginVerbose", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableLoginVerbose { get; set; }

        [JsonProperty("UnlockAllCores", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UnlockAllCores { get; set; }

        [JsonProperty("SvchostProcessSplitting", NullValueHandling = NullValueHandling.Ignore)]
        public SvchostProcessSplitting SvchostProcessSplitting { get; set; }
    }

    [Serializable]
    public sealed class Cleaner {
        [JsonProperty("TempFiles", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TempFiles { get; set; }

        [JsonProperty("BsodDumps", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BsodDumps { get; set; }

        [JsonProperty("ErrorReports", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ErrorReports { get; set; }

        [JsonProperty("RecycleBin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RecycleBin { get; set; }

        [JsonProperty("GoogleChrome", NullValueHandling = NullValueHandling.Ignore)]
        public BaseBrowser GoogleChrome { get; set; }

        [JsonProperty("MozillaFirefox", NullValueHandling = NullValueHandling.Ignore)]
        public BaseBrowser MozillaFirefox { get; set; }

        [JsonProperty("MicrosoftEdge", NullValueHandling = NullValueHandling.Ignore)]
        public BaseBrowser MicrosoftEdge { get; set; }

        [JsonProperty("BraveBrowser", NullValueHandling = NullValueHandling.Ignore)]
        public BaseBrowser BraveBrowser { get; set; }

        [JsonProperty("InternetExplorer", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InternetExplorer { get; set; }
    }

    [Serializable]
    public sealed class BaseBrowser {
        [JsonProperty("Cache", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cache { get; set; }

        [JsonProperty("Cookies", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cookies { get; set; }

        [JsonProperty("History", NullValueHandling = NullValueHandling.Ignore)]
        public bool? History { get; set; }

        [JsonProperty("Session", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Session { get; set; }

        [JsonProperty("Passwords", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Passwords { get; set; }
    }

    [Serializable]
    public sealed class HostsEditor {
        [JsonProperty("Block", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Block { get; set; }

        [JsonProperty("Remove", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Remove { get; set; }

        [JsonProperty("Add", NullValueHandling = NullValueHandling.Ignore)]
        public AddHostsEntry[] Add { get; set; }

        [JsonProperty("IncludeWwwCname", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeWwwCname { get; set; }
    }

    [Serializable]
    public sealed class AddHostsEntry {
        [JsonProperty("Domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        [JsonProperty("IPAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }
    }

    [Serializable]
    public sealed class Integrator {
        [JsonProperty("TakeOwnership", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TakeOwnership { get; set; }

        [JsonProperty("OpenWithCMD", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OpenWithCmd { get; set; }
    }

    [Serializable]
    public sealed class Pinger {
        [JsonProperty("SetDNS", NullValueHandling = NullValueHandling.Ignore)]
        public string SetDns { get; set; }

        [JsonProperty("FlushDNSCache", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FlushDnsCache { get; set; }

        [JsonProperty("CustomDNSv4", NullValueHandling = NullValueHandling.Ignore)]
        public string[] CustomDNSv4 { get; set; }

        [JsonProperty("CustomDNSv6", NullValueHandling = NullValueHandling.Ignore)]
        public string[] CustomDNSv6 { get; set; }
    }

    [Serializable]
    public sealed class PostAction {
        [JsonProperty("Restart", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Restart { get; set; }

        [JsonProperty("RestartType", NullValueHandling = NullValueHandling.Ignore)]
        public string RestartType { get; set; }
    }

    [Serializable]
    public sealed class ProcessControl {
        [JsonProperty("Prevent", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Prevent { get; set; }

        [JsonProperty("Allow", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Allow { get; set; }
    }

    [Serializable]
    public sealed class RegistryFix {
        [JsonProperty("TaskManager", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TaskManager { get; set; }

        [JsonProperty("CommandPrompt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CommandPrompt { get; set; }

        [JsonProperty("ControlPanel", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ControlPanel { get; set; }

        [JsonProperty("FolderOptions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FolderOptions { get; set; }

        [JsonProperty("RunDialog", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RunDialog { get; set; }

        [JsonProperty("RightClickMenu", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RightClickMenu { get; set; }

        [JsonProperty("WindowsFirewall", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WindowsFirewall { get; set; }

        [JsonProperty("RegistryEditor", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RegistryEditor { get; set; }
    }

    [Serializable]
    public sealed class SvchostProcessSplitting {
        [JsonProperty("Disable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disable { get; set; }

        [JsonProperty("RAM", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ram { get; set; }
    }

    [Serializable]
    public sealed class Tweaks {
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

        public bool? DisableEdgeDiscoverBar { get; set; }
        public bool? DisableEdgeTelemetry { get; set; }

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
        public bool? RestoreClassicPhotoViewer { get; set; }

        public bool? DisableOneDrive { get; set; }

        public bool? TaskbarToLeft { get; set; }
        public bool? DisableSnapAssist { get; set; }
        public bool? DisableWidgets { get; set; }
        public bool? DisableChat { get; set; }
        public bool? ClassicMenu { get; set; }
        public bool? DisableTPMCheck { get; set; }
        public bool? CompactMode { get; set; }
        public bool? DisableStickers { get; set; }
        public bool? DisableVirtualizationBasedTechnology { get; set; }
        public bool? DisableCoPilotAI { get; set; }
    }
}
