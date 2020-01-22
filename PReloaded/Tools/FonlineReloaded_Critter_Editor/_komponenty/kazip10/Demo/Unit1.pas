unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, KAZip, StdCtrls, ComCtrls, KAZipTreeView, KAZipListView, ImgList,
  ExtCtrls, ShellAPI, ShlObj, Menus, ToolWin, Masks;

type
  TForm1 = class(TForm)
    KAZip1: TKAZip;
    KAZipTreeView1: TKAZipTreeView;
    KAZipListView1: TKAZipListView;
    ImageList1: TImageList;
    ImageList2: TImageList;
    Panel1: TPanel;
    StatusBar1: TStatusBar;
    Splitter1: TSplitter;
    MainMenu1: TMainMenu;
    File1: TMenuItem;
    OpenZipArchive1: TMenuItem;
    CloseZipArchive1: TMenuItem;
    OpenDialog1: TOpenDialog;
    Saveas1: TMenuItem;
    N2: TMenuItem;
    SaveDialog1: TSaveDialog;
    NewZipArchive1: TMenuItem;
    TestZipIntegrity1: TMenuItem;
    N3: TMenuItem;
    File2: TMenuItem;
    AddFiletoZip1: TMenuItem;
    ExtractSelectedFiles1: TMenuItem;
    DeleteSelectedFilesfrpmZip1: TMenuItem;
    SaveSelectedFileas1: TMenuItem;
    OpenDialog2: TOpenDialog;
    ExtractAllFiles1: TMenuItem;
    N1: TMenuItem;
    N4: TMenuItem;
    N5: TMenuItem;
    N6: TMenuItem;
    SelectAll1: TMenuItem;
    DelesectAll1: TMenuItem;
    InvertSelection1: TMenuItem;
    PopupMenu3: TPopupMenu;
    Insertfileinselectedfolder1: TMenuItem;
    MenuItem1: TMenuItem;
    Deletefolder1: TMenuItem;
    PopupMenu2: TPopupMenu;
    Open1: TMenuItem;
    N7: TMenuItem;
    MenuItem11: TMenuItem;
    MenuItem12: TMenuItem;
    MenuItem13: TMenuItem;
    MenuItem14: TMenuItem;
    MenuItem15: TMenuItem;
    MenuItem16: TMenuItem;
    MenuItem17: TMenuItem;
    MenuItem18: TMenuItem;
    MenuItem19: TMenuItem;
    MenuItem20: TMenuItem;
    MenuItem21: TMenuItem;
    MenuItem22: TMenuItem;
    View1: TMenuItem;
    LargeIcons1: TMenuItem;
    SmallIcons1: TMenuItem;
    List1: TMenuItem;
    Report1: TMenuItem;
    N8: TMenuItem;
    ViewwithNotepad1: TMenuItem;
    ImageList3: TImageList;
    ToolBar1: TToolBar;
    ToolButton1: TToolButton;
    ToolButton2: TToolButton;
    ToolButton3: TToolButton;
    ToolButton4: TToolButton;
    ToolButton5: TToolButton;
    ToolButton6: TToolButton;
    ToolButton7: TToolButton;
    ToolButton8: TToolButton;
    ToolButton10: TToolButton;
    ToolButton9: TToolButton;
    Panel2: TPanel;
    ools1: TMenuItem;
    Find1: TMenuItem;
    Label2: TLabel;
    Edit1: TEdit;
    Button1: TButton;
    Button2: TButton;
    Button3: TButton;
    ToolButton11: TToolButton;
    Edit2: TEdit;
    Label1: TLabel;
    Button4: TButton;
    procedure KAZipTreeView1Change(Sender: TObject; Node: TTreeNode);
    procedure KAZipTreeView1DblClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
    procedure KAZipTreeView1GetImageIndex(Sender: TObject;
      Node: TTreeNode);
    procedure KAZipTreeView1GetSelectedIndex(Sender: TObject;
      Node: TTreeNode);
    procedure KAZipListView1Change(Sender: TObject; Items: TListItem;
      Change: TItemChange);
    procedure KAZipListView1DblClick(Sender: TObject);
    procedure KAZipListView1KeyPress(Sender: TObject; var Key: Char);
    procedure KAZip1DecompressFile(Sender: TObject; Current,
      Total: Integer);
    procedure OpenZipArchive1Click(Sender: TObject);
    procedure CloseZipArchive1Click(Sender: TObject);
    procedure KAZip1CompressFile(Sender: TObject; Current, Total: Integer);
    procedure Saveas1Click(Sender: TObject);
    procedure KAZip1ZipChange(Sender: TObject; ChangeType: Integer);
    procedure NewZipArchive1Click(Sender: TObject);
    procedure TestZipIntegrity1Click(Sender: TObject);
    procedure AddFiletoZip1Click(Sender: TObject);
    procedure DeleteSelectedFilesfrpmZip1Click(Sender: TObject);
    procedure SaveSelectedFileas1Click(Sender: TObject);
    procedure ExtractSelectedFiles1Click(Sender: TObject);
    procedure ExtractAllFiles1Click(Sender: TObject);
    procedure SelectAll1Click(Sender: TObject);
    procedure DelesectAll1Click(Sender: TObject);
    procedure InvertSelection1Click(Sender: TObject);
    procedure Insertfileinselectedfolder1Click(Sender: TObject);
    procedure Deletefolder1Click(Sender: TObject);
    procedure LargeIcons1Click(Sender: TObject);
    procedure SmallIcons1Click(Sender: TObject);
    procedure List1Click(Sender: TObject);
    procedure Report1Click(Sender: TObject);
    procedure ViewwithNotepad1Click(Sender: TObject);
    procedure Edit1KeyPress(Sender: TObject; var Key: Char);
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Find1Click(Sender: TObject);
    procedure Edit2KeyPress(Sender: TObject; var Key: Char);
    procedure Button4Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
    FilesToDelete : TStringList;
    ProgressBar1  : TProgressBar;
    function  Matches(const Filename, Mask: string): Boolean;
    function  BrowseDialog(const Title: string; const Flag: integer): string;
    function  IsFolder(Items : TListItem):Boolean;
    function  LastIndexOf(Const Substr : String; Const Str : String):Integer;
  end;

var
  Form1      : TForm1;
  LastFolder : String;
  LastFound  : Integer = -1;

implementation
{$R *.dfm}
uses Unit2, Unit3;


function BrowseDialogCallBack(Wnd: HWND; uMsg: Cardinal; lParam, lpData: Integer): Integer;stdcall;
var
  wa, rect : TRect;
  dialogPT : TPoint;
  P        : PChar;
begin
  if uMsg = BFFM_INITIALIZED then
  begin
    if LastFolder <> '' Then
       Begin
         P := PChar(LastFolder);
         SendMessage(Wnd, BFFM_SETSELECTION, Ord(TRUE), Integer(P));
       End;
    wa := Screen.WorkAreaRect;
    GetWindowRect(Wnd, Rect);
    dialogPT.X := ((wa.Right-wa.Left) div 2) -
                  ((rect.Right-rect.Left) div 2);
    dialogPT.Y := ((wa.Bottom-wa.Top) div 2) -
                  ((rect.Bottom-rect.Top) div 2);
    MoveWindow(Wnd,
               dialogPT.X,
               dialogPT.Y,
               Rect.Right - Rect.Left,
               Rect.Bottom - Rect.Top,
               True);
  end;
  Result := 0;
end;


function TForm1.BrowseDialog(const Title: string; const Flag: integer): string;
var
  LpItemID    : PItemIDList;
  BrowseInfo  : TBrowseInfo;
  DisplayName : Array[0..MAX_PATH] of Char;
  TempPath    : Array[0..MAX_PATH] of Char;
Begin
  Result      := '';
  FillChar(BrowseInfo, sizeof(TBrowseInfo), #0);
  with BrowseInfo do
    begin
      hwndOwner      := Handle;
      pszDisplayName := @DisplayName;
      lpszTitle      := PChar(Title);
      ulFlags        := Flag;
      lpfn           := BrowseDialogCallBack;
   end;
  lpItemID := SHBrowseForFolder(BrowseInfo);
  if lpItemId <> nil then
     begin
       SHGetPathFromIDList(lpItemID, TempPath);
       Result      := TempPath;
       LastFolder  := Result;
       GlobalFreePtr(lpItemID);
     end;
end;

function TForm1.IsFolder(Items: TListItem): Boolean;
begin
  Result := Items.Data=TObject(-1);
end;

function TForm1.LastIndexOf(Const Substr : String; Const Str : String): Integer;
Var
  S : String;
  P : Integer;
begin
  Result := 0;
  S      := Str;
  P      := Pos(Substr,S);
  While P > 0 Do
    Begin
      Result := Result+P;
      System.Delete(S,1,P+Length(Substr));
      P      := Pos(Substr,S);
    End;
end;



procedure TForm1.KAZipTreeView1Change(Sender: TObject; Node: TTreeNode);
Var
  S : String;
begin
  If Node <> Nil Then
     Begin
       S := '';
       While Node.Parent <> Nil do
          Begin
            if Integer(Node.Data) < 0 Then
               Begin
                 S    := Node.Text+'\'+S;
               End;
            Node := Node.Parent;
          End;
       KAZipListView1.FilterFolder := S;
     End
  Else
     Begin
       KAZipListView1.FilterFolder := '';
     End;
end;

procedure TForm1.KAZipTreeView1DblClick(Sender: TObject);
Var
 Node : TTreeNode;
 FN   : String;
begin
 Node := KAZipTreeView1.Selected;
 if Node <> Nil Then
    Begin                       
      if Integer(Node.Data) > -1 Then
         Begin
            FN := KAZip1.GetDelphiTempFileName;
            DeleteFile(FN);
            FN := ExtractFilePath(FN) + ExtractFileName(Node.Text);
            KAZip1.Entries.Items[Integer(Node.Data)].ExtractToFile(FN);
            ProgressBar1.Position := 0;
            if ShellExecute(Handle,'open',PChar(FN),'',PChar(ExtractFilePath(FN)),SW_SHOWNORMAL) < 33 Then
               Begin
                 MessageBox(Handle,'Cannot run the selected file!','Stop',MB_ICONEXCLAMATION OR MB_OK);
                 DeleteFile(FN);
                 Exit;
               End;
            FilesToDelete.Add(FN);
         End;
    End;
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
  FilesToDelete        := TStringList.Create;
  ProgressBar1         := TProgressBar.Create(StatusBar1);
  ProgressBar1.Parent  := StatusBar1;
  ProgressBar1.Top     := 4;
  ProgressBar1.Left    := 2;
  ProgressBar1.Width   := 400;
  ProgressBar1.Height  := StatusBar1.ClientHeight-6;
end;

procedure TForm1.FormDestroy(Sender: TObject);
Var
 X : Integer;
begin
  For X := 0 To FilesToDelete.Count-1 do
    Begin
      DeleteFile(FilesToDelete.Strings[X]);
    End;
  FilesToDelete.Free;
end;

procedure TForm1.KAZipTreeView1GetImageIndex(Sender: TObject;
  Node: TTreeNode);
begin
 Node.ImageIndex := -1;
 if Node.Parent=Nil Then
    Begin
      Node.ImageIndex := 2;
    End
 Else
 if Integer(Node.Data)=-1 Then
    Begin
      If Node.Expanded Then Node.ImageIndex := 1 Else Node.ImageIndex := 0
    End
 Else
 if Integer(Node.Data)> -1 Then
    Begin
      Node.ImageIndex := 3
    End;
end;

procedure TForm1.KAZipTreeView1GetSelectedIndex(Sender: TObject;
  Node: TTreeNode);
begin
Node.SelectedIndex := -1;
if Node.Parent=Nil Then
    Begin
      Node.SelectedIndex := 2;
    End
Else
if Integer(Node.Data)=-1 Then
    Begin
      Node.SelectedIndex := 1
    End
 Else
 if Integer(Node.Data)> -1 Then
    Begin
      Node.SelectedIndex := 3
    End;
end;

procedure TForm1.KAZipListView1Change(Sender: TObject; Items: TListItem;
  Change: TItemChange);
begin
 if (Items <> Nil) And (Items.Data <> Nil) Then
    Begin
      if NOT IsFolder(Items) Then
         Begin
           if Integer(Items.Data) < KAZip1.Entries.Count Then
              StatusBar1.SimpleText := ' '+KAZip1.Entries.Items[Integer(Items.Data)].FileName;
         End
      Else
         Begin
           StatusBar1.SimpleText := ' '+Items.Caption;
         End
    End;
end;

procedure TForm1.ViewwithNotepad1Click(Sender: TObject);
Var
  FN : String;
begin
  if KAZipListView1.Selected <> Nil Then
     Begin
       if NOT IsFolder(KAZipListView1.Selected) Then
          begin
            FN := KAZip1.GetDelphiTempFileName;
            DeleteFile(FN);
            FN := ExtractFilePath(FN) + ExtractFileName(KAZipListView1.Selected.Caption);
            KAZip1.Entries.Items[Integer(KAZipListView1.Selected.Data)].ExtractToFile(FN);
            ProgressBar1.Position := 0;
            WinExec(PChar('Notepad.exe "'+FN+'"'),SW_SHOWNORMAL);
            FilesToDelete.Add(FN);
          End;
     End;
  KAZipListView1.SetFocus;
end;



procedure TForm1.KAZipListView1DblClick(Sender: TObject);
Var
  FN : String;
  P1 : Integer;
  P2 : Integer;
begin
  if KAZipListView1.Selected <> Nil Then
     Begin
       if IsFolder(KAZipListView1.Selected) Then
          Begin
            if (KAZipListView1.Filtered) Then
               Begin
                 if KAZipListView1.Selected.Caption ='..' Then
                    Begin
                      if KAZipListView1.FilterFolder<>'' Then
                         Begin
                           P2 := Pos('\',FN);
                           FN := ExcludeTrailingBackslash(KAZipListView1.FilterFolder);
                           P1 := LastIndexOf('\',FN);
                           if P1=P2 Then
                              Begin
                                KAZipListView1.FilterFolder := ''
                              End
                           Else
                              Begin
                                KAZipListView1.FilterFolder := Copy(FN,1,P1+1);
                              End;
                         End;
                      KAZipTreeView1.SetCurrentFolder(KAZipListView1.FilterFolder);
                      if KAZipListView1.Items.Count > 0 Then KAZipListView1.Items[0].Focused := True;
                    End
                 Else
                    Begin
                      KAZipListView1.FilterFolder := KAZipListView1.FilterFolder+KAZipListView1.Selected.Caption+'\';
                      KAZipTreeView1.SetCurrentFolder(KAZipListView1.FilterFolder);
                      if KAZipListView1.Items.Count > 0 Then KAZipListView1.Items[0].Focused := True;
                    End;
               End;
          End
       Else
          begin
            FN := KAZip1.GetDelphiTempFileName;
            DeleteFile(FN);
            FN := ExtractFilePath(FN) + ExtractFileName(KAZipListView1.Selected.Caption);
            KAZip1.Entries.Items[Integer(KAZipListView1.Selected.Data)].ExtractToFile(FN);
            ProgressBar1.Position := 0;
            if ShellExecute(Handle,'open',PChar(FN),'',PChar(ExtractFilePath(FN)),SW_SHOWNORMAL) < 33 Then
               Begin
                 MessageBox(Handle,'Cannot run the selected file!','Stop',MB_ICONEXCLAMATION OR MB_OK);
                 DeleteFile(FN);
                 Exit;
               End;
            FilesToDelete.Add(FN);
          End;
     End;
  KAZipListView1.SetFocus;
end;


procedure TForm1.KAZipListView1KeyPress(Sender: TObject; var Key: Char);
begin
   if Key=#13 Then
     Begin
       Key := #0;
       KAZipListView1DblClick(KAZipListView1);
     End;
end;

procedure TForm1.KAZip1DecompressFile(Sender: TObject; Current,
  Total: Integer);
begin
  if Total <> ProgressBar1.Max Then
     Begin
       ProgressBar1.Position := 0;
       ProgressBar1.Max      := Total;
       ProgressBar1.Min      := 0;
     End;
  ProgressBar1.Position := Current;
end;

procedure TForm1.KAZip1CompressFile(Sender: TObject; Current,
  Total: Integer);
begin
  if Total <> ProgressBar1.Max Then
     Begin
       ProgressBar1.Position := 0;
       ProgressBar1.Max      := Total;
       ProgressBar1.Min      := 0;
     End;
  ProgressBar1.Position := Current;
end;

procedure TForm1.OpenZipArchive1Click(Sender: TObject);
begin
  if OpenDialog1.Execute Then
     Begin
       KAZip1.Open(OpenDialog1.FileName);
       Caption := 'KAZip Demo   '+OpenDialog1.FileName;
     End;
end;

procedure TForm1.CloseZipArchive1Click(Sender: TObject);
begin
  KAZipListView1.Items.Clear;
  KAZipTreeView1.Items.Clear;
  KAZip1.Close;
  Caption := 'KAZip Demo';
end;

procedure TForm1.Saveas1Click(Sender: TObject);
Var
  FS : TFileStream;
begin
  if SaveDialog1.Execute Then
     Begin
       if NOT KAZip1.Active Then
          Begin
            FS := TFileStream.Create(SaveDialog1.FileName,fmOpenReadWrite or FmCreate);
            Try
               KAZip1.CreateZip(FS);
            Finally
               FS.Free;
            End;
          End
       Else
          Begin
            FS := TFileStream.Create(SaveDialog1.FileName,fmOpenReadWrite or FmCreate);
            Try
              FS.Position := 0;
              KAZip1.SaveToStream(FS);
            Finally
              FS.Free;
            End;
          End;
       KAZip1.Open(SaveDialog1.FileName);                                              
       Caption := 'KAZip Demo   '+SaveDialog1.FileName;
     End;
end;

procedure TForm1.KAZip1ZipChange(Sender: TObject; ChangeType: Integer);
Var
  SL : TStringList;
  X  : Integer;
  P  : Integer;
  S  : String;
  FN : String;
  DT : TDateTime;
begin
   KAZipListView1.Items.Clear;
   KAZipTreeView1.Items.Clear;
   if NOT KAZip1.IsZipFile Then Exit;
   SL := TStringList.Create;
   Try
     For X := 0 To KAZip1.Entries.Count-1 do
         Begin
           FN := KAZip1.Entries.Items[X].FileName;
           FN := StringReplace(FN,'//','\',[rfReplaceAll]);
           FN := StringReplace(FN,'/','\',[rfReplaceAll]);
           P := Pos(':\',FN);
           if P > 0 Then System.Delete(FN,1,P+1);
           SL.AddObject(FN,TObject(Integer(X)));
         End;
     KAZipTreeView1.FillTreeView(SL);
   Finally
     SL.Free;
   End;
   SL := TStringList.Create;
    Try
      For X := 0 To KAZip1.Entries.Count-1 do
          Begin
            FN := KAZip1.Entries.Items[X].FileName;
            FN := StringReplace(FN,'//','\',[rfReplaceAll]);
            FN := StringReplace(FN,'/','\',[rfReplaceAll]);
            P := Pos(':\',FN);
            if P > 0 Then System.Delete(FN,1,P+1);
            S  := '';
            S  := S+ExtractFilePath(FN)+'=';
            S  := S+ExtractFileName(FN)+#9;
            S  := S+ExtractFilePath(FN)+#9;
            DT := KAZip1.Entries.Items[X].Date;
            S  := S+DateTimeToStr(DT)+#9;
            S  := S+IntToStr(KAZip1.Entries.Items[X].SizeUncompressed)+#9;
            S  := S+IntToStr(KAZip1.Entries.Items[X].SizeCompressed)+#9;
            if KAZip1.Entries.Items[X].SizeUnCompressed > 0 Then
               S  := S+Format('%2.f',[(1-(KAZip1.Entries.Items[X].SizeCompressed/KAZip1.Entries.Items[X].SizeUnCompressed))*100])+#9
            Else
               S  := S+'0'+#9;
            S  := S+KAZip1.Entries.Items[X].Comment+#9;
            S  := S+AnsiUpperCase(IntToHex(KAZip1.Entries.Items[X].CRC32,8))+#9;
            if KAZip1.Entries.Items[X].IsEncrypted Then
               S  := S+'Encrypted'+#9
            Else
               S  := S+''+#9;
            S  := S+IntToStr(Integer(KAZip1.Entries.Items[X].Attributes));
            SL.AddObject(S,TObject(0))
          End;
      KAZipListView1.FillListView(SL);
    Finally
     SL.Free;
    End;
end;


procedure TForm1.NewZipArchive1Click(Sender: TObject);
Var
  FS : TFileStream;
begin
  if SaveDialog1.Execute Then
     Begin
       KAZip1.Close;
       FS := TFileStream.Create(SaveDialog1.FileName,fmOpenReadWrite or FmCreate);
       Try
         KAZip1.CreateZip(FS);
       Finally
         FS.Free;
       End;
       KAZip1.Open(SaveDialog1.FileName);
     End;                                                                 
end;

procedure TForm1.TestZipIntegrity1Click(Sender: TObject);
begin
  if KAZip1.Active Then
     Begin
       Try
         Form2 := TForm2.Create(Self);
         Form2.Execute(KAZip1);
       Finally
         Form2.Free;
       End;
     End;
end;

procedure TForm1.AddFiletoZip1Click(Sender: TObject);
begin
  if KAZip1.Active Then
     Begin
        if OpenDialog2.Execute Then
           Begin
             if OpenDialog2.Files.Count=1 Then
                KAZip1.Entries.AddFile(OpenDialog2.Files.Strings[0])
             Else
                KAZip1.Entries.AddFiles(OpenDialog2.Files);
           End;
        ProgressBar1.Position := 0;
     End;
end;

procedure TForm1.DeleteSelectedFilesfrpmZip1Click(Sender: TObject);
Var
 X            : Integer;
 Y            : Integer;
 SL           : TList;
 Folder       : String;
 ItemFolder   : String;
 ItemFile     : String;
begin
 if NOT KAZip1.Active Then Exit;
 If MessageBox(Handle,'Are you sure to delete selected files from archive?','Question',MB_ICONQUESTION OR MB_YESNOCANCEL) <> ID_YES Then Exit;
 if (KAZipListView1.SelCount > 0) Then
    Begin
      SL := TList.Create;
      Try
        For X := 0 To KAZipListView1.Items.Count-1 Do
          Begin
            if KAZipListView1.Items[X].Selected Then
               Begin
                  if IsFolder(KAZipListView1.Items[X]) Then
                     Begin
                       if KAZipListView1.Items[X].Caption <> '..' Then
                          Begin
                            Folder := AnsiLowerCase(KAZipTreeView1.GetCurrentFolder+KAZipListView1.Items[X].Caption+'\');
                            For Y  := 0 To KAZip1.Entries.Count-1 do
                                Begin
                                  ItemFile   := KAZip1.GetFileName(KAZip1.Entries.Items[Y].FileName);
                                  ItemFolder := KAZip1.GetFilePath(KAZip1.Entries.Items[Y].FileName);
                                  if Pos(Folder,AnsiLowerCase(ItemFolder))=1 Then
                                     Begin
                                       if SL.IndexOf(TObject(Y))=-1 Then
                                          Begin
                                            SL.Add(TObject(Y));
                                          End;
                                     End;
                                End;
                          End;
                     End
                  Else
                     Begin
                       if SL.IndexOf(KAZipListView1.Items[X].Data)=-1 Then
                          SL.Add(KAZipListView1.Items[X].Data);
                     End;
               End;
          End;
      if SL.Count > 0 Then
         Begin
           KAZip1.RemoveFiles(SL);
         End;
      Finally
        SL.Free;
      End;
      if (KAZipListView1.Filtered) Then KAZipTreeView1.SetCurrentFolder(KAZipListView1.FilterFolder);
    End;
end;

procedure TForm1.SaveSelectedFileas1Click(Sender: TObject);
begin
  if NOT KAZip1.Active Then Exit;
  if KAZipListView1.Selected <> Nil Then
    Begin
      Savedialog1.FileName := ExtractFileName(KAZipListView1.Items[KAZipListView1.Items.IndexOf(KAZipListView1.Selected)].Caption);
      if Savedialog1.Execute Then
         Begin
           if IsFolder(KAZipListView1.Selected) Then
              Begin
                if KAZipListView1.Selected.Caption <> '..' Then
                   Begin
                   End;
              End
           Else
              Begin
                KAZip1.ExtractToFile(KAZip1.Entries.Items[Integer(KAZipListView1.Selected.Data)],Savedialog1.FileName);
              End;
         End;
       ProgressBar1.Position := 0;
    End;
end;

procedure TForm1.ExtractSelectedFiles1Click(Sender: TObject);
Var
  Folder       : String;
  ItemFolder   : String;
  ItemFile     : String;
  TargetFolder : String;
  X            : Integer;
  Y            : Integer;
begin
  // BIF_RETURNONLYFSDIRS;
  // BIF_BROWSEINCLUDEFILES;
  // BIF_BROWSEFORCOMPUTER;
  // BIF_BROWSEFORPRINTER;

  if NOT KAZip1.Active Then Exit;
  if KAZipListView1.SelCount=0 Then Exit;

  if KAZipListView1.SelCount=1 Then
     Begin
       SaveSelectedFileas1Click(KAZipListView1);
       Exit;
     End;

  TargetFolder := BrowseDialog('Select Folder to extract files',BIF_RETURNONLYFSDIRS);
  if TargetFolder <> '' Then
     Begin
       For X := 0 To KAZipListView1.Items.Count-1 Do
          Begin
            if KAZipListView1.Items[X].Selected Then
               Begin
                 if IsFolder(KAZipListView1.Items[X]) Then
                    Begin
                      //SELECTED OBJECT IS FOLDER
                      if KAZipListView1.Items[X].Caption <> '..' Then
                         Begin
                            Folder := AnsiLowerCase(KAZipTreeView1.GetCurrentFolder+KAZipListView1.Items[X].Caption+'\');
                            For Y := 0 To KAZip1.Entries.Count-1 do
                                Begin
                                  ItemFile   := KAZip1.GetFileName(KAZip1.Entries.Items[Y].FileName);
                                  ItemFolder := KAZip1.GetFilePath(KAZip1.Entries.Items[Y].FileName);
                                  if Pos(Folder,AnsiLowerCase(ItemFolder))=1 Then
                                     Begin
                                       System.Delete(ItemFolder,1,Length(Folder));
                                       ForceDirectories(TargetFolder+'\'+KAZipListView1.Items[X].Caption+'\'+ItemFolder);
                                       if ItemFile <> '' Then
                                          KAZip1.Entries.Items[Y].ExtractToFile(TargetFolder+'\'+KAZipListView1.Items[X].Caption+'\'+ItemFolder+'\'+ItemFile);
                                     End;
                                End;
                         End;
                    End
                 Else
                    Begin
                      //SELECTED OBJECT IS FILE
                      KAZip1.Entries.Items[Integer(KAZipListView1.Items[X].Data)].ExtractToFile(TargetFolder+'\'+KAZipListView1.Items[X].Caption);
                    End
               End;
          End;
     End;
  ProgressBar1.Position := 0;
end;


procedure TForm1.ExtractAllFiles1Click(Sender: TObject);
Var
  TargetFolder : String;
  X            : Integer;
  Path         : String;
  FN           : String;
begin
 // BIF_RETURNONLYFSDIRS;
  // BIF_BROWSEINCLUDEFILES;
  // BIF_BROWSEFORCOMPUTER;
  // BIF_BROWSEFORPRINTER;
  TargetFolder := BrowseDialog('Select Folder to extract files',BIF_RETURNONLYFSDIRS);
  if TargetFolder <> '' Then
     Begin
       For X := 0 To KAZip1.Entries.Count-1 Do
          Begin
            if (KAZip1.Entries.Items[X].Attributes and faDirectory)=0 Then
               Begin
                  Path := StringReplace(KAZip1.Entries.Items[X].FileName,'/','\',[rfReplaceAll]);
                  FN   := ExtractFileName(Path);
                  Path := ExtractFilePath(Path);
                  if Path <> '' Then
                     Begin
                       ForceDirectories(TargetFolder+'\'+Path);
                       KAZip1.Entries.Items[X].ExtractToFile(TargetFolder+'\'+Path+FN);
                     End
                   Else
                     Begin
                       KAZip1.Entries.Items[X].ExtractToFile(TargetFolder+'\'+FN);
                     End;
               End;
          End;
     End;
  ProgressBar1.Position := 0;
end;

procedure TForm1.SelectAll1Click(Sender: TObject);
begin
  KAZipListView1.SelectAll;
end;

procedure TForm1.DelesectAll1Click(Sender: TObject);
Var
  X : Integer;
begin
 For X := 0 To KAZipListView1.Items.Count-1 do
     Begin
       KAZipListView1.Items[X].Selected := False;
     End;
end;

procedure TForm1.InvertSelection1Click(Sender: TObject);
Var
  X : Integer;
begin
 For X := 0 To KAZipListView1.Items.Count-1 do
     Begin
       KAZipListView1.Items[X].Selected := NOT KAZipListView1.Items[X].Selected;
     End;
end;


procedure TForm1.Insertfileinselectedfolder1Click(Sender: TObject);
Var
  Node : TTreeNode;
  S    : String;
begin
  Node := KAZipTreeView1.Selected;
  If Node <> Nil Then
     Begin
       S := '';
       While Node.Parent <> Nil do
          Begin
            S    := Node.Text+'\'+S;
            Node := Node.Parent;
          End;
       If OpenDialog2.Execute Then
          Begin
            KAZip1.Entries.AddFile(OpenDialog2.FileName,S+ExtractFileName(OpenDialog2.FileName));
          End;
       ProgressBar1.Position := 0;
     End;
End;

procedure TForm1.Deletefolder1Click(Sender: TObject);
Var
  Node : TTreeNode;
  X    : Integer;
  SL   : TList;
  Sel  : TTreeNode;
  S    : String;
  Flt  : Boolean;
begin
  If MessageBox(Handle,'Are you sure to delete selected folder from archive?','Question',MB_ICONQUESTION OR MB_YESNOCANCEL) <> ID_YES Then Exit;
  Node := KAZipTreeView1.Selected;
  If (Node <> Nil) And (Node.Parent <> Nil) Then
     Begin
       While Node.Parent <> Nil do
          Begin
            S    := Node.Text+'\'+S;
            Node := Node.Parent;
          End;
       S                       := AnsiLowerCase(S);
       SL                      := TList.Create;
       Flt                     := KAZipListView1.Filtered;
       KAZipListView1.Visible  := False;
       KAZipListView1.Filtered := False;
       Try
        For X := 0 To KAZip1.Entries.Count-1 Do
          Begin
             if Pos(S,ToDosName(AnsiLowerCase(KAZip1.Entries.Items[X].FileName))) = 1 Then
                Begin
                  SL.Add(Pointer(X));
                End;
          End;
       if SL.Count > 0 Then KAZip1.RemoveFiles(SL);
       Finally
         KAZipListView1.Filtered := Flt;
         KAZipListView1.Visible  := True;
         SL.Free;
       End;
       Sel                       := KAZipTreeView1.Selected;
       KAZipTreeView1.Selected := Nil;
       if (Sel=Nil) And (KAZipTreeView1.Items.Count > 0) Then Sel := KAZipTreeView1.Items[0];
       KAZipTreeView1.Selected := Sel;
     End;
end;


procedure TForm1.LargeIcons1Click(Sender: TObject);
begin
  KAZipListView1.ViewStyle := vsIcon;
end;

procedure TForm1.SmallIcons1Click(Sender: TObject);
begin
  KAZipListView1.ViewStyle := vsSmallIcon;
end;

procedure TForm1.List1Click(Sender: TObject);
begin
  KAZipListView1.ViewStyle := vsList;
end;

procedure TForm1.Report1Click(Sender: TObject);
begin
 KAZipListView1.ViewStyle := vsReport;
end;

procedure TForm1.Edit1KeyPress(Sender: TObject; var Key: Char);
begin
  if Key=#13 Then
     Begin
       Key := #0;
       Button1.Click;
     End;
end;

procedure TForm1.Button1Click(Sender: TObject);
begin
  KAZipListView1.FilterWildcard := Edit1.Text;
end;

procedure TForm1.Button2Click(Sender: TObject);
Var
  X : Integer;
begin
  if Edit1.Text='*.*' Then
     Begin
       For X := 0 To KAZipListView1.Items.Count-1 do
            Begin
              KAZipListView1.Items.Item[X].Selected := True;
            End;
     End
  Else
     Begin
        For X := 0 To KAZipListView1.Items.Count-1 do
            Begin
              if MatchesMask(KAZipListView1.Items.Item[X].Caption,Edit1.Text) Then
                 KAZipListView1.Items.Item[X].Selected := True;
            End;
     End;
end;

procedure TForm1.Button3Click(Sender: TObject);
Var
  X : Integer;
begin
  if Edit1.Text='*.*' Then
     Begin
       For X := 0 To KAZipListView1.Items.Count-1 do
            Begin
              KAZipListView1.Items.Item[X].Selected := False;
            End;
     End
  Else
     Begin
        For X := 0 To KAZipListView1.Items.Count-1 do
            Begin
              if MatchesMask(KAZipListView1.Items.Item[X].Caption,Edit1.Text) Then
                 KAZipListView1.Items.Item[X].Selected := False;
            End;
     End;
end;

procedure TForm1.Find1Click(Sender: TObject);
begin
  Form3 := TForm3.CreateParented(Self.Handle);
  Form3.Show;
end;


procedure TForm1.Edit2KeyPress(Sender: TObject; var Key: Char);
begin
if Key=#13 Then
     Begin
       Key := #0;
       Button4.Click
     End;
end;

function TForm1.Matches(const Filename, Mask: string): Boolean;
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

procedure TForm1.Button4Click(Sender: TObject);
Var
  X     : Integer;
  Start : Integer;
  LF    : Integer;
  S     : String;
  Found : Boolean;
begin
  if Edit2.Text<>'' Then
     Begin
      S     := Edit2.Text;
      Start := 0;
      LF    := 0;
      if KAZipListView1.Selected <> Nil Then
         Begin
           LF   := KAZipListView1.Selected.Index;
           KAZipListView1.ClearSelection;
           For X := LF+1 To KAZipListView1.Items.Count-1 do
               Begin
                  if Matches(KAZipListView1.Items.Item[X].Caption,S) Then
                     Begin
                       KAZipListView1.Items[X].Selected := True;
                       KAZipListView1.Items[X].MakeVisible(False);
                       KAZipListView1.SetFocus;
                       Edit2.SetFocus;
                       Exit;
                     End;
              End;
           if Matches(KAZipListView1.Items.Item[LF].Caption,S) Then
              Begin
                 Start := Integer(KAZipListView1.Items[LF].Data);
                 If Start < KAZip1.Entries.Count-1 Then
                    Inc(Start)
                 Else
                    Start := 0;
              End;
         End;
      Found := False;
      For X := Start To KAZip1.FileNames.Count-1 do
          Begin
            if Matches(ExtractFileName(KAZip1.FileNames.Strings[X]),S)  Then
               Begin
                 KAZipTreeView1.SetCurrentFolder(ExtractFilePath(KAZip1.FileNames.Strings[X]));
                 Found := True;
                 System.Break;
               End;
          End;
      if Not Found Then
         Begin
           For X := 0 To KAZip1.FileNames.Count-1 do
               Begin
                  if Matches(ExtractFileName(KAZip1.FileNames.Strings[X]),S) Then
                     Begin
                       KAZipTreeView1.SetCurrentFolder(ExtractFilePath(KAZip1.FileNames.Strings[X]));
                       System.Break;
                     End;
               End;
         End;
      For X := 0 To KAZipListView1.Items.Count-1 do
          Begin
            if Matches(KAZipListView1.Items.Item[X].Caption,S) Then
               Begin
                 KAZipListView1.Items[X].Selected := True;
                 KAZipListView1.Items[X].MakeVisible(False);
                 KAZipListView1.SetFocus;
                 System.Break;
               End;
          End;
       Edit2.SetFocus;
     End;
end;

end.
