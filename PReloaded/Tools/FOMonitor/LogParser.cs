using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

namespace FOMonitor
{
    class LogParser
    {
        List<Player> Players = new List<Player>();
        ServerData _ServerData = new ServerData();

        string Convert(string s)
        {
            System.Text.Encoding enc_1 = System.Text.Encoding.Default;
            System.Text.Encoding utf_8 = System.Text.Encoding.GetEncoding("Windows-1252");

            // Convert to ISO-8859-1 bytes.
            byte[] isoBytes = enc_1.GetBytes(s);

            // Convert to UTF-8.
            byte[] utf8Bytes = System.Text.Encoding.Convert(enc_1, utf_8, isoBytes);
            return System.Text.UTF7Encoding.ASCII.GetString(utf8Bytes);
        }

        int GetStartLineForLastInstance(List<string> lines)
        {
            int line = 0;
            for (int i = 0; i < lines.Count; i++)
            {
                if ((lines[i].Contains("Name")) && lines[i].Contains("Id") && lines[i].Contains("Online") && lines[i].Contains("Cond") && lines[i].Contains("Level"))
                    line = i;
            }
            return line;
        }

        public ServerData GetServerData()
        {
            return _ServerData;
        }

        string GetLogElement(string line, out string modified, bool ParseToSingleSpace)
        {
            string matchstr = "  ";
            if (ParseToSingleSpace)
                matchstr = " ";

            string str = line.Substring(0, line.IndexOf(matchstr));
            line = line.Remove(0, line.IndexOf(matchstr));
            line = line.TrimStart();
            modified = line;
            return str;
        }

        void ReadLog(string path, bool parseAll, bool overwriteMatch, bool onlyUnique)
        {
                List<string> lines = new List<string>(File.ReadAllLines(path, Encoding.GetEncoding("Windows-1251")));
                
                string TimeStamp = "";
                int startline = 0;
                if (!parseAll)
                    startline = GetStartLineForLastInstance(lines);

                for (int i = startline; i < lines.Count; i++)
                {
                    string line = lines[i];
                    if (!((line.Contains("Life") || line.Contains("Dead") || line.Contains("Knockout")) && (line.Contains("Yes") || line.Contains("Disconnect"))))
                    {
                        TimeStamp = "";
                        continue;
                    }
                    if (string.IsNullOrEmpty(TimeStamp))
                        TimeStamp = line.Substring(0, 8);

                    line = line.Remove(0, 11);
                    Player player = new Player();
                    player.FromFile = Path.GetFileName(path);
                    player.TimeStamp = TimeStamp;
                    player.Name     =           GetLogElement(line, out line, false);
                    player.Id       = int.Parse(GetLogElement(line, out line, true));
                    player.Ip       =           GetLogElement(line, out line, true);
                    player.NetState =           GetLogElement(line, out line, true);
                    player.Cond     =           GetLogElement(line, out line, true);
                    player.X        = int.Parse(GetLogElement(line, out line, true));
                    player.Y        = int.Parse(GetLogElement(line, out line, true));
                    if (line.Substring(0, 10) == "Global map")
                    {
                        player.Location = GetLogElement(line, out line, false);
                        player.Map = "";
                        player.MapId = 0;
                        player.MapPid = 0;
                        player.LocationId = 0;
                        player.LocationPid = 0;
                        line = line.Trim();
                        player.Level = int.Parse(line);
                    }
                    else
                    {
                        player.Location = line.Substring(0, line.IndexOf(')')+1);
                        line = line.Remove(0, line.IndexOf(')')+1);
                        line = line.TrimStart();
                        string temp = player.Location.Substring(player.Location.IndexOf('(') + 1, player.Location.Length-player.Location.IndexOf('(') - 2);
                        temp = temp.Trim();
                        string[] vals = temp.Split(',');
                        player.LocationId = int.Parse(vals[0]);
                        player.LocationPid = int.Parse(vals[1]);

                        player.Map = line.Substring(0, line.IndexOf(')')+1);
                        line = line.Remove(0, line.IndexOf(')')+1);
                        line = line.Trim();

                        temp = player.Map.Substring(player.Map.IndexOf('(') + 1, player.Map.Length - player.Map.IndexOf('(') - 2);
                        temp = temp.Trim();
                        vals = temp.Split(',');
                        player.MapId = int.Parse(vals[0]);
                        player.MapPid = int.Parse(vals[1]);
                        player.Level = int.Parse(line);
                    }

                    if (onlyUnique)
                    {
                        if (!Exists(Players, player))
                            Players.Add(player);
                        else
                        {
                            if (overwriteMatch)
                            {
                                Players.Remove(Players.Find(x => x.Id == player.Id));
                                Players.Add(player);
                            }
                        }
                    }
                    else
                        Players.Add(player);

                }
        }

        public LogParser(string path, bool parseall, bool matchmode, bool onlyunique)
        {
            ReadLog(path, parseall, matchmode, onlyunique);
        }

        public LogParser(List<string> paths, bool parseall, bool matchmode, bool onlyunique)
        {
            foreach(string path in paths)
                ReadLog(path, parseall, matchmode, onlyunique);
        }

        public List<Player> GetPlayers()
        {
            return Players;
        }

        private bool Exists(List<Player> arr, Player p)
        {
            foreach (Player i in arr)
            {
                if (p.Id == i.Id)
                    return true;
            }
            return false;
        }

        string GetIpSubnet(string ip)
        {
            string[] parts = ip.Split('.');
            string subnetip = "";
            for(int i=0;i<parts.Length-1;i++)
            {
                subnetip += parts[i];
                if (i<parts.Length-2)
                    subnetip+=".";
            }
            return subnetip;
        }

        public List<Player> GetAlts(bool AggressiveIpMatching, bool NameCheck)
        {
            List<Player> Alts = new List<Player>();
            foreach (Player p in Players)
            {
                foreach (Player i in Players)
                {
                    if ((i.Name == p.Name))
                        continue;

                    if (NameCheck && (i.Name.Substring(0, 4) == p.Name.Substring(0, 4))) // Don't need to do other checks.
                    {
                    }
                    else
                    {
                        if (AggressiveIpMatching)
                        {
                            if (GetIpSubnet(i.Ip) != GetIpSubnet(p.Ip))
                                continue;
                        }
                        else
                            if (i.Ip != p.Ip)
                                continue;
                    }

                    if (!Exists(Alts, i))
                        Alts.Add(i);
                    if (!Exists(Alts, p))
                        Alts.Add(p);
                }
            }
            return Alts;
        }
    }
}
