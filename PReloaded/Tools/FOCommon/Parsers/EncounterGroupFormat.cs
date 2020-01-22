using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

using FOCommon.Worldmap.EncounterGroup;

// Class for parsing 2238 worldmap encountergroups.

namespace FOCommon.Parsers
{
    public enum GroupFormatData
    {
        Item = 0,
        Perk = 1
    };

    public static class EncounterGroupFormat
    {
        static CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();

        public static List<FOCommon.Worldmap.EncounterGroup.EncounterGroup> LoadNew(List<string> lines)
        {
            List<FOCommon.Worldmap.EncounterGroup.EncounterGroup> Groups = new List<FOCommon.Worldmap.EncounterGroup.EncounterGroup>();

            int groupId = 0;
            EncounterGroup Group = null;
            foreach (string line in lines)
            {

                if (line.StartsWith("*")) // Npc data
                {
                    string[] parts = line.Split('|');
                    string[] param = parts[0].Split(',');

                    EncounterNpc NpcObj = new EncounterNpc(Int32.Parse(param[1]), Int32.Parse(param[2]), param[3], Int32.Parse(param[4]), param[5] == "1" ? true : false,
                        Int32.Parse(param[6]), Int32.Parse(param[7]), Int32.Parse(param[8]));

                    for (int i = 1; i < parts.Length; i++)
                    {
                        string[] npcData = parts[i].Split(',');
                        if (Int32.Parse(npcData[0]) == (int)GroupFormatData.Item)
                        {
                            EncounterItem item = new EncounterItem(Int32.Parse(npcData[1]), Int32.Parse(npcData[2]), Int32.Parse(npcData[3]), Int32.Parse(npcData[4]));
                            NpcObj.AddItem(item);
                        }
                        else if (Int32.Parse(npcData[0]) == (int)GroupFormatData.Perk)
                        {
                            EncounterPerk perk = new EncounterPerk(npcData[1], Int32.Parse(npcData[2]), Int32.Parse(npcData[3]), Int32.Parse(npcData[4]));
                            NpcObj.Perks.Add(perk);
                        }
                    }
                    Group.Npcs.Add(NpcObj);
                }
                else // Group data
                {
                    if (String.IsNullOrEmpty(line) || line.Length < 5)
                        continue;

                    string[] param = line.Split(',');

                    float quantityDay = (float)double.Parse(param[7], NumberStyles.Any, ci);
                    float quantityNight = (float)double.Parse(param[8], NumberStyles.Any, ci);

                    Group = new FOCommon.Worldmap.EncounterGroup.EncounterGroup(param[0], Int32.Parse(param[1]), Int32.Parse(param[2]),
                          Int32.Parse(param[3]), Int32.Parse(param[4]), Int32.Parse(param[5]), Int32.Parse(param[6]), quantityDay, quantityNight, Int32.Parse(param[9]), Int32.Parse(param[10]));

                    if (Group != null)
                    {
                        Group.Id = groupId++;
                        Groups.Add(Group);
                    }
                }
            }

            return Groups;
        }

        public static List<FOCommon.Worldmap.EncounterGroup.EncounterGroup> LoadOld(List<string> lines)
        {
            List<FOCommon.Worldmap.EncounterGroup.EncounterGroup> Groups = new List<FOCommon.Worldmap.EncounterGroup.EncounterGroup>();
            int groupId = 0;

            foreach (string line in lines)
            {
                string[] partsdel = { "|||" };
                string[] npcsdel = { "||" };
                string[] parts = line.Split(partsdel, StringSplitOptions.RemoveEmptyEntries);
                
                string[] npcs;
                if (parts.Length == 2)
                    npcs = parts[1].Split(npcsdel, StringSplitOptions.RemoveEmptyEntries);
                else
                    npcs = new string[0];

                string[] param = parts[0].Split(',');

                float quantityDay = (float)double.Parse(param[7], NumberStyles.Any, ci);
                float quantityNight = (float)double.Parse(param[8], NumberStyles.Any, ci);

                FOCommon.Worldmap.EncounterGroup.EncounterGroup Group = new FOCommon.Worldmap.EncounterGroup.EncounterGroup(param[0], Int32.Parse(param[1]), Int32.Parse(param[2]),
                      Int32.Parse(param[3]), Int32.Parse(param[4]), Int32.Parse(param[5]), Int32.Parse(param[6]), quantityDay, quantityNight, Int32.Parse(param[9]), Int32.Parse(param[10]));

                Group.Id = groupId++;

                foreach (string npc in npcs)
                {
                    string[] npcparts = npc.Split('|');
                    string[] npcparams = npcparts[0].Split(',');

                    // Convert
                    EncounterNpc NpcObj = new EncounterNpc(Int32.Parse(npcparams[0]), Int32.Parse(npcparams[1]), npcparams[2], Int32.Parse(npcparams[3]),npcparams[4] == "1" ? true : false, 
                        -1, -1, -1);

                    for (int i = 1; i < npcparts.Length; i++)
                    {
                        string[] itemparam = npcparts[i].Split(',');
                        EncounterItem item = new EncounterItem(Int32.Parse(itemparam[0]), Int32.Parse(itemparam[1]), Int32.Parse(itemparam[2]), Int32.Parse(itemparam[3]));
                        NpcObj.AddItem(item);
                    }

                    Group.Npcs.Add(NpcObj);
                }
                Groups.Add(Group);
            }
            return Groups;
        }

        public static List<FOCommon.Worldmap.EncounterGroup.EncounterGroup> Load(string path)
        {
            ci.NumberFormat.CurrencyDecimalSeparator = "."; // , is default in some locales

            if (!File.Exists(path))
                return null;
            List<string> lines = new List<string>();
            lines.AddRange(File.ReadAllLines(path));
            return LoadNew(lines);
        }

        public static bool Save(List<FOCommon.Worldmap.EncounterGroup.EncounterGroup> Groups, string path)
        {
            ci.NumberFormat.NumberDecimalSeparator = ".";
            ci.NumberFormat.CurrencyDecimalSeparator = "."; // , is default in some locales

            if (Groups == null || Groups.Count == 0)
                return false;

            List<string> lines = new List<string>();
            foreach (FOCommon.Worldmap.EncounterGroup.EncounterGroup grp in Groups)
            {
                string line;

                // Group data, one line
                line = grp.Name + "," + grp.Position + "," + grp.Spacing + "," + grp.RatioMin + "," + grp.RatioMax + "," + grp.FactionId + "," + grp.FactionMode + "," 
                    + String.Format(ci, "{0:0.00}", grp.QuantityDay) + "," + String.Format(ci, "{0:0.00}", grp.QuantityNight) + ","+grp.DistMin + "," + grp.DistMax;
                lines.Add(line);

                // Npc data, one line for each NPC, [Basic data]|[GroupFormatData identifier  as defined in Enum],[data...]|[GroupFormatData identifier],[data...]
                foreach (EncounterNpc npc in grp.Npcs)
                {
                    // Parameters
                    line= "*," + npc.Proto.Id + "," + npc.Dialog.Id + "," + npc.Script + "," + npc.Ratio + "," + (npc.Dead ? 1 : 0) + "," + npc.ArmorPid + "," + npc.HelmPid + "," + npc.ForcedCrType;

                    if (npc.Items.Count > 0)
                    {
                        foreach(EncounterItem item in npc.Items)
                        {
                            line+= String.Format("|{0},{1},{2},{3},{4}", (int)GroupFormatData.Item, item.Item.Pid, item.Min, item.Max, (int)item.Slot);
                        }

                        foreach(EncounterPerk perk in npc.Perks)
                        {
                            line += String.Format("|{0},{1},{2},{3},{4}", (int)GroupFormatData.Perk, perk.Define, perk.Index, perk.Level, perk.Chance);
                        }
                    }
                    lines.Add(line);
                }
            }
            File.WriteAllLines(path, lines.ToArray());
            return true;
        }
    }
}
