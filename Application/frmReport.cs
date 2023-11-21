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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
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
            frmModules form = new frmModules();
            form.Show();
            this.Hide();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReg form = new frmReg();
            form.Show();
            this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers form = new frmUsers();
            form.Show();
            this.Hide();
        }

        private void btnAssess_Click(object sender, EventArgs e)
        {
           
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            frmModuleReport form = new frmModuleReport();
            form.Show();
            this.Hide();
        }
    }
}
