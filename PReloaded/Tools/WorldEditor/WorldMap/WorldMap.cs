using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using FOCommon.Parsers;
using FOCommon.WMLocation;
using FOCommon.Worldmap;
using FOCommon.Worldmap.EncounterGroup;

namespace WorldEditor
{
    public class WorldMap
    {
        IZone SelectedZone;
        int SelectedZoneX = -1;
        int SelectedZoneY = -1;
        int SelectedIndex;
        List<IZone> Zones = new List<IZone>();
        List<Location> Locations = new List<Location>();

        public FOCommon.Parsers.MSGParser FODLGParser { get; set; }
        public FOCommon.Parsers.MSGParser FOOBJParser { get; set; }
        public FOGMParser GMParser { get; set; }
        public GWParser GWParser { get; set; }
        public FOGAMEParser FOGameParser { get; set; }
        public LocationParser LocParser { get; set; }
        public MapParser MapParser { get; set; }
        public EncounterGroupParser GroupParser { get; set; }
        public DialogListParser DialogListParser { get; set; }
        public ScriptListParser ScriptListParser { get; set; }
        public DefineParser DefineParser { get; set; }
        IWorldMapFormat WMFormat;

        List<IWorldMapDrawable> MapObjects { get; set; }

        public Font ZoneDisplayFont { get; set; }

        string FileName;
        string CompiledFileName;

        public WorldMap(string WorldMapFileName, string CompiledWorldMapFilename, IWorldMapFormat WMFormat)
        {
            FOCommon.Cache.Cache.Load(".\\Cache.dat");

            this.WMFormat              = WMFormat;
            this.FileName              = WorldMapFileName;
            this.CompiledFileName      = CompiledWorldMapFilename;
            this.GMParser              = new FOGMParser(Config.PathGm);
            this.GWParser              = new GWParser(Config.PathGw);
            this.FOGameParser          = new FOGAMEParser(Config.PathGame);
            this.DialogListParser      = new DialogListParser(Config.PathDialogsDir + "/dialogs.cfg");
            this.FODLGParser           = new FOCommon.Parsers.MSGParser(Config.PathDlg);
            this.FOOBJParser           = new FOCommon.Parsers.MSGParser(Config.PathTextDir + " /FOOBJ.MSG");
            this.GroupParser           = new EncounterGroupParser(Config.PathGroups, FOGameParser, DialogListParser, GMParser, FODLGParser);
            this.MapParser             = new MapParser(GMParser, Config.PathMapsDir, Config.PathCity);
            this.ScriptListParser      = new ScriptListParser(Config.PathScriptsDir + "/scripts.cfg");
            this.DefineParser          = new DefineParser(); // worldmap_h and _maps
            this.ZoneDisplayFont       = new Font(FontFamily.GenericMonospace, 10.0f);
            this.LocParser             = new LocationParser(Config.PathCity, MapParser, GWParser, GMParser);

            this.MapObjects            = new List<IWorldMapDrawable>();
        }

        public void Parse()
        {
            // Parse all data...
            if (!this.DefineParser.ReadDefines(Config.PathWorldmapHeader)) Utils.HandleParseError(this.DefineParser.Error, Config.PathWorldmapHeader);
            if (!this.DefineParser.ReadDefines(Config.PathMapsHeader))     Utils.HandleParseError(this.DefineParser.Error, Config.PathMapsHeader);
            if (!this.DefineParser.ReadDefines(Config.PathDefines))        Utils.HandleParseError(this.DefineParser.Error, Config.PathDefines);
            EditorData.LoadDataFromDefines(DefineParser.Defines);
            this.GMParser.Parse();
            this.GWParser.Parse();
            this.FOGameParser.Parse();
            this.DialogListParser.Parse();
            this.FODLGParser.Parse();
            this.FOOBJParser.Parse();
            this.GroupParser.Parse();
            this.MapParser.Parse();
            this.ScriptListParser.Parse();
            LoadZones(GroupParser);
            this.LocParser.Parse();
            Locations = LocParser.GetLocations();
            //MapObjects.AddRange(Locations);
        }

        public List<Location> GetLocations()     { return Locations; }
        public List<EncounterGroup> GetGroups()  { return GroupParser.GetGroups(); }

        public Location GetLocation(int x, int y)
        {
            foreach (Location Loc in Locations)
            {
                if ((x >= Loc.X - Loc.Size && x <= (Loc.X + Loc.Size)) && (y >= Loc.Y - Loc.Size && y <= (Loc.Y + Loc.Size)))
                return Loc;
            }
            return null;
        }

        public void SaveSelected()
        {
            Zones[SelectedIndex] = SelectedZone;
        }

        public void ClearAllBrushed()
        {
            foreach (IZone i in Zones)
            {
                i.Brushed = false;
            }
        }

        public bool MoveSelectedZone(int x, int y)
        {
            IZone zone = GetZone(SelectedZone.X+x, SelectedZone.Y+y);
            if (zone == null)
                return false;
           
            SetSelectedZone(SelectedZone.X + x, SelectedZone.Y + y);
            return true;
        }

        public bool ModifyDifficulty(string value)
        {
            if (SelectedZone == null)
                return false;

            IExtZone ExtZone = (IExtZone)SelectedZone;

            if (ExtZone.Difficulty != Int32.Parse(value))
            {
                ExtZone.Modified = true;
            }

            ExtZone.Difficulty = Int32.Parse(value);
            return true;
        }

        public bool ModifyLocation(List<EncounterZoneLocation> locations)
        {
            if (SelectedZone == null)
                return false;

            IExtZone ExtZone = (IExtZone)SelectedZone;

            if (ExtZone.EncounterLocations != locations)
                SelectedZone.Modified = true;

            ExtZone.EncounterLocations = locations;
            return true;
        }

        public bool ModifyGroups(List<EncounterZoneGroup> groups)
        {
            if (SelectedZone == null)
                return false;

            IExtZone ExtZone = (IExtZone)SelectedZone;

            if (ExtZone.EncounterGroups != groups)
                SelectedZone.Modified = true;

            ExtZone.EncounterGroups = groups;
            return true;
        }

        public bool ModifyChance(string text)
        {
            if (SelectedZone == null)
                return false;

            if (SelectedZone.Chance != text)
                SelectedZone.Modified = true;

            SelectedZone.Chance = text;
            return true;
        }

        public IZone NewZone(int x, int y)
        {
            if (Utils.IsOutOfZoneBoundries(x,y))
                return null;

            IZone zone = new Zone(x, y);

            zone.Chance = EditorData.Chances[0];
            zone.Terrain = EditorData.Terrains[0];
            zone.Fill = "FILL_No_Fill";
            zone.Modified = true;
            return zone;
        }

        public bool ModifySelectedZoneWithBrush(List<EncounterZoneGroup> Groups, List<EncounterZoneLocation> Locations, List<String> Flags, bool add, int chance)
        {
            bool Modified = false;

            Zone ExtZone = (Zone)SelectedZone;

            int GroupCount=0;
            int LocationsCount=0;
            int FlagCount=0;

            if (ExtZone.EncounterGroups == null) ExtZone.EncounterGroups = new List<EncounterZoneGroup>();
            if (ExtZone.EncounterLocations == null) ExtZone.EncounterLocations = new List<EncounterZoneLocation>();
            if (ExtZone.Flags == null) ExtZone.Flags = new List<String>();

            GroupCount = ExtZone.EncounterGroups.Count();
            LocationsCount = ExtZone.EncounterLocations.Count();
            FlagCount = ExtZone.Flags.Count();

            if (add)
            {
                ExtZone.EncounterGroups.AddRange(Groups);
                ExtZone.EncounterLocations.AddRange(Locations);
                ExtZone.Flags.AddRange(Flags);

                ExtZone.EncounterGroups = Utils.RemoveDuplicates<EncounterZoneGroup>(ExtZone.EncounterGroups);
                ExtZone.EncounterLocations = Utils.RemoveDuplicates<EncounterZoneLocation>(ExtZone.EncounterLocations);
                ExtZone.Flags = Utils.RemoveDuplicates<String>(ExtZone.Flags);

            }
            else
            {
                ExtZone.EncounterGroups = ExtZone.EncounterGroups.Except<EncounterZoneGroup>(Groups).ToList();
                ExtZone.EncounterLocations = ExtZone.EncounterLocations.Except<EncounterZoneLocation>(Locations).ToList();
                ExtZone.Flags = ExtZone.Flags.Except<String>(Flags).ToList<String>();
            }

            if(GroupCount != ExtZone.EncounterGroups.Count()) Modified = true;
            if(LocationsCount != ExtZone.EncounterLocations.Count()) Modified = true;
            if(FlagCount != ExtZone.Flags.Count()) Modified = true;

            if(Modified)
                SelectedZone.Brushed = true;

            SaveSelected();
            return Modified;
        }

        public void ReplaceSelectedZone(IZone zone, ICopy ICopyParams)
        {
            int x = SelectedZone.X;
            int y = SelectedZone.Y;

            IZone copyzone = zone.Clone();

            if (ICopyParams is Copy)
            {
                Copy CopyParams = (Copy)ICopyParams;
                IExtZone ExtSelectedZone = (IExtZone)SelectedZone;
                IExtZone ExtCopyZone = (IExtZone)copyzone;

                if (CopyParams.CopyDifficulty)
                    ExtSelectedZone.Difficulty = ExtCopyZone.Difficulty;
                if (CopyParams.CopyGroups)
                {
                    if (CopyParams.Overwrite)
                        ExtSelectedZone.EncounterGroups = ExtCopyZone.EncounterGroups;
                    else
                    {
                        ExtSelectedZone.EncounterGroups.AddRange(ExtCopyZone.EncounterGroups);
                        ExtSelectedZone.EncounterGroups = Utils.RemoveDuplicates<EncounterZoneGroup>(ExtSelectedZone.EncounterGroups);
                    }
                }
                if (CopyParams.CopyLocations)
                {
                    if (CopyParams.Overwrite)
                        ExtSelectedZone.EncounterLocations = ExtCopyZone.EncounterLocations;
                    else
                    {
                        ExtSelectedZone.EncounterLocations.AddRange(ExtCopyZone.EncounterLocations);
                        ExtSelectedZone.EncounterLocations = Utils.RemoveDuplicates<EncounterZoneLocation>(ExtCopyZone.EncounterLocations);
                    }
                }

                if (ExtSelectedZone.EncounterGroups == null)
                    ExtSelectedZone.EncounterGroups = new List<EncounterZoneGroup>();
                if (ExtSelectedZone.EncounterLocations == null)
                    ExtSelectedZone.EncounterLocations = new List<EncounterZoneLocation>();
            }

            if (ICopyParams.CopyTerrain)
                SelectedZone.Terrain = copyzone.Terrain;
            if (ICopyParams.CopyChance)
                SelectedZone.Chance = copyzone.Chance;
            
            SelectedZone.Brushed = copyzone.Brushed;
            SelectedZone.X = x;
            SelectedZone.Y = y;


            SaveSelected();
        }

        public void SetSelectedZone(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                SelectedZone = null;
                SelectedZoneX = -1;
                SelectedZoneY = -1;
                return;
            }

            SelectedZoneX = x;
            SelectedZoneY = y;

            IZone zone = GetZone(x, y);
            if (zone == null)
            {
                if (Zones == null)
                    return;

                IZone newZone = NewZone(x, y);
                if (newZone != null)
                {
                    SelectedZone = newZone;
                    Zones.Add(SelectedZone);
                    SelectedIndex = Zones.IndexOf(SelectedZone);
                }
            }
            else
            {
                SelectedZone = zone;
                SelectedIndex = Zones.IndexOf(zone);
            }
        }

        public void DrawSelectedZone(Graphics g)
        {
            if (SelectedZoneX == -1 || SelectedZoneY == -1)
                return;

            Drawing.DrawZone(g, Drawing.SelectedColor, SelectedZoneX, SelectedZoneY);
        }

        public void DrawAvailable(Graphics g)
        {
            if (Zones == null)
                return;

            foreach (IZone i in Zones)
            {
                Drawing.DrawZone(g, Drawing.ImplementedColor, i.X, i.Y);
            }
        }

        public void DrawBrushed(Graphics g)
        {
            if (Zones == null)
                return;

            foreach (IZone i in Zones)
            {
                if (i.Brushed)
                    Drawing.DrawZone(g, Drawing.BrushedColor, i.X, i.Y);
            }
        }

        public void DrawModified(Graphics g)
        {
            if (Zones == null)
                return;

            foreach (IZone i in Zones)
            {
                if (i.Modified == true)
                    Drawing.DrawZone(g, Drawing.ModifiedColor, i.X, i.Y);
            }
        }

        public void DrawZoneValue(Graphics g, List<ValueZone> zones)
        {
            foreach (ValueZone zone in zones)
            {
                Drawing.DrawZone(g, zone.c, zone.x, zone.y);
            }
        }

        public bool IsModified()
        {
            if (Zones == null) return false;

            foreach (IZone i in Zones)
                if (i.Modified)
                    return true;
            return false;
        }

        public void DrawScript(Graphics g)
        {
            if (Config.ScriptingEnabled) Scripting.Host.ScriptHost.draw_worldmap(g);
        }

        public void DrawLocations(Graphics g)
        {
            if (!Config.ShowLocations)
                return;

            foreach (Location Loc in Locations)
            {
                if (Config.ScriptingEnabled)
                {
                    bool Visible = Loc.OnWorldmap;
                    Scripting.Host.ScriptHost.worldmap_location_visible(Loc, ref Visible);
                    if (Visible)
                        Drawing.DrawLocation(g, Color.Green, Loc);
                    Scripting.Host.ScriptHost.worldmap_location_drawing(Loc, g);
                }
                else
                {
                    if (Loc.OnWorldmap)
                        Drawing.DrawLocation(g, Color.Green, Loc);
                }
            }
        }

        public void DrawObjects(Graphics g)
        {
            foreach (IWorldMapDrawable Obj in MapObjects)
            {
                Obj.Draw(g);
            }
            DrawLocations(g);
        }

        public void DrawGroupDensity(Graphics g, bool ShowNumbers)
        {
            foreach (Zone i in Zones)
            {
                if (i.EncounterGroups == null)
                    continue;

                int gr = i.EncounterGroups.Count * 20;
                if (gr > 255)
                    gr = 255;

                int a = i.EncounterGroups.Count * 50;
                if (a > 255)
                    a = 255;
                if(ShowNumbers)
                    Drawing.DrawZoneDisplay(g, Color.White, i.X, i.Y, i.EncounterGroups.Count.ToString(), ZoneDisplayFont);
                Drawing.DrawZone(g, Color.FromArgb(a, 0, 255- gr, 0), i.X, i.Y);
            }
        }

        public void DrawGroupQuantities(Graphics g, bool ShowNumbers, int modifier)
        {
            foreach (Zone i in Zones)
            {
                float quantity=0;
                if (i.EncounterGroups == null)
                    continue;
                foreach (EncounterZoneGroup grp in i.EncounterGroups)
                {
                    if (modifier == 0)
                        quantity += grp.Quantity;
                    else if (modifier == 1)
                        quantity += grp.QuantityDay;
                    else if (modifier == 2)
                        quantity += grp.QuantityNight;
                }

                int gr = (int)(quantity * 8);
                if (gr > 255)
                    gr = 255;

                int a = (int)(quantity * 8);
                if (a > 255)
                    a = 255;
                if (ShowNumbers)
                {
                    int num = (int)quantity;
                    Drawing.DrawZoneDisplay(g, Color.White, i.X, i.Y, num.ToString(), ZoneDisplayFont);
                }
                Drawing.DrawZone(g, Color.FromArgb(a, 0, 255 - gr, 0), i.X, i.Y);
            }
        }

        private int ItemsInZone(Zone i, int ItemPid)
        {
            int num = 0;
            if (i.EncounterGroups == null)
                return 0;

            foreach (EncounterZoneGroup gr in i.EncounterGroups)
            {
                EncounterGroup realgroup = GroupParser.GetGroupByName(gr.Name); // Because gr contains only small amount of data parsed
                                                                                // from worldmap.fowm, rest is in parser.
                foreach (EncounterNpc npc in realgroup.Npcs)
                    foreach (EncounterItem item in npc.Items)
                        if (item.Item.Pid == ItemPid)
                            num++;
            }
            return num;
        }

        public void DrawItemZones(Graphics g, string ItemDefine, bool ShowNumbers)
        {
            foreach (Zone i in Zones)
            {
                int num = ItemsInZone(i, ItemPid.GetPid(ItemDefine));
                if (num != 0)
                {
                    Drawing.DrawZone(g, Color.Blue, i.X, i.Y);
                    if (ShowNumbers && num < 100)
                        Drawing.DrawZoneDisplay(g, Color.White, i.X, i.Y, num.ToString(), ZoneDisplayFont);
                }
            }
        }

        public void DrawDifficultyZones(Graphics g, bool IsAbove, int Val, bool ShowNumbers)
        {
            foreach (Zone i in Zones)
            {
                if(IsAbove&&(i.Difficulty<Val))
                    continue;
                if (!IsAbove&&(i.Difficulty > Val))
                    continue;

                int r =  i.Difficulty*4;
                if(r>255)
                    r=255;

                int a = i.Difficulty*4;
                if (a > 255)
                    a = 255;
                if (ShowNumbers && (i.Difficulty<100))
                    Drawing.DrawZoneDisplay(g, Color.White, i.X, i.Y, i.Difficulty.ToString(), ZoneDisplayFont);
                Drawing.DrawZone(g, Color.FromArgb(a,255-r,0,0), i.X, i.Y);
            }
        }

        public void DrawFilteredWorldZones(IFilter Filter, Graphics g)
        {
            if (Zones == null)
                return;

            foreach (IZone i in Zones)
            {
                if (Filter is DefaultFilter)
                {
                    DefaultFilter DF = (DefaultFilter)Filter;
                    Zone Zonei = (Zone)i;

                    if (!DF.FilterChance&&!DF.FilterFlag&&!DF.FilterGroup&&!DF.FilterLocation
                        &&!DF.FilterNoGroup&&!DF.FilterNoLocation&&!DF.FilterTerrain)
                        continue;

                    if (DF.FilterNoGroup)
                        if (Zonei.EncounterGroups != null)
                        {
                            if (Zonei.EncounterGroups.Count != 0)
                                continue;
                        }

                    if (DF.FilterNoLocation)
                        if (Zonei.EncounterLocations != null)
                        {
                            if (Zonei.EncounterLocations.Count > 0)
                                continue;
                        }

                    if (DF.FilterLocation)
                        if (!Zonei.ContainsLocationWithName(DF.Location))
                            continue;

                    if (DF.FilterGroup)
                        if (!Zonei.ContainsGroupWithName(DF.Group))
                            continue;

                    if (DF.FilterFlag)
                        if (Zonei.Flags.IndexOf(DF.Flag) == -1)
                            continue;
                }
                
                if (Filter.FilterChance)
                    if (i.Chance != Filter.Chance)
                        continue;

                if (Filter.FilterTerrain)
                    if (i.Terrain != Filter.Terrain)
                        continue;

                Drawing.DrawZone(g, Drawing.FilteredColor, i.X, i.Y);
            }
        }

        public bool DeleteSelected()
        {
            if (SelectedZone == null)
                return false;
            Zones.RemoveAt(SelectedIndex);
            SelectedZone = null;
            return true;
        }

        public IZone GetSelectedZone()
        {
            return SelectedZone;
        }

        public List<IZone> GetZones()
        {
            return Zones;
        }

        public IWorldMapFormat GetWorldMapFormat()
        {
            return WMFormat;
        }

        public IZone GetZone(int x, int y)
        {
            if (Zones == null) return null;

            foreach (IZone i in Zones)
            {
                if ((i.X == x) && (i.Y == y))
                {
                    return i;
                }
            }
            return null;
        }

        public void RefreshZoneGroups()
        {
            foreach (Zone i in Zones)
            {
                if (i.EncounterGroups == null)
                    continue;

                foreach (EncounterZoneGroup grp in i.EncounterGroups)
                    grp.RefreshQuantity();
            }
        }

        public bool LoadZones(EncounterGroupParser GroupParser)
        {
            if (Config.ScriptingEnabled)
            {
                if (Scripting.Host.ScriptHost.load_zones(FileName))
                    return true;
            }

            Utils.Log("Loading zones from " + FileName + "...");
            Zones = WMFormat.LoadZones(FileName, GroupParser);
            return (Zones != null && Zones.Count!=0);
        }

        public bool Save()
        {
            FOCommon.Cache.Cache.Save(".\\Cache.dat");
            SaveLocations();
            SaveMaps();
            SaveZones();
            return Compile();
        }

        public bool SaveZones()
        {
            if (Config.ScriptingEnabled)
            {
                if (Scripting.Host.ScriptHost.save_zones(FileName))
                    return true;
            }
            Utils.Log("Saving zones to " + FileName + "...");
            return (WMFormat.SaveZones(FileName, Zones));
        }

        public void SaveMaps()
        {
            MapParser.SaveMaps();
        }

        public void SaveLocations()
        {
            LocParser.SaveLocations(Locations);
        }

        public bool Compile()
        {
            if (Config.ScriptingEnabled)
            {
                if (Scripting.Host.ScriptHost.compile_zones(CompiledFileName, DefineParser.Defines)) return true;
            }

            return new Compiler().Compile(CompiledFileName, DefineParser.Defines, Zones);
        }
    }
}
