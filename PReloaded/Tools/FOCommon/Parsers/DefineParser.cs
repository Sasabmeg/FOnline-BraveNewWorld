using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace FOCommon.Parsers
{
    // TODO: Make compatible with IParser
    // TODO: Break out param stuff and unify with IDefineParser
    public class DefineParam
    {
        public readonly int Index;
        private string ParamName = "";
        public string Name
        {
            get
            {
                if (ParamName.Length == 0)
                    return ("PARAM_" + Index);
                else
                    return (ParamName);
            }
            set
            {
                ParamName = value;
            }
        }
        public string Group = "";

        public DefineParam(int index)
        {
            Index = index;
        }

        public DefineParam(int index, string name)
        {
            Index = index;
            Name = name;
        }

        public DefineParam(int index, string name, string group)
        {
            Index = index;
            Name = name;
            Group = group;
        }
    }

    public class DefineParser
    {
        private ParseError _parseError = null;

        public Dictionary<string, int> Defines = new Dictionary<string,int>();
        public Dictionary<string, int> ParamsRaw = new Dictionary<string,int>();
        public List<DefineParam> Params = new List<DefineParam>();

        public List<string> KeysToList()
        {
            return new List<string>(Defines.Keys);
        }

        void SetError(string fileName, Exception exception, string errorLine)
        {
            _parseError = new ParseError();
            _parseError.ErrorLine = errorLine;
            _parseError.File = fileName;
            _parseError.Exception = exception;
        }

        public ParseError Error { get { return _parseError; } }


        private void LoadParams()
        {
            // Code by Wipe
            foreach (KeyValuePair<string, int> define in Defines)
            {
                string regexp = "^(ST|SK|TAG|TO|PE|ADDICTION|KARMA|DAMAGE|MODE|TRAIT|REPUTATION|FV)_([A-Z0-9_]+)$";
                Match match = Regex.Match(define.Key, regexp);
                if (match.Success)
                {
                    if (match.Groups[1].Value == "DAMAGE" && define.Value < 10)
                        continue;

                    if (match.Groups[2].Value == "BEGIN" ||
                        match.Groups[2].Value == "END" ||
                        match.Groups[2].Value == "COUNT")
                        continue;

                    if ((match.Groups[2].Value.Length >= 4 && match.Groups[2].Value.Substring(0, 4) == "EXT_") ||
                        (match.Groups[2].Value.Length >= 5 && match.Groups[2].Value.Substring(0, 5) == "FLAG_"))
                        continue;

                    DefineParam param = Params.Find(x => x.Index == define.Value);
                    if (param != null)
                    {
                        param.Name = define.Key;
                    }
                    else
                    {
                        Params.Add(new DefineParam(define.Value, define.Key));
                        ParamsRaw.Add(define.Key, define.Value);
                    }
                }
            }
        }

        public List<DefineParam> GetParams()
        {
            if (Params.Count > 0)
                return Params;
            if (Defines.Count == 0)
                return null;
            LoadParams();
            return Params;
        }

        public Dictionary<String, int> GetRawParams()
        {
            if (Params.Count > 0)
                return ParamsRaw;
            if (Defines.Count == 0)
                return null;
            LoadParams();
            return ParamsRaw;
        }

        public Dictionary<String, int> GetDefinesByPrefix(string[] Prefixes)
        {
            Dictionary<String, int> DefineDict = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> define in Defines)
            {
                foreach(string Prefix in Prefixes)
                    if (define.Key.StartsWith(Prefix))
                        DefineDict.Add(define.Key, define.Value);
            }
            return DefineDict;
        }

        public Dictionary<String, int> GetDefinesByPrefix(string Prefix)
        {
            return GetDefinesByPrefix(new string[] { Prefix });
        }

        public bool ReadDefines(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return false;
            }

            string currentLine = String.Empty;

                List<string> lines = new List<string>(File.ReadAllLines(fileName));

            try
            {
                foreach (string line in lines)
                {
                    currentLine = line;
                    char[] sep = { ' ', '\t' };
                    string[] splittedLine = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    if (splittedLine.Length > 2 && splittedLine[0] == "#define")
                    {
                        bool parseHex = false;
                        string val="";
                        if (splittedLine[2] == "(") // ( x ) format
                        {
                            for (int i = 2; i < splittedLine.Length; i++)
                            {
                                val += splittedLine[i];
                                if (splittedLine[i].Contains(")"))
                                    break;
                            }
                            val = val.Trim(' ', '(', ')');
                        }
                        else
                            val = splittedLine[2].Trim('(', ')');
                        if (val.Length > 2 && val[0] == '0' && val[1] == 'x')
                        {
                            val = val.Remove(0, 2);
                            parseHex = true;
                        }
                        int x;
                        if (Int32.TryParse(val, (parseHex ? NumberStyles.HexNumber : NumberStyles.Integer), CultureInfo.InvariantCulture.NumberFormat, out x))
                        {
                            if (!Defines.ContainsKey(splittedLine[1]))
                                Defines.Add(splittedLine[1], x);
                        }
                    }
                }
                
                return true;
            }
            catch (IndexOutOfRangeException ex)
            {
                Utils.Log("Failed to parse line: '" + currentLine + "' in " + fileName);
                SetError(fileName, ex, currentLine);
                return false;
            }
        }
    }
}
