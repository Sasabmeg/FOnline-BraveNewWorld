using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

// This class handles custom proto fields defined in Custom.cfg.
// See Custom.cfg for more info about the syntax.

namespace ObjectEditor
{
    public class CustomUIObject 
    {
        public string Text;
        public int PosX;
        public int PosY;
        public string ItemTab;
        public int Width;
        public int Min;
        public int Max;
        public int Space;
    }

    public class FieldObject : CustomUIObject
    {
        public string CustomFieldName;
        public string DataType;
    }

    public class LabelObject : CustomUIObject
    {
        public int FontSize;
    }
    public class CommonObject : CustomUIObject 
    {
        public int IncX;
        public int IncY;
    }

    public class Custom
    {
        public Dictionary<string, string> CustomFlags = new Dictionary<string, string>();
        public Dictionary<string, FOCommon.Items.ItemProtoCustomField> CustomFields = new Dictionary<string, FOCommon.Items.ItemProtoCustomField>();
        public Dictionary<string, List<TabPage>> CustomTabPages = new Dictionary<string, List<TabPage>>();

        Dictionary<string, List<CustomUIObject>> Objects = new Dictionary<string, List<CustomUIObject>>();

        private string FieldName, FieldValue;

        frmMain Main;
        Graphics g;
        TabControl TabControlMain;
        TabControl TabControlProperties;

        String ItemTabCommon;

        public Custom(frmMain Main, Graphics g, TabControl TabControlMain, TabControl TabControlProperties)
        {
            this.Main = Main;
            this.g = g;
            this.TabControlMain = TabControlMain;
            this.TabControlProperties = TabControlProperties;
        }

        public void ParseFlags()
        {
            CustomFlags.Clear();
            List<String> Lines = new List<string>(File.ReadAllLines(".\\Flags.cfg"));
            char[] Sep = { ',' };
            
            foreach (String Line in Lines)
            {
                if (Line.Substring(0, 2) == "//" || Line[0] == '#')
                    continue;
                String[] Parts = Line.Split(Sep, StringSplitOptions.RemoveEmptyEntries);
                if (!Data.Defines.ContainsKey(Parts[0]))
                {
                    Message.Show("Trying to create GUI control for " + Parts[0] + " but no such flag exists in _defines.fos" + Environment.NewLine + "Check Flags.cfg", MessageBoxButtons.OK, MessageBoxIcon.Error, true);
                    continue;
                }
                CustomFlags.Add(Parts[1], Parts[0]);
            }
        }

        public void ParseLine(string Line)
        {
            String[] Parts = Line.Split(new char[]{'='}, StringSplitOptions.RemoveEmptyEntries);
            if (Parts.Length != 2) return;
            FieldName = Parts[0];
            FieldValue = Parts[1];
            if (FieldValue.Contains("#")) FieldValue = FieldValue.Remove(FieldValue.IndexOf('#'));
        }

        public void ParseData(string IfText, ref string Value) { if (IfText == FieldName) Value = FieldValue; }
        public void ParseData(string IfText, ref int Value) { if (IfText == FieldName) Value = Int32.Parse(FieldValue); }

        public CustomUIObject ParseCommonData(CustomUIObject Obj)
        {
            ParseData("ItemTab", ref Obj.ItemTab);
            ParseData("PosX", ref Obj.PosX);
            ParseData("PosY", ref Obj.PosY);
            ParseData("Min", ref Obj.Min);
            ParseData("Max", ref Obj.Max);
            ParseData("Width", ref Obj.Width);
            ParseData("Space", ref Obj.Space);
            ParseData("Text", ref Obj.Text);
            return Obj;
        }

        private void AddPage(TabControl Ctrl, string TopTab, String ItemTab, string Text)
        {
            TabPage SubPage = new TabPage();
            SubPage.Name = ItemTab;
            SubPage.Text = Text;
            SubPage.BackColor = Color.Transparent;
            SubPage.UseVisualStyleBackColor = true;
            Ctrl.TabPages.Add(SubPage);
            if (!CustomTabPages.ContainsKey(TopTab))
                CustomTabPages.Add(TopTab, new List<TabPage>());
            CustomTabPages[TopTab].Add(SubPage);
        }

        private bool SkipLine(String Line)
        {
            return (String.IsNullOrEmpty(Line) || (Line.Length>0 && Line[0] == '#') || (Line.Length>1 && Line[1] == '#') 
                || (Line.Length>1 && Line.Substring(0, 2) == "//"));
        }

        private void AddObject(CustomUIObject Obj)
        {
            if (Obj.ItemTab == null)
                Obj.ItemTab = ItemTabCommon;

            if (!Objects.ContainsKey(Obj.ItemTab))
                Objects[Obj.ItemTab] = new List<CustomUIObject>();
            List<CustomUIObject> ObjType = Objects[Obj.ItemTab];
            ObjType.Add(Obj);
        }


        public FieldObject ParseFieldObject(List<String> Lines, ref int i)
        {
            FieldObject Obj = new FieldObject();
            do
            {
                ParseLine(Lines[i++]);
                Obj = (FieldObject)ParseCommonData(Obj);
                ParseData("FieldName", ref Obj.CustomFieldName);
                ParseData("DataType", ref Obj.DataType);

            } while (Lines[i] != "");
            return Obj;
        }

        public LabelObject ParseLabelObject(List<String> Lines, ref int i)
        {
            LabelObject Obj = new LabelObject();
            do
            {
                ParseLine(Lines[i++]);
                Obj = (LabelObject)ParseCommonData(Obj);
                ParseData("FontSize", ref Obj.FontSize);
            } while (Lines[i] != "");
            return Obj;
        }

        public CommonObject ParseCommonObject(List<String> Lines, ref int i)
        {
            CommonObject Obj = new CommonObject();
            do
            {
                ParseLine(Lines[i++]);
                Obj = (CommonObject)ParseCommonData(Obj);
                ParseData("IncX", ref Obj.IncX);
                ParseData("IncY", ref Obj.IncY);
                ParseData("ItemTab", ref ItemTabCommon);
            } while (Lines[i] != "");
            return Obj;
        }

        public void CreateTabPage(List<String> Lines, ref int i)
        {
            String TopTab="";
            String ItemTab = "";
            String ItemType = "";
            String Text = "";

            do
            {
                ParseLine(Lines[i++]);
                ParseData("TopTab", ref TopTab);
                ParseData("ItemTab", ref ItemTab);
                ParseData("ItemType", ref ItemType);
                ParseData("Text", ref Text);
            } while (Lines[i] != "");

            TabPage TopPage = null;
            TabControl SubControl = null;

            if (TopTab == "Main")
            {
                SubControl = TabControlMain;
            }
            else
            {
                if (Main.HardcodedTabs.ContainsKey(TopTab))
                    TopPage = Main.HardcodedTabs[TopTab];

                if (TopPage == null)
                {
                    if (!CustomTabPages.ContainsKey(TopTab))
                    {
                        TopPage = new TabPage();
                        TopPage.Text = TopTab;
                        TopPage.BackColor = Color.Transparent;
                        TopPage.UseVisualStyleBackColor = true;
                        TopPage.Tag = ItemType;
                        SubControl = new TabControl();
                        SubControl.Location = new Point(3, 3);
                        SubControl.Size = new Size(764, 160);
                        TopPage.Controls.Add(SubControl);
                        TabControlProperties.TabPages.Add(TopPage);
                        SubControl = (TabControl)TopPage.Controls[0];
                    }
                    else
                    {
                        SubControl = (TabControl)CustomTabPages[TopTab][0].Parent;
                    }
                }
                else
                    SubControl = (TabControl)TopPage.Controls[0];
            }
            bool Found = false;
            foreach (TabPage Page in SubControl.TabPages)
            {
                if (Page.Name == ItemTab) { Found = true; break; }
            }
            if (!Found)
            {
                AddPage(SubControl, TopTab, ItemTab, Text);
            }
        }

        public void ParseObjects()
        {
            Objects.Clear();
            CustomFields.Clear();

            List<String> Lines = new List<string>(File.ReadAllLines(".\\Custom.cfg", Encoding.UTF8));
            Lines.Add("");

            for(int i=0;i<Lines.Count;i++)
            {
                String Line = Lines[i];
                if(SkipLine(Line))
                    continue;

                if (Line == "[Field]")
                {
                    FieldObject Obj = ParseFieldObject(Lines, ref i);
                    CustomFields.Add(Obj.CustomFieldName, new FOCommon.Items.ItemProtoCustomField(Obj.CustomFieldName,
                        FOCommon.Utils.GetTypeFromString(Obj.DataType)));
                    AddObject(Obj);
                }
                else if (Line == "[Label]")
                    AddObject(ParseLabelObject(Lines, ref i));
                else if (Line == "[Common]")
                    AddObject(ParseCommonObject(Lines, ref i));
                else if (Line == "[CreateTab]")
                    CreateTabPage(Lines, ref i);
            }

            CustomInterpreter Interpreter = new CustomInterpreter();
            Interpreter.ProcessFields(Main, TabControlMain, CustomTabPages, Objects, g);
        }

        public void CreateFilterButtons(int x, int y, Panel pnl, EventHandler Handler)
        {
            List<String> Items = new List<string>(Data.ItemTypes.Keys);
            Items.Sort();

            foreach (String Type in Items)
                if (Type != "NONE" && Type != "ITEM_TYPE_NONE")
                {
                    CheckBox Chk = new CheckBox();
                    pnl.Controls.Add(Chk);
                    Chk.UseVisualStyleBackColor = true;
                    Chk.Text = Type;
                    Chk.Location = new Point(x, y);
                    Chk.Name = "_chk" + Type;
                    Chk.AutoSize = true;
                    Chk.Checked = true;
                    Chk.BringToFront();
                    Chk.CheckedChanged += Handler;
                    y += 14;
                }
        }

        public void CreateFlags(GroupBox GrpBox, int x, int y, bool Chked)
        {
            int beginY = y;
            int count = 0;
            foreach(KeyValuePair<String, String> kvp in CustomFlags)
            {

                CheckBox chkBox = new CheckBox();
                chkBox.Text = kvp.Key;
                chkBox.Tag = kvp.Value;
                GrpBox.Controls.Add(chkBox);
                chkBox.Location = new System.Drawing.Point(x, y);
                chkBox.AutoSize = true;
                chkBox.Checked = Chked;
                chkBox.BringToFront();
                y += 14;
                count++;
                if (count == 19)
                {
                    x += 100;
                    y = beginY;
                }
            }
        }
    }
}
