using System.Windows.Forms;

namespace ObjectEditor
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        public void setProgress(int value)
        {
            progressBar.Value = value;
        }

        public void setText(string value)
        {
            lblStatus.Text = value;
        }
    }
}
