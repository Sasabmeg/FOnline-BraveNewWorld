unit KAZipTreeView;

interface

uses
  Windows,
  SysUtils,
  Classes,
  Controls,
  ComCtrls;

type
  TKAZipTreeView = class(TTreeView)
  private
    { Private declarations }
  protected
    { Protected declarations }
    RootNode : TTreeNode;
    FShowFiles: Boolean;
    Function  FindRootNode(Dir:String;Create:Boolean):TTreeNode;
    Function  FindSubNode(Node:TTreeNode;Dir:String;Create:Boolean):TTreeNode;
    procedure SetShowFiles(const Value: Boolean);
  public
    { Public declarations }
    Procedure FillTreeView(DirList:TStrings);
    Procedure SetCurrentFolder(Folder:string);
    Function  GetCurrentFolder:String;
  published
    { Published declarations }
    Property ShowFiles   : Boolean Read FShowFiles Write SetShowFiles;
    Property Items         Stored False;
  end;

procedure Register;

implementation

procedure Register;
begin
  RegisterComponents('KA', [TKAZipTreeView]);
end;

{ TKAZipTreeView }

function TKAZipTreeView.FindRootNode(Dir: String; Create:Boolean): TTreeNode;
begin
  Result := RootNode.GetFirstChild;
  While Result <> Nil Do
    Begin
      if AnsiCompareText(Result.Text,Dir)=0 Then
         Begin
           Exit;
         End;
      Result := RootNode.GetNextChild(Result);
    End;
  if Create Then
     Result := Items.AddChildObject(RootNode,Dir,TObject(Integer(-1)))
  Else
     Result := Nil;
end;

function TKAZipTreeView.FindSubNode(Node: TTreeNode; Dir: String;Create:Boolean): TTreeNode;
begin
  Result := Node.GetFirstChild;
  While Result <> Nil Do
    Begin
      if AnsiCompareText(Result.Text,Dir)=0 Then
         Begin
           Exit;
         End;
      Result := Node.GetNextChild(Result);
    End;
  if Create Then
      Result := Items.AddChildObject(Node,Dir,TObject(Integer(-1)))
  Else
      Result := Nil;
end;

procedure TKAZipTreeView.FillTreeView(DirList: TStrings);
Var
  SL       : TStringList;
  X        : Integer;
  L1       : Integer;
  L2       : Integer;
  P        : Integer;
  Level    : Integer;
  NoChange : Boolean;
  S        : String;
  Dir      : String;
  Node     : TTreeNode;
begin
  Items.Clear;
  LockWindowUpdate(Handle);
  SL := TStringList.Create;
  Try
    SL.Assign(TStringList(DirList));
    Repeat
      NoChange := True;
      if SL.Count > 1 Then
         Begin
           For X := 0 To SL.Count-2 do
               Begin
                 L1 := Length(SL.Strings[X]);
                 L2 := Length(SL.Strings[X+1]);
                 if L2 > L1 Then
                    Begin
                      SL.Exchange(X,X+1);
                      NoChange := False;
                    End;
               End;
         End;
    Until NoChange;
    RootNode := Items.AddChildObject(Nil,'Archive',TObject(Integer(-2)));
    Node     := Nil;
    For X := 0 To SL.Count-1 do
        Begin
          S     := SL.Strings[X];
          Level := -1;
          P     := Pos('\',S);
          While P > 0 Do
            Begin
              Dir := Copy(S,1,P-1);
              System.Delete(S,1,P);
              P   := Pos('\',S);
              if Level=-1 Then
                 Begin
                   Node := FindRootNode(Dir,True);
                 End
              Else
                 Begin
                   Node := FindSubNode(Node,Dir,True);
                 End;
               Inc(Level);
            End;
          If (FShowFiles) And (S <> '') Then
             Begin
               Inc(Level);
               if Level=0 Then
                  Begin
                    Node := Items.AddChildObject(RootNode,S,SL.Objects[X]);
                  End
               Else
                  Begin
                    Node := Items.AddChildObject(Node,S,SL.Objects[X]);
                  End;
             End;
        End;
  Finally
    SL.Free;
    Items.AlphaSort(True);
    LockWindowUpdate(0);
  End;
  RootNode.Expand(False);
end;



procedure TKAZipTreeView.SetShowFiles(const Value: Boolean);
begin
  FShowFiles := Value;
end;

procedure TKAZipTreeView.SetCurrentFolder(Folder: string);
Var
  S     : String;
  Dir   : String;
  P     : Integer;
  Node  : TTreeNode;
  Level : Integer;
begin
  S     := Folder;
  Level := -1;
  Node  := Nil; 
  P     := Pos('\',S);
  if P=0 Then
     Begin
       RootNode.Selected := True;
       RootNode.Expand(False);
       RootNode.MakeVisible;
     End
 Else
 While P > 0 Do
    Begin
      Dir := Copy(S,1,P-1);
      System.Delete(S,1,P);
      P   := Pos('\',S);
      if Level=-1 Then
         Begin
           Node := FindRootNode(Dir,False);
         End
      Else
         Begin
           Node := FindSubNode(Node,Dir,False);
         End;
      if Node <> Nil Then
         Begin
           Node.Selected := True;
           Node.Expand(False);
           Node.MakeVisible;
           Inc(Level);
         End
      Else
         Begin
           RootNode.Selected := True;
           RootNode.Expand(False);
           RootNode.MakeVisible;
         End;
    End;
end;

Function TKAZipTreeView.GetCurrentFolder:String;
Var
  Node : TTreeNode;
Begin
  Result := '';
  if Selected <> Nil Then
     Begin
       Node := Selected;
       While Node.Parent <> Nil do
          Begin
            Result    := Node.Text+'\'+Result;
            Node := Node.Parent;
          End;
     End;
End;

end.
