using System;

namespace WorldEditor
{
    public interface IFilter
    {
        String Terrain { get; set; }
        String Chance { get; set; }
        bool FilterTerrain { get; set; }
        bool FilterChance { get; set; }
    }

    class SDKFilter : IFilter
    {
        public SDKFilter(bool FilterTerrain, bool FilterChance, bool FilterTable,
                         String Terrain, String Chance, String Table)
        {
            this.FilterTerrain = FilterTerrain;
            this.FilterChance = FilterChance;
            this.FilterTable = FilterTable;
            this.Terrain = Terrain;
            this.Chance = Chance;
            this.Table = Table;
        }

        public String Terrain { get; set; }
        public String Chance { get; set; }
        public String Table { get; set; }
        public bool FilterTerrain { get; set; }
        public bool FilterChance { get; set; }
        public bool FilterTable { get; set; }
    }

    class DefaultFilter : IFilter
    {
         public DefaultFilter(bool FilterTerrain, bool FilterChance, bool FilterNoLocation, bool FilterNoGroup, 
             bool FilterLocation, bool FilterGroup, bool FilterFlag,
                 String Terrain, String Chance, String Group, String Location, String Flag)
        {
            this.FilterTerrain = FilterTerrain;
            this.FilterChance = FilterChance;
            this.FilterNoLocation = FilterNoLocation;
            this.FilterNoGroup = FilterNoGroup;
            this.FilterLocation = FilterLocation;
            this.FilterGroup = FilterGroup;
            this.FilterFlag = FilterFlag;
            this.Terrain = Terrain;
            this.Chance = Chance;
            this.Group = Group;
            this.Location = Location;
            this.Flag = Flag;
        }

        public String Terrain { get; set; }
        public String Chance { get; set; }
        public String Group { get; set; }
        public String Location { get; set; }
        public String Flag { get; set; }
        public bool FilterTerrain { get; set; }
        public bool FilterChance { get; set; }

        public bool FilterNoLocation { get; set; }
        public bool FilterNoGroup { get; set; }
        public bool FilterLocation { get; set; }
        public bool FilterGroup { get; set; }
        public bool FilterFlag { get; set; }
    }
}
