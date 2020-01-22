using System.Drawing;
using System.Runtime.InteropServices;

namespace WorldEditor.Debug
{
    class DebugManager
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern bool FreeConsole();

        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;


        public DebugManager(string version)
        {
            frmShell Debug = new frmShell(version, true);
            Debug.Show();
            Debug.Text = "Debug";
            var csl = Debug.GetConsole();
            csl.ForeColor = Color.Orange;
            csl.ReadOnly = true;
            csl.WordWrap = true;

            Debug.GetConsole().RedirectConsole(Debug);
        }
    }
}
