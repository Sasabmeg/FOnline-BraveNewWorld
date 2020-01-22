unit Unit2;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ComCtrls, Buttons;

type
  TForm2 = class(TForm)
    Label1: TLabel;
    Label2: TLabel;
    Edit1: TEdit;
    Edit2: TEdit;
    Button1: TButton;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label8: TLabel;
    Edit3: TEdit;
    ListView1: TListView;
    BitBtn1: TBitBtn;
    Label7: TLabel;
    Edit4: TEdit;
    Edit5: TEdit;
    Edit6: TEdit;
    Label9: TLabel;
    Label10: TLabel;
    Label11: TLabel;
    Edit7: TEdit;
    Edit8: TEdit;
    Edit9: TEdit;
    Label12: TLabel;
    Label13: TLabel;
    Label14: TLabel;
    Edit10: TEdit;
    Label15: TLabel;
    Edit11: TEdit;
    Label16: TLabel;
    Edit12: TEdit;
    Label17: TLabel;
    Edit13: TEdit;
    Label18: TLabel;
    Edit14: TEdit;
    Label19: TLabel;
    CheckBox1: TCheckBox;
    CheckBox2: TCheckBox;
    CheckBox3: TCheckBox;
    CheckBox4: TCheckBox;
    CheckBox5: TCheckBox;
    CheckBox6: TCheckBox;
    CheckBox7: TCheckBox;
    CheckBox8: TCheckBox;
    CheckBox9: TCheckBox;
    CheckBox11: TCheckBox;
    CheckBox10: TCheckBox;
    Label20: TLabel;
    OpenDialog1: TOpenDialog;
    Edit15: TEdit;
    Label22: TLabel;
    Label23: TLabel;
    CheckBox12: TCheckBox;
    CheckBox13: TCheckBox;
    Label21: TLabel;
    Edit16: TEdit;
    CheckBox14: TCheckBox;
    Label24: TLabel;
    Label25: TLabel;
    Label26: TLabel;
    Label27: TLabel;
    Edit17: TEdit;
    Edit18: TEdit;
    Edit19: TEdit;
    Edit20: TEdit;
    CheckBox15: TCheckBox;
    CheckBox16: TCheckBox;
    CheckBox17: TCheckBox;
    CheckBox18: TCheckBox;
    Label28: TLabel;
    Edit21: TEdit;
    CheckBox19: TCheckBox;
    Label29: TLabel;
    Button2: TButton;
    Label30: TLabel;
    Label31: TLabel;
    procedure Button1Click(Sender: TObject);
    procedure ListView1ColumnClick(Sender: TObject; Column: TListColumn);
    procedure ListView1Compare(Sender: TObject; Item1, Item2: TListItem;
      Data: Integer; var Compare: Integer);
    procedure BitBtn1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure ListView1SelectItem(Sender: TObject; Item: TListItem;
      Selected: Boolean);
    procedure CheckBox1Click(Sender: TObject);
    procedure CheckBox13Click(Sender: TObject);
    procedure CheckBox12Click(Sender: TObject);
    procedure CheckBox2Click(Sender: TObject);
    procedure CheckBox3Click(Sender: TObject);
    procedure CheckBox4Click(Sender: TObject);
    procedure CheckBox5Click(Sender: TObject);
    procedure CheckBox6Click(Sender: TObject);
    procedure CheckBox7Click(Sender: TObject);
    procedure CheckBox8Click(Sender: TObject);
    procedure CheckBox9Click(Sender: TObject);
    procedure CheckBox10Click(Sender: TObject);
    procedure CheckBox11Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);

  private
    { Private declarations }
    procedure ShowSelected(Item:TListItem);
    procedure MasowyZapis;
    procedure PojedynczyZapis;
    function isCritter(linia:String):Boolean;

    procedure ReloadFile; // przeładowanie pliku po wykonaniu Save
	
  public
    { Public declarations }
  end;

var
  Form2: TForm2;
  plik:TextFile;
  licznik_Critters_PID:Integer;
  nr_linii:Integer;
  ColumnToSort: Integer;
  ZAPISUJ:Boolean;

  Selected_Item:TListItem;
  nazwa_pliku:String;

  StringPlik:TStringList;

implementation


{$R *.dfm}

procedure TForm2.ShowSelected(Item:TListItem);
begin
  if Assigned(Item) then
  begin
    Label20.Visible:=True;
    Label20.Caption:=Trim(Item.Caption);


    Edit15.Text:='';     //nr new PID, po kazdym kliknieciu w ListView1 powinna sie zerowac (puste pole)

    Edit1.Text:=Trim(Item.SubItems.Strings[1]);     //nr PID
    Edit2.Text:=Trim(Item.SubItems.Strings[2]);     //MapX
    Edit3.Text:=Trim(Item.SubItems.Strings[3]);     //MapY
    Edit4.Text:=Trim(Item.SubItems.Strings[4]);     //Dir

    Edit5.Text:=Trim(Item.SubItems.Strings[5]);     //ScriptName
    Edit6.Text:=Trim(Item.SubItems.Strings[6]);     //FuncName

    Edit7.Text:=Trim(Item.SubItems.Strings[7]);     //Critter_Cond
    Edit8.Text:=Trim(Item.SubItems.Strings[8]);     //Critter_CondExt

    Edit9.Text:=Trim(Item.SubItems.Strings[9]);     //CritterAnim1
    Edit10.Text:=Trim(Item.SubItems.Strings[10]);     //CritterAnim1

    Edit11.Text:=Trim(Item.SubItems.Strings[11]);     //Dialog ID
    Edit12.Text:=Trim(Item.SubItems.Strings[12]);     //AI ID
    Edit13.Text:=Trim(Item.SubItems.Strings[13]);     //Bag ID
    Edit14.Text:=Trim(Item.SubItems.Strings[14]);     //Team ID
    Edit16.Text:=Trim(Item.SubItems.Strings[15]);     //NPC ROLE
    Edit17.Text:=Trim(Item.SubItems.Strings[16]);     //Replication Time

    Edit18.Text:=Trim(Item.SubItems.Strings[17]);     //Faction rank
    Edit19.Text:=Trim(Item.SubItems.Strings[18]);     //Faction mode
    Edit20.Text:=Trim(Item.SubItems.Strings[19]);     //Override crtype
    Edit21.Text:=Trim(Item.SubItems.Strings[20]);     //ST_Level
  end;
end;


procedure TForm2.ReloadFile;
var linia,linia_temp:String;
    str_ProtoId:String;
    str_MapX:String;
    str_MapY:String;
    str_Dir:String;
    str_ScriptName:String;
    str_FuncName:String;
    str_Critter_Cond:String;
    str_Critter_CondExt:String;
    str_Critter_Anim1:String;
    str_Critter_Anim2:String;
    str_Critter_ParamIndex0:String;
    str_Critter_ParamValue0:String;
    str_Critter_ParamIndex1:String;
    str_Critter_ParamValue1:String;
    str_Critter_ParamIndex2:String;
    str_Critter_ParamValue2:String;
    str_Critter_ParamIndex3:String;
    str_Critter_ParamValue3:String;
    str_Critter_ParamIndex4:String;
    str_Critter_ParamValue4:String;
    str_Critter_ParamIndex5:String;
    str_Critter_ParamValue5:String;
    str_Critter_ParamIndex6:String;
    str_Critter_ParamValue6:String;
    str_Critter_ParamIndex7:String;
    str_Critter_ParamValue7:String;
    str_Critter_ParamIndex8:String;
    str_Critter_ParamValue8:String;
    str_Critter_ParamIndex9:String;
    str_Critter_ParamValue9:String;

    ListItem:TListItem;


begin

  if not FileExists(nazwa_pliku) then
    Exit;

  Label7.Caption:=ExtractFileName(nazwa_pliku);


  Screen.Cursor:=crHourGlass;
  ListView1.Items.Clear;


  licznik_Critters_PID:=0;
  Label3.Caption:=IntToStr(licznik_Critters_PID);

  nr_linii:=0;
  Label3.Caption:=IntToStr(nr_linii);

  AssignFile(plik,nazwa_pliku);
  Reset(plik);
  While not Eof(plik) do
  begin
    Inc(nr_linii);
    Label3.Caption:=IntToStr(nr_linii);

    Readln(plik,linia);

    linia_temp:=Trim(linia);

    if Pos('MapObjType           0',linia_temp)>0 then
    begin
      Inc(licznik_Critters_PID);
      Label4.Caption:=IntToStr(licznik_Critters_PID);

      ListItem := ListView1.Items.Add;
      ListItem.Caption := IntToStr(nr_linii);
      ListItem.SubItems.Add(IntToStr(licznik_Critters_PID));


      str_ProtoId:='';
      str_MapX:='';
      str_MapY:='';
      str_Dir:='';
      str_ScriptName:='';
      str_FuncName:='';
      str_Critter_Cond:='';
      str_Critter_CondExt:='';

      str_Critter_Anim1:='';
      str_Critter_Anim2:='';
      str_Critter_ParamIndex0:='';
      str_Critter_ParamValue0:='';
      str_Critter_ParamIndex1:='';
      str_Critter_ParamValue1:='';
      str_Critter_ParamIndex2:='';
      str_Critter_ParamValue2:='';
      str_Critter_ParamIndex3:='';
      str_Critter_ParamValue3:='';
      str_Critter_ParamIndex4:='';
      str_Critter_ParamValue4:='';
      str_Critter_ParamIndex5:='';
      str_Critter_ParamValue5:='';

      str_Critter_ParamIndex6:='';
      str_Critter_ParamValue6:='';
      str_Critter_ParamIndex7:='';
      str_Critter_ParamValue7:='';
      str_Critter_ParamIndex8:='';
      str_Critter_ParamValue8:='';
      str_Critter_ParamIndex9:='';
      str_Critter_ParamValue9:='';



     repeat
      Readln(plik,linia);
      Inc(nr_linii);

      linia_temp:=Trim(linia);
      if Pos('ProtoId',linia_temp)>0 then
      begin
        Delete(linia_temp,1,7);
        linia_temp:=Trim(linia_temp);
        str_ProtoID:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('MapX',linia_temp)>0 then
      begin
        Delete(linia_temp,1,4);
        linia_temp:=Trim(linia_temp);
        str_MapX:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('MapY',linia_temp)>0 then
      begin
        Delete(linia_temp,1,4);
        linia_temp:=Trim(linia_temp);
        str_MapY:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Dir',linia_temp)>0 then
      begin
        Delete(linia_temp,1,3);
        linia_temp:=Trim(linia_temp);
        str_Dir:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('ScriptName',linia_temp)>0 then
      begin
        Delete(linia_temp,1,10);
        linia_temp:=Trim(linia_temp);
        str_ScriptName:=linia_temp;
      end;


      linia_temp:=Trim(linia);
      if Pos('FuncName',linia_temp)>0 then
      begin
        Delete(linia_temp,1,8);
        linia_temp:=Trim(linia_temp);
        str_FuncName:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_Cond ',linia_temp)>0 then
      begin
        Delete(linia_temp,1,13);
        linia_temp:=Trim(linia_temp);
        str_Critter_Cond:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_CondExt',linia_temp)>0 then
      begin
        Delete(linia_temp,1,15);
        linia_temp:=Trim(linia_temp);
        str_Critter_CondExt:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_Anim1',linia_temp)>0 then
      begin
        Delete(linia_temp,1,Length('Critter_Anim1'));
        linia_temp:=Trim(linia_temp);
        str_Critter_Anim1:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_Anim2',linia_temp)>0 then
      begin
        Delete(linia_temp,1,Length('Critter_Anim2'));
        linia_temp:=Trim(linia_temp);
        str_Critter_Anim2:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex0',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex0:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue0',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue0:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex1',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex1:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue1',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue1:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex2',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex2:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue2',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue2:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex3',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex3:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue3',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue3:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex4',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex4:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue4',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue4:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex5',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex5:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue5',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue5:=linia_temp;
      end;

      //
      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex6',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex6:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue6',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue6:=linia_temp;
      end;

      //
      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex7',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex7:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue7',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue7:=linia_temp;
      end;


      //
      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex8',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex8:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue8',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue8:=linia_temp;
      end;


      //
      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex9',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex9:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue9',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue9:=linia_temp;
      end;


     until Length(linia)=0;


     ListItem.SubItems.Add(str_ProtoID);
     ListItem.SubItems.Add(str_MapX);
     ListItem.SubItems.Add(str_MapY);
     ListItem.SubItems.Add(str_Dir);
     ListItem.SubItems.Add(str_ScriptName);
     ListItem.SubItems.Add(str_FuncName);
     ListItem.SubItems.Add(str_Critter_Cond);
     ListItem.SubItems.Add(str_Critter_CondExt);

     ListItem.SubItems.Add(str_Critter_Anim1);
     ListItem.SubItems.Add(str_Critter_Anim2);

     ListItem.SubItems.Add(str_Critter_ParamValue0);
     ListItem.SubItems.Add(str_Critter_ParamValue1);
     ListItem.SubItems.Add(str_Critter_ParamValue2);
     ListItem.SubItems.Add(str_Critter_ParamValue3);
     ListItem.SubItems.Add(str_Critter_ParamValue4);
     ListItem.SubItems.Add(str_Critter_ParamValue5);
     ListItem.SubItems.Add(str_Critter_ParamValue6);
     ListItem.SubItems.Add(str_Critter_ParamValue7);
     ListItem.SubItems.Add(str_Critter_ParamValue8);
     ListItem.SubItems.Add(str_Critter_ParamValue9);



    end;

    Update;
    Application.ProcessMessages;
  end;
  CloseFile(plik);
  Screen.Cursor:=crDefault;

  if Assigned(ListView1.Items[0]) then
  begin
    ListView1.Items[0].Focused:=True;
    ListView1.Items[0].Selected:=True;
  end;


  //ShowMessage('Wczytywanie pliku zakonczone.');
end;


procedure TForm2.Button1Click(Sender: TObject);  //Otworz i Wczytaj plik
var linia,linia_temp:String;
    str_ProtoId:String;
    str_MapX:String;
    str_MapY:String;
    str_Dir:String;
    str_ScriptName:String;
    str_FuncName:String;
    str_Critter_Cond:String;
    str_Critter_CondExt:String;
    str_Critter_Anim1:String;
    str_Critter_Anim2:String;
    str_Critter_ParamIndex0:String;
    str_Critter_ParamValue0:String;
    str_Critter_ParamIndex1:String;
    str_Critter_ParamValue1:String;
    str_Critter_ParamIndex2:String;
    str_Critter_ParamValue2:String;
    str_Critter_ParamIndex3:String;
    str_Critter_ParamValue3:String;
    str_Critter_ParamIndex4:String;
    str_Critter_ParamValue4:String;
    str_Critter_ParamIndex5:String;
    str_Critter_ParamValue5:String;
    str_Critter_ParamIndex6:String;
    str_Critter_ParamValue6:String;
    str_Critter_ParamIndex7:String;
    str_Critter_ParamValue7:String;
    str_Critter_ParamIndex8:String;
    str_Critter_ParamValue8:String;
    str_Critter_ParamIndex9:String;
    str_Critter_ParamValue9:String;

    ListItem:TListItem;

    //iter:Integer;

    czas_p:TTime;
    hour, min, sec, msec: word;
begin

  if OpenDialog1.Execute then
    nazwa_pliku:=OpenDialog1.FileName
  else
    Exit;


  czas_p:=now;
  Label7.Caption:=ExtractFileName(nazwa_pliku);


  Screen.Cursor:=crHourGlass;
  ListView1.Items.Clear;


  licznik_Critters_PID:=0;
  Label3.Caption:=IntToStr(licznik_Critters_PID);

  nr_linii:=0;
  Label3.Caption:=IntToStr(nr_linii);

  AssignFile(plik,nazwa_pliku);
  Reset(plik);
  While not Eof(plik) do
  begin
    Inc(nr_linii);
    Label3.Caption:=IntToStr(nr_linii);

    Readln(plik,linia);
    linia_temp:=Trim(linia);

    if Pos('MapObjType           0',linia_temp)>0 then
    begin
      Inc(licznik_Critters_PID);
      Label4.Caption:=IntToStr(licznik_Critters_PID);

      ListItem := ListView1.Items.Add;
      ListItem.Caption := IntToStr(nr_linii);
      ListItem.SubItems.Add(IntToStr(licznik_Critters_PID));


      str_ProtoId:='';
      str_MapX:='';
      str_MapY:='';
      str_Dir:='';
      str_ScriptName:='';
      str_FuncName:='';
      str_Critter_Cond:='';
      str_Critter_CondExt:='';

      str_Critter_Anim1:='';
      str_Critter_Anim2:='';
      str_Critter_ParamIndex0:='';
      str_Critter_ParamValue0:='';
      str_Critter_ParamIndex1:='';
      str_Critter_ParamValue1:='';
      str_Critter_ParamIndex2:='';
      str_Critter_ParamValue2:='';
      str_Critter_ParamIndex3:='';
      str_Critter_ParamValue3:='';
      str_Critter_ParamIndex4:='';
      str_Critter_ParamValue4:='';
      str_Critter_ParamIndex5:='';
      str_Critter_ParamValue5:='';

      str_Critter_ParamIndex6:='';
      str_Critter_ParamValue6:='';
      str_Critter_ParamIndex7:='';
      str_Critter_ParamValue7:='';
      str_Critter_ParamIndex8:='';
      str_Critter_ParamValue8:='';
      str_Critter_ParamIndex9:='';
      str_Critter_ParamValue9:='';



     repeat
      Readln(plik,linia);
      Inc(nr_linii);

      linia_temp:=Trim(linia);
      if Pos('ProtoId',linia_temp)>0 then
      begin
        Delete(linia_temp,1,7);
        linia_temp:=Trim(linia_temp);
        str_ProtoID:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('MapX',linia_temp)>0 then
      begin
        Delete(linia_temp,1,4);
        linia_temp:=Trim(linia_temp);
        str_MapX:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('MapY',linia_temp)>0 then
      begin
        Delete(linia_temp,1,4);
        linia_temp:=Trim(linia_temp);
        str_MapY:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Dir',linia_temp)>0 then
      begin
        Delete(linia_temp,1,3);
        linia_temp:=Trim(linia_temp);
        str_Dir:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('ScriptName',linia_temp)>0 then
      begin
        Delete(linia_temp,1,10);
        linia_temp:=Trim(linia_temp);
        str_ScriptName:=linia_temp;
      end;


      linia_temp:=Trim(linia);
      if Pos('FuncName',linia_temp)>0 then
      begin
        Delete(linia_temp,1,8);
        linia_temp:=Trim(linia_temp);
        str_FuncName:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_Cond ',linia_temp)>0 then
      begin
        Delete(linia_temp,1,13);
        linia_temp:=Trim(linia_temp);
        str_Critter_Cond:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_CondExt',linia_temp)>0 then
      begin
        Delete(linia_temp,1,15);
        linia_temp:=Trim(linia_temp);
        str_Critter_CondExt:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_Anim1',linia_temp)>0 then
      begin
        Delete(linia_temp,1,Length('Critter_Anim1'));
        linia_temp:=Trim(linia_temp);
        str_Critter_Anim1:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_Anim2',linia_temp)>0 then
      begin
        Delete(linia_temp,1,Length('Critter_Anim2'));
        linia_temp:=Trim(linia_temp);
        str_Critter_Anim2:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex0',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex0:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue0',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue0:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex1',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex1:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue1',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue1:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex2',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex2:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue2',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue2:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex3',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex3:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue3',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue3:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex4',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex4:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue4',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue4:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex5',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex5:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue5',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue5:=linia_temp;
      end;

      //
      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex6',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex6:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue6',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue6:=linia_temp;
      end;

      //
      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex7',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex7:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue7',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue7:=linia_temp;
      end;


      //
      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex8',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex8:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue8',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue8:=linia_temp;
      end;


      //
      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex9',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex9:=linia_temp;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue9',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue9:=linia_temp;
      end;


     until Length(linia)=0;


     ListItem.SubItems.Add(str_ProtoID);
     ListItem.SubItems.Add(str_MapX);
     ListItem.SubItems.Add(str_MapY);
     ListItem.SubItems.Add(str_Dir);
     ListItem.SubItems.Add(str_ScriptName);
     ListItem.SubItems.Add(str_FuncName);
     ListItem.SubItems.Add(str_Critter_Cond);
     ListItem.SubItems.Add(str_Critter_CondExt);

     ListItem.SubItems.Add(str_Critter_Anim1);
     ListItem.SubItems.Add(str_Critter_Anim2);

     ListItem.SubItems.Add(str_Critter_ParamValue0);
     ListItem.SubItems.Add(str_Critter_ParamValue1);
     ListItem.SubItems.Add(str_Critter_ParamValue2);
     ListItem.SubItems.Add(str_Critter_ParamValue3);
     ListItem.SubItems.Add(str_Critter_ParamValue4);
     ListItem.SubItems.Add(str_Critter_ParamValue5);
     ListItem.SubItems.Add(str_Critter_ParamValue6);
     ListItem.SubItems.Add(str_Critter_ParamValue7);
     ListItem.SubItems.Add(str_Critter_ParamValue8);
     ListItem.SubItems.Add(str_Critter_ParamValue9);



    end;

    Update;
    Application.ProcessMessages;
  end;
  CloseFile(plik);
  Screen.Cursor:=crDefault;

  if Assigned(ListView1.Items[0]) then
  begin
    ListView1.Items[0].Focused:=True;
    ListView1.Items[0].Selected:=True;
  end;

  DecodeTime( Now-czas_p, hour, min, sec, msec );
  Label30.Caption:=IntToStr(sec) + ':' + IntToStr(msec) + 'ms';

  //ShowMessage('Wczytywanie pliku zakonczone.');
end;

procedure TForm2.ListView1ColumnClick(Sender: TObject;
  Column: TListColumn);
begin
//*******************************
//* zmiana sposobu sortowania
//******************************}
  ColumnToSort := Column.Index;
  (Sender as TCustomListView).AlphaSort;
end;



procedure TForm2.ListView1Compare(Sender: TObject; Item1, Item2: TListItem;
  Data: Integer; var Compare: Integer);

var ix: Integer;
begin
  if ZAPISUJ=FALSE then
  begin
    if ColumnToSort = 0 then
      Compare := CompareText(Item1.Caption,Item2.Caption)
    else
    begin
      ix := ColumnToSort - 1;
      Compare := CompareText(Item1.SubItems[ix],Item2.SubItems[ix]);
    end;
  end
end;


procedure TForm2.BitBtn1Click(Sender: TObject);
begin
  if CheckBox1.Checked=True then
    MasowyZapis
  else
    PojedynczyZapis;
end;





procedure TForm2.FormCreate(Sender: TObject);
begin
  Caption:='Fonline Reloaded: Fomap Text Editor - Critter Editor v 0.4.1.5';
  ZAPISUJ:=False;
end;


procedure TForm2.ListView1SelectItem(Sender: TObject; Item: TListItem;
  Selected: Boolean);
begin
  if Selected then
  begin
    ShowSelected(Item);
    Selected_Item:=Item;
    Update;
  end
  else ShowSelected(nil);
end;





procedure TForm2.MasowyZapis;
var linia,linia_temp:String;

    linia_ProtoId:String;
    linia_MapX:String;
    linia_MapY:String;
    linia_Dir:String;
    linia_ScriptName:String;
    linia_FuncName:String;
    linia_Critter_Cond:String;
    linia_Critter_CondExt:String;
    linia_Critter_ParamIndex0:String;
    linia_Critter_ParamValue0:String;
    linia_Critter_ParamIndex1:String;
    linia_Critter_ParamValue1:String;
    linia_Critter_ParamIndex2:String;
    linia_Critter_ParamValue2:String;
    linia_Critter_ParamIndex3:String;
    linia_Critter_ParamValue3:String;
    linia_Critter_ParamIndex4:String;
    linia_Critter_ParamValue4:String;
    linia_Critter_ParamIndex5:String;
    linia_Critter_ParamValue5:String;
//    linia_pusta:String;

    str_ProtoId:String;
    str_MapX:String;
    str_MapY:String;
    str_Dir:String;
    str_ScriptName:String;
    str_FuncName:String;
    str_Critter_Cond:String;
    str_Critter_CondExt:String;
    str_Critter_ParamIndex0:String;
    str_Critter_ParamValue0:String;
    str_Critter_ParamIndex1:String;
    str_Critter_ParamValue1:String;
    str_Critter_ParamIndex2:String;
    str_Critter_ParamValue2:String;
    str_Critter_ParamIndex3:String;
    str_Critter_ParamValue3:String;
    str_Critter_ParamIndex4:String;
    str_Critter_ParamValue4:String;
    str_Critter_ParamIndex5:String;
    str_Critter_ParamValue5:String;

    ListItem:TListItem;

    plik2:TextFile;

begin
  ZAPISUJ:=TRUE;

  Screen.Cursor:=crHourGlass;
  ListView1.Items.Clear;

  licznik_Critters_PID:=0;
  Label4.Caption:=IntToStr(licznik_Critters_PID);

  nr_linii:=0;
  Label3.Caption:=IntToStr(nr_linii);

  AssignFile(plik2,'tempowy_plik.fomap');
  Rewrite(plik2);
  AssignFile(plik,nazwa_pliku);
  Reset(plik);
  While not Eof(plik) do
  begin
    Inc(nr_linii);
    Label3.Caption:=IntToStr(nr_linii);

    Readln(plik,linia);

    linia_temp:=Trim(linia);

    if Pos('MapObjType           0',linia_temp)>0 then
    begin
      Writeln(plik2,linia);
      Inc(licznik_Critters_PID);
      Label4.Caption:=IntToStr(licznik_Critters_PID);

      ListItem := ListView1.Items.Add;
      ListItem.Caption := IntToStr(nr_linii);
      ListItem.SubItems.Add(IntToStr(licznik_Critters_PID));

      str_ProtoId:='';
      str_MapX:='';
      str_MapY:='';
      str_Dir:='';
      str_ScriptName:='';
      str_FuncName:='';
      str_Critter_Cond:='';
      str_Critter_CondExt:='';
      str_Critter_ParamIndex0:='';
      str_Critter_ParamValue0:='';
      str_Critter_ParamIndex1:='';
      str_Critter_ParamValue1:='';
      str_Critter_ParamIndex2:='';
      str_Critter_ParamValue2:='';
      str_Critter_ParamIndex3:='';
      str_Critter_ParamValue3:='';
      str_Critter_ParamIndex4:='';
      str_Critter_ParamValue4:='';
      str_Critter_ParamIndex5:='';
      str_Critter_ParamValue5:='';


      linia_ProtoId:='';
      linia_MapX:='';
      linia_MapY:='';
      linia_Dir:='';
      linia_ScriptName:='';
      linia_FuncName:='';
      linia_Critter_Cond:='';
      linia_Critter_CondExt:='';
      linia_Critter_ParamIndex0:='';
      linia_Critter_ParamValue0:='';
      linia_Critter_ParamIndex1:='';
      linia_Critter_ParamValue1:='';
      linia_Critter_ParamIndex2:='';
      linia_Critter_ParamValue2:='';
      linia_Critter_ParamIndex3:='';
      linia_Critter_ParamValue3:='';
      linia_Critter_ParamIndex4:='';
      linia_Critter_ParamValue4:='';
      linia_Critter_ParamIndex5:='';
      linia_Critter_ParamValue5:='';



     repeat
      Readln(plik,linia);
      inc(nr_linii);

      linia_temp:=Trim(linia);
      if Pos('ProtoId',linia_temp)>0 then
      begin
        Delete(linia_temp,1,7);
        linia_temp:=Trim(linia_temp);
        str_ProtoID:=linia_temp;
        linia_ProtoID:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('MapX',linia_temp)>0 then
      begin
        Delete(linia_temp,1,4);
        linia_temp:=Trim(linia_temp);
        str_MapX:=linia_temp;
        linia_MapX:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('MapY',linia_temp)>0 then
      begin
        Delete(linia_temp,1,4);
        linia_temp:=Trim(linia_temp);
        str_MapY:=linia_temp;
        linia_MapY:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Dir',linia_temp)>0 then
      begin
        Delete(linia_temp,1,3);
        linia_temp:=Trim(linia_temp);
        str_Dir:=linia_temp;
        linia_Dir:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('ScriptName',linia_temp)>0 then
      begin
        Delete(linia_temp,1,10);
        linia_temp:=Trim(linia_temp);
        str_ScriptName:=linia_temp;
        linia_ScriptName:=linia;
      end;


      linia_temp:=Trim(linia);
      if Pos('FuncName',linia_temp)>0 then
      begin
        Delete(linia_temp,1,8);
        linia_temp:=Trim(linia_temp);
        str_FuncName:=linia_temp;
        linia_FuncName:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_Cond ',linia_temp)>0 then
      begin
        Delete(linia_temp,1,13);
        linia_temp:=Trim(linia_temp);
        str_Critter_Cond:=linia_temp;
        linia_Critter_Cond:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_CondExt',linia_temp)>0 then
      begin
        Delete(linia_temp,1,15);
        linia_temp:=Trim(linia_temp);
        str_Critter_CondExt:=linia_temp;
        linia_Critter_CondExt:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex0',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex0:=linia_temp;
        linia_Critter_ParamIndex0:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue0',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue0:=linia_temp;
        linia_Critter_ParamValue0:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex1',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex1:=linia_temp;
        linia_Critter_ParamIndex1:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue1',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue1:=linia_temp;
        linia_Critter_ParamValue1:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex2',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex2:=linia_temp;
        linia_Critter_ParamIndex2:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue2',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue2:=linia_temp;
        linia_Critter_ParamValue2:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex3',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex3:=linia_temp;
        linia_Critter_ParamIndex3:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue3',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue3:=linia_temp;
        linia_Critter_ParamValue3:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex4',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex4:=linia_temp;
        linia_Critter_ParamIndex4:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue4',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue4:=linia_temp;
        linia_Critter_ParamValue4:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex5',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex5:=linia_temp;
        linia_Critter_ParamIndex5:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue5',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue5:=linia_temp;
        linia_Critter_ParamValue5:=linia;
      end;

     until Length(linia)=0;

     if (str_ProtoID=Edit1.Text) and (CheckBox13.Checked=True) then
     begin
       if (Edit15.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_ProtoId:=Edit15.Text;
         linia_ProtoId:='ProtoId           ' +str_ProtoId;
        end;
     end;

     if (str_ProtoID=Edit1.Text) and (CheckBox12.Checked=True) then
     begin
       if (Edit4.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Dir:=Edit4.Text;
         linia_Dir:='Dir           ' +str_Dir;
        end;
     end;

     if (str_ProtoID=Edit1.Text) and (CheckBox2.Checked=True) then
     begin
       if (Edit5.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_ScriptName:=Edit5.Text;
         linia_ScriptName:='ScriptName           ' +str_ScriptName;
        end;
     end;

     if (str_ProtoID=Edit1.Text) and (CheckBox3.Checked=True) then
     begin
       if (Edit6.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_FuncName:=Edit6.Text;
         linia_FuncName:='FuncName             ' +str_FuncName;
        end;
     end;

     if (str_ProtoID=Edit1.Text) and (CheckBox4.Checked=True) then
     begin
       if (Edit7.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_Cond:=Edit7.Text;
         linia_Critter_Cond:='Critter_Cond           ' +str_Critter_Cond;
        end;
     end;

     if (str_ProtoID=Edit1.Text) and (CheckBox5.Checked=True) then
     begin
       if (Edit8.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_CondExt:=Edit8.Text;
         linia_Critter_CondExt:='Critter_CondExt           ' +str_Critter_CondExt;
        end;
     end;


     if (str_ProtoID=Edit1.Text) and (CheckBox6.Checked=True) then
     begin
       if (Edit9.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_ParamValue0:=Edit9.Text;
         linia_Critter_ParamValue0:='Critter_ParamValue0           ' +str_Critter_ParamValue0;  //Dialog ID
        end;
     end;

     if (str_ProtoID=Edit1.Text) and (CheckBox7.Checked=True) then
     begin
       if (Edit10.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_ParamValue1:=Edit10.Text;
         linia_Critter_ParamValue1:='Critter_ParamValue1           ' +str_Critter_ParamValue1;  // AI ID
        end;
     end;

     if (str_ProtoID=Edit1.Text) and (CheckBox8.Checked=True) then
     begin
       if (Edit11.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_ParamValue2:=Edit11.Text;
         linia_Critter_ParamValue2:='Critter_ParamValue2           ' +str_Critter_ParamValue2;  // Bag ID
        end;
     end;

     if (str_ProtoID=Edit1.Text) and (CheckBox9.Checked=True) then
     begin
       if (Edit12.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_ParamValue3:=Edit12.Text;
         linia_Critter_ParamValue3:='Critter_ParamValue3           ' +str_Critter_ParamValue3;  // Team ID
        end;
     end;

     if (str_ProtoID=Edit1.Text) and (CheckBox10.Checked=True) then
     begin
       if (Edit13.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_ParamValue4:=Edit13.Text;
         linia_Critter_ParamValue4:='Critter_ParamValue4           ' +str_Critter_ParamValue4;  // NPC Role
        end;
     end;

     if (str_ProtoID=Edit1.Text) and (CheckBox11.Checked=True) then
     begin
       if (Edit14.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_ParamValue5:=Edit14.Text;
         linia_Critter_ParamValue5:='Critter_ParamValue5           ' +str_Critter_ParamValue5;  // Replication Time
        end;
     end;


     ListItem.SubItems.Add(str_ProtoID);
     ListItem.SubItems.Add(str_MapX);
     ListItem.SubItems.Add(str_MapY);
     ListItem.SubItems.Add(str_Dir);
     ListItem.SubItems.Add(str_ScriptName);
     ListItem.SubItems.Add(str_FuncName);
     ListItem.SubItems.Add(str_Critter_Cond);
     ListItem.SubItems.Add(str_Critter_CondExt);
     ListItem.SubItems.Add(str_Critter_ParamValue0);
     ListItem.SubItems.Add(str_Critter_ParamValue1);
     ListItem.SubItems.Add(str_Critter_ParamValue2);
     ListItem.SubItems.Add(str_Critter_ParamValue3);
     ListItem.SubItems.Add(str_Critter_ParamValue4);
     ListItem.SubItems.Add(str_Critter_ParamValue5);
     


     if not (linia_ProtoId='') then
     begin
       Writeln(plik2,linia_ProtoId);
     end;

     if not (linia_MapX='') then
     begin
       Writeln(plik2,linia_MapX);
     end;

     if not (linia_MapY='') then
     begin
       Writeln(plik2,linia_MapY);
     end;

     if not (linia_Dir='') then
     begin
       Writeln(plik2,linia_Dir);
     end;

     if not (linia_ScriptName='') then
     begin
       Writeln(plik2,linia_ScriptName);
     end;

     if not (linia_FuncName='') then
     begin
       Writeln(plik2,linia_FuncName);
     end;

     if not (linia_Critter_Cond='') then
     begin
       Writeln(plik2,linia_Critter_Cond);
     end;

     if not (linia_Critter_CondExt='') then
     begin
       Writeln(plik2,linia_Critter_CondExt);
     end;

     if not (linia_Critter_ParamIndex0='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex0);
     end;

     if not (linia_Critter_ParamValue0='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue0);
     end;

     if not (linia_Critter_ParamIndex1='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex1);
     end;

     if not (linia_Critter_ParamValue1='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue1);
     end;

     if not (linia_Critter_ParamIndex2='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex2);
     end;

     if not (linia_Critter_ParamValue2='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue2);
     end;

     if not (linia_Critter_ParamIndex3='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex3);
     end;

     if not (linia_Critter_ParamValue3='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue3);
     end;

     if not (linia_Critter_ParamIndex4='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex4);
     end;

     if not (linia_Critter_ParamValue4='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue4);
     end;

     if not (linia_Critter_ParamIndex5='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex5);
     end;

     if not (linia_Critter_ParamValue5='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue5);
     end;

     Writeln(plik2,''); //pusta linia, zeby oddzielic kolejna sekcje

    end
    else
      Writeln(plik2,linia);

    //Update;
    Application.ProcessMessages;
  end;
  CloseFile(plik);
  CloseFile(plik2);
  Erase(plik);
  Rename(plik2,nazwa_pliku);
  
  ZAPISUJ:=FALSE;

  Screen.Cursor:=crDefault;

  ListView1.ItemIndex:=ListView1.Items.IndexOf(Selected_Item);
  if Assigned(ListView1.Items[ListView1.ItemIndex]) then
  begin
    ListView1.Items[ListView1.ItemIndex].Focused:=True;
    ListView1.Items[ListView1.ItemIndex].Selected:=True;
  end;


  //ShowMessage('Zapisywanie masowe zakonczone!');
end;


procedure TForm2.CheckBox1Click(Sender: TObject);
begin
  if CheckBox1.Checked=True then
  begin
    CheckBox1.Font.Style:=[fsBold];
//    Label20.Caption:='0';
    CheckBox2.Visible:=True;
    CheckBox3.Visible:=True;
    CheckBox4.Visible:=True;
    CheckBox5.Visible:=True;
    CheckBox6.Visible:=True;
    CheckBox7.Visible:=True;
    CheckBox8.Visible:=True;
    CheckBox9.Visible:=True;
    CheckBox10.Visible:=True;
    CheckBox11.Visible:=True;
    CheckBox12.Visible:=True;
    CheckBox13.Visible:=True;

  end
  else
  begin
    CheckBox1.Font.Style:=[];
    
    CheckBox2.Checked:=False;
    CheckBox3.Checked:=False;
    CheckBox4.Checked:=False;
    CheckBox5.Checked:=False;
    CheckBox6.Checked:=False;
    CheckBox7.Checked:=False;
    CheckBox8.Checked:=False;
    CheckBox9.Checked:=False;
    CheckBox10.Checked:=False;
    CheckBox11.Checked:=False;
    CheckBox12.Checked:=False;
    CheckBox13.Checked:=False;


    CheckBox2.Visible:=False;
    CheckBox3.Visible:=False;
    CheckBox4.Visible:=False;
    CheckBox5.Visible:=False;
    CheckBox6.Visible:=False;
    CheckBox7.Visible:=False;
    CheckBox8.Visible:=False;
    CheckBox9.Visible:=False;
    CheckBox10.Visible:=False;
    CheckBox11.Visible:=False;
    CheckBox12.Visible:=False;
    CheckBox13.Visible:=False;
  end;
end;




procedure TForm2.PojedynczyZapis;
var linia,linia_temp:String;


    linia_ProtoId:String;
    linia_MapX:String;
    linia_MapY:String;
    linia_Dir:String;
    linia_ScriptName:String;
    linia_FuncName:String;
    linia_Critter_Cond:String;
    linia_Critter_CondExt:String;
    linia_Critter_Anim1:String;
    linia_Critter_Anim2:String;
    linia_Critter_ParamIndex0:String;
    linia_Critter_ParamValue0:String;
    linia_Critter_ParamIndex1:String;
    linia_Critter_ParamValue1:String;
    linia_Critter_ParamIndex2:String;
    linia_Critter_ParamValue2:String;
    linia_Critter_ParamIndex3:String;
    linia_Critter_ParamValue3:String;
    linia_Critter_ParamIndex4:String;
    linia_Critter_ParamValue4:String;
    linia_Critter_ParamIndex5:String;
    linia_Critter_ParamValue5:String;

    linia_Critter_ParamIndex6:String;
    linia_Critter_ParamValue6:String;
    linia_Critter_ParamIndex7:String;
    linia_Critter_ParamValue7:String;
    linia_Critter_ParamIndex8:String;
    linia_Critter_ParamValue8:String;
    linia_Critter_ParamIndex9:String;
    linia_Critter_ParamValue9:String;

//    linia_pusta:String;


    str_ProtoId:String;
    str_MapX:String;
    str_MapY:String;
    str_Dir:String;
    str_ScriptName:String;
    str_FuncName:String;
    str_Critter_Cond:String;
    str_Critter_CondExt:String;
    str_Critter_Anim1:String;
    str_Critter_Anim2:String;
    str_Critter_ParamIndex0:String;
    str_Critter_ParamValue0:String;
    str_Critter_ParamIndex1:String;
    str_Critter_ParamValue1:String;
    str_Critter_ParamIndex2:String;
    str_Critter_ParamValue2:String;
    str_Critter_ParamIndex3:String;
    str_Critter_ParamValue3:String;
    str_Critter_ParamIndex4:String;
    str_Critter_ParamValue4:String;
    str_Critter_ParamIndex5:String;
    str_Critter_ParamValue5:String;
    str_Critter_ParamIndex6:String;
    str_Critter_ParamValue6:String;
    str_Critter_ParamIndex7:String;
    str_Critter_ParamValue7:String;
    str_Critter_ParamIndex8:String;
    str_Critter_ParamValue8:String;
    str_Critter_ParamIndex9:String;
    str_Critter_ParamValue9:String;


    ListItem:TListItem;

    plik2:TextFile;
    ZapisujSkurczybyka:Boolean;


    Column: TListColumn;
    wybrana_linia:Integer;

begin
  ZAPISUJ:=TRUE;
  ZapisujSkurczybyka:=False;

  wybrana_linia:=ListView1.Items.IndexOf(Selected_Item);
  Screen.Cursor:=crHourGlass;
  ListView1.Items.Clear;

  licznik_Critters_PID:=0;
  Label4.Caption:=IntToStr(licznik_Critters_PID);

  nr_linii:=0;
  Label3.Caption:=IntToStr(nr_linii);

  AssignFile(plik2,'tempowy_plik.fomap');
  Rewrite(plik2);
  AssignFile(plik,nazwa_pliku);
  Reset(plik);
  While not Eof(plik) do
  begin
    Inc(nr_linii);
    Label3.Caption:=IntToStr(nr_linii);

    if nr_linii=StrToInt(Label20.Caption) then
    begin
      ZapisujSkurczybyka:=True;
    end;


    Readln(plik,linia);


    linia_temp:=Trim(linia);

    if Pos('MapObjType           0',linia_temp)>0 then
    begin
      Writeln(plik2,linia);
      Inc(licznik_Critters_PID);
      Label4.Caption:=IntToStr(licznik_Critters_PID);

      ListItem := ListView1.Items.Add;
      ListItem.Caption := IntToStr(nr_linii);
      ListItem.SubItems.Add(IntToStr(licznik_Critters_PID));



      str_ProtoId:='';
      str_MapX:='';
      str_MapY:='';
      str_Dir:='';
      str_ScriptName:='';
      str_FuncName:='';
      str_Critter_Cond:='';
      str_Critter_CondExt:='';
      str_Critter_Anim1:='';
      str_Critter_Anim2:='';
      str_Critter_ParamIndex0:='';
      str_Critter_ParamValue0:='';
      str_Critter_ParamIndex1:='';
      str_Critter_ParamValue1:='';
      str_Critter_ParamIndex2:='';
      str_Critter_ParamValue2:='';
      str_Critter_ParamIndex3:='';
      str_Critter_ParamValue3:='';
      str_Critter_ParamIndex4:='';
      str_Critter_ParamValue4:='';
      str_Critter_ParamIndex5:='';
      str_Critter_ParamValue5:='';
      str_Critter_ParamIndex6:='';
      str_Critter_ParamValue6:='';
      str_Critter_ParamIndex7:='';
      str_Critter_ParamValue7:='';
      str_Critter_ParamIndex8:='';
      str_Critter_ParamValue8:='';
      str_Critter_ParamIndex9:='';
      str_Critter_ParamValue9:='';



      linia_ProtoId:='';
      linia_MapX:='';
      linia_MapY:='';
      linia_Dir:='';
      linia_ScriptName:='';
      linia_FuncName:='';
      linia_Critter_Cond:='';
      linia_Critter_CondExt:='';
      linia_Critter_Anim1:='';
      linia_Critter_Anim1:='';
      linia_Critter_ParamIndex0:='';
      linia_Critter_ParamValue0:='';
      linia_Critter_ParamIndex1:='';
      linia_Critter_ParamValue1:='';
      linia_Critter_ParamIndex2:='';
      linia_Critter_ParamValue2:='';
      linia_Critter_ParamIndex3:='';
      linia_Critter_ParamValue3:='';
      linia_Critter_ParamIndex4:='';
      linia_Critter_ParamValue4:='';
      linia_Critter_ParamIndex5:='';
      linia_Critter_ParamValue5:='';
      linia_Critter_ParamIndex6:='';
      linia_Critter_ParamValue6:='';
      linia_Critter_ParamIndex7:='';
      linia_Critter_ParamValue7:='';
      linia_Critter_ParamIndex8:='';
      linia_Critter_ParamValue8:='';
      linia_Critter_ParamIndex9:='';
      linia_Critter_ParamValue9:='';



     repeat
      Readln(plik,linia);
      Inc(nr_linii);

      linia_temp:=Trim(linia);
      if Pos('ProtoId',linia_temp)>0 then
      begin
        Delete(linia_temp,1,7);
        linia_temp:=Trim(linia_temp);
        str_ProtoID:=linia_temp;
        linia_ProtoID:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('MapX',linia_temp)>0 then
      begin
        Delete(linia_temp,1,4);
        linia_temp:=Trim(linia_temp);
        str_MapX:=linia_temp;
        linia_MapX:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('MapY',linia_temp)>0 then
      begin
        Delete(linia_temp,1,4);
        linia_temp:=Trim(linia_temp);
        str_MapY:=linia_temp;
        linia_MapY:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Dir',linia_temp)>0 then
      begin
        Delete(linia_temp,1,3);
        linia_temp:=Trim(linia_temp);
        str_Dir:=linia_temp;
        linia_Dir:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('ScriptName',linia_temp)>0 then
      begin
        Delete(linia_temp,1,10);
        linia_temp:=Trim(linia_temp);
        str_ScriptName:=linia_temp;
        linia_ScriptName:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('FuncName',linia_temp)>0 then
      begin
        Delete(linia_temp,1,8);
        linia_temp:=Trim(linia_temp);
        str_FuncName:=linia_temp;
        linia_FuncName:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_Cond ',linia_temp)>0 then
      begin
        Delete(linia_temp,1,13);
        linia_temp:=Trim(linia_temp);
        str_Critter_Cond:=linia_temp;
        linia_Critter_Cond:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_CondExt',linia_temp)>0 then
      begin
        Delete(linia_temp,1,15);
        linia_temp:=Trim(linia_temp);
        str_Critter_CondExt:=linia_temp;
        linia_Critter_CondExt:=linia;
      end;


      linia_temp:=Trim(linia);
      if Pos('Critter_Anim1',linia_temp)>0 then
      begin
        Delete(linia_temp,1,Length('Critter_Anim1'));
        linia_temp:=Trim(linia_temp);
        str_Critter_Anim1:=linia_temp;
        linia_Critter_Anim1:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_Anim2',linia_temp)>0 then
      begin
        Delete(linia_temp,1,Length('Critter_Anim2'));
        linia_temp:=Trim(linia_temp);
        str_Critter_Anim2:=linia_temp;
        linia_Critter_Anim2:=linia;
      end;


      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex0',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex0:=linia_temp;
        linia_Critter_ParamIndex0:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue0',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue0:=linia_temp;
        linia_Critter_ParamValue0:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex1',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex1:=linia_temp;
        linia_Critter_ParamIndex1:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue1',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue1:=linia_temp;
        linia_Critter_ParamValue1:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex2',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex2:=linia_temp;
        linia_Critter_ParamIndex2:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue2',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue2:=linia_temp;
        linia_Critter_ParamValue2:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex3',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex3:=linia_temp;
        linia_Critter_ParamIndex3:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue3',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue3:=linia_temp;
        linia_Critter_ParamValue3:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex4',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex4:=linia_temp;
        linia_Critter_ParamIndex4:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue4',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue4:=linia_temp;
        linia_Critter_ParamValue4:=linia;
      end;

////
      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex5',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex5:=linia_temp;
        linia_Critter_ParamIndex5:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue5',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue5:=linia_temp;
        linia_Critter_ParamValue5:=linia;
      end;



////
      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex6',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex6:=linia_temp;
        linia_Critter_ParamIndex6:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue6',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue6:=linia_temp;
        linia_Critter_ParamValue6:=linia;
      end;



////
      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex7',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex7:=linia_temp;
        linia_Critter_ParamIndex7:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue7',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue7:=linia_temp;
        linia_Critter_ParamValue7:=linia;
      end;


////
      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex8',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex8:=linia_temp;
        linia_Critter_ParamIndex8:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue8',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue8:=linia_temp;
        linia_Critter_ParamValue8:=linia;
      end;


////
      linia_temp:=Trim(linia);
      if Pos('Critter_ParamIndex9',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex9:=linia_temp;
        linia_Critter_ParamIndex9:=linia;
      end;

      linia_temp:=Trim(linia);
      if Pos('Critter_ParamValue9',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue9:=linia_temp;
        linia_Critter_ParamValue9:=linia;
      end;


     until Length(linia)=0;


    if ZapisujSkurczybyka=True then
    begin
     ZapisujSkurczybyka:=False; // zapisywanie pojedynczego wykonane

     if (str_ProtoID=Edit1.Text) then
     begin
       if (Edit15.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_ProtoId:=Edit15.Text;
         linia_ProtoId:='ProtoId              ' +str_ProtoId;
        end;

       if (Edit2.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_MapX:=Edit2.Text;
         linia_MapX:='MapX                 ' +str_MapX;
        end;

       if (Edit3.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_MapY:=Edit3.Text;
         linia_MapY:='MapY                 ' +str_MapY;
        end;

       if (Edit4.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Dir:=Edit4.Text;
         linia_Dir:='Dir                  ' +str_Dir;
        end;

       if (Edit5.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_ScriptName:=Edit5.Text;
         linia_ScriptName:='ScriptName           ' +str_ScriptName;
        end;

       if (Edit6.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_FuncName:=Edit6.Text;
         linia_FuncName:='FuncName             ' +str_FuncName;
        end;

       if (Edit7.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_Cond:=Edit7.Text;
         linia_Critter_Cond:='Critter_Cond         ' +str_Critter_Cond;
        end;

       if (Edit8.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_CondExt:=Edit8.Text;
         linia_Critter_CondExt:='Critter_CondExt      ' +str_Critter_CondExt;
        end;

       if (Edit9.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_Anim1:=Edit9.Text;
         linia_Critter_Anim1:='Critter_Anim1        ' +str_Critter_Anim1;
        end;

       if (Edit10.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_Anim2:=Edit10.Text;
         linia_Critter_Anim2:='Critter_Anim2        ' +str_Critter_Anim2;
        end;

       if (Edit11.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_ParamValue0:=Edit11.Text;
         linia_Critter_ParamValue0:='Critter_ParamValue0  ' +str_Critter_ParamValue0;  //Dialog ID
        end;

       if (Edit12.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_ParamValue1:=Edit12.Text;
         linia_Critter_ParamValue1:='Critter_ParamValue1  ' +str_Critter_ParamValue1;  // AI ID
        end;

       if (Edit13.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_ParamValue2:=Edit13.Text;
         linia_Critter_ParamValue2:='Critter_ParamValue2  ' +str_Critter_ParamValue2;  // Bag ID
        end;

       if (Edit14.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_ParamValue3:=Edit14.Text;
         linia_Critter_ParamValue3:='Critter_ParamValue3  ' +str_Critter_ParamValue3;  // Team ID
        end;

       if (Edit16.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_ParamValue4:=Edit16.Text;
         linia_Critter_ParamValue4:='Critter_ParamValue4  ' +str_Critter_ParamValue4;  // NPC Role
        end;

       if (Edit17.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_ParamValue5:=Edit17.Text;
         linia_Critter_ParamValue5:='Critter_ParamValue5  ' +str_Critter_ParamValue5;  // Replication Time
        end;

       if (Edit18.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_ParamValue6:=Edit18.Text;
         linia_Critter_ParamValue6:='Critter_ParamValue6  ' +str_Critter_ParamValue6;  // Faction Rank
        end;

       if (Edit19.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_ParamValue7:=Edit19.Text;
         linia_Critter_ParamValue7:='Critter_ParamValue7  ' +str_Critter_ParamValue7;  // Faction Mode
        end;

       if (Edit20.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_ParamValue8:=Edit20.Text;
         linia_Critter_ParamValue8:='Critter_ParamValue8  ' +str_Critter_ParamValue8;  // Override crType
        end;

       if (Edit21.Text<>'') then //jesli dlugosc <> od zera czyli jest wpisana jakas nazwa skryptu
       begin
         str_Critter_ParamValue9:=Edit21.Text;
         linia_Critter_ParamValue9:='Critter_ParamValue9  ' +str_Critter_ParamValue9;  // ST_LEVEL
        end;
     end;

     if not (linia_ProtoId='') then
     begin
       Writeln(plik2,linia_ProtoId);
     end;

     if not (linia_MapX='') then
     begin
       Writeln(plik2,linia_MapX);
     end;

     if not (linia_MapY='') then
     begin
       Writeln(plik2,linia_MapY);
     end;

     if not (linia_Dir='') then
     begin
       Writeln(plik2,linia_Dir);
     end;

     if not (linia_ScriptName='') then
     begin
       Writeln(plik2,linia_ScriptName);
     end;

     if not (linia_FuncName='') then
     begin
       Writeln(plik2,linia_FuncName);
     end;

     if not (linia_Critter_Cond='') then
     begin
       Writeln(plik2,linia_Critter_Cond);
     end;

     if not (linia_Critter_CondExt='') then
     begin
       Writeln(plik2,linia_Critter_CondExt);
     end;

     if not (linia_Critter_Anim1='') then
     begin
       Writeln(plik2,linia_Critter_Anim1);
     end;

     if not (linia_Critter_Anim2='') then
     begin
       Writeln(plik2,linia_Critter_Anim2);
     end;

     if not (linia_Critter_ParamIndex0='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex0);
     end;

     if not (linia_Critter_ParamValue0='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue0);
     end;

     if not (linia_Critter_ParamIndex1='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex1);
     end;

     if not (linia_Critter_ParamValue1='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue1);
     end;

     if not (linia_Critter_ParamIndex2='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex2);
     end;

     if not (linia_Critter_ParamValue2='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue2);
     end;

     if not (linia_Critter_ParamIndex3='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex3);
     end;

     if not (linia_Critter_ParamValue3='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue3);
     end;

     if not (linia_Critter_ParamIndex4='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex4);
     end;

     if not (linia_Critter_ParamValue4='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue4);
     end;

     if not (linia_Critter_ParamIndex5='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex5);
     end;

     if not (linia_Critter_ParamValue5='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue5);
     end;


     if not (linia_Critter_ParamIndex6='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex6);
     end;

     if not (linia_Critter_ParamValue6='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue6);
     end;


     if not (linia_Critter_ParamIndex7='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex7);
     end;

     if not (linia_Critter_ParamValue7='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue7);
     end;


     if not (linia_Critter_ParamIndex8='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex8);
     end;

     if not (linia_Critter_ParamValue8='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue8);
     end;


     if not (linia_Critter_ParamIndex9='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex9);
     end;

     if not (linia_Critter_ParamValue9='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue9);
     end;


     Writeln(plik2,''); //pusta linia, zeby oddzielic kolejna sekcje


     ListItem.SubItems.Add(str_ProtoID);
     ListItem.SubItems.Add(str_MapX);
     ListItem.SubItems.Add(str_MapY);
     ListItem.SubItems.Add(str_Dir);
     ListItem.SubItems.Add(str_ScriptName);
     ListItem.SubItems.Add(str_FuncName);
     ListItem.SubItems.Add(str_Critter_Cond);
     ListItem.SubItems.Add(str_Critter_CondExt);

     ListItem.SubItems.Add(str_Critter_Anim1);
     ListItem.SubItems.Add(str_Critter_Anim2);

     ListItem.SubItems.Add(str_Critter_ParamValue0);
     ListItem.SubItems.Add(str_Critter_ParamValue1);
     ListItem.SubItems.Add(str_Critter_ParamValue2);
     ListItem.SubItems.Add(str_Critter_ParamValue3);
     ListItem.SubItems.Add(str_Critter_ParamValue4);
     ListItem.SubItems.Add(str_Critter_ParamValue5);
     ListItem.SubItems.Add(str_Critter_ParamValue6);
     ListItem.SubItems.Add(str_Critter_ParamValue7);
     ListItem.SubItems.Add(str_Critter_ParamValue8);
     ListItem.SubItems.Add(str_Critter_ParamValue9);


    end
    else
    begin
     if not (linia_ProtoId='') then
     begin
       Writeln(plik2,linia_ProtoId);
     end;

     if not (linia_MapX='') then
     begin
       Writeln(plik2,linia_MapX);
     end;

     if not (linia_MapY='') then
     begin
       Writeln(plik2,linia_MapY);
     end;

     if not (linia_Dir='') then
     begin
       Writeln(plik2,linia_Dir);
     end;

     if not (linia_ScriptName='') then
     begin
       Writeln(plik2,linia_ScriptName);
     end;

     if not (linia_FuncName='') then
     begin
       Writeln(plik2,linia_FuncName);
     end;

     if not (linia_Critter_Cond='') then
     begin
       Writeln(plik2,linia_Critter_Cond);
     end;

     if not (linia_Critter_CondExt='') then
     begin
       Writeln(plik2,linia_Critter_CondExt);
     end;

     if not (linia_Critter_Anim1='') then
     begin
       Writeln(plik2,linia_Critter_Anim1);
     end;

     if not (linia_Critter_Anim2='') then
     begin
       Writeln(plik2,linia_Critter_Anim2);
     end;


     if not (linia_Critter_ParamIndex0='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex0);
     end;

     if not (linia_Critter_ParamValue0='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue0);
     end;

     if not (linia_Critter_ParamIndex1='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex1);
     end;

     if not (linia_Critter_ParamValue1='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue1);
     end;

     if not (linia_Critter_ParamIndex2='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex2);
     end;

     if not (linia_Critter_ParamValue2='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue2);
     end;

     if not (linia_Critter_ParamIndex3='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex3);
     end;

     if not (linia_Critter_ParamValue3='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue3);
     end;

     if not (linia_Critter_ParamIndex4='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex4);
     end;

     if not (linia_Critter_ParamValue4='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue4);
     end;

     if not (linia_Critter_ParamIndex5='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex5);
     end;

     if not (linia_Critter_ParamValue5='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue5);
     end;



     if not (linia_Critter_ParamIndex6='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex6);
     end;

     if not (linia_Critter_ParamValue6='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue6);
     end;


     if not (linia_Critter_ParamIndex7='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex7);
     end;

     if not (linia_Critter_ParamValue7='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue7);
     end;


     if not (linia_Critter_ParamIndex8='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex8);
     end;

     if not (linia_Critter_ParamValue8='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue8);
     end;


     if not (linia_Critter_ParamIndex9='') then
     begin
       Writeln(plik2,linia_Critter_ParamIndex9);
     end;

     if not (linia_Critter_ParamValue9='') then
     begin
       Writeln(plik2,linia_Critter_ParamValue9);
     end;


     Writeln(plik2,''); //pusta linia, zeby oddzielic kolejna sekcje


     ListItem.SubItems.Add(str_ProtoID);
     ListItem.SubItems.Add(str_MapX);
     ListItem.SubItems.Add(str_MapY);
     ListItem.SubItems.Add(str_Dir);
     ListItem.SubItems.Add(str_ScriptName);
     ListItem.SubItems.Add(str_FuncName);
     ListItem.SubItems.Add(str_Critter_Cond);
     ListItem.SubItems.Add(str_Critter_CondExt);

     ListItem.SubItems.Add(str_Critter_Anim1);
     ListItem.SubItems.Add(str_Critter_Anim2);

     ListItem.SubItems.Add(str_Critter_ParamValue0);
     ListItem.SubItems.Add(str_Critter_ParamValue1);
     ListItem.SubItems.Add(str_Critter_ParamValue2);
     ListItem.SubItems.Add(str_Critter_ParamValue3);
     ListItem.SubItems.Add(str_Critter_ParamValue4);
     ListItem.SubItems.Add(str_Critter_ParamValue5);
     ListItem.SubItems.Add(str_Critter_ParamValue6);
     ListItem.SubItems.Add(str_Critter_ParamValue7);
     ListItem.SubItems.Add(str_Critter_ParamValue8);
     ListItem.SubItems.Add(str_Critter_ParamValue9);



    end;
    end
    else
      Writeln(plik2,linia);

    Update;
    Application.ProcessMessages;
  end;
  
  CloseFile(plik);
  CloseFile(plik2);
  Erase(plik);
  Rename(plik2,nazwa_pliku);

  ZAPISUJ:=FALSE;

  Screen.Cursor:=crDefault;


  ColumnToSort := 0;
  ListView1.AlphaSort;



  ListView1.ItemIndex:=wybrana_linia;
  if Assigned(ListView1.Items[ListView1.ItemIndex]) then
  begin
    ListView1.Items[ListView1.ItemIndex].Focused:=True;
    ListView1.Items[ListView1.ItemIndex].Selected:=True;
  end;


  {
  if Assigned(ListView1.Items[0]) then
  begin
    ListView1.Items[0].Focused:=True;
    ListView1.Items[0].Selected:=True;
  end;
  }
  //ShowMessage('Zapis pojedynczego NPC-a zakonczony.');
end;

procedure TForm2.CheckBox13Click(Sender: TObject);
begin
  if CheckBox13.Checked=True then
    Label23.Font.Style:=[fsBold]
  else
    Label23.Font.Style:=[];
end;

procedure TForm2.CheckBox12Click(Sender: TObject);
begin
begin
  if CheckBox12.Checked=True then
    Label9.Font.Style:=[fsBold]
  else
    Label9.Font.Style:=[];
end;
end;

procedure TForm2.CheckBox2Click(Sender: TObject);
begin
  if CheckBox2.Checked=True then
    Label10.Font.Style:=[fsBold]
  else
    Label10.Font.Style:=[];
end;

procedure TForm2.CheckBox3Click(Sender: TObject);
begin
  if CheckBox3.Checked=True then
    Label11.Font.Style:=[fsBold]
  else
    Label11.Font.Style:=[];
end;

procedure TForm2.CheckBox4Click(Sender: TObject);
begin
  if CheckBox4.Checked=True then
    Label12.Font.Style:=[fsBold]
  else
    Label12.Font.Style:=[];
end;

procedure TForm2.CheckBox5Click(Sender: TObject);
begin
  if CheckBox5.Checked=True then
    Label13.Font.Style:=[fsBold]
  else
    Label13.Font.Style:=[];
end;

procedure TForm2.CheckBox6Click(Sender: TObject);
begin
  if CheckBox6.Checked=True then
    Label14.Font.Style:=[fsBold]
  else
    Label14.Font.Style:=[];
end;

procedure TForm2.CheckBox7Click(Sender: TObject);
begin
  if CheckBox7.Checked=True then
    Label15.Font.Style:=[fsBold]
  else
    Label15.Font.Style:=[];
end;

procedure TForm2.CheckBox8Click(Sender: TObject);
begin
  if CheckBox8.Checked=True then
    Label16.Font.Style:=[fsBold]
  else
    Label16.Font.Style:=[];
end;

procedure TForm2.CheckBox9Click(Sender: TObject);
begin
  if CheckBox9.Checked=True then
    Label17.Font.Style:=[fsBold]
  else
    Label17.Font.Style:=[];
end;

procedure TForm2.CheckBox10Click(Sender: TObject);
begin
  if CheckBox10.Checked=True then
    Label18.Font.Style:=[fsBold]
  else
    Label18.Font.Style:=[];
end;

procedure TForm2.CheckBox11Click(Sender: TObject);
begin
  if CheckBox11.Checked=True then
    Label19.Font.Style:=[fsBold]
  else
    Label19.Font.Style:=[];
end;


function TForm2.isCritter(linia:String):Boolean;
var isMapObkectType, isZERO: Boolean;

begin
  result:=False;

  if Copy(linia,1,Length('MapObjType'))='MapObjType' then
  begin
    Delete(linia,1,Length('MapObjType'));
    linia:=Trim(linia);

    if linia='0' then
      result:=True;
  end
  else
    result:=False;


{  if (Copy(linia,1,Length('MapObjType'))='MapObjType') and (Trim(Copy(linia,Length('MapObjType')+1,Length(linia)-Length('MapObjType') ))='0') then
  begin
      result:=True;
  end
  else
    result:=False;
}
end;

procedure TForm2.Button2Click(Sender: TObject);
var linia,linia_temp:String;
    str_ProtoId:String;
    str_MapX:String;
    str_MapY:String;
    str_Dir:String;
    str_ScriptName:String;
    str_FuncName:String;
    str_Critter_Cond:String;
    str_Critter_CondExt:String;
    str_Critter_Anim1:String;
    str_Critter_Anim2:String;
    str_Critter_ParamIndex0:String;
    str_Critter_ParamValue0:String;
    str_Critter_ParamIndex1:String;
    str_Critter_ParamValue1:String;
    str_Critter_ParamIndex2:String;
    str_Critter_ParamValue2:String;
    str_Critter_ParamIndex3:String;
    str_Critter_ParamValue3:String;
    str_Critter_ParamIndex4:String;
    str_Critter_ParamValue4:String;
    str_Critter_ParamIndex5:String;
    str_Critter_ParamValue5:String;
    str_Critter_ParamIndex6:String;
    str_Critter_ParamValue6:String;
    str_Critter_ParamIndex7:String;
    str_Critter_ParamValue7:String;
    str_Critter_ParamIndex8:String;
    str_Critter_ParamValue8:String;
    str_Critter_ParamIndex9:String;
    str_Critter_ParamValue9:String;

    ListItem:TListItem;

    iter:Integer;
    czas_p:TTime;
    hour, min, sec, msec: word;



begin

  if OpenDialog1.Execute then
    nazwa_pliku:=OpenDialog1.FileName
  else
    Exit;

  czas_p:=Now;
  StringPlik:=TStringList.Create;
  try
    StringPlik.LoadFromFile(nazwa_pliku);

  Label3.Caption:='0';
  Label4.Caption:='0';
  Label7.Caption:=ExtractFileName(nazwa_pliku);


  Screen.Cursor:=crHourGlass;
  //ListView1.Items.BeginUpdate;
  ListView1.Items.Clear;


  licznik_Critters_PID:=0;
  Label3.Caption:=IntToStr(licznik_Critters_PID);

  nr_linii:=0;
  Label3.Caption:=IntToStr(nr_linii);


  iter:=0;
  While iter<StringPlik.Count-1 do
  begin
    Inc(nr_linii);
    Label3.Caption:=IntToStr(nr_linii);

    linia:=StringPlik.Strings[iter];
    Inc(iter);
    linia_temp:=Trim(linia);

    //if Pos('MapObjType           0',linia_temp)>0 then
    if isCritter(linia_temp) then
    begin
      Inc(licznik_Critters_PID);
      Label4.Caption:=IntToStr(licznik_Critters_PID);

      ListItem := ListView1.Items.Add;
      ListItem.Caption := IntToStr(nr_linii);
      ListItem.SubItems.Add(IntToStr(licznik_Critters_PID));


      str_ProtoId:='';
      str_MapX:='';
      str_MapY:='';
      str_Dir:='';
      str_ScriptName:='';
      str_FuncName:='';
      str_Critter_Cond:='';
      str_Critter_CondExt:='';

      str_Critter_Anim1:='';
      str_Critter_Anim2:='';
      //str_Critter_ParamIndex0:='';
      str_Critter_ParamValue0:='';
      //str_Critter_ParamIndex1:='';
      str_Critter_ParamValue1:='';
      //str_Critter_ParamIndex2:='';
      str_Critter_ParamValue2:='';
      //str_Critter_ParamIndex3:='';
      str_Critter_ParamValue3:='';
      //str_Critter_ParamIndex4:='';
      str_Critter_ParamValue4:='';
      //str_Critter_ParamIndex5:='';
      str_Critter_ParamValue5:='';

      //str_Critter_ParamIndex6:='';
      str_Critter_ParamValue6:='';
      //str_Critter_ParamIndex7:='';
      str_Critter_ParamValue7:='';
      //str_Critter_ParamIndex8:='';
      str_Critter_ParamValue8:='';
      //str_Critter_ParamIndex9:='';
      str_Critter_ParamValue9:='';



     repeat
      //Readln(plik,linia);
      linia:=StringPlik.Strings[iter];  linia_temp:=Trim(linia);
      Inc(iter);      
      Inc(nr_linii);

      
      if Pos('ProtoId',linia_temp)>0 then
      begin
        Delete(linia_temp,1,7);
        linia_temp:=Trim(linia_temp);
        str_ProtoID:=linia_temp;
      end;

      if Pos('MapX',linia_temp)>0 then
      begin
        Delete(linia_temp,1,4);
        linia_temp:=Trim(linia_temp);
        str_MapX:=linia_temp;
      end;

      if Pos('MapY',linia_temp)>0 then
      begin
        Delete(linia_temp,1,4);
        linia_temp:=Trim(linia_temp);
        str_MapY:=linia_temp;
      end;

      if Pos('Dir',linia_temp)>0 then
      begin
        Delete(linia_temp,1,3);
        linia_temp:=Trim(linia_temp);
        str_Dir:=linia_temp;
      end;

      if Pos('ScriptName',linia_temp)>0 then
      begin
        Delete(linia_temp,1,10);
        linia_temp:=Trim(linia_temp);
        str_ScriptName:=linia_temp;
      end;

      if Pos('FuncName',linia_temp)>0 then
      begin
        Delete(linia_temp,1,8);
        linia_temp:=Trim(linia_temp);
        str_FuncName:=linia_temp;
      end;

      if Pos('Critter_Cond ',linia_temp)>0 then
      begin
        Delete(linia_temp,1,13);
        linia_temp:=Trim(linia_temp);
        str_Critter_Cond:=linia_temp;
      end;

      if Pos('Critter_CondExt',linia_temp)>0 then
      begin
        Delete(linia_temp,1,15);
        linia_temp:=Trim(linia_temp);
        str_Critter_CondExt:=linia_temp;
      end;

      if Pos('Critter_Anim1',linia_temp)>0 then
      begin
        Delete(linia_temp,1,Length('Critter_Anim1'));
        linia_temp:=Trim(linia_temp);
        str_Critter_Anim1:=linia_temp;
      end;

      if Pos('Critter_Anim2',linia_temp)>0 then
      begin
        Delete(linia_temp,1,Length('Critter_Anim2'));
        linia_temp:=Trim(linia_temp);
        str_Critter_Anim2:=linia_temp;
      end;

      {if Pos('Critter_ParamIndex0',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex0:=linia_temp;
      end;
      }
      if Pos('Critter_ParamValue0',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue0:=linia_temp;
      end;

      {if Pos('Critter_ParamIndex1',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex1:=linia_temp;
      end;
      }
      if Pos('Critter_ParamValue1',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue1:=linia_temp;
      end;

      {if Pos('Critter_ParamIndex2',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex2:=linia_temp;
      end;
      }
      if Pos('Critter_ParamValue2',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue2:=linia_temp;
      end;

      {if Pos('Critter_ParamIndex3',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex3:=linia_temp;
      end;
      }
      if Pos('Critter_ParamValue3',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue3:=linia_temp;
      end;

      {if Pos('Critter_ParamIndex4',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex4:=linia_temp;
      end;
      }
      if Pos('Critter_ParamValue4',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue4:=linia_temp;
      end;

      {if Pos('Critter_ParamIndex5',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex5:=linia_temp;
      end;
      }
      if Pos('Critter_ParamValue5',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue5:=linia_temp;
      end;

      {if Pos('Critter_ParamIndex6',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex6:=linia_temp;
      end;
      }
      if Pos('Critter_ParamValue6',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue6:=linia_temp;
      end;

      {if Pos('Critter_ParamIndex7',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex7:=linia_temp;
      end;
      }
      if Pos('Critter_ParamValue7',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue7:=linia_temp;
      end;

      {if Pos('Critter_ParamIndex8',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex8:=linia_temp;
      end;
      }
      if Pos('Critter_ParamValue8',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue8:=linia_temp;
      end;

      {if Pos('Critter_ParamIndex9',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamIndex9:=linia_temp;
      end;
      }
      if Pos('Critter_ParamValue9',linia_temp)>0 then
      begin
        Delete(linia_temp,1,19);
        linia_temp:=Trim(linia_temp);
        str_Critter_ParamValue9:=linia_temp;
      end;


     until Length(linia)=0;


     ListItem.SubItems.Add(str_ProtoID);
     ListItem.SubItems.Add(str_MapX);
     ListItem.SubItems.Add(str_MapY);
     ListItem.SubItems.Add(str_Dir);
     ListItem.SubItems.Add(str_ScriptName);
     ListItem.SubItems.Add(str_FuncName);
     ListItem.SubItems.Add(str_Critter_Cond);
     ListItem.SubItems.Add(str_Critter_CondExt);

     ListItem.SubItems.Add(str_Critter_Anim1);
     ListItem.SubItems.Add(str_Critter_Anim2);

     ListItem.SubItems.Add(str_Critter_ParamValue0);
     ListItem.SubItems.Add(str_Critter_ParamValue1);
     ListItem.SubItems.Add(str_Critter_ParamValue2);
     ListItem.SubItems.Add(str_Critter_ParamValue3);
     ListItem.SubItems.Add(str_Critter_ParamValue4);
     ListItem.SubItems.Add(str_Critter_ParamValue5);
     ListItem.SubItems.Add(str_Critter_ParamValue6);
     ListItem.SubItems.Add(str_Critter_ParamValue7);
     ListItem.SubItems.Add(str_Critter_ParamValue8);
     ListItem.SubItems.Add(str_Critter_ParamValue9);



    end;

    //Update;
    Application.ProcessMessages;
  end;

  //ListView1.Items.EndUpdate;
  Screen.Cursor:=crDefault;

  if Assigned(ListView1.Items[0]) then
  begin
    ListView1.Items[0].Focused:=True;
    ListView1.Items[0].Selected:=True;
  end;

  finally
    StringPlik.Free;
  end;

//  czas_p:=Now;
  DecodeTime( Now-czas_p, hour, min, sec, msec );
  Label31.Caption:=IntToStr(sec) + ':' + IntToStr(msec) + 'ms';

  //ShowMessage('Wczytywanie pliku zakonczone.');
end;

end.




procedure TForm2.ListView1ColumnClick(Sender: TObject;
  Column: TListColumn);

begin
//*******************************
//* zmiana sposobu sortowania
//******************************}
  ColumnToSort := Column.Index;
  (Sender as TCustomListView).AlphaSort;
end;

procedure TForm2.ListView1Compare(Sender: TObject; Item1, Item2: TListItem;
  Data: Integer; var Compare: Integer);

var ix: Integer;
begin
  if ZAPISUJ=FALSE then
  begin
    if ColumnToSort = 0 then
      Compare := CompareText(Item1.Caption,Item2.Caption)
    else
    begin
      ix := ColumnToSort - 1;
      Compare := CompareText(Item1.SubItems[ix],Item2.SubItems[ix]);
    end;
  end
end;





MapObjType           0
ProtoId              496
MapX                 195
MapY                 312
Dir                  3
ScriptName           fo2077_shady
FuncName             _GuardInit
Critter_Cond         1
Critter_CondExt      1
Critter_ParamIndex0  ST_DIALOG_ID
Critter_ParamValue0  0
Critter_ParamIndex1  ST_AI_ID
Critter_ParamValue1  0
Critter_ParamIndex2  ST_BAG_ID
Critter_ParamValue2  0
Critter_ParamIndex3  ST_TEAM_ID
Critter_ParamValue3  16
Critter_ParamIndex4  ST_NPC_ROLE
Critter_ParamValue4  0
Critter_ParamIndex5  ST_REPLICATION_TIME
Critter_ParamValue5  0