namespace frmTeamReg
{
    partial class frmMainMenu
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
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.relegateTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleFixturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLeagueTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateTeamProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTeams,
            this.fixturesToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(808, 24);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuTeams
            // 
            this.mnuTeams.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegTeam,
            this.mnuUpdTeam,
            this.relegateTeamToolStripMenuItem});
            this.mnuTeams.Name = "mnuTeams";
            this.mnuTeams.Size = new System.Drawing.Size(53, 20);
            this.mnuTeams.Text = "Teams";
            // 
            // mnuRegTeam
            // 
            this.mnuRegTeam.Name = "mnuRegTeam";
            this.mnuRegTeam.Size = new System.Drawing.Size(152, 22);
            this.mnuRegTeam.Text = "Register Team";
            this.mnuRegTeam.Click += new System.EventHandler(this.mnuRegTeam_Click);
            // 
            // mnuUpdTeam
            // 
            this.mnuUpdTeam.Name = "mnuUpdTeam";
            this.mnuUpdTeam.Size = new System.Drawing.Size(152, 22);
            this.mnuUpdTeam.Text = "Update Team";
            this.mnuUpdTeam.Click += new System.EventHandler(this.mnuUpdTeam_Click_1);
            // 
            // relegateTeamToolStripMenuItem
            // 
            this.relegateTeamToolStripMenuItem.Name = "relegateTeamToolStripMenuItem";
            this.relegateTeamToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.relegateTeamToolStripMenuItem.Text = "Relegate Team";
            this.relegateTeamToolStripMenuItem.Click += new System.EventHandler(this.relegateTeamToolStripMenuItem_Click);
            // 
            // fixturesToolStripMenuItem
            // 
            this.fixturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.scheduleFixturesToolStripMenuItem,
            this.enterResultsToolStripMenuItem,
            this.showLeagueTableToolStripMenuItem});
            this.fixturesToolStripMenuItem.Name = "fixturesToolStripMenuItem";
            this.fixturesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.fixturesToolStripMenuItem.Text = "Fixtures";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.generateToolStripMenuItem.Text = "Generate Fixtures";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
            // 
            // scheduleFixturesToolStripMenuItem
            // 
            this.scheduleFixturesToolStripMenuItem.Name = "scheduleFixturesToolStripMenuItem";
            this.scheduleFixturesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.scheduleFixturesToolStripMenuItem.Text = "Schedule Fixtures";
            this.scheduleFixturesToolStripMenuItem.Click += new System.EventHandler(this.scheduleFixturesToolStripMenuItem_Click);
            // 
            // enterResultsToolStripMenuItem
            // 
            this.enterResultsToolStripMenuItem.Name = "enterResultsToolStripMenuItem";
            this.enterResultsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.enterResultsToolStripMenuItem.Text = "Enter Results";
            this.enterResultsToolStripMenuItem.Click += new System.EventHandler(this.enterResultsToolStripMenuItem_Click);
            // 
            // showLeagueTableToolStripMenuItem
            // 
            this.showLeagueTableToolStripMenuItem.Name = "showLeagueTableToolStripMenuItem";
            this.showLeagueTableToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.showLeagueTableToolStripMenuItem.Text = "Show League Table";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateTeamProfileToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // generateTeamProfileToolStripMenuItem
            // 
            this.generateTeamProfileToolStripMenuItem.Name = "generateTeamProfileToolStripMenuItem";
            this.generateTeamProfileToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.generateTeamProfileToolStripMenuItem.Text = "Generate Team Profile";
            this.generateTeamProfileToolStripMenuItem.Click += new System.EventHandler(this.generateTeamProfileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 411);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmMainMenu";
            this.Text = "PemSYS - [Main Menu]";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuTeams;
        private System.Windows.Forms.ToolStripMenuItem mnuRegTeam;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdTeam;
        private System.Windows.Forms.ToolStripMenuItem relegateTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleFixturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLeagueTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateTeamProfileToolStripMenuItem;
    }
}