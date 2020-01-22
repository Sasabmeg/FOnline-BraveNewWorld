using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ScriptHost.Forms
{

    public partial class frmExtensionList : Form
    {
        List<ExtensionEntry> Entries;

        string ScriptPath;

        public frmExtensionList(string Path) // Config.PathEditorScript
        {
            this.ScriptPath = Path;
            InitializeComponent();
        }

        private void frmExtensionList_Load(object sender, EventArgs e)
        {
            if (!File.Exists(ScriptPath + "scripts.lst"))
            {
                MessageBox.Show("Can't find " + ScriptPath + "scripts.lst");
                return;
            }

            Entries = new List<ExtensionEntry>();
            foreach (String line in File.ReadAllLines(ScriptPath + "scripts.lst"))
            {
                if(line.Length==0 || (line.Length>1 && line[0]=='/' && line[1]=='/'))
                    continue;
                if (line[0] == '@') Entries.Add(new ExtensionEntry(line.Remove(0, 1), true));
                else Entries.Add(new ExtensionEntry(line, false));
            }
            lstExtensions.SetObjects(Entries);
            foreach (String file in Directory.GetFiles(ScriptPath, "*.cs"))
                cmbAdd.Items.Add(Path.GetFileName(file));
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<String> lines = new List<string>();
            lines.Add("// Scripts are loaded in this order");
            lines.Add("// @ = enabled");
            foreach (ExtensionEntry ent in Entries)
                lines.Add((ent.Enabled ? "@" : "") + ent.FileName);
            File.WriteAllLines((ScriptPath + "scripts.lst"), lines.ToArray());
            this.Close();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lstExtensions.SelectedItem == null) return;
            int index = lstExtensions.SelectedItem.Index;
            if (index == 0) return;
            var item = Entries[index];
            Entries.RemoveAt(index--);
            Entries.Insert(index, item);
            lstExtensions.SetObjects(Entries);
            lstExtensions.SelectObject(item);
            lstExtensions.Select();
        }

        private void lstExtensions_BeforeSorting(object sender, BrightIdeasSoftware.BeforeSortingEventArgs e)
        {
            e.Canceled = true;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (lstExtensions.SelectedItem == null) return;
            int index = lstExtensions.SelectedItem.Index;
            if (index == Entries.Count-1) return;
            var item = Entries[index];
            Entries.RemoveAt(index++);
            Entries.Insert(index, item);
            lstExtensions.SetObjects(Entries);
            lstExtensions.SelectObject(item);
            lstExtensions.Select();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Entries.Add(new ExtensionEntry(cmbAdd.Text, true));
            lstExtensions.SetObjects(Entries);
        }

        private void lstExtensions_KeyUp(object sender, KeyEventArgs e)
        {
            if (lstExtensions.SelectedIndex == -1)
                return;
            if (e.KeyCode == Keys.Delete)
            {
                Entries.RemoveAt(lstExtensions.SelectedIndex);
                lstExtensions.SetObjects(Entries);
            }
        }
    }

    class ExtensionEntry
    {
        public string FileName { get; set; }
        public bool Enabled { get; set; }

        public ExtensionEntry(string FileName, bool Enabled) { this.FileName = FileName; this.Enabled = Enabled; }
    }
}
