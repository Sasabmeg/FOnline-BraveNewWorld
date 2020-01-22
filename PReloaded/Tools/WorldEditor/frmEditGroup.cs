using System;
using System.Windows.Forms;

namespace WorldEditor
{
    public partial class frmEditGroup : Form
    {
        public EncounterZoneGroup group;

        public frmEditGroup()
        {
            InitializeComponent();
        }

        private void frmEditGroup_Load(object sender, EventArgs e)
        {
            this.Text = "Editing '" + group.Name + "'";
            numEncounterChance.Value = group.Quantity;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            group.Quantity = Decimal.ToInt32(numEncounterChance.Value);
            this.Close();
        }
    }
}
