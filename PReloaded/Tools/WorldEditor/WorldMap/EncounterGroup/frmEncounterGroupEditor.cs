using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Linq;

using WorldEditor.ProtoEditor;

using FOCommon;
using FOCommon.Items;
using FOCommon.Parsers;
using FOCommon.Dialog;
using FOCommon.Critter;

using FOCommon.Worldmap.EncounterGroup;

namespace WorldEditor.NZone.EncounterGroup
{
    public partial class frmEncounterGroupEditor : Form
    {
        bool IsFirstPaint = true;

        public List<IZone> Zones;
        public Dictionary<string, int> GroupDefines;
        List<FOCommon.Worldmap.EncounterGroup.EncounterGroup> Groups = new List<FOCommon.Worldmap.EncounterGroup.EncounterGroup>();
        List<string> FOGMNames = new List<string>();
        Dictionary<int, string> ProtoNames = new Dictionary<int, string>();
        List<Faction> Factions = new List<Faction>();
        List<CritterProto> CrProtos = new List<CritterProto>();
        List<ArmorProto> ArmorProtos = new List<ArmorProto>();
        List<ArmorProto> HelmetProtos = new List<ArmorProto>();
        Dictionary<string, int> CrTypeDefines = new Dictionary<string, int>();
        frmFilter frmFilter;

        MSGParser FODLG;
        FOGAMEParser GameParser;
        EncounterGroupParser GroupParser;

        DefineParser DefineParser;

        DialogListParser DialogParser;

        FOCommon.Worldmap.EncounterGroup.EncounterGroup CurrentGroup;
        EncounterNpc CurrentNpc;
        EncounterItem CurrentItem;

        private void AddArmorProtoToCmb(ArmorProto ItProt, ComboBox Cmb)
        {
            Cmb.Items.Add(ItProt.Name + " [" + (!String.IsNullOrEmpty(ItemPid.GetDefineName(ItProt.ProtoId)) ? ItemPid.GetDefineName(ItProt.ProtoId) : ItProt.ProtoId.ToString()) + "]");
        }

        public frmEncounterGroupEditor(List<IZone> Zones, FOGAMEParser GameParser, EncounterGroupParser GroupParser, DialogListParser DialogParser, MSGParser FOObj, MSGParser FODLG, DefineParser DefineParser)
        {
            this.Zones = Zones;
            this.FODLG = FODLG;
            this.DefineParser = DefineParser;
            this.GameParser = GameParser;
            this.GroupParser = GroupParser;
            this.DialogParser = DialogParser;
            InitializeComponent();
            LoadCrTypeDefines();
            LoadArmorProtos(Config.PathArmorProtos, Config.PathHelmetProtos, FOObj);

            foreach (ArmorProto ItProt in ArmorProtos)
                AddArmorProtoToCmb(ItProt, cmbArmorPid);
            foreach (ArmorProto ItProt in HelmetProtos)
                AddArmorProtoToCmb(ItProt, cmbHelmetPid);

            cmbArmorPid.SelectedIndex = 0;
            cmbHelmetPid.SelectedIndex = 0;

            this.frmFilter = new frmFilter(this.DefineParser, null);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CurrentNpc != null)
                SaveCurrentNpc();
            if (CurrentItem != null)
                SaveCurrentItem();

            SaveCurrentGroup();

            TableSerializer.Save("lstGroups", lstGroups.SaveState());
            TableSerializer.Save("lstNpcs", lstNpcs.SaveState());
            TableSerializer.Save("lstNpcItems", lstNpcItems.SaveState());
            TableSerializer.Save("lstPerks", lstPerks.SaveState());

            if (this.GroupParser.Save(Groups, Config.PathGroups, Config.PathWorldmapHeader))
            {
                //this.Close();
                Message.Show("Groups saved successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                Message.Show("Groups failed to save.", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void AddCrTypeToCmb(ComboBox Cmb, uint CrType)
        {
            if (CrType == 0)
                return;

            Cmb.Items.Add(GetCrTypeDefineByPid((int)CrType) + " [" + CrType + "]");
        }

        private void cmbArmorPid_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbForcedCrType.Enabled = (cmbArmorPid.Text != "Proto Default");
            if (!cmbForcedCrType.Enabled)
                return;

            cmbForcedCrType.Items.Clear();

            if(CurrentNpc==null) 
                return;

            ProtoCritter CrProt = ProtoManager.Protos[CurrentNpc.Proto.Id];
            if (CrProt == null)
            {
                Message.Show("Proto for critter not loaded, unable to gain gender information.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbArmorPid.Text == "None")
            {
                if (CrProt.Params[Consts.ST_GENDER] == 1) // female
                {
                    cmbForcedCrType.Items.Add(GetCrTypeDefineByPid(61) + " [61]");
                    cmbForcedCrType.Items.Add(GetCrTypeDefineByPid(63) + " [63]");
                }
                else
                {
                    cmbForcedCrType.Items.Add(GetCrTypeDefineByPid(62) + " [62]");
                    cmbForcedCrType.Items.Add(GetCrTypeDefineByPid(64) + " [64]");
                }
                if (CurrentNpc.ForcedCrType == -1 || CurrentNpc.ForcedCrType == 0)
                    cmbForcedCrType.SelectedIndex = 0;
            }
            else
            {
                if (cmbArmorPid.SelectedIndex < 2)
                    return;

                ArmorProto ItProt = (ArmorProto)ArmorProtos[cmbArmorPid.SelectedIndex - 2];
                if (CrProt.Params[Consts.ST_GENDER] == 1)
                {
                    AddCrTypeToCmb(cmbForcedCrType, ItProt.Armor_CrTypeFemale);
                    AddCrTypeToCmb(cmbForcedCrType, ItProt.Armor_CrTypeFemale2);
                    AddCrTypeToCmb(cmbForcedCrType, ItProt.Armor_CrTypeFemale3);
                    AddCrTypeToCmb(cmbForcedCrType, ItProt.Armor_CrTypeFemale4);
                }
                else
                {
                    AddCrTypeToCmb(cmbForcedCrType, ItProt.Armor_CrTypeMale);
                    AddCrTypeToCmb(cmbForcedCrType, ItProt.Armor_CrTypeMale2);
                    AddCrTypeToCmb(cmbForcedCrType, ItProt.Armor_CrTypeMale3);
                    AddCrTypeToCmb(cmbForcedCrType, ItProt.Armor_CrTypeMale4);
                }

                if (CurrentNpc.ForcedCrType == -1 || CurrentNpc.ForcedCrType == 0)
                    cmbForcedCrType.SelectedIndex = 0;
            }

        }

        private string GetCrTypeDefineByPid(int pid)
        {
            foreach (KeyValuePair<String, int> kvp in CrTypeDefines)
            {
                if (kvp.Value == pid)
                    return kvp.Key;
            }
            return "";
        }

        private void LoadCrTypeDefines()
        {
            if (!File.Exists(Config.PathScriptsDir + "_basetypes.fos"))
                return;

            DefineParser CrTypeParser = new DefineParser();
            if (!CrTypeParser.ReadDefines(Config.PathScriptsDir + "_basetypes.fos"))
                Utils.HandleParseError(CrTypeParser.Error, Config.PathScriptsDir + "_basetypes.fos");
            CrTypeDefines = CrTypeParser.Defines;
        }

        private bool LoadArmorProtos(string ArmorPath, string HelmetPath, MSGParser FOObj)
        {
            FOCommon.Parsers.SimpleItemProtoParser ItemParser = new FOCommon.Parsers.SimpleItemProtoParser(new ArmorProto());
            bool DuplicatesFound=false;

            ArmorProtos = ItemParser.LoadProtosFromFile(ArmorPath, FOObj, out DuplicatesFound).Cast<ArmorProto>().ToList();
            ItemParser = new FOCommon.Parsers.SimpleItemProtoParser(new ArmorProto());
            HelmetProtos = ItemParser.LoadProtosFromFile(HelmetPath, FOObj, out DuplicatesFound).Cast<ArmorProto>().ToList();
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateGroupZoneStats(FOCommon.Worldmap.EncounterGroup.EncounterGroup Grp)
        {
            ZoneStatistics Zt = new ZoneStatistics(Grp);
            Zt.CalculateZoneStatistics(Zones);
            Grp.ZoneCount = Zt.ZoneCount;
            Grp.ZoneAvg = Zt.ZoneDiffAvg;
            Grp.ZoneMax = Zt.ZoneDiffMax;
            Grp.ZoneMed = Zt.ZoneDiffMed;
            Grp.ZoneMin = Zt.ZoneDiffMin;
        }

        private void frmEncounterGroupEditor_Paint(object sender, PaintEventArgs e)
        {
            if (IsFirstPaint)
            {
                cmbGroupPosition.SelectedIndex = 0;
                numDialog.Maximum = Int32.MaxValue;
                numProto.Maximum = Int32.MaxValue;
                Groups = GroupParser.GetGroups();

                foreach (FOCommon.Worldmap.EncounterGroup.EncounterGroup Grp in Groups)
                    CalculateGroupZoneStats(Grp);

                List<Item> items = ItemPid.GetItems();

                foreach(Item item in items)
                    cmbItemPid.Items.Add(item.Define);
                cmbItemPid.Sorted = true;


                if (TableSerializer.Exists("lstGroups"))
                    lstGroups.RestoreState(TableSerializer.Load("lstGroups"));
                if (TableSerializer.Exists("lstNpcs"))
                    lstNpcs.RestoreState(TableSerializer.Load("lstNpcs"));
                if (TableSerializer.Exists("lstNpcItems"))
                    lstNpcItems.RestoreState(TableSerializer.Load("lstNpcItems"));
                
                Factions = GameParser.GetFactions();

                ProtoNames = FODLG.GetData();

                foreach(KeyValuePair<int, string> kvp in ProtoNames)
                {
                    if (kvp.Key%2==1)
                        continue;
                    CritterProto CrP = new CritterProto((kvp.Key / 10));
                    CrP.Name = kvp.Value;
                    CrProtos.Add(CrP);
                }
                foreach (FOCommon.Worldmap.EncounterGroup.EncounterGroup grp in Groups)
                    foreach (Faction f in Factions)
                        if (grp.FactionId == f.Id)
                            grp.FactionName = f.Name;


                lstGroups.SetObjects(Groups);

                cmbPerkDefine.Items.AddRange(DefineParser.GetDefinesByPrefix("PE_").Keys.ToArray<String>());

                IsFirstPaint = false;
            }
        }

        private void SaveCurrentGroup()
        {
            if (CurrentGroup == null)
                return;

            CurrentGroup.Id = (int) numGroupId.Value;
            CurrentGroup.Spacing = Decimal.ToInt32(numSpacing.Value);
            CurrentGroup.RatioMin = Decimal.ToInt32(numRatioMin.Value);
            CurrentGroup.RatioMax = Decimal.ToInt32(numRatioMax.Value);
            CurrentGroup.DistMin = Decimal.ToInt32(numDistMin.Value);
            CurrentGroup.DistMax = Decimal.ToInt32(numDistMax.Value);
            CurrentGroup.FactionId = Decimal.ToInt32(numFactionId.Value);
            CurrentGroup.FactionMode = cmbFactionMode.SelectedIndex;
            CurrentGroup.Position = cmbGroupPosition.SelectedIndex+1;
            CurrentGroup.GMName = txtGMName.Text;
            CurrentGroup.QuantityDay = (float)Decimal.ToDouble(numQuantityDay.Value);
            CurrentGroup.QuantityNight = (float)Decimal.ToDouble(numQuantityNight.Value);
        }

        private void SaveCurrentNpc()
        {
            CurrentNpc.Dialog.Id = Decimal.ToInt32(numDialog.Value);
            CurrentNpc.Dead = chkDead.Checked;
            CurrentNpc.Proto.Id = Decimal.ToInt32(numProto.Value);
            CurrentNpc.Script = cmbScript.Text;
            CurrentNpc.Ratio = Decimal.ToInt32(numNpcRatio.Value);
            CurrentNpc.ArmorPid = GetArmorPid();
            CurrentNpc.HelmPid = GetHelmPid();
            CurrentNpc.ForcedCrType = GetForcedCrType();
        }

        private void SaveCurrentItem()
        {
            CurrentItem.Item = ItemPid.GetItemByDefine(cmbItemPid.SelectedItem.ToString());
            CurrentItem.Slot = (SlotEnum)cmbSlot.SelectedIndex;
            CurrentItem.Min = Decimal.ToInt32(numItemMin.Value);
            CurrentItem.Max = Decimal.ToInt32(numItemMax.Value);
        }

        private void RefreshNpcList()
        {
            if (CurrentGroup == null)
                return;

            foreach (EncounterNpc npc in CurrentGroup.Npcs)
            {
                if(npc.Proto.Id!=0)
                    npc.Proto.Name= ProtoNames[npc.Proto.Id * 10];
                if (npc.Dialog.Id != 0)
                    npc.Dialog.Name = DialogParser.GetNameById(npc.Dialog.Id);
            }

            if (CurrentGroup.Npcs.Count == 1)
                lstNpcs.SetObjects(null);
            lstNpcs.SetObjects(CurrentGroup.Npcs);
            lstNpcs.SelectedObject = CurrentNpc;
        }

        private void RefreshGroupList()
        {
            foreach(FOCommon.Worldmap.EncounterGroup.EncounterGroup grp in Groups)
                foreach (Faction f in Factions)
                    if (grp.FactionId == f.Id)
                        grp.FactionName = f.Name;


            if (frmFilter.Filter.Enabled)
            {
                List<FOCommon.Worldmap.EncounterGroup.EncounterGroup> FilteredGroupList = new List<FOCommon.Worldmap.EncounterGroup.EncounterGroup>();
                foreach (FOCommon.Worldmap.EncounterGroup.EncounterGroup grp in Groups)
                {
                    bool FoundNpc = false;
                    bool FoundItem = false;
                    bool FoundPerk = false;
                    
                        foreach (EncounterNpc npc in grp.Npcs)
                        {
                            if (npc.Proto.Id == frmFilter.Filter.NpcPid)
                                FoundNpc = true;
                            if(frmFilter.Filter.EnabledItem)
                                foreach (EncounterItem item in npc.Items)
                                {
                                    if (item.Item.Pid == frmFilter.Filter.ItemPid)
                                        FoundItem = true;
                                }
                            if(frmFilter.Filter.EnabledPerk)
                                foreach (EncounterPerk perk in npc.Perks)
                                {
                                    if (perk.Index == frmFilter.Filter.PerkIndex)
                                        FoundPerk = true;
                                }
                        }
                        if (frmFilter.Filter.EnabledItem && !FoundItem)
                            continue;
                        if (frmFilter.Filter.EnabledNpc && !FoundNpc)
                            continue;
                        if (frmFilter.Filter.EnabledPerk && !FoundPerk)
                            continue;

                        FilteredGroupList.Add(grp);

                }
                lstGroups.SetObjects(FilteredGroupList);
            }
            else
                lstGroups.SetObjects(Groups);
        }

        private void RefreshCurrentGroup()
        {
            if (CurrentGroup.FactionId < 2)
                CurrentGroup.FactionName = "";
            else
            {
                foreach (Faction f in Factions)
                    if (CurrentGroup.FactionId == f.Id)
                        CurrentGroup.FactionName = f.Name;
            }
            lstGroups.RefreshObject(CurrentGroup);
            lstGroups.SelectedObject = CurrentGroup;
        }

        private void RefreshArmor()
        {
            if(CurrentNpc.ArmorPid<1)
                cmbArmorPid.SelectedIndex = CurrentNpc.ArmorPid+1;
            if(CurrentNpc.HelmPid<1)
                cmbHelmetPid.SelectedIndex = CurrentNpc.HelmPid+1;

            for(int i=0;i<ArmorProtos.Count;i++)
            {
                if (CurrentNpc.HelmPid > 0 && CurrentNpc.HelmPid == ArmorProtos[i].ProtoId)
                    cmbHelmetPid.SelectedIndex = i + 2;
                if (CurrentNpc.ArmorPid > 0 && CurrentNpc.ArmorPid == ArmorProtos[i].ProtoId)
                    cmbArmorPid.SelectedIndex = i + 2;
            }
            if (cmbArmorPid.SelectedIndex != 0)
            {
                for (int y = 0; y < cmbForcedCrType.Items.Count; y++)
                    if (cmbForcedCrType.Items[y].ToString().Contains("[" + CurrentNpc.ForcedCrType + "]"))
                        cmbForcedCrType.SelectedIndex = y;
            }
            else
                cmbForcedCrType.Items.Clear();
        }

        private void RefreshItems()
        {
            if (CurrentNpc.Items.Count == 1)
                lstNpcItems.SetObjects(null);
            lstNpcItems.SetObjects(CurrentNpc.Items);
            foreach (EncounterItem It in CurrentNpc.Items)
            {
                It.Item.Define = ItemPid.GetDefineName(It.Item.Pid);
            }

            lstNpcItems.SelectedObject = CurrentItem;
        }

        private void RefreshPerks()
        {
            if (CurrentNpc == null) return;
            if (CurrentNpc.Perks.Count == 1)
                lstPerks.SetObjects(null);
            lstPerks.SetObjects(CurrentNpc.Perks);
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the name of the new group", "Add Group", "GROUP_", -1, -1);
            if (!input.Contains("GROUP"))
            {
                Message.Show("Group name must contain 'GROUP'", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FOCommon.Worldmap.EncounterGroup.EncounterGroup newGrp = new FOCommon.Worldmap.EncounterGroup.EncounterGroup();
            newGrp.Name = input;
            newGrp.Id = Groups.Count;
            Groups.Add(newGrp);
            RefreshGroupList();
        }

        private void btnRemoveGroup_Click(object sender, EventArgs e)
        {
            Groups.Remove(CurrentGroup);

            int lastId = 0;
            foreach (FOCommon.Worldmap.EncounterGroup.EncounterGroup Grp in Groups)
            {
                if (lastId != 0 && (Grp.Id - lastId) > 1)
                    Grp.Id = lastId+1;
                lastId = Grp.Id;
            }

            RefreshGroupList();
            RefreshNpcList();
        }

        private void lstGroups_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Groups.Remove(CurrentGroup);
                RefreshGroupList();
                RefreshNpcList();
            }
        }

        private void btnSelectDialog_Click(object sender, EventArgs e)
        {
            frmSelectObject sp = new frmSelectObject("Select dialog for NPC.", "Double-click on dialog to open it in dialog editor.");
            foreach (ListDialog dlg in DialogParser.GetDialogs(true))
                sp.AddObject((object)dlg);
            sp.ShowDialog();
            if (sp.Selected != 0)
            {
                numDialog.Value = sp.Selected;
                if (CurrentNpc != null)
                    CurrentNpc.Dialog.Id=sp.Selected;
            }
            RefreshNpcList();
        }

        private void btnSelectFaction_Click(object sender, EventArgs e)
        {
            frmSelectObject sp = new frmSelectObject("Select faction for group.", "");
            foreach (Faction cr in Factions)
                sp.AddObject((object)cr);
            sp.ShowDialog();
            if (sp.Selected != 0)
            {
                numFactionId.Value = sp.Selected;
                if (CurrentGroup != null)
                    CurrentGroup.FactionId = sp.Selected;
            }
            RefreshGroupList();
        }

        private void btnSelectProto_Click(object sender, EventArgs e)
        {
            frmSelectObject sp = new frmSelectObject("Select critter proto for NPC.", "");
            foreach (CritterProto cr in CrProtos)
                sp.AddObject((object)cr);
            sp.ShowDialog();
            if (sp.Selected != 0)
            {
                numProto.Value = sp.Selected;
                if (CurrentNpc!=null)
                    CurrentNpc.Proto.Id = sp.Selected;
            }
            RefreshNpcList();
        }

        private void RemoveNpc()
        {
            CurrentGroup.Npcs.Remove(CurrentNpc);
            CurrentGroup.NpcCount--;
            RefreshNpcList();
            lstGroups.RefreshObject(CurrentGroup);
        }

        private void lstNpcs_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete)
                RemoveNpc();
        }

        private void btnRemoveNpc_Click(object sender, EventArgs e)
        {
            RemoveNpc();
        }

        private int GetArmorPid()
        {
            if (cmbArmorPid.SelectedIndex > 1)
                return ArmorProtos[cmbArmorPid.SelectedIndex - 2].ProtoId;
            else
                return cmbArmorPid.SelectedIndex-1;
        }

        private int GetHelmPid()
        {
            if (cmbHelmetPid.SelectedIndex > 1)
                return ArmorProtos[cmbHelmetPid.SelectedIndex - 2].ProtoId;
            else
                return cmbHelmetPid.SelectedIndex-1;
        }

        private int GetForcedCrType()
        {
            // Non-default
            if (cmbArmorPid.SelectedIndex != 0)
            {
                string Txt = cmbForcedCrType.Text;
                if (String.IsNullOrEmpty(Txt))
                    return 0;
                string Sub = Txt.Substring(Txt.IndexOf('[') + 1, Txt.Length - Txt.IndexOf(']') + 1);
                return Int32.Parse(Sub); // Ugly
            }
            return 0;
        }

        private void btnAddNpc_Click(object sender, EventArgs e)
        {
            EncounterNpc Npc = new EncounterNpc(Decimal.ToInt32(numProto.Value), Decimal.ToInt32(numDialog.Value), cmbScript.Text, Decimal.ToInt32(numNpcRatio.Value), chkDead.Checked,
                GetArmorPid(), GetHelmPid(), GetForcedCrType());
            if (lstNpcItems.Items.Count > 0)
            {
                foreach (Object o in lstNpcItems.Objects)
                {
                    EncounterItem item = (EncounterItem)o;
                    Npc.AddItem(item);
                }
            }
            CurrentGroup.Npcs.Add(Npc);
            CurrentGroup.NpcCount++;
            RefreshNpcList();
        }

        private void lstNpcItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                CurrentNpc.RemoveItem(CurrentItem);
                RefreshItems();
                RefreshNpcList();
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            CurrentNpc.RemoveItem(CurrentItem);
            RefreshItems();
            RefreshNpcList();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbItemPid.SelectedIndex==-1)
            {
                Message.Show("No item PID selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbSlot.SelectedIndex==-1)
            {
                Message.Show("No item slot selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EncounterItem Item = new EncounterItem(ItemPid.GetPid(cmbItemPid.SelectedItem.ToString()), Decimal.ToInt32(numItemMin.Value), Decimal.ToInt32(numItemMax.Value), cmbSlot.SelectedIndex);
            CurrentNpc.AddItem(Item);
            RefreshItems();
            RefreshNpcList();
        }

        private void txtGMName_TextChanged(object sender, EventArgs e)
        {
            if (CurrentGroup == null)
                return;

            CurrentGroup.GMName = txtGMName.Text;
            lstGroups.RefreshObject(CurrentGroup);
        }

        private void numProto_ValueChanged(object sender, EventArgs e)
        {
            if (CurrentNpc == null)
                return;
            CurrentNpc.Proto.Id = Decimal.ToInt32(numProto.Value);
            RefreshNpcList();
        }

        private void numFactionId_ValueChanged(object sender, EventArgs e)
        {
            if (CurrentGroup == null)
                return;

            CurrentGroup.FactionId = Decimal.ToInt32(numFactionId.Value);
            RefreshCurrentGroup();
        }

        private void cmbScript_TextChanged(object sender, EventArgs e)
        {
            if (CurrentNpc == null)
                return;

            CurrentNpc.Script = cmbScript.Text;
            RefreshNpcList();
        }

        private void numDialog_ValueChanged(object sender, EventArgs e)
        {
            if (CurrentNpc == null)
                return;

            CurrentNpc.Dialog.Id=(Decimal.ToInt32(numDialog.Value));
            RefreshNpcList();
        }

        private void cmbSlot_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CurrentItem == null)
                return;

            //CurrentItem.SetSlot(cmbSlot.SelectedIndex);
            //RefreshItems();
        }

        private void numNpcRatio_ValueChanged(object sender, EventArgs e)
        {
            if (CurrentNpc == null)
                return;

            CurrentNpc.Ratio = Decimal.ToInt32(numNpcRatio.Value);
            RefreshNpcList();
        }

        private void lstNpcs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EncounterNpc Npc = (EncounterNpc)lstNpcs.SelectedObject;
            if ((Npc == null) || (Npc.Proto.Id == 0))
                return;
            frmProtoCritterEditor critterEdit = new frmProtoCritterEditor(null, Npc.Proto.Id);
            critterEdit.ShowDialog();
        }

        private void lstNpcItems_SelectionChanged(object sender, EventArgs e)
        {
            EncounterItem Item = (EncounterItem)lstNpcItems.SelectedObject;
            if (Item == null)
                return;

            if (CurrentItem == Item)
                return;
           
            CurrentItem = Item;
            

            cmbItemPid.SelectedIndex = cmbItemPid.Items.IndexOf(Item.Item.Define);
            cmbSlot.SelectedIndex = (int)Item.Slot;
            numItemMin.Value = Item.Min;
            numItemMax.Value = Item.Max;
        }

        private void numItemMax_ValueChanged(object sender, EventArgs e)
        {
            if (CurrentItem == null)
                return;

            //CurrentItem.Max = Decimal.ToInt32(numItemMax.Value);
            //RefreshItems();
        }

        private void numItemMin_ValueChanged(object sender, EventArgs e)
        {
            if (CurrentItem == null)
                return;

            //CurrentItem.Min = Decimal.ToInt32(numItemMin.Value);
            //RefreshItems();
        }

        private void cmbItemPid_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CurrentItem == null)
                return;

            //CurrentItem.Item = ItemPid.GetItemByDefine(cmbItemPid.SelectedItem.ToString());
            //RefreshItems();
        }

        private void lstNpcs_SelectionChanged(object sender, EventArgs e)
        {
            EncounterNpc Npc = (EncounterNpc)lstNpcs.SelectedObject;
            if (Npc == null)
                return;

            if (CurrentNpc == Npc)
                return;

            if (CurrentNpc != null)
                SaveCurrentNpc();

            CurrentNpc = Npc;
            RefreshItems();
            RefreshArmor();
            RefreshPerks();

            numDialog.Value = Npc.Dialog.Id;
            cmbScript.Text = Npc.Script;
            numProto.Value = Npc.Proto.Id;
            numNpcRatio.Value = Npc.Ratio;
            chkDead.Checked = Npc.Dead;
        }

        private void lstGroups_SelectionChanged(object sender, EventArgs e)
        {
            FOCommon.Worldmap.EncounterGroup.EncounterGroup grp = (FOCommon.Worldmap.EncounterGroup.EncounterGroup)lstGroups.SelectedObject;
            if (grp == null)
                return;

            if (CurrentGroup != null)
                SaveCurrentGroup();

            CurrentGroup = grp;
            RefreshNpcList();
            RefreshPerks();

            numGroupId.Value = grp.Id;
            numSpacing.Value = grp.Spacing;
            numRatioMin.Value = grp.RatioMin;
            numRatioMax.Value = grp.RatioMax;
            numDistMin.Value = grp.DistMin;
            numDistMax.Value = grp.DistMax;
            numFactionId.Value = grp.FactionId;
            cmbFactionMode.SelectedIndex = grp.FactionMode;
            cmbGroupPosition.SelectedIndex = grp.Position - 1;
            numQuantityDay.Value = decimal.Parse(grp.QuantityDay.ToString());
            numQuantityNight.Value = decimal.Parse(grp.QuantityNight.ToString());
            txtGMName.Text = grp.GMName;
        }

        private void btnFilterGroups_Click(object sender, EventArgs e)
        {
            frmFilter.ShowDialog();
            RefreshGroupList();
        }

        private void btnAddPerk_Click(object sender, EventArgs e)
        {
            if (CurrentNpc == null) return;
            if (cmbPerkDefine.SelectedIndex == -1) return;
            CurrentNpc.Perks.Add(new EncounterPerk() {
                Define=cmbPerkDefine.SelectedItem.ToString(), 
                Index=DefineParser.Defines[cmbPerkDefine.SelectedItem.ToString()],
                Level=(int)numPerkLevel.Value,
                Chance=(int)numPerkChance.Value});
            RefreshPerks();
        }

        private void btnRemovePerk_Click(object sender, EventArgs e)
        {
            EncounterPerk CurrentPerk = (EncounterPerk)lstPerks.SelectedObject;
            if (CurrentPerk == null)
                return;
            CurrentNpc.Perks.Remove(CurrentPerk);
            RefreshPerks();
        }

        private void btnChangeItem_Click(object sender, EventArgs e)
        {
            if (cmbItemPid.SelectedIndex == -1)
            {
                Message.Show("No item PID selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbSlot.SelectedIndex == -1)
            {
                Message.Show("No item slot selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            /* EncounterItem Item = (EncounterItem)lstNpcItems.SelectedObject;
            if (Item == null)
                return;

            if (CurrentItem == Item)
                return;

            CurrentItem = Item;

            if (CurrentItem == null)
                return;

            //if (CurrentItem != null)
            //    SaveCurrentItem();
            */

            if (CurrentItem != null)
                SaveCurrentItem();
            //CurrentItem.Item = ItemPid.GetItemByDefine(cmbItemPid.SelectedItem.ToString());
            //CurrentItem.Slot = (SlotEnum)cmbSlot.SelectedIndex;
            //CurrentItem.Min = Decimal.ToInt32(numItemMin.Value);
            //CurrentItem.Max = Decimal.ToInt32(numItemMax.Value);

            RefreshItems();
        }


    }
}


