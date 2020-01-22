using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WorldEditor
{
    public class Compiler
    {
        Dictionary<string, int> Defines;

        private bool ZoneContains(String var, Zone zone, String error)
        {
            String zoneStr = "Zone[" + zone.X + "," + zone.Y + "]:";
            if (!Defines.ContainsKey(var))
            {
                Message.Show(zoneStr + " Unable to find "+error+" define for " + var, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool Compile(string fileName, Dictionary<string, int> Defines, List<IZone> zones)
        {
            this.Defines = Defines;
            StreamWriter file;
            List<String> lines = new List<string>();
                foreach (Zone zone in zones)
                {

                    if (!ZoneContains(zone.Terrain, zone, "Terrain")) return false;
                    if (!ZoneContains(zone.Fill, zone,    "Fill")) return false;
                    if (!ZoneContains(zone.Chance, zone, "Chance")) return false;

                    if (Utils.IsOutOfZoneBoundries(zone.X, zone.Y))
                    {
                        if (Message.Show("Failed bound check on zone " + zone.X + "," + zone.Y + ". Do you want to skip this zone?", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                            return false;
                        else
                            continue;
                    }

                    string line = zone.X + "," + zone.Y + "|" + zone.Difficulty.ToString() + "," + Defines[zone.Terrain].ToString() + "," +
                        Defines[zone.Fill].ToString() + "," + Defines[zone.Chance].ToString();

                    line += "|";
                    if (zone.EncounterLocations!=null && zone.EncounterLocations.Count > 0)
                    {
                        for (int i = 0; i < zone.EncounterLocations.Count; i++)
                        {
                            if (zone.EncounterLocations[i].Name == "")
                                continue;

                            if (!Defines.ContainsKey(zone.EncounterLocations[i].Name))
                            {
                                Message.Show("Unable to find Location define in _maps.fos for " + zone.EncounterLocations[i].Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }

                            if (i == zone.EncounterLocations.Count - 1)
                                line += Defines[zone.EncounterLocations[i].Name];
                            else
                                line += Defines[zone.EncounterLocations[i].Name] + ",";
                        }
                    }

                    line += "|";
                    if (zone.EncounterGroups!=null && zone.EncounterGroups.Count > 0)
                    {
                        for (int i = 0; i < zone.EncounterGroups.Count; i++)
                        {

                            if (!ZoneContains(zone.EncounterGroups[i].Name, zone, "Group")) return false;

                            if (i == zone.EncounterGroups.Count - 1)
                                line += Defines[zone.EncounterGroups[i].Name] + ":" + zone.EncounterGroups[i].Quantity;
                            else
                                line += Defines[zone.EncounterGroups[i].Name] + ":" + zone.EncounterGroups[i].Quantity + ",";
                        }
                    }

                    line += "|";
                    if (zone.Flags.Count > 0)
                    {
                        for (int i = 0; i < zone.Flags.Count; i++)
                        {
                            if (!ZoneContains(zone.Flags[i], zone, "Flag")) return false;

                            if (i == zone.Flags.Count - 1)
                                line += Defines[zone.Flags[i]];
                            else
                                line += Defines[zone.Flags[i]] + ",";
                        }
                    }
                    lines.Add(line);
                }
                file = File.CreateText(fileName);
                file.AutoFlush = false;
                file.NewLine = "\n";
                foreach(String line in lines)
                    file.WriteLine(line);
                file.Flush();
                file.Close();
                return true;
        }
    }
}
