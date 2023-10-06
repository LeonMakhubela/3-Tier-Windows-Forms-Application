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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void btnAllUsers_Click(object sender, EventArgs e)
        {

        }

        private void btnSingleUser_Click(object sender, EventArgs e)
        {
            if (grbUser.Visible == true)
                grbUser.Visible = false;
            else
                grbUser.Visible = true;
        }

        private void btnSpecificUsers_Click(object sender, EventArgs e)
        {
            if (grbSpecificUsers.Visible == true)
                grbSpecificUsers.Visible = false;
            else
            grbSpecificUsers.Visible = true;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            grbUser.Visible = false;
            grbSpecificUsers.Visible = false;
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
    }
}
