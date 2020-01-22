using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FOMonitor
{
    public static class Utils
    {

        private static string FileName;
        public static void InitLog(string FileName)
        {
            Utils.FileName = FileName;
            File.Delete(FileName);
        }

        public static void Log(String Text)
        {
            File.AppendAllText(FileName, "[" + DateTime.Now.ToString() + "] " + Text + Environment.NewLine);
        }

        public static Dictionary<int, string> ParseWhitelist(string[] lines)
        {
            Dictionary<int, string> Whitelist = new Dictionary<int,string>();
            for (int i = 0; i < lines.Length; i++)
            {
                try
                {
                    int a;
                    if (string.IsNullOrEmpty(lines[i]) || (!int.TryParse(lines[i], out a) && !lines[i].Contains(';')))
                        continue;
                    if (lines[i].Contains(';'))
                    {
                        string[] parts = lines[i].Split(';');
                        Whitelist.Add(Int32.Parse(parts[0]), parts[1]);
                    }
                    else
                        Whitelist.Add(Int32.Parse(lines[i]), "");
                }
                catch (Exception) { }
            }
            return Whitelist;
        }

        public static Dictionary<string, string> ParseBlacklist(string[] lines)
        {
            Dictionary<string, string> Blacklist = new Dictionary<string, string>();
            for (int i = 0; i < lines.Length; i++)
            {
                try
                {
                    if (string.IsNullOrEmpty(lines[i]))
                        continue;
                    if (lines[i].Contains(';'))
                    {
                        string[] parts = lines[i].Split(';');
                        Blacklist.Add(parts[0].Trim(), parts[1]);
                    }
                    else
                        Blacklist.Add(lines[i], "");
                }
                catch (Exception) { }
            }
            return Blacklist;
        }

        public static List<string> BlacklistToLines(Dictionary<string, string> Blacklist)
        {
            List<string> lines = new List<string>();
            foreach (KeyValuePair<string, string> kvp in Blacklist)
            {
                if (!string.IsNullOrEmpty(kvp.Value))
                    lines.Add(kvp.Key + " ;" + kvp.Value + "\n");
                else
                    lines.Add(kvp.Key.ToString());
            }
            return lines;
        }

        public static List<string> WhitelistToLines(Dictionary<int, string> Whitelist)
        {
            List<string> lines = new List<string>();
            foreach (KeyValuePair<int, string> kvp in Whitelist)
            {
                if (!string.IsNullOrEmpty(kvp.Value))
                    lines.Add(kvp.Key + " ;" + kvp.Value + "\n");
                else
                    lines.Add(kvp.Key.ToString());
            }
            return lines;
        }
    }
}
