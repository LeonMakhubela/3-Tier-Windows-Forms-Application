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

using BLL;

namespace ONT_Project_2023
{
    public partial class frmStuModules : Form
    {
        public frmStuModules()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentModule studentModule = new StudentModule(int.Parse(cmbLecModule.SelectedValue.ToString()), int.Parse(cmbName.SelectedValue.ToString()),
              dtpDate.Text, cmbStatus.SelectedItem.ToString());

            int x = bll.InsertStudentModules(studentModule);
            if (x > 0)
            {
                MessageBox.Show(x + " Student was assigned to a module.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            StudentModule studentModule = new StudentModule(int.Parse(dgvModules.SelectedRows[0].Cells["StudentModuleID"].Value.ToString()),
                int.Parse(cmbLecModule.SelectedValue.ToString()), int.Parse(cmbName.SelectedValue.ToString()), dtpDate.Text,
                cmbStatus.SelectedItem.ToString());

            int x = bll.UpdateStudentModules(studentModule);

            if (x > 0)
            {
                MessageBox.Show(x + " Student was Updated to a module.");
                dgvModules.DataSource = bll.ListStudentModules();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
           dgvModules.DataSource = bll.ListStudentModules();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StudentModule studentModule = new StudentModule(int.Parse(dgvModules.SelectedRows[0].Cells["StudentModuleID"].Value.ToString()));

            int x = bll.DeleteStudentModules(studentModule);

            if (x > 0)
            {
                MessageBox.Show(x + " Student was deleted to a module.");
                dgvModules.DataSource = bll.ListStudentModules();
            }
        }

        private void dgvModules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvModules.SelectedRows.Count > 0)
            {
                cmbLecModule.Text = dgvModules.SelectedRows[0].Cells["LecturerModule"].Value.ToString();
                cmbName.Text = dgvModules.SelectedRows[0].Cells["StudentName"].Value.ToString();
                dtpDate.Text = dgvModules.SelectedRows[0].Cells["Date"].Value.ToString();
                cmbStatus.Text = dgvModules.SelectedRows[0].Cells["StudModStatus"].Value.ToString();
            }
        }

        private void frmStuModules_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Unavailable");

            cmbLecModule.DataSource = bll.GetLecturerModule();
            cmbLecModule.DisplayMember = "ModuleName";
            cmbLecModule.ValueMember = "LecturerModuleID";

            cmbName.DataSource = bll.SelectStudents();
            cmbName.DisplayMember = "Name";
            cmbName.ValueMember = "UserID";
        }
    }
}
