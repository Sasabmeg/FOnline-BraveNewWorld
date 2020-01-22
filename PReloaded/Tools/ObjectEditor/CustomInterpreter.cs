using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectEditor
{
    // This class interprets Custom.cfg and generates appropriate controls based on the data.
    // See Custom.cfg for more info about the syntax.

    public class CommonVar
    {
        public CommonVar(int Default) { this.Value = Int32.MaxValue; this.Default = Default; }
        public int Value;
        public int Default;
    };

    class CustomInterpreter
    {
        CommonVar CommonSpace ;
        CommonVar CommonWidth ;
        CommonVar CommonMin   ;
        CommonVar CommonMax   ;

        string CommonItemTab="";
        int CommonPosX;
        int CommonPosY;
        int IncX;
        int IncY;

        // TabControl->Page
        private TabPage GetTabPageFromTabControl(TabControl Ctrl, String Name)
        {
            List<TabPage> Pages = new List<TabPage>();
            foreach (TabPage Page in Ctrl.TabPages)
                Pages.Add(Page);
            return GetTabPageByName(Pages, Name);
        }

        // Page->TabControl->Page
        private TabPage GetSubTabPageByName(IEnumerable<TabPage> Pages, String Name)
        {
            foreach (TabPage Page in Pages)
            {
                if (Page.Controls.Count == 0 || !(Page.Controls[0] is TabControl))
                    continue;

                TabControl Tab = (TabControl)Page.Controls[0];
                return GetTabPageFromTabControl(Tab, Name);
            }
            return null;
        }

        private TabPage GetTabPageByName(IEnumerable<TabPage> Pages, String Name)
        {
            foreach (TabPage Page in Pages)
            {
                if (Page.Name == Name)
                    return Page;
            }
            return null;
        }

        private TabPage GetCustomTabPage(frmMain Main, TabControl MainTabControl, Dictionary<string, List<TabPage>> CustomTabPages, String TabPageName)
        {
            TabPage Page = null;
            Page = GetTabPageFromTabControl(MainTabControl, TabPageName);

            if (Page == null)
                Page = GetSubTabPageByName(Main.HardcodedTabs.Values, TabPageName);

            if (Page == null)
            {
                foreach (List<TabPage> Pages in CustomTabPages.Values)
                {
                    Page = GetTabPageByName(Pages, TabPageName);
                    if (Page != null) break;
                }
            }
            return Page;
        }

        private void IfNonZeroSet(int Value, ref int VariableToSet)
        {
            if (Value != 0) VariableToSet = Value;
        }

        private void IfNonZeroSet(string Value, ref string VariableToSet)
        {
            if (!String.IsNullOrEmpty(Value)) VariableToSet = Value;
        }

        private int GetObjectValue(int Primary, CommonVar Common)
        {
            if (Primary != 0) return Primary;
            return (Common.Value == Int32.MaxValue ? Common.Default : Common.Value);
        }

        private int GetObjectValue(int Primary, int Fallback)
        {
            if (Primary != 0) return Primary;
            return Fallback;
        }

        private Label CreateLabelControl(string Text, Point Position, int FontSize)
        {
            Label Lbl = new Label();
            Lbl.AutoSize = true;
            Lbl.Text = Text;
            Lbl.Location = new Point(Position.X, Position.Y);
            if (FontSize != 0) Lbl.Font = new Font(Lbl.Font.FontFamily, FontSize);
            return Lbl;
        }

        private Label CreateLabelControl(LabelObject UIObject, Point Position)
        {
            Label Lbl = CreateLabelControl(UIObject.Text, Position, UIObject.FontSize);
            Lbl.Tag = UIObject;
            return Lbl;
        }

        private NumericUpDown CreateNumericControl(FieldObject UIObject, Point Position)
        {
            NumericUpDown Num = new NumericUpDown();
            Num.Location = Position;
            Num.Minimum = GetObjectValue(UIObject.Min,   CommonMin);
            Num.Maximum = GetObjectValue(UIObject.Max,   CommonMax);
            Num.Width   = GetObjectValue(UIObject.Width, CommonWidth);
            Num.Tag = UIObject;
            return Num;
        }

        private CheckBox CreateCheckBoxControl(FieldObject UIObject, Point Position)
        {
            CheckBox Chk = new CheckBox();
            Chk.Text = UIObject.Text;
            Chk.Location = new Point(Position.X, Position.Y);
            Chk.Tag = UIObject;
            return Chk;
        }

         private void InitEnvironment()
        {
            CommonPosX  = 10;
            CommonPosY  = 10;
            CommonSpace = new CommonVar(85);
            CommonWidth = new CommonVar(75);
            CommonMin   = new CommonVar(0);
            CommonMax   = new CommonVar(100);
            IncX        = 0;
            IncY        = 20;
        }

        public void ProcessFields(frmMain Main, TabControl MainTabControl, Dictionary<string, List<TabPage>> CustomTabPages, Dictionary<string, List<CustomUIObject>> Objects, Graphics g)
        {
            foreach (KeyValuePair<string, List<CustomUIObject>> kvp in Objects)
            {
                // This is the TabPage where these objects go to
                TabPage Page = GetCustomTabPage(Main, MainTabControl, CustomTabPages, kvp.Key);
                if (Page == null)
                    continue;

                InitEnvironment();

                foreach (CustomUIObject CObj in kvp.Value)
                {
                    int PosX = GetObjectValue(CObj.PosX, CommonPosX);
                    int PosY = GetObjectValue(CObj.PosY, CommonPosY);

                    Point Position = new Point(PosX, PosY);

                    if (CObj is LabelObject)
                    {
                        Page.Controls.Add(CreateLabelControl((LabelObject)CObj, Position));
                    }
                    else if (CObj is FieldObject)
                    {
                        FieldObject FObj = (FieldObject)CObj;
                        if (FObj.DataType == "bool")
                            Page.Controls.Add(CreateCheckBoxControl((FieldObject)CObj, Position));
                        else
                        {
                            // Label-->[Space]-->NumericControl
                            Page.Controls.Add(CreateLabelControl(CObj.Text, new Point(PosX, PosY), 0));
                            int Space = GetObjectValue(FObj.Space, CommonSpace);
                            Page.Controls.Add(CreateNumericControl(FObj, new Point(PosX + Space, PosY - 2)));
                        }
                    }
                    else if (CObj is CommonObject)
                    {
                        CommonObject IObj = (CommonObject)CObj;
                        IfNonZeroSet(IObj.Space, ref CommonSpace.Value);
                        IfNonZeroSet(IObj.IncX, ref IncX);
                        IfNonZeroSet(IObj.IncY, ref IncY);
                        IfNonZeroSet(IObj.Min, ref CommonMin.Value);
                        IfNonZeroSet(IObj.Max, ref CommonMax.Value);
                        IfNonZeroSet(IObj.Width, ref CommonWidth.Value);
                        IfNonZeroSet(IObj.PosX, ref CommonPosX);
                        IfNonZeroSet(IObj.PosY, ref CommonPosY);
                        IfNonZeroSet(IObj.ItemTab, ref CommonItemTab);
                    }

                    if (!(CObj is CommonObject))
                    {
                        CommonPosX += IncX;
                        CommonPosY += IncY;
                    }
                }
            }
        }
    }
}
