using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ONT_Project_2023
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();

        }
        DataTable dt;
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void rdbYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            classUser user = new classUser(txtEmail.Text, txtPassword.Text);
            dt = bll.UserLogin(user);
            try
            {
                string role = dt.Rows[0]["Role"].ToString();

                if (dt.Rows.Count > 0)
                {
                    if (role == "Administrator")
                    {
                        frmMain form = new frmMain();
                        form.Show();
                        this.Hide();
                    }
                    else if (role == "Lecture")
                    {
                    frmLecturerMenu form = new frmLecturerMenu();
                        form.Show();
                        this.Hide();
                    }
                    else if (role == "Student")
                    {
                        frmStudentMenu form = new frmStudentMenu();
                        form.Show();
                        this.Hide();
                    }
                }
            }
            catch
            {
                lblError.Visible = true;
            }
       }

        private void chbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPassword.Checked == true)
            {
                txtPassword.PasswordChar = (char)0;
                chbPassword.Text = "Hide";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                chbPassword.Text = "Show";
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAboutMe frmAboutUs = new frmAboutMe();  
            frmAboutUs.Show();
            this.Hide();
        }
    }
}
