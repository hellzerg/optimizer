using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimizer
{
    public enum LogType
    {
        Information,
        Error,
    }

    public enum WindowsVersion
    {
        Unsupported,
        Windows7,
        Windows8,
        Windows10,
        WindowsServer2008,
        WindowsServer2012,
        WindowsServer2016
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

    public enum MessagerType
    {
        Error,
        Optimize,
        Startup,
        Restart,
        Hosts,
        Integrator
    }

    public enum DesktopItemType
    {
        Program,
        Folder,
        Link,
        File,
        Command
    }

    public enum DesktopTypePosition
    {
        Top,
        Middle,
        Bottom
    }

    public enum Theme
    {
        Zerg,
        Ocean,
        Caramel,
        Magma,
        Lime,
        Minimal
    }

    public enum RecycleFlag : int
    {
        SHERB_NOCONFIRMATION = 0x00000001, // No confirmation, when emptying
        SHERB_NOPROGRESSUI = 0x00000001, // No progress tracking window during the emptying of the recycle bin
        SHERB_NOSOUND = 0x00000004 // No sound when the emptying of the recycle bin is complete
    }
}
