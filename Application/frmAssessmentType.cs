using DAL;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ONT_Project_2023
{
    public partial class frmAssessmentType : Form
    {
        public frmAssessmentType()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLecturerMenu frmLecturerMenu = new frmLecturerMenu();

            frmLecturerMenu.Show();
            this.Close();
        }

        private void frmAssessmentType_Load(object sender, EventArgs e)
        {
            
        }

        public int Validate(bool validate, int y)
        {
            if (string.IsNullOrEmpty(txtAssessmentTypeDesc.Text))
            {
                err.SetError(txtAssessmentTypeDesc, "Please Enter your name!");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            int y = 0;

            y = Validate(false, y);

            if(y > 1)
            {
                AssessmentType assessmentType = new AssessmentType(txtAssessmentTypeDesc.Text);

                int x = bll.InsertAssessmentTypes(assessmentType);
                if (x > 0)
                {
                    MessageBox.Show(x + " Assessment Type was Added.");
                    txtAssessmentTypeDesc.Clear();
                }
            }
            else
            {
                MessageBox.Show("Something went wrong, \n\nfailed to save data", "Fail Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AssessmentType assessmentType = new AssessmentType(int.Parse(dgvModules.SelectedRows[0].Cells["AssessmentTypeID"].Value.ToString()), txtAssessmentTypeDesc.Text);
            int x = bll.UpdateAssessmentTypes(assessmentType);

            if (x > 0)
            {
                MessageBox.Show(x + " Assessment Type was Updated.");
                txtAssessmentTypeDesc.Clear();
                Display();
            }
        }
        public void Display()
        {
            dgvModules.DataSource = bll.ListAssessmentTypes();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dgvModules.DataSource = bll.ListAssessmentTypes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AssessmentType assessmentType = new AssessmentType(int.Parse(dgvModules.SelectedRows[0].Cells["AssessmentTypeID"].Value.ToString()));
            int x = bll.DeleteAssessmentTypes(assessmentType);

            if (x > 0)
            {
                MessageBox.Show(x + " Assessment Type was Deleted.");
                txtAssessmentTypeDesc.Clear();
                Display();
            }
        }

        private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvModules.SelectedRows.Count > 0)
            {
                txtAssessmentTypeDesc.Text = dgvModules.SelectedRows[0].Cells["AssessmentTypeDescription"].Value.ToString();
            }
        }
    }
}
