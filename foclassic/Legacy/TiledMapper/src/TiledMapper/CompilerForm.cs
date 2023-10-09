using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TiledMapper
{
    public partial class CompilerForm : Form
    {
        public bool OK { get; private set; }
        public CompilerForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            OK = true;
            Config.CurrentPreset = cbCurrent.SelectedItem.ToString();
            Config.PresetsPath = tbPath.Text;
            Config.NeverShowHeaderForm = cbNeverShow.Checked;
            Config.RefreshPresets();
            Config.Save();
            this.Close();
        }

        private void CompilerForm_Load(object sender, EventArgs e)
        {
            OK = false;
            fillControls(Config.PresetsPath);

            cbCurrent.SelectedItem = Config.CurrentPreset;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Select the path for the tile presets.";
            dlg.SelectedPath = tbPath.Text;
            dlg.ShowDialog(this);

            string path = dlg.SelectedPath;
            if (string.IsNullOrEmpty(path)) return;

            if (!File.Exists(path + @"\block.txt"))
            {
                MessageBox.Show(this, "The block.txt file is missing from the preset path.", "Missing block.txt!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            fillControls(path);
        }

        private void fillControls(string path)
        {
            tbPath.Text = path;
            List<string> presets = new List<string>(Directory.GetFiles(path, "*.fomap"));
            for (int i = 0; i < presets.Count; i++) presets[i] = Path.GetFileName(presets[i]);

            lbPresets.Items.Clear();
            lbPresets.Items.AddRange(presets.ToArray());
            cbCurrent.Items.Clear();
            cbCurrent.Items.Add("");
            cbCurrent.Items.AddRange(presets.ToArray());
            cbCurrent.SelectedIndex = 0;
            cbNeverShow.Checked = Config.NeverShowHeaderForm;
        }
    }
}
