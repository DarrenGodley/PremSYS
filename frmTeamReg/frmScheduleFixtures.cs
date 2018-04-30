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
    public partial class frmScheduleFixtures : Form
    {
        frmMainMenu parent;
        public frmScheduleFixtures(frmMainMenu Parent)
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

        private void frmScheduleFixtures_Load(object sender, EventArgs e)
        {
            //load combo with TeamID and Team_Name for all Teams
            DataSet ds = new DataSet();
            ds = Team.getAllTeams(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                cboTeams.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0') + " " + ds.Tables[0].Rows[i][1].ToString());
        }

        private void cboTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get unplayed fixtures for team
            DataSet ds = new DataSet();
            ds = Fixtures.getUnplayedFixtures(ds, Convert.ToInt32(cboTeams.Text.Substring(0,2)));
            cboUnplayed.Items.Clear();
            Font font1 = new Font(FontFamily.GenericMonospace.Name, 10);
            cboUnplayed.Font = font1;


            for (int i = 0; i < ds.Tables["ufx"].Rows.Count; i++)
                 cboUnplayed.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][1].ToString().Trim() + " V " + ds.Tables[0].Rows[i][2].ToString());

            //display fixtures
            cboUnplayed.Visible = true;

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //check that date and time are entered and are valid


            Fixtures.scheduleFixture(Convert.ToInt32(cboUnplayed.Text.Substring(0, 3)), String.Format("{0:dd-MMM-yy}", dtpDate.Value), txtTime.Text);


            //Display confirmation message
            MessageBox.Show("Fixture Scheduled", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
