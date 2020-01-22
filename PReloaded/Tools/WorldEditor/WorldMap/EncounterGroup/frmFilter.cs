using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using FOCommon.Items;
using FOCommon.Parsers;

using WorldEditor.Worldmap.EncounterGroup;

namespace WorldEditor.NZone.EncounterGroup
{
    public partial class frmFilter : Form
    {
        private DefineParser DefineParser;
        public Filtering Filter { get; set; }

        public frmFilter(DefineParser DefineParser, Filtering Filter)
        {
            InitializeComponent();
            this.Filter = Filter;
            if (Filter == null)
                this.Filter = new Filtering();
            this.DefineParser = DefineParser;
            List<Item> items = ItemPid.GetItems();
            foreach (Item item in items)
                cmbItem.Items.Add(item.Define);
            cmbPerk.Items.AddRange(DefineParser.GetDefinesByPrefix("PE_").Keys.ToArray<String>());

            cmbItem.Sorted = true;
            cmbPerk.Sorted = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Filter.Enabled = chkEnableFilter.Checked;
            Filter.EnabledNpc = chkNpc.Checked;
            Filter.EnabledItem = chkItem.Checked;
            Filter.EnabledPerk = chkPerk.Checked;
            Filter.NpcPid = (int)numNPCPID.Value;
            Filter.ItemPid = (int)ItemPid.GetPid(cmbItem.Text);
            Filter.PerkIndex = (int)DefineParser.Defines[cmbPerk.SelectedItem.ToString()];
            this.Close();
        }
    }
}
