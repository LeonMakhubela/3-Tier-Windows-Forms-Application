using BLL;
using DAL;
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
    public partial class StudentAssessmentReport : Form
    {
        public StudentAssessmentReport()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dal = new DataAccessLayer();
        private void btnSearchSpecific_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = dal.GetAssessmentByType(cmbType.Text);
        }

        private void btnSpecificAssess_Click(object sender, EventArgs e)
        {

        }

        private void btnAllAssessments_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = dal.GetAssessmentByType(cmbType.Text);
        }

        private void btnTypeDate_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmStudentMenu frmStudentMenu = new frmStudentMenu();
            frmStudentMenu.Show();
            this.Hide();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = bll.AssessmentbyDates(dtpFirstDate.Text, dtpLastDate.Text);
        }

        private void StudentAssessmentReport_Load(object sender, EventArgs e)
        {
            cmbType.DataSource = bll.GetAssessmentType();
            cmbType.DisplayMember = "AssessmentTypeDescription";
            cmbType.ValueMember = "AssessmentTypeID";
        }
    }
}
