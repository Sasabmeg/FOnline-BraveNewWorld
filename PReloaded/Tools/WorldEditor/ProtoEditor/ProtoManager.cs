using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using FOCommon.Parsers;

namespace WorldEditor.ProtoEditor
{
    public static class ProtoManager
    {
        private static Dictionary<int, string> ProtoNames = new Dictionary<int, string>();
        public static Dictionary<int,ProtoCritter> Protos = new Dictionary<int,ProtoCritter>();
        public static string[] BasicFileNames;
        public static string[] FileNames;
        public static bool Initialized = false;
        private static string CritterProtoString = "[Critter proto]";

        public static bool Init(string[] _basicFileNames, string[] _fileNames, MSGParser DLGParser)
        {
            ProtoNames = DLGParser.GetData();

            if (_fileNames.Length == 0)
            {
                Message.Show("ProtoManager::Init: no extra files specified.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach (string shortfilename in _basicFileNames)
            {
                string filename = Config.PathCritterProtoDir + shortfilename;
                if (!File.Exists(filename))
                {
                    Message.Show("ProtoManager::Init: " + filename + " not found.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            foreach (string shortfilename in _fileNames)
            {
                string filename = Config.PathCritterProtoDir + shortfilename;
                if (!File.Exists(filename))
                {
                    Message.Show("ProtoManager::Init: " + filename + " not found.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            BasicFileNames = _basicFileNames;
            FileNames = _fileNames;
            return true;
        }

        public static bool Load()
        {
            if (BasicFileNames == null)
                return false;

            foreach (string filename in BasicFileNames)
            {
                if (!LoadFile(filename))
                {
                    Message.Show("ProtoManager::Load: failed to load " + Config.PathCritterProtoDir + filename, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                };
            }
            foreach (string filename in FileNames)
            {
                if (!LoadFile(filename))
                {
                    Message.Show("ProtoManager::Load: failed to load " + Config.PathCritterProtoDir + filename, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                };
            }
            Initialized = true;
            return true;
        }
        private static bool LoadFile(string filename)
        {

            List<string> lines = new List<string>(File.ReadAllLines(Config.PathCritterProtoDir+filename));
            int len = lines.Count;

            int current = 0;
            while (current < len && String.Compare(lines[current],0, CritterProtoString,0,CritterProtoString.Length) != 0)
                current++;

            if (current == len) return true;
            current++;
            List<string> block = new List<string>();
            int id=0;
            while (current < len)
            {
                block.Add(lines[current]);
                current++;
                if (current<len && String.Compare(lines[current],0, CritterProtoString,0,CritterProtoString.Length) == 0)
                {
                    id++;
                    int pid = 0;
                    foreach (string line in block)
                    {
                        if (line.Substring(0, 4) == "Pid=")
                        {
                            pid = int.Parse(line.Substring(4,line.Length-4));
                            break;
                        }
                    }
                    if (pid == 0)
                    {
                        Message.Show("ProtoManager::LoadFile: failed to parse block number " + id+" (no PID)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (!Protos.ContainsKey(pid))
                    {
                        ProtoCritter pc = new ProtoCritter();
                        pc.Name = ProtoNames[pid * 10];
                        if(ProtoNames.ContainsKey((pid * 10)+1))
                             pc.Desc=ProtoNames[(pid * 10)+1];
                        Protos.Add(pid, pc);   
                    }
                    if (!Protos[pid].Parse(block, filename))
                    {
                        Message.Show("ProtoManager::LoadFile: failed to parse block with PID " + pid, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    block.Clear();
                    current++;
                }
            }


            int rpid = 0;
            foreach (string line in block)
            {
                if (line.Substring(0, 4) == "Pid=")
                {
                    rpid = int.Parse(line.Substring(4, line.Length - 4));
                    break;
                }
            }
            if (rpid == 0)
            {
                MessageBox.Show("ProtoManager::LoadFile: failed to parse block number " + id + " (no PID)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Protos.ContainsKey(rpid))
            {
                ProtoCritter pc = new ProtoCritter();
                Protos.Add(rpid, pc);
            }
            if (!Protos[rpid].Parse(block, filename))
            {
                MessageBox.Show("ProtoManager::LoadFile: failed to parse block with PID " + rpid, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static string CorrectFile(string filename)
        {
            foreach (string name in FileNames) if (name == filename) return filename;
            return FileNames[0];
        }
        public static int CorrectFileIndex(string filename)
        {
            for (int i = 0, j = FileNames.Length; i < j;i++ ) if (FileNames[i] == filename) return i;
            return 0;
        }
        public static bool CheckFile(string filename)
        {
            foreach (string name in BasicFileNames) if (name == filename) return false;
            return true;
        }
        
        public static void Save()
        {
            Dictionary<string, List<string>> files = new Dictionary<string, List<string>>();
            foreach (KeyValuePair<int, ProtoCritter> pair in Protos)
            {
                if (CheckFile(pair.Value.Savefile))
                {
                    string savefile = pair.Value.Savefile;
                    if (!files.ContainsKey(savefile)) files[savefile] = new List<string>();
                    files[savefile].Add("[Critter proto]");
                    files[savefile].Add("Pid="+pair.Key);
                    for (int i = 0, j = pair.Value.Params.Length; i < j; i++)
                    {
                        if (pair.Value.Params[i]!=0)
                        {
                            string name=ParamsDefines.GetParamName(i);
                            if (name == "")
                            {
                                MessageBox.Show("ProtoManager::Save: failed to save PID " + pair.Key+": Param "+i+" name unknown. Saving aborted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            files[savefile].Add(name + "=" + pair.Value.Params[i]);
                        }
                    }
                    files[savefile].Add("");
                }
            }
            foreach (KeyValuePair<string, List<string>> pair in files)
            {
                StreamWriter sw = new StreamWriter(Config.PathCritterProtoDir+pair.Key);
                foreach (string line in pair.Value) sw.Write(line+"\n");
                sw.Close();
            }
        }

        public static void Remove(int n)
        {
            Protos.Remove(n);
        }

        public static int GetFreeNumber()
        {
            int free = 1;
            List<int> numbers = new List<int>();
            foreach (KeyValuePair<int, ProtoCritter> pair in Protos) numbers.Add(pair.Key);
            numbers.Sort();
            for (int i = 0, j = numbers.Count; i < j; i++, free++) if (numbers[i] != free) break;
            return free;
        }

        public static bool AddProto(ProtoCritter cr)
        {
            int free = GetFreeNumber();
            cr.Id = free;
            Protos[free] = cr;
            return true;
        }

        public static int AddProto()
        {
            ProtoCritter proto = new ProtoCritter(true);
            int free = GetFreeNumber();
            proto.Id = free;
            proto.Savefile = FileNames[0];
            Protos[free] = proto;
            return free;
        }
        public static bool AddProto(int n)
        {
            if (Protos.ContainsKey(n))
            {
                MessageBox.Show("ProtoManager::AddProto: failed to save PID " + n + ": already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            ProtoCritter proto = new ProtoCritter(true);
            proto.Id = n;
            proto.Savefile = FileNames[0];
            Protos[n] = proto;
            return true;
        }
        public static void SaveProtoAs(ProtoCritter pc, int n)
        {
            Protos[n] = pc;
        }
        public static void FillFilenames(ComboBox box)
        {
            box.DataSource = FileNames;
        }
    }
}
