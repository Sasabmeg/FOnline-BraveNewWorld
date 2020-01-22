using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using FOCommon.Worldmap.EncounterGroup;

namespace WorldEditor
{
    public partial class frmAddGroup : Form
    {
        public List<EncounterZoneGroup> SelectedGroups = new List<EncounterZoneGroup>();
        public List<EncounterZoneGroup> ExistingGroups;
        public int EncounterChance;

        public bool IsDup(EncounterGroup Group)
        {
            if (ExistingGroups == null)
                return false;

            foreach (EncounterZoneGroup egrp in ExistingGroups)
                if (egrp.Name == Group.Name)
                    return true;
            return false;
        }

        public frmAddGroup(List<EncounterGroup> Groups, List<EncounterZoneGroup> ExistingGroups)
        {
            this.ExistingGroups = ExistingGroups;
            InitializeComponent();
            foreach(EncounterGroup ngrp in Groups)
                if(!IsDup(ngrp))
                    lstGroups.AddObject(ngrp);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ArrayList SGroups = (ArrayList)lstGroups.SelectedObjects;
            SGroups.Cast<EncounterGroup>();
            foreach (EncounterGroup group in SGroups.ToArray())
            {
                EncounterZoneGroup NewGroup = new EncounterZoneGroup();
                NewGroup.Name = group.Name;
                NewGroup.Quantity = Decimal.ToInt32(numEncounterQuantity.Value);
                SelectedGroups.Add(NewGroup);
            }

            EncounterChance = Decimal.ToInt32(numEncounterQuantity.Value);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
