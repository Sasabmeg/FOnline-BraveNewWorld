using System;
using System.Collections.Generic;

using FOCommon.Worldmap.EncounterGroup;
using FOCommon.Critter;

using System.IO;

// Class for parsing 2238 worldmap encountergroups.

namespace FOCommon.Parsers
{
    public class EncounterGroupParser : BaseParser, IParser
    {
        readonly List<EncounterGroup> _groups = new List<EncounterGroup>();
        readonly FOGAMEParser _gameParser;
        readonly FOGMParser _gmParser;
        readonly MSGParser _fodlgParser;
        readonly List<CritterProto> _crProtos = new List<CritterProto>();
        readonly string _filename;

        public List<EncounterGroup> GetGroups()
        {
            return _groups;
        }

        public EncounterGroup GetGroupByName(string GroupName)
        {
            foreach (EncounterGroup grp in _groups)
                if (grp.Name == GroupName)
                    return grp;
            return null;
        }

        public EncounterGroup FillGroupInfo(EncounterGroup Group)
        {
            foreach (EncounterGroup grp in _groups)
                if (grp.Name == Group.Name)
                    return grp.Clone();
            return null;
        }

        public EncounterGroupParser(string filename, FOGAMEParser gameParser, DialogListParser dialogParser, FOGMParser gmParser, MSGParser fodlgParser)
        {
            _gameParser = gameParser;
            _gmParser = gmParser;
            _fodlgParser = fodlgParser;
            _filename = filename;
            _groups = EncounterGroupFormat.Load(filename);
        }

        public bool Parse()
        {
            if (!File.Exists(_filename))
                return false;

            List<Faction> factions = _gameParser.GetFactions();

            List<string> fogmNames = _gmParser.GetGroupGameNames();
            Dictionary<int, string> protoNames = _fodlgParser.GetData();

            foreach (KeyValuePair<int, string> kvp in protoNames)
            {
                if (kvp.Key % 2 == 1)
                    continue;
                CritterProto critterProto = new CritterProto((kvp.Key / 10));
                critterProto.Name = kvp.Value;
                _crProtos.Add(critterProto);
            }

            foreach (EncounterGroup grp in _groups)
            {
                grp.NpcCount = grp.Npcs.Count;
                grp.GMName = fogmNames[grp.Id];

                foreach (Faction f in factions)
                    if (grp.FactionId == f.Id)
                        grp.FactionName = f.Name;
            }

            _IsParsed = true;
            return true;
        }

        private int GetEncounterGroupStartLine(List<string> lines)
        {
            for (int i = 0; i < lines.Count; i++)
                /*if (lines[i].Contains("GROUP_Player#(i)"))*/
                if (lines[i].Contains("GROUP_Player"))
                    return i + 1;
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

        public bool WriteEncounterGroupBlock(List<EncounterGroup> groups, string worldHeaderPath)
        {
            List<String> groupNames = new List<string>();
            foreach (EncounterGroup grp in groups)
                groupNames.Add(grp.Name);

            groupNames.Add("GROUP_Game_Foreshadowing");
            groupNames.Add("GROUP_MAX");

            List<string> lines = new List<string>(File.ReadAllLines(worldHeaderPath));
            int startline = GetEncounterGroupStartLine(lines);
            Utils.Log("startline == " + startline + " in WriteEncounterGroupBlock");
            if (startline == -1)
                return false;
            int y = -1;
            for (int i = startline; i < startline + groupNames.Count; i++)
            {

                if (string.IsNullOrEmpty(lines[i]))
                    lines.Insert(i, "");
                lines[i] = "#define " + groupNames[++y] + GetSpacing(groupNames[y]) + "(" + y + ")";
            }
            for (int i = (startline + groupNames.Count); i < (startline + groupNames.Count) + 50; i++)
            {
                if (i > lines.Count - 1)
                    break;
                if (lines[i].Contains("GROUP_"))
                    lines.RemoveAt(i);
            }

            File.WriteAllLines(worldHeaderPath, lines.ToArray());

            return true;
        }

        public bool Save(List<EncounterGroup> groups, string groupsPath, string worldHeaderPath)
        {
            Utils.Log("Saving group defines to " + worldHeaderPath);
            Utils.Log("Saving groups to " + groupsPath);
            Utils.Log("Saving GM group data to " + _gmParser.GetFilename());

            if (!EncounterGroupFormat.Save(groups, groupsPath) ||
                !WriteEncounterGroupBlock(groups, worldHeaderPath) ||
                !_gmParser.WriteEncounterGroupNameBlock(groups))
                return false;
            return true;
        }
    }
}
