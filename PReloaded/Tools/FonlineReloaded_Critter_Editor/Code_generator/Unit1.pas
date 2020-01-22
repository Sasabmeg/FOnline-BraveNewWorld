unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm1 = class(TForm)
    Button1: TButton;
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
var Lista:TStringList;
    iter:Byte;
    plik_temp, plik_wynik:TextFile;
    linia_temp:String;
begin
 //ladowanie listy perkow z combat_perks.txt do ViewListEditor1

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

      AssignFile(plik_temp, ExtractFilePath(Application.ExeName) + 'wynik.txt');
      Rewrite(plik_temp);
      for iter:=0 to Lista.Count-1 do
      begin
Writeln(plik_temp,'          else');
Writeln(plik_temp,'          if Copy(linia2,1,pozycja-1)= "' + Lista.Strings[iter] + '" then');
Writeln(plik_temp,'          begin');
Writeln(plik_temp,'            Delete(linia2,1,pozycja);');
Writeln(plik_temp,'            linia2:=Trim(linia2);');
Writeln(plik_temp,'            ' + Lista.Strings[iter] + ':=linia2;');
Writeln(plik_temp,'          end');
        //ValueListEditor1.InsertRow(Lista.Strings[iter], '0', true);
      end;

      CloseFile(plik_temp);

    finally
      Lista.Free;
    end;
    ShowMessage('Koniec');
end;

end.
          else
          if Copy(linia2,1,pozycja-1)= 'ST_WALK_TIME' then
          begin
            Delete(linia2,1,pozycja);
            linia2:=Trim(linia2);
            ST_WALK_TIME:=linia2;
          end