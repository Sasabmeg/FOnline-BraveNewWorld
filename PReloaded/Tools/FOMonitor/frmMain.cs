using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BrightIdeasSoftware;

// Todo: Logfile column -> Date
namespace FOMonitor
{
    public partial class frmMain : Form
    {
        string logPath;
        string logExt;
        private string version = "0.76";
        Dictionary<int, Map> Maps = new Dictionary<int, Map>();
        Dictionary<int, string> Whitelist = new Dictionary<int, string>();
        Dictionary<string, string> Blacklist = new Dictionary<string, string>();
        LogParser parser;

        [DllImport("user32.dll")]
        public static extern bool
        SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        static extern IntPtr SetCapture(IntPtr hWnd);

        public frmMain()
        {
            InitializeComponent();
        }

        IniReader ini = new IniReader("./config.ini");

        void ReadConfig()
        {
            if (!File.Exists("./config.ini"))
                return;
            IniReader ini = new IniReader("./config.ini");
            Serializer.DeserializeChk("Options", "removelog", chkRemove);
            Serializer.DeserializeChk("Options", "single_table", chkSingleTable);
            Serializer.DeserializeChk("Options", "one_hit_per_player", chkOneHitPerPlayer);
            Serializer.DeserializeCmb("Options", "sources", cmbSources);
            Serializer.DeserializeChk("Options", "load_on_update", chkLoadOnUpdate);
            Serializer.DeserializeChk("Options", "useblacklist", chkBlacklist);
            Serializer.DeserializeCmb("Options", "blacklistcolour", cmbBlacklistColor);
            Serializer.DeserializeChk("Options", "keeplatestlog", chkLogDeletionKeepLatest);
            Serializer.DeserializeChk("Options", "movelogs", chkMoveLogs);
            Serializer.DeserializeTextBox("Options", "movepath", txtLogMovePath);
            int tablefont = ini.IniReadInt("Options", "tablefont");

            // Filters
            Serializer.DeserializeChk("Filters", "alts", chkAlts);
            Serializer.DeserializeChk("Filters", "alt_based_on_name", chkAltBasedOnName);
            Serializer.DeserializeChk("Filters", "aggressive_ip_matching", chkAggressiveIpMatching);

            // Location filters
            Serializer.DeserializeChk("Filters", "town", chkInTown);
            Serializer.DeserializeChk("Filters", "base", chkInBase);
            Serializer.DeserializeChk("Filters", "tent", chkInTent);
            Serializer.DeserializeChk("Filters", "encounter", chkInEncounter);
            Serializer.DeserializeChk("Filters", "rawfilter", chkRawId);
            Serializer.DeserializeNum("Filters", "rawfilterid", numMapFilter);

            // Condition filters
            Serializer.DeserializeChk("Filters", "netstate", chkFilterNetstate);
            Serializer.DeserializeCmb("Filters", "netstateidx", cmbNetState);
            Serializer.DeserializeChk("Filters", "cond", chkFilterCond);
            Serializer.DeserializeCmb("Filters", "condidx", cmbCond);

            // IP
            Serializer.DeserializeChk("Filters", "ip", chkFilterIp);
            Serializer.DeserializeTextBox("Filters", "ipstring", txtIp);
            
            // Window
            int x = ini.IniReadInt("Window", "x");
            int y = ini.IniReadInt("Window", "y");
            int width = ini.IniReadInt("Window", "width");
            int height = ini.IniReadInt("Window", "height");
            int splitterpos = ini.IniReadInt("Window", "splitterpos");

            if (chkSingleTable.Checked)
                splitContainer1.Panel1Collapsed = true;

            if ((x > 0)&&(y>0)) 
                this.Location = new Point(x,y);
            if ((width > 0) && (height > 0))
                this.Size = new Size(width, height);

            splitContainer1.SplitterDistance = splitterpos;

            chkAggressiveIpMatching.Enabled = chkAlts.Checked;
            chkAltBasedOnName.Enabled = chkAlts.Checked;

            cmbCond.Enabled = chkFilterCond.Checked;
            cmbNetState.Enabled = chkFilterNetstate.Checked;

            txtIp.Enabled = chkFilterIp.Checked;

            if (tablefont > -1)
            {
                cmbFont.SelectedIndex = tablefont;
                SetFont(cmbFont.Text);
            }
        }

        void SaveConfig()
        {

            ini.IniWriteInt("Options", "removelog", (chkRemove.Checked?1:0));
            ini.IniWriteInt("Options", "single_table", (chkSingleTable.Checked ? 1 : 0));
            ini.IniWriteInt("Options", "sources", cmbSources.SelectedIndex);
            ini.IniWriteInt("Options", "one_hit_per_player", (chkOneHitPerPlayer.Checked?1:0));
            ini.IniWriteInt("Options", "load_on_update", (chkLoadOnUpdate.Checked ? 1 : 0));
            ini.IniWriteInt("Options", "useblacklist", (chkBlacklist.Checked ? 1 : 0));
            ini.IniWriteInt("Options", "blacklistcolour", cmbBlacklistColor.SelectedIndex);
            ini.IniWriteInt("Options", "keeplatestlog", (chkLogDeletionKeepLatest.Checked?1:0));
            ini.IniWriteInt("Options", "movelogs", (chkMoveLogs.Checked ? 1 : 0));
            ini.IniWriteValue("Options", "movepath", txtLogMovePath.Text);
            ini.IniWriteInt("Options", "tablefont", cmbFont.SelectedIndex);

            // filters
            ini.IniWriteInt("Filters", "alts", (chkAlts.Checked ? 1 : 0));
            ini.IniWriteInt("Filters", "alt_based_on_name", (chkAltBasedOnName.Checked ? 1 : 0));
            ini.IniWriteInt("Filters", "aggressive_ip_matching", (chkAggressiveIpMatching.Checked ? 1 : 0));
            ini.IniWriteInt("Filters", "town", (chkInTown.Checked ? 1 : 0));
            ini.IniWriteInt("Filters", "base", (chkInBase.Checked ? 1 : 0));
            ini.IniWriteInt("Filters", "tent", (chkInTent.Checked ? 1 : 0));
            ini.IniWriteInt("Filters", "encounter", (chkInEncounter.Checked ? 1 : 0));
            ini.IniWriteInt("Filters", "cond", (chkFilterCond.Checked ? 1 : 0));
            ini.IniWriteInt("Filters", "netstate", (chkFilterNetstate.Checked ? 1 : 0));
            ini.IniWriteInt("Filters", "condidx", cmbCond.SelectedIndex);
            ini.IniWriteInt("Filters", "netstateidx", cmbNetState.SelectedIndex);
            ini.IniWriteInt("Filters", "rawfilter", (chkRawId.Checked ? 1 : 0));
            ini.IniWriteInt("Filters", "rawfilterid", Decimal.ToInt32(numMapFilter.Value));
            ini.IniWriteInt("Filters", "ip", (chkFilterIp.Checked?1:0));
            ini.IniWriteValue("Filters", "ipstring", txtIp.Text);
            // window
            ini.IniWriteInt("Window", "x", this.Location.X);
            ini.IniWriteInt("Window", "y", this.Location.Y);
            ini.IniWriteInt("Window", "width", this.Size.Width);
            ini.IniWriteInt("Window", "height", this.Size.Height);
            ini.IniWriteInt("Window", "splitterpos", splitContainer1.SplitterDistance);
        }

        void RestoreTableState()
        {
            if (!File.Exists("./table1.fom"))
                return;

            lstPlayers.RestoreState(File.ReadAllBytes("./table1.fom"));
            lstFiltered.RestoreState(File.ReadAllBytes("./table2.fom"));
        }

        void SaveTableState()
        {
            File.WriteAllBytes("./table1.fom", lstPlayers.SaveState());
            File.WriteAllBytes("./table2.fom", lstFiltered.SaveState());
        }

        private bool containsLogTag(string str)
        {
            string[] defLogTags = { "%DAY%", "%MONTH%", "%YEAR%", "%HOUR%", "%MINUTE%", "%SECOND%", "%EXTENSION%", "%CHARNAME%", "%CHARLEVEL% " };
            List<String> specialLogTags = new List<string>(defLogTags);
            foreach (string tag in specialLogTags)
            {
                if (str.Contains(tag))
                    return true;
            }
            return false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Utils.InitLog(".\\FOMonitor.log");

            System.Drawing.Text.InstalledFontCollection ifc = new System.Drawing.Text.InstalledFontCollection();
            foreach (FontFamily ff in ifc.Families)
            {
                cmbFont.Items.Add(ff.Name);
                if (ff.Name == "Tahoma")
                    cmbFont.SelectedIndex = cmbFont.Items.Count-1;
            }

            IniReader Fo2238Config = new IniReader(".\\FOnline2238.cfg");
            logPath = Fo2238Config.IniReadValue("2238", "LogfileName");

            if(String.IsNullOrEmpty(logPath))
                logPath = ".\\";
            bool containsTag = containsLogTag(logPath);
            
            if(containsTag)
            {
                string validPath = Path.GetPathRoot(logPath);
                string[] parts = logPath.Split(Path.DirectorySeparatorChar);
                foreach(string part in parts)
                {
                    if (!containsLogTag(part))
                        validPath += part + Path.DirectorySeparatorChar;
                    else
                        break;
                }
                logExt = Path.GetExtension(logPath);
                logPath = validPath;
                lblLogsPath.Text = String.Format("Searching for logs in: {0} (defined in FOnline2238.cfg)", logPath);
            }
            
            List<string> Colors = new List<string>(Enum.GetNames(typeof(System.Drawing.KnownColor)));
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (System.Reflection.PropertyInfo c in propInfoList)
                this.cmbBlacklistColor.Items.Add(c.Name);

            this.Text = "FOMonitor " + version;
            this.cmbMapFilterRaw.SelectedIndex = 0;
            this.cmbSources.SelectedIndex = 0;
            this.cmbBlacklistColor.SelectedIndex = 0;
            this.cmbMatchMode.SelectedIndex = 0;

            this.numMapFilter.Maximum = Int32.MaxValue;
            lblInstructions.Text = "Use ~gameinfo 1 and press F2, then " + Environment.NewLine + "press update.";
            if (!File.Exists("FOnline.exe"))
            {
                MessageBox.Show("FOnline.exe not found." + Environment.NewLine + 
                    "Please move this program to same directory as the fonline client", "FOMonitor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Serializer.Init();
            ReadConfig();
            RestoreTableState();
            if (File.Exists("./whitelist.txt"))
            {
                Whitelist = new Dictionary<int, string>();
                try
                {
                    List<string> lines = new List<string>(File.ReadAllLines("./whitelist.txt"));
                    Whitelist = Utils.ParseWhitelist(lines.ToArray());
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Failed to parse whitelist: " + ex.Message);
                }
                
            }
            else
                File.Create("./whitelist.txt");

            if (File.Exists("./blacklist.txt"))
            {
                Blacklist = new Dictionary<string, string>();
                try
                {
                    List<string> lines = new List<string>(File.ReadAllLines("./blacklist.txt"));
                    Blacklist = Utils.ParseBlacklist(lines.ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to parse blacklist: " + ex.Message);
                }

            }
            else
                File.Create("./blacklist.txt");
        }

        List<string> FindAllLogs(string path, string ext)
        {
            if (!Directory.Exists(path))
            {
                MessageBox.Show("Unable to find logpath: " + path);
                return new List<string>();
            }

            return new List<string>(Directory.GetFiles(path, "*"+ext, SearchOption.AllDirectories));
        }

        string FindLatestLog(string path, string ext)
        {
            string[] files = Directory.GetFiles(path, "*"+ext, SearchOption.AllDirectories);
            string lpath = "";
            DateTime ltime = DateTime.MinValue;
            for (int i = 0; i < files.Length; i++)
            {
                DateTime dt = File.GetLastWriteTime(files[i]);
                if (dt>ltime)
                {
                    ltime = File.GetLastWriteTime(files[i]);
                    lpath = files[i];
                }
            }
            return lpath;
        }

        void ShowNoLogError()
        {
            MessageBox.Show("No logfile found.", "FOnline Monitor", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string latestpath = FindLatestLog(logPath, logExt);
            if (string.IsNullOrEmpty(latestpath))
            {
                ShowNoLogError();
                return;
            }
            List<string> paths = new List<string>(FindAllLogs(logPath, logExt));
            if (paths.Count == 0)
            {
                ShowNoLogError();
                return;
            }

            if (cmbSources.SelectedIndex == 2)
                parser = new LogParser(paths, true, cmbMatchMode.SelectedIndex == 1,  (chkOneHitPerPlayer.Checked ? true : false));
            else
                parser = new LogParser(latestpath, ((cmbSources.SelectedIndex > 0) ? true : false), cmbMatchMode.SelectedIndex == 1, (chkOneHitPerPlayer.Checked ? true : false));

            if (chkLoadOnUpdate.Checked)
            {
                List<Player> Players = parser.GetPlayers();
                if (chkSingleTable.Checked)
                {
                    this.lstFiltered.SetObjects(Players);
                }
                else
                    this.lstPlayers.SetObjects(Players);


                lblPlayers.Text = Players.Count + " players found.";
            }

            if ((chkRemove.Checked))
            {
                foreach (string _path in paths)
                {
                    if(chkLogDeletionKeepLatest.Checked&&_path==latestpath)
                        continue;
                    if (chkMoveLogs.Checked)
                        File.Move(_path, txtLogMovePath.Text + "\\" + Path.GetFileName(_path));
                    else
                        File.Delete(_path);
                }
            }
        }

        private bool IsWithinRange(int val, int n, int x)
        {
            return ((val >= n) && (val <= x));
        }

        private bool InBase(Player p)
        {
            int pid = p.LocationPid;
            return (IsWithinRange(pid, 202, 205) || IsWithinRange(pid, 207, 208) || pid == 210 || IsWithinRange(pid, 245, 246));
        }

        private bool InTown(Player p)
        {
            int pid = p.MapPid;
            return (pid != 0) && !InBase(p) && !InEncounter(p) && !InTent(p);
        }

        private bool InTent(Player p)
        {
            int pid = p.MapPid;
            return (IsWithinRange(pid,287,290));
        }

        private bool InEncounter(Player p)
        {
            int pid = p.MapPid;
            return ((pid >= 150 && pid < 220) || (pid >= 345 && pid < 370) || (pid >= 400 && pid < 450) || (pid >= 500 && pid < 550));
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            if (parser == null)
                return;

            List<Player> Players = new List<Player>();
            List<Player> Add = new List<Player>();

            if (chkAlts.Checked)
                Players = parser.GetAlts(chkAggressiveIpMatching.Checked, chkAltBasedOnName.Checked);
            else
                Players = parser.GetPlayers();

            if (chkBlacklist.Checked)
            {
                lstFiltered.ClearObjects();
            }

            foreach (Player p in Players)
            {
                if (Whitelist.ContainsKey(p.Id))
                    continue;

                if ((chkInEncounter.Checked) && !InEncounter(p))
                    continue;
                if ((chkInTown.Checked) && !InTown(p))
                    continue;
                if ((chkInBase.Checked) && !InBase(p))
                    continue;
                if ((chkInTent.Checked) && !InTent(p))
                    continue;

                if (chkFilterIp.Checked)
                {
                    Regex regxp = new Regex("\\A"+txtIp.Text);
                    if (!regxp.IsMatch(p.Ip))
                        continue;
                }

                if ((chkRawId.Checked))
                {
                    int val = Int32.Parse(numMapFilter.Value.ToString());
                    if (cmbMapFilterRaw.SelectedIndex == 0)
                    {
                        if (p.MapPid != val)
                            continue;
                    }
                    else if (cmbMapFilterRaw.SelectedIndex == 1)
                    {
                        if (p.MapId != val)
                            continue;
                    }
                    else if (cmbMapFilterRaw.SelectedIndex == 2)
                    {
                        if (p.LocationPid != val)
                            continue;
                    }
                    else if (cmbMapFilterRaw.SelectedIndex == 3)
                    {
                        if (p.LocationId != val)
                            continue;
                    }
                }

                if (chkFilterNetstate.Checked)
                {
                    if ((cmbNetState.SelectedIndex == 0) && (p.NetState != "Yes"))
                        continue;
                    else if ((cmbNetState.SelectedIndex == 1) && (p.NetState != "Disconnect"))
                        continue;
                }

                if (chkFilterCond.Checked)
                {
                    if ((cmbCond.SelectedIndex == 0) && (p.Cond != "Life"))
                        continue;
                    else if ((cmbCond.SelectedIndex == 1) && (p.Cond != "Knockout"))
                        continue;
                    else if ((cmbCond.SelectedIndex == 2) && (p.Cond != "Dead"))
                        continue;
                }
                Add.Add(p);
            }

            lblPlayers.Text = parser.GetPlayers().Count + " players found. " + (Add.Count) + " players matches current filter settings.";
            this.lstFiltered.SetObjects(Add);
        }

        private void lstPlayers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                lstPlayers.CopySelectionToClipboard();
                Clipboard.SetText(Clipboard.GetText().Replace("\t", ", "));
            }
        }

        private void lstFiltered_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                lstFiltered.CopySelectionToClipboard();
                Clipboard.SetText(Clipboard.GetText().Replace("\t", ", "));
            }
        }

        private void chkSingleTable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSingleTable.Checked)
            {
                splitContainer1.Panel1Collapsed = true;
                lstFiltered.Objects = lstPlayers.Objects;
            }
            else
            {
                splitContainer1.Panel1Collapsed = false;
                lstFiltered.Objects = null;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveTableState();
            SaveConfig();
            List<string> lines = new List<string>();
            foreach (KeyValuePair<int, string> kvp in Whitelist)
                lines.Add(kvp.Key + " ;" + kvp.Value);
            File.WriteAllLines("./whitelist.txt", lines.ToArray());
            lines = new List<string>();
            foreach (KeyValuePair<string, string> kvp in Blacklist)
                lines.Add(kvp.Key + " ;" + kvp.Value);
            File.WriteAllLines("./blacklist.txt", lines.ToArray());
        }

        private void btnWhitelist_Click(object sender, EventArgs e)
        {
            frmWhitelist Whitelistwindow = new frmWhitelist();
            Whitelistwindow.Whitelist = Whitelist;
            Whitelistwindow.ShowDialog();
            Whitelist = Whitelistwindow.Whitelist;
        }

        private void btnBlacklist_Click(object sender, EventArgs e)
        {
            frmBlacklist Blacklistwindow = new frmBlacklist();
            Blacklistwindow.Blacklist = Blacklist;
            Blacklistwindow.ShowDialog();
            Blacklist = Blacklistwindow.Blacklist;
        }

        private void chkAlts_CheckedChanged(object sender, EventArgs e)
        {
            chkAggressiveIpMatching.Enabled = chkAlts.Checked;
            chkAltBasedOnName.Enabled = chkAlts.Checked;
        }

        private void chkFilterNetstate_CheckedChanged(object sender, EventArgs e)
        {
            cmbNetState.Enabled = chkFilterNetstate.Checked;
        }

        private void chkFilterCond_CheckedChanged(object sender, EventArgs e)
        {
            cmbCond.Enabled = chkFilterCond.Checked;
        }

        private void chkFilterIp_CheckedChanged(object sender, EventArgs e)
        {
            txtIp.Enabled = chkFilterIp.Checked;
        }

        private void SetFont(string familyname)
        {
            try
            {
                lstFiltered.Font = new Font(familyname, 8.0f);
                lstPlayers.Font = new Font(familyname, 8.0f);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Font not supported.", "FOnline Monitor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool BlacklistedIp(Player p)
        {
            foreach (string key in Blacklist.Keys)
            {
                if (!key.ToLower().Contains("ip"))
                    continue;
                string[] parts = key.Split(':');
                Regex regxp = new Regex("\\A" + parts[1]);
                if (regxp.IsMatch(p.Ip))
                    return true;
            }
            return false;
        }

        private void lstFiltered_FormatRow(object sender, FormatRowEventArgs e)
        {
            if (!chkBlacklist.Checked)
                return;

            if (cmbBlacklistColor.SelectedIndex == -1)
                return;

            Player player = (Player)e.Model;
            if (Blacklist.ContainsKey(player.Id.ToString()) || BlacklistedIp(player))
            {
                if(!string.IsNullOrEmpty(cmbBlacklistColor.SelectedItem.ToString()))
                    e.Item.ForeColor = Color.FromName(cmbBlacklistColor.SelectedItem.ToString());
            }
        }

        private void btnLogMovePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog()==DialogResult.OK)
                txtLogMovePath.Text = folderBrowserDialog.SelectedPath;
        }

        private void cmbFont_SelectedValueChanged(object sender, EventArgs e)
        {
            SetFont(cmbFont.Text);
        }
    }
}