using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

namespace FOCommon.Parsers
{
    // TODO: rewrite this piece of crap, it's unmaintainable. 
    // Idea: Instead of reading buffer (like now) from file and then modifying this buffer and lastly writing it to disk, read everything into an List<T>
    // including comments, then modify the List when doing changes, and finally iterate over it when saving. Result: less complexity and better code.
    // the main reason for current design if I recall correctly is that I wanted to preserve comments that were on MSG lines, like on this one:
    // {1600}{}{This is an example value} #Example comment...

    public class MSGParser
    {
        public MSGParser(string filename)
        {
            this.filename = filename;
        }
        Dictionary<int, List<string>> Data = new Dictionary<int, List<string>>();
        Dictionary<int, List<int>> IdToLine = new Dictionary<int, List<int>>();
        List<String> Lines = new List<string>();
        string filename;

        public bool IsParsed { get; set; }

        public string GetFilename() { return filename; }

        public bool IdExists(int Id) { return IdToLine.ContainsKey(Id); }

        public void WriteFile()
        {
            if (!File.Exists(filename))
                Utils.Log(filename + " doesn't exist. Can't write data.");
            else
            {
                File.WriteAllLines(filename, Lines.ToArray(), new UTF8Encoding(false));
                Utils.Log("Data written to " + filename);
            }
        }

        //{Id}{}{Value}
        private int ParseId(string Line)
        {
            if (Line.Length == 0) return -1;
            if (Line.Length > 0 && Line[0] != '{') return -1;
            return Int32.Parse(Line.Substring(1, Line.IndexOf('}') - 1));
        }

        private void ReadData()
        {
            Data.Clear();
            IdToLine.Clear();
            for (int i = 0; i < Lines.Count; i++)
            {
                int Id = ParseId(Lines[i]);
                if (Id == -1) continue;
                string Value = Lines[i];
                int BraceCount=0;

                int entryLine = i; // Which line an entry begins on, important for multiline

                foreach (Char c in Value)
                    if (c == '}') BraceCount++;
                if (BraceCount == 2) // multiline
                {
                    int LastBraceIndex = Value.LastIndexOf('}');
                    do
                    {
                        Value += "\n" + Lines[++i];
                    } while (Value.LastIndexOf('}') == LastBraceIndex);
                    int efb = Value.LastIndexOf('{') + 1;
                    Value = Value.Substring(efb, Value.LastIndexOf('}') - (efb));
                }
                else
                {
                    int efb = Value.LastIndexOf('{')+1;
                    Value = Value.Substring(efb, Value.LastIndexOf('}') - (efb));
                }


                if (!Data.ContainsKey(Id))
                    Data.Add(Id, new List<string>());
                Data[Id].Add(Value);
                if (!IdToLine.ContainsKey(Id))
                {
                    List<int> IdLines = new List<int>();
                    IdLines.Add(entryLine);
                    IdToLine.Add(Id, IdLines);
                }
                else
                {
                    List<int> IdLines = IdToLine[Id]; // this id is present on these lines
                    if (!IdLines.Contains(entryLine))
                        IdLines.Add(entryLine);
                }
            }
        }

        public bool Parse()
        {
            if (!File.Exists(filename))
            {
                Utils.Log(filename + " doesn't exist. Can't parse data.");
                return false;
            }

            Lines.Clear();
            Lines.AddRange(File.ReadAllLines(filename, new UTF8Encoding(false)));
            ReadData();
            
            Utils.Log(filename + " parsed.");
            IsParsed = true;
            return true;
        }

        public void CleanFromTo(ref List<string> lines, int i, string to)
        {
            do
            {
                lines.RemoveAt(i);
            } while (!lines[i+1].Contains(to));
        }

        public int GetLineIndex(List<string> lines, string lineContains)
        {
            for (int i = 0; i < lines.Count; i++)
                if (lines[i].Contains(lineContains))
                    return i;
            return -1;
        }

        public List<string> GetLines()
        {
            return Lines;
        }

        public int GetLineFromId(int id, int index)
        {
            if (!IdToLine.ContainsKey(id))
                return -1;

            List<int> IdLines = IdToLine[id];
            if (IdLines.Count - 1 < index)
                index = 0;

            return IdLines[index];
        }

        protected string FormatMSGLine(int id, string val)
        {
            return "{" + id + "}{}{" + val + "}";
        }

        private int FindNearestLowerIdLine(int TargetId)
        {
            int FoundId=0;
            int FoundLine=0;
            for (int i = 0; i < Lines.Count; i++)
            {
                int id = ParseId(Lines[i]);
                if (id == -1) continue;

                if (id < TargetId && id > FoundId)
                {
                    FoundId = id;
                    FoundLine = i;
                }
                if (id > TargetId)
                    return FoundLine;
            }
            return FoundLine;
        }

        // We use this to find where multi line entry starts, example:
        /*
         * {902001}{}{Small paper, with some name and password:
            1-8Turner
            a58ew64v}
         */
        public int GetFirstLineOfEntry(int lineId)
        {
            for (int i = lineId; i > 0; i--)
            {
                if (ParseId(Lines[i]) != -1)
                    return i;
            }
            return -1;
        }

        // if index=0, then overwrite first occurance of id<->value pair, if it exists, else, create a new line.
        public void WriteMSGLine(int id, string val, int index)
        {
            if (IdToLine.ContainsKey(id))
            {
                List<int> IdLines = IdToLine[id];
                if (IdLines.Count - 1 < index)
                    index = 0;

                string Line = Lines[IdLines[index]];

                if (val.Contains("\n"))
                {
                    string[] vals = val.Split("\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < vals.Length; i++)
                    {
                        if (i == 0) Lines[IdLines[index]] = "{" + id + "}{}{" + vals[0];
                        else if (i == vals.Length - 1) Lines[IdLines[index] + i] = vals[i] + "}";
                        else Lines[IdLines[index] + i] = vals[i];
                    }
                }
                else
                {
                    string Comments = Line.Substring(Line.LastIndexOf('}') + 1, Line.Length - Line.LastIndexOf('}') - 1);
                    Lines[IdLines[index]] = FormatMSGLine(id, val) + Comments;
                }
                
            }
            else
            {
                int line = FindNearestLowerIdLine(id);
                Lines.Insert(line+1, FormatMSGLine(id, val));
                ReadData();
            }
        }

        public int GetMSGValuesCount(int id)
        {
            if (!Data.ContainsKey(id))
                return 0;

            return Data[id].Count;
        }

        public String GetMSGValue(int id, Regex FromLine, Regex ToLine)
        {
            List<String> Values = GetMSGValues(id, FromLine, ToLine);
            if (Values!=null && Values.Count>0)
                return Values[0];
            return "";
        }

        public string GetMSGValue(int id)
        {
            if (!Data.ContainsKey(id))
                return "";

            return Data[id][0];
        }

        public List<string> GetMSGValues(int id)
        {
            if (!Data.ContainsKey(id))
                return null;

            return Data[id];
        }

        public Dictionary<int, List<string>> GetMSGValues(int FromId, int ToId, Regex FromLine, Regex ToLine)
        {
            Dictionary<int, List<string>> ValueRangeList = new Dictionary<int,List<string>>();
            foreach (KeyValuePair<int, List<string>> kvp in Data)
            {
                if(kvp.Key<FromId||kvp.Key>ToId)
                    continue;
                List<String> Values = GetMSGValues(kvp.Key, FromLine, ToLine);
                if(Values!=null && Values.Count>0)
                    ValueRangeList[kvp.Key]=Values;
            }
            return ValueRangeList;
        }

        // Return only values which are between specific lines (first occurances) in the file
        // If ToLine = null, FromLine -> EOF
        public List<string> GetMSGValues(int id, Regex FromLine, Regex ToLine)
        {
            if (!Data.ContainsKey(id))
                return null;

            int SearchLineId = 0;
            int SLine = 0;
            int ELine = Lines.Count;
            foreach (String Li in Lines)
            {
                if (FromLine.Match(Li).Success)
                    SLine = SearchLineId;
                if (ToLine != null)
                {
                    if (ToLine.Match(Li).Success && SLine != 0 && SLine != SearchLineId)
                    {
                        ELine = SearchLineId;
                        break;
                    }
                }
                SearchLineId++;
            }

            List<string> ResultValues = new List<string>();
            List<string> Values = Data[id];
            List<int> IdLines = IdToLine[id];
            for (int i = 0; i < IdLines.Count; i++)
                if (IdLines[i] > SLine && IdLines[i] < ELine)
                    ResultValues.Add(Values[i]);

            return ResultValues;
        }

        public Dictionary<int,string> GetData()
        {
            Dictionary<int, string> SingleDataDict = new Dictionary<int, string>();
            foreach (KeyValuePair<int, List<string>> kvp in Data)
                SingleDataDict.Add(kvp.Key, kvp.Value[0]);

            return SingleDataDict;
        }

        public Dictionary<int, List<string>> GetMultiValueData()
        {
            return Data;
        }

        public Dictionary<int, string> GetSpecificData(int fromId, int toId)
        {
            Dictionary<int, string> SData = new Dictionary<int, string>();
            
            foreach(KeyValuePair<int, List<string>> kvp in Data)
            {
                if(kvp.Key>=fromId&&kvp.Key<=toId)
                    SData.Add(kvp.Key, kvp.Value[0]);
            }
            return SData;
        }
    }
}
