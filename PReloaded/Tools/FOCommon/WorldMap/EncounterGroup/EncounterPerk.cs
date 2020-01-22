using System;
using System.Collections.Generic;
using System.Text;

namespace FOCommon.Worldmap.EncounterGroup
{
    public class EncounterPerk
    {
        public string Define { get; set; }
        public int Index { get; set; }
        public int Level { get; set; }
        public int Chance { get; set;}

        public EncounterPerk() { }

        public EncounterPerk(string Define, int Index, int Level, int Chance)
        {
            this.Define = Define;
            this.Index  = Index;
            this.Level  = Level;
            this.Chance = Chance;
        }
    }
}
