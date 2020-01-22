object Form2: TForm2
  Left = 380
  Top = 278
  VertScrollBar.Smooth = True
  ActiveControl = Button1
  BorderStyle = bsDialog
  Caption = 'Testing ...'
  ClientHeight = 315
  ClientWidth = 576
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  OnActivate = FormActivate
  PixelsPerInch = 96
  TextHeight = 13
  object StringGrid1: TStringGrid
    Left = 0
    Top = 0
    Width = 576
    Height = 281
    Align = alTop
    ColCount = 2
    DefaultRowHeight = 18
    FixedCols = 0
    RowCount = 2
    Options = [goFixedVertLine, goFixedHorzLine, goVertLine, goHorzLine, goRangeSelect, goRowSelect]
    ScrollBars = ssVertical
    TabOrder = 0
    ColWidths = (
      480
      70)
  end
  object Button1: TButton
    Left = 497
    Top = 287
    Width = 75
    Height = 25
    Cancel = True
    Caption = 'Close'
    TabOrder = 1
    OnClick = Button1Click
  end
  object StaticText1: TStaticText
    Left = 5
    Top = 288
    Width = 253
    Height = 22
    Caption = 'No errors detected on this zip file.'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clTeal
    Font.Height = -16
    Font.Name = 'Arial'
    Font.Style = [fsBold, fsItalic]
    ParentFont = False
    TabOrder = 2
    Visible = False
  end
end
