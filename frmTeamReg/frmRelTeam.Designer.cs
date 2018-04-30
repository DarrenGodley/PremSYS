namespace frmTeamReg
{
    partial class frmRelTeam
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboTeams = new System.Windows.Forms.ComboBox();
            this.btnRelegate = new System.Windows.Forms.Button();
            this.grpRelegate = new System.Windows.Forms.GroupBox();
            this.mnuRegTeam.SuspendLayout();
            this.grpRelegate.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRegTeam
            // 
            this.mnuRegTeam.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.exitToolStripMenuItem});
            this.mnuRegTeam.Location = new System.Drawing.Point(0, 0);
            this.mnuRegTeam.Name = "mnuRegTeam";
            this.mnuRegTeam.Size = new System.Drawing.Size(494, 24);
            this.mnuRegTeam.TabIndex = 57;
            this.mnuRegTeam.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cboTeams
            // 
            this.cboTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeams.FormattingEnabled = true;
            this.cboTeams.Location = new System.Drawing.Point(6, 19);
            this.cboTeams.MaxDropDownItems = 20;
            this.cboTeams.Name = "cboTeams";
            this.cboTeams.Size = new System.Drawing.Size(236, 21);
            this.cboTeams.TabIndex = 58;
            // 
            // btnRelegate
            // 
            this.btnRelegate.Location = new System.Drawing.Point(6, 46);
            this.btnRelegate.Name = "btnRelegate";
            this.btnRelegate.Size = new System.Drawing.Size(75, 23);
            this.btnRelegate.TabIndex = 59;
            this.btnRelegate.Text = "Relegate";
            this.btnRelegate.UseVisualStyleBackColor = true;
            this.btnRelegate.Click += new System.EventHandler(this.btnRelegate_Click);
            // 
            // grpRelegate
            // 
            this.grpRelegate.Controls.Add(this.cboTeams);
            this.grpRelegate.Controls.Add(this.btnRelegate);
            this.grpRelegate.Location = new System.Drawing.Point(24, 53);
            this.grpRelegate.Name = "grpRelegate";
            this.grpRelegate.Size = new System.Drawing.Size(344, 88);
            this.grpRelegate.TabIndex = 60;
            this.grpRelegate.TabStop = false;
            this.grpRelegate.Text = "Relegate Team";
            // 
            // frmRelTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 215);
            this.Controls.Add(this.grpRelegate);
            this.Controls.Add(this.mnuRegTeam);
            this.Name = "frmRelTeam";
            this.Text = "frmRelTeam";
            this.Load += new System.EventHandler(this.frmRelTeam_Load);
            this.mnuRegTeam.ResumeLayout(false);
            this.mnuRegTeam.PerformLayout();
            this.grpRelegate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRegTeam;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ComboBox cboTeams;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnRelegate;
        private System.Windows.Forms.GroupBox grpRelegate;
    }
}