using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FOCommon.WMLocation;
using ScriptHost;
using WorldEditor.ProtoEditor;

namespace WorldEditor.Scripting
{
    public interface IScript : ScriptHost.IScript
    {
        void draw_worldmap(Graphics Surface);
        bool load_zones(string fileName); // return false to let WE handle
        bool save_zones(string fileName); // return false to let WE handle
        bool compile_zones(string fileName, Dictionary<String, int> defines);
        void worldmap_location_drawing(Location Loc, Graphics Surface);
        bool worldmap_location_visible(Location Loc, ref bool Visible);
        bool worldmap_coords_clicked(MouseEventArgs e, int x, int y);
        bool zone_activated(int x, int y);
    }

    public class ScriptGlobal : ScriptHost.ScriptGlobal
    {
        private WorldMap WM;
        private PictureBox PctWM;

        public IZone GetZone(int x, int y) { if (WM == null) return null; return WM.GetZone(x, y); }
        public Location GetLocation(int x, int y) { if (WM == null) return null; return WM.GetLocation(x, y); }
        public List<Location> GetLocations() { if (WM == null) return null; return WM.GetLocations(); }
        public List<Map> GetMaps() { if (WM == null) return null; return WM.MapParser.GetMaps(); }
        public List<ProtoCritter> GetCrProtos() { if (!ProtoManager.Initialized) return null; return new List<ProtoCritter>(ProtoManager.Protos.Values); }
        public void SetSelectedZone(int x, int y) { if (WM == null) return; WM.SetSelectedZone(x, y); }
        public void SaveLocations() { if (WM == null) return; WM.SaveLocations(); }
        public void SaveMaps() { if (WM == null) return; WM.SaveMaps(); }
        public bool ResourcesLoaded() { return WM != null; }
        public void RefreshWorldMap() { if (PctWM == null) return; PctWM.Refresh(); }
        public Graphics GetWorldMapSurface() { return PctWM.CreateGraphics(); }
        public int Random(int min, int max) { return Rand.Next(); }
        public double Random(double min, double max) { return Rand.NextDouble(); }
        public void RegisterForm(Form form) { Host.RegisterFormEvents(form); }

        public void Init(ScriptHost.ScriptHost Host, WorldMap WM, PictureBox Pct)
        {
            this.Host = Host;
            this.WM = WM;
            this.PctWM = Pct;
            Rand = new Random();
        }
    }

    public static class Host
    {
        public static ScriptGlobal ScriptGlobal;
        public static WEScriptHost ScriptHost;
    }

    public class WEScriptHost : ScriptHost.ScriptHost
    {
        public override string GetImports()
        {
            return @"using System;
                        using System.Collections;
                        using System.Drawing;
                        using System.Windows.Forms;
                        using System.Collections.Generic;
                        using System.Linq;
                        using WorldEditor;
                        using FOCommon.WMLocation;
                        using WorldEditor.Scripting;" + Environment.NewLine;
        }

        public override void Preprocess(ref string Text)
        {
            //bool Done = false;
            // Try each one, if found and preprocessed, skip all others.
            Alias(ref Text, "SaveLocations", "Host.ScriptGlobal.SaveLocations");
            Alias(ref Text, "SaveMaps", "Host.ScriptGlobal.SaveMaps");
            Alias(ref Text, "GetZone", "Host.ScriptGlobal.GetZone");
            Alias(ref Text, "CrProtos", "Host.ScriptGlobal.GetCrProtos()");
            Alias(ref Text, "Maps", "Host.ScriptGlobal.GetMaps()");
            Alias(ref Text, "RefreshWorldMap", Environment.NewLine + "Host.ScriptGlobal.RefreshWorldMap");
            Alias(ref Text, "ScriptGlobal.RefreshWorldMap", Environment.NewLine + "Host.ScriptGlobal.RefreshWorldMap");
            Alias(ref Text, "ScriptGlobal.ResourcesLoaded", Environment.NewLine + "Host.ScriptGlobal.ResourcesLoaded");

            Alias(ref Text, new string[] { "Locations", "Locs" }, "Host.ScriptGlobal.GetLocations()");
            Alias(ref Text, new string[] { "Print", "Echo", "Console.WriteLine" }, "Host.ScriptHost.WriteLine");

            PreprocessAccessor(ref Text, "Host.ScriptGlobal.GetLocations().\"", "Name", true);
            PreprocessAccessor(ref Text, "Host.ScriptGlobal.GetLocations().'", "Name", false);
            PreprocessAccessor(ref Text, "Host.ScriptGlobal.GetMaps().\"", "Name", true);
            PreprocessAccessor(ref Text, "Host.ScriptGlobal.GetMaps().'", "Name", false);
            PreprocessAccessor(ref Text, "Host.ScriptGlobal.GetCrProtos().\"", "Name", true);
            PreprocessAccessor(ref Text, "Host.ScriptGlobal.GetCrProtos().'", "Name", false);
        }

        public override void Log(string Text)
        {
            Utils.Log(Text);
        }

        public override void InitEventStubs()
        {
            EventStubs.Add("public void draw_worldmap"             ,"public void draw_worldmap(Graphics Surface) { }");
            EventStubs.Add("public bool worldmap_coords_clicked"   ,"public bool worldmap_coords_clicked(MouseEventArgs e, int x, int y) { return false; }");
            EventStubs.Add("public bool worldmap_location_visible" ,"public bool worldmap_location_visible(Location Loc, ref bool Visible) { return false; }");
            EventStubs.Add("public void worldmap_location_drawing" ,"public void worldmap_location_drawing(Location Loc, Graphics Surface) { }");
            EventStubs.Add("public bool zone_activated"            ,"public bool zone_activated(int x, int y) { return false; }");
            EventStubs.Add("public bool load_zones"                ,"public bool load_zones(string fileName) { return false; }");
            EventStubs.Add("public bool save_zones"                ,"public bool save_zones(string fileName) { return false; }");
            EventStubs.Add("public bool compile_zones"             ,"public bool compile_zones(string fileName, Dictionary<String, int> defines) { return false; }");
        }

        /////////// Wrappers for callbacks ///////////////////////////////////
        // if return parameter, only for main script                         /
        // else for all registered extensions                                /
        //////////////////////////////////////////////////////////////////////
        public void draw_worldmap(Graphics Surface)      { foreach (ScriptExtension Ext in Extensions) Ext.Handle.draw_worldmap(Surface); }
        public void main_form_loaded()                   { foreach (ScriptExtension Ext in Extensions) Ext.Handle.main_form_loaded(); }
        public void resources_loaded()                   { foreach (ScriptExtension Ext in Extensions) Ext.Handle.resources_loaded(); }
        public void worldmap_location_drawing(Location Loc, Graphics Surface) { foreach (ScriptExtension Ext in Extensions) Ext.Handle.worldmap_location_drawing(Loc, Surface); }
        public bool worldmap_location_visible(Location Loc, ref bool Visible) { foreach (ScriptExtension Ext in Extensions) if (Ext.Handle.worldmap_location_visible(Loc, ref Visible)) return true; return false; }
        public bool worldmap_coords_clicked(MouseEventArgs e, int x, int y) { foreach (ScriptExtension Ext in Extensions) if (Ext.Handle.worldmap_coords_clicked(e, x, y)) return true; return false; }
        public bool zone_activated(int x, int y)         { foreach (ScriptExtension Ext in Extensions) if (Ext.Handle.zone_activated(x, y)) return true; return false; }
        public bool compile_zones(string fileName, Dictionary<String, int> defines)       { foreach (ScriptExtension Ext in Extensions) if (Ext.Handle.compile_zones(fileName, defines)) return true; return false; }
        public bool load_zones(string fileName)          { foreach (ScriptExtension Ext in Extensions) if (Ext.Handle.load_zones(fileName)) return true; return false; }
        public bool save_zones(string fileName)          { foreach (ScriptExtension Ext in Extensions) if (Ext.Handle.save_zones(fileName)) return true; return false; }
        public bool shell_input(ref string text)                { foreach (ScriptExtension Ext in Extensions) if (Ext.Handle.shell_input(ref text)) return true; return false; }
    }
}
