using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FOCommon.Parsers
{
    // Class for editing _vars.fos
    public class VariableParser
    {
        String FileName;
        List<GameVariable> Variables = new List<GameVariable>();

        public VariableParser(String FileName)
        {
            this.FileName = FileName;

        }

        public List<GameVariable> GetVariables() { return Variables; }

        public bool Save(List<GameVariable> SaveVars)
        {
            List<String> Lines = new List<string>();

            String Count = SaveVars.Count.ToString();
            for (int i = Count.Length; i <= 8; i++)
                Count = Count.Insert(0, "0");

            Lines.Add("#ifndef __VARS__");
            Lines.Add("#define __VARS__");
            Lines.Add("/*************************************************************************************");
            Lines.Add("***  VARS  *****  COUNT: "+Count+" ***************************************************");
            Lines.Add("*************************************************************************************/");
            Lines.Add("");
            Lines.Add("");
            foreach (GameVariable Var in SaveVars)
            {
                String Prefix = "";
                if (Var.Type == GameVariableType.Global) Prefix = "GVAR";
                if (Var.Type == GameVariableType.Unicum) Prefix = "UVAR";
                if (Var.Type == GameVariableType.Local) Prefix = "LVAR";
                if (Var.Type == GameVariableType.LocalItem) Prefix = "LIVAR";
                if (Var.Type == GameVariableType.LocalLocation) Prefix = "LLVAR";
                if (Var.Type == GameVariableType.LocalMap) Prefix = "LMVAR";

                String Line = String.Format("#define {0}_{1}", Prefix, Var.Name);
                Lines.Add(Utils.GetSpacedLine(Line, "("+Var.Id+")", 53));
            }
            Lines.Add("");
            Lines.Add("");
            Lines.Add("/*************************************************************************************");
            Lines.Add("	Id	Type	Name		Start	Min	Max	Flags");
            Lines.Add("**************************************************************************************/");
            foreach (GameVariable Var in SaveVars)
            {
                int Flags=0;
                if(Var.Quest) Flags|=1;
                if(Var.Random) Flags|=2;
                if(Var.NoLimit) Flags|=4;

                Lines.Add(String.Format("$\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", Var.Id, (int)Var.Type, Var.Name, 
                    Var.StartValue, Var.MinValue, Var.MaxValue, Flags));
                Lines.Add("**********");

                String[] Desc = Var.Description.Split(new string[]{"\r\n"}, StringSplitOptions.None);
                foreach (String Str in Desc)
                    Lines.Add(Str);
                Lines.RemoveAt(Lines.Count - 1);

                if (Desc.Length == 1)
                    Lines.Add("");

                Lines.Add("**********");
                Lines.Add("");
            }

            File.WriteAllLines(FileName, Lines.ToArray(), Encoding.GetEncoding("Windows-1251"));
            return true;
        }

        public bool Parse()
        {
            if (!File.Exists(FileName))
                return false;

            bool Parse=false;
            bool ParseComment = false;
            string Comment="";
            GameVariable GameVar = null;

            foreach (String Line in File.ReadAllLines(FileName, Encoding.GetEncoding("Windows-1251")))
            {
                if (Line == "**************************************************************************************")
                    Parse = !Parse;
                if (Line == "**********")
                {
                    ParseComment = !ParseComment;
                    if (!ParseComment) // end of variable
                    {
                        if (GameVar != null)
                        {
                            GameVar.Description = Comment;
                            Variables.Add(GameVar);
                        }
                        Comment = "";
                    }
                    else
                        continue;
                }

                if (!Parse || Line.Length < 3)
                    continue;

                if (ParseComment)
                {
                    Comment += Line + Environment.NewLine;
                }

                if (Line[0] == '$')
                {
                    GameVar = new GameVariable();
                    String[] Params = Line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    GameVar.Id = Int32.Parse(Params[1]);
                    GameVar.Type = (GameVariableType)Int32.Parse(Params[2]);
                    GameVar.Name = Params[3];
                    GameVar.StartValue = Int32.Parse(Params[4]);
                    GameVar.MinValue = Int32.Parse(Params[5]);
                    GameVar.MaxValue = Int32.Parse(Params[6]);

                    if (Params.Length > 7)
                    {
                        int Flags = Int32.Parse(Params[7]);
                        GameVar.Quest = ((Flags & 1) == 1);
                        GameVar.Random = ((Flags & 2) == 2);
                        GameVar.NoLimit = ((Flags & 4) == 4);
                    }
                }
            }

            return true;
        }


    }
}
