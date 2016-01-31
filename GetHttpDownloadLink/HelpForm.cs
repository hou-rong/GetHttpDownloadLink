using System;
using System.Windows.Forms;
using GetHttpDownloadLink.Properties;

namespace GetHttpDownloadLink
{
    public partial class HelpForm : Form
    {
        private readonly GetHttpDownloadLinkForm _mainForm;
        public HelpForm(GetHttpDownloadLinkForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void HelpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            _mainForm.Location = Location;
            _mainForm.Show();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            Location = _mainForm.Location;
            Text = Resources.HelpForm;
        }
    }
}
