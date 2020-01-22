using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectEditor
{
    public partial class frmFrmGallery : Form
    {
        frmSplash splashScreen;
        PictureBox selected;
        PictureBox chosen;
        public bool isOk { get; set; }
        public bool isFirstPaint { get; set; }

        public int PageSize { get; set; }
        public int CurrentPage { get; set; }

        List<FlowLayoutPanel> items = new List<FlowLayoutPanel>();

        List<FlowLayoutPanel> all = new List<FlowLayoutPanel>();

        public PictureBox getSelected() { return chosen; }

        public frmFrmGallery()
        {
            InitializeComponent();
            splashScreen = new frmSplash();
            isFirstPaint = true;
            PageSize = 25;
            CurrentPage = 1;
        }

        public void prepareGraphics()
        {
            backgroundLoad.RunWorkerAsync();
        }

        void select(PictureBox pct)
        {
            if (selected != null)
            {
                selected.Parent.BackColor = Color.Transparent;
                //selected.BackColor = 
            }
            selected = pct;
            selected.Parent.BackColor = Color.DimGray;
        }

        void flp_MouseClick(object sender, MouseEventArgs e)
        {
            FlowLayoutPanel flp = (FlowLayoutPanel)sender;
            select((PictureBox)flp.Controls[0]);
        }

        void pct_MouseClick(object sender, MouseEventArgs e)
        {
            select((PictureBox)sender);
        }

        private void ok()
        {
            this.isOk = true;
            this.chosen = selected;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ok();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetPage(int page)
        {
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;

            if (page == 1)
                btnPrevious.Enabled = false;
            else if (page == GetPageMax())
                btnNext.Enabled = false;

            flowFrms.Visible = false;

            foreach (FlowLayoutPanel item in items)
                item.Visible = false;
            CurrentPage = page;

            int j = ((page-1)*PageSize) + PageSize;

            int numItems = items.Count;

            for (int i = (page-1) * PageSize; i < j; i++)
            {
                if(i < numItems)
                    items[i].Visible = true;
            }

            flowFrms.Visible = true;

            lblPage.Text = "Page " + CurrentPage.ToString() + " / " + GetPageMax();
        }

        int GetPageMax()
        {
            int max = items.Count / PageSize;
            if (max < 1) max = 1;
            return max;
        }

        private void backgroundLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            if (IsHandleCreated)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    flowFrms.Controls.Clear();
                    flowFrms.Visible = false;
                    splashScreen = new frmSplash();
                });
            }
            else
            {
                flowFrms.Controls.Clear();
                flowFrms.Visible = false;
                splashScreen = new frmSplash();
            }

            int count = Data.Graphics.Count;
            int i = 0;
            foreach (KeyValuePair<string, Bitmap> kvp in Data.Graphics)
            {
                i++;
                float progress = (float)i / (float)count;
                backgroundLoad.ReportProgress((int)(progress*100));
                PictureBox pct = new PictureBox();
                pct.Image = kvp.Value;
                pct.Tag = kvp.Key;
                pct.SizeMode = PictureBoxSizeMode.AutoSize;
                pct.MouseClick +=new MouseEventHandler(pct_MouseClick);
                pct.MouseDoubleClick += new MouseEventHandler(pct_MouseDoubleClick);
                Label lbl = new Label();
                lbl.Text = System.IO.Path.GetFileName(kvp.Key);
                lbl.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 7.0f, FontStyle.Bold);
                lbl.AutoSize = true;
                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.FlowDirection = FlowDirection.TopDown;
                flp.Controls.Add(pct);
                flp.Controls.Add(lbl);
                all.Add(flp);
                if (i > PageSize)
                    flp.Visible = false;
                flp.MouseClick += new MouseEventHandler(flp_MouseClick);

                if (IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        flowFrms.Controls.Add(flp);
                        splashScreen.setText(kvp.Key);
                    });
                }
                else
                {
                    flowFrms.Controls.Add(flp);
                }
            }
        }

        void pct_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ok();
        }

        private void backgroundLoad_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (IsHandleCreated)
                this.Invoke((MethodInvoker)delegate { splashScreen.setProgress(e.ProgressPercentage); });
        }

        private void backgroundLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            splashScreen.Close();
            flowFrms.Visible = true;
            foreach (FlowLayoutPanel item in all)
                items.Add(item);

            SetPage(1);
        }

        private void frmFrmGallery_Paint(object sender, PaintEventArgs e)
        {
            if (isFirstPaint)
            {
                if (backgroundLoad.IsBusy)
                {
                    if (!splashScreen.Visible)
                        splashScreen.ShowDialog();
                }
                isFirstPaint = false;
            }
        }

        private void cmbShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            prepareGraphics();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            SetPage(1);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            SetPage(GetPageMax());
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            SetPage(CurrentPage - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SetPage(CurrentPage + 1);
        }

        private void chkAutoSize_CheckStateChanged(object sender, EventArgs e)
        {
            foreach (FlowLayoutPanel item in items)
                item.AutoSize = chkAutoSize.Checked;
        }

        private void numPageSize_ValueChanged(object sender, EventArgs e)
        {
            PageSize = (int)numPageSize.Value;
            SetPage(1);
        }

        private void Filter()
        {
            items.Clear();
            flowFrms.Visible = false;
            foreach (FlowLayoutPanel item in all)
                item.Visible = false;
            flowFrms.Visible = true;

            foreach (FlowLayoutPanel item in all)
            {
                String path = ((String)item.Controls[0].Tag);
                path.ToLower();

                if(cmbFilterPath.Text != "" && !path.Contains(cmbFilterPath.Text))
                    continue;
                if (txtSearch.Text != "" && !path.Contains(txtSearch.Text.ToLower()))
                    continue;

                items.Add(item);
            }
            SetPage(1);
        }

        private void cmbFilterPath_SelectedValueChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Filter();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}
