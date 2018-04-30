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
    public partial class frmGenerateFixtures : Form
    {
        frmMainMenu parent;
        public frmGenerateFixtures(frmMainMenu Parent)
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Team updTeam = new Team(Convert.ToInt32(txtTeam_ID.Text), txtTeamName.Text, txtHomeGround.Text, txtManager.Text, txtEmail.Text, txtPhone.Text, 0);

        private void btnGenerateFixtures_Click_1(object sender, EventArgs e)
        {
            //check that there are 20 teams
            

            //check no games have been played


            //generate fixtures
            DataSet ds = new DataSet();
            ds = Fixtures.genFixtures(ds);
   
            int fixId= 1;
               
             for (int i = 0; i < ds.Tables["fx"].Rows.Count; i++)
             { 
                  Fixtures.insFixture(fixId, Convert.ToInt32(ds.Tables["fx"].Rows[i][0]), Convert.ToInt32(ds.Tables["fx"].Rows[i][1]));
                  fixId++;
                  hsbProgress.Value++;
             }
            //Display confirmation message
            MessageBox.Show("Fixtures generated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
