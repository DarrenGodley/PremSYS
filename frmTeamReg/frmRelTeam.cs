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
    public partial class frmRelTeam : Form
    {
        frmMainMenu parent;

        public frmRelTeam(frmMainMenu Parent)
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

        private void frmRelTeam_Load(object sender, EventArgs e)
        {
            //load combo with TeamID, TeamName and Points for all teams
            DataSet ds = new DataSet();
            ds = Team.getTeamStanding(ds);
            Font font1 = new Font(FontFamily.GenericMonospace.Name, 10);
            cboTeams.Font = font1;

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                cboTeams.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0') + " " + ds.Tables[0].Rows[i][1].ToString().PadRight(20,' ') + " " + ds.Tables[0].Rows[i][6].ToString().PadLeft(2, ' '));
        }

        private void btnRelegate_Click(object sender, EventArgs e)
        {
            //Display confirmation message
            MessageBox.Show("Team Relegated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
