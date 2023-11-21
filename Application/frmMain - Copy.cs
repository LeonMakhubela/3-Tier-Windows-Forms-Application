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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome form = new frmHome();
            form.Show();
            this.Hide();
        }

        private void btnRegPage_Click(object sender, EventArgs e)
        {
            frmReg form = new frmReg();
            form.Show();
            this.Hide();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnModuleMan_Click(object sender, EventArgs e)
        {

            frmModules form = new frmModules();
            form.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport form = new frmReport();
            form.Show();
            this.Hide();
        }
    }
}
