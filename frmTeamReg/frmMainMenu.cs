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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void mnuRegTeam_Click(object sender, EventArgs e)
        {
            //hide current form
            this.Hide();

            //Create instance of Reg Team Form
            frmTeamReg nextForm = new frmTeamReg(this);
            nextForm.Show();
        }

        private void mnuUpdTeam_Click_1(object sender, EventArgs e)
        {
            //hide current form
            this.Hide();

            //Create instance of Reg Team Form
            frmUpdTeam nextForm = new frmUpdTeam(this);
            nextForm.Show();
        }


        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void relegateTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hide current form
            this.Hide();

            //Create instance of Reg Team Form
            frmRelTeam nextForm = new frmRelTeam(this);
            nextForm.Show();
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hide current form
            this.Hide();

            //Create instance of Generate fixtures Form
            frmGenerateFixtures nextForm = new frmGenerateFixtures(this);
            nextForm.Show();
        }

        private void scheduleFixturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hide current form
            this.Hide();

            //Create instance of Schedule fixtures Form
            frmScheduleFixtures nextForm = new frmScheduleFixtures(this);
            nextForm.Show();
        }

        private void generateTeamProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hide current form
            this.Hide();

            //Create instance of GentTeamProfile Form
            frmGenTeamProfile nextForm = new frmGenTeamProfile(this);
            nextForm.Show();
        }

        private void enterResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hide current form
            this.Hide();

            //Create instance of GentTeamProfile Form
            frmEnterResult nextForm = new frmEnterResult(this);
            nextForm.Show();
        }
    }
}
