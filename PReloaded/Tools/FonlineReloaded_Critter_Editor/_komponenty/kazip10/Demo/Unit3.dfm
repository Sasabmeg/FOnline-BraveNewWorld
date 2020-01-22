object Form3: TForm3
  Left = 420
  Top = 337
  BorderStyle = bsDialog
  Caption = 'Find File'
  ClientHeight = 73
  ClientWidth = 388
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poMainFormCenter
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 8
    Top = 16
    Width = 50
    Height = 13
    Caption = '&File Name:'
    FocusControl = Edit1
  end
  object Edit1: TEdit
    Left = 63
    Top = 13
    Width = 236
    Height = 21
    TabOrder = 0
    OnKeyPress = Edit1KeyPress
  end
  object Button1: TButton
    Left = 304
    Top = 11
    Width = 75
    Height = 25
    Caption = 'Find Next'
    Default = True
    TabOrder = 1
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 304
    Top = 40
    Width = 75
    Height = 25
    Cancel = True
    Caption = '&Cancel'
    TabOrder = 2
    OnClick = Button2Click
  end
end
