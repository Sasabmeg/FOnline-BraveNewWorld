using System;
using System.Collections.Generic;
using System.IO;

using FOCommon.Parsers;
using FOCommon.Script;

namespace FOCommon.Parsers
{
    // This class is for parsing scripts.cfg
    // TODO: Add functionality to modify/save.
    public class ScriptListParser : BaseParser, IParser
    {
        string filename;
        List<ScriptDeclaration> Scripts = new List<ScriptDeclaration>();
        List<string> Lines = new List<string>();

        public ScriptListParser(string filename)
        {
            this.filename = filename;
        }

        public bool Parse()
        {
            if (!File.Exists(filename))
                return false;

            ScriptApp App = ScriptApp.Server;
            ScriptType Type = ScriptType.Module;

            Lines.Clear();
            Lines.AddRange(File.ReadAllLines(filename));
            foreach (string Line in Lines)
            {
                if (string.IsNullOrEmpty(Line?.Trim() ?? string.Empty) || Line.TrimStart(new char[] { ' ', '\t' }).StartsWith("#") || Line.TrimStart(new char[] { ' ', '\t' }).StartsWith(";"))
                    continue;

                if (Line[0] == '[')
                {
                    if (Line.ToLower().Contains("server"))
                        App = ScriptApp.Server;
                    else if (Line.ToLower().Contains("client"))
                        App = ScriptApp.Server;
                    else if (Line.ToLower().Contains("mapper"))
                        App = ScriptApp.Server;
                    else
                        return false;

                    if (Line.ToLower().Contains("scripts"))
                        Type = ScriptType.Module;
                    else if (Line.ToLower().Contains("binds"))
                        Type = ScriptType.Bind;
                    else
                        return false;

                    continue;
                }

                string[] row = Line.Split('=');
                string[] parameters = row[1].Split(new char[] { '#', ';' });
                string param = String.Join(" ", parameters[0].Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries));

                bool Enabled;
                string Reserved = "";

                Enabled = Type == ScriptType.Bind || param.ToLower() == "load";

                string Name = row[0].Trim(new char[] { ' ', '\t' });
                List<string> Desc = new List<string>();

                if (Type == ScriptType.Bind)
                    Reserved = param;

                ScriptDeclaration script = new ScriptDeclaration(Name, App, Type, Enabled);

                script.Description = (parameters.Length > 1) ? parameters[1].Trim(new char[] { ' ', '\t' }) : "";
                script.ReservedPlace = Reserved;
                Scripts.Add(script);
            }
            _IsParsed = true;
            return true;
        }

        public List<ScriptDeclaration> GetScripts()
        {
            return Scripts;
        }
    }
}
