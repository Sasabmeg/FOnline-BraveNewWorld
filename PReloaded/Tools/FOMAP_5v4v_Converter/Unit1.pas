unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ComCtrls, FileCtrl;

type
  TForm1 = class(TForm)
    Button1: TButton;
    Memo1: TMemo;
    procedure Button1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
    procedure KonwertujMapke(nazwa_pliku1, nazwa_pliku2:String);
  end;

const
  tab_critter_param:Array [0..9] of String =
('ST_DIALOG_ID',
'ST_AI_ID',
'ST_BAG_ID',
'ST_TEAM_ID',
'ST_NPC_ROLE',
'ST_REPLICATION_TIME',
'ST_FACTION_RANK',
'ST_FACTION_MODE',
'ST_OVERRIDE_CRTYPE',
'ST_LEVEL');


var
  Form1: TForm1;
  tab_critter_values:Array [0..9] of Integer;

implementation

{$R *.dfm}

procedure TForm1.KonwertujMapke(nazwa_pliku1, nazwa_pliku2:String);
var
    plik1, plik2:TextFile;
    linia, linia_temp :String;
    licznik:Integer;

    str_Dir:String;
    str_Critter_ParamIndex:String;
    str_Critter_ParamValue:String;

    skip:Boolean;

    iter:Integer;


begin
  AssignFile(plik1, nazwa_pliku1);
  Reset(plik1);

  AssignFile(plik2, nazwa_pliku2);
  Rewrite(plik2);

  skip:=True;

  While not Eof(plik1) do
  begin
    Readln(plik1, linia);
    linia_temp:=Trim(linia);
    for iter:=0 to 9 do tab_critter_values[iter]:=0;

    if Pos('Version              5',linia_temp)>0 then
    begin
      linia_temp:='Version              4';
      Writeln(plik2, linia_temp);
      skip:=False;
    end
    else
    if (Pos('MapObjType           0',linia_temp)>0) and (skip=False) then
    begin
      Writeln(plik2, linia_temp);

      repeat
        Readln(plik1,linia);
        linia_temp:=Trim(linia);

        if (Pos('Critter_Dir',linia_temp)>0) and (skip=False) then
        begin
          Delete(linia_temp,1,11);
          linia_temp:=Trim(linia_temp);
          str_Dir:=linia_temp;
          linia_temp:='Dir                  ' + str_Dir;
          Writeln(plik2, linia_temp);
        end
        else
        if (Pos('Critter_ParamIndex',linia_temp)>0) and (skip=False) then
        begin
          for iter:=0 to 9 do tab_critter_values[iter]:=0;

          Delete(linia_temp,1,18);
          linia_temp:=Trim(linia_temp);
          str_Critter_ParamIndex:=linia_temp;

          if str_Critter_ParamIndex='ST_DIALOG_ID' then licznik:=0
          else
          if str_Critter_ParamIndex='ST_AI_ID' then licznik:=1
          else
          if str_Critter_ParamIndex='ST_BAG_ID' then licznik:=2
          else
          if str_Critter_ParamIndex='ST_TEAM_ID' then licznik:=3
          else
          if str_Critter_ParamIndex='ST_NPC_ROLE' then licznik:=4
          else
          if str_Critter_ParamIndex='ST_REPLICATION_TIME' then licznik:=5
          else
          if str_Critter_ParamIndex='ST_FACTION_RANK' then licznik:=6
          else
          if str_Critter_ParamIndex='ST_FACTION_MODE' then licznik:=7
          else
          if str_Critter_ParamIndex='ST_OVERRIDE_CRTYPE' then licznik:=8
          else
          if str_Critter_ParamIndex='ST_LEVEL' then licznik:=9
          else
          licznik:=0;


          linia_temp:='Critter_ParamIndex' + IntToStr(licznik) + '   ' + str_Critter_ParamIndex;
          Writeln(plik2, linia_temp);
          tab_critter_values[licznik]:=1;

          Readln(plik1,linia);
          linia_temp:=Trim(linia);

          Delete(linia_temp,1,18);
          linia_temp:=Trim(linia_temp);
          str_Critter_ParamValue:=linia_temp;
          linia_temp:='Critter_ParamValue' + IntToStr(licznik) + '   ' + str_Critter_ParamValue;
          Writeln(plik2, linia_temp);

          repeat
            Readln(plik1,linia);
            linia_temp:=Trim(linia);

            if (Pos('Critter_ParamIndex',linia_temp)>0) and (skip=False) then
            begin
              Delete(linia_temp,1,18);
              linia_temp:=Trim(linia_temp);
              str_Critter_ParamIndex:=linia_temp;

              if str_Critter_ParamIndex='ST_DIALOG_ID' then licznik:=0
              else
              if str_Critter_ParamIndex='ST_AI_ID' then licznik:=1
              else
              if str_Critter_ParamIndex='ST_BAG_ID' then licznik:=2
              else
              if str_Critter_ParamIndex='ST_TEAM_ID' then licznik:=3
              else
              if str_Critter_ParamIndex='ST_NPC_ROLE' then licznik:=4
              else
              if str_Critter_ParamIndex='ST_REPLICATION_TIME' then licznik:=5
              else
              if str_Critter_ParamIndex='ST_FACTION_RANK' then licznik:=6
              else
              if str_Critter_ParamIndex='ST_FACTION_MODE' then licznik:=7
              else
              if str_Critter_ParamIndex='ST_OVERRIDE_CRTYPE' then licznik:=8
              else
              if str_Critter_ParamIndex='ST_LEVEL' then licznik:=9
              else
              Inc(licznik);


              linia_temp:='Critter_ParamIndex' + IntToStr(licznik) + '   ' + str_Critter_ParamIndex;
              Writeln(plik2, linia_temp);
              tab_critter_values[licznik]:=1;

              Readln(plik1,linia);
              linia_temp:=Trim(linia);
              Delete(linia_temp,1,18);
              linia_temp:=Trim(linia_temp);
              str_Critter_ParamValue:=linia_temp;
              linia_temp:='Critter_ParamValue' + IntToStr(licznik) + '   ' + str_Critter_ParamValue;
              Writeln(plik2, linia_temp);
            end
            else
            if Length(linia)=0 then
            begin
              for iter:=0 to 9 do
              begin
                if tab_critter_values[iter]=0 then
                begin
                  tab_critter_values[iter]:=0;
                  linia_temp:='Critter_ParamIndex' + IntToStr(iter) + '   ' + tab_critter_param[iter];
                  Writeln(plik2, linia_temp);
                  linia_temp:='Critter_ParamValue' + IntToStr(iter) + '   ' + '0';
                  Writeln(plik2, linia_temp);
                end;
                tab_critter_values[iter]:=0; // przy okazji zerowanie tablicy
              end;

              linia_temp:='';
              Writeln(plik2, linia_temp);
            end;

          until Length(linia)=0;

        end
        else
        if Length(linia)=0 then
        begin
          for iter:=0 to 9 do
          begin
            if tab_critter_values[iter]=0 then
            begin
              tab_critter_values[iter]:=0;
              linia_temp:='Critter_ParamIndex' + IntToStr(iter) + '   ' + tab_critter_param[iter];
              Writeln(plik2, linia_temp);
              linia_temp:='Critter_ParamValue' + IntToStr(iter) + '   ' + '0';
              Writeln(plik2, linia_temp);
            end;
            tab_critter_values[iter]:=0; // przy okazji zerowanie tablicy
          end;

          linia_temp:='';
          Writeln(plik2, linia_temp);
        end
        else
          Writeln(plik2, linia_temp);


      until Length(linia)=0;
    end
    else
      Writeln(plik2, linia_temp);

  end; // While not Eof(plik1) do
  CloseFile(plik1);
  Flush(plik2);
  CloseFile(plik2);


end;




procedure TForm1.Button1Click(Sender: TObject);
var SearchRec:TSearchRec;
    nazwa_pliku1:String;
    nazwa_katalogu_mapek:String;

begin
  if SelectDirectory('Wybierz katalog z mapkami do konwersji:','',nazwa_katalogu_mapek) then
  begin
    if not DirectoryExists(nazwa_katalogu_mapek + '\Converted') then
    begin
      CreateDir(nazwa_katalogu_mapek + '\Converted');
    end;

    ChDir(nazwa_katalogu_mapek);

    Screen.Cursor:=crHourGlass;

    if FindFirst('*.fomap',(faArchive+ faReadOnly),SearchRec)=0 then
    begin
      nazwa_pliku1:=SearchRec.Name;
      Memo1.Lines.Append(nazwa_pliku1);

      KonwertujMapke(nazwa_pliku1, nazwa_katalogu_mapek + '\Converted\' + nazwa_pliku1);

      while FindNext(SearchRec)=0 do
      begin
        nazwa_pliku1:=SearchRec.Name;
        Memo1.Lines.Append(nazwa_pliku1);

        KonwertujMapke(nazwa_pliku1, nazwa_katalogu_mapek + '\Converted\' + nazwa_pliku1);
      end;
    end;
    FindClose(SearchRec);

    Memo1.Lines.Append(' Done ');
    Screen.Cursor:=crDefault;
  end;
end;


procedure TForm1.FormCreate(Sender: TObject);
begin
  Caption:='Fonline Map Converter from v5 to v4';
  Memo1.Clear;
end;

end.



MapObjType           0
ProtoId              52
MapX                 93
MapY                 99
Dir                  3
Critter_Cond         1
Critter_Anim1        0
Critter_Anim2        0
Critter_ParamIndex0  ST_DIALOG_ID
Critter_ParamValue0  0
Critter_ParamIndex1  ST_AI_ID
Critter_ParamValue1  15
Critter_ParamIndex2  ST_BAG_ID
Critter_ParamValue2  0
Critter_ParamIndex3  ST_TEAM_ID
Critter_ParamValue3  0
Critter_ParamIndex4  ST_NPC_ROLE
Critter_ParamValue4  0
Critter_ParamIndex5  ST_REPLICATION_TIME
Critter_ParamValue5  0
Critter_ParamIndex6  ST_FACTION_RANK
Critter_ParamValue6  0
Critter_ParamIndex7  ST_FACTION_MODE
Critter_ParamValue7  0
Critter_ParamIndex8  ST_OVERRIDE_CRTYPE
Critter_ParamValue8  27
Critter_ParamIndex9  ST_LEVEL
Critter_ParamValue9  0
