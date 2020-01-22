unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ComCtrls, Buttons, Math, IniFiles, ExtCtrls, ShellApi, FileCtrl, GraphicEx,
  Spin, ImgList, Grids, ValEdit, KAZip;

type
  TForm1 = class(TForm)
    ListView1: TListView;
    BitBtn1: TBitBtn;
    BitBtn2: TBitBtn;
    BitBtn3: TBitBtn;
    PageControl1: TPageControl;
    TabSheet1: TTabSheet;
    TabSheet2: TTabSheet;
    TabSheet3: TTabSheet;
    GroupBox1: TGroupBox;
    Label9: TLabel;
    Label43: TLabel;
    Label44: TLabel;
    Edit37: TEdit;
    Edit38: TEdit;
    GroupBox2: TGroupBox;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    Label1: TLabel;
    Label10: TLabel;
    Label11: TLabel;
    Label12: TLabel;
    Label13: TLabel;
    Label14: TLabel;
    Label15: TLabel;
    Label16: TLabel;
    Label23: TLabel;
    Label24: TLabel;
    Label25: TLabel;
    Label26: TLabel;
    Label27: TLabel;
    Label28: TLabel;
    Label29: TLabel;
    Label30: TLabel;
    Label31: TLabel;
    Label32: TLabel;
    Label33: TLabel;
    Label34: TLabel;
    Label35: TLabel;
    Label36: TLabel;
    Label37: TLabel;
    Label38: TLabel;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Edit5: TEdit;
    Edit6: TEdit;
    Edit7: TEdit;
    UpDown1: TUpDown;
    UpDown2: TUpDown;
    UpDown3: TUpDown;
    UpDown4: TUpDown;
    UpDown5: TUpDown;
    UpDown6: TUpDown;
    UpDown7: TUpDown;
    Edit8: TEdit;
    Edit9: TEdit;
    Edit10: TEdit;
    Edit11: TEdit;
    Edit12: TEdit;
    Edit13: TEdit;
    Edit14: TEdit;
    Edit15: TEdit;
    Edit16: TEdit;
    Edit17: TEdit;
    Edit18: TEdit;
    Edit19: TEdit;
    Edit20: TEdit;
    Edit21: TEdit;
    Edit22: TEdit;
    Edit23: TEdit;
    Edit24: TEdit;
    Edit25: TEdit;
    Edit26: TEdit;
    Edit27: TEdit;
    Edit28: TEdit;
    Edit29: TEdit;
    Edit30: TEdit;
    Edit31: TEdit;
    UpDown8: TUpDown;
    UpDown9: TUpDown;
    UpDown10: TUpDown;
    UpDown11: TUpDown;
    UpDown12: TUpDown;
    UpDown13: TUpDown;
    UpDown14: TUpDown;
    UpDown15: TUpDown;
    GroupBox3: TGroupBox;
    Label22: TLabel;
    Label17: TLabel;
    Label18: TLabel;
    Label20: TLabel;
    Edit33: TEdit;
    UpDown17: TUpDown;
    ComboBox1: TComboBox;
    ComboBox2: TComboBox;
    ComboBox4: TComboBox;
    GroupBox4: TGroupBox;
    Label40: TLabel;
    Edit35: TEdit;
    UpDown19: TUpDown;
    UpDown16: TUpDown;
    Edit32: TEdit;
    Label21: TLabel;
    GroupBox5: TGroupBox;
    Label45: TLabel;
    Label46: TLabel;
    Label47: TLabel;
    Label48: TLabel;
    Label49: TLabel;
    Label50: TLabel;
    Label51: TLabel;
    Label52: TLabel;
    Label53: TLabel;
    Label54: TLabel;
    Label55: TLabel;
    Label56: TLabel;
    Label57: TLabel;
    Label58: TLabel;
    Label59: TLabel;
    Label60: TLabel;
    Label61: TLabel;
    Label62: TLabel;
    Edit41: TEdit;
    Edit42: TEdit;
    Edit43: TEdit;
    Edit44: TEdit;
    Edit45: TEdit;
    Edit46: TEdit;
    Edit47: TEdit;
    Edit48: TEdit;
    Edit49: TEdit;
    Edit50: TEdit;
    Edit51: TEdit;
    Edit52: TEdit;
    Edit53: TEdit;
    Edit54: TEdit;
    Edit55: TEdit;
    Edit56: TEdit;
    Edit57: TEdit;
    Label64: TLabel;
    Label65: TLabel;
    Edit58: TEdit;
    Label66: TLabel;
    Label67: TLabel;
    Label68: TLabel;
    Label69: TLabel;
    Label70: TLabel;
    Label71: TLabel;
    Label72: TLabel;
    Label73: TLabel;
    Label74: TLabel;
    Label75: TLabel;
    Label76: TLabel;
    Label77: TLabel;
    Label78: TLabel;
    Label79: TLabel;
    Label80: TLabel;
    Label81: TLabel;
    Label82: TLabel;
    Label83: TLabel;
    Label84: TLabel;
    Label85: TLabel;
    Label86: TLabel;
    Label87: TLabel;
    Label88: TLabel;
    Label89: TLabel;
    Label90: TLabel;
    Label91: TLabel;
    Label92: TLabel;
    Label93: TLabel;
    Label94: TLabel;
    Label95: TLabel;
    Label96: TLabel;
    Label97: TLabel;
    Label98: TLabel;
    Label99: TLabel;
    Label100: TLabel;
    Label101: TLabel;
    UpDown23: TUpDown;
    UpDown24: TUpDown;
    UpDown25: TUpDown;
    UpDown26: TUpDown;
    UpDown27: TUpDown;
    UpDown28: TUpDown;
    UpDown29: TUpDown;
    UpDown30: TUpDown;
    UpDown31: TUpDown;
    UpDown32: TUpDown;
    UpDown33: TUpDown;
    UpDown34: TUpDown;
    UpDown35: TUpDown;
    UpDown36: TUpDown;
    UpDown37: TUpDown;
    UpDown38: TUpDown;
    UpDown39: TUpDown;
    UpDown40: TUpDown;
    Edit61: TEdit;
    Edit62: TEdit;
    Edit63: TEdit;
    Edit64: TEdit;
    Edit65: TEdit;
    Edit66: TEdit;
    Edit67: TEdit;
    Edit68: TEdit;
    Edit69: TEdit;
    Edit70: TEdit;
    Edit71: TEdit;
    Edit72: TEdit;
    Edit73: TEdit;
    Edit74: TEdit;
    Edit75: TEdit;
    Edit76: TEdit;
    Edit77: TEdit;
    Edit78: TEdit;
    Edit81: TEdit;
    Edit82: TEdit;
    Edit83: TEdit;
    Edit84: TEdit;
    Edit85: TEdit;
    Edit86: TEdit;
    Edit87: TEdit;
    Edit88: TEdit;
    Edit89: TEdit;
    Edit90: TEdit;
    Edit91: TEdit;
    Edit92: TEdit;
    Edit93: TEdit;
    Edit94: TEdit;
    Edit95: TEdit;
    Edit96: TEdit;
    Edit97: TEdit;
    Edit98: TEdit;
    TabSheet4: TTabSheet;
    GroupBox6: TGroupBox;
    GroupBox7: TGroupBox;
    Label103: TLabel;
    Edit99: TEdit;
    Label104: TLabel;
    Edit100: TEdit;
    Label105: TLabel;
    Edit101: TEdit;
    Label106: TLabel;
    Edit102: TEdit;
    Label107: TLabel;
    Edit103: TEdit;
    Label108: TLabel;
    Edit104: TEdit;
    Label109: TLabel;
    Edit105: TEdit;
    Edit106: TEdit;
    Edit107: TEdit;
    Edit108: TEdit;
    Edit109: TEdit;
    Edit110: TEdit;
    Edit111: TEdit;
    Edit112: TEdit;
    Label110: TLabel;
    Label111: TLabel;
    Edit60: TEdit;
    Edit79: TEdit;
    Label112: TLabel;
    Label113: TLabel;
    CheckBox1: TCheckBox;
    CheckBox2: TCheckBox;
    CheckBox3: TCheckBox;
    CheckBox4: TCheckBox;
    CheckBox5: TCheckBox;
    CheckBox6: TCheckBox;
    CheckBox7: TCheckBox;
    CheckBox8: TCheckBox;
    CheckBox9: TCheckBox;
    CheckBox10: TCheckBox;
    CheckBox11: TCheckBox;
    CheckBox12: TCheckBox;
    CheckBox13: TCheckBox;
    CheckBox14: TCheckBox;
    CheckBox15: TCheckBox;
    CheckBox16: TCheckBox;
    CheckBox17: TCheckBox;
    CheckBox18: TCheckBox;
    CheckBox19: TCheckBox;
    CheckBox20: TCheckBox;
    CheckBox21: TCheckBox;
    CheckBox22: TCheckBox;
    CheckBox23: TCheckBox;
    Label19: TLabel;
    ComboBox3: TComboBox;
    ComboBox5: TComboBox;
    Label114: TLabel;
    ComboBox6: TComboBox;
    Label115: TLabel;
    SaveDialog1: TSaveDialog;
    SpeedButton1: TSpeedButton;
    SpeedButton2: TSpeedButton;
    SpeedButton3: TSpeedButton;
    SpeedButton4: TSpeedButton;
    SpeedButton5: TSpeedButton;
    SpeedButton6: TSpeedButton;
    SpeedButton7: TSpeedButton;
    SpeedButton8: TSpeedButton;
    SpeedButton9: TSpeedButton;
    SpeedButton10: TSpeedButton;
    SpeedButton11: TSpeedButton;
    SpeedButton12: TSpeedButton;
    SpeedButton13: TSpeedButton;
    SpeedButton14: TSpeedButton;
    Label119: TLabel;
    Edit80: TEdit;
    Edit113: TEdit;
    Edit114: TEdit;
    Edit115: TEdit;
    Label120: TLabel;
    Label121: TLabel;
    Label122: TLabel;
    Label123: TLabel;
    UpDown43: TUpDown;
    UpDown44: TUpDown;
    Label124: TLabel;
    Edit116: TEdit;
    UpDown45: TUpDown;
    Label125: TLabel;
    Edit117: TEdit;
    UpDown46: TUpDown;
    GroupBox8: TGroupBox;
    Label39: TLabel;
    Edit34: TEdit;
    UpDown18: TUpDown;
    Image1: TImage;
    Label42: TLabel;
    StatusBar1: TStatusBar;
    Panel1: TPanel;
    SpeedButton15: TSpeedButton;
    SpeedButton16: TSpeedButton;
    BitBtn5: TBitBtn;
    BitBtn6: TBitBtn;
    BitBtn7: TBitBtn;
    BitBtn8: TBitBtn;
    BitBtn9: TBitBtn;
    ComboBox7: TComboBox;
    OpenDialog1: TOpenDialog;
    CheckBox36: TCheckBox;
    CheckBox37: TCheckBox;
    CheckBox38: TCheckBox;
    CheckBox39: TCheckBox;
    Image2: TImage;
    SpinEdit0: TSpinEdit;
    SpinEdit40: TSpinEdit;
    SpinEdit59: TSpinEdit;
    Label41: TLabel;
    Edit36: TEdit;
    SpinEdit1000: TSpinEdit;
    SpinEdit1001: TSpinEdit;
    SpinEdit1002: TSpinEdit;
    Label63: TLabel;
    Label116: TLabel;
    Label117: TLabel;
    BitBtn4: TBitBtn;
    CheckBox24: TCheckBox;
    CheckBox40: TCheckBox;
    CheckBox41: TCheckBox;
    CheckBox42: TCheckBox;
    CheckBox43: TCheckBox;
    CheckBox44: TCheckBox;
    CheckBox51: TCheckBox;
    CheckBox50: TCheckBox;
    CheckBox49: TCheckBox;
    CheckBox48: TCheckBox;
    CheckBox47: TCheckBox;
    CheckBox46: TCheckBox;
    CheckBox45: TCheckBox;
    TabSheet5: TTabSheet;
    GroupBox9: TGroupBox;
    ValueListEditor1: TValueListEditor;
    BitBtn10: TBitBtn;
    BitBtn11: TBitBtn;
    Label118: TLabel;
    ComboBox8: TComboBox;
    Label126: TLabel;
    ComboBox9: TComboBox;
    ValueListEditor2: TValueListEditor;
    BitBtn12: TBitBtn;
    SpinEdit1: TSpinEdit;
    Label102: TLabel;
    BitBtn13: TBitBtn;
    KAZip1: TKAZip;
    procedure ListView1SelectItem(Sender: TObject; Item: TListItem;
      Selected: Boolean);
    procedure FormCreate(Sender: TObject);
    procedure BitBtn1Click(Sender: TObject);
    procedure BitBtn2Click(Sender: TObject);
    procedure BitBtn3Click(Sender: TObject);
    procedure Edit34Change(Sender: TObject);
    procedure Edit1Change(Sender: TObject);
    procedure Edit2Change(Sender: TObject);
    procedure Edit3Change(Sender: TObject);
    procedure Edit4Change(Sender: TObject);
    procedure Edit5Change(Sender: TObject);
    procedure Edit6Change(Sender: TObject);
    procedure Edit7Change(Sender: TObject);
    procedure Edit16Change(Sender: TObject);
    procedure Edit17Change(Sender: TObject);
    procedure Edit18Change(Sender: TObject);
    procedure Edit19Change(Sender: TObject);
    procedure Edit20Change(Sender: TObject);
    procedure Edit21Change(Sender: TObject);
    procedure Edit22Change(Sender: TObject);
    procedure Edit23Change(Sender: TObject);
    procedure Edit61Change(Sender: TObject);
    procedure Edit62Change(Sender: TObject);
    procedure Edit63Change(Sender: TObject);
    procedure Edit64Change(Sender: TObject);
    procedure Edit65Change(Sender: TObject);
    procedure Edit66Change(Sender: TObject);
    procedure Edit67Change(Sender: TObject);
    procedure Edit68Change(Sender: TObject);
    procedure Edit69Change(Sender: TObject);
    procedure Edit70Change(Sender: TObject);
    procedure Edit71Change(Sender: TObject);
    procedure Edit72Change(Sender: TObject);
    procedure Edit73Change(Sender: TObject);
    procedure Edit74Change(Sender: TObject);
    procedure Edit75Change(Sender: TObject);
    procedure Edit76Change(Sender: TObject);
    procedure Edit77Change(Sender: TObject);
    procedure Edit78Change(Sender: TObject);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
    procedure Edit37Change(Sender: TObject);
    procedure Edit38Change(Sender: TObject);
    procedure ComboBox1Change(Sender: TObject);
    procedure ComboBox2Change(Sender: TObject);
    procedure ComboBox4Change(Sender: TObject);
    procedure ComboBox3Change(Sender: TObject);
    procedure Edit33Change(Sender: TObject);
    procedure Edit36Change(Sender: TObject);
    procedure Edit39Change(Sender: TObject);
    procedure Edit35Change(Sender: TObject);
    procedure Edit32Change(Sender: TObject);
    procedure CheckBox1Click(Sender: TObject);
    procedure CheckBox2Click(Sender: TObject);
    procedure CheckBox3Click(Sender: TObject);
    procedure CheckBox4Click(Sender: TObject);
    procedure CheckBox5Click(Sender: TObject);
    procedure CheckBox6Click(Sender: TObject);
    procedure CheckBox7Click(Sender: TObject);
    procedure CheckBox8Click(Sender: TObject);
    procedure CheckBox9Click(Sender: TObject);
    procedure CheckBox10Click(Sender: TObject);
    procedure CheckBox11Click(Sender: TObject);
    procedure CheckBox12Click(Sender: TObject);
    procedure CheckBox13Click(Sender: TObject);
    procedure CheckBox14Click(Sender: TObject);
    procedure CheckBox15Click(Sender: TObject);
    procedure CheckBox16Click(Sender: TObject);
    procedure CheckBox17Click(Sender: TObject);
    procedure CheckBox18Click(Sender: TObject);
    procedure CheckBox19Click(Sender: TObject);
    procedure CheckBox20Click(Sender: TObject);
    procedure CheckBox21Click(Sender: TObject);
    procedure CheckBox22Click(Sender: TObject);
    procedure CheckBox23Click(Sender: TObject);
    procedure Edit99Change(Sender: TObject);
    procedure Edit100Change(Sender: TObject);
    procedure Edit101Change(Sender: TObject);
    procedure Edit102Change(Sender: TObject);
    procedure Edit103Change(Sender: TObject);
    procedure Edit104Change(Sender: TObject);
    procedure Edit105Change(Sender: TObject);
    procedure Edit106Change(Sender: TObject);
    procedure Edit107Change(Sender: TObject);
    procedure Edit108Change(Sender: TObject);
    procedure Edit109Change(Sender: TObject);
    procedure Edit110Change(Sender: TObject);
    procedure Edit111Change(Sender: TObject);
    procedure Edit112Change(Sender: TObject);
    procedure Edit60Change(Sender: TObject);
    procedure Edit79Change(Sender: TObject);
    procedure SpeedButton1Click(Sender: TObject);
    procedure SpeedButton2Click(Sender: TObject);
    procedure SpeedButton3Click(Sender: TObject);
    procedure SpeedButton4Click(Sender: TObject);
    procedure SpeedButton5Click(Sender: TObject);
    procedure SpeedButton6Click(Sender: TObject);
    procedure SpeedButton7Click(Sender: TObject);
    procedure SpeedButton8Click(Sender: TObject);
    procedure SpeedButton9Click(Sender: TObject);
    procedure SpeedButton10Click(Sender: TObject);
    procedure SpeedButton11Click(Sender: TObject);
    procedure SpeedButton12Click(Sender: TObject);
    procedure SpeedButton13Click(Sender: TObject);
    procedure SpeedButton14Click(Sender: TObject);
    procedure Edit114Change(Sender: TObject);
    procedure Edit115Change(Sender: TObject);
    procedure Edit116Change(Sender: TObject);
    procedure Edit117Change(Sender: TObject);
    procedure ListView1Change(Sender: TObject; Item: TListItem;
      Change: TItemChange);
    procedure SpeedButton15Click(Sender: TObject);
    procedure SpeedButton16Click(Sender: TObject);
    procedure BitBtn5Click(Sender: TObject);
    procedure BitBtn6Click(Sender: TObject);
    procedure BitBtn7Click(Sender: TObject);
    procedure BitBtn8Click(Sender: TObject);
    procedure BitBtn9Click(Sender: TObject);
    procedure ComboBox7Change(Sender: TObject);
    procedure ComboBox1Select(Sender: TObject);
    procedure ComboBox5Change(Sender: TObject);
    procedure ComboBox6Change(Sender: TObject);
    procedure CheckBox36Click(Sender: TObject);
    procedure CheckBox37Click(Sender: TObject);
    procedure CheckBox38Click(Sender: TObject);
    procedure CheckBox39Click(Sender: TObject);
    procedure BitBtn4Click(Sender: TObject);
    procedure CheckBox24Click(Sender: TObject);
    procedure BitBtn10Click(Sender: TObject);
    procedure BitBtn11Click(Sender: TObject);
    procedure BitBtn12Click(Sender: TObject);
    procedure ValueListEditor1StringsChange(Sender: TObject);
    procedure ValueListEditor2StringsChange(Sender: TObject);
    procedure BitBtn13Click(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
  private
    { Private declarations }
    procedure ShowSelected(Item:TListItem);

    procedure Sprawdz_NazwyCritterow_PrzedZapisemDoPliku(_ListView: TListView); // sprawdza wpsiy w listview z nazwami "new critter" i kasuje je jesli sa, zeby zapobiec zapisowi do plikow takich smieciowych rzeczy
    procedure SaveListViewToFile(AListView: TListView; fopro_FileName,fodlg_FileName: string);
//    procedure PolaczPlikiMSG;
    procedure StampArmor(indeks:Integer);

    procedure ZapiszBiezacyCritter;

    procedure WczytajFopro;
    procedure ZapiszFopro;

    procedure BackupServerFiles;

    procedure Inicjalizacja;

    function isHumanoid(ComboBoxIndex_body_type:Integer):Boolean;
    procedure RemoveDirectory(const Dir: String);
  public
    { Public declarations }
  end;

var
    Form1: TForm1;
    Selected_Item:TListItem;

    ListItem:TListItem;

    Lista:TStringList; // tymczasowa zmienna do przechowywania listy stringow wpisywanych pozniej do listy itemow w jakims ComboBox
    plik_temp:TextFile; // tymczasowa zmienna do oblsugi plikow tekstowych
    linia_temp:String;
    pozycja_temp1:Integer;
    pozycja_temp2:Integer;

    Pid,
    ST_BASE_CRTYPE,

    ST_AI_ID:String;

    ST_STRENGTH,
    ST_PERCEPTION,
    ST_ENDURANCE,
    ST_CHARISMA,
    ST_INTELLECT,
    ST_AGILITY,
    ST_LUCK:String;

    ST_MAX_LIFE,
    ST_ACTION_POINTS,
    ST_ARMOR_CLASS,
    ST_MELEE_DAMAGE,
    ST_CARRY_WEIGHT,
    ST_SEQUENCE,
    ST_HEALING_RATE,
    ST_CRITICAL_CHANCE,
    ST_MAX_CRITICAL:String;

    ST_KILL_EXPERIENCE,
    ST_BODY_TYPE,
    ST_LOCOMOTION_TYPE,
    ST_DAMAGE_TYPE,
    ST_AGE,
    ST_GENDER,
    ST_SCALE_FACTOR:String;  // uzywane dla 3D

    ST_NORMAL_ABSORB,
    ST_LASER_ABSORB,
    ST_FIRE_ABSORB,
    ST_PLASMA_ABSORB,
    ST_ELECTRO_ABSORB,
    ST_EMP_ABSORB,
    ST_EXPLODE_ABSORB,
    ST_NORMAL_RESIST,
    ST_LASER_RESIST,
    ST_FIRE_RESIST,
    ST_PLASMA_RESIST,
    ST_ELECTRO_RESIST,
    ST_EMP_RESIST,
    ST_EXPLODE_RESIST,
    ST_RADIATION_RESISTANCE,
    ST_POISON_RESISTANCE:String;

    SK_SMALL_GUNS,
    SK_BIG_GUNS,
    SK_ENERGY_WEAPONS,
    SK_UNARMED,
    SK_SCAVENGING,
    SK_THROWING,
    SK_FIRST_AID,
    SK_DOCTOR,
    SK_SNEAK,
    SK_LOCKPICK,
    SK_STEAL,
    SK_TRAPS,
    SK_SCIENCE,
    SK_REPAIR,
    SK_SPEECH,
    SK_BARTER,
    SK_GAMBLING,
    SK_OUTDOORSMAN:String;

    ST_DIALOG_ID:String;
    ST_BAG_ID:String;
    ST_TEAM_ID:String;


    MODE_HIDE,            //NPC jest niewidoczny
    MODE_NO_STEAL,
    MODE_NO_BARTER,
    MODE_NO_ENEMY_STACK,  //NPC does not remember the enemies
    MODE_NO_PVP,          //Prohibits PvP for player
    MODE_NO_HOME,         //NPC does not return to the home position automatically
    MODE_DLG_SCRIPT_BARTER,  //mozna handlowac przy aktywnym skrypcie dialogowym
    MODE_UNLIMITED_AMMO,     // nieskonczone ammo
    MODE_NO_DROP,           // nie upusci broni
    MODE_NO_LOOSE_LIMBS,    // nie mozna polamac konczyn

    MODE_DEAD_AGES,         //A dead body does not disappear
    MODE_NO_HEAL,           //Damage is not healed with time
    MODE_INVULNERABLE,      // nie mzna zabic
    MODE_NO_FLATTEN,        // po smierci MARTWY NPC bedzie stanowic przeszkode
    MODE_SPECIAL_DEAD,      // specjalny rodzaj smierci
    MODE_RANGE_HTH,         // mozliwy atak na odleglosc bez broni
    MODE_NO_KNOCK,          // nie upadnie na ziemie
    MODE_NO_LOOT,           // nie mzna lootowac
    MODE_NO_KARMA_ON_KILL,   // mozna zabic NPC-a bez zmiany karmy
    MODE_BARTER_ONLY_CASH,   //When bartering NPC accepts payment in cash only
    MODE_NO_PUSH,            //Can't be pushed
    MODE_NO_UNARMED,         //Not have unarmed attacks
    MODE_NO_AIM,             // Critter can't do aim attacks
    MODE_NO_WALK,            // Critter can't walk
    MODE_NO_RUN,             // Critter can't run
    MODE_NO_TALK:String;     // Npc can't talk


//    MODE_END_COMBAT,      //Would the player to finish turn-based combat
//    MODE_DEFAULT_COMBAT,
//    MODE_GECK,
//    MODE_NO_FAVORITE_ITEM,
//    MODE_NO_ITEM_GARBAGER,
//    MODE_NO_SUPPLY,         //Do not come to the bounty hunters at the death of NPC

  ST_TOXIC, ST_RADIOACTIVE:String;
  ST_LEVEL, ST_WALK_TIME, ST_RUN_TIME:String;
  
  PE_ACTION_BOY            :String;
PE_ADRENALINE_RUSH       :String;
PE_BEST_OF_A_BAD_LOT     :String;
PE_BETTER_CRITICALS      :String;
PE_BLESSED_ARE_THE_WEAK  :String;
PE_BONUS_HTH_ATTACKS     :String;
PE_CLOSE_COMBAT_MASTER      :String;
PE_CLOSE_COMBAT_MASTER_II   :String;
PE_BONUS_MOVE            :String;
PE_BONUS_RANGED_DAMAGE   :String;
PE_BONUS_RATE_OF_ATTACK    :String;
PE_BORN_LEADER           :String;
PE_DEAD_MAN_WALKING      :String;
PE_DEMOLITION_EXPERT     :String;
PE_DERMAL_IMPACT         :String;
PE_DERMAL_IMPACT_ENH     :String;
PE_DODGER                :String;
PE_DODGER_II             :String;
PE_EARLIER_SEQUENCE      :String;
PE_EVEN_MORE_CRITICALS   :String;
PE_EVEN_TOUGHER          :String;
PE_FAST_RELOAD           :String;
PE_HAND_LOADER           :String;
PE_FIELD_MEDIC_II             :String;
PE_HEAVE_HO              :String;
PE_HEAVE_HO_II           :String;
PE_HIT_THE_GAPS          :String;
PE_HTH_CRITICALS         :String;
PE_HTH_EVADE             :String;
PE_HTH_EVADE_II          :String;
PE_IN_YOUR_FACE          :String;
PE_IRON_LIMBS             :String;
PE_JINXED_II             :String;
PE_LIVEWIRE              :String;
PE_LIVING_ANATOMY        :String;
PE_MAN_OF_STEEL          :String;
PE_MELT_INTO_SHADOW      :String;
PE_MORE_CRITICALS        :String;
PE_MORE_RANGED_DAMAGE    :String;
PE_NEMEAN_ARMOR          :String;
PE_PHOENIX_IMPLANTS      :String;
PE_PHOENIX_IMPLANTS_ENH  :String;
PE_PYROMANIAC            :String;
PE_QUICK_POCKETS         :String;
PE_QUICK_RECOVERY        :String;
PE_RIGHT_BETWEEN_THE_EYES:String;
PE_SHARPSHOOTER          :String;
PE_SILENT_DEATH          :String;
PE_SLAYER                :String;
PE_SNIPER                :String;
PE_SPRAY_AND_PRAY        :String;
PE_STEALTH_GIRL          :String;
PE_STONEWALL             :String;
PE_TERMINATOR            :String;
PE_TOUGHNESS             :String;
PE_TREE_TRUNK_THIGHS     :String;
PE_WEAPON_HANDLING       :String;
//perki dodane do listy w pliku 04-02-2014 bo ich brakowalo
PE_FASTER_HEALING        :String;
PE_GHOST       			 :String;
PE_FIELD_MEDIC      			 :String;
PE_LIFEGIVER       	     :String;
PE_LIGHT_STEP            :String;
PE_MEDIC                 :String;


ST_DEFAULT_ARMOR_PID:String;
ST_DEFAULT_HELMET_PID:String;

// traity dodoane 04.02.2014
TRAIT_FAST_METABOLISM:String;
TRAIT_BRUISER:String;
TRAIT_SMALL_FRAME:String;
TRAIT_ONE_HANDER:String;
TRAIT_FINESSE:String;
TRAIT_KAMIKAZE:String;
TRAIT_HEAVY_HANDED:String;
TRAIT_FAST_SHOT:String;
TRAIT_BLOODY_MESS:String;
TRAIT_JINXED:String;
TRAIT_GOOD_NATURED:String;
TRAIT_CHEM_RELIANT:String;
TRAIT_CHEM_RESISTANT:String;
TRAIT_BONEHEAD:String;
TRAIT_SKILLED:String;
TRAIT_LONER:String;

  licznik_critterow:Integer;
  nazwa_crittera,opis_crittera:String; // czytane z pliku fodlg.msg
  nazwa_frm:String;

  wersja_programu:String;
//  server_revision_number:String;
  plikIni:TIniFile;
  path_server,path_all_fopro,path_fodlg_msg,path_CritterTypes_cfg:String;


  path_selected_fopro, path_selected_msg:String;

//  path_teams_fos:String; // okreslenie sciezki dostpeu do pliku _teams.fos i wczytywanie do listy ComboBox6 (po odpowiedniej obrobce pliku)
//  path_backup_all_fopro,path_backup_fodlg_msg:String;

  global_STOP_FOR_SAVE:Boolean;  // jesli= true to przed zamknieciem programu bedzie krzyczalo, ze trzeba zapisac dane do pliku! Uaktywaniny przyciskiem SAVE
  lokal_STOP_FOR_SAVE:Boolean;  // jesli True to znaczy, ze w ktoryms okienku byla edycja i przed wyborem nowego crittera w liscie ListView bedzie pojawial sie komunikat czy zapisac

  tab_PID:Array[1..9999] of String;
  tab_nazwy:Array[1..9999] of String;
  tab_opisy:Array[1..9999] of String;

  language:String; // jezyk pliku fodlg.msg (engl, russ albo dowolny jaki jest w serwerze, domyslnie engl)
  lang1,lang2,lang3:String; // zmienne przechowujace mozliwe jezyki zczytywane z ini

  ostatni_numer_pid_w_fodlg_msg:String; // podczas Wczytywania pliku fopro, odczytywany jest plik fodlg.msg i jako ostania pozycja w tym pliku to ostatni_1numer_pid_w_fodlg_msg na potzeby Append zeby ustalic kolejny PID nowego crittera aby nie tworzyl  pid-y nowych wpisow od 1 bo ndpisze name i descr w fodlg.msg

//  MAX_PID_RANGE:Integer;  // zmienna ta jest czytana z pliku ini i okresla ona ilosc PID critterow w danej lokacji/grupie (p[liku fopro) domyslnie PID_RANGE=100 zgodnie z sugestia Kilgore 22-12-2010
//  SHOW_BUTTON_CREATE_FILES:Integer; // zmienna, Po kliknieciu przycisku Create Files zgasi go i nie bedzie niepotrzebnie wyswuetolac przy kolejnych uruchoeminaich, True - jak za 1 razem, False - zgasi przycisk Crate Files

  combat_perks:TextFile;

implementation

{$R *.dfm}

function TForm1.isHumanoid(ComboBoxIndex_body_type:Integer):Boolean;
begin
  if (ComboBoxIndex_body_type>=0) and (ComboBoxIndex_body_type < 5) then
  isHumanoid:=True
  else
  isHumanoid:=False;
end;

   

procedure TForm1.FormCreate(Sender: TObject);
var iter:Integer;
begin
  wersja_programu:=' v1.1.7.11';
  Caption:='Fonline:Reloaded - Critter Proto Editor ' + wersja_programu;
  Position:=poScreenCenter;
{  Left:=0;
  Top:=0;
  Height:=Screen.Height-36;
  Width:=Screen.Width-5;}



  Panel1.Caption:=Caption;

  PageControl1.Visible:=false;
  GroupBox8.Visible:=False;
  Panel1.Visible:=False;
//  Button2.Enabled:=False;
  BitBtn8.Enabled:=False;    //SAVE all Viewlist to file

//  Button3.Enabled:=False;
  BitBtn5.Enabled:=False; // save to viewlist
  BitBtn10.Enabled:=False; // Cancel button

//  Button3.Visible:=False;
  BitBtn5.Visible:=False;
  BitBtn10.Visible:=False; // Cancel button

//  Button7.Visible:=False;
  BitBtn6.Visible:=False;

  // przyciski Append Insert i Delete na stracie niewidoczne, dopoki nie ebdzie zaladowany jakis plik do edycji
  BitBtn1.Visible:=False;
  BitBtn2.Visible:=False;
  BitBtn3.Visible:=False;
  // w celu "ukrycia" przycisku, zeby nie byl widoczny (a nie mozna uzywc visible bo musi ono dzialac zeby Appen poprawnie dazialal, rozmiary beda minimalne zeby zniknal:
  BitBtn3.Height:=0;
  BitBtn3.Width:=0;


  path_selected_fopro:='';
  path_selected_msg:='';

  lang1:='';
  lang2:='';
  lang3:='';

  licznik_critterow:=0;

  if not FileExists(ExtractFilePath(Application.ExeName) + 'CritterProtoEditor.ini') then
  begin
    plikIni := TINIFile.Create(ExtractFilePath(Application.ExeName) + 'CritterProtoEditor.ini');
    try
      plikIni.WriteString('main','path_server','');
      plikIni.WriteString('main','language','engl');
      plikIni.WriteString('Languages','lang1','engl');
      plikIni.WriteString('Languages','lang2','russ');
      plikIni.WriteString('Languages','lang3','');


      lang1:='engl';
      lang2:='russ';
      lang3:='';
    finally
      plikIni.Free;
    end;
  end
  else
  begin
    plikIni:=TiniFile.Create(ExtractFilePath(Application.ExeName) + 'CritterProtoEditor.ini');
    try
      path_server:=plikIni.ReadString('main','path_server', '');
      language:=plikIni.ReadString('main','language', 'engl');
      language:=Trim(language);

      path_CritterTypes_cfg:=path_server+'\data\CritterTypes.cfg';
      path_all_fopro:=path_server+'\proto\critters\';
      path_fodlg_msg:=path_server+'\text\'+language+'\fodlg.msg';

//      path_teams_fos:=path_server+'\scripts\_teams.fos';

      lang1:=plikIni.ReadString('Languages','lang1', 'engl');
      lang2:=plikIni.ReadString('Languages','lang2', 'russ');
      lang3:=plikIni.ReadString('Languages','lang3', '');
    finally
      plikIni.Free;
    end;
  end;

  if not FileExists(path_CritterTypes_cfg) then
  begin
    if SelectDirectory('Select Fonline ...\Server\ directory:','',path_server) then
    begin
      plikIni := TINIFile.Create(ExtractFilePath(Application.ExeName) + 'CritterProtoEditor.ini');
      try
        plikIni.WriteString('main','path_server',path_server);
        language:='engl';
        plikIni.WriteString('main','language',language);

        plikIni.WriteString('Languages','lang1','engl');
        plikIni.WriteString('Languages','lang2','russ');
        plikIni.WriteString('Languages','lang3','');

        lang1:='engl';
        lang2:='russ';
        lang3:='';
      finally
        plikIni.Free;
      end;
    end
    else
    begin
      ShowMessage('                  Action canceled!                 ');
      Application.Terminate;
    end;
  end;

  BitBtn9.Visible:=True;  // button Backup


  path_CritterTypes_cfg:=path_server+'\data\CritterTypes.cfg';
  path_all_fopro:=path_server+'\proto\critters\';
  path_fodlg_msg:=path_server+'\text\'+language+'\fodlg.msg';
//  path_teams_fos:=path_server+'\scripts\_teams.fos';

  path_selected_fopro:=path_server+'\proto\critters\';
  path_selected_msg:=path_server+'\text\'+language+'\fodlg.msg';

  OpenDialog1.InitialDir:=path_server+'\proto\critters\';


  ComboBox7.Clear;
  if Length(lang1)=4 then ComboBox7.Items.Append(lang1);
  if Length(lang2)=4 then ComboBox7.Items.Append(lang2);
  if Length(lang3)=4 then ComboBox7.Items.Append(lang3);
  if ComboBox7.Items.Count>0 then ComboBox7.ItemIndex:=ComboBox7.Items.IndexOf(language);



  if not FileExists(path_CritterTypes_cfg) then
  begin
    ShowMessage('                  Fonline SERVER directory is not correct                 ');
    Halt;
  end
  else
  begin
    //ladowanie listy teammow z _teams.fos do ComboBox6 (TEAM ID)

    {Lista := TStringList.Create;
    try
      AssignFile(plik_temp,path_teams_fos);
      Reset(plik_temp);

      While not Eof(plik_temp) do
      begin
        Readln(plik_temp,linia_temp);
        linia_temp:=Trim(linia_temp);
        pozycja_temp1:=Pos('TEAM_',linia_temp);
        if pozycja_temp1>0 then
        begin
          pozycja_temp2:=Pos('(',linia_temp);
          linia_temp:=Copy(linia_temp,pozycja_temp1,pozycja_temp2-pozycja_temp1);
          linia_temp:=Trim(linia_temp);

          Lista.Add(linia_temp);
        end;
      end;
      CloseFile(plik_temp);

      ComboBox6.Items.Clear;
      ComboBox6.Items.AddStrings(Lista);
    finally
      Lista.Free;
    end;
    }

    Lista := TStringList.Create;
    try
      linia_temp:='TEAM_Default';
      Lista.Add(linia_temp);
      ComboBox6.Items.Clear;
      ComboBox6.Items.AddStrings(Lista);
    finally
      Lista.Free;
    end;

    //ladowanie listy PERKow z combat_perks.txt do ViewListEditor1

    Lista := TStringList.Create;
    try
      AssignFile(plik_temp, ExtractFilePath(Application.ExeName) + 'combat_perks.txt');
      Reset(plik_temp);

      While not Eof(plik_temp) do
      begin
        Readln(plik_temp,linia_temp);
        linia_temp:=Trim(linia_temp);
        Lista.Add(linia_temp);
      end;
      CloseFile(plik_temp);

	  for iter:=0 to Lista.Count-1 do
      ValueListEditor1.InsertRow(Lista.Strings[iter], '', true);

      for iter:=0 to Lista.Count-1 do
        ListView1.Columns.Add.Caption:=Lista[iter];

    finally
      Lista.Free;
    end;

    // pancerz i helm crittera (jako Itemy w inv)
	  ListView1.Columns.Add.Caption:='ST_DEFAULT_ARMOR_PID';
    ListView1.Columns.Add.Caption:='ST_DEFAULT_HELMET_PID';

    
	//ladowanie listy TRAIT z traits.txt do ViewListEditor1

    Lista := TStringList.Create;
    try
      AssignFile(plik_temp, ExtractFilePath(Application.ExeName) + 'traits.txt');
      Reset(plik_temp);

      While not Eof(plik_temp) do
      begin
        Readln(plik_temp,linia_temp);
        linia_temp:=Trim(linia_temp);
        Lista.Add(linia_temp);
      end;
      CloseFile(plik_temp);

	  for iter:=0 to Lista.Count-1 do
      ValueListEditor2.InsertRow(Lista.Strings[iter], '', true);

      for iter:=0 to Lista.Count-1 do
        ListView1.Columns.Add.Caption:=Lista[iter];

    finally
      Lista.Free;
    end;
	
{
    //ladowanie listy traitow z traits.txt do ViewListEditor1

    Lista := TStringList.Create;
    try
      AssignFile(plik_temp, ExtractFilePath(Application.ExeName) + 'combat_perks.txt');
      Reset(plik_temp);

      While not Eof(plik_temp) do
      begin
        Readln(plik_temp,linia_temp);
        linia_temp:=Trim(linia_temp);
        Lista.Add(linia_temp);
      end;
      CloseFile(plik_temp);

	  for iter:=0 to Lista.Count-1 do
      ValueListEditor1.InsertRow(Lista.Strings[iter], '0', true);


      //ComboBox8.Items.Clear;
      //ComboBox8.Items.AddStrings(Lista);

      for iter:=0 to Lista.Count-1 do
        ListView1.Columns.Add.Caption:=Lista[iter];

    finally
      Lista.Free;
    end;
}
    Inicjalizacja;

  end;

//  BackupServerFiles;

  global_STOP_FOR_SAVE:=False;
  lokal_STOP_FOR_SAVE:=False;
end;


procedure TForm1.Inicjalizacja;
var iter:Integer;

begin
//######## inicjalizacja tablic ####################
  for iter:=1 to 9999 do
  begin
    tab_PID[iter]:='';
    tab_nazwy[iter]:='';
    tab_opisy[iter]:='';
  end;
end;



procedure TForm1.Sprawdz_NazwyCritterow_PrzedZapisemDoPliku(_ListView: TListView);
var
  idxItem: Integer;
  ItemCount: Word;
  iter:Integer;

begin
  ItemCount := 0;

  if _ListView.Items.Count = 0 then // List is empty
    ItemCount := 0
  else
    ItemCount := _ListView.Items.Count;

  idxItem := 0;



  idxItem := 0;
  if _ListView.Items.Count > 0 then
    while idxItem<=ItemCount-1 do
    begin

      if (_ListView.Items[idxItem].SubItems[1]='new critter') then
      begin
        _ListView.Items[idxItem].Delete;
        ItemCount := _ListView.Items.Count;
        idxItem:=0;
      end

      else
      if idxItem<ItemCount then
        Inc(idxItem);

    end;

  if _ListView.Items.Count > 0 then
    _ListView.Items[ItemCount-1].Selected:=True;
end;



procedure TForm1.SaveListViewToFile(AListView: TListView; fopro_FileName,fodlg_FileName: string);
var
  idxItem, idxSub: Integer;
  plik:TextFile;
  plik2:TextFile;

  sText: string;
  ItemCount, SubCount: Word;
  PIDek:String; //z mienna do przechowywania wartosci pid potrzebnej do zapisu nazwy crittera
  nazwa_cr,opis_cr:String;

  iter:Integer;

begin
if global_STOP_FOR_SAVE=True then
begin

  Caption:='Fonline:Reloaded Critter Proto Editor ' + wersja_programu +' - Saving ...';


  ItemCount := 0;
  SubCount  := 0;


  AssignFile(plik,fopro_FileName);
  Rewrite(plik);


  if AListView.Items.Count = 0 then // List is empty
    ItemCount := 0
  else
    ItemCount := AListView.Items.Count;

  if AListView.Items.Count > 0 then
  begin
    for idxItem := 1 to ItemCount do
    begin
      Writeln(plik,'[Critter proto]');
      //Save subitems count
      if AListView.Items[idxItem - 1].SubItems.Count = 0 then
        SubCount := 0
      else
        SubCount := AListView.Items[idxItem - 1].Subitems.Count;

      if SubCount > 0 then
      begin
        for idxSub := 0 to AListView.Items[idxItem - 1].SubItems.Count - 1 do
        begin
          //Save Item's subitems
          sText := AListView.Items[idxItem - 1].SubItems[idxSub];
          case idxSub of
          0:begin if sText<>'' then Writeln(plik,'Pid='+sText); PIDek:=sText; tab_PID[strToInt(PIDek)]:=Trim(PIDek); { Memo1.Lines.Append(tab_PID[strToInt(PIDek)] + ', ' + PIDek);} end;
          1:begin
              // zapisanie nazwy i opisu crittera do pliku fodlg.msg
              nazwa_cr:=sText;
              //opis_cr:= AListView.Items[idxItem - 1].SubItems[idxSub];
              opis_cr:= AListView.Items[idxItem - 1].Caption;


              tab_nazwy[strToInt(PIDek)]:=Trim(nazwa_cr);
              tab_opisy[strToInt(PIDek)]:=Trim(opis_cr);

//              Memo1.Lines.Append(tab_nazwy[strToInt(PIDek)]+ ', ' + PIDek);
            end;

          2:begin if sText<>'' then begin Writeln(plik,'ST_BASE_CRTYPE='+sText); Writeln(plik,'ST_OVERRIDE_CRTYPE='+sText); end; end;
          4:begin if sText<>'' then Writeln(plik,'ST_STRENGTH='+sText); end;
          5:begin if sText<>'' then Writeln(plik,'ST_PERCEPTION='+sText); end;
          6:begin if sText<>'' then Writeln(plik,'ST_ENDURANCE='+sText); end;
          7:begin if sText<>'' then Writeln(plik,'ST_CHARISMA='+sText); end;
          8:begin if sText<>'' then Writeln(plik,'ST_INTELLECT='+sText); end;
          9:begin if sText<>'' then Writeln(plik,'ST_AGILITY='+sText); end;
          10:begin if sText<>'' then Writeln(plik,'ST_LUCK='+sText); end;

          11:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_KILL_EXPERIENCE='+sText); end;

          12:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_MAX_LIFE='+sText); end;
          13:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_ACTION_POINTS='+sText); end;
          14:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_ARMOR_CLASS='+sText); end;
          15:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_MELEE_DAMAGE='+sText); end;
          16:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_CARRY_WEIGHT='+sText); end;
          17:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_SEQUENCE='+sText); end;
          18:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_HEALING_RATE='+sText); end;
          19:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_CRITICAL_CHANCE='+sText); end;

          20:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_BODY_TYPE='+sText); end;
          21:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_LOCOMOTION_TYPE='+sText); end;
          22:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_DAMAGE_TYPE='+sText); end;
          23:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_GENDER='+sText); end;
          24:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_AGE='+sText); end;
          25:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_SCALE_FACTOR='+sText); end;
          26:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_AI_ID='+sText); end;

          27:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'SK_SMALL_GUNS='+sText); end;
          28:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'SK_BIG_GUNS='+sText); end;
          29:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'SK_ENERGY_WEAPONS='+sText); end;
          30:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'SK_UNARMED='+sText); end;
          31:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'SK_SCAVENGING='+sText); end;
          32:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'SK_THROWING='+sText); end;
          33:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'SK_FIRST_AID='+sText); end;
          34:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'SK_DOCTOR='+sText); end;
          35:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'SK_SNEAK='+sText); end;
          36:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'SK_LOCKPICK='+sText); end;
          37:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'SK_STEAL='+sText); end;
          38:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'SK_TRAPS='+sText); end;
          39:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'SK_SCIENCE='+sText); end;
          40:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'SK_REPAIR='+sText); end;
          41:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'SK_SPEECH='+sText); end;
          42:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'SK_BARTER='+sText); end;
          43:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'SK_GAMBLING='+sText); end;
          44:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'SK_OUTDOORSMAN='+sText); end;

          45:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_NORMAL_ABSORB='+sText); end;
          46:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_LASER_ABSORB='+sText); end;
          47:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_FIRE_ABSORB='+sText); end;
          48:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_PLASMA_ABSORB='+sText); end;
          49:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_ELECTRO_ABSORB='+sText); end;
          50:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_EMP_ABSORB='+sText); end;
          51:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_EXPLODE_ABSORB='+sText); end;
          52:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_NORMAL_RESIST='+sText); end;
          53:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_LASER_RESIST='+sText); end;
          54:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_FIRE_RESIST='+sText); end;
          55:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_PLASMA_RESIST='+sText); end;
          56:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_ELECTRO_RESIST='+sText); end;
          57:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_EMP_RESIST='+sText); end;
          58:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_EXPLODE_RESIST='+sText); end;
          59:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_RADIATION_RESISTANCE='+sText); end;
          60:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_POISON_RESISTANCE='+sText); end;


          61:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_DIALOG_ID='+sText); end;
          62:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_BAG_ID='+sText); end;
          63:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_TEAM_ID='+sText); end;


          64:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_HIDE='+sText); end;
          65:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_NO_STEAL='+sText); end;
          66:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_NO_BARTER='+sText); end;
          67:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_NO_ENEMY_STACK='+sText); end;
          68:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_NO_PVP='+sText); end;
          69:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_NO_HOME='+sText); end;
          70:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_DLG_SCRIPT_BARTER='+sText); end;
          71:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_UNLIMITED_AMMO='+sText); end;
          72:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_NO_DROP='+sText); end;
          73:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_NO_LOOSE_LIMBS='+sText); end;
          74:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_DEAD_AGES='+sText); end;
          75:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_NO_HEAL='+sText); end;
          76:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_INVULNERABLE='+sText); end;
          77:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_NO_FLATTEN='+sText); end;
          78:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_SPECIAL_DEAD='+sText); end;
          79:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_RANGE_HTH='+sText); end;
          80:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_NO_KNOCK='+sText); end;
          81:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_NO_LOOT='+sText); end;
          82:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_NO_KARMA_ON_KILL='+sText); end;
          83:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_BARTER_ONLY_CASH='+sText); end;
          84:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_NO_PUSH='+sText); end;
          85:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_NO_UNARMED='+sText); end;
          86:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_NO_AIM='+sText); end;
          87:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_NO_WALK='+sText); end;
          88:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_NO_RUN='+sText); end;
          89:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'MODE_NO_TALK='+sText); end;
          90:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_TOXIC='+sText); end;
          91:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_RADIOACTIVE='+sText); end;

          92:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_LEVEL='+sText); end;
          93:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_WALK_TIME='+sText); end;
          94:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'ST_RUN_TIME='+sText); end;

		  95 :begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_ACTION_BOY='+sText); end;
96 :begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_ADRENALINE_RUSH='+sText); end;
97 :begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_BEST_OF_A_BAD_LOT='+sText); end;
98 :begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_BETTER_CRITICALS='+sText); end;
99 :begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_BLESSED_ARE_THE_WEAK='+sText); end;
100:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_BONUS_HTH_ATTACKS='+sText); end;
101:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_CLOSE_COMBAT_MASTER='+sText); end;
102:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_CLOSE_COMBAT_MASTER_II='+sText); end;
103:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_BONUS_MOVE='+sText); end;
104:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_BONUS_RANGED_DAMAGE='+sText); end;
105:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_BONUS_RATE_OF_ATTACK='+sText); end;
106:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_BORN_LEADER='+sText); end;
107:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_DEAD_MAN_WALKING='+sText); end;
108:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_DEMOLITION_EXPERT='+sText); end;
109:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_DERMAL_IMPACT='+sText); end;
110:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_DERMAL_IMPACT_ENH='+sText); end;
111:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_DODGER='+sText); end;
112:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_DODGER_II='+sText); end;
113:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_EARLIER_SEQUENCE='+sText); end;
114:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_EVEN_MORE_CRITICALS='+sText); end;
115:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_EVEN_TOUGHER='+sText); end;
116:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_FAST_RELOAD='+sText); end;
117:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_HAND_LOADER='+sText); end;
118:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_FIELD_MEDIC_II='+sText); end;
119:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_HEAVE_HO='+sText); end;
120:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_HEAVE_HO_II='+sText); end;
121:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_HIT_THE_GAPS='+sText); end;
122:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_HTH_CRITICALS='+sText); end;
123:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_HTH_EVADE='+sText); end;
124:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_HTH_EVADE_II='+sText); end;
125:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_IN_YOUR_FACE='+sText); end;
126:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_IRON_LIMBS='+sText); end;
127:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_JINXED_II='+sText); end;
128:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_LIVEWIRE='+sText); end;
129:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_LIVING_ANATOMY='+sText); end;
130:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_MAN_OF_STEEL='+sText); end;
131:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_MELT_INTO_SHADOW='+sText); end;
132:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_MORE_CRITICALS='+sText); end;
133:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_MORE_RANGED_DAMAGE='+sText); end;
134:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_NEMEAN_ARMOR='+sText); end;
135:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_PHOENIX_IMPLANTS='+sText); end;
136:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_PHOENIX_IMPLANTS_ENH='+sText); end;
137:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_PYROMANIAC='+sText); end;
138:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_QUICK_POCKETS='+sText); end;
139:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_QUICK_RECOVERY='+sText); end;
140:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_RIGHT_BETWEEN_THE_EYES='+sText); end;
141:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_SHARPSHOOTER='+sText); end;
142:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_SILENT_DEATH='+sText); end;
143:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_SLAYER='+sText); end;
144:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_SNIPER='+sText); end;
145:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_SPRAY_AND_PRAY='+sText); end;
146:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_STEALTH_GIRL='+sText); end;
147:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_STONEWALL='+sText); end;
148:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_TERMINATOR='+sText); end;
149:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_TOUGHNESS='+sText); end;
150:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_TREE_TRUNK_THIGHS='+sText); end;
151:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_WEAPON_HANDLING='+sText); end;

152:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_FASTER_HEALING='+sText); end;
153:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_GHOST='+sText); end;
154:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_FIELD_MEDIC='+sText); end;
155:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_LIFEGIVER='+sText); end;
156:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_LIGHT_STEP='+sText); end;
157:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'PE_MEDIC='+sText); end;

158:begin if (sText<>'') and (sText<>'None') then Writeln(plik,'ST_DEFAULT_ARMOR_PID='+sText); end;
159:begin if (sText<>'') and (sText<>'None') then Writeln(plik,'ST_DEFAULT_HELMET_PID='+sText); end;

160:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'TRAIT_FAST_METABOLISM='+sText); end;
161:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'TRAIT_BRUISER='+sText); end;
162:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'TRAIT_SMALL_FRAME='+sText); end;
163:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'TRAIT_ONE_HANDER='+sText); end;
164:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'TRAIT_FINESSE='+sText); end;
165:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'TRAIT_KAMIKAZE='+sText); end;
166:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'TRAIT_HEAVY_HANDED='+sText); end;
167:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'TRAIT_FAST_SHOT='+sText); end;
168:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'TRAIT_BLOODY_MESS='+sText); end;
169:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'TRAIT_JINXED='+sText); end;
170:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'TRAIT_GOOD_NATURED='+sText); end;
171:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'TRAIT_CHEM_RELIANT='+sText); end;
172:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'TRAIT_CHEM_RESISTANT='+sText); end;
173:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'TRAIT_BONEHEAD='+sText); end;
174:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'TRAIT_SKILLED='+sText); end;
175:begin if (sText<>'') and (sText<>'0') then Writeln(plik,'TRAIT_LONER='+sText); end;


          end;
        end;
      end;
      Writeln(plik,'');
    end;
  end;
  CloseFile(plik);



  AssignFile(plik2,fodlg_FileName);
  Rewrite(plik2);
  for iter:=1 to 9999 do
  begin
    if IntToStr(iter)=tab_PID[iter] then
    begin
      if ((Trim(tab_nazwy[iter])<>'') and (Trim(tab_nazwy[iter])<>'new critter')) then Writeln(plik2,'{'+IntToStr(iter)+'0}{}{'+tab_nazwy[iter]+'}');
      if Trim(tab_opisy[iter])<>'' then Writeln(plik2,'{'+IntToStr(iter)+'1}{}{'+tab_opisy[iter]+'}');
    end

  end;
  CloseFile(plik2);

  Sleep(300);
  Caption:=ExtractFileName(path_selected_fopro) + '  -  ' + 'Fonline:Reloaded Critter Proto Editor ' + wersja_programu;
end;
  global_STOP_FOR_SAVE:=False;
end;


procedure TForm1.ZapiszFopro;
begin
  Form1.Cursor:=crHourGlass;

  BitBtn8.Enabled:=False;

  Sprawdz_NazwyCritterow_PrzedZapisemDoPliku(ListView1);

  SaveListViewToFile(ListView1, path_selected_fopro,path_selected_msg);

  BitBtn8.Enabled:=True;

  Form1.Cursor:=crDefault;
end;



procedure TForm1.WczytajFopro;    //Load from file
var plik,plik2:TextFile;
    linia,linia2,linia_:String;
    pozycja:Integer;
    numerek:String; // tymczasowa zmienna do przechowania numeru odczytanego z CritterTypes.cfg
    linia_critter,linia_numer_critter:String;
//    iter:Integer;
    linia_numer_critter_temp:String;
    cyfra:String;

    name,desc:String; // zmienne przechowujace name i descr crittera pochodzace z konwersji Fallout do fonline


begin
  //Memo1.Clear;
  path_selected_fopro:=path_all_fopro;
  path_selected_msg:=path_fodlg_msg;

  if not FileExists(path_selected_msg) then
  begin
    ShowMessage('File ' + path_selected_msg + ' not exists!');
    Exit;
  end;

  Caption:='Fonline:Reloaded Critter Proto Editor ' + wersja_programu +' - Loading ...';
  StatusBar1.SimpleText:=Caption;
  ListView1.Items.Clear;

  BitBtn7.Caption:='Load';

  linia:='';
  licznik_critterow:=0;



  Caption:='Fonline:Reloaded Critter Proto Editor ' + wersja_programu +' - Loading ...' + path_selected_fopro;

  Inicjalizacja;

  linia_numer_critter_temp:='';
  
  AssignFile(plik2,path_selected_msg);
  Reset(plik2);
  while not eof(plik2) do
  begin
    //{2470}{}{Nasty Floater}
    Readln(plik2,linia_critter);
    linia_critter:=Trim(linia_critter);
    //    ShowMessage(linia_critter[1]);
    if (length(linia_critter)>0) and (linia_critter[1]<>'#') then
    begin
      Delete(linia_critter,1,1);
      //2470}{}{Nasty Floater}
      pozycja:=Pos('}',linia_critter);
      //linia_numer_critter:=linia_critter;
      linia_numer_critter:=Copy(linia_critter,1,pozycja-1);
      //Delete(linia_numer_critter,pozycja,length(linia_numer_critter));

      //ShowMessage(linia_numer_critter);
      linia_numer_critter_temp:=IntToStr(StrToInt(linia_numer_critter) div 10);

      if StrToInt(linia_numer_critter) mod 10=0 then
        cyfra:='0'
      else
        cyfra:='1';

//      pozycja:=Pos('0}',linia_numer_critter);
//      if pozycja>0 then
//        cyfra:='0'
//      else
//        cyfra:='1';

      if cyfra='0' then
      begin
        tab_PID[StrToInt(linia_numer_critter) div 10]:=linia_numer_critter_temp;

        //pozycja:=Pos('}{}{',linia_numer_critter);
        Delete(linia_critter,1,pozycja+3);
        Delete(linia_critter,length(linia_critter),1);  // tutaj linia_temp jest numerem PID crittera i na jego podstawie bede szukal numeru obrazka i nazwy z tego numeru
        nazwa_crittera:=Trim(linia_critter);

        tab_nazwy[StrToInt(linia_numer_critter) div 10]:=nazwa_crittera;
        //Memo1.Lines.Append(nazwa_crittera);
        //Memo1.Lines.Append(tab_PID[StrToInt(linia_numer_critter) div 10]+':'+tab_nazwy[StrToInt(linia_numer_critter) div 10]);
      end;
      if cyfra='1' then
      begin
        tab_PID[StrToInt(linia_numer_critter) div 10]:=linia_numer_critter_temp;

        //pozycja:=Pos('}{}{',linia_numer_critter);
        Delete(linia_critter,1,pozycja+3);
        Delete(linia_critter,length(linia_critter),1);  // tutaj linia_temp jest numerem PID crittera i na jego podstawie bede szukal numeru obrazka i nazwy z tego numeru
        opis_crittera:=Trim(linia_critter);

        tab_opisy[StrToInt(linia_numer_critter) div 10]:=opis_crittera;
        //Memo1.Lines.Append(opis_crittera);
        //Memo1.Lines.Append(tab_PID[StrToInt(linia_numer_critter) div 10]+':'+tab_nazwy[StrToInt(linia_numer_critter) div 10]);
      end;
    end;
  end;
  CloseFile(plik2);
  ostatni_numer_pid_w_fodlg_msg:=IntToStr(StrToInt(linia_numer_critter) div 10);
  //ShowMessage(ostatni_numer_pid_w_fodlg_msg);

  AssignFile(plik,path_selected_fopro);
  Reset(plik);
  While not Eof(plik) do
  begin

    if Copy(linia,1,15)='[Critter proto]' then
    begin
      Inc(licznik_critterow);

      name:='';
      desc:='';

      nazwa_crittera:='';
      opis_crittera:='';
      nazwa_frm:='';

      Pid:='';
      ST_BASE_CRTYPE:='';
      ST_AI_ID:='1';

      ST_STRENGTH:='5';
      ST_PERCEPTION:='5';
      ST_ENDURANCE:='5';
      ST_CHARISMA:='5';
      ST_INTELLECT:='5';
      ST_AGILITY:='5';
      ST_LUCK:='5';

      ST_MAX_LIFE:='0';
      ST_ACTION_POINTS:='0';
      ST_ARMOR_CLASS:='0';
      ST_MELEE_DAMAGE:='0';
      ST_CARRY_WEIGHT:='0';
      ST_SEQUENCE:='0';
      ST_HEALING_RATE:='0';
      ST_CRITICAL_CHANCE:='0';
      ST_MAX_CRITICAL:='0';

      ST_KILL_EXPERIENCE:='0';
      ST_BODY_TYPE:='0';
      ST_LOCOMOTION_TYPE:='0';
      ST_DAMAGE_TYPE:='1';
      ST_AGE:='25';
      ST_GENDER:='0';
      ST_SCALE_FACTOR:='0';

      ST_NORMAL_ABSORB:='0';
      ST_LASER_ABSORB:='0';
      ST_FIRE_ABSORB:='0';
      ST_PLASMA_ABSORB:='0';
      ST_ELECTRO_ABSORB:='0';
      ST_EMP_ABSORB:='0';
      ST_EXPLODE_ABSORB:='0';
      ST_NORMAL_RESIST:='0';
      ST_LASER_RESIST:='0';
      ST_FIRE_RESIST:='0';
      ST_PLASMA_RESIST:='0';
      ST_ELECTRO_RESIST:='0';
      ST_EMP_RESIST:='500';
      ST_EXPLODE_RESIST:='0';
      ST_RADIATION_RESISTANCE:='0';
      ST_POISON_RESISTANCE:='0';

      SK_SMALL_GUNS:='0';
      SK_BIG_GUNS:='0';
      SK_ENERGY_WEAPONS:='0';
      SK_UNARMED:='0';
      SK_SCAVENGING:='0';
      SK_THROWING:='0';
      SK_FIRST_AID:='0';
      SK_DOCTOR:='0';
      SK_SNEAK:='0';
      SK_LOCKPICK:='0';
      SK_STEAL:='0';
      SK_TRAPS:='0';
      SK_SCIENCE:='0';
      SK_REPAIR:='0';
      SK_SPEECH:='0';
      SK_BARTER:='0';
      SK_GAMBLING:='0';
      SK_OUTDOORSMAN:='0';

      ST_DIALOG_ID:='0';
      ST_BAG_ID:='0';
      ST_TEAM_ID:='0';

      MODE_HIDE:='0';
      MODE_NO_STEAL:='0';
      MODE_NO_BARTER:='0';
      MODE_NO_ENEMY_STACK:='0';
      MODE_NO_PVP:='0';
      MODE_NO_HOME:='0';
      MODE_DLG_SCRIPT_BARTER:='0';
      MODE_UNLIMITED_AMMO:='0';
      MODE_NO_DROP:='0';
      MODE_NO_LOOSE_LIMBS:='0';
      MODE_DEAD_AGES:='0';
      MODE_NO_HEAL:='0';
      MODE_INVULNERABLE:='0';
      MODE_NO_FLATTEN:='0';
      MODE_SPECIAL_DEAD:='0';
      MODE_RANGE_HTH:='0';
      MODE_NO_KNOCK:='0';
      MODE_NO_LOOT:='0';
      MODE_NO_KARMA_ON_KILL:='0';
      MODE_BARTER_ONLY_CASH:='0';
      MODE_NO_PUSH:='0';
      MODE_NO_UNARMED:='0';
      MODE_NO_AIM:='0';             // Critter can't do aim attacks
      MODE_NO_WALK:='0';            // Critter can't walk
      MODE_NO_RUN:='0';             // Critter can't run
      MODE_NO_TALK:='0';

      ST_TOXIC:='0';
      ST_RADIOACTIVE:='0';

      ST_LEVEL:='0';
      ST_WALK_TIME:='0';
      ST_RUN_TIME:='0';

PE_ACTION_BOY            :='';
PE_ADRENALINE_RUSH       :='';
PE_BEST_OF_A_BAD_LOT     :='';
PE_BETTER_CRITICALS      :='';
PE_BLESSED_ARE_THE_WEAK  :='';
PE_BONUS_HTH_ATTACKS     :='';
PE_CLOSE_COMBAT_MASTER      :='';
PE_CLOSE_COMBAT_MASTER_II   :='';
PE_BONUS_MOVE            :='';
PE_BONUS_RANGED_DAMAGE   :='';
PE_BONUS_RATE_OF_ATTACK    :='';
PE_BORN_LEADER           :='';
PE_DEAD_MAN_WALKING      :='';
PE_DEMOLITION_EXPERT     :='';
PE_DERMAL_IMPACT         :='';
PE_DERMAL_IMPACT_ENH     :='';
PE_DODGER                :='';
PE_DODGER_II             :='';
PE_EARLIER_SEQUENCE      :='';
PE_EVEN_MORE_CRITICALS   :='';
PE_EVEN_TOUGHER          :='';
PE_FAST_RELOAD           :='';
PE_HAND_LOADER           :='';
PE_FIELD_MEDIC_II             :='';
PE_HEAVE_HO              :='';
PE_HEAVE_HO_II           :='';
PE_HIT_THE_GAPS          :='';
PE_HTH_CRITICALS         :='';
PE_HTH_EVADE             :='';
PE_HTH_EVADE_II          :='';
PE_IN_YOUR_FACE          :='';
PE_IRON_LIMBS             :='';
PE_JINXED_II             :='';
PE_LIVEWIRE              :='';
PE_LIVING_ANATOMY        :='';
PE_MAN_OF_STEEL          :='';
PE_MELT_INTO_SHADOW      :='';
PE_MORE_CRITICALS        :='';
PE_MORE_RANGED_DAMAGE    :='';
PE_NEMEAN_ARMOR          :='';
PE_PHOENIX_IMPLANTS      :='';
PE_PHOENIX_IMPLANTS_ENH  :='';
PE_PYROMANIAC            :='';
PE_QUICK_POCKETS         :='';
PE_QUICK_RECOVERY        :='';
PE_RIGHT_BETWEEN_THE_EYES:='';
PE_SHARPSHOOTER          :='';
PE_SILENT_DEATH          :='';
PE_SLAYER                :='';
PE_SNIPER                :='';
PE_SPRAY_AND_PRAY        :='';
PE_STEALTH_GIRL          :='';
PE_STONEWALL             :='';
PE_TERMINATOR            :='';
PE_TOUGHNESS             :='';
PE_TREE_TRUNK_THIGHS     :='';
PE_WEAPON_HANDLING       :='';

PE_FASTER_HEALING:='';
PE_GHOST:='';
PE_FIELD_MEDIC:='';
PE_LIFEGIVER:='';
PE_LIGHT_STEP:='';
PE_MEDIC:='';

ST_DEFAULT_ARMOR_PID     :='None';
ST_DEFAULT_HELMET_PID     :='None';

TRAIT_FAST_METABOLISM:='';
TRAIT_BRUISER:='';
TRAIT_SMALL_FRAME:='';
TRAIT_ONE_HANDER:='';
TRAIT_FINESSE:='';
TRAIT_KAMIKAZE:='';
TRAIT_HEAVY_HANDED:='';
TRAIT_FAST_SHOT:='';
TRAIT_BLOODY_MESS:='';
TRAIT_JINXED:='';
TRAIT_GOOD_NATURED:='';
TRAIT_CHEM_RELIANT:='';
TRAIT_CHEM_RESISTANT:='';
TRAIT_BONEHEAD:='';
TRAIT_SKILLED:='';
TRAIT_LONER:='';


      Readln(plik,linia);
      linia:=Trim(linia);

      while (linia<>'[Critter proto]') and (not Eof(plik)) do
      begin
        linia2:=linia;
        pozycja:=Pos('=',linia2);
        if pozycja>0 then
        begin
          if Copy(linia2,1,pozycja-1)= 'name' then
          begin
            Delete(linia2,1,pozycja);
            name:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'desc' then
          begin
            Delete(linia2,1,pozycja);
            desc:=linia2;
          end
          else

          if Copy(linia2,1,pozycja-1)= 'Pid' then
          begin
            Delete(linia2,1,pozycja);
            Pid:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_BASE_CRTYPE' then
          begin
            Delete(linia2,1,pozycja);
            ST_BASE_CRTYPE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_AI_ID' then
          begin
            Delete(linia2,1,pozycja);
            ST_AI_ID:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_STRENGTH' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_STRENGTH:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_PERCEPTION' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_PERCEPTION:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_ENDURANCE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_ENDURANCE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_CHARISMA' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_CHARISMA:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_INTELLECT' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_INTELLECT:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_AGILITY' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_AGILITY:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_LUCK' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_LUCK:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_MAX_LIFE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_MAX_LIFE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_ACTION_POINTS' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_ACTION_POINTS:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_ARMOR_CLASS' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_ARMOR_CLASS:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_MELEE_DAMAGE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_MELEE_DAMAGE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_CARRY_WEIGHT' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_CARRY_WEIGHT:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_SEQUENCE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_SEQUENCE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_HEALING_RATE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_HEALING_RATE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_CRITICAL_CHANCE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_CRITICAL_CHANCE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_MAX_CRITICAL' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_MAX_CRITICAL:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_NORMAL_ABSORB' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_NORMAL_ABSORB:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_LASER_ABSORB' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_LASER_ABSORB:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_FIRE_ABSORB' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_FIRE_ABSORB:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_PLASMA_ABSORB' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_PLASMA_ABSORB:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_ELECTRO_ABSORB' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_ELECTRO_ABSORB:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_EMP_ABSORB' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_EMP_ABSORB:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_EXPLODE_ABSORB' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_EXPLODE_ABSORB:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_NORMAL_RESIST' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_NORMAL_RESIST:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_LASER_RESIST' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_LASER_RESIST:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_FIRE_RESIST' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_FIRE_RESIST:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_PLASMA_RESIST' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_PLASMA_RESIST:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_ELECTRO_RESIST' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_ELECTRO_RESIST:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_EMP_RESIST' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_EMP_RESIST:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_EXPLODE_RESIST' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_EXPLODE_RESIST:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_RADIATION_RESISTANCE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_RADIATION_RESISTANCE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_POISON_RESISTANCE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_POISON_RESISTANCE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_KILL_EXPERIENCE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_KILL_EXPERIENCE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_BODY_TYPE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_BODY_TYPE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_LOCOMOTION_TYPE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_LOCOMOTION_TYPE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_DAMAGE_TYPE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_DAMAGE_TYPE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_AGE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_AGE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_GENDER' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_GENDER:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_SCALE_FACTOR' then
          begin
//            Delete(linia2,1,pozycja);
//            linia2:=Trim(linia2);
//            ST_SCALE_FACTOR:=linia2;
            ST_SCALE_FACTOR:='0';
          end
          else
          if Copy(linia2,1,pozycja-1)= 'SK_SMALL_GUNS' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            SK_SMALL_GUNS:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'SK_BIG_GUNS' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            SK_BIG_GUNS:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'SK_ENERGY_WEAPONS' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            SK_ENERGY_WEAPONS:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'SK_UNARMED' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            SK_UNARMED:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'SK_SCAVENGING' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            SK_SCAVENGING:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'SK_THROWING' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            SK_THROWING:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'SK_FIRST_AID' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            SK_FIRST_AID:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'SK_DOCTOR' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            SK_DOCTOR:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'SK_SNEAK' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            SK_SNEAK:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'SK_LOCKPICK' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            SK_LOCKPICK:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'SK_STEAL' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            SK_STEAL:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'SK_TRAPS' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            SK_TRAPS:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'SK_SCIENCE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            SK_SCIENCE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'SK_REPAIR' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            SK_REPAIR:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'SK_SPEECH' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            SK_SPEECH:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'SK_BARTER' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            SK_BARTER:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'SK_GAMBLING' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            SK_GAMBLING:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'SK_OUTDOORSMAN' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            SK_OUTDOORSMAN:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_DIALOG_ID' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_DIALOG_ID:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_BAG_ID' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_BAG_ID:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_TEAM_ID' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_TEAM_ID:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_HIDE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_HIDE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_NO_STEAL' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_NO_STEAL:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_NO_BARTER' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_NO_BARTER:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_NO_ENEMY_STACK' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_NO_ENEMY_STACK:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_NO_PVP' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_NO_PVP:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_NO_HOME' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_NO_HOME:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_DLG_SCRIPT_BARTER' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_DLG_SCRIPT_BARTER:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_UNLIMITED_AMMO' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_UNLIMITED_AMMO:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_NO_DROP' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_NO_DROP:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_NO_LOOSE_LIMBS' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_NO_LOOSE_LIMBS:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_DEAD_AGES' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_DEAD_AGES:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_NO_HEAL' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_NO_HEAL:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_INVULNERABLE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_INVULNERABLE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_NO_FLATTEN' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_NO_FLATTEN:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_SPECIAL_DEAD' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_SPECIAL_DEAD:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_RANGE_HTH' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_RANGE_HTH:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_NO_KNOCK' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_NO_KNOCK:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_NO_LOOT' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_NO_LOOT:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_NO_KARMA_ON_KILL' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_NO_KARMA_ON_KILL:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_BARTER_ONLY_CASH' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_BARTER_ONLY_CASH:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_NO_PUSH' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_NO_PUSH:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_NO_UNARMED' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_NO_UNARMED:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_NO_AIM' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_NO_AIM:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_NO_WALK' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_NO_WALK:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_NO_RUN' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_NO_RUN:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'MODE_NO_TALK' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            MODE_NO_TALK:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_TOXIC' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_TOXIC:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_RADIOACTIVE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_RADIOACTIVE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_LEVEL' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_LEVEL:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_WALK_TIME' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_WALK_TIME:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_RUN_TIME' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_RUN_TIME:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_ACTION_BOY' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_ACTION_BOY:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_ADRENALINE_RUSH' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_ADRENALINE_RUSH:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_BEST_OF_A_BAD_LOT' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_BEST_OF_A_BAD_LOT:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_BETTER_CRITICALS' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_BETTER_CRITICALS:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_BLESSED_ARE_THE_WEAK' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_BLESSED_ARE_THE_WEAK:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_BONUS_HTH_ATTACKS' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_BONUS_HTH_ATTACKS:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_CLOSE_COMBAT_MASTER' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_CLOSE_COMBAT_MASTER:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_CLOSE_COMBAT_MASTER_II' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_CLOSE_COMBAT_MASTER_II:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_BONUS_MOVE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_BONUS_MOVE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_BONUS_RANGED_DAMAGE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_BONUS_RANGED_DAMAGE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_BONUS_RATE_OF_ATTACK' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_BONUS_RATE_OF_ATTACK:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_BORN_LEADER' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_BORN_LEADER:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_DEAD_MAN_WALKING' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_DEAD_MAN_WALKING:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_DEMOLITION_EXPERT' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_DEMOLITION_EXPERT:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_DERMAL_IMPACT' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_DERMAL_IMPACT:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_DERMAL_IMPACT_ENH' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_DERMAL_IMPACT_ENH:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_DODGER' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_DODGER:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_DODGER_II' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_DODGER_II:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_EARLIER_SEQUENCE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_EARLIER_SEQUENCE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_EVEN_MORE_CRITICALS' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_EVEN_MORE_CRITICALS:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_EVEN_TOUGHER' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_EVEN_TOUGHER:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_FAST_RELOAD' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_FAST_RELOAD:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_HAND_LOADER' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_HAND_LOADER:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_FIELD_MEDIC_II' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_FIELD_MEDIC_II:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_HEAVE_HO' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_HEAVE_HO:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_HEAVE_HO_II' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_HEAVE_HO_II:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_HIT_THE_GAPS' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_HIT_THE_GAPS:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_HTH_CRITICALS' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_HTH_CRITICALS:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_HTH_EVADE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_HTH_EVADE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_HTH_EVADE_II' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_HTH_EVADE_II:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_IN_YOUR_FACE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_IN_YOUR_FACE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_IRON_LIMBS' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_IRON_LIMBS:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_JINXED_II' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_JINXED_II:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_LIVEWIRE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_LIVEWIRE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_LIVING_ANATOMY' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_LIVING_ANATOMY:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_MAN_OF_STEEL' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_MAN_OF_STEEL:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_MELT_INTO_SHADOW' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_MELT_INTO_SHADOW:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_MORE_CRITICALS' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_MORE_CRITICALS:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_MORE_RANGED_DAMAGE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_MORE_RANGED_DAMAGE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_NEMEAN_ARMOR' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_NEMEAN_ARMOR:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_PHOENIX_IMPLANTS' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_PHOENIX_IMPLANTS:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_PHOENIX_IMPLANTS_ENH' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_PHOENIX_IMPLANTS_ENH:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_PYROMANIAC' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_PYROMANIAC:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_QUICK_POCKETS' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_QUICK_POCKETS:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_QUICK_RECOVERY' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_QUICK_RECOVERY:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_RIGHT_BETWEEN_THE_EYES' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_RIGHT_BETWEEN_THE_EYES:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_SHARPSHOOTER' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_SHARPSHOOTER:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_SILENT_DEATH' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_SILENT_DEATH:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_SLAYER' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_SLAYER:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_SNIPER' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_SNIPER:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_SPRAY_AND_PRAY' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_SPRAY_AND_PRAY:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_STEALTH_GIRL' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_STEALTH_GIRL:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_STONEWALL' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_STONEWALL:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_TERMINATOR' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_TERMINATOR:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_TOUGHNESS' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_TOUGHNESS:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_TREE_TRUNK_THIGHS' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_TREE_TRUNK_THIGHS:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_WEAPON_HANDLING' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_WEAPON_HANDLING:=linia2;
          end
          else
		  
          if Copy(linia2,1,pozycja-1)= 'PE_FASTER_HEALING' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_FASTER_HEALING:=linia2;
          end
          else		  
          if Copy(linia2,1,pozycja-1)= 'PE_GHOST' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_GHOST:=linia2;
          end
          else		  
          if Copy(linia2,1,pozycja-1)= 'PE_FIELD_MEDIC' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_FIELD_MEDIC:=linia2;
          end
          else		  
          if Copy(linia2,1,pozycja-1)= 'PE_LIFEGIVER' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_LIFEGIVER:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_LIGHT_STEP' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_LIGHT_STEP:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'PE_MEDIC' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            PE_MEDIC:=linia2;
          end
          else		  
		  
          if Copy(linia2,1,pozycja-1)= 'ST_DEFAULT_ARMOR_PID' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_DEFAULT_ARMOR_PID:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'ST_DEFAULT_HELMET_PID' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_DEFAULT_HELMET_PID:=linia2;
          end
		      else

          if Copy(linia2,1,pozycja-1)= 'TRAIT_FAST_METABOLISM' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            TRAIT_FAST_METABOLISM:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'TRAIT_BRUISER' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            TRAIT_BRUISER:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'TRAIT_SMALL_FRAME' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            TRAIT_SMALL_FRAME:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'TRAIT_ONE_HANDER' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            TRAIT_ONE_HANDER:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'TRAIT_FINESSE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            TRAIT_FINESSE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'TRAIT_KAMIKAZE' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            TRAIT_KAMIKAZE:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'TRAIT_HEAVY_HANDED' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            TRAIT_HEAVY_HANDED:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'TRAIT_FAST_SHOT' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            TRAIT_FAST_SHOT:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'TRAIT_BLOODY_MESS' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            TRAIT_BLOODY_MESS:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'TRAIT_JINXED' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            TRAIT_JINXED:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'TRAIT_GOOD_NATURED' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            TRAIT_GOOD_NATURED:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'TRAIT_CHEM_RELIANT' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            TRAIT_CHEM_RELIANT:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'TRAIT_CHEM_RESISTANT' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            TRAIT_CHEM_RESISTANT:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'TRAIT_BONEHEAD' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            TRAIT_BONEHEAD:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'TRAIT_SKILLED' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            TRAIT_SKILLED:=linia2;
          end
          else
          if Copy(linia2,1,pozycja-1)= 'TRAIT_LONER' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            TRAIT_LONER:=linia2;
          end;		  


        end;

        Readln(plik,linia);
        linia:=Trim(linia);
      end;  {end while}


 
	  
	  

      AssignFile(plik2,path_selected_msg);
      Reset(plik2);
      while not eof(plik2) do
      begin
        //{2470}{}{Nasty Floater}
        Readln(plik2,linia_critter);
        linia_critter:=Trim(linia_critter);
        if (length(linia_critter)>0) and (linia_critter[1]<>'#') then
        begin
          Delete(linia_critter,1,1);
          //2470}{}{Nasty Floater}
          pozycja:=Pos('}',linia_critter);
          linia_numer_critter:=Copy(linia_critter,1,pozycja-1);
          if linia_numer_critter=Pid+'0' then
          begin
            Delete(linia_critter,1,pozycja+3);
            Delete(linia_critter,length(linia_critter),1);  // tutaj linia_temp jest numerem PID crittera i na jego podstawie bede szukal numeru obrazka i nazwy z tego numeru
            nazwa_crittera:=linia_critter;
            //Memo1.Lines.Append(nazwa_crittera);
          end
          else
          if linia_numer_critter=Pid+'1' then
          begin
            Delete(linia_critter,1,pozycja+3);
            Delete(linia_critter,length(linia_critter),1);  // tutaj linia_temp jest numerem PID crittera i na jego podstawie bede szukal numeru obrazka i nazwy z tego numeru
            opis_crittera:=linia_critter;
            //Memo1.Lines.Append(opis_crittera);
          end;
        end;
      end;
      CloseFile(plik2);



      AssignFile(plik2,path_CritterTypes_cfg);
      reset(plik2);
      While not Eof(plik2) do
      begin
        Readln(plik2,linia_);
        linia_:=Trim(linia_);
//@   94    nfasia     11   0   0    1    0    1    0    1      1 1 1 0 0 0 0 0 0 0 0 0 0 0 0 0 0 1 0 0    495    0  10  0  0  0     -

        if (length(linia_)>0) then
        if linia_[1]='@' then
        begin
          Delete(linia_,1,1);
          linia_:=Trim(linia_);
          numerek:= Copy(linia_,1,3);
          numerek:=Trim(numerek);

          if numerek=ST_BASE_CRTYPE then
          begin
            Delete(linia_,1,3);
            linia_:=Trim(linia_);
            pozycja:=Pos(' ',linia_);
            nazwa_frm:=Copy(linia_,1,pozycja);
            nazwa_frm:=Trim(nazwa_frm);
          end;
        end;
      end;
      CloseFile(plik2);


      ListItem := ListView1.Items.Add;

      //tab_PID[licznik_critterow]:=Pid;

      if name<>'' then        // jesli name<>'' to znaczy ze znalazl wklejony wpis z konwersji Fallout do fonline z f2critters.exe
      begin
        nazwa_crittera:=name;
        opis_crittera:=desc;
      end;
      
      //tab_nazwy[licznik_critterow]:=nazwa_crittera;
      //tab_opisy[licznik_critterow]:=opis_crittera;

      ListItem.Caption:=opis_crittera;
      ListItem.SubItems.Add(Pid);


      ListItem.SubItems.Add(nazwa_crittera);
      ListItem.SubItems.Add(ST_BASE_CRTYPE);
      ListItem.SubItems.Add(nazwa_frm);

      ListItem.SubItems.Add(ST_STRENGTH);
      ListItem.SubItems.Add(ST_PERCEPTION);
      ListItem.SubItems.Add(ST_ENDURANCE);
      ListItem.SubItems.Add(ST_CHARISMA);
      ListItem.SubItems.Add(ST_INTELLECT);
      ListItem.SubItems.Add(ST_AGILITY);
      ListItem.SubItems.Add(ST_LUCK);
      ListItem.SubItems.Add(ST_KILL_EXPERIENCE);
      ListItem.SubItems.Add(ST_MAX_LIFE);
      ListItem.SubItems.Add(ST_ACTION_POINTS);

      ListItem.SubItems.Add(ST_ARMOR_CLASS);
      ListItem.SubItems.Add(ST_MELEE_DAMAGE);
      ListItem.SubItems.Add(ST_CARRY_WEIGHT);
      ListItem.SubItems.Add(ST_SEQUENCE);
      ListItem.SubItems.Add(ST_HEALING_RATE);
      ListItem.SubItems.Add(ST_CRITICAL_CHANCE);

      ListItem.SubItems.Add(ST_BODY_TYPE);
      ListItem.SubItems.Add(ST_LOCOMOTION_TYPE);
      ListItem.SubItems.Add(ST_DAMAGE_TYPE);
      ListItem.SubItems.Add(ST_GENDER);
      ListItem.SubItems.Add(ST_AGE);
      ListItem.SubItems.Add(ST_SCALE_FACTOR);

      ListItem.SubItems.Add(ST_AI_ID);


      ListItem.SubItems.Add(SK_SMALL_GUNS);
      ListItem.SubItems.Add(SK_BIG_GUNS);
      ListItem.SubItems.Add(SK_ENERGY_WEAPONS);
      ListItem.SubItems.Add(SK_UNARMED);
      ListItem.SubItems.Add(SK_SCAVENGING);
      ListItem.SubItems.Add(SK_THROWING);
      ListItem.SubItems.Add(SK_FIRST_AID);
      ListItem.SubItems.Add(SK_DOCTOR);
      ListItem.SubItems.Add(SK_SNEAK);
      ListItem.SubItems.Add(SK_LOCKPICK);
      ListItem.SubItems.Add(SK_STEAL);
      ListItem.SubItems.Add(SK_TRAPS);
      ListItem.SubItems.Add(SK_SCIENCE);
      ListItem.SubItems.Add(SK_REPAIR);
      ListItem.SubItems.Add(SK_SPEECH);
      ListItem.SubItems.Add(SK_BARTER);
      ListItem.SubItems.Add(SK_GAMBLING);
      ListItem.SubItems.Add(SK_OUTDOORSMAN);


      ListItem.SubItems.Add(ST_NORMAL_ABSORB);
      ListItem.SubItems.Add(ST_LASER_ABSORB);
      ListItem.SubItems.Add(ST_FIRE_ABSORB);
      ListItem.SubItems.Add(ST_PLASMA_ABSORB);
      ListItem.SubItems.Add(ST_ELECTRO_ABSORB);
      ListItem.SubItems.Add(ST_EMP_ABSORB);
      ListItem.SubItems.Add(ST_EXPLODE_ABSORB);
      ListItem.SubItems.Add(ST_NORMAL_RESIST);
      ListItem.SubItems.Add(ST_LASER_RESIST);
      ListItem.SubItems.Add(ST_FIRE_RESIST);
      ListItem.SubItems.Add(ST_PLASMA_RESIST);
      ListItem.SubItems.Add(ST_ELECTRO_RESIST);
      ListItem.SubItems.Add(ST_EMP_RESIST);
      ListItem.SubItems.Add(ST_EXPLODE_RESIST);
      ListItem.SubItems.Add(ST_RADIATION_RESISTANCE);
      ListItem.SubItems.Add(ST_POISON_RESISTANCE);

      ListItem.SubItems.Add(ST_DIALOG_ID);
      ListItem.SubItems.Add(ST_BAG_ID);
      ListItem.SubItems.Add(ST_TEAM_ID);



      ListItem.SubItems.Add(MODE_HIDE);
      ListItem.SubItems.Add(MODE_NO_STEAL);
      ListItem.SubItems.Add(MODE_NO_BARTER);
      ListItem.SubItems.Add(MODE_NO_ENEMY_STACK);
      ListItem.SubItems.Add(MODE_NO_PVP);
      ListItem.SubItems.Add(MODE_NO_HOME);
      ListItem.SubItems.Add(MODE_DLG_SCRIPT_BARTER);
      ListItem.SubItems.Add(MODE_UNLIMITED_AMMO);
      ListItem.SubItems.Add(MODE_NO_DROP);
      ListItem.SubItems.Add(MODE_NO_LOOSE_LIMBS);
      ListItem.SubItems.Add(MODE_DEAD_AGES);
      ListItem.SubItems.Add(MODE_NO_HEAL);
      ListItem.SubItems.Add(MODE_INVULNERABLE);
      ListItem.SubItems.Add(MODE_NO_FLATTEN);
      ListItem.SubItems.Add(MODE_SPECIAL_DEAD);
      ListItem.SubItems.Add(MODE_RANGE_HTH);
      ListItem.SubItems.Add(MODE_NO_KNOCK);
      ListItem.SubItems.Add(MODE_NO_LOOT);
      ListItem.SubItems.Add(MODE_NO_KARMA_ON_KILL);
      ListItem.SubItems.Add(MODE_BARTER_ONLY_CASH);
      ListItem.SubItems.Add(MODE_NO_PUSH);
      ListItem.SubItems.Add(MODE_NO_UNARMED);
      ListItem.SubItems.Add(MODE_NO_AIM);
      ListItem.SubItems.Add(MODE_NO_WALK);
      ListItem.SubItems.Add(MODE_NO_RUN);
      ListItem.SubItems.Add(MODE_NO_TALK);
      ListItem.SubItems.Add(ST_TOXIC);
      ListItem.SubItems.Add(ST_RADIOACTIVE);

      ListItem.SubItems.Add(ST_LEVEL);
      ListItem.SubItems.Add(ST_WALK_TIME);
      ListItem.SubItems.Add(ST_RUN_TIME);

ListItem.SubItems.Add(PE_ACTION_BOY);
ListItem.SubItems.Add(PE_ADRENALINE_RUSH);
ListItem.SubItems.Add(PE_BEST_OF_A_BAD_LOT);
ListItem.SubItems.Add(PE_BETTER_CRITICALS);
ListItem.SubItems.Add(PE_BLESSED_ARE_THE_WEAK);
ListItem.SubItems.Add(PE_BONUS_HTH_ATTACKS);
ListItem.SubItems.Add(PE_CLOSE_COMBAT_MASTER);
ListItem.SubItems.Add(PE_CLOSE_COMBAT_MASTER_II);
ListItem.SubItems.Add(PE_BONUS_MOVE);
ListItem.SubItems.Add(PE_BONUS_RANGED_DAMAGE);
ListItem.SubItems.Add(PE_BONUS_RATE_OF_ATTACK);
ListItem.SubItems.Add(PE_BORN_LEADER);
ListItem.SubItems.Add(PE_DEAD_MAN_WALKING);
ListItem.SubItems.Add(PE_DEMOLITION_EXPERT);
ListItem.SubItems.Add(PE_DERMAL_IMPACT);
ListItem.SubItems.Add(PE_DERMAL_IMPACT_ENH);
ListItem.SubItems.Add(PE_DODGER);
ListItem.SubItems.Add(PE_DODGER_II);
ListItem.SubItems.Add(PE_EARLIER_SEQUENCE);
ListItem.SubItems.Add(PE_EVEN_MORE_CRITICALS);
ListItem.SubItems.Add(PE_EVEN_TOUGHER);
ListItem.SubItems.Add(PE_FAST_RELOAD);
ListItem.SubItems.Add(PE_HAND_LOADER);
ListItem.SubItems.Add(PE_FIELD_MEDIC_II);
ListItem.SubItems.Add(PE_HEAVE_HO);
ListItem.SubItems.Add(PE_HEAVE_HO_II);
ListItem.SubItems.Add(PE_HIT_THE_GAPS);
ListItem.SubItems.Add(PE_HTH_CRITICALS);
ListItem.SubItems.Add(PE_HTH_EVADE);
ListItem.SubItems.Add(PE_HTH_EVADE_II);
ListItem.SubItems.Add(PE_IN_YOUR_FACE);
ListItem.SubItems.Add(PE_IRON_LIMBS);
ListItem.SubItems.Add(PE_JINXED_II);
ListItem.SubItems.Add(PE_LIVEWIRE);
ListItem.SubItems.Add(PE_LIVING_ANATOMY);
ListItem.SubItems.Add(PE_MAN_OF_STEEL);
ListItem.SubItems.Add(PE_MELT_INTO_SHADOW);
ListItem.SubItems.Add(PE_MORE_CRITICALS);
ListItem.SubItems.Add(PE_MORE_RANGED_DAMAGE);
ListItem.SubItems.Add(PE_NEMEAN_ARMOR);
ListItem.SubItems.Add(PE_PHOENIX_IMPLANTS);
ListItem.SubItems.Add(PE_PHOENIX_IMPLANTS_ENH);
ListItem.SubItems.Add(PE_PYROMANIAC);
ListItem.SubItems.Add(PE_QUICK_POCKETS);
ListItem.SubItems.Add(PE_QUICK_RECOVERY);
ListItem.SubItems.Add(PE_RIGHT_BETWEEN_THE_EYES);
ListItem.SubItems.Add(PE_SHARPSHOOTER);
ListItem.SubItems.Add(PE_SILENT_DEATH);
ListItem.SubItems.Add(PE_SLAYER);
ListItem.SubItems.Add(PE_SNIPER);
ListItem.SubItems.Add(PE_SPRAY_AND_PRAY);
ListItem.SubItems.Add(PE_STEALTH_GIRL);
ListItem.SubItems.Add(PE_STONEWALL);
ListItem.SubItems.Add(PE_TERMINATOR);
ListItem.SubItems.Add(PE_TOUGHNESS);
ListItem.SubItems.Add(PE_TREE_TRUNK_THIGHS);
ListItem.SubItems.Add(PE_WEAPON_HANDLING);

ListItem.SubItems.Add(PE_FASTER_HEALING);
ListItem.SubItems.Add(PE_GHOST);
ListItem.SubItems.Add(PE_FIELD_MEDIC);
ListItem.SubItems.Add(PE_LIFEGIVER);
ListItem.SubItems.Add(PE_LIGHT_STEP);
ListItem.SubItems.Add(PE_MEDIC);

ListItem.SubItems.Add(ST_DEFAULT_ARMOR_PID);
ListItem.SubItems.Add(ST_DEFAULT_HELMET_PID);

ListItem.SubItems.Add(TRAIT_FAST_METABOLISM);
ListItem.SubItems.Add(TRAIT_BRUISER);
ListItem.SubItems.Add(TRAIT_SMALL_FRAME);
ListItem.SubItems.Add(TRAIT_ONE_HANDER);
ListItem.SubItems.Add(TRAIT_FINESSE);
ListItem.SubItems.Add(TRAIT_KAMIKAZE);
ListItem.SubItems.Add(TRAIT_HEAVY_HANDED);
ListItem.SubItems.Add(TRAIT_FAST_SHOT);
ListItem.SubItems.Add(TRAIT_BLOODY_MESS);
ListItem.SubItems.Add(TRAIT_JINXED);
ListItem.SubItems.Add(TRAIT_GOOD_NATURED);
ListItem.SubItems.Add(TRAIT_CHEM_RELIANT);
ListItem.SubItems.Add(TRAIT_CHEM_RESISTANT);
ListItem.SubItems.Add(TRAIT_BONEHEAD);
ListItem.SubItems.Add(TRAIT_SKILLED);
ListItem.SubItems.Add(TRAIT_LONER);


    end { zakonczenie tego ifa: if Copy(linia,1,15)='[Critter proto]' then}
    else
    begin
      Readln(plik,linia);
      linia:=Trim(linia);
    end;

  end; // koniec petli While czytajacej z pliku fopro
  CloseFile(plik);

  begin
    PageControl1.Visible:=True;  // ta instrukcja jest potrzebna zeby przy zaladowaniu pustego pliku nie mozna bylo edytowac w okienkach po prawej stronie bo to generuje niepoprawne dzialanie ze strony uzytkowniaka oraz przy probie zapsiu blad
    GroupBox8.Visible:=True;
    Panel1.Visible:=True;

//    Button2.Enabled:=True;
    BitBtn8.Enabled:=True;
//    Button3.Enabled:=True;
    BitBtn5.Enabled:=True;
    BitBtn10.Enabled:=True; // Cancel button
  end;

  Label119.Visible:=False;

  if (Length(path_selected_fopro)>0) then  // jesli zaladowany plik fopro to uaktywniaj przyciski Append Insert Delete oraz Merge MSG
  begin
    BitBtn1.Visible:=True;
    BitBtn2.Visible:=True;
//    Button7.Enabled:=True;  // przycisk Raw Data
    BitBtn6.Enabled:=True;
    //Button3.Visible:=True;
    BitBtn5.Visible:=True;
    BitBtn10.Visible:=True; // Cancel button

    //Button7.Visible:=True;
    BitBtn6.Visible:=True;

    if ListView1.Items.Count>0 then        // jesli wczytany plik nie jest pusty to ustaw visible dla buttona, zeby w Append dzialala funkcja ZapiszCrittera
      BitBtn3.Visible:=True
    else
    begin
      BitBtn3.Visible:=False;

      PageControl1.Visible:=False;
      GroupBox8.Visible:=False;
      Panel1.Visible:=False;
      //Button2.Enabled:=False;
      BitBtn8.Enabled:=False;
      //Button3.Enabled:=False;
      BitBtn5.Enabled:=False;
      BitBtn10.Enabled:=False; // Cancel button
      
      //Button3.Visible:=False;
      BitBtn5.Visible:=False;
      BitBtn10.Visible:=False; // Cancel button

      //Button7.Visible:=False;
      BitBtn6.Visible:=False;

      //Label126.Caption:='Last PID number is: ' + ostatni_numer_pid_w_fodlg_msg;
      //ShowMessage('Remember last PID number in FODLG.MSG: ' + ostatni_numer_pid_w_fodlg_msg);
      
    end;
  end;

  BitBtn5.Font.Color:=clBlack;

  if Assigned(ListView1.Items[0]) then
  begin
    ListView1.Items[0].Focused:=True;
    ListView1.Items[0].Selected:=True;
  end;

//  PageControl1.ActivePageIndex:=0;
//  PageControl1.ActivePageIndex:=1;
//  PageControl1.ActivePageIndex:=2;
//  PageControl1.ActivePageIndex:=3;
  PageControl1.ActivePageIndex:=0;

  Caption:=ExtractFileName(path_selected_fopro) + '  -  ' + 'Fonline:Reloaded Critter Proto Editor ' + wersja_programu;
  StatusBar1.SimpleText:='File loaded: ' + ExtractFileName(path_selected_fopro);
end;

procedure TForm1.ListView1SelectItem(Sender: TObject; Item: TListItem;
  Selected: Boolean);
begin
{  if lokal_STOP_FOR_SAVE=True then
  begin
    BitBtn5.Font.Color:=clRed;
    StatusBar1.Color:=clRed;
    StatusBar1.Font.Style:=[fsBold];
    StatusBar1.SimpleText:='Critter:   ' + '[' + IntToStr(SpinEdit0.Value) + ']     ' + Edit37.Text + '      ' + Edit38.Text + '   was modified!  Save/Cancel before select next one!';
    //ShowMessage('There are changes made to actual critter!');
  end;

  if lokal_STOP_FOR_SAVE=False then}
  begin
  if Selected then
  begin
    ShowSelected(Item);
    Selected_Item:=Item;
    Update;
  end
  else ShowSelected(nil);
  end;
end;


procedure TForm1.ZapiszBiezacyCritter;
var aktywny_arkusz:Integer;
begin
  aktywny_arkusz:=PageControl1.ActivePageIndex;

  PageControl1.ActivePageIndex:=0;
  PageControl1.ActivePageIndex:=1;
  PageControl1.ActivePageIndex:=2;
  PageControl1.ActivePageIndex:=3;
  PageControl1.ActivePageIndex:=aktywny_arkusz;



  global_STOP_FOR_SAVE:=TRUE;
  lokal_STOP_FOR_SAVE:=False;
  Caption:='Fonline:Reloaded Critter Proto Editor ' + wersja_programu +' - Saving ...';


  with ListView1.Items.Item[ListView1.ItemIndex] do
  begin
    if checkbox24.Checked=False then // jesli kontrolka zmiany PID NIE jest zaznaczona, to zapisuj wszystkie dane do ListView z okienek po prawej w normlany sposób
    begin

      Selected_Item.Caption:=Edit38.Text;               //Descr

      Selected_Item.SubItems.Strings[0]:=IntToStr(SpinEdit0.Value);    //PID

      Selected_Item.SubItems.Strings[1]:=Edit37.Text;  // nazwa
      Selected_Item.SubItems.Strings[2]:=Edit34.Text;  //critter_type
      Selected_Item.SubItems.Strings[3]:=Label42.Caption;  // frm name

      Selected_Item.SubItems.Strings[4]:=Edit1.Text;
      Selected_Item.SubItems.Strings[5]:=Edit2.Text;
      Selected_Item.SubItems.Strings[6]:=Edit3.Text;
      Selected_Item.SubItems.Strings[7]:=Edit4.Text;
      Selected_Item.SubItems.Strings[8]:=Edit5.Text;
      Selected_Item.SubItems.Strings[9]:=Edit6.Text;
      Selected_Item.SubItems.Strings[10]:=Edit7.Text;


      Selected_Item.SubItems.Strings[11]:=Edit33.Text;
      Selected_Item.SubItems.Strings[12]:=Edit16.Text;
      Selected_Item.SubItems.Strings[13]:=Edit17.Text;
      Selected_Item.SubItems.Strings[14]:=Edit18.Text;
      Selected_Item.SubItems.Strings[15]:=Edit19.Text;
      Selected_Item.SubItems.Strings[16]:=Edit20.Text;
      Selected_Item.SubItems.Strings[17]:=Edit21.Text;
      Selected_Item.SubItems.Strings[18]:=Edit22.Text;
      Selected_Item.SubItems.Strings[19]:=Edit23.Text;

      Selected_Item.SubItems.Strings[20]:=IntToStr(ComboBox1.ItemIndex);
      Selected_Item.SubItems.Strings[21]:=IntToStr(ComboBox2.ItemIndex);
      Selected_Item.SubItems.Strings[22]:=IntToStr(ComboBox3.ItemIndex);
      Selected_Item.SubItems.Strings[23]:=IntToStr(ComboBox4.ItemIndex);


      Selected_Item.SubItems.Strings[24]:=Edit32.Text;


      Selected_Item.SubItems.Strings[25]:=Edit35.Text;// SCALE Factor
      Selected_Item.SubItems.Strings[26]:=IntToStr(ComboBox5.ItemIndex);  // AI ID


      Selected_Item.SubItems.Strings[27]:=Edit61.Text;  // skill Small guns
      Selected_Item.SubItems.Strings[28]:=Edit62.Text;
      Selected_Item.SubItems.Strings[29]:=Edit63.Text;
      Selected_Item.SubItems.Strings[30]:=Edit64.Text;
      Selected_Item.SubItems.Strings[31]:=Edit65.Text;
      Selected_Item.SubItems.Strings[32]:=Edit66.Text;
      Selected_Item.SubItems.Strings[33]:=Edit67.Text;
      Selected_Item.SubItems.Strings[34]:=Edit68.Text;
      Selected_Item.SubItems.Strings[35]:=Edit69.Text;
      Selected_Item.SubItems.Strings[36]:=Edit70.Text;
      Selected_Item.SubItems.Strings[37]:=Edit71.Text;
      Selected_Item.SubItems.Strings[38]:=Edit72.Text;
      Selected_Item.SubItems.Strings[39]:=Edit73.Text;
      Selected_Item.SubItems.Strings[40]:=Edit74.Text;
      Selected_Item.SubItems.Strings[41]:=Edit75.Text;
      Selected_Item.SubItems.Strings[42]:=Edit76.Text;
      Selected_Item.SubItems.Strings[43]:=Edit77.Text;
      Selected_Item.SubItems.Strings[44]:=Edit78.Text;    // skill Outdoorsman

    //armor stats
      Selected_Item.SubItems.Strings[45]:=Edit99.Text;
      Selected_Item.SubItems.Strings[46]:=Edit100.Text;
      Selected_Item.SubItems.Strings[47]:=Edit101.Text;
      Selected_Item.SubItems.Strings[48]:=Edit102.Text;
      Selected_Item.SubItems.Strings[49]:=Edit103.Text;
      Selected_Item.SubItems.Strings[50]:=Edit104.Text;
      Selected_Item.SubItems.Strings[51]:=Edit105.Text;

      Selected_Item.SubItems.Strings[52]:=Edit106.Text;
      Selected_Item.SubItems.Strings[53]:=Edit107.Text;
      Selected_Item.SubItems.Strings[54]:=Edit108.Text;
      Selected_Item.SubItems.Strings[55]:=Edit109.Text;
      Selected_Item.SubItems.Strings[56]:=Edit110.Text;
      Selected_Item.SubItems.Strings[57]:=Edit111.Text;
      Selected_Item.SubItems.Strings[58]:=Edit112.Text;

//    radiation + poison resist
      Selected_Item.SubItems.Strings[59]:=Edit114.Text;
      Selected_Item.SubItems.Strings[60]:=Edit115.Text;


    Selected_Item.SubItems.Strings[61]:=IntToStr(SpinEdit40.Value); //Dialog ID
    Selected_Item.SubItems.Strings[62]:=IntToStr(SpinEdit59.Value); //Bag ID
    Selected_Item.SubItems.Strings[63]:=IntToStr(ComboBox6.ItemIndex); //Team ID

    Selected_Item.SubItems.Strings[64]:=IntToStr(-StrToInt(BoolToStr(CheckBox1.Checked)));
    Selected_Item.SubItems.Strings[65]:=IntToStr(-StrToInt(BoolToStr(CheckBox2.Checked)));
    Selected_Item.SubItems.Strings[66]:=IntToStr(-StrToInt(BoolToStr(CheckBox3.Checked)));
    Selected_Item.SubItems.Strings[67]:=IntToStr(-StrToInt(BoolToStr(CheckBox4.Checked)));
    Selected_Item.SubItems.Strings[68]:=IntToStr(-StrToInt(BoolToStr(CheckBox5.Checked)));
    Selected_Item.SubItems.Strings[69]:=IntToStr(-StrToInt(BoolToStr(CheckBox6.Checked)));
    Selected_Item.SubItems.Strings[70]:=IntToStr(-StrToInt(BoolToStr(CheckBox7.Checked)));
    Selected_Item.SubItems.Strings[71]:=IntToStr(-StrToInt(BoolToStr(CheckBox8.Checked)));
    Selected_Item.SubItems.Strings[72]:=IntToStr(-StrToInt(BoolToStr(CheckBox9.Checked)));
    Selected_Item.SubItems.Strings[73]:=IntToStr(-StrToInt(BoolToStr(CheckBox10.Checked)));
    Selected_Item.SubItems.Strings[74]:=IntToStr(-StrToInt(BoolToStr(CheckBox11.Checked)));
    Selected_Item.SubItems.Strings[75]:=IntToStr(-StrToInt(BoolToStr(CheckBox12.Checked)));
    Selected_Item.SubItems.Strings[76]:=IntToStr(-StrToInt(BoolToStr(CheckBox13.Checked)));
    Selected_Item.SubItems.Strings[77]:=IntToStr(-StrToInt(BoolToStr(CheckBox14.Checked)));
    Selected_Item.SubItems.Strings[78]:=IntToStr(-StrToInt(BoolToStr(CheckBox15.Checked)));
    Selected_Item.SubItems.Strings[79]:=IntToStr(-StrToInt(BoolToStr(CheckBox16.Checked)));
    Selected_Item.SubItems.Strings[80]:=IntToStr(-StrToInt(BoolToStr(CheckBox17.Checked)));
    Selected_Item.SubItems.Strings[81]:=IntToStr(-StrToInt(BoolToStr(CheckBox18.Checked)));
    Selected_Item.SubItems.Strings[82]:=IntToStr(-StrToInt(BoolToStr(CheckBox19.Checked)));
    Selected_Item.SubItems.Strings[83]:=IntToStr(-StrToInt(BoolToStr(CheckBox20.Checked)));
    Selected_Item.SubItems.Strings[84]:=IntToStr(-StrToInt(BoolToStr(CheckBox21.Checked)));
    Selected_Item.SubItems.Strings[85]:=IntToStr(-StrToInt(BoolToStr(CheckBox22.Checked)));
    Selected_Item.SubItems.Strings[86]:=IntToStr(-StrToInt(BoolToStr(CheckBox23.Checked)));
    Selected_Item.SubItems.Strings[87]:=IntToStr(-StrToInt(BoolToStr(CheckBox36.Checked)));
    Selected_Item.SubItems.Strings[88]:=IntToStr(-StrToInt(BoolToStr(CheckBox37.Checked)));
    Selected_Item.SubItems.Strings[89]:=IntToStr(-StrToInt(BoolToStr(CheckBox38.Checked)));


    Selected_Item.SubItems.Strings[90]:=Edit116.Text; //ST_TOXIC
    Selected_Item.SubItems.Strings[91]:=Edit117.Text; //ST_RADIOACTIVE

    Selected_Item.SubItems.Strings[92]:=IntToStr(SpinEdit1000.Value); //ST_LEVEL
    Selected_Item.SubItems.Strings[93]:=IntToStr(SpinEdit1001.Value); //ST_WALK_TIME
    Selected_Item.SubItems.Strings[94]:=IntToStr(SpinEdit1002.Value); //ST_RUN_TIME

    Selected_Item.SubItems.Strings[95 ]:=ValueListEditor1.Values['PE_ACTION_BOY'];
Selected_Item.SubItems.Strings[96 ]:=ValueListEditor1.Values['PE_ADRENALINE_RUSH'];
Selected_Item.SubItems.Strings[97 ]:=ValueListEditor1.Values['PE_BEST_OF_A_BAD_LOT'];
Selected_Item.SubItems.Strings[98 ]:=ValueListEditor1.Values['PE_BETTER_CRITICALS'];
Selected_Item.SubItems.Strings[99 ]:=ValueListEditor1.Values['PE_BLESSED_ARE_THE_WEAK'];
Selected_Item.SubItems.Strings[100]:=ValueListEditor1.Values['PE_BONUS_HTH_ATTACKS'];
Selected_Item.SubItems.Strings[101]:=ValueListEditor1.Values['PE_CLOSE_COMBAT_MASTER'];
Selected_Item.SubItems.Strings[102]:=ValueListEditor1.Values['PE_CLOSE_COMBAT_MASTER_II'];
Selected_Item.SubItems.Strings[103]:=ValueListEditor1.Values['PE_BONUS_MOVE'];
Selected_Item.SubItems.Strings[104]:=ValueListEditor1.Values['PE_BONUS_RANGED_DAMAGE'];
Selected_Item.SubItems.Strings[105]:=ValueListEditor1.Values['PE_BONUS_RATE_OF_ATTACK'];
Selected_Item.SubItems.Strings[106]:=ValueListEditor1.Values['PE_BORN_LEADER'];
Selected_Item.SubItems.Strings[107]:=ValueListEditor1.Values['PE_DEAD_MAN_WALKING'];
Selected_Item.SubItems.Strings[108]:=ValueListEditor1.Values['PE_DEMOLITION_EXPERT'];
Selected_Item.SubItems.Strings[109]:=ValueListEditor1.Values['PE_DERMAL_IMPACT'];
Selected_Item.SubItems.Strings[110]:=ValueListEditor1.Values['PE_DERMAL_IMPACT_ENH'];
Selected_Item.SubItems.Strings[111]:=ValueListEditor1.Values['PE_DODGER'];
Selected_Item.SubItems.Strings[112]:=ValueListEditor1.Values['PE_DODGER_II'];
Selected_Item.SubItems.Strings[113]:=ValueListEditor1.Values['PE_EARLIER_SEQUENCE'];
Selected_Item.SubItems.Strings[114]:=ValueListEditor1.Values['PE_EVEN_MORE_CRITICALS'];
Selected_Item.SubItems.Strings[115]:=ValueListEditor1.Values['PE_EVEN_TOUGHER'];
Selected_Item.SubItems.Strings[116]:=ValueListEditor1.Values['PE_FAST_RELOAD'];
Selected_Item.SubItems.Strings[117]:=ValueListEditor1.Values['PE_HAND_LOADER'];
Selected_Item.SubItems.Strings[118]:=ValueListEditor1.Values['PE_FIELD_MEDIC_II'];
Selected_Item.SubItems.Strings[119]:=ValueListEditor1.Values['PE_HEAVE_HO'];
Selected_Item.SubItems.Strings[120]:=ValueListEditor1.Values['PE_HEAVE_HO_II'];
Selected_Item.SubItems.Strings[121]:=ValueListEditor1.Values['PE_HIT_THE_GAPS'];
Selected_Item.SubItems.Strings[122]:=ValueListEditor1.Values['PE_HTH_CRITICALS'];
Selected_Item.SubItems.Strings[123]:=ValueListEditor1.Values['PE_HTH_EVADE'];
Selected_Item.SubItems.Strings[124]:=ValueListEditor1.Values['PE_HTH_EVADE_II'];
Selected_Item.SubItems.Strings[125]:=ValueListEditor1.Values['PE_IN_YOUR_FACE'];
Selected_Item.SubItems.Strings[126]:=ValueListEditor1.Values['PE_IRON_LIMBS'];
Selected_Item.SubItems.Strings[127]:=ValueListEditor1.Values['PE_JINXED_II'];
Selected_Item.SubItems.Strings[128]:=ValueListEditor1.Values['PE_LIVEWIRE'];
Selected_Item.SubItems.Strings[129]:=ValueListEditor1.Values['PE_LIVING_ANATOMY'];
Selected_Item.SubItems.Strings[130]:=ValueListEditor1.Values['PE_MAN_OF_STEEL'];
Selected_Item.SubItems.Strings[131]:=ValueListEditor1.Values['PE_MELT_INTO_SHADOW'];
Selected_Item.SubItems.Strings[132]:=ValueListEditor1.Values['PE_MORE_CRITICALS'];
Selected_Item.SubItems.Strings[133]:=ValueListEditor1.Values['PE_MORE_RANGED_DAMAGE'];
Selected_Item.SubItems.Strings[134]:=ValueListEditor1.Values['PE_NEMEAN_ARMOR'];
Selected_Item.SubItems.Strings[135]:=ValueListEditor1.Values['PE_PHOENIX_IMPLANTS'];
Selected_Item.SubItems.Strings[136]:=ValueListEditor1.Values['PE_PHOENIX_IMPLANTS_ENH'];
Selected_Item.SubItems.Strings[137]:=ValueListEditor1.Values['PE_PYROMANIAC'];
Selected_Item.SubItems.Strings[138]:=ValueListEditor1.Values['PE_QUICK_POCKETS'];
Selected_Item.SubItems.Strings[139]:=ValueListEditor1.Values['PE_QUICK_RECOVERY'];
Selected_Item.SubItems.Strings[140]:=ValueListEditor1.Values['PE_RIGHT_BETWEEN_THE_EYES'];
Selected_Item.SubItems.Strings[141]:=ValueListEditor1.Values['PE_SHARPSHOOTER'];
Selected_Item.SubItems.Strings[142]:=ValueListEditor1.Values['PE_SILENT_DEATH'];
Selected_Item.SubItems.Strings[143]:=ValueListEditor1.Values['PE_SLAYER'];
Selected_Item.SubItems.Strings[144]:=ValueListEditor1.Values['PE_SNIPER'];
Selected_Item.SubItems.Strings[145]:=ValueListEditor1.Values['PE_SPRAY_AND_PRAY'];
Selected_Item.SubItems.Strings[146]:=ValueListEditor1.Values['PE_STEALTH_GIRL'];
Selected_Item.SubItems.Strings[147]:=ValueListEditor1.Values['PE_STONEWALL'];
Selected_Item.SubItems.Strings[148]:=ValueListEditor1.Values['PE_TERMINATOR'];
Selected_Item.SubItems.Strings[149]:=ValueListEditor1.Values['PE_TOUGHNESS'];
Selected_Item.SubItems.Strings[150]:=ValueListEditor1.Values['PE_TREE_TRUNK_THIGHS'];
Selected_Item.SubItems.Strings[151]:=ValueListEditor1.Values['PE_WEAPON_HANDLING'];

Selected_Item.SubItems.Strings[152]:=ValueListEditor1.Values['PE_FASTER_HEALING'];
Selected_Item.SubItems.Strings[153]:=ValueListEditor1.Values['PE_GHOST'];
Selected_Item.SubItems.Strings[154]:=ValueListEditor1.Values['PE_FIELD_MEDIC'];
Selected_Item.SubItems.Strings[155]:=ValueListEditor1.Values['PE_LIFEGIVER'];
Selected_Item.SubItems.Strings[156]:=ValueListEditor1.Values['PE_LIGHT_STEP'];
Selected_Item.SubItems.Strings[157]:=ValueListEditor1.Values['PE_MEDIC'];


//ComboBox8.ItemIndex:=ComboBox8.Items.IndexOf(Trim(Item.SubItems.Strings[152]));
//ComboBox9.ItemIndex:=ComboBox9.Items.IndexOf(Trim(Item.SubItems.Strings[153]));

if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'None' then Selected_Item.SubItems.Strings[158]:='None';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_LEATHER_JACKET' then Selected_Item.SubItems.Strings[158]:='74';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_LEATHER_ARMOR' then Selected_Item.SubItems.Strings[158]:='1';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_LEATHER_ARMOR_MK_II' then Selected_Item.SubItems.Strings[158]:='379';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_CURED_LEATHER_ARMOR' then Selected_Item.SubItems.Strings[158]:='265';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_METAL_ARMOR' then Selected_Item.SubItems.Strings[158]:='2';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_METAL_ARMOR_MK_II' then Selected_Item.SubItems.Strings[158]:='380';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_TESLA_ARMOR' then Selected_Item.SubItems.Strings[158]:='240';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_COMBAT_ARMOR' then Selected_Item.SubItems.Strings[158]:='17';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_COMBAT_ARMOR_MK_II' then Selected_Item.SubItems.Strings[158]:='381';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_BROTHERHOOD_COMBAT_ARMOR' then Selected_Item.SubItems.Strings[158]:='239';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_NCR_ARMOR' then Selected_Item.SubItems.Strings[158]:='9654';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_ENVIROMENTAL_ARMOR' then Selected_Item.SubItems.Strings[158]:='751';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_ENCLAVE_COMBAT_ARMOR' then Selected_Item.SubItems.Strings[158]:='752';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_VAULT_13_SUIT' then Selected_Item.SubItems.Strings[158]:='753';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_VAULT_SUIT' then Selected_Item.SubItems.Strings[158]:='754';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_WORN_ROBE' then Selected_Item.SubItems.Strings[158]:='755';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_BLUE_ROBE' then Selected_Item.SubItems.Strings[158]:='756';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_RED_ROBE' then Selected_Item.SubItems.Strings[158]:='757';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_GRAY_ROBE' then Selected_Item.SubItems.Strings[158]:='758';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_POWERED_ARMOR' then Selected_Item.SubItems.Strings[158]:='3';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_HARDENED_POWER_ARMOR' then Selected_Item.SubItems.Strings[158]:='232';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_ADVANCED_POWER_ARMOR' then Selected_Item.SubItems.Strings[158]:='348';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_ADVANCED_POWER_ARMOR_MK2' then Selected_Item.SubItems.Strings[158]:='349';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_PURPLE_ROBE' then Selected_Item.SubItems.Strings[158]:='113';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_KEEPBRIGE_ROBE' then Selected_Item.SubItems.Strings[158]:='524';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_SAND_ROBE' then Selected_Item.SubItems.Strings[158]:='750';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_TIBBETS_PRISON' then Selected_Item.SubItems.Strings[158]:='723';
if ComboBox8.Items.Strings[ComboBox8.ItemIndex] = 'PID_DESERT_COMBAT_ARMOR' then Selected_Item.SubItems.Strings[158]:='778';


if ComboBox9.Items.Strings[ComboBox9.ItemIndex] = 'None' then Selected_Item.SubItems.Strings[159]:='None';
if ComboBox9.Items.Strings[ComboBox9.ItemIndex] = 'PID_POWER_HELMET' then Selected_Item.SubItems.Strings[159]:='721';
if ComboBox9.Items.Strings[ComboBox9.ItemIndex] = 'PID_MOTORCYCLE_HELMET' then Selected_Item.SubItems.Strings[159]:='722';
if ComboBox9.Items.Strings[ComboBox9.ItemIndex] = 'PID_COMBAT_HELMET' then Selected_Item.SubItems.Strings[159]:='725';
if ComboBox9.Items.Strings[ComboBox9.ItemIndex] = 'PID_COMBAT_HELMET_MK_II' then Selected_Item.SubItems.Strings[159]:='726';
if ComboBox9.Items.Strings[ComboBox9.ItemIndex] = 'PID_BROTHERHOOD_HELMET' then Selected_Item.SubItems.Strings[159]:='727';
if ComboBox9.Items.Strings[ComboBox9.ItemIndex] = 'PID_LEATHER_JACKET_HELMET' then Selected_Item.SubItems.Strings[159]:='728';
if ComboBox9.Items.Strings[ComboBox9.ItemIndex] = 'PID_COMBAT_LEATHER_JACKET_HELMET' then Selected_Item.SubItems.Strings[159]:='729';
if ComboBox9.Items.Strings[ComboBox9.ItemIndex] = 'PID_LEATHER_ARMOR_HELMET' then Selected_Item.SubItems.Strings[159]:='730';
if ComboBox9.Items.Strings[ComboBox9.ItemIndex] = 'PID_LEATHER_ARMOR_HELMET_MK2' then Selected_Item.SubItems.Strings[159]:='731';
if ComboBox9.Items.Strings[ComboBox9.ItemIndex] = 'PID_METAL_HELMET' then Selected_Item.SubItems.Strings[159]:='732';
if ComboBox9.Items.Strings[ComboBox9.ItemIndex] = 'PID_METAL_HELMET_MK2' then Selected_Item.SubItems.Strings[159]:='733';
if ComboBox9.Items.Strings[ComboBox9.ItemIndex] = 'PID_TESLA_HELMET' then Selected_Item.SubItems.Strings[159]:='734';
if ComboBox9.Items.Strings[ComboBox9.ItemIndex] = 'PID_APA_HELMET' then Selected_Item.SubItems.Strings[159]:='735';
if ComboBox9.Items.Strings[ComboBox9.ItemIndex] = 'PID_APA_HELMET_MK2' then Selected_Item.SubItems.Strings[159]:='736';
if ComboBox9.Items.Strings[ComboBox9.ItemIndex] = 'PID_HARDENED_POWER_HELMET' then Selected_Item.SubItems.Strings[159]:='737';
if ComboBox9.Items.Strings[ComboBox9.ItemIndex] = 'PID_ENCLAVE_COMBAT_HELMET' then Selected_Item.SubItems.Strings[159]:='738';
if ComboBox9.Items.Strings[ComboBox9.ItemIndex] = 'PID_ENCLAVE_COMBAT_HELMET_MK2' then Selected_Item.SubItems.Strings[159]:='739';
if ComboBox9.Items.Strings[ComboBox9.ItemIndex] = 'PID_DESERT_COMBAT_HELMET' then Selected_Item.SubItems.Strings[159]:='740';
//Selected_Item.SubItems.Strings[152]:= ComboBox8.Items.Strings[ComboBox8.ItemIndex];
//Selected_Item.SubItems.Strings[153]:= ComboBox9.Items.Strings[ComboBox9.ItemIndex];

Selected_Item.SubItems.Strings[160]:=ValueListEditor2.Values['TRAIT_FAST_METABOLISM'];
Selected_Item.SubItems.Strings[161]:=ValueListEditor2.Values['TRAIT_BRUISER'];
Selected_Item.SubItems.Strings[162]:=ValueListEditor2.Values['TRAIT_SMALL_FRAME'];
Selected_Item.SubItems.Strings[163]:=ValueListEditor2.Values['TRAIT_ONE_HANDER'];
Selected_Item.SubItems.Strings[164]:=ValueListEditor2.Values['TRAIT_FINESSE'];
Selected_Item.SubItems.Strings[165]:=ValueListEditor2.Values['TRAIT_KAMIKAZE'];
Selected_Item.SubItems.Strings[166]:=ValueListEditor2.Values['TRAIT_HEAVY_HANDED'];
Selected_Item.SubItems.Strings[167]:=ValueListEditor2.Values['TRAIT_FAST_SHOT'];
Selected_Item.SubItems.Strings[168]:=ValueListEditor2.Values['TRAIT_BLOODY_MESS'];
Selected_Item.SubItems.Strings[169]:=ValueListEditor2.Values['TRAIT_JINXED'];
Selected_Item.SubItems.Strings[170]:=ValueListEditor2.Values['TRAIT_GOOD_NATURED'];
Selected_Item.SubItems.Strings[171]:=ValueListEditor2.Values['TRAIT_CHEM_RELIANT'];
//Selected_Item.SubItems.Strings[172]:=ValueListEditor2.Values['TRAIT_CHEM_RESISTANT'];
Selected_Item.SubItems.Strings[172]:='';
Selected_Item.SubItems.Strings[173]:=ValueListEditor2.Values['TRAIT_BONEHEAD'];
Selected_Item.SubItems.Strings[174]:=ValueListEditor2.Values['TRAIT_SKILLED'];
Selected_Item.SubItems.Strings[175]:=ValueListEditor2.Values['TRAIT_LONER'];

    end
    else
      Selected_Item.SubItems.Strings[0]:=IntToStr(SpinEdit0.Value);    //PID // jesli kontrolka zmiany PID JEST zaznaczona, to zapisuj do ListView z okienek po prawej TYLKO numer PID !!!


  end;
  Sleep(300);
  Caption:=ExtractFileName(path_selected_fopro) + '  -  ' + 'Fonline:Reloaded Critter Proto Editor ' + wersja_programu;

  if Pid<>'' then BitBtn8.Enabled:=True;  // jesli numer PID posiada jakas wartosc to mozna aktywowac przycisk Save to file i po jego uzyciu blad podczas proby zapsiu do pliku nie wywali sie
end;


procedure TForm1.BitBtn1Click(Sender: TObject);    // Append critter
var ListItem:TListItem;
    plik:Textfile;
    linia_critter,linia_numer_critter:String;
    pozycja:Integer;
begin
  global_STOP_FOR_SAVE:=False;

  PageControl1.Visible:=True;  // ta instrukcja jest potrzebna zeby przy zaladowaniu pustego pliku nie mozna bylo edytowac w okienkach po prawej stronie bo to generuje niepoprawne dzialanie ze strony uzytkowniaka oraz przy probie zapsiu blad
  GroupBox8.Visible:=True;
  Panel1.Visible:=True;

  //Button2.Enabled:=True;
  BitBtn8.Enabled:=True;
  //Button3.Enabled:=True;
  BitBtn5.Enabled:=True;
  BitBtn5.Visible:=True;
  BitBtn10.Enabled:=True; // Cancel button
  BitBtn10.Visible:=True; // Cancel button
  BitBtn6.Enabled:=True;
  BitBtn6.Visible:=True;

  BitBtn3.Visible:=True;

  Inc(licznik_critterow);

  //Inicjalizacja;

  linia_numer_critter:='';

  AssignFile(plik,path_selected_msg);
  Reset(plik);
  while not eof(plik) do
  begin
    //{2470}{}{Nasty Floater}
    Readln(plik,linia_critter);
    linia_critter:=Trim(linia_critter);
    if (length(linia_critter)>0) and (linia_critter[1]<>'#') then
    begin
      Delete(linia_critter,1,1);
      //2470}{}{Nasty Floater}
      pozycja:=Pos('}',linia_critter);
      linia_numer_critter:=Copy(linia_critter,1,pozycja-1);
    end;
  end;
  CloseFile(plik);
  ostatni_numer_pid_w_fodlg_msg:=IntToStr(StrToInt(linia_numer_critter) div 10);




  if ListView1.Items.Count>0 then
  begin
    //Pid:=IntToStr(StrToInt((ListView1.Items[0].SubItems[0])) + (ListView1.Items.Count));
    Pid:=IntToStr(StrToInt((ListView1.Items[ListView1.Items.Count-1].SubItems[0]))+1);

    //if StrToInt(Pid)<StrToInt(ostatni_numer_pid_w_fodlg_msg) then
//      Pid:=IntToStr(StrToInt(ostatni_numer_pid_w_fodlg_msg) + 1);

    with ListView1.Items.Item[ListView1.ItemIndex] do
    begin
      //Pid:=Selected_Item.SubItems.Strings[0]; // dla pokazania numeru indeksu Listview.Strings[0]
      //nazwa_crittera:=Selected_Item.SubItems.Strings[1]; // dla pokazania numeru indeksu Listview.Strings[1]

      ST_BASE_CRTYPE:=Selected_Item.SubItems.Strings[2];
      nazwa_frm:=Selected_Item.SubItems.Strings[3];

      ST_STRENGTH:=Selected_Item.SubItems.Strings[4];
      ST_PERCEPTION:=Selected_Item.SubItems.Strings[5];
      ST_ENDURANCE:=Selected_Item.SubItems.Strings[6];
      ST_CHARISMA:=Selected_Item.SubItems.Strings[7];
      ST_INTELLECT:=Selected_Item.SubItems.Strings[8];
      ST_AGILITY:=Selected_Item.SubItems.Strings[9];
      ST_LUCK:=Selected_Item.SubItems.Strings[10];
      ST_KILL_EXPERIENCE:=Selected_Item.SubItems.Strings[11];
      ST_MAX_LIFE:=Selected_Item.SubItems.Strings[12];
      ST_ACTION_POINTS:=Selected_Item.SubItems.Strings[13];

      ST_ARMOR_CLASS:=Selected_Item.SubItems.Strings[14];
      ST_MELEE_DAMAGE:=Selected_Item.SubItems.Strings[15];
      ST_CARRY_WEIGHT:=Selected_Item.SubItems.Strings[16];
      ST_SEQUENCE:=Selected_Item.SubItems.Strings[17];
      ST_HEALING_RATE:=Selected_Item.SubItems.Strings[18];
      ST_CRITICAL_CHANCE:=Selected_Item.SubItems.Strings[19];

      ST_BODY_TYPE:=Selected_Item.SubItems.Strings[20];
      ST_LOCOMOTION_TYPE:=Selected_Item.SubItems.Strings[21];
      ST_DAMAGE_TYPE:=Selected_Item.SubItems.Strings[22];
      ST_GENDER:=Selected_Item.SubItems.Strings[23];
      ST_AGE:=Selected_Item.SubItems.Strings[24];
      //ST_SCALE_FACTOR:=Selected_Item.SubItems.Strings[25];
      ST_SCALE_FACTOR:='0';

      ST_AI_ID:=Selected_Item.SubItems.Strings[26];

      SK_SMALL_GUNS:=Selected_Item.SubItems.Strings[27];
      SK_BIG_GUNS:=Selected_Item.SubItems.Strings[28];
      SK_ENERGY_WEAPONS:=Selected_Item.SubItems.Strings[29];
      SK_UNARMED:=Selected_Item.SubItems.Strings[30];
      SK_SCAVENGING:=Selected_Item.SubItems.Strings[31];
      SK_THROWING:=Selected_Item.SubItems.Strings[32];
      SK_FIRST_AID:=Selected_Item.SubItems.Strings[33];
      SK_DOCTOR:=Selected_Item.SubItems.Strings[34];
      SK_SNEAK:=Selected_Item.SubItems.Strings[35];
      SK_LOCKPICK:=Selected_Item.SubItems.Strings[36];
      SK_STEAL:=Selected_Item.SubItems.Strings[37];
      SK_TRAPS:=Selected_Item.SubItems.Strings[38];
      SK_SCIENCE:=Selected_Item.SubItems.Strings[39];
      SK_REPAIR:=Selected_Item.SubItems.Strings[40];
      SK_SPEECH:=Selected_Item.SubItems.Strings[41];
      SK_BARTER:=Selected_Item.SubItems.Strings[42];
      SK_GAMBLING:=Selected_Item.SubItems.Strings[43];
      SK_OUTDOORSMAN:=Selected_Item.SubItems.Strings[44];

      ST_NORMAL_ABSORB:=Selected_Item.SubItems.Strings[45];
      ST_LASER_ABSORB:=Selected_Item.SubItems.Strings[46];
      ST_FIRE_ABSORB:=Selected_Item.SubItems.Strings[47];
      ST_PLASMA_ABSORB:=Selected_Item.SubItems.Strings[48];
      ST_ELECTRO_ABSORB:=Selected_Item.SubItems.Strings[49];
      ST_EMP_ABSORB:=Selected_Item.SubItems.Strings[50];
      ST_EXPLODE_ABSORB:=Selected_Item.SubItems.Strings[51];
      ST_NORMAL_RESIST:=Selected_Item.SubItems.Strings[52];
      ST_LASER_RESIST:=Selected_Item.SubItems.Strings[53];
      ST_FIRE_RESIST:=Selected_Item.SubItems.Strings[54];
      ST_PLASMA_RESIST:=Selected_Item.SubItems.Strings[55];
      ST_ELECTRO_RESIST:=Selected_Item.SubItems.Strings[56];
      ST_EMP_RESIST:=Selected_Item.SubItems.Strings[57];
      ST_EXPLODE_RESIST:=Selected_Item.SubItems.Strings[58];
      ST_RADIATION_RESISTANCE:=Selected_Item.SubItems.Strings[59];
      ST_POISON_RESISTANCE:=Selected_Item.SubItems.Strings[60];

      ST_DIALOG_ID:=Selected_Item.SubItems.Strings[61];
      ST_BAG_ID:=Selected_Item.SubItems.Strings[62];
      ST_TEAM_ID:=Selected_Item.SubItems.Strings[63];

      MODE_HIDE:=Selected_Item.SubItems.Strings[64];
      MODE_NO_STEAL:=Selected_Item.SubItems.Strings[65];
      MODE_NO_BARTER:=Selected_Item.SubItems.Strings[66];
      MODE_NO_ENEMY_STACK:=Selected_Item.SubItems.Strings[67];
      MODE_NO_PVP:=Selected_Item.SubItems.Strings[68];
      MODE_NO_HOME:=Selected_Item.SubItems.Strings[69];
      MODE_DLG_SCRIPT_BARTER:=Selected_Item.SubItems.Strings[70];
      MODE_UNLIMITED_AMMO:=Selected_Item.SubItems.Strings[71];
      MODE_NO_DROP:=Selected_Item.SubItems.Strings[72];
      MODE_NO_LOOSE_LIMBS:=Selected_Item.SubItems.Strings[73];
      MODE_DEAD_AGES:=Selected_Item.SubItems.Strings[74];
      MODE_NO_HEAL:=Selected_Item.SubItems.Strings[75];
      MODE_INVULNERABLE:=Selected_Item.SubItems.Strings[76];
      MODE_NO_FLATTEN:=Selected_Item.SubItems.Strings[77];
      MODE_SPECIAL_DEAD:=Selected_Item.SubItems.Strings[78];
      MODE_RANGE_HTH:=Selected_Item.SubItems.Strings[79];
      MODE_NO_KNOCK:=Selected_Item.SubItems.Strings[80];
      MODE_NO_LOOT:=Selected_Item.SubItems.Strings[81];
      MODE_NO_KARMA_ON_KILL:=Selected_Item.SubItems.Strings[82];
      MODE_BARTER_ONLY_CASH:=Selected_Item.SubItems.Strings[83];
      MODE_NO_PUSH:=Selected_Item.SubItems.Strings[84];
      MODE_NO_UNARMED:=Selected_Item.SubItems.Strings[85];
      MODE_NO_AIM:=Selected_Item.SubItems.Strings[86];
      MODE_NO_WALK:=Selected_Item.SubItems.Strings[87];
      MODE_NO_RUN:=Selected_Item.SubItems.Strings[88];
      MODE_NO_TALK:=Selected_Item.SubItems.Strings[89];

      ST_TOXIC:=Selected_Item.SubItems.Strings[90];
      ST_RADIOACTIVE:=Selected_Item.SubItems.Strings[91];

      ST_LEVEL:=Selected_Item.SubItems.Strings[92];
      ST_WALK_TIME:=Selected_Item.SubItems.Strings[93];
      ST_RUN_TIME:=Selected_Item.SubItems.Strings[94];
	  
PE_ACTION_BOY:=Selected_Item.SubItems.Strings[95];
PE_ADRENALINE_RUSH:=Selected_Item.SubItems.Strings[96];
PE_BEST_OF_A_BAD_LOT:=Selected_Item.SubItems.Strings[97];
PE_BETTER_CRITICALS:=Selected_Item.SubItems.Strings[98];
PE_BLESSED_ARE_THE_WEAK:=Selected_Item.SubItems.Strings[99];
PE_BONUS_HTH_ATTACKS:=Selected_Item.SubItems.Strings[100];
PE_CLOSE_COMBAT_MASTER:=Selected_Item.SubItems.Strings[101];
PE_CLOSE_COMBAT_MASTER_II:=Selected_Item.SubItems.Strings[102];
PE_BONUS_MOVE:=Selected_Item.SubItems.Strings[103];
PE_BONUS_RANGED_DAMAGE:=Selected_Item.SubItems.Strings[104];
PE_BONUS_RATE_OF_ATTACK:=Selected_Item.SubItems.Strings[105];
PE_BORN_LEADER:=Selected_Item.SubItems.Strings[106];
PE_DEAD_MAN_WALKING:=Selected_Item.SubItems.Strings[107];
PE_DEMOLITION_EXPERT:=Selected_Item.SubItems.Strings[108];
PE_DERMAL_IMPACT:=Selected_Item.SubItems.Strings[109];
PE_DERMAL_IMPACT_ENH:=Selected_Item.SubItems.Strings[110];
PE_DODGER:=Selected_Item.SubItems.Strings[111];
PE_DODGER_II:=Selected_Item.SubItems.Strings[112];
PE_EARLIER_SEQUENCE:=Selected_Item.SubItems.Strings[113];
PE_EVEN_MORE_CRITICALS:=Selected_Item.SubItems.Strings[114];
PE_EVEN_TOUGHER:=Selected_Item.SubItems.Strings[115];
PE_FAST_RELOAD:=Selected_Item.SubItems.Strings[116];
PE_HAND_LOADER:=Selected_Item.SubItems.Strings[117];
PE_FIELD_MEDIC_II:=Selected_Item.SubItems.Strings[118];
PE_HEAVE_HO:=Selected_Item.SubItems.Strings[119];
PE_HEAVE_HO_II:=Selected_Item.SubItems.Strings[120];
PE_HIT_THE_GAPS:=Selected_Item.SubItems.Strings[121];
PE_HTH_CRITICALS:=Selected_Item.SubItems.Strings[122];
PE_HTH_EVADE:=Selected_Item.SubItems.Strings[123];
PE_HTH_EVADE_II:=Selected_Item.SubItems.Strings[124];
PE_IN_YOUR_FACE:=Selected_Item.SubItems.Strings[125];
PE_IRON_LIMBS:=Selected_Item.SubItems.Strings[126];
PE_JINXED_II:=Selected_Item.SubItems.Strings[127];
PE_LIVEWIRE:=Selected_Item.SubItems.Strings[128];
PE_LIVING_ANATOMY:=Selected_Item.SubItems.Strings[129];
PE_MAN_OF_STEEL:=Selected_Item.SubItems.Strings[130];
PE_MELT_INTO_SHADOW:=Selected_Item.SubItems.Strings[131];
PE_MORE_CRITICALS:=Selected_Item.SubItems.Strings[132];
PE_MORE_RANGED_DAMAGE:=Selected_Item.SubItems.Strings[133];
PE_NEMEAN_ARMOR:=Selected_Item.SubItems.Strings[134];
PE_PHOENIX_IMPLANTS:=Selected_Item.SubItems.Strings[135];
PE_PHOENIX_IMPLANTS_ENH:=Selected_Item.SubItems.Strings[136];
PE_PYROMANIAC:=Selected_Item.SubItems.Strings[137];
PE_QUICK_POCKETS:=Selected_Item.SubItems.Strings[138];
PE_QUICK_RECOVERY:=Selected_Item.SubItems.Strings[139];
PE_RIGHT_BETWEEN_THE_EYES:=Selected_Item.SubItems.Strings[140];
PE_SHARPSHOOTER:=Selected_Item.SubItems.Strings[141];
PE_SILENT_DEATH:=Selected_Item.SubItems.Strings[142];
PE_SLAYER:=Selected_Item.SubItems.Strings[143];
PE_SNIPER:=Selected_Item.SubItems.Strings[144];
PE_SPRAY_AND_PRAY:=Selected_Item.SubItems.Strings[145];
PE_STEALTH_GIRL:=Selected_Item.SubItems.Strings[146];
PE_STONEWALL:=Selected_Item.SubItems.Strings[147];
PE_TERMINATOR:=Selected_Item.SubItems.Strings[148];
PE_TOUGHNESS:=Selected_Item.SubItems.Strings[149];
PE_TREE_TRUNK_THIGHS:=Selected_Item.SubItems.Strings[150];
PE_WEAPON_HANDLING:=Selected_Item.SubItems.Strings[151];

PE_FASTER_HEALING:=Selected_Item.SubItems.Strings[152];
PE_GHOST:=Selected_Item.SubItems.Strings[153];
PE_FIELD_MEDIC:=Selected_Item.SubItems.Strings[154];
PE_LIFEGIVER:=Selected_Item.SubItems.Strings[155];
PE_LIGHT_STEP:=Selected_Item.SubItems.Strings[156];
PE_MEDIC:=Selected_Item.SubItems.Strings[157];

ST_DEFAULT_ARMOR_PID:=Selected_Item.SubItems.Strings[158];
ST_DEFAULT_HELMET_PID:=Selected_Item.SubItems.Strings[159];

TRAIT_FAST_METABOLISM:=Selected_Item.SubItems.Strings[160];
TRAIT_BRUISER:=Selected_Item.SubItems.Strings[161];
TRAIT_SMALL_FRAME:=Selected_Item.SubItems.Strings[162];
TRAIT_ONE_HANDER:=Selected_Item.SubItems.Strings[163];
TRAIT_FINESSE:=Selected_Item.SubItems.Strings[164];
TRAIT_KAMIKAZE:=Selected_Item.SubItems.Strings[165];
TRAIT_HEAVY_HANDED:=Selected_Item.SubItems.Strings[166];
TRAIT_FAST_SHOT:=Selected_Item.SubItems.Strings[167];
TRAIT_BLOODY_MESS:=Selected_Item.SubItems.Strings[168];
TRAIT_JINXED:=Selected_Item.SubItems.Strings[169];
TRAIT_GOOD_NATURED:=Selected_Item.SubItems.Strings[170];
TRAIT_CHEM_RELIANT:=Selected_Item.SubItems.Strings[171];
//TRAIT_CHEM_RESISTANT:=Selected_Item.SubItems.Strings[172];
TRAIT_CHEM_RESISTANT:='';
TRAIT_BONEHEAD:=Selected_Item.SubItems.Strings[173];
TRAIT_SKILLED:=Selected_Item.SubItems.Strings[174];
TRAIT_LONER:=Selected_Item.SubItems.Strings[175];


    end;

  end
  else // (if ListView1.Items.Count=0 then) czyli jesli pusta lista, i towrzymy nowy item jako pierwszy;, w przeciwnym razie bedzie "kopiowal" wartosci z aktulanie zaznaczonego crittera
  begin
    //ShowMessage('You start new empty file *.fopro, please carefully select PID number for avoid overwrite names and describes in FODLG.MSG !!! ');


    //Pid:=IntToStr(ListView1.Items.Count+1);

    Pid:=IntToStr(StrToInt(ostatni_numer_pid_w_fodlg_msg) + 1);

    ST_BASE_CRTYPE:='0';
    ST_AI_ID:='0';

    ST_DIALOG_ID:='0';
    ST_BAG_ID:='0';
    ST_TEAM_ID:='0';


    ST_STRENGTH:='5';
    ST_PERCEPTION:='5';
    ST_ENDURANCE:='5';
    ST_CHARISMA:='5';
    ST_INTELLECT:='5';
    ST_AGILITY:='5';
    ST_LUCK:='5';

    ST_MAX_LIFE:='0';
    ST_ACTION_POINTS:='0';
    ST_ARMOR_CLASS:='0';
    ST_MELEE_DAMAGE:='0';
    ST_CARRY_WEIGHT:='0';
    ST_SEQUENCE:='0';
    ST_HEALING_RATE:='0';
    ST_CRITICAL_CHANCE:='0';
    ST_MAX_CRITICAL:='0';

    ST_KILL_EXPERIENCE:='0';
    ST_BODY_TYPE:='0';
    ST_LOCOMOTION_TYPE:='0';
    ST_DAMAGE_TYPE:='1';
    ST_AGE:='25';
    ST_GENDER:='0';
    ST_SCALE_FACTOR:='0';

    ST_NORMAL_ABSORB:='0';
    ST_LASER_ABSORB:='0';
    ST_FIRE_ABSORB:='0';
    ST_PLASMA_ABSORB:='0';
    ST_ELECTRO_ABSORB:='0';
    ST_EMP_ABSORB:='0';
    ST_EXPLODE_ABSORB:='0';
    ST_NORMAL_RESIST:='0';
    ST_LASER_RESIST:='0';
    ST_FIRE_RESIST:='0';
    ST_PLASMA_RESIST:='0';
    ST_ELECTRO_RESIST:='0';
    ST_EMP_RESIST:='0';
    ST_EXPLODE_RESIST:='0';
    ST_RADIATION_RESISTANCE:='0';
    ST_POISON_RESISTANCE:='0';

    SK_SMALL_GUNS:='0';
    SK_BIG_GUNS:='0';
    SK_ENERGY_WEAPONS:='0';
    SK_UNARMED:='0';
    SK_SCAVENGING:='0';
    SK_THROWING:='0';
    SK_FIRST_AID:='0';
    SK_DOCTOR:='0';
    SK_SNEAK:='0';
    SK_LOCKPICK:='0';
    SK_STEAL:='0';
    SK_TRAPS:='0';
    SK_SCIENCE:='0';
    SK_REPAIR:='0';
    SK_SPEECH:='0';
    SK_BARTER:='0';
    SK_GAMBLING:='0';
    SK_OUTDOORSMAN:='0';

    MODE_HIDE:='0';
    MODE_NO_STEAL:='0';
    MODE_NO_BARTER:='0';
    MODE_NO_ENEMY_STACK:='0';
    MODE_NO_PVP:='0';
    MODE_NO_HOME:='0';
    MODE_DLG_SCRIPT_BARTER:='0';
    MODE_UNLIMITED_AMMO:='0';
    MODE_NO_DROP:='0';
    MODE_NO_LOOSE_LIMBS:='0';
    MODE_DEAD_AGES:='0';
    MODE_NO_HEAL:='0';
    MODE_INVULNERABLE:='0';
    MODE_NO_FLATTEN:='0';
    MODE_SPECIAL_DEAD:='0';
    MODE_RANGE_HTH:='0';
    MODE_NO_KNOCK:='0';
    MODE_NO_LOOT:='0';
    MODE_NO_KARMA_ON_KILL:='0';
    MODE_BARTER_ONLY_CASH:='0';
    MODE_NO_PUSH:='0';
    MODE_NO_UNARMED:='0';
    MODE_NO_AIM:='0';             // Critter can't do aim attacks
    MODE_NO_WALK:='0';            // Critter can't walk
    MODE_NO_RUN:='0';             // Critter can't run
    MODE_NO_TALK:='0';

    ST_TOXIC:='0';
    ST_RADIOACTIVE:='0';

    ST_LEVEL:='0';
    ST_WALK_TIME:='0';
    ST_RUN_TIME:='0';

	
PE_ACTION_BOY            :='';
PE_ADRENALINE_RUSH       :='';
PE_BEST_OF_A_BAD_LOT     :='';
PE_BETTER_CRITICALS      :='';
PE_BLESSED_ARE_THE_WEAK  :='';
PE_BONUS_HTH_ATTACKS     :='';
PE_CLOSE_COMBAT_MASTER      :='';
PE_CLOSE_COMBAT_MASTER_II   :='';
PE_BONUS_MOVE            :='';
PE_BONUS_RANGED_DAMAGE   :='';
PE_BONUS_RATE_OF_ATTACK    :='';
PE_BORN_LEADER           :='';
PE_DEAD_MAN_WALKING      :='';
PE_DEMOLITION_EXPERT     :='';
PE_DERMAL_IMPACT         :='';
PE_DERMAL_IMPACT_ENH     :='';
PE_DODGER                :='';
PE_DODGER_II             :='';
PE_EARLIER_SEQUENCE      :='';
PE_EVEN_MORE_CRITICALS   :='';
PE_EVEN_TOUGHER          :='';
PE_FAST_RELOAD           :='';
PE_HAND_LOADER           :='';
PE_FIELD_MEDIC_II             :='';
PE_HEAVE_HO              :='';
PE_HEAVE_HO_II           :='';
PE_HIT_THE_GAPS          :='';
PE_HTH_CRITICALS         :='';
PE_HTH_EVADE             :='';
PE_HTH_EVADE_II          :='';
PE_IN_YOUR_FACE          :='';
PE_IRON_LIMBS             :='';
PE_JINXED_II             :='';
PE_LIVEWIRE              :='';
PE_LIVING_ANATOMY        :='';
PE_MAN_OF_STEEL          :='';
PE_MELT_INTO_SHADOW      :='';
PE_MORE_CRITICALS        :='';
PE_MORE_RANGED_DAMAGE    :='';
PE_NEMEAN_ARMOR          :='';
PE_PHOENIX_IMPLANTS      :='';
PE_PHOENIX_IMPLANTS_ENH  :='';
PE_PYROMANIAC            :='';
PE_QUICK_POCKETS         :='';
PE_QUICK_RECOVERY        :='';
PE_RIGHT_BETWEEN_THE_EYES:='';
PE_SHARPSHOOTER          :='';
PE_SILENT_DEATH          :='';
PE_SLAYER                :='';
PE_SNIPER                :='';
PE_SPRAY_AND_PRAY        :='';
PE_STEALTH_GIRL          :='';
PE_STONEWALL             :='';
PE_TERMINATOR            :='';
PE_TOUGHNESS             :='';
PE_TREE_TRUNK_THIGHS     :='';
PE_WEAPON_HANDLING       :='';

PE_FASTER_HEALING:='';
PE_GHOST:='';
PE_FIELD_MEDIC:='';
PE_LIFEGIVER:='';
PE_LIGHT_STEP:='';
PE_MEDIC:='';

ST_DEFAULT_ARMOR_PID     :='None';
ST_DEFAULT_HELMET_PID     :='None';

TRAIT_FAST_METABOLISM:='';
TRAIT_BRUISER:='';
TRAIT_SMALL_FRAME:='';
TRAIT_ONE_HANDER:='';
TRAIT_FINESSE:='';
TRAIT_KAMIKAZE:='';
TRAIT_HEAVY_HANDED:='';
TRAIT_FAST_SHOT:='';
TRAIT_BLOODY_MESS:='';
TRAIT_JINXED:='';
TRAIT_GOOD_NATURED:='';
TRAIT_CHEM_RELIANT:='';
TRAIT_CHEM_RESISTANT:='';
TRAIT_BONEHEAD:='';
TRAIT_SKILLED:='';
TRAIT_LONER:='';

  end;

  nazwa_crittera:=tab_nazwy[StrToInt(Pid)];

  if nazwa_crittera='' then
    nazwa_crittera:='new critter';
//  else
//    nazwa_crittera:=tab_nazwy[StrToInt(Pid)];

  //nazwa_crittera:='';
  opis_crittera:='';
  if nazwa_frm='' then nazwa_frm:='hmjmps';

  // dane o wartosciach w zmiennych np ST_BASE_CRTYPE,  ST_STRENGTH, skilalch i MODE itd brane sa z aktulanie zaznacoznego crittera w ListView, a sa one odczytane na poczatku tej procedury
  
  ListItem := ListView1.Items.Add;

  ListItem.Caption:=opis_crittera;
  ListItem.SubItems.Add(Pid);
  ListItem.SubItems.Add(nazwa_crittera);
  ListItem.SubItems.Add(ST_BASE_CRTYPE);
  ListItem.SubItems.Add(nazwa_frm);

  ListItem.SubItems.Add(ST_STRENGTH);
  ListItem.SubItems.Add(ST_PERCEPTION);
  ListItem.SubItems.Add(ST_ENDURANCE);
  ListItem.SubItems.Add(ST_CHARISMA);
  ListItem.SubItems.Add(ST_INTELLECT);
  ListItem.SubItems.Add(ST_AGILITY);
  ListItem.SubItems.Add(ST_LUCK);
  ListItem.SubItems.Add(ST_KILL_EXPERIENCE);
  ListItem.SubItems.Add(ST_MAX_LIFE);
  ListItem.SubItems.Add(ST_ACTION_POINTS);

  ListItem.SubItems.Add(ST_ARMOR_CLASS);
  ListItem.SubItems.Add(ST_MELEE_DAMAGE);
  ListItem.SubItems.Add(ST_CARRY_WEIGHT);
  ListItem.SubItems.Add(ST_SEQUENCE);
  ListItem.SubItems.Add(ST_HEALING_RATE);
  ListItem.SubItems.Add(ST_CRITICAL_CHANCE);

  ListItem.SubItems.Add(ST_BODY_TYPE);
  ListItem.SubItems.Add(ST_LOCOMOTION_TYPE);
  ListItem.SubItems.Add(ST_DAMAGE_TYPE);
  ListItem.SubItems.Add(ST_GENDER);
  ListItem.SubItems.Add(ST_AGE);
  ListItem.SubItems.Add(ST_SCALE_FACTOR);

  ListItem.SubItems.Add(ST_AI_ID);


  ListItem.SubItems.Add(SK_SMALL_GUNS);
  ListItem.SubItems.Add(SK_BIG_GUNS);
  ListItem.SubItems.Add(SK_ENERGY_WEAPONS);
  ListItem.SubItems.Add(SK_UNARMED);
  ListItem.SubItems.Add(SK_SCAVENGING);
  ListItem.SubItems.Add(SK_THROWING);
  ListItem.SubItems.Add(SK_FIRST_AID);
  ListItem.SubItems.Add(SK_DOCTOR);
  ListItem.SubItems.Add(SK_SNEAK);
  ListItem.SubItems.Add(SK_LOCKPICK);
  ListItem.SubItems.Add(SK_STEAL);
  ListItem.SubItems.Add(SK_TRAPS);
  ListItem.SubItems.Add(SK_SCIENCE);
  ListItem.SubItems.Add(SK_REPAIR);
  ListItem.SubItems.Add(SK_SPEECH);
  ListItem.SubItems.Add(SK_BARTER);
  ListItem.SubItems.Add(SK_GAMBLING);
  ListItem.SubItems.Add(SK_OUTDOORSMAN);

  ListItem.SubItems.Add(ST_NORMAL_ABSORB);
  ListItem.SubItems.Add(ST_LASER_ABSORB);
  ListItem.SubItems.Add(ST_FIRE_ABSORB);
  ListItem.SubItems.Add(ST_PLASMA_ABSORB);
  ListItem.SubItems.Add(ST_ELECTRO_ABSORB);
  ListItem.SubItems.Add(ST_EMP_ABSORB);
  ListItem.SubItems.Add(ST_EXPLODE_ABSORB);
  ListItem.SubItems.Add(ST_NORMAL_RESIST);
  ListItem.SubItems.Add(ST_LASER_RESIST);
  ListItem.SubItems.Add(ST_FIRE_RESIST);
  ListItem.SubItems.Add(ST_PLASMA_RESIST);
  ListItem.SubItems.Add(ST_ELECTRO_RESIST);
  ListItem.SubItems.Add(ST_EMP_RESIST);
  ListItem.SubItems.Add(ST_EXPLODE_RESIST);
  ListItem.SubItems.Add(ST_RADIATION_RESISTANCE);
  ListItem.SubItems.Add(ST_POISON_RESISTANCE);

  ListItem.SubItems.Add(ST_DIALOG_ID);
  ListItem.SubItems.Add(ST_BAG_ID);
  ListItem.SubItems.Add(ST_TEAM_ID);

  ListItem.SubItems.Add(MODE_HIDE);
  ListItem.SubItems.Add(MODE_NO_STEAL);
  ListItem.SubItems.Add(MODE_NO_BARTER);
  ListItem.SubItems.Add(MODE_NO_ENEMY_STACK);
  ListItem.SubItems.Add(MODE_NO_PVP);
  ListItem.SubItems.Add(MODE_NO_HOME);
  ListItem.SubItems.Add(MODE_DLG_SCRIPT_BARTER);
  ListItem.SubItems.Add(MODE_UNLIMITED_AMMO);
  ListItem.SubItems.Add(MODE_NO_DROP);
  ListItem.SubItems.Add(MODE_NO_LOOSE_LIMBS);
  ListItem.SubItems.Add(MODE_DEAD_AGES);
  ListItem.SubItems.Add(MODE_NO_HEAL);
  ListItem.SubItems.Add(MODE_INVULNERABLE);
  ListItem.SubItems.Add(MODE_NO_FLATTEN);
  ListItem.SubItems.Add(MODE_SPECIAL_DEAD);
  ListItem.SubItems.Add(MODE_RANGE_HTH);
  ListItem.SubItems.Add(MODE_NO_KNOCK);
  ListItem.SubItems.Add(MODE_NO_LOOT);
  ListItem.SubItems.Add(MODE_NO_KARMA_ON_KILL);
  ListItem.SubItems.Add(MODE_BARTER_ONLY_CASH);
  ListItem.SubItems.Add(MODE_NO_PUSH);
  ListItem.SubItems.Add(MODE_NO_UNARMED);
  ListItem.SubItems.Add(MODE_NO_AIM);
  ListItem.SubItems.Add(MODE_NO_WALK);
  ListItem.SubItems.Add(MODE_NO_RUN);
  ListItem.SubItems.Add(MODE_NO_TALK);

  ListItem.SubItems.Add(ST_TOXIC);
  ListItem.SubItems.Add(ST_RADIOACTIVE);

  ListItem.SubItems.Add(ST_LEVEL);
  ListItem.SubItems.Add(ST_WALK_TIME);
  ListItem.SubItems.Add(ST_RUN_TIME);
  
  ListItem.SubItems.Add(PE_ACTION_BOY);
ListItem.SubItems.Add(PE_ADRENALINE_RUSH);
ListItem.SubItems.Add(PE_BEST_OF_A_BAD_LOT);
ListItem.SubItems.Add(PE_BETTER_CRITICALS);
ListItem.SubItems.Add(PE_BLESSED_ARE_THE_WEAK);
ListItem.SubItems.Add(PE_BONUS_HTH_ATTACKS);
ListItem.SubItems.Add(PE_CLOSE_COMBAT_MASTER);
ListItem.SubItems.Add(PE_CLOSE_COMBAT_MASTER_II);
ListItem.SubItems.Add(PE_BONUS_MOVE);
ListItem.SubItems.Add(PE_BONUS_RANGED_DAMAGE);
ListItem.SubItems.Add(PE_BONUS_RATE_OF_ATTACK);
ListItem.SubItems.Add(PE_BORN_LEADER);
ListItem.SubItems.Add(PE_DEAD_MAN_WALKING);
ListItem.SubItems.Add(PE_DEMOLITION_EXPERT);
ListItem.SubItems.Add(PE_DERMAL_IMPACT);
ListItem.SubItems.Add(PE_DERMAL_IMPACT_ENH);
ListItem.SubItems.Add(PE_DODGER);
ListItem.SubItems.Add(PE_DODGER_II);
ListItem.SubItems.Add(PE_EARLIER_SEQUENCE);
ListItem.SubItems.Add(PE_EVEN_MORE_CRITICALS);
ListItem.SubItems.Add(PE_EVEN_TOUGHER);
ListItem.SubItems.Add(PE_FAST_RELOAD);
ListItem.SubItems.Add(PE_HAND_LOADER);
ListItem.SubItems.Add(PE_FIELD_MEDIC_II);
ListItem.SubItems.Add(PE_HEAVE_HO);
ListItem.SubItems.Add(PE_HEAVE_HO_II);
ListItem.SubItems.Add(PE_HIT_THE_GAPS);
ListItem.SubItems.Add(PE_HTH_CRITICALS);
ListItem.SubItems.Add(PE_HTH_EVADE);
ListItem.SubItems.Add(PE_HTH_EVADE_II);
ListItem.SubItems.Add(PE_IN_YOUR_FACE);
ListItem.SubItems.Add(PE_IRON_LIMBS);
ListItem.SubItems.Add(PE_JINXED_II);
ListItem.SubItems.Add(PE_LIVEWIRE);
ListItem.SubItems.Add(PE_LIVING_ANATOMY);
ListItem.SubItems.Add(PE_MAN_OF_STEEL);
ListItem.SubItems.Add(PE_MELT_INTO_SHADOW);
ListItem.SubItems.Add(PE_MORE_CRITICALS);
ListItem.SubItems.Add(PE_MORE_RANGED_DAMAGE);
ListItem.SubItems.Add(PE_NEMEAN_ARMOR);
ListItem.SubItems.Add(PE_PHOENIX_IMPLANTS);
ListItem.SubItems.Add(PE_PHOENIX_IMPLANTS_ENH);
ListItem.SubItems.Add(PE_PYROMANIAC);
ListItem.SubItems.Add(PE_QUICK_POCKETS);
ListItem.SubItems.Add(PE_QUICK_RECOVERY);
ListItem.SubItems.Add(PE_RIGHT_BETWEEN_THE_EYES);
ListItem.SubItems.Add(PE_SHARPSHOOTER);
ListItem.SubItems.Add(PE_SILENT_DEATH);
ListItem.SubItems.Add(PE_SLAYER);
ListItem.SubItems.Add(PE_SNIPER);
ListItem.SubItems.Add(PE_SPRAY_AND_PRAY);
ListItem.SubItems.Add(PE_STEALTH_GIRL);
ListItem.SubItems.Add(PE_STONEWALL);
ListItem.SubItems.Add(PE_TERMINATOR);
ListItem.SubItems.Add(PE_TOUGHNESS);
ListItem.SubItems.Add(PE_TREE_TRUNK_THIGHS);
ListItem.SubItems.Add(PE_WEAPON_HANDLING);

ListItem.SubItems.Add(PE_FASTER_HEALING);
ListItem.SubItems.Add(PE_GHOST);
ListItem.SubItems.Add(PE_FIELD_MEDIC);
ListItem.SubItems.Add(PE_LIFEGIVER);
ListItem.SubItems.Add(PE_LIGHT_STEP);
ListItem.SubItems.Add(PE_MEDIC);

ListItem.SubItems.Add(ST_DEFAULT_ARMOR_PID);
ListItem.SubItems.Add(ST_DEFAULT_HELMET_PID);

ListItem.SubItems.Add(TRAIT_FAST_METABOLISM);
ListItem.SubItems.Add(TRAIT_BRUISER);
ListItem.SubItems.Add(TRAIT_SMALL_FRAME);
ListItem.SubItems.Add(TRAIT_ONE_HANDER);
ListItem.SubItems.Add(TRAIT_FINESSE);
ListItem.SubItems.Add(TRAIT_KAMIKAZE);
ListItem.SubItems.Add(TRAIT_HEAVY_HANDED);
ListItem.SubItems.Add(TRAIT_FAST_SHOT);
ListItem.SubItems.Add(TRAIT_BLOODY_MESS);
ListItem.SubItems.Add(TRAIT_JINXED);
ListItem.SubItems.Add(TRAIT_GOOD_NATURED);
ListItem.SubItems.Add(TRAIT_CHEM_RELIANT);
ListItem.SubItems.Add(TRAIT_CHEM_RESISTANT);
ListItem.SubItems.Add(TRAIT_BONEHEAD);
ListItem.SubItems.Add(TRAIT_SKILLED);
ListItem.SubItems.Add(TRAIT_LONER);


  begin
    ListView1.Items[ListView1.Items.Count-1].Focused:=True;
    ListView1.Items[ListView1.Items.Count-1].Selected:=True;
  end;

  if Pid='' then BitBtn8.Enabled:=False;  // po dodaniu nowego crittera przycisk Save to file musi byc zdeaktywoany, bo nie ma numeru PID i sie wywali blad
end;



procedure TForm1.BitBtn2Click(Sender: TObject);  // Delete item
var Indeks:Integer;
begin
  Indeks:=ListView1.ItemIndex;

  ListView1.DeleteSelected;
  Dec(licznik_critterow);
  if licznik_critterow<0 then licznik_critterow:=0;

  if Indeks<1 then
    Indeks:=0
  else
  if Indeks=ListView1.Items.Count then
    Indeks:=ListView1.Items.Count-1
  else
    Indeks:=Indeks;


  if ListView1.Items.Count>0 then
  begin
    ListView1.Items[Indeks].Focused:=True;
    ListView1.Items[Indeks].Selected:=True;
  end
  else
  begin
    PageControl1.Visible:=False;  // ta instrukcja jest potrzebna zeby przy zaladowaniu pustego pliku nie mozna bylo edytowac w okienkach po prawej stronie bo to generuje niepoprawne dzialanie ze strony uzytkowniaka oraz przy probie zapsiu blad
    GroupBox8.Visible:=False;
    Panel1.Visible:=False;
    //Button3.Enabled:=False;

    BitBtn3.Visible:=False;

    BitBtn5.Enabled:=False;
    BitBtn5.Visible:=False;
    BitBtn10.Enabled:=False; // Cancel button
    BitBtn10.Visible:=False; // Cancel button

    BitBtn6.Enabled:=False;
    BitBtn6.Visible:=False;
  end;


end;

procedure TForm1.BitBtn3Click(Sender: TObject);    // insert item 
var ListItem : TListItem;
begin
  ZapiszBiezacyCritter;

  if ListView1.Items.Count>0 then
  begin
    global_STOP_FOR_SAVE:=False;

    with ListView1 do
      ListItem := Items.Insert(Selected.Index);


      Inc(licznik_critterow);

    nazwa_crittera:='';
    opis_crittera:='';
    if nazwa_frm='' then
      nazwa_frm:='hmjmps';


  if Edit37.Text='' then
  begin
    //Pid:=IntToStr(UpDown42.Min);
    Pid:=IntToStr(SpinEdit0.Value);

    ST_BASE_CRTYPE:='0';
    ST_AI_ID:='1';
    ST_DIALOG_ID:='0';
    ST_BAG_ID:='0';
    ST_TEAM_ID:='0';


    ST_STRENGTH:='5';
    ST_PERCEPTION:='5';
    ST_ENDURANCE:='5';
    ST_CHARISMA:='5';
    ST_INTELLECT:='5';
    ST_AGILITY:='5';
    ST_LUCK:='5';

    ST_MAX_LIFE:='0';
    ST_ACTION_POINTS:='0';
    ST_ARMOR_CLASS:='0';
    ST_MELEE_DAMAGE:='0';
    ST_CARRY_WEIGHT:='0';
    ST_SEQUENCE:='0';
    ST_HEALING_RATE:='0';
    ST_CRITICAL_CHANCE:='0';
    ST_MAX_CRITICAL:='0';

    ST_KILL_EXPERIENCE:='0';
    ST_BODY_TYPE:='0';
    ST_LOCOMOTION_TYPE:='0';
    ST_DAMAGE_TYPE:='1';
    ST_AGE:='25';
    ST_GENDER:='0';
    ST_SCALE_FACTOR:='0';

    ST_NORMAL_ABSORB:='0';
    ST_LASER_ABSORB:='0';
    ST_FIRE_ABSORB:='0';
    ST_PLASMA_ABSORB:='0';
    ST_ELECTRO_ABSORB:='0';
    ST_EMP_ABSORB:='0';
    ST_EXPLODE_ABSORB:='0';
    ST_NORMAL_RESIST:='0';
    ST_LASER_RESIST:='0';
    ST_FIRE_RESIST:='0';
    ST_PLASMA_RESIST:='0';
    ST_ELECTRO_RESIST:='0';
    ST_EMP_RESIST:='0';
    ST_EXPLODE_RESIST:='0';
    ST_RADIATION_RESISTANCE:='0';
    ST_POISON_RESISTANCE:='0';

    SK_SMALL_GUNS:='0';
    SK_BIG_GUNS:='0';
    SK_ENERGY_WEAPONS:='0';
    SK_UNARMED:='0';
    SK_SCAVENGING:='0';
    SK_THROWING:='0';
    SK_FIRST_AID:='0';
    SK_DOCTOR:='0';
    SK_SNEAK:='0';
    SK_LOCKPICK:='0';
    SK_STEAL:='0';
    SK_TRAPS:='0';
    SK_SCIENCE:='0';
    SK_REPAIR:='0';
    SK_SPEECH:='0';
    SK_BARTER:='0';
    SK_GAMBLING:='0';
    SK_OUTDOORSMAN:='0';

    MODE_HIDE:='0';
    MODE_NO_STEAL:='0';
    MODE_NO_BARTER:='0';
    MODE_NO_ENEMY_STACK:='0';
    MODE_NO_PVP:='0';
    MODE_NO_HOME:='0';
    MODE_DLG_SCRIPT_BARTER:='0';
    MODE_UNLIMITED_AMMO:='0';
    MODE_NO_DROP:='0';
    MODE_NO_LOOSE_LIMBS:='0';
    MODE_DEAD_AGES:='0';
    MODE_NO_HEAL:='0';
    MODE_INVULNERABLE:='0';
    MODE_NO_FLATTEN:='0';
    MODE_SPECIAL_DEAD:='0';
    MODE_RANGE_HTH:='0';
    MODE_NO_KNOCK:='0';
    MODE_NO_LOOT:='0';
    MODE_NO_KARMA_ON_KILL:='0';
    MODE_BARTER_ONLY_CASH:='0';
    MODE_NO_PUSH:='0';
    MODE_NO_UNARMED:='0';
    MODE_NO_AIM:='0';             // Critter can't do aim attacks
    MODE_NO_WALK:='0';            // Critter can't walk
    MODE_NO_RUN:='0';             // Critter can't run
    MODE_NO_TALK:='0';

    ST_TOXIC:='0';
    ST_RADIOACTIVE:='0';

PE_ACTION_BOY            :='';
PE_ADRENALINE_RUSH       :='';
PE_BEST_OF_A_BAD_LOT     :='';
PE_BETTER_CRITICALS      :='';
PE_BLESSED_ARE_THE_WEAK  :='';
PE_BONUS_HTH_ATTACKS     :='';
PE_CLOSE_COMBAT_MASTER      :='';
PE_CLOSE_COMBAT_MASTER_II   :='';
PE_BONUS_MOVE            :='';
PE_BONUS_RANGED_DAMAGE   :='';
PE_BONUS_RATE_OF_ATTACK    :='';
PE_BORN_LEADER           :='';
PE_DEAD_MAN_WALKING      :='';
PE_DEMOLITION_EXPERT     :='';
PE_DERMAL_IMPACT         :='';
PE_DERMAL_IMPACT_ENH     :='';
PE_DODGER                :='';
PE_DODGER_II             :='';
PE_EARLIER_SEQUENCE      :='';
PE_EVEN_MORE_CRITICALS   :='';
PE_EVEN_TOUGHER          :='';
PE_FAST_RELOAD           :='';
PE_HAND_LOADER           :='';
PE_FIELD_MEDIC_II             :='';
PE_HEAVE_HO              :='';
PE_HEAVE_HO_II           :='';
PE_HIT_THE_GAPS          :='';
PE_HTH_CRITICALS         :='';
PE_HTH_EVADE             :='';
PE_HTH_EVADE_II          :='';
PE_IN_YOUR_FACE          :='';
PE_IRON_LIMBS             :='';
PE_JINXED_II             :='';
PE_LIVEWIRE              :='';
PE_LIVING_ANATOMY        :='';
PE_MAN_OF_STEEL          :='';
PE_MELT_INTO_SHADOW      :='';
PE_MORE_CRITICALS        :='';
PE_MORE_RANGED_DAMAGE    :='';
PE_NEMEAN_ARMOR          :='';
PE_PHOENIX_IMPLANTS      :='';
PE_PHOENIX_IMPLANTS_ENH  :='';
PE_PYROMANIAC            :='';
PE_QUICK_POCKETS         :='';
PE_QUICK_RECOVERY        :='';
PE_RIGHT_BETWEEN_THE_EYES:='';
PE_SHARPSHOOTER          :='';
PE_SILENT_DEATH          :='';
PE_SLAYER                :='';
PE_SNIPER                :='';
PE_SPRAY_AND_PRAY        :='';
PE_STEALTH_GIRL          :='';
PE_STONEWALL             :='';
PE_TERMINATOR            :='';
PE_TOUGHNESS             :='';
PE_TREE_TRUNK_THIGHS     :='';
PE_WEAPON_HANDLING       :='';

PE_FASTER_HEALING:='';
PE_GHOST:='';
PE_FIELD_MEDIC:='';
PE_LIFEGIVER:='';
PE_LIGHT_STEP:='';
PE_MEDIC:='';

ST_DEFAULT_ARMOR_PID     :='None';
ST_DEFAULT_HELMET_PID     :='None';

TRAIT_FAST_METABOLISM:='';
TRAIT_BRUISER:='';
TRAIT_SMALL_FRAME:='';
TRAIT_ONE_HANDER:='';
TRAIT_FINESSE:='';
TRAIT_KAMIKAZE:='';
TRAIT_HEAVY_HANDED:='';
TRAIT_FAST_SHOT:='';
TRAIT_BLOODY_MESS:='';
TRAIT_JINXED:='';
TRAIT_GOOD_NATURED:='';
TRAIT_CHEM_RELIANT:='';
TRAIT_CHEM_RESISTANT:='';
TRAIT_BONEHEAD:='';
TRAIT_SKILLED:='';
TRAIT_LONER:='0';


  end;


    ListItem.Caption := opis_crittera;

      ListItem.Caption:=opis_crittera;
      ListItem.SubItems.Add(Pid);
      ListItem.SubItems.Add(nazwa_crittera);
      ListItem.SubItems.Add(ST_BASE_CRTYPE);
      ListItem.SubItems.Add(nazwa_frm);

      ListItem.SubItems.Add(ST_STRENGTH);
      ListItem.SubItems.Add(ST_PERCEPTION);
      ListItem.SubItems.Add(ST_ENDURANCE);
      ListItem.SubItems.Add(ST_CHARISMA);
      ListItem.SubItems.Add(ST_INTELLECT);
      ListItem.SubItems.Add(ST_AGILITY);
      ListItem.SubItems.Add(ST_LUCK);
      ListItem.SubItems.Add(ST_KILL_EXPERIENCE);
      ListItem.SubItems.Add(ST_MAX_LIFE);
      ListItem.SubItems.Add(ST_ACTION_POINTS);

      ListItem.SubItems.Add(ST_ARMOR_CLASS);
      ListItem.SubItems.Add(ST_MELEE_DAMAGE);
      ListItem.SubItems.Add(ST_CARRY_WEIGHT);
      ListItem.SubItems.Add(ST_SEQUENCE);
      ListItem.SubItems.Add(ST_HEALING_RATE);
      ListItem.SubItems.Add(ST_CRITICAL_CHANCE);

      ListItem.SubItems.Add(ST_BODY_TYPE);
      ListItem.SubItems.Add(ST_LOCOMOTION_TYPE);
      ListItem.SubItems.Add(ST_DAMAGE_TYPE);
      ListItem.SubItems.Add(ST_GENDER);
      ListItem.SubItems.Add(ST_AGE);
      ListItem.SubItems.Add(ST_SCALE_FACTOR);

      ListItem.SubItems.Add(ST_AI_ID);


    ListItem.SubItems.Add(SK_SMALL_GUNS);
    ListItem.SubItems.Add(SK_BIG_GUNS);
    ListItem.SubItems.Add(SK_ENERGY_WEAPONS);
    ListItem.SubItems.Add(SK_UNARMED);
    ListItem.SubItems.Add(SK_SCAVENGING);
    ListItem.SubItems.Add(SK_THROWING);
    ListItem.SubItems.Add(SK_FIRST_AID);
    ListItem.SubItems.Add(SK_DOCTOR);
    ListItem.SubItems.Add(SK_SNEAK);
    ListItem.SubItems.Add(SK_LOCKPICK);
    ListItem.SubItems.Add(SK_STEAL);
    ListItem.SubItems.Add(SK_TRAPS);
    ListItem.SubItems.Add(SK_SCIENCE);
    ListItem.SubItems.Add(SK_REPAIR);
    ListItem.SubItems.Add(SK_SPEECH);
    ListItem.SubItems.Add(SK_BARTER);
    ListItem.SubItems.Add(SK_GAMBLING);
    ListItem.SubItems.Add(SK_OUTDOORSMAN);


    ListItem.SubItems.Add(ST_NORMAL_ABSORB);
    ListItem.SubItems.Add(ST_LASER_ABSORB);
    ListItem.SubItems.Add(ST_FIRE_ABSORB);
    ListItem.SubItems.Add(ST_PLASMA_ABSORB);
    ListItem.SubItems.Add(ST_ELECTRO_ABSORB);
    ListItem.SubItems.Add(ST_EMP_ABSORB);
    ListItem.SubItems.Add(ST_EXPLODE_ABSORB);
    ListItem.SubItems.Add(ST_NORMAL_RESIST);
    ListItem.SubItems.Add(ST_LASER_RESIST);
    ListItem.SubItems.Add(ST_FIRE_RESIST);
    ListItem.SubItems.Add(ST_PLASMA_RESIST);
    ListItem.SubItems.Add(ST_ELECTRO_RESIST);
    ListItem.SubItems.Add(ST_EMP_RESIST);
    ListItem.SubItems.Add(ST_EXPLODE_RESIST);
    ListItem.SubItems.Add(ST_RADIATION_RESISTANCE);
    ListItem.SubItems.Add(ST_POISON_RESISTANCE);

    ListItem.SubItems.Add(ST_DIALOG_ID);
    ListItem.SubItems.Add(ST_BAG_ID);
    ListItem.SubItems.Add(ST_TEAM_ID);


    ListItem.SubItems.Add(MODE_HIDE);
    ListItem.SubItems.Add(MODE_NO_STEAL);
    ListItem.SubItems.Add(MODE_NO_BARTER);
    ListItem.SubItems.Add(MODE_NO_ENEMY_STACK);
    ListItem.SubItems.Add(MODE_NO_PVP);
    ListItem.SubItems.Add(MODE_NO_HOME);
    ListItem.SubItems.Add(MODE_DLG_SCRIPT_BARTER);
    ListItem.SubItems.Add(MODE_UNLIMITED_AMMO);
    ListItem.SubItems.Add(MODE_NO_DROP);
    ListItem.SubItems.Add(MODE_NO_LOOSE_LIMBS);
    ListItem.SubItems.Add(MODE_DEAD_AGES);
    ListItem.SubItems.Add(MODE_NO_HEAL);
    ListItem.SubItems.Add(MODE_INVULNERABLE);
    ListItem.SubItems.Add(MODE_NO_FLATTEN);
    ListItem.SubItems.Add(MODE_SPECIAL_DEAD);
    ListItem.SubItems.Add(MODE_RANGE_HTH);
    ListItem.SubItems.Add(MODE_NO_KNOCK);
    ListItem.SubItems.Add(MODE_NO_LOOT);
    ListItem.SubItems.Add(MODE_NO_KARMA_ON_KILL);
    ListItem.SubItems.Add(MODE_BARTER_ONLY_CASH);
    ListItem.SubItems.Add(MODE_NO_PUSH);
    ListItem.SubItems.Add(MODE_NO_UNARMED);
    ListItem.SubItems.Add(MODE_NO_AIM);
    ListItem.SubItems.Add(MODE_NO_WALK);
    ListItem.SubItems.Add(MODE_NO_RUN);
    ListItem.SubItems.Add(MODE_NO_TALK);

    ListItem.SubItems.Add(ST_TOXIC);
    ListItem.SubItems.Add(ST_RADIOACTIVE);
	
      ListItem.SubItems.Add(ST_LEVEL);
      ListItem.SubItems.Add(ST_WALK_TIME);
      ListItem.SubItems.Add(ST_RUN_TIME);


ListItem.SubItems.Add(PE_ACTION_BOY);
ListItem.SubItems.Add(PE_ADRENALINE_RUSH);
ListItem.SubItems.Add(PE_BEST_OF_A_BAD_LOT);
ListItem.SubItems.Add(PE_BETTER_CRITICALS);
ListItem.SubItems.Add(PE_BLESSED_ARE_THE_WEAK);
ListItem.SubItems.Add(PE_BONUS_HTH_ATTACKS);
ListItem.SubItems.Add(PE_CLOSE_COMBAT_MASTER);
ListItem.SubItems.Add(PE_CLOSE_COMBAT_MASTER_II);
ListItem.SubItems.Add(PE_BONUS_MOVE);
ListItem.SubItems.Add(PE_BONUS_RANGED_DAMAGE);
ListItem.SubItems.Add(PE_BONUS_RATE_OF_ATTACK);
ListItem.SubItems.Add(PE_BORN_LEADER);
ListItem.SubItems.Add(PE_DEAD_MAN_WALKING);
ListItem.SubItems.Add(PE_DEMOLITION_EXPERT);
ListItem.SubItems.Add(PE_DERMAL_IMPACT);
ListItem.SubItems.Add(PE_DERMAL_IMPACT_ENH);
ListItem.SubItems.Add(PE_DODGER);
ListItem.SubItems.Add(PE_DODGER_II);
ListItem.SubItems.Add(PE_EARLIER_SEQUENCE);
ListItem.SubItems.Add(PE_EVEN_MORE_CRITICALS);
ListItem.SubItems.Add(PE_EVEN_TOUGHER);
ListItem.SubItems.Add(PE_FAST_RELOAD);
ListItem.SubItems.Add(PE_HAND_LOADER);
ListItem.SubItems.Add(PE_FIELD_MEDIC_II);
ListItem.SubItems.Add(PE_HEAVE_HO);
ListItem.SubItems.Add(PE_HEAVE_HO_II);
ListItem.SubItems.Add(PE_HIT_THE_GAPS);
ListItem.SubItems.Add(PE_HTH_CRITICALS);
ListItem.SubItems.Add(PE_HTH_EVADE);
ListItem.SubItems.Add(PE_HTH_EVADE_II);
ListItem.SubItems.Add(PE_IN_YOUR_FACE);
ListItem.SubItems.Add(PE_IRON_LIMBS);
ListItem.SubItems.Add(PE_JINXED_II);
ListItem.SubItems.Add(PE_LIVEWIRE);
ListItem.SubItems.Add(PE_LIVING_ANATOMY);
ListItem.SubItems.Add(PE_MAN_OF_STEEL);
ListItem.SubItems.Add(PE_MELT_INTO_SHADOW);
ListItem.SubItems.Add(PE_MORE_CRITICALS);
ListItem.SubItems.Add(PE_MORE_RANGED_DAMAGE);
ListItem.SubItems.Add(PE_NEMEAN_ARMOR);
ListItem.SubItems.Add(PE_PHOENIX_IMPLANTS);
ListItem.SubItems.Add(PE_PHOENIX_IMPLANTS_ENH);
ListItem.SubItems.Add(PE_PYROMANIAC);
ListItem.SubItems.Add(PE_QUICK_POCKETS);
ListItem.SubItems.Add(PE_QUICK_RECOVERY);
ListItem.SubItems.Add(PE_RIGHT_BETWEEN_THE_EYES);
ListItem.SubItems.Add(PE_SHARPSHOOTER);
ListItem.SubItems.Add(PE_SILENT_DEATH);
ListItem.SubItems.Add(PE_SLAYER);
ListItem.SubItems.Add(PE_SNIPER);
ListItem.SubItems.Add(PE_SPRAY_AND_PRAY);
ListItem.SubItems.Add(PE_STEALTH_GIRL);
ListItem.SubItems.Add(PE_STONEWALL);
ListItem.SubItems.Add(PE_TERMINATOR);
ListItem.SubItems.Add(PE_TOUGHNESS);
ListItem.SubItems.Add(PE_TREE_TRUNK_THIGHS);
ListItem.SubItems.Add(PE_WEAPON_HANDLING);

ListItem.SubItems.Add(PE_FASTER_HEALING);
ListItem.SubItems.Add(PE_GHOST);
ListItem.SubItems.Add(PE_FIELD_MEDIC);
ListItem.SubItems.Add(PE_LIFEGIVER);
ListItem.SubItems.Add(PE_LIGHT_STEP);
ListItem.SubItems.Add(PE_MEDIC);

ListItem.SubItems.Add(ST_DEFAULT_ARMOR_PID);
ListItem.SubItems.Add(ST_DEFAULT_HELMET_PID);


ListItem.SubItems.Add(TRAIT_FAST_METABOLISM);
ListItem.SubItems.Add(TRAIT_BRUISER);
ListItem.SubItems.Add(TRAIT_SMALL_FRAME);
ListItem.SubItems.Add(TRAIT_ONE_HANDER);
ListItem.SubItems.Add(TRAIT_FINESSE);
ListItem.SubItems.Add(TRAIT_KAMIKAZE);
ListItem.SubItems.Add(TRAIT_HEAVY_HANDED);
ListItem.SubItems.Add(TRAIT_FAST_SHOT);
ListItem.SubItems.Add(TRAIT_BLOODY_MESS);
ListItem.SubItems.Add(TRAIT_JINXED);
ListItem.SubItems.Add(TRAIT_GOOD_NATURED);
ListItem.SubItems.Add(TRAIT_CHEM_RELIANT);
ListItem.SubItems.Add(TRAIT_CHEM_RESISTANT);
ListItem.SubItems.Add(TRAIT_BONEHEAD);
ListItem.SubItems.Add(TRAIT_SKILLED);
ListItem.SubItems.Add(TRAIT_LONER);



    if Assigned(ListView1.Items[ListView1.ItemIndex-1]) then
    begin
      ListView1.Items[ListView1.ItemIndex-1].Focused:=True;
      ListView1.Items[ListView1.ItemIndex-1].Selected:=True;
    end;
  end;

//  if Pid='' then Button2.Enabled:=False;  // po dodaniu nowego crittera przycisk Save to file musi byc zdeaktywoany, bo nie ma numeru PID i sie wywali blad
  if Pid='' then BitBtn8.Enabled:=False;  // po dodaniu nowego crittera przycisk Save to file musi byc zdeaktywoany, bo nie ma numeru PID i sie wywali blad
end;


{
procedure TForm1.Edit34Change(Sender: TObject);
var plik:TextFile;
    linia:String;
    numerek:String;
    numer_frm:String;

    archiwum:TZipForge;
    lokal_znalazlem_obrazek:boolean;
    znak:String[1];
begin
  lokal_STOP_FOR_SAVE:=True;
  lokal_znalazlem_obrazek:=False;
  numer_frm:=IntToStr(UpDown18.Position);

  AssignFile(plik,path_CritterTypes_cfg);
  reset(plik);
  While not Eof(plik) do
  begin
    Readln(plik,linia);
    linia:=Trim(linia);
    if length(linia)>0 then znak:=linia[1];
    if znak='@' then
    begin
      lokal_znalazlem_obrazek:=true;
      Delete(linia,1,1);
      linia:=Trim(linia);
      numerek:=Copy(linia,1,3);
      numerek:=Trim(numerek);

      if numerek=numer_frm then
      begin
        Delete(linia,1,3);
        linia:=Trim(linia);
        nazwa_frm:=Copy(linia,1,Pos(' ',linia));
        nazwa_frm:=Trim(nazwa_frm);

        // Create an instance of the TZipForge class
        archiwum := TZipForge.Create(nil);
        try
          with archiwum do
          begin
            // The name of the archive file
            // from which we want to extract file
//            FileName := ExtractFilePath(Application.ExeName) + 'frm_critters.zip';
            FileName := ExtractFilePath(Application.ExeName) + 'critter_editor.dat';
            // Because we extract file from an existing archive,
            // we set Mode to fmOpenRead
            OpenArchive(fmOpenRead);
            // Set base (default) directory for all archive operations
            BaseDir := ExtractFilePath(Application.ExeName)+'pliki\';
            // Extract test.txt file from the archive
            // to the default directory
            ExtractFiles(nazwa_frm+'aa.png');
            ExtractFiles('reservaa.png');
            CloseArchive();
          end;
          except
          on E: Exception do
          begin
            ShowMessage('Exception: ' + E.Message);
            // Wait for the key to be pressed
          end;
        end;


        with Image1 do
        begin
          if FileExists(ExtractFilePath(Application.ExeName)+'pliki\frm_critters\'+nazwa_frm+'aa.png') then
            Picture.LoadFromFile(ExtractFilePath(Application.ExeName)+'pliki\frm_critters\'+nazwa_frm+'aa.png')
          else
            Picture.LoadFromFile(ExtractFilePath(Application.ExeName)+'pliki\frm_critters\reservaa.png');
        end;

        if FileExists(ExtractFilePath(Application.ExeName)+'pliki\frm_critters\reservaa.png') then
          DeleteFile(ExtractFilePath(Application.ExeName)+'pliki\frm_critters\reservaa.png');

        if FileExists(ExtractFilePath(Application.ExeName)+'pliki\frm_critters\'+nazwa_frm+'aa.png') then
          DeleteFile(ExtractFilePath(Application.ExeName)+'pliki\frm_critters\'+nazwa_frm+'aa.png');


        if not RemoveDir(ExtractFilePath(Application.ExeName)+'pliki\frm_critters') then
        begin
          ShowMessage('Could not delete folder: ' + ExtractFilePath(Application.ExeName)+'pliki\frm_critters');
        end;

        if not RemoveDir(ExtractFilePath(Application.ExeName)+'pliki') then
        begin
          ShowMessage('Could not delete folder: ' + ExtractFilePath(Application.ExeName)+'pliki');
        end;

        Label42.Caption:=nazwa_frm;
      end;
    end
    else
    begin
      if lokal_znalazlem_obrazek=false then
      begin
        Image1.Picture:=nil;
        Label42.Caption:='selected frm not exists';
      end;
    end;
  end;

  CloseFile(plik);
end;
}

procedure TForm1.Edit34Change(Sender: TObject);
var plik:TextFile;
    linia:String;
    numerek:String;
    numer_frm:String;


    TargetFolder : String;
    X            : Integer;
    Path         : String;
    FN           : String;
    //UnZip1: TUnZip;

    lokal_znalazlem_obrazek:boolean;
    znak:String[1];
    tab_znakow:Array [1..24] of String; // tablica od nazwy (hmjmps) do O ( jako Rifle)
    znaczek:String; // zmienna pomocnicza
    i:Byte;


begin
  // zerowanie tablicy i czyszczenie checkboxow
  for i:=1 to 23 do
  begin
    tab_znakow[i]:='0';
    case i of
    10 : if tab_znakow[i]='1' then CheckBox40.Checked:=True else CheckBox40.Checked:=False;
    11,12: begin end;
    13: if tab_znakow[i]='1' then CheckBox41.Checked:=True else CheckBox41.Checked:=False;
    14: if tab_znakow[i]='1' then CheckBox42.Checked:=True else CheckBox42.Checked:=False;
    15: if tab_znakow[i]='1' then CheckBox43.Checked:=True else CheckBox43.Checked:=False;
    16: if tab_znakow[i]='1' then CheckBox44.Checked:=True else CheckBox44.Checked:=False;
    17: if tab_znakow[i]='1' then CheckBox45.Checked:=True else CheckBox45.Checked:=False;
    18: if tab_znakow[i]='1' then CheckBox46.Checked:=True else CheckBox46.Checked:=False;
    19: if tab_znakow[i]='1' then CheckBox47.Checked:=True else CheckBox47.Checked:=False;
    20: if tab_znakow[i]='1' then CheckBox48.Checked:=True else CheckBox48.Checked:=False;
    21: if tab_znakow[i]='1' then CheckBox49.Checked:=True else CheckBox49.Checked:=False;
    22: if tab_znakow[i]='1' then CheckBox50.Checked:=True else CheckBox50.Checked:=False;
    23: if tab_znakow[i]='1' then CheckBox51.Checked:=True else CheckBox51.Checked:=False;

    end;
  end;



      if not FileExists(ExtractFilePath(Application.ExeName)+'pliki\frm_critters\reservaa.png') then
      begin
        //KAZip1.Active:=True;
        Kazip1.Open(ExtractFilePath(Application.ExeName) + 'critter_editor.dat');
        TargetFolder:=ExtractFilePath(Application.ExeName)+'pliki'; //Targetfolder:=GetCurrentDir;
        if TargetFolder <> '' then
        begin
          for X := 0 to KAZip1.Entries.Count-1 Do
          begin
            if (KAZip1.Entries.Items[X].Attributes and faDirectory)=0 Then
            begin
              Path := StringReplace(KAZip1.Entries.Items[X].FileName,'/','\',[rfReplaceAll]);
              FN   := ExtractFileName(Path);
              Path := ExtractFilePath(Path);
              if Path <> '' Then
              begin
                ForceDirectories(TargetFolder+'\'+Path);
                KAZip1.Entries.Items[X].ExtractToFile(TargetFolder+'\'+Path+FN);
              end
              else
              begin
                try
                  KAZip1.Entries.Items[X].ExtractToFile(TargetFolder+'\'+FN);
                except
                end;
              end;
            end;
          end;
        end;
        KAZip1.Close;
      end;



  lokal_STOP_FOR_SAVE:=True;
  lokal_znalazlem_obrazek:=False;
  numer_frm:=IntToStr(UpDown18.Position);

  AssignFile(plik,path_CritterTypes_cfg);
  reset(plik);
  While not Eof(plik) do
  begin
    Readln(plik,linia);
    linia:=Trim(linia);
    if length(linia)>0 then znak:=linia[1];
    if znak='@' then
    begin
      lokal_znalazlem_obrazek:=true;
      Delete(linia,1,1);
      linia:=Trim(linia);
      numerek:=Copy(linia,1,3);
      numerek:=Trim(numerek);

      if numerek=numer_frm then
      begin

//#    Nr    Name    Alias MH Tp Wk Rn Am Ar Rt   A B C D E F G H I J K L M N O P Q R S T U V W X Y Z   Walk  Run   Walk steps Sound name
//@    0    hmjmps      0   0  0  1  1  1  1  1   1 0 0 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 0 0 0 0 0 0 0 0   400  200   4  8  0  0     -
        Delete(linia,1,3);
        linia:=Trim(linia);   // linia == 'hmjmps      0   0  0  1  1  1  1  1   1 0 0 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 0 0 0 0 0 0 0 0   400  200   4  8  0  0     -'

        nazwa_frm:=Copy(linia,1,Pos(' ',linia));
        nazwa_frm:=Trim(nazwa_frm);
        tab_znakow[1]:=nazwa_frm;

        Delete(linia,1,length(nazwa_frm));
        linia:=Trim(linia);   // linia == '0   0  0  1  1  1  1  1   1 0 0 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 0 0 0 0 0 0 0 0   400  200   4  8  0  0     -'
        znaczek:=Copy(linia,1,Pos(' ',linia));
        tab_znakow[2]:=Trim(znaczek);

        for i:=3 to 24 do
        begin
          Delete(linia,1,length(znaczek));
          linia:=Trim(linia);   // linia == '0   0  0  1  1  1  1  1   1 0 0 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 0 0 0 0 0 0 0 0   400  200   4  8  0  0     -'
          znaczek:=Copy(linia,1,Pos(' ',linia));
          tab_znakow[i]:=Trim(znaczek);
        end;


        for i:=10 to 23 do
        begin
        case i of
        10 : if tab_znakow[i]='1' then CheckBox40.Checked:=True else CheckBox40.Checked:=False;
        11,12: begin end;
        13: if tab_znakow[i]='1' then CheckBox41.Checked:=True else CheckBox41.Checked:=False;
        14: if tab_znakow[i]='1' then CheckBox42.Checked:=True else CheckBox42.Checked:=False;
        15: if tab_znakow[i]='1' then CheckBox43.Checked:=True else CheckBox43.Checked:=False;
        16: if tab_znakow[i]='1' then CheckBox44.Checked:=True else CheckBox44.Checked:=False;
        17: if tab_znakow[i]='1' then CheckBox45.Checked:=True else CheckBox45.Checked:=False;
        18: if tab_znakow[i]='1' then CheckBox46.Checked:=True else CheckBox46.Checked:=False;
        19: if tab_znakow[i]='1' then CheckBox47.Checked:=True else CheckBox47.Checked:=False;
        20: if tab_znakow[i]='1' then CheckBox48.Checked:=True else CheckBox48.Checked:=False;
        21: if tab_znakow[i]='1' then CheckBox49.Checked:=True else CheckBox49.Checked:=False;
        22: if tab_znakow[i]='1' then CheckBox50.Checked:=True else CheckBox50.Checked:=False;
        23: if tab_znakow[i]='1' then CheckBox51.Checked:=True else CheckBox51.Checked:=False;
        end;
        end;



        with Image1 do
        begin
          if FileExists(ExtractFilePath(Application.ExeName)+'pliki\frm_critters\'+nazwa_frm+'aa.png') then
            Picture.LoadFromFile(ExtractFilePath(Application.ExeName)+'pliki\frm_critters\'+nazwa_frm+'aa.png')
          else
            Picture.LoadFromFile(ExtractFilePath(Application.ExeName)+'pliki\frm_critters\reservaa.png');
        end;


        Label42.Caption:=nazwa_frm;
      end;
    end
    else
    begin
      if lokal_znalazlem_obrazek=false then
      begin
        Image1.Picture:=nil;
        Label42.Caption:='selected frm not exists';
      end;
    end;
  end;
  CloseFile(plik);

{

        if FileExists(ExtractFilePath(Application.ExeName)+'pliki\frm_critters\reservaa.png') then
          DeleteFile(ExtractFilePath(Application.ExeName)+'pliki\frm_critters\reservaa.png');
        if FileExists(ExtractFilePath(Application.ExeName)+'pliki\frm_critters\'+nazwa_frm+'aa.png') then
          DeleteFile(ExtractFilePath(Application.ExeName)+'pliki\frm_critters\'+nazwa_frm+'aa.png');


        if not RemoveDir(ExtractFilePath(Application.ExeName)+'pliki\frm_critters') then
        begin
          ShowMessage('Could not delete folder: ' + ExtractFilePath(Application.ExeName)+'pliki\frm_critters');
        end;

        if not RemoveDir(ExtractFilePath(Application.ExeName)+'pliki') then
        begin
          ShowMessage('Could not delete folder: ' + ExtractFilePath(Application.ExeName)+'pliki');
        end;
}
end;



// STATs - SPECIAL
procedure TForm1.Edit1Change(Sender: TObject);     // ST
begin
  lokal_STOP_FOR_SAVE:=True;

  Edit8.Text:=IntToStr(15 + StrToInt(Edit1.Text)+StrToInt(Edit3.Text)*2); // Hit Points
  if isHumanoid(ComboBox1.ItemIndex)=True then Edit8.Text:=IntToStr(15 + 40 + StrToInt(Edit1.Text)+StrToInt(Edit3.Text)*2); // Hit Points

  if StrToInt(Edit1.Text)>6 then
    Edit11.Text:=IntToStr(StrToInt(Edit1.Text)-5) // Melee Damage
  else
    Edit11.Text:='1';

  Edit12.Text:=IntToStr(453*(25 + StrToInt(Edit1.Text)*25));  //Carry weight

  Edit24.Text:=IntToStr(StrToInt(Edit8.Text)+StrToInt(Edit16.Text)); //kilgore zmienil +15 w pliku _parameters.fos w dniu 8.12.2010 rev 408 na wartosc +20 ale tutaj narazie do czasu rozstrzygniecia niech bedzie jak w oryginale +15

  Edit27.Text:=IntToStr(StrToInt(Edit11.Text)+StrToInt(Edit19.Text));
  Edit28.Text:=IntToStr(StrToInt(Edit12.Text)+StrToInt(Edit20.Text));

  Edit44.Text:=IntToStr(30+2*(StrToInt(Edit6.Text) + StrToInt(Edit1.Text)));//_param_[SK_UNARMED]+=30+2*(_param_[ST_AGILITY]+_param_[ST_STRENGTH]);

  // cubik: 30.12.2015: zamiana SK_MELEE_WEAPONS na SK_SCAVENGING dla mojuka, wartosc bazowa ma byc zawsze = 0
  //Edit45.Text:=IntToStr(20+2*(StrToInt(Edit6.Text) + StrToInt(Edit1.Text)));//_param_[SK_SCAVENGING]+=20+2*(_param_[ST_AGILITY]+_param_[ST_STRENGTH]);
  Edit45.Text:='0';

end;


procedure TForm1.Edit2Change(Sender: TObject);  // PE
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit13.Text:=IntToStr(StrToInt(Edit2.Text)*2); // Sequence
  Edit29.Text:=IntToStr(StrToInt(Edit13.Text)+StrToInt(Edit21.Text));

  Edit47.Text:=IntToStr(0+2*(StrToInt(Edit2.Text) + StrToInt(Edit5.Text)));//_param_[SK_FIRST_AID]+=0+2*(_param_[ST_PERCEPTION]+_param_[ST_INTELLECT]);
  Edit48.Text:=IntToStr(5+(StrToInt(Edit2.Text) + StrToInt(Edit5.Text)));//_param_[SK_DOCTOR]+=5+_param_[ST_PERCEPTION]+_param_[ST_INTELLECT];

  Edit50.Text:=IntToStr(10+(StrToInt(Edit2.Text)+StrToInt(Edit6.Text)));//_param_[SK_LOCKPICK]+=10+_param_[ST_PERCEPTION]+_param_[ST_AGILITY];
  Edit52.Text:=IntToStr(10+(StrToInt(Edit2.Text)+StrToInt(Edit6.Text)));//_param_[SK_TRAPS]+=10+_param_[ST_PERCEPTION]+_param_[ST_AGILITY];


end;


procedure TForm1.Edit3Change(Sender: TObject);      // ENdurance
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit8.Text:=IntToStr(15 + StrToInt(Edit1.Text)+StrToInt(Edit3.Text)*2); // Hit Points
  if isHumanoid(ComboBox1.ItemIndex)=True then Edit8.Text:=IntToStr(15 + 40 + StrToInt(Edit1.Text)+StrToInt(Edit3.Text)*2); // Hit Points
  
  Edit14.Text:=IntToStr(Max(1,StrToInt(Edit3.Text) div 3));  // Healin Rate

  Edit24.Text:=IntToStr(StrToInt(Edit8.Text)+StrToInt(Edit16.Text)); //kilgore zmienil +15 w pliku _parameters.fos w dniu 8.12.2010 rev 408 na wartosc +20 ale tutaj narazie do czasu rozstrzygniecia niech bedzie jak w oryginale +15
  Edit30.Text:=IntToStr(StrToInt(Edit14.Text)+StrToInt(Edit22.Text));

  Edit58.Text:=IntToStr(0+2*(StrToInt(Edit3.Text) + StrToInt(Edit5.Text)));;//_param_[SK_OUTDOORSMAN]+=0+2*(_param_[ST_ENDURANCE]+_param_[ST_INTELLECT]);

  Edit80.Text:=IntToStr(0+2*(StrToInt(Edit3.Text))); //_param_[ST_RADIATION_RESISTANCE]+=_param_[ST_ENDURANCE]*2;
  Edit113.Text:=IntToStr(0+5*(StrToInt(Edit3.Text)));//_param_[ST_POISON_RESISTANCE]+=_param_[ST_ENDURANCE]*5;

end;


procedure TForm1.Edit4Change(Sender: TObject);   // Charisma
begin
  lokal_STOP_FOR_SAVE:=True;
// od charyzmy sa zmiany tlyko do speech i barter skilla
 	Edit55.Text:=IntToStr(0+5*(StrToInt(Edit4.Text)));//_param_[SK_SPEECH]+=0+5*_param_[ST_CHARISMA];
 	Edit56.Text:=IntToStr(0+4*(StrToInt(Edit4.Text)));//_param_[SK_BARTER]+=0+4*_param_[ST_CHARISMA];
end;


procedure TForm1.Edit5Change(Sender: TObject);   // IN
begin
  lokal_STOP_FOR_SAVE:=True;
// od inteligencji zmieniaja sie tylko skille
  Edit47.Text:=IntToStr(0+2*(StrToInt(Edit2.Text) + StrToInt(Edit5.Text)));//_param_[SK_FIRST_AID]+=0+2*(_param_[ST_PERCEPTION]+_param_[ST_INTELLECT]);
  Edit48.Text:=IntToStr(5+(StrToInt(Edit2.Text) + StrToInt(Edit5.Text)));//_param_[SK_DOCTOR]+=5+_param_[ST_PERCEPTION]+_param_[ST_INTELLECT];

  Edit53.Text:=IntToStr(0+4*(StrToInt(Edit5.Text)));//_param_[SK_SCIENCE]+=0+4*_param_[ST_INTELLECT];
  Edit54.Text:=IntToStr(0+3*(StrToInt(Edit5.Text)));//_param_[SK_REPAIR]+=0+3*_param_[ST_INTELLECT];

  Edit58.Text:=IntToStr(0+2*(StrToInt(Edit3.Text) + StrToInt(Edit5.Text)));;//_param_[SK_OUTDOORSMAN]+=0+2*(_param_[ST_ENDURANCE]+_param_[ST_INTELLECT]);

end;


procedure TForm1.Edit6Change(Sender: TObject);   // Agility
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit9.Text:=IntToStr(5 + StrToInt(Edit6.Text) div 2);  // Action Points
  Edit10.Text:=IntToStr(3 * StrToInt(Edit6.Text));; // Armor Class

  Edit25.Text:=IntToStr(StrToInt(Edit9.Text)+StrToInt(Edit17.Text));
  Edit26.Text:=IntToStr(StrToInt(Edit10.Text)+StrToInt(Edit18.Text));



  Edit41.Text:=IntToStr(5+4*StrToInt(Edit6.Text));//_param_[SK_SMALL_GUNS]+=5+4*_param_[ST_AGILITY];
  Edit42.Text:=IntToStr(0+2*StrToInt(Edit6.Text));//_param_[SK_BIG_GUNS]+=0+2*_param_[ST_AGILITY];
  Edit43.Text:=IntToStr(0+2*StrToInt(Edit6.Text));//_param_[SK_ENERGY_WEAPONS]+=0+2*_param_[ST_AGILITY];

  Edit44.Text:=IntToStr(30+2*(StrToInt(Edit6.Text) + StrToInt(Edit1.Text)));//_param_[SK_UNARMED]+=30+2*(_param_[ST_AGILITY]+_param_[ST_STRENGTH]);

    // cubik: 30.12.2015: zamiana SK_MELEE_WEAPONS na SK_SCAVENGING dla mojuka, wartosc bazowa ma byc zawsze = 0
  //Edit45.Text:=IntToStr(20+2*(StrToInt(Edit6.Text) + StrToInt(Edit1.Text)));//_param_[SK_SCAVENGING]+=20+2*(_param_[ST_AGILITY]+_param_[ST_STRENGTH]);
  Edit45.Text:='0';
  //Edit45.Text:=IntToStr(20+2*(StrToInt(Edit6.Text) + StrToInt(Edit1.Text)));//_param_[SK_SCAVENGING]+=20+2*(_param_[ST_AGILITY]+_param_[ST_STRENGTH]);

  Edit46.Text:=IntToStr(0+4*StrToInt(Edit6.Text));//_param_[SK_THROWING]+=0+4*_param_[ST_AGILITY];
  Edit49.Text:=IntToStr(5+3*(StrToInt(Edit6.Text)));//_param_[SK_SNEAK]+=5+3*_param_[ST_AGILITY];
  Edit51.Text:=IntToStr(0+3*(StrToInt(Edit6.Text)));//_param_[SK_STEAL]+=0+3*_param_[ST_AGILITY];

  Edit50.Text:=IntToStr(10+(StrToInt(Edit2.Text)+StrToInt(Edit6.Text)));//_param_[SK_LOCKPICK]+=10+_param_[ST_PERCEPTION]+_param_[ST_AGILITY];
  Edit52.Text:=IntToStr(10+(StrToInt(Edit2.Text)+StrToInt(Edit6.Text)));//_param_[SK_TRAPS]+=10+_param_[ST_PERCEPTION]+_param_[ST_AGILITY];

end;


procedure TForm1.Edit7Change(Sender: TObject);      // Luck
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit15.Text:=Edit7.Text;  // Critical Chance
  Edit31.Text:=IntToStr(StrToInt(Edit15.Text)+StrToInt(Edit23.Text));

  Edit57.Text:=IntToStr(0+5*(StrToInt(Edit7.Text)));//_param_[SK_GAMBLING]+=0+5*_param_[ST_LUCK];

end;





procedure TForm1.Edit16Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;

  Edit8.Text:=IntToStr(15 + StrToInt(Edit1.Text)+StrToInt(Edit3.Text)*2); // Hit Points
  if isHumanoid(ComboBox1.ItemIndex)=True then Edit8.Text:=IntToStr(15 + 40 + StrToInt(Edit1.Text)+StrToInt(Edit3.Text)*2); // Hit Points

  Edit24.Text:=IntToStr(StrToInt(Edit8.Text)+StrToInt(Edit16.Text)); //kilgore zmienil +15 w pliku _parameters.fos w dniu 8.12.2010 rev 408 na wartosc +20 ale tutaj narazie do czasu rozstrzygniecia niech bedzie jak w oryginale +15
end;

procedure TForm1.Edit17Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit25.Text:=IntToStr(StrToInt(Edit9.Text)+StrToInt(Edit17.Text));
end;

procedure TForm1.Edit18Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit26.Text:=IntToStr(StrToInt(Edit10.Text)+StrToInt(Edit18.Text));
  Edit36.Text:=Edit18.Text;  
end;

procedure TForm1.Edit19Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit27.Text:=IntToStr(StrToInt(Edit11.Text)+StrToInt(Edit19.Text));
end;

procedure TForm1.Edit20Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit28.Text:=IntToStr(StrToInt(Edit12.Text)+StrToInt(Edit20.Text));
end;

procedure TForm1.Edit21Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit29.Text:=IntToStr(StrToInt(Edit13.Text)+StrToInt(Edit21.Text));
end;

procedure TForm1.Edit22Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit30.Text:=IntToStr(StrToInt(Edit14.Text)+StrToInt(Edit22.Text));
end;

procedure TForm1.Edit23Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit31.Text:=IntToStr(StrToInt(Edit15.Text)+StrToInt(Edit23.Text));
end;


//############################################################
//#######################  ShowSelected ######################
//############################################################
procedure TForm1.ShowSelected(Item:TListItem);          // ShowSelected
var aktywny_arkusz:Integer;
begin
  aktywny_arkusz:=PageControl1.ActivePageIndex;

  if Assigned(Item) then
  begin
//    PageControl1.ActivePageIndex:=0;

    Edit38.Text:=Trim(Item.Caption);  // opis crittera

    //SpinEdit0.Value:=Trim(Item.SubItems.Strings[0]);   //PID
//    UpDown42.Position:=StrToInt(Trim(Item.SubItems.Strings[0]));// PID               SpinEdit0
    SpinEdit0.Value:=StrToInt(Trim(Item.SubItems.Strings[0]));// PID               SpinEdit0

    Edit37.Text:=Trim(Item.SubItems.Strings[1]);  // nazwa crittera

    StatusBar1.SimpleText:='Selected critter:   ' + '[' + IntToStr(SpinEdit0.Value) + ']     ' + Edit37.Text + '      ' + Edit38.Text;



   //Edit1.Text:=Trim(Item.SubItems.Strings[4]);   //ST
    UpDown1.Position:=StrToInt(Trim(Item.SubItems.Strings[4]));// ST               Edit1
    //Edit2.Text:=Trim(Item.SubItems.Strings[5]);   //PE
    UpDown2.Position:=StrToInt(Trim(Item.SubItems.Strings[5]));// PE               Edit2
    //Edit3.Text:=Trim(Item.SubItems.Strings[6]);   //EN
    UpDown3.Position:=StrToInt(Trim(Item.SubItems.Strings[6]));// EN               Edit3
    //Edit4.Text:=Trim(Item.SubItems.Strings[7]);   //CH
    UpDown4.Position:=StrToInt(Trim(Item.SubItems.Strings[7]));// CH               Edit4
    //Edit5.Text:=Trim(Item.SubItems.Strings[8]);   //IN
    UpDown5.Position:=StrToInt(Trim(Item.SubItems.Strings[8]));// IN               Edit5
    //Edit6.Text:=Trim(Item.SubItems.Strings[9]);   //AG
    UpDown6.Position:=StrToInt(Trim(Item.SubItems.Strings[9]));// AG               Edit6
    //Edit7.Text:=Trim(Item.SubItems.Strings[10]);  //LK
    UpDown7.Position:=StrToInt(Trim(Item.SubItems.Strings[10]));//LK               Edit7

// 05-02-2014: przeniesione nizej poza linie odczytu Body type, w celu usatlenia poprawnej ilosci HP
//    Edit8.Text:=IntToStr(15 + StrToInt(Edit1.Text)+StrToInt(Edit3.Text)*2); // Hit Points   //kilgore zmienil +15 w pliku _parameters.fos w dniu 8.12.2010 rev 408 na wartosc +20 // w oryginale jest +15
//	  if isHumanoid(ComboBox1.ItemIndex)=True then Edit8.Text:=IntToStr(15 + 40 + StrToInt(Edit1.Text)+StrToInt(Edit3.Text)*2); // Hit Points

    Edit9.Text:=IntToStr(5 + StrToInt(Edit6.Text) div 2);  // Action Points
    Edit10.Text:=IntToStr(3 * StrToInt(Edit6.Text));; // Armor Class

    if StrToInt(Edit1.Text)>6 then
      Edit11.Text:=IntToStr(StrToInt(Edit1.Text)-5) // Melee Damage
    else
      Edit11.Text:='1';

    Edit12.Text:=IntToStr(453*(25 + StrToInt(Edit1.Text)*25));  //Carry weight

    Edit13.Text:=IntToStr(StrToInt(Edit2.Text)*2); // Sequence

    Edit14.Text:=IntToStr(Max(1,StrToInt(Edit3.Text) div 3));  // Healin Rate

    Edit15.Text:=Edit7.Text;  // Critical Chance



    //Edit33.Text:=Trim(Item.SubItems.Strings[11]); //Exp
    UpDown17.Position:=StrToInt(Trim(Item.SubItems.Strings[11]));//Exp               Edit33

    //Edit16.Text:=Trim(Item.SubItems.Strings[12]); //HP ext
    UpDown8.Position:=StrToInt(Trim(Item.SubItems.Strings[12]));//HP ext               Edit16

    //Edit17.Text:=Trim(Item.SubItems.Strings[13]);
    UpDown9.Position:=StrToInt(Trim(Item.SubItems.Strings[13]));//HP ext               Edit17
    //Edit18.Text:=Trim(Item.SubItems.Strings[14]);
    UpDown10.Position:=StrToInt(Trim(Item.SubItems.Strings[14]));//HP ext               Edit18
    //Edit19.Text:=Trim(Item.SubItems.Strings[15]);
    UpDown11.Position:=StrToInt(Trim(Item.SubItems.Strings[15]));//HP ext               Edit19
    //Edit20.Text:=Trim(Item.SubItems.Strings[16]);
    UpDown12.Position:=StrToInt(Trim(Item.SubItems.Strings[16]));//HP ext               Edit20
    //Edit21.Text:=Trim(Item.SubItems.Strings[17]);
    UpDown13.Position:=StrToInt(Trim(Item.SubItems.Strings[17]));//HP ext               Edit21
    //Edit22.Text:=Trim(Item.SubItems.Strings[18]);
    UpDown14.Position:=StrToInt(Trim(Item.SubItems.Strings[18]));//HP ext               Edit22
    //Edit23.Text:=Trim(Item.SubItems.Strings[19]);
    UpDown15.Position:=StrToInt(Trim(Item.SubItems.Strings[19]));//HP ext               Edit23

    Edit24.Text:=IntToStr(StrToInt(Edit8.Text)+StrToInt(Edit16.Text));
    Edit25.Text:=IntToStr(StrToInt(Edit9.Text)+StrToInt(Edit17.Text));
    Edit26.Text:=IntToStr(StrToInt(Edit10.Text)+StrToInt(Edit18.Text));
    Edit27.Text:=IntToStr(StrToInt(Edit11.Text)+StrToInt(Edit19.Text));
    Edit28.Text:=IntToStr(StrToInt(Edit12.Text)+StrToInt(Edit20.Text));
    Edit29.Text:=IntToStr(StrToInt(Edit13.Text)+StrToInt(Edit21.Text));
    Edit30.Text:=IntToStr(StrToInt(Edit14.Text)+StrToInt(Edit22.Text));
    Edit31.Text:=IntToStr(StrToInt(Edit15.Text)+StrToInt(Edit23.Text));


    if Trim(Item.SubItems.Strings[20])<>'' then
      ComboBox1.ItemIndex:=StrToInt(Trim(Item.SubItems.Strings[20]));

    Edit8.Text:=IntToStr(15 + StrToInt(Edit1.Text)+StrToInt(Edit3.Text)*2); // Hit Points   //kilgore zmienil +15 w pliku _parameters.fos w dniu 8.12.2010 rev 408 na wartosc +20 // w oryginale jest +15
	  if isHumanoid(ComboBox1.ItemIndex)=True then Edit8.Text:=IntToStr(15 + 40 + StrToInt(Edit1.Text)+StrToInt(Edit3.Text)*2); // Hit Points


    if Trim(Item.SubItems.Strings[21])<>'' then
      ComboBox2.ItemIndex:=StrToInt(Trim(Item.SubItems.Strings[21]));

    if Trim(Item.SubItems.Strings[23])<>'' then
      ComboBox4.ItemIndex:=StrToInt(Trim(Item.SubItems.Strings[23]));

//    Edit34.Text:=Trim(Item.SubItems.Strings[2]); if Edit34.Text='' then Edit34.Text:='0';
    if Trim(Item.SubItems.Strings[2])='' then Item.SubItems.Strings[2]:='0'; UpDown18.Position:=StrToInt(Trim(Item.SubItems.Strings[2]));// critter animation     Edit34

//    Edit36.Text:=Trim(Item.SubItems.Strings[26]);
    if Trim(Item.SubItems.Strings[26])<>'' then
      ComboBox5.ItemIndex:=StrToInt(Trim(Item.SubItems.Strings[26]));        //AI ID


    SpinEdit40.Value:=StrToInt(Trim(Item.SubItems.Strings[61]));  //DialogID
    SpinEdit59.Value:=StrToInt(Trim(Item.SubItems.Strings[62]));  //BagID
//    Edit39.Text:=Trim(Item.SubItems.Strings[61]);  //TeamID
    if Trim(Item.SubItems.Strings[63])<>'' then
      ComboBox6.ItemIndex:=StrToInt(Trim(Item.SubItems.Strings[63]));


//    PageControl1.ActivePageIndex:=1;
//    skills appendix  from critter proto
    UpDown23.Position:=StrToInt(Trim(Item.SubItems.Strings[27]));
    UpDown24.Position:=StrToInt(Trim(Item.SubItems.Strings[28]));
    UpDown25.Position:=StrToInt(Trim(Item.SubItems.Strings[29]));
    UpDown26.Position:=StrToInt(Trim(Item.SubItems.Strings[30]));
    UpDown27.Position:=StrToInt(Trim(Item.SubItems.Strings[31]));
    UpDown28.Position:=StrToInt(Trim(Item.SubItems.Strings[32]));
    UpDown29.Position:=StrToInt(Trim(Item.SubItems.Strings[33]));
    UpDown30.Position:=StrToInt(Trim(Item.SubItems.Strings[34]));
    UpDown31.Position:=StrToInt(Trim(Item.SubItems.Strings[35]));
    UpDown32.Position:=StrToInt(Trim(Item.SubItems.Strings[36]));
    UpDown33.Position:=StrToInt(Trim(Item.SubItems.Strings[37]));
    UpDown34.Position:=StrToInt(Trim(Item.SubItems.Strings[38]));
    UpDown35.Position:=StrToInt(Trim(Item.SubItems.Strings[39]));
    UpDown36.Position:=StrToInt(Trim(Item.SubItems.Strings[40]));
    UpDown37.Position:=StrToInt(Trim(Item.SubItems.Strings[41]));
    UpDown38.Position:=StrToInt(Trim(Item.SubItems.Strings[42]));
    UpDown39.Position:=StrToInt(Trim(Item.SubItems.Strings[43]));
    UpDown40.Position:=StrToInt(Trim(Item.SubItems.Strings[44]));


// calculate Skills

    Edit41.Text:=IntToStr(5+4*StrToInt(Edit6.Text));//_param_[SK_SMALL_GUNS]+=5+4*_param_[ST_AGILITY];
    Edit42.Text:=IntToStr(0+2*StrToInt(Edit6.Text));//_param_[SK_BIG_GUNS]+=0+2*_param_[ST_AGILITY];
    Edit43.Text:=IntToStr(0+2*StrToInt(Edit6.Text));//_param_[SK_ENERGY_WEAPONS]+=0+2*_param_[ST_AGILITY];
    Edit44.Text:=IntToStr(30+2*(StrToInt(Edit6.Text) + StrToInt(Edit1.Text)));//_param_[SK_UNARMED]+=30+2*(_param_[ST_AGILITY]+_param_[ST_STRENGTH]);

    //Edit45.Text:=IntToStr(20+2*(StrToInt(Edit6.Text) + StrToInt(Edit1.Text)));//_param_[SK_SCAVENGING]+=20+2*(_param_[ST_AGILITY]+_param_[ST_STRENGTH]);
      // cubik: 30.12.2015: zamiana SK_MELEE_WEAPONS na SK_SCAVENGING dla mojuka, wartosc bazowa ma byc zawsze = 0
    //Edit45.Text:=IntToStr(20+2*(StrToInt(Edit6.Text) + StrToInt(Edit1.Text)));//_param_[SK_SCAVENGING]+=20+2*(_param_[ST_AGILITY]+_param_[ST_STRENGTH]);
    Edit45.Text:='0';


    Edit46.Text:=IntToStr(0+4*StrToInt(Edit6.Text));//_param_[SK_THROWING]+=0+4*_param_[ST_AGILITY];

    Edit47.Text:=IntToStr(0+2*(StrToInt(Edit2.Text) + StrToInt(Edit5.Text)));//_param_[SK_FIRST_AID]+=0+2*(_param_[ST_PERCEPTION]+_param_[ST_INTELLECT]);
    Edit48.Text:=IntToStr(5+(StrToInt(Edit2.Text) + StrToInt(Edit5.Text)));//_param_[SK_DOCTOR]+=5+_param_[ST_PERCEPTION]+_param_[ST_INTELLECT];

    Edit49.Text:=IntToStr(5+3*(StrToInt(Edit6.Text)));//_param_[SK_SNEAK]+=5+3*_param_[ST_AGILITY];
    Edit50.Text:=IntToStr(10+(StrToInt(Edit2.Text)+StrToInt(Edit6.Text)));//_param_[SK_LOCKPICK]+=10+_param_[ST_PERCEPTION]+_param_[ST_AGILITY];
    Edit51.Text:=IntToStr(0+3*(StrToInt(Edit6.Text)));//_param_[SK_STEAL]+=0+3*_param_[ST_AGILITY];
    Edit52.Text:=IntToStr(10+(StrToInt(Edit2.Text)+StrToInt(Edit6.Text)));//_param_[SK_TRAPS]+=10+_param_[ST_PERCEPTION]+_param_[ST_AGILITY];

    Edit53.Text:=IntToStr(0+4*(StrToInt(Edit5.Text)));//_param_[SK_SCIENCE]+=0+4*_param_[ST_INTELLECT];
    Edit54.Text:=IntToStr(0+3*(StrToInt(Edit5.Text)));//_param_[SK_REPAIR]+=0+3*_param_[ST_INTELLECT];

    Edit55.Text:=IntToStr(0+5*(StrToInt(Edit4.Text)));//_param_[SK_SPEECH]+=0+5*_param_[ST_CHARISMA];
    Edit56.Text:=IntToStr(0+4*(StrToInt(Edit4.Text)));//_param_[SK_BARTER]+=0+4*_param_[ST_CHARISMA];

    Edit57.Text:=IntToStr(0+5*(StrToInt(Edit7.Text)));//_param_[SK_GAMBLING]+=0+5*_param_[ST_LUCK];
    Edit58.Text:=IntToStr(0+2*(StrToInt(Edit3.Text) + StrToInt(Edit5.Text)));;//_param_[SK_OUTDOORSMAN]+=0+2*(_param_[ST_ENDURANCE]+_param_[ST_INTELLECT]);




    Edit80.Text:=IntToStr(0+2*(StrToInt(Edit3.Text))); //_param_[ST_RADIATION_RESISTANCE]+=_param_[ST_ENDURANCE]*2;
    Edit113.Text:=IntToStr(0+5*(StrToInt(Edit3.Text)));//_param_[ST_POISON_RESISTANCE]+=_param_[ST_ENDURANCE]*5;



//    PageControl1.ActivePageIndex:=2;
    if Trim(Item.SubItems.Strings[22])<>'' then
      ComboBox3.ItemIndex:=StrToInt(Trim(Item.SubItems.Strings[22]));

//    Edit32.Text:=Trim(Item.SubItems.Strings[24]);
    UpDown16.Position:=StrToInt(Trim(Item.SubItems.Strings[24]));// Age               Edit32

//    Edit35.Text:=Trim(Item.SubItems.Strings[25]);
    UpDown19.Position:=StrToInt(Trim(Item.SubItems.Strings[25]));// Scale Factor      Edit35


    CheckBox1.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[64])));
    CheckBox2.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[65])));
    CheckBox3.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[66])));
    CheckBox4.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[67])));
    CheckBox5.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[68])));
    CheckBox6.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[69])));
    CheckBox7.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[70])));
    CheckBox8.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[71])));
    CheckBox9.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[72])));
    CheckBox10.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[73])));
    CheckBox11.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[74])));
    CheckBox12.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[75])));
    CheckBox13.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[76])));
    CheckBox14.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[77])));
    CheckBox15.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[78])));
    CheckBox16.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[79])));
    CheckBox17.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[80])));
    CheckBox18.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[81])));
    CheckBox19.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[82])));
    CheckBox20.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[83])));
    CheckBox21.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[84])));
    CheckBox22.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[85])));
    CheckBox23.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[86])));
    CheckBox36.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[87])));
    CheckBox37.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[88])));
    CheckBox38.Checked:=StrToBool(IntToStr(-strToInt(Item.SubItems.Strings[89])));

    UpDown45.Position:=StrToInt(Trim(Item.SubItems.Strings[90]));// Toxic             Edit116
    UpDown46.Position:=StrToInt(Trim(Item.SubItems.Strings[91]));// Radioactive       Edit117

    SpinEdit1000.Value:=StrToInt(Trim(Item.SubItems.Strings[92]));//ST_LEVEL
    SpinEdit1001.Value:=StrToInt(Trim(Item.SubItems.Strings[93]));//ST_WALK_TIME
    SpinEdit1002.Value:=StrToInt(Trim(Item.SubItems.Strings[94]));//ST_RUN_TIME


ValueListEditor1.Values['PE_ACTION_BOY']:=Trim(Item.SubItems.Strings[95]);
ValueListEditor1.Values['PE_ADRENALINE_RUSH']:=Trim(Item.SubItems.Strings[96]);
ValueListEditor1.Values['PE_BEST_OF_A_BAD_LOT']:=Trim(Item.SubItems.Strings[97]);
ValueListEditor1.Values['PE_BETTER_CRITICALS']:=Trim(Item.SubItems.Strings[98]);
//ValueListEditor1.Values['PE_BLESSED_ARE_THE_WEAK']:=Trim(Item.SubItems.Strings[99]);
//ValueListEditor1.Values['PE_BONUS_HTH_ATTACKS']:=Trim(Item.SubItems.Strings[100]);
ValueListEditor1.Values['PE_CLOSE_COMBAT_MASTER']:=Trim(Item.SubItems.Strings[101]);
//ValueListEditor1.Values['PE_CLOSE_COMBAT_MASTER_II']:=Trim(Item.SubItems.Strings[102]);
ValueListEditor1.Values['PE_BONUS_MOVE']:=Trim(Item.SubItems.Strings[103]);
ValueListEditor1.Values['PE_BONUS_RANGED_DAMAGE']:=Trim(Item.SubItems.Strings[104]);
ValueListEditor1.Values['PE_BONUS_RATE_OF_ATTACK']:=Trim(Item.SubItems.Strings[105]);
ValueListEditor1.Values['PE_BORN_LEADER']:=Trim(Item.SubItems.Strings[106]);
ValueListEditor1.Values['PE_DEAD_MAN_WALKING']:=Trim(Item.SubItems.Strings[107]);
ValueListEditor1.Values['PE_DEMOLITION_EXPERT']:=Trim(Item.SubItems.Strings[108]);
ValueListEditor1.Values['PE_DERMAL_IMPACT']:=Trim(Item.SubItems.Strings[109]);
ValueListEditor1.Values['PE_DERMAL_IMPACT_ENH']:=Trim(Item.SubItems.Strings[110]);
ValueListEditor1.Values['PE_DODGER']:=Trim(Item.SubItems.Strings[111]);
//ValueListEditor1.Values['PE_DODGER_II']:=Trim(Item.SubItems.Strings[112]);
ValueListEditor1.Values['PE_EARLIER_SEQUENCE']:=Trim(Item.SubItems.Strings[113]);
ValueListEditor1.Values['PE_EVEN_MORE_CRITICALS']:=Trim(Item.SubItems.Strings[114]);
ValueListEditor1.Values['PE_EVEN_TOUGHER']:=Trim(Item.SubItems.Strings[115]);
ValueListEditor1.Values['PE_FAST_RELOAD']:=Trim(Item.SubItems.Strings[116]);
ValueListEditor1.Values['PE_HAND_LOADER']:=Trim(Item.SubItems.Strings[117]);
//ValueListEditor1.Values['PE_FIELD_MEDIC_II']:=Trim(Item.SubItems.Strings[118]);
ValueListEditor1.Values['PE_HEAVE_HO']:=Trim(Item.SubItems.Strings[119]);
//ValueListEditor1.Values['PE_HEAVE_HO_II']:=Trim(Item.SubItems.Strings[120]);
//ValueListEditor1.Values['PE_HIT_THE_GAPS']:=Trim(Item.SubItems.Strings[121]);
//ValueListEditor1.Values['PE_HTH_CRITICALS']:=Trim(Item.SubItems.Strings[122]);
//ValueListEditor1.Values['PE_HTH_EVADE']:=Trim(Item.SubItems.Strings[123]);
//ValueListEditor1.Values['PE_HTH_EVADE_II']:=Trim(Item.SubItems.Strings[124]);
ValueListEditor1.Values['PE_IN_YOUR_FACE']:=Trim(Item.SubItems.Strings[125]);
ValueListEditor1.Values['PE_IRON_LIMBS']:=Trim(Item.SubItems.Strings[126]);
ValueListEditor1.Values['PE_JINXED_II']:=Trim(Item.SubItems.Strings[127]);
ValueListEditor1.Values['PE_LIVEWIRE']:=Trim(Item.SubItems.Strings[128]);
//ValueListEditor1.Values['PE_LIVING_ANATOMY']:=Trim(Item.SubItems.Strings[129]);
ValueListEditor1.Values['PE_MAN_OF_STEEL']:=Trim(Item.SubItems.Strings[130]);
ValueListEditor1.Values['PE_MELT_INTO_SHADOW']:=Trim(Item.SubItems.Strings[131]);
ValueListEditor1.Values['PE_MORE_CRITICALS']:=Trim(Item.SubItems.Strings[132]);
ValueListEditor1.Values['PE_MORE_RANGED_DAMAGE']:=Trim(Item.SubItems.Strings[133]);
ValueListEditor1.Values['PE_NEMEAN_ARMOR']:=Trim(Item.SubItems.Strings[134]);
ValueListEditor1.Values['PE_PHOENIX_IMPLANTS']:=Trim(Item.SubItems.Strings[135]);
ValueListEditor1.Values['PE_PHOENIX_IMPLANTS_ENH']:=Trim(Item.SubItems.Strings[136]);
ValueListEditor1.Values['PE_PYROMANIAC']:=Trim(Item.SubItems.Strings[137]);
ValueListEditor1.Values['PE_QUICK_POCKETS']:=Trim(Item.SubItems.Strings[138]);
ValueListEditor1.Values['PE_QUICK_RECOVERY']:=Trim(Item.SubItems.Strings[139]);
//ValueListEditor1.Values['PE_RIGHT_BETWEEN_THE_EYES']:=Trim(Item.SubItems.Strings[140]);
ValueListEditor1.Values['PE_SHARPSHOOTER']:=Trim(Item.SubItems.Strings[141]);
ValueListEditor1.Values['PE_SILENT_DEATH']:=Trim(Item.SubItems.Strings[142]);
ValueListEditor1.Values['PE_SLAYER']:=Trim(Item.SubItems.Strings[143]);
ValueListEditor1.Values['PE_SNIPER']:=Trim(Item.SubItems.Strings[144]);
ValueListEditor1.Values['PE_SPRAY_AND_PRAY']:=Trim(Item.SubItems.Strings[145]);
ValueListEditor1.Values['PE_STEALTH_GIRL']:=Trim(Item.SubItems.Strings[146]);
ValueListEditor1.Values['PE_STONEWALL']:=Trim(Item.SubItems.Strings[147]);
ValueListEditor1.Values['PE_TERMINATOR']:=Trim(Item.SubItems.Strings[148]);
ValueListEditor1.Values['PE_TOUGHNESS']:=Trim(Item.SubItems.Strings[149]);
//ValueListEditor1.Values['PE_TREE_TRUNK_THIGHS']:=Trim(Item.SubItems.Strings[150]);
ValueListEditor1.Values['PE_WEAPON_HANDLING']:=Trim(Item.SubItems.Strings[151]);

ValueListEditor1.Values['PE_FASTER_HEALING']:=Trim(Item.SubItems.Strings[152]);
ValueListEditor1.Values['PE_GHOST']:=Trim(Item.SubItems.Strings[153]);
ValueListEditor1.Values['PE_FIELD_MEDIC']:=Trim(Item.SubItems.Strings[154]);
ValueListEditor1.Values['PE_LIFEGIVER']:=Trim(Item.SubItems.Strings[155]);
ValueListEditor1.Values['PE_LIGHT_STEP']:=Trim(Item.SubItems.Strings[156]);
ValueListEditor1.Values['PE_MEDIC']:=Trim(Item.SubItems.Strings[157]);



if Trim(Item.SubItems.Strings[158])='None' then ComboBox8.ItemIndex:=0;
if Trim(Item.SubItems.Strings[158])='74' then ComboBox8.ItemIndex:=1;
if Trim(Item.SubItems.Strings[158])='1' then ComboBox8.ItemIndex:=2;
if Trim(Item.SubItems.Strings[158])='379' then ComboBox8.ItemIndex:=3;
if Trim(Item.SubItems.Strings[158])='265' then ComboBox8.ItemIndex:=4;
if Trim(Item.SubItems.Strings[158])='2' then ComboBox8.ItemIndex:=5;
if Trim(Item.SubItems.Strings[158])='380' then ComboBox8.ItemIndex:=6;
if Trim(Item.SubItems.Strings[158])='240' then ComboBox8.ItemIndex:=7;
if Trim(Item.SubItems.Strings[158])='17' then ComboBox8.ItemIndex:=8;
if Trim(Item.SubItems.Strings[158])='381' then ComboBox8.ItemIndex:=9;
if Trim(Item.SubItems.Strings[158])='239' then ComboBox8.ItemIndex:=10;
if Trim(Item.SubItems.Strings[158])='9654' then ComboBox8.ItemIndex:=11;
if Trim(Item.SubItems.Strings[158])='751' then ComboBox8.ItemIndex:=12;
if Trim(Item.SubItems.Strings[158])='752' then ComboBox8.ItemIndex:=13;
if Trim(Item.SubItems.Strings[158])='753' then ComboBox8.ItemIndex:=14;
if Trim(Item.SubItems.Strings[158])='754' then ComboBox8.ItemIndex:=15;
if Trim(Item.SubItems.Strings[158])='755' then ComboBox8.ItemIndex:=16;
if Trim(Item.SubItems.Strings[158])='756' then ComboBox8.ItemIndex:=17;
if Trim(Item.SubItems.Strings[158])='757' then ComboBox8.ItemIndex:=18;
if Trim(Item.SubItems.Strings[158])='758' then ComboBox8.ItemIndex:=19;
if Trim(Item.SubItems.Strings[158])='3' then ComboBox8.ItemIndex:=20;
if Trim(Item.SubItems.Strings[158])='232' then ComboBox8.ItemIndex:=21;
if Trim(Item.SubItems.Strings[158])='348' then ComboBox8.ItemIndex:=22;
if Trim(Item.SubItems.Strings[158])='349' then ComboBox8.ItemIndex:=23;
if Trim(Item.SubItems.Strings[158])='113' then ComboBox8.ItemIndex:=24;
if Trim(Item.SubItems.Strings[158])='524' then ComboBox8.ItemIndex:=25;
if Trim(Item.SubItems.Strings[158])='750' then ComboBox8.ItemIndex:=26;
if Trim(Item.SubItems.Strings[158])='723' then ComboBox8.ItemIndex:=27;
if Trim(Item.SubItems.Strings[158])='778' then ComboBox8.ItemIndex:=28;

if Trim(Item.SubItems.Strings[159])='None' then ComboBox9.ItemIndex:=0;
if Trim(Item.SubItems.Strings[159])='721' then ComboBox9.ItemIndex:=1 ;
if Trim(Item.SubItems.Strings[159])='722' then ComboBox9.ItemIndex:=2 ;
if Trim(Item.SubItems.Strings[159])='725' then ComboBox9.ItemIndex:=3 ;
if Trim(Item.SubItems.Strings[159])='726' then ComboBox9.ItemIndex:=4 ;
if Trim(Item.SubItems.Strings[159])='727' then ComboBox9.ItemIndex:=5 ;
if Trim(Item.SubItems.Strings[159])='728' then ComboBox9.ItemIndex:=6 ;
if Trim(Item.SubItems.Strings[159])='729' then ComboBox9.ItemIndex:=7 ;
if Trim(Item.SubItems.Strings[159])='730' then ComboBox9.ItemIndex:=8 ;
if Trim(Item.SubItems.Strings[159])='731' then ComboBox9.ItemIndex:=9 ;
if Trim(Item.SubItems.Strings[159])='732' then ComboBox9.ItemIndex:=10;
if Trim(Item.SubItems.Strings[159])='733' then ComboBox9.ItemIndex:=11;
if Trim(Item.SubItems.Strings[159])='734' then ComboBox9.ItemIndex:=12;
if Trim(Item.SubItems.Strings[159])='735' then ComboBox9.ItemIndex:=13;
if Trim(Item.SubItems.Strings[159])='736' then ComboBox9.ItemIndex:=14;
if Trim(Item.SubItems.Strings[159])='737' then ComboBox9.ItemIndex:=15;
if Trim(Item.SubItems.Strings[159])='738' then ComboBox9.ItemIndex:=16;
if Trim(Item.SubItems.Strings[159])='739' then ComboBox9.ItemIndex:=17;
if Trim(Item.SubItems.Strings[159])='740' then ComboBox9.ItemIndex:=18;


ValueListEditor2.Values['TRAIT_FAST_METABOLISM']:=Trim(Item.SubItems.Strings[160]);
ValueListEditor2.Values['TRAIT_BRUISER']:=Trim(Item.SubItems.Strings[161]);
ValueListEditor2.Values['TRAIT_SMALL_FRAME']:=Trim(Item.SubItems.Strings[162]);
ValueListEditor2.Values['TRAIT_ONE_HANDER']:=Trim(Item.SubItems.Strings[163]);
ValueListEditor2.Values['TRAIT_FINESSE']:=Trim(Item.SubItems.Strings[164]);
ValueListEditor2.Values['TRAIT_KAMIKAZE']:=Trim(Item.SubItems.Strings[165]);
ValueListEditor2.Values['TRAIT_HEAVY_HANDED']:=Trim(Item.SubItems.Strings[166]);
ValueListEditor2.Values['TRAIT_FAST_SHOT']:=Trim(Item.SubItems.Strings[167]);
ValueListEditor2.Values['TRAIT_BLOODY_MESS']:=Trim(Item.SubItems.Strings[168]);
ValueListEditor2.Values['TRAIT_JINXED']:=Trim(Item.SubItems.Strings[169]);
ValueListEditor2.Values['TRAIT_GOOD_NATURED']:=Trim(Item.SubItems.Strings[170]);
ValueListEditor2.Values['TRAIT_CHEM_RELIANT']:=Trim(Item.SubItems.Strings[171]);
//ValueListEditor2.Values['TRAIT_CHEM_RESISTANT']:=Trim(Item.SubItems.Strings[172]);
ValueListEditor2.Values['TRAIT_BONEHEAD']:=Trim(Item.SubItems.Strings[173]);
ValueListEditor2.Values['TRAIT_SKILLED']:=Trim(Item.SubItems.Strings[174]);
ValueListEditor2.Values['TRAIT_LONER']:=Trim(Item.SubItems.Strings[175]);



//    PageControl1.ActivePageIndex:=3;
    //armor stats
    Edit36.Text:=Edit18.Text;  //Armor class - ten parametr "pancerza" crittera jest wartoscia dodana poza ta jaka jest wylicozna z AG

    Edit99.Text:=Trim(Item.SubItems.Strings[45]);
    Edit100.Text:=Trim(Item.SubItems.Strings[46]);
    Edit101.Text:=Trim(Item.SubItems.Strings[47]);
    Edit102.Text:=Trim(Item.SubItems.Strings[48]);
    Edit103.Text:=Trim(Item.SubItems.Strings[49]);
    Edit104.Text:=Trim(Item.SubItems.Strings[50]);
    Edit105.Text:=Trim(Item.SubItems.Strings[51]);

    Edit106.Text:=Trim(Item.SubItems.Strings[52]);
    Edit107.Text:=Trim(Item.SubItems.Strings[53]);
    Edit108.Text:=Trim(Item.SubItems.Strings[54]);
    Edit109.Text:=Trim(Item.SubItems.Strings[55]);
    Edit110.Text:=Trim(Item.SubItems.Strings[56]);
    Edit111.Text:=Trim(Item.SubItems.Strings[57]);
    Edit112.Text:=Trim(Item.SubItems.Strings[58]);

//    radiation + poison resist
//    Edit114.Text:=Trim(Item.SubItems.Strings[59]);
//    Edit115.Text:=Trim(Item.SubItems.Strings[60]);
    UpDown43.Position:=StrToInt(Trim(Item.SubItems.Strings[59]));// Rad resist        Edit114
    UpDown44.Position:=StrToInt(Trim(Item.SubItems.Strings[60]));// Pois resist       Edit115


    lokal_STOP_FOR_SAVE:=False; // po wybraniu kolejnego crittera z ListView1 zapobiega uaktywnianiu sie przycisku SAVE ktory ma sie uaktywniac tylko gdy ktores okno edycyjne po rpawej stronie bedzie uzyte, zeby zaakcentowac koniecznosc jego uzycia przed wyborem nastpengo crittera z listy Listview1

  end;
  PageControl1.ActivePageIndex:=aktywny_arkusz;
end;

procedure TForm1.Edit61Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit81.Text:=IntToStr(StrToInt(Edit41.Text) + StrToInt(Edit61.Text));
end;

procedure TForm1.Edit62Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit82.Text:=IntToStr(StrToInt(Edit42.Text) + StrToInt(Edit62.Text));
end;

procedure TForm1.Edit63Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit83.Text:=IntToStr(StrToInt(Edit43.Text) + StrToInt(Edit63.Text));
end;

procedure TForm1.Edit64Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit84.Text:=IntToStr(StrToInt(Edit44.Text) + StrToInt(Edit64.Text));
end;

procedure TForm1.Edit65Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  //Edit85.Text:=IntToStr(StrToInt(Edit45.Text) + StrToInt(Edit65.Text));
  Edit85.Text:='0';
end;

procedure TForm1.Edit66Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit86.Text:=IntToStr(StrToInt(Edit46.Text) + StrToInt(Edit66.Text));
end;

procedure TForm1.Edit67Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit87.Text:=IntToStr(StrToInt(Edit47.Text) + StrToInt(Edit67.Text));
end;

procedure TForm1.Edit68Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit88.Text:=IntToStr(StrToInt(Edit48.Text) + StrToInt(Edit68.Text));
end;

procedure TForm1.Edit69Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit89.Text:=IntToStr(StrToInt(Edit49.Text) + StrToInt(Edit69.Text));
end;

procedure TForm1.Edit70Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit90.Text:=IntToStr(StrToInt(Edit50.Text) + StrToInt(Edit70.Text));
end;

procedure TForm1.Edit71Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit91.Text:=IntToStr(StrToInt(Edit51.Text) + StrToInt(Edit71.Text));
end;

procedure TForm1.Edit72Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit92.Text:=IntToStr(StrToInt(Edit52.Text) + StrToInt(Edit72.Text));
end;

procedure TForm1.Edit73Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit93.Text:=IntToStr(StrToInt(Edit53.Text) + StrToInt(Edit73.Text));
end;

procedure TForm1.Edit74Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit94.Text:=IntToStr(StrToInt(Edit54.Text) + StrToInt(Edit74.Text));
end;

procedure TForm1.Edit75Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit95.Text:=IntToStr(StrToInt(Edit55.Text) + StrToInt(Edit75.Text));
end;

procedure TForm1.Edit76Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit96.Text:=IntToStr(StrToInt(Edit56.Text) + StrToInt(Edit76.Text));
end;

procedure TForm1.Edit77Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit97.Text:=IntToStr(StrToInt(Edit57.Text) + StrToInt(Edit77.Text));
end;

procedure TForm1.Edit78Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit98.Text:=IntToStr(StrToInt(Edit58.Text) + StrToInt(Edit78.Text));
end;

procedure TForm1.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
  if global_STOP_FOR_SAVE=True then
  begin
//    if ListView1.Items.Count>0 then  // raczej to wylaczone, bo czasem moze sie zdarzyc, ze chcemy oproznic plik i nie byloby mozliowsci jego zapisania
    case MessageBox(Handle,PChar('"'+ ExtractFileName(path_selected_fopro) + '" was modified! Do you want to save changes before exit? "Yes" - Save & Exit, "No" - Exit w/o save, "Cancel" - Return to program.'),'Exiting...', MB_YESNOCANCEL + MB_ICONSTOP) of
    IDYES: begin
             SaveListViewToFile(ListView1, path_selected_fopro,path_selected_msg);
             global_STOP_FOR_SAVE:=False;

             CanClose:=True;
           end;
    IDCANCEL: begin
                CanClose:=False;
              end;
    IDNO: CanClose:=True;
    end;
  end;
end;

procedure TForm1.Edit37Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit38Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.ComboBox1Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
{  if isHumanoid(ComboBox1.ItemIndex)=True then
    Edit8.Text:=IntToStr(15 + 40 + StrToInt(Edit1.Text)+StrToInt(Edit3.Text)*2)
  else
    Edit8.Text:=IntToStr(15 + StrToInt(Edit1.Text)+StrToInt(Edit3.Text)*2)
}

  Edit8.Text:=IntToStr(15 + StrToInt(Edit1.Text)+StrToInt(Edit3.Text)*2); // Hit Points
  if isHumanoid(ComboBox1.ItemIndex)=True then Edit8.Text:=IntToStr(15 + 40 + StrToInt(Edit1.Text)+StrToInt(Edit3.Text)*2); // Hit Points

  Edit24.Text:=IntToStr(StrToInt(Edit8.Text)+StrToInt(Edit16.Text)); //kilgore zmienil +15 w pliku _parameters.fos w dniu 8.12.2010 rev 408 na wartosc +20 ale tutaj narazie do czasu rozstrzygniecia niech bedzie jak w oryginale +15


end;

procedure TForm1.ComboBox2Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.ComboBox4Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.ComboBox3Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit33Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Update;
end;

procedure TForm1.Edit36Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit39Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit35Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit32Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox1Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox2Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox3Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox4Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox5Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox6Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox7Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox8Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox9Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox10Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox11Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox12Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox13Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox14Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox15Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox16Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox17Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox18Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox19Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox20Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox21Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox22Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox23Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox36Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox37Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.CheckBox38Click(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;


procedure TForm1.Edit99Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit100Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit101Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit102Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit103Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit104Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit105Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit106Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit107Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit108Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit109Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit110Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit111Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit112Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit60Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
  Edit60.Text:=IntToStr(StrToInt(Edit114.Text) + StrToInt(Edit80.Text));
  if StrToInt(Edit60.Text)>95 then
  begin
    //ShowMessage('Value can not exceed 95!');
    Edit114.Text:=IntToStr(95 - StrToInt(Edit80.Text));
  end;
  if StrToInt(Edit60.Text)<0 then
  begin
    //ShowMessage('Value can not be under 0!');
    Edit114.Text:=IntToStr(0 - StrToInt(Edit80.Text));

  end;

end;

procedure TForm1.Edit79Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;

  Edit79.Text:=IntToStr(StrToInt(Edit113.Text) + StrToInt(Edit115.Text));
  if StrToInt(Edit79.Text)>95 then
  begin
    Edit115.Text:=IntToStr(95 - StrToInt(Edit113.Text));
  end;
  if StrToInt(Edit79.Text)<0 then
  begin
    Edit115.Text:=IntToStr(0 - StrToInt(Edit113.Text));
  end;
end;

procedure TForm1.Edit114Change(Sender: TObject);
begin
  Edit60.Text:=IntToStr(StrToInt(Edit114.Text) + StrToInt(Edit80.Text));
end;

procedure TForm1.Edit115Change(Sender: TObject);
begin
  Edit79.Text:=IntToStr(StrToInt(Edit113.Text) + StrToInt(Edit115.Text));
end;





procedure TForm1.BackupServerFiles;
var //archiwum:TZipForge;
    nazwa_archiwum:String;
begin
{  Caption:='Fonline:Reloaded Critter Proto Editor ' + wersja_programu +' - Backup server files ...';

  DateSeparator:= '-';
  TimeSeparator:= '-';
  ShortDateFormat := 'dd/mmm/yyyy';
  ShortTimeFormat := 'hh:nn:ss';

  ForceDirectories(ExtractFilePath(Application.ExeName)+'BackupServerFiles');
  nazwa_archiwum:= FormatDateTime('dd/mm/yyyy_hh:nn:ss', Now) + '_backup_server_files.zip';


  // Create an instance of the TZipForge class
  archiwum := TZipForge.Create(nil);
  try
  with archiwum do
  begin
    // Set the name of the archive file we want to create
    FileName := ExtractFilePath(Application.ExeName) + 'BackupServerFiles\' + nazwa_archiwum;
    // Because we create a new archive,
    // we set Mode to fmCreate
    OpenArchive(fmCreate);

    // Set base (default) directory for all archive operations
    BaseDir := path_server;
    // Add the c:\Test folder to the archive with all subfolders
    AddFiles(path_server + '\proto\critters\*.*');

    if Length(lang1)=4 then AddFiles(path_server+'\text\'+lang1+'\fodlg.msg');
    if Length(lang2)=4 then AddFiles(path_server+'\text\'+lang2+'\fodlg.msg');
    if Length(lang3)=4 then AddFiles(path_server+'\text\'+lang3+'\fodlg.msg');

//    AddFiles(path_server+'\text\'+language+'\fodlg.msg');
//    AddFiles(path_server + '\text\russ\fodlg.msg');

    CloseArchive();
  end;
  except
  on E: Exception do
    begin
      ShowMessage('Exception: ' + E.Message);
    end;
  end;

  Sleep(350);
  if ExtractFileName(path_selected_fopro) <> '' then
    Caption:=ExtractFileName(path_selected_fopro) + '  -  ' + 'Fonline:Reloaded Critter Proto Editor ' + wersja_programu
  else
    Caption:='Fonline:Reloaded Critter Proto Editor ' + wersja_programu;

  StatusBar1.SimpleText:='Files are stored to:   ' + nazwa_archiwum;
}
end;


procedure TForm1.StampArmor(indeks:Integer);
begin
  case indeks of
  0 : begin   // No armor
        Edit18.Text:='0'; // AC na pierwszej planszy

        Edit99.Text:='0';  // normal
        Edit100.Text:='0'; // laser
        Edit101.Text:='0'; // fire
        Edit102.Text:='0'; // plasma
        Edit103.Text:='0'; // electr
        Edit104.Text:='0'; // EMP
        Edit105.Text:='0'; // explode

        Edit106.Text:='0';
        Edit107.Text:='0';
        Edit108.Text:='0';
        Edit109.Text:='0';
        Edit110.Text:='0';
        Edit111.Text:='500';
        Edit112.Text:='0';
      end;
  1 : begin   // Robe
        Edit18.Text:='0'; // AC na pierwszej planszy

        Edit99.Text:='0';  // normal
        Edit100.Text:='0'; // laser
        Edit101.Text:='0'; // fire
        Edit102.Text:='0'; // plasma
        Edit103.Text:='0'; // electr
        Edit104.Text:='0'; // EMP
        Edit105.Text:='0'; // explode

        Edit106.Text:='15';
        Edit107.Text:='25';
        Edit108.Text:='10';
        Edit109.Text:='10';
        Edit110.Text:='40';
        Edit111.Text:='500';
        Edit112.Text:='15';
      end;
  2 : begin    // Leather Jacket
        Edit18.Text:='0'; // AC na pierwszej planszy

        Edit99.Text:='0';  // normal
        Edit100.Text:='0'; // laser
        Edit101.Text:='0'; // fire
        Edit102.Text:='0'; // plasma
        Edit103.Text:='0'; // electr
        Edit104.Text:='0'; // EMP
        Edit105.Text:='0'; // explode

        Edit106.Text:='20';
        Edit107.Text:='20';
        Edit108.Text:='20';
        Edit109.Text:='10';
        Edit110.Text:='30';
        Edit111.Text:='500';
        Edit112.Text:='20';
      end;
  3 : begin  // Combat Leather Jacket
        Edit18.Text:='0'; // AC na pierwszej planszy

        Edit99.Text:='2';  // normal
        Edit100.Text:='0'; // laser
        Edit101.Text:='4'; // fire
        Edit102.Text:='0'; // plasma
        Edit103.Text:='0'; // electr
        Edit104.Text:='0'; // EMP
        Edit105.Text:='2'; // explode

        Edit106.Text:='25';
        Edit107.Text:='20';
        Edit108.Text:='40';
        Edit109.Text:='10';
        Edit110.Text:='30';
        Edit111.Text:='500';
        Edit112.Text:='30';
      end;
  4 : begin   // Leather Armor
        Edit18.Text:='10'; // AC na pierwszej planszy

        Edit99.Text:='3';  // normal
        Edit100.Text:='0'; // laser
        Edit101.Text:='3'; // fire
        Edit102.Text:='0'; // plasma
        Edit103.Text:='0'; // electr
        Edit104.Text:='0'; // EMP
        Edit105.Text:='3'; // explode

        Edit106.Text:='25';
        Edit107.Text:='20';
        Edit108.Text:='30';
        Edit109.Text:='10';
        Edit110.Text:='30';
        Edit111.Text:='500';
        Edit112.Text:='30';
      end;
  5 : begin  // Leather Armor MkII
        Edit18.Text:='10'; // AC na pierwszej planszy

        Edit99.Text:='4';  // normal
        Edit100.Text:='0'; // laser
        Edit101.Text:='4'; // fire
        Edit102.Text:='0'; // plasma
        Edit103.Text:='1'; // electr
        Edit104.Text:='0'; // EMP
        Edit105.Text:='4'; // explode

        Edit106.Text:='30';
        Edit107.Text:='20';
        Edit108.Text:='35';
        Edit109.Text:='10';
        Edit110.Text:='40';
        Edit111.Text:='500';
        Edit112.Text:='35';
      end;
  6 : begin  // Tesla Armor
        Edit18.Text:='30'; // AC na pierwszej planszy

        Edit99.Text:='3';  // normal
        Edit100.Text:='10'; // laser
        Edit101.Text:='0'; // fire
        Edit102.Text:='10'; // plasma
        Edit103.Text:='12'; // electr
        Edit104.Text:='0'; // EMP
        Edit105.Text:='1'; // explode

        Edit106.Text:='25';
        Edit107.Text:='85';
        Edit108.Text:='10';
        Edit109.Text:='75';
        Edit110.Text:='80';
        Edit111.Text:='500';
        Edit112.Text:='20';
      end;
  7 : begin   // Metal Armor
        Edit18.Text:='30'; // AC na pierwszej planszy

        Edit99.Text:='2';  // normal
        Edit100.Text:='6'; // laser
        Edit101.Text:='0'; // fire
        Edit102.Text:='4'; // plasma
        Edit103.Text:='0'; // electr
        Edit104.Text:='0'; // EMP
        Edit105.Text:='1'; // explode

        Edit106.Text:='25';
        Edit107.Text:='75';
        Edit108.Text:='10';
        Edit109.Text:='20';
        Edit110.Text:='0';
        Edit111.Text:='500';
        Edit112.Text:='20';
      end;
  8 : begin    // Metal Armor MkII
        Edit18.Text:='30'; // AC na pierwszej planszy

        Edit99.Text:='3';  // normal
        Edit100.Text:='7'; // laser
        Edit101.Text:='0'; // fire
        Edit102.Text:='4'; // plasma
        Edit103.Text:='1'; // electr
        Edit104.Text:='0'; // EMP
        Edit105.Text:='2'; // explode

        Edit106.Text:='30';
        Edit107.Text:='80';
        Edit108.Text:='10';
        Edit109.Text:='25';
        Edit110.Text:='10';
        Edit111.Text:='500';
        Edit112.Text:='25';
      end;
  9 : begin   // Combat Armor
        Edit18.Text:='20'; // AC na pierwszej planszy

        Edit99.Text:='5';  // normal
        Edit100.Text:='6'; // laser
        Edit101.Text:='3'; // fire
        Edit102.Text:='4'; // plasma
        Edit103.Text:='2'; // electr
        Edit104.Text:='0'; // EMP
        Edit105.Text:='5'; // explode

        Edit106.Text:='40';
        Edit107.Text:='60';
        Edit108.Text:='25';
        Edit109.Text:='50';
        Edit110.Text:='45';
        Edit111.Text:='500';
        Edit112.Text:='40';
      end;
  10: begin    // Combat Armor MkII
        Edit18.Text:='20'; // AC na pierwszej planszy

        Edit99.Text:='6';  // normal
        Edit100.Text:='7'; // laser
        Edit101.Text:='4'; // fire
        Edit102.Text:='5'; // plasma
        Edit103.Text:='3'; // electr
        Edit104.Text:='0'; // EMP
        Edit105.Text:='6'; // explode

        Edit106.Text:='40';
        Edit107.Text:='65';
        Edit108.Text:='30';
        Edit109.Text:='50';
        Edit110.Text:='50';
        Edit111.Text:='500';
        Edit112.Text:='40';
      end;
  11: begin     // Brotherhood Armor
        Edit18.Text:='20'; // AC na pierwszej planszy

        Edit99.Text:='8';  // normal
        Edit100.Text:='8'; // laser
        Edit101.Text:='7'; // fire
        Edit102.Text:='7'; // plasma
        Edit103.Text:='6'; // electr
        Edit104.Text:='0'; // EMP
        Edit105.Text:='8'; // explode

        Edit106.Text:='40';
        Edit107.Text:='70';
        Edit108.Text:='50';
        Edit109.Text:='60';
        Edit110.Text:='60';
        Edit111.Text:='500';
        Edit112.Text:='40';
      end;
  12: begin     // Power Armor
        Edit18.Text:='5'; // AC na pierwszej planszy

        Edit99.Text:='12';  // normal
        Edit100.Text:='18'; // laser
        Edit101.Text:='12'; // fire
        Edit102.Text:='10'; // plasma
        Edit103.Text:='12'; // electr
        Edit104.Text:='0'; // EMP
        Edit105.Text:='20'; // explode

        Edit106.Text:='40';
        Edit107.Text:='80';
        Edit108.Text:='60';
        Edit109.Text:='40';
        Edit110.Text:='40';
        Edit111.Text:='500';
        Edit112.Text:='50';
      end;
  13: begin    // Hardened Power Armor
        Edit18.Text:='5'; // AC na pierwszej planszy

        Edit99.Text:='13';  // normal
        Edit100.Text:='19'; // laser
        Edit101.Text:='14'; // fire
        Edit102.Text:='13'; // plasma
        Edit103.Text:='13'; // electr
        Edit104.Text:='0'; // EMP
        Edit105.Text:='20'; // explode

        Edit106.Text:='50';
        Edit107.Text:='90';
        Edit108.Text:='70';
        Edit109.Text:='50';
        Edit110.Text:='50';
        Edit111.Text:='505';
        Edit112.Text:='60';
      end;
  14: begin    // Advanced Power Armor
        Edit18.Text:='5'; // AC na pierwszej planszy

        Edit99.Text:='15';  // normal
        Edit100.Text:='19'; // laser
        Edit101.Text:='16'; // fire
        Edit102.Text:='15'; // plasma
        Edit103.Text:='15'; // electr
        Edit104.Text:='0'; // EMP
        Edit105.Text:='20'; // explode

        Edit106.Text:='55';
        Edit107.Text:='90';
        Edit108.Text:='70';
        Edit109.Text:='60';
        Edit110.Text:='60';
        Edit111.Text:='500';
        Edit112.Text:='65';
      end;
  15: begin    // Advanced Power Armor Mk II
        Edit18.Text:='5'; // AC na pierwszej planszy

        Edit99.Text:='18';  // normal
        Edit100.Text:='19'; // laser
        Edit101.Text:='16'; // fire
        Edit102.Text:='18'; // plasma
        Edit103.Text:='15'; // electr
        Edit104.Text:='0'; // EMP
        Edit105.Text:='20'; // explode

        Edit106.Text:='60';
        Edit107.Text:='90';
        Edit108.Text:='70';
        Edit109.Text:='60';
        Edit110.Text:='65';
        Edit111.Text:='500';
        Edit112.Text:='70';
      end;

  end;
end;

procedure TForm1.SpeedButton1Click(Sender: TObject);
begin
  StampArmor(0);
end;

procedure TForm1.SpeedButton2Click(Sender: TObject);
begin
  StampArmor(1);
end;

procedure TForm1.SpeedButton3Click(Sender: TObject);
begin
  StampArmor(2);
end;

procedure TForm1.SpeedButton4Click(Sender: TObject);
begin
  StampArmor(3);
end;

procedure TForm1.SpeedButton5Click(Sender: TObject);
begin
  StampArmor(4);
end;

procedure TForm1.SpeedButton6Click(Sender: TObject);
begin
  StampArmor(5);
end;

procedure TForm1.SpeedButton7Click(Sender: TObject);
begin
  StampArmor(6);
end;

procedure TForm1.SpeedButton8Click(Sender: TObject);
begin
  StampArmor(7);
end;

procedure TForm1.SpeedButton9Click(Sender: TObject);
begin
  StampArmor(8);
end;

procedure TForm1.SpeedButton10Click(Sender: TObject);
begin
  StampArmor(9);
end;

procedure TForm1.SpeedButton11Click(Sender: TObject);
begin
  StampArmor(10);
end;

procedure TForm1.SpeedButton12Click(Sender: TObject);
begin
  StampArmor(11);
end;

procedure TForm1.SpeedButton13Click(Sender: TObject);
begin
  StampArmor(12);
end;

procedure TForm1.SpeedButton14Click(Sender: TObject);
begin
  StampArmor(13);
end;

procedure TForm1.SpeedButton15Click(Sender: TObject);
begin
  StampArmor(14);
end;

procedure TForm1.SpeedButton16Click(Sender: TObject);
begin
  StampArmor(15);
end;



procedure TForm1.Edit116Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.Edit117Change(Sender: TObject);
begin
  lokal_STOP_FOR_SAVE:=True;
end;

procedure TForm1.ListView1Change(Sender: TObject; Item: TListItem;
  Change: TItemChange);
begin
  global_STOP_FOR_SAVE:=TRUE;
end;




procedure TForm1.BitBtn5Click(Sender: TObject);
begin
  ZapiszBiezacyCritter;
  BitBtn5.Font.Color:=clBlack;
  StatusBar1.Color:=clBtnFace;
  StatusBar1.Font.Style:=[];
end;

procedure TForm1.BitBtn6Click(Sender: TObject);
begin
  ShellExecute(Handle, 'open', 'Notepad++.exe' , PChar(path_selected_fopro), PChar(path_server + '\proto\critters'), {SW_SHOWNORMAL}SW_SHOWMAXIMIZED);
end;



procedure TForm1.BitBtn7Click(Sender: TObject);  // Load
begin
  if global_STOP_FOR_SAVE=True then
  begin
    case MessageBox(Handle, PChar('"'+ ExtractFileName(path_selected_fopro) + '" was modified! Do you want to save changes before load new file?'), 'Loading file...', MB_YESNOCANCEL + MB_ICONSTOP) of
    IDYES: begin
             global_STOP_FOR_SAVE:=False;
             SaveListViewToFile(ListView1, path_selected_fopro,path_selected_msg);
             ShowMessage('File ' + path_selected_fopro + ' saved.');
             if OpenDialog1.Execute then
             begin
               path_all_fopro:=OpenDialog1.FileName;
               WczytajFopro;
               lokal_STOP_FOR_SAVE:=False;
               BitBtn5.Font.Color:=clBlack;
               StatusBar1.Color:=clBtnFace;
               StatusBar1.Font.Style:=[];
             end;
           end;
    IDCANCEL: begin
              end;
    IDNO: begin
             global_STOP_FOR_SAVE:=False;

             if OpenDialog1.Execute then
             begin
               path_all_fopro:=OpenDialog1.FileName;
               WczytajFopro;
               lokal_STOP_FOR_SAVE:=False;
               BitBtn5.Font.Color:=clBlack;
               StatusBar1.Color:=clBtnFace;
               StatusBar1.Font.Style:=[];
             end;
           end;
    end;
  end
  else
  begin
    if OpenDialog1.Execute then
    begin
      path_all_fopro:=OpenDialog1.FileName;
      WczytajFopro;
      lokal_STOP_FOR_SAVE:=False;
	    global_STOP_FOR_SAVE:=False;
      BitBtn5.Font.Color:=clBlack;
      StatusBar1.Color:=clBtnFace;
      StatusBar1.Font.Style:=[];
    end;
  end;
end;





procedure TForm1.BitBtn8Click(Sender: TObject);
begin
  ZapiszFopro;
end;

procedure TForm1.BitBtn9Click(Sender: TObject);
begin
  BackupServerFiles;
end;



procedure TForm1.ComboBox7Change(Sender: TObject);
begin
  BitBtn7.Caption:='Reload';

  language:=ComboBox7.Items.Strings[ComboBox7.ItemIndex];
//  if ComboBox7.Items.Count>0 then ComboBox7.ItemIndex:=ComboBox7.Items.IndexOf(language);

//  if language='engl' then language:='russ' else language:='engl';

  plikIni := TINIFile.Create(ExtractFilePath(Application.ExeName) + 'CritterProtoEditor.ini');
  try
    plikIni.WriteString('main','path_server',path_server);
    plikIni.WriteString('main','language',language);

    plikIni.WriteString('Languages','lang1',lang1);
    plikIni.WriteString('Languages','lang2',lang2);
    plikIni.WriteString('Languages','lang3',lang3);
  finally
    plikIni.Free;
  end;

  //ShellExecute(Handle, 'open', 'Notepad.exe' , 'CritterProtoEditor.ini', PChar(FileExists(ExtractFilePath(Application.ExeName))), SW_SHOWNORMAL);

  path_fodlg_msg:=path_server+'\text\'+language+'\fodlg.msg';
  path_selected_msg:=path_server+'\text\'+language+'\fodlg.msg';


  //WczytajFopro;
end;

procedure TForm1.ComboBox1Select(Sender: TObject);
begin
//  StatusBar1.SimpleText:='Body Type index: ' + IntToStr(ComboBox1.itemIndex) + '     ';
  StatusBar1.Panels[1].Text:='Body Type index: ' + IntToStr(ComboBox1.itemIndex) + '          ';

  Edit8.Text:=IntToStr(15 + StrToInt(Edit1.Text)+StrToInt(Edit3.Text)*2); // Hit Points
  if isHumanoid(ComboBox1.ItemIndex)=True then Edit8.Text:=IntToStr(15 + 40 + StrToInt(Edit1.Text)+StrToInt(Edit3.Text)*2); // Hit Points

  Edit24.Text:=IntToStr(StrToInt(Edit8.Text)+StrToInt(Edit16.Text)); //kilgore zmienil +15 w pliku _parameters.fos w dniu 8.12.2010 rev 408 na wartosc +20 ale tutaj narazie do czasu rozstrzygniecia niech bedzie jak w oryginale +15
  
end;

procedure TForm1.ComboBox5Change(Sender: TObject);
begin
  StatusBar1.Panels[1].Text:='AI ID: ' + IntToStr(ComboBox5.itemIndex) + '          ';
end;

procedure TForm1.ComboBox6Change(Sender: TObject);
begin
  StatusBar1.Panels[1].Text:='Team ID: ' + IntToStr(ComboBox6.itemIndex) + '          ';
end;

procedure TForm1.CheckBox39Click(Sender: TObject);
{var roznica:Integer;
    iter:Integer;}
begin

{  Image2.Canvas.Pen.Width:=1;
  Image2.Canvas.Pen.Color:=clBlack; // clRed jest sta³¹ odpowiadaj¹c¹ za kolor czerwony
  Image2.Canvas.MoveTo(Image2.Width div 2 + 1,1);
  Image2.Canvas.LineTo(Image2.Width div 2 + 1,Image2.Height-9);

  roznica:=UpDown24.Top-UpDown23.Top;
  with Image2 do
  begin
    for iter:=1 to 18 do
    begin
      Canvas.MoveTo(1 , iter * roznica - roznica div 2);
      Canvas.LineTo(Image2.Width div 2 + 1,iter * roznica  - roznica div 2);
    end;
  end;
}


{  PaintBox1.Canvas.Pen.Width:=1;
  PaintBox1.Canvas.Pen.Color:=clBlack; // clRed jest sta³¹ odpowiadaj¹c¹ za kolor czerwony
  PaintBox1.Canvas.MoveTo(PaintBox1.Width div 2 + 1,1);
  PaintBox1.Canvas.LineTo(PaintBox1.Width div 2 + 1,PaintBox1.Height-9);

  roznica:=UpDown24.Top-UpDown23.Top;
  with PaintBox1 do
  begin
    for iter:=1 to 18 do
    begin
      Canvas.MoveTo(1 , iter * roznica - roznica div 2);
      Canvas.LineTo(PaintBox1.Width div 2 + 1,iter * roznica  - roznica div 2);
    end;
  end;
}

  if checkBox39.Checked then
  begin
    Image2.Visible:=True;
    UpDown23.Increment:=10;
    UpDown24.Increment:=10;
    UpDown25.Increment:=10;
    UpDown26.Increment:=10;
    UpDown27.Increment:=10;
    UpDown28.Increment:=10;
    UpDown29.Increment:=10;
    UpDown30.Increment:=10;
    UpDown31.Increment:=10;
    UpDown32.Increment:=10;
    UpDown33.Increment:=10;
    UpDown34.Increment:=10;
    UpDown35.Increment:=10;
    UpDown36.Increment:=10;
    UpDown37.Increment:=10;
    UpDown38.Increment:=10;
    UpDown39.Increment:=10;
    UpDown40.Increment:=10;
  end
  else
  begin
    Image2.Visible:=False;  
    UpDown23.Increment:=1;
    UpDown24.Increment:=1;
    UpDown25.Increment:=1;
    UpDown26.Increment:=1;
    UpDown27.Increment:=1;
    UpDown28.Increment:=1;
    UpDown29.Increment:=1;
    UpDown30.Increment:=1;
    UpDown31.Increment:=1;
    UpDown32.Increment:=1;
    UpDown33.Increment:=1;
    UpDown34.Increment:=1;
    UpDown35.Increment:=1;
    UpDown36.Increment:=1;
    UpDown37.Increment:=1;
    UpDown38.Increment:=1;
    UpDown39.Increment:=1;
    UpDown40.Increment:=1;
  end;
end;


procedure TForm1.BitBtn4Click(Sender: TObject);
var
  InputString: string;
  FileHandle:Integer;
  plikT:TextFile;
  linia:String;
  krotka_nazwa_pliku_fopro:String;
begin
  Repeat
    InputString:= InputBox('Input Box', 'Set new *.fopro file name (w/o extension):', '');
  until Pos('.', InputString)=0;

  if InputString<>'' then // plik fopro utworzony
  begin
    if Pos('.',InputString)>0 then
    begin
      Delete(InputString,Pos('.', InputString),100);
      path_all_fopro:=path_server+'\proto\critters\'+InputString;
      krotka_nazwa_pliku_fopro:=InputString;
    end
    else
    begin
      //path_all_fopro:=path_server+'\proto\critters\'+InputString+'.fopro';
      //krotka_nazwa_pliku_fopro:=InputString+'.fopro';
      path_all_fopro:=path_server+'\proto\critters\'+InputString;
      krotka_nazwa_pliku_fopro:=InputString;
    end;

    if FileExists(path_all_fopro) then
    begin
      case MessageBox(Handle,PChar('There is exists file "' + krotka_nazwa_pliku_fopro + '". Do you want to overwrite?'),'New file...', MB_OKCANCEL or MB_DEFBUTTON2 or MB_ICONWARNING) of
      IDOK: begin
               FileHandle:=FileCreate(path_all_fopro);
               FileClose(FileHandle);
               WczytajFopro;
             end;
      IDCANCEL:
             begin

             end;
      end;
    end
    else
    begin
      FileHandle:=FileCreate(path_all_fopro);
      FileClose(FileHandle);

      AssignFile(plikT,path_server+'\proto\critters\critters.lst');
      Append(plikT);
      Writeln(plikT);
      Writeln(plikT,krotka_nazwa_pliku_fopro);
      CloseFile(plikT);
      
      WczytajFopro;
    end;
  end;
end;

procedure TForm1.CheckBox24Click(Sender: TObject);
begin
  if CheckBox24.Checked=True then
  begin
    CheckBox24.Font.Color:=clRed;
    CheckBox24.Font.Style:=[fsBold];
  end
  else
  begin
    CheckBox24.Font.Color:=clBlack;
    CheckBox24.Font.Style:=[];
  end;

end;

procedure TForm1.BitBtn10Click(Sender: TObject); // Cancel button
begin
  lokal_STOP_FOR_SAVE:=False;
  StatusBar1.SimpleText:='Selected critter:   ' + '[' + IntToStr(SpinEdit0.Value) + ']     ' + Edit37.Text + '      ' + Edit38.Text;
  BitBtn5.Font.Color:=clBlack;
  StatusBar1.Color:=clBtnFace;
  StatusBar1.Font.Style:=[];
end;

procedure TForm1.BitBtn11Click(Sender: TObject);
var iter:Byte;
    _key:String;
    _value:String;
begin
  for iter:=1 to ValueListEditor1.RowCount-1 do
  begin
    _key:=ValueListEditor1.Keys[iter];
    ValueListEditor1.Values[_key]:='';
  end;
end;

procedure TForm1.BitBtn12Click(Sender: TObject);
var iter:Byte;
    _key:String;
    _value:String;
begin
  for iter:=1 to ValueListEditor2.RowCount-1 do
  begin
    _key:=ValueListEditor2.Keys[iter];
    ValueListEditor2.Values[_key]:='';
  end;
end;

procedure TForm1.ValueListEditor1StringsChange(Sender: TObject);
var iter:Byte;
    _key:String;
    _value:String;

begin
  for iter:=0 to ValueListEditor1.RowCount-1 do
  begin
    _key:=ValueListEditor1.Keys[iter];
    if length(ValueListEditor1.Values[_key])>0 then
    begin
      ValueListEditor1.RowHeights[iter]:=16;
    end
    else
    begin
      ValueListEditor1.RowHeights[iter]:=16;
    end;
  end;
end;

procedure TForm1.ValueListEditor2StringsChange(Sender: TObject);
var iter:Byte;
    _key:String;
    _value:String;

begin
  for iter:=0 to ValueListEditor2.RowCount-1 do
  begin
    _key:=ValueListEditor2.Keys[iter];
    if length(ValueListEditor2.Values[_key])>0 then
    begin
      ValueListEditor2.RowHeights[iter]:=16;
    end
    else
    begin
      ValueListEditor2.RowHeights[iter]:=16;
    end;
  end;
end;

procedure TForm1.BitBtn13Click(Sender: TObject);
var old_HP, new_HP, edit16_HP:Integer;
begin
  edit16_HP:=StrToInt(Edit16.Text);
  old_HP:=StrToInt(Edit24.Text);
//  new_HP:=old_HP+Trunc(old_HP*SpinEdit1.Value/100);
  Edit16.Text:=IntToStr(edit16_HP + Trunc(old_HP*SpinEdit1.Value/100));
end;



procedure TForm1.RemoveDirectory(const Dir: String);
var
  sDir: String;
  Rec: TSearchRec;
begin
  sDir := IncludeTrailingPathDelimiter(Dir);
  if FindFirst(sDir + '*.*', faAnyFile, Rec) = 0 then
  try
    repeat
      if (Rec.Attr and faDirectory) = faDirectory then
      begin
        if (Rec.Name <> '.') and (Rec.Name <> '..') then
          RemoveDirectory(sDir + Rec.Name);
      end else
      begin
        DeleteFile(sDir + Rec.Name);
      end;
    until FindNext(Rec) <> 0;
  finally
    FindClose(Rec);
  end;
  RemoveDir(sDir);
end;


procedure TForm1.FormClose(Sender: TObject; var Action: TCloseAction);
begin
  RemoveDirectory(ExtractFilePath(Application.ExeName)+'pliki\frm_critters');
  RemoveDirectory(ExtractFilePath(Application.ExeName)+'pliki');
end;

end.



