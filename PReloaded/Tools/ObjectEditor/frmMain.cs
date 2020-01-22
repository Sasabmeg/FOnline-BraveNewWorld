using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using BrightIdeasSoftware;
using FOCommon.Items;
using FOCommon.Parsers;
using FOCommon.Translation;
using FOCommon.Win32;

namespace ObjectEditor
{
    public partial class frmMain : Form
    {
        List<ItemProto> LoadedProtos = new List<ItemProto>();
        List<String> LoadedFilenames = new List<string>();
        public Dictionary<String, TabPage> HardcodedTabs = new Dictionary<string, TabPage>();
        MSGParser FOObj;
        private Config Config;

        frmFrmGallery gallery;


        Thread ScriptThread = null;
        ItemProto CurrentProto=null;
        frmOptions OptionsForm;
        frmFilter FilterForm;
        frmMain MainObj;
        Custom CustomInterface;
        bool IsFirstPaint = true;
        uint FilterFlags;

        int LIGHT_DISABLE_DIR(Byte dir) { return (1 << Utils.Clamp(dir, 0, 5)); }
        const uint LIGHT_GLOBAL = 0x40;
        const uint LIGHT_INVERSE = 0x80;

        public frmMain()
        {
            Directory.SetCurrentDirectory(Directory.GetParent(Assembly.GetExecutingAssembly().Location).ToString());

            Config = new Config("ObjectEditor");
            if (Config.IsFirstTime())
            {
                OptionsForm = new frmOptions(Config);
                OptionsForm.ShowDialog();
            }
            Config.Load();

            Utils.InitLog(".\\ObjectEditor.log");
            FOCommon.Utils.InitLog(".\\ObjectEditor.log", false);
            Utils.Log("Initializing Object Editor " + Utils.GetVersion() + " compatible with " + Utils.GetFormatCompatibilityVersion() + " format.");
            Utils.Log(FOCommon.Utils.GetCLRInfo());

            if (Config.ScriptingEnabled)
            {
                Utils.Log("Starting scripthost...");
                Scripting.Host.ScriptHost = new Scripting.OEScriptHost();
                Scripting.Host.ScriptGlobal = new Scripting.ScriptGlobal();
                Scripting.Host.ScriptGlobal.Init(Scripting.Host.ScriptHost);
                Scripting.Host.ScriptHost.Init(this, Config.PathEditorScript);
                Scripting.Host.ScriptHost.RegisterFormEvents(this);
            }

            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        string GetAbout()
        {
            return "FOnline ObjectEditor " + Utils.GetVersion() + Environment.NewLine +
                           "Coded by Ghosthack" + Environment.NewLine +
                           "Original tool by cvet" + Environment.NewLine +
                           "http://fonline.ru" + Environment.NewLine +
                           "http://fodev.net" + Environment.NewLine +
                           "http://github.com/rotators/tools" +
                           
                           Environment.NewLine + Environment.NewLine +
                           "Compatible with proto files from ObjectEditor " + Utils.GetFormatCompatibilityVersion() + " and newer." + Environment.NewLine + 
                           Environment.NewLine +
                           "Uses the Silk Icon set 1.3 by Mark James http://www.famfamfam.com/lab/icons/silk/";
        }

        private void Exit()
        {
            Utils.Log("Exiting...");
            Config.WindowLocationX = this.Location.X;
            Config.WindowLocationY = this.Location.Y;
            Config.WindowSizeX = this.Size.Width;
            Config.WindowSizeY = this.Size.Height;
            Config.Save();
            Utils.SerializeObjectListView(".\\listview.bin", ref lstProtos, false);
       
            WinAPI.UnsetWindowExFlag(this.Handle, (int)Win32.WS_EX_COMPOSITED);
            WinAPI.UnsetWindowExFlag(this.Handle, (int)Win32.WS_EX_LAYERED);
            Environment.Exit(0);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void InitGuiDefines()
        {
            foreach (KeyValuePair<string, int> kvp in Data.ItemTypes)   { cmbType.Items.Add(kvp.Key); }
            foreach (KeyValuePair<string, int> kvp in Data.Calibers)    { cmbCaliberAmmo.Items.Add(kvp.Key); cmbCaliberWeapon.Items.Add(kvp.Key); }
            foreach (KeyValuePair<string, int> kvp in Data.WeaponPerks) { cmbWeaponPerk.Items.Add(kvp.Key); }
            foreach (KeyValuePair<string, int> kvp in Data.Anim1)       { cmbAnim1.Items.Add(kvp.Key); } 
            foreach (KeyValuePair<string, int> kvp in Data.Anim2)       { cmbWeaponAnim2_1.Items.Add(kvp.Key); } 
            foreach (KeyValuePair<string, int> kvp in Data.Anim2)       { cmbWeaponAnim2_2.Items.Add(kvp.Key); } 
            foreach (KeyValuePair<string, int> kvp in Data.Anim2)       { cmbWeaponAnim2_3.Items.Add(kvp.Key); } 
            foreach (KeyValuePair<string, int> kvp in Data.ItemPid)     { cmdWeaponDefaultAmmo.Items.Add(kvp.Key); }
            foreach (KeyValuePair<string, int> kvp in Data.Skills)      { cmbWeaponSkill1.Items.Add(kvp.Key); }
            foreach (KeyValuePair<string, int> kvp in Data.Skills)      { cmbWeaponSkill2.Items.Add(kvp.Key); }
            foreach (KeyValuePair<string, int> kvp in Data.Skills)      { cmbWeaponSkill3.Items.Add(kvp.Key); }
            foreach (KeyValuePair<string, int> kvp in Data.DamageTypes) { cmbDmgType1.Items.Add(kvp.Key); }
            foreach (KeyValuePair<string, int> kvp in Data.DamageTypes) { cmbDmgType2.Items.Add(kvp.Key); }
            foreach (KeyValuePair<string, int> kvp in Data.DamageTypes) { cmbDmgType3.Items.Add(kvp.Key); }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "FOnline Object Editor " + Utils.GetVersion();
            MainObj = this;

            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.txtSearch, "Enter text to search for in any visible column (name, pid, script function etc.). Case insensitive.");

            this.Size = new Size(Config.WindowSizeX, Config.WindowSizeY);
            this.Location = new Point(Config.WindowLocationX, Config.WindowLocationY);

            if (!Data.LoadDefines(Config))
                Exit();

            OptionsForm = new frmOptions(Config);
            Utils.SerializeObjectListView(".\\listview.bin", ref lstProtos, true);
            InitGuiDefines();
            SetListViewFormatters();

            Translate.WriteTemplateLanguageFile(this);

            Data.Init();
            InitData();
             
            SetTabPages();
            ItemProtoParser ProtoParser = new ItemProtoParser();

            if (Config.ScriptingEnabled)
            {
                Utils.Log("Starting script thread...");
                ScriptThread = new Thread(new ThreadStart(UpdateScripts_Tick));
                ScriptThread.Start();
            }

            Utils.Log("Initializing successful.");
        }

        private void InitData()
        {
            if (Config.TranslateLanguage)
            {
                Translate.LoadLanguage(Config.PathLanguage);
                Translate.TranslateForm(this);
            }
            InitFOObj();
        }

        // Runs after GUI is initialized
        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            if (IsFirstPaint)
            {
                if(Config.LoadGraphics)
                    backgroundResources.RunWorkerAsync();
                InitCustomGui(e.Graphics);
                //
                IsFirstPaint = false;
                if(FOCommon.Utils.IsWinVistaOrHigher())
                    this.TransparencyKey = Color.Lime; // Hack, to enable WS_EX_COMPOSITED to work
                if (Config.ScriptingEnabled)
                {
                    Scripting.Host.ScriptHost.main_form_loaded();
                    Scripting.Host.ScriptHost.resources_loaded();
                    Scripting.Host.ScriptHost.InstallExtensionsMenu(this.MainMenuStrip, 3);
                    List<Control> Ctrls = FOCommon.Utils.GetAllControls(this.Controls);
                    for (int i = 0; i < Ctrls.Count;i++ )
                    {
                        bool Add = true;
                        Control RefCtrl = Ctrls[i];
                        Scripting.Host.ScriptHost.add_control(ref RefCtrl, ref Add);
                        if (!Add) Ctrls[i].Visible = false;
                    }
                }
            }
        }

        private void InitCustomGui(Graphics g)
        {
            CustomInterface = new Custom(this, g, this.panelMain, this.panelProperties);   
            CustomInterface.ParseFlags();
            CustomInterface.CreateFlags(grpExtInfoFlags, 7, 15, false);
            CustomInterface.ParseObjects();
            pnlFilterButtons.Visible = false;
            CustomInterface.CreateFilterButtons(0, 0, pnlFilterButtons, chkFilter_CheckedChanged);
            pnlFilterButtons.Visible = true;

            FilterForm = new frmFilter(CustomInterface);
        }

        private bool IsFilterTypeChecked(string Name)
        {
            foreach (Control Ctrl in pnlFilterButtons.Controls)
            {
                CheckBox Chk = (CheckBox)Ctrl;
                if (Chk.Text == Name)
                    return Chk.Checked;
            }
            return false;
        }

        private void SetListViewFormatters()
        {
            this.olvType.AspectToStringConverter = delegate(object x) {
                int Id=(int)x;
                return String.Format("{0}", FOCommon.Utils.GetKeyByValue(Data.ItemTypes, Id));
            };

            this.olvPID.AspectToStringConverter = delegate(object x)
            {
                UInt16 Pid = (UInt16)x;
                if (Config.ShowItemPidDefine)
                {
                    String Str = FOCommon.Utils.GetKeyByValue(Data.ItemPid, Pid);
                    if (String.IsNullOrEmpty(Str))
                        return String.Format("{0}", Pid);
                    else
                    {
                        if (Config.ItemPidDefineBeforeId)
                            return String.Format("{0}", Str + " [" + Pid + "]");
                        else
                            return String.Format("{0}", Pid + " [" + Str + "]");
                    }
                }
                return String.Format("{0}", Pid);
            };

            this.olvFile.AspectToStringConverter = delegate(object x)
            {
                String FilePath = (String)x;
                if (Config.ShowWholeFilePath)
                    return FilePath;
                return Path.GetFileName(FilePath);
            };
        }

        bool LoadProtoList(string Path)
        {
            // Parse stuff
            ItemProtoParser ProtoParser = new ItemProtoParser();
            int Count = LoadedProtos.Count;
            if (ProtoParser.LoadProtosFromFile(Path, Utils.GetVersion(), FOObj, LoadedProtos, CustomInterface.CustomFields))
            {
                Message.Show("Some protos already loaded have been overwritten because they had the same proto id, for information on which protos, see ObjectEditor.log",
                      System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            lstProtos.SetObjects(LoadedProtos);

            if (Count == LoadedProtos.Count)
            {
                Message.Show("Invalid file or version of the proto. No item data found.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void changeStatus(string Text)
        {
            this.toolStripStatus.Text = DateTime.Now.ToString("HH:mm:ss") + ": " + Text;
        }

        private void LoadFileName(string FileName)
        {
            if (LoadedFilenames.Contains(FileName))
            {
                Message.Show(FileName + " is already loaded.", MessageBoxButtons.OK, MessageBoxIcon.Error, true);
                return;
            }
            if (LoadProtoList(FileName))
            {
                LoadedFilenames.Add(FileName);
                changeStatus("Loaded " + FileName);
            }
        }

        private void loadListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenProto = new OpenFileDialog();
            OpenProto.Filter = "Proto list|*.fopro;*.lst";
            OpenProto.Multiselect = true;
            OpenProto.RestoreDirectory = true;
            if (OpenProto.ShowDialog() == DialogResult.OK)
            {
                foreach (String FileName in OpenProto.FileNames)
                {
                    if (Path.GetExtension(FileName) == ".lst")
                    {
                        foreach (String Line in File.ReadAllLines(FileName, Encoding.UTF8))
                        {
                            if (Line.Length > 0 && Line[0] == '#')
                                continue;
                            if (Path.IsPathRooted(Line))
                                LoadFileName(Line);
                            else
                                LoadFileName(Path.GetDirectoryName(FileName) + "\\" + Line);
                        }
                    }
                    else
                        LoadFileName(FileName);
                }
            }
        }

        private void InitFOObj()
        {
            FOObj = new MSGParser(Config.PathObjMsg);
            if (!FOObj.Parse())
                Utils.Log("Failed to parse FOObj.msg");
        }


        // Property tabs that are hardcoded
        // searched in custom controls code (CustomInterpreter.cs)
        public void SetTabPages()
        {
            HardcodedTabs.Add("Ammo", tabPageAmmo);
            HardcodedTabs.Add("Armor", tabPageArmor);
            HardcodedTabs.Add("Car", tabPageCar);
            HardcodedTabs.Add("Container", tabPageContainer);
            HardcodedTabs.Add("Door", tabPageDoor);
            HardcodedTabs.Add("Drug", tabPageDrug);
            HardcodedTabs.Add("Generic", tabPageGeneric);
            HardcodedTabs.Add("Grid", tabPageGrid);
            HardcodedTabs.Add("Key", tabPageKey);
            HardcodedTabs.Add("Misc", tabPageMisc);
            HardcodedTabs.Add("Wall", tabPageWall);
            HardcodedTabs.Add("Weapon", tabPageWeapon);
        }

        private TabPage GetTabPageByItemType(int ItemType)
        {
            switch (ItemType)
            {
                case (int)FOCommon.Parsers.ItemTypes.ITEM_AMMO: return tabPageAmmo;
                case (int)FOCommon.Parsers.ItemTypes.ITEM_ARMOR: return tabPageArmor;
                case (int)FOCommon.Parsers.ItemTypes.ITEM_CAR: return tabPageCar;
                case (int)FOCommon.Parsers.ItemTypes.ITEM_CONTAINER: return tabPageContainer;
                case (int)FOCommon.Parsers.ItemTypes.ITEM_DOOR: return tabPageDoor;
                case (int)FOCommon.Parsers.ItemTypes.ITEM_DRUG: return tabPageDrug;
                case (int)FOCommon.Parsers.ItemTypes.ITEM_GENERIC: return tabPageGeneric;
                case (int)FOCommon.Parsers.ItemTypes.ITEM_GRID: return tabPageGrid;
                case (int)FOCommon.Parsers.ItemTypes.ITEM_KEY: return tabPageKey;
                case (int)FOCommon.Parsers.ItemTypes.ITEM_MISC: return tabPageMisc;
                case (int)FOCommon.Parsers.ItemTypes.ITEM_WALL: return tabPageWall;
                case (int)FOCommon.Parsers.ItemTypes.ITEM_WEAPON: return tabPageWeapon;
                default: return null;
            }
        }

        private void lstProtos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ItemProto Prot = (ItemProto)lstProtos.SelectedObject;
            if (Prot != null)
                SetNewProto(Prot);
        }

        private void SetNewProto(ItemProto Prot)
        {
            if (CurrentProto != null)
                SetProtoGUI(CurrentProto, false); // Save data to proto
            CurrentProto = Prot;
            SetProtoGUI(CurrentProto, true);
            if (Config.SwitchTab)
            {
                TabPage Page = GetTabPageByItemType(CurrentProto.Type);
                if (Page == null)
                {
                    foreach (TabPage TopPage in panelProperties.Controls)
                    {
                        String ItemType = (String)TopPage.Tag;
                        if (ItemType == null)
                            continue;
                        if (Data.ItemTypes.ContainsKey(ItemType) || Data.ItemTypes.ContainsKey("ITEM_TYPE_" + ItemType))
                        {
                            Page = TopPage;
                            break;
                        }
                    }

                }

                panelProperties.SelectedTab = Page;
                lstProtos.Focus();
            }
        }

        void SetCustomTabPage(ref ItemProto Prot, TabPage Page, bool ToUI)
        {
            foreach (Control Ctrl in Page.Controls)
            {
                if (Ctrl is NumericUpDown)
                {
                    NumericUpDown Num = (NumericUpDown)Ctrl;
                    FieldObject FieldData;

                    FieldData = (FieldObject)Num.Tag;
                    if (FieldData == null)
                        continue;

                    if (ToUI)
                    {
                        Num.Value = 0;
                        if (Prot.CustomFields.ContainsKey(FieldData.CustomFieldName))
                        {
                            if (Prot.CustomFields[FieldData.CustomFieldName].Value is Decimal)
                                Num.Value = (decimal)Prot.CustomFields[FieldData.CustomFieldName].Value;
                            if (Prot.CustomFields[FieldData.CustomFieldName].Value is int)
                                Num.Value = (int)Prot.CustomFields[FieldData.CustomFieldName].Value;
                            if (Prot.CustomFields[FieldData.CustomFieldName].Value is uint)
                                Num.Value = (uint)Prot.CustomFields[FieldData.CustomFieldName].Value;
                            if (Prot.CustomFields[FieldData.CustomFieldName].Value is UInt16)
                                Num.Value = (UInt16)Prot.CustomFields[FieldData.CustomFieldName].Value;
                            if (Prot.CustomFields[FieldData.CustomFieldName].Value is Int16)
                                Num.Value = (Int16)Prot.CustomFields[FieldData.CustomFieldName].Value;
                            if (Prot.CustomFields[FieldData.CustomFieldName].Value is SByte)
                                Num.Value = (SByte)Prot.CustomFields[FieldData.CustomFieldName].Value;
                        }
                    }
                    else
                    {
                        if (Prot.CustomFields.ContainsKey(FieldData.CustomFieldName))
                            Prot.CustomFields[FieldData.CustomFieldName].Value = Num.Value;
                        if (Num.Value != 0 && !Prot.CustomFields.ContainsKey(FieldData.CustomFieldName))
                        {
                            ItemProtoCustomField NewField = new ItemProtoCustomField(FieldData.CustomFieldName, FOCommon.Utils.GetTypeFromString(FieldData.DataType));
                            NewField.Value = Num.Value;
                            Prot.CustomFields.Add(FieldData.CustomFieldName, NewField);
                        }
                    }
                }
                else if (Ctrl is CheckBox)
                {
                    CheckBox Chk = (CheckBox)Ctrl;
                    FieldObject FieldData;

                    FieldData = (FieldObject)Chk.Tag;
                    if (FieldData == null)
                        continue;

                    if (ToUI)
                    {
                        if (Prot.CustomFields.ContainsKey(FieldData.CustomFieldName) && Prot.CustomFields[FieldData.CustomFieldName].Value is bool)
                            Chk.Checked = (bool)Prot.CustomFields[FieldData.CustomFieldName].Value;
                        else
                            Chk.Checked = false;
                    }
                    else
                    {
                        if (Prot.CustomFields.ContainsKey(FieldData.CustomFieldName))
                            Prot.CustomFields[FieldData.CustomFieldName].Value = Chk.Checked;
                        if (Chk.Checked && !Prot.CustomFields.ContainsKey(FieldData.CustomFieldName))
                        {
                            ItemProtoCustomField NewField = new ItemProtoCustomField(FieldData.CustomFieldName, FOCommon.Utils.GetTypeFromString(FieldData.DataType));
                            NewField.Value = true;
                            Prot.CustomFields.Add(FieldData.CustomFieldName, NewField);
                        }
                    }
                }
            }
        }

        void SetCustomData(ref ItemProto Prot, bool ToUI)
        {
            // Custom data, see Custom.cfg
            // Parse trough all pages in properties panels
            foreach (TabPage Page in panelProperties.TabPages)
            {
                TabControl SubControl = null;
                foreach (Control TopCtrl in Page.Controls)
                {
                    if (TopCtrl is TabControl)
                        SubControl = (TabControl)Page.Controls[0];
                }
                if (SubControl == null)
                    continue;

                foreach (TabPage SubPage in SubControl.TabPages)
                {
                    SetCustomTabPage(ref Prot, SubPage, ToUI);
                }
            }

            foreach (TabPage Page in panelMain.TabPages)
            {
                SetCustomTabPage(ref Prot, Page, ToUI);
            }
        }

        void SetProtoGUI(ItemProto Prot, bool ToUI)
        {
            if (Prot == null) return;

            // UI<->Data sync
            // Uncommented stuff are not implemented in GUI yet
#region SetControl
            try
            {
                FOCommon.Utils.SetControl(numPID, ref Prot.ProtoId, ToUI);
                FOCommon.Utils.SetControl(cmbType, ref Prot.Type, Data.ItemTypes, ToUI);
                FOCommon.Utils.SetControl(txtName, ref Prot.Name, ToUI);
                FOCommon.Utils.SetControl(txtProtoFileName, ref Prot.FileName, ToUI);
                FOCommon.Utils.SetControl(txtDescription, ref Prot.Description, ToUI);
                FOCommon.Utils.SetControl(txtScriptModule, ref Prot.ScriptModule, ToUI);
                FOCommon.Utils.SetControl(txtScriptFunction, ref Prot.ScriptFunction, ToUI);
                FOCommon.Utils.SetControl(txtGroundPic, ref Prot.PicMap, ToUI);
                FOCommon.Utils.SetControl(txtInvPic, ref Prot.PicInv, ToUI);
                FOCommon.Utils.SetControl(chkStackable, ref Prot.Stackable, ToUI);
                FOCommon.Utils.SetControl(chkDeteriorable, ref Prot.Deteriorable, ToUI);
                FOCommon.Utils.SetControl(chkGroundLevel, ref Prot.GroundLevel, ToUI);
                //                                = Prot.Dir;
                FOCommon.Utils.SetControl(numSlot, ref Prot.Slot, ToUI);
                FOCommon.Utils.SetControl(numWeight, ref Prot.Weight, ToUI);
                FOCommon.Utils.SetControl(numVolume, ref Prot.Volume, ToUI);
                FOCommon.Utils.SetControl(numCost, ref Prot.Cost, ToUI);
                FOCommon.Utils.SetControl(numStartCount, ref Prot.StartCount, ToUI);
                FOCommon.Utils.SetControl(numSoundId, ref Prot.SoundId, ToUI);
                FOCommon.Utils.SetControl(numLightDistance, ref Prot.LightDistance, ToUI);
                FOCommon.Utils.SetControl(numLightIntensity, ref Prot.LightIntensity, ToUI);
                FOCommon.Utils.SetControl(chkDisableEgg, ref Prot.DisableEgg, ToUI);
                FOCommon.Utils.SetControl(numAnimWaitBase, ref Prot.AnimWaitBase, ToUI);
                FOCommon.Utils.SetControl(numAnimWaitMin, ref Prot.AnimWaitRndMin, ToUI);
                FOCommon.Utils.SetControl(numAnimWaitMax, ref Prot.AnimWaitRndMax, ToUI);
                FOCommon.Utils.SetControl(numAnimStay0, ref Prot.AnimStay_0, ToUI);
                FOCommon.Utils.SetControl(numAnimStay1, ref Prot.AnimStay_1, ToUI);
                FOCommon.Utils.SetControl(numAnimShow0, ref Prot.AnimShow_0, ToUI);
                FOCommon.Utils.SetControl(numAnimShow1, ref Prot.AnimShow_1, ToUI);
                FOCommon.Utils.SetControl(numAnimHide0, ref Prot.AnimHide_0, ToUI);
                FOCommon.Utils.SetControl(numAnimHide1, ref Prot.AnimHide_1, ToUI);
                FOCommon.Utils.SetControl(numDrawOffsetsX, ref Prot.OffsetX, ToUI);
                FOCommon.Utils.SetControl(numDrawOffsetsY, ref Prot.OffsetY, ToUI);
                FOCommon.Utils.SetControl(numDrawOrderOffsetHexY, ref Prot.DrawOrderOffsetHexY, ToUI);
                FOCommon.Utils.SetControl(numRadioChannel, ref Prot.RadioChannel, ToUI);
                FOCommon.Utils.SetControl(numRadioBroadcastSend, ref Prot.RadioBroadcastSend, ToUI);
                FOCommon.Utils.SetControl(numRadioBroadcastReceive, ref Prot.RadioBroadcastRecv, ToUI);
                FOCommon.Utils.SetControl(numIndicatorStart, ref Prot.IndicatorStart, ToUI);
                FOCommon.Utils.SetControl(numIndicatorMax, ref Prot.IndicatorMax, ToUI);
                FOCommon.Utils.SetControl(numHolodiskNum, ref Prot.HolodiskNum, ToUI);
                FOCommon.Utils.SetControl(numStartValue1, ref Prot.StartValue[0], ToUI);
                FOCommon.Utils.SetControl(numStartValue2, ref Prot.StartValue[1], ToUI);
                FOCommon.Utils.SetControl(numStartValue3, ref Prot.StartValue[2], ToUI);
                FOCommon.Utils.SetControl(numStartValue4, ref Prot.StartValue[3], ToUI);
                FOCommon.Utils.SetControl(numStartValue5, ref Prot.StartValue[4], ToUI);
                FOCommon.Utils.SetControl(numStartValue6, ref Prot.StartValue[5], ToUI);
                FOCommon.Utils.SetControl(numStartValue7, ref Prot.StartValue[6], ToUI);
                FOCommon.Utils.SetControl(numStartValue8, ref Prot.StartValue[7], ToUI);
                FOCommon.Utils.SetControl(numStartValue9, ref Prot.StartValue[8], ToUI);
                FOCommon.Utils.SetControl(numStartValue10, ref Prot.StartValue[9], ToUI);
                FOCommon.Utils.SetControl(txtBlockLines, ref Prot.BlockLines, ToUI);
                FOCommon.Utils.SetControl(numChildPid1, ref Prot.ChildPid[0], ToUI);
                FOCommon.Utils.SetControl(numChildPid2, ref Prot.ChildPid[1], ToUI);
                FOCommon.Utils.SetControl(numChildPid3, ref Prot.ChildPid[2], ToUI);
                FOCommon.Utils.SetControl(numChildPid4, ref Prot.ChildPid[3], ToUI);
                FOCommon.Utils.SetControl(numChildPid5, ref Prot.ChildPid[4], ToUI);
                FOCommon.Utils.SetControl(txtChildLines1, ref Prot.ChildLines[0], ToUI);
                FOCommon.Utils.SetControl(txtChildLines2, ref Prot.ChildLines[1], ToUI);
                FOCommon.Utils.SetControl(txtChildLines3, ref Prot.ChildLines[2], ToUI);
                FOCommon.Utils.SetControl(txtChildLines4, ref Prot.ChildLines[3], ToUI);
                FOCommon.Utils.SetControl(txtChildLines5, ref Prot.ChildLines[4], ToUI);
                // Weapon stuff
                FOCommon.Utils.SetControl(chkIsUnarmed, ref Prot.Weapon_IsUnarmed, ToUI);
                FOCommon.Utils.SetControl(numUnarmedTree, ref Prot.Weapon_UnarmedTree, ToUI);
                FOCommon.Utils.SetControl(numUnarmedPriority, ref Prot.Weapon_UnarmedPriority, ToUI);
                FOCommon.Utils.SetControl(numMinAgility, ref Prot.Weapon_UnarmedMinAgility, ToUI);
                FOCommon.Utils.SetControl(numMinUnarmed, ref Prot.Weapon_UnarmedMinUnarmed, ToUI);
                FOCommon.Utils.SetControl(numMinLevel, ref Prot.Weapon_UnarmedMinLevel, ToUI);
                FOCommon.Utils.SetControl(cmbAnim1, ref Prot.Weapon_Anim1, Data.Anim1, ToUI);
                FOCommon.Utils.SetControl(numMaxAmmoCount, ref Prot.Weapon_MaxAmmoCount, ToUI);
                FOCommon.Utils.SetControl(cmbCaliberWeapon, ref Prot.Weapon_Caliber, Data.Calibers, ToUI);
                FOCommon.Utils.SetControl(cmdWeaponDefaultAmmo, ref Prot.Weapon_DefaultAmmoPid, Data.ItemPid, ToUI);
                FOCommon.Utils.SetControl(numMinStrength, ref Prot.Weapon_MinStrength, ToUI);
                FOCommon.Utils.SetControl(cmbWeaponPerk, ref Prot.Weapon_Perk, Data.WeaponPerks, ToUI);
                FOCommon.Utils.SetControl(cmbWeaponSkill1, ref Prot.Weapon_Skill_0, Data.Skills, ToUI);
                FOCommon.Utils.SetControl(cmbWeaponSkill2, ref Prot.Weapon_Skill_1, Data.Skills, ToUI);
                FOCommon.Utils.SetControl(cmbWeaponSkill3, ref Prot.Weapon_Skill_2, Data.Skills, ToUI);
                FOCommon.Utils.SetControl(cmbWeaponAnim2_1, ref Prot.Weapon_Anim2_0, Data.Anim2, ToUI);
                FOCommon.Utils.SetControl(cmbWeaponAnim2_2, ref Prot.Weapon_Anim2_1, Data.Anim2, ToUI);
                FOCommon.Utils.SetControl(cmbWeaponAnim2_3, ref Prot.Weapon_Anim2_2, Data.Anim2, ToUI);
                FOCommon.Utils.SetControl(cmbDmgType1, ref Prot.Weapon_DmgType_0, Data.DamageTypes, ToUI);
                FOCommon.Utils.SetControl(cmbDmgType2, ref Prot.Weapon_DmgType_1, Data.DamageTypes, ToUI);
                FOCommon.Utils.SetControl(cmbDmgType3, ref Prot.Weapon_DmgType_2, Data.DamageTypes, ToUI);
                FOCommon.Utils.SetControl(chkWeaponRemove1, ref Prot.Weapon_Remove_0, ToUI);
                FOCommon.Utils.SetControl(chkWeaponRemove2, ref Prot.Weapon_Remove_1, ToUI);
                FOCommon.Utils.SetControl(chkWeaponRemove3, ref Prot.Weapon_Remove_2, ToUI);
                FOCommon.Utils.SetControl(numWeaponFlyEffect1, ref Prot.Weapon_FlyEffect_0, ToUI);
                FOCommon.Utils.SetControl(numWeaponFlyEffect2, ref Prot.Weapon_FlyEffect_1, ToUI);
                FOCommon.Utils.SetControl(numWeaponFlyEffect3, ref Prot.Weapon_FlyEffect_2, ToUI);
                FOCommon.Utils.SetControl(numWeaponDmgMin1, ref Prot.Weapon_DmgMin_0, ToUI);
                FOCommon.Utils.SetControl(numWeaponDmgMin2, ref Prot.Weapon_DmgMin_1, ToUI);
                FOCommon.Utils.SetControl(numWeaponDmgMin3, ref Prot.Weapon_DmgMin_2, ToUI);
                FOCommon.Utils.SetControl(numWeaponDmgMax1, ref Prot.Weapon_DmgMax_0, ToUI);
                FOCommon.Utils.SetControl(numWeaponDmgMax2, ref Prot.Weapon_DmgMax_1, ToUI);
                FOCommon.Utils.SetControl(numWeaponDmgMax3, ref Prot.Weapon_DmgMax_2, ToUI);
                FOCommon.Utils.SetControl(txtUseGraphics1, ref Prot.Weapon_PicUse_0, ToUI);
                FOCommon.Utils.SetControl(txtUseGraphics2, ref Prot.Weapon_PicUse_1, ToUI);
                FOCommon.Utils.SetControl(txtUseGraphics3, ref Prot.Weapon_PicUse_2, ToUI);
                FOCommon.Utils.SetControl(numDistance1, ref Prot.Weapon_MaxDist_0, ToUI);
                FOCommon.Utils.SetControl(numDistance2, ref Prot.Weapon_MaxDist_1, ToUI);
                FOCommon.Utils.SetControl(numDistance3, ref Prot.Weapon_MaxDist_2, ToUI);
                FOCommon.Utils.SetControl(numBulletsRound1, ref Prot.Weapon_Round_0, ToUI);
                FOCommon.Utils.SetControl(numBulletsRound2, ref Prot.Weapon_Round_1, ToUI);
                FOCommon.Utils.SetControl(numBulletsRound3, ref Prot.Weapon_Round_2, ToUI);
                FOCommon.Utils.SetControl(numAttackAP1, ref Prot.Weapon_ApCost_0, ToUI);
                FOCommon.Utils.SetControl(numAttackAP2, ref Prot.Weapon_ApCost_1, ToUI);
                FOCommon.Utils.SetControl(numAttackAP3, ref Prot.Weapon_ApCost_2, ToUI);
                FOCommon.Utils.SetControl(txtSoundId1, ref Prot.Weapon_SoundId_0, ToUI);
                FOCommon.Utils.SetControl(txtSoundId2, ref Prot.Weapon_SoundId_1, ToUI);
                FOCommon.Utils.SetControl(txtSoundId3, ref Prot.Weapon_SoundId_2, ToUI);
                FOCommon.Utils.SetControl(chkAimAvailable1, ref Prot.Weapon_Aim_0, ToUI);
                FOCommon.Utils.SetControl(chkAimAvailable2, ref Prot.Weapon_Aim_1, ToUI);
                FOCommon.Utils.SetControl(chkAimAvailable3, ref Prot.Weapon_Aim_2, ToUI);
                FOCommon.Utils.SetControl(cmbCaliberAmmo, ref Prot.Ammo_Caliber, Data.Calibers, ToUI);
                FOCommon.Utils.SetControl(numCriticalFailure, ref Prot.Weapon_CriticalFailture, ToUI);
                FOCommon.Utils.SetControl(numAcMod, ref Prot.Ammo_AcMod, ToUI);
                FOCommon.Utils.SetControl(numDrMod, ref Prot.Ammo_DrMod, ToUI);
                FOCommon.Utils.SetControl(numCrTypeMale, ref Prot.Armor_CrTypeMale, ToUI);
                FOCommon.Utils.SetControl(numCrTypeFemale, ref Prot.Armor_CrTypeFemale, ToUI);

                // Misc
                FOCommon.Utils.SetControl(chkDoorNoBlockLight, ref Prot.Door_NoBlockLight, ToUI);
                FOCommon.Utils.SetControl(chkDoorNoBlockShoot, ref Prot.Door_NoBlockShoot, ToUI);
                FOCommon.Utils.SetControl(chkDoorNoBlockMove, ref Prot.Door_NoBlockMove, ToUI);
                FOCommon.Utils.SetControl(numContainerVolume, ref Prot.Container_Volume, ToUI);
                FOCommon.Utils.SetControl(chkContainerChangable, ref Prot.Container_Changeble, ToUI);
                FOCommon.Utils.SetControl(chkContainerCannotPickup, ref Prot.Container_CannotPickUp, ToUI);
                FOCommon.Utils.SetControl(chkContainerMagicHandsGrnd, ref Prot.Container_MagicHandsGrnd, ToUI);

                FOCommon.Utils.SetControl(numCarSpeed, ref Prot.Car_Speed, ToUI);
                FOCommon.Utils.SetControl(numCarPassability, ref Prot.Car_Passability, ToUI);
                FOCommon.Utils.SetControl(numCarDeteriorationRate, ref Prot.Car_DeteriorationRate, ToUI);
                FOCommon.Utils.SetControl(numCarCritterCapacity, ref Prot.Car_CrittersCapacity, ToUI);
                FOCommon.Utils.SetControl(numCarTankVolume, ref Prot.Car_TankVolume, ToUI);
                FOCommon.Utils.SetControl(numCarMaxDeterioration, ref Prot.Car_MaxDeterioration, ToUI);
                FOCommon.Utils.SetControl(numCarFuelConsumption, ref Prot.Car_FuelConsumption, ToUI);
                FOCommon.Utils.SetControl(numCarEntrance, ref Prot.Car_Entrance, ToUI);

                // Parse flags
                FOCommon.Utils.SetControlFlag(chkColorFlagColorize, ref Prot.Flags, (uint)Data.Defines["ITEM_FLAG_COLORIZE"], ToUI);
                FOCommon.Utils.SetControlFlag(chkColorFlagColorizeInventory, ref Prot.Flags, (uint)Data.Defines["ITEM_FLAG_COLORIZE_INV"], ToUI);
                FOCommon.Utils.SetControlFlag(chkRadioEnabled, ref Prot.Flags, (uint)Data.Defines["ITEM_FLAG_RADIO"], ToUI);

                FOCommon.Utils.SetControlFlag(chkHolodiskEnabled, ref Prot.Flags, (uint)Data.Defines["ITEM_FLAG_HOLODISK"], ToUI);
                FOCommon.Utils.SetControlFlag(chkLight, ref Prot.Flags, (uint)Data.Defines["ITEM_FLAG_LIGHT"], ToUI);
                FOCommon.Utils.SetControlFlag(chkShowAnim, ref Prot.Flags, (uint)Data.Defines["ITEM_FLAG_SHOW_ANIM"], ToUI);
                FOCommon.Utils.SetControlFlag(chkShowAnimExt, ref Prot.Flags, (uint)Data.Defines["ITEM_FLAG_SHOW_ANIM_EXT"], ToUI);

                FOCommon.Utils.SetControlFlag(chkLightFlagDisableDir0, ref Prot.LightFlags, (uint)LIGHT_DISABLE_DIR(0), ToUI);
                FOCommon.Utils.SetControlFlag(chkLightFlagDisableDir1, ref Prot.LightFlags, (uint)LIGHT_DISABLE_DIR(1), ToUI);
                FOCommon.Utils.SetControlFlag(chkLightFlagDisableDir2, ref Prot.LightFlags, (uint)LIGHT_DISABLE_DIR(2), ToUI);
                FOCommon.Utils.SetControlFlag(chkLightFlagDisableDir3, ref Prot.LightFlags, (uint)LIGHT_DISABLE_DIR(3), ToUI);
                FOCommon.Utils.SetControlFlag(chkLightFlagDisableDir4, ref Prot.LightFlags, (uint)LIGHT_DISABLE_DIR(4), ToUI);
                FOCommon.Utils.SetControlFlag(chkLightFlagDisableDir5, ref Prot.LightFlags, (uint)LIGHT_DISABLE_DIR(5), ToUI);
                FOCommon.Utils.SetControlFlag(chkLightFlagGlobal, ref Prot.LightFlags, LIGHT_GLOBAL, ToUI);
                FOCommon.Utils.SetControlFlag(chkLightFlagInverse, ref Prot.LightFlags, LIGHT_INVERSE, ToUI);
                FOCommon.Utils.SetControlFlag(chkRadioFlagDisableSend, ref Prot.RadioFlags, (uint)Data.Defines["RADIO_DISABLE_SEND"], ToUI);
                FOCommon.Utils.SetControlFlag(chkRadioFlagDisableRecv, ref Prot.RadioFlags, (uint)Data.Defines["RADIO_DISABLE_RECV"], ToUI);
                FOCommon.Utils.SetControlFlag(chkRadioFlagDisableShiftRecv, ref Prot.RadioFlags, (uint)Data.Defines["RADIO_DISABLE_SHIFT_RECV"], ToUI);
                FOCommon.Utils.SetControlFlag(chkRadioFlagDisableShiftSend, ref Prot.RadioFlags, (uint)Data.Defines["RADIO_DISABLE_SHIFT_SEND"], ToUI);
                FOCommon.Utils.SetControlFlag(chkRadioFlagDisableShiftBCSend, ref Prot.RadioFlags, (uint)Data.Defines["RADIO_DISABLE_SHIFT_BC_SEND"], ToUI);
                FOCommon.Utils.SetControlFlag(chkRadioFlagDisableShiftBCRecv, ref Prot.RadioFlags, (uint)Data.Defines["RADIO_DISABLE_SHIFT_BC_RECV"], ToUI);
                FOCommon.Utils.SetControlFlag(chkRadioFlagDisableShiftChannel, ref Prot.RadioFlags, (uint)Data.Defines["RADIO_DISABLE_SHIFT_CHANNEL"], ToUI);

                FOCommon.Utils.SetControl(grpCarMovementType, ref Prot.Car_MovementType, ToUI);
                FOCommon.Utils.SetControl(grpExtInfoMaterial, ref Prot.Material, ToUI);
                FOCommon.Utils.SetControl(grpExtInfoCorner, ref Prot.Corner, ToUI);
                FOCommon.Utils.SetControl(grpSpriteCutting, ref Prot.SpriteCut, ToUI);
                FOCommon.Utils.SetControl(grpGridType, ref Prot.Grid_Type, ToUI);

                // Multiline textbox
                if (ToUI)
                    txtDescription.Text = txtDescription.Text.Replace("\n", "\r\n");
                else
                    txtDescription.Text = txtDescription.Text.Replace("\r\n", "\n");
            }
            catch (ArgumentOutOfRangeException Arg)
            {
                Utils.Log(Prot.Name+"["+Prot.ProtoId+"]: "+ Arg.Message + "::" + Arg.Source);
            }
#endregion

            // Custom flags from Flags.cfg
            foreach (CheckBox chkBox in grpExtInfoFlags.Controls)
            {
                string Define = (String)chkBox.Tag;
                FOCommon.Utils.SetControlFlag(chkBox, ref Prot.Flags, (uint)Data.Defines[Define], ToUI);
            }

            // For Custom.cfg stuff
            SetCustomData(ref Prot, ToUI);

            // Stuff that needs some special handling
            if (ToUI)
            {
                numColorAlpha.Value = (Prot.LightColor >> 24) & 0xFF;
                numColorRed.Value = (Prot.LightColor >> 16) & 0xFF;
                numColorGreen.Value = (Prot.LightColor >> 8) & 0xFF;
                numColorBlue.Value = (Prot.LightColor) & 0xFF;
                chkActive1.Checked = false;
                chkActive2.Checked = false;
                chkActive3.Checked = false;
                for (uint i = 0; i <= Prot.Weapon_ActiveUses; i++)
                {
                    if (i == 1) chkActive1.Checked = true;
                    if (i == 2) chkActive2.Checked = true;
                    if (i == 3) chkActive3.Checked = true;
                }
            }
            else
            {
                uint ActiveCount = 0;
                if (chkActive1.Checked) ActiveCount++;
                if (chkActive2.Checked) ActiveCount++;
                if (chkActive3.Checked) ActiveCount++;
                Prot.Weapon_ActiveUses = ActiveCount;
                Prot.LightColor = ((Int32)numColorAlpha.Value << 24) | ((Int32)numColorRed.Value << 16) | ((Int32)numColorGreen.Value << 8) | ((Int32)numColorBlue.Value);
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm.ShowDialog();
            if (FOObj.GetFilename() != Config.PathObjMsg)
            {
                InitFOObj();
                foreach (ItemProto Prot in LoadedProtos)
                {
                    Prot.Name = FOObj.GetMSGValue(Prot.ProtoId * 100);
                    Prot.Description = FOObj.GetMSGValue(Prot.ProtoId * 100 + 1);
                }
            }
            if (Config.TranslateLanguage)
            {
                Translate.LoadLanguage(Config.PathLanguage);
                Translate.TranslateForm(this);
            }
            lstProtos.Refresh();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit();
        }

        private void panelProperties_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (CurrentProto == null) return;
            TabPage Tab=GetTabPageByItemType(CurrentProto.Type);
            if(Tab==null) return;
            if (Tab != e.TabPage)
                e.Cancel = Config.LockTabs;
            else
                WinAPI.SetWindowExFlag(MainObj.Handle, (int)Win32.WS_EX_COMPOSITED);
        }

        private void chkIsUnarmed_CheckedChanged(object sender, EventArgs e)
        {
            grpUnarmed.Visible = chkIsUnarmed.Checked;
        }

        private void aboutObjectEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout AboutForm = new frmAbout(GetAbout());
            AboutForm.ShowDialog();
        }

        private void unloadAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadedFilenames.Count == 0 && LoadedProtos.Count == 0)
                return;
            
            if (DialogResult.No == Message.Show("Are you sure that you want to unload all loaded items?"+Environment.NewLine+"Any pending changes will be lost.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                return;
            
            lstProtos.ClearObjects();
            LoadedProtos.Clear();
            LoadedFilenames.Clear();
            CurrentProto = null;
            SetProtoGUI(new ItemProto(), true);
            changeStatus("Unloaded all items.");
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox Chk = (CheckBox)sender;
            TabPage Page = null;
            if (Chk == chkActive1) Page = WeaponAttack1;
            if (Chk == chkActive2) Page = WeaponAttack2;
            if (Chk == chkActive3) Page = WeaponAttack3;

            foreach (Control Ctrl in Page.Controls)
            {
                if (Ctrl == sender)
                    continue;
                
                Ctrl.Visible = Chk.Checked;
            }
        }

        private bool TextInProto(ItemProto proto, string Text)
        {
            Text = Text.ToLower();

            if (olvName.IsVisible && proto.Name.ToLower().Contains(Text))
                return true;
            if (olvPID.IsVisible && proto.ProtoId.ToString().ToLower().Contains(Text))
                return true;
            if (olvScript.IsVisible && proto.ScriptModule!= null && proto.ScriptModule.ToLower().Contains(Text))
                return true;
            if (olvScriptFunc.IsVisible && proto.ScriptFunction != null && proto.ScriptFunction.ToLower().Contains(Text))
                return true;

            return false;
        }

        private void ApplyFilter()
        {
            SortOrder so = lstProtos.Sorting;
            if (!chkFilter.Checked)
            {
                lstProtos.ModelFilter = null;
                return;
            }
            else
            {
                this.lstProtos.ModelFilter = new ModelFilter(delegate(object x)
                {
                    ItemProto Prot = (ItemProto)x;
                    if (FilterFlags != 0)
                    {
                        foreach (KeyValuePair<string, string> kvp in CustomInterface.CustomFlags)
                        {
                            uint Flag = (uint)Data.Defines[kvp.Value];
                            if (FOCommon.Utils.IsFlagSet(FilterFlags, Flag) && !FOCommon.Utils.IsFlagSet(Prot.Flags, Flag))
                                return false;
                        }
                    }
                    if (!IsFilterTypeChecked(FOCommon.Utils.GetKeyByValue(Data.ItemTypes, Prot.Type)))
                        return false;

                    if (txtSearch.Text != "")
                        return TextInProto(Prot, txtSearch.Text);

                    return true;
                });
            }
            lstProtos.Sorting = so;
        }

        private void btnSetFilter_Click(object sender, EventArgs e)
        {
            FilterForm.ShowDialog();
            FilterFlags = FilterForm.GetFlags();
            ApplyFilter();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemProto NewProt = new ItemProto();
            NewProt.New = true;
            LoadedProtos.Add(NewProt);
            lstProtos.AddObject(NewProt);
            SetNewProto(NewProt);
        }

        private void numPID_ValueChanged(object sender, EventArgs e)
        {
            if (CurrentProto == null) return;
            CurrentProto.ProtoId = (ushort)numPID.Value;
            lstProtos.RefreshObject(CurrentProto);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (CurrentProto == null) return;
            CurrentProto.Name = txtName.Text;
            lstProtos.RefreshObject(CurrentProto);
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentProto == null) return;
            if (cmbType.Text=="") return;
            CurrentProto.Type = Data.ItemTypes[cmbType.Text];
            lstProtos.RefreshObject(CurrentProto);
            if (Config.SwitchTab)
            {
                panelProperties.SelectedTab = GetTabPageByItemType(CurrentProto.Type);
                lstProtos.Focus();
            }
        }

        private void removeSelectedObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList Arr = (ArrayList)lstProtos.SelectedObjects;
            List<ItemProto> Prots = new List<ItemProto>((ItemProto[])Arr.ToArray(typeof(ItemProto)));
            foreach (ItemProto Prot in Prots)
            {
                if (CurrentProto!=null && CurrentProto.ProtoId == Prot.ProtoId)
                {
                    CurrentProto = null;
                    SetProtoGUI(new ItemProto(), true);
                }
                LoadedProtos.Remove(Prot);
            }
            lstProtos.SetObjects(LoadedProtos);
            lstProtos.SelectedObjects = null;
        }

        private void SaveProtos(List<ItemProto> Protos)
        {
            if (CurrentProto != null)
                SetProtoGUI(CurrentProto, false);
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.OverwritePrompt = true;
            SaveFile.RestoreDirectory = true;
            SaveFile.Filter = "Protofile (*.fopro)|*.fopro";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                ItemProtoParser ProtoParser = new ItemProtoParser();
                ProtoParser.SaveProtosToFile(SaveFile.FileName, Utils.GetVersion(), FOObj, Protos, CustomInterface.CustomFields, Config.FormatWithSpace);
            }

            changeStatus("Saved protos.");
        }

        private void chkFilter_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void saveListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadedProtos.Count>0)
                SaveProtos(LoadedProtos);
            else
                Message.Show("No items loaded.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void saveSingleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList Arr = (ArrayList)lstProtos.SelectedObjects;
            List<ItemProto> Prots = new List<ItemProto>((ItemProto[])Arr.ToArray(typeof(ItemProto)));
            if (Prots.Count > 0)
                SaveProtos(Prots);
            else
                Message.Show("No items selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void saveFilteredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<ItemProto> Prots = new List<ItemProto>();
            foreach (ItemProto Prot in lstProtos.FilteredObjects) Prots.Add(Prot);
            if (Prots.Count > 0)
                SaveProtos(Prots);
            else
                Message.Show("No items in filtered list.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void saveListToRespectiveFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<String, List<ItemProto>> FileProtoList = new Dictionary<string, List<ItemProto>>();
            List<ItemProto> Prots = new List<ItemProto>();
            foreach (ItemProto Prot in lstProtos.FilteredObjects) Prots.Add(Prot);
            if (Prots.Count > 0)
            {
                foreach (ItemProto Prot in lstProtos.FilteredObjects)
                {
                    if (String.IsNullOrEmpty(Prot.FileName))
                    {
                        Message.Show("Item " + Prot.Name + " [" + Prot.ProtoId + "] has no filename assigned, and therefore can't be saved.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    if (FileProtoList.ContainsKey(Prot.FileName))
                        FileProtoList[Prot.FileName].Add(Prot);
                    else
                    {
                        FileProtoList[Prot.FileName] = new List<ItemProto>();
                        FileProtoList[Prot.FileName].Add(Prot);
                    }
                }
                foreach(KeyValuePair<String, List<ItemProto>> kvp in FileProtoList)
                {
                    ItemProtoParser ProtoParser = new ItemProtoParser();
                    if (CurrentProto != null)
                        SetProtoGUI(CurrentProto, false);
                    ProtoParser.SaveProtosToFile(kvp.Key, Utils.GetVersion(), FOObj, kvp.Value, CustomInterface.CustomFields, Config.FormatWithSpace);
                }
            }
            else
                Message.Show("No items in filtered list.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void panelMain_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                WinAPI.UnsetWindowExFlag(MainObj.Handle, (int)Win32.WS_EX_COMPOSITED);
            }
            else
            {
                WinAPI.SetWindowExFlag(MainObj.Handle, (int)Win32.WS_EX_COMPOSITED);
            }
        }

        private void frmMain_ResizeBegin(object sender, EventArgs e)
        {
            if (!Config.ResizeOnResize)
            {
                SuspendLayout();
            }
        }

        private void frmMain_ResizeEnd(object sender, EventArgs e)
        {
            if (!Config.ResizeOnResize)
            {
                ResumeLayout();
            }
        }

        private void chklstTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        // TODO: Move to script library
        private void UpdateScripts_Tick()
        {
            bool Close = true;
            foreach (ScriptHost.ScriptExtension Ext in Scripting.Host.ScriptHost.GetLoadedExtensions())
            {
                if (Ext.UpdateTime != 0)
                    Close = false;
            }

            while (!Close)
            {
                foreach (ScriptHost.ScriptExtension Ext in Scripting.Host.ScriptHost.GetLoadedExtensions())
                {
                    if (Ext.UpdateTime == 0)
                        continue;

                    long delta = Environment.TickCount - Ext.UpdateTimeCount;

                    if (delta >= Ext.UpdateTime)
                    {
                        Ext.UpdateTimeCount = Environment.TickCount;
                        this.Invoke((MethodInvoker)delegate { Scripting.Host.ScriptHost.update(Ext); });
                    }

                }
                Thread.Sleep(1);
            }
        }


        private void Search()
        {
            chkFilter.Checked = true;
            ApplyFilter();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Search();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private bool isProtoIdLoaded(int id)
        {
            foreach(ItemProto prot in LoadedProtos)
            if (prot.ProtoId == id)
                return true;
            return false;
        }

        private void cloneSelectedObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList Arr = (ArrayList)lstProtos.SelectedObjects;
            List<ItemProto> Prots = new List<ItemProto>((ItemProto[])Arr.ToArray(typeof(ItemProto)));
            if (Prots.Count > 1)
            {
                Message.Show("Can't clone multiple objects at the same time, select one proto and try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                changeStatus("Unable to clone multiple object(s)");
            }
            else if (Prots.Count == 0)
            {
                Message.Show("No proto selected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ushort suggestedPid = 0;
                for (int i = Prots[0].ProtoId; i < ushort.MaxValue; i++)
                {
                    if (Data.ItemPid.ContainsValue(i))
                        continue;
                    if (isProtoIdLoaded(i))
                        continue;
                    suggestedPid = (ushort)i;
                    break;
                }

                frmClone frmClone = new frmClone(Prots[0], suggestedPid);
                frmClone.ShowDialog();
                if (!frmClone.clickedOk)
                    return;

                if (isProtoIdLoaded(frmClone.protoId))
                {
                    Message.Show("A proto with that id is already loaded!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ItemProto newProto = DeepCopier.DeepCopy(Prots[0]);
                newProto.ProtoId = frmClone.protoId;
                LoadedProtos.Add(newProto);
                lstProtos.AddObject(newProto);
                lstProtos.SelectedObject = newProto;
                lstProtos.EnsureModelVisible(newProto);
                SetNewProto(newProto);
                changeStatus(string.Format("Cloned {0} ({1}) into a new object with PID {2}", Prots[0].Name, Prots[0].ProtoId, frmClone.protoId));
            }
        }

        private void waitGallery()
        {
            while (gallery == null)
            {
                Thread.Sleep(1);
            } 
        }

        private void selectImage(TextBox target)
        {
            waitGallery();
            gallery.Visible = false;
            gallery.ShowDialog();
            if (gallery.getSelected() != null)
                target.Text = gallery.getSelected().Tag.ToString();
        }

        private void btnSelectGround_Click(object sender, EventArgs e)
        {
            selectImage(txtGroundPic);
        }

        private void btnSelectInventory_Click(object sender, EventArgs e)
        {
            selectImage(txtInvPic);
        }

        private void backgroundResources_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (Config.LoadGraphics)
            {
                string[] paths = Config.PathGraphics.Split(";".ToCharArray());

                foreach (string path in paths)
                {
                    if (String.IsNullOrEmpty(path))
                        continue;

                    string ext = Path.GetExtension(path).ToLower();
                    if (ext == ".zip")
                        Data.LoadZip(path, Color.FromArgb(11, 0, 11));
                    else if (ext == ".dat")
                        Data.LoadDat(path, Color.FromArgb(11, 0, 11));
                    else
                        Message.Show("Can't process '" + path + "', only .dat or .zip supported.");
                }
            }
        }

        private void backgroundResources_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            gallery = new frmFrmGallery();
            gallery.prepareGraphics();
            btnSelectGround.Enabled = true;
            btnSelectInventory.Enabled = true;
        }

        private void txtGroundPic_TextChanged(object sender, EventArgs e)
        {
            if (Data.Graphics.ContainsKey(txtGroundPic.Text.ToLower()))
            {
                Bitmap bmp = Data.Graphics[txtGroundPic.Text.ToLower()];
                pctGround.Image = bmp;
            }
            else
                pctGround.Image = null;
        }

        private void txtInvPic_TextChanged(object sender, EventArgs e)
        {
            if (Data.Graphics.ContainsKey(txtInvPic.Text.ToLower()))
            {
                Bitmap bmp = Data.Graphics[txtInvPic.Text.ToLower()];
                pctInventory.Image = bmp;
            }
            else
                pctInventory.Image = null;
        }
    }
}

