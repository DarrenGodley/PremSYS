namespace frmTeamReg
{
    partial class frmGenerateFixtures
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
            this.btnGenerateFixtures = new System.Windows.Forms.Button();
            this.hsbProgress = new System.Windows.Forms.HScrollBar();
            this.mnuRegTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRegTeam
            // 
            this.mnuRegTeam.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.exitToolStripMenuItem});
            this.mnuRegTeam.Location = new System.Drawing.Point(0, 0);
            this.mnuRegTeam.Name = "mnuRegTeam";
            this.mnuRegTeam.Size = new System.Drawing.Size(750, 24);
            this.mnuRegTeam.TabIndex = 58;
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
            // btnGenerateFixtures
            // 
            this.btnGenerateFixtures.Location = new System.Drawing.Point(111, 277);
            this.btnGenerateFixtures.Name = "btnGenerateFixtures";
            this.btnGenerateFixtures.Size = new System.Drawing.Size(510, 23);
            this.btnGenerateFixtures.TabIndex = 65;
            this.btnGenerateFixtures.Text = "Generate Fixtures";
            this.btnGenerateFixtures.UseVisualStyleBackColor = true;
            this.btnGenerateFixtures.Click += new System.EventHandler(this.btnGenerateFixtures_Click_1);
            // 
            // hsbProgress
            // 
            this.hsbProgress.Location = new System.Drawing.Point(75, 110);
            this.hsbProgress.Maximum = 380;
            this.hsbProgress.Name = "hsbProgress";
            this.hsbProgress.Size = new System.Drawing.Size(604, 53);
            this.hsbProgress.TabIndex = 66;
            // 
            // frmGenerateFixtures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 424);
            this.Controls.Add(this.hsbProgress);
            this.Controls.Add(this.btnGenerateFixtures);
            this.Controls.Add(this.mnuRegTeam);
            this.Name = "frmGenerateFixtures";
            this.Text = "frmGenerateFixtures";
            this.mnuRegTeam.ResumeLayout(false);
            this.mnuRegTeam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRegTeam;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnGenerateFixtures;
        private System.Windows.Forms.HScrollBar hsbProgress;
    }
}