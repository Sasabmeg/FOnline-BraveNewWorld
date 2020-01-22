using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using FOCommon.WMLocation;

namespace WorldEditor
{
    public partial class frmSpecialEncounters : Form
    {
        List<Location> Locations;
        List<SpecialEncounter> SpecialEncounters = new List<SpecialEncounter>();

        public void LoadSpecialEncounters()
        {
            List<String> Lines = new List<string>(File.ReadAllLines(@"./specialencounters.fowm"));
            for (int i=0;i<Lines.Count;i++)
            {
                string[] SepChunks = { "|||" };
                string[] SepConRes = { "||" };
                string[] Parts = Lines[i].Split(SepChunks, StringSplitOptions.None);
                if (Parts.Length != 3)
                {
                    Message.Show("Failed to parse special encounters, on line " + (i + 1), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string[] Properties = Parts[0].Split('|');

                Location Loc=null;
                foreach(Location LLoc in Locations)
                    if(LLoc.Pid==Int32.Parse(Properties[2]))
                        Loc=LLoc;

                SpecialEncounter se = new SpecialEncounter(Properties[0], Properties[1], Loc,100/Int32.Parse(Properties[3]));

                if (Parts[1].Length > 0)
                {
                    string[] Conditions = Parts[1].Split(SepConRes, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string Condition in Conditions)
                    {
                        string[] CondProperties = Condition.Split(',');
                        se.AddCondition((ConditionType)Int32.Parse(CondProperties[0]), CondProperties[1], CondProperties[2], Int32.Parse(CondProperties[3]));
                    }
                }

                if (Parts[2].Length > 0)
                {
                    string[] Results = Parts[2].Split(SepConRes, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string Result in Results)
                    {
                        string[] ResultProperties = Result.Split(',');
                        se.AddResult((ConditionType)Int32.Parse(ResultProperties[0]), ResultProperties[1], ResultProperties[2], Int32.Parse(ResultProperties[3]));
                    }
                }

                this.SpecialEncounters.Add(se);
            }
        }

        public frmSpecialEncounters(List<Location> Locations)
        {
            InitializeComponent();
            this.Locations = Locations;
            LoadSpecialEncounters();
            lstSpecialEncounters.SetObjects(SpecialEncounters);
        }

        private void frmSpecialEncounters_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmEditSpecialEncounter EditEncounter = new frmEditSpecialEncounter(null, Locations);
            EditEncounter.ShowDialog();
            if (EditEncounter.Save)
            {
                SpecialEncounters.Add(EditEncounter.Encounter);
                lstSpecialEncounters.SetObjects(SpecialEncounters);
            }
        }
    }
}
