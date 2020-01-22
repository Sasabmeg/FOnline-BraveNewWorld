using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using FOCommon.Parsers;

namespace WorldEditor
{
    public interface IWorldMapFormat
    {
        List<IZone> LoadZones(string FileName, EncounterGroupParser GroupParser);
        bool SaveZones(string FileName, List<IZone> Zones);
        bool SupportExtendedFeatures(); // Extended features such as encounter location/groups instead of just tables
    }

    public static class WorldMapUtils
    {
        public static bool VerifyFormat(string line, string fileName, string formatString, out string versionNum)
        {
            if (!line.Contains("Format") || !line.Contains("Version"))
            {
                Message.Show("Can't parse worldmap " + fileName + ", invalid format.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                versionNum = null;
                return false;
            }
            string[] header = line.Split('|');
            string[] format = header[0].Split('=');
            string[] version = header[1].Split('=');

            if (format[1] != formatString)
            {
                Message.Show("Can't parse worldmap, format is '"+format[1]+"', expected '"+formatString+"'", MessageBoxButtons.OK, MessageBoxIcon.Error);
                versionNum = null;
                return false;
            }
            versionNum = version[1];
            return true;
        }
    }

    public class WorldMapFormat : IWorldMapFormat
    {
        protected DefineParser Defines;

        public WorldMapFormat(DefineParser WorldMapHeaderDefines)
        {
            this.Defines = WorldMapHeaderDefines;
        }

        public bool SupportExtendedFeatures() { return true; }

        private List<EncounterZoneLocation> ParseLocations(String[] Locations, string Pos)
        {
            List<EncounterZoneLocation> Locs = new List<EncounterZoneLocation>();
            if (Locations.Length > 1 || Locations[0] != "")
                foreach (string i in Locations)
                {
                    if (i.Length < 8 || i.Substring(0, 8) != "LOCATION") Message.Show("Invalid location " + i + " at " + Pos + ".", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EncounterZoneLocation loc = new EncounterZoneLocation();
                    loc.Name = i;
                    Locs.Add(loc);
                }
            return Locs;
        }

        private List<EncounterZoneGroup> ParseGroups(String[] Groups, EncounterGroupParser GroupParser, string Pos)
        {
            List<EncounterZoneGroup> Grps = new List<EncounterZoneGroup>();

            if (Groups.Length > 1 || Groups[0] != "")
                foreach (string i in Groups)
                {
                    if (i.Length < 5 || i.Substring(0, 5) != "GROUP") Message.Show("Invalid group " + i + " at " + Pos + ".", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    String[] toks = i.Split(':');
                    EncounterZoneGroup group = new EncounterZoneGroup(toks[0], Int32.Parse(toks[1]), GroupParser.GetGroupByName(toks[0]));
                    Grps.Add(group);
                }
            return Grps;
        }

        private List<String> ParseFlags(String[] Flags, string Pos)
        {
            List<String> Flgs = new List<String>();

            if (Flags.Length > 1 || Flags[0] != "")
                foreach (string i in Flags)
                {
                    if (!String.IsNullOrEmpty(i))
                    {
                        if (i.Length < 4 || i.Substring(0, 4) != "FLAG") Message.Show("Invalid flag " + i + " at " + Pos + ".", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Flgs.Add(i);
                    }
                }

            return Flgs;
        }

        public List<IZone> LoadZones(string FileName, EncounterGroupParser GroupParser)
        {
            if(!File.Exists(FileName))
            {
                Message.Show("Couldn't open " + FileName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            //try
           // {
                List<IZone> Zones = new List<IZone>();
                List<string> lines = new List<string>(File.ReadAllLines(FileName));

                if (lines.Count == 0)
                {
                    Message.Show("Worldmap file is empty.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                string version;
                if (!WorldMapUtils.VerifyFormat(lines[0], FileName, "2238", out version))
                    return null;

                foreach (string line in lines)
                {
                    if (line.Length == 0 || (line.Contains("Format") && line.Contains("Version")))
                        continue;

                    List<EncounterZoneLocation> AddLocations = new List<EncounterZoneLocation>();
                    List<EncounterZoneGroup> AddGroups = new List<EncounterZoneGroup>();
                    List<String> AddFlags = new List<String>();

                    String[] SplittedLine = line.Split('|');
                    String[] Coords = SplittedLine[0].Split(',');
                    String[] Parameters = SplittedLine[1].Split(',');

                    Zone zone = new Zone(Int32.Parse(Coords[0]), Int32.Parse(Coords[1]));
                    zone.Difficulty = Int32.Parse(Parameters[0]);
                    zone.Terrain = Parameters[1];
                    zone.Fill = Parameters[2];
                    zone.Chance = Parameters[3];

                    if (SplittedLine.Length > 2)
                    {
                        if (SplittedLine[2].Length > 2)
                            zone.EncounterLocations = ParseLocations(SplittedLine[2].Split(','), SplittedLine[0]);
                    }
                    if (SplittedLine.Length > 3)
                    {
                        if (SplittedLine[3].Length > 2)
                            zone.EncounterGroups = ParseGroups(SplittedLine[3].Split(','), GroupParser, SplittedLine[0]);
                    }
                    if (SplittedLine.Length > 4)
                    {
                        zone.Flags = ParseFlags(SplittedLine[4].Split(','), SplittedLine[0]);
                    }

                    Zones.Add(zone);
                }
                return Zones;
        }

        public bool SaveZones(string FileName, List<IZone> Zones)
        {
            StreamWriter file;

            if (Zones == null)
                return false;

                file = File.CreateText(FileName);
                file.WriteLine("Format=2238|Version=1");
                foreach (Zone zone in Zones)
                {
                    if (Utils.IsOutOfZoneBoundries(zone.X, zone.Y))
                    {
                        if (Message.Show("Failed bound check on zone " + zone.X + "," + zone.Y + ". Do you want to delete this zone?", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                            return false;
                        else
                            continue;
                    }

                    string line = zone.X + "," + zone.Y + "|" + zone.Difficulty + "," + zone.Terrain + "," + zone.Fill + "," + zone.Chance;

                    line += "|";
                    if (zone.EncounterLocations != null && zone.EncounterLocations.Count > 0)
                    {
                        for (int i = 0; i < zone.EncounterLocations.Count; i++)
                        {
                            if (i == zone.EncounterLocations.Count - 1)
                                line += zone.EncounterLocations[i].Name;
                            else
                                line += zone.EncounterLocations[i].Name + ",";
                        }
                    }

                    line += "|";
                    if (zone.EncounterGroups != null && zone.EncounterGroups.Count > 0)
                    {                            
                            for (int i = 0; i < zone.EncounterGroups.Count; i++)
                            {
                                if (i == zone.EncounterGroups.Count - 1)
                                    line += zone.EncounterGroups[i].Name + ":" + zone.EncounterGroups[i].Quantity;
                                else
                                    line += zone.EncounterGroups[i].Name + ":" + zone.EncounterGroups[i].Quantity + ",";
                            }
                    }

                    line += "|";
                    if (zone.Flags != null && zone.Flags.Count > 0)
                    {
                        for (int i = 0; i < zone.Flags.Count; i++)
                        {
                            if (i == zone.Flags.Count - 1)
                                line += zone.Flags[i];
                            else
                                line += zone.Flags[i] + ",";
                        }
                    }

                    file.WriteLine(line);
                }
                file.Close();
                return true;
            }
    }
}
