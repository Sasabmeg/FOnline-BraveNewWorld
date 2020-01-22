using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using FOCommon.Parsers;
using FOCommon.WMLocation;

namespace WorldEditor
{
    public partial class frmEditMap : Form
    {
        public Map Map;
        public bool save;
        public bool newmap;

        MapParser MapParser;

        public frmEditMap(Map Map, MapParser MapParser, bool newmap)
        {
            this.newmap = newmap;
            this.Map = Map;
            this.MapParser = MapParser;
            InitializeComponent();
        }

        private void frmEditMap_Load(object sender, EventArgs e)
        {
            if (newmap)
            {
                Map = new Map();
                this.Text = "Map";
                txtPID.Text = MapParser.GetFreeMapPID(1).ToString();
                txtPID.Enabled = true;
                btnAssignPID.Enabled = true;
            }
            else
            {
                this.Text = "Map - " + Map.Name + " (" + Map.FileName + "), PID = " + Map.Pid;
                txtPID.Text = Map.Pid.ToString();
                txtPID.Enabled = false;
                btnAssignPID.Enabled = false;

                txtName.Text = Map.Name;
                txtFileName.Text = Map.FileName;
                txtScript.Text = Map.ScriptName;
                lstBoxMusic.DataSource = Map.Music;
                txtSound.Text = Map.SoundString;
                txtTime.Text = Map.Time;
                chkNologout.Checked = Map.NoLogout;
                chkAutomap.Checked = Map.AutoMap;
            }
            save = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Map.Pid = int.Parse(txtPID.Text);
            if (newmap && MapParser.MapExists(Map))
            {
                Message.Show("PID " + Map.Pid + " already used by another map. Choose another one.",MessageBoxButtons.OK,  MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtFileName.Text))
            {
                Message.Show("Filename can't be null.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Map.Name = txtName.Text;
            Map.FileName = txtFileName.Text;
            Map.ScriptName = txtScript.Text;
            Map.SoundString = txtSound.Text;
            Map.NoLogout = chkNologout.Checked;
            Map.Time = txtTime.Text;
            Map.Modified = true;
            Map.AutoMap = chkAutomap.Checked;
            save = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAssignPID_Click(object sender, EventArgs e)
        {
            txtPID.Text = MapParser.GetFreeMapPID(Int32.Parse(txtPID.Text)+1).ToString();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            FileDialog fileDlg = new OpenFileDialog();
            fileDlg.Filter = "FOnline map (*.fomap)|*.fomap";
            fileDlg.CheckFileExists = true;
            fileDlg.RestoreDirectory = true;
            fileDlg.InitialDirectory = Config.PathMapsDir;
            DialogResult ret = fileDlg.ShowDialog();
            if (ret == DialogResult.OK)
                txtFileName.Text = Path.GetFileNameWithoutExtension(fileDlg.FileName);
        }

        private void btnAddMusic_Click(object sender, EventArgs e)
        {
            if (Map.Music == null) Map.Music = new List<string>();
            Map.Music.Add(cmbMusic.Text);
            RefreshMusic();
        }

        private void RefreshMusic()
        {
            lstBoxMusic.DataSource = null;
            lstBoxMusic.DataSource = Map.Music;
        }

        private void RemoveMusic()
        {
            int n = lstBoxMusic.SelectedIndex;
            if (n < 0) return;
            Map.Music.RemoveAt(n);
            RefreshMusic();
        }

        private void btnRemoveMusic_Click(object sender, EventArgs e)
        {
            RemoveMusic();
        }

        private void lstBoxMusic_DoubleClick(object sender, EventArgs e)
        {
            RemoveMusic();
        }
    }
}
