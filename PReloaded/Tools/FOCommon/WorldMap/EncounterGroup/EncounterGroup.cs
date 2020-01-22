using System.Collections.Generic;

using FOCommon.Parsers;

namespace FOCommon.Worldmap.EncounterGroup
{
    // This class maps to CEncounterObject@ in worldmap.fos, used in WorldEditor, which is the reason for the Zone* variables.
    public class EncounterGroup : IZoneProperty
    {
        public string GetName() { return Name; }

        public string Name { get; set; }
        public string GMName { get; set; }
        public int Id { get; set; }
        public int Spacing { get; set; }
        public int Position { get; set; }
        public string FactionName { get; set; }
        public int FactionId { get; set; }
        public int FactionMode { get; set; }
        public int RatioMin { get; set; }
        public int RatioMax { get; set; }
        public float QuantityDay { get; set; }
        public float QuantityNight { get; set; }
        public int DistMin { get; set; }
        public int DistMax { get; set; }

        public int NpcCount { get; set; }
        public int Quantity { get; set; }

        public List<EncounterNpc> Npcs { get; set; }
        public List<EncounterItem> Items { get; set; }

        public int ZoneCount { get; set; }
        public int ZoneAvg { get; set; }
        public int ZoneMed { get; set; }
        public int ZoneMin { get; set; }
        public int ZoneMax { get; set; }

        public EncounterGroup()
        {
            Init();
        }

        private void Init()
        {
            Npcs = new List<EncounterNpc>();
            Items = new List<EncounterItem>();
        }

        public EncounterGroup(string Name, int Id)
        {
            Init();
            this.Name = Name;
            this.Id = Id;
        }

        public EncounterGroup(string Name, int Position, int Spacing, int RatioMin, int RatioMax, int FactionId, int FactionMode, float QuantityDay, float QuantityNight, int DistMin, int DistMax)
        {
            Init();
            this.Name = Name;
            this.Spacing = Spacing;
            this.Position = Position;
            this.FactionId = FactionId;
            this.FactionMode = FactionMode;
            this.RatioMin = RatioMin;
            this.RatioMax = RatioMax;
            this.QuantityDay = QuantityDay;
            this.QuantityNight = QuantityNight;
            this.DistMin = DistMin;
            this.DistMax = DistMax;
            Npcs = new List<EncounterNpc>();
            Items = new List<EncounterItem>();
        }

        public EncounterGroup Clone()
        {
            return ((EncounterGroup)this.MemberwiseClone());
        }
    }
}