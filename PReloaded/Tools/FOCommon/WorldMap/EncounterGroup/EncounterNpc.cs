using System.Collections.Generic;

using FOCommon.Dialog;
using FOCommon.Critter;

namespace FOCommon.Worldmap.EncounterGroup
{
    public class EncounterNpc
    {
        public List<EncounterPerk> Perks { get; set; }
        public List<EncounterItem> Items { get; set; }
        public CritterProto Proto { get; set; }
        public ListDialog Dialog { get; set; }
        public string Script { get; set; }
        public bool Dead { get; set; }
        public int Ratio { get; set; }

        public int ArmorPid { get; set; }
        public int HelmPid { get; set; }
        public int ForcedCrType { get; set; }

        public void AddItem(EncounterItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(EncounterItem item)
        {
            Items.Remove(item);
        }

        public EncounterNpc(int ProtoId, int DialogId, string Script, int Ratio, bool Dead, int ArmorPid, int HelmPid, int ForcedCrType)
        {
            this.Dialog = new ListDialog(DialogId);
            this.Proto = new CritterProto(ProtoId);
            this.Script = Script;
            this.Ratio = Ratio;
            this.Dead = Dead;
            this.ArmorPid = ArmorPid;
            this.HelmPid = HelmPid;
            this.ForcedCrType = ForcedCrType;
            Items = new List<EncounterItem>();
            Perks = new List<EncounterPerk>();
        }
    }
}
