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
using DAL;
using BLL;
using System.IO;

namespace ONT_Project_2023
{
    public partial class frmUsers : Form
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dal = new DataAccessLayer();
        public frmUsers()
        {
            InitializeComponent();
        }

        private void btnAllUsers_Click(object sender, EventArgs e)
        {
            classUser user = new classUser();
            dgvDisplay.DataSource = bll.SelectUser(user);
        }

        private void btnSingleUser_Click(object sender, EventArgs e)
        {

        }

        private void btnSpecificUsers_Click(object sender, EventArgs e)
        {

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            grbUser.Visible = false;
            grbSpecificUsers.Visible = false;

            cmbUserRoles.Items.Add("Student");
            cmbUserRoles.Items.Add("Administrator");
            cmbUserRoles.Items.Add("Lecture");
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
            frmReport form = new frmReport();
            form.Show();
            this.Hide();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReg form = new frmReg();
            form.Show();
            this.Hide();
        }

        private void manageModulesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmModules form = new frmModules();
            form.Show();
            this.Hide();
        }

        private void btnSpecificUsers_Click_1(object sender, EventArgs e)
        {
            if(grbSpecificUsers.Visible == false)
            grbSpecificUsers.Visible = true;
            else
                grbSpecificUsers.Visible = false;
        }

        private void btnSingleUser_Click_1(object sender, EventArgs e)
        {
            if (grbUser.Visible == false)
                grbUser.Visible = true;
            else
                grbUser.Visible = false;
        }

        private void btnSearchByRole_Click(object sender, EventArgs e)
        {

            if (cmbUserRoles.Text == "Student")
            {
                classStudent user = new classStudent();
                dgvDisplay.DataSource = bll.SelectStudents();
            }
            else if (cmbUserRoles.Text == "Administrator")
            {
                classAdministrator user = new classAdministrator();
                dgvDisplay.DataSource = bll.SelectAdminstrator(user);
                
            }
            else if (cmbUserRoles.Text == "Lecture")
            {
                
                dgvDisplay.DataSource = bll.SelectLecture();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }
    }
}
