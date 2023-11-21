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
    public partial class frmModuleReport : Form
    {
        public frmModuleReport()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dal = new DataAccessLayer();
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {


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

        private void mainMenuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMain form = new frmMain();
            form.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLecturerMenu frmLecturerMenu = new frmLecturerMenu();

            frmLecturerMenu.Show();
            this.Close();
        }

        private void btnAllUsers_Click(object sender, EventArgs e)
        {
            dgvDisplay.DataSource =  bll.ListLecturerModules();
        }

        private void frmModuleReport_Load(object sender, EventArgs e)
        {
            cmbModuleTypeDesc.DataSource = bll.GetModuleType();
            cmbModuleTypeDesc.DisplayMember = "ModuleTypeDescription";
            cmbModuleTypeDesc.ValueMember = "ModuleTypeID";
        }

        private void btnSearchSpecific_Click(object sender, EventArgs e)
        {
            dgvDisplay.DataSource = dal.ModulebyType(cmbModuleTypeDesc.Text);
        }
    }
}
