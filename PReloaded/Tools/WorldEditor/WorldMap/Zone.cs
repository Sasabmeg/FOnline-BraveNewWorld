using System;
using System.Collections.Generic;

namespace WorldEditor
{
    public interface IZone
    {
        int X { get; set; }
        int Y { get; set; }
        string Chance { get; set; }
        string Terrain { get; set; }
        string Fill { get; set; }
        bool Modified { get; set; }
        bool Brushed { get; set; }
        IZone Clone();
    }

    public interface IExtZone : IZone
    {
        List<EncounterZoneGroup> EncounterGroups { get; set; }
        List<EncounterZoneLocation> EncounterLocations { get; set; }
        List<String> Flags { get; set; }
        string MorningChance { get; set; }
        string AfternoonChance { get; set; }
        string NightChance { get; set; }
        int Difficulty { get; set; }
    }

    public class Zone : IExtZone
    {
        public Zone(int x, int y)
        {
            X = x;
            Y = y;
            Modified = false;
        }

        public bool Brushed { get; set; }
        public List<EncounterZoneGroup> EncounterGroups { get; set; }
        public List<EncounterZoneLocation> EncounterLocations { get; set; }
        public List<String> Flags { get; set; }
        public bool Modified { get; set; }
        public string Chance { get; set; }
        public string MorningChance { get; set; }
        public string AfternoonChance { get; set; }
        public string NightChance { get; set; }
        public string Terrain { get; set; }
        public string Fill { get; set; }
        public int Difficulty { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public IZone Clone() { return ((Zone)this.MemberwiseClone()); }

        public bool ContainsGroupWithName(string name)
        {
            if (EncounterGroups == null)
                return false;

            foreach (EncounterZoneGroup i in EncounterGroups)
            {
                if (i.Name == name)
                    return true;
            }
            return false;
        }

        public bool ContainsLocationWithName(string name)
        {
            if (EncounterLocations == null)
                return false;
            foreach (EncounterZoneLocation i in EncounterLocations)
            {
                if (i.Name == name)
                    return true;
            }
            return false;
        }

        public List<string> LocationsToStringList()
        {
            if (EncounterLocations == null)
                return null;

            List<string> slist = new List<string>();

            foreach (EncounterZoneLocation i in EncounterLocations)
            {
                slist.Add(i.Name);
            }
            return slist;
        }

        public List<string> GroupsToStringList()
        {
            List<string> slist = new List<string>();
            foreach (EncounterZoneGroup i in EncounterGroups)
            {
                slist.Add(i.Name);
            }
            return slist;
        }
    }
}
