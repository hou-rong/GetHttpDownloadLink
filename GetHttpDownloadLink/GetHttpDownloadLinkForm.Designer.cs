namespace GetHttpDownloadLink
{
    partial class GetHttpDownloadLinkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelHelp = new System.Windows.Forms.Label();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textInput = new System.Windows.Forms.TextBox();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.Location = new System.Drawing.Point(13, 13);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(29, 12);
            this.labelHelp.TabIndex = 0;
            this.labelHelp.Text = "help";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textInput);
            this.groupBoxInput.Location = new System.Drawing.Point(13, 29);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(416, 124);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "input";
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(6, 20);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(404, 98);
            this.textInput.TabIndex = 0;
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(6, 20);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(404, 98);
            this.textOutput.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(348, 289);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.textOutput);
            this.groupBoxOutput.Location = new System.Drawing.Point(13, 159);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(416, 124);
            this.groupBoxOutput.TabIndex = 2;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "output";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(348, 8);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "btnHelp";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // GetHttpDownloadLinkForm
            // 
            this.AcceptButton = this.btnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 322);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.labelHelp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetHttpDownloadLinkForm";
            this.ShowIcon = false;
            this.Text = "GetHttpDownloadLinkForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GetHttpDownloadLinkForm_FormClosing);
            this.Load += new System.EventHandler(this.GetHttpDownloadLinkForm_Load);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Button btnHelp;
    }
}