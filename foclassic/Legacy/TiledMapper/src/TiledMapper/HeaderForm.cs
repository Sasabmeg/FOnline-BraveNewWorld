using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiledMapper
{
    public partial class HeaderForm : Form
    {
        public HeaderForm()
        {
            InitializeComponent();
        }

        public bool OK { get; private set; }
        public string Module
        {
            get
            {
                return tbModule.Text;
            }
        }
        public string Function
        {
            get
            {
                return tbFunc.Text;
            }
        }
        public string Time
        {
            get
            {
                return tbTime.Text;
            }
        }
        public string DayTime
        {
            get
            {
                return tbDayTime.Text;
            }
        }
        public string DayColor0
        {
            get
            {
                return tbDayColor0.Text;
            }
        }
        public string DayColor1
        {
            get
            {
                return tbDayColor1.Text;
            }
        }
        public string DayColor2
        {
            get
            {
                return tbDayColor2.Text;
            }
        }
        public string DayColor3
        {
            get
            {
                return tbDayColor3.Text;
            }
        }
        public bool NoLogOut
        {
            get
            {
                return cbNoLogout.Checked;
            }
        }


        private void HeaderForm_Load(object sender, EventArgs e)
        {
            OK = false;
            tbModule.Text      = Config.Module;
            tbFunc.Text        = Config.Function;
            tbTime.Text        = Config.Time; 
            tbDayTime.Text     = Config.DayTime;
            tbDayColor0.Text   = Config.DayColor0 ;
            tbDayColor1.Text   = Config.DayColor1 ;
            tbDayColor2.Text   = Config.DayColor2 ;
            tbDayColor3.Text   = Config.DayColor3 ;
            cbNoLogout.Checked = Config.NoLogOut;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            OK = true;

            if (cbDefault.Checked)
            {
                Config.Module = tbModule.Text;
                Config.Function = tbFunc.Text;
                Config.Time = tbTime.Text;
                Config.DayTime = tbDayTime.Text;
                Config.DayColor0 = tbDayColor0.Text;
                Config.DayColor1 = tbDayColor1.Text;
                Config.DayColor2 = tbDayColor2.Text;
                Config.DayColor3 = tbDayColor3.Text;
                Config.NoLogOut = cbNoLogout.Checked;
            }

            if (cbNeverShow.Checked) Config.NeverShowHeaderForm = true;

            if (cbNeverShow.Checked || cbDefault.Checked)
                Config.Save();
            this.Close();
        }
    }
}
