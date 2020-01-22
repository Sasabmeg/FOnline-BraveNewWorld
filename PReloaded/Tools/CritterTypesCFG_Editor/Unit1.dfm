object Form1: TForm1
  Left = 261
  Top = 130
  Width = 926
  Height = 317
  Caption = 'Form1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Label39: TLabel
    Left = 34
    Top = 10
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
  object GroupBox8: TGroupBox
    Left = 240
    Top = 55
    Width = 329
    Height = 150
    Caption = 'Animation'
    TabOrder = 0
    object Image1: TImage
      Left = 166
      Top = 8
      Width = 155
      Height = 126
      Center = True
      Transparent = True
    end
    object Label42: TLabel
      Left = 226
      Top = 134
      Width = 34
      Height = 13
      Caption = 'gjhgjhg'
    end
    object CheckBox40: TCheckBox
      Left = 8
      Top = 24
      Width = 65
      Height = 17
      Caption = 'Unarmed'
      TabOrder = 0
      OnClick = CheckBox40Click
    end
    object CheckBox41: TCheckBox
      Left = 8
      Top = 48
      Width = 65
      Height = 17
      Caption = 'Knife'
      TabOrder = 1
      OnClick = CheckBox41Click
    end
    object CheckBox42: TCheckBox
      Left = 8
      Top = 64
      Width = 65
      Height = 17
      Caption = 'Club'
      TabOrder = 2
      OnClick = CheckBox42Click
    end
    object CheckBox43: TCheckBox
      Left = 8
      Top = 80
      Width = 65
      Height = 17
      Caption = 'Hammer'
      TabOrder = 3
      OnClick = CheckBox43Click
    end
    object CheckBox44: TCheckBox
      Left = 8
      Top = 96
      Width = 65
      Height = 17
      Caption = 'Spear'
      TabOrder = 4
      OnClick = CheckBox44Click
    end
    object CheckBox45: TCheckBox
      Left = 96
      Top = 24
      Width = 65
      Height = 17
      Caption = 'Pistol'
      TabOrder = 5
      OnClick = CheckBox45Click
    end
    object CheckBox46: TCheckBox
      Left = 96
      Top = 40
      Width = 65
      Height = 17
      Caption = 'SMG'
      TabOrder = 6
      OnClick = CheckBox46Click
    end
    object CheckBox47: TCheckBox
      Left = 96
      Top = 56
      Width = 65
      Height = 17
      Caption = 'Shootgun'
      TabOrder = 7
      OnClick = CheckBox47Click
    end
    object CheckBox48: TCheckBox
      Left = 96
      Top = 80
      Width = 65
      Height = 17
      Caption = 'H. Rifle'
      TabOrder = 8
      OnClick = CheckBox48Click
    end
    object CheckBox49: TCheckBox
      Left = 96
      Top = 96
      Width = 65
      Height = 17
      Caption = 'Minigun'
      TabOrder = 9
      OnClick = CheckBox49Click
    end
    object CheckBox50: TCheckBox
      Left = 96
      Top = 112
      Width = 65
      Height = 17
      Caption = 'R. Launchr'
      TabOrder = 10
      OnClick = CheckBox50Click
    end
    object CheckBox51: TCheckBox
      Left = 96
      Top = 128
      Width = 65
      Height = 17
      Caption = 'Flamer'
      TabOrder = 11
      OnClick = CheckBox51Click
    end
  end
  object Edit1: TEdit
    Left = 16
    Top = 216
    Width = 881
    Height = 24
    Font.Charset = EASTEUROPE_CHARSET
    Font.Color = clBlack
    Font.Height = -13
    Font.Name = 'Courier New'
    Font.Style = []
    ParentFont = False
    TabOrder = 1
    Text = 'Edit1'
  end
  object GroupBox1: TGroupBox
    Left = 32
    Top = 55
    Width = 193
    Height = 150
    Caption = 'Animation'
    TabOrder = 2
    object CheckBox1: TCheckBox
      Left = 8
      Top = 16
      Width = 125
      Height = 17
      Caption = 'MH - multiHex'
      TabOrder = 0
      OnClick = CheckBox1Click
    end
    object CheckBox2: TCheckBox
      Left = 8
      Top = 32
      Width = 175
      Height = 17
      Caption = 'Tp, Animation type, Fallout=0'
      Enabled = False
      TabOrder = 1
    end
    object CheckBox3: TCheckBox
      Left = 8
      Top = 48
      Width = 125
      Height = 17
      Caption = 'Wk, Walk'
      TabOrder = 2
      OnClick = CheckBox3Click
    end
    object CheckBox4: TCheckBox
      Left = 8
      Top = 64
      Width = 125
      Height = 17
      Caption = 'Rn, Run'
      TabOrder = 3
      OnClick = CheckBox4Click
    end
    object CheckBox5: TCheckBox
      Left = 8
      Top = 80
      Width = 125
      Height = 17
      Caption = 'Am, Hit aiming'
      TabOrder = 4
      OnClick = CheckBox5Click
    end
    object CheckBox6: TCheckBox
      Left = 8
      Top = 96
      Width = 125
      Height = 17
      Caption = 'Ar, Change armor'
      TabOrder = 5
      OnClick = CheckBox6Click
    end
    object CheckBox7: TCheckBox
      Left = 8
      Top = 112
      Width = 125
      Height = 17
      Caption = 'Rt, Rotate'
      TabOrder = 6
      OnClick = CheckBox7Click
    end
  end
  object Edit34: TEdit
    Left = 32
    Top = 28
    Width = 57
    Height = 21
    TabOrder = 3
    Text = '0'
    OnChange = Edit34Change
  end
  object UpDown18: TUpDown
    Left = 89
    Top = 28
    Width = 16
    Height = 21
    Associate = Edit34
    Max = 999
    TabOrder = 4
    Thousands = False
  end
  object Button1: TButton
    Left = 16
    Top = 248
    Width = 97
    Height = 25
    Caption = 'Copy to Clpbrd'
    TabOrder = 5
    OnClick = Button1Click
  end
  object ZipForge1: TZipForge
    ExtractCorruptedFiles = False
    CompressionLevel = clFastest
    CompressionMode = 1
    CurrentVersion = '5.05 '
    SpanningMode = smNone
    SpanningOptions.AdvancedNaming = False
    SpanningOptions.VolumeSize = vsAutoDetect
    Options.FlushBuffers = True
    Options.OEMFileNames = True
    InMemory = False
    Zip64Mode = zmDisabled
    UnicodeFilenames = False
    EncryptionMethod = caPkzipClassic
    Left = 512
    Top = 16
  end
end
