using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONT_Project_2023
{
    public partial class frmAssessmentReport : Form
    {
        public frmAssessmentReport()
        {
            InitializeComponent();
        }

        private void mstAdm_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmAssessmentReport_Load(object sender, EventArgs e)
        {
            grbSpecificAssess.Visible = false;
            grbType.Visible = false;
        }

        private void btnSpecificAssess_Click(object sender, EventArgs e)
        {
            if(grbSpecificAssess.Visible == true)
            {
                grbSpecificAssess.Visible = false;
            }
            else if(grbSpecificAssess.Visible == false)
            {
                grbSpecificAssess.Visible = true;
            }
            datePick.Visible = false;
            cmbType.Visible = false;
        }

        private void btnTypeDate_Click(object sender, EventArgs e)
        {
            if (grbType.Visible == false)
            {
                grbType.Visible = true;
            }
            else if (grbType.Visible == true)
            {
                grbType.Visible = false;
            }
            cmbType.Visible = false;
            datePick.Visible = false;
        }

        private void rdbType_CheckedChanged(object sender, EventArgs e)
        {
            datePick.Visible = false;
            cmbType.Visible = true;
        }

        private void rdbDate_CheckedChanged(object sender, EventArgs e)
        {
            cmbType.Visible = false;
            datePick.Visible = true;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome form = new frmHome();
            form.Show();
            this.Hide();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain form = new frmMain();
            form.Show();
            this.Hide();
        }

        private void manageModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModules form = new frmModules();
            form.Show();
            this.Hide();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReg form = new frmReg();
            form.Show();
            this.Hide();
        }

    }
}
