using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using FOCommon.Dialog;
using System.Text.RegularExpressions;

namespace FOCommon.Parsers
{
    public class DialogParser
    {
        readonly MSGParser _textStrings;
        readonly String _fileName;
        readonly List<String> _lines = new List<string>();
        FOCommon.Dialog.Dialog _dialog;

        public DialogParser(String fileName)
        {
            this._fileName = fileName;
            _textStrings = new MSGParser(fileName);
        }

        public FOCommon.Dialog.Dialog GetDialog() { return _dialog; }

        public bool IsLastTok(String[] parts, char tok)
        {
            return (parts[parts.Length-1]==tok.ToString());
        }

        private void AddDynamic(Answer answer, Dynamic dynamic, bool recheck)
        {
            if (dynamic is Demand)
            {
                var demand = (Demand)dynamic;
                demand.NoRecheck = recheck;
                answer.Demands.Add(demand);
            }
            if (dynamic is Result)
            {
                var result = (Result)dynamic;
                answer.Results.Add(result);
            }
        }
        
        public bool Parse()
        {
            if (!File.Exists(_fileName))
            {
                Utils.Log(_fileName + " doesn't exist. Can't parse data.");
                return false;
            }

            _lines.Clear();
            _lines.AddRange(File.ReadAllLines(_fileName, Encoding.GetEncoding("Windows-1251")));

            bool parseMode=false;
            bool isNode = true;

            Node node = null;
            var languages = new List<string>();

            _textStrings.Parse();
            var langEndLine = new Regex("^\\[.*\\]");

            int answerNum=0;
            int nodeNum = 0;
            _dialog = new Dialog.Dialog();

            int parseLine=0;
            foreach (string line in _lines)
            {
                parseLine++;
                if (line == "[dialog]")
                {
                    parseMode = true;
                    continue;
                }

                if (parseLine == 2)
                    _dialog.Comment = line;

                if (line.Contains("lang="))
                {
                    string langStr = line.Substring(5, line.Length - 5);
                    languages.AddRange(langStr.Split(' '));
                    _dialog.LanguageTrees = languages;

                    foreach (String lang in languages)
                    {
                        ParseLanguageStrings(langEndLine, lang);
                    }
                }

                if (!parseMode)
                    continue;
                if (String.IsNullOrEmpty(line))
                    break;

                if (line == "&")
                {
                    continue;
                }
                String[] parts = line.Split(' ');
                if (isNode)
                {
                    node = ParseNode(langEndLine, languages, parts, ref nodeNum);
                }
                else // It's an answer
                {
                    var ans = ParseAnswer(answerNum, langEndLine, parts, languages, nodeNum);
                    node.Answers.Add(ans);
                }
                if (IsLastTok(parts, '@'))
                {
                    _dialog.Nodes.Add(node);
                    isNode = true;
                    answerNum = 0;
                }
                else
                {
                    answerNum++;
                    isNode = false;
                }

                if (IsLastTok(parts, '&'))
                {
                    _dialog.Nodes.Add(node);
                    parseMode = false;
                }
            }
            return true;
        }

        private Node ParseNode(Regex langEndLine, IEnumerable<string> languages, string[] parts, ref int nodeNum)
        {
            nodeNum++;
            var node = new Node {Id = Int32.Parse(parts[0]), ScriptString = parts[2], ShuffleAnswers = (parts[3] != "1")};

            foreach (String lang in languages)
            {
                Regex langStartLine = new Regex("^\\[" + lang + "\\]");
                node.Text[lang] = _textStrings.GetMSGValue(nodeNum*1000, langStartLine, langEndLine);
            }
            return node;
        }

        private Answer ParseAnswer(int answerNum, Regex langEndLine, string[] parts, IEnumerable<string> languages, int nodeNum)
        {
            Answer ans = new Answer();
            ans.ToNode = Int32.Parse(parts[0]);
            foreach (String lang in languages)
            {
                Regex langStartLine = new Regex("^\\[" + lang + "\\]");
                ans.Text[lang] = _textStrings.GetMSGValue(nodeNum*1000 + (answerNum*10), langStartLine, langEndLine);
            }

            if (parts.Length > 3)
            {
                int i = 2;
                bool noRecheck = false;
                Dynamic dyn = null;
                do
                {
                    if (parts[i] == "_script")
                    {
                        FuncCall call = new FuncCall();
                        call.ScriptString = parts[++i];
                        int argsNum = Int32.Parse(parts[++i]);
                        if (argsNum != 0)
                        {
                            for (int k = 0; k < argsNum; k++)
                                call.Args.Add(parts[++i]);
                        }
                        dyn.FuncCall = call;
                        AddDynamic(ans, dyn, noRecheck);
                    }
                    else if (parts[i] == "_item")
                    {
                        dyn.Item = new DialogItem();
                        dyn.ForPlayer = (parts[++i] == "p");
                        dyn.Item.PidDefine = parts[++i];
                        dyn.Operator = Dialog.Dialog.GetOperator(parts[++i]);
                        dyn.Value = Int32.Parse(parts[++i]);
                        AddDynamic(ans, dyn, noRecheck);
                    }
                    else if (parts[i] == "_var")
                    {
                        dyn.Var = new GameVariable();
                        dyn.ForPlayer = (parts[++i] == "p");
                        dyn.Var.Name = parts[++i];
                        dyn.Operator = Dialog.Dialog.GetOperator(parts[++i]);
                        dyn.Value = Int32.Parse(parts[++i]);
                        AddDynamic(ans, dyn, noRecheck);
                    }
                    else if (parts[i] == "_param")
                    {
                        dyn.Param = new Parameter();
                        dyn.ForPlayer = (parts[++i] == "p");
                        dyn.Param.ParamDefine = parts[++i];
                        dyn.Operator = Dialog.Dialog.GetOperator(parts[++i]);
                        dyn.Value = Int32.Parse(parts[++i]);
                        AddDynamic(ans, dyn, noRecheck);
                    }
                    else if (parts[i] == "no_recheck")
                    {
                        noRecheck = true;
                    }
                    else if (parts[i] == "R")
                    {
                        dyn = new Result();
                        noRecheck = false;
                    }
                    else if (parts[i] == "D")
                    {
                        dyn = new Demand();
                        noRecheck = false;
                    }

                    i++;
                } while (i < parts.Length - 1);
            }
            return ans;
        }

        private void ParseLanguageStrings(Regex langEndLine, string lang)
        {
            Regex langStartLine = new Regex("^\\[" + lang + "\\]");

            _dialog.NpcName[lang] = _textStrings.GetMSGValue(100, langStartLine, langEndLine);
            _dialog.DescriptionAlive[lang] = _textStrings.GetMSGValues(200, langStartLine, langEndLine);
            _dialog.DescriptionAliveFull[lang] = _textStrings.GetMSGValues(210, langStartLine, langEndLine);
            _dialog.DescriptionKnocked[lang] = _textStrings.GetMSGValues(220, langStartLine, langEndLine);
            _dialog.DescriptionKnockedFull[lang] = _textStrings.GetMSGValues(230, langStartLine, langEndLine);
            _dialog.DescriptionDead[lang] = _textStrings.GetMSGValues(240, langStartLine, langEndLine);
            _dialog.DescriptionDeadFull[lang] = _textStrings.GetMSGValues(250, langStartLine, langEndLine);
            _dialog.DescriptionCriticalDead[lang] = _textStrings.GetMSGValues(260, langStartLine, langEndLine);
            _dialog.DescriptionCriticalDeadFull[lang] = _textStrings.GetMSGValues(270, langStartLine, langEndLine);

            _dialog.UserStrings[lang] = _textStrings.GetMSGValues(100000000, 999999999, langStartLine, langEndLine);
        }

        string MSGFormat(int id, string value)
        {
            return "{" + id.ToString() + "}{}{" + value + "}";
        }

        public bool Save(FOCommon.Dialog.Dialog dialog, String fileName)
        {
            var lines = new List<string>();
            lines.Add("[comment]");
            lines.Add(dialog.Comment);
            lines.Add("");
            lines.Add("[data]");
            lines.Add("lang="+String.Join(" ", dialog.LanguageTrees.ToArray()));
            lines.Add("");
            lines.Add("[dialog]");
            lines.Add("&");
            int nodeNum=0;
            foreach (FOCommon.Dialog.Node node in dialog.Nodes)
            {
                nodeNum = WriteNode(lines, nodeNum, node);
            }
            lines[lines.Count-1]= lines[lines.Count - 1].Replace('#', '&');
            lines[lines.Count-1]= lines[lines.Count - 1].Replace('@', '&');

            lines.Add("");
            foreach (String lang in dialog.LanguageTrees)
            {
                WriteDialogStrings(dialog, lines, lang);
            }
            
            // Add editor metadata here

            File.WriteAllLines(fileName, lines.ToArray(), Encoding.GetEncoding("Windows-1251"));

            return true;
        }

        private void WriteDialogStrings(Dialog.Dialog dialog, List<string> lines, string lang)
        {
            lines.Add("[" + lang + "]");
            lines.Add(MSGFormat(100, dialog.NpcName[lang]));
            if (dialog.DescriptionAlive[lang] != null)
                foreach (String str in dialog.DescriptionAlive[lang]) lines.Add(MSGFormat(200, str));
            if (dialog.DescriptionAliveFull[lang] != null)
                foreach (String str in dialog.DescriptionAliveFull[lang]) lines.Add(MSGFormat(210, str));
            if (dialog.DescriptionKnocked[lang] != null)
                foreach (String str in dialog.DescriptionKnocked[lang]) lines.Add(MSGFormat(220, str));
            if (dialog.DescriptionKnockedFull[lang] != null)
                foreach (String str in dialog.DescriptionKnockedFull[lang]) lines.Add(MSGFormat(230, str));
            if (dialog.DescriptionDead[lang] != null)
                foreach (String str in dialog.DescriptionDead[lang]) lines.Add(MSGFormat(240, str));
            if (dialog.DescriptionDeadFull[lang] != null)
                foreach (String str in dialog.DescriptionDeadFull[lang]) lines.Add(MSGFormat(250, str));
            if (dialog.DescriptionCriticalDead[lang] != null)
                foreach (String str in dialog.DescriptionCriticalDead[lang]) lines.Add(MSGFormat(260, str));
            if (dialog.DescriptionCriticalDeadFull[lang] != null)
                foreach (String str in dialog.DescriptionCriticalDeadFull[lang]) lines.Add(MSGFormat(270, str));
            int nodeNum = 0;
            foreach (FOCommon.Dialog.Node node in dialog.Nodes)
            {
                int ansNum = 0;
                lines.Add(MSGFormat(++nodeNum*1000, node.Text[lang]));
                foreach (FOCommon.Dialog.Answer answer in node.Answers)
                {
                    lines.Add(MSGFormat(nodeNum*1000 + (++ansNum*10), answer.Text[lang]));
                }
            }

            foreach (KeyValuePair<int, List<String>> kvp in dialog.UserStrings[lang])
            {
                foreach (String line in kvp.Value)
                    lines.Add(MSGFormat(100000000 + kvp.Key, line));
            }
            lines.Add("");
        }

        private int WriteNode(List<string> lines, int nodeNum, Node node)
        {
            nodeNum++;
            String line = String.Empty;
            line = String.Format("{0} {1} {2} {3} {4}", node.Id, nodeNum*1000, node.ScriptString,
                                 node.ShuffleAnswers ? "0" : "1", node.Answers != null && node.Answers.Count > 0 ? "#" : "@");
            lines.Add(line);
            if (node.Answers != null && node.Answers.Count > 0)
            {
                int ansNum = 0;
                for (int i = 0; i < node.Answers.Count; i++)
                {
                    line = String.Format("{0} {1}", node.Answers[i].ToNode, nodeNum*1000 + (++ansNum*10));

                    var dynamics = new List<Dynamic>(node.Answers[i].Demands.ToArray());
                    dynamics.AddRange(node.Answers[i].Results.ToArray());

                    foreach (Dynamic dyn in dynamics)
                    {
                        WriteDynamicLine(ref line, dyn);
                    }

                    if (i == node.Answers.Count - 1)
                        line += " @";
                    else
                        line += " #";
                    lines.Add(line);
                }
            }
            return nodeNum;
        }

        private void WriteDynamicLine(ref string line, Dynamic dyn)
        {
            if (dyn is Demand)
                line += " D ";
            else
                line += " R ";

            if (dyn.FuncCall != null)
            {
                line += String.Format("{0} {1} {2}", "_script", dyn.FuncCall.ScriptString,
                                      dyn.FuncCall.Args == null ? 0 : dyn.FuncCall.Args.Count);
                if (dyn.FuncCall.Args != null && dyn.FuncCall.Args.Count > 0)
                    line += " " + String.Join(" ", dyn.FuncCall.Args.ToArray());
            }
            else if (dyn.Item != null)
            {
                line += String.Format("{0} {1} {2} {3} {4}", "_item", dyn.ForPlayer ? "p" : "n", dyn.Item.PidDefine,
                                      Dialog.Dialog.SetOperator(dyn.Operator), dyn.Value);
            }
            else if (dyn.Param != null)
            {
                line += String.Format("{0} {1} {2} {3} {4}", "_param", dyn.ForPlayer ? "p" : "n",
                                      dyn.Param.ParamDefine, Dialog.Dialog.SetOperator(dyn.Operator), dyn.Value);
            }
            else if (dyn.Var != null)
            {
                line += String.Format("{0} {1} {2} {3} {4}", "_var", dyn.ForPlayer ? "p" : "n", dyn.Var.Name,
                                      Dialog.Dialog.SetOperator(dyn.Operator), dyn.Value);
            }
        }
    }
}
