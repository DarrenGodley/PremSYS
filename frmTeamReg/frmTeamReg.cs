using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Oracle.ManagedDataAccess.Client;

namespace frmTeamReg
{
    public partial class frmTeamReg : Form
    {
        frmMainMenu parent;

        public frmTeamReg()
        {
            InitializeComponent();
        }

        public frmTeamReg(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void FrmTeamReg_Load(object sender, EventArgs e)
        {
            txtTeam_ID.Text = Team.NextTeamID().ToString("00");
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //close current form
            this.Close();

            //go back to previous (parent) form
            parent.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // validate data
            if (txtTeamName.Text.Equals(""))
            {
                MessageBox.Show("Team Name must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTeamName.Focus();
                return;
            }

            else if (txtHomeGround.Text.Equals(""))
            {
                MessageBox.Show("Home Ground must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHomeGround.Focus();
                return;
            }

            else if (txtManager.Text.Equals(""))
            {
                MessageBox.Show("Manager must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManager.Focus();
                return;
            }

            else if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Email must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            else if (txtPhone.Text.Equals(""))
            {
                MessageBox.Show("Phone must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            else if (txtTeam_ID.Text.Equals("21"))
            {
                MessageBox.Show("More than 20 teams entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            //assign instance variables
            Team newTeam = new Team(Convert.ToInt32(txtTeam_ID.Text), txtTeamName.Text, txtHomeGround.Text, txtManager.Text, txtEmail.Text, txtPhone.Text, 0);

            //save team details in DB
            newTeam.regTeam();

            //Display confirmation message
            MessageBox.Show("Team Registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset ui
            txtTeam_ID.Text = Team.NextTeamID().ToString("00");
            txtTeamName.Text = "";
            txtHomeGround.Text = "";
            txtManager.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtTeamName.Focus();
        }
    }
}
