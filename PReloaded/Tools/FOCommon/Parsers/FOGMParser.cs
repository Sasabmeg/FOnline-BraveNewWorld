using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using FOCommon.Worldmap.EncounterGroup;
using FOCommon.WMLocation;

namespace FOCommon.Parsers
{
    // TODO: Rewrite to include MSGParser instead of subclass.
    public class FOGMParser : MSGParser
    {
        public FOGMParser(string path): base(path) {}

        private int GetEncounterGroupNameStartLine(List<string> lines)
        {
            for (int i = 0; i < lines.Count; i++)
                if (lines[i].Contains("{20000000}{}"))
                    return i;
            return -1;
        }

        private string GetSpacing(string group)
        {
            if (string.IsNullOrEmpty(group))
                return "";

            int len = 40 - group.Length;
            string str = "";
            for (int i = 0; i < len; i++)
                str += " ";
            return str;
        }

        public List<string> GetGroupGameNames()
        {
            return (new List<string>(GetSpecificData(20000000, 20001000).Values));
        }

        public bool WriteEncounterGroupNameBlock(List<EncounterGroup> groups)
        {
            List<String> groupNames = new List<string>();
            foreach (EncounterGroup grp in groups)
                groupNames.Add(grp.GMName);
            groupNames.Add("The what?");

            List<string> gmLines = this.GetLines();
            int startline = GetLineIndex(gmLines, "{20000000}{}");
            if (startline==-1)
                return false;
            int y = 0;
            for (int i = startline; i < startline + groupNames.Count; i++)
            {
                if ((i>=gmLines.Count)||string.IsNullOrEmpty(gmLines[i]))
                    gmLines.Insert(i, "");
                gmLines[i] = "{" + (20000000 + y) + "}{}{" + groupNames[y++] + "}";
            }
            for (int i = (startline + groupNames.Count); i < (startline + groupNames.Count) + 50; i++)
            {
                if (i > gmLines.Count - 1)
                    break;
                if (!string.IsNullOrEmpty(gmLines[i]))
                    gmLines.RemoveAt(i);
            }
            WriteFile();
            return true;
        }

        public void FillMapInfo(Map map)
        {
            map.Name = GetMSGValue(GetNameId(map.Pid));
            List<string> values=GetMSGValues(GetMusicId(map.Pid));
            if(values != null) map.Music = values;
            map.SoundString = GetMSGValue(GetSoundId(map.Pid));
        }

        public void FillLocationInfo(Location loc)
        {
            loc.WorldMapName = GetMSGValue(((loc.Pid)+100)*1000);
            loc.WorldMapDescription = GetMSGValue((((loc.Pid) + 100)*1000)+5);
            string fidloc = GetMSGValue((((loc.Pid) + 100) * 1000) + 20);
            string fidtab = GetMSGValue((((loc.Pid) + 100) * 1000) + 30);
            if (!string.IsNullOrEmpty(fidloc))
                loc.WorldMapTownImagePath = fidloc;
            if (!string.IsNullOrEmpty(fidtab))
                loc.WorldMapSignImagePath = fidtab;
            string entrypoints = GetMSGValue((((loc.Pid) + 100) * 1000) + 90);
            if (!string.IsNullOrEmpty(entrypoints))
                for (int i = 0; i < Int32.Parse(entrypoints); i++)
                {
                    var ent = ParseEntryPoint(loc, i);
                    loc.EntryPoints.Add(ent);
                }
        }

        private EntryPoint ParseEntryPoint(Location Loc, int i)
        {
            var ent = new EntryPoint();
            ent.Name = GetMSGValue((((Loc.Pid) + 100)*1000) + 100 + (i*10) + 1);
            string Txt = GetMSGValue((((Loc.Pid) + 100)*1000) + 100 + (i*10) + 2);
            if (!string.IsNullOrEmpty(Txt))
                ent.X = Int32.Parse(Txt);
            Txt = GetMSGValue((((Loc.Pid) + 100)*1000) + 100 + (i*10) + 3);
            if (!string.IsNullOrEmpty(Txt))
                ent.Y = Int32.Parse(Txt);
            if (Loc.EntryPoints == null)
                Loc.EntryPoints = new List<EntryPoint>();
            return ent;
        }

        void WriteLocationDataLine(ref int i, List<string> lines, string str)
        {
            lines[i++] = str;
            if (lines[i + 2].Contains("# Worldmap Encounter messages"))
                lines.Insert(i, "");
        }

        public void WriteLocationDataBlock(List<Location> locations)
        {
            List<string> lines = GetLines();
            int startline = (GetLineIndex(lines, "# Entire X pic y, (pid + 100) * 1000 + 100 + X*10 + 3")+2);
            int i = startline;
            foreach (Location loc in locations)
            {
                string name;

                if ((string.IsNullOrEmpty(loc.WorldMapName)))
                {
                    if(string.IsNullOrEmpty(loc.Name))
                        continue;
                    name=loc.Name;
                }
                else
                    name=loc.WorldMapName;

                WriteLocationDataLine(ref i, lines,  "# " + name + ", pid " + loc.Pid + ", base " + ((loc.Pid + 100) * 1000));
                WriteLocationDataLine(ref i, lines,  FormatMSGLine((loc.Pid + 100) * 1000, name));
                WriteLocationDataLine(ref  i, lines, FormatMSGLine(((loc.Pid + 100) * 1000 + 5), loc.WorldMapDescription));
                WriteLocationDataLine(ref i, lines, FormatMSGLine(((loc.Pid + 100) * 1000 + 10), loc.Size.ToString()));
                if (!string.IsNullOrEmpty(loc.WorldMapTownImagePath))
                    WriteLocationDataLine(ref  i, lines, FormatMSGLine(((loc.Pid + 100) * 1000 + 20), loc.WorldMapTownImagePath.ToString()));
                if (!string.IsNullOrEmpty(loc.WorldMapSignImagePath))
                    WriteLocationDataLine(ref  i, lines, FormatMSGLine(((loc.Pid + 100) * 1000 + 30), loc.WorldMapSignImagePath.ToString()));
                WriteEntryPoints(ref lines, loc, ref i);
                WriteLocationDataLine(ref i, lines, "");
            }
            CleanFromTo(ref lines, i, "# Worldmap Encounter messages");
            WriteFile();
        }

        private void WriteEntryPoints(ref List<string> lines, Location loc, ref int i)
        {
            if ((loc.EntryPoints != null) && loc.EntryPoints.Count > 0)
            {
                if (!String.IsNullOrEmpty(loc.EntryPoints[0].Name)) // Hack, to account for single entrypoints.
                {
                    WriteLocationDataLine(ref i, lines,
                                          FormatMSGLine(((loc.Pid + 100)*1000 + 90), loc.EntryPoints.Count.ToString()));
                    for (int k = 0; k < loc.EntryPoints.Count; k++)
                    {
                        WriteLocationDataLine(ref i, lines,
                                              FormatMSGLine(((loc.Pid + 100)*1000 + 100 + (k*10) + 1), loc.EntryPoints[k].Name));
                        WriteLocationDataLine(ref i, lines,
                                              FormatMSGLine(((loc.Pid + 100)*1000 + 100 + (k*10) + 2),
                                                            loc.EntryPoints[k].X.ToString()));
                        WriteLocationDataLine(ref i, lines,
                                              FormatMSGLine(((loc.Pid + 100)*1000 + 100 + (k*10) + 3),
                                                            loc.EntryPoints[k].Y.ToString()));
                    }
                }
            }
        }

        void WriteMapDataLine(ref int i, List<string> Lines, string str)
        {
            Lines[i++] = str;
            if (Lines[i + 2].Contains("# Global map"))
                Lines.Insert(i, "");
        }

        public void WriteMapDataBlock(List<Map> maps)
        {
            List<string> lines = GetLines();
            int startline = (GetLineIndex(lines, "{16}{}{blank:100}") + 2);
            int i = startline;
            maps.Sort();
            foreach (Map map in maps)
            {
                i = WriteMapData(lines, map, i);
            }
            CleanFromTo(ref lines, i, "Global map");

            WriteFile();
        }

        private int WriteMapData(List<string> lines, Map map, int i)
        {
            if (string.IsNullOrEmpty(map.Name))
                return i;
            WriteMapDataLine(ref i, lines, "# Map " + map.Pid + ", base " + (GetNameId(map.Pid)));
            WriteMapDataLine(ref i, lines, FormatMSGLine(GetNameId(map.Pid), map.Name));
            foreach (string s in map.Music)
                WriteMapDataLine(ref i, lines, FormatMSGLine(GetMusicId(map.Pid), s));
            WriteMapDataLine(ref i, lines, FormatMSGLine(GetSoundId(map.Pid), map.SoundString));
            WriteMapDataLine(ref i, lines, "");
            return i;
        }

        private int GetNameId(int pid)
        {
            return ((pid + 1) * 10);
        }

        private int GetMusicId(int pid)
        {
            return (((pid + 1) * 10) + 5);
        }

        private int GetSoundId(int pid)
        {
            return (((pid + 1) * 10) + 6);
        }
    }
}
