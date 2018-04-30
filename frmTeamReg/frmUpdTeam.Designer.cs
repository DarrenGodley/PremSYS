namespace frmTeamReg
{
    partial class frmUpdTeam
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
            this.grpTeam = new System.Windows.Forms.GroupBox();
            this.txtTeam_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.lblManager = new System.Windows.Forms.Label();
            this.txtHomeGround = new System.Windows.Forms.TextBox();
            this.lblHomeGround = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.mnuRegTeam = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpTeam.SuspendLayout();
            this.mnuRegTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTeam
            // 
            this.grpTeam.Controls.Add(this.txtTeam_ID);
            this.grpTeam.Controls.Add(this.label1);
            this.grpTeam.Controls.Add(this.btnSubmit);
            this.grpTeam.Controls.Add(this.txtPhone);
            this.grpTeam.Controls.Add(this.lblPhone);
            this.grpTeam.Controls.Add(this.txtEmail);
            this.grpTeam.Controls.Add(this.lblEmail);
            this.grpTeam.Controls.Add(this.txtManager);
            this.grpTeam.Controls.Add(this.lblManager);
            this.grpTeam.Controls.Add(this.txtHomeGround);
            this.grpTeam.Controls.Add(this.lblHomeGround);
            this.grpTeam.Controls.Add(this.txtTeamName);
            this.grpTeam.Controls.Add(this.lblTeamName);
            this.grpTeam.Location = new System.Drawing.Point(12, 41);
            this.grpTeam.Name = "grpTeam";
            this.grpTeam.Size = new System.Drawing.Size(353, 239);
            this.grpTeam.TabIndex = 57;
            this.grpTeam.TabStop = false;
            this.grpTeam.Text = "Enter Team Details";
            // 
            // txtTeam_ID
            // 
            this.txtTeam_ID.Location = new System.Drawing.Point(113, 40);
            this.txtTeam_ID.Name = "txtTeam_ID";
            this.txtTeam_ID.Size = new System.Drawing.Size(40, 20);
            this.txtTeam_ID.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Team ID:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(112, 196);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 64;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(112, 170);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(158, 20);
            this.txtPhone.TabIndex = 63;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(27, 173);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 62;
            this.lblPhone.Text = "Phone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 144);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 20);
            this.txtEmail.TabIndex = 61;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(27, 147);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 60;
            this.lblEmail.Text = "Email:";
            // 
            // txtManager
            // 
            this.txtManager.Location = new System.Drawing.Point(112, 118);
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(158, 20);
            this.txtManager.TabIndex = 59;
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new System.Drawing.Point(27, 121);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(52, 13);
            this.lblManager.TabIndex = 58;
            this.lblManager.Text = "Manager:";
            // 
            // txtHomeGround
            // 
            this.txtHomeGround.Location = new System.Drawing.Point(112, 92);
            this.txtHomeGround.Name = "txtHomeGround";
            this.txtHomeGround.Size = new System.Drawing.Size(158, 20);
            this.txtHomeGround.TabIndex = 57;
            // 
            // lblHomeGround
            // 
            this.lblHomeGround.AutoSize = true;
            this.lblHomeGround.Location = new System.Drawing.Point(27, 95);
            this.lblHomeGround.Name = "lblHomeGround";
            this.lblHomeGround.Size = new System.Drawing.Size(79, 13);
            this.lblHomeGround.TabIndex = 56;
            this.lblHomeGround.Text = "Home Ground :";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(112, 66);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(158, 20);
            this.txtTeamName.TabIndex = 55;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(27, 69);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(66, 13);
            this.lblTeamName.TabIndex = 54;
            this.lblTeamName.Text = "Team name:";
            // 
            // mnuRegTeam
            // 
            this.mnuRegTeam.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.mnuRegTeam.Location = new System.Drawing.Point(0, 0);
            this.mnuRegTeam.Name = "mnuRegTeam";
            this.mnuRegTeam.Size = new System.Drawing.Size(550, 24);
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
            // frmUpdTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 343);
            this.Controls.Add(this.grpTeam);
            this.Controls.Add(this.mnuRegTeam);
            this.Name = "frmUpdTeam";
            this.Text = "frmUpdTeam";
            this.Load += new System.EventHandler(this.frmUpdTeam_Load);
            this.grpTeam.ResumeLayout(false);
            this.grpTeam.PerformLayout();
            this.mnuRegTeam.ResumeLayout(false);
            this.mnuRegTeam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTeam;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.TextBox txtHomeGround;
        private System.Windows.Forms.Label lblHomeGround;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.MenuStrip mnuRegTeam;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TextBox txtTeam_ID;
        private System.Windows.Forms.Label label1;
    }
}