using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using FOCommon.Parsers;

namespace TiledMapper
{
    /// <summary>
    /// The class containing all configurable variables.
    /// </summary>
    public static class Config
    {
        public static int GridSize = 25;
        public static int LineSize = 5;
        public static int WallSize = 1;

        public static int WidePadding = 2;
        public static int WallPadding = 5;

        public static Font Font = new Font("Lucida Console", 8.25f, FontStyle.Regular);

        public static string PresetsPath = "";
        public static string CurrentPreset = "";
        public static bool NeverShowHeaderForm = false;

        public static List<string> Presets;

        public static Color BackgroundColor = Color.White;
        public static Color LineColor = Color.LightGray;
        public static Color BlockColor = Color.Red;
        public static Color TileColor = Color.Black;

        public static Color ScrollblockerTextColor = Color.CadetBlue;
        public static Color VariantTextColor = Color.DarkGray;
        public static Color WallColor = Color.Red;

        public static string Module = "";
        public static string Function = "";
        public static string Time = "-1";
        public static string DayTime = "300  600  1140 1380";
        public static string DayColor0 = "18  18  53 ";
        public static string DayColor1 = "128 128 128";
        public static string DayColor2 = "103 95  86 ";
        public static string DayColor3 = "51  40  29 ";
        public static bool NoLogOut = false;

        // this is hardcoded
        public const ushort BigTileEdgeSize = 10;
        public const ushort ScrollblockerPID = 4012;
        public const string MapVersion = "1.1";
        public const string AppVersion = "1.0.1";

        /// <summary>
        /// Initialize the config. It will demand to provide the presets path.
        /// </summary>
        public static void Init()
        {
            if (File.Exists(getConfigPath()))
            {
                Load();
            }
            else
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                dlg.Description = "Select the path for the tile presets.";
                dlg.ShowDialog();

                PresetsPath = dlg.SelectedPath;
                Save();
            }

            if (string.IsNullOrEmpty(PresetsPath))
            {
                MessageBox.Show(null, "Invalid preset path. The program will close now.", "No presets path!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            if (!File.Exists(PresetsPath + @"\block.txt"))
            {
                MessageBox.Show(null, "The block.txt file is missing from the preset path. The program will close now.", "Missing block.txt!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(2);
            }

            RefreshPresets();

            if (!Presets.Contains(CurrentPreset))
                CurrentPreset = "";
        }

        /// <summary>
        /// Refreshes the presets list.
        /// </summary>
        public static void RefreshPresets()
        {
            Presets = new List<string>(Directory.GetFiles(PresetsPath, "*.fomap"));
            for (int i = 0; i < Presets.Count; i++) Presets[i] = Path.GetFileName(Presets[i]);
        }

        /// <summary>
        /// Loads the settings from the ini file.
        /// </summary>
        public static void Load()
        {
            IniReader ini = new IniReader(getConfigPath());

            // Appearance
            GridSize = ini.IniReadValueInt("Appearance", "GridSize");
            LineSize = ini.IniReadValueInt("Appearance", "LineSize");
            WallSize = ini.IniReadValueInt("Appearance", "WallSize");

            WidePadding = ini.IniReadValueInt("Appearance", "WidePadding");
            WallPadding = ini.IniReadValueInt("Appearance", "WallPadding");

            string fontName = ini.IniReadValue("Appearance", "Font");
            float fontSize = ini.IniReadValueFloat("Appearance", "FontSize");
            FontStyle fontMods = (FontStyle)(ini.IniReadValueInt("Appearance", "FontStyle"));
            Config.Font = new Font(fontName, fontSize, fontMods);

            BackgroundColor = Color.FromArgb(ini.IniReadValueHexInt("Appearance", "BackgroundColor"));
            LineColor = Color.FromArgb(ini.IniReadValueHexInt("Appearance", "LineColor"));
            BlockColor = Color.FromArgb(ini.IniReadValueHexInt("Appearance", "BlockColor"));
            TileColor = Color.FromArgb(ini.IniReadValueHexInt("Appearance", "TileColor"));

            ScrollblockerTextColor = Color.FromArgb(ini.IniReadValueHexInt("Appearance", "ScrollblockerTextColor"));
            VariantTextColor = Color.FromArgb(ini.IniReadValueHexInt("Appearance", "VariantTextColor"));
            WallColor = Color.FromArgb(ini.IniReadValueHexInt("Appearance", "WallColor"));

            // Compiler
            PresetsPath = ini.IniReadValue("Compiler", "PresetsPath");
            CurrentPreset = ini.IniReadValue("Compiler", "CurrentPreset");
            NeverShowHeaderForm = ini.IniReadValueBool("Compiler", "NeverShowHeaderForm");

            // header
            Module = ini.IniReadValue("Header", "Module");
            Function = ini.IniReadValue("Header", "Function");
            Time = ini.IniReadValue("Header", "Time");
            DayTime = ini.IniReadValue("Header", "DayTime");
            DayColor0 = ini.IniReadValue("Header", "DayColor0");
            DayColor1 = ini.IniReadValue("Header", "DayColor1");
            DayColor2 = ini.IniReadValue("Header", "DayColor2");
            DayColor3 = ini.IniReadValue("Header", "DayColor3");
            NoLogOut = ini.IniReadValueBool("Header", "NoLogOut");

            clamp<int>(ref GridSize, 1, 100);
            clamp<int>(ref LineSize, 1, 100);
            clamp<int>(ref WallSize, 1, 100);
            clamp<int>(ref WidePadding, 1, 100);
            clamp<int>(ref WallPadding, 1, 100);
        }

        /// <summary>
        /// Saves the settings to the ini file.
        /// </summary>
        public static void Save()
        {
            IniReader ini = new IniReader(getConfigPath());
            // Appearance
            ini.IniWriteValue("Appearance", "GridSize", GridSize.ToString());
            ini.IniWriteValue("Appearance", "LineSize", LineSize.ToString());
            ini.IniWriteValue("Appearance", "WallSize", WallSize.ToString());

            ini.IniWriteValue("Appearance", "WidePadding", WidePadding.ToString());
            ini.IniWriteValue("Appearance", "WallPadding", WallPadding.ToString());

            ini.IniWriteValue("Appearance", "Font", Font.Name);
            ini.IniWriteValue("Appearance", "FontSize", Font.Size.ToString());
            ini.IniWriteValue("Appearance", "FontStyle", Font.Style.ToString());

            ini.IniWriteValueHexInt("Appearance", "BackgroundColor", BackgroundColor.ToArgb());
            ini.IniWriteValueHexInt("Appearance", "LineColor", LineColor.ToArgb());
            ini.IniWriteValueHexInt("Appearance", "BlockColor", BlockColor.ToArgb());
            ini.IniWriteValueHexInt("Appearance", "TileColor", TileColor.ToArgb());

            ini.IniWriteValueHexInt("Appearance", "ScrollblockerTextColor", ScrollblockerTextColor.ToArgb());
            ini.IniWriteValueHexInt("Appearance", "VariantTextColor", VariantTextColor.ToArgb());
            ini.IniWriteValueHexInt("Appearance", "WallColor", WallColor.ToArgb());

            // Compiler
            ini.IniWriteValue("Compiler", "PresetsPath", PresetsPath.ToString());
            ini.IniWriteValue("Compiler", "CurrentPreset", CurrentPreset.ToString());
            ini.IniWriteValueBool("Compiler", "NeverShowHeaderForm", NeverShowHeaderForm);

            // Header
            ini.IniWriteValue("Header", "Module", Module);
            ini.IniWriteValue("Header", "Function", Function);
            ini.IniWriteValue("Header", "Time", Time);
            ini.IniWriteValue("Header", "DayTime", DayTime);
            ini.IniWriteValue("Header", "DayColor0", DayColor0);
            ini.IniWriteValue("Header", "DayColor1", DayColor1);
            ini.IniWriteValue("Header", "DayColor2", DayColor2);
            ini.IniWriteValue("Header", "DayColor3", DayColor3);
            ini.IniWriteValueBool("Header", "NoLogOut", NoLogOut);
        }

        private static string getConfigPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "TiledMapper.cfg";
        }

        static void clamp<T>(ref T v, T min, T max) where T : System.IComparable<T>
        {
            if (v.CompareTo(min) < 0) v = min;
            else if (v.CompareTo(max) > 0) v = max;
        }
    }
}
