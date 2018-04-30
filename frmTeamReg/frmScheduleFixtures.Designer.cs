namespace frmTeamReg
{
    partial class frmScheduleFixtures
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
            this.cboTeams = new System.Windows.Forms.ComboBox();
            this.mnuRegTeam = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpTeam = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.cboUnplayed = new System.Windows.Forms.ComboBox();
            this.mnuRegTeam.SuspendLayout();
            this.grpTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTeams
            // 
            this.cboTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeams.FormattingEnabled = true;
            this.cboTeams.Location = new System.Drawing.Point(51, 56);
            this.cboTeams.Name = "cboTeams";
            this.cboTeams.Size = new System.Drawing.Size(215, 21);
            this.cboTeams.TabIndex = 0;
            this.cboTeams.SelectedIndexChanged += new System.EventHandler(this.cboTeams_SelectedIndexChanged);
            // 
            // mnuRegTeam
            // 
            this.mnuRegTeam.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.mnuRegTeam.Location = new System.Drawing.Point(0, 0);
            this.mnuRegTeam.Name = "mnuRegTeam";
            this.mnuRegTeam.Size = new System.Drawing.Size(1046, 24);
            this.mnuRegTeam.TabIndex = 55;
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
            // grpTeam
            // 
            this.grpTeam.Controls.Add(this.txtTime);
            this.grpTeam.Controls.Add(this.dtpDate);
            this.grpTeam.Controls.Add(this.label1);
            this.grpTeam.Controls.Add(this.btnSubmit);
            this.grpTeam.Controls.Add(this.lblTeamName);
            this.grpTeam.Location = new System.Drawing.Point(51, 192);
            this.grpTeam.Name = "grpTeam";
            this.grpTeam.Size = new System.Drawing.Size(326, 172);
            this.grpTeam.TabIndex = 56;
            this.grpTeam.TabStop = false;
            this.grpTeam.Text = "Fixture Details";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(100, 76);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(128, 20);
            this.txtTime.TabIndex = 69;
            this.txtTime.Text = "14:00";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(100, 26);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Fixture Date:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(122, 117);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 64;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(27, 79);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(67, 13);
            this.lblTeamName.TabIndex = 54;
            this.lblTeamName.Text = "Fixture Time:";
            // 
            // cboUnplayed
            // 
            this.cboUnplayed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnplayed.FormattingEnabled = true;
            this.cboUnplayed.Location = new System.Drawing.Point(51, 101);
            this.cboUnplayed.Name = "cboUnplayed";
            this.cboUnplayed.Size = new System.Drawing.Size(510, 21);
            this.cboUnplayed.TabIndex = 57;
            this.cboUnplayed.Visible = false;
            // 
            // frmScheduleFixtures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 527);
            this.Controls.Add(this.cboUnplayed);
            this.Controls.Add(this.grpTeam);
            this.Controls.Add(this.mnuRegTeam);
            this.Controls.Add(this.cboTeams);
            this.Name = "frmScheduleFixtures";
            this.Text = "Schedule Fixture";
            this.Load += new System.EventHandler(this.frmScheduleFixtures_Load);
            this.mnuRegTeam.ResumeLayout(false);
            this.mnuRegTeam.PerformLayout();
            this.grpTeam.ResumeLayout(false);
            this.grpTeam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTeams;
        private System.Windows.Forms.MenuStrip mnuRegTeam;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cboUnplayed;
        private System.Windows.Forms.TextBox txtTime;
    }
}