using System.Collections.Generic;
using System.Windows.Forms;

using FOCommon;

namespace WorldEditor.ProtoEditor
{
    public class ProtoCritter : ISelectable
    {
        public int Id { get; set; }
        public int[] Params = new int[1000];
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Savefile {get; set;}

        public override string ToString()
        {
            return "-- " + Name + " -- " + "\n" +
                FOCommon.Utils.ToStringProp("Pid", Id.ToString()) +
                FOCommon.Utils.ToStringProp("Name", Name) +
                FOCommon.Utils.ToStringProp("Desc", Desc) +
                FOCommon.Utils.ToStringProp("SaveFile", Savefile);
        }

        public ProtoCritter()
        {
            Id = 0;
            for (int i = 0, j = Params.Length; i < j; i++) Params[i] = 0;
            Name = "";
            Desc = "";
            Savefile = "";
        }
        public ProtoCritter(bool defaultfill)
        {
            Id = 0;
            for (int i = 0; i < 7; i++) Params[i] = 5;
            for (int i = 7, j = Params.Length; i < j; i++) Params[i] = 0;
            Params[Consts.ST_DAMAGE_TYPE] = 1;
            Name = "";
            Desc = "";
            Savefile = ProtoManager.FileNames[0];
        }
        public void ClearExtra()
        {
            for (int i = Consts.PERK_BEGIN; i <= Consts.PERK_END; i++)
                Params[i]=0;

            for (int i = Consts.MODE_BEGIN; i <= Consts.MODE_END; i++)
                Params[i]=0;

            for (int i = Consts.TRAIT_BEGIN; i <= Consts.TRAIT_END; i++)
                Params[i] = 0;
        }
        public bool Parse(List<string> lines, string _savefile)
        {
            Id = 0;
            for (int i=0,j=Params.Length;i<j;i++) Params[i]=0;

            Savefile = "";
            foreach (string line in lines)
            {
                if (line == "") continue;
                string[] splittedLine = line.Split('=');
                if (splittedLine.Length != 2)
                {
                    MessageBox.Show("ProtoCritter::Parse: failed to parse a line: "+line+".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (splittedLine[0] == "Pid")
                {
                    this.Id = int.Parse(splittedLine[1]);
                    continue;
                }
                int param = ParamsDefines.GetParam(splittedLine[0]);
                if (param == -1)
                {
                    MessageBox.Show("ProtoCritter::Parse: failed to parse a line: " + line + ". No param found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                Params[param] = int.Parse(splittedLine[1]);
            }
            this.Savefile = _savefile;
            return true;
        }
        public ProtoCritter DeepCopy()
        {
            ProtoCritter newpc = new ProtoCritter();
            newpc.Id = this.Id;
            for (int i = 0, j = Params.Length; i < j; i++) newpc.Params[i] = this.Params[i];
            newpc.Name = this.Name;
            newpc.Desc = this.Desc;
            newpc.Savefile = this.Savefile;
            return newpc;
        }
    }
}
