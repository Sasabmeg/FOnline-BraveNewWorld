unit Unit3;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls,Masks;

type
  TForm3 = class(TForm)
    Label1: TLabel;
    Edit1: TEdit;
    Button1: TButton;
    Button2: TButton;
    procedure Button1Click(Sender: TObject);
    procedure Edit1KeyPress(Sender: TObject; var Key: Char);
    procedure Button2Click(Sender: TObject);
  private
    { Private declarations }
    function Matches(const Filename, Mask: string): Boolean;
  public
    { Public declarations }
  end;

var
  Form3: TForm3;

implementation
{$R *.dfm}
Uses Unit1;

function TForm3.Matches(const Filename, Mask: string): Boolean;
Begin
  Result := False;
  if Filename='' Then Exit;
  if Mask='*.*' Then
     Begin
       Result := True;
       Exit;
     End;
  Result := MatchesMask(Filename, Mask);
End;

procedure TForm3.Button1Click(Sender: TObject);
Var
  X     : Integer;
  Start : Integer;
  LF    : Integer;
  S     : String;
  Found : Boolean;
begin
  if Edit1.Text<>'' Then
     Begin
      S     := Edit1.Text;
      Start := 0;
      LF    := 0;
      if Form1.KAZipListView1.Selected <> Nil Then
         Begin
           LF   := Form1.KAZipListView1.Selected.Index;
           Form1.KAZipListView1.ClearSelection;
           For X := LF+1 To Form1.KAZipListView1.Items.Count-1 do
               Begin
                  if Matches(Form1.KAZipListView1.Items.Item[X].Caption,S) Then
                     Begin
                       Form1.KAZipListView1.Items[X].Selected := True;
                       Form1.KAZipListView1.Items[X].MakeVisible(False);
                       Form1.KAZipListView1.SetFocus;
                       Edit1.SetFocus;
                       Exit;
                     End;
              End;
           if Matches(Form1.KAZipListView1.Items.Item[LF].Caption,S) Then
              Begin
                 Start := Integer(Form1.KAZipListView1.Items[LF].Data);
                 If Start < Form1.KAZip1.Entries.Count-1 Then
                    Inc(Start)
                 Else
                    Start := 0;
              End;
         End;
      Found := False;
      For X := Start To Form1.KAZip1.FileNames.Count-1 do
          Begin
            if Matches(ExtractFileName(Form1.KAZip1.FileNames.Strings[X]),S)  Then
               Begin
                 Form1.KAZipTreeView1.SetCurrentFolder(ExtractFilePath(Form1.KAZip1.FileNames.Strings[X]));
                 Found := True;
                 System.Break;
               End;
          End;
      if Not Found Then
         Begin
           For X := 0 To Form1.KAZip1.FileNames.Count-1 do
               Begin
                  if Matches(ExtractFileName(Form1.KAZip1.FileNames.Strings[X]),S) Then
                     Begin
                       Form1.KAZipTreeView1.SetCurrentFolder(ExtractFilePath(Form1.KAZip1.FileNames.Strings[X]));
                       System.Break;
                     End;
               End;
         End;
      For X := 0 To Form1.KAZipListView1.Items.Count-1 do
          Begin
            if Matches(Form1.KAZipListView1.Items.Item[X].Caption,S) Then
               Begin
                 Form1.KAZipListView1.Items[X].Selected := True;
                 Form1.KAZipListView1.Items[X].MakeVisible(False);
                 Form1.KAZipListView1.SetFocus;
                 System.Break;
               End;
          End;
       Edit1.SetFocus;
     End;
End;

procedure TForm3.Edit1KeyPress(Sender: TObject; var Key: Char);
begin
  if Key=#13 Then
     Begin
       Key := #0;
       Button1.Click
     End;
end;

procedure TForm3.Button2Click(Sender: TObject);
begin
  Close;
end;

end.
