object Form2: TForm2
  Left = 321
  Top = 139
  Width = 1300
  Height = 780
  Anchors = [akTop, akRight]
  Caption = 'Form2'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poDesktopCenter
  OnCreate = FormCreate
  DesignSize = (
    1292
    753)
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 1099
    Top = 64
    Width = 28
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'MapX'
  end
  object Label2: TLabel
    Left = 1155
    Top = 64
    Width = 28
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'MapY'
  end
  object Label3: TLabel
    Left = 256
    Top = 16
    Width = 6
    Height = 13
    Caption = '0'
  end
  object Label4: TLabel
    Left = 256
    Top = 32
    Width = 6
    Height = 13
    Caption = '0'
  end
  object Label5: TLabel
    Left = 192
    Top = 16
    Width = 59
    Height = 13
    Caption = 'Line counter'
  end
  object Label6: TLabel
    Left = 192
    Top = 32
    Width = 61
    Height = 13
    Caption = 'NPC counter'
  end
  object Label8: TLabel
    Left = 1091
    Top = 24
    Width = 48
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'Critter PID'
  end
  object Label7: TLabel
    Left = 331
    Top = 16
    Width = 54
    Height = 20
    Caption = 'nazwa'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clBlack
    Font.Height = -16
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object Label9: TLabel
    Left = 1211
    Top = 64
    Width = 19
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'DIR'
  end
  object Label10: TLabel
    Left = 1107
    Top = 104
    Width = 55
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'ScriptName'
  end
  object Label11: TLabel
    Left = 1107
    Top = 144
    Width = 52
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'FuncName'
  end
  object Label12: TLabel
    Left = 1107
    Top = 184
    Width = 55
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'Critter Cond'
  end
  object Label13: TLabel
    Left = 1107
    Top = 224
    Width = 73
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'Critter Cond Ext'
  end
  object Label14: TLabel
    Left = 1107
    Top = 264
    Width = 79
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'str_Critter_Anim1'
  end
  object Label15: TLabel
    Left = 1107
    Top = 304
    Width = 79
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'str_Critter_Anim2'
  end
  object Label16: TLabel
    Left = 1107
    Top = 344
    Width = 77
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'ST_DIALOG_ID'
  end
  object Label17: TLabel
    Left = 1107
    Top = 384
    Width = 47
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'ST_AI_ID'
  end
  object Label18: TLabel
    Left = 1107
    Top = 424
    Width = 59
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'ST_BAG_ID'
  end
  object Label19: TLabel
    Left = 1107
    Top = 464
    Width = 67
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'ST_TEAM_ID'
  end
  object Label20: TLabel
    Left = 1163
    Top = 8
    Width = 51
    Height = 13
    Anchors = [akTop, akRight]
    Caption = '                 '
    Visible = False
  end
  object Label22: TLabel
    Left = 1152
    Top = 40
    Width = 44
    Height = 16
    Anchors = [akTop, akRight]
    Caption = '------->'
    Font.Charset = EASTEUROPE_CHARSET
    Font.Color = clBlack
    Font.Height = -13
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object Label23: TLabel
    Left = 1200
    Top = 24
    Width = 43
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'New PID'
  end
  object Label21: TLabel
    Left = 1107
    Top = 504
    Width = 77
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'ST_NPC_ROLE'
  end
  object Label24: TLabel
    Left = 1107
    Top = 544
    Width = 123
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'ST_REPLICATION_TIME'
  end
  object Label25: TLabel
    Left = 1107
    Top = 584
    Width = 102
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'ST_FACTION_RANK'
  end
  object Label26: TLabel
    Left = 1107
    Top = 624
    Width = 104
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'ST_FACTION_MODE'
  end
  object Label27: TLabel
    Left = 1107
    Top = 664
    Width = 125
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'ST_OVERRIDE_CRTYPE'
  end
  object Label28: TLabel
    Left = 1107
    Top = 704
    Width = 53
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'ST_LEVEL'
  end
  object Label29: TLabel
    Left = 1093
    Top = 8
    Width = 64
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'Selected line:'
  end
  object Label30: TLabel
    Left = 744
    Top = 8
    Width = 38
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'Label30'
  end
  object Label31: TLabel
    Left = 744
    Top = 24
    Width = 38
    Height = 13
    Anchors = [akTop, akRight]
    Caption = 'Label31'
  end
  object Edit1: TEdit
    Left = 1091
    Top = 40
    Width = 46
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 1
  end
  object Edit2: TEdit
    Left = 1091
    Top = 80
    Width = 46
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 2
  end
  object Button1: TButton
    Left = 16
    Top = 16
    Width = 161
    Height = 25
    Caption = 'Open text map'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clBlack
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentFont = False
    TabOrder = 16
    TabStop = False
    OnClick = Button1Click
  end
  object Edit3: TEdit
    Left = 1147
    Top = 80
    Width = 46
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 3
  end
  object ListView1: TListView
    Left = 16
    Top = 56
    Width = 1036
    Height = 681
    Anchors = [akLeft, akTop, akRight, akBottom]
    Columns = <
      item
        Caption = 'nr_linii'
      end
      item
        Caption = 'nr_crittera'
      end
      item
        Caption = 'ProtoId'
        Width = 46
      end
      item
        Caption = 'MapX'
        Width = 45
      end
      item
        Caption = 'MapY'
        Width = 45
      end
      item
        Caption = 'Dir'
        Width = 25
      end
      item
        Caption = 'ScriptName'
        Width = 125
      end
      item
        Caption = 'FuncName'
        Width = 125
      end
      item
        Caption = 'Critter_Cond'
        Width = 70
      end
      item
        Caption = 'Critter_CondExt'
        Width = 85
      end
      item
        Caption = 'str_Critter_Anim1'
      end
      item
        Caption = 'str_Critter_Anim2'
      end
      item
        Caption = 'ST_DIALOG_ID'
      end
      item
        Caption = 'ST_AI_ID'
      end
      item
        Caption = 'ST_BAG_ID'
      end
      item
        Caption = 'ST_TEAM_ID'
      end
      item
        Caption = 'ST_NPC_ROLE'
      end
      item
        Caption = 'ST_REPLICATION_TIME'
      end
      item
        Caption = 'ST_FACTION_RANK'
      end
      item
        Caption = 'ST_FACTION_MODE'
      end
      item
        Caption = 'ST_OVERRIDE_CRTYPE'
      end
      item
        Caption = 'ST_LEVEL'
      end>
    GridLines = True
    HideSelection = False
    ReadOnly = True
    RowSelect = True
    SortType = stText
    TabOrder = 0
    ViewStyle = vsReport
    OnColumnClick = ListView1ColumnClick
    OnCompare = ListView1Compare
    OnSelectItem = ListView1SelectItem
  end
  object BitBtn1: TBitBtn
    Left = 827
    Top = 16
    Width = 105
    Height = 25
    Anchors = [akTop, akRight]
    Caption = 'Save to file'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clBlack
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentFont = False
    TabOrder = 15
    TabStop = False
    OnClick = BitBtn1Click
  end
  object Edit4: TEdit
    Left = 1203
    Top = 80
    Width = 46
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 4
  end
  object Edit5: TEdit
    Left = 1091
    Top = 120
    Width = 158
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 5
  end
  object Edit6: TEdit
    Left = 1091
    Top = 160
    Width = 158
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 6
  end
  object Edit7: TEdit
    Left = 1091
    Top = 200
    Width = 158
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 7
  end
  object Edit8: TEdit
    Left = 1091
    Top = 240
    Width = 158
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 8
  end
  object Edit9: TEdit
    Left = 1091
    Top = 280
    Width = 158
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 9
  end
  object Edit10: TEdit
    Left = 1091
    Top = 320
    Width = 158
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 10
  end
  object Edit11: TEdit
    Left = 1091
    Top = 360
    Width = 158
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 11
  end
  object Edit12: TEdit
    Left = 1091
    Top = 400
    Width = 158
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 12
  end
  object Edit13: TEdit
    Left = 1091
    Top = 440
    Width = 158
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 13
  end
  object Edit14: TEdit
    Left = 1091
    Top = 480
    Width = 158
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 14
  end
  object CheckBox1: TCheckBox
    Left = 939
    Top = 24
    Width = 105
    Height = 17
    Anchors = [akTop, akRight]
    Caption = 'Enable mass save'
    Enabled = False
    TabOrder = 17
    OnClick = CheckBox1Click
  end
  object CheckBox2: TCheckBox
    Left = 1065
    Top = 120
    Width = 17
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 18
    Visible = False
    OnClick = CheckBox2Click
  end
  object CheckBox3: TCheckBox
    Left = 1065
    Top = 160
    Width = 17
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 19
    Visible = False
    OnClick = CheckBox3Click
  end
  object CheckBox4: TCheckBox
    Left = 1065
    Top = 200
    Width = 17
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 20
    Visible = False
    OnClick = CheckBox4Click
  end
  object CheckBox5: TCheckBox
    Left = 1065
    Top = 240
    Width = 17
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 21
    Visible = False
    OnClick = CheckBox5Click
  end
  object CheckBox6: TCheckBox
    Left = 1065
    Top = 280
    Width = 17
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 22
    Visible = False
    OnClick = CheckBox6Click
  end
  object CheckBox7: TCheckBox
    Left = 1065
    Top = 320
    Width = 17
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 23
    Visible = False
    OnClick = CheckBox7Click
  end
  object CheckBox8: TCheckBox
    Left = 1065
    Top = 360
    Width = 17
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 24
    Visible = False
    OnClick = CheckBox8Click
  end
  object CheckBox9: TCheckBox
    Left = 1065
    Top = 400
    Width = 17
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 25
    Visible = False
    OnClick = CheckBox9Click
  end
  object CheckBox11: TCheckBox
    Left = 1065
    Top = 480
    Width = 17
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 26
    Visible = False
    OnClick = CheckBox11Click
  end
  object CheckBox10: TCheckBox
    Left = 1065
    Top = 440
    Width = 17
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 27
    Visible = False
    OnClick = CheckBox10Click
  end
  object Edit15: TEdit
    Left = 1200
    Top = 40
    Width = 46
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 28
  end
  object CheckBox12: TCheckBox
    Left = 1249
    Top = 80
    Width = 17
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 29
    Visible = False
    OnClick = CheckBox12Click
  end
  object CheckBox13: TCheckBox
    Left = 1249
    Top = 39
    Width = 17
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 30
    Visible = False
    OnClick = CheckBox13Click
  end
  object Edit16: TEdit
    Left = 1091
    Top = 520
    Width = 158
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 31
  end
  object CheckBox14: TCheckBox
    Left = 1065
    Top = 520
    Width = 17
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 32
    Visible = False
    OnClick = CheckBox11Click
  end
  object Edit17: TEdit
    Left = 1091
    Top = 560
    Width = 158
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 33
  end
  object Edit18: TEdit
    Left = 1091
    Top = 600
    Width = 158
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 34
  end
  object Edit19: TEdit
    Left = 1091
    Top = 640
    Width = 158
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 35
  end
  object Edit20: TEdit
    Left = 1091
    Top = 680
    Width = 158
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 36
  end
  object CheckBox15: TCheckBox
    Left = 1065
    Top = 560
    Width = 17
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 37
    Visible = False
    OnClick = CheckBox8Click
  end
  object CheckBox16: TCheckBox
    Left = 1065
    Top = 600
    Width = 17
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 38
    Visible = False
    OnClick = CheckBox9Click
  end
  object CheckBox17: TCheckBox
    Left = 1065
    Top = 680
    Width = 17
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 39
    Visible = False
    OnClick = CheckBox11Click
  end
  object CheckBox18: TCheckBox
    Left = 1065
    Top = 640
    Width = 17
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 40
    Visible = False
    OnClick = CheckBox10Click
  end
  object Edit21: TEdit
    Left = 1091
    Top = 720
    Width = 158
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 41
  end
  object CheckBox19: TCheckBox
    Left = 1065
    Top = 720
    Width = 17
    Height = 21
    Anchors = [akTop, akRight]
    TabOrder = 42
    Visible = False
    OnClick = CheckBox11Click
  end
  object Button2: TButton
    Left = 600
    Top = 16
    Width = 129
    Height = 25
    Anchors = [akTop, akRight]
    Caption = 'Otworz jako StringList'
    TabOrder = 43
    OnClick = Button2Click
  end
  object OpenDialog1: TOpenDialog
    DefaultExt = '*.fomap'
    Filter = 'Map text file (*.fomap)|*.fomap|Any file (*.*)|*.*'
    Left = 24
    Top = 32
  end
end
