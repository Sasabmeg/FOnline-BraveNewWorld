using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WorldEditor.ProtoEditor
{
    public partial class frmProtoCritterRawEditor : Form
    {
        private ProtoCritter pc;
        private frmProtoCritterEditor parent;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams result = base.CreateParams;
                if (Environment.OSVersion.Platform == PlatformID.Win32NT
                    && Environment.OSVersion.Version.Major >= 6)
                {
                    result.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                }

                return result;
            }
        }
        
        public frmProtoCritterRawEditor()
        {
            InitializeComponent();
        }
        public frmProtoCritterRawEditor(frmProtoCritterEditor parent, ProtoCritter pc)
        {
            this.pc = pc;
            this.parent = parent;
            InitializeComponent();
        }
        private void LoadRawData()
        {
            List<string> lines = new List<string>();
            for (int i = 0, j = this.pc.Params.Length; i < j;i++ )
            {
                if (this.pc.Params[i] == 0) continue;
                string name = ParamsDefines.GetParamName(i);
                if (name == "") name = "Param" + i;
                lines.Add(name + "=" + this.pc.Params[i]);
            }
            this.rtbData.Lines = lines.ToArray();
        }
        private void frmProtoCritterRawEditor_Load(object sender, EventArgs e)
        {
            LoadRawData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProtoCritter newpc = this.pc.DeepCopy();
            if (newpc.Parse(this.rtbData.Lines.ToList(), ProtoManager.CorrectFile(newpc.Savefile)))
            {
                newpc.Id = pc.Id;
                this.pc = newpc;
                parent.pc = newpc;
                ProtoManager.Protos[newpc.Id] = newpc;
                this.parent.LoadProto();
                this.parent.parent.RefreshList();
                this.Close();
            }
        }
    }
}
