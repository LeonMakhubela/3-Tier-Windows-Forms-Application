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
using DAL;

namespace ONT_Project_2023
{
    public partial class frmLecModules : Form
    {
        public frmLecModules()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }

        private void frmLecModules_Load(object sender, EventArgs e)
        {
            cmbLecName.DataSource = bll.SelectLecture();
            cmbLecName.DisplayMember = "Name";
            cmbLecName.ValueMember = "UserID";

            cmbModuleName.DataSource = bll.GetModule();
            cmbModuleName.DisplayMember = "ModuleName";
            cmbModuleName.ValueMember = "ModuleID";

            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("In-Active");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dgvModules.DataSource = bll.ListLecturerModules();
        }
        public void Display()
        {
            dgvModules.DataSource = bll.ListLecturerModules();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LecturerModule lecturerModule = new LecturerModule(int.Parse(cmbLecName.SelectedValue.ToString()), int.Parse(cmbModuleName.SelectedValue.ToString()),
                dtpDate.Text, cmbStatus.SelectedItem.ToString());

            int x = bll.InsertLecturerModules(lecturerModule);
            if (x > 0)
            {
                MessageBox.Show(x + " Module was assigned.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LecturerModule lecturerModule = new LecturerModule(int.Parse(dgvModules.SelectedRows[0].Cells["LecturerModuleID"].Value.ToString()), int.Parse(cmbLecName.SelectedValue.ToString()), int.Parse(cmbModuleName.SelectedValue.ToString()),
                dtpDate.Text, cmbStatus.SelectedItem.ToString());

            int x = bll.UpdateLecturerModules(lecturerModule);

            if (x > 0)
            {
                MessageBox.Show(x + " Module was assigned.");
                Display();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LecturerModule lecturerModule = new LecturerModule(int.Parse(dgvModules.SelectedRows[0].Cells["LecturerModuleID"].Value.ToString()));

            int x = bll.DeleteLecturerModules(lecturerModule);

            if (x > 0)
            {
                MessageBox.Show(x + " Lecturer was deleted to a module.");
                Display();
            }
        }
    }
}
