using System;
using System.Collections.Generic;
using System.Text;

namespace FOCommon.Items
{
    public class ParseItem
    {
        public string VarName { get; set; }
        public string FieldName { get; set; }
        public ParseItem(String fieldName, String varName)
        {
            this.VarName = varName;
            this.FieldName = fieldName;
        }
    }

    // Skeleton for implementation of partial parser.
    // If you want to parse a proto fully, use ItemProto and ItemProtoParser.
    public abstract class SimpleItemProto : System.IComparable<SimpleItemProto>
    {
        public string FileName;
        public UInt16 ProtoId  { get; set; }
        public string Name  { get; set; } // FOOBJ.msg
        public string Description  { get; set; } // FOOBJ.msg

        static readonly List<ParseItem> ParseItems = new List<ParseItem>();

        public int CompareTo(SimpleItemProto prot)
        {
            if (this.ProtoId < prot.ProtoId) return -1;
            if (this.ProtoId == prot.ProtoId) return 0;
            return 1;
        }

        protected void AddParseItem(string fieldName, string varName)
        {
            ParseItems.Add(new ParseItem(fieldName, varName));
        }

        // If FieldName==VarName
        protected void AddParseItem(string name)
        {
            ParseItems.Add(new ParseItem(name, name));
        }


        public abstract void CreateParseInfo(); // Fill with AddParseItem
        public List<ParseItem> GetParseInfo()
        {
            if (ParseItems.Count > 0)
                return ParseItems;
            CreateParseInfo();
            return ParseItems;
        }
    }

    class ExampleSimpleItemProto : SimpleItemProto
    {
        public uint Armor_CrTypeMale = 0;
        public uint Armor_CrTypeMale2 = 0;
        public uint Armor_CrTypeMale3 = 0;
        public uint Armor_CrTypeMale4 = 0;
        public uint Armor_CrTypeFemale = 0;
        public uint Armor_CrTypeFemale2 = 0;
        public uint Armor_CrTypeFemale3 = 0;
        public uint Armor_CrTypeFemale4 = 0;

        public override void CreateParseInfo()
        {
            AddParseItem("Armor_CrTypeMale", "Armor_CrTypeMale");
            AddParseItem("Armor_CrTypeMale2", "Armor_CrTypeMale2");
            AddParseItem("Armor_CrTypeMale3", "Armor_CrTypeMale3");
            AddParseItem("Armor_CrTypeFemale");
            AddParseItem("Armor_CrTypeFemale2");
            AddParseItem("Armor_CrTypeFemale3");
            AddParseItem("Armor_CrTypeFemale4");
        }
    }
}
