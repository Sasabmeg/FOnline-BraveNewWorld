using System;

// TODO: Use same config system as ObjectEditor

namespace WorldEditor
{
    public class Config : FOCommon.Config
    {
        public static bool ZoneShowImplemented;
        public static bool ZoneShowSpecific;
        public static bool ZoneShowModified;

        public static bool CopyFlags;
        public static bool CopyChance;
        public static bool CopyDifficulty;
        public static bool CopyGroups;
        public static bool CopyLocations;
        public static bool CopyTerrain;
        public static bool CopyOverwrite;

        public static string PathWorldmapHeader;
        public static string PathMapsHeader;
        public static string PathCity;
        public static string PathDlg;
        public static string PathGw;
        public static string PathGm;
        public static string PathItemPid;
        public static string PathGame;
        public static string PathDefines;
        public static string PathParamNames;
        public static string PathTownMaps;
        public static string PathArmorProtos;
        public static string PathHelmetProtos;

        public static string PathWorldMapPic;
        public static string PathWorldMap; // worldmap.fowm
        public static string PathWorldMapCompiled; // worldmap.focwm
        public static string PathGroups; // groups.fowm

        public static string PathEditorScript;
        public static string PathMapper;

        public static string BaseProtoFiles;
        public static string ProtoFiles;

        public static string PathBaseDir;
        public static string PathDialogsDir;
        public static string PathScriptsDir;
        public static string PathMapsDir;
        public static string PathTextDir;
        public static string PathExtensionsDir;
        public static string PathCritterProtoDir;
        public static string PathItemProtoDir;
        public static string PathDataDir;

        public static string ColorImplemented;
        public static string ColorFiltered;
        public static string ColorSelected;
        public static string ColorModified;
        public static string ColorBrushed;

        public static bool ShowTooltip;
        public static bool ShowLocations;
        public static bool ShowLocationNames;

        public static bool DebugConsole;
        public static bool AsyncLoading;
        public static bool ScriptingEnabled;

        public static int WindowX;
        public static int WindowY;
        public static int WindowH;
        public static int WindowW;

        public static int ZoneMaxX; // read from define
        public static int ZoneMaxY; // read from define

        public static int WorldmapScale;
        public static int WorldmapZoneSize;


        // TODO: Defaults?
        // TODO: All settings in UI
        public Config(String ConfigName)
            : base(ConfigName)
        {
            // Global            [Group]     Key                      Variable              Default
            AddConfigItem(false, "Path",     "ScriptsDir",            "PathScriptsDir"      ,"");
            AddConfigItem(false, "Path",     "Textdir",               "PathTextDir"         ,"");
            AddConfigItem(false, "Path",     "Mapsdir",               "PathMapsDir"         ,"");
            AddConfigItem(false, "Path",     "Dialogsdir",            "PathDialogsDir"      ,"");
            AddConfigItem(false, "Path",     "ExtensionsDir",         "PathExtensionsDir"   ,"");
            AddConfigItem(false, "Path",     "CritterprotoDir",       "PathCritterProtoDir" ,"");
            AddConfigItem(false, "Path",     "ItemprotoDir",          "PathItemProtoDir"    ,"");
            AddConfigItem(false, "Path",     "DataDir",               "PathDataDir"         ,"");
            AddConfigItem(false, "Path",     "WorldMapPic",           "PathWorldMapPic"     ,"worldmap.png");
            AddConfigItem(false, "Path",     "WorldMapFile",          "PathWorldMap"        ,"");
            AddConfigItem(false, "Path",     "WorldMapFileCompiled",  "PathWorldMapCompiled","");
            AddConfigItem(false, "Path",     "Groups",                "PathGroups"          ,"");
            AddConfigItem(false, "Path",     "WorldMapHeader",        "PathWorldmapHeader"  ,"");
            AddConfigItem(false, "Path",     "MapsHeader",            "PathMapsHeader"      ,"");
            AddConfigItem(false, "Path",     "Itempid",               "PathItemPid"         ,"");
            AddConfigItem(false, "Path",     "Locations",             "PathCity"            ,"");
            AddConfigItem(false, "Path",     "GenerateWorld",         "PathGw"              ,"");
            AddConfigItem(false, "Path",     "FOGM",                  "PathGm"              ,"");
            AddConfigItem(false, "Path",     "FODLG",                 "PathDlg"             ,"");
            AddConfigItem(false, "Path",     "FOGAME",                "PathGame"            ,"");
            AddConfigItem(false, "Path",     "ParamNames",            "PathParamNames"      ,"");
            AddConfigItem(false, "Path",     "Defines",               "PathDefines"         ,"");
            AddConfigItem(false, "Path",     "BaseProtoFiles",        "BaseProtoFiles"      ,"");
            AddConfigItem(false, "Path",     "ProtoFiles",            "ProtoFiles"          ,"");
            AddConfigItem(false, "Path",     "TownGraphics",          "PathTownMaps"        ,"");
            AddConfigItem(false, "Path",     "ArmorProtos",           "PathArmorProtos"     ,"");
            AddConfigItem(false, "Path",     "HelmetProtos",          "PathHelmetProtos"    ,"");
            AddConfigItem(false, "Path",     "EditorScript",          "PathEditorScript"    ,"");

            AddConfigItem(false, "Worldmap", "ZoneSize",              "WorldmapZoneSize"    ,25);
            AddConfigItem(false, "Worldmap", "Scale",                 "WorldmapScale"       ,100);


            // User             [Group]       Key                  Variable               Default
            AddConfigItem(true, "Zone",       "ShowImplemented",   "ZoneShowImplemented", false   );
            AddConfigItem(true, "Zone",       "ShowModified",      "ZoneShowModified"   , true    );
            AddConfigItem(true, "Zone",       "ShowSpecific",      "ZoneShowSpecific"   , false   );
            AddConfigItem(true, "Clone",      "Flags",             "CopyFlags"          , false   );
            AddConfigItem(true, "Clone",      "Chance",            "CopyChance"         , false   );
            AddConfigItem(true, "Clone",      "Difficulty",        "CopyDifficulty"     , false   );
            AddConfigItem(true, "Clone",      "Groups",            "CopyGroups"         , false   );
            AddConfigItem(true, "Clone",      "Locations",         "CopyLocations"      , false   );
            AddConfigItem(true, "Clone",      "Terrain",           "CopyTerrain"        , false   );
            AddConfigItem(true, "Clone",      "Overwrite",         "CopyOverwrite"      , false   );
            AddConfigItem(true, "Color",      "Implemented",       "ColorImplemented"   , "Green"     );
            AddConfigItem(true, "Color",      "Filtered",          "ColorFiltered"      , "DarkKhaki" );
            AddConfigItem(true, "Color",      "Selected",          "ColorSelected"      , "Red"       );
            AddConfigItem(true, "Color",      "Modified",          "ColorModified"      , "White"     );
            AddConfigItem(true, "Color",      "Brushed",           "ColorBrushed"       , "Tomato" );
            AddConfigItem(true, "Misc",       "AsyncLoading",      "AsyncLoading"       , true        );
            AddConfigItem(true, "Misc",       "ShowTooltip",       "ShowTooltip"        , true        );
            AddConfigItem(true, "Misc",       "ShowLocations",     "ShowLocations"      , true        );
            AddConfigItem(true, "Misc",       "ShowLocationNames", "ShowLocationNames"  , true        );
            AddConfigItem(true, "Window",     "X",                 "WindowX"            , 300        );
            AddConfigItem(true, "Window",     "Y",                 "WindowY"            , 300        );
            AddConfigItem(true, "Window",     "Width",             "WindowW"            , 600        );
            AddConfigItem(true, "Window",     "Height",            "WindowH"            , 800        );
            AddConfigItem(true, "Scripting" , "Enabled",           "ScriptingEnabled"   , true);
            AddConfigItem(true, "Debug",      "Console",           "DebugConsole"       , false);
            AddConfigItem(true, "External",   "Mapper",            "PathMapper"         , "");
        }
    }
}
