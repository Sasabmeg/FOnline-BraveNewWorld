using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.Win32;
using System.Diagnostics;
using FOCommon.WMLocation;

namespace FOCommon
{
    public class NetVersion
    {
        public string Name { get; set; }
        public string RegKeyInstall { get; set;}
        public string RegKeySP { get; set; }
        public string RegKeyVersion { get; set; }
        public bool Installed { get; set; }
        public string Version { get; set; }
        public string SP { get; set; }
    }
    
    // Collection of various useful functions.
    public static class Utils
    {
        public static bool IsWinVistaOrHigher()
        {
            OperatingSystem OS = Environment.OSVersion;
            return (OS.Platform == PlatformID.Win32NT) && (OS.Version.Major >= 6);
        }

        public enum DataType
        {
            INT,
            INT16,
            UINT,
            UINT16,
            SBYTE,
            BOOL,
        };

        public static bool LaunchDialogEditor(FOCommon.Dialog.ListDialog Dialog, string DialogEditorPath)
        {
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = Path.GetFullPath(DialogEditorPath);
            startinfo.Arguments = "dialogs/" + Dialog.Name + ".fodlg";

            if (!File.Exists(startinfo.FileName))
                return false;

            Process proc = new Process();
            proc.StartInfo = startinfo;
            proc.Start();
            return true;
        }

        public static bool LaunchMapper(Map Map, string MapperPath, string MapsDir)
        {
            if (!File.Exists(MapperPath))
                return false;

            MapperPath = Path.GetFullPath(MapperPath);

            int HexX = 0;
            int HexY = 0;

            StreamReader sr = File.OpenText(MapsDir + "/" + Map.FileName + ".fomap");
            while (!sr.EndOfStream)
            {
                String MapLine = sr.ReadLine();
                if (String.IsNullOrEmpty(MapLine))
                    continue;

                if (MapLine.Contains("WorkHexX"))
                    HexX = Int32.Parse(MapLine.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[1]);
                else if (MapLine.Contains("WorkHexY"))
                {
                    HexY = Int32.Parse(MapLine.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[1]);
                    break;
                }
            }
            sr.Close();

            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = MapperPath;
            startinfo.Arguments = String.Format("-Map {0} -HexX {1} -HexY {2}", Map.FileName, HexX, HexY);

            Process proc = new Process();
            proc.StartInfo = startinfo;
            proc.Start();
            return true;
        }

        public static List<Control> GetAllControls(IList ctrls)
        {
            List<Control> RetCtrls = new List<Control>();
            foreach (Control ctl in ctrls)
            {
                RetCtrls.Add(ctl);
                List<Control> SubCtrls = GetAllControls(ctl.Controls);
                RetCtrls.AddRange(SubCtrls);
            }
            return RetCtrls;
        }

        public static string GetSpacedLine(string Text1, string Text2, int Distance)
        {
            string Entry = Text1;
            int Len = Distance - Entry.Length;
            for (int i = 0; i < Len; i++)
                Entry += " ";
            Entry += Text2;
            return Entry;
        }

        public static DataType GetTypeFromString(String Str)
        {
            if (Str == "int") return DataType.INT;
            if (Str == "int16") return DataType.INT16;
            if (Str == "uint") return DataType.UINT;
            if (Str == "uint16") return DataType.UINT16;
            if (Str == "uint8") return DataType.SBYTE;
            if (Str == "int8") return DataType.SBYTE;
            if (Str == "bool") return DataType.BOOL;
            return 0;
        }

        private static string _fileName;
        public static void InitLog(string fileName, bool deleteOld)
        {
            Utils._fileName = fileName;
            if(deleteOld)
                File.Delete(fileName);
        }

        public static void Log(String Text, bool ToConsole = false)
        {
            if (String.IsNullOrEmpty(_fileName))
                return;

            if (ToConsole)
                Console.WriteLine("[" + DateTime.Now.ToString() + "] " + Text);

            File.AppendAllText(_fileName, "[" + DateTime.Now.ToString() + "] " + Text + Environment.NewLine);
        }

        // .NET name or R,G,B,A
        public static Color GetColor(String Str)
        {
            Color Color;
            if (Str.Contains(","))
            {
                String[] Parts = Str.Split(',');
                if (Parts.Length != 4)
                    return Color.Empty;
                Color = Color.FromArgb(Int32.Parse(Parts[3]),
                                       Int32.Parse(Parts[0]),
                                       Int32.Parse(Parts[1]),
                                       Int32.Parse(Parts[2]));
            }
            else
            {
                Color = Color.FromName(Str);
            }
            return Color;
        }

        public static void SetColor(FOCommon.Controls.ColorComboBox ComboBox, ref String Text, bool ToUI)
        {
            if (ToUI)
            {
                if (Text.Contains(","))
                {
                    ComboBox.SelectedIndex = 0;
                    ComboBox.CustomColor = Utils.GetColor(Text);
                }
                else
                {
                    ComboBox.SelectedIndex = ComboBox.FindStringExact(Text);
                }
            }
            else
            {
                if (ComboBox.SelectedIndex == 0)
                {
                    Color Cl = ComboBox.CustomColor;
                    Text = String.Format("{0},{1},{2},{3}", Cl.R, Cl.G, Cl.B, Cl.A);
                }
                else
                {
                    Text = (String)ComboBox.Text;
                }
            }
        }

        // Functions for Data<->UI syncronization
        // .NET databinding should probably be used instead of this.
        public static void SetControl(TextBox Ctrl, ref string Data, bool ToUI) { if (ToUI) Ctrl.Text = Data; else Data = Ctrl.Text; }
        public static void SetControl(TextBox Ctrl, ref Byte Data, bool ToUI) { if (ToUI) Ctrl.Text = Data.ToString(); else Data = Byte.Parse(Ctrl.Text); }
        public static void SetControl(CheckBox Ctrl, ref bool Data, bool ToUI) { if (ToUI) Ctrl.Checked = Data; else Data = Ctrl.Checked; }
        public static void SetControl(NumericUpDown Ctrl, ref Int32 Data, bool ToUI) { if (ToUI) Ctrl.Value = Data; else Data = (Int32)Ctrl.Value; }
        public static void SetControl(NumericUpDown Ctrl, ref UInt32 Data, bool ToUI) { if (ToUI) Ctrl.Value = Data; else Data = (UInt32)Ctrl.Value; }
        public static void SetControl(NumericUpDown Ctrl, ref short Data, bool ToUI) { if (ToUI) Ctrl.Value = Data; else Data = (short)Ctrl.Value; }
        public static void SetControl(NumericUpDown Ctrl, ref ushort Data, bool ToUI) { if (ToUI) Ctrl.Value = Data; else Data = (ushort)Ctrl.Value; }
        public static void SetControl(NumericUpDown Ctrl, ref Byte Data, bool ToUI) { if (ToUI) Ctrl.Value = Data; else Data = (Byte)Ctrl.Value; }
        public static void SetControl(NumericUpDown Ctrl, ref SByte Data, bool ToUI) { if (ToUI) Ctrl.Value = Data; else Data = (SByte)Ctrl.Value; }
        public static void SetControl(ComboBox Ctrl, ref String Data, bool ToUI) { if (ToUI) Ctrl.Text = Data; else Data = Ctrl.Text; }
        public static void SetControl(ComboBox Ctrl, ref float Data, bool ToUI) { if (ToUI) Ctrl.Text = Data.ToString(); else Data = float.Parse(Ctrl.Text); }
        public static void SetControl(GroupBox Ctrl, ref int Data, bool ToUI)
        {
            if (ToUI) ((RadioButton)Ctrl.Controls[(int)Data]).Checked = true;
            else { Data = (int)GetGroupRadioButtonIndex(Ctrl); }
        }
        public static void SetControl(GroupBox Ctrl, ref uint Data, bool ToUI)
        {
            if (ToUI) ((RadioButton)Ctrl.Controls[(int)Data]).Checked = true;
            else { Data = (uint)GetGroupRadioButtonIndex(Ctrl); }
        }
        public static void SetControl(GroupBox Ctrl, ref byte Data, bool ToUI)
        {
            if (ToUI) ((RadioButton)Ctrl.Controls[(int)Data]).Checked = true;
            else { Data = (byte)GetGroupRadioButtonIndex(Ctrl); }
        }
        public static void SetControl(ComboBox Ctrl, ref int Data, Dictionary<string, int> Defines, bool ToUI)
        {
            if (ToUI) Ctrl.Text = GetKeyByValue(Defines, Data);
            else { if (!String.IsNullOrEmpty(Ctrl.Text)) Data = Defines[Ctrl.Text]; Ctrl.SelectedIndex = -1; }
        }
        public static void SetControl(ComboBox Ctrl, ref uint Data, Dictionary<string, int> Defines, bool ToUI)
        {
            if (ToUI) Ctrl.Text = GetKeyByValue(Defines, (int)Data);
            else { if (!String.IsNullOrEmpty(Ctrl.Text)) Data = (uint)Defines[Ctrl.Text]; Ctrl.SelectedIndex = -1; }
        }
        public static void SetControl(ComboBox Ctrl, ref ushort Data, Dictionary<string, int> Defines, bool ToUI)
        {
            if (ToUI) Ctrl.Text = GetKeyByValue(Defines, (int)Data);
            else { if (!String.IsNullOrEmpty(Ctrl.Text)) Data = (ushort)Defines[Ctrl.Text]; Ctrl.SelectedIndex = -1; }
        }
        public static void SetControl(ComboBox Ctrl, ref string Data, Dictionary<string, int> Defines, bool ToUI)
        {
            if (ToUI)
            {
                for (int i = 0; i < Ctrl.Items.Count; i++)
                {
                    if (Data == (String)Ctrl.Items[i])
                        Ctrl.SelectedIndex = i;
                }
            }
            else { if (!String.IsNullOrEmpty(Ctrl.Text)) Data = Ctrl.Text; Ctrl.SelectedIndex = -1; }
        }

        public static void SetControlFlag(CheckBox Ctrl, ref Int32 Flags, ref Int32 Flag, bool ToUI)
        {
            if (ToUI) Ctrl.Checked = ((Flags & Flag) != 0);
            else { if (Ctrl.Checked) Flags = Flags | Flag; else Flags = Flags & ~Flag; }
        }
        public static void SetControlFlag(CheckBox Ctrl, ref UInt32 Flags, UInt32 Flag, bool ToUI)
        {
            if (ToUI) Ctrl.Checked = ((Flags & Flag) != 0);
            else { if (Ctrl.Checked) Flags = (uint)Flags | Flag; else Flags = Flags & ~Flag; }
        }
        public static void SetControlFlag(CheckBox Ctrl, ref ushort Flags, UInt32 Flag, bool ToUI)
        {
            if (ToUI) Ctrl.Checked = ((Flags & Flag) != 0);
            else { if (Ctrl.Checked) Flags = (ushort)(Flags | Flag); else Flags = (ushort)(Flags & ~Flag); }
        }
        public static void SetControlFlag(CheckBox Ctrl, ref byte Flags, UInt32 Flag, bool ToUI)
        {
            if (ToUI) Ctrl.Checked = ((Flags & Flag) != 0);
            else { if (Ctrl.Checked) Flags = (byte)(Flags | Flag); else Flags = (byte)(Flags & ~Flag); }
        }

        public static int GetGroupRadioButtonIndex(GroupBox Ctrl)
        {
            int count = 0;
            foreach (RadioButton Btn in Ctrl.Controls) { if (Btn.Checked) return count; count++; }
            return count;
        }

        public static string GetKeyByValue(Dictionary<string, int> Dict, int Value)
        {
            foreach (KeyValuePair<string, int> kvp in Dict)
                if (kvp.Value == Value)
                    return kvp.Key;
            return "";
        }

        public static void SetFlag(ref UInt32 Flags, UInt32 Flag)
        {
            Flags = (Flags | Flag);
        }

        public static bool IsFlagSet(UInt32 Flags, UInt32 Flag)
        {
            return ((Flags & Flag) != 0);
        }

        public static string ToStringProp(string Prop, string Value)
        {
            return "\t" + Prop+": " + Value + "\n";
        }

        private static object GetRegKeyValue(string KeyValuePath)
        {
            RegistryKey Key = Registry.LocalMachine.OpenSubKey(KeyValuePath.Remove(KeyValuePath.LastIndexOf('\\'), KeyValuePath.Length - KeyValuePath.LastIndexOf('\\')));
            if (Key == null) return null;
            string Value = KeyValuePath.Substring(KeyValuePath.LastIndexOf('\\')+1, KeyValuePath.Length - (KeyValuePath.LastIndexOf('\\')+1));
            return Key.GetValue(Value);
        }

        public static string GetCLRInfo()
        {
            List<NetVersion> Versions = new List<NetVersion>();
            Versions.Add(new NetVersion() 
            {
                Name="1.0", 
                RegKeyInstall=@"Software\Microsoft\.NETFramework\Policy\v1.0\3705", 
                RegKeySP=@"Software\Microsoft\Active Setup\Installed Components\{78705f0d-e8db-4b2d-8193-982bdda15ecd}\Version", 
                RegKeyVersion=@"Software\Microsoft\Active Setup\Installed Components\{78705f0d-e8db-4b2d-8193-982bdda15ecd}\Version"
            });

            Versions.Add(new NetVersion() 
            {
                Name="1.1", 
                RegKeyInstall=@"Software\Microsoft\NET Framework Setup\NDP\v1.1.4322\Install", 
                RegKeySP=@"Software\Microsoft\NET Framework Setup\NDP\v1.1.4322\SP", 
                RegKeyVersion=@"Software\Microsoft\NET Framework Setup\NDP\v1.1.4322"
            });

            Versions.Add(new NetVersion() 
            {
                Name="2.0", 
                RegKeyInstall=@"Software\Microsoft\NET Framework Setup\NDP\v2.0.50727\Install", 
                RegKeySP=@"Software\Microsoft\NET Framework Setup\NDP\v2.0.50727\SP", 
                RegKeyVersion=@"Software\Microsoft\NET Framework Setup\NDP\v2.0.50727\Version"
            });

            Versions.Add(new NetVersion() 
            {
                Name="3.0", 
                RegKeyInstall=@"Software\Microsoft\NET Framework Setup\NDP\v3.0\Setup\InstallSuccess", 
                RegKeySP=@"Software\Microsoft\NET Framework Setup\NDP\v3.0\SP", 
                RegKeyVersion=@"Software\Microsoft\NET Framework Setup\NDP\v3.0\Version"
            });

            Versions.Add(new NetVersion() 
            {
                Name="3.5", 
                RegKeyInstall=@"Software\Microsoft\NET Framework Setup\NDP\v3.5\Install", 
                RegKeySP=@"Software\Microsoft\NET Framework Setup\NDP\v3.5\SP", 
                RegKeyVersion=@"Software\Microsoft\NET Framework Setup\NDP\v3.5\Version"
            });

            Versions.Add(new NetVersion() 
            {
                Name="4.0 Client Profile", 
                RegKeyInstall=@"Software\Microsoft\NET Framework Setup\NDP\v4\Client\Install", 
                RegKeySP=@"Software\Microsoft\NET Framework Setup\NDP\v4\Client\Servicing", 
                RegKeyVersion=@"Software\Microsoft\NET Framework Setup\NDP\v4\Version"
            });

            Versions.Add(new NetVersion() 
            {
                Name="4.0 Full Profile", 
                RegKeyInstall=@"Software\Microsoft\NET Framework Setup\NDP\v4\Full\Install", 
                RegKeySP=@"Software\Microsoft\NET Framework Setup\NDP\v4\Full\Servicing", 
                RegKeyVersion=@"Software\Microsoft\NET Framework Setup\NDP\v4\Version"
            });

            string Info="";
            Info +="   OS version: " + Environment.OSVersion.VersionString + (IntPtr.Size == 4 ? " 32-bit" : " 64-bit") + Environment.NewLine;
            Info += "   .NET CLR version: " + Environment.Version + Environment.NewLine;

            if (Directory.Exists(@Environment.GetEnvironmentVariable("windir") + @"\Microsoft.NET\Framework"))
            {
                Info+="   .NET installed versions:"+Environment.NewLine;

                foreach (NetVersion version in Versions)
                {
                    version.Installed = (GetRegKeyValue(version.RegKeyInstall)!=null);
                    if (!version.Installed)
                        continue;
                    version.Version = (string)GetRegKeyValue(version.RegKeyVersion);
                    try { version.SP = ((int)GetRegKeyValue(version.RegKeySP)).ToString(); }
                    catch (Exception) { version.SP = (string)GetRegKeyValue(version.RegKeySP).ToString(); }
                }
                foreach (NetVersion version in Versions.FindAll(x => x.Installed))
                {
                    Info += "       " + version.Name + (version.SP!="0"?" (SP "+version.SP+")":"")+ (!String.IsNullOrEmpty(version.Version)?" - " + version.Version:"") + Environment.NewLine;
                }

            }
            return Info;
        }
    }
}
