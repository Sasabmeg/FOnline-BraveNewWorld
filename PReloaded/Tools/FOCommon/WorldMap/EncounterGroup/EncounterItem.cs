using System.Collections.Generic;

using FOCommon.Items;

namespace FOCommon.Worldmap.EncounterGroup
{
    public enum SlotEnum
    {
        SLOT_INV,
        SLOT_HAND1,
        SLOT_HAND2
    };

    public class EncounterItem
    {
        public Item Item { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public SlotEnum Slot { get; set; }

        public EncounterItem(int Pid, int Min, int Max, int Slot)
        {
            this.Item = new Item(Pid);
            this.Min = Min;
            this.Max = Max;
            this.Slot = (SlotEnum)Slot;
        }

        public void SetSlot(int Slot)
        {
            this.Slot = (SlotEnum)Slot;
        }
    }
}
