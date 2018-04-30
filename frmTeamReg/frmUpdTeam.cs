using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTeamReg
{
    public partial class frmUpdTeam : Form
    {
        frmMainMenu parent;

        public frmUpdTeam()
        {
            InitializeComponent();
        }

        public frmUpdTeam(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //close current form
            this.Close();

            //go back to previous (parent) form
            parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
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

            else if ((txtTeam_ID) > 20)
            {
                MessageBox.Show("Team Doesn't Exist", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            //assign instance variables
            Team updTeam = new Team(Convert.ToInt32(txtTeam_ID.Text), txtTeamName.Text, txtHomeGround.Text, txtManager.Text, txtEmail.Text, txtPhone.Text, 0);

            //save team details in DB
            updTeam.updTeam();

            //Display confirmation message
            MessageBox.Show("Team Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset ui
            txtTeam_ID.Text = "";
            txtTeamName.Text = "";
            txtHomeGround.Text = "";
            txtManager.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";

            txtTeam_ID.Focus();
        }

        private void frmUpdTeam_Load(object sender, EventArgs e)
        {
            txtTeam_ID.Focus();
        }
    }
    }