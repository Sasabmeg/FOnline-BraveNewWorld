using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace WorldEditor.ProtoEditor
{
    public partial class frmCritterProtoList : Form
    {
        ProtoCritter copiedCritter = null;

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

        public frmCritterProtoList()
        {
            InitializeComponent();
        }

        public void RefreshList()
        {
            this.protoList.SetObjects(ProtoManager.Protos);
            this.protoList.Refresh();
        }

        private void frmCritterProtoList_Load(object sender, EventArgs e)
        {
            RefreshList();
            this.protoList.Sort(this.col1, SortOrder.Ascending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void protoList_DoubleClick(object sender, EventArgs e)
        {
            Object obj = protoList.SelectedObject;
            if (obj is KeyValuePair<int, ProtoCritter>)
            {
                KeyValuePair<int, ProtoCritter> pair = (KeyValuePair<int, ProtoCritter>)obj;
                frmProtoCritterEditor form = new frmProtoCritterEditor(this,pair.Key);
                form.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProtoManager.Save();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ArrayList objs = (ArrayList)protoList.SelectedObjects;
            foreach (Object obj in objs)
            if (obj is KeyValuePair<int, ProtoCritter>)
            {
                KeyValuePair<int, ProtoCritter> pair = (KeyValuePair<int, ProtoCritter>)obj;
                ProtoManager.Remove(pair.Key);
            }
            if (objs.Count>0)RefreshList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rdbAssignFree.Checked)
            {
                int newProto = ProtoManager.AddProto();
                RefreshList();
                frmProtoCritterEditor form = new frmProtoCritterEditor(this, newProto, true);
                form.Show();
            }
            else
            {
                if (ProtoManager.AddProto((int)numPid.Value))
                {
                    RefreshList();
                    frmProtoCritterEditor form = new frmProtoCritterEditor(this, (int)numPid.Value, true);
                    form.Show();
                }
            }
        }

        private string getCopiedText()
        {
            return copiedCritter.Name + "(" + copiedCritter.Id + ") copied to clipboard, use ctrl+v to clone it.";
        }

        private void protoList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Object obj = protoList.SelectedObject;
                if (obj != null)
                {
                    var kvp = (KeyValuePair<int, ProtoCritter>)obj;
                    copiedCritter = (ProtoCritter)kvp.Value;
                    lblCopied.Text = getCopiedText();
                }
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                ProtoCritter cr = copiedCritter.DeepCopy();
                ProtoManager.AddProto(cr);
                RefreshList();
                lblCopied.Text = getCopiedText() + " Cloned into PID " + cr.Id;
                e.SuppressKeyPress = true;
            }
        }
    }
}
