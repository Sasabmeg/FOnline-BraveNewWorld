using System;
using System.Collections.Generic;

namespace WorldEditor
{
    static class EditorData
    {
        public static List<String> Tables = new List<string>();
        public static List<String> Terrains = new List<string>();
        public static List<String> Fills = new List<string>();
        public static List<String> Chances = new List<string>();
        public static List<String> Groups = new List<string>();
        public static List<String> Locations = new List<string>();
        public static List<String> Flags = new List<string>();

        public static bool IsParsed { get; set; }

        public static bool LoadDataFromDefines(Dictionary<String, int> Defines)
        {
            foreach (string i in Defines.Keys)
            {
                if (i.StartsWith("TABLE")) Tables.Add(i);
                if (i.StartsWith("TERRAIN")) Terrains.Add(i);
                if (i.StartsWith("CHANCE")) Chances.Add(i);
                if (i.StartsWith("FILLS")) Fills.Add(i);
                if (i.StartsWith("GROUP") && !i.Contains("GROUP_Game_Foreshadowing") && !i.Contains("GROUP_MAX")) Groups.Add(i);
                if (i.StartsWith("LOCATION")) Locations.Add(i);
                if (i.StartsWith("FLAG")) Flags.Add(i);
            }

            for (int i = 0; i < Locations.Count; i++)
                if (!Locations[i].Contains("Encounter")||Locations[i].Contains("Special"))
                    Locations.RemoveAt(i--);

            Locations.Sort();
            Groups.Sort();
            Flags.Sort();
            Terrains.Sort();

            Config.ZoneMaxX = Defines["ZONE_COUNT_X"]-1;
            Config.ZoneMaxY = Defines["ZONE_COUNT_Y"]-1;
            IsParsed = true;
            return (Defines.Count > 10);
        }

        public static void ClearLists()
        {
            Tables.Clear();
            Terrains.Clear();
            Fills.Clear();
            Chances.Clear();
            Groups.Clear();
            Locations.Clear();
            Flags.Clear();
        }
    }
}
