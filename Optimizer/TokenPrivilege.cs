using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Optimizer
{
    /*
     *  Allows clients to obtain a Windows token privilege for a well-defined scope simply by "using" an instance of this class.
     */
    sealed class TokenPrivilege : IDisposable
    {
        private enum PrivilegeAction : uint
        {
            Disable = 0x0,
            Enable = 0x2
        }

        public static TokenPrivilege Backup => new TokenPrivilege("SeBackupPrivilege");
        public static TokenPrivilege Restore => new TokenPrivilege("SeRestorePrivilege");
        public static TokenPrivilege TakeOwnership => new TokenPrivilege("SeTakeOwnershipPrivilege");

        private readonly string privilegeName;

        private TokenPrivilege(string privilegeName)
        {
            this.privilegeName = privilegeName;
            Apply(PrivilegeAction.Enable);
        }

        private void Apply(PrivilegeAction action)
        {
            OpenProcessToken(GetCurrentProcess(), TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, out IntPtr tokenHandle);
            LookupPrivilegeValue(null, privilegeName, out Luid luid);
            var tokenPrivilege = new TokenPrivileges(luid, (uint)action);
            UpdateTokenPrivileges(tokenHandle, tokenPrivilege);
        }

        private void UpdateTokenPrivileges(IntPtr tokenHandle, TokenPrivileges privilegeInfo)
        {
            bool successful = AdjustTokenPrivileges(tokenHandle, false, ref privilegeInfo, 0, IntPtr.Zero, IntPtr.Zero);
            if (!successful || Marshal.GetLastWin32Error() == ERROR_NOT_ALL_ASSIGNED)
                throw new SecurityException($"Can't adjust token privilege {privilegeName}");
        }

        public void Dispose()
        {
            Apply(PrivilegeAction.Disable);
        }

        #region P/Invoke structs and methods
        private const int ERROR_NOT_ALL_ASSIGNED = 1300;

        [StructLayout(LayoutKind.Sequential)]
        private struct TokenPrivileges
        {
            // We can use this struct only with one privilege since CLR doesn't support marshalling dynamic-sized arrays
            public TokenPrivileges(Luid luid, uint attributes)
            {
                Count = 1;
                Privileges = new[] {
                    new LuidAndAttributes(luid, attributes)
                };
            }

            private uint Count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
            private LuidAndAttributes[] Privileges;
        }

        [StructLayout(LayoutKind.Sequential)]
        private readonly struct LuidAndAttributes
        {
            public LuidAndAttributes(Luid luid, uint attributes)
            {
                Luid = luid;
                Attributes = attributes;
            }

            private readonly Luid Luid;
            private readonly uint Attributes;
        }

        [StructLayout(LayoutKind.Sequential)]
        private readonly struct Luid
        {
            private readonly uint LowPart;
            private readonly int HighPart;
        }

        private const int TOKEN_QUERY = 0x8;
        private const int TOKEN_ADJUST_PRIVILEGES = 0x20;

        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool AdjustTokenPrivileges(IntPtr tokenHandle,
                                                         bool disableAllPrivileges,
                                                         ref TokenPrivileges newState,
                                                         int bufferLength,
                                                         IntPtr previousState,
                                                         IntPtr returnLength);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetCurrentProcess();

        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool OpenProcessToken(IntPtr processHandle, int desiredAccess, out IntPtr tokenHandle);

        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool LookupPrivilegeValue(string systemName, string privilegeName, out Luid privilegeLuid);
        #endregion
    }
}
