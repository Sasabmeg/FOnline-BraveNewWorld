using System;

namespace ObjectEditor
{
    public class Config : FOCommon.Config
    {
        public int WindowSizeX;
        public int WindowSizeY;
        public int WindowLocationX;
        public int WindowLocationY;
        public string PathGraphics; // For item graphics
        public string PathDataFolder; // [server_root]/data
        public string PathObjMsg; // FOOBJ.MSG
        public string PathDefines; // _defines.fos
        public string PathDefinesFOClassic; // FOClassic.fos
        public string PathLanguage; // *.lang
        public string PathEditorScript;
        public bool TranslateLanguage;
        public bool LoadGraphics;
        public bool LockTabs;
        public bool SwitchTab;
        public bool StripPrefix;
        public bool ResizeOnResize;
        public bool ShowItemPidDefine;
        public bool ShowWholeFilePath;
        public bool ItemPidDefineBeforeId;
        public bool FormatWithSpace;
        public bool ScriptingEnabled;

        public Config(String ConfigName)
            : base(ConfigName)
        {
            
            AddConfigItem(false, "Paths",  "NamesFolder",           "PathDataFolder",        ".\\data\\");
            AddConfigItem(false, "Paths",  "Scripts",               "PathEditorScript",      ".\\scripts\\");
            AddConfigItem(false, "Paths",  "ObjMsg",                "PathObjMsg",            "FOOBJ.MSG");
            AddConfigItem(false, "Paths",  "Defines",               "PathDefines",           "_defines.fos");
            AddConfigItem(false, "Paths",  "DefinesFOClassic",      "PathDefinesFOClassic",  "FOClassic.fos");
            AddConfigItem(true,  "Paths",  "Language",              "PathLanguage",          "");
            AddConfigItem(true,  "Paths",  "Graphics",              "PathGraphics",          "");
            AddConfigItem(true,  "Misc",   "LoadGraphics",          "LoadGraphics",          false);
            AddConfigItem(true,  "Misc",   "LockTabs",              "LockTabs",              false);
            AddConfigItem(true,  "Misc",   "SwitchTab",             "SwitchTab",             true);
            AddConfigItem(true,  "Misc",   "TranslateLanguage",     "TranslateLanguage",     false);
            AddConfigItem(true,  "Misc",   "StripPrefix",           "StripPrefix",           true);
            AddConfigItem(true,  "Misc",   "ResizeOnWindowResize",  "ResizeOnResize",        true);
            AddConfigItem(true,  "Misc",   "ShowItemPidDefine",     "ShowItemPidDefine",     false);
            AddConfigItem(true,  "Misc",   "ShowWholeFilePath",     "ShowWholeFilePath",     false);
            AddConfigItem(true,  "Misc",   "ItemPidDefineBeforeId", "ItemPidDefineBeforeId", false);
            AddConfigItem(true,  "Misc",   "FormatWithSpace",       "FormatWithSpace",       false);
            AddConfigItem(true,  "Scripting", "Enabled",            "ScriptingEnabled",      false);
            AddConfigItem(true,  "Window", "WindowLocationX",       "WindowLocationX",       200);
            AddConfigItem(true,  "Window", "WindowLocationY",       "WindowLocationY",       200);
            AddConfigItem(true,  "Window", "WindowSizeX",           "WindowSizeX",           800);
            AddConfigItem(true,  "Window", "WindowSizeY",           "WindowSizeY",           600);
        }
    }
}
