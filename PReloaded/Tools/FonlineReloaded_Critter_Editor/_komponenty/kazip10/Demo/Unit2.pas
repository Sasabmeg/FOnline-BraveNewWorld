unit Unit2;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Grids, KAZip, Menus;

type
  TForm2 = class(TForm)
    StringGrid1: TStringGrid;
    Button1: TButton;
    StaticText1: TStaticText;
    procedure Button1Click(Sender: TObject);
    procedure FormActivate(Sender: TObject);
  private
    { Private declarations }
    FZip : TKAZip;
  public
    { Public declarations }
    Procedure Execute(AZip:TKAZip);
  end;

var
  Form2: TForm2;

implementation

uses Unit1;

{$R *.dfm}

procedure TForm2.Button1Click(Sender: TObject);
begin
  StaticText1.Visible := False;
  ModalResult         := mrOK;
end;

procedure TForm2.Execute(AZip: TKAZip);
begin
   StringGrid1.RowCount   := 2;
   StringGrid1.Cells[0,0] := 'File';
   StringGrid1.Cells[1,0] := 'Status';
   StringGrid1.Cells[0,1] := '';
   StringGrid1.Cells[1,1] := '';
   FZip := AZip;
   ShowModal;
end;

procedure TForm2.FormActivate(Sender: TObject);
Var
  X      : Integer;
  HasErr : Integer;
begin
   HasErr := 0;
   For  X := 0 To FZip.Entries.Count-1 do
       Begin
         if X > 0 Then StringGrid1.RowCount := StringGrid1.RowCount+1;
         StringGrid1.Cells[0,X+1] := FZip.Entries.Items[X].FileName;
         Try
           If FZip.Entries.Items[X].Test Then
              Begin
                StringGrid1.Cells[1,X+1] := 'OK';
              End
           Else
              Begin
                StringGrid1.Cells[1,X+1] := 'ERROR';
                Inc(HasErr);
              End;
         Except
           StringGrid1.Cells[1,X+1] := 'ERROR';
           Inc(HasErr);
         End;
         StringGrid1.Row := X+1;
         StringGrid1.Update;
         Application.ProcessMessages;
       End;
   Form1.ProgressBar1.Position := 0;
   if HasErr = 0 Then
      Begin
        StaticText1.Caption := 'No errors detected on this zip file.';
        StaticText1.Font.Color := clTeal;
      End
   Else
      Begin
        StaticText1.Caption    := IntToStr(HasErr)+' errors detected on this zip file.';
        StaticText1.Font.Color := clRed;
      End;
   StaticText1.Visible := True;
end;

end.
