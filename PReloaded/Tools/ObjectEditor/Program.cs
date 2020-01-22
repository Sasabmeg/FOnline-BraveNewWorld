using System;
using System.Collections.Generic;
using System.Windows.Forms;

// FOnline ObjectEditor
// Coded by Ghosthack, developer of FOnline: 2238
// Original tool by cvet
// http://fonline.ru
// http://fonline2238.net

namespace ObjectEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
