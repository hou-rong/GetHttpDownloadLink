using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DownLinkTransfer;
using GetHttpDownloadLink.Properties;

namespace GetHttpDownloadLink
{
    public partial class GetHttpDownloadLinkForm : Form
    {
        private HelpForm helpForm;
        public GetHttpDownloadLinkForm()
        {
            InitializeComponent();
        }

        private void GetHttpDownloadLinkForm_Load(object sender, EventArgs e)
        {
            labelHelp.Text = Resources.Help;
            groupBoxInput.Text = Resources.input;
            groupBoxOutput.Text = Resources.output;
            btnRun.Text = Resources.run;
            btnHelp.Text = Resources.btnHelp;
            Text = Resources.MainForm;
            helpForm = new HelpForm(this);
        }

        private string GetDownLinks()
        {
            string[] linkStrings = textInput.Text.Split(',');
            List<string> httpLinkStringList = new List<string>();
            foreach (string linkString in linkStrings)
            {
                if (linkString.Contains("qqdl://"))
                {
                    string result;
                    if (GetHttpLink.FromQqDownload(linkString, out result))
                    {
                        httpLinkStringList.Add(result);
                    }
                }

                if (linkString.Contains("thunder://"))
                {
                    string result;
                    if (GetHttpLink.FromThunder(linkString, out result))
                    {
                        httpLinkStringList.Add(result);
                    }
                }

                if (linkString.Contains("flashget://"))
                {
                    string result;
                    if (GetHttpLink.FromFlashGet(linkString, out result))
                    {
                        httpLinkStringList.Add(result);
                    }
                }
            }
            return String.Join("\r\n", httpLinkStringList);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textInput.Text))
            {
                textOutput.Text = GetDownLinks();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            helpForm.Show();
        }

        private void GetHttpDownloadLinkForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            helpForm.Close();
        }
    }
}
