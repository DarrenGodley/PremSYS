namespace frmTeamReg
{
    partial class frmEnterResult
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
            this.mnuRegTeam = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cboTeams = new System.Windows.Forms.ComboBox();
            this.cboScheduledFixtures = new System.Windows.Forms.ComboBox();
            this.mnuRegTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRegTeam
            // 
            this.mnuRegTeam.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.mnuRegTeam.Location = new System.Drawing.Point(0, 0);
            this.mnuRegTeam.Name = "mnuRegTeam";
            this.mnuRegTeam.Size = new System.Drawing.Size(797, 24);
            this.mnuRegTeam.TabIndex = 56;
            this.mnuRegTeam.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // cboTeams
            // 
            this.cboTeams.FormattingEnabled = true;
            this.cboTeams.Location = new System.Drawing.Point(25, 68);
            this.cboTeams.Name = "cboTeams";
            this.cboTeams.Size = new System.Drawing.Size(121, 21);
            this.cboTeams.TabIndex = 57;
            this.cboTeams.SelectedIndexChanged += new System.EventHandler(this.cboScheduledFixtures_SelectedIndexChanged);
            // 
            // cboScheduledFixtures
            // 
            this.cboScheduledFixtures.FormattingEnabled = true;
            this.cboScheduledFixtures.Location = new System.Drawing.Point(25, 114);
            this.cboScheduledFixtures.Name = "cboScheduledFixtures";
            this.cboScheduledFixtures.Size = new System.Drawing.Size(468, 21);
            this.cboScheduledFixtures.TabIndex = 58;
            // 
            // frmEnterResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 415);
            this.Controls.Add(this.cboScheduledFixtures);
            this.Controls.Add(this.cboTeams);
            this.Controls.Add(this.mnuRegTeam);
            this.Name = "frmEnterResult";
            this.Text = "frmEnterResult";
            this.Load += new System.EventHandler(this.frmEnterResult_Load);
            this.mnuRegTeam.ResumeLayout(false);
            this.mnuRegTeam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRegTeam;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ComboBox cboTeams;
        private System.Windows.Forms.ComboBox cboScheduledFixtures;
    }
}