using DAL;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONT_Project_2023
{
    public partial class frmStudentAssessment : Form
    {
        public frmStudentAssessment()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmStudentMenu frmLecturerMenu = new frmStudentMenu();

            frmLecturerMenu.Show();
            this.Close();
        }

        private void frmStudentAssessment_Load(object sender, EventArgs e)
        {
            string[] statuses = new string[] { "Complete", "Missed", "Not-Yet-Due" };
            cmbStatus.DataSource = statuses;
            cmbStatus.SelectedIndex = 0;
        }
        public int Validate(bool validate, int y)
        {
            if (string.IsNullOrEmpty(cmbStatus.Text))
            {
                err.SetError(cmbStatus, "Please Enter Something!");
                validate = false;
                y--;
            }
            else
            {
                validate = true;
                err.Clear();
                y++;
            }


            if (y >= 1)
            {
                return y = 7;
            }
            else
            {
                return y;
            }


        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int y = 0;

            y = Validate(false, y);


            if (y > 1)
            {

                Assessment assessment = new Assessment(int.Parse(dgvAssess.SelectedRows[0].Cells["AssessmentID"].Value.ToString()), cmbStatus.Text);

                int x = bll.UpdateStudentAssessment(assessment);

                if (x > 0)
                {
                    MessageBox.Show(x + " Assessment was Updated.");
                    dgvAssess.DataSource = bll.ListAssessments();
                }
            }
            else
            {
                MessageBox.Show("Something went wrong, \n\nfailed to save data", "Fail Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dgvAssess.DataSource = bll.ListAssessments();
        }
    }
}
