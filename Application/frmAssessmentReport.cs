using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using System.Drawing.Imaging;

namespace ONT_Project_2023
{
    public partial class frmAssessmentReport : Form
    {
        public frmAssessmentReport()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dal = new DataAccessLayer();
        private void mstAdm_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmAssessmentReport_Load(object sender, EventArgs e)
        {
            cmbType.DataSource = bll.GetAssessmentType();
            cmbType.DisplayMember = "AssessmentTypeDescription";
            cmbType.ValueMember = "AssessmentTypeID";
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
            dtpFirstDate.Visible = false;
            
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
            
            
        }

        private void rdbType_CheckedChanged(object sender, EventArgs e)
        {
            dtpFirstDate.Visible = false;
            
        }

        private void rdbDate_CheckedChanged(object sender, EventArgs e)
        {
           
            dtpFirstDate.Visible = true;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome form = new frmHome();
            form.Show();
            this.Hide();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void manageModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLecturerMenu frm = new frmLecturerMenu();
            frm.Show();
            this.Hide();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = bll.AssessmentbyDates(dtpFirstDate.Text, dtpLastDate.Text);
        }

        private void btnAllAssessments_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = bll.ListAssessments();
        }

        private void btnSearchSpecific_Click(object sender, EventArgs e)
        {
            
            dgvReport.DataSource = dal.GetAssessmentByType(cmbType.Text);
        }
    }
}
