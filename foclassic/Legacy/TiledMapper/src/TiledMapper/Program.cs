using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TiledMapper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FOCommon.Utils.InitLog("TiledMapper.log", true);
            Config.Init();
            PresetsManager.Init();
            FOCommon.Utils.Log("Tiled Mapper " + Config.AppVersion + " started.");
            Application.Run(new MainForm(args));
        }
    }
}
