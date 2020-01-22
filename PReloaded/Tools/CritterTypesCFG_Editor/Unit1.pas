unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ComCtrls, ExtCtrls, ZipForge, GraphicEx;

type
  TForm1 = class(TForm)
    GroupBox8: TGroupBox;
    Image1: TImage;
    Label42: TLabel;
    CheckBox40: TCheckBox;
    CheckBox41: TCheckBox;
    CheckBox42: TCheckBox;
    CheckBox43: TCheckBox;
    CheckBox44: TCheckBox;
    CheckBox45: TCheckBox;
    CheckBox46: TCheckBox;
    CheckBox47: TCheckBox;
    CheckBox48: TCheckBox;
    CheckBox49: TCheckBox;
    CheckBox50: TCheckBox;
    CheckBox51: TCheckBox;
    ZipForge1: TZipForge;
    Edit1: TEdit;
    GroupBox1: TGroupBox;
    CheckBox1: TCheckBox;
    CheckBox2: TCheckBox;
    CheckBox3: TCheckBox;
    CheckBox4: TCheckBox;
    CheckBox5: TCheckBox;
    CheckBox6: TCheckBox;
    CheckBox7: TCheckBox;
    Edit34: TEdit;
    Label39: TLabel;
    UpDown18: TUpDown;
    Button1: TButton;
    procedure Edit34Change(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure CheckBox1Click(Sender: TObject);
    procedure CheckBox3Click(Sender: TObject);
    procedure CheckBox4Click(Sender: TObject);
    procedure CheckBox5Click(Sender: TObject);
    procedure CheckBox6Click(Sender: TObject);
    procedure CheckBox7Click(Sender: TObject);
    procedure CheckBox40Click(Sender: TObject);
    procedure CheckBox41Click(Sender: TObject);
    procedure CheckBox42Click(Sender: TObject);
    procedure CheckBox43Click(Sender: TObject);
    procedure CheckBox44Click(Sender: TObject);
    procedure CheckBox45Click(Sender: TObject);
    procedure CheckBox46Click(Sender: TObject);
    procedure CheckBox47Click(Sender: TObject);
    procedure CheckBox48Click(Sender: TObject);
    procedure CheckBox49Click(Sender: TObject);
    procedure CheckBox50Click(Sender: TObject);
    procedure CheckBox51Click(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  tab_znakow:Array [0..45] of String; // tablica od znaku @ do Sound name

implementation

{$R *.dfm}

procedure TForm1.Edit34Change(Sender: TObject);
var plik:TextFile;
    linia:String;
    numerek:String;
    numer_frm:String;

    archiwum:TZipForge;
    lokal_znalazlem_obrazek:boolean;
    znak:String[1];

    znaczek:String; // zmienna pomocnicza
    i:Byte;

    nazwa_frm:String;
begin
  // zerowanie tablicy i czyszczenie checkboxow
  for i:=0 to 23 do
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


  lokal_znalazlem_obrazek:=False;
  numer_frm:=IntToStr(UpDown18.Position);

  AssignFile(plik,'CritterTypes.cfg');
  reset(plik);
  While not Eof(plik) do
  begin
    Readln(plik,linia);
    linia:=Trim(linia);
    if length(linia)>0 then znak:=linia[1];
    if znak='@' then
    begin
      //@  113    nmmax8     11   0  0  1  1  1  1  1   1 0 0 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 0 0 0 0 0 0 0 0    400  200   4  8  0  0   hmjmps
      lokal_znalazlem_obrazek:=true;

      Delete(linia,1,1);
      linia:=Trim(linia);
      numerek:=Copy(linia,1,3);
      numerek:=Trim(numerek);

      if numerek=numer_frm then
      begin
       tab_znakow[0]:=numerek;

       Edit1.Text:='@ '+linia;
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

        for i:=3 to 42 do
        begin
          Delete(linia,1,length(znaczek));
          linia:=Trim(linia);   // linia == '0   0  0  1  1  1  1  1   1 0 0 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 0 0 0 0 0 0 0 0   400  200   4  8  0  0     -'
          znaczek:=Copy(linia,1,Pos(' ',linia));
          if Pos(' ',linia)=0 then tab_znakow[i]:=linia
          else
            tab_znakow[i]:=Trim(znaczek);
        end;


        for i:=3 to 23 do
        begin
        case i of
        3:  if tab_znakow[i]='1' then CheckBox1.Checked:=True else CheckBox1.Checked:=False;
        4:  if tab_znakow[i]='1' then CheckBox2.Checked:=True else CheckBox2.Checked:=False;
        5:  if tab_znakow[i]='1' then CheckBox3.Checked:=True else CheckBox3.Checked:=False;
        6:  if tab_znakow[i]='1' then CheckBox4.Checked:=True else CheckBox4.Checked:=False;
        7:  if tab_znakow[i]='1' then CheckBox5.Checked:=True else CheckBox5.Checked:=False;
        8:  if tab_znakow[i]='1' then CheckBox6.Checked:=True else CheckBox6.Checked:=False;
        9:  if tab_znakow[i]='1' then CheckBox7.Checked:=True else CheckBox7.Checked:=False;

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


procedure TForm1.FormCreate(Sender: TObject);
begin
  Edit1.Text:='';
end;

procedure TForm1.CheckBox1Click(Sender: TObject);
var linia:String;
    iter:Integer;
begin
  if CheckBox1.Checked=True then tab_znakow[3]:='1';
  if CheckBox1.Checked=False then tab_znakow[3]:='0';

  linia:='@ ';
  for iter:=0 to 42 do
  begin
    linia:= linia + tab_znakow[iter] + ' ';
  end;
  {Memo1.Lines.Append(linia);} Edit1.text:=linia;
end;

procedure TForm1.CheckBox3Click(Sender: TObject);
var linia:String;
    iter:Integer;
begin
  if CheckBox3.Checked=True then tab_znakow[5]:='1';
  if CheckBox3.Checked=False then tab_znakow[5]:='0';

  linia:='@ ';
  for iter:=0 to 42 do
  begin
    linia:= linia + tab_znakow[iter] + ' ';
  end;
  {Memo1.Clear;}
  {Memo1.Lines.Append(linia);} Edit1.text:=linia;
end;
procedure TForm1.CheckBox4Click(Sender: TObject);
var linia:String;
    iter:Integer;
begin
  if CheckBox4.Checked=True then tab_znakow[6]:='1';
  if CheckBox4.Checked=False then tab_znakow[6]:='0';

  linia:='@ ';
  for iter:=0 to 42 do
  begin
    linia:= linia + tab_znakow[iter] + ' ';
  end;
  {Memo1.Clear;}
  {Memo1.Lines.Append(linia);} Edit1.text:=linia;
end;

procedure TForm1.CheckBox5Click(Sender: TObject);
var linia:String;
    iter:Integer;
begin
  if CheckBox5.Checked=True then tab_znakow[7]:='1';
  if CheckBox5.Checked=False then tab_znakow[7]:='0';

  linia:='@ ';
  for iter:=0 to 42 do
  begin
    linia:= linia + tab_znakow[iter] + ' ';
  end;
  {Memo1.Clear;}
  {Memo1.Lines.Append(linia);} Edit1.text:=linia;
end;

procedure TForm1.CheckBox6Click(Sender: TObject);
var linia:String;
    iter:Integer;
begin
  if CheckBox6.Checked=True then tab_znakow[8]:='1';
  if CheckBox6.Checked=False then tab_znakow[8]:='0';

  linia:='@ ';
  for iter:=0 to 42 do
  begin
    linia:= linia + tab_znakow[iter] + ' ';
  end;
  {Memo1.Clear;}
  {Memo1.Lines.Append(linia);} Edit1.text:=linia;
end;

procedure TForm1.CheckBox7Click(Sender: TObject);
var linia:String;
    iter:Integer;
begin
  if CheckBox7.Checked=True then tab_znakow[9]:='1';
  if CheckBox7.Checked=False then tab_znakow[9]:='0';

  linia:='@ ';
  for iter:=0 to 42 do
  begin
    linia:= linia + tab_znakow[iter] + ' ';
  end;
  {Memo1.Clear;}
  {Memo1.Lines.Append(linia);} Edit1.text:=linia;
end;

procedure TForm1.CheckBox40Click(Sender: TObject);
var linia:String;
    iter:Integer;
begin
  if CheckBox40.Checked=True then tab_znakow[10]:='1';
  if CheckBox40.Checked=False then tab_znakow[10]:='0';

  linia:='@ ';
  for iter:=0 to 42 do
  begin
    linia:= linia + tab_znakow[iter] + ' ';
  end;
  {Memo1.Clear;}
  {Memo1.Lines.Append(linia);} Edit1.text:=linia;
end;

procedure TForm1.CheckBox41Click(Sender: TObject);
var linia:String;
    iter:Integer;
begin
  if CheckBox41.Checked=True then tab_znakow[13]:='1';
  if CheckBox41.Checked=False then tab_znakow[13]:='0';

  linia:='@ ';
  for iter:=0 to 42 do
  begin
    linia:= linia + tab_znakow[iter] + ' ';
  end;
  {Memo1.Clear;}
  {Memo1.Lines.Append(linia);} Edit1.text:=linia;
end;

procedure TForm1.CheckBox42Click(Sender: TObject);
var linia:String;
    iter:Integer;
begin
  if CheckBox42.Checked=True then tab_znakow[14]:='1';
  if CheckBox42.Checked=False then tab_znakow[14]:='0';

  linia:='@ ';
  for iter:=0 to 42 do
  begin
    linia:= linia + tab_znakow[iter] + ' ';
  end;
  {Memo1.Clear;}
  {Memo1.Lines.Append(linia);} Edit1.text:=linia;
end;


procedure TForm1.CheckBox43Click(Sender: TObject);
var linia:String;
    iter:Integer;
begin
  if CheckBox43.Checked=True then tab_znakow[15]:='1';
  if CheckBox43.Checked=False then tab_znakow[15]:='0';

  linia:='@ ';
  for iter:=0 to 42 do
  begin
    linia:= linia + tab_znakow[iter] + ' ';
  end;
  {Memo1.Clear;}
  {Memo1.Lines.Append(linia);} Edit1.text:=linia;
end;



procedure TForm1.CheckBox44Click(Sender: TObject);
var linia:String;
    iter:Integer;
begin
  if CheckBox44.Checked=True then tab_znakow[16]:='1';
  if CheckBox44.Checked=False then tab_znakow[16]:='0';

  linia:='@ ';
  for iter:=0 to 42 do
  begin
    linia:= linia + tab_znakow[iter] + ' ';
  end;
  {Memo1.Clear;}
  {Memo1.Lines.Append(linia);} Edit1.text:=linia;
end;

procedure TForm1.CheckBox45Click(Sender: TObject);
var linia:String;
    iter:Integer;
begin
  if CheckBox45.Checked=True then tab_znakow[17]:='1';
  if CheckBox45.Checked=False then tab_znakow[17]:='0';

  linia:='@ ';
  for iter:=0 to 42 do
  begin
    linia:= linia + tab_znakow[iter] + ' ';
  end;
  {Memo1.Clear;}
  {Memo1.Lines.Append(linia);} Edit1.text:=linia;
end;


procedure TForm1.CheckBox46Click(Sender: TObject);
var linia:String;
    iter:Integer;
begin
  if CheckBox46.Checked=True then tab_znakow[18]:='1';
  if CheckBox46.Checked=False then tab_znakow[18]:='0';

  linia:='@ ';
  for iter:=0 to 42 do
  begin
    linia:= linia + tab_znakow[iter] + ' ';
  end;
  {Memo1.Clear;}
  {Memo1.Lines.Append(linia);} Edit1.text:=linia;
end;

procedure TForm1.CheckBox47Click(Sender: TObject);
var linia:String;
    iter:Integer;
begin
  if CheckBox47.Checked=True then tab_znakow[19]:='1';
  if CheckBox47.Checked=False then tab_znakow[19]:='0';

  linia:='@ ';
  for iter:=0 to 42 do
  begin
    linia:= linia + tab_znakow[iter] + ' ';
  end;
  {Memo1.Clear;}
  {Memo1.Lines.Append(linia);} Edit1.text:=linia;
end;

procedure TForm1.CheckBox48Click(Sender: TObject);
var linia:String;
    iter:Integer;
begin
  if CheckBox48.Checked=True then tab_znakow[20]:='1';
  if CheckBox48.Checked=False then tab_znakow[20]:='0';

  linia:='@ ';
  for iter:=0 to 42 do
  begin
    linia:= linia + tab_znakow[iter] + ' ';
  end;
  {Memo1.Clear;}
  {Memo1.Lines.Append(linia);} Edit1.text:=linia;
end;

procedure TForm1.CheckBox49Click(Sender: TObject);
var linia:String;
    iter:Integer;
begin
  if CheckBox49.Checked=True then tab_znakow[21]:='1';
  if CheckBox49.Checked=False then tab_znakow[21]:='0';

  linia:='@ ';
  for iter:=0 to 42 do
  begin
    linia:= linia + tab_znakow[iter] + ' ';
  end;
  {Memo1.Clear;}
  {Memo1.Lines.Append(linia);} Edit1.text:=linia;
end;


procedure TForm1.CheckBox50Click(Sender: TObject);
var linia:String;
    iter:Integer;
begin
  if CheckBox50.Checked=True then tab_znakow[22]:='1';
  if CheckBox50.Checked=False then tab_znakow[22]:='0';

  linia:='@ ';
  for iter:=0 to 42 do
  begin
    linia:= linia + tab_znakow[iter] + ' ';
  end;
  {Memo1.Clear;}
  {Memo1.Lines.Append(linia);} Edit1.text:=linia;
end;


procedure TForm1.CheckBox51Click(Sender: TObject);
var linia:String;
    iter:Integer;
begin
  if CheckBox51.Checked=True then tab_znakow[23]:='1';
  if CheckBox51.Checked=False then tab_znakow[23]:='0';

  linia:='@ ';
  for iter:=0 to 42 do
  begin
    linia:= linia + tab_znakow[iter] + ' ';
  end;
  {Memo1.Clear;}
  {Memo1.Lines.Append(linia);} Edit1.text:=linia;
end;


procedure TForm1.Button1Click(Sender: TObject);
begin
  Edit1.SelectAll;
  Edit1.CopyToClipboard;
end;

end.
