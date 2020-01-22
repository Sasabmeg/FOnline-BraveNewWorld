object Form1: TForm1
  Left = 316
  Top = 156
  Width = 1200
  Height = 754
  BorderIcons = [biSystemMenu, biMinimize]
  Caption = 'Form1'
  Color = clBtnFace
  Constraints.MinHeight = 740
  Constraints.MinWidth = 1023
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clBlack
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poMainFormCenter
  OnClose = FormClose
  OnCloseQuery = FormCloseQuery
  OnCreate = FormCreate
  DesignSize = (
    1192
    727)
  PixelsPerInch = 96
  TextHeight = 13
  object Label119: TLabel
    Left = 472
    Top = 504
    Width = 358
    Height = 16
    Caption = 'Plik all.fopro nie jest obs3ugiwany w modzie Fo2077'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clRed
    Font.Height = -13
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentFont = False
    Visible = False
  end
  object ListView1: TListView
    Left = 8
    Top = 39
    Width = 473
    Height = 654
    Anchors = [akLeft, akTop, akBottom]
    Columns = <
      item
        Caption = 'Descr.'
        Width = 1
      end
      item
        Caption = 'PID'
        Width = 45
      end
      item
        Caption = 'Name'
        Width = 200
      end
      item
        Caption = 'Critter Type'
      end
      item
        Caption = 'Frm picture'
        Width = 75
      end
      item
        Caption = 'ST'
      end
      item
        Caption = 'PE'
      end
      item
        Caption = 'EN'
      end
      item
        Caption = 'CH'
      end
      item
        Caption = 'IN'
      end
      item
        Caption = 'AG'
      end
      item
        Caption = 'LK'
      end
      item
        Caption = 'Exp'
      end
      item
        Caption = 'Max Life'
      end
      item
        Caption = 'Action Points'
      end
      item
        Caption = 'Armor Class'
      end
      item
        Caption = 'Melee Damage'
      end
      item
        Caption = 'Carry Weight'
      end
      item
        Caption = 'Sequence'
      end
      item
        Caption = 'Healing Rate'
      end
      item
        Caption = 'Critical Chance'
      end
      item
        Caption = 'Body Type'
      end
      item
        Caption = 'Locomotion Type'
      end
      item
        Caption = 'Damage Type'
      end
      item
        Caption = 'Gender'
      end
      item
        Caption = 'Age'
      end
      item
        Caption = 'Scale Factor'
      end
      item
        Caption = 'AI ID'
      end
      item
        Caption = 'Small guns'
      end
      item
        Caption = 'Big guns'
      end
      item
        Caption = 'Energy guns'
      end
      item
        Caption = 'Unarmed'
      end
      item
        Caption = 'Melee'
      end
      item
        Caption = 'Throwing'
      end
      item
        Caption = 'First aid'
      end
      item
        Caption = 'Doctor'
      end
      item
        Caption = 'Sneak'
      end
      item
        Caption = 'Lockpick'
      end
      item
        Caption = 'Steal'
      end
      item
        Caption = 'Traps'
      end
      item
        Caption = 'Science'
      end
      item
        Caption = 'Repair'
      end
      item
        Caption = 'Speech'
      end
      item
        Caption = 'Barter'
      end
      item
        Caption = 'Gambling'
      end
      item
        Caption = 'Outdoorsman'
      end
      item
        Caption = 'DT normal'
      end
      item
        Caption = 'DT laser'
      end
      item
        Caption = 'DT fire'
      end
      item
        Caption = 'DT plasma'
      end
      item
        Caption = 'DT electrical'
      end
      item
        Caption = 'DT EMP'
      end
      item
        Caption = 'DT explode'
      end
      item
        Caption = 'DR normal'
      end
      item
        Caption = 'DR laser'
      end
      item
        Caption = 'DR fire'
      end
      item
        Caption = 'DR plasma'
      end
      item
        Caption = 'DR electrical'
      end
      item
        Caption = 'DR EMP'
      end
      item
        Caption = 'DR explode'
      end
      item
        Caption = 'DR radiation'
      end
      item
        Caption = 'DR Poison'
      end
      item
        Caption = 'Dialog ID'
      end
      item
        Caption = 'Bag ID'
      end
      item
        Caption = 'Team ID'
      end
      item
        Caption = 'MODE_HIDE'
      end
      item
        Caption = 'MODE_NO_STEAL'
      end
      item
        Caption = 'MODE_NO_BARTER'
      end
      item
        Caption = 'MODE_NO_ENEMY_STACK'
      end
      item
        Caption = 'MODE_NO_PVP'
      end
      item
        Caption = 'MODE_NO_HOME'
      end
      item
        Caption = 'MODE_DLG_SCRIPT_BARTER'
      end
      item
        Caption = 'MODE_UNLIMITED_AMMO'
      end
      item
        Caption = 'MODE_NO_FROP'
      end
      item
        Caption = 'MODE_NO_LOOSE_LIMBS'
      end
      item
        Caption = 'MODE_DEAD_AGES'
      end
      item
        Caption = 'MODE_NO_HEAL'
      end
      item
        Caption = 'MODE_INVULNERABLE'
      end
      item
        Caption = 'MODE_NO_FLATTEN'
      end
      item
        Caption = 'MODE_SPECIAL_DEAD'
      end
      item
        Caption = 'MODE_RANGE_HTH'
      end
      item
        Caption = 'MODE_NO_KNOCK'
      end
      item
        Caption = 'MODE_NO_LOOT'
      end
      item
        Caption = 'MODE_NO_KARMA_ON_KILL'
      end
      item
        Caption = 'MODE_BARTER_ONLY_CASH'
      end
      item
        Caption = 'MODE_NO_PUSH'
      end
      item
        Caption = 'MODE_NO_UNARMED'
      end
      item
        Caption = 'MODE_NO_AIM'
      end
      item
        Caption = 'MODE_NO_WALK'
      end
      item
        Caption = 'MODE_NO_RUN'
      end
      item
        Caption = 'MODE_NO_TALK'
      end
      item
        Caption = 'ST Toxic'
      end
      item
        Caption = 'ST Radioactive'
      end
      item
        Caption = 'ST_LEVEL'
      end
      item
        Caption = 'ST_WALK_TIME'
      end
      item
        Caption = 'ST_RUN_TIME'
      end>
    Font.Charset = RUSSIAN_CHARSET
    Font.Color = clBlack
    Font.Height = -11
    Font.Name = 'Verdana'
    Font.Style = []
    HideSelection = False
    ReadOnly = True
    RowSelect = True
    ParentFont = False
    TabOrder = 0
    ViewStyle = vsReport
    OnChange = ListView1Change
    OnSelectItem = ListView1SelectItem
  end
  object BitBtn1: TBitBtn
    Left = 348
    Top = 8
    Width = 65
    Height = 25
    Anchors = [akTop, akRight]
    Caption = 'Append'
    TabOrder = 1
    OnClick = BitBtn1Click
    Glyph.Data = {
      36030000424D3603000000000000360000002800000010000000100000000100
      18000000000000030000120B0000120B00000000000000000000FB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB
      00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FFFB00FF64B89C64B89CFB00FFFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF64B89C98
      EEC998EEC964B89CFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FF64B89C5EE1A35EE1A364B89CFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF64B89C63
      E5A863E5A864B89CFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FF64B89C64B89C64B89C64B89C67E9AD67E9AD64B89C64B89C64B89C64B8
      9CFB00FFFB00FFFB00FFFB00FFFB00FF64B89CA7F6D5A7F6D5A7F6D5A7F6D56D
      EDB26DEDB2A7F6D5A7F6D5A7F6D5A7F6D564B89CFB00FFFB00FFFB00FFFB00FF
      64B89C72F2B872F2B872F2B872F2B872F2B872F2B872F2B872F2B872F2B872F2
      B864B89CFB00FFFB00FFFB00FFFB00FFFB00FF64B89C64B89C64B89C64B89C76
      F6BD76F6BD64B89C64B89C64B89C64B89CFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FF64B89C7BFAC27BFAC264B89CFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF64B89C7E
      FDC57EFDC564B89CFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FF64B89C81FFC881FFC864B89CFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF64
      B89C64B89CFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB
      00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF}
  end
  object BitBtn2: TBitBtn
    Left = 418
    Top = 8
    Width = 65
    Height = 25
    Anchors = [akTop, akRight]
    Caption = 'Delete'
    TabOrder = 2
    OnClick = BitBtn2Click
    Glyph.Data = {
      36030000424D3603000000000000360000002800000010000000100000000100
      18000000000000030000120B0000120B00000000000000000000FB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB
      00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB
      00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB
      00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FF6464B86464B86464B86464B86464B86464B86464B86464B86464B86464
      B8FB00FFFB00FFFB00FFFB00FFFB00FF6464B8A7A7F6A7A7F6A7A7F6A7A7F6A7
      A7F6A7A7F6A7A7F6A7A7F6A7A7F6A7A7F66464B8FB00FFFB00FFFB00FFFB00FF
      6464B88181FF8181FF8181FF8181FF8181FF8181FF8181FF8181FF8181FF8181
      FF6464B8FB00FFFB00FFFB00FFFB00FFFB00FF6464B86464B86464B86464B864
      64B86464B86464B86464B86464B86464B8FB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB
      00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB
      00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB
      00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF}
  end
  object BitBtn3: TBitBtn
    Left = 668
    Top = 8
    Width = 67
    Height = 25
    Anchors = [akTop, akRight]
    Caption = 'Insert'
    Enabled = False
    TabOrder = 3
    Visible = False
    OnClick = BitBtn3Click
  end
  object PageControl1: TPageControl
    Left = 486
    Top = 8
    Width = 691
    Height = 529
    ActivePage = TabSheet1
    Anchors = [akTop]
    TabOrder = 4
    object TabSheet1: TTabSheet
      Caption = 'General'
      object GroupBox1: TGroupBox
        Left = 8
        Top = 4
        Width = 673
        Height = 113
        Color = clBtnFace
        ParentColor = False
        TabOrder = 0
        object Label9: TLabel
          Left = 13
          Top = 16
          Width = 22
          Height = 13
          Caption = 'PID'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clWindowText
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label43: TLabel
          Left = 10
          Top = 48
          Width = 33
          Height = 13
          Caption = 'Name'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label44: TLabel
          Left = 10
          Top = 80
          Width = 34
          Height = 13
          Caption = 'Desc.'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Edit37: TEdit
          Left = 50
          Top = 48
          Width = 193
          Height = 21
          Font.Charset = RUSSIAN_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'Verdana'
          Font.Style = []
          ParentFont = False
          TabOrder = 0
          OnChange = Edit37Change
        end
        object Edit38: TEdit
          Left = 50
          Top = 80
          Width = 447
          Height = 21
          Font.Charset = RUSSIAN_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'Verdana'
          Font.Style = []
          ParentFont = False
          TabOrder = 1
          OnChange = Edit38Change
        end
        object SpinEdit0: TSpinEdit
          Left = 48
          Top = 16
          Width = 73
          Height = 22
          MaxLength = 5
          MaxValue = 99999
          MinValue = 1
          TabOrder = 2
          Value = 1
        end
        object CheckBox24: TCheckBox
          Left = 128
          Top = 16
          Width = 353
          Height = 17
          Caption = 'Change only PID number, other stats will be not saved'
          TabOrder = 3
          OnClick = CheckBox24Click
        end
      end
      object GroupBox2: TGroupBox
        Left = 8
        Top = 116
        Width = 673
        Height = 225
        Color = clBtnFace
        ParentColor = False
        TabOrder = 1
        object Label2: TLabel
          Left = 26
          Top = 24
          Width = 17
          Height = 13
          Caption = 'ST'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label3: TLabel
          Left = 26
          Top = 51
          Width = 17
          Height = 13
          Caption = 'PE'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label4: TLabel
          Left = 26
          Top = 78
          Width = 18
          Height = 13
          Caption = 'EN'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label5: TLabel
          Left = 26
          Top = 105
          Width = 18
          Height = 13
          Caption = 'CH'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label6: TLabel
          Left = 26
          Top = 132
          Width = 14
          Height = 13
          Caption = 'IN'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label7: TLabel
          Left = 26
          Top = 159
          Width = 18
          Height = 13
          Caption = 'AG'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label8: TLabel
          Left = 26
          Top = 186
          Width = 16
          Height = 13
          Caption = 'LK'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label1: TLabel
          Left = 186
          Top = 24
          Width = 56
          Height = 13
          Caption = 'Hit Points'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label10: TLabel
          Left = 186
          Top = 48
          Width = 76
          Height = 13
          Caption = 'Action Points'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label11: TLabel
          Left = 186
          Top = 72
          Width = 67
          Height = 13
          Caption = 'Armor Class'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label12: TLabel
          Left = 186
          Top = 96
          Width = 85
          Height = 13
          Caption = 'Melee Damage'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label13: TLabel
          Left = 186
          Top = 120
          Width = 74
          Height = 13
          Caption = 'Carry Weight'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label14: TLabel
          Left = 186
          Top = 144
          Width = 58
          Height = 13
          Caption = 'Sequence'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label15: TLabel
          Left = 186
          Top = 168
          Width = 75
          Height = 13
          Caption = 'Healing Rate'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label16: TLabel
          Left = 186
          Top = 192
          Width = 87
          Height = 13
          Caption = 'Critical Chance'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label23: TLabel
          Left = 338
          Top = 24
          Width = 6
          Height = 13
          Caption = '+'
        end
        object Label24: TLabel
          Left = 338
          Top = 48
          Width = 6
          Height = 13
          Caption = '+'
        end
        object Label25: TLabel
          Left = 338
          Top = 72
          Width = 6
          Height = 13
          Caption = '+'
        end
        object Label26: TLabel
          Left = 338
          Top = 96
          Width = 6
          Height = 13
          Caption = '+'
        end
        object Label27: TLabel
          Left = 338
          Top = 120
          Width = 6
          Height = 13
          Caption = '+'
        end
        object Label28: TLabel
          Left = 338
          Top = 144
          Width = 6
          Height = 13
          Caption = '+'
        end
        object Label29: TLabel
          Left = 338
          Top = 168
          Width = 6
          Height = 13
          Caption = '+'
        end
        object Label30: TLabel
          Left = 338
          Top = 192
          Width = 6
          Height = 13
          Caption = '+'
        end
        object Label31: TLabel
          Left = 434
          Top = 24
          Width = 6
          Height = 13
          Caption = '='
        end
        object Label32: TLabel
          Left = 434
          Top = 48
          Width = 6
          Height = 13
          Caption = '='
        end
        object Label33: TLabel
          Left = 434
          Top = 72
          Width = 6
          Height = 13
          Caption = '='
        end
        object Label34: TLabel
          Left = 434
          Top = 96
          Width = 6
          Height = 13
          Caption = '='
        end
        object Label35: TLabel
          Left = 434
          Top = 120
          Width = 6
          Height = 13
          Caption = '='
        end
        object Label36: TLabel
          Left = 434
          Top = 144
          Width = 6
          Height = 13
          Caption = '='
        end
        object Label37: TLabel
          Left = 434
          Top = 168
          Width = 6
          Height = 13
          Caption = '='
        end
        object Label38: TLabel
          Left = 434
          Top = 192
          Width = 6
          Height = 13
          Caption = '='
        end
        object Label102: TLabel
          Left = 648
          Top = 24
          Width = 12
          Height = 16
          Caption = '%'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -13
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
        end
        object Edit1: TEdit
          Left = 50
          Top = 24
          Width = 35
          Height = 21
          TabOrder = 0
          Text = '5'
          OnChange = Edit1Change
        end
        object Edit2: TEdit
          Left = 50
          Top = 51
          Width = 35
          Height = 21
          TabOrder = 1
          Text = '5'
          OnChange = Edit2Change
        end
        object Edit3: TEdit
          Left = 50
          Top = 78
          Width = 35
          Height = 21
          TabOrder = 2
          Text = '5'
          OnChange = Edit3Change
        end
        object Edit4: TEdit
          Left = 50
          Top = 105
          Width = 35
          Height = 21
          TabOrder = 3
          Text = '5'
          OnChange = Edit4Change
        end
        object Edit5: TEdit
          Left = 50
          Top = 132
          Width = 35
          Height = 21
          TabOrder = 4
          Text = '5'
          OnChange = Edit5Change
        end
        object Edit6: TEdit
          Left = 50
          Top = 159
          Width = 35
          Height = 21
          TabOrder = 5
          Text = '5'
          OnChange = Edit6Change
        end
        object Edit7: TEdit
          Left = 50
          Top = 186
          Width = 35
          Height = 21
          TabOrder = 6
          Text = '5'
          OnChange = Edit7Change
        end
        object UpDown1: TUpDown
          Left = 85
          Top = 24
          Width = 16
          Height = 21
          Associate = Edit1
          Min = 1
          Max = 10
          Position = 5
          TabOrder = 7
          Thousands = False
        end
        object UpDown2: TUpDown
          Left = 85
          Top = 51
          Width = 16
          Height = 21
          Associate = Edit2
          Min = 1
          Max = 10
          Position = 5
          TabOrder = 8
          Thousands = False
        end
        object UpDown3: TUpDown
          Left = 85
          Top = 78
          Width = 16
          Height = 21
          Associate = Edit3
          Min = 1
          Max = 10
          Position = 5
          TabOrder = 9
          Thousands = False
        end
        object UpDown4: TUpDown
          Left = 85
          Top = 105
          Width = 16
          Height = 21
          Associate = Edit4
          Min = 1
          Max = 10
          Position = 5
          TabOrder = 10
          Thousands = False
        end
        object UpDown5: TUpDown
          Left = 85
          Top = 132
          Width = 16
          Height = 21
          Associate = Edit5
          Min = 1
          Max = 10
          Position = 5
          TabOrder = 11
          Thousands = False
        end
        object UpDown6: TUpDown
          Left = 85
          Top = 159
          Width = 16
          Height = 21
          Associate = Edit6
          Min = 1
          Max = 10
          Position = 5
          TabOrder = 12
          Thousands = False
        end
        object UpDown7: TUpDown
          Left = 85
          Top = 186
          Width = 16
          Height = 21
          Associate = Edit7
          Min = 1
          Max = 10
          Position = 5
          TabOrder = 13
          Thousands = False
        end
        object Edit8: TEdit
          Left = 282
          Top = 24
          Width = 50
          Height = 21
          Enabled = False
          TabOrder = 14
        end
        object Edit9: TEdit
          Left = 282
          Top = 48
          Width = 50
          Height = 21
          Enabled = False
          TabOrder = 15
        end
        object Edit10: TEdit
          Left = 282
          Top = 72
          Width = 50
          Height = 21
          Enabled = False
          TabOrder = 16
        end
        object Edit11: TEdit
          Left = 282
          Top = 96
          Width = 50
          Height = 21
          Enabled = False
          TabOrder = 17
        end
        object Edit12: TEdit
          Left = 282
          Top = 120
          Width = 50
          Height = 21
          Enabled = False
          TabOrder = 18
        end
        object Edit13: TEdit
          Left = 282
          Top = 144
          Width = 50
          Height = 21
          Enabled = False
          TabOrder = 19
        end
        object Edit14: TEdit
          Left = 282
          Top = 168
          Width = 50
          Height = 21
          Enabled = False
          TabOrder = 20
        end
        object Edit15: TEdit
          Left = 282
          Top = 192
          Width = 50
          Height = 21
          Enabled = False
          TabOrder = 21
        end
        object Edit16: TEdit
          Left = 354
          Top = 24
          Width = 50
          Height = 21
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 22
          Text = '0'
          OnChange = Edit16Change
        end
        object Edit17: TEdit
          Left = 354
          Top = 48
          Width = 50
          Height = 21
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 23
          Text = '0'
          OnChange = Edit17Change
        end
        object Edit18: TEdit
          Left = 354
          Top = 72
          Width = 50
          Height = 21
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 24
          Text = '0'
          OnChange = Edit18Change
        end
        object Edit19: TEdit
          Left = 354
          Top = 96
          Width = 50
          Height = 21
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 25
          Text = '0'
          OnChange = Edit19Change
        end
        object Edit20: TEdit
          Left = 354
          Top = 120
          Width = 50
          Height = 21
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 26
          Text = '0'
          OnChange = Edit20Change
        end
        object Edit21: TEdit
          Left = 354
          Top = 144
          Width = 50
          Height = 21
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 27
          Text = '0'
          OnChange = Edit21Change
        end
        object Edit22: TEdit
          Left = 354
          Top = 168
          Width = 50
          Height = 21
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 28
          Text = '0'
          OnChange = Edit22Change
        end
        object Edit23: TEdit
          Left = 354
          Top = 192
          Width = 50
          Height = 21
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 29
          Text = '0'
          OnChange = Edit23Change
        end
        object Edit24: TEdit
          Left = 450
          Top = 24
          Width = 50
          Height = 21
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 30
        end
        object Edit25: TEdit
          Left = 450
          Top = 48
          Width = 50
          Height = 21
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 31
        end
        object Edit26: TEdit
          Left = 450
          Top = 72
          Width = 50
          Height = 21
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 32
        end
        object Edit27: TEdit
          Left = 450
          Top = 96
          Width = 50
          Height = 21
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 33
        end
        object Edit28: TEdit
          Left = 450
          Top = 120
          Width = 50
          Height = 21
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 34
        end
        object Edit29: TEdit
          Left = 450
          Top = 144
          Width = 50
          Height = 21
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 35
        end
        object Edit30: TEdit
          Left = 450
          Top = 168
          Width = 50
          Height = 21
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 36
        end
        object Edit31: TEdit
          Left = 450
          Top = 192
          Width = 50
          Height = 21
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 37
        end
        object UpDown8: TUpDown
          Left = 404
          Top = 24
          Width = 16
          Height = 21
          Associate = Edit16
          Min = -9999
          Max = 9999
          TabOrder = 38
          Thousands = False
        end
        object UpDown9: TUpDown
          Left = 404
          Top = 48
          Width = 16
          Height = 21
          Associate = Edit17
          Min = -9999
          Max = 9999
          TabOrder = 39
          Thousands = False
        end
        object UpDown10: TUpDown
          Left = 404
          Top = 72
          Width = 16
          Height = 21
          Associate = Edit18
          Min = -90
          Max = 90
          TabOrder = 40
          Thousands = False
        end
        object UpDown11: TUpDown
          Left = 404
          Top = 96
          Width = 16
          Height = 21
          Associate = Edit19
          Min = -9999
          Max = 9999
          TabOrder = 41
          Thousands = False
        end
        object UpDown12: TUpDown
          Left = 404
          Top = 120
          Width = 16
          Height = 21
          Associate = Edit20
          Min = -32677
          Max = 32677
          TabOrder = 42
          Thousands = False
        end
        object UpDown13: TUpDown
          Left = 404
          Top = 144
          Width = 16
          Height = 21
          Associate = Edit21
          Min = -9999
          Max = 9999
          TabOrder = 43
          Thousands = False
        end
        object UpDown14: TUpDown
          Left = 404
          Top = 168
          Width = 16
          Height = 21
          Associate = Edit22
          Min = -9999
          Max = 9999
          TabOrder = 44
          Thousands = False
        end
        object UpDown15: TUpDown
          Left = 404
          Top = 192
          Width = 16
          Height = 21
          Associate = Edit23
          Min = -100
          TabOrder = 45
          Thousands = False
        end
        object SpinEdit1: TSpinEdit
          Left = 592
          Top = 24
          Width = 57
          Height = 22
          Increment = 5
          MaxValue = 200
          MinValue = -200
          TabOrder = 46
          Value = 0
        end
        object BitBtn13: TBitBtn
          Left = 512
          Top = 24
          Width = 75
          Height = 25
          Caption = 'change HP:'
          TabOrder = 47
          OnClick = BitBtn13Click
        end
      end
      object GroupBox3: TGroupBox
        Left = 8
        Top = 340
        Width = 673
        Height = 153
        Color = clBtnFace
        ParentColor = False
        TabOrder = 2
        object Label22: TLabel
          Left = 10
          Top = 25
          Width = 42
          Height = 13
          Caption = 'Kill exp'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label17: TLabel
          Left = 10
          Top = 57
          Width = 61
          Height = 13
          Caption = 'Body Type'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label18: TLabel
          Left = 10
          Top = 81
          Width = 85
          Height = 13
          Caption = 'Locomot. Type'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label20: TLabel
          Left = 10
          Top = 105
          Width = 42
          Height = 13
          Caption = 'Gender'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label64: TLabel
          Left = 266
          Top = 25
          Width = 54
          Height = 13
          Caption = 'Dialog ID'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label65: TLabel
          Left = 266
          Top = 51
          Width = 40
          Height = 13
          Caption = 'Bag ID'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label114: TLabel
          Left = 266
          Top = 105
          Width = 30
          Height = 13
          Caption = 'AI ID'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label115: TLabel
          Left = 266
          Top = 78
          Width = 49
          Height = 13
          Caption = 'Team ID'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Edit33: TEdit
          Left = 96
          Top = 25
          Width = 137
          Height = 21
          TabOrder = 0
          Text = '0'
          OnChange = Edit33Change
        end
        object UpDown17: TUpDown
          Left = 233
          Top = 25
          Width = 16
          Height = 21
          Associate = Edit33
          Max = 9999
          TabOrder = 1
          Thousands = False
        end
        object ComboBox1: TComboBox
          Left = 96
          Top = 57
          Width = 153
          Height = 21
          Style = csDropDownList
          DropDownCount = 15
          ItemHeight = 13
          TabOrder = 2
          OnChange = ComboBox1Change
          OnSelect = ComboBox1Select
          Items.Strings = (
            'BT_MEN'
            'BT_WOMEN'
            'BT_CHILDREN'
            'BT_SUPER_MUTANT'
            'BT_GHOUL'
            'BT_BRAHMIN'
            'BT_RADSCORPION'
            'BT_RAT'
            'BT_FLOATER'
            'BT_CENTAUR'
            'BT_ROBOT'
            'BT_DOG'
            'BT_MANTI'
            'BT_DEADCLAW'
            'BT_PLANT'
            'BT_GECKO'
            'BT_ALIEN'
            'BT_GIANT_ANT'
            'BT_BIG_BAD_BOSS'
            'BT_DESERT_STALKER'
            'BT_MAN_TRAP'
            'BT_RAD_TOAD'
            'BT_THORNSLINGER'
            'BT_PASHTSHUUR')
        end
        object ComboBox2: TComboBox
          Left = 96
          Top = 81
          Width = 153
          Height = 21
          Style = csDropDownList
          ItemHeight = 13
          ItemIndex = 0
          TabOrder = 3
          Text = 'LOCOMOTION_BIPED'
          OnChange = ComboBox2Change
          Items.Strings = (
            'LOCOMOTION_BIPED'
            'LOCOMOTION_QUADRUPED'
            'LOCOMOTION_ROBOTIC'
            'LOCOMOTION_FLY')
        end
        object ComboBox4: TComboBox
          Left = 96
          Top = 105
          Width = 153
          Height = 21
          Style = csDropDownList
          ItemHeight = 13
          ItemIndex = 0
          TabOrder = 4
          Text = 'GENDER_MALE'
          OnChange = ComboBox4Change
          Items.Strings = (
            'GENDER_MALE'
            'GENDER_FEMALE'
            'GENDER_IT')
        end
        object ComboBox5: TComboBox
          Left = 328
          Top = 105
          Width = 179
          Height = 21
          Style = csDropDownList
          DropDownCount = 14
          ItemHeight = 13
          ItemIndex = 0
          TabOrder = 5
          Text = 'PLAYER_AI'
          OnChange = ComboBox5Change
          Items.Strings = (
            'PLAYER_AI'
            'ARROYO_WARRIOR'
            'ARROYO_VILLAGER'
            'ARROYO_ELDER'
            'ARROYO_SHAMAN'
            'SPORE_PLANT'
            'BRAHMIN'
            'RAT'
            'SCORPION'
            'MANTIS'
            'DEATHCLAW'
            'DRUG_ADDICT'
            'GENERIC_GUARDS'
            'THUGS'
            'PEASANTS'
            'CHILD'
            'SLAVER'
            'STORE_OWNER'
            'VAULT_GUARD'
            'DOCTOR'
            'SLAG'
            'GENERIC_DOG'
            'TOUGH_GUARD'
            'KAMAKAZI'
            'TOUGH_CITIZEN'
            'WIMPY_PEASANT'
            'GECKO'
            'FIGHTING_MANTIS'
            'BRAIN_MOLE_RAT'
            'VAULT_DEATHCLAWS'
            'REPAIR_BOT'
            'SECURITY_BOT'
            'TOUGH_BOT'
            'COWARD'
            'TORR'
            'GHOUL_PEASANT'
            'GHOUL_GUARD'
            'GHOUL_MERCHANT'
            'BERSERKER'
            'WIMPY_GECKO'
            'BOXER'
            'PATRON'
            'DRUG_DEALER'
            'BOXING_FAN'
            'PIMP'
            'PROSTITUTE'
            'SLAVE'
            'SUPER_MUTANT'
            'MUTATED_RAT'
            'LONER_CITIZEN'
            'CYBERDOG'
            'REACTOR_GHOUL'
            'REDDING_ADDICT'
            'PARTY_VIC_BERSERK'
            'PARTY_VIC_AGGRESSIVE'
            'PARTY_VIC_DEFENSIVE'
            'PARTY_VIC_COWARD'
            'PARTY_VIC_CUSTOM'
            'PARTY_MYRON_BERSERK'
            'PARTY_MYRON_AGGRESSIVE'
            'PARTY_MYRON_DEFENSIVE'
            'PARTY_MYRON_COWARD'
            'PARTY_MYRON_CUSTOM'
            'PARTY_MARCUS_BERSERK'
            'PARTY_MARCUS_AGGRESSIVE'
            'PARTY_MARCUS_DEFENSIVE'
            'PARTY_MARCUS_COWARD'
            'PARTY_MARCUS_CUSTOM'
            'PARTY_MACRAE_BERSERK'
            'PARTY_MACRAE_AGGRESSIVE'
            'PARTY_MACRAE_DEFENSIVE'
            'PARTY_MACRAE_COWARD'
            'PARTY_MACRAE_CUSTOM'
            'PARTY_SULIK_BERSERK'
            'PARTY_SULIK_AGGRESSIVE'
            'PARTY_SULIK_DEFENSIVE'
            'PARTY_SULIK_COWARD'
            'PARTY_SULIK_CUSTOM'
            'PARTY_LENNY_BERSERK'
            'PARTY_LENNY_AGGRESSIVE'
            'PARTY_LENNY_DEFENSIVE'
            'PARTY_LENNY_COWARD'
            'PARTY_LENNY_CUSTOM'
            'PARTY_CYBERDOG_BERSERK'
            'PARTY_CYBERDOG_AGGRESSIVE'
            'PARTY_CYBERDOG_DEFENSIVE'
            'PARTY_CYBERDOG_COWARD'
            'PARTY_CYBERDOG_CUSTOM'
            'PARTY_DOC_BERSERK'
            'PARTY_DOC_AGGRESSIVE'
            'PARTY_DOC_DEFENSIVE'
            'PARTY_DOC_COWARD'
            'PARTY_DOC_CUSTOM'
            'PARTY_GORIS_BERSERK'
            'PARTY_GORIS_AGGRESSIVE'
            'PARTY_GORIS_DEFENSIVE'
            'PARTY_GORIS_COWARD'
            'PARTY_GORIS_CUSTOM'
            'PARTY_DAVIN_BERSERK'
            'PARTY_DAVIN_AGGRESSIVE'
            'PARTY_DAVIN_DEFENSIVE'
            'PARTY_DAVIN_COWARD'
            'PARTY_DAVIN_CUSTOM'
            'PARTY_MARIA_BERSERK'
            'PARTY_MARIA_AGGRESSIVE'
            'PARTY_MARIA_DEFENSIVE'
            'PARTY_MARIA_COWARD'
            'PARTY_MARIA_CUSTOM'
            'PARTY_LADDIE_BERSERK'
            'PARTY_LADDIE_AGGRESSIVE'
            'PARTY_LADDIE_DEFENSIVE'
            'PARTY_LADDIE_COWARD'
            'PARTY_LADDIE_CUSTOM'
            'PARTY_ROBOBRAIN_BERSERK'
            'PARTY_ROBOBRAIN_AGGRESSIVE'
            'PARTY_ROBOBRAIN_DEFENSIVE'
            'PARTY_ROBOBRAIN_COWARD'
            'PARTY_ROBOBRAIN_CUSTOM'
            'PARTY_BESS_BERSERK'
            'PARTY_BESS_AGGRESSIVE'
            'PARTY_BESS_DEFENSIVE'
            'PARTY_BESS_COWARD'
            'PARTY_BESS_CUSTOM'
            'SCARED_BRAHMIN'
            'BOUNTY_HUNTER'
            'MYSTERIOUS_STRANGER'
            'DUNTON'
            'NCR_RANGERS'
            'MOBSTERS'
            'MASTERS_ARMY'
            'ALIEN'
            'MEAN_DEATHCLAW'
            'FLOATER'
            'CENTAUR'
            'ENCLAVE_PATROL'
            'MERC_CAPTAIN'
            'MERC_RAIDER'
            'SHADOW_WHO_WALKS'
            'THE_DRAGON'
            'LOPAN'
            'REDDING_MINER'
            'KAGA'
            'END_BOSS'
            'DUMAR'
            'FIRE_GECKOS'
            'CRAZED_ROBOT'
            'RAT_GOD'
            'TOUGH_MERCHANT'
            'CRAZY_ADDICT'
            'ALGERNON'
            'OZ7'
            'OZ9'
            'BADGER'
            'SHI'
            'CHIP'
            'RYAN'
            'SHI_GUARD'
            'ELRON'
            'ELRON_GUARD'
            'RON_CRUZ'
            'NIKKI_GOLDMAN'
            'PUNK'
            'KHAN'
            'TOUGH_KHAN'
            'PARTY_DOGMEAT_AGRESSIVE'
            'PARTY_DOGMEAT_BERSERK'
            'PARTY_DOGMEAT_COWARD'
            'PARTY_DOGMEAT_CUSTOM'
            'PARTY_DOGMEAT_DEFENSIVE'
            'PARTY_PARIADOG_AGRESSIVE'
            'PARTY_PARIADOG_BERSERK'
            'PARTY_PARIADOG_COWARD'
            'PARTY_PARIADOG_CUSTOM'
            'PARTY_PARIADOG_DEFENSIVE'
            'ROBOT_TURRET'
            'NAVARRO_GUARD'
            'GUN_TURRET'
            'THE_BRAIN'
            'BRAHMIN_WIMPY'
            'ADDICT_WIMPY'
            'PEASANT_NO_MOVE'
            'CARAVAN_GUARD'
            'CARAVAN_DRIVER'
            'PEASANT_KAMAKAZI'
            'PRIMITIVE_COWARD'
            'PRIMITIVE_KAMAKAZI'
            'DOG_TOUGH'
            'FO1_PLAYER_AI'
            'FO1_BERZERKER'
            'FO1_CAREFUL'
            'FO1_COW'
            'FO1_GUARD'
            'FO1_LOSER'
            'FO1_PEASANT'
            'FO1_SUPER_MUTANT'
            'FO1_DOG'
            'FO1_GHOUL'
            'FO1_MUTANT_GUARDS'
            'FO1_BOUNCER'
            'FO1_RATS'
            'FO1_MOLE_RATS'
            'FO1_RADSCORPION'
            'FO1_GUARD_GUNG_HO'
            'FO1_GUARD_SADISTIC'
            'FO1_GUARD_HUMOROUS'
            'FO1_GUARD_QUIET'
            'FO1_GUARD_SMARTASS'
            'FO1_GENERIC_RAIDER'
            'FO1_RAIDER_GUARD'
            'FO1_RAIDER_LEADER'
            'FO1_SHADY_SANDS_PEASANT'
            'FO1_SHADY_SANDS_GUARD'
            'FO1_SHADY_SANDS_LEADER'
            'FO1_RIPPERS'
            'FO1_BLADES'
            'FO1_GUNRUNNERS'
            'FO1_REGULATORS'
            'FO1_ADYTOWNER'
            'FO1_GENERIC_FOLLOWER'
            'FO1_FOLLOWER_SCOUT'
            'FO1_FOLLOWER_GUARD'
            'FO1_FOLLOWER_LEADER'
            'FO1_RIPPER_LEADER'
            'FO1_BLADE_SCOUT'
            'FO1_BLADE_LEADER'
            'FO1_GUNRUNNER_LEADER'
            'FO1_ADYTUM_LEADER'
            'FO1_GHOUL_COWARD'
            'FO1_GHOUL_NORMAL'
            'FO1_GHOUL_BRAVE'
            'FO1_GARL_HONOR'
            'FO1_EMPTY_SLOT_1'
            'FO1_EMPTY_SLOT_2'
            'FO1_SUPER_MUTANT_GUARD'
            'FO1_SUPER_MUTANT_NORMAL'
            'FO1_SUPER_MUTANT_AGGRESSIVE'
            'FO1_SUPER_MUTANT_SGT_'
            'FO1_MERCHANT'
            'FO1_HUB_PEASANTS'
            'FO1_HUB_THIEF'
            'FO1_HUB_MUTANTS'
            'FO1_DEATHCLAW'
            'FO1_JUNKTOWN_PEASANT'
            'FO1_JUNKTOWN_GUARD'
            'FO1_KILLIAN'
            'FO1_JUNKTOWN_THUG'
            'FO1_SKULZ'
            'FO1_GIZMO'
            'FO1_SELLBABIES'
            'FO1_BROTHERHOOD_INITIATE'
            'FO1_BROTHERHOOD_SCRIBE'
            'FO1_BROTHERHOOD_KNIGHT'
            'FO1_BROTHERHOOD_PALADIN'
            'FO1_NIGHTKIN'
            'FO1_BRAINWASHED_CHILDREN'
            'FO1_LITTLE_KIDS'
            'FO1_CHILDREN_TRUE'
            'FO1_MASTER'
            'FO1_ROBOTS'
            'FO1_CENTAUR'
            'FO1_FLOATER'
            'FO1_EYEBALL'
            'FO1_MARCELLES'
            'FO1_GUARD_ROOKIE'
            'FO1_COC_HUB_BRAINWASHED'
            'FO1_GHOUL_NASTY'
            'FO1_SUPER_MUTANT_NECRO'
            'FO1_BOS_ELDERS'
            'FO1_BOS_RHOMBUS'
            'FO1_COC_MORPHEUS'
            'FO1_COC_LASHER'
            'FO1_COC_JAIN'
            'FO1_HUB_UNDERGROUND'
            'FO1_HUB_POLICE'
            'FO1_DECKER'
            'FO1_CAIN'
            'FO1_IAN'
            'FO1_TYCHO'
            'FO1_VAULTDWELLER'
            'FO1_STRANGER'
            'FO1_GHOUL_MINDLESS'
            'FO1_RUNAWAY')
        end
        object ComboBox6: TComboBox
          Left = 370
          Top = 78
          Width = 137
          Height = 21
          Style = csDropDownList
          DropDownCount = 16
          ItemHeight = 13
          ItemIndex = 0
          TabOrder = 6
          Text = 'TEAM_Default'
          OnChange = ComboBox6Change
          Items.Strings = (
            'TEAM_Default'
            'TEAM_Player'
            'TEAM_Poorman'
            'TEAM_Narcoman'
            'TEAM_Citizen'
            'TEAM_Guard'
            'TEAM_PrivateGuard'
            'TEAM_Trader'
            'TEAM_Bandit'
            'TEAM_CasinoPlayer'
            'TEAM_BoSTrooper'
            'TEAM_EnclaveTrooper'
            'TEAM_ShiTrooper'
            'TEAM_CityElite'
            'TEAM_QuestNpc'
            'TEAM_BountyHunters'
            'TEAM_Police'
            'TEAM_Cattle'
            'TEAM_Animals'
            'TEAM_ReplicationTurret'
            'TEAM_ReplictionHubb'
            'TEAM_Slaver'
            'TEAM_Slave'
            'TEAM_Trapper'
            'TEAM_Mob0'
            'TEAM_Mob1'
            'TEAM_Mob2'
            'TEAM_Mob3'
            'TEAM_Mob4'
            'TEAM_Mob5'
            'TEAM_Mob6'
            'TEAM_Mob7'
            'TEAM_Mob8'
            'TEAM_Mob9')
        end
        object SpinEdit40: TSpinEdit
          Left = 368
          Top = 24
          Width = 137
          Height = 22
          MaxLength = 7
          MaxValue = 9999999
          MinValue = 0
          TabOrder = 7
          Value = 0
        end
        object SpinEdit59: TSpinEdit
          Left = 368
          Top = 48
          Width = 137
          Height = 22
          MaxLength = 4
          MaxValue = 9999
          MinValue = 0
          TabOrder = 8
          Value = 0
        end
      end
    end
    object TabSheet2: TTabSheet
      Caption = 'Skills'
      ImageIndex = 1
      object GroupBox5: TGroupBox
        Left = 8
        Top = 0
        Width = 673
        Height = 497
        Caption = 'Skills'
        TabOrder = 0
        DesignSize = (
          673
          497)
        object Label45: TLabel
          Left = 16
          Top = 24
          Width = 62
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = 'Small guns'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label46: TLabel
          Left = 16
          Top = 50
          Width = 50
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = 'Big guns'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label47: TLabel
          Left = 16
          Top = 76
          Width = 71
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = 'Energy guns'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label48: TLabel
          Left = 16
          Top = 102
          Width = 78
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = 'Close Combat'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label49: TLabel
          Left = 16
          Top = 128
          Width = 68
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = 'Scavenging'
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label50: TLabel
          Left = 16
          Top = 154
          Width = 53
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = 'Throwing'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label51: TLabel
          Left = 16
          Top = 180
          Width = 47
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = 'First Aid'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label52: TLabel
          Left = 16
          Top = 206
          Width = 39
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = 'Doctor'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label53: TLabel
          Left = 16
          Top = 232
          Width = 37
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = 'Sneak'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label54: TLabel
          Left = 16
          Top = 258
          Width = 53
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = 'Lockpick'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label55: TLabel
          Left = 16
          Top = 284
          Width = 30
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = 'Steal'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label56: TLabel
          Left = 16
          Top = 310
          Width = 33
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = 'Traps'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label57: TLabel
          Left = 16
          Top = 336
          Width = 47
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = 'Science'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label58: TLabel
          Left = 16
          Top = 362
          Width = 38
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = 'Repair'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label59: TLabel
          Left = 16
          Top = 388
          Width = 44
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = 'Speech'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label60: TLabel
          Left = 16
          Top = 414
          Width = 35
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = 'Barter'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label61: TLabel
          Left = 16
          Top = 440
          Width = 53
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = 'Gambling'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label62: TLabel
          Left = 16
          Top = 466
          Width = 75
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = 'Outdoorsman'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label66: TLabel
          Left = 208
          Top = 466
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '+'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label67: TLabel
          Left = 208
          Top = 440
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '+'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label68: TLabel
          Left = 208
          Top = 414
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '+'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label69: TLabel
          Left = 208
          Top = 388
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '+'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label70: TLabel
          Left = 208
          Top = 362
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '+'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label71: TLabel
          Left = 208
          Top = 336
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '+'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label72: TLabel
          Left = 208
          Top = 310
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '+'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label73: TLabel
          Left = 208
          Top = 284
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '+'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label74: TLabel
          Left = 208
          Top = 258
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '+'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label75: TLabel
          Left = 208
          Top = 232
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '+'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label76: TLabel
          Left = 208
          Top = 206
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '+'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label77: TLabel
          Left = 208
          Top = 180
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '+'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label78: TLabel
          Left = 208
          Top = 154
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '+'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label79: TLabel
          Left = 208
          Top = 128
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '+'
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label80: TLabel
          Left = 208
          Top = 102
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '+'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label81: TLabel
          Left = 208
          Top = 76
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '+'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label82: TLabel
          Left = 208
          Top = 50
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '+'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label83: TLabel
          Left = 208
          Top = 24
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '+'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label84: TLabel
          Left = 400
          Top = 466
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '='
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label85: TLabel
          Left = 400
          Top = 440
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '='
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label86: TLabel
          Left = 400
          Top = 414
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '='
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label87: TLabel
          Left = 400
          Top = 388
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '='
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label88: TLabel
          Left = 400
          Top = 362
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '='
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label89: TLabel
          Left = 400
          Top = 336
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '='
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label90: TLabel
          Left = 400
          Top = 310
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '='
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label91: TLabel
          Left = 400
          Top = 284
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '='
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label92: TLabel
          Left = 400
          Top = 258
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '='
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label93: TLabel
          Left = 400
          Top = 232
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '='
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label94: TLabel
          Left = 400
          Top = 206
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '='
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label95: TLabel
          Left = 400
          Top = 180
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '='
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label96: TLabel
          Left = 400
          Top = 154
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '='
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label97: TLabel
          Left = 400
          Top = 128
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '='
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label98: TLabel
          Left = 400
          Top = 102
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '='
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label99: TLabel
          Left = 400
          Top = 76
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '='
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label100: TLabel
          Left = 400
          Top = 50
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '='
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label101: TLabel
          Left = 400
          Top = 24
          Width = 8
          Height = 13
          Anchors = [akLeft, akBottom]
          Caption = '='
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Image2: TImage
          Left = 330
          Top = 24
          Width = 25
          Height = 457
          Center = True
          Enabled = False
          Picture.Data = {
            07544269746D6170725D0000424D725D00000000000036000000280000001100
            0000CB01000001001800000000003C5D00000000000000000000000000000000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0000000000000000000000000000000
            0000000000000000000000000000000000000000000000000000000000000000
            000000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000000000000000
            0000000000000000000000000000000000000000000000000000000000000000
            0000000000000000000000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000000000000000000000000000000000000000000000000000000000000000
            00000000000000000000000000000000000000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F00000000000000000000000000000000000000000000000000000
            000000000000000000000000000000000000000000000000000000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0000000000000000000000000000000000000
            0000000000000000000000000000000000000000000000000000000000000000
            000000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000000000000000
            0000000000000000000000000000000000000000000000000000000000000000
            0000000000000000000000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000000000000000000000000000000000000000000000000000000000000000
            00000000000000000000000000000000000000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F00000000000000000000000000000000000000000000000000000
            000000000000000000000000000000000000000000000000000000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0000000000000000000000000000000000000
            0000000000000000000000000000000000000000000000000000000000000000
            000000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000000000000000
            0000000000000000000000000000000000000000000000000000000000000000
            0000000000000000000000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000000000000000000000000000000000000000000000000000000000000000
            00000000000000000000000000000000000000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F00000000000000000000000000000000000000000000000000000
            000000000000000000000000000000000000000000000000000000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0000000000000000000000000000000000000
            0000000000000000000000000000000000000000000000000000000000000000
            000000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000000000000000
            0000000000000000000000000000000000000000000000000000000000000000
            0000000000000000000000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000000000000000000000000000000000000000000000000000000000000000
            00000000000000000000000000000000000000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F00000000000000000000000000000000000000000000000000000
            000000000000000000000000000000000000000000000000000000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0000000000000000000000000000000000000
            0000000000000000000000000000000000000000000000000000000000000000
            000000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000000000000000
            0000000000000000000000000000000000000000000000000000000000000000
            0000000000000000000000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F00000
            0000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F000000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0
            F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000}
          Transparent = True
          Visible = False
        end
        object Edit41: TEdit
          Left = 120
          Top = 24
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          TabOrder = 0
          Text = '0'
          OnChange = Edit61Change
        end
        object Edit42: TEdit
          Left = 120
          Top = 50
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          TabOrder = 1
          Text = '0'
          OnChange = Edit62Change
        end
        object Edit43: TEdit
          Left = 120
          Top = 76
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          TabOrder = 2
          Text = '0'
          OnChange = Edit63Change
        end
        object Edit44: TEdit
          Left = 120
          Top = 102
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          TabOrder = 3
          Text = '0'
          OnChange = Edit64Change
        end
        object Edit45: TEdit
          Left = 120
          Top = 128
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          TabOrder = 4
          Text = '0'
          OnChange = Edit65Change
        end
        object Edit46: TEdit
          Left = 120
          Top = 154
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          TabOrder = 5
          Text = '0'
          OnChange = Edit66Change
        end
        object Edit47: TEdit
          Left = 120
          Top = 180
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          TabOrder = 6
          Text = '0'
          OnChange = Edit67Change
        end
        object Edit48: TEdit
          Left = 120
          Top = 206
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          TabOrder = 7
          Text = '0'
          OnChange = Edit68Change
        end
        object Edit49: TEdit
          Left = 120
          Top = 232
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          TabOrder = 8
          Text = '0'
          OnChange = Edit69Change
        end
        object Edit50: TEdit
          Left = 120
          Top = 258
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          TabOrder = 9
          Text = '0'
          OnChange = Edit70Change
        end
        object Edit51: TEdit
          Left = 120
          Top = 284
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          TabOrder = 10
          Text = '0'
          OnChange = Edit71Change
        end
        object Edit52: TEdit
          Left = 120
          Top = 310
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          TabOrder = 11
          Text = '0'
          OnChange = Edit72Change
        end
        object Edit53: TEdit
          Left = 120
          Top = 336
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          TabOrder = 12
          Text = '0'
          OnChange = Edit73Change
        end
        object Edit54: TEdit
          Left = 120
          Top = 362
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          TabOrder = 13
          Text = '0'
          OnChange = Edit74Change
        end
        object Edit55: TEdit
          Left = 120
          Top = 388
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          TabOrder = 14
          Text = '0'
          OnChange = Edit75Change
        end
        object Edit56: TEdit
          Left = 120
          Top = 414
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          TabOrder = 15
          Text = '0'
          OnChange = Edit76Change
        end
        object Edit57: TEdit
          Left = 120
          Top = 440
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          TabOrder = 16
          Text = '0'
          OnChange = Edit77Change
        end
        object Edit58: TEdit
          Left = 120
          Top = 466
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          TabOrder = 17
          Text = '0'
          OnChange = Edit78Change
        end
        object UpDown23: TUpDown
          Left = 308
          Top = 24
          Width = 17
          Height = 21
          Anchors = [akLeft, akBottom]
          Associate = Edit61
          Min = -300
          Max = 300
          TabOrder = 18
          Thousands = False
        end
        object UpDown24: TUpDown
          Left = 308
          Top = 50
          Width = 17
          Height = 21
          Anchors = [akLeft, akBottom]
          Associate = Edit62
          Min = -300
          Max = 300
          TabOrder = 19
          Thousands = False
        end
        object UpDown25: TUpDown
          Left = 308
          Top = 76
          Width = 17
          Height = 21
          Anchors = [akLeft, akBottom]
          Associate = Edit63
          Min = -300
          Max = 300
          TabOrder = 20
          Thousands = False
        end
        object UpDown26: TUpDown
          Left = 308
          Top = 102
          Width = 17
          Height = 21
          Anchors = [akLeft, akBottom]
          Associate = Edit64
          Min = -300
          Max = 300
          TabOrder = 21
          Thousands = False
        end
        object UpDown27: TUpDown
          Left = 308
          Top = 128
          Width = 17
          Height = 21
          Anchors = [akLeft, akBottom]
          Associate = Edit65
          Enabled = False
          Min = -300
          Max = 300
          TabOrder = 22
          Thousands = False
        end
        object UpDown28: TUpDown
          Left = 308
          Top = 154
          Width = 17
          Height = 21
          Anchors = [akLeft, akBottom]
          Associate = Edit66
          Min = -300
          Max = 300
          TabOrder = 23
          Thousands = False
        end
        object UpDown29: TUpDown
          Left = 308
          Top = 180
          Width = 17
          Height = 21
          Anchors = [akLeft, akBottom]
          Associate = Edit67
          Min = -300
          Max = 300
          TabOrder = 24
          Thousands = False
        end
        object UpDown30: TUpDown
          Left = 308
          Top = 206
          Width = 17
          Height = 21
          Anchors = [akLeft, akBottom]
          Associate = Edit68
          Min = -300
          Max = 300
          TabOrder = 25
          Thousands = False
        end
        object UpDown31: TUpDown
          Left = 308
          Top = 232
          Width = 17
          Height = 21
          Anchors = [akLeft, akBottom]
          Associate = Edit69
          Min = -300
          Max = 300
          TabOrder = 26
          Thousands = False
        end
        object UpDown32: TUpDown
          Left = 308
          Top = 258
          Width = 17
          Height = 21
          Anchors = [akLeft, akBottom]
          Associate = Edit70
          Min = -300
          Max = 300
          TabOrder = 27
          Thousands = False
        end
        object UpDown33: TUpDown
          Left = 308
          Top = 284
          Width = 17
          Height = 21
          Anchors = [akLeft, akBottom]
          Associate = Edit71
          Min = -300
          Max = 300
          TabOrder = 28
          Thousands = False
        end
        object UpDown34: TUpDown
          Left = 308
          Top = 310
          Width = 17
          Height = 21
          Anchors = [akLeft, akBottom]
          Associate = Edit72
          Min = -300
          Max = 300
          TabOrder = 29
          Thousands = False
        end
        object UpDown35: TUpDown
          Left = 308
          Top = 336
          Width = 17
          Height = 21
          Anchors = [akLeft, akBottom]
          Associate = Edit73
          Min = -300
          Max = 300
          TabOrder = 30
          Thousands = False
        end
        object UpDown36: TUpDown
          Left = 308
          Top = 362
          Width = 17
          Height = 21
          Anchors = [akLeft, akBottom]
          Associate = Edit74
          Min = -300
          Max = 300
          TabOrder = 31
          Thousands = False
        end
        object UpDown37: TUpDown
          Left = 308
          Top = 388
          Width = 17
          Height = 21
          Anchors = [akLeft, akBottom]
          Associate = Edit75
          Min = -300
          Max = 300
          TabOrder = 32
          Thousands = False
        end
        object UpDown38: TUpDown
          Left = 308
          Top = 414
          Width = 17
          Height = 21
          Anchors = [akLeft, akBottom]
          Associate = Edit76
          Min = -300
          Max = 300
          TabOrder = 33
          Thousands = False
        end
        object UpDown39: TUpDown
          Left = 308
          Top = 440
          Width = 17
          Height = 21
          Anchors = [akLeft, akBottom]
          Associate = Edit77
          Min = -300
          Max = 300
          TabOrder = 34
          Thousands = False
        end
        object UpDown40: TUpDown
          Left = 308
          Top = 466
          Width = 17
          Height = 21
          Anchors = [akLeft, akBottom]
          Associate = Edit78
          Min = -300
          Max = 300
          TabOrder = 35
          Thousands = False
        end
        object Edit61: TEdit
          Left = 248
          Top = 24
          Width = 60
          Height = 21
          TabStop = False
          Anchors = [akLeft, akBottom]
          ReadOnly = True
          TabOrder = 36
          Text = '0'
          OnChange = Edit61Change
        end
        object Edit62: TEdit
          Left = 248
          Top = 50
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          ReadOnly = True
          TabOrder = 37
          Text = '0'
          OnChange = Edit62Change
        end
        object Edit63: TEdit
          Left = 248
          Top = 76
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          ReadOnly = True
          TabOrder = 38
          Text = '0'
          OnChange = Edit63Change
        end
        object Edit64: TEdit
          Left = 248
          Top = 102
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          ReadOnly = True
          TabOrder = 39
          Text = '0'
          OnChange = Edit64Change
        end
        object Edit65: TEdit
          Left = 248
          Top = 128
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          ReadOnly = True
          TabOrder = 40
          Text = '0'
          OnChange = Edit65Change
        end
        object Edit66: TEdit
          Left = 248
          Top = 154
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          ReadOnly = True
          TabOrder = 41
          Text = '0'
          OnChange = Edit66Change
        end
        object Edit67: TEdit
          Left = 248
          Top = 180
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          ReadOnly = True
          TabOrder = 42
          Text = '0'
          OnChange = Edit67Change
        end
        object Edit68: TEdit
          Left = 248
          Top = 206
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          ReadOnly = True
          TabOrder = 43
          Text = '0'
          OnChange = Edit68Change
        end
        object Edit69: TEdit
          Left = 248
          Top = 232
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          ReadOnly = True
          TabOrder = 44
          Text = '0'
          OnChange = Edit69Change
        end
        object Edit70: TEdit
          Left = 248
          Top = 258
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          ReadOnly = True
          TabOrder = 45
          Text = '0'
          OnChange = Edit70Change
        end
        object Edit71: TEdit
          Left = 248
          Top = 284
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          ReadOnly = True
          TabOrder = 46
          Text = '0'
          OnChange = Edit71Change
        end
        object Edit72: TEdit
          Left = 248
          Top = 310
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          ReadOnly = True
          TabOrder = 47
          Text = '0'
          OnChange = Edit72Change
        end
        object Edit73: TEdit
          Left = 248
          Top = 336
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          ReadOnly = True
          TabOrder = 48
          Text = '0'
          OnChange = Edit73Change
        end
        object Edit74: TEdit
          Left = 248
          Top = 362
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          ReadOnly = True
          TabOrder = 49
          Text = '0'
          OnChange = Edit74Change
        end
        object Edit75: TEdit
          Left = 248
          Top = 388
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          ReadOnly = True
          TabOrder = 50
          Text = '0'
          OnChange = Edit75Change
        end
        object Edit76: TEdit
          Left = 248
          Top = 414
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          ReadOnly = True
          TabOrder = 51
          Text = '0'
          OnChange = Edit76Change
        end
        object Edit77: TEdit
          Left = 248
          Top = 440
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          ReadOnly = True
          TabOrder = 52
          Text = '0'
          OnChange = Edit77Change
        end
        object Edit78: TEdit
          Left = 248
          Top = 466
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          ReadOnly = True
          TabOrder = 53
          Text = '0'
          OnChange = Edit78Change
        end
        object Edit81: TEdit
          Left = 432
          Top = 24
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 54
          Text = '0'
        end
        object Edit82: TEdit
          Left = 432
          Top = 50
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 55
          Text = '0'
        end
        object Edit83: TEdit
          Left = 432
          Top = 76
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 56
          Text = '0'
        end
        object Edit84: TEdit
          Left = 432
          Top = 102
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 57
          Text = '0'
        end
        object Edit85: TEdit
          Left = 432
          Top = 128
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentFont = False
          TabOrder = 58
          Text = '0'
        end
        object Edit86: TEdit
          Left = 432
          Top = 154
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 59
          Text = '0'
        end
        object Edit87: TEdit
          Left = 432
          Top = 180
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 60
          Text = '0'
        end
        object Edit88: TEdit
          Left = 432
          Top = 206
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 61
          Text = '0'
        end
        object Edit89: TEdit
          Left = 432
          Top = 232
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 62
          Text = '0'
        end
        object Edit90: TEdit
          Left = 432
          Top = 258
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 63
          Text = '0'
        end
        object Edit91: TEdit
          Left = 432
          Top = 284
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 64
          Text = '0'
        end
        object Edit92: TEdit
          Left = 432
          Top = 310
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 65
          Text = '0'
        end
        object Edit93: TEdit
          Left = 432
          Top = 336
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 66
          Text = '0'
        end
        object Edit94: TEdit
          Left = 432
          Top = 362
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 67
          Text = '0'
        end
        object Edit95: TEdit
          Left = 432
          Top = 388
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 68
          Text = '0'
        end
        object Edit96: TEdit
          Left = 432
          Top = 414
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 69
          Text = '0'
        end
        object Edit97: TEdit
          Left = 432
          Top = 440
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 70
          Text = '0'
        end
        object Edit98: TEdit
          Left = 432
          Top = 466
          Width = 60
          Height = 21
          Anchors = [akLeft, akBottom]
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 71
          Text = '0'
        end
        object CheckBox39: TCheckBox
          Left = 311
          Top = 7
          Width = 90
          Height = 17
          Anchors = [akLeft, akBottom]
          Caption = 'increment x 10'
          TabOrder = 72
          OnClick = CheckBox39Click
        end
      end
    end
    object TabSheet3: TTabSheet
      Caption = 'Mode'
      ImageIndex = 2
      object GroupBox4: TGroupBox
        Left = 8
        Top = 280
        Width = 673
        Height = 217
        Caption = 'Other stats'
        TabOrder = 0
        object Label40: TLabel
          Left = 18
          Top = 64
          Width = 73
          Height = 13
          Caption = 'Scale Factor'
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label21: TLabel
          Left = 18
          Top = 96
          Width = 23
          Height = 13
          Caption = 'Age'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label19: TLabel
          Left = 18
          Top = 32
          Width = 79
          Height = 13
          Caption = 'Damage Type'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label124: TLabel
          Left = 18
          Top = 144
          Width = 32
          Height = 13
          Caption = 'Toxic'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label125: TLabel
          Left = 18
          Top = 176
          Width = 69
          Height = 13
          Caption = 'Radioactive'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label63: TLabel
          Left = 298
          Top = 40
          Width = 62
          Height = 13
          Caption = 'ST_LEVEL'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label116: TLabel
          Left = 298
          Top = 72
          Width = 96
          Height = 13
          Caption = 'ST_WALK_TIME'
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label117: TLabel
          Left = 298
          Top = 104
          Width = 88
          Height = 13
          Caption = 'ST_RUN_TIME'
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Edit35: TEdit
          Left = 106
          Top = 64
          Width = 119
          Height = 21
          Enabled = False
          TabOrder = 0
          Text = '0'
          OnChange = Edit35Change
        end
        object UpDown19: TUpDown
          Left = 225
          Top = 64
          Width = 16
          Height = 21
          Associate = Edit35
          Enabled = False
          Max = 0
          TabOrder = 1
          Thousands = False
        end
        object UpDown16: TUpDown
          Left = 225
          Top = 96
          Width = 16
          Height = 21
          Associate = Edit32
          Min = 16
          Max = 60
          Position = 25
          TabOrder = 2
          Thousands = False
        end
        object Edit32: TEdit
          Left = 106
          Top = 96
          Width = 119
          Height = 21
          TabOrder = 3
          Text = '25'
          OnChange = Edit32Change
        end
        object ComboBox3: TComboBox
          Left = 106
          Top = 32
          Width = 135
          Height = 21
          Style = csDropDownList
          ItemHeight = 13
          ItemIndex = 1
          TabOrder = 4
          Text = 'DAMAGE_NORMAL'
          OnChange = ComboBox3Change
          Items.Strings = (
            'DAMAGE_UNCALLED'
            'DAMAGE_NORMAL'
            'DAMAGE_LASER'
            'DAMAGE_FIRE'
            'DAMAGE_PLASMA'
            'DAMAGE_ELECTR'
            'DAMAGE_EMP'
            'DAMAGE_EXPLODE')
        end
        object Edit116: TEdit
          Left = 106
          Top = 144
          Width = 119
          Height = 21
          TabOrder = 5
          Text = '0'
          OnChange = Edit116Change
        end
        object UpDown45: TUpDown
          Left = 225
          Top = 144
          Width = 17
          Height = 21
          Associate = Edit116
          Max = 1000
          TabOrder = 6
          Thousands = False
        end
        object Edit117: TEdit
          Left = 106
          Top = 176
          Width = 119
          Height = 21
          TabOrder = 7
          Text = '0'
          OnChange = Edit117Change
        end
        object UpDown46: TUpDown
          Left = 225
          Top = 176
          Width = 17
          Height = 21
          Associate = Edit117
          Max = 1000
          TabOrder = 8
          Thousands = False
        end
        object SpinEdit1000: TSpinEdit
          Left = 400
          Top = 32
          Width = 97
          Height = 22
          MaxLength = 4
          MaxValue = 9999
          MinValue = 0
          TabOrder = 9
          Value = 0
        end
        object SpinEdit1001: TSpinEdit
          Left = 400
          Top = 64
          Width = 97
          Height = 22
          Enabled = False
          MaxLength = 5
          MaxValue = 99999
          MinValue = 0
          TabOrder = 10
          Value = 0
        end
        object SpinEdit1002: TSpinEdit
          Left = 400
          Top = 96
          Width = 97
          Height = 22
          Enabled = False
          MaxLength = 5
          MaxValue = 99999
          MinValue = 0
          TabOrder = 11
          Value = 0
        end
      end
      object GroupBox6: TGroupBox
        Left = 8
        Top = 4
        Width = 673
        Height = 273
        Caption = 'MODE'
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'MS Sans Serif'
        Font.Style = []
        ParentFont = False
        TabOrder = 1
        object CheckBox1: TCheckBox
          Left = 8
          Top = 24
          Width = 170
          Height = 17
          Caption = 'MODE_HIDE'
          TabOrder = 0
          OnClick = CheckBox1Click
        end
        object CheckBox2: TCheckBox
          Left = 8
          Top = 48
          Width = 170
          Height = 17
          Caption = 'MODE_NO_STEAL'
          TabOrder = 1
          OnClick = CheckBox2Click
        end
        object CheckBox3: TCheckBox
          Left = 8
          Top = 72
          Width = 170
          Height = 17
          Caption = 'MODE_NO_BARTER'
          TabOrder = 2
          OnClick = CheckBox3Click
        end
        object CheckBox4: TCheckBox
          Left = 8
          Top = 96
          Width = 170
          Height = 17
          Caption = 'MODE_NO_ENEMY_STACK'
          TabOrder = 3
          OnClick = CheckBox4Click
        end
        object CheckBox5: TCheckBox
          Left = 8
          Top = 120
          Width = 170
          Height = 17
          Caption = 'MODE_NO_PVP'
          TabOrder = 4
          OnClick = CheckBox5Click
        end
        object CheckBox6: TCheckBox
          Left = 8
          Top = 144
          Width = 170
          Height = 17
          Caption = 'MODE_NO_HOME'
          TabOrder = 5
          OnClick = CheckBox6Click
        end
        object CheckBox7: TCheckBox
          Left = 8
          Top = 168
          Width = 170
          Height = 17
          Caption = 'MODE_DLG_SCRIPT_BARTER'
          TabOrder = 6
          OnClick = CheckBox7Click
        end
        object CheckBox8: TCheckBox
          Left = 8
          Top = 192
          Width = 170
          Height = 17
          Caption = 'MODE_UNLIMITED_AMMO'
          TabOrder = 7
          OnClick = CheckBox8Click
        end
        object CheckBox9: TCheckBox
          Left = 8
          Top = 216
          Width = 170
          Height = 17
          Caption = 'MODE_NO_DROP'
          TabOrder = 8
          OnClick = CheckBox9Click
        end
        object CheckBox10: TCheckBox
          Left = 8
          Top = 240
          Width = 170
          Height = 17
          Caption = 'MODE_NO_LOOSE_LIMBS'
          TabOrder = 9
          OnClick = CheckBox10Click
        end
        object CheckBox11: TCheckBox
          Left = 192
          Top = 24
          Width = 160
          Height = 17
          Caption = 'MODE_DEAD_AGES'
          TabOrder = 10
          OnClick = CheckBox11Click
        end
        object CheckBox12: TCheckBox
          Left = 192
          Top = 48
          Width = 160
          Height = 17
          Caption = 'MODE_NO_HEAL'
          TabOrder = 11
          OnClick = CheckBox12Click
        end
        object CheckBox13: TCheckBox
          Left = 192
          Top = 72
          Width = 160
          Height = 17
          Caption = 'MODE_INVULNERABLE'
          TabOrder = 12
          OnClick = CheckBox13Click
        end
        object CheckBox14: TCheckBox
          Left = 192
          Top = 96
          Width = 160
          Height = 17
          Caption = 'MODE_NO_FLATTEN'
          TabOrder = 13
          OnClick = CheckBox14Click
        end
        object CheckBox15: TCheckBox
          Left = 192
          Top = 120
          Width = 160
          Height = 17
          Caption = 'MODE_SPECIAL_DEAD'
          TabOrder = 14
          OnClick = CheckBox15Click
        end
        object CheckBox16: TCheckBox
          Left = 192
          Top = 144
          Width = 160
          Height = 17
          Caption = 'MODE_RANGE_HTH'
          TabOrder = 15
          OnClick = CheckBox16Click
        end
        object CheckBox17: TCheckBox
          Left = 192
          Top = 168
          Width = 160
          Height = 17
          Caption = 'MODE_NO_KNOCK'
          TabOrder = 16
          OnClick = CheckBox17Click
        end
        object CheckBox18: TCheckBox
          Left = 192
          Top = 192
          Width = 160
          Height = 17
          Caption = 'MODE_NO_LOOT'
          TabOrder = 17
          OnClick = CheckBox18Click
        end
        object CheckBox19: TCheckBox
          Left = 192
          Top = 216
          Width = 170
          Height = 17
          Caption = 'MODE_NO_KARMA_ON_KILL'
          TabOrder = 18
          OnClick = CheckBox19Click
        end
        object CheckBox20: TCheckBox
          Left = 192
          Top = 240
          Width = 170
          Height = 17
          Caption = 'MODE_BARTER_ONLY_CASH'
          TabOrder = 19
          OnClick = CheckBox20Click
        end
        object CheckBox21: TCheckBox
          Left = 360
          Top = 24
          Width = 140
          Height = 17
          Caption = 'MODE_NO_PUSH'
          TabOrder = 20
          OnClick = CheckBox21Click
        end
        object CheckBox22: TCheckBox
          Left = 360
          Top = 48
          Width = 140
          Height = 17
          Caption = 'MODE_NO_UNARMED'
          TabOrder = 21
          OnClick = CheckBox22Click
        end
        object CheckBox23: TCheckBox
          Left = 360
          Top = 72
          Width = 140
          Height = 17
          Caption = 'MODE_NO_AIM'
          TabOrder = 22
          OnClick = CheckBox23Click
        end
        object CheckBox36: TCheckBox
          Left = 360
          Top = 96
          Width = 137
          Height = 17
          Caption = 'MODE_NO_WALK'
          TabOrder = 23
          OnClick = CheckBox36Click
        end
        object CheckBox37: TCheckBox
          Left = 360
          Top = 120
          Width = 137
          Height = 17
          Caption = 'MODE_NO_RUN'
          TabOrder = 24
          OnClick = CheckBox37Click
        end
        object CheckBox38: TCheckBox
          Left = 360
          Top = 144
          Width = 137
          Height = 17
          Caption = 'MODE_NO_TALK'
          TabOrder = 25
          OnClick = CheckBox38Click
        end
      end
    end
    object TabSheet4: TTabSheet
      Caption = 'Armor'
      ImageIndex = 3
      object GroupBox7: TGroupBox
        Left = 8
        Top = 4
        Width = 673
        Height = 489
        Caption = 'Armor'
        TabOrder = 0
        object Label103: TLabel
          Left = 16
          Top = 104
          Width = 40
          Height = 13
          Caption = 'Normal'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label104: TLabel
          Left = 16
          Top = 130
          Width = 32
          Height = 13
          Caption = 'Laser'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label105: TLabel
          Left = 16
          Top = 156
          Width = 22
          Height = 13
          Caption = 'Fire'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label106: TLabel
          Left = 16
          Top = 182
          Width = 41
          Height = 13
          Caption = 'Plasma'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label107: TLabel
          Left = 16
          Top = 208
          Width = 54
          Height = 13
          Caption = 'Electrical'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label108: TLabel
          Left = 16
          Top = 234
          Width = 27
          Height = 13
          Caption = 'EMP'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label109: TLabel
          Left = 16
          Top = 260
          Width = 46
          Height = 13
          Caption = 'Explode'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label110: TLabel
          Left = 80
          Top = 80
          Width = 18
          Height = 13
          Caption = 'DT'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label111: TLabel
          Left = 128
          Top = 80
          Width = 19
          Height = 13
          Caption = 'DR'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label112: TLabel
          Left = 16
          Top = 418
          Width = 80
          Height = 13
          Caption = 'Radiation res.'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label113: TLabel
          Left = 16
          Top = 444
          Width = 77
          Height = 13
          Caption = 'Poison resist.'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object SpeedButton1: TSpeedButton
          Left = 168
          Top = 40
          Width = 50
          Height = 33
          Hint = 'No armor'
          Flat = True
          Glyph.Data = {
            BE040000424DBE0400000000000036000000280000000D0000001D0000000100
            18000000000088040000130B0000130B00000000000000000000FCFCFCFCFCFC
            FCFCFCFCFCFCFCFCFCFCFCFCFCFCFCFCFCFCFBFBFBA4A9AF30507848546AB0B2
            B565FCFCFCF5F5F5E4E4E4FCFCFCFCFCFCFCFCFCF2F2F2E9E9E9CFCFCF171C21
            4975B42C47684B586A65FCFCFC94A0AE384456868687C3C3C3B3B3B344444430
            30300C0C0C15181C314F6E838D93F5F6F665D5D5D5647B933551730E10171113
            220E0E0E0C0C0C0C0C0C0C0C0C0F0F101F212567676AFCFCFC652424241D2430
            2C3F530C100F0D0D100C0C0C0C0C0C0C0C0C0C0C0C1212171E1E2368686AFCFC
            FC65EDEDED9192922020241316171010101414140E0E0E1717177979791D2022
            1E2124626464FCFCFC65FCFCFCCECECE1E1E23101514E9E9E9FCFCFCD1D1D1FC
            FCFCC6C6C622282C1E2A335C6160FCFCFC65FCFCFCCECECF24272A2023274549
            47FCFCFCFCFCFCFCFCFCF6F6F6324358212B467A7A7EFCFCFC65FCFCFCCECECE
            1F2836222F4522282FFCFCFCFCFCFCFCFCFCF6F7F73641551D2941CBCBCFFCFC
            FC65FCFCFCF2F2F29B9DA821324C202830FCFCFCFCFCFCFCFCFCA4A5A8161F30
            181D30CECFD1FCFCFC65FCFCFCFCFCFCF4F5F534374810141CB2B2B2FCFCFCD9
            DBDC2D2F401315293E4145F6F7F7FCFCFC65FCFCFCFCFCFCFCFCFC3338441112
            216B706CFCFCFC757A801B25370E1B2C484C54FAFAFAFCFCFC65FCFCFCFCFCFC
            FCFCFC343C4D1520312A3331D1D3D5273242181F36192136365272CDCFD1FCFC
            FC65F8F9F9C3C7CCDEDEDF3A4251181F390D13193C3D43121C2E162437172539
            395B83CDCFD2FCFCFC65AAB1B62B3950CBCDD33A3F4F161A2E111725141E3017
            233D16182E1923352D4667CFD1D4FCFCFC6594A1AD2D425FC9CBCD8B8D9B212F
            431D2A452032481E2D4813142924304E324F7CCECFD5FCFCFC65929DA8586475
            F6F7F7A2A8AF2438532131491F2F471F304110182E3A58793E6AA1CDCED5FCFC
            FC6590A2B558687DFCFCFCFAFAFA52586C223553263A5C1A1E360D1321395685
            44699672777EFCFCFC657595AF4E6B85DCDCDCFCFCFC303D50415D7D37588726
            36501219224E759E3E5E87CFD2D4FCFCFC6543628D314D70C4C4C4B3B8BC1C24
            3C3855795082B94D75A52F4159406082333F5DDADADAFCFCFC655E79A02A4C7A
            A8ADB4596D843E5F812335545287CD5589C5334C6F2B3943515255FCFCFCFCFC
            FC65B7C0CA4C7EAE374E6D5170945A88BB3653753A598A5F93E44974B34D76AF
            575F6EFCFCFCFCFCFC65EBEDEE5E89AB4A75A55C88C8699FE15889C24B77A946
            6AB15F95C84B73A88A929DFCFCFCFCFCFC65FCFCFC8FA4BA568ABA63A2EC6096
            EC68A2E271B3F6365581334F728594A0FBFBFBFCFCFCFCFCFC65FCFCFCEEF0F3
            7592A96387B2679CDD5E95E35690C94F71A1A2A3A6FCFCFCFCFCFCFCFCFCFCFC
            FC65FCFCFCFCFCFCFCFCFCFCFCFCDDE1E46C8098243346565C66F8F8F8FCFCFC
            FCFCFCFCFCFCFCFCFC65FCFCFCFCFCFCFCFCFCFCFCFCF0F1F12C2F371A1E260B
            1012EBECEBFCFCFCFCFCFCFCFCFCFCFCFC65FCFCFCFCFCFCFCFCFCFCFCFCFAFA
            FA676E73202F370E151CBDBDBDFCFCFCFCFCFCFCFCFCFCFCFC65FCFCFCFCFCFC
            FCFCFCFCFCFCFCFCFCA1A5A91A212A1B1C20ECECECFCFCFCFCFCFCFCFCFCFCFC
            FC65}
          ParentShowHint = False
          ShowHint = True
          OnClick = SpeedButton1Click
        end
        object SpeedButton2: TSpeedButton
          Left = 168
          Top = 80
          Width = 50
          Height = 33
          Hint = 'Robe'
          Flat = True
          Glyph.Data = {
            4A080000424D4A080000000000003604000028000000240000001D0000000100
            08000000000014040000130B0000130B00000001000000000000040E0400548A
            B400244A540044124400142A34006C4E7400240E24003C6E8400CCC6CC000C1A
            1C004C3A54004C4A7C00140A14001C3A4C002C5A6C004C265C009C86A400241A
            3400E4E6E4006C726C00444A4400A4A6A400141214002C5264002C362C003C7A
            9400541A5400340E34006C3A6C008C6E940014221C000C0E1C00344A6C00343A
            3400F4F6F400441A4C00D4D6D400BCBEC4004C7AA4001C323C004C427400545A
            54001C0A2400947A94002C4A5400244254002C6274005C225C00949A9C001C12
            24003C1644000C161400241634001C1A2C002C2E4C003C0E3C0014222C000C0E
            0C004C164C00242E2C00546EA400D4D2DC000C1E24005C2E5C001C0A1C00345A
            7400341E4400ECEEF400747A7C00141224003C829C006C427400CCBECC005C5E
            8C002C4254002C324C008C668C002C0A2C0034566C005C1E5C00FCFEFC00A47E
            A4002C4A640064366C005496BC004416440044769C00C4CED400140E14002C5E
            7C004C2A5C00A492A400ECE6EC00BCA6BC0014161400341234009C769C001C22
            24000C161C00FCF6FC004C1A4C00E4DEE4005482AC009482940024465C006426
            6400AC96AC003C2A4400141A24003C26540004121400244E64001C2E3400845A
            84003C729C005C4E74002C5E740054225C00846E84002C566C00447AA400541E
            5C006C3E7400946E9400344E64003C3A5C00C4BAC4004C7EAC0024364C004452
            7C005C3E7C00646294005C626C007C467C00649AC40054669C007C828400B49E
            B4003C424C005C327400544E8C005492BC005476AC00242E3C004482A4009C82
            A40074527C00141E1400A48AAC0074767400DCDADC002C122C003C1E4C003436
            4400AC8EAC00C4AAC400243E4C004C4684009C9E9C00F4F2F400744674003C2A
            540034627C001C222C00CCCECC00447294002C1A3400DCD2DC007C7A7C00142E
            3C000C1224001C364400545E5C001C0E24002C4E5C0024464C003C123C000C12
            1400345E7C00CCC2CC002C0E2C00BCAAC4003C2E4C00141E2C0094729C00C4BE
            CC00CCCACC00E4EAE400441E4C001C1624001C0E1C00141624002C4E6400643A
            6C00ECEAEC001C262400FCFAFC00E4E2E40054265C003C224C00040E0C00244A
            5C0044124C00240E2C00140A1C002C5A740014121C002C526C003C7A9C00541A
            5C00340E3C006C3A740014222400F4F6FC004C7AAC002C4A5C005C2264000C0E
            14004C1654005C2E6400CCBED4002C425C008C669400345674005C1E64004416
            4C00140E1C0014161C0034123C000C1624004C1A540094829C0064266C00141A
            2C00344E6C00242E44004482AC001C2234001C0E2C00244654003C1244002C0E
            3400181500000000000070834E00EF206F0018F56E000077650030080000F606
            44004315170000000000708D5E00EF16050018F5100000776500505050505050
            505050505050C476060000C3159F505050505050505050505050505050505050
            505050505050505050632B325FD958D90021BB50505050505050505050505050
            505050505050505050505050C4E7321AF0CBF1CB000018ACA8A4A41250505050
            505050505050505050505050505050503DCADAD83A03F0AD000000000000003B
            30505050505050505050505050505050505050653F1A7979DAE6030658C800C8
            003939001EC550505050505050505050505050505050501D79D8D1D1D179E697
            06BED9D9C80CADBEC888505050505050505050505050505050C51D1AD879D8D8
            D83A03D21B0658583939CCBDE39550505050505050505050505050505C7A4FE8
            D8D8D8E879DAF0CAE15FCB06585858C80029249FC450505050505050505050C4
            4CD8D8D8D8D8E8D8793AE6CAE1F1B42AD939C8C8000000C89E9F505050505050
            5050505D79D8E8D879D8E8E055E11AE61ADA3AE40658D939D9C8C80000149650
            5050505050507E1C79D8E8E8E8D879E63A79D83AE079E6B01B11046CE93EE509
            6E0093132450505050C5471AD8D84FE86979F0F0F0033AE6791AE6E1A17CAE2D
            9CABA97035BE00001EBA50505092794FD8D84FD8E81ACA3AD20303CADAE15AEA
            592E2EC9C9AE27A306CB5800006150506A2F7979D8D8D8D8E1E6D81AF037CA3A
            CAC7A2CD74CD17D7C0CFEF31ADD21BD9C8395089E64FD8E64F4F79E63AD8D879
            55F037B042D70EB2776F772CCD206DBE4037F0F1B45E5CC1D14F4F7923E61A1A
            3AD1D8E8E1F01B424AC0AE41C0C9684A983AE65FBEB03AB0A6257B1A79C6B6E2
            E2E2AD06B49755E67955BCD76FC9D7C968AF3637CAD1D8E606E1E105085079E1
            BC735638BFCE5858E2E258E2EE348068D7C90268DD4BF1D203E6D8E1F0535BC2
            5050BCF0F00B54D02D62D91F1FD9D9E2CE4545AABF6CB7EDBD0640AD065579F0
            0A5C50505050D84F1A75837FEC7252ED3939D9CECE454545CEE258D93958E2E2
            F079715BC25050505050B585D8D81A8B490178194E16D93958581F1FE2D95839
            58584D64105CD55050505050505050639BD3D8794F0F28812666D439583958D9
            D91F1FCEE2588A43505050505050505050505050505060751AD8D879798C8EEB
            58583958585858B1C85E999F505050505050505050505050505050911A79D8D1
            79E882D6DF33D9583900C87D8F445050505050505050505050505050505050A7
            DB4FD87979E84F9D8646770D62C86B94B3505050505050505050505050505050
            505050509A79D879D8E8D8753C8D900784676550505050505050505050505050
            5050505050505050D5B879D8E8E8D8797587A557505050505050505050505050
            5050505050505050505050505022DC5160E8D879E675B9505050505050505050
            5050505050505050505050505050505050505050C49F5DDEA048505050505050
            5050505050505050505050505050}
          ParentShowHint = False
          ShowHint = True
          OnClick = SpeedButton2Click
        end
        object SpeedButton3: TSpeedButton
          Left = 218
          Top = 80
          Width = 50
          Height = 33
          Hint = 'Leather Jacket'
          Flat = True
          Glyph.Data = {
            D6070000424DD60700000000000036040000280000001D0000001D0000000100
            080000000000A0030000130B0000130B000000010000000000000C0E0C00848A
            8C00444E5400242E2C00646E6C00C4C6CC002C3E4400141E1C005C5A6400ACAA
            AC0034323400747E8400E4E6E40044424400241E24004C5A6C00141614008C9A
            9C002C36340034464C0074727400D4D6D4004C4E5400242624002C2E2C00F4F6
            F400140E14009492940064727C003C4244001C2624005C666C00BCBABC008482
            8400CCCED400343A3C001C161C009C9A9C002C2A2C00948E8C006C6E6C00343E
            44001C1E1C00ECEEEC00444A4C0054626C002C3644003C4644004C565C00242A
            3400A4A2A4000C120C008C8A8C003C566C0024323C007C7E7C00545A5C00141A
            2400747A7C00E4E2E400242A24002C323C006C6A6C00C4C2C400344244001C22
            2C003C4A540024323400CCCACC005C5E5C00ACB2B40034363400ECEAEC002422
            2400141A1C002C3A3C00D4DADC002C323400FCFEFC001412140064666400BCBE
            BC0084868400D4D2D4003C3A3C009C9E9C006C7274001C2224004C4A4C003C4A
            4C0054565400545A6C000C0E1400848E940044525C00242E3400646E7400C4CA
            CC00747E8C00E4E6EC004446440014161C002C363C0074767C00D4D6DC004C52
            540024262C002C2E3400FCFAFC0094969400647284003C424C001C262C00BCBA
            C400CCD2D400343A44001C1A1C006C6E7400343E4C001C1E2400F4F2F400444A
            54002C3A44003C464C00A4A6A4000C1214008C8E8C00445664007C828400B4B6
            B4007C7A7C00646A6C00545E5C00242A2C0034424C005C5E640034363C002422
            2C0014121C0084868C009C9EA40054565C0019170000000000008C14F000CB00
            9F001200190000000000BC781D0000CB00000012000000000000E8216400CB00
            22001200E7000000770086080000BB010100E900000077000000900850001801
            5B00E800010077000000FF080000FF010000FF001500FF000000FB0D14003300
            C900E7001200770000005468000017000000E70000007700000058C8FC004300
            F7001900120000000000960802001B012400E700F800770077000308F8003801
            5400E700F700770077005808FF004301FF001901FF000000FF0014008D001B00
            1600E73FF500770077000030210000CA1E001512E7000000770000E80000009F
            0000001915000000000001F8000000CA00000012000000000000C8545000CB21
            5B0012F5150000770000584C0000430201001900000000000000FCA01C00F7CD
            18001219E8000000770086000000BB000000E91500007700000020E80100189F
            0000E819000077000000FF000100FF000600FF000100FF00A10096CC40001BCB
            CA00E712120077000000F8BF4900BE1F060043F510000077E800587849004301
            0600191500000000000058834E0043206F0019F56E000077650030080000F606
            44004315170000000000588D49004316060019F510000077E8004E4E4E4E4E4E
            4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E20646A854D464E0000004E4E4E4E4E4E
            4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E8274897940376C0000004E4E4E4E4E4E
            4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E2774664B2943780000004E4E4E4E4E4E
            4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E63705F23233D780000004E4E4E4E4E4E
            4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E48578585424D220000004E4E4E4E4E4E
            4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E6377576A666B8B0000004E4E4E4E4E4E
            4E4E4E485520327E1B7E7E1B814E4E4E638985851D5F210000004E4E4E4E4E4E
            19581000004F1000000000004F8C4E4E631E6A660685520000004E4E4E4E4E4E
            5365334F1065100000652A2A493E6C4E0C773157855F2C0000004E4E4E4E4E4E
            716A545823472A4926498557266A534E4885572A857A4D0000004E4E4E4E4E4E
            250A541D693D6A174D1785264D57506C4E3E77777B7F6B0000004E4E4E4E4E4E
            258588233002182A6A2A2A490D1777534E75413D5E0F850000004E4E4E4E4E4E
            511D0D4D840482640A6B266A772A77871958496A6602570000004E4E4E4E4E4E
            532364182C1D4D17314977772A7474075A5C49036659310000004E4E4E4E4E6C
            6B4F1774663C186A18772A6A17777465104F2A6A1D59110000004E4E4E4E4E7C
            4F65102A1616541D73404D6B4D4974107474856613065D0000004E4E194C6850
            2A2A4D1D642C0A4D4D5F772A2A2A2A744A77774D406A520000006C4432657785
            2A261D692880451D1323856A8549492A74576B23665F210000005049855F296B
            740A891812801D1D237B1D23856A2A2A7457184B1285520000003B02366B854A
            2A26854D4D626F1223234D574917858577178866855F8B0000004E1531854924
            2A5757898D62474903665F851749492A494D5F6B665F010000004E6C83438565
            771731856E0217236A4917858589492A171D3D4D365F2B0000004E78088A7474
            49496A881C6A5749234D85858549032A18291D5F8529780000004E14657D4F39
            4774852D6F4F774977854D6A856B26578506666B85566C0000004E05762E8635
            5B3C2F024A5C2A2A2A2A2A6B734D6B856A067A8514194E0000004E4E611F6631
            743129730000657477852A2A74887B896A386046784E4E0000004E4E4E786852
            67723A6F2A001A747B546B572485856A092B4E4E4E4E4E0000004E4E4E4E4E4E
            4E4E6C150B0E657785856A49574788814E4E4E4E4E4E4E0000004E4E4E4E4E4E
            4E4E4E4E6C786D343F7878096B16484E4E4E4E4E4E4E4E000000}
          ParentShowHint = False
          ShowHint = True
          OnClick = SpeedButton3Click
        end
        object SpeedButton4: TSpeedButton
          Left = 268
          Top = 80
          Width = 50
          Height = 33
          Hint = 'Combat Leather Jacket'
          Flat = True
          Glyph.Data = {
            62070000424D620700000000000036040000280000001C0000001D0000000100
            0800000000002C030000130B0000130B0000000100000000000004121C00748E
            9C002C526400042E44002C2E2C00041E2C001C1E1C000C3E5C00C4CED4006462
            64001C2E24002C424C001C261400E4E6E400140E140094AAB400041E34001C32
            4400647A84003C3E44004C4E4C002C262C002C363400243634001C262C00D4DE
            E4007C7A7C000C3A5400142A2C001C2E34009C969C00141E14001C3E4C001416
            140004161C00B4AEB400241E1C002C465C00F4F6F400042A3C003C464C005C5E
            64003C3A3C001C4A6400142E3C00CCD2D4003436340024262C007C8284001C16
            1C00848A8C00446A7C00646E64001C3A4400242E3400141E2400BCBABC001426
            3400444E5400342E34001C1E2C0024262400ECEEEC004C565C000C161C008C86
            8C008C929400D4CED400646A7400242E2400343E44006C869C00E4E2E400141A
            24000C26340044464C002446540034364400848284008C8A8C000C0E0C000C2E
            3C002C323C000C1E2C001C221C00CCCACC001C262400747A7400444244001C2A
            2C00DCE2EC00143644009C9EA40014221400243E4C00141A1400B4B6B400344A
            5C0014324C00242A2C00243A440024323400F4F2F4005C5A5C000C1A2C003442
            44000C2A4400244A64008C8E8C00345A74002C3234006466640014121400ACAE
            AC00243644003C4244002C3A4400DCDADC001C323C0024222C002C4A5C00FCFE
            FC003C4A4C005466640014324400D4D2D400343A3C001C1A1C001C3A54006C72
            7C00C4C2C4004C526400ECEAEC00FCFAFC00545A64005C6A6C006C7684004452
            5C000C324C00143A5400A4A2A400143E54009CAABC001C3E5C006C6A74001C2A
            1C007C7E84002422240014222C0044524C00ECF2F4004C5A64000C1A1C002432
            2C000C2A3C00244A5C00848684000C1214000C222400CCCECC00244254000422
            34001C3644002C2A2C00B4B2B4007C868400BCBEBC00142A3400343234001C22
            2C00242A2400444A4C00343A44001C2A24009CA2A400DCDEDC00D4D6D4002C52
            6C002C2E34001C1E24001C2E2C002C363C0024363C001C2634001C2E3C00141E
            1C0014161C0004162400142E440034363C00242634001C3A4C00242E3C00141E
            2C00ECEEF400242E2C00343E4C000C263C0024465C008C8A94000C0E14000C2E
            44001C222400747A7C001C2A340014364C0014221C00141A1C00B4B6BC00242A
            340024323C0034424C008C8E940064666C0014121C003C424C002C4A64003C4A
            54001C1A24000C1A240084868C000C222C00CCCED400770000002003A0001800
            0B00E800F30077000000FF000100FF000600FF000100FF00A100960040001B00
            CA00E700120077000000F8CC4900BECB0600431210000000D300286049003222
            060019F500000077000028834E0032206F0019F56E000077650030080000F606
            44004315170000000000288D98003216040019F5F30000770000797979797979
            79797979797979797979797979797926A64E304F487979797979797979797979
            7979797979797979797979A424B3C37E92797979797979797979797979797979
            79797979797979A47FD11D91133E793E60D0D0AF797979797979797979797979
            79797984B2D2B6ADD184793059B7DA1538797979797979797979797979797979
            2A3C7417AC84669572C4A970717979797979797979797979797979794DD1D20A
            7A428416D2B5BEB37D7979660D840D0D0D0D0D0D85797979BDA918C3594E0DB5
            D3D218D175DC6F2A70045050505050C81E797979A8CA1DCA5D925C1864B3BA04
            57BAC8505031505050705070B37979793BD1D1CFCE6F92B3D1A9BA04677018B3
            BA06217FB3B30EBA21237979A3CAB3560C631AB3D136DA042921CC3CBACA59D2
            3649D60E212A7979417F1865AD6370CAC0D1CF3B099D70DA3718A9D23C7FBA93
            9D21238504BAB70B9963B3C0D131A92E09B3379D2FD1D2D22FD2D2CCB3703D48
            A3B3BACCCE56A5185921B3DAA35F5BCC9494949474A025D2CF70501421CFA936
            54AD32A9CAD1777F21B41C949494949494A2CCB9997050509DCA2FB35434D474
            36B736932191409494949494BBC1B345C3B9CF0EB336B5CA1FDCDCB565B52FDA
            BABA02029494940251C1DACAAD994521CA65B5AA5D4E3063D36374B3CF2F0202
            94B3BA02020202CF3DC3547FB376747EAC9CC736B5D3ACB370020202B37ECA06
            0202020249B393BD043DB669696C2686D936B3B3020202A9B59736D2DA020202
            02BAB3B32EB2931D35427990639349C102020218973AB22F2FBA9E0202027FB3
            D158B206638C79822FBACD020202CA5288BDB26E06CAB35302020202C13C36CC
            A98479B0D202020202026E287BB3B352BD1836CA400202020202B7118966798E
            0202020202734687D17F7FB393B52F2F6318B30202028A614466790102020202
            4974D96E50BAB3B3060663B552BE93390202C633797979196D020211D1747206
            50BA77062FCAB30636D9D7188FB1070F79797979C2476D2528D2742F21507F6E
            737E5663D1B54B8183120896797979797979C25A2DCB3FB56321CF3D18633D36
            744632269685797979797979797979797926AE7E55439C323E3E9FD5ABDE8579
            797979797979}
          ParentShowHint = False
          ShowHint = True
          OnClick = SpeedButton4Click
        end
        object SpeedButton5: TSpeedButton
          Left = 168
          Top = 120
          Width = 50
          Height = 33
          Hint = 'Leather Armor'
          Flat = True
          Glyph.Data = {
            A6090000424DA60900000000000036040000280000002E0000001D0000000100
            08000000000070050000130B0000130B00000001000000000000040E0C00648A
            9400345254004C6E6C00242E2C00545254003C3A3C00445E5C009CC6CC002C3E
            3C00141E1C009C9A9C00444E54006C6E6C00242E4C005C7E7C002C3E5C00344E
            6C001C1E34002C2E34004466640084B2CC005C6E74001412140054626400D4D2
            D400ACB2B4008C9294003C5654002C4644001C26240044565400646264003C46
            4C004C5E5C00141A14002C465C006C9AAC00344E5C00547674002C363400ECEA
            EC0024363C001C263800546E8600242227009CAAAC006C828C00243654005C76
            7C0054667400BCBEBF00445A6F00C4C6C400343E44005C7E94003C5671004C66
            78004C4A4C00546E6E001C2E3C003C5E6C001C1E21003C4664003C4E5E002426
            3C000C0E0F006C92B40014122400DCDEDC0034464E004C566400141A29003446
            6200343A5F00545A6400647E8600343E5F00343234004C666A00ACBABC004446
            44004C5E6C0034363C007C7E84000C0E1C0034466C003C424800ACDEEC002442
            4C009CA2A4004C4E54003C4E74002C2E440094BAC400646E7400546A6C00949A
            9C003C5664002426280044566400646A6C007C9AA0002C364400F4F6F400ACAA
            AC002C364C005C7A94005C66740054727C00242E3E001C1E2C00748E94003C4E
            5300446262009CCEEC00445264006C767C005C72790014161A005C625C00B4B2
            B4009492940034525F001C2A3800747E8400C4C2C400CCD6CC0034424C006486
            9400DCDADC00F4F2F400CCCECC00E4E6E400FCFEFC008CBACC00749EA400A4D2
            DC007C868C007492A8006C8A8C00445E6C00E4E2E4005C5A64002C3E5000747A
            84003C3E4C002C324C005C7E8C00A4A6AC003C567C00242A440094B6D4002C3A
            5C00749AB4001C1A1C004C5A6C001C1A2600444244006C6A6F00647A8C00141E
            2C002C465400B4BABC00A4A2A4006486A4004C726C002432340054565C009CCA
            D4009C9EA000445256005C828400345274001C2236002C32390054666C00ACB6
            BC008C969C003C5A5C00445A5C003C4A4F004C626400547A7C002C3A3C00243A
            44005C7A8000546A7900BCC2C400C4CACC00344242003C5A6C004C6A74005472
            71001C2224003C526300242A36000C12120014162700DCE2E400344A5200344A
            5F0064828C0034425E004C6A6C00444A49004C626D003C526E00242A2C002C3A
            530024323E003C525400748288006C8E940044626F005C5E5C002C424C002432
            4C002C425C00D4D6D40064666400ECEEEC003C4A64004C5A6400545E64000C12
            1C00344A6C002C3244003C5A6400445A64002C3A4400ACAEAC005C6A74001C22
            2C00B4B6B40094969400A4AAAC0094BAD4004C6E7400242E3400445E6400141E
            24006C6E740044666C005C6E7C0014121C0054626C003C565C002C464C001C26
            2C0044565C004C5E6400141A1C00344E64002C363C0024364400868686868686
            868686868686A4617A7A06771742421717777751338686868686868686868686
            86868686868686860000868686868686868635A42063F5424242424242424242
            4242424220868686868686868686868686868686868686860000868686868686
            35D73E42424242424242424242424242424242422D8286868686868686868686
            8686868686868686000086868686290B3E424242424242424242424242424242
            424242F542AADD8686868686868686868686868686868686000086868686DC42
            42424242424242424242424217482BF9AE2BBEEFAFE984868686868686868686
            8686868686868686000086868686784242424242424242424242F5D1D110DA4D
            4A6A2246B5B96983868686868686868686868686868686860000868686869F42
            C54242424242424217AECB9611CBDE5CADFD64C8B8C46F7E8686868686868686
            8686868686868686000086868668CDE96E6F6FF5E14217E34996CFAD56C924D1
            49E23F2121B5908A86868686868686868686868686868686000086868633CD57
            7C2B2BD9CB90E23896CF1149E24D4A99D19397ABD6F7408F8686868686868686
            8686868686868686000086868686F452C96EC42B0E4938E2E2CFCB4D300E416F
            C644FFAD3264AF4E45868686868686868686868686868686000086868686E74B
            6F48AE2BD2D14A3FD16E411244F555555555A1AEAF9D44445382868686868686
            8686868686868686000086868686859EF544C612AE5DCB0E2BA1C648444444F5
            55F5F54444C636FEEFEA8686868686868686868686868686000086868686BDB5
            2342424242F5E96F2BAEC6C6C6C6C6C644C644C64857B540478386DBEA79EAA3
            83868686868686860000868686868E5BAF4255424444C66FAE12C6C6C6444444
            C6C6444444FED10C9285EB06632D2D63CDF2332986868686000086868686DD9F
            2D4255F544444448AE12C64444444444C6444444442D2DC46F9E633E3E3E9D3E
            F92DC23A95298686000086868686867977424255F5444444F544444444F5F5F5
            554444C6C69D6F4848F5C5FC3E9D9D3E9B9B779BC205DD86000086868686860D
            FC42425542445555425555F5C644773EC6C6C6F1C6C644C6C6E14277C2C29D9D
            777777C59B3EA883000086868686DD549B4242425544444455F53E1336DFE8BB
            A02C327B40903C776F424242773E779B9BF5C577179B771B000086868619063E
            9B77F5F50A486F4444C4C32CED73A95898886B2CBF7B6AE1550000F563D0F9EF
            3EC2C23EC23E3E7A00008686AA53C2F16E67FD38A5667CF5C6A22C81819A8708
            94C070BA4FFA4009F542177777F9AF71B3CCCC64B546E6860000199F63E9D2C9
            7BCF3D3437891526E959344F6D6DD525CAF376C1BB4FFAE52AE977EF1D3646D8
            AFEFD290FEC2177A00007A3E2DEFD2C849C3C35260AC8B8B01A2E452CCBA27EE
            397452CCB636F8D364D8A74680C3766632AB36BEEF1EC2280000DDBEEF574CB4
            02074F21FE2A71BB43C8B4CCB0C1C1316071AF57FE46DF07F7C336FAD3F08DBB
            4CBAB7C8BEE6D0D00000C736464C5E8CB44FF004EF80D3C04CD6F06452CC3BCC
            EE4FE5AFD36472B4DF72F771033BC16DCECECECECE16ECDB000065F7B3CE6D2F
            B0F0CCFA3646B8076DCCE48D628D3BEECCCEFBCECE72CE60CCAB1F724FBAC1CE
            39C052167D2986860000857552C34FC10FABDFDF0771D3B4CCCCCE4FCE62E5CC
            603B4FB0F0CE3B4FFA71E53BB6CC3B03525F7DDD86868686000086868E956C76
            604F603B3BB528091C3BCEA6604F62E4CC0360B0CE34D4BC91C3144F60CC4F18
            E7DD86868686868600008686868686295AE03B3BC13BC13B03C1CCD603CC9C72
            52BBB0F6DF5A298683EAD4B6DFB17F8686868686868686860000868686868686
            868683EC1A508A74FA21B22E95EC698686868686868686868686868686868686
            86868686868686860000}
          ParentShowHint = False
          ShowHint = True
          OnClick = SpeedButton5Click
        end
        object SpeedButton6: TSpeedButton
          Left = 218
          Top = 120
          Width = 50
          Height = 33
          Hint = 'Leather Armor MkII'
          Flat = True
          Glyph.Data = {
            A6090000424DA60900000000000036040000280000002E0000001D0000000100
            08000000000070050000130B0000130B00000001000000000000040E0C00648E
            B4002C4E5C001C2E44004C7294003C3A3C0054525400243E5400BCC6C400345E
            8400141E1C009492940044526400243E5C002C32340034566C00141E34009CAE
            BC0024466400141214006C6E6C00E4E6E400445E6C0074A6DC003C4E5C005C7E
            9C001C26340014122C0044668C00243644002C3A540034465C005C6E7C009CA2
            A4008C8E94005C625C0034465400D4D6D40024222400B4B2B4002C4E74002C36
            4400345674003C464400343E4400141A1C00445E7C0024263C00242E3C001C26
            2C00343E5C002C465C005C7A8C00646264001C1E1C00F4F6F4000C0E0C00949A
            9C00445A6C0084B2EC003C4E74009CAAAC00DCDEDC00B4BEC4003C5674004C4A
            4C005C9AC400344E5C001C1E340014122400ECEEEC001C264400141A2C004C66
            7C002436540034466C00646E7C007CA2CC0034363C003C466400242E4C000C0E
            1C004C7A9C002C3E4C00CCCACC004C5664002C3E5C002C2E4400ACB2B4006C7E
            8C004C5E740084AEDC00A4A2A4005466740034527400344254004C5E7C002C46
            6C001C1E2C009C9A9C00344E6C004C6A8C006C92B4003C6684003C566C00A4AE
            B400244A6400141614007CAEDC003C525C001C2A3400243A4800343A5F00344A
            5E0084969C002C3A470044464400344247001C1A1F00242A440024323E003442
            5E00646A74000C121200DCE2EC00BCBEC0003C5A78004C6A8100546684008C9A
            AC007C7E84005C5E5C00444244006486A200FCFEFC008CBAF400CCD2D400546E
            8900B4BABC007C868C006C8AAC00ECEAEC00DCDADC00F4F2F4003C3E4C007CA6
            DC005C728C003C4A54006496C40064728C001C1A2C00547AA4008C96A4006C6A
            6C00C4C6C4003C5E8400141E2C00343234005C7A9C00A4AAAC00D4D2D4001C32
            4C0054565C00445668002442610014223400E4EAEC004462740014162D009CA6
            AC00D4DADC00242627002C527700345A7C0044628200242A37002C4A5C001C22
            2400949EA4003C526D00DCE2E400345264001C22370064728400343A44002C42
            54002C324600A4A6AC009C9EA0003C5A6900A4B2BC00444A4C00BCC2C4006C8E
            B400244254009496940074AADC005C727C008C929400344A5400B4B6B4006466
            6400141624001C2A4400243A5400344A6C003C4A640024324C000C121C002C42
            5C004C6274004C627C002C4A6C001C222C0034526C00546A84001C2E4C00141E
            2400141E3C0024466C0014121C006C6E7400445E74003C4E64001C263C002436
            4C002C3A5C00344664009CA2AC002C364C0034567C00343E4C00141A2400242E
            4400343E64002C4664005C7A94001C1E24000C0E1400445A7400DCDEE4003C56
            7C00344E6400ECEEF400141A34004C6684002C3E54004C566C0054667C003452
            7C003C668C00A4AEBC00244A6C0014161C003C5264001C2A3C00868686868686
            8686868686865C390B0B056B13EE3813136B6B747D8686868686868686868686
            8686868686868686000086868686868686869A5C35ABDCEEEE38383838383838
            3838383835868686868686868686868686868686868686860000868686868686
            9A83ED3838EE3838383838383838383838383838ED8E86868686868686868686
            86868686868686860000868686868D63363838EE383838383838383838383838
            3838EEDCEEBC468686868686868686868686868686868686000086868686C9EE
            383838383838EE38EE38383813E81A31B6E02CAF30D554868686868686868686
            8686868686868686000086868686233838EEEEEE383838EE38EEDC1E1E56D132
            70E5A324531D9F8F868686868686868686868686868686860000868686869938
            7BEE3838EEEEEEEE13B679F16479CE3C5EF2DFB978AF48C08686868686868686
            86868686868686860000868686372BD5306262DCD0EE13BAE3F1B35E4B71331E
            E3CD4F535375538B8686868686868686868686868686868600008686868A5375
            FF1AE0CF79F6CD40F1B364E3CDEA70E21EBA7733DE711F558686868686868686
            868686868686868600008686868620407130AFE050E340CDCDB379324A502F62
            A8451DEF5AB5309D3E8686868686868686868686868686860000868686869FA3
            6248B6E0781E704F1EE92F4445DC515151519CB6304845454EAA868686868686
            868686868686868600008686868615B8DC45A844B65779501A9CCA48454545DC
            51DCDC4545CA2C78305886868686868686868686868686860000868686860853
            6BEEEEEEEEDCD5621AB6CACAA8A8CAA845A845CAA875C7710C8F8625C827C88A
            8F86868686868686000086868686B4930EEE51EE4545CA62B644CACAA8454545
            A8CA4545457873C79015C305AB2626ABBFDD7D8D86868686000086868686467A
            26EE51DC45454548B644CA4545454545CA4545454562626E6284AB36EDED76ED
            3126B141BB8D86860000868686868627FD38EE51DC454545DC45454545DCDCDC
            514545CACA9662E848DC7B2DED7676ED7676FD76B10646860000868686868614
            2DEEEE51EE455151EE5151DCCA45FDEDCACACAD9CACA45A8A8D0EEFDB1B17676
            FDFDFD7B7636A28F00008686868646827638EEEE5145454551DC76AF2C0C5AF8
            897FDE71DFB9AFFD623838EEFD36FD7676DC7BFD1376FDC60000868686A005ED
            FDFDDCDC0AE86245456EFE4991873B87178CECF568B0E551510000DC1B6231AF
            EDB1B136B1ED360B00008686BC4EB1D9AF78FEA385856EDCCAF665EC9E016CC4
            42AE9E7F7E02711DDCEE515151A81ACC0D285EF233D1BA860000A099ABD53071
            F2B3EFEF525B4D71D51DD6EF497F19668971B371686871B57862DCF46FE0D8A1
            A5F4B6A1CBE8512200000B3662B630241FF2B540DE92858597B9B32ADEE77378
            AFD51A1A6F2A1F7143F6A5D8CF120997B507E0E0B6A81BB60000467310CF1CF2
            71FE3A3ADEF8D2D7C1C7F27E7EDF29BAE95F1F1FF2E6B36DB01FCBB0566128E6
            AE7E67E103DAA8A80000F0474AAE9404F2687ED3EF2EDEAE89EF71D67EEFDEEF
            D37E2A2ABD40A3FEB568A4CC2828287EE6E6E6E62816A9880000F7A4A4E69BFA
            0FFE3A7E7E2EAEDE49DE71407E7EDE5A7E7ED67E7E2A7EEFEFF6C2FCACE628D6
            E6AC28D2B78D868600007C80BDFC28F9AE43F27EAED35AD3602EAD7EDE7E5ADE
            7EDE7E7E407EDE7E33C2EBACD42828FC28D24C468686868600008686B481EF7E
            DBB3DEDEDE7E7EDEDED37E5ADE7EDEDEEFDE7E7E400F343FC56A28ACACD45ECE
            E44686868686868600008686868686A698F2A7DE5A2E5ADEDE5ADE68EFEF2A5D
            BDD33A3AFEB28D86F36995F2F2FB888686868686868686860000868686868686
            86868F3D11BE59F21853723D21A9A98686868686868686868686868686868686
            86868686868686860000}
          ParentShowHint = False
          ShowHint = True
          OnClick = SpeedButton6Click
        end
        object SpeedButton7: TSpeedButton
          Left = 168
          Top = 160
          Width = 50
          Height = 33
          Hint = 'Tesla Armor'
          Flat = True
          Glyph.Data = {
            4A080000424D4A080000000000003604000028000000240000001D0000000100
            08000000000014040000130B0000130B000000010000000000000C0E0C00848A
            8C001C566400C4C6C4004C2E1C00644E4C006C6E6C0014363C00ACAAAC00E4E6
            E400444244002C161400A48A740064625C008C726400D4D6DC001C1E1C002C2A
            2C00C4B69C005C3E2C00F4F6F4007C7E7C002C3A4400949694007C624C001C12
            1400B4B6B400ECEEEC00A49A9C004C4E4C00643A240064666400E4DAD400B49E
            840044362C007C563400948A8C007C6E6C00444644002C2224008C7E74003C2E
            2400D4CECC0064564C00A4A2A400545A5400B4B2AC005C463C0054362400F4EA
            F4002C3234001C1A1C0094928C009C82740014161400B4AAAC00ECE6E400745E
            5400DCDEDC001C262C00C4BAB400848684003C363400F4EEEC0074666400E4E2
            E4007C767400CCCECC006C4E44004C3E34002C1E1C00342A2400847E7C009C9E
            9C0024121400BCBEBC005C5254006C666400443A3400544644003C221C009486
            8400ACA29C0084767400140E0C00CCC6BC0074767400DCD6D400241E1C006446
            2C00FCFEFC00AC9A8C00545654009C8A7C0094827400DCD2D400745654005C62
            5C005C4A4C00ECEAF400D4C2B4003C3E3C00F4F2EC004C4244008C8A8C001C6E
            84004C322C00746E6C001C424C00ACAEA4002C1A14006C625C009C766400FCFA
            F4009C9694008C623C001C161400BCB6B400544E4C00E4DEE400B4A6A4004C36
            24004C46440034261C008C827C003C323400D4D2CC006C5A54005C5A5C001C62
            74006C4224008C5A34008C7A7400C4C2C4003436340084665C00BCA294001C32
            3400A4866C0064423C006C4A2C00AC9E9C009C928C0024262400ECE2E400644A
            4400ECEEFC0034323400241A1C00341E1C001C2224007C828400E4DEDC003C32
            2C00543A2C00B4AEAC00ECEAEC0074625C00C4BEBC003C3A34007C7A74006C52
            44004C423C00342E2C0084827C006C6A6400544A4C00ACA6A40014121400CCCA
            C400DCDAD40024222400747274009C9A9C00BCBABC00545254004C4A4C006452
            4C002C2E2C00A49E9C00646A6400948E8C002C262400A4A6A400241614003C26
            1C00847A74008C8E8C005C5E5C000C0E1400C4C6CC004C2E2400E4E6EC006462
            6400C4B6A4008C7E7C0064565400B4B2B40054362C009492940014161C00ECE6
            EC00745E5C00DCDEE400F4EEF400E4E2EC006C4E4C004C3E3C00342A2C009C9E
            A400BCBEC400443A3C00ACA2A4009C8A8400F4F2F400ACAEAC002C1A1C00FCFA
            FC001C161C004C362C00D4D2D400B4AEB4003C3A3C007C7A7C00848284006C6A
            6C00DCDADC0077000000FF007800FF000100FF003F00FF00000096CC38001BCB
            3A00E7123F0077000000F8BF6D00BE1F030043F510000077900008787800E001
            010019153F000000000008837800E020010019F53F000077000030080000F606
            44004315170000000000088D3800E016390019F53F00007700005A5A5A5A5A5A
            5A5A5A5A5AD91B646AABB2E02CD95A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A
            5A5A5A5A5A5A5A5AD95B302900005410ABE12C5A5A5A5A5A5A5A5A5A5A5A5A5A
            5A5A5A5A5A5A5A5A5A5A5A5ADC194A54000000000033112C5A5A5A5A5A5A5A5A
            5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A3AD0B80B54000000000000A811B75A5A5A
            5AC52A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A6B54B8190000000000000000A8
            10AF1BD9C733725A5A5A5A5A5A5A5A5A5A5A5A5A5A5A754AD84A000000000000
            00000000A836472B0000AFD95A5A5A5A5A5A5A5A5A5A5A5A5A5A840430190000
            00000000A836C83636A88F3EA8000003D95A5A5A5A5A5A5A5A5A57DCDC9E9A82
            30540000000000361010AB8F8FAB333393330000C15A5A5A5A5A5A5A5A5DB900
            00A819795000000000BD3610AB11938693938F8FB200363333C55A5A5A5A5A5A
            208A8C5400A836DA94B80000003610ABB2866565DEDE86A3AB338FAB10AD5A5A
            5A5A5A5A7188235400000033105874543310ABB2DE0A1D1D2693863ECF86B211
            58AD5A5A5A5A5A5A5A21836E0000363310ABAB1010ABB2DEB05CBCBC5C266526
            5C17E0B2AB1C145A5A5A5A5A5A1273B954A810ABAB1111B2223E651DBC06BCAF
            5C2DA2AB07112CDE27C6E05A5A5A5A5A5A5559463310ABABAB8F8F112244394D
            AC68611DB00A863B0296ACDEA313D75A5A5A5AD6B3DEDA10ABB28665650A65DE
            8693D3A6A0B785C549C7DE6C698965DE9F11035A5A5A5EA1B87410B2DE0A1D5C
            C1E15656060D1D0AB2B0BE43AFE15C6C81AB652686B21DB0B55A281E6E10AB93
            DE0AAFC156BB2CD7D7B7340A368FDDCB49560632161D4D2636B2B6B6535A1418
            95D85811DE65AFE13DD743C06341DCACC12CDC63C93D653D082478BC06931142
            095A5A1BB1D8948F86DEB01F688563929292CDADE01797C5AE562DB48ED5A0D1
            01D34C385A5A5A5A9C62D85811862680E0AE63929292DCA74BA47FCA7F3D6B9D
            CEA6D20F1F67095A5A5A5A5A5A9C40D8ABB2DE1D062CCB92CC31D48D51056005
            91A5E1C4456F779EE10A5A5A5A5A5A5A5A5A5AB3D38F93655C151AC0CC5FA990
            3838358D57B1997BDB1743874F583A5A5A5A5A5A5A5A5A5A98C37D932680DF6D
            2EE25A5A5A5AD6E25A2A8BBF76AD48DC3CB993415A5A5A5A5A5A5A5A5A5A5772
            D3B0BCB77E5A5A5A5A5A5A5A5A5AB3E23C2F7AE25A667C4E689C5A5A5A5A5A5A
            5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A4B4B5A98259B5A5A3F0C29655A5A
            5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A0E6B5A5A7534D95A5AC2
            9DBA5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A52AA5A5A3FC3
            755A5A3F38D65A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A
            5A5A5A707D375A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A5A
            5A5A5A5A5A5A5A5D75E25A5A5A5A}
          ParentShowHint = False
          ShowHint = True
          OnClick = SpeedButton7Click
        end
        object SpeedButton8: TSpeedButton
          Left = 218
          Top = 160
          Width = 50
          Height = 33
          Hint = 'Netal Armor'
          Flat = True
          Glyph.Data = {
            4A080000424D4A080000000000003604000028000000240000001D0000000100
            08000000000014040000130B0000130B00000001000000000000040E0C00848A
            84003C4E5C00242E24006C6E6C003C363400C4C6C400141E14005C5A5400A4AA
            AC002C4254001C324C00747E7C001C225C003C423C004C5E6C00241E24002C36
            1C00949A9C004C4E4C005C625C004C423C004C565400E4E6E400141214006C72
            8400B4BABC00342E24006C6254001C2624004442540084827C0024261C009CA2
            9C008C928C00243234006C7674001C1E2C00444A4400141A3400D4D6D4004C56
            5C00141A140024262C003C3E4C0044423C002C3634004C4E5C001C1E1400ACB2
            B4002C3244007C868400646A6400F4F6F400C4C2C400746E64003C3E34006C6A
            6C008C969C000C1614002C2E1C00747E8C00949EB4005452440064625C007C7A
            7C00BCC2BC00A4A2AC0054565C002C263400343634002C3A4C000C0E0C00CCCE
            CC005C5E5C00ACAAA4009C9A9C004C4A4400ECEEEC001C1614006C7A8C006C6A
            5C0084828C002C2E3400DCDEDC001C1A1C0044464C001C1E24008C8E8C00445A
            6C00344644007C7E7C003C424C0054667C004C524C0054564C00141624003432
            34002C2A240094A2B400949294007C76740044463C0074727400443E3C002C2E
            2C0064666C00343A34000C120C00ACAAB4002C323400848E8C00444E54006C72
            6C003C3A4400CCCACC00141E240064564C00343E44002C263C0024223400343A
            2C00ECEAEC001416140074767C00BCBABC001C2A34003C4A5C0084868400FCFE
            FC00343A5C0074666400747A7C0074766C00DCDADC00FCFAFC00D4D2D400F4F2
            F400E4E2E4009CA6BC0024364C0054626C00B4B2B40094969C00343A4400544A
            4400746A6400444A54009CA2AC00141A24007C8694003C3E440054525400BCC2
            CC003C3A3C0034322C00242A24008C9694001C222C004C5A5C00242A2C004C52
            5C001C221C002C36440074726C007482940064666400A4A6A400545A5C002C2A
            2C00ACAEAC009C9E9C007C827C00545A54002C2A4400747A7400242224006C76
            840084868C001C2224003C464C00546A7C002C322C00BCBEBC00B4B6B400848A
            8C00242E2C00C4C6CC00141E1C005C5A5C003C4244002C362400949AA4004C4E
            54005C6264004C424400E4E6EC001C262C0084828400242624008C929400444A
            4C004C566400141A1C003C3E5400444244002C363C004C4E64001C1E1C002C32
            4C00646A6C00C4C2CC00746E6C003C3E3C006C6A74008C96A4002C2E24006462
            6400BCC2C4005456640034363C000C0E14005C5E6400ACAAAC004C4A4C006C6A
            64002C2E3C00DCDEE4001C1A24004C5254005456540034323C0044464400343A
            3C000C1214002C323C00444E5C006C727400343E4C0014161C001C223400242A
            34002C2A34009C9EA4007C828400F2206F0017F56E000077650030080000F606
            44004315170000000000988D5E00F216050017F5100000774F00818181818181
            8181818181811749E77BBCA0ED86818181818181818181818181818181818181
            818181818181818181A7CBCB7BEFB0536EF2F386818181818181818181818181
            818181818181818181818181A7D07BDD55B0C7A0D89B6E564E81818181818181
            81818181818181818181818181818188B0D07B55D0D0C7622062A9A92C7A8181
            81888181818181818181818181818181814E54D518D05555D0D0D0B0D0A22BCE
            6EE5DA88E92B4E8181818181818181818181818136CD692A2A5518B0B0C7A969
            200347B47FF19EBC742BD53681818181818181818181814E9861D048484807A2
            696146BF79CEEE699A0BB0E495B069CD5481818181818181812804536B57572A
            0048D0C761386979BEA90A6EE88CCD2B25579EBE8A81818181818181816AF17B
            5725F05A9ECB7BC71B1110C9E546A061BE9FE6D12B2B9ADC7C81818181818181
            81DC3BEFB0695C32E2BEC54F303CE74D5F05466946AD9878DC46E0E867818181
            8181818181CD7B7BD069E96ED5CDCE1DA26672C33F752DCD5EADCFD1D5D5D513
            974E81818181818154D5C7EA481869A9C7A9696E576993DE37927591D4A4CC2C
            CDE0E0E0538F8181818181818198186C487B7B5323A01D6E9E57A92FD6A41483
            511C7727250D822CA0B281818181818189B8B3BA76708D7FCA7FA82F705C9053
            E297DCDE65E115539ADB1EAE60528181818149BDE89E5C2C2984B996C0A56F01
            240F0256762E714C58ACE9E6134DAEDC1D6773818181BEBE6EE4BEC9712121F3
            BB63B8AA21B25DECA0D0E5C89D84985F40E04553B3EBC9AA8181C4E0E42BCD34
            D9D9195D6D8B8686734BB14A69E8E643A7ACD5348008A02E7EE9A0648181817A
            139E61C904C2B93D0CD7E373BB363A5B0E98E6588013613467139CDCEB9A5B8A
            818181817AE56E46E04AAC4CAA59944288D3AA5BD5E0E5E6A8E89A4D4A13644A
            E0E0818181818181817A16A061C9C2848E31B9B7993E12C2D5979746464A699A
            688006A8985481818181818181817A56C5DCC9293309AAB550A75BC14426E946
            56DC46A0E02239E5BD498181818181818181817AEDBEDCBE445BABB90C04BD54
            8186DF12B6BAD02BD284E8E6B0A94E81818181818181818181E3A890A3A1851F
            AFBD8A81818181811AA9EB46A8448A286EC798818181818181818181818187AB
            842EE9E9B917818181818181B861C228AD618E817DC7C7418181818181818181
            81818181814E7A7A878181818181818135E642815B0EA6818106F446A7818181
            818181818181818181818181818181818181818181C6B88181E67135818149DF
            C6B781818181818181818181818181818181818181818181810481818154E5B7
            8181818117B88181818181818181818181818181818181818181818181368181
            81814C7381818181818181818181818181818181818181818181818181818181
            8181818181814EC8818181818181}
          ParentShowHint = False
          ShowHint = True
          OnClick = SpeedButton8Click
        end
        object SpeedButton9: TSpeedButton
          Left = 268
          Top = 160
          Width = 50
          Height = 33
          Hint = 'Metal Armor MkII'
          Flat = True
          Glyph.Data = {
            4A080000424D4A080000000000003604000028000000240000001D0000000100
            08000000000014040000130B0000130B000000010000000000000C0E0C006C8E
            AC003C526400BCC6CC006C6E6C00242E2C009C9694005C5A5C00E4E6E4002442
            4C00ACAEA4004C5E6C00141E24007C7A7400D4D6DC00949A9C004C4E4C003C3E
            3C0034323400848A8400F4F6F400BCBABC00242224009CA2A4007C828400D4D2
            CC00747E84005C6A6C0084929C0074727400ECEEEC0054565400141614002C36
            3C00B4BABC00DCDEDC003C464C003C566400CCCECC006472840034464C00ACA2
            A400B4AEB400546674001C262C00343A3C00242A2C008C868400CCCAC4002C2E
            2C00F4EAF40084827C006C6A6C0094928C00E4DEE400C4C6C4005C625C00ECE6
            EC00545E6C001C1E1C00847E7C0054524C00948E8400C4C2C400A4A2A4006466
            64004C5A64001C1A1C004C4A4C00140E0C007C8A8C00444E5C006C7674009C9E
            9C00343E3C007C7E8400444244008C8A8C00FCFEFC00C4BEBC002C2624008C92
            9400F4EEF4003C4A5C00445A6C006476840034465C00B4B6B4003C3A3C002C32
            3C0084868C001C222C006C727400A4B6C4007C7E7C00DCDADC00849EB4004C52
            54003C4244003C363400FCFAFC00BCBEBC0024262400DCD2D400545A5C00141A
            1C002C3A4400DCE2E40044464400B4A6A400B4B2AC002C2A2C002C3234008486
            8400E4E2E400C4CACC0064625C00ECEAEC0054626C001C222400A4A6A400646A
            64007C8EA4008C96A4000C0E14003C526C00BCC6D4006C6E7400242E340084A6
            C40044526C0034424C002C424C00ECEEFC009C9A9C004C627400F4FAFC007C86
            8C00B4BEC400CCD2D4001C2A34009496940014121400444A4C005C5E5C00D4DA
            DC0034363400747674003C5A6400ACA6A4008C8E8C008C969400F4F2F400344A
            5C00E4E6EC00ACAEAC007C7A7C004C4E54003C3E4400848A8C009CA2AC00D4D2
            D4005C6A740054565C0014161C002C364400DCDEE40064728C00344654005466
            7C00343A4400242A34002C2E340084828400C4C6CC001C1E2400545254004C5A
            6C001C1A24007C8A94009C9EA400445A740064768C003C3A4400BCBEC4002426
            2C00B4B2B400E4E2EC0064626400ECEAF40054627400A4A6AC00646A6C001B00
            1600E73FF500770077000030210000CA1E001512E7000000770000E80000009F
            0000001915000000000001F8000000CA00000012000000000000C8545000CB21
            5B0012F5150000770000989B0000F30001001700000000000000FC281C00F7DB
            18001219E8000000770086000000BB000000E91500007700000020E80100189F
            0000E819000077000000FF000100FF000600FF000100FF00A10096CC40001BCB
            CA00E712120077000000F8BF7F00BE1F060043F5100000777E0098787F00F301
            0600171500000000000098834E00F3206F0017F56E000077650030080000F606
            44004315170000000000988D7F00F316060017F5100000777E004E4E4E4E4E4E
            4E4E4E4E4E641E7E831631AD40644E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E
            4E4E4E4E4E4E4E4E64A0A8590000453B1634404E4E4E4E4E4E4E4E4E4E4E4E4E
            4E4E4E4E4E4E4E4E4E4E4E4EA1A4778E0000000000436F404E4E4E4E4E4E4E4E
            4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E2331772C8E0000000000008E6F784E4E4E
            4EBA264E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E9320776900000000000000008E
            3B1F1E648D43864E4E4E4E4E4E4E4E4E4E4E4E4E4E4E223B8CAF000000000000
            000000008E20ACB10000B0644E4E4E4E4E4E4E4E4E4E4E4E4E4E898399A40000
            000000008E20A420208E66638E000037644E4E4E4E4E4E4E4E4E5FA1A1B853B5
            568E0000000000203B3B16666616434312430000BC4E4E4E4E4E4E4E4E7B2100
            008E698359000000007C203B166F129212126666128E204343574E4E4E4E4E4E
            A601B500008E20B2AF0C000000203B1631921111585812AC163B66163B864E4E
            4E4E4E4E8881A920000000433BAF698E433B1631584C1010441192310531316F
            16864E4E4E4E4E4E4E60A72C000020433B16163B3B163158441F90901F1F4411
            6F58583116B4144E4E4E4E4E4E5DB6A58E8E3B16166F6F31AA6A1110900490B0
            BCBC1F3D664C5831B9A8AD4E4E4E4E4E4E73825B433B16161666666FAAB1BEC0
            1D4D381010BCBC8F4C076C1270539B4E4E4E4E98409EA44316319211114C1158
            9212B79D0D783FBA494904580490B0624A31374E4E4E1CBE77433B31584C101F
            BC3493930474104C3144AE26B0345E311504114C92311044514EB37D2C431612
            584CB0BC9396409B9B78354C20662AA649931F6CAD6E066C20312E2E1A4E1427
            802C3B6F5811B034719B269ABD72A11DBC40A1BD3971311833936D9004123193
            084E4E1E3AAB7766925844414D3FBD858585BB86AD8D18BA866C1F798D3E0DB4
            9F621F084E4E4E4E75A3AB166F926C07AD15BD858585A195651876A224047F76
            0B47B80E416C084E4E4E4E4E4E755CB9163158100440A6855232291746548794
            252BC068281B364F344C4E4E4E4E4E4E4E4E4EBF246612111F5E579A5267309A
            9A9A7AA0914221AC849726553450234E4E4E4E4E4E4E4E4E6B5A2D706C079C0A
            6E5F4E4E4E4E985F4E8B020961863CA14B3411724E4E4E4E4E4E4E4E4E4E910F
            62109078194E4E4E4E4E4E4E4E4E8A230348125F64A1046C724E4E4E4E4E4E4E
            4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E753F988D1D404E4E159C1F724E4E
            4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E08574E6535B0984E4EA1
            962F4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E08084E4E3F93
            494E4E4E755F4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E
            4E4E98401F4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E4E
            4E4E4E4E4E4E4E64134E4E4E4E4E}
          ParentShowHint = False
          ShowHint = True
          OnClick = SpeedButton9Click
        end
        object SpeedButton10: TSpeedButton
          Left = 168
          Top = 200
          Width = 50
          Height = 33
          Hint = 'Combat Armor'
          Flat = True
          Glyph.Data = {
            BE080000424DBE080000000000003604000028000000250000001D0000000100
            08000000000088040000130B0000130B00000001000000000000040E04007486
            840024463C0014261C001C3624005C666400345E440004160C00BCC6BC001C26
            6C002C2A2C00343634001C1A1C00444644009CAAA4001C2E1C002C5244000C1E
            140024363C00E4E6E400545E54007476740004063C007C9A8C003C6A4C002426
            240034463C00445E4C0014161400D4DAD4001C2E34001C42340014121400646E
            6400343E3400B4B6B4008C8A8C00142A2C00040E14003C6644000C2224001C22
            3C003C524C007C928C000C161C00CCCACC001C221C00243E3C00343E44002C4E
            3C003C5E440044524400ACAAAC00242E2400848684001C261C002C362C006C6A
            6C002C322C00345A4400141E1400F4F6F40084828400344E3C002C4634005C6A
            74000C160C00A4AEAC0034523C0094969400242E34002C3E34000C0E0C007C86
            7C00243624006C7E6C000412240014162400E4E2E4006C6E6C000C0E1400CCD2
            CC002C464400241E2400A4A6A4001C2E2C002C363C00ECEEEC00242634003C46
            3C0044665400DCE2E400243E2C003C3E3C00BCBEBC001C262C00242224002C42
            3C003C3E44003C5E54005456540034564C00949E9C002436340004120400142A
            22006466640034625400C4C6C4002C2E30003C3A3C001C1E2C00444E4C000C22
            180044625000141A1900DCDADC00141E24003C6248004C52540024322A001C2A
            210034323400142219002C4A39000C1A130034564200243237006C827C004C6E
            5C00242E54008C969400447254008C929400FCFEFC004C4A4C00ECEAEC000C0A
            3400848E9400FCFAFC0064666C000C0E2400F4F2F4009C9E9C00747E8400444A
            540034464C0024424C007C8A8C00446A54003C4E4400D4D2D4003C6654001C22
            2C002C323C002C424C0094929400748A80005C6A600034624C00041A0C00BCCA
            C400343A3C001C1E1C001C322400E4EAEC0054625C00242A2400344A44001C32
            380064726C0034423C00B4BAB9003C564C000C1A1C00CCCECE0034424400243A
            2C006C726E000C121700A4AAA8002C3A3F0024423300BCC2C4001C2A31001422
            28004C564C000C1226009CA2A4002C564400243A3C00747A7400041214002442
            3C00ACAEAC00949A94002C4234000C120C00141A24002C4A44001C322C00242A
            34003C423C003C424400243A3400DCDEDC00646A6C00040E0C0014262400345E
            4C0004161400BCC6C4002C2A340034363C001C1A24001C2E24000C1E1C002426
            2C00445E540014161C00D4DADC0014121C00343E3C003C664C003C5254000C16
            24001C222400343E4C002C4E44003C5E4C0044524C00242E2C0084868C001C26
            24002C3634002C323400141E1C0084828C00344E44002C463C000C161400A4AE
            B40034524400242E3C007C86840024362C006C7E74006C6E74000C0E1C00CCD2
            D400A4A6AC003C464400243E34001C26340024222C0004120C0086868B4FF062
            4E86868686868686868686868686868686868686868686868686868686868600
            0000868BBCE2CF00EB741313ACC223AF888E8686868686868686868686868686
            8686868686868600000086A512EC0000001CF0CFC50B600B0A398B8686868686
            86868686868686868686868686868600000086F1B87300000000000C0B60530B
            0A604EFA548FB24FB2853D8686868686868686868686860000008B901E070000
            00FF422ED51CB3FEDBB33E6D37C50007ECD71D5E9EAAAF868686868686868600
            00003D41B8C50000CFAE005DECCFCFD6B300E2E27300C542EC7974FA475CB5C2
            868686868686860000008EB5E9FF000000C026FF48FFC5A342002E75736807A0
            2ED7CDB4F5402FDA138686868686860000008EB5E2FF0000C5BBBB8DEC737DE2
            E719F5D76DFFFFF0EC5FDCB478FC3FF2D3868686868686000000B712ECC5CF60
            2909898DB3DB73CB70052114A8ECB3E9E79AE39AAB677C7E0886868686868600
            0000195FB3CF48F07D82164CBBB3EC3A5DBA9E214B2AFF19229156D9AB33617E
            A1868686868686000000E7F0CF48F0C673E1BBF0DD7DD0D0F5CC40DAF6E6FF00
            FF730CDB2E0BE7EA83868686868686000000AF305F73FF00CFC0F32C73ECEC55
            FCFCB6313B5600687D7B2ECFFF00FF3759518686868686000000868A7FECFFCF
            CFFFAE117B0355B1FC7CEE3BD171A003A4B1F5B3F042117B7BBA3D8686868600
            000086AFBEE2F00019077D7B79A4B1C4F21B7232D111790440EF1A73EC7B0FD7
            4AB1AC86868686000000863D94557D0000077379D7A4B17C7E812784557BF567
            407EFBEC7BD7D7A47C7EBF86868686000000868613FBECFF00427D79B1B1FC31
            767227027369CCB67C06B0E969B1B1B1BD3B808686868600000086868EE8E27D
            077D7369A4B17CC7E47E31D87BF5FC52F25A9BD85FCCFCB610069D8686868600
            00008B39A7CF00C5737D79D70FB1CC7C7CA47DD8D767E4E472E0B57DC8CC2FC7
            3B9F9D868686860000008C00D27DAEFF00F07DF5A437D811F07DEC79A4FCE4A6
            B215770B7BA9C1C13B180186868686000000A3E92528AE07000007EC797D48CF
            42EC73ECA3B865706A4F0D5DA7B82FC77E6BF4868686860000008C78AED82CFF
            0007D8A4B1EF7B20B3B300B32C37B8D46E6E7A6E3579672FAD63F93D6C3E3600
            0000AF7828737DFF077D37F5CC403BD0B35050B32CB96FC9466D9960E2B9C699
            92936664EC791F0000008BCE037DF0FFA03C0FB12FE476F2FF26B3B36F7FB556
            CB0D877A73B3DBD5C973F069FC7C980000008697A27DD2FF7D7BD7B1FC7EE5DF
            71B3F0F0B8A97F7FEBA2DECBB3E14DE2C57DD7F5B6DF170000008686CDF77D07
            7D3C79F5404472967DF8CFECFD7F99B30073CB62B34DB3FF034A78B1B6954E00
            00008686863D23E72C1179F5FCEE3CCFB326732CB8B3CFCF00002E6DB3DBCF03
            A4B6C4A4B60E8B000000868686868613AC153A381AB2E70000CFECE2F0CF0000
            0000C058DBA073D7B17E44DA438B86000000868686868686868688888886572D
            EBCAE7A7FFFFC5CF0000B3FDC6B311D7EF7E2B5B868686000000868686868686
            86868686868686863D3D8E459C9C9C24EDEAEC3485493ACAC3748B8686868600
            0000}
          ParentShowHint = False
          ShowHint = True
          OnClick = SpeedButton10Click
        end
        object SpeedButton11: TSpeedButton
          Left = 218
          Top = 200
          Width = 50
          Height = 33
          Hint = 'Combat Armor MkII'
          Flat = True
          Glyph.Data = {
            BE080000424DBE080000000000003604000028000000250000001D0000000100
            08000000000088040000130B0000130B00000001000000000000040E04006486
            A400344A3C001C2A2400546E6C00243A2C0054565400141A140094C6E400445A
            4C00343234001C323400343A3400444A44001C223C0074727400242224000C0A
            2400344234009496940014221C00CCCACC00140E1400344A5C002C2A24005C7A
            7C002C322C00E4E6E4005466640044524C00345244001C2A3400141A24003446
            5400ACAEAC000C160C00646A6C002C4234003C423C000C0E1400243A44002432
            3C00DCDADC0064626400344A5400242A2400445E6C003C3A3C009CA29C002C32
            3C00F4F6F4004452640084AECC003C4A44001C1A1400243224007C7E7C001C22
            1C00141614004C524C006C726C002C3A34004C6254004C4E4C0034424400CCD2
            D4006C7A74001C1A24006C6A6C00ACAAAC00243234001C222C000C0E0C008486
            8400344E3C00546A8400545E5C004C5A54003C323400343E4400444E4400747A
            74002C2624000C1224003C5264002C2E34002C362C00ECEEEC00546274003C52
            4400242A3400BCBEBC003C463C000C1214006C666400242E2400A4AAA4001C26
            1C001C2E2C00141E1C00445E5C0034364400343E3400141E5400242624003446
            3C0014120C002C2E2C00547A94005C625C0044564C00ACB6B4002C3A4C00E4E2
            E400646664003C3E3C002C363C00FCFEFC001C1E1C0024362C001C1614004C56
            4C002C3E3400D4D2D4001C1E24006C6E6C008C96940014163C003C564400C4C6
            C400647E8C009C9E9C008C8E8C005C6A64005C5A5C00ECEAEC003C424C004C62
            7400A4A6A400FCFAFC0084828400F4F2F4002C464400141624007C7A7C005C5E
            5C005C7A9400B4B6B400344E6400646E6400243644003C566C00242E34005C66
            64003436340074767400CCCECC00141E2400DCDEDC0084B2CC003C4E44003446
            4400243634000C120C00546E8400142254002C3E4C00D4D6D400040E0C00344A
            44001C2A2C00243A3400141A1C00445A5400444A4C0034423C002C2A2C002C32
            34000C1614003C4244000C0E1C00242A2C001C1A1C0024322C001C2224001416
            1C00344E4400444E4C002C3634003C524C003C4644000C121C00242E2C00A4AA
            AC001C262400343E3C0024262C00141214004456540064666C003C3E44002C36
            44004C5654002C3E3C001C1E2C006C6E7400242E3C0000000000C8C85000CB05
            5B00121515000000000020000000E00001001900000000000000FC001C00F700
            18001200E8000000770086000000BB000000E900000077000000200301001800
            0000E800000077000000FF000100FF000600FF000100FF00A100960340001B00
            CA00E700120077000000F8CC7F00BECB0600431210000000590020607F00E022
            060019F500000077000020834E00E0206F0019F56E000077650030080000F606
            44004315170000000000208D7F00E016060019F510000077590075757544B9A8
            B68A757575757575757575757575757575757575757575757575757575757500
            000075757B68A30000B681154572C77D849C1B75757575757575757575757575
            75757575757575000000757551B8A30000A8480048B8687676763B7575757575
            7575757575757575757575757575750000007587AE43A8000000A84848B01010
            7676B09E44492BB0B091132A7575757575757575757575000000754146AC0000
            0048A3483910107676B9B986B0484848A3482727C57C86157575757575757500
            00007541C0C500000048484810B6B6072748275AB6484848C5C548C53AB01A6B
            5B7575757575750000007593C05D000000482748005DC55DB24820B547C548A3
            073A483AC52D9A0A9A71757575757500000075CDB5C5000048B611BF8F5D3AB6
            68B8682DB53AA3A348B607C5C56BBC6B1038757575757500000057AE9DA34848
            B4A567B4484807B6B33F6D3C4C7A76C52039393A3A563D56B00F757575757500
            0000837CC54848485D0E7F53C527B976C0AF798595421048C57676C5B66B1AB7
            689B7575757575000000493A27A34848A33A48484848C5105F560C123E8539A8
            48481627B93AB618689B75757575750000005784AA765D000000B95D4848B668
            1A3D0C66355976485D76683AACC5486AB69A81757575750000007541B5B82748
            A8004848A3C5761A3D3D3D66500D07ACC277667607B6762D2D684C7575757500
            0000757524B53A4848074816B6762DC00C3D730D3556765FA2C302C476106805
            0C12265775757500000075759C743948000048AC7610B5563D0CC3A00C39C077
            3DAF4A4F7C109AAF5CBA50607575750000007575757E103A48A307B610681A3D
            0C0C733DB839B7BCAFA94A4BB8B00CAFA080802275757500000032C10C3AA3B9
            A3A3AC68685F561A686BC4766362A2CBA10204017C6BAF8EA9BD1D608D8D8B00
            000073484827A3A35DB2AC5F7777BCB076B63AACC2C03DA935199F6C206B2FBA
            1E1EBD39A3B68300000048B97CAC0048A848072DB777C0B8B9AC3976B8373D02
            82080892A6144EA01E1EB7483AC2B80000005D3AAC3A4800A848B2B5B7BC7748
            484827C53A395F0B2988403121986B5C69AB27630AB3C0000000BBB263AC27A8
            4823AC6177BCA1C2C5484848483A7C5A98CE55C41047B126AF363AB7A0C6A000
            00001310ACB2A348485D3968B73D6959A03A484848B41F285458977029C4B552
            7648C26909641D000000870AACB24848480739B7772502025961A84848202996
            21C9942C2C4710763AC53DBD4D6E1C0000007515C05D4848A3B239B777660202
            0977A84827CC96C96365A4891743B6ACB9C0264D6ECA3000000075759C104848
            B207765F3D0CA0801D61A8A8278FC548A8C5A434338F78B903C3A06EAD995700
            0000757575755EB65DB9762DBCAF35793D4848484848A8000000482ECE76B6AC
            5FAF59BEBE937500000075757575759C2B0AB9106B73BB0648A848484800A800
            0000A8B8B51076762D665CBB6F75750000007575757575757587159C417BA78D
            226886C548A848A8A8000076768C152BC8908A87757575000000757575757575
            757575757575757575878B1B1B1B1BA73890B668158B758B5775757575757500
            0000}
          ParentShowHint = False
          ShowHint = True
          OnClick = SpeedButton11Click
        end
        object SpeedButton12: TSpeedButton
          Left = 268
          Top = 200
          Width = 50
          Height = 33
          Hint = 'Brotherhood Armor'
          Flat = True
          Glyph.Data = {
            BE080000424DBE080000000000003604000028000000250000001D0000000100
            08000000000088040000130B0000130B00000001000000000000040E04008486
            8400344A44001C2A24003C2A24006C4E340024121400445E5C00243A2C00C4C6
            C400141A1400544A34002C2A24003C3A3C000C0A24003C564400A4A6A400140E
            0C00E4E6E4006C6A6C001C223C002C322C00444A4400241E1C00847274002C42
            34001C221C004C3A2C008C96940034221C0024322C003C32240054564C003C42
            3C000C160C00D4D6D40014160C00F4F6F400747674005C5E5C001C1A1C00ACB6
            B4002C32340044524C0024261C00A49EA4000C0E1400242A2400343A34002C2A
            2C00345244004C564C00ECEEEC004C32240044423C00CCCECC00B4AEA4004C4A
            4C00344234009C9E9C00645A5C005C6664002C3A3400141A240054525400ACAE
            AC001C1214007C726C002C1E1C0084827C001C222C00443224005C5654001C16
            14007C7E7C0034323400242A3400342A2C000C0E0C008C8E8C003C4A44004C2E
            24005C524400443E34000C12240044564C00ACAAAC0014120C00F4EAF4006C72
            6C0034322400444E44001C261C009C9694003C26240024362C00DCDEDC007C7A
            7C001C1E1C002C2624000C121400242E240044463C0034464400646664001C2E
            2C00442A24006C666400241A1400545E5C00D4CAC400141E1C005C4E3C00342A
            24003C3E3C00A4AAA400ECEAEC006C6E6C00141E540024221C00544234003426
            1C00545A54003C463C0014161C00FCFEFC00747A7400C4C2BC002C3634008C66
            4C00947E7400A4A2A40014163C00AC9A940054666400847A7400CCCACC00DCDA
            DC00FCFAFC0064626400F4F2EC00D4D2D40094929400E4E2E4008C8A8400544E
            44002C46440044363400141624004C524C003C52440094969400B4B6B4002426
            2C004C3E3400343E34002C2E2C004C5A54004C362C00CCD2D40034463C002C3E
            34005C5A5C00445A4C0034362C009C9A9C00646A6C00442E1C00342E1C00344E
            44002C362C003C3624004C4E4C009CA29C00141E24002C221C0034363400342E
            2C000C120C003C4E440014225400040E0C001C2A2C00243A3400141A1C00140E
            1400444A4C001C22240024323400545654000C161400141614001C1A24004452
            5400242624000C0E1C00242A2C004C5654004442440034423C00848284004432
            2C001C161C0014121400444E4C001C262400243634001C1E24000C121C00242E
            2C004446440064666C00241A1C003C3E4400A4AAAC00ECEAF4006C6E74002422
            2400342624003C464400747A7C002C363C00F4F2F4003C524C00343E3C002C2E
            34002C3E3C00445A5400FF000100FF000600FF000100FF00A100960340001B00
            CA00E700120077000000F8CC8800BECB010043123F00000000002060F800E022
            0F0019F5F3000077000020830400E020000019F500000077000030080000F606
            00004315000000000000208D5800E016010019F5F300007700007D7D7D137CB5
            28107D7D7D7D7D7D7D7D7D7D7D7D7D7D7D7D7D7D7D7D7D7D7D7D7D7D7D7D7D00
            00007D7D8DC2B200002809885668D3754F37127D7D7D7D7D7D7D7D7D7D7D7D7D
            7D7D7D7D7D7D7D0000007D7D7EBBB20000B54E004EBBC2626262957D7D7D7D7D
            7D7D7D7D7D7D7D7D7D7D7D7D7D7D7D0000007D74BAC0B5000000B54E4E31D9D9
            6262316013018B3131275D897D7D7D7D7D7D7D7D7D7D7D0000007D9FBCB80000
            004EB24E1AD9D962627C7CA2314E4E4E244E112D48443C887D7D7D7D7D7D7D00
            00007D9FD1CB0000004E4E4ED928280A2E4E2E4C284E4E4ECBCB0683485EAB1B
            7F7D7D7D7D7D7D0000007D98D1640000004E2E4E0064CB64BE4E3FC446CB4EB2
            0ACA068348DAB0B19A8F7D7D7D7D7D0000007DD8C4CB00004E280ED09464BF28
            6228C22FC4BFB25742496C10484D9CD904457D7D7D7D7D00000034BAAEB24E4E
            C3B476C34E4E0A2862D9D19C0DAA62BF4B26DC9C624747D971437D7D7D7D7D00
            00003BCFCB4E4E4E64148454CB2E7C62D99C8030210D624E1A6801722A26911D
            44187D7D7D7D7D00000001BF2EB24E4EB2BF4E4E4E4ECBD965AAACAC16DB6200
            004ECBCBB81A2F0CAF877D7D7D7D7D000000344FB662640000007C644E4E28C2
            1530BA20165B624E64622C57B8CB4E4217B0097D7D7D7D0000007D9FC4BB2E4E
            B5004E4EB2CB6215300D90755B160AB8CD5F1F6C0A28D42F2FC26D7D7D7D7D00
            00007D7DA6C4BF4E4E0A4EB928622FD13016372BDBAA6265CEE0537162776308
            303A218C7D7D7D0000007D7D37DD1A4E00004EB862D9C4AA30D226AC4B1AD15F
            3EC70B78D9AF5AC77BA95B387D7D7D0000007D7D7D1CD9BF4EB20A28D9C21530
            300D364BBB1A1E80C7020543C2A8B0C7B30F0F417D7D7D00000025D630BFB27C
            B2B2B8C2C265AA15C29C99626F69CEE2676681A5D96AC79202DF2B73DEDE8A00
            0000724E4E2EB2B264BEB8655F5F80316228BFB8CDD13E0270826E8ECD7993A9
            3232DF1AB2283B0000004E7CCFCFB564B54E0ACDD15FD1BB7CB862D4170CA49A
            8558D78E391A51B332321E4E64BBBB00000064BFB86F4EE1B54EBE0A72E05F4E
            4E4E2ECBBF777152A58F234A6815A77BA0B72E6F6250D1000000CCBE6FB82E4E
            4E22B85CD18067CDCB4E4E4E4EBFC240DC4197138B15C99E3549BF1EA1C1B300
            000097D9B8BEB24E4E641AC21E3EA096B3BF4E4E4EBFB0D28BDC13BD40B0C463
            D94ECDA0A3072B000000744BB8BE4E4E4E0A1A1E5F19A06F9B5CB54E4ED90DC6
            40C68BBD409CD962B8BFCCDF9D55860000007D88D1644E4EB2BE1A1E5F9B80D9
            7A5FB54ECB31C6C662720126A2C228B87CD1219D55C5AD0000007D7D37D94E4E
            BE0A62653E30B3322B5CB5B51117BF4E00BE01231362497C03E0B355E33D3400
            00007D7D7D7D6B28647C622F80C750333E4E4E4E4E4E0000000000590D6228B8
            65C796DBDB987D0000007D7D7D7D7D378B4B7CD99C72CCBD4EB54E4E4E00B500
            0000002F31D962622F9B7BCC297D7D0000007D7D7D7D7D7D7D7488379F8D23DE
            41C2A2CB4EB54EB5B500006262C8888BD56110747D7D7D0000007D7D7D7D7D7D
            7D7D7D7D7D7D7D7D7D748A12121212234A6128C2888A7D8A347D7D7D7D7D7D00
            0000}
          ParentShowHint = False
          ShowHint = True
          OnClick = SpeedButton12Click
        end
        object SpeedButton13: TSpeedButton
          Left = 168
          Top = 240
          Width = 50
          Height = 33
          Hint = 'Power Armor'
          Flat = True
          Glyph.Data = {
            D6070000424DD60700000000000036040000280000001E0000001D0000000100
            080000000000A0030000130B0000130B00000001000000000000040E0400748E
            84003C4E4400142E3400546E6400A4CABC003432340054525400141E14008CAA
            9C00D4D2D4006C6E740094969C00243E5C0034423C004C5E540054625C002422
            2400242E24007C9A8C0024324400140E1400E4EAF4006C7E7400444E4C002436
            340044464C00B4DED40044564C001C26240064626400848E94004C7E7C00ACAE
            AC007C828400344A5C0014161400343A34005C6A5C00242E3400F4F6F4006472
            6C00BCC6CC00545A5400DCDEDC00242A2400B4BAC4000C1A1400141E2400A4A2
            A4005462740084A294004452640084968C0014162C00CCD6DC000C0E0C005C76
            74006C766C003C4A44005C625C002C362C004C565C00343E44005C5E5C003C42
            3C00F4F2F400748294004C4E4C00CCEEEC001C262C00848284001C161C00CCCA
            CC00749284005C6E6400949E9C003C6A6C002C2E2C00ECEAEC00748684004C4A
            5400C4DED400B4B6B4002C2E3400545A6400E4E6E4002C2A2C008C928C002C36
            3C001C1E1C0094B6A400D4DADC002C4A4C00242634008C9A9C002C364400747E
            7C00444654004C565400646A74005C7A74003C465400141A14003C3E3C00FCFE
            FC00C4C6C400545E5400E4E2E400BCBEBC001C1E24008CA29C000C120C00747A
            7C005C665C003C463C001C2A2C0004120C00344E5C003436340074727C004462
            6C0054665C002426240024322C00849A840024365400141214006C827400A4AA
            AC007C96A4004C6A6C00ACC2C400C4E6E4002C466400CCD6F4002C3E4C00BCE2
            D4008C8A9400B4B2B400FCFAFC00ACA6AC001C1A24007C968C00647A74007C8A
            84007C868C00DCE2EC004C525C00747674003C3E44009C9E9C00242A3400DCDA
            DC003C524C0054565C00D4D6DC00E4EEFC0044524C00243A3C00444A4400B4E2
            CC00445A54001C2A1C0064666400ACB2B4007C867C00343E3C0024323C00DCE2
            E4002C3A34004C5A5C004C52540084868400CCCED4005C726C00ECEEEC002C32
            34008C969400C4CACC001C2224008CA694008C8E8C00647E6C006C727400949A
            9C0034463C002436440064766C00A4A6A4001C1A1C002C322C002C3A3C001C22
            1C0094BAA4004C5A54003C4A5400040E0C00546E6C00141E1C004C5E5C00242E
            2C006C7E7C00344A640014161C00343A3C005C6A6400F4F6FC00545A5C00242A
            2C00849694000C0E14005C767C005C6264002C3634004C5664005C5E64003C42
            44004C4E54001C2634005C6E6C00B4B6BC002C2A34008C929400141A1C00C4C6
            CC00545E5C00BCBEC4000C121400747A84005C6664003C4644001C2A34003436
            3C005466640024262C00849A8C0014121C003C3E4C009C9EA40044525400444A
            4C0064666C0084868C00ECEEF4002C323C001C222C008CA69C0030080000F606
            44004315170000000000088D80006016090017F5F3000077000056A4D3CC8A28
            696969696969696969696969696969696969696969B056420000B8B4B48ED394
            5669696969696969696969696969696969696969994E38EE0000EB1D59B46ED3
            EF8C69696AD007DA44DADADAAC9BEF5C696969690638E0CC00005EA89898F6CC
            48B069EF7F247B7B7BBE5A7F38383844CF696947E4A874F100009827B48E2798
            387BABEB38BF4B5033132515D3D3D3CC6D8CDF246EC7A8A500004759EB0B6E30
            F6CCE76B38242B7DA1045A6711247024AD49EDCCE0BBF14200000CD16ED3E027
            3024E07B38241DE6C2A0B1BFBFD6B47F774E7FE4E8C9DD69000021D198CC5A24
            46B4383838C7B1E7EC10BF191959AABF7F70384646A569690000CE3F9F8E5A7B
            12DB27E0C727F10F6F91D12D7CB118B7B146D18EA5696969000097C834988603
            6802A8A823664B802AEC0F24E0573B26884671536969696900004222E6797EA8
            14A2C9EA657AE60987824B7AE79EB4CC0D556969696969690000699940CB3263
            7660B106B5D018AF931B80E76BE7118E36A56969696969690000696931432E96
            3BC424E417C87F7BE352BCD97A68707F5A4F69696969696900006969E542B09B
            B129CD38D11CC95A5F89AFF14BCD5AD6F169696969696969000069AE78699CDE
            D9CE3919E4C97CE74C85DC3EBC3E61CAB3696969696969690000690A0B8D24C1
            C302C8C67A9073293752E6CEBC7BE0788C696969696969690000696981067F7B
            633BBC9EA4351FD24505F0BC637BBEDA4269696969696969000069690B419EBE
            4EA00FA77AD2B2E25B8F6318117FD6588C6969696969696900006969D9A561BE
            7F63722FA33C4CA6BAB40875C50096B9696969696969696900006969DA8B9962
            1E18D06767256B4B01A64BAC066E1A6C696969696969696900006969A944F251
            DD2BCDE24A84169DF76ECC11B1E95669696969696969696900006969698C64E4
            B664E05ABFD98BB33D57D15AD1BD6969696969696969696900006969698CD5E0
            78EF7738D30EA7D09A5D9F6844696969696969696969696900006969698CA5CD
            D1F3703838257257D4204D9ADD696969696969696969696900006969696969D8
            F3CC24383838E44E7383A7F128696969696969696969696900006969696969EF
            0BF57C67703838183A44D0E169696969696969696969696900006969696969F4
            B3D7C0AA3FB1B495496969696969696969696969696969690000696969696969
            694F92F02D24542C696969696969696969696969696969690000696969696969
            69696D3E6EDAB369696969696969696969696969696969690000}
          ParentShowHint = False
          ShowHint = True
          OnClick = SpeedButton13Click
        end
        object SpeedButton14: TSpeedButton
          Left = 218
          Top = 240
          Width = 50
          Height = 33
          Hint = 'Hardened Power Armor'
          Flat = True
          Glyph.Data = {
            D6070000424DD60700000000000036040000280000001E0000001D0000000100
            080000000000A0030000130B0000130B00000001000000000000040E0400748E
            84003C4E4400142E3400546E6400A4CABC003432340054525400141E14008CAA
            9C00D4D2D4006C6E740094969C00243E5C0034423C004C5E540054625C002422
            2400242E24007C9A8C0024324400140E1400E4EAF4006C7E7400444E4C002436
            340044464C00B4DED40044564C001C26240064626400848E94004C7E7C00ACAE
            AC007C828400344A5C0014161400343A34005C6A5C00242E3400F4F6F4006472
            6C00BCC6CC00545A5400DCDEDC00242A2400B4BAC4000C1A1400141E2400A4A2
            A4005462740084A294004452640084968C0014162C00CCD6DC000C0E0C005C76
            74006C766C003C4A44005C625C002C362C004C565C00343E44005C5E5C003C42
            3C00F4F2F400748294004C4E4C00CCEEEC001C262C00848284001C161C00CCCA
            CC00749284005C6E6400949E9C003C6A6C002C2E2C00ECEAEC00748684004C4A
            5400C4DED400B4B6B4002C2E3400545A6400E4E6E4002C2A2C008C928C002C36
            3C001C1E1C0094B6A400D4DADC002C4A4C00242634008C9A9C002C364400747E
            7C00444654004C565400646A74005C7A74003C465400141A14003C3E3C00FCFE
            FC00C4C6C400545E5400E4E2E400BCBEBC001C1E24008CA29C000C120C00747A
            7C005C665C003C463C001C2A2C0004120C00344E5C003436340074727C004462
            6C0054665C002426240024322C00849A840024365400141214006C827400A4AA
            AC007C96A4004C6A6C00ACC2C400C4E6E4002C466400CCD6F4002C3E4C00BCE2
            D4008C8A9400B4B2B400FCFAFC00ACA6AC001C1A24007C968C00647A74007C8A
            84007C868C00DCE2EC004C525C00747674003C3E44009C9E9C00242A3400DCDA
            DC003C524C0054565C00D4D6DC00E4EEFC0044524C00243A3C00444A4400B4E2
            CC00445A54001C2A1C0064666400ACB2B4007C867C00343E3C0024323C00DCE2
            E4002C3A34004C5A5C004C52540084868400CCCED4005C726C00ECEEEC002C32
            34008C969400C4CACC001C2224008CA694008C8E8C00647E6C006C727400949A
            9C0034463C002436440064766C00A4A6A4001C1A1C002C322C002C3A3C001C22
            1C0094BAA4004C5A54003C4A5400040E0C00546E6C00141E1C004C5E5C00242E
            2C006C7E7C00344A640014161C00343A3C005C6A6400F4F6FC00545A5C00242A
            2C00849694000C0E14005C767C005C6264002C3634004C5664005C5E64003C42
            44004C4E54001C2634005C6E6C00B4B6BC002C2A34008C929400141A1C00C4C6
            CC00545E5C00BCBEC4000C121400747A84005C6664003C4644001C2A34003436
            3C005466640024262C00849A8C0014121C003C3E4C009C9EA40044525400444A
            4C0064666C0084868C00ECEEF4002C323C001C222C008CA69C0030080000F606
            44004315170000000000088D80006016090017F5F3000077000056A4D3CC8A28
            696969696969696969696969696969696969696969B056420000B8B4B48ED394
            5669696969696969696969696969696969696969994E38EE0000EB1D59B46ED3
            EF8C69696AD007DA44DADADAAC9BEF5C696969690638E0CC00005EA89898F6CC
            48B069EF7F247B7B7BBE5A7F38383844CF696947E4A874F100009827B48E2798
            387BABEB38BF4B5033132515D3D3D3CC6D8CDF246EC7A8A500004759EB0B6E30
            F6CCE76B38242B7DA1045A6711247024AD49EDCCE0BBF14200000CD16ED3E027
            3024E07B38241DE6C2A0B1BFBFD6B47F774E7FE4E8C9DD69000021D198CC5A24
            46B4383838C7B1E7EC10BF191959AABF7F70384646A569690000CE3F9F8E5A7B
            12DB27E0C727F10F6F91D12D7CB118B7B146D18EA5696969000097C834988603
            6802A8A823664B802AEC0F24E0573B26884671536969696900004222E6797EA8
            14A2C9EA657AE60987824B7AE79EB4CC0D556969696969690000699940CB3263
            7660B106B5D018AF931B80E76BE7118E36A56969696969690000696931432E96
            3BC424E417C87F7BE352BCD97A68707F5A4F69696969696900006969E542B09B
            B129CD38D11CC95A5F89AFF14BCD5AD6F169696969696969000069AE78699CDE
            D9CE3919E4C97CE74C85DC3EBC3E61CAB3696969696969690000690A0B8D24C1
            C302C8C67A9073293752E6CEBC7BE0788C696969696969690000696981067F7B
            633BBC9EA4351FD24505F0BC637BBEDA4269696969696969000069690B419EBE
            4EA00FA77AD2B2E25B8F6318117FD6588C6969696969696900006969D9A561BE
            7F63722FA33C4CA6BAB40875C50096B9696969696969696900006969DA8B9962
            1E18D06767256B4B01A64BAC066E1A6C696969696969696900006969A944F251
            DD2BCDE24A84169DF76ECC11B1E95669696969696969696900006969698C64E4
            B664E05ABFD98BB33D57D15AD1BD6969696969696969696900006969698CD5E0
            78EF7738D30EA7D09A5D9F6844696969696969696969696900006969698CA5CD
            D1F3703838257257D4204D9ADD696969696969696969696900006969696969D8
            F3CC24383838E44E7383A7F128696969696969696969696900006969696969EF
            0BF57C67703838183A44D0E169696969696969696969696900006969696969F4
            B3D7C0AA3FB1B495496969696969696969696969696969690000696969696969
            694F92F02D24542C696969696969696969696969696969690000696969696969
            69696D3E6EDAB369696969696969696969696969696969690000}
          ParentShowHint = False
          ShowHint = True
          OnClick = SpeedButton14Click
        end
        object Label120: TLabel
          Left = 152
          Top = 416
          Width = 8
          Height = 13
          Caption = '+'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label121: TLabel
          Left = 152
          Top = 442
          Width = 8
          Height = 13
          Caption = '+'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label122: TLabel
          Left = 240
          Top = 416
          Width = 8
          Height = 13
          Caption = '='
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label123: TLabel
          Left = 240
          Top = 442
          Width = 8
          Height = 13
          Caption = '='
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object SpeedButton15: TSpeedButton
          Left = 168
          Top = 280
          Width = 50
          Height = 33
          Hint = 'Advanced Power Armor'
          Flat = True
          Glyph.Data = {
            7A060000424D7A060000000000003604000028000000140000001D0000000100
            08000000000044020000130B0000130B00000001000000000000040E04005C92
            A4002C4E5C005C5E4400042E4C003C6A84005C725C002C2E1C00C4C6C400444E
            4C00241E2400949294002C3E440074766C00445A5C00141E1400444234005C66
            5C005C7E8C00A4AEAC00141214007C8A8400444E54002C3E4C0024424C00346E
            9C005C727400545A54006C6A6C0074AADC00849684000C160C0074826C000C1E
            34005C6A7400345E6C002C3234001C2E3400949E9C00848A7C00545254004C72
            7C00E4E6E4005C6E5C00849294002C464C006C7274003C3A3C000C121C003C4E
            54003C3E3C00444A3C00C4C2C40044565C0054625C00848284002C3A3C001C3A
            64005C5A5C00342A2C004C625C0064666400B4AEAC0014262C001C3A44000C0E
            0C006C7264001C262400545A6400A4A29C00848A8C00547A7C003C464C00D4D6
            D400544E4C0024262400949A9600847A5C004C5A64001C1E1E004C5258006472
            74000C161C007C867C00242E2F00FCFAFC00345660004C666C00343E3800747A
            7400444244006C868400ACAEB000141A1C00447AB400747E80003C5A6C003432
            340054767C005C625C008C8A8C0004121400143244003C362400CCCED0004C52
            3C005C666C005C8694004452640014466C00446E94005C728400545E58001C1E
            2C00646A74002C5E8C009CA6AC0054565600ECEEEC008C92880034464C006C7A
            74003C4644004C4A4400343A3700646A6C001C262C006C7A6C00242A3C00548A
            C400E4E2DC006492CC0074929C00647A6C004C6E7C00446EB4001C4A74002456
            5C0014364C0064625400B4B6B400545644004C62740064726C00342E1C00646E
            6800648684007C7274003C6AA4008C968C0014222C00ECEAEC00ACA6A400546A
            74004C464C007C7E7C00F4F2F4001422240064828C00343E4C009C9E9C005C5E
            6C004C5A6C00ACB2BC0054728C00142E54004C4E4C001C426C001C263C00446A
            7C00CCC6CC004C565C009C9A9C003C565C007C7A7C001C1A2000646264005C5E
            54002C2E2C00445A6C00444A4C003C2A2C00243A4400343E44008C9294003446
            5C006C7A840004120C009496940044525C005C7678000C1A14005C6E7C003462
            74002C3639001C3238002C4A54003C5258003C42420084868300646A6100B4B2
            B4000C120E006C766C00545E6A00A4A6A400848E90003C4A4C00242A28004C5E
            62001C221C0064767C000C1A1F002432340044464700ACB2B4002C525C002422
            24002C424400141614006C6E6C006C7674005C5E5C00FCFEFC00343634008C8E
            8C005C6A6C001C222C001C2A2C008C9A8C007C827C0034424C009CA29C005476
            8C004C524C00040E0C0094929C0074767400141E1C005C666400444E5C00545A
            5C000C1614005C6A7C00345E7400848A840054525C004C7284000C122400444A
            440044566400546264002C3A44006C726C00547A84003C465400DFDFDFDFDF59
            4B24C2FAD7DFDFDFDFDFDFDFDFDFDFDFDFDF59D90000004FABB8EFDC0BDFDFDF
            DFDFDFDFD7D732D64F00007A4EF1F5CDC734DFDFDFDFDF5C11DD7BC84B0000D6
            BDF11BFDD608DFDFDFDFDF139972F9F9B214007CD0B4C63DCDDFDFDFDFDFDF5C
            12CC1B2F2461CA5843A63DAADFDFDFDFDFDFDFDF2C3C637CD675B24BF9DC8515
            DFDFDFDFDFDFDFDF26FBB1B47DC728B2A6F5537F68DFDFDFDFDFDF55BABE3375
            2EBC3DA6754CF5636355DFDFDFDFDFA3E7D348CC2E461C28FD4CF5FDF1C7DFDF
            DFDF686ABD925072DCED3D75E6CEED0D1BDE49DFDFDF5C6CE2BEABC0B01CDE3A
            159B3D9175A65CDFDFDF4CC5AD86D1A4CC3A75C8535F752850F18CDFDFDF97C4
            A9623C6FCC28A6FDCBFD36B4708FAC49E8822A8E01291A9F50D6759111EAE0C2
            63C88D772745745184F79ED00AE075507CEE004F10034D20C7A0ECCCFF17E957
            D6B7614BCABB0000078B4269F977CD5F4FEBA8D8D5E3F2EBB96E8AEBCA90672B
            1EBC44F35DF8049D60C5E396831D19A5EB001F0695E122E7416D810CE2CE4C80
            73879488D400CAD270C7A1D6AF5E6B5B53E1C9F59F66A73921EBEBBBAE55285A
            C63647FED1D1794CE59138E3E4EA00F5DFDF76640935B32331D1560E8FE6E68F
            9109003BDFDFDF931686C33F3FFCC1562DCF1B367A5DEB1437DF98B5E70502C3
            3F7E1823F4187EDBBB0052DACAF54A09F0D8893F30EBCA18C418D4000000BB31
            D9CAC616A27EB64065001F547825EB00D4D50FBFD95DA0B4585430DBD6AC8CDF
            2AC6AF9D7DDE547EC243DFB00A9AE18CDFDFDFDFDFDF3E35799CE1F671C7}
          ParentShowHint = False
          ShowHint = True
          OnClick = SpeedButton15Click
        end
        object SpeedButton16: TSpeedButton
          Left = 218
          Top = 280
          Width = 50
          Height = 33
          Hint = 'Advanced Power Armor Mk2'
          Flat = True
          Glyph.Data = {
            7A060000424D7A060000000000003604000028000000140000001D0000000100
            08000000000044020000130B0000130B00000001000000000000040E04005C92
            A4002C4E5C005C5E4400042E4C003C6A84005C725C002C2E1C00C4C6C400444E
            4C00241E2400949294002C3E440074766C00445A5C00141E1400444234005C66
            5C005C7E8C00A4AEAC00141214007C8A8400444E54002C3E4C0024424C00346E
            9C005C727400545A54006C6A6C0074AADC00849684000C160C0074826C000C1E
            34005C6A7400345E6C002C3234001C2E3400949E9C00848A7C00545254004C72
            7C00E4E6E4005C6E5C00849294002C464C006C7274003C3A3C000C121C003C4E
            54003C3E3C00444A3C00C4C2C40044565C0054625C00848284002C3A3C001C3A
            64005C5A5C00342A2C004C625C0064666400B4AEAC0014262C001C3A44000C0E
            0C006C7264001C262400545A6400A4A29C00848A8C00547A7C003C464C00D4D6
            D400544E4C0024262400949A9600847A5C004C5A64001C1E1E004C5258006472
            74000C161C007C867C00242E2F00FCFAFC00345660004C666C00343E3800747A
            7400444244006C868400ACAEB000141A1C00447AB400747E80003C5A6C003432
            340054767C005C625C008C8A8C0004121400143244003C362400CCCED0004C52
            3C005C666C005C8694004452640014466C00446E94005C728400545E58001C1E
            2C00646A74002C5E8C009CA6AC0054565600ECEEEC008C92880034464C006C7A
            74003C4644004C4A4400343A3700646A6C001C262C006C7A6C00242A3C00548A
            C400E4E2DC006492CC0074929C00647A6C004C6E7C00446EB4001C4A74002456
            5C0014364C0064625400B4B6B400545644004C62740064726C00342E1C00646E
            6800648684007C7274003C6AA4008C968C0014222C00ECEAEC00ACA6A400546A
            74004C464C007C7E7C00F4F2F4001422240064828C00343E4C009C9E9C005C5E
            6C004C5A6C00ACB2BC0054728C00142E54004C4E4C001C426C001C263C00446A
            7C00CCC6CC004C565C009C9A9C003C565C007C7A7C001C1A2000646264005C5E
            54002C2E2C00445A6C00444A4C003C2A2C00243A4400343E44008C9294003446
            5C006C7A840004120C009496940044525C005C7678000C1A14005C6E7C003462
            74002C3639001C3238002C4A54003C5258003C42420084868300646A6100B4B2
            B4000C120E006C766C00545E6A00A4A6A400848E90003C4A4C00242A28004C5E
            62001C221C0064767C000C1A1F002432340044464700ACB2B4002C525C002422
            24002C424400141614006C6E6C006C7674005C5E5C00FCFEFC00343634008C8E
            8C005C6A6C001C222C001C2A2C008C9A8C007C827C0034424C009CA29C005476
            8C004C524C00040E0C0094929C0074767400141E1C005C666400444E5C00545A
            5C000C1614005C6A7C00345E7400848A840054525C004C7284000C122400444A
            440044566400546264002C3A44006C726C00547A84003C465400DFDFDFDFDF59
            4B24C2FAD7DFDFDFDFDFDFDFDFDFDFDFDFDF59D90000004FABB8EFDC0BDFDFDF
            DFDFDFDFD7D732D64F00007A4EF1F5CDC734DFDFDFDFDF5C11DD7BC84B0000D6
            BDF11BFDD608DFDFDFDFDF139972F9F9B214007CD0B4C63DCDDFDFDFDFDFDF5C
            12CC1B2F2461CA5843A63DAADFDFDFDFDFDFDFDF2C3C637CD675B24BF9DC8515
            DFDFDFDFDFDFDFDF26FBB1B47DC728B2A6F5537F68DFDFDFDFDFDF55BABE3375
            2EBC3DA6754CF5636355DFDFDFDFDFA3E7D348CC2E461C28FD4CF5FDF1C7DFDF
            DFDF686ABD925072DCED3D75E6CEED0D1BDE49DFDFDF5C6CE2BEABC0B01CDE3A
            159B3D9175A65CDFDFDF4CC5AD86D1A4CC3A75C8535F752850F18CDFDFDF97C4
            A9623C6FCC28A6FDCBFD36B4708FAC49E8822A8E01291A9F50D6759111EAE0C2
            63C88D772745745184F79ED00AE075507CEE004F10034D20C7A0ECCCFF17E957
            D6B7614BCABB0000078B4269F977CD5F4FEBA8D8D5E3F2EBB96E8AEBCA90672B
            1EBC44F35DF8049D60C5E396831D19A5EB001F0695E122E7416D810CE2CE4C80
            73879488D400CAD270C7A1D6AF5E6B5B53E1C9F59F66A73921EBEBBBAE55285A
            C63647FED1D1794CE59138E3E4EA00F5DFDF76640935B32331D1560E8FE6E68F
            9109003BDFDFDF931686C33F3FFCC1562DCF1B367A5DEB1437DF98B5E70502C3
            3F7E1823F4187EDBBB0052DACAF54A09F0D8893F30EBCA18C418D4000000BB31
            D9CAC616A27EB64065001F547825EB00D4D50FBFD95DA0B4585430DBD6AC8CDF
            2AC6AF9D7DDE547EC243DFB00A9AE18CDFDFDFDFDFDF3E35799CE1F671C7}
          ParentShowHint = False
          ShowHint = True
          OnClick = SpeedButton16Click
        end
        object Label41: TLabel
          Left = 16
          Top = 48
          Width = 48
          Height = 13
          Caption = 'Armor Cl'
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
        end
        object Label118: TLabel
          Left = 324
          Top = 8
          Width = 56
          Height = 13
          Caption = 'Armor (Item)'
        end
        object Label126: TLabel
          Left = 500
          Top = 8
          Width = 62
          Height = 13
          Caption = 'Helmet (Item)'
        end
        object Edit99: TEdit
          Left = 72
          Top = 104
          Width = 40
          Height = 21
          TabOrder = 0
          Text = '0'
          OnChange = Edit99Change
        end
        object Edit100: TEdit
          Left = 72
          Top = 130
          Width = 40
          Height = 21
          TabOrder = 1
          Text = '0'
          OnChange = Edit100Change
        end
        object Edit101: TEdit
          Left = 72
          Top = 156
          Width = 40
          Height = 21
          TabOrder = 2
          Text = '0'
          OnChange = Edit101Change
        end
        object Edit102: TEdit
          Left = 72
          Top = 182
          Width = 40
          Height = 21
          TabOrder = 3
          Text = '0'
          OnChange = Edit102Change
        end
        object Edit103: TEdit
          Left = 72
          Top = 208
          Width = 40
          Height = 21
          TabOrder = 4
          Text = '0'
          OnChange = Edit103Change
        end
        object Edit104: TEdit
          Left = 72
          Top = 234
          Width = 40
          Height = 21
          TabOrder = 5
          Text = '0'
          OnChange = Edit104Change
        end
        object Edit105: TEdit
          Left = 72
          Top = 260
          Width = 40
          Height = 21
          TabOrder = 6
          Text = '0'
          OnChange = Edit105Change
        end
        object Edit106: TEdit
          Left = 120
          Top = 104
          Width = 40
          Height = 21
          TabOrder = 7
          Text = '0'
          OnChange = Edit106Change
        end
        object Edit107: TEdit
          Left = 120
          Top = 130
          Width = 40
          Height = 21
          TabOrder = 8
          Text = '0'
          OnChange = Edit107Change
        end
        object Edit108: TEdit
          Left = 120
          Top = 156
          Width = 40
          Height = 21
          TabOrder = 9
          Text = '0'
          OnChange = Edit108Change
        end
        object Edit109: TEdit
          Left = 120
          Top = 182
          Width = 40
          Height = 21
          TabOrder = 10
          Text = '0'
          OnChange = Edit109Change
        end
        object Edit110: TEdit
          Left = 120
          Top = 208
          Width = 40
          Height = 21
          TabOrder = 11
          Text = '0'
          OnChange = Edit110Change
        end
        object Edit111: TEdit
          Left = 120
          Top = 234
          Width = 40
          Height = 21
          TabOrder = 12
          Text = '0'
          OnChange = Edit111Change
        end
        object Edit112: TEdit
          Left = 120
          Top = 260
          Width = 40
          Height = 21
          TabOrder = 13
          Text = '0'
          OnChange = Edit112Change
        end
        object Edit60: TEdit
          Left = 264
          Top = 410
          Width = 40
          Height = 21
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 14
          Text = '0'
          OnChange = Edit60Change
        end
        object Edit79: TEdit
          Left = 264
          Top = 444
          Width = 40
          Height = 21
          Enabled = False
          Font.Charset = DEFAULT_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'MS Sans Serif'
          Font.Style = [fsBold]
          ParentFont = False
          TabOrder = 15
          Text = '0'
          OnChange = Edit79Change
        end
        object Edit80: TEdit
          Left = 104
          Top = 410
          Width = 40
          Height = 21
          Enabled = False
          TabOrder = 16
          Text = '0'
          OnChange = Edit60Change
        end
        object Edit113: TEdit
          Left = 104
          Top = 444
          Width = 40
          Height = 21
          Enabled = False
          TabOrder = 17
          Text = '0'
          OnChange = Edit79Change
        end
        object Edit114: TEdit
          Left = 168
          Top = 410
          Width = 40
          Height = 21
          TabOrder = 18
          Text = '0'
          OnChange = Edit114Change
        end
        object Edit115: TEdit
          Left = 168
          Top = 444
          Width = 40
          Height = 21
          TabOrder = 19
          Text = '0'
          OnChange = Edit115Change
        end
        object UpDown43: TUpDown
          Left = 208
          Top = 410
          Width = 16
          Height = 21
          Associate = Edit114
          Min = -200
          Max = 200
          TabOrder = 20
        end
        object UpDown44: TUpDown
          Left = 208
          Top = 444
          Width = 16
          Height = 21
          Associate = Edit115
          Min = -200
          Max = 200
          TabOrder = 21
        end
        object Edit36: TEdit
          Left = 72
          Top = 48
          Width = 40
          Height = 21
          Enabled = False
          ReadOnly = True
          TabOrder = 22
          Text = '0'
          OnChange = Edit36Change
        end
        object ComboBox8: TComboBox
          Left = 320
          Top = 24
          Width = 174
          Height = 457
          Style = csSimple
          ItemHeight = 13
          TabOrder = 23
          Text = 'None'
          Items.Strings = (
            'None'
            'PID_LEATHER_JACKET'
            'PID_LEATHER_ARMOR'
            'PID_LEATHER_ARMOR_MK_II'
            'PID_CURED_LEATHER_ARMOR'
            'PID_METAL_ARMOR'
            'PID_METAL_ARMOR_MK_II'
            'PID_TESLA_ARMOR'
            'PID_COMBAT_ARMOR'
            'PID_COMBAT_ARMOR_MK_II'
            'PID_BROTHERHOOD_COMBAT_ARMOR'
            'PID_NCR_ARMOR'
            'PID_ENVIROMENTAL_ARMOR'
            'PID_ENCLAVE_COMBAT_ARMOR'
            'PID_VAULT_13_SUIT'
            'PID_VAULT_SUIT'
            'PID_WORN_ROBE'
            'PID_BLUE_ROBE'
            'PID_RED_ROBE'
            'PID_GRAY_ROBE'
            'PID_POWERED_ARMOR'
            'PID_HARDENED_POWER_ARMOR'
            'PID_ADVANCED_POWER_ARMOR'
            'PID_ADVANCED_POWER_ARMOR_MK2'
            'PID_PURPLE_ROBE'
            'PID_KEEPBRIGE_ROBE'
            'PID_SAND_ROBE'
            'PID_TIBBETS_PRISON'
            'PID_DESERT_COMBAT_ARMOR')
        end
        object ComboBox9: TComboBox
          Left = 495
          Top = 24
          Width = 174
          Height = 457
          Style = csSimple
          ItemHeight = 13
          TabOrder = 24
          Text = 'None'
          Items.Strings = (
            'None'
            'PID_POWER_HELMET'
            'PID_MOTORCYCLE_HELMET'
            'PID_COMBAT_HELMET'
            'PID_COMBAT_HELMET_MK_II'
            'PID_BROTHERHOOD_HELMET'
            'PID_LEATHER_JACKET_HELMET'
            'PID_COMBAT_LEATHER_JACKET_HELMET'
            'PID_LEATHER_ARMOR_HELMET'
            'PID_LEATHER_ARMOR_HELMET_MK2'
            'PID_METAL_HELMET'
            'PID_METAL_HELMET_MK2'
            'PID_TESLA_HELMET'
            'PID_APA_HELMET'
            'PID_APA_HELMET_MK2'
            'PID_HARDENED_POWER_HELMET'
            'PID_ENCLAVE_COMBAT_HELMET'
            'PID_ENCLAVE_COMBAT_HELMET_MK2'
            'PID_DESERT_COMBAT_HELMET')
        end
      end
    end
    object TabSheet5: TTabSheet
      Caption = 'Perks/Traits'
      ImageIndex = 4
      object GroupBox9: TGroupBox
        Left = 8
        Top = 4
        Width = 673
        Height = 493
        Caption = 'Perks'
        TabOrder = 0
        object ValueListEditor1: TValueListEditor
          Left = 8
          Top = 16
          Width = 321
          Height = 441
          DefaultRowHeight = 16
          Font.Charset = EASTEUROPE_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'Verdana'
          Font.Style = []
          ParentFont = False
          TabOrder = 0
          TitleCaptions.Strings = (
            'Perk'
            'Value')
          OnStringsChange = ValueListEditor1StringsChange
          ColWidths = (
            250
            65)
        end
        object BitBtn11: TBitBtn
          Left = 264
          Top = 464
          Width = 64
          Height = 23
          Caption = 'reset Values'
          TabOrder = 1
          OnClick = BitBtn11Click
        end
        object ValueListEditor2: TValueListEditor
          Left = 344
          Top = 16
          Width = 321
          Height = 441
          DefaultRowHeight = 16
          Font.Charset = EASTEUROPE_CHARSET
          Font.Color = clBlack
          Font.Height = -11
          Font.Name = 'Verdana'
          Font.Style = []
          ParentFont = False
          TabOrder = 2
          TitleCaptions.Strings = (
            'Trait'
            'Value')
          OnStringsChange = ValueListEditor2StringsChange
          ColWidths = (
            250
            65)
        end
        object BitBtn12: TBitBtn
          Left = 600
          Top = 462
          Width = 64
          Height = 23
          Caption = 'reset Values'
          TabOrder = 3
          OnClick = BitBtn12Click
        end
      end
    end
  end
  object GroupBox8: TGroupBox
    Left = 489
    Top = 540
    Width = 345
    Height = 150
    Anchors = [akTop, akRight]
    Caption = 'Animation'
    TabOrder = 5
    object Label39: TLabel
      Left = 10
      Top = 18
      Width = 70
      Height = 13
      Caption = 'Critter Anim.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clBlack
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Image1: TImage
      Left = 174
      Top = 8
      Width = 155
      Height = 126
      Center = True
      Transparent = True
    end
    object Label42: TLabel
      Left = 234
      Top = 134
      Width = 34
      Height = 13
      Caption = 'gjhgjhg'
    end
    object Edit34: TEdit
      Left = 8
      Top = 36
      Width = 57
      Height = 21
      TabOrder = 0
      Text = '0'
      OnChange = Edit34Change
    end
    object UpDown18: TUpDown
      Left = 65
      Top = 36
      Width = 15
      Height = 21
      Associate = Edit34
      Max = 999
      TabOrder = 1
      Thousands = False
    end
    object CheckBox40: TCheckBox
      Left = 8
      Top = 64
      Width = 65
      Height = 17
      Caption = 'Unarmed'
      TabOrder = 2
    end
    object CheckBox41: TCheckBox
      Left = 8
      Top = 80
      Width = 65
      Height = 17
      Caption = 'Knife'
      TabOrder = 3
    end
    object CheckBox42: TCheckBox
      Left = 8
      Top = 96
      Width = 65
      Height = 17
      Caption = 'Club'
      TabOrder = 4
    end
    object CheckBox43: TCheckBox
      Left = 8
      Top = 112
      Width = 65
      Height = 17
      Caption = 'Hammer'
      TabOrder = 5
    end
    object CheckBox44: TCheckBox
      Left = 8
      Top = 128
      Width = 65
      Height = 17
      Caption = 'Spear'
      TabOrder = 6
    end
    object CheckBox51: TCheckBox
      Left = 96
      Top = 128
      Width = 65
      Height = 17
      Caption = 'Flamer'
      TabOrder = 7
    end
    object CheckBox50: TCheckBox
      Left = 96
      Top = 112
      Width = 65
      Height = 17
      Caption = 'R. Launchr'
      TabOrder = 8
    end
    object CheckBox49: TCheckBox
      Left = 96
      Top = 96
      Width = 65
      Height = 17
      Caption = 'Minigun'
      TabOrder = 9
    end
    object CheckBox48: TCheckBox
      Left = 96
      Top = 80
      Width = 65
      Height = 17
      Caption = 'H. Rifle'
      TabOrder = 10
    end
    object CheckBox47: TCheckBox
      Left = 96
      Top = 64
      Width = 65
      Height = 17
      Caption = 'Shootgun'
      TabOrder = 11
    end
    object CheckBox46: TCheckBox
      Left = 96
      Top = 48
      Width = 65
      Height = 17
      Caption = 'SMG'
      TabOrder = 12
    end
    object CheckBox45: TCheckBox
      Left = 96
      Top = 32
      Width = 65
      Height = 17
      Caption = 'Pistol'
      TabOrder = 13
    end
  end
  object StatusBar1: TStatusBar
    Left = 0
    Top = 708
    Width = 1192
    Height = 19
    Anchors = [akLeft, akBottom]
    BiDiMode = bdLeftToRight
    Font.Charset = RUSSIAN_CHARSET
    Font.Color = clBlack
    Font.Height = -11
    Font.Name = 'Verdana'
    Font.Style = []
    Panels = <
      item
        BiDiMode = bdLeftToRight
        ParentBiDiMode = False
        Style = psOwnerDraw
        Width = 800
      end
      item
        Alignment = taRightJustify
        BiDiMode = bdLeftToRight
        ParentBiDiMode = False
        Style = psOwnerDraw
        Width = 200
      end>
    ParentBiDiMode = False
    ParentShowHint = False
    ShowHint = False
    UseSystemFont = False
  end
  object Panel1: TPanel
    Left = 840
    Top = 545
    Width = 337
    Height = 89
    Anchors = [akTop]
    BevelInner = bvRaised
    BevelOuter = bvLowered
    Caption = 'Fonline:Reloaded - Critter Proto Editor'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentFont = False
    TabOrder = 7
  end
  object BitBtn5: TBitBtn
    Left = 840
    Top = 640
    Width = 105
    Height = 49
    Anchors = [akTop, akRight]
    Caption = 'SAVE'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clBlack
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentFont = False
    TabOrder = 8
    OnClick = BitBtn5Click
    Glyph.Data = {
      36030000424D3603000000000000360000002800000010000000100000000100
      18000000000000030000120B0000120B00000000000000000000FB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB
      00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF64B89C64B89CFB
      00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFFB00FF64B89C98EECA98EECA64B89CFB00FFFB00FFFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF64B89C9CF1CD60E3A560E3A59C
      F1CD64B89CFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      64B89CA1F3D166E8AB66E8AB66E8AB66E8ABA1F3D164B89CFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FF64B89C6DEDB26DEDB264B89C64B89C6D
      EDB26DEDB2A7F6D564B89CFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FF64B89C64B89CFB00FFFB00FF64B89C73F3B973F3B9ABF9D964B89CFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB
      00FF64B89C79F8BF79F8BFB0FBDD64B89CFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF64B89C7EFCC47EFCC4B3FD
      E064B89CFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB
      00FFFB00FFFB00FF64B89C81FFC881FFC864B89CFB00FFFB00FFFB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF64B89C64B8
      9CFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB
      00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB
      00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF}
  end
  object BitBtn6: TBitBtn
    Left = 1072
    Top = 640
    Width = 105
    Height = 49
    Anchors = [akTop]
    Caption = 'Edit raw data'
    TabOrder = 9
    OnClick = BitBtn6Click
    Glyph.Data = {
      36030000424D3603000000000000360000002800000010000000100000000100
      18000000000000030000120B0000120B00000000000000000000FB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB
      00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
      AAFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFAAAAAAF8F8F8F8F8F8F8F8F8F8
      F8F8F8F8F8F8F8F8F8F8F8F8F8F8AAAAAAFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFAAAAAAEDEDEDEDEDEDEDEDEDEDEDEDEDEDEDEDEDEDEDEDEDEDEDEDAAAA
      AAFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFAAAAAAE8E8E8E8E8E8E8E8E8E8
      E8E8E8E8E8E8E8E8E8E8E8E8E8E8AAAAAAFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFAAAAAAEAEAEAEAEAEAEAEAEAEAEAEAEAEAEAEAEAEAEAEAEAEAEAEAAAAA
      AAFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFAAAAAAEBEBEBEBEBEBEBEBEBEB
      EBEBEBEBEBEBEBEBEBEBEBEBEBEBAAAAAAFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFAAAAAAEFEFEFEFEFEFEFEFEFEFEFEFEFEFEFEFEFEFEFEFEFEFEFEFAAAA
      AAFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFAAAAAAF3F3F3F3F3F3F3F3F3F3
      F3F3F3F3F3F3F3F3F3F3F3F3F3F3AAAAAAFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFAAAAAAF7F7F7F7F7F7F7F7F7F7F7F7F7F7F7F7F7F7F7F7F7F7F7F7AAAA
      AAFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFAAAAAAFAFAFAFAFAFAFAFAFAFA
      FAFAFAFAFAAAAAAAAAAAAAAAAAAAAAAAAAFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFAAAAAAFDFDFDFDFDFDFDFDFDFDFDFDFDFDFDAAAAAAEDEDEDEDEDEDAAAA
      AAFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFAAAAAAFFFFFFFFFFFFFFFFFFFF
      FFFFFFFFFFAAAAAAFFFFFFAAAAAAFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB
      00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF}
  end
  object BitBtn7: TBitBtn
    Left = 63
    Top = 8
    Width = 65
    Height = 25
    Caption = 'Load'
    TabOrder = 10
    OnClick = BitBtn7Click
    Glyph.Data = {
      36030000424D3603000000000000360000002800000010000000100000000100
      18000000000000030000120B0000120B00000000000000000000FB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB
      00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      37A3CA37A3CA37A3CA37A3CA37A3CA37A3CA37A3CA37A3CA37A3CA37A3CAFB00
      FFFB00FFFB00FFFB00FFFB00FF37A3CA37A3CAA2FFFFA2FFFFA2FFFFA2FFFFA2
      FFFFA2FFFFA2FFFFA2FFFFA2FFFF37A3CAFB00FFFB00FFFB00FFFB00FF37A3CA
      37A3CA8FF5FC69F2FB69F2FB69F2FB69F2FB69F2FB69F2FB69F2FB8FF5FC37A3
      CAFB00FFFB00FFFB00FFFB00FF37A3CA80EFFA37A3CA74E9F845E1F645E1F645
      E1F645E1F645E1F645E1F645E1F674E9F837A3CAFB00FFFB00FFFB00FF37A3CA
      74E9F837A3CA66E2F633D8F333D8F333D8F333D8F333D8F333D8F333D8F366E2
      F637A3CAFB00FFFB00FFFB00FF37A3CA6AE4F738DBF437A3CAA2FFFFA2FFFFA2
      FFFFA2FFFFA2FFFFA2FFFFA2FFFFA2FFFFA2FFFF37A3CAFB00FFFB00FF37A3CA
      66E2F633D8F333D8F337A3CA37A3CA37A3CA37A3CA37A3CA37A3CA37A3CA37A3
      CA37A3CAFB00FFFB00FFFB00FF37A3CA80EFFA55E9F855E9F880EFFA80EFFA80
      EFFA80EFFA80EFFA80EFFA80EFFA37A3CAFB00FFFB00FFFB00FFFB00FF37A3CA
      A2FFFFA2FFFFA2FFFF37A3CA37A3CA37A3CA37A3CA37A3CA37A3CA37A3CAFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FF37A3CA37A3CA37A3CAFB00FFFB00FFFB
      00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB
      00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF
      FB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00
      FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB
      00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FFFB00FF}
  end
  object BitBtn8: TBitBtn
    Left = 131
    Top = 8
    Width = 65
    Height = 25
    Caption = 'Save'
    TabOrder = 11
    OnClick = BitBtn8Click
    Glyph.Data = {
      36040000424D3604000000000000360000002800000010000000100000000100
      2000000000000004000000000000000000000000000000000000000000000000
      0000000000000000000000000000000000000000000000000000000000000000
      0000000000000000000000000000000000000000000000000000000000000000
      0000000000000000000000000000000000000000000000000000000000000000
      000000000000000000000000000000000000000000000000000000000000A98D
      63FFAF8D5BFFA98D63FFAEAEAEFFAEAEAEFFAEAEAEFFAEAEAEFFAEAEAEFFAEAE
      AEFFAEAEAEFFA98D63FFAF8D5BFFA98D63FF000000000000000000000000AF8D
      5BFFF6DFC2FFA98D63FFF3F3F3FFF3F3F3FFF3F3F3FFF3F3F3FFF3F3F3FFF3F3
      F3FFF3F3F3FFA98D63FFF6DFC2FFAF8D5BFF000000000000000000000000AF8D
      5BFFF0C79AFFA98D63FFF5F5F5FFC2C2C2FFC2C2C2FFC2C2C2FFC2C2C2FFC2C2
      C2FFF5F5F5FFA98D63FFF0C79AFFAF8D5BFF000000000000000000000000AF8D
      5BFFF1C99CFFA98D63FFF8F8F8FFF8F8F8FFF8F8F8FFF8F8F8FFF8F8F8FFF8F8
      F8FFF8F8F8FFA98D63FFF1C99CFFAF8D5BFF000000000000000000000000AF8D
      5BFFF3CB9DFFA98D63FFFBFBFBFFC2C2C2FFC2C2C2FFC2C2C2FFC2C2C2FFC2C2
      C2FFFBFBFBFFA98D63FFF3CB9DFFAF8D5BFF000000000000000000000000AF8D
      5BFFF5CEA1FFA98D63FFFDFDFDFFFDFDFDFFFDFDFDFFFDFDFDFFFDFDFDFFFDFD
      FDFFFDFDFDFFA98D63FFF5CEA1FFAF8D5BFF000000000000000000000000AF8D
      5BFFF7D1A4FFA98D63FFA98D63FFA98D63FFA98D63FFA98D63FFA98D63FFA98D
      63FFA98D63FFA98D63FFF7D1A4FFAF8D5BFF000000000000000000000000AF8D
      5BFFF9D4A6FFF7C990FFF7C990FFF7C990FFF7C990FFF7C990FFF7C990FFF7C9
      90FFF7C990FFF7C990FFF9D4A6FFAF8D5BFF000000000000000000000000AF8D
      5BFFFAD7A9FFA98D63FFA98D63FFA98D63FFA98D63FFA98D63FFA98D63FFA98D
      63FFA98D63FFA98D63FFFAD7A9FFAF8D5BFF000000000000000000000000AF8D
      5BFFFDDAABFFA98D63FFF4F4F4FFF4F4F4FFF4F4F4FFF4F4F4FF928780FF9287
      80FFF4F4F4FFA98D63FFFDDAABFFAF8D5BFF000000000000000000000000AF8D
      5BFFFDDDADFFA98D63FFF8F8F8FFF8F8F8FFF8F8F8FFF8F8F8FF928780FF9287
      80FFF8F8F8FFA98D63FFFDDDADFFAF8D5BFF000000000000000000000000AF8D
      5BFFFFEDD3FFD0BE9FFFFDFDFDFFFDFDFDFFFDFDFDFFFDFDFDFFC1BAB5FFC1BA
      B5FFFDFDFDFFD0BE9FFFAF8D5BFF00000000000000000000000000000000A98D
      63FFAF8D5BFFA98D63FFAEAEAEFFAEAEAEFFAEAEAEFFAEAEAEFFAEAEAEFFAEAE
      AEFFAEAEAEFFA98D63FF00000000000000000000000000000000000000000000
      0000000000000000000000000000000000000000000000000000000000000000
      0000000000000000000000000000000000000000000000000000}
  end
  object BitBtn9: TBitBtn
    Left = 200
    Top = 8
    Width = 65
    Height = 25
    Caption = 'Backup'
    Enabled = False
    TabOrder = 12
    OnClick = BitBtn9Click
    Glyph.Data = {
      36030000424D3603000000000000360000002800000010000000100000000100
      18000000000000030000130B0000130B00000000000000000000000000000000
      0000000000000000000000000000000000000000000000000000000000000000
      0000000000000000000000000000203040B0D040A0D040A0C840A0C040A0C030
      80A040A0C040A0C040A0C040A0B8206880000000000000000000000000004060
      B8EEF080E0E080E0E080E0E080E0E060A0B080E0E080E0E080E0E080E0E040A0
      B8006080000000000000000000004060B8EEF080E0E080E0E080E0E080E0E060
      A0B080E0E080E0E080E0E080E0E040A0C0006080005878000000000000204060
      B8EEF080E0E080E0E080E0E080E0E060A0B080E0E080E0E080E0E080E0E040A0
      C00060880070A0000000000000204060B8EEF080E0E080E0E080E0E080E0E060
      A0B080E0E080E0E080E0E080E0E040A0C00060900070A0000000000000103850
      7CA7B860A0B060A0B060A0B060A0B050809860A0B060A0B060A0B060A0B03078
      980060880070A0000000000000204060B8EEF080E0E080E0E080E0E080E0E060
      A0B080E0E080E0E080E0E080E0E04098C00050780070A0000000000000204060
      B8EEF080E0E080E0E080E0E080E0E060A0B080E0E080E0E080E0E080E0E040A0
      C0006090006080000000000000204060B8EEF080E0E080E0E080E0E080E0E060
      A0B080E0E080E0E080E0E080E0E040A0C0006090006898000000000000204860
      B8EEF080E0E080E0E080E0E080E0E060A0B080E0E080E0E080E0E080E0E040A0
      C00060900070A0000000000000205060D4F5F8B8EEF0B8EEF0B8EEF0B8EEF07C
      AFC0B8EEF0B8EEF0B8EEF0B8EEF040B0D00060900070A0000000000000000000
      5C7F98F0FBFFF0FBFFF0FBFFF0FBFF7CC7E8C4E5F0F0FBFFF0FBFFF0FBFFD4ED
      F81068900070A0000000000000000000000000307898B8DEF0B8DEF0B8DEF0B8
      DEF07CC7D860C0D8B8DEF0B8DEF0B8DEF0A8D6E81080C0000000000000000000
      0000000000000040600040600040600040600040600040600040600040600040
      6000406000203000000000000000000000000000000000000000000000000000
      0000000000000000000000000000000000000000000000000000}
  end
  object ComboBox7: TComboBox
    Left = 8
    Top = 10
    Width = 49
    Height = 21
    Style = csDropDownList
    Ctl3D = False
    ItemHeight = 13
    ParentCtl3D = False
    TabOrder = 13
    OnChange = ComboBox7Change
  end
  object BitBtn4: TBitBtn
    Left = 268
    Top = 8
    Width = 58
    Height = 25
    Caption = 'New'
    TabOrder = 14
    OnClick = BitBtn4Click
    Glyph.Data = {
      2E020000424D2E0200000000000036000000280000000C0000000E0000000100
      180000000000F801000000000000000000000000000000000000D26F5AD26F5A
      D26F5AD26F5AD26F5AD26F5AD26F5AD26F5AD26F5AD26F5AD26F5AD26F5AD371
      5CFFEAE4FFEAE4FFEAE4FFE5DEFFE5DEFFE1DAFFE1DAFFE1DAFFDCD4FFDCD4D2
      6F5AD57560FFEDE6FFEDE6FFE9E2FFE9E2FFE5DEFFE5DEFFE5DEFFE0D8FFE0D8
      FFDCD4D26F5AD77964FFEFE9FFEFE9FFEFE9FFEAE3FFEAE3FFE6DFFFE6DFFFE2
      DBFFE2DBFFE2DBD26F5AD97D68FFF2EBFFF2EBFFEEE7FFEEE7FFEAE3FFEAE3FF
      EAE3FFE5DDFFE5DDFFE1D9D26F5ADB826CFFF4EEFFF4EEFFF0EAFFF0EAFFF0EA
      FFEBE4FFEBE4FFE7E0FFE7E0FFE3DCD26F5ADD8670FFF6F0FFF6F0FFF6F0FFF1
      EAFFF1EAFFEDE6FFEDE6FFE9E2FFE9E2FFE9E2D26F5ADF8A74FFF6F0FFF6F0FF
      F6F0FFF6F0FFF1EBFFF1EBFFF1EBFFECE5FFECE5FFE8E1D26F5AE18E78FFF6F0
      FFF6F0FFF6F0FFF6F0FFF6F0FFF2ECEEBEB3ECB9ACECB9ACECB9ACD26F5AE492
      7CFFF6F0FFF6F0FFF6F0FFF6F0FFF6F0F9E1D9DB8977E7A698E7A293E9AC9ED2
      6F5AE69780FFF6F0FFF6F0FFF6F0FFF6F0FFF6F0F6DCD3DE9483FFEFE9FFEBE4
      FFEFE9D2705BE89B84FFF6F0FFF6F0FFF6F0FFF6F0FFF6F0F7DDD4E09786FFF6
      F0FFF6F0D67762FFFFFFEA9F88FFF6F0FFF6F0FFF6F0FFF6F0FFF6F0F7DDD4DF
      9786FFF6F0DA7F69FFFFFFFFFFFFECA38CEAA089E89C86E79982E5957FE3927B
      E08D77E08D77DE8771FFFFFFFFFFFFFFFFFF}
  end
  object BitBtn10: TBitBtn
    Left = 952
    Top = 640
    Width = 105
    Height = 49
    Anchors = [akTop, akRight]
    Caption = 'Cancel'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clBlack
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ModalResult = 2
    ParentFont = False
    TabOrder = 15
    OnClick = BitBtn10Click
    Glyph.Data = {
      F6000000424DF600000000000000760000002800000010000000100000000100
      04000000000080000000130B0000130B00001000000000000000000000000000
      800000800000008080008000000080008000808000007F7F7F00BFBFBF000000
      FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00333333333333
      3333333333FFFFF333333333F77777FFF333333777333777FF333377FF333337
      7FF337777FF3333377F337F777FF333337FF77F3777FF333377F77F33777FF33
      377F77F333777FF3377F77F3333777FF377F77FF3333777FF773373FF3333777
      F7F33773FF333377773333773FFFFFF773333337773337773333}
  end
  object SaveDialog1: TSaveDialog
    Left = 72
    Top = 80
  end
  object OpenDialog1: TOpenDialog
    DefaultExt = '*'
    Filter = 'Fonline critter proto file|*|Any file|*.*'
    Left = 112
    Top = 80
  end
  object KAZip1: TKAZip
    IsZipFile = False
    SaveMethod = FastSave
    StoreRelativePath = True
    CompressionType = ctMaximum
    Active = False
    Left = 152
    Top = 80
  end
end
