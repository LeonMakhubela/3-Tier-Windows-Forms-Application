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
    public partial class frmAssessment : Form
    {
        public frmAssessment()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Assessment assessment = new Assessment(int.Parse(dgvDisplay.SelectedRows[0].Cells["AssessmentID"].Value.ToString()),
                int.Parse(cmbStuLecMod.SelectedValue.ToString()), dtpAssess.Text, int.Parse(cmbType.SelectedValue.ToString()), cmbStatus.SelectedItem.ToString());

            int x = bll.UpdateAssessments(assessment);

            if (x > 0)
            {
                MessageBox.Show(x + " Assessment was Updated.");
                dgvDisplay.DataSource = bll.ListAssessments();
            }
        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLecturerMenu frmLecturerMenu = new frmLecturerMenu();

            frmLecturerMenu.Show();
            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            frmLecturerMenu frmLecturerMenu = new frmLecturerMenu();

            frmLecturerMenu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmAssessment_Load(object sender, EventArgs e)
        {
            string[] statuses = new string[] { "Complete", "Missed", "Not-Yet-Due" };
            cmbStatus.DataSource = statuses;
            cmbStatus.SelectedIndex = 0;

            cmbType.DataSource = bll.GetAssessmentType();
            cmbType.DisplayMember = "AssessmentTypeDescription";
            cmbType.ValueMember = "AssessmentTypeID";

            cmbStuLecMod.DataSource = bll.GetStudentLecturerModule();
            cmbStuLecMod.DisplayMember = "StudentLecturerModule";
            cmbStuLecMod.ValueMember = "StudentModuleID";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvModules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDisplay.SelectedRows.Count > 0)
            {
                cmbStuLecMod.Text = dgvDisplay.SelectedRows[0].Cells["StudentLecturerModule"].Value.ToString();
                cmbType.Text = dgvDisplay.SelectedRows[0].Cells["AssessmentTypeDescription"].Value.ToString();
                dtpAssess.Text = dgvDisplay.SelectedRows[0].Cells["DueDate"].Value.ToString();
                cmbStatus.Text = dgvDisplay.SelectedRows[0].Cells["AssessmentStatus"].Value.ToString();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dgvDisplay.DataSource = bll.ListAssessments();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Assessment assessment = new Assessment(int.Parse(cmbStuLecMod.SelectedValue.ToString()), dtpAssess.Text,
            int.Parse(cmbType.SelectedValue.ToString()), cmbStatus.SelectedItem.ToString());

            int x = bll.InsertAssessments(assessment);
            if (x > 0)
            {
                MessageBox.Show(x + " Assessment was Completed.");
                dgvDisplay.DataSource = bll.ListAssessments();
            }
        }
    }
}
