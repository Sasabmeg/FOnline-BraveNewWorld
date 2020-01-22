using System.Windows.Forms;
using FOCommon.Items;

namespace ObjectEditor
{
    public partial class frmClone : Form
    {
        public bool clickedOk { get; set; }
        public ushort protoId { get; set; }

        public frmClone(ItemProto proto, ushort suggestedPid)
        {
            InitializeComponent();
            this.Text += string.Format("{0} ({1})", proto.Name, proto.ProtoId);
            this.numPid.Maximum = ushort.MaxValue;
            this.numPid.Value = suggestedPid;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            clickedOk = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void numPid_ValueChanged(object sender, System.EventArgs e)
        {
            this.protoId = (ushort)numPid.Value;
        }


    }
}
