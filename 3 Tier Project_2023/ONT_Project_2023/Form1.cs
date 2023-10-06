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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            grbSignIn.Hide();
            btnRegister.Visible = false;
        }

        private void rdbYes_CheckedChanged(object sender, EventArgs e)
        {
            grbSignIn.Hide();
            btnRegister.Visible = true;
        }

        private void rdbNo_CheckedChanged(object sender, EventArgs e)
        {
            grbSignIn.Show();
            btnRegister.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmReg form = new frmReg();
            form.Show();
            this.Hide();
            
        }
    }
}
