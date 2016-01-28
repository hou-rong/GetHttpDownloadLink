using System;
using System.Windows.Forms;
using GetHttpDownloadLink.Properties;

namespace GetHttpDownloadLink
{
    public partial class HelpForm : Form
    {
        private GetHttpDownloadLinkForm mainForm;
        public HelpForm(GetHttpDownloadLinkForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void HelpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            mainForm.Location = this.Location;
            mainForm.Show();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            this.Location = mainForm.Location;
            this.Text = Resources.HelpForm;
        }
    }
}
