using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace FOCommon.Win32
{
    public static class WinAPI
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        public static bool IsWinVistaOrHigher()
        {
            OperatingSystem OS = Environment.OSVersion;
            return (OS.Platform == PlatformID.Win32NT) && (OS.Version.Major >= 6);
        }

        public static void SetWindowExFlag(IntPtr Handle, int dwNewLong)
        {
            if ((dwNewLong == Win32.WS_EX_COMPOSITED || dwNewLong == Win32.WS_EX_LAYERED) && !IsWinVistaOrHigher())
                return;

            int windowLong = GetWindowLong(Handle, -20);
            SetWindowLong(Handle, -20, windowLong |= (int)dwNewLong);
        }
        public static void UnsetWindowExFlag(IntPtr Handle, int dwNewLong)
        {
            if ((dwNewLong == Win32.WS_EX_COMPOSITED || dwNewLong == Win32.WS_EX_LAYERED) && !IsWinVistaOrHigher())
                return;

            int windowLong = GetWindowLong(Handle, -20);
            SetWindowLong(Handle, -20, windowLong & ~(int)dwNewLong);
        }
    }
}
