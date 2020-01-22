using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorldEditor.ProtoEditor
{
    public partial class frmProtoCritterEditor : Form
    {
        public ProtoCritter pc;
        public frmCritterProtoList parent;
        bool deleteOnExit;
        private List<NumericUpDown> SkillNums = new List<NumericUpDown>();
        private List<NumericUpDown> SkillBaseNums = new List<NumericUpDown>();
        private List<NumericUpDown> skillFullNums = new List<NumericUpDown>();
        private List<NumericUpDown> StatNums = new List<NumericUpDown>();
        private List<NumericUpDown> DTNums = new List<NumericUpDown>();
        private List<NumericUpDown> DRNums = new List<NumericUpDown>();
        private List<string> Modes = new List<string>();
        private List<string> Perks = new List<string>();
        private List<string> Traits = new List<string>();
        private List<IntPair> ModesLevels = new List<IntPair>();
        private List<IntPair> PerksLevels = new List<IntPair>();
        private List<IntPair> TraitsLevels = new List<IntPair>();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams result = base.CreateParams;
                if (Environment.OSVersion.Platform == PlatformID.Win32NT
                    && Environment.OSVersion.Version.Major >= 6)
                {
                    result.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                }

                return result;
            }
        }

        public frmProtoCritterEditor(frmCritterProtoList parent, int pcid)
        {
            this.parent = parent;
            this.pc = ProtoManager.Protos[pcid].DeepCopy();
            this.deleteOnExit = false;
            InitializeComponent();
        }
        public frmProtoCritterEditor(frmCritterProtoList parent, int pcid, bool deleteOnExit)
        {
            this.deleteOnExit = deleteOnExit;
            this.parent = parent;
            this.pc = ProtoManager.Protos[pcid].DeepCopy();
            InitializeComponent();
        }

        public void LoadProto()
        {
            for (int i = Consts.ST_STRENGTH; i <= Consts.ST_LUCK;i++ )
                StatNums[i].Value = pc.Params[i];

            hpNum.Value = pc.Params[Consts.ST_MAX_LIFE];
            apNum.Value = pc.Params[Consts.ST_ACTION_POINTS];
            acNum.Value = pc.Params[Consts.ST_ARMOR_CLASS];
            mdNum.Value = pc.Params[Consts.ST_MELEE_DAMAGE];
            cwNum.Value = pc.Params[Consts.ST_CARRY_WEIGHT];
            seqNum.Value = pc.Params[Consts.ST_SEQUENCE];
            hrNum.Value = pc.Params[Consts.ST_HEALING_RATE];
            critNum.Value = pc.Params[Consts.ST_CRITICAL_CHANCE];
            killExpNum.Value = pc.Params[Consts.ST_KILL_EXPERIENCE];
            ageNum.Value = pc.Params[Consts.ST_AGE];
            baseCrTypeNum.Value = pc.Params[Consts.ST_BASE_CRTYPE];
            dialogIdNum.Value = pc.Params[Consts.ST_DIALOG_ID];
            aiPackNum.Value = pc.Params[Consts.ST_AI_ID];
            teamIdNum.Value = pc.Params[Consts.ST_TEAM_ID];
            bagIdNum.Value = pc.Params[Consts.ST_BAG_ID];
            nameText.Text = pc.Name;
            descText.Text = pc.Desc;
            locomotionBox.SelectedIndex = pc.Params[Consts.ST_LOCOMOTION_TYPE];
            damageTypeBox.SelectedIndex = pc.Params[Consts.ST_DAMAGE_TYPE];
            genderBox.SelectedIndex = pc.Params[Consts.ST_GENDER];
            bodytypeBox.SelectedIndex = pc.Params[Consts.ST_BODY_TYPE];

            for (int i = Consts.SK_SMALL_GUNS; i <= Consts.SK_OUTDOORSMAN; i++)
                SkillNums[i - Consts.SK_SMALL_GUNS].Value = pc.Params[i];

            for (int i = Consts.ST_NORMAL_ABSORB; i <= Consts.ST_EXPLODE_ABSORB; i++)
                DTNums[i - Consts.ST_NORMAL_ABSORB].Value = pc.Params[i];

            for (int i = Consts.ST_NORMAL_RESIST; i <= Consts.ST_EXPLODE_RESIST; i++)
                DRNums[i - Consts.ST_NORMAL_RESIST].Value = pc.Params[i];

            poisonNum.Value = pc.Params[Consts.ST_POISON_RESISTANCE];
            radNum.Value = pc.Params[Consts.ST_RADIATION_RESISTANCE];

            savefileBox.SelectedIndex = ProtoManager.CorrectFileIndex(pc.Savefile);
            Perks.Clear();
            PerksLevels.Clear();
            Traits.Clear();
            TraitsLevels.Clear();
            Modes.Clear();
            ModesLevels.Clear();

            for (int i = Consts.PERK_BEGIN; i <= Consts.PERK_END; i++)
                SetParam(PerksLevels, Perks, i, pc.Params[i]);

            for (int i = Consts.MODE_BEGIN; i <= Consts.MODE_END; i++)
                SetParam(ModesLevels, Modes, i, pc.Params[i]);

            for (int i = Consts.TRAIT_BEGIN; i <= Consts.TRAIT_END; i++)
                SetParam(TraitsLevels, Traits, i, pc.Params[i]);

            UpdateBaseStats();
            for (int i = 0; i < 18; i++) UpdateFullSkill(i);
        }

        private void SaveProto()
        {
            this.pc.ClearExtra();
            for (int i = Consts.ST_STRENGTH; i <= Consts.ST_LUCK; i++)
                pc.Params[i] = (int)StatNums[i].Value;

            pc.Params[Consts.ST_MAX_LIFE] = (int)hpNum.Value;
            pc.Params[Consts.ST_ACTION_POINTS] = (int)apNum.Value;
            pc.Params[Consts.ST_ARMOR_CLASS] = (int)acNum.Value;
            pc.Params[Consts.ST_MELEE_DAMAGE] = (int)mdNum.Value;
            pc.Params[Consts.ST_CARRY_WEIGHT] = (int)cwNum.Value;
            pc.Params[Consts.ST_SEQUENCE] = (int)seqNum.Value;
            pc.Params[Consts.ST_HEALING_RATE] = (int)hrNum.Value;
            pc.Params[Consts.ST_CRITICAL_CHANCE] = (int)critNum.Value;
            pc.Params[Consts.ST_KILL_EXPERIENCE] = (int)killExpNum.Value;
            pc.Params[Consts.ST_AGE] = (int)ageNum.Value;
            pc.Params[Consts.ST_BASE_CRTYPE] = (int)baseCrTypeNum.Value;
            pc.Params[Consts.ST_DIALOG_ID] = (int)dialogIdNum.Value;
            pc.Params[Consts.ST_AI_ID] = (int)aiPackNum.Value;
            pc.Params[Consts.ST_TEAM_ID] = (int)teamIdNum.Value;
            pc.Params[Consts.ST_BAG_ID] = (int)bagIdNum.Value;
            pc.Name = nameText.Text;
            pc.Desc = descText.Text;
            pc.Params[Consts.ST_LOCOMOTION_TYPE] = locomotionBox.SelectedIndex;
            pc.Params[Consts.ST_DAMAGE_TYPE] = damageTypeBox.SelectedIndex;
            pc.Params[Consts.ST_GENDER] = genderBox.SelectedIndex;
            pc.Params[Consts.ST_BODY_TYPE] = bodytypeBox.SelectedIndex;

            for (int i = Consts.SK_SMALL_GUNS; i <= Consts.SK_OUTDOORSMAN; i++)
                pc.Params[i] = (int)SkillNums[i - Consts.SK_SMALL_GUNS].Value;

            for (int i = Consts.ST_NORMAL_ABSORB; i <= Consts.ST_EXPLODE_ABSORB; i++)
                pc.Params[i] = (int)DTNums[i - Consts.ST_NORMAL_ABSORB].Value;

            for (int i = Consts.ST_NORMAL_RESIST; i <= Consts.ST_EXPLODE_RESIST; i++)
                pc.Params[i] = (int)DRNums[i - Consts.ST_NORMAL_RESIST].Value;

            pc.Params[Consts.ST_POISON_RESISTANCE] = (int)poisonNum.Value;
            pc.Params[Consts.ST_RADIATION_RESISTANCE] = (int)radNum.Value;

            pc.Savefile = (string)savefileBox.SelectedValue;

            foreach (IntPair pair in PerksLevels) pc.Params[pair.Key] = pair.Value;
            foreach (IntPair pair in ModesLevels) pc.Params[pair.Key] = pair.Value;
            foreach (IntPair pair in TraitsLevels) pc.Params[pair.Key] = pair.Value;
        }

        private void PrepareUpDown(NumericUpDown updown)
        {
            updown.Controls[0].Hide();
            updown.Region = new System.Drawing.Region(new
System.Drawing.Rectangle(0, 0, updown.Width - updown.Controls[0].Width
- 2, updown.Height));
        }
        private void PrepareUpDowns(List<NumericUpDown> updowns)
        {
            foreach (NumericUpDown updown in updowns) PrepareUpDown(updown);
        }

        private void GroupSkillsNums()
        {
            SkillNums.Add(skill0Num);
            SkillNums.Add(skill1Num);
            SkillNums.Add(skill2Num);
            SkillNums.Add(skill3Num);
            SkillNums.Add(skill4Num);
            SkillNums.Add(skill5Num);
            SkillNums.Add(skill6Num);
            SkillNums.Add(skill7Num);
            SkillNums.Add(skill8Num);
            SkillNums.Add(skill9Num);
            SkillNums.Add(skill10Num);
            SkillNums.Add(skill11Num);
            SkillNums.Add(skill12Num);
            SkillNums.Add(skill13Num);
            SkillNums.Add(skill14Num);
            SkillNums.Add(skill15Num);
            SkillNums.Add(skill16Num);
            SkillNums.Add(skill17Num);

            skillFullNums.Add(skill0FullNum);
            skillFullNums.Add(skill1FullNum);
            skillFullNums.Add(skill2FullNum);
            skillFullNums.Add(skill3FullNum);
            skillFullNums.Add(skill4FullNum);
            skillFullNums.Add(skill5FullNum);
            skillFullNums.Add(skill6FullNum);
            skillFullNums.Add(skill7FullNum);
            skillFullNums.Add(skill8FullNum);
            skillFullNums.Add(skill9FullNum);
            skillFullNums.Add(skill10FullNum);
            skillFullNums.Add(skill11FullNum);
            skillFullNums.Add(skill12FullNum);
            skillFullNums.Add(skill13FullNum);
            skillFullNums.Add(skill14FullNum);
            skillFullNums.Add(skill15FullNum);
            skillFullNums.Add(skill16FullNum);
            skillFullNums.Add(skill17FullNum);

            SkillBaseNums.Add(skill0BaseNum);
            SkillBaseNums.Add(skill1BaseNum);
            SkillBaseNums.Add(skill2BaseNum);
            SkillBaseNums.Add(skill3BaseNum);
            SkillBaseNums.Add(skill4BaseNum);
            SkillBaseNums.Add(skill5BaseNum);
            SkillBaseNums.Add(skill6BaseNum);
            SkillBaseNums.Add(skill7BaseNum);
            SkillBaseNums.Add(skill8BaseNum);
            SkillBaseNums.Add(skill9BaseNum);
            SkillBaseNums.Add(skill10BaseNum);
            SkillBaseNums.Add(skill11BaseNum);
            SkillBaseNums.Add(skill12BaseNum);
            SkillBaseNums.Add(skill13BaseNum);
            SkillBaseNums.Add(skill14BaseNum);
            SkillBaseNums.Add(skill15BaseNum);
            SkillBaseNums.Add(skill16BaseNum);
            SkillBaseNums.Add(skill17BaseNum);
        }
        private void GroupStatNums()
        {
            StatNums.Add(stNum);
            StatNums.Add(peNum);
            StatNums.Add(enNum);
            StatNums.Add(chNum);
            StatNums.Add(inNum);
            StatNums.Add(agNum);
            StatNums.Add(lkNum);
        }
        private void GroupDamageNums()
        {
            DTNums.Add(dt0Num);
            DTNums.Add(dt1Num);
            DTNums.Add(dt2Num);
            DTNums.Add(dt3Num);
            DTNums.Add(dt4Num);
            DTNums.Add(dt5Num);
            DTNums.Add(dt6Num);
            DRNums.Add(dr0Num);
            DRNums.Add(dr1Num);
            DRNums.Add(dr2Num);
            DRNums.Add(dr3Num);
            DRNums.Add(dr4Num);
            DRNums.Add(dr5Num);
            DRNums.Add(dr6Num);
        }

        private void UpdateBaseStats()
        {
            UpdateBaseHP();
            UpdateBaseAP();
            UpdateBaseAC();
            UpdateBaseMD();
            UpdateBaseCW();
            UpdateBaseSeq();
            UpdateBaseHR();
            UpdateBaseCrit();
            UpdateBasePoison();
            UpdateBaseRad();
        }

        private void UpdateBaseHP() { hpBaseNum.Value = 15 + stNum.Value + 2 * enNum.Value; UpdateFullHP();  }
        private void UpdateBaseAP() { apBaseNum.Value = 5 + (int)agNum.Value / 2; UpdateFullAP();  }
        private void UpdateBaseAC() { acBaseNum.Value = agNum.Value; UpdateFullAC();  }
        private void UpdateBaseMD() { if (stNum.Value > 5) mdBaseNum.Value = (stNum.Value - 5); else mdBaseNum.Value = 1; UpdateFullMD();  }
        private void UpdateBaseCW() { cwBaseNum.Value = (453 * (25 + (stNum.Value + 1))); UpdateFullCW();  }
        private void UpdateBaseSeq() { seqBaseNum.Value = (2 * seqNum.Value); UpdateFullSeq();  }
        private void UpdateBaseHR() { if (enNum.Value > 5) hrBaseNum.Value = ((int)enNum.Value / 3); else hrBaseNum.Value = 1; UpdateFullHR();  }
        private void UpdateBaseCrit() { critBaseNum.Value = lkNum.Value; UpdateFullCrit();  }
        private void UpdateBasePoison() { poisonBaseNum.Value = 5 * enNum.Value; UpdateFullPoison(); }
        private void UpdateBaseRad() { radBaseNum.Value = 2 * enNum.Value; UpdateFullRad(); }

        private void UpdateFullHP() { hpFullNum.Value = hpBaseNum.Value + hpNum.Value; }
        private void UpdateFullAP() { apFullNum.Value = apBaseNum.Value + apNum.Value; }
        private void UpdateFullAC() { acFullNum.Value = acBaseNum.Value + acNum.Value; }
        private void UpdateFullMD() { mdFullNum.Value = mdBaseNum.Value + mdNum.Value; }
        private void UpdateFullCW() { cwFullNum.Value = cwBaseNum.Value + cwNum.Value; }
        private void UpdateFullSeq() { seqFullNum.Value = seqBaseNum.Value + seqNum.Value; }
        private void UpdateFullHR() { hrFullNum.Value = hrBaseNum.Value + hrNum.Value; }
        private void UpdateFullCrit() { critFullNum.Value = critBaseNum.Value + critNum.Value; }
        private void UpdateFullPoison() { poisonFullNum.Value = poisonBaseNum.Value + poisonNum.Value; }
        private void UpdateFullRad() { radFullNum.Value = radBaseNum.Value + radNum.Value; }

        private void UpdatedStat(int stat)
        {
            switch (stat)
            {
                case Consts.ST_STRENGTH:
                    UpdateBaseCW();
                    UpdateBaseHP();
                    UpdateBaseMD();
                    break;
                case Consts.ST_PERCEPTION:
                    UpdateBaseSeq();
                    break;
                case Consts.ST_ENDURANCE:
                    UpdateBaseHR();
                    UpdateBaseHP();
                    UpdateBasePoison();
                    UpdateBaseRad();
                    break;
                case Consts.ST_CHARISMA:
                    break;
                case Consts.ST_INTELLECT:
                    break;
                case Consts.ST_AGILITY:
                    UpdateBaseAC();
                    UpdateBaseAP();
                    break;
                case Consts.ST_LUCK:
                    UpdateBaseCrit();
                    break;
                case Consts.ST_MAX_LIFE:
                    UpdateFullHP();
                    break;
                case Consts.ST_ACTION_POINTS:
                    UpdateFullAP();
                    break;
                case Consts.ST_ARMOR_CLASS:
                    UpdateFullAC();
                    break;
                case Consts.ST_MELEE_DAMAGE:
                    UpdateFullMD();
                    break;
                case Consts.ST_CARRY_WEIGHT:
                    UpdateFullCW();
                    break;
                case Consts.ST_SEQUENCE:
                    UpdateFullSeq();
                    break;
                case Consts.ST_HEALING_RATE:
                    UpdateFullHR();
                    break;
                case Consts.ST_CRITICAL_CHANCE:
                    UpdateFullCrit();
                    break;
            }
            if (stat <= Consts.ST_LUCK)
                foreach (int skill in ParamsDefines.Depends[stat])
                    UpdateBaseSkill(skill);
        }
        private void UpdateBaseSkill(int skill)
        {
            int baseval=0;

            foreach (IntPair pair in ParamsDefines.SkillFormulas[skill])
            {
                if (pair.Key == -1) baseval += pair.Value;
                else
                    baseval += (int)StatNums[pair.Key].Value * pair.Value;
            }
            SkillBaseNums[skill].Value = baseval;
            UpdateFullSkill(skill);
        }
        private void UpdateFullSkill(int skill)
        {
            skillFullNums[skill].Value = SkillNums[skill].Value + SkillBaseNums[skill].Value;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveProto();
            frmProtoCritterRawEditor form = new frmProtoCritterRawEditor(this,this.pc);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveProto();
            ProtoManager.SaveProtoAs(this.pc, this.pc.Id);
            if(this.parent!=null)
                parent.RefreshList();
            else
                ProtoManager.Save();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (deleteOnExit)
                ProtoManager.Remove(this.pc.Id);
            if (this.parent != null)
                parent.RefreshList();
            this.Close();
        }

        private void frmProtoCritterEditor_Load(object sender, EventArgs e)
        {
            this.Text = "Critter Proto Editor: PID "+pc.Id;
            PrepareUpDown(hpBaseNum);
            PrepareUpDown(apBaseNum);
            PrepareUpDown(acBaseNum);
            PrepareUpDown(mdBaseNum);
            PrepareUpDown(cwBaseNum);
            PrepareUpDown(seqBaseNum);
            PrepareUpDown(hrBaseNum);
            PrepareUpDown(critBaseNum);
            PrepareUpDown(hpFullNum);
            PrepareUpDown(apFullNum);
            PrepareUpDown(acFullNum);
            PrepareUpDown(mdFullNum);
            PrepareUpDown(cwFullNum);
            PrepareUpDown(seqFullNum);
            PrepareUpDown(hrFullNum);
            PrepareUpDown(critFullNum);
            PrepareUpDown(poisonBaseNum);
            PrepareUpDown(radBaseNum);
            PrepareUpDown(poisonFullNum);
            PrepareUpDown(radFullNum);
            ParamsDefines.FillBodytypes(bodytypeBox);
            ParamsDefines.FillModes(modesBox);
            ParamsDefines.FillTraits(traitsBox);
            ParamsDefines.FillPerks(perksBox);
            ProtoManager.FillFilenames(savefileBox);

            GroupStatNums();
            GroupSkillsNums();
            GroupDamageNums();
            PrepareUpDowns(SkillBaseNums);
            PrepareUpDowns(skillFullNums);

            LoadProto();

            perksList.DataSource = Perks;
            modesList.DataSource = Modes;
            traitsList.DataSource = Traits;
            this.Refresh();
        }
        private void AddParam(List<IntPair> levels, List<string> display, string param)
        {
            int id = ParamsDefines.ParamNames[param];
            //for (int i=0, j=levels.Count; i<j ; i++)
            for (int i = 0; i < levels.Count; i++)
            {
                if (levels[i].Key == id)
                {
                    levels[i].Value++;
                    display[i] = param;
                    if (levels[i].Value > 1) display[i] += " (" + levels[i].Value + ")";
                    return;
                }
            }
            levels.Add(new IntPair(id,1));
            display.Add(param);
        }
        private void SetParam(List<IntPair> levels, List<string> display, int id, int level)
        {
            if (level == 0) return;
            string name = ParamsDefines.Names[id];
            levels.Add(new IntPair(id, level));
            display.Add(name);
        }
        private void RemoveParam(List<IntPair> levels, List<string> display, int id)
        {
            if (id == -1) return;
            if (levels[id].Value == 1)
            {
                levels.RemoveAt(id);
                display.RemoveAt(id);
            }
            else
            {
                levels[id].Value--;
                display[id] = ParamsDefines.Names[levels[id].Key];
                if (levels[id].Value > 1) display[id] += " (" + levels[id].Value + ")";
            }
        }
        private void stNum_ValueChanged(object sender, EventArgs e)
        {
            UpdatedStat(Consts.ST_STRENGTH);
        }

        private void peNum_ValueChanged(object sender, EventArgs e)
        {
            UpdatedStat(Consts.ST_PERCEPTION);
        }

        private void enNum_ValueChanged(object sender, EventArgs e)
        {
            UpdatedStat(Consts.ST_ENDURANCE);
        }

        private void chNum_ValueChanged(object sender, EventArgs e)
        {
            UpdatedStat(Consts.ST_CHARISMA);
        }

        private void inNum_ValueChanged(object sender, EventArgs e)
        {
            UpdatedStat(Consts.ST_INTELLECT);
        }

        private void agNum_ValueChanged(object sender, EventArgs e)
        {
            UpdatedStat(Consts.ST_AGILITY);
        }

        private void lkNum_ValueChanged(object sender, EventArgs e)
        {
            UpdatedStat(Consts.ST_LUCK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddParam(PerksLevels, Perks, (string)perksBox.SelectedValue);
            perksList.DataSource = null;
            perksList.DataSource = Perks;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddParam(ModesLevels, Modes, (string)modesBox.SelectedValue);
            modesList.DataSource = null;
            modesList.DataSource = Modes;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddParam(TraitsLevels, Traits, (string)traitsBox.SelectedValue);
            traitsList.DataSource = null;
            traitsList.DataSource = Traits;
        }

        private void perksList_DoubleClick(object sender, EventArgs e)
        {
            RemoveParam(PerksLevels, Perks, perksList.SelectedIndex);
            perksList.DataSource = null;
            perksList.DataSource = Perks;
        }

        private void modesList_DoubleClick(object sender, EventArgs e)
        {
            RemoveParam(ModesLevels, Modes, modesList.SelectedIndex);
            modesList.DataSource = null;
            modesList.DataSource = Modes;
        }

        private void traitsList_DoubleClick(object sender, EventArgs e)
        {
            RemoveParam(TraitsLevels, Traits, traitsList.SelectedIndex);
            traitsList.DataSource = null;
            traitsList.DataSource = Traits;
        }

        private void skill0Num_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullSkill(0);
        }

        private void skill1Num_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullSkill(1);
        }

        private void skill2Num_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullSkill(2);
        }

        private void skill3Num_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullSkill(3);
        }

        private void skill4Num_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullSkill(4);
        }

        private void skill5Num_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullSkill(5);
        }

        private void skill6Num_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullSkill(6);
        }

        private void skill7Num_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullSkill(7);
        }

        private void skill8Num_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullSkill(8);
        }

        private void skill9Num_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullSkill(9);
        }

        private void skill10Num_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullSkill(10);
        }

        private void skill11Num_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullSkill(11);
        }

        private void skill12Num_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullSkill(12);
        }

        private void skill13Num_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullSkill(13);
        }

        private void skill14Num_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullSkill(14);
        }

        private void skill15Num_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullSkill(15);
        }

        private void skill16Num_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullSkill(16);
        }

        private void skill17Num_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullSkill(17);
        }

        private void hpNum_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullHP();
        }

        private void apNum_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullAP();
        }

        private void acNum_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullAC();
        }

        private void mdNum_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullMD();
        }

        private void cwNum_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullCW();
        }

        private void seqNum_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullSeq();
        }

        private void hrNum_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullHR();
        }

        private void critNum_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullCrit();
        }

        private void poisonNum_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullPoison();
        }

        private void radNum_ValueChanged(object sender, EventArgs e)
        {
            UpdateFullRad();
        }
    }
    public class IntPair
    {
        public int Key;
        public int Value;
        public IntPair()
        {
            Key = 0;
            Value = 0;
        }
        public IntPair(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}
