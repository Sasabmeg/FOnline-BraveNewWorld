using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using FOCommon.Items;

namespace FOCommon.Parsers
{
    public class SimpleItemProtoParser
    {
        private string ItemObjectName;
        private string FieldName;
        private string FieldValue;
        private List<SimpleItemProto> LoadedProtos = new List<SimpleItemProto>();

        public SimpleItemProtoParser(object SimpleItemProtoDerivedObject)
        {
            this.ItemObjectName = SimpleItemProtoDerivedObject.GetType().AssemblyQualifiedName;
        }

        public List<SimpleItemProto> LoadProtosFromFile(String Path, MSGParser FOObj, out bool DuplicatesFound)
        {
            List<String> Lines = new List<string>(File.ReadAllLines(Path));
            return Load(Path, Lines, FOObj, out DuplicatesFound);
        }

        public SimpleItemProto CreateInstance() { return (SimpleItemProto)Activator.CreateInstance(Type.GetType(ItemObjectName)); }

        public void SetField(ref SimpleItemProto Prot, string Variable, string Value)
        {
            Prot.GetType().GetField(Variable).SetValue(Prot, Convert.ChangeType(Value, Prot.GetType().GetField(Variable).FieldType));
        }

        private void LoadData(SimpleItemProto Prot)
        {
            List<ParseItem> ParseItems = Prot.GetParseInfo();
            foreach (ParseItem PI in ParseItems)
            {
                if (FieldName == PI.FieldName) { SetField(ref Prot, PI.FieldName, FieldValue); continue; }
            }
        }

        public List<SimpleItemProto> Load(string FilePath, List<String> Lines, MSGParser FOObj, out bool DuplicateFound)
        {
            SimpleItemProto Prot = null;
            DuplicateFound = false;

            List<int> ProcessedPids = new List<int>();

            foreach (SimpleItemProto LProt in LoadedProtos)
                ProcessedPids.Add(LProt.ProtoId);

            int j = Lines.Count;
            for (int i = 0; i < j; i++)// String Line in Lines)
            {
                String Line = Lines[i];
                if (Line == "[Proto]" || i == Lines.Count - 1)
                {
                    if (Prot != null)
                    {
                        if (FOObj != null)
                        {
                            Prot.Name = FOObj.GetMSGValue(Prot.ProtoId * 100);
                            Prot.Description = FOObj.GetMSGValue(Prot.ProtoId * 100 + 1);
                        }
                        Prot.FileName = Path.GetFileName(FilePath);
                        if (ProcessedPids.Contains(Prot.ProtoId))
                        {
                            DuplicateFound = true;
                            Utils.Log("An object with the ProtoId " + Prot.ProtoId + " was already loaded. Overwriting proto.");
                            for (ushort u = 0; u < LoadedProtos.Count; u++)
                                if (LoadedProtos[u].ProtoId == Prot.ProtoId)
                                    LoadedProtos[u] = Prot;
                        }
                        else
                            LoadedProtos.Add(Prot);

                        ProcessedPids.Add(Prot.ProtoId);
                    }
                    Prot = CreateInstance();
                    continue;
                }

                if (string.IsNullOrEmpty(Lines[i]) || (Lines[i].Length > 0 && Lines[i][0] == '#'))
                    continue;

                String[] Parts = Line.Split('=');
                if (Parts.Length != 2)
                    continue;
                FieldName = Parts[0].Trim();
                FieldValue = Parts[1].TrimStart(' ', '\t');

                if (Prot == null) continue;
                if (FieldName == "ProtoId") { Prot.ProtoId = ushort.Parse(FieldValue); }

                LoadData(Prot);
            }
            return LoadedProtos;
        }
    }
}
