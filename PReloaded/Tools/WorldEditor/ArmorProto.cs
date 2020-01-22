

namespace WorldEditor
{
    // Add our fields, rest is inherited from base.
    // See SimpleItemProto in FOCommon.
    // Uses SimpleItemProtoParser.
    public class ArmorProto : FOCommon.Items.SimpleItemProto
    {
        public uint Armor_CrTypeMale;
        public uint Armor_CrTypeMale2;
        public uint Armor_CrTypeMale3;
        public uint Armor_CrTypeMale4;
        public uint Armor_CrTypeFemale;
        public uint Armor_CrTypeFemale2;
        public uint Armor_CrTypeFemale3;
        public uint Armor_CrTypeFemale4;

        public override void CreateParseInfo()
        {
            AddParseItem("Armor_CrTypeMale");
            AddParseItem("Armor_CrTypeMale2");
            AddParseItem("Armor_CrTypeMale3");
            AddParseItem("Armor_CrTypeFemale");
            AddParseItem("Armor_CrTypeFemale2");
            AddParseItem("Armor_CrTypeFemale3");
            AddParseItem("Armor_CrTypeFemale4");
        }
    }
}
