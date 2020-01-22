namespace ObjectEditor
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlFilterButtons = new System.Windows.Forms.Panel();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.btnSetFilter = new System.Windows.Forms.Button();
            this.grpGeneralObjectInfo = new System.Windows.Forms.GroupBox();
            this.tabGeneralInfo = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.txtProtoFileName = new System.Windows.Forms.TextBox();
            this.lblProtoFileName = new System.Windows.Forms.Label();
            this.numPID = new System.Windows.Forms.NumericUpDown();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tabGraphics = new System.Windows.Forms.TabPage();
            this.btnSelectInventory = new System.Windows.Forms.Button();
            this.btnSelectGround = new System.Windows.Forms.Button();
            this.pctInventory = new System.Windows.Forms.PictureBox();
            this.pctGround = new System.Windows.Forms.PictureBox();
            this.txtInvPic = new System.Windows.Forms.TextBox();
            this.txtGroundPic = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lstProtos = new BrightIdeasSoftware.FastObjectListView();
            this.olvName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvPID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvCost = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvScript = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvScriptFunc = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvFile = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPageExt = new System.Windows.Forms.TabPage();
            this.grpExtInfoFlags = new System.Windows.Forms.GroupBox();
            this.grpExtInfoColor = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.numColorAlpha = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.numColorBlue = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.numColorGreen = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.numColorRed = new System.Windows.Forms.NumericUpDown();
            this.chkColorFlagColorizeInventory = new System.Windows.Forms.CheckBox();
            this.chkColorFlagColorize = new System.Windows.Forms.CheckBox();
            this.grpExtInfoIndicator = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.numIndicatorMax = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.numIndicatorStart = new System.Windows.Forms.NumericUpDown();
            this.grpExtInfoMaterial = new System.Windows.Forms.GroupBox();
            this.rdbMaterialGlass = new System.Windows.Forms.RadioButton();
            this.rdbMaterialMetal = new System.Windows.Forms.RadioButton();
            this.rdbMaterialPlastic = new System.Windows.Forms.RadioButton();
            this.rdbMaterialWood = new System.Windows.Forms.RadioButton();
            this.rdbMaterialDirt = new System.Windows.Forms.RadioButton();
            this.rdbMaterialStone = new System.Windows.Forms.RadioButton();
            this.rdbMaterialCement = new System.Windows.Forms.RadioButton();
            this.rdbMaterialLeather = new System.Windows.Forms.RadioButton();
            this.grpExtInfoCorner = new System.Windows.Forms.GroupBox();
            this.rdbCornerSouth = new System.Windows.Forms.RadioButton();
            this.rdbCornerEast = new System.Windows.Forms.RadioButton();
            this.rdbCornerWest = new System.Windows.Forms.RadioButton();
            this.rdbCornerNorth = new System.Windows.Forms.RadioButton();
            this.rdbCornerWestEast = new System.Windows.Forms.RadioButton();
            this.rdbCornerNorthSouth = new System.Windows.Forms.RadioButton();
            this.grpExtInfoEgg = new System.Windows.Forms.GroupBox();
            this.chkDisableEgg = new System.Windows.Forms.CheckBox();
            this.grpExtInfoLight = new System.Windows.Forms.GroupBox();
            this.numLightDistance = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.numLightIntensity = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.chkLightFlagDisableDir5 = new System.Windows.Forms.CheckBox();
            this.chkLightFlagDisableDir4 = new System.Windows.Forms.CheckBox();
            this.chkLightFlagDisableDir3 = new System.Windows.Forms.CheckBox();
            this.chkLightFlagDisableDir2 = new System.Windows.Forms.CheckBox();
            this.chkLightFlagDisableDir1 = new System.Windows.Forms.CheckBox();
            this.chkLightFlagDisableDir0 = new System.Windows.Forms.CheckBox();
            this.chkLightFlagGlobal = new System.Windows.Forms.CheckBox();
            this.chkLightFlagInverse = new System.Windows.Forms.CheckBox();
            this.chkLight = new System.Windows.Forms.CheckBox();
            this.grpExtInfoMain = new System.Windows.Forms.GroupBox();
            this.lblBaseCost = new System.Windows.Forms.Label();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.numVolume = new System.Windows.Forms.NumericUpDown();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.tabPageExt2 = new System.Windows.Forms.TabPage();
            this.grpSpriteCutting = new System.Windows.Forms.GroupBox();
            this.rdbSpriteCuttingDisabled = new System.Windows.Forms.RadioButton();
            this.rdbSpriteCuttingHorizontal = new System.Windows.Forms.RadioButton();
            this.rdbSpriteCuttingVertical = new System.Windows.Forms.RadioButton();
            this.grpAnimation = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.numAnimHide1 = new System.Windows.Forms.NumericUpDown();
            this.numAnimHide0 = new System.Windows.Forms.NumericUpDown();
            this.label41 = new System.Windows.Forms.Label();
            this.numAnimShow1 = new System.Windows.Forms.NumericUpDown();
            this.numAnimShow0 = new System.Windows.Forms.NumericUpDown();
            this.label40 = new System.Windows.Forms.Label();
            this.numAnimStay1 = new System.Windows.Forms.NumericUpDown();
            this.numAnimStay0 = new System.Windows.Forms.NumericUpDown();
            this.chkShowAnimExt = new System.Windows.Forms.CheckBox();
            this.numAnimWaitMax = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.numAnimWaitMin = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.numAnimWaitBase = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.chkShowAnim = new System.Windows.Forms.CheckBox();
            this.grpDrawOrderOffset = new System.Windows.Forms.GroupBox();
            this.numDrawOrderOffsetHexY = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.numDrawOffsetsY = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.numDrawOffsetsX = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.numHolodiskNum = new System.Windows.Forms.NumericUpDown();
            this.chkHolodiskEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.numSoundId = new System.Windows.Forms.NumericUpDown();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.numSlot = new System.Windows.Forms.NumericUpDown();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.chkRadioFlagDisableShiftChannel = new System.Windows.Forms.CheckBox();
            this.chkRadioFlagDisableShiftBCRecv = new System.Windows.Forms.CheckBox();
            this.chkRadioFlagDisableShiftBCSend = new System.Windows.Forms.CheckBox();
            this.chkRadioFlagDisableShiftRecv = new System.Windows.Forms.CheckBox();
            this.chkRadioFlagDisableShiftSend = new System.Windows.Forms.CheckBox();
            this.chkRadioFlagDisableRecv = new System.Windows.Forms.CheckBox();
            this.chkRadioFlagDisableSend = new System.Windows.Forms.CheckBox();
            this.chkRadioEnabled = new System.Windows.Forms.CheckBox();
            this.numRadioBroadcastReceive = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.numRadioBroadcastSend = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.numRadioChannel = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.grpScript = new System.Windows.Forms.GroupBox();
            this.txtScriptFunction = new System.Windows.Forms.TextBox();
            this.txtScriptModule = new System.Windows.Forms.TextBox();
            this.label87 = new System.Windows.Forms.Label();
            this.tabPageExt3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label67 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.numChildPid5 = new System.Windows.Forms.NumericUpDown();
            this.numChildPid4 = new System.Windows.Forms.NumericUpDown();
            this.numChildPid3 = new System.Windows.Forms.NumericUpDown();
            this.label65 = new System.Windows.Forms.Label();
            this.numChildPid2 = new System.Windows.Forms.NumericUpDown();
            this.label64 = new System.Windows.Forms.Label();
            this.numChildPid1 = new System.Windows.Forms.NumericUpDown();
            this.label63 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.txtChildLines5 = new System.Windows.Forms.TextBox();
            this.txtChildLines4 = new System.Windows.Forms.TextBox();
            this.txtChildLines3 = new System.Windows.Forms.TextBox();
            this.txtChildLines2 = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.txtChildLines1 = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.txtBlockLines = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkGroundLevel = new System.Windows.Forms.CheckBox();
            this.chkStackable = new System.Windows.Forms.CheckBox();
            this.chkDeteriorable = new System.Windows.Forms.CheckBox();
            this.grpInitialCondition = new System.Windows.Forms.GroupBox();
            this.label58 = new System.Windows.Forms.Label();
            this.numStartValue10 = new System.Windows.Forms.NumericUpDown();
            this.numStartValue9 = new System.Windows.Forms.NumericUpDown();
            this.label59 = new System.Windows.Forms.Label();
            this.numStartValue8 = new System.Windows.Forms.NumericUpDown();
            this.label60 = new System.Windows.Forms.Label();
            this.numStartValue7 = new System.Windows.Forms.NumericUpDown();
            this.label61 = new System.Windows.Forms.Label();
            this.numStartValue6 = new System.Windows.Forms.NumericUpDown();
            this.label62 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.numStartValue5 = new System.Windows.Forms.NumericUpDown();
            this.numStartValue4 = new System.Windows.Forms.NumericUpDown();
            this.label56 = new System.Windows.Forms.Label();
            this.numStartValue3 = new System.Windows.Forms.NumericUpDown();
            this.label55 = new System.Windows.Forms.Label();
            this.numStartValue2 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.numStartValue1 = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.numStartCount = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.panelProperties = new System.Windows.Forms.TabControl();
            this.tabPageArmor = new System.Windows.Forms.TabPage();
            this.tabControlArmor = new System.Windows.Forms.TabControl();
            this.ArmorMain = new System.Windows.Forms.TabPage();
            this.numCrTypeFemale = new System.Windows.Forms.NumericUpDown();
            this.lblCritterTypeFemale = new System.Windows.Forms.Label();
            this.numCrTypeMale = new System.Windows.Forms.NumericUpDown();
            this.lblCritterTypeMale = new System.Windows.Forms.Label();
            this.tabPageAmmo = new System.Windows.Forms.TabPage();
            this.tabControlAmmo = new System.Windows.Forms.TabControl();
            this.AmmoMain = new System.Windows.Forms.TabPage();
            this.numDrMod = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numAcMod = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCaliberAmmo = new System.Windows.Forms.ComboBox();
            this.label73 = new System.Windows.Forms.Label();
            this.tabPageCar = new System.Windows.Forms.TabPage();
            this.tabControlCar = new System.Windows.Forms.TabControl();
            this.CarMain = new System.Windows.Forms.TabPage();
            this.numCarEntrance = new System.Windows.Forms.NumericUpDown();
            this.label53 = new System.Windows.Forms.Label();
            this.numCarSpeed = new System.Windows.Forms.NumericUpDown();
            this.label49 = new System.Windows.Forms.Label();
            this.numCarCritterCapacity = new System.Windows.Forms.NumericUpDown();
            this.label48 = new System.Windows.Forms.Label();
            this.numCarPassability = new System.Windows.Forms.NumericUpDown();
            this.label47 = new System.Windows.Forms.Label();
            this.numCarFuelConsumption = new System.Windows.Forms.NumericUpDown();
            this.label46 = new System.Windows.Forms.Label();
            this.numCarTankVolume = new System.Windows.Forms.NumericUpDown();
            this.label45 = new System.Windows.Forms.Label();
            this.numCarMaxDeterioration = new System.Windows.Forms.NumericUpDown();
            this.label44 = new System.Windows.Forms.Label();
            this.numCarDeteriorationRate = new System.Windows.Forms.NumericUpDown();
            this.label43 = new System.Windows.Forms.Label();
            this.grpCarMovementType = new System.Windows.Forms.GroupBox();
            this.rdbCarMovementTypeGround = new System.Windows.Forms.RadioButton();
            this.rdbCarMovementTypeAir = new System.Windows.Forms.RadioButton();
            this.rdbCarMovementTypeWater = new System.Windows.Forms.RadioButton();
            this.tabPageContainer = new System.Windows.Forms.TabPage();
            this.tabControlContainer = new System.Windows.Forms.TabControl();
            this.ContainerMain = new System.Windows.Forms.TabPage();
            this.chkContainerMagicHandsGrnd = new System.Windows.Forms.CheckBox();
            this.chkContainerCannotPickup = new System.Windows.Forms.CheckBox();
            this.chkContainerChangable = new System.Windows.Forms.CheckBox();
            this.numContainerVolume = new System.Windows.Forms.NumericUpDown();
            this.label108 = new System.Windows.Forms.Label();
            this.tabPageDrug = new System.Windows.Forms.TabPage();
            this.tabControlDrug = new System.Windows.Forms.TabControl();
            this.DrugMain = new System.Windows.Forms.TabPage();
            this.tabPageDoor = new System.Windows.Forms.TabPage();
            this.tabControlDoor = new System.Windows.Forms.TabControl();
            this.DoorMain = new System.Windows.Forms.TabPage();
            this.chkDoorNoBlockShoot = new System.Windows.Forms.CheckBox();
            this.chkDoorNoBlockLight = new System.Windows.Forms.CheckBox();
            this.chkDoorNoBlockMove = new System.Windows.Forms.CheckBox();
            this.tabPageGeneric = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.GenericMain = new System.Windows.Forms.TabPage();
            this.tabPageGrid = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpGridType = new System.Windows.Forms.GroupBox();
            this.rdbNone = new System.Windows.Forms.RadioButton();
            this.rdbExitGrid = new System.Windows.Forms.RadioButton();
            this.rdbStairs = new System.Windows.Forms.RadioButton();
            this.rdbLadderBottom = new System.Windows.Forms.RadioButton();
            this.rdbLadderTop = new System.Windows.Forms.RadioButton();
            this.rdbElevator = new System.Windows.Forms.RadioButton();
            this.tabPageKey = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.KeyMain = new System.Windows.Forms.TabPage();
            this.tabPageMisc = new System.Windows.Forms.TabPage();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.MiscMain = new System.Windows.Forms.TabPage();
            this.tabPageWall = new System.Windows.Forms.TabPage();
            this.tabControl6 = new System.Windows.Forms.TabControl();
            this.WallMain = new System.Windows.Forms.TabPage();
            this.tabPageWeapon = new System.Windows.Forms.TabPage();
            this.tabControlWeapon = new System.Windows.Forms.TabControl();
            this.WeaponMain = new System.Windows.Forms.TabPage();
            this.grpUnarmed = new System.Windows.Forms.GroupBox();
            this.numUnarmedCriticalBonus = new System.Windows.Forms.NumericUpDown();
            this.label86 = new System.Windows.Forms.Label();
            this.chkArmorPiercing = new System.Windows.Forms.CheckBox();
            this.label85 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.numMinLevel = new System.Windows.Forms.NumericUpDown();
            this.numMinUnarmed = new System.Windows.Forms.NumericUpDown();
            this.numMinAgility = new System.Windows.Forms.NumericUpDown();
            this.label83 = new System.Windows.Forms.Label();
            this.numUnarmedPriority = new System.Windows.Forms.NumericUpDown();
            this.label82 = new System.Windows.Forms.Label();
            this.numUnarmedTree = new System.Windows.Forms.NumericUpDown();
            this.label81 = new System.Windows.Forms.Label();
            this.chkIsUnarmed = new System.Windows.Forms.CheckBox();
            this.numMinStrength = new System.Windows.Forms.NumericUpDown();
            this.label80 = new System.Windows.Forms.Label();
            this.cmdWeaponDefaultAmmo = new System.Windows.Forms.ComboBox();
            this.label79 = new System.Windows.Forms.Label();
            this.cmbCaliberWeapon = new System.Windows.Forms.ComboBox();
            this.label78 = new System.Windows.Forms.Label();
            this.numMaxAmmoCount = new System.Windows.Forms.NumericUpDown();
            this.label77 = new System.Windows.Forms.Label();
            this.cmbAnim1 = new System.Windows.Forms.ComboBox();
            this.cmbWeaponPerk = new System.Windows.Forms.ComboBox();
            this.label76 = new System.Windows.Forms.Label();
            this.numCriticalFailure = new System.Windows.Forms.NumericUpDown();
            this.label75 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.WeaponAttack1 = new System.Windows.Forms.TabPage();
            this.numWeaponFlyEffect1 = new System.Windows.Forms.NumericUpDown();
            this.numWeaponDmgMax1 = new System.Windows.Forms.NumericUpDown();
            this.numWeaponDmgMin1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkWeaponRemove1 = new System.Windows.Forms.CheckBox();
            this.cmbDmgType1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbWeaponAnim2_1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.txtUseGraphics1 = new System.Windows.Forms.TextBox();
            this.label98 = new System.Windows.Forms.Label();
            this.txtSoundId1 = new System.Windows.Forms.TextBox();
            this.label95 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.numBulletsRound1 = new System.Windows.Forms.NumericUpDown();
            this.numDistance1 = new System.Windows.Forms.NumericUpDown();
            this.numAttackAP1 = new System.Windows.Forms.NumericUpDown();
            this.label91 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.chkAimAvailable1 = new System.Windows.Forms.CheckBox();
            this.label88 = new System.Windows.Forms.Label();
            this.cmbWeaponSkill1 = new System.Windows.Forms.ComboBox();
            this.chkActive1 = new System.Windows.Forms.CheckBox();
            this.WeaponAttack2 = new System.Windows.Forms.TabPage();
            this.numWeaponFlyEffect2 = new System.Windows.Forms.NumericUpDown();
            this.numWeaponDmgMax2 = new System.Windows.Forms.NumericUpDown();
            this.numWeaponDmgMin2 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.chkWeaponRemove2 = new System.Windows.Forms.CheckBox();
            this.cmbDmgType2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbWeaponAnim2_2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUseGraphics2 = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.txtSoundId2 = new System.Windows.Forms.TextBox();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.numBulletsRound2 = new System.Windows.Forms.NumericUpDown();
            this.numDistance2 = new System.Windows.Forms.NumericUpDown();
            this.numAttackAP2 = new System.Windows.Forms.NumericUpDown();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.chkAimAvailable2 = new System.Windows.Forms.CheckBox();
            this.label101 = new System.Windows.Forms.Label();
            this.cmbWeaponSkill2 = new System.Windows.Forms.ComboBox();
            this.chkActive2 = new System.Windows.Forms.CheckBox();
            this.label100 = new System.Windows.Forms.Label();
            this.WeaponAttack3 = new System.Windows.Forms.TabPage();
            this.numWeaponFlyEffect3 = new System.Windows.Forms.NumericUpDown();
            this.numWeaponDmgMax3 = new System.Windows.Forms.NumericUpDown();
            this.numWeaponDmgMin3 = new System.Windows.Forms.NumericUpDown();
            this.label110 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.chkWeaponRemove3 = new System.Windows.Forms.CheckBox();
            this.cmbDmgType3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbWeaponAnim2_3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUseGraphics3 = new System.Windows.Forms.TextBox();
            this.label102 = new System.Windows.Forms.Label();
            this.txtSoundId3 = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.numBulletsRound3 = new System.Windows.Forms.NumericUpDown();
            this.numDistance3 = new System.Windows.Forms.NumericUpDown();
            this.numAttackAP3 = new System.Windows.Forms.NumericUpDown();
            this.label105 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.chkAimAvailable3 = new System.Windows.Forms.CheckBox();
            this.label107 = new System.Windows.Forms.Label();
            this.cmbWeaponSkill3 = new System.Windows.Forms.ComboBox();
            this.chkActive3 = new System.Windows.Forms.CheckBox();
            this.label112 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFilteredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveListToRespectiveFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSingleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.unloadAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloneSelectedObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutObjectEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundResources = new System.ComponentModel.BackgroundWorker();
            this.panelMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.grpGeneralObjectInfo.SuspendLayout();
            this.tabGeneralInfo.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPID)).BeginInit();
            this.tabGraphics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstProtos)).BeginInit();
            this.tabPageExt.SuspendLayout();
            this.grpExtInfoColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColorAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColorBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColorGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColorRed)).BeginInit();
            this.grpExtInfoIndicator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndicatorMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndicatorStart)).BeginInit();
            this.grpExtInfoMaterial.SuspendLayout();
            this.grpExtInfoCorner.SuspendLayout();
            this.grpExtInfoEgg.SuspendLayout();
            this.grpExtInfoLight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLightDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLightIntensity)).BeginInit();
            this.grpExtInfoMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            this.tabPageExt2.SuspendLayout();
            this.grpSpriteCutting.SuspendLayout();
            this.grpAnimation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimHide1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimHide0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimShow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimShow0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimStay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimStay0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimWaitMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimWaitMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimWaitBase)).BeginInit();
            this.grpDrawOrderOffset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawOrderOffsetHexY)).BeginInit();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawOffsetsY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawOffsetsX)).BeginInit();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHolodiskNum)).BeginInit();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoundId)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSlot)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRadioBroadcastReceive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadioBroadcastSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadioChannel)).BeginInit();
            this.grpScript.SuspendLayout();
            this.tabPageExt3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChildPid5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildPid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildPid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildPid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildPid1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpInitialCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartCount)).BeginInit();
            this.panelProperties.SuspendLayout();
            this.tabPageArmor.SuspendLayout();
            this.tabControlArmor.SuspendLayout();
            this.ArmorMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCrTypeFemale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrTypeMale)).BeginInit();
            this.tabPageAmmo.SuspendLayout();
            this.tabControlAmmo.SuspendLayout();
            this.AmmoMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAcMod)).BeginInit();
            this.tabPageCar.SuspendLayout();
            this.tabControlCar.SuspendLayout();
            this.CarMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCarEntrance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarCritterCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarPassability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarFuelConsumption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarTankVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarMaxDeterioration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarDeteriorationRate)).BeginInit();
            this.grpCarMovementType.SuspendLayout();
            this.tabPageContainer.SuspendLayout();
            this.tabControlContainer.SuspendLayout();
            this.ContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numContainerVolume)).BeginInit();
            this.tabPageDrug.SuspendLayout();
            this.tabControlDrug.SuspendLayout();
            this.tabPageDoor.SuspendLayout();
            this.tabControlDoor.SuspendLayout();
            this.DoorMain.SuspendLayout();
            this.tabPageGeneric.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPageGrid.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpGridType.SuspendLayout();
            this.tabPageKey.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPageMisc.SuspendLayout();
            this.tabControl5.SuspendLayout();
            this.tabPageWall.SuspendLayout();
            this.tabControl6.SuspendLayout();
            this.tabPageWeapon.SuspendLayout();
            this.tabControlWeapon.SuspendLayout();
            this.WeaponMain.SuspendLayout();
            this.grpUnarmed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnarmedCriticalBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinUnarmed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinAgility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnarmedPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnarmedTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAmmoCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCriticalFailure)).BeginInit();
            this.WeaponAttack1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeaponFlyEffect1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeaponDmgMax1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeaponDmgMin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBulletsRound1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackAP1)).BeginInit();
            this.WeaponAttack2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeaponFlyEffect2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeaponDmgMax2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeaponDmgMin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBulletsRound2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackAP2)).BeginInit();
            this.WeaponAttack3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeaponFlyEffect3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeaponDmgMax3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeaponDmgMin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBulletsRound3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackAP3)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.tabPageMain);
            this.panelMain.Controls.Add(this.tabPageExt);
            this.panelMain.Controls.Add(this.tabPageExt2);
            this.panelMain.Controls.Add(this.tabPageExt3);
            this.panelMain.Location = new System.Drawing.Point(12, 27);
            this.panelMain.Name = "panelMain";
            this.panelMain.SelectedIndex = 0;
            this.panelMain.Size = new System.Drawing.Size(784, 336);
            this.panelMain.TabIndex = 1;
            this.panelMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.panelMain_Selecting);
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.btnSearch);
            this.tabPageMain.Controls.Add(this.txtSearch);
            this.tabPageMain.Controls.Add(this.pnlFilterButtons);
            this.tabPageMain.Controls.Add(this.chkFilter);
            this.tabPageMain.Controls.Add(this.btnSetFilter);
            this.tabPageMain.Controls.Add(this.grpGeneralObjectInfo);
            this.tabPageMain.Controls.Add(this.lstProtos);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(776, 310);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main Info";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(350, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(7, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(337, 20);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // pnlFilterButtons
            // 
            this.pnlFilterButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilterButtons.Location = new System.Drawing.Point(437, 55);
            this.pnlFilterButtons.Name = "pnlFilterButtons";
            this.pnlFilterButtons.Size = new System.Drawing.Size(92, 248);
            this.pnlFilterButtons.TabIndex = 3;
            // 
            // chkFilter
            // 
            this.chkFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFilter.AutoSize = true;
            this.chkFilter.Location = new System.Drawing.Point(437, 32);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(48, 17);
            this.chkFilter.TabIndex = 2;
            this.chkFilter.Text = "Filter";
            this.chkFilter.UseVisualStyleBackColor = true;
            this.chkFilter.CheckedChanged += new System.EventHandler(this.chkFilter_CheckedChanged);
            // 
            // btnSetFilter
            // 
            this.btnSetFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnSetFilter.Image")));
            this.btnSetFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetFilter.Location = new System.Drawing.Point(437, 3);
            this.btnSetFilter.Name = "btnSetFilter";
            this.btnSetFilter.Size = new System.Drawing.Size(67, 23);
            this.btnSetFilter.TabIndex = 1;
            this.btnSetFilter.Text = "Filter";
            this.btnSetFilter.UseVisualStyleBackColor = true;
            this.btnSetFilter.Click += new System.EventHandler(this.btnSetFilter_Click);
            // 
            // grpGeneralObjectInfo
            // 
            this.grpGeneralObjectInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGeneralObjectInfo.Controls.Add(this.tabGeneralInfo);
            this.grpGeneralObjectInfo.Location = new System.Drawing.Point(535, 6);
            this.grpGeneralObjectInfo.Name = "grpGeneralObjectInfo";
            this.grpGeneralObjectInfo.Size = new System.Drawing.Size(233, 297);
            this.grpGeneralObjectInfo.TabIndex = 7;
            this.grpGeneralObjectInfo.TabStop = false;
            this.grpGeneralObjectInfo.Text = "General Object Information";
            // 
            // tabGeneralInfo
            // 
            this.tabGeneralInfo.Controls.Add(this.tabGeneral);
            this.tabGeneralInfo.Controls.Add(this.tabGraphics);
            this.tabGeneralInfo.Location = new System.Drawing.Point(9, 19);
            this.tabGeneralInfo.Name = "tabGeneralInfo";
            this.tabGeneralInfo.SelectedIndex = 0;
            this.tabGeneralInfo.Size = new System.Drawing.Size(218, 272);
            this.tabGeneralInfo.TabIndex = 12;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.txtProtoFileName);
            this.tabGeneral.Controls.Add(this.lblProtoFileName);
            this.tabGeneral.Controls.Add(this.numPID);
            this.tabGeneral.Controls.Add(this.cmbType);
            this.tabGeneral.Controls.Add(this.label54);
            this.tabGeneral.Controls.Add(this.txtName);
            this.tabGeneral.Controls.Add(this.label17);
            this.tabGeneral.Controls.Add(this.label14);
            this.tabGeneral.Controls.Add(this.txtDescription);
            this.tabGeneral.Controls.Add(this.lblDescription);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(210, 246);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "Main";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // txtProtoFileName
            // 
            this.txtProtoFileName.Location = new System.Drawing.Point(6, 206);
            this.txtProtoFileName.Name = "txtProtoFileName";
            this.txtProtoFileName.Size = new System.Drawing.Size(189, 20);
            this.txtProtoFileName.TabIndex = 25;
            // 
            // lblProtoFileName
            // 
            this.lblProtoFileName.AutoSize = true;
            this.lblProtoFileName.Location = new System.Drawing.Point(3, 189);
            this.lblProtoFileName.Name = "lblProtoFileName";
            this.lblProtoFileName.Size = new System.Drawing.Size(77, 13);
            this.lblProtoFileName.TabIndex = 33;
            this.lblProtoFileName.Text = "Proto Filename";
            // 
            // numPID
            // 
            this.numPID.Location = new System.Drawing.Point(34, 6);
            this.numPID.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numPID.Name = "numPID";
            this.numPID.Size = new System.Drawing.Size(63, 20);
            this.numPID.TabIndex = 20;
            this.numPID.ValueChanged += new System.EventHandler(this.numPID_ValueChanged);
            // 
            // cmbType
            // 
            this.cmbType.DropDownHeight = 300;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.DropDownWidth = 200;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.IntegralHeight = false;
            this.cmbType.Location = new System.Drawing.Point(128, 5);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(67, 21);
            this.cmbType.Sorted = true;
            this.cmbType.TabIndex = 21;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(96, 9);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(31, 13);
            this.label54.TabIndex = 32;
            this.label54.Text = "Type";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 20);
            this.txtName.TabIndex = 22;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "PID";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 79);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(189, 107);
            this.txtDescription.TabIndex = 24;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 63);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 30;
            this.lblDescription.Text = "Description";
            // 
            // tabGraphics
            // 
            this.tabGraphics.Controls.Add(this.btnSelectInventory);
            this.tabGraphics.Controls.Add(this.btnSelectGround);
            this.tabGraphics.Controls.Add(this.pctInventory);
            this.tabGraphics.Controls.Add(this.pctGround);
            this.tabGraphics.Controls.Add(this.txtInvPic);
            this.tabGraphics.Controls.Add(this.txtGroundPic);
            this.tabGraphics.Controls.Add(this.label16);
            this.tabGraphics.Controls.Add(this.label15);
            this.tabGraphics.Location = new System.Drawing.Point(4, 22);
            this.tabGraphics.Name = "tabGraphics";
            this.tabGraphics.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraphics.Size = new System.Drawing.Size(210, 246);
            this.tabGraphics.TabIndex = 1;
            this.tabGraphics.Text = "Graphics";
            this.tabGraphics.UseVisualStyleBackColor = true;
            // 
            // btnSelectInventory
            // 
            this.btnSelectInventory.Enabled = false;
            this.btnSelectInventory.Location = new System.Drawing.Point(179, 151);
            this.btnSelectInventory.Name = "btnSelectInventory";
            this.btnSelectInventory.Size = new System.Drawing.Size(25, 20);
            this.btnSelectInventory.TabIndex = 37;
            this.btnSelectInventory.Text = "...";
            this.btnSelectInventory.UseVisualStyleBackColor = true;
            this.btnSelectInventory.Click += new System.EventHandler(this.btnSelectInventory_Click);
            // 
            // btnSelectGround
            // 
            this.btnSelectGround.Enabled = false;
            this.btnSelectGround.Location = new System.Drawing.Point(179, 24);
            this.btnSelectGround.Name = "btnSelectGround";
            this.btnSelectGround.Size = new System.Drawing.Size(25, 20);
            this.btnSelectGround.TabIndex = 36;
            this.btnSelectGround.Text = "...";
            this.btnSelectGround.UseVisualStyleBackColor = true;
            this.btnSelectGround.Click += new System.EventHandler(this.btnSelectGround_Click);
            // 
            // pctInventory
            // 
            this.pctInventory.Location = new System.Drawing.Point(9, 179);
            this.pctInventory.Name = "pctInventory";
            this.pctInventory.Size = new System.Drawing.Size(84, 58);
            this.pctInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctInventory.TabIndex = 35;
            this.pctInventory.TabStop = false;
            // 
            // pctGround
            // 
            this.pctGround.BackColor = System.Drawing.Color.Transparent;
            this.pctGround.InitialImage = null;
            this.pctGround.Location = new System.Drawing.Point(9, 51);
            this.pctGround.Name = "pctGround";
            this.pctGround.Size = new System.Drawing.Size(84, 63);
            this.pctGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctGround.TabIndex = 34;
            this.pctGround.TabStop = false;
            // 
            // txtInvPic
            // 
            this.txtInvPic.Location = new System.Drawing.Point(9, 151);
            this.txtInvPic.Name = "txtInvPic";
            this.txtInvPic.Size = new System.Drawing.Size(166, 20);
            this.txtInvPic.TabIndex = 33;
            this.txtInvPic.TextChanged += new System.EventHandler(this.txtInvPic_TextChanged);
            // 
            // txtGroundPic
            // 
            this.txtGroundPic.Location = new System.Drawing.Point(9, 24);
            this.txtGroundPic.Name = "txtGroundPic";
            this.txtGroundPic.Size = new System.Drawing.Size(166, 20);
            this.txtGroundPic.TabIndex = 30;
            this.txtGroundPic.TextChanged += new System.EventHandler(this.txtGroundPic_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Inventory Picture";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Ground Picture";
            // 
            // lstProtos
            // 
            this.lstProtos.AllColumns.Add(this.olvName);
            this.lstProtos.AllColumns.Add(this.olvPID);
            this.lstProtos.AllColumns.Add(this.olvType);
            this.lstProtos.AllColumns.Add(this.olvCost);
            this.lstProtos.AllColumns.Add(this.olvScript);
            this.lstProtos.AllColumns.Add(this.olvScriptFunc);
            this.lstProtos.AllColumns.Add(this.olvFile);
            this.lstProtos.AllowColumnReorder = true;
            this.lstProtos.AlternateRowBackColor = System.Drawing.Color.WhiteSmoke;
            this.lstProtos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvName,
            this.olvPID,
            this.olvType,
            this.olvCost,
            this.olvScript,
            this.olvScriptFunc,
            this.olvFile});
            this.lstProtos.FullRowSelect = true;
            this.lstProtos.GridLines = true;
            this.lstProtos.HideSelection = false;
            this.lstProtos.Location = new System.Drawing.Point(6, 32);
            this.lstProtos.Name = "lstProtos";
            this.lstProtos.OwnerDraw = true;
            this.lstProtos.ShowGroups = false;
            this.lstProtos.Size = new System.Drawing.Size(425, 272);
            this.lstProtos.TabIndex = 0;
            this.lstProtos.TintSortColumn = true;
            this.lstProtos.UnfocusedHighlightBackgroundColor = System.Drawing.Color.RoyalBlue;
            this.lstProtos.UnfocusedHighlightForegroundColor = System.Drawing.Color.White;
            this.lstProtos.UseAlternatingBackColors = true;
            this.lstProtos.UseCompatibleStateImageBehavior = false;
            this.lstProtos.UseCustomSelectionColors = true;
            this.lstProtos.UseFiltering = true;
            this.lstProtos.View = System.Windows.Forms.View.Details;
            this.lstProtos.VirtualMode = true;
            this.lstProtos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstProtos_MouseDoubleClick);
            // 
            // olvName
            // 
            this.olvName.AspectName = "Name";
            this.olvName.DisplayIndex = 1;
            this.olvName.Text = "Name";
            this.olvName.Width = 160;
            // 
            // olvPID
            // 
            this.olvPID.AspectName = "ProtoId";
            this.olvPID.DisplayIndex = 0;
            this.olvPID.Text = "PID";
            this.olvPID.Width = 40;
            // 
            // olvType
            // 
            this.olvType.AspectName = "Type";
            this.olvType.IsEditable = false;
            this.olvType.Text = "Type";
            this.olvType.Width = 100;
            // 
            // olvCost
            // 
            this.olvCost.AspectName = "Cost";
            this.olvCost.Text = "Cost";
            // 
            // olvScript
            // 
            this.olvScript.AspectName = "ScriptModule";
            this.olvScript.Text = "Script Module";
            this.olvScript.Width = 100;
            // 
            // olvScriptFunc
            // 
            this.olvScriptFunc.AspectName = "ScriptFunction";
            this.olvScriptFunc.Text = "Script Function";
            // 
            // olvFile
            // 
            this.olvFile.AspectName = "FileName";
            this.olvFile.Text = "File";
            // 
            // tabPageExt
            // 
            this.tabPageExt.Controls.Add(this.grpExtInfoFlags);
            this.tabPageExt.Controls.Add(this.grpExtInfoColor);
            this.tabPageExt.Controls.Add(this.grpExtInfoIndicator);
            this.tabPageExt.Controls.Add(this.grpExtInfoMaterial);
            this.tabPageExt.Controls.Add(this.grpExtInfoCorner);
            this.tabPageExt.Controls.Add(this.grpExtInfoEgg);
            this.tabPageExt.Controls.Add(this.grpExtInfoLight);
            this.tabPageExt.Controls.Add(this.grpExtInfoMain);
            this.tabPageExt.Location = new System.Drawing.Point(4, 22);
            this.tabPageExt.Name = "tabPageExt";
            this.tabPageExt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExt.Size = new System.Drawing.Size(776, 310);
            this.tabPageExt.TabIndex = 1;
            this.tabPageExt.Text = "Ext Info";
            this.tabPageExt.UseVisualStyleBackColor = true;
            // 
            // grpExtInfoFlags
            // 
            this.grpExtInfoFlags.Location = new System.Drawing.Point(505, 6);
            this.grpExtInfoFlags.Name = "grpExtInfoFlags";
            this.grpExtInfoFlags.Size = new System.Drawing.Size(262, 297);
            this.grpExtInfoFlags.TabIndex = 9;
            this.grpExtInfoFlags.TabStop = false;
            this.grpExtInfoFlags.Text = "Flags (see Flags.cfg)";
            // 
            // grpExtInfoColor
            // 
            this.grpExtInfoColor.Controls.Add(this.label23);
            this.grpExtInfoColor.Controls.Add(this.numColorAlpha);
            this.grpExtInfoColor.Controls.Add(this.label24);
            this.grpExtInfoColor.Controls.Add(this.numColorBlue);
            this.grpExtInfoColor.Controls.Add(this.label22);
            this.grpExtInfoColor.Controls.Add(this.numColorGreen);
            this.grpExtInfoColor.Controls.Add(this.label21);
            this.grpExtInfoColor.Controls.Add(this.numColorRed);
            this.grpExtInfoColor.Controls.Add(this.chkColorFlagColorizeInventory);
            this.grpExtInfoColor.Controls.Add(this.chkColorFlagColorize);
            this.grpExtInfoColor.Location = new System.Drawing.Point(6, 147);
            this.grpExtInfoColor.Name = "grpExtInfoColor";
            this.grpExtInfoColor.Size = new System.Drawing.Size(122, 156);
            this.grpExtInfoColor.TabIndex = 6;
            this.grpExtInfoColor.TabStop = false;
            this.grpExtInfoColor.Text = "Color (0..255)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 115);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 14;
            this.label23.Text = "Alpha";
            // 
            // numColorAlpha
            // 
            this.numColorAlpha.Location = new System.Drawing.Point(48, 113);
            this.numColorAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numColorAlpha.Name = "numColorAlpha";
            this.numColorAlpha.Size = new System.Drawing.Size(53, 20);
            this.numColorAlpha.TabIndex = 13;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 96);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(28, 13);
            this.label24.TabIndex = 12;
            this.label24.Text = "Blue";
            // 
            // numColorBlue
            // 
            this.numColorBlue.Location = new System.Drawing.Point(48, 94);
            this.numColorBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numColorBlue.Name = "numColorBlue";
            this.numColorBlue.Size = new System.Drawing.Size(53, 20);
            this.numColorBlue.TabIndex = 11;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "Green";
            // 
            // numColorGreen
            // 
            this.numColorGreen.Location = new System.Drawing.Point(48, 76);
            this.numColorGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numColorGreen.Name = "numColorGreen";
            this.numColorGreen.Size = new System.Drawing.Size(53, 20);
            this.numColorGreen.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 59);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Red";
            // 
            // numColorRed
            // 
            this.numColorRed.Location = new System.Drawing.Point(48, 58);
            this.numColorRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numColorRed.Name = "numColorRed";
            this.numColorRed.Size = new System.Drawing.Size(53, 20);
            this.numColorRed.TabIndex = 5;
            // 
            // chkColorFlagColorizeInventory
            // 
            this.chkColorFlagColorizeInventory.AutoSize = true;
            this.chkColorFlagColorizeInventory.Location = new System.Drawing.Point(6, 36);
            this.chkColorFlagColorizeInventory.Name = "chkColorFlagColorizeInventory";
            this.chkColorFlagColorizeInventory.Size = new System.Drawing.Size(110, 17);
            this.chkColorFlagColorizeInventory.TabIndex = 1;
            this.chkColorFlagColorizeInventory.Text = "Colorize Inventory";
            this.chkColorFlagColorizeInventory.UseVisualStyleBackColor = true;
            // 
            // chkColorFlagColorize
            // 
            this.chkColorFlagColorize.AutoSize = true;
            this.chkColorFlagColorize.Location = new System.Drawing.Point(6, 19);
            this.chkColorFlagColorize.Name = "chkColorFlagColorize";
            this.chkColorFlagColorize.Size = new System.Drawing.Size(63, 17);
            this.chkColorFlagColorize.TabIndex = 0;
            this.chkColorFlagColorize.Text = "Colorize";
            this.chkColorFlagColorize.UseVisualStyleBackColor = true;
            // 
            // grpExtInfoIndicator
            // 
            this.grpExtInfoIndicator.Controls.Add(this.label27);
            this.grpExtInfoIndicator.Controls.Add(this.label26);
            this.grpExtInfoIndicator.Controls.Add(this.numIndicatorMax);
            this.grpExtInfoIndicator.Controls.Add(this.label25);
            this.grpExtInfoIndicator.Controls.Add(this.numIndicatorStart);
            this.grpExtInfoIndicator.Location = new System.Drawing.Point(332, 6);
            this.grpExtInfoIndicator.Name = "grpExtInfoIndicator";
            this.grpExtInfoIndicator.Size = new System.Drawing.Size(166, 84);
            this.grpExtInfoIndicator.TabIndex = 5;
            this.grpExtInfoIndicator.TabStop = false;
            this.grpExtInfoIndicator.Text = "Indicator";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 60);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(121, 13);
            this.label27.TabIndex = 8;
            this.label27.Text = "Activated when max !=0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 39);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(27, 13);
            this.label26.TabIndex = 7;
            this.label26.Text = "Max";
            // 
            // numIndicatorMax
            // 
            this.numIndicatorMax.Location = new System.Drawing.Point(50, 37);
            this.numIndicatorMax.Name = "numIndicatorMax";
            this.numIndicatorMax.Size = new System.Drawing.Size(46, 20);
            this.numIndicatorMax.TabIndex = 6;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 21);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 13);
            this.label25.TabIndex = 5;
            this.label25.Text = "Start";
            // 
            // numIndicatorStart
            // 
            this.numIndicatorStart.Location = new System.Drawing.Point(50, 19);
            this.numIndicatorStart.Name = "numIndicatorStart";
            this.numIndicatorStart.Size = new System.Drawing.Size(46, 20);
            this.numIndicatorStart.TabIndex = 5;
            // 
            // grpExtInfoMaterial
            // 
            this.grpExtInfoMaterial.Controls.Add(this.rdbMaterialGlass);
            this.grpExtInfoMaterial.Controls.Add(this.rdbMaterialMetal);
            this.grpExtInfoMaterial.Controls.Add(this.rdbMaterialPlastic);
            this.grpExtInfoMaterial.Controls.Add(this.rdbMaterialWood);
            this.grpExtInfoMaterial.Controls.Add(this.rdbMaterialDirt);
            this.grpExtInfoMaterial.Controls.Add(this.rdbMaterialStone);
            this.grpExtInfoMaterial.Controls.Add(this.rdbMaterialCement);
            this.grpExtInfoMaterial.Controls.Add(this.rdbMaterialLeather);
            this.grpExtInfoMaterial.Location = new System.Drawing.Point(332, 96);
            this.grpExtInfoMaterial.Name = "grpExtInfoMaterial";
            this.grpExtInfoMaterial.Size = new System.Drawing.Size(166, 94);
            this.grpExtInfoMaterial.TabIndex = 4;
            this.grpExtInfoMaterial.TabStop = false;
            this.grpExtInfoMaterial.Text = "Material";
            // 
            // rdbMaterialGlass
            // 
            this.rdbMaterialGlass.AutoSize = true;
            this.rdbMaterialGlass.Location = new System.Drawing.Point(6, 19);
            this.rdbMaterialGlass.Name = "rdbMaterialGlass";
            this.rdbMaterialGlass.Size = new System.Drawing.Size(51, 17);
            this.rdbMaterialGlass.TabIndex = 0;
            this.rdbMaterialGlass.TabStop = true;
            this.rdbMaterialGlass.Text = "Glass";
            this.rdbMaterialGlass.UseVisualStyleBackColor = true;
            // 
            // rdbMaterialMetal
            // 
            this.rdbMaterialMetal.AutoSize = true;
            this.rdbMaterialMetal.Location = new System.Drawing.Point(6, 35);
            this.rdbMaterialMetal.Name = "rdbMaterialMetal";
            this.rdbMaterialMetal.Size = new System.Drawing.Size(51, 17);
            this.rdbMaterialMetal.TabIndex = 1;
            this.rdbMaterialMetal.TabStop = true;
            this.rdbMaterialMetal.Text = "Metal";
            this.rdbMaterialMetal.UseVisualStyleBackColor = true;
            // 
            // rdbMaterialPlastic
            // 
            this.rdbMaterialPlastic.AutoSize = true;
            this.rdbMaterialPlastic.Location = new System.Drawing.Point(6, 52);
            this.rdbMaterialPlastic.Name = "rdbMaterialPlastic";
            this.rdbMaterialPlastic.Size = new System.Drawing.Size(56, 17);
            this.rdbMaterialPlastic.TabIndex = 2;
            this.rdbMaterialPlastic.TabStop = true;
            this.rdbMaterialPlastic.Text = "Plastic";
            this.rdbMaterialPlastic.UseVisualStyleBackColor = true;
            // 
            // rdbMaterialWood
            // 
            this.rdbMaterialWood.AutoSize = true;
            this.rdbMaterialWood.Location = new System.Drawing.Point(6, 68);
            this.rdbMaterialWood.Name = "rdbMaterialWood";
            this.rdbMaterialWood.Size = new System.Drawing.Size(54, 17);
            this.rdbMaterialWood.TabIndex = 3;
            this.rdbMaterialWood.TabStop = true;
            this.rdbMaterialWood.Text = "Wood";
            this.rdbMaterialWood.UseVisualStyleBackColor = true;
            // 
            // rdbMaterialDirt
            // 
            this.rdbMaterialDirt.AutoSize = true;
            this.rdbMaterialDirt.Location = new System.Drawing.Point(63, 19);
            this.rdbMaterialDirt.Name = "rdbMaterialDirt";
            this.rdbMaterialDirt.Size = new System.Drawing.Size(41, 17);
            this.rdbMaterialDirt.TabIndex = 4;
            this.rdbMaterialDirt.TabStop = true;
            this.rdbMaterialDirt.Text = "Dirt";
            this.rdbMaterialDirt.UseVisualStyleBackColor = true;
            // 
            // rdbMaterialStone
            // 
            this.rdbMaterialStone.AutoSize = true;
            this.rdbMaterialStone.Location = new System.Drawing.Point(63, 35);
            this.rdbMaterialStone.Name = "rdbMaterialStone";
            this.rdbMaterialStone.Size = new System.Drawing.Size(53, 17);
            this.rdbMaterialStone.TabIndex = 5;
            this.rdbMaterialStone.TabStop = true;
            this.rdbMaterialStone.Text = "Stone";
            this.rdbMaterialStone.UseVisualStyleBackColor = true;
            // 
            // rdbMaterialCement
            // 
            this.rdbMaterialCement.AutoSize = true;
            this.rdbMaterialCement.Location = new System.Drawing.Point(63, 52);
            this.rdbMaterialCement.Name = "rdbMaterialCement";
            this.rdbMaterialCement.Size = new System.Drawing.Size(61, 17);
            this.rdbMaterialCement.TabIndex = 6;
            this.rdbMaterialCement.TabStop = true;
            this.rdbMaterialCement.Text = "Cement";
            this.rdbMaterialCement.UseVisualStyleBackColor = true;
            // 
            // rdbMaterialLeather
            // 
            this.rdbMaterialLeather.AutoSize = true;
            this.rdbMaterialLeather.Location = new System.Drawing.Point(63, 68);
            this.rdbMaterialLeather.Name = "rdbMaterialLeather";
            this.rdbMaterialLeather.Size = new System.Drawing.Size(61, 17);
            this.rdbMaterialLeather.TabIndex = 7;
            this.rdbMaterialLeather.TabStop = true;
            this.rdbMaterialLeather.Text = "Leather";
            this.rdbMaterialLeather.UseVisualStyleBackColor = true;
            // 
            // grpExtInfoCorner
            // 
            this.grpExtInfoCorner.Controls.Add(this.rdbCornerSouth);
            this.grpExtInfoCorner.Controls.Add(this.rdbCornerEast);
            this.grpExtInfoCorner.Controls.Add(this.rdbCornerWest);
            this.grpExtInfoCorner.Controls.Add(this.rdbCornerNorth);
            this.grpExtInfoCorner.Controls.Add(this.rdbCornerWestEast);
            this.grpExtInfoCorner.Controls.Add(this.rdbCornerNorthSouth);
            this.grpExtInfoCorner.Location = new System.Drawing.Point(197, 7);
            this.grpExtInfoCorner.Name = "grpExtInfoCorner";
            this.grpExtInfoCorner.Size = new System.Drawing.Size(128, 134);
            this.grpExtInfoCorner.TabIndex = 3;
            this.grpExtInfoCorner.TabStop = false;
            this.grpExtInfoCorner.Text = "Corner";
            // 
            // rdbCornerSouth
            // 
            this.rdbCornerSouth.AutoSize = true;
            this.rdbCornerSouth.Location = new System.Drawing.Point(6, 93);
            this.rdbCornerSouth.Name = "rdbCornerSouth";
            this.rdbCornerSouth.Size = new System.Drawing.Size(53, 17);
            this.rdbCornerSouth.TabIndex = 5;
            this.rdbCornerSouth.TabStop = true;
            this.rdbCornerSouth.Text = "South";
            this.rdbCornerSouth.UseVisualStyleBackColor = true;
            // 
            // rdbCornerEast
            // 
            this.rdbCornerEast.AutoSize = true;
            this.rdbCornerEast.Location = new System.Drawing.Point(6, 78);
            this.rdbCornerEast.Name = "rdbCornerEast";
            this.rdbCornerEast.Size = new System.Drawing.Size(46, 17);
            this.rdbCornerEast.TabIndex = 4;
            this.rdbCornerEast.TabStop = true;
            this.rdbCornerEast.Text = "East";
            this.rdbCornerEast.UseVisualStyleBackColor = true;
            // 
            // rdbCornerWest
            // 
            this.rdbCornerWest.AutoSize = true;
            this.rdbCornerWest.Location = new System.Drawing.Point(6, 63);
            this.rdbCornerWest.Name = "rdbCornerWest";
            this.rdbCornerWest.Size = new System.Drawing.Size(50, 17);
            this.rdbCornerWest.TabIndex = 3;
            this.rdbCornerWest.TabStop = true;
            this.rdbCornerWest.Text = "West";
            this.rdbCornerWest.UseVisualStyleBackColor = true;
            // 
            // rdbCornerNorth
            // 
            this.rdbCornerNorth.AutoSize = true;
            this.rdbCornerNorth.Location = new System.Drawing.Point(6, 48);
            this.rdbCornerNorth.Name = "rdbCornerNorth";
            this.rdbCornerNorth.Size = new System.Drawing.Size(51, 17);
            this.rdbCornerNorth.TabIndex = 2;
            this.rdbCornerNorth.TabStop = true;
            this.rdbCornerNorth.Text = "North";
            this.rdbCornerNorth.UseVisualStyleBackColor = true;
            // 
            // rdbCornerWestEast
            // 
            this.rdbCornerWestEast.AutoSize = true;
            this.rdbCornerWestEast.Location = new System.Drawing.Point(6, 33);
            this.rdbCornerWestEast.Name = "rdbCornerWestEast";
            this.rdbCornerWestEast.Size = new System.Drawing.Size(76, 17);
            this.rdbCornerWestEast.TabIndex = 1;
            this.rdbCornerWestEast.TabStop = true;
            this.rdbCornerWestEast.Text = "West/East";
            this.rdbCornerWestEast.UseVisualStyleBackColor = true;
            // 
            // rdbCornerNorthSouth
            // 
            this.rdbCornerNorthSouth.AutoSize = true;
            this.rdbCornerNorthSouth.Location = new System.Drawing.Point(6, 18);
            this.rdbCornerNorthSouth.Name = "rdbCornerNorthSouth";
            this.rdbCornerNorthSouth.Size = new System.Drawing.Size(84, 17);
            this.rdbCornerNorthSouth.TabIndex = 0;
            this.rdbCornerNorthSouth.TabStop = true;
            this.rdbCornerNorthSouth.Text = "North/South";
            this.rdbCornerNorthSouth.UseVisualStyleBackColor = true;
            // 
            // grpExtInfoEgg
            // 
            this.grpExtInfoEgg.Controls.Add(this.chkDisableEgg);
            this.grpExtInfoEgg.Location = new System.Drawing.Point(6, 96);
            this.grpExtInfoEgg.Name = "grpExtInfoEgg";
            this.grpExtInfoEgg.Size = new System.Drawing.Size(177, 45);
            this.grpExtInfoEgg.TabIndex = 2;
            this.grpExtInfoEgg.TabStop = false;
            this.grpExtInfoEgg.Text = "Transparent Egg";
            // 
            // chkDisableEgg
            // 
            this.chkDisableEgg.AutoSize = true;
            this.chkDisableEgg.Location = new System.Drawing.Point(9, 19);
            this.chkDisableEgg.Name = "chkDisableEgg";
            this.chkDisableEgg.Size = new System.Drawing.Size(83, 17);
            this.chkDisableEgg.TabIndex = 0;
            this.chkDisableEgg.Text = "Disable Egg";
            this.chkDisableEgg.UseVisualStyleBackColor = true;
            // 
            // grpExtInfoLight
            // 
            this.grpExtInfoLight.Controls.Add(this.numLightDistance);
            this.grpExtInfoLight.Controls.Add(this.label29);
            this.grpExtInfoLight.Controls.Add(this.numLightIntensity);
            this.grpExtInfoLight.Controls.Add(this.label28);
            this.grpExtInfoLight.Controls.Add(this.chkLightFlagDisableDir5);
            this.grpExtInfoLight.Controls.Add(this.chkLightFlagDisableDir4);
            this.grpExtInfoLight.Controls.Add(this.chkLightFlagDisableDir3);
            this.grpExtInfoLight.Controls.Add(this.chkLightFlagDisableDir2);
            this.grpExtInfoLight.Controls.Add(this.chkLightFlagDisableDir1);
            this.grpExtInfoLight.Controls.Add(this.chkLightFlagDisableDir0);
            this.grpExtInfoLight.Controls.Add(this.chkLightFlagGlobal);
            this.grpExtInfoLight.Controls.Add(this.chkLightFlagInverse);
            this.grpExtInfoLight.Controls.Add(this.chkLight);
            this.grpExtInfoLight.Location = new System.Drawing.Point(134, 147);
            this.grpExtInfoLight.Name = "grpExtInfoLight";
            this.grpExtInfoLight.Size = new System.Drawing.Size(191, 156);
            this.grpExtInfoLight.TabIndex = 1;
            this.grpExtInfoLight.TabStop = false;
            this.grpExtInfoLight.Text = "Light (color taken from Color)";
            // 
            // numLightDistance
            // 
            this.numLightDistance.Location = new System.Drawing.Point(9, 113);
            this.numLightDistance.Name = "numLightDistance";
            this.numLightDistance.Size = new System.Drawing.Size(63, 20);
            this.numLightDistance.TabIndex = 17;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 96);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(49, 13);
            this.label29.TabIndex = 16;
            this.label29.Text = "Distance";
            // 
            // numLightIntensity
            // 
            this.numLightIntensity.Location = new System.Drawing.Point(9, 72);
            this.numLightIntensity.Name = "numLightIntensity";
            this.numLightIntensity.Size = new System.Drawing.Size(63, 20);
            this.numLightIntensity.TabIndex = 15;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 57);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(85, 13);
            this.label28.TabIndex = 9;
            this.label28.Text = "Intensity (0..100)";
            // 
            // chkLightFlagDisableDir5
            // 
            this.chkLightFlagDisableDir5.AutoSize = true;
            this.chkLightFlagDisableDir5.Location = new System.Drawing.Point(91, 135);
            this.chkLightFlagDisableDir5.Name = "chkLightFlagDisableDir5";
            this.chkLightFlagDisableDir5.Size = new System.Drawing.Size(80, 17);
            this.chkLightFlagDisableDir5.TabIndex = 8;
            this.chkLightFlagDisableDir5.Text = "DisableDir5";
            this.chkLightFlagDisableDir5.UseVisualStyleBackColor = true;
            // 
            // chkLightFlagDisableDir4
            // 
            this.chkLightFlagDisableDir4.AutoSize = true;
            this.chkLightFlagDisableDir4.Location = new System.Drawing.Point(91, 119);
            this.chkLightFlagDisableDir4.Name = "chkLightFlagDisableDir4";
            this.chkLightFlagDisableDir4.Size = new System.Drawing.Size(80, 17);
            this.chkLightFlagDisableDir4.TabIndex = 7;
            this.chkLightFlagDisableDir4.Text = "DisableDir4";
            this.chkLightFlagDisableDir4.UseVisualStyleBackColor = true;
            // 
            // chkLightFlagDisableDir3
            // 
            this.chkLightFlagDisableDir3.AutoSize = true;
            this.chkLightFlagDisableDir3.Location = new System.Drawing.Point(91, 104);
            this.chkLightFlagDisableDir3.Name = "chkLightFlagDisableDir3";
            this.chkLightFlagDisableDir3.Size = new System.Drawing.Size(80, 17);
            this.chkLightFlagDisableDir3.TabIndex = 6;
            this.chkLightFlagDisableDir3.Text = "DisableDir3";
            this.chkLightFlagDisableDir3.UseVisualStyleBackColor = true;
            // 
            // chkLightFlagDisableDir2
            // 
            this.chkLightFlagDisableDir2.AutoSize = true;
            this.chkLightFlagDisableDir2.Location = new System.Drawing.Point(91, 89);
            this.chkLightFlagDisableDir2.Name = "chkLightFlagDisableDir2";
            this.chkLightFlagDisableDir2.Size = new System.Drawing.Size(80, 17);
            this.chkLightFlagDisableDir2.TabIndex = 5;
            this.chkLightFlagDisableDir2.Text = "DisableDir2";
            this.chkLightFlagDisableDir2.UseVisualStyleBackColor = true;
            // 
            // chkLightFlagDisableDir1
            // 
            this.chkLightFlagDisableDir1.AutoSize = true;
            this.chkLightFlagDisableDir1.Location = new System.Drawing.Point(91, 73);
            this.chkLightFlagDisableDir1.Name = "chkLightFlagDisableDir1";
            this.chkLightFlagDisableDir1.Size = new System.Drawing.Size(80, 17);
            this.chkLightFlagDisableDir1.TabIndex = 4;
            this.chkLightFlagDisableDir1.Text = "DisableDir1";
            this.chkLightFlagDisableDir1.UseVisualStyleBackColor = true;
            // 
            // chkLightFlagDisableDir0
            // 
            this.chkLightFlagDisableDir0.AutoSize = true;
            this.chkLightFlagDisableDir0.Location = new System.Drawing.Point(91, 58);
            this.chkLightFlagDisableDir0.Name = "chkLightFlagDisableDir0";
            this.chkLightFlagDisableDir0.Size = new System.Drawing.Size(80, 17);
            this.chkLightFlagDisableDir0.TabIndex = 3;
            this.chkLightFlagDisableDir0.Text = "DisableDir0";
            this.chkLightFlagDisableDir0.UseVisualStyleBackColor = true;
            // 
            // chkLightFlagGlobal
            // 
            this.chkLightFlagGlobal.AutoSize = true;
            this.chkLightFlagGlobal.Location = new System.Drawing.Point(91, 36);
            this.chkLightFlagGlobal.Name = "chkLightFlagGlobal";
            this.chkLightFlagGlobal.Size = new System.Drawing.Size(56, 17);
            this.chkLightFlagGlobal.TabIndex = 2;
            this.chkLightFlagGlobal.Text = "Global";
            this.chkLightFlagGlobal.UseVisualStyleBackColor = true;
            // 
            // chkLightFlagInverse
            // 
            this.chkLightFlagInverse.AutoSize = true;
            this.chkLightFlagInverse.Location = new System.Drawing.Point(91, 19);
            this.chkLightFlagInverse.Name = "chkLightFlagInverse";
            this.chkLightFlagInverse.Size = new System.Drawing.Size(61, 17);
            this.chkLightFlagInverse.TabIndex = 1;
            this.chkLightFlagInverse.Text = "Inverse";
            this.chkLightFlagInverse.UseVisualStyleBackColor = true;
            // 
            // chkLight
            // 
            this.chkLight.AutoSize = true;
            this.chkLight.Location = new System.Drawing.Point(6, 19);
            this.chkLight.Name = "chkLight";
            this.chkLight.Size = new System.Drawing.Size(49, 17);
            this.chkLight.TabIndex = 0;
            this.chkLight.Text = "Light";
            this.chkLight.UseVisualStyleBackColor = true;
            // 
            // grpExtInfoMain
            // 
            this.grpExtInfoMain.Controls.Add(this.lblBaseCost);
            this.grpExtInfoMain.Controls.Add(this.numCost);
            this.grpExtInfoMain.Controls.Add(this.numVolume);
            this.grpExtInfoMain.Controls.Add(this.numWeight);
            this.grpExtInfoMain.Controls.Add(this.lblVolume);
            this.grpExtInfoMain.Controls.Add(this.lblWeight);
            this.grpExtInfoMain.Location = new System.Drawing.Point(6, 6);
            this.grpExtInfoMain.Name = "grpExtInfoMain";
            this.grpExtInfoMain.Size = new System.Drawing.Size(177, 84);
            this.grpExtInfoMain.TabIndex = 0;
            this.grpExtInfoMain.TabStop = false;
            this.grpExtInfoMain.Text = "Main";
            // 
            // lblBaseCost
            // 
            this.lblBaseCost.AutoSize = true;
            this.lblBaseCost.Location = new System.Drawing.Point(6, 51);
            this.lblBaseCost.Name = "lblBaseCost";
            this.lblBaseCost.Size = new System.Drawing.Size(55, 13);
            this.lblBaseCost.TabIndex = 4;
            this.lblBaseCost.Text = "Base Cost";
            // 
            // numCost
            // 
            this.numCost.Location = new System.Drawing.Point(92, 49);
            this.numCost.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(79, 20);
            this.numCost.TabIndex = 3;
            // 
            // numVolume
            // 
            this.numVolume.Location = new System.Drawing.Point(92, 32);
            this.numVolume.Name = "numVolume";
            this.numVolume.Size = new System.Drawing.Size(79, 20);
            this.numVolume.TabIndex = 2;
            // 
            // numWeight
            // 
            this.numWeight.Location = new System.Drawing.Point(92, 14);
            this.numWeight.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(79, 20);
            this.numWeight.TabIndex = 0;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(6, 34);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(42, 13);
            this.lblVolume.TabIndex = 1;
            this.lblVolume.Text = "Volume";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(6, 16);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(80, 13);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Weight (Grams)";
            // 
            // tabPageExt2
            // 
            this.tabPageExt2.Controls.Add(this.grpSpriteCutting);
            this.tabPageExt2.Controls.Add(this.grpAnimation);
            this.tabPageExt2.Controls.Add(this.grpDrawOrderOffset);
            this.tabPageExt2.Controls.Add(this.groupBox15);
            this.tabPageExt2.Controls.Add(this.groupBox14);
            this.tabPageExt2.Controls.Add(this.groupBox13);
            this.tabPageExt2.Controls.Add(this.groupBox12);
            this.tabPageExt2.Controls.Add(this.groupBox11);
            this.tabPageExt2.Controls.Add(this.grpScript);
            this.tabPageExt2.Location = new System.Drawing.Point(4, 22);
            this.tabPageExt2.Name = "tabPageExt2";
            this.tabPageExt2.Size = new System.Drawing.Size(776, 310);
            this.tabPageExt2.TabIndex = 2;
            this.tabPageExt2.Text = "Ext Info 2";
            this.tabPageExt2.UseVisualStyleBackColor = true;
            // 
            // grpSpriteCutting
            // 
            this.grpSpriteCutting.Controls.Add(this.rdbSpriteCuttingDisabled);
            this.grpSpriteCutting.Controls.Add(this.rdbSpriteCuttingHorizontal);
            this.grpSpriteCutting.Controls.Add(this.rdbSpriteCuttingVertical);
            this.grpSpriteCutting.Location = new System.Drawing.Point(416, 79);
            this.grpSpriteCutting.Name = "grpSpriteCutting";
            this.grpSpriteCutting.Size = new System.Drawing.Size(166, 120);
            this.grpSpriteCutting.TabIndex = 10;
            this.grpSpriteCutting.TabStop = false;
            this.grpSpriteCutting.Text = "Sprite Cutting (for long walls)";
            // 
            // rdbSpriteCuttingDisabled
            // 
            this.rdbSpriteCuttingDisabled.AutoSize = true;
            this.rdbSpriteCuttingDisabled.Location = new System.Drawing.Point(9, 22);
            this.rdbSpriteCuttingDisabled.Name = "rdbSpriteCuttingDisabled";
            this.rdbSpriteCuttingDisabled.Size = new System.Drawing.Size(66, 17);
            this.rdbSpriteCuttingDisabled.TabIndex = 0;
            this.rdbSpriteCuttingDisabled.TabStop = true;
            this.rdbSpriteCuttingDisabled.Text = "Disabled";
            this.rdbSpriteCuttingDisabled.UseVisualStyleBackColor = true;
            // 
            // rdbSpriteCuttingHorizontal
            // 
            this.rdbSpriteCuttingHorizontal.AutoSize = true;
            this.rdbSpriteCuttingHorizontal.Location = new System.Drawing.Point(9, 41);
            this.rdbSpriteCuttingHorizontal.Name = "rdbSpriteCuttingHorizontal";
            this.rdbSpriteCuttingHorizontal.Size = new System.Drawing.Size(128, 17);
            this.rdbSpriteCuttingHorizontal.TabIndex = 1;
            this.rdbSpriteCuttingHorizontal.TabStop = true;
            this.rdbSpriteCuttingHorizontal.Text = "Horizontal (HexX axis)";
            this.rdbSpriteCuttingHorizontal.UseVisualStyleBackColor = true;
            // 
            // rdbSpriteCuttingVertical
            // 
            this.rdbSpriteCuttingVertical.AutoSize = true;
            this.rdbSpriteCuttingVertical.Location = new System.Drawing.Point(9, 62);
            this.rdbSpriteCuttingVertical.Name = "rdbSpriteCuttingVertical";
            this.rdbSpriteCuttingVertical.Size = new System.Drawing.Size(116, 17);
            this.rdbSpriteCuttingVertical.TabIndex = 2;
            this.rdbSpriteCuttingVertical.TabStop = true;
            this.rdbSpriteCuttingVertical.Text = "Vertical (HexY axis)";
            this.rdbSpriteCuttingVertical.UseVisualStyleBackColor = true;
            // 
            // grpAnimation
            // 
            this.grpAnimation.Controls.Add(this.label42);
            this.grpAnimation.Controls.Add(this.numAnimHide1);
            this.grpAnimation.Controls.Add(this.numAnimHide0);
            this.grpAnimation.Controls.Add(this.label41);
            this.grpAnimation.Controls.Add(this.numAnimShow1);
            this.grpAnimation.Controls.Add(this.numAnimShow0);
            this.grpAnimation.Controls.Add(this.label40);
            this.grpAnimation.Controls.Add(this.numAnimStay1);
            this.grpAnimation.Controls.Add(this.numAnimStay0);
            this.grpAnimation.Controls.Add(this.chkShowAnimExt);
            this.grpAnimation.Controls.Add(this.numAnimWaitMax);
            this.grpAnimation.Controls.Add(this.label39);
            this.grpAnimation.Controls.Add(this.numAnimWaitMin);
            this.grpAnimation.Controls.Add(this.label38);
            this.grpAnimation.Controls.Add(this.numAnimWaitBase);
            this.grpAnimation.Controls.Add(this.label37);
            this.grpAnimation.Controls.Add(this.label36);
            this.grpAnimation.Controls.Add(this.chkShowAnim);
            this.grpAnimation.Location = new System.Drawing.Point(588, 12);
            this.grpAnimation.Name = "grpAnimation";
            this.grpAnimation.Size = new System.Drawing.Size(177, 270);
            this.grpAnimation.TabIndex = 9;
            this.grpAnimation.TabStop = false;
            this.grpAnimation.Text = "Animation";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(61, 208);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(66, 13);
            this.label42.TabIndex = 34;
            this.label42.Text = "Hide Frames";
            // 
            // numAnimHide1
            // 
            this.numAnimHide1.Location = new System.Drawing.Point(90, 222);
            this.numAnimHide1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAnimHide1.Name = "numAnimHide1";
            this.numAnimHide1.Size = new System.Drawing.Size(57, 20);
            this.numAnimHide1.TabIndex = 33;
            // 
            // numAnimHide0
            // 
            this.numAnimHide0.Location = new System.Drawing.Point(31, 222);
            this.numAnimHide0.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAnimHide0.Name = "numAnimHide0";
            this.numAnimHide0.Size = new System.Drawing.Size(57, 20);
            this.numAnimHide0.TabIndex = 32;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(61, 171);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(71, 13);
            this.label41.TabIndex = 31;
            this.label41.Text = "Show Frames";
            // 
            // numAnimShow1
            // 
            this.numAnimShow1.Location = new System.Drawing.Point(90, 185);
            this.numAnimShow1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAnimShow1.Name = "numAnimShow1";
            this.numAnimShow1.Size = new System.Drawing.Size(57, 20);
            this.numAnimShow1.TabIndex = 30;
            // 
            // numAnimShow0
            // 
            this.numAnimShow0.Location = new System.Drawing.Point(31, 185);
            this.numAnimShow0.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAnimShow0.Name = "numAnimShow0";
            this.numAnimShow0.Size = new System.Drawing.Size(57, 20);
            this.numAnimShow0.TabIndex = 29;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(58, 133);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(65, 13);
            this.label40.TabIndex = 28;
            this.label40.Text = "Stay Frames";
            // 
            // numAnimStay1
            // 
            this.numAnimStay1.Location = new System.Drawing.Point(87, 147);
            this.numAnimStay1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAnimStay1.Name = "numAnimStay1";
            this.numAnimStay1.Size = new System.Drawing.Size(57, 20);
            this.numAnimStay1.TabIndex = 27;
            // 
            // numAnimStay0
            // 
            this.numAnimStay0.Location = new System.Drawing.Point(28, 147);
            this.numAnimStay0.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAnimStay0.Name = "numAnimStay0";
            this.numAnimStay0.Size = new System.Drawing.Size(57, 20);
            this.numAnimStay0.TabIndex = 26;
            // 
            // chkShowAnimExt
            // 
            this.chkShowAnimExt.AutoSize = true;
            this.chkShowAnimExt.Location = new System.Drawing.Point(12, 115);
            this.chkShowAnimExt.Name = "chkShowAnimExt";
            this.chkShowAnimExt.Size = new System.Drawing.Size(91, 17);
            this.chkShowAnimExt.TabIndex = 25;
            this.chkShowAnimExt.Text = "ShowAnimExt";
            this.chkShowAnimExt.UseVisualStyleBackColor = true;
            // 
            // numAnimWaitMax
            // 
            this.numAnimWaitMax.Location = new System.Drawing.Point(117, 89);
            this.numAnimWaitMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAnimWaitMax.Name = "numAnimWaitMax";
            this.numAnimWaitMax.Size = new System.Drawing.Size(50, 20);
            this.numAnimWaitMax.TabIndex = 24;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(117, 73);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(27, 13);
            this.label39.TabIndex = 23;
            this.label39.Text = "Max";
            // 
            // numAnimWaitMin
            // 
            this.numAnimWaitMin.Location = new System.Drawing.Point(61, 89);
            this.numAnimWaitMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAnimWaitMin.Name = "numAnimWaitMin";
            this.numAnimWaitMin.Size = new System.Drawing.Size(50, 20);
            this.numAnimWaitMin.TabIndex = 22;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(61, 73);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(24, 13);
            this.label38.TabIndex = 21;
            this.label38.Text = "Min";
            // 
            // numAnimWaitBase
            // 
            this.numAnimWaitBase.Location = new System.Drawing.Point(9, 89);
            this.numAnimWaitBase.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAnimWaitBase.Name = "numAnimWaitBase";
            this.numAnimWaitBase.Size = new System.Drawing.Size(50, 20);
            this.numAnimWaitBase.TabIndex = 20;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(9, 73);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(31, 13);
            this.label37.TabIndex = 2;
            this.label37.Text = "Base";
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(6, 39);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(130, 30);
            this.label36.TabIndex = 1;
            this.label36.Text = "Base+Random(Min, Max) in 1/100 second";
            // 
            // chkShowAnim
            // 
            this.chkShowAnim.AutoSize = true;
            this.chkShowAnim.Location = new System.Drawing.Point(9, 19);
            this.chkShowAnim.Name = "chkShowAnim";
            this.chkShowAnim.Size = new System.Drawing.Size(76, 17);
            this.chkShowAnim.TabIndex = 0;
            this.chkShowAnim.Text = "ShowAnim";
            this.chkShowAnim.UseVisualStyleBackColor = true;
            // 
            // grpDrawOrderOffset
            // 
            this.grpDrawOrderOffset.Controls.Add(this.numDrawOrderOffsetHexY);
            this.grpDrawOrderOffset.Controls.Add(this.label35);
            this.grpDrawOrderOffset.Location = new System.Drawing.Point(416, 206);
            this.grpDrawOrderOffset.Name = "grpDrawOrderOffset";
            this.grpDrawOrderOffset.Size = new System.Drawing.Size(166, 76);
            this.grpDrawOrderOffset.TabIndex = 8;
            this.grpDrawOrderOffset.TabStop = false;
            this.grpDrawOrderOffset.Text = "Draw Order Offset";
            // 
            // numDrawOrderOffsetHexY
            // 
            this.numDrawOrderOffsetHexY.Location = new System.Drawing.Point(64, 22);
            this.numDrawOrderOffsetHexY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDrawOrderOffsetHexY.Name = "numDrawOrderOffsetHexY";
            this.numDrawOrderOffsetHexY.Size = new System.Drawing.Size(79, 20);
            this.numDrawOrderOffsetHexY.TabIndex = 19;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 24);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(36, 13);
            this.label35.TabIndex = 18;
            this.label35.Text = "Hex Y";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.numDrawOffsetsY);
            this.groupBox15.Controls.Add(this.label34);
            this.groupBox15.Controls.Add(this.numDrawOffsetsX);
            this.groupBox15.Controls.Add(this.label33);
            this.groupBox15.Location = new System.Drawing.Point(416, 12);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(166, 67);
            this.groupBox15.TabIndex = 7;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Draw Offsets";
            // 
            // numDrawOffsetsY
            // 
            this.numDrawOffsetsY.Location = new System.Drawing.Point(64, 40);
            this.numDrawOffsetsY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDrawOffsetsY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numDrawOffsetsY.Name = "numDrawOffsetsY";
            this.numDrawOffsetsY.Size = new System.Drawing.Size(79, 20);
            this.numDrawOffsetsY.TabIndex = 17;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 42);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(52, 13);
            this.label34.TabIndex = 16;
            this.label34.Text = "Monitor Y";
            // 
            // numDrawOffsetsX
            // 
            this.numDrawOffsetsX.Location = new System.Drawing.Point(64, 17);
            this.numDrawOffsetsX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDrawOffsetsX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numDrawOffsetsX.Name = "numDrawOffsetsX";
            this.numDrawOffsetsX.Size = new System.Drawing.Size(79, 20);
            this.numDrawOffsetsX.TabIndex = 15;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 19);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(52, 13);
            this.label33.TabIndex = 14;
            this.label33.Text = "Monitor X";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.numHolodiskNum);
            this.groupBox14.Controls.Add(this.chkHolodiskEnabled);
            this.groupBox14.Location = new System.Drawing.Point(283, 129);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(126, 70);
            this.groupBox14.TabIndex = 6;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Holodisk";
            // 
            // numHolodiskNum
            // 
            this.numHolodiskNum.Location = new System.Drawing.Point(7, 44);
            this.numHolodiskNum.Name = "numHolodiskNum";
            this.numHolodiskNum.Size = new System.Drawing.Size(97, 20);
            this.numHolodiskNum.TabIndex = 1;
            // 
            // chkHolodiskEnabled
            // 
            this.chkHolodiskEnabled.AutoSize = true;
            this.chkHolodiskEnabled.Location = new System.Drawing.Point(7, 22);
            this.chkHolodiskEnabled.Name = "chkHolodiskEnabled";
            this.chkHolodiskEnabled.Size = new System.Drawing.Size(65, 17);
            this.chkHolodiskEnabled.TabIndex = 0;
            this.chkHolodiskEnabled.Text = "Enabled";
            this.chkHolodiskEnabled.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.numSoundId);
            this.groupBox13.Location = new System.Drawing.Point(283, 66);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(127, 57);
            this.groupBox13.TabIndex = 5;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Sound";
            // 
            // numSoundId
            // 
            this.numSoundId.Location = new System.Drawing.Point(8, 20);
            this.numSoundId.Name = "numSoundId";
            this.numSoundId.Size = new System.Drawing.Size(97, 20);
            this.numSoundId.TabIndex = 1;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.numSlot);
            this.groupBox12.Location = new System.Drawing.Point(284, 12);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(126, 47);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Slot";
            // 
            // numSlot
            // 
            this.numSlot.Location = new System.Drawing.Point(7, 19);
            this.numSlot.Name = "numSlot";
            this.numSlot.Size = new System.Drawing.Size(97, 20);
            this.numSlot.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.chkRadioFlagDisableShiftChannel);
            this.groupBox11.Controls.Add(this.chkRadioFlagDisableShiftBCRecv);
            this.groupBox11.Controls.Add(this.chkRadioFlagDisableShiftBCSend);
            this.groupBox11.Controls.Add(this.chkRadioFlagDisableShiftRecv);
            this.groupBox11.Controls.Add(this.chkRadioFlagDisableShiftSend);
            this.groupBox11.Controls.Add(this.chkRadioFlagDisableRecv);
            this.groupBox11.Controls.Add(this.chkRadioFlagDisableSend);
            this.groupBox11.Controls.Add(this.chkRadioEnabled);
            this.groupBox11.Controls.Add(this.numRadioBroadcastReceive);
            this.groupBox11.Controls.Add(this.label32);
            this.groupBox11.Controls.Add(this.numRadioBroadcastSend);
            this.groupBox11.Controls.Add(this.label31);
            this.groupBox11.Controls.Add(this.numRadioChannel);
            this.groupBox11.Controls.Add(this.label30);
            this.groupBox11.Location = new System.Drawing.Point(12, 66);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(265, 216);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Radio";
            // 
            // chkRadioFlagDisableShiftChannel
            // 
            this.chkRadioFlagDisableShiftChannel.AutoSize = true;
            this.chkRadioFlagDisableShiftChannel.Location = new System.Drawing.Point(129, 148);
            this.chkRadioFlagDisableShiftChannel.Name = "chkRadioFlagDisableShiftChannel";
            this.chkRadioFlagDisableShiftChannel.Size = new System.Drawing.Size(121, 17);
            this.chkRadioFlagDisableShiftChannel.TabIndex = 13;
            this.chkRadioFlagDisableShiftChannel.Text = "DisableShiftChannel";
            this.chkRadioFlagDisableShiftChannel.UseVisualStyleBackColor = true;
            // 
            // chkRadioFlagDisableShiftBCRecv
            // 
            this.chkRadioFlagDisableShiftBCRecv.AutoSize = true;
            this.chkRadioFlagDisableShiftBCRecv.Location = new System.Drawing.Point(129, 132);
            this.chkRadioFlagDisableShiftBCRecv.Name = "chkRadioFlagDisableShiftBCRecv";
            this.chkRadioFlagDisableShiftBCRecv.Size = new System.Drawing.Size(122, 17);
            this.chkRadioFlagDisableShiftBCRecv.TabIndex = 12;
            this.chkRadioFlagDisableShiftBCRecv.Text = "DisableShiftBCRecv";
            this.chkRadioFlagDisableShiftBCRecv.UseVisualStyleBackColor = true;
            // 
            // chkRadioFlagDisableShiftBCSend
            // 
            this.chkRadioFlagDisableShiftBCSend.AutoSize = true;
            this.chkRadioFlagDisableShiftBCSend.Location = new System.Drawing.Point(129, 117);
            this.chkRadioFlagDisableShiftBCSend.Name = "chkRadioFlagDisableShiftBCSend";
            this.chkRadioFlagDisableShiftBCSend.Size = new System.Drawing.Size(121, 17);
            this.chkRadioFlagDisableShiftBCSend.TabIndex = 11;
            this.chkRadioFlagDisableShiftBCSend.Text = "DisableShiftBCSend";
            this.chkRadioFlagDisableShiftBCSend.UseVisualStyleBackColor = true;
            // 
            // chkRadioFlagDisableShiftRecv
            // 
            this.chkRadioFlagDisableShiftRecv.AutoSize = true;
            this.chkRadioFlagDisableShiftRecv.Location = new System.Drawing.Point(129, 101);
            this.chkRadioFlagDisableShiftRecv.Name = "chkRadioFlagDisableShiftRecv";
            this.chkRadioFlagDisableShiftRecv.Size = new System.Drawing.Size(108, 17);
            this.chkRadioFlagDisableShiftRecv.TabIndex = 10;
            this.chkRadioFlagDisableShiftRecv.Text = "DisableShiftRecv";
            this.chkRadioFlagDisableShiftRecv.UseVisualStyleBackColor = true;
            // 
            // chkRadioFlagDisableShiftSend
            // 
            this.chkRadioFlagDisableShiftSend.AutoSize = true;
            this.chkRadioFlagDisableShiftSend.Location = new System.Drawing.Point(129, 86);
            this.chkRadioFlagDisableShiftSend.Name = "chkRadioFlagDisableShiftSend";
            this.chkRadioFlagDisableShiftSend.Size = new System.Drawing.Size(107, 17);
            this.chkRadioFlagDisableShiftSend.TabIndex = 9;
            this.chkRadioFlagDisableShiftSend.Text = "DisableShiftSend";
            this.chkRadioFlagDisableShiftSend.UseVisualStyleBackColor = true;
            // 
            // chkRadioFlagDisableRecv
            // 
            this.chkRadioFlagDisableRecv.AutoSize = true;
            this.chkRadioFlagDisableRecv.Location = new System.Drawing.Point(129, 70);
            this.chkRadioFlagDisableRecv.Name = "chkRadioFlagDisableRecv";
            this.chkRadioFlagDisableRecv.Size = new System.Drawing.Size(87, 17);
            this.chkRadioFlagDisableRecv.TabIndex = 8;
            this.chkRadioFlagDisableRecv.Text = "DisableRecv";
            this.chkRadioFlagDisableRecv.UseVisualStyleBackColor = true;
            // 
            // chkRadioFlagDisableSend
            // 
            this.chkRadioFlagDisableSend.AutoSize = true;
            this.chkRadioFlagDisableSend.Location = new System.Drawing.Point(129, 55);
            this.chkRadioFlagDisableSend.Name = "chkRadioFlagDisableSend";
            this.chkRadioFlagDisableSend.Size = new System.Drawing.Size(86, 17);
            this.chkRadioFlagDisableSend.TabIndex = 7;
            this.chkRadioFlagDisableSend.Text = "DisableSend";
            this.chkRadioFlagDisableSend.UseVisualStyleBackColor = true;
            // 
            // chkRadioEnabled
            // 
            this.chkRadioEnabled.AutoSize = true;
            this.chkRadioEnabled.Location = new System.Drawing.Point(129, 19);
            this.chkRadioEnabled.Name = "chkRadioEnabled";
            this.chkRadioEnabled.Size = new System.Drawing.Size(96, 17);
            this.chkRadioEnabled.TabIndex = 6;
            this.chkRadioEnabled.Text = "Radio Enabled";
            this.chkRadioEnabled.UseVisualStyleBackColor = true;
            // 
            // numRadioBroadcastReceive
            // 
            this.numRadioBroadcastReceive.Location = new System.Drawing.Point(10, 117);
            this.numRadioBroadcastReceive.Name = "numRadioBroadcastReceive";
            this.numRadioBroadcastReceive.Size = new System.Drawing.Size(66, 20);
            this.numRadioBroadcastReceive.TabIndex = 5;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 100);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(98, 13);
            this.label32.TabIndex = 4;
            this.label32.Text = "Broadcast Receive";
            // 
            // numRadioBroadcastSend
            // 
            this.numRadioBroadcastSend.Location = new System.Drawing.Point(10, 77);
            this.numRadioBroadcastSend.Name = "numRadioBroadcastSend";
            this.numRadioBroadcastSend.Size = new System.Drawing.Size(66, 20);
            this.numRadioBroadcastSend.TabIndex = 3;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(7, 60);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(83, 13);
            this.label31.TabIndex = 2;
            this.label31.Text = "Broadcast Send";
            // 
            // numRadioChannel
            // 
            this.numRadioChannel.Location = new System.Drawing.Point(10, 37);
            this.numRadioChannel.Name = "numRadioChannel";
            this.numRadioChannel.Size = new System.Drawing.Size(66, 20);
            this.numRadioChannel.TabIndex = 1;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(7, 20);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(46, 13);
            this.label30.TabIndex = 0;
            this.label30.Text = "Channel";
            // 
            // grpScript
            // 
            this.grpScript.Controls.Add(this.txtScriptFunction);
            this.grpScript.Controls.Add(this.txtScriptModule);
            this.grpScript.Controls.Add(this.label87);
            this.grpScript.Location = new System.Drawing.Point(12, 12);
            this.grpScript.Name = "grpScript";
            this.grpScript.Size = new System.Drawing.Size(265, 47);
            this.grpScript.TabIndex = 2;
            this.grpScript.TabStop = false;
            this.grpScript.Text = "Script (Module@Function)";
            // 
            // txtScriptFunction
            // 
            this.txtScriptFunction.Location = new System.Drawing.Point(138, 19);
            this.txtScriptFunction.Name = "txtScriptFunction";
            this.txtScriptFunction.Size = new System.Drawing.Size(121, 20);
            this.txtScriptFunction.TabIndex = 2;
            // 
            // txtScriptModule
            // 
            this.txtScriptModule.Location = new System.Drawing.Point(6, 19);
            this.txtScriptModule.Name = "txtScriptModule";
            this.txtScriptModule.Size = new System.Drawing.Size(116, 20);
            this.txtScriptModule.TabIndex = 0;
            this.txtScriptModule.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(121, 22);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(18, 13);
            this.label87.TabIndex = 1;
            this.label87.Text = "@";
            // 
            // tabPageExt3
            // 
            this.tabPageExt3.Controls.Add(this.groupBox5);
            this.tabPageExt3.Controls.Add(this.groupBox4);
            this.tabPageExt3.Controls.Add(this.groupBox3);
            this.tabPageExt3.Controls.Add(this.grpInitialCondition);
            this.tabPageExt3.Location = new System.Drawing.Point(4, 22);
            this.tabPageExt3.Name = "tabPageExt3";
            this.tabPageExt3.Size = new System.Drawing.Size(776, 310);
            this.tabPageExt3.TabIndex = 3;
            this.tabPageExt3.Text = "Ext Info 3";
            this.tabPageExt3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label67);
            this.groupBox5.Controls.Add(this.label66);
            this.groupBox5.Controls.Add(this.numChildPid5);
            this.groupBox5.Controls.Add(this.numChildPid4);
            this.groupBox5.Controls.Add(this.numChildPid3);
            this.groupBox5.Controls.Add(this.label65);
            this.groupBox5.Controls.Add(this.numChildPid2);
            this.groupBox5.Controls.Add(this.label64);
            this.groupBox5.Controls.Add(this.numChildPid1);
            this.groupBox5.Controls.Add(this.label63);
            this.groupBox5.Location = new System.Drawing.Point(126, 176);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(204, 130);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Child Pids";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(7, 102);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(54, 13);
            this.label67.TabIndex = 9;
            this.label67.Text = "ChildPid 5";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(7, 82);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(54, 13);
            this.label66.TabIndex = 8;
            this.label66.Text = "ChildPid 4";
            // 
            // numChildPid5
            // 
            this.numChildPid5.Location = new System.Drawing.Point(67, 100);
            this.numChildPid5.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numChildPid5.Name = "numChildPid5";
            this.numChildPid5.Size = new System.Drawing.Size(97, 20);
            this.numChildPid5.TabIndex = 7;
            // 
            // numChildPid4
            // 
            this.numChildPid4.Location = new System.Drawing.Point(67, 80);
            this.numChildPid4.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numChildPid4.Name = "numChildPid4";
            this.numChildPid4.Size = new System.Drawing.Size(97, 20);
            this.numChildPid4.TabIndex = 6;
            // 
            // numChildPid3
            // 
            this.numChildPid3.Location = new System.Drawing.Point(67, 60);
            this.numChildPid3.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numChildPid3.Name = "numChildPid3";
            this.numChildPid3.Size = new System.Drawing.Size(97, 20);
            this.numChildPid3.TabIndex = 5;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(7, 62);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(54, 13);
            this.label65.TabIndex = 4;
            this.label65.Text = "ChildPid 3";
            // 
            // numChildPid2
            // 
            this.numChildPid2.Location = new System.Drawing.Point(67, 40);
            this.numChildPid2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numChildPid2.Name = "numChildPid2";
            this.numChildPid2.Size = new System.Drawing.Size(97, 20);
            this.numChildPid2.TabIndex = 3;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(7, 44);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(54, 13);
            this.label64.TabIndex = 2;
            this.label64.Text = "ChildPid 2";
            // 
            // numChildPid1
            // 
            this.numChildPid1.Location = new System.Drawing.Point(67, 20);
            this.numChildPid1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numChildPid1.Name = "numChildPid1";
            this.numChildPid1.Size = new System.Drawing.Size(97, 20);
            this.numChildPid1.TabIndex = 1;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(7, 24);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(54, 13);
            this.label63.TabIndex = 0;
            this.label63.Text = "ChildPid 1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label51);
            this.groupBox4.Controls.Add(this.label50);
            this.groupBox4.Controls.Add(this.label72);
            this.groupBox4.Controls.Add(this.label71);
            this.groupBox4.Controls.Add(this.label70);
            this.groupBox4.Controls.Add(this.txtChildLines5);
            this.groupBox4.Controls.Add(this.txtChildLines4);
            this.groupBox4.Controls.Add(this.txtChildLines3);
            this.groupBox4.Controls.Add(this.txtChildLines2);
            this.groupBox4.Controls.Add(this.label69);
            this.groupBox4.Controls.Add(this.txtChildLines1);
            this.groupBox4.Controls.Add(this.label68);
            this.groupBox4.Controls.Add(this.txtBlockLines);
            this.groupBox4.Controls.Add(this.label52);
            this.groupBox4.Location = new System.Drawing.Point(336, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(430, 250);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Blocking";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(242, 112);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(68, 13);
            this.label51.TabIndex = 37;
            this.label51.Text = "Bag 2 for car";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(242, 92);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(68, 13);
            this.label50.TabIndex = 36;
            this.label50.Text = "Bag 1 for car";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(15, 168);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(60, 13);
            this.label72.TabIndex = 35;
            this.label72.Text = "Childlines 5";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(15, 148);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(60, 13);
            this.label71.TabIndex = 34;
            this.label71.Text = "Childlines 4";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(15, 128);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(60, 13);
            this.label70.TabIndex = 33;
            this.label70.Text = "Childlines 3";
            // 
            // txtChildLines5
            // 
            this.txtChildLines5.Location = new System.Drawing.Point(81, 168);
            this.txtChildLines5.Multiline = true;
            this.txtChildLines5.Name = "txtChildLines5";
            this.txtChildLines5.Size = new System.Drawing.Size(154, 17);
            this.txtChildLines5.TabIndex = 32;
            // 
            // txtChildLines4
            // 
            this.txtChildLines4.Location = new System.Drawing.Point(81, 148);
            this.txtChildLines4.Multiline = true;
            this.txtChildLines4.Name = "txtChildLines4";
            this.txtChildLines4.Size = new System.Drawing.Size(154, 17);
            this.txtChildLines4.TabIndex = 31;
            // 
            // txtChildLines3
            // 
            this.txtChildLines3.Location = new System.Drawing.Point(81, 128);
            this.txtChildLines3.Multiline = true;
            this.txtChildLines3.Name = "txtChildLines3";
            this.txtChildLines3.Size = new System.Drawing.Size(154, 17);
            this.txtChildLines3.TabIndex = 30;
            // 
            // txtChildLines2
            // 
            this.txtChildLines2.Location = new System.Drawing.Point(81, 108);
            this.txtChildLines2.Multiline = true;
            this.txtChildLines2.Name = "txtChildLines2";
            this.txtChildLines2.Size = new System.Drawing.Size(154, 17);
            this.txtChildLines2.TabIndex = 29;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(15, 108);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(60, 13);
            this.label69.TabIndex = 28;
            this.label69.Text = "Childlines 2";
            // 
            // txtChildLines1
            // 
            this.txtChildLines1.Location = new System.Drawing.Point(81, 88);
            this.txtChildLines1.Multiline = true;
            this.txtChildLines1.Name = "txtChildLines1";
            this.txtChildLines1.Size = new System.Drawing.Size(154, 17);
            this.txtChildLines1.TabIndex = 27;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(15, 88);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(60, 13);
            this.label68.TabIndex = 26;
            this.label68.Text = "Childlines 1";
            // 
            // txtBlockLines
            // 
            this.txtBlockLines.Location = new System.Drawing.Point(81, 20);
            this.txtBlockLines.Multiline = true;
            this.txtBlockLines.Name = "txtBlockLines";
            this.txtBlockLines.Size = new System.Drawing.Size(154, 62);
            this.txtBlockLines.TabIndex = 25;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(14, 20);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(55, 13);
            this.label52.TabIndex = 24;
            this.label52.Text = "Blocklines";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkGroundLevel);
            this.groupBox3.Controls.Add(this.chkStackable);
            this.groupBox3.Controls.Add(this.chkDeteriorable);
            this.groupBox3.Location = new System.Drawing.Point(6, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 130);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General Properties";
            // 
            // chkGroundLevel
            // 
            this.chkGroundLevel.AutoSize = true;
            this.chkGroundLevel.Location = new System.Drawing.Point(9, 66);
            this.chkGroundLevel.Name = "chkGroundLevel";
            this.chkGroundLevel.Size = new System.Drawing.Size(90, 17);
            this.chkGroundLevel.TabIndex = 2;
            this.chkGroundLevel.Text = "Ground Level";
            this.chkGroundLevel.UseVisualStyleBackColor = true;
            // 
            // chkStackable
            // 
            this.chkStackable.AutoSize = true;
            this.chkStackable.Location = new System.Drawing.Point(9, 43);
            this.chkStackable.Name = "chkStackable";
            this.chkStackable.Size = new System.Drawing.Size(74, 17);
            this.chkStackable.TabIndex = 1;
            this.chkStackable.Text = "Stackable";
            this.chkStackable.UseVisualStyleBackColor = true;
            // 
            // chkDeteriorable
            // 
            this.chkDeteriorable.AutoSize = true;
            this.chkDeteriorable.Location = new System.Drawing.Point(9, 20);
            this.chkDeteriorable.Name = "chkDeteriorable";
            this.chkDeteriorable.Size = new System.Drawing.Size(83, 17);
            this.chkDeteriorable.TabIndex = 0;
            this.chkDeteriorable.Text = "Deteriorable";
            this.chkDeteriorable.UseVisualStyleBackColor = true;
            // 
            // grpInitialCondition
            // 
            this.grpInitialCondition.Controls.Add(this.label58);
            this.grpInitialCondition.Controls.Add(this.numStartValue10);
            this.grpInitialCondition.Controls.Add(this.numStartValue9);
            this.grpInitialCondition.Controls.Add(this.label59);
            this.grpInitialCondition.Controls.Add(this.numStartValue8);
            this.grpInitialCondition.Controls.Add(this.label60);
            this.grpInitialCondition.Controls.Add(this.numStartValue7);
            this.grpInitialCondition.Controls.Add(this.label61);
            this.grpInitialCondition.Controls.Add(this.numStartValue6);
            this.grpInitialCondition.Controls.Add(this.label62);
            this.grpInitialCondition.Controls.Add(this.label57);
            this.grpInitialCondition.Controls.Add(this.numStartValue5);
            this.grpInitialCondition.Controls.Add(this.numStartValue4);
            this.grpInitialCondition.Controls.Add(this.label56);
            this.grpInitialCondition.Controls.Add(this.numStartValue3);
            this.grpInitialCondition.Controls.Add(this.label55);
            this.grpInitialCondition.Controls.Add(this.numStartValue2);
            this.grpInitialCondition.Controls.Add(this.label20);
            this.grpInitialCondition.Controls.Add(this.numStartValue1);
            this.grpInitialCondition.Controls.Add(this.label19);
            this.grpInitialCondition.Controls.Add(this.numStartCount);
            this.grpInitialCondition.Controls.Add(this.label18);
            this.grpInitialCondition.Location = new System.Drawing.Point(6, 6);
            this.grpInitialCondition.Name = "grpInitialCondition";
            this.grpInitialCondition.Size = new System.Drawing.Size(324, 164);
            this.grpInitialCondition.TabIndex = 0;
            this.grpInitialCondition.TabStop = false;
            this.grpInitialCondition.Text = "Initial Condition";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(148, 132);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(71, 13);
            this.label58.TabIndex = 21;
            this.label58.Text = "StartValue 10";
            // 
            // numStartValue10
            // 
            this.numStartValue10.Location = new System.Drawing.Point(219, 130);
            this.numStartValue10.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numStartValue10.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numStartValue10.Name = "numStartValue10";
            this.numStartValue10.Size = new System.Drawing.Size(65, 20);
            this.numStartValue10.TabIndex = 20;
            // 
            // numStartValue9
            // 
            this.numStartValue9.Location = new System.Drawing.Point(219, 110);
            this.numStartValue9.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numStartValue9.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numStartValue9.Name = "numStartValue9";
            this.numStartValue9.Size = new System.Drawing.Size(65, 20);
            this.numStartValue9.TabIndex = 19;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(148, 112);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(65, 13);
            this.label59.TabIndex = 18;
            this.label59.Text = "StartValue 9";
            // 
            // numStartValue8
            // 
            this.numStartValue8.Location = new System.Drawing.Point(219, 90);
            this.numStartValue8.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numStartValue8.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numStartValue8.Name = "numStartValue8";
            this.numStartValue8.Size = new System.Drawing.Size(65, 20);
            this.numStartValue8.TabIndex = 17;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(148, 92);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(65, 13);
            this.label60.TabIndex = 16;
            this.label60.Text = "StartValue 8";
            // 
            // numStartValue7
            // 
            this.numStartValue7.Location = new System.Drawing.Point(219, 70);
            this.numStartValue7.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numStartValue7.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numStartValue7.Name = "numStartValue7";
            this.numStartValue7.Size = new System.Drawing.Size(65, 20);
            this.numStartValue7.TabIndex = 15;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(148, 72);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(65, 13);
            this.label61.TabIndex = 14;
            this.label61.Text = "StartValue 7";
            // 
            // numStartValue6
            // 
            this.numStartValue6.Location = new System.Drawing.Point(219, 50);
            this.numStartValue6.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numStartValue6.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numStartValue6.Name = "numStartValue6";
            this.numStartValue6.Size = new System.Drawing.Size(65, 20);
            this.numStartValue6.TabIndex = 13;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(148, 52);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(65, 13);
            this.label62.TabIndex = 12;
            this.label62.Text = "StartValue 6";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(6, 132);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(65, 13);
            this.label57.TabIndex = 11;
            this.label57.Text = "StartValue 5";
            // 
            // numStartValue5
            // 
            this.numStartValue5.Location = new System.Drawing.Point(77, 130);
            this.numStartValue5.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numStartValue5.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numStartValue5.Name = "numStartValue5";
            this.numStartValue5.Size = new System.Drawing.Size(65, 20);
            this.numStartValue5.TabIndex = 10;
            // 
            // numStartValue4
            // 
            this.numStartValue4.Location = new System.Drawing.Point(77, 110);
            this.numStartValue4.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numStartValue4.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numStartValue4.Name = "numStartValue4";
            this.numStartValue4.Size = new System.Drawing.Size(65, 20);
            this.numStartValue4.TabIndex = 9;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(6, 112);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(65, 13);
            this.label56.TabIndex = 8;
            this.label56.Text = "StartValue 4";
            // 
            // numStartValue3
            // 
            this.numStartValue3.Location = new System.Drawing.Point(77, 90);
            this.numStartValue3.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numStartValue3.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numStartValue3.Name = "numStartValue3";
            this.numStartValue3.Size = new System.Drawing.Size(65, 20);
            this.numStartValue3.TabIndex = 7;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 92);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(65, 13);
            this.label55.TabIndex = 6;
            this.label55.Text = "StartValue 3";
            // 
            // numStartValue2
            // 
            this.numStartValue2.Location = new System.Drawing.Point(77, 70);
            this.numStartValue2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numStartValue2.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numStartValue2.Name = "numStartValue2";
            this.numStartValue2.Size = new System.Drawing.Size(65, 20);
            this.numStartValue2.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "StartValue 2";
            // 
            // numStartValue1
            // 
            this.numStartValue1.Location = new System.Drawing.Point(77, 50);
            this.numStartValue1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numStartValue1.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numStartValue1.Name = "numStartValue1";
            this.numStartValue1.Size = new System.Drawing.Size(65, 20);
            this.numStartValue1.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "StartValue 1";
            // 
            // numStartCount
            // 
            this.numStartCount.Location = new System.Drawing.Point(148, 23);
            this.numStartCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numStartCount.Name = "numStartCount";
            this.numStartCount.Size = new System.Drawing.Size(65, 20);
            this.numStartCount.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(82, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Start Count";
            // 
            // panelProperties
            // 
            this.panelProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProperties.Controls.Add(this.tabPageArmor);
            this.panelProperties.Controls.Add(this.tabPageAmmo);
            this.panelProperties.Controls.Add(this.tabPageCar);
            this.panelProperties.Controls.Add(this.tabPageContainer);
            this.panelProperties.Controls.Add(this.tabPageDrug);
            this.panelProperties.Controls.Add(this.tabPageDoor);
            this.panelProperties.Controls.Add(this.tabPageGeneric);
            this.panelProperties.Controls.Add(this.tabPageGrid);
            this.panelProperties.Controls.Add(this.tabPageKey);
            this.panelProperties.Controls.Add(this.tabPageMisc);
            this.panelProperties.Controls.Add(this.tabPageWall);
            this.panelProperties.Controls.Add(this.tabPageWeapon);
            this.panelProperties.Location = new System.Drawing.Point(12, 369);
            this.panelProperties.Name = "panelProperties";
            this.panelProperties.SelectedIndex = 0;
            this.panelProperties.Size = new System.Drawing.Size(780, 215);
            this.panelProperties.TabIndex = 11;
            this.panelProperties.Tag = "";
            this.panelProperties.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.panelProperties_Selecting);
            // 
            // tabPageArmor
            // 
            this.tabPageArmor.Controls.Add(this.tabControlArmor);
            this.tabPageArmor.Location = new System.Drawing.Point(4, 22);
            this.tabPageArmor.Name = "tabPageArmor";
            this.tabPageArmor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArmor.Size = new System.Drawing.Size(772, 189);
            this.tabPageArmor.TabIndex = 0;
            this.tabPageArmor.Text = "Armor";
            this.tabPageArmor.UseVisualStyleBackColor = true;
            // 
            // tabControlArmor
            // 
            this.tabControlArmor.Controls.Add(this.ArmorMain);
            this.tabControlArmor.Location = new System.Drawing.Point(3, 3);
            this.tabControlArmor.Name = "tabControlArmor";
            this.tabControlArmor.SelectedIndex = 0;
            this.tabControlArmor.Size = new System.Drawing.Size(764, 181);
            this.tabControlArmor.TabIndex = 4;
            // 
            // ArmorMain
            // 
            this.ArmorMain.Controls.Add(this.numCrTypeFemale);
            this.ArmorMain.Controls.Add(this.lblCritterTypeFemale);
            this.ArmorMain.Controls.Add(this.numCrTypeMale);
            this.ArmorMain.Controls.Add(this.lblCritterTypeMale);
            this.ArmorMain.Location = new System.Drawing.Point(4, 22);
            this.ArmorMain.Name = "ArmorMain";
            this.ArmorMain.Padding = new System.Windows.Forms.Padding(3);
            this.ArmorMain.Size = new System.Drawing.Size(756, 155);
            this.ArmorMain.TabIndex = 0;
            this.ArmorMain.Text = "Main";
            this.ArmorMain.UseVisualStyleBackColor = true;
            // 
            // numCrTypeFemale
            // 
            this.numCrTypeFemale.Location = new System.Drawing.Point(107, 30);
            this.numCrTypeFemale.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCrTypeFemale.Name = "numCrTypeFemale";
            this.numCrTypeFemale.Size = new System.Drawing.Size(69, 20);
            this.numCrTypeFemale.TabIndex = 7;
            // 
            // lblCritterTypeFemale
            // 
            this.lblCritterTypeFemale.AutoSize = true;
            this.lblCritterTypeFemale.Location = new System.Drawing.Point(6, 32);
            this.lblCritterTypeFemale.Name = "lblCritterTypeFemale";
            this.lblCritterTypeFemale.Size = new System.Drawing.Size(95, 13);
            this.lblCritterTypeFemale.TabIndex = 6;
            this.lblCritterTypeFemale.Text = "CritterType Female";
            // 
            // numCrTypeMale
            // 
            this.numCrTypeMale.Location = new System.Drawing.Point(107, 10);
            this.numCrTypeMale.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCrTypeMale.Name = "numCrTypeMale";
            this.numCrTypeMale.Size = new System.Drawing.Size(69, 20);
            this.numCrTypeMale.TabIndex = 5;
            // 
            // lblCritterTypeMale
            // 
            this.lblCritterTypeMale.AutoSize = true;
            this.lblCritterTypeMale.Location = new System.Drawing.Point(6, 12);
            this.lblCritterTypeMale.Name = "lblCritterTypeMale";
            this.lblCritterTypeMale.Size = new System.Drawing.Size(84, 13);
            this.lblCritterTypeMale.TabIndex = 4;
            this.lblCritterTypeMale.Text = "CritterType Male";
            // 
            // tabPageAmmo
            // 
            this.tabPageAmmo.Controls.Add(this.tabControlAmmo);
            this.tabPageAmmo.Location = new System.Drawing.Point(4, 22);
            this.tabPageAmmo.Name = "tabPageAmmo";
            this.tabPageAmmo.Size = new System.Drawing.Size(772, 189);
            this.tabPageAmmo.TabIndex = 3;
            this.tabPageAmmo.Text = "Ammo";
            this.tabPageAmmo.UseVisualStyleBackColor = true;
            // 
            // tabControlAmmo
            // 
            this.tabControlAmmo.Controls.Add(this.AmmoMain);
            this.tabControlAmmo.Location = new System.Drawing.Point(3, 3);
            this.tabControlAmmo.Name = "tabControlAmmo";
            this.tabControlAmmo.SelectedIndex = 0;
            this.tabControlAmmo.Size = new System.Drawing.Size(757, 163);
            this.tabControlAmmo.TabIndex = 6;
            // 
            // AmmoMain
            // 
            this.AmmoMain.Controls.Add(this.numDrMod);
            this.AmmoMain.Controls.Add(this.label4);
            this.AmmoMain.Controls.Add(this.numAcMod);
            this.AmmoMain.Controls.Add(this.label3);
            this.AmmoMain.Controls.Add(this.cmbCaliberAmmo);
            this.AmmoMain.Controls.Add(this.label73);
            this.AmmoMain.Location = new System.Drawing.Point(4, 22);
            this.AmmoMain.Name = "AmmoMain";
            this.AmmoMain.Padding = new System.Windows.Forms.Padding(3);
            this.AmmoMain.Size = new System.Drawing.Size(749, 137);
            this.AmmoMain.TabIndex = 0;
            this.AmmoMain.Text = "Main";
            this.AmmoMain.UseVisualStyleBackColor = true;
            // 
            // numDrMod
            // 
            this.numDrMod.Location = new System.Drawing.Point(57, 57);
            this.numDrMod.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numDrMod.Name = "numDrMod";
            this.numDrMod.Size = new System.Drawing.Size(60, 20);
            this.numDrMod.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "DR Mod";
            // 
            // numAcMod
            // 
            this.numAcMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numAcMod.Location = new System.Drawing.Point(57, 37);
            this.numAcMod.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numAcMod.Name = "numAcMod";
            this.numAcMod.Size = new System.Drawing.Size(60, 20);
            this.numAcMod.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "AC Mod";
            // 
            // cmbCaliberAmmo
            // 
            this.cmbCaliberAmmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaliberAmmo.DropDownWidth = 250;
            this.cmbCaliberAmmo.FormattingEnabled = true;
            this.cmbCaliberAmmo.Location = new System.Drawing.Point(57, 9);
            this.cmbCaliberAmmo.Name = "cmbCaliberAmmo";
            this.cmbCaliberAmmo.Size = new System.Drawing.Size(127, 21);
            this.cmbCaliberAmmo.TabIndex = 7;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(6, 12);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(39, 13);
            this.label73.TabIndex = 6;
            this.label73.Text = "Caliber";
            // 
            // tabPageCar
            // 
            this.tabPageCar.Controls.Add(this.tabControlCar);
            this.tabPageCar.Location = new System.Drawing.Point(4, 22);
            this.tabPageCar.Name = "tabPageCar";
            this.tabPageCar.Size = new System.Drawing.Size(772, 189);
            this.tabPageCar.TabIndex = 12;
            this.tabPageCar.Text = "Car";
            this.tabPageCar.UseVisualStyleBackColor = true;
            // 
            // tabControlCar
            // 
            this.tabControlCar.Controls.Add(this.CarMain);
            this.tabControlCar.Location = new System.Drawing.Point(3, 3);
            this.tabControlCar.Name = "tabControlCar";
            this.tabControlCar.SelectedIndex = 0;
            this.tabControlCar.Size = new System.Drawing.Size(763, 159);
            this.tabControlCar.TabIndex = 24;
            // 
            // CarMain
            // 
            this.CarMain.Controls.Add(this.numCarEntrance);
            this.CarMain.Controls.Add(this.label53);
            this.CarMain.Controls.Add(this.numCarSpeed);
            this.CarMain.Controls.Add(this.label49);
            this.CarMain.Controls.Add(this.numCarCritterCapacity);
            this.CarMain.Controls.Add(this.label48);
            this.CarMain.Controls.Add(this.numCarPassability);
            this.CarMain.Controls.Add(this.label47);
            this.CarMain.Controls.Add(this.numCarFuelConsumption);
            this.CarMain.Controls.Add(this.label46);
            this.CarMain.Controls.Add(this.numCarTankVolume);
            this.CarMain.Controls.Add(this.label45);
            this.CarMain.Controls.Add(this.numCarMaxDeterioration);
            this.CarMain.Controls.Add(this.label44);
            this.CarMain.Controls.Add(this.numCarDeteriorationRate);
            this.CarMain.Controls.Add(this.label43);
            this.CarMain.Controls.Add(this.grpCarMovementType);
            this.CarMain.Location = new System.Drawing.Point(4, 22);
            this.CarMain.Name = "CarMain";
            this.CarMain.Padding = new System.Windows.Forms.Padding(3);
            this.CarMain.Size = new System.Drawing.Size(755, 133);
            this.CarMain.TabIndex = 0;
            this.CarMain.Text = "Main";
            this.CarMain.UseVisualStyleBackColor = true;
            // 
            // numCarEntrance
            // 
            this.numCarEntrance.Location = new System.Drawing.Point(565, 27);
            this.numCarEntrance.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numCarEntrance.Name = "numCarEntrance";
            this.numCarEntrance.Size = new System.Drawing.Size(90, 20);
            this.numCarEntrance.TabIndex = 40;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(562, 11);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(86, 13);
            this.label53.TabIndex = 39;
            this.label53.Text = "Entrance (Entire)";
            // 
            // numCarSpeed
            // 
            this.numCarSpeed.Location = new System.Drawing.Point(455, 27);
            this.numCarSpeed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numCarSpeed.Name = "numCarSpeed";
            this.numCarSpeed.Size = new System.Drawing.Size(90, 20);
            this.numCarSpeed.TabIndex = 38;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(452, 11);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(76, 13);
            this.label49.TabIndex = 37;
            this.label49.Text = "Vehicle Speed";
            // 
            // numCarCritterCapacity
            // 
            this.numCarCritterCapacity.Location = new System.Drawing.Point(352, 70);
            this.numCarCritterCapacity.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numCarCritterCapacity.Name = "numCarCritterCapacity";
            this.numCarCritterCapacity.Size = new System.Drawing.Size(90, 20);
            this.numCarCritterCapacity.TabIndex = 36;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(349, 54);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(78, 13);
            this.label48.TabIndex = 35;
            this.label48.Text = "Critter Capacity";
            // 
            // numCarPassability
            // 
            this.numCarPassability.Location = new System.Drawing.Point(352, 27);
            this.numCarPassability.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numCarPassability.Name = "numCarPassability";
            this.numCarPassability.Size = new System.Drawing.Size(90, 20);
            this.numCarPassability.TabIndex = 34;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(349, 11);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(56, 13);
            this.label47.TabIndex = 33;
            this.label47.Text = "Passability";
            // 
            // numCarFuelConsumption
            // 
            this.numCarFuelConsumption.Location = new System.Drawing.Point(235, 70);
            this.numCarFuelConsumption.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numCarFuelConsumption.Name = "numCarFuelConsumption";
            this.numCarFuelConsumption.Size = new System.Drawing.Size(90, 20);
            this.numCarFuelConsumption.TabIndex = 32;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(232, 54);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(91, 13);
            this.label46.TabIndex = 31;
            this.label46.Text = "Fuel Consumption";
            // 
            // numCarTankVolume
            // 
            this.numCarTankVolume.Location = new System.Drawing.Point(235, 27);
            this.numCarTankVolume.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numCarTankVolume.Name = "numCarTankVolume";
            this.numCarTankVolume.Size = new System.Drawing.Size(90, 20);
            this.numCarTankVolume.TabIndex = 30;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(232, 11);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(70, 13);
            this.label45.TabIndex = 29;
            this.label45.Text = "Tank Volume";
            // 
            // numCarMaxDeterioration
            // 
            this.numCarMaxDeterioration.Location = new System.Drawing.Point(120, 70);
            this.numCarMaxDeterioration.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numCarMaxDeterioration.Name = "numCarMaxDeterioration";
            this.numCarMaxDeterioration.Size = new System.Drawing.Size(90, 20);
            this.numCarMaxDeterioration.TabIndex = 28;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(117, 54);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(114, 13);
            this.label44.TabIndex = 27;
            this.label44.Text = "Maximum Deterioration";
            // 
            // numCarDeteriorationRate
            // 
            this.numCarDeteriorationRate.Location = new System.Drawing.Point(120, 26);
            this.numCarDeteriorationRate.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numCarDeteriorationRate.Name = "numCarDeteriorationRate";
            this.numCarDeteriorationRate.Size = new System.Drawing.Size(90, 20);
            this.numCarDeteriorationRate.TabIndex = 26;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(117, 11);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(93, 13);
            this.label43.TabIndex = 25;
            this.label43.Text = "Deterioration Rate";
            // 
            // grpCarMovementType
            // 
            this.grpCarMovementType.Controls.Add(this.rdbCarMovementTypeGround);
            this.grpCarMovementType.Controls.Add(this.rdbCarMovementTypeAir);
            this.grpCarMovementType.Controls.Add(this.rdbCarMovementTypeWater);
            this.grpCarMovementType.Location = new System.Drawing.Point(6, 6);
            this.grpCarMovementType.Name = "grpCarMovementType";
            this.grpCarMovementType.Size = new System.Drawing.Size(105, 86);
            this.grpCarMovementType.TabIndex = 24;
            this.grpCarMovementType.TabStop = false;
            this.grpCarMovementType.Text = "Movement Type";
            // 
            // rdbCarMovementTypeGround
            // 
            this.rdbCarMovementTypeGround.AutoSize = true;
            this.rdbCarMovementTypeGround.Location = new System.Drawing.Point(7, 20);
            this.rdbCarMovementTypeGround.Name = "rdbCarMovementTypeGround";
            this.rdbCarMovementTypeGround.Size = new System.Drawing.Size(60, 17);
            this.rdbCarMovementTypeGround.TabIndex = 0;
            this.rdbCarMovementTypeGround.TabStop = true;
            this.rdbCarMovementTypeGround.Text = "Ground";
            this.rdbCarMovementTypeGround.UseVisualStyleBackColor = true;
            // 
            // rdbCarMovementTypeAir
            // 
            this.rdbCarMovementTypeAir.AutoSize = true;
            this.rdbCarMovementTypeAir.Location = new System.Drawing.Point(7, 40);
            this.rdbCarMovementTypeAir.Name = "rdbCarMovementTypeAir";
            this.rdbCarMovementTypeAir.Size = new System.Drawing.Size(37, 17);
            this.rdbCarMovementTypeAir.TabIndex = 1;
            this.rdbCarMovementTypeAir.TabStop = true;
            this.rdbCarMovementTypeAir.Text = "Air";
            this.rdbCarMovementTypeAir.UseVisualStyleBackColor = true;
            // 
            // rdbCarMovementTypeWater
            // 
            this.rdbCarMovementTypeWater.AutoSize = true;
            this.rdbCarMovementTypeWater.Location = new System.Drawing.Point(7, 60);
            this.rdbCarMovementTypeWater.Name = "rdbCarMovementTypeWater";
            this.rdbCarMovementTypeWater.Size = new System.Drawing.Size(54, 17);
            this.rdbCarMovementTypeWater.TabIndex = 2;
            this.rdbCarMovementTypeWater.TabStop = true;
            this.rdbCarMovementTypeWater.Text = "Water";
            this.rdbCarMovementTypeWater.UseVisualStyleBackColor = true;
            // 
            // tabPageContainer
            // 
            this.tabPageContainer.Controls.Add(this.tabControlContainer);
            this.tabPageContainer.Location = new System.Drawing.Point(4, 22);
            this.tabPageContainer.Name = "tabPageContainer";
            this.tabPageContainer.Size = new System.Drawing.Size(772, 189);
            this.tabPageContainer.TabIndex = 4;
            this.tabPageContainer.Text = "Container";
            this.tabPageContainer.UseVisualStyleBackColor = true;
            // 
            // tabControlContainer
            // 
            this.tabControlContainer.Controls.Add(this.ContainerMain);
            this.tabControlContainer.Location = new System.Drawing.Point(3, 3);
            this.tabControlContainer.Name = "tabControlContainer";
            this.tabControlContainer.SelectedIndex = 0;
            this.tabControlContainer.Size = new System.Drawing.Size(764, 160);
            this.tabControlContainer.TabIndex = 5;
            // 
            // ContainerMain
            // 
            this.ContainerMain.Controls.Add(this.chkContainerMagicHandsGrnd);
            this.ContainerMain.Controls.Add(this.chkContainerCannotPickup);
            this.ContainerMain.Controls.Add(this.chkContainerChangable);
            this.ContainerMain.Controls.Add(this.numContainerVolume);
            this.ContainerMain.Controls.Add(this.label108);
            this.ContainerMain.Location = new System.Drawing.Point(4, 22);
            this.ContainerMain.Name = "ContainerMain";
            this.ContainerMain.Padding = new System.Windows.Forms.Padding(3);
            this.ContainerMain.Size = new System.Drawing.Size(756, 134);
            this.ContainerMain.TabIndex = 0;
            this.ContainerMain.Text = "Main";
            this.ContainerMain.UseVisualStyleBackColor = true;
            // 
            // chkContainerMagicHandsGrnd
            // 
            this.chkContainerMagicHandsGrnd.AutoSize = true;
            this.chkContainerMagicHandsGrnd.Location = new System.Drawing.Point(9, 70);
            this.chkContainerMagicHandsGrnd.Name = "chkContainerMagicHandsGrnd";
            this.chkContainerMagicHandsGrnd.Size = new System.Drawing.Size(109, 17);
            this.chkContainerMagicHandsGrnd.TabIndex = 9;
            this.chkContainerMagicHandsGrnd.Text = "MagicHandsGrnd";
            this.chkContainerMagicHandsGrnd.UseVisualStyleBackColor = true;
            // 
            // chkContainerCannotPickup
            // 
            this.chkContainerCannotPickup.AutoSize = true;
            this.chkContainerCannotPickup.Location = new System.Drawing.Point(9, 55);
            this.chkContainerCannotPickup.Name = "chkContainerCannotPickup";
            this.chkContainerCannotPickup.Size = new System.Drawing.Size(93, 17);
            this.chkContainerCannotPickup.TabIndex = 8;
            this.chkContainerCannotPickup.Text = "CannotPickup";
            this.chkContainerCannotPickup.UseVisualStyleBackColor = true;
            // 
            // chkContainerChangable
            // 
            this.chkContainerChangable.AutoSize = true;
            this.chkContainerChangable.Location = new System.Drawing.Point(9, 40);
            this.chkContainerChangable.Name = "chkContainerChangable";
            this.chkContainerChangable.Size = new System.Drawing.Size(77, 17);
            this.chkContainerChangable.TabIndex = 7;
            this.chkContainerChangable.Text = "Changable";
            this.chkContainerChangable.UseVisualStyleBackColor = true;
            // 
            // numContainerVolume
            // 
            this.numContainerVolume.Location = new System.Drawing.Point(102, 11);
            this.numContainerVolume.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numContainerVolume.Name = "numContainerVolume";
            this.numContainerVolume.Size = new System.Drawing.Size(75, 20);
            this.numContainerVolume.TabIndex = 6;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(6, 13);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(90, 13);
            this.label108.TabIndex = 5;
            this.label108.Text = "Container Volume";
            // 
            // tabPageDrug
            // 
            this.tabPageDrug.Controls.Add(this.tabControlDrug);
            this.tabPageDrug.Location = new System.Drawing.Point(4, 22);
            this.tabPageDrug.Name = "tabPageDrug";
            this.tabPageDrug.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDrug.Size = new System.Drawing.Size(772, 189);
            this.tabPageDrug.TabIndex = 1;
            this.tabPageDrug.Text = "Drug";
            this.tabPageDrug.UseVisualStyleBackColor = true;
            // 
            // tabControlDrug
            // 
            this.tabControlDrug.Controls.Add(this.DrugMain);
            this.tabControlDrug.Location = new System.Drawing.Point(3, 3);
            this.tabControlDrug.Name = "tabControlDrug";
            this.tabControlDrug.SelectedIndex = 0;
            this.tabControlDrug.Size = new System.Drawing.Size(764, 160);
            this.tabControlDrug.TabIndex = 6;
            // 
            // DrugMain
            // 
            this.DrugMain.Location = new System.Drawing.Point(4, 22);
            this.DrugMain.Name = "DrugMain";
            this.DrugMain.Padding = new System.Windows.Forms.Padding(3);
            this.DrugMain.Size = new System.Drawing.Size(756, 134);
            this.DrugMain.TabIndex = 0;
            this.DrugMain.Text = "Main";
            this.DrugMain.UseVisualStyleBackColor = true;
            // 
            // tabPageDoor
            // 
            this.tabPageDoor.Controls.Add(this.tabControlDoor);
            this.tabPageDoor.Location = new System.Drawing.Point(4, 22);
            this.tabPageDoor.Name = "tabPageDoor";
            this.tabPageDoor.Size = new System.Drawing.Size(772, 189);
            this.tabPageDoor.TabIndex = 6;
            this.tabPageDoor.Text = "Door";
            this.tabPageDoor.UseVisualStyleBackColor = true;
            // 
            // tabControlDoor
            // 
            this.tabControlDoor.Controls.Add(this.DoorMain);
            this.tabControlDoor.Location = new System.Drawing.Point(3, 3);
            this.tabControlDoor.Name = "tabControlDoor";
            this.tabControlDoor.SelectedIndex = 0;
            this.tabControlDoor.Size = new System.Drawing.Size(764, 160);
            this.tabControlDoor.TabIndex = 7;
            // 
            // DoorMain
            // 
            this.DoorMain.Controls.Add(this.chkDoorNoBlockShoot);
            this.DoorMain.Controls.Add(this.chkDoorNoBlockLight);
            this.DoorMain.Controls.Add(this.chkDoorNoBlockMove);
            this.DoorMain.Location = new System.Drawing.Point(4, 22);
            this.DoorMain.Name = "DoorMain";
            this.DoorMain.Padding = new System.Windows.Forms.Padding(3);
            this.DoorMain.Size = new System.Drawing.Size(756, 134);
            this.DoorMain.TabIndex = 0;
            this.DoorMain.Text = "Main";
            this.DoorMain.UseVisualStyleBackColor = true;
            // 
            // chkDoorNoBlockShoot
            // 
            this.chkDoorNoBlockShoot.AutoSize = true;
            this.chkDoorNoBlockShoot.Location = new System.Drawing.Point(6, 36);
            this.chkDoorNoBlockShoot.Name = "chkDoorNoBlockShoot";
            this.chkDoorNoBlockShoot.Size = new System.Drawing.Size(95, 17);
            this.chkDoorNoBlockShoot.TabIndex = 5;
            this.chkDoorNoBlockShoot.Text = "NoBlockShoot";
            this.chkDoorNoBlockShoot.UseVisualStyleBackColor = true;
            // 
            // chkDoorNoBlockLight
            // 
            this.chkDoorNoBlockLight.AutoSize = true;
            this.chkDoorNoBlockLight.Location = new System.Drawing.Point(6, 21);
            this.chkDoorNoBlockLight.Name = "chkDoorNoBlockLight";
            this.chkDoorNoBlockLight.Size = new System.Drawing.Size(90, 17);
            this.chkDoorNoBlockLight.TabIndex = 4;
            this.chkDoorNoBlockLight.Text = "NoBlockLight";
            this.chkDoorNoBlockLight.UseVisualStyleBackColor = true;
            // 
            // chkDoorNoBlockMove
            // 
            this.chkDoorNoBlockMove.AutoSize = true;
            this.chkDoorNoBlockMove.Location = new System.Drawing.Point(6, 6);
            this.chkDoorNoBlockMove.Name = "chkDoorNoBlockMove";
            this.chkDoorNoBlockMove.Size = new System.Drawing.Size(94, 17);
            this.chkDoorNoBlockMove.TabIndex = 3;
            this.chkDoorNoBlockMove.Text = "NoBlockMove";
            this.chkDoorNoBlockMove.UseVisualStyleBackColor = true;
            // 
            // tabPageGeneric
            // 
            this.tabPageGeneric.Controls.Add(this.tabControl3);
            this.tabPageGeneric.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneric.Name = "tabPageGeneric";
            this.tabPageGeneric.Size = new System.Drawing.Size(772, 189);
            this.tabPageGeneric.TabIndex = 10;
            this.tabPageGeneric.Text = "Generic";
            this.tabPageGeneric.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.GenericMain);
            this.tabControl3.Location = new System.Drawing.Point(3, 3);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(764, 160);
            this.tabControl3.TabIndex = 6;
            // 
            // GenericMain
            // 
            this.GenericMain.Location = new System.Drawing.Point(4, 22);
            this.GenericMain.Name = "GenericMain";
            this.GenericMain.Padding = new System.Windows.Forms.Padding(3);
            this.GenericMain.Size = new System.Drawing.Size(756, 134);
            this.GenericMain.TabIndex = 0;
            this.GenericMain.Text = "Main";
            this.GenericMain.UseVisualStyleBackColor = true;
            // 
            // tabPageGrid
            // 
            this.tabPageGrid.Controls.Add(this.tabControl1);
            this.tabPageGrid.Location = new System.Drawing.Point(4, 22);
            this.tabPageGrid.Name = "tabPageGrid";
            this.tabPageGrid.Size = new System.Drawing.Size(772, 189);
            this.tabPageGrid.TabIndex = 7;
            this.tabPageGrid.Text = "Grid";
            this.tabPageGrid.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 160);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpGridType);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 134);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpGridType
            // 
            this.grpGridType.Controls.Add(this.rdbNone);
            this.grpGridType.Controls.Add(this.rdbExitGrid);
            this.grpGridType.Controls.Add(this.rdbStairs);
            this.grpGridType.Controls.Add(this.rdbLadderBottom);
            this.grpGridType.Controls.Add(this.rdbLadderTop);
            this.grpGridType.Controls.Add(this.rdbElevator);
            this.grpGridType.Location = new System.Drawing.Point(6, 6);
            this.grpGridType.Name = "grpGridType";
            this.grpGridType.Size = new System.Drawing.Size(176, 99);
            this.grpGridType.TabIndex = 1;
            this.grpGridType.TabStop = false;
            this.grpGridType.Text = "Type";
            // 
            // rdbNone
            // 
            this.rdbNone.AutoSize = true;
            this.rdbNone.Location = new System.Drawing.Point(6, 20);
            this.rdbNone.Name = "rdbNone";
            this.rdbNone.Size = new System.Drawing.Size(51, 17);
            this.rdbNone.TabIndex = 5;
            this.rdbNone.TabStop = true;
            this.rdbNone.Text = "None";
            this.rdbNone.UseVisualStyleBackColor = true;
            // 
            // rdbExitGrid
            // 
            this.rdbExitGrid.AutoSize = true;
            this.rdbExitGrid.Location = new System.Drawing.Point(74, 66);
            this.rdbExitGrid.Name = "rdbExitGrid";
            this.rdbExitGrid.Size = new System.Drawing.Size(61, 17);
            this.rdbExitGrid.TabIndex = 0;
            this.rdbExitGrid.TabStop = true;
            this.rdbExitGrid.Text = "ExitGrid";
            this.rdbExitGrid.UseVisualStyleBackColor = true;
            // 
            // rdbStairs
            // 
            this.rdbStairs.AutoSize = true;
            this.rdbStairs.Location = new System.Drawing.Point(6, 43);
            this.rdbStairs.Name = "rdbStairs";
            this.rdbStairs.Size = new System.Drawing.Size(51, 17);
            this.rdbStairs.TabIndex = 1;
            this.rdbStairs.TabStop = true;
            this.rdbStairs.Text = "Stairs";
            this.rdbStairs.UseVisualStyleBackColor = true;
            // 
            // rdbLadderBottom
            // 
            this.rdbLadderBottom.AutoSize = true;
            this.rdbLadderBottom.Location = new System.Drawing.Point(74, 20);
            this.rdbLadderBottom.Name = "rdbLadderBottom";
            this.rdbLadderBottom.Size = new System.Drawing.Size(91, 17);
            this.rdbLadderBottom.TabIndex = 2;
            this.rdbLadderBottom.TabStop = true;
            this.rdbLadderBottom.Text = "LadderBottom";
            this.rdbLadderBottom.UseVisualStyleBackColor = true;
            // 
            // rdbLadderTop
            // 
            this.rdbLadderTop.AutoSize = true;
            this.rdbLadderTop.Location = new System.Drawing.Point(74, 43);
            this.rdbLadderTop.Name = "rdbLadderTop";
            this.rdbLadderTop.Size = new System.Drawing.Size(77, 17);
            this.rdbLadderTop.TabIndex = 3;
            this.rdbLadderTop.TabStop = true;
            this.rdbLadderTop.Text = "LadderTop";
            this.rdbLadderTop.UseVisualStyleBackColor = true;
            // 
            // rdbElevator
            // 
            this.rdbElevator.AutoSize = true;
            this.rdbElevator.Location = new System.Drawing.Point(7, 66);
            this.rdbElevator.Name = "rdbElevator";
            this.rdbElevator.Size = new System.Drawing.Size(64, 17);
            this.rdbElevator.TabIndex = 4;
            this.rdbElevator.TabStop = true;
            this.rdbElevator.Text = "Elevator";
            this.rdbElevator.UseVisualStyleBackColor = true;
            // 
            // tabPageKey
            // 
            this.tabPageKey.Controls.Add(this.tabControl4);
            this.tabPageKey.Location = new System.Drawing.Point(4, 22);
            this.tabPageKey.Name = "tabPageKey";
            this.tabPageKey.Size = new System.Drawing.Size(772, 189);
            this.tabPageKey.TabIndex = 9;
            this.tabPageKey.Text = "Key";
            this.tabPageKey.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.KeyMain);
            this.tabControl4.Location = new System.Drawing.Point(3, 3);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(764, 160);
            this.tabControl4.TabIndex = 6;
            // 
            // KeyMain
            // 
            this.KeyMain.Location = new System.Drawing.Point(4, 22);
            this.KeyMain.Name = "KeyMain";
            this.KeyMain.Padding = new System.Windows.Forms.Padding(3);
            this.KeyMain.Size = new System.Drawing.Size(756, 134);
            this.KeyMain.TabIndex = 0;
            this.KeyMain.Text = "Main";
            this.KeyMain.UseVisualStyleBackColor = true;
            // 
            // tabPageMisc
            // 
            this.tabPageMisc.Controls.Add(this.tabControl5);
            this.tabPageMisc.Location = new System.Drawing.Point(4, 22);
            this.tabPageMisc.Name = "tabPageMisc";
            this.tabPageMisc.Size = new System.Drawing.Size(772, 189);
            this.tabPageMisc.TabIndex = 8;
            this.tabPageMisc.Text = "Misc";
            this.tabPageMisc.UseVisualStyleBackColor = true;
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.MiscMain);
            this.tabControl5.Location = new System.Drawing.Point(3, 3);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(764, 160);
            this.tabControl5.TabIndex = 6;
            // 
            // MiscMain
            // 
            this.MiscMain.Location = new System.Drawing.Point(4, 22);
            this.MiscMain.Name = "MiscMain";
            this.MiscMain.Padding = new System.Windows.Forms.Padding(3);
            this.MiscMain.Size = new System.Drawing.Size(756, 134);
            this.MiscMain.TabIndex = 0;
            this.MiscMain.Text = "Main";
            this.MiscMain.UseVisualStyleBackColor = true;
            // 
            // tabPageWall
            // 
            this.tabPageWall.Controls.Add(this.tabControl6);
            this.tabPageWall.Location = new System.Drawing.Point(4, 22);
            this.tabPageWall.Name = "tabPageWall";
            this.tabPageWall.Size = new System.Drawing.Size(772, 189);
            this.tabPageWall.TabIndex = 11;
            this.tabPageWall.Text = "Wall";
            this.tabPageWall.UseVisualStyleBackColor = true;
            // 
            // tabControl6
            // 
            this.tabControl6.Controls.Add(this.WallMain);
            this.tabControl6.Location = new System.Drawing.Point(3, 3);
            this.tabControl6.Name = "tabControl6";
            this.tabControl6.SelectedIndex = 0;
            this.tabControl6.Size = new System.Drawing.Size(764, 160);
            this.tabControl6.TabIndex = 6;
            // 
            // WallMain
            // 
            this.WallMain.Location = new System.Drawing.Point(4, 22);
            this.WallMain.Name = "WallMain";
            this.WallMain.Padding = new System.Windows.Forms.Padding(3);
            this.WallMain.Size = new System.Drawing.Size(756, 134);
            this.WallMain.TabIndex = 0;
            this.WallMain.Text = "Main";
            this.WallMain.UseVisualStyleBackColor = true;
            // 
            // tabPageWeapon
            // 
            this.tabPageWeapon.Controls.Add(this.tabControlWeapon);
            this.tabPageWeapon.Location = new System.Drawing.Point(4, 22);
            this.tabPageWeapon.Name = "tabPageWeapon";
            this.tabPageWeapon.Size = new System.Drawing.Size(772, 189);
            this.tabPageWeapon.TabIndex = 2;
            this.tabPageWeapon.Text = "Weapon";
            this.tabPageWeapon.UseVisualStyleBackColor = true;
            // 
            // tabControlWeapon
            // 
            this.tabControlWeapon.Controls.Add(this.WeaponMain);
            this.tabControlWeapon.Controls.Add(this.WeaponAttack1);
            this.tabControlWeapon.Controls.Add(this.WeaponAttack2);
            this.tabControlWeapon.Controls.Add(this.WeaponAttack3);
            this.tabControlWeapon.Location = new System.Drawing.Point(3, 3);
            this.tabControlWeapon.Name = "tabControlWeapon";
            this.tabControlWeapon.SelectedIndex = 0;
            this.tabControlWeapon.Size = new System.Drawing.Size(766, 159);
            this.tabControlWeapon.TabIndex = 0;
            // 
            // WeaponMain
            // 
            this.WeaponMain.Controls.Add(this.grpUnarmed);
            this.WeaponMain.Controls.Add(this.chkIsUnarmed);
            this.WeaponMain.Controls.Add(this.numMinStrength);
            this.WeaponMain.Controls.Add(this.label80);
            this.WeaponMain.Controls.Add(this.cmdWeaponDefaultAmmo);
            this.WeaponMain.Controls.Add(this.label79);
            this.WeaponMain.Controls.Add(this.cmbCaliberWeapon);
            this.WeaponMain.Controls.Add(this.label78);
            this.WeaponMain.Controls.Add(this.numMaxAmmoCount);
            this.WeaponMain.Controls.Add(this.label77);
            this.WeaponMain.Controls.Add(this.cmbAnim1);
            this.WeaponMain.Controls.Add(this.cmbWeaponPerk);
            this.WeaponMain.Controls.Add(this.label76);
            this.WeaponMain.Controls.Add(this.numCriticalFailure);
            this.WeaponMain.Controls.Add(this.label75);
            this.WeaponMain.Controls.Add(this.label74);
            this.WeaponMain.Location = new System.Drawing.Point(4, 22);
            this.WeaponMain.Name = "WeaponMain";
            this.WeaponMain.Padding = new System.Windows.Forms.Padding(3);
            this.WeaponMain.Size = new System.Drawing.Size(758, 133);
            this.WeaponMain.TabIndex = 0;
            this.WeaponMain.Text = "Main";
            this.WeaponMain.UseVisualStyleBackColor = true;
            // 
            // grpUnarmed
            // 
            this.grpUnarmed.Controls.Add(this.numUnarmedCriticalBonus);
            this.grpUnarmed.Controls.Add(this.label86);
            this.grpUnarmed.Controls.Add(this.chkArmorPiercing);
            this.grpUnarmed.Controls.Add(this.label85);
            this.grpUnarmed.Controls.Add(this.label84);
            this.grpUnarmed.Controls.Add(this.numMinLevel);
            this.grpUnarmed.Controls.Add(this.numMinUnarmed);
            this.grpUnarmed.Controls.Add(this.numMinAgility);
            this.grpUnarmed.Controls.Add(this.label83);
            this.grpUnarmed.Controls.Add(this.numUnarmedPriority);
            this.grpUnarmed.Controls.Add(this.label82);
            this.grpUnarmed.Controls.Add(this.numUnarmedTree);
            this.grpUnarmed.Controls.Add(this.label81);
            this.grpUnarmed.Location = new System.Drawing.Point(525, 7);
            this.grpUnarmed.Name = "grpUnarmed";
            this.grpUnarmed.Size = new System.Drawing.Size(227, 120);
            this.grpUnarmed.TabIndex = 16;
            this.grpUnarmed.TabStop = false;
            this.grpUnarmed.Text = "Unarmed";
            this.grpUnarmed.Visible = false;
            // 
            // numUnarmedCriticalBonus
            // 
            this.numUnarmedCriticalBonus.Location = new System.Drawing.Point(162, 76);
            this.numUnarmedCriticalBonus.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUnarmedCriticalBonus.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numUnarmedCriticalBonus.Name = "numUnarmedCriticalBonus";
            this.numUnarmedCriticalBonus.Size = new System.Drawing.Size(57, 20);
            this.numUnarmedCriticalBonus.TabIndex = 12;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(159, 60);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(71, 13);
            this.label86.TabIndex = 11;
            this.label86.Text = "Critical Bonus";
            // 
            // chkArmorPiercing
            // 
            this.chkArmorPiercing.Location = new System.Drawing.Point(162, 15);
            this.chkArmorPiercing.Name = "chkArmorPiercing";
            this.chkArmorPiercing.Size = new System.Drawing.Size(65, 31);
            this.chkArmorPiercing.TabIndex = 10;
            this.chkArmorPiercing.Text = "Armor Piercing";
            this.chkArmorPiercing.UseVisualStyleBackColor = true;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(13, 96);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(53, 13);
            this.label85.TabIndex = 9;
            this.label85.Text = "Min Level";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(13, 77);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(70, 13);
            this.label84.TabIndex = 8;
            this.label84.Text = "Min Unarmed";
            // 
            // numMinLevel
            // 
            this.numMinLevel.Location = new System.Drawing.Point(99, 94);
            this.numMinLevel.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMinLevel.Name = "numMinLevel";
            this.numMinLevel.Size = new System.Drawing.Size(57, 20);
            this.numMinLevel.TabIndex = 7;
            // 
            // numMinUnarmed
            // 
            this.numMinUnarmed.Location = new System.Drawing.Point(99, 75);
            this.numMinUnarmed.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numMinUnarmed.Name = "numMinUnarmed";
            this.numMinUnarmed.Size = new System.Drawing.Size(57, 20);
            this.numMinUnarmed.TabIndex = 6;
            // 
            // numMinAgility
            // 
            this.numMinAgility.Location = new System.Drawing.Point(99, 55);
            this.numMinAgility.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numMinAgility.Name = "numMinAgility";
            this.numMinAgility.Size = new System.Drawing.Size(57, 20);
            this.numMinAgility.TabIndex = 5;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(13, 57);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(54, 13);
            this.label83.TabIndex = 4;
            this.label83.Text = "Min Agility";
            // 
            // numUnarmedPriority
            // 
            this.numUnarmedPriority.Location = new System.Drawing.Point(99, 35);
            this.numUnarmedPriority.Name = "numUnarmedPriority";
            this.numUnarmedPriority.Size = new System.Drawing.Size(57, 20);
            this.numUnarmedPriority.TabIndex = 3;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(13, 37);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(84, 13);
            this.label82.TabIndex = 2;
            this.label82.Text = "Unarmed Priority";
            // 
            // numUnarmedTree
            // 
            this.numUnarmedTree.Location = new System.Drawing.Point(99, 15);
            this.numUnarmedTree.Name = "numUnarmedTree";
            this.numUnarmedTree.Size = new System.Drawing.Size(57, 20);
            this.numUnarmedTree.TabIndex = 1;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(13, 16);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(75, 13);
            this.label81.TabIndex = 0;
            this.label81.Text = "Unarmed Tree";
            // 
            // chkIsUnarmed
            // 
            this.chkIsUnarmed.AutoSize = true;
            this.chkIsUnarmed.Location = new System.Drawing.Point(428, 7);
            this.chkIsUnarmed.Name = "chkIsUnarmed";
            this.chkIsUnarmed.Size = new System.Drawing.Size(103, 17);
            this.chkIsUnarmed.TabIndex = 15;
            this.chkIsUnarmed.Text = "Unarmed Attack";
            this.chkIsUnarmed.UseVisualStyleBackColor = true;
            this.chkIsUnarmed.CheckedChanged += new System.EventHandler(this.chkIsUnarmed_CheckedChanged);
            // 
            // numMinStrength
            // 
            this.numMinStrength.Location = new System.Drawing.Point(345, 49);
            this.numMinStrength.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numMinStrength.Name = "numMinStrength";
            this.numMinStrength.Size = new System.Drawing.Size(77, 20);
            this.numMinStrength.TabIndex = 14;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(251, 51);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(67, 13);
            this.label80.TabIndex = 13;
            this.label80.Text = "Min Strength";
            // 
            // cmdWeaponDefaultAmmo
            // 
            this.cmdWeaponDefaultAmmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdWeaponDefaultAmmo.DropDownWidth = 250;
            this.cmdWeaponDefaultAmmo.FormattingEnabled = true;
            this.cmdWeaponDefaultAmmo.Location = new System.Drawing.Point(95, 76);
            this.cmdWeaponDefaultAmmo.Name = "cmdWeaponDefaultAmmo";
            this.cmdWeaponDefaultAmmo.Size = new System.Drawing.Size(150, 21);
            this.cmdWeaponDefaultAmmo.Sorted = true;
            this.cmdWeaponDefaultAmmo.TabIndex = 12;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(6, 79);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(73, 13);
            this.label79.TabIndex = 11;
            this.label79.Text = "Default Ammo";
            // 
            // cmbCaliberWeapon
            // 
            this.cmbCaliberWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaliberWeapon.DropDownWidth = 250;
            this.cmbCaliberWeapon.FormattingEnabled = true;
            this.cmbCaliberWeapon.Location = new System.Drawing.Point(94, 54);
            this.cmbCaliberWeapon.Name = "cmbCaliberWeapon";
            this.cmbCaliberWeapon.Size = new System.Drawing.Size(151, 21);
            this.cmbCaliberWeapon.TabIndex = 10;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(6, 57);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(39, 13);
            this.label78.TabIndex = 9;
            this.label78.Text = "Caliber";
            // 
            // numMaxAmmoCount
            // 
            this.numMaxAmmoCount.Location = new System.Drawing.Point(345, 7);
            this.numMaxAmmoCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMaxAmmoCount.Name = "numMaxAmmoCount";
            this.numMaxAmmoCount.Size = new System.Drawing.Size(77, 20);
            this.numMaxAmmoCount.TabIndex = 8;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(251, 10);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(90, 13);
            this.label77.TabIndex = 7;
            this.label77.Text = "Max Ammo Count";
            // 
            // cmbAnim1
            // 
            this.cmbAnim1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnim1.DropDownWidth = 250;
            this.cmbAnim1.FormattingEnabled = true;
            this.cmbAnim1.Location = new System.Drawing.Point(94, 10);
            this.cmbAnim1.Name = "cmbAnim1";
            this.cmbAnim1.Size = new System.Drawing.Size(151, 21);
            this.cmbAnim1.TabIndex = 6;
            // 
            // cmbWeaponPerk
            // 
            this.cmbWeaponPerk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeaponPerk.DropDownWidth = 250;
            this.cmbWeaponPerk.FormattingEnabled = true;
            this.cmbWeaponPerk.Location = new System.Drawing.Point(94, 32);
            this.cmbWeaponPerk.Name = "cmbWeaponPerk";
            this.cmbWeaponPerk.Size = new System.Drawing.Size(151, 21);
            this.cmbWeaponPerk.TabIndex = 5;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(6, 35);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(73, 13);
            this.label76.TabIndex = 4;
            this.label76.Text = "Weapon Perk";
            // 
            // numCriticalFailure
            // 
            this.numCriticalFailure.Location = new System.Drawing.Point(345, 28);
            this.numCriticalFailure.Name = "numCriticalFailure";
            this.numCriticalFailure.Size = new System.Drawing.Size(77, 20);
            this.numCriticalFailure.TabIndex = 3;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(251, 30);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(72, 13);
            this.label75.TabIndex = 2;
            this.label75.Text = "Critical Failure";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(6, 13);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(85, 13);
            this.label74.TabIndex = 0;
            this.label74.Text = "Anim1 Animation";
            // 
            // WeaponAttack1
            // 
            this.WeaponAttack1.Controls.Add(this.numWeaponFlyEffect1);
            this.WeaponAttack1.Controls.Add(this.numWeaponDmgMax1);
            this.WeaponAttack1.Controls.Add(this.numWeaponDmgMin1);
            this.WeaponAttack1.Controls.Add(this.label11);
            this.WeaponAttack1.Controls.Add(this.label10);
            this.WeaponAttack1.Controls.Add(this.label9);
            this.WeaponAttack1.Controls.Add(this.chkWeaponRemove1);
            this.WeaponAttack1.Controls.Add(this.cmbDmgType1);
            this.WeaponAttack1.Controls.Add(this.label6);
            this.WeaponAttack1.Controls.Add(this.cmbWeaponAnim2_1);
            this.WeaponAttack1.Controls.Add(this.label1);
            this.WeaponAttack1.Controls.Add(this.label99);
            this.WeaponAttack1.Controls.Add(this.txtUseGraphics1);
            this.WeaponAttack1.Controls.Add(this.label98);
            this.WeaponAttack1.Controls.Add(this.txtSoundId1);
            this.WeaponAttack1.Controls.Add(this.label95);
            this.WeaponAttack1.Controls.Add(this.label94);
            this.WeaponAttack1.Controls.Add(this.numBulletsRound1);
            this.WeaponAttack1.Controls.Add(this.numDistance1);
            this.WeaponAttack1.Controls.Add(this.numAttackAP1);
            this.WeaponAttack1.Controls.Add(this.label91);
            this.WeaponAttack1.Controls.Add(this.label90);
            this.WeaponAttack1.Controls.Add(this.chkAimAvailable1);
            this.WeaponAttack1.Controls.Add(this.label88);
            this.WeaponAttack1.Controls.Add(this.cmbWeaponSkill1);
            this.WeaponAttack1.Controls.Add(this.chkActive1);
            this.WeaponAttack1.Location = new System.Drawing.Point(4, 22);
            this.WeaponAttack1.Name = "WeaponAttack1";
            this.WeaponAttack1.Padding = new System.Windows.Forms.Padding(3);
            this.WeaponAttack1.Size = new System.Drawing.Size(758, 133);
            this.WeaponAttack1.TabIndex = 1;
            this.WeaponAttack1.Text = "Attack 1";
            this.WeaponAttack1.UseVisualStyleBackColor = true;
            // 
            // numWeaponFlyEffect1
            // 
            this.numWeaponFlyEffect1.Location = new System.Drawing.Point(474, 79);
            this.numWeaponFlyEffect1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numWeaponFlyEffect1.Name = "numWeaponFlyEffect1";
            this.numWeaponFlyEffect1.Size = new System.Drawing.Size(72, 20);
            this.numWeaponFlyEffect1.TabIndex = 36;
            // 
            // numWeaponDmgMax1
            // 
            this.numWeaponDmgMax1.Location = new System.Drawing.Point(474, 55);
            this.numWeaponDmgMax1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numWeaponDmgMax1.Name = "numWeaponDmgMax1";
            this.numWeaponDmgMax1.Size = new System.Drawing.Size(72, 20);
            this.numWeaponDmgMax1.TabIndex = 35;
            // 
            // numWeaponDmgMin1
            // 
            this.numWeaponDmgMin1.Location = new System.Drawing.Point(474, 31);
            this.numWeaponDmgMin1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numWeaponDmgMin1.Name = "numWeaponDmgMin1";
            this.numWeaponDmgMin1.Size = new System.Drawing.Size(72, 20);
            this.numWeaponDmgMin1.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(402, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "FlyEffect";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(401, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Damage Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Damage Min";
            // 
            // chkWeaponRemove1
            // 
            this.chkWeaponRemove1.AutoSize = true;
            this.chkWeaponRemove1.Location = new System.Drawing.Point(628, 8);
            this.chkWeaponRemove1.Name = "chkWeaponRemove1";
            this.chkWeaponRemove1.Size = new System.Drawing.Size(123, 17);
            this.chkWeaponRemove1.TabIndex = 30;
            this.chkWeaponRemove1.Text = "Remove after attack";
            this.chkWeaponRemove1.UseVisualStyleBackColor = true;
            // 
            // cmbDmgType1
            // 
            this.cmbDmgType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDmgType1.FormattingEnabled = true;
            this.cmbDmgType1.Location = new System.Drawing.Point(60, 72);
            this.cmbDmgType1.Name = "cmbDmgType1";
            this.cmbDmgType1.Size = new System.Drawing.Size(109, 21);
            this.cmbDmgType1.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "DmgType";
            // 
            // cmbWeaponAnim2_1
            // 
            this.cmbWeaponAnim2_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeaponAnim2_1.FormattingEnabled = true;
            this.cmbWeaponAnim2_1.Location = new System.Drawing.Point(60, 49);
            this.cmbWeaponAnim2_1.Name = "cmbWeaponAnim2_1";
            this.cmbWeaponAnim2_1.Size = new System.Drawing.Size(109, 21);
            this.cmbWeaponAnim2_1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Anim2";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(670, 27);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(68, 73);
            this.label99.TabIndex = 25;
            this.label99.Text = "1";
            // 
            // txtUseGraphics1
            // 
            this.txtUseGraphics1.Location = new System.Drawing.Point(323, 6);
            this.txtUseGraphics1.Name = "txtUseGraphics1";
            this.txtUseGraphics1.Size = new System.Drawing.Size(196, 20);
            this.txtUseGraphics1.TabIndex = 22;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(249, 8);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(71, 13);
            this.label98.TabIndex = 21;
            this.label98.Text = "Use Graphics";
            // 
            // txtSoundId1
            // 
            this.txtSoundId1.Location = new System.Drawing.Point(584, 7);
            this.txtSoundId1.Name = "txtSoundId1";
            this.txtSoundId1.Size = new System.Drawing.Size(33, 20);
            this.txtSoundId1.TabIndex = 18;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(525, 9);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(50, 13);
            this.label95.TabIndex = 17;
            this.label95.Text = "Sound Id";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(249, 34);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(73, 13);
            this.label94.TabIndex = 16;
            this.label94.Text = "Bullets Round";
            // 
            // numBulletsRound1
            // 
            this.numBulletsRound1.Location = new System.Drawing.Point(323, 31);
            this.numBulletsRound1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBulletsRound1.Name = "numBulletsRound1";
            this.numBulletsRound1.Size = new System.Drawing.Size(72, 20);
            this.numBulletsRound1.TabIndex = 15;
            // 
            // numDistance1
            // 
            this.numDistance1.Location = new System.Drawing.Point(323, 80);
            this.numDistance1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDistance1.Name = "numDistance1";
            this.numDistance1.Size = new System.Drawing.Size(73, 20);
            this.numDistance1.TabIndex = 13;
            // 
            // numAttackAP1
            // 
            this.numAttackAP1.Location = new System.Drawing.Point(323, 57);
            this.numAttackAP1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAttackAP1.Name = "numAttackAP1";
            this.numAttackAP1.Size = new System.Drawing.Size(73, 20);
            this.numAttackAP1.TabIndex = 12;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(249, 81);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(49, 13);
            this.label91.TabIndex = 8;
            this.label91.Text = "Distance";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(249, 58);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(55, 13);
            this.label90.TabIndex = 7;
            this.label90.Text = "Attack AP";
            // 
            // chkAimAvailable1
            // 
            this.chkAimAvailable1.AutoSize = true;
            this.chkAimAvailable1.Location = new System.Drawing.Point(154, 4);
            this.chkAimAvailable1.Name = "chkAimAvailable1";
            this.chkAimAvailable1.Size = new System.Drawing.Size(89, 17);
            this.chkAimAvailable1.TabIndex = 3;
            this.chkAimAvailable1.Text = "Aim Available";
            this.chkAimAvailable1.UseVisualStyleBackColor = true;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(2, 29);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(26, 13);
            this.label88.TabIndex = 2;
            this.label88.Text = "Skill";
            // 
            // cmbWeaponSkill1
            // 
            this.cmbWeaponSkill1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeaponSkill1.FormattingEnabled = true;
            this.cmbWeaponSkill1.Location = new System.Drawing.Point(60, 26);
            this.cmbWeaponSkill1.Name = "cmbWeaponSkill1";
            this.cmbWeaponSkill1.Size = new System.Drawing.Size(109, 21);
            this.cmbWeaponSkill1.TabIndex = 1;
            // 
            // chkActive1
            // 
            this.chkActive1.AutoSize = true;
            this.chkActive1.Checked = true;
            this.chkActive1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive1.Location = new System.Drawing.Point(3, 3);
            this.chkActive1.Name = "chkActive1";
            this.chkActive1.Size = new System.Drawing.Size(56, 17);
            this.chkActive1.TabIndex = 0;
            this.chkActive1.Text = "Active";
            this.chkActive1.UseVisualStyleBackColor = true;
            this.chkActive1.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // WeaponAttack2
            // 
            this.WeaponAttack2.Controls.Add(this.numWeaponFlyEffect2);
            this.WeaponAttack2.Controls.Add(this.numWeaponDmgMax2);
            this.WeaponAttack2.Controls.Add(this.numWeaponDmgMin2);
            this.WeaponAttack2.Controls.Add(this.label12);
            this.WeaponAttack2.Controls.Add(this.label13);
            this.WeaponAttack2.Controls.Add(this.label109);
            this.WeaponAttack2.Controls.Add(this.chkWeaponRemove2);
            this.WeaponAttack2.Controls.Add(this.cmbDmgType2);
            this.WeaponAttack2.Controls.Add(this.label7);
            this.WeaponAttack2.Controls.Add(this.cmbWeaponAnim2_2);
            this.WeaponAttack2.Controls.Add(this.label2);
            this.WeaponAttack2.Controls.Add(this.txtUseGraphics2);
            this.WeaponAttack2.Controls.Add(this.label89);
            this.WeaponAttack2.Controls.Add(this.txtSoundId2);
            this.WeaponAttack2.Controls.Add(this.label92);
            this.WeaponAttack2.Controls.Add(this.label93);
            this.WeaponAttack2.Controls.Add(this.numBulletsRound2);
            this.WeaponAttack2.Controls.Add(this.numDistance2);
            this.WeaponAttack2.Controls.Add(this.numAttackAP2);
            this.WeaponAttack2.Controls.Add(this.label96);
            this.WeaponAttack2.Controls.Add(this.label97);
            this.WeaponAttack2.Controls.Add(this.chkAimAvailable2);
            this.WeaponAttack2.Controls.Add(this.label101);
            this.WeaponAttack2.Controls.Add(this.cmbWeaponSkill2);
            this.WeaponAttack2.Controls.Add(this.chkActive2);
            this.WeaponAttack2.Controls.Add(this.label100);
            this.WeaponAttack2.Location = new System.Drawing.Point(4, 22);
            this.WeaponAttack2.Name = "WeaponAttack2";
            this.WeaponAttack2.Size = new System.Drawing.Size(758, 133);
            this.WeaponAttack2.TabIndex = 4;
            this.WeaponAttack2.Text = "Attack 2";
            this.WeaponAttack2.UseVisualStyleBackColor = true;
            // 
            // numWeaponFlyEffect2
            // 
            this.numWeaponFlyEffect2.Location = new System.Drawing.Point(474, 79);
            this.numWeaponFlyEffect2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numWeaponFlyEffect2.Name = "numWeaponFlyEffect2";
            this.numWeaponFlyEffect2.Size = new System.Drawing.Size(72, 20);
            this.numWeaponFlyEffect2.TabIndex = 76;
            // 
            // numWeaponDmgMax2
            // 
            this.numWeaponDmgMax2.Location = new System.Drawing.Point(474, 55);
            this.numWeaponDmgMax2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numWeaponDmgMax2.Name = "numWeaponDmgMax2";
            this.numWeaponDmgMax2.Size = new System.Drawing.Size(72, 20);
            this.numWeaponDmgMax2.TabIndex = 75;
            // 
            // numWeaponDmgMin2
            // 
            this.numWeaponDmgMin2.Location = new System.Drawing.Point(474, 31);
            this.numWeaponDmgMin2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numWeaponDmgMin2.Name = "numWeaponDmgMin2";
            this.numWeaponDmgMin2.Size = new System.Drawing.Size(72, 20);
            this.numWeaponDmgMin2.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(402, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 73;
            this.label12.Text = "FlyEffect";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(401, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 72;
            this.label13.Text = "Damage Max";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(401, 33);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(67, 13);
            this.label109.TabIndex = 71;
            this.label109.Text = "Damage Min";
            // 
            // chkWeaponRemove2
            // 
            this.chkWeaponRemove2.AutoSize = true;
            this.chkWeaponRemove2.Location = new System.Drawing.Point(628, 8);
            this.chkWeaponRemove2.Name = "chkWeaponRemove2";
            this.chkWeaponRemove2.Size = new System.Drawing.Size(123, 17);
            this.chkWeaponRemove2.TabIndex = 70;
            this.chkWeaponRemove2.Text = "Remove after attack";
            this.chkWeaponRemove2.UseVisualStyleBackColor = true;
            // 
            // cmbDmgType2
            // 
            this.cmbDmgType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDmgType2.FormattingEnabled = true;
            this.cmbDmgType2.Location = new System.Drawing.Point(60, 72);
            this.cmbDmgType2.Name = "cmbDmgType2";
            this.cmbDmgType2.Size = new System.Drawing.Size(109, 21);
            this.cmbDmgType2.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "DmgType";
            // 
            // cmbWeaponAnim2_2
            // 
            this.cmbWeaponAnim2_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeaponAnim2_2.FormattingEnabled = true;
            this.cmbWeaponAnim2_2.Location = new System.Drawing.Point(60, 49);
            this.cmbWeaponAnim2_2.Name = "cmbWeaponAnim2_2";
            this.cmbWeaponAnim2_2.Size = new System.Drawing.Size(109, 21);
            this.cmbWeaponAnim2_2.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Anim2";
            // 
            // txtUseGraphics2
            // 
            this.txtUseGraphics2.Location = new System.Drawing.Point(323, 6);
            this.txtUseGraphics2.Name = "txtUseGraphics2";
            this.txtUseGraphics2.Size = new System.Drawing.Size(196, 20);
            this.txtUseGraphics2.TabIndex = 65;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(249, 8);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(71, 13);
            this.label89.TabIndex = 64;
            this.label89.Text = "Use Graphics";
            // 
            // txtSoundId2
            // 
            this.txtSoundId2.Location = new System.Drawing.Point(584, 7);
            this.txtSoundId2.Name = "txtSoundId2";
            this.txtSoundId2.Size = new System.Drawing.Size(33, 20);
            this.txtSoundId2.TabIndex = 63;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(525, 9);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(50, 13);
            this.label92.TabIndex = 62;
            this.label92.Text = "Sound Id";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(249, 34);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(73, 13);
            this.label93.TabIndex = 61;
            this.label93.Text = "Bullets Round";
            // 
            // numBulletsRound2
            // 
            this.numBulletsRound2.Location = new System.Drawing.Point(323, 31);
            this.numBulletsRound2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBulletsRound2.Name = "numBulletsRound2";
            this.numBulletsRound2.Size = new System.Drawing.Size(72, 20);
            this.numBulletsRound2.TabIndex = 60;
            // 
            // numDistance2
            // 
            this.numDistance2.Location = new System.Drawing.Point(323, 80);
            this.numDistance2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDistance2.Name = "numDistance2";
            this.numDistance2.Size = new System.Drawing.Size(73, 20);
            this.numDistance2.TabIndex = 59;
            // 
            // numAttackAP2
            // 
            this.numAttackAP2.Location = new System.Drawing.Point(323, 57);
            this.numAttackAP2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAttackAP2.Name = "numAttackAP2";
            this.numAttackAP2.Size = new System.Drawing.Size(73, 20);
            this.numAttackAP2.TabIndex = 58;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(249, 81);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(49, 13);
            this.label96.TabIndex = 57;
            this.label96.Text = "Distance";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(249, 58);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(55, 13);
            this.label97.TabIndex = 56;
            this.label97.Text = "Attack AP";
            // 
            // chkAimAvailable2
            // 
            this.chkAimAvailable2.AutoSize = true;
            this.chkAimAvailable2.Location = new System.Drawing.Point(154, 4);
            this.chkAimAvailable2.Name = "chkAimAvailable2";
            this.chkAimAvailable2.Size = new System.Drawing.Size(89, 17);
            this.chkAimAvailable2.TabIndex = 55;
            this.chkAimAvailable2.Text = "Aim Available";
            this.chkAimAvailable2.UseVisualStyleBackColor = true;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(2, 29);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(26, 13);
            this.label101.TabIndex = 54;
            this.label101.Text = "Skill";
            // 
            // cmbWeaponSkill2
            // 
            this.cmbWeaponSkill2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeaponSkill2.FormattingEnabled = true;
            this.cmbWeaponSkill2.Location = new System.Drawing.Point(60, 26);
            this.cmbWeaponSkill2.Name = "cmbWeaponSkill2";
            this.cmbWeaponSkill2.Size = new System.Drawing.Size(109, 21);
            this.cmbWeaponSkill2.TabIndex = 53;
            // 
            // chkActive2
            // 
            this.chkActive2.AutoSize = true;
            this.chkActive2.Checked = true;
            this.chkActive2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive2.Location = new System.Drawing.Point(3, 3);
            this.chkActive2.Name = "chkActive2";
            this.chkActive2.Size = new System.Drawing.Size(56, 17);
            this.chkActive2.TabIndex = 52;
            this.chkActive2.Text = "Active";
            this.chkActive2.UseVisualStyleBackColor = true;
            this.chkActive2.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(670, 27);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(68, 73);
            this.label100.TabIndex = 51;
            this.label100.Text = "2";
            // 
            // WeaponAttack3
            // 
            this.WeaponAttack3.Controls.Add(this.numWeaponFlyEffect3);
            this.WeaponAttack3.Controls.Add(this.numWeaponDmgMax3);
            this.WeaponAttack3.Controls.Add(this.numWeaponDmgMin3);
            this.WeaponAttack3.Controls.Add(this.label110);
            this.WeaponAttack3.Controls.Add(this.label111);
            this.WeaponAttack3.Controls.Add(this.label113);
            this.WeaponAttack3.Controls.Add(this.chkWeaponRemove3);
            this.WeaponAttack3.Controls.Add(this.cmbDmgType3);
            this.WeaponAttack3.Controls.Add(this.label8);
            this.WeaponAttack3.Controls.Add(this.cmbWeaponAnim2_3);
            this.WeaponAttack3.Controls.Add(this.label5);
            this.WeaponAttack3.Controls.Add(this.txtUseGraphics3);
            this.WeaponAttack3.Controls.Add(this.label102);
            this.WeaponAttack3.Controls.Add(this.txtSoundId3);
            this.WeaponAttack3.Controls.Add(this.label103);
            this.WeaponAttack3.Controls.Add(this.label104);
            this.WeaponAttack3.Controls.Add(this.numBulletsRound3);
            this.WeaponAttack3.Controls.Add(this.numDistance3);
            this.WeaponAttack3.Controls.Add(this.numAttackAP3);
            this.WeaponAttack3.Controls.Add(this.label105);
            this.WeaponAttack3.Controls.Add(this.label106);
            this.WeaponAttack3.Controls.Add(this.chkAimAvailable3);
            this.WeaponAttack3.Controls.Add(this.label107);
            this.WeaponAttack3.Controls.Add(this.cmbWeaponSkill3);
            this.WeaponAttack3.Controls.Add(this.chkActive3);
            this.WeaponAttack3.Controls.Add(this.label112);
            this.WeaponAttack3.Location = new System.Drawing.Point(4, 22);
            this.WeaponAttack3.Name = "WeaponAttack3";
            this.WeaponAttack3.Size = new System.Drawing.Size(758, 133);
            this.WeaponAttack3.TabIndex = 3;
            this.WeaponAttack3.Text = "Attack 3";
            this.WeaponAttack3.UseVisualStyleBackColor = true;
            // 
            // numWeaponFlyEffect3
            // 
            this.numWeaponFlyEffect3.Location = new System.Drawing.Point(474, 79);
            this.numWeaponFlyEffect3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numWeaponFlyEffect3.Name = "numWeaponFlyEffect3";
            this.numWeaponFlyEffect3.Size = new System.Drawing.Size(72, 20);
            this.numWeaponFlyEffect3.TabIndex = 102;
            // 
            // numWeaponDmgMax3
            // 
            this.numWeaponDmgMax3.Location = new System.Drawing.Point(474, 55);
            this.numWeaponDmgMax3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numWeaponDmgMax3.Name = "numWeaponDmgMax3";
            this.numWeaponDmgMax3.Size = new System.Drawing.Size(72, 20);
            this.numWeaponDmgMax3.TabIndex = 101;
            // 
            // numWeaponDmgMin3
            // 
            this.numWeaponDmgMin3.Location = new System.Drawing.Point(474, 31);
            this.numWeaponDmgMin3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numWeaponDmgMin3.Name = "numWeaponDmgMin3";
            this.numWeaponDmgMin3.Size = new System.Drawing.Size(72, 20);
            this.numWeaponDmgMin3.TabIndex = 100;
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(402, 82);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(48, 13);
            this.label110.TabIndex = 99;
            this.label110.Text = "FlyEffect";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(401, 57);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(70, 13);
            this.label111.TabIndex = 98;
            this.label111.Text = "Damage Max";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(401, 33);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(67, 13);
            this.label113.TabIndex = 97;
            this.label113.Text = "Damage Min";
            // 
            // chkWeaponRemove3
            // 
            this.chkWeaponRemove3.AutoSize = true;
            this.chkWeaponRemove3.Location = new System.Drawing.Point(628, 8);
            this.chkWeaponRemove3.Name = "chkWeaponRemove3";
            this.chkWeaponRemove3.Size = new System.Drawing.Size(123, 17);
            this.chkWeaponRemove3.TabIndex = 96;
            this.chkWeaponRemove3.Text = "Remove after attack";
            this.chkWeaponRemove3.UseVisualStyleBackColor = true;
            // 
            // cmbDmgType3
            // 
            this.cmbDmgType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDmgType3.FormattingEnabled = true;
            this.cmbDmgType3.Location = new System.Drawing.Point(60, 72);
            this.cmbDmgType3.Name = "cmbDmgType3";
            this.cmbDmgType3.Size = new System.Drawing.Size(109, 21);
            this.cmbDmgType3.TabIndex = 95;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 94;
            this.label8.Text = "DmgType";
            // 
            // cmbWeaponAnim2_3
            // 
            this.cmbWeaponAnim2_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeaponAnim2_3.FormattingEnabled = true;
            this.cmbWeaponAnim2_3.Location = new System.Drawing.Point(60, 49);
            this.cmbWeaponAnim2_3.Name = "cmbWeaponAnim2_3";
            this.cmbWeaponAnim2_3.Size = new System.Drawing.Size(109, 21);
            this.cmbWeaponAnim2_3.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "Anim2";
            // 
            // txtUseGraphics3
            // 
            this.txtUseGraphics3.Location = new System.Drawing.Point(323, 6);
            this.txtUseGraphics3.Name = "txtUseGraphics3";
            this.txtUseGraphics3.Size = new System.Drawing.Size(196, 20);
            this.txtUseGraphics3.TabIndex = 91;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(249, 8);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(71, 13);
            this.label102.TabIndex = 90;
            this.label102.Text = "Use Graphics";
            // 
            // txtSoundId3
            // 
            this.txtSoundId3.Location = new System.Drawing.Point(584, 7);
            this.txtSoundId3.Name = "txtSoundId3";
            this.txtSoundId3.Size = new System.Drawing.Size(33, 20);
            this.txtSoundId3.TabIndex = 89;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(525, 9);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(50, 13);
            this.label103.TabIndex = 88;
            this.label103.Text = "Sound Id";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(249, 34);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(73, 13);
            this.label104.TabIndex = 87;
            this.label104.Text = "Bullets Round";
            // 
            // numBulletsRound3
            // 
            this.numBulletsRound3.Location = new System.Drawing.Point(323, 31);
            this.numBulletsRound3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBulletsRound3.Name = "numBulletsRound3";
            this.numBulletsRound3.Size = new System.Drawing.Size(72, 20);
            this.numBulletsRound3.TabIndex = 86;
            // 
            // numDistance3
            // 
            this.numDistance3.Location = new System.Drawing.Point(323, 80);
            this.numDistance3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDistance3.Name = "numDistance3";
            this.numDistance3.Size = new System.Drawing.Size(73, 20);
            this.numDistance3.TabIndex = 85;
            // 
            // numAttackAP3
            // 
            this.numAttackAP3.Location = new System.Drawing.Point(323, 57);
            this.numAttackAP3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAttackAP3.Name = "numAttackAP3";
            this.numAttackAP3.Size = new System.Drawing.Size(73, 20);
            this.numAttackAP3.TabIndex = 84;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(249, 81);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(49, 13);
            this.label105.TabIndex = 83;
            this.label105.Text = "Distance";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(249, 58);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(55, 13);
            this.label106.TabIndex = 82;
            this.label106.Text = "Attack AP";
            // 
            // chkAimAvailable3
            // 
            this.chkAimAvailable3.AutoSize = true;
            this.chkAimAvailable3.Location = new System.Drawing.Point(154, 4);
            this.chkAimAvailable3.Name = "chkAimAvailable3";
            this.chkAimAvailable3.Size = new System.Drawing.Size(89, 17);
            this.chkAimAvailable3.TabIndex = 81;
            this.chkAimAvailable3.Text = "Aim Available";
            this.chkAimAvailable3.UseVisualStyleBackColor = true;
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(2, 29);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(26, 13);
            this.label107.TabIndex = 80;
            this.label107.Text = "Skill";
            // 
            // cmbWeaponSkill3
            // 
            this.cmbWeaponSkill3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeaponSkill3.FormattingEnabled = true;
            this.cmbWeaponSkill3.Location = new System.Drawing.Point(60, 26);
            this.cmbWeaponSkill3.Name = "cmbWeaponSkill3";
            this.cmbWeaponSkill3.Size = new System.Drawing.Size(109, 21);
            this.cmbWeaponSkill3.TabIndex = 79;
            // 
            // chkActive3
            // 
            this.chkActive3.AutoSize = true;
            this.chkActive3.Checked = true;
            this.chkActive3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive3.Location = new System.Drawing.Point(3, 3);
            this.chkActive3.Name = "chkActive3";
            this.chkActive3.Size = new System.Drawing.Size(56, 17);
            this.chkActive3.TabIndex = 78;
            this.chkActive3.Text = "Active";
            this.chkActive3.UseVisualStyleBackColor = true;
            this.chkActive3.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label112.Location = new System.Drawing.Point(670, 27);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(68, 73);
            this.label112.TabIndex = 77;
            this.label112.Text = "3";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(796, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadListToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveListToolStripMenuItem,
            this.saveFilteredToolStripMenuItem,
            this.saveListToRespectiveFilesToolStripMenuItem,
            this.saveSingleToolStripMenuItem,
            this.toolStripSeparator1,
            this.unloadAllToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadListToolStripMenuItem
            // 
            this.loadListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadListToolStripMenuItem.Image")));
            this.loadListToolStripMenuItem.Name = "loadListToolStripMenuItem";
            this.loadListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadListToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.loadListToolStripMenuItem.Text = "&Load List";
            this.loadListToolStripMenuItem.Click += new System.EventHandler(this.loadListToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(360, 6);
            // 
            // saveListToolStripMenuItem
            // 
            this.saveListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveListToolStripMenuItem.Image")));
            this.saveListToolStripMenuItem.Name = "saveListToolStripMenuItem";
            this.saveListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveListToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.saveListToolStripMenuItem.Text = "&Save List";
            this.saveListToolStripMenuItem.Click += new System.EventHandler(this.saveListToolStripMenuItem_Click);
            // 
            // saveFilteredToolStripMenuItem
            // 
            this.saveFilteredToolStripMenuItem.Name = "saveFilteredToolStripMenuItem";
            this.saveFilteredToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveFilteredToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.saveFilteredToolStripMenuItem.Text = "Save List Filtered";
            this.saveFilteredToolStripMenuItem.Click += new System.EventHandler(this.saveFilteredToolStripMenuItem_Click);
            // 
            // saveListToRespectiveFilesToolStripMenuItem
            // 
            this.saveListToRespectiveFilesToolStripMenuItem.Name = "saveListToRespectiveFilesToolStripMenuItem";
            this.saveListToRespectiveFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveListToRespectiveFilesToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.saveListToRespectiveFilesToolStripMenuItem.Text = "Save List to Respective Files (Filtered)";
            this.saveListToRespectiveFilesToolStripMenuItem.Click += new System.EventHandler(this.saveListToRespectiveFilesToolStripMenuItem_Click);
            // 
            // saveSingleToolStripMenuItem
            // 
            this.saveSingleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveSingleToolStripMenuItem.Image")));
            this.saveSingleToolStripMenuItem.Name = "saveSingleToolStripMenuItem";
            this.saveSingleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveSingleToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.saveSingleToolStripMenuItem.Text = "Save S&elected";
            this.saveSingleToolStripMenuItem.Click += new System.EventHandler(this.saveSingleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(360, 6);
            // 
            // unloadAllToolStripMenuItem
            // 
            this.unloadAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("unloadAllToolStripMenuItem.Image")));
            this.unloadAllToolStripMenuItem.Name = "unloadAllToolStripMenuItem";
            this.unloadAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.unloadAllToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.unloadAllToolStripMenuItem.Text = "Unload All";
            this.unloadAllToolStripMenuItem.Click += new System.EventHandler(this.unloadAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(360, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.editToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("optionsToolStripMenuItem.Image")));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.removeSelectedObjectToolStripMenuItem,
            this.cloneSelectedObjectToolStripMenuItem});
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.itemsToolStripMenuItem.Text = "&Objects";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewToolStripMenuItem.Image")));
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.addNewToolStripMenuItem.Text = "Add Object";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // removeSelectedObjectToolStripMenuItem
            // 
            this.removeSelectedObjectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeSelectedObjectToolStripMenuItem.Image")));
            this.removeSelectedObjectToolStripMenuItem.Name = "removeSelectedObjectToolStripMenuItem";
            this.removeSelectedObjectToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.removeSelectedObjectToolStripMenuItem.Text = "Remove Selected Object(s)";
            this.removeSelectedObjectToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedObjectToolStripMenuItem_Click);
            // 
            // cloneSelectedObjectToolStripMenuItem
            // 
            this.cloneSelectedObjectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cloneSelectedObjectToolStripMenuItem.Image")));
            this.cloneSelectedObjectToolStripMenuItem.Name = "cloneSelectedObjectToolStripMenuItem";
            this.cloneSelectedObjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.cloneSelectedObjectToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.cloneSelectedObjectToolStripMenuItem.Text = "Clone Selected Object";
            this.cloneSelectedObjectToolStripMenuItem.Click += new System.EventHandler(this.cloneSelectedObjectToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutObjectEditorToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // aboutObjectEditorToolStripMenuItem
            // 
            this.aboutObjectEditorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutObjectEditorToolStripMenuItem.Image")));
            this.aboutObjectEditorToolStripMenuItem.Name = "aboutObjectEditorToolStripMenuItem";
            this.aboutObjectEditorToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aboutObjectEditorToolStripMenuItem.Text = "About ObjectEditor";
            this.aboutObjectEditorToolStripMenuItem.Click += new System.EventHandler(this.aboutObjectEditorToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 587);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(796, 22);
            this.statusBar.TabIndex = 12;
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatus.Text = "Editor loaded.";
            // 
            // backgroundResources
            // 
            this.backgroundResources.WorkerReportsProgress = true;
            this.backgroundResources.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundResources_DoWork);
            this.backgroundResources.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundResources_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 609);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.panelProperties);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOnline Object Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResizeBegin += new System.EventHandler(this.frmMain_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.frmMain_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.panelMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.grpGeneralObjectInfo.ResumeLayout(false);
            this.tabGeneralInfo.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPID)).EndInit();
            this.tabGraphics.ResumeLayout(false);
            this.tabGraphics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstProtos)).EndInit();
            this.tabPageExt.ResumeLayout(false);
            this.grpExtInfoColor.ResumeLayout(false);
            this.grpExtInfoColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColorAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColorBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColorGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColorRed)).EndInit();
            this.grpExtInfoIndicator.ResumeLayout(false);
            this.grpExtInfoIndicator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndicatorMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndicatorStart)).EndInit();
            this.grpExtInfoMaterial.ResumeLayout(false);
            this.grpExtInfoMaterial.PerformLayout();
            this.grpExtInfoCorner.ResumeLayout(false);
            this.grpExtInfoCorner.PerformLayout();
            this.grpExtInfoEgg.ResumeLayout(false);
            this.grpExtInfoEgg.PerformLayout();
            this.grpExtInfoLight.ResumeLayout(false);
            this.grpExtInfoLight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLightDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLightIntensity)).EndInit();
            this.grpExtInfoMain.ResumeLayout(false);
            this.grpExtInfoMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            this.tabPageExt2.ResumeLayout(false);
            this.grpSpriteCutting.ResumeLayout(false);
            this.grpSpriteCutting.PerformLayout();
            this.grpAnimation.ResumeLayout(false);
            this.grpAnimation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimHide1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimHide0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimShow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimShow0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimStay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimStay0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimWaitMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimWaitMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimWaitBase)).EndInit();
            this.grpDrawOrderOffset.ResumeLayout(false);
            this.grpDrawOrderOffset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawOrderOffsetHexY)).EndInit();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawOffsetsY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawOffsetsX)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHolodiskNum)).EndInit();
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSoundId)).EndInit();
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSlot)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRadioBroadcastReceive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadioBroadcastSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadioChannel)).EndInit();
            this.grpScript.ResumeLayout(false);
            this.grpScript.PerformLayout();
            this.tabPageExt3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChildPid5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildPid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildPid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildPid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildPid1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpInitialCondition.ResumeLayout(false);
            this.grpInitialCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartCount)).EndInit();
            this.panelProperties.ResumeLayout(false);
            this.tabPageArmor.ResumeLayout(false);
            this.tabControlArmor.ResumeLayout(false);
            this.ArmorMain.ResumeLayout(false);
            this.ArmorMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCrTypeFemale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrTypeMale)).EndInit();
            this.tabPageAmmo.ResumeLayout(false);
            this.tabControlAmmo.ResumeLayout(false);
            this.AmmoMain.ResumeLayout(false);
            this.AmmoMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAcMod)).EndInit();
            this.tabPageCar.ResumeLayout(false);
            this.tabControlCar.ResumeLayout(false);
            this.CarMain.ResumeLayout(false);
            this.CarMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCarEntrance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarCritterCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarPassability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarFuelConsumption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarTankVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarMaxDeterioration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarDeteriorationRate)).EndInit();
            this.grpCarMovementType.ResumeLayout(false);
            this.grpCarMovementType.PerformLayout();
            this.tabPageContainer.ResumeLayout(false);
            this.tabControlContainer.ResumeLayout(false);
            this.ContainerMain.ResumeLayout(false);
            this.ContainerMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numContainerVolume)).EndInit();
            this.tabPageDrug.ResumeLayout(false);
            this.tabControlDrug.ResumeLayout(false);
            this.tabPageDoor.ResumeLayout(false);
            this.tabControlDoor.ResumeLayout(false);
            this.DoorMain.ResumeLayout(false);
            this.DoorMain.PerformLayout();
            this.tabPageGeneric.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPageGrid.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpGridType.ResumeLayout(false);
            this.grpGridType.PerformLayout();
            this.tabPageKey.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPageMisc.ResumeLayout(false);
            this.tabControl5.ResumeLayout(false);
            this.tabPageWall.ResumeLayout(false);
            this.tabControl6.ResumeLayout(false);
            this.tabPageWeapon.ResumeLayout(false);
            this.tabControlWeapon.ResumeLayout(false);
            this.WeaponMain.ResumeLayout(false);
            this.WeaponMain.PerformLayout();
            this.grpUnarmed.ResumeLayout(false);
            this.grpUnarmed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnarmedCriticalBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinUnarmed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinAgility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnarmedPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnarmedTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAmmoCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCriticalFailure)).EndInit();
            this.WeaponAttack1.ResumeLayout(false);
            this.WeaponAttack1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeaponFlyEffect1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeaponDmgMax1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeaponDmgMin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBulletsRound1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackAP1)).EndInit();
            this.WeaponAttack2.ResumeLayout(false);
            this.WeaponAttack2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeaponFlyEffect2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeaponDmgMax2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeaponDmgMin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBulletsRound2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackAP2)).EndInit();
            this.WeaponAttack3.ResumeLayout(false);
            this.WeaponAttack3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeaponFlyEffect3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeaponDmgMax3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeaponDmgMin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBulletsRound3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackAP3)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl panelMain;
        private System.Windows.Forms.TabPage tabPageExt;
        private System.Windows.Forms.TabControl panelProperties;
        private System.Windows.Forms.TabPage tabPageArmor;
        private System.Windows.Forms.TabPage tabPageDrug;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSingleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageExt2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageWeapon;
        private System.Windows.Forms.TabPage tabPageAmmo;
        private System.Windows.Forms.TabPage tabPageContainer;
        private System.Windows.Forms.TabPage tabPageDoor;
        private System.Windows.Forms.TabPage tabPageGrid;
        private System.Windows.Forms.TabPage tabPageMisc;
        private System.Windows.Forms.TabPage tabPageKey;
        private System.Windows.Forms.TabPage tabPageGeneric;
        private System.Windows.Forms.TabPage tabPageWall;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.GroupBox grpGeneralObjectInfo;
        private System.Windows.Forms.GroupBox grpExtInfoMain;
        private System.Windows.Forms.GroupBox grpExtInfoColor;
        private System.Windows.Forms.GroupBox grpExtInfoIndicator;
        private System.Windows.Forms.GroupBox grpExtInfoMaterial;
        private System.Windows.Forms.GroupBox grpExtInfoCorner;
        private System.Windows.Forms.GroupBox grpExtInfoEgg;
        private System.Windows.Forms.GroupBox grpExtInfoLight;
        private System.Windows.Forms.Label lblBaseCost;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.NumericUpDown numVolume;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.CheckBox chkDisableEgg;
        private System.Windows.Forms.CheckBox chkLightFlagDisableDir5;
        private System.Windows.Forms.CheckBox chkLightFlagDisableDir4;
        private System.Windows.Forms.CheckBox chkLightFlagDisableDir3;
        private System.Windows.Forms.CheckBox chkLightFlagDisableDir2;
        private System.Windows.Forms.CheckBox chkLightFlagDisableDir1;
        private System.Windows.Forms.CheckBox chkLightFlagDisableDir0;
        private System.Windows.Forms.CheckBox chkLightFlagGlobal;
        private System.Windows.Forms.CheckBox chkLightFlagInverse;
        private System.Windows.Forms.CheckBox chkLight;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown numColorAlpha;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown numColorBlue;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown numColorGreen;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown numColorRed;
        private System.Windows.Forms.CheckBox chkColorFlagColorizeInventory;
        private System.Windows.Forms.CheckBox chkColorFlagColorize;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown numIndicatorMax;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown numIndicatorStart;
        private System.Windows.Forms.RadioButton rdbMaterialLeather;
        private System.Windows.Forms.RadioButton rdbMaterialCement;
        private System.Windows.Forms.RadioButton rdbMaterialStone;
        private System.Windows.Forms.RadioButton rdbMaterialDirt;
        private System.Windows.Forms.RadioButton rdbMaterialWood;
        private System.Windows.Forms.RadioButton rdbMaterialPlastic;
        private System.Windows.Forms.RadioButton rdbMaterialMetal;
        private System.Windows.Forms.RadioButton rdbMaterialGlass;
        private System.Windows.Forms.GroupBox grpScript;
        private System.Windows.Forms.TextBox txtScriptModule;
        private System.Windows.Forms.RadioButton rdbCornerSouth;
        private System.Windows.Forms.RadioButton rdbCornerEast;
        private System.Windows.Forms.RadioButton rdbCornerWest;
        private System.Windows.Forms.RadioButton rdbCornerNorth;
        private System.Windows.Forms.RadioButton rdbCornerWestEast;
        private System.Windows.Forms.RadioButton rdbCornerNorthSouth;
        private System.Windows.Forms.NumericUpDown numLightDistance;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown numLightIntensity;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox grpAnimation;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.NumericUpDown numAnimHide1;
        private System.Windows.Forms.NumericUpDown numAnimHide0;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.NumericUpDown numAnimShow1;
        private System.Windows.Forms.NumericUpDown numAnimShow0;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.NumericUpDown numAnimStay1;
        private System.Windows.Forms.NumericUpDown numAnimStay0;
        private System.Windows.Forms.CheckBox chkShowAnimExt;
        private System.Windows.Forms.NumericUpDown numAnimWaitMax;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.NumericUpDown numAnimWaitMin;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.NumericUpDown numAnimWaitBase;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.CheckBox chkShowAnim;
        private System.Windows.Forms.GroupBox grpDrawOrderOffset;
        private System.Windows.Forms.NumericUpDown numDrawOrderOffsetHexY;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.NumericUpDown numDrawOffsetsY;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown numDrawOffsetsX;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.NumericUpDown numHolodiskNum;
        private System.Windows.Forms.CheckBox chkHolodiskEnabled;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.NumericUpDown numSlot;
        private System.Windows.Forms.CheckBox chkRadioFlagDisableShiftChannel;
        private System.Windows.Forms.CheckBox chkRadioFlagDisableShiftBCRecv;
        private System.Windows.Forms.CheckBox chkRadioFlagDisableShiftBCSend;
        private System.Windows.Forms.CheckBox chkRadioFlagDisableShiftRecv;
        private System.Windows.Forms.CheckBox chkRadioFlagDisableShiftSend;
        private System.Windows.Forms.CheckBox chkRadioFlagDisableRecv;
        private System.Windows.Forms.CheckBox chkRadioFlagDisableSend;
        private System.Windows.Forms.CheckBox chkRadioEnabled;
        private System.Windows.Forms.NumericUpDown numRadioBroadcastReceive;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.NumericUpDown numRadioBroadcastSend;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.NumericUpDown numRadioChannel;
        private System.Windows.Forms.Label label30;
        private BrightIdeasSoftware.FastObjectListView lstProtos;
        private BrightIdeasSoftware.OLVColumn olvName;
        private BrightIdeasSoftware.OLVColumn olvPID;
        private System.Windows.Forms.GroupBox grpSpriteCutting;
        private System.Windows.Forms.RadioButton rdbSpriteCuttingVertical;
        private System.Windows.Forms.RadioButton rdbSpriteCuttingHorizontal;
        private System.Windows.Forms.RadioButton rdbSpriteCuttingDisabled;
        private System.Windows.Forms.TabPage tabPageCar;
        private System.Windows.Forms.NumericUpDown numSoundId;
        private BrightIdeasSoftware.OLVColumn olvType;
        private System.Windows.Forms.TabPage tabPageExt3;
        private System.Windows.Forms.GroupBox grpInitialCondition;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.NumericUpDown numStartValue10;
        private System.Windows.Forms.NumericUpDown numStartValue9;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.NumericUpDown numStartValue8;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.NumericUpDown numStartValue7;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.NumericUpDown numStartValue6;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.NumericUpDown numStartValue5;
        private System.Windows.Forms.NumericUpDown numStartValue4;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.NumericUpDown numStartValue3;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.NumericUpDown numStartValue2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown numStartValue1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numStartCount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkDeteriorable;
        private System.Windows.Forms.CheckBox chkGroundLevel;
        private System.Windows.Forms.CheckBox chkStackable;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBlockLines;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.NumericUpDown numChildPid5;
        private System.Windows.Forms.NumericUpDown numChildPid4;
        private System.Windows.Forms.NumericUpDown numChildPid3;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.NumericUpDown numChildPid2;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.NumericUpDown numChildPid1;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TextBox txtChildLines5;
        private System.Windows.Forms.TextBox txtChildLines4;
        private System.Windows.Forms.TextBox txtChildLines3;
        private System.Windows.Forms.TextBox txtChildLines2;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox txtChildLines1;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TabControl tabControlWeapon;
        private System.Windows.Forms.TabPage WeaponMain;
        private System.Windows.Forms.TabPage WeaponAttack1;
        private System.Windows.Forms.TabPage WeaponAttack3;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.ComboBox cmbWeaponPerk;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.NumericUpDown numCriticalFailure;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.ComboBox cmbAnim1;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.ComboBox cmbCaliberWeapon;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.NumericUpDown numMaxAmmoCount;
        private System.Windows.Forms.ComboBox cmdWeaponDefaultAmmo;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.NumericUpDown numMinStrength;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.GroupBox grpUnarmed;
        private System.Windows.Forms.CheckBox chkIsUnarmed;
        private System.Windows.Forms.NumericUpDown numUnarmedCriticalBonus;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.CheckBox chkArmorPiercing;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.NumericUpDown numMinLevel;
        private System.Windows.Forms.NumericUpDown numMinUnarmed;
        private System.Windows.Forms.NumericUpDown numMinAgility;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.NumericUpDown numUnarmedPriority;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.NumericUpDown numUnarmedTree;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.TextBox txtScriptFunction;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.ToolStripMenuItem aboutObjectEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unloadAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.CheckBox chkActive1;
        private System.Windows.Forms.CheckBox chkAimAvailable1;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.ComboBox cmbWeaponSkill1;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.TextBox txtUseGraphics1;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.TextBox txtSoundId1;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.NumericUpDown numBulletsRound1;
        private System.Windows.Forms.NumericUpDown numDistance1;
        private System.Windows.Forms.NumericUpDown numAttackAP1;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.TabPage WeaponAttack2;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.TextBox txtUseGraphics2;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.TextBox txtSoundId2;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.NumericUpDown numBulletsRound2;
        private System.Windows.Forms.NumericUpDown numDistance2;
        private System.Windows.Forms.NumericUpDown numAttackAP2;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.CheckBox chkAimAvailable2;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.ComboBox cmbWeaponSkill2;
        private System.Windows.Forms.CheckBox chkActive2;
        private System.Windows.Forms.TextBox txtUseGraphics3;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.TextBox txtSoundId3;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.NumericUpDown numBulletsRound3;
        private System.Windows.Forms.NumericUpDown numDistance3;
        private System.Windows.Forms.NumericUpDown numAttackAP3;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.CheckBox chkAimAvailable3;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.ComboBox cmbWeaponSkill3;
        private System.Windows.Forms.CheckBox chkActive3;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Button btnSetFilter;
        private BrightIdeasSoftware.OLVColumn olvCost;
        private System.Windows.Forms.TabControl tabControlArmor;
        private System.Windows.Forms.TabPage ArmorMain;
        private System.Windows.Forms.NumericUpDown numCrTypeFemale;
        private System.Windows.Forms.Label lblCritterTypeFemale;
        private System.Windows.Forms.NumericUpDown numCrTypeMale;
        private System.Windows.Forms.Label lblCritterTypeMale;
        private BrightIdeasSoftware.OLVColumn olvScript;
        private BrightIdeasSoftware.OLVColumn olvScriptFunc;
        private System.Windows.Forms.TabControl tabControlCar;
        private System.Windows.Forms.TabPage CarMain;
        private System.Windows.Forms.NumericUpDown numCarEntrance;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.NumericUpDown numCarSpeed;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.NumericUpDown numCarCritterCapacity;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.NumericUpDown numCarPassability;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.NumericUpDown numCarFuelConsumption;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.NumericUpDown numCarTankVolume;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.NumericUpDown numCarMaxDeterioration;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.NumericUpDown numCarDeteriorationRate;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.GroupBox grpCarMovementType;
        private System.Windows.Forms.RadioButton rdbCarMovementTypeGround;
        private System.Windows.Forms.RadioButton rdbCarMovementTypeAir;
        private System.Windows.Forms.RadioButton rdbCarMovementTypeWater;
        private System.Windows.Forms.TabControl tabControlAmmo;
        private System.Windows.Forms.TabPage AmmoMain;
        private System.Windows.Forms.NumericUpDown numDrMod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAcMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCaliberAmmo;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedObjectToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkFilter;
        private System.Windows.Forms.GroupBox grpExtInfoFlags;
        private System.Windows.Forms.TabControl tabControlContainer;
        private System.Windows.Forms.TabPage ContainerMain;
        private System.Windows.Forms.CheckBox chkContainerMagicHandsGrnd;
        private System.Windows.Forms.CheckBox chkContainerCannotPickup;
        private System.Windows.Forms.CheckBox chkContainerChangable;
        private System.Windows.Forms.NumericUpDown numContainerVolume;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.TabControl tabControlDrug;
        private System.Windows.Forms.TabPage DrugMain;
        private System.Windows.Forms.TabControl tabControlDoor;
        private System.Windows.Forms.TabPage DoorMain;
        private System.Windows.Forms.CheckBox chkDoorNoBlockShoot;
        private System.Windows.Forms.CheckBox chkDoorNoBlockLight;
        private System.Windows.Forms.CheckBox chkDoorNoBlockMove;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage GenericMain;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage KeyMain;
        private System.Windows.Forms.TabControl tabControl5;
        private System.Windows.Forms.TabPage MiscMain;
        private System.Windows.Forms.TabControl tabControl6;
        private System.Windows.Forms.TabPage WallMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpGridType;
        private System.Windows.Forms.RadioButton rdbExitGrid;
        private System.Windows.Forms.RadioButton rdbStairs;
        private System.Windows.Forms.RadioButton rdbLadderBottom;
        private System.Windows.Forms.RadioButton rdbLadderTop;
        private System.Windows.Forms.RadioButton rdbElevator;
        private System.Windows.Forms.Panel pnlFilterButtons;
        private System.Windows.Forms.RadioButton rdbNone;
        private System.Windows.Forms.ToolStripMenuItem saveFilteredToolStripMenuItem;
        private BrightIdeasSoftware.OLVColumn olvFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbWeaponAnim2_1;
        private System.Windows.Forms.ComboBox cmbWeaponAnim2_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbWeaponAnim2_3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDmgType1;
        private System.Windows.Forms.ComboBox cmbDmgType2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDmgType3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkWeaponRemove1;
        private System.Windows.Forms.CheckBox chkWeaponRemove2;
        private System.Windows.Forms.CheckBox chkWeaponRemove3;
        private System.Windows.Forms.NumericUpDown numWeaponFlyEffect1;
        private System.Windows.Forms.NumericUpDown numWeaponDmgMax1;
        private System.Windows.Forms.NumericUpDown numWeaponDmgMin1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numWeaponFlyEffect2;
        private System.Windows.Forms.NumericUpDown numWeaponDmgMax2;
        private System.Windows.Forms.NumericUpDown numWeaponDmgMin2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.NumericUpDown numWeaponFlyEffect3;
        private System.Windows.Forms.NumericUpDown numWeaponDmgMax3;
        private System.Windows.Forms.NumericUpDown numWeaponDmgMin3;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.ToolStripMenuItem saveListToRespectiveFilesToolStripMenuItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem cloneSelectedObjectToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.TabControl tabGeneralInfo;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TextBox txtProtoFileName;
        private System.Windows.Forms.Label lblProtoFileName;
        private System.Windows.Forms.NumericUpDown numPID;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TabPage tabGraphics;
        private System.Windows.Forms.TextBox txtInvPic;
        private System.Windows.Forms.TextBox txtGroundPic;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pctInventory;
        private System.Windows.Forms.PictureBox pctGround;
        private System.Windows.Forms.Button btnSelectInventory;
        private System.Windows.Forms.Button btnSelectGround;
        private System.ComponentModel.BackgroundWorker backgroundResources;

    }
}

