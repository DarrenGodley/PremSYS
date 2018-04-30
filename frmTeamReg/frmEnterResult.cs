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
    public partial class frmEnterResult : Form
    {
        frmMainMenu parent;
        public frmEnterResult(frmMainMenu Parent)
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
        private void frmEnterResult_Load(object sender, EventArgs e)
        {
            //load combo with TeamID and Team_Name for all Teams
            DataSet ds = new DataSet();
            ds = Team.getAllTeams(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                cboTeams.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0') + " " + ds.Tables[0].Rows[i][1].ToString());
        }

        private void cboScheduledFixtures_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Fixtures.getScheduledFixtures(ds, Convert.ToInt32(cboScheduledFixtures.Text.Substring(0, 2)));
            cboScheduledFixtures.Items.Clear();
            Font font1 = new Font(FontFamily.GenericMonospace.Name, 10);
            cboScheduledFixtures.Font = font1;


            for (int i = 0; i < ds.Tables["sfx"].Rows.Count; i++)
                cboScheduledFixtures.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][1].ToString().Trim() + " V " + ds.Tables[0].Rows[i][2].ToString());

            //display fixtures
            cboScheduledFixtures.Visible = true;
        }
    }
}
