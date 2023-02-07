namespace Optimizer
{
    internal enum LogType
    {
        Information,
        Error,
    }

    internal enum WindowsVersion
    {
        Unsupported,
        Windows7,
        Windows8,
        Windows10,
        Windows11
    }

    public enum StartupItemLocation
    {
        Folder,
        HKLM,
        HKLMWoW,
        HKCU
    }

    public enum StartupItemType
    {
        None,
        Run,
        RunOnce
    }

    internal enum MessageType
    {
        Error,
        Startup,
        Restart,
        Hosts,
        Integrator
    }

    internal enum DesktopItemType
    {
        Program,
        Folder,
        Link,
        File,
        Command
    }

    internal enum DesktopTypePosition
    {
        Top,
        Middle,
        Bottom
    }

    internal enum RecycleFlag : int
    {
        SHERB_NOCONFIRMATION = 0x00000001,
        SHERB_NOPROGRESSUI = 0x00000001,
        SHERB_NOSOUND = 0x00000004
    }

    public enum ToggleSwitchAlignment
    {
        Near,
        Center,
        Far
    }

    public enum ToggleSwitchButtonAlignment
    {
        Left,
        Center,
        Right
    }

    public enum LanguageCode
    {
        EN, // english
        RU, // russian
        EL, // hellenic
        TR, // turkish
        DE, // german
        ES, // spanish
        PT,  // portuguese
        FR, // french
        IT, // italian
        CN, // chinese
        CZ, // czech
        TW, // taiwan
        KO, // korean
        PL, // polish
        AR, // arabic
        KU, // kurdish
        HU, // hungarian
        RO, // romanian
        NL, // dutch
        UA, // ukrainian
        JA // japanese
    }
}
