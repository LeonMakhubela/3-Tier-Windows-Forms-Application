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
    public partial class frmReg : Form
    {
        public frmReg()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dal = new DataAccessLayer();

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
            frmReport form = new frmReport();
            form.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = false;
            int y = 0;
            y = Validate(validate, y);
            if (y >= 4)
            {
               
                classUser user = new classUser(int.Parse(txtID.Text),txt_Name.Text, txt_Surname.Text, cmbTitle.Text, cmb_Role.Text, txt_Email.Text, txt_Password.Text, cmb_Status.Text);
                if (cmb_Role.Text == "Administrator")
                {
                    classStudent student = new classStudent();
                    classLecturer lecturer = new classLecturer();
                    classAdministrator admin = new classAdministrator(int.Parse(txtID.Text));
                    int x = bll.InsertUser(user, admin,lecturer, student);

                    if (x > 0)
                    {
                        MessageBox.Show(x + " Added." +
                            "\nPlease continue to login.", "***EXECUTION WINDOW***", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtID.ResetText();
                        txt_Email.ResetText();
                        txt_Password.ResetText();
                        txt_Name.ResetText();
                        txt_Surname.ResetText();
                        cmbTitle.ResetText();
                        cmb_Role.ResetText();
                        cmb_Status.ResetText();

                        //pnl_Login_Admin.BringToFront();
                        //pnl_Register_Admin.SendToBack();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong, \n\nfailed to save data", "***EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
                else if (cmb_Role.Text == "Lecture")
                {
                    classStudent student = new classStudent();
                    classAdministrator admin = new classAdministrator();
                    classLecturer lecturer = new classLecturer(int.Parse(txtID.Text));
                    int x = bll.InsertUser(user, admin,lecturer, student);

                    if (x > 0)
                    {
                        MessageBox.Show(x + " Added." +
                            "\nPlease continue to login.", "***EXECUTION WINDOW***", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtID.ResetText();
                        txt_Email.ResetText();
                        txt_Password.ResetText();
                        txt_Name.ResetText();
                        txt_Surname.ResetText();
                        cmbTitle.ResetText();
                        cmb_Role.ResetText();
                        cmb_Status.ResetText();

                        //pnl_Login_Admin.BringToFront();
                        //pnl_Register_Admin.SendToBack();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong, \n\nfailed to save data", "***EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
                else if (cmb_Role.Text == "Student")
                {
                    classStudent student = new classStudent(int.Parse(txtID.Text));
                    classAdministrator admin = new classAdministrator();
                    classLecturer lecturer = new classLecturer();
                    int x = bll.InsertUser(user, admin,lecturer,student);

                    if (x > 0)
                    {
                        MessageBox.Show(x + " Added." +
                            "\nPlease continue to login.", "***EXECUTION WINDOW***", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtID.ResetText();
                        txt_Email.ResetText();
                        txt_Password.ResetText();
                        txt_Name.ResetText();
                        txt_Surname.ResetText();
                        cmbTitle.ResetText();
                        cmb_Role.ResetText();
                        cmb_Status.ResetText();

                        //pnl_Login_Admin.BringToFront();
                        //pnl_Register_Admin.SendToBack();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong, \n\nfailed to save data", "***EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }

                classUser user1 = new classUser();
                dgvReg.DataSource = bll.SelectUser(user1);



            }
        }


        private void frmReg_Load(object sender, EventArgs e)
        {

           txtID.Enabled = false;
            cmb_Role.Text = "Administrator";


            if(cmb_Role.Text == "Administrator")
            {
                classAdministrator user = new classAdministrator();
                DataTable dt = new DataTable();

                dt = bll.SelectHighAdminID(user);

                try
                {
                    int id = int.Parse(dt.Rows[0]["HighestUserID"].ToString());
                    id = id + 1;
                    txtID.Text = id.ToString();

                }
                catch
                {
                    int id = 1;
                    txtID.Text = id.ToString();

                }
            }

            cmb_Status.Items.Add("Active");
            cmb_Status.Items.Add("In-Active");


            cmbTitle.Items.Add("Mr");
            cmbTitle.Items.Add("Miss");
            cmbTitle.Items.Add("Dr");


            cmb_Role.Items.Add("Student");
            cmb_Role.Items.Add("Administrator");
            cmb_Role.Items.Add("Lecture");
        }

        public int Validate(bool validate, int y)
        {
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                err_Name.SetError(txt_Name, "Please Enter your name!");
                validate = false;
                y--;
            }
            else
            {
                validate = true;
                err_Name.Clear();
                y++;
            }

            if (string.IsNullOrEmpty(txt_Surname.Text))
            {
                err_Surname.SetError(txt_Surname, "Please Enter your surname!");
                validate = false;
                y--;
            }
            else
            {
                validate = true;
                err_Surname.Clear();
                y++;
            }

            if (string.IsNullOrEmpty(txt_Email.Text) || (!Regex.IsMatch(txt_Email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
            {
                err_Email.SetError(txt_Email, "Please Enter your Email format correctly!");
                validate = false;
                y--;
            }
            else
            {
                validate = true;
                err_Email.Clear();
                y++;
            }

            if (string.IsNullOrEmpty(txt_Password.Text) || (!Regex.IsMatch(txt_Password.Text, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")))
            {
                error_Password.SetError(txt_Password, "Password correct FORMAT\n\n" +
                    "1. Has minimum 8 characters in length.\n" +
                    "2. At least one uppercase English letter.\n" +
                    "3. At least one lowercase English letter. \n" +
                    "4. At least one digit.\n" +
                    "5. At least one special character");
                validate = false;
                y--;
            }
            else
            {
                validate = true;
                error_Password.Clear();
                y++;
            }

            if (y >= 4)
            {
                return y = 7;
            }
            else
            {
                return y;
            }


        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            classUser user = new classUser();
            dgvReg.DataSource = bll.SelectUser(user);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool validate = false;
            int y = 0;
            y = Validate(validate, y);
            if (y >= 4)
            {
                classUser user = new classUser(int.Parse(txtID.Text), txt_Name.Text, txt_Surname.Text, cmbTitle.Text, cmb_Role.Text, txt_Email.Text, txt_Password.Text, cmb_Status.Text);
                int x = bll.UpdateUser(user);

                if (x > 0)
                {
                    MessageBox.Show(x + " Updated" +
                        "\nPlease continue to login.", "***EXECUTION WINDOW***", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtID.ResetText();
                    txt_Email.ResetText();
                    txt_Password.ResetText();
                    txt_Name.ResetText();
                    txt_Surname.ResetText();
                    cmbTitle.ResetText();
                    cmb_Role.ResetText();
                    cmb_Status.ResetText();

                    
                }
                else
                {
                    MessageBox.Show("Something went wrong, \n\nfailed to save data", "***EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }

            }

            classUser user1 = new classUser();
            dgvReg.DataSource = bll.SelectUser(user1);
        }

        private void dgvReg_Click(object sender, EventArgs e)
        {
            if (dgvReg.SelectedRows.Count > 0)
            {
                txtID.Text = dgvReg.SelectedRows[0].Cells["UserID"].Value.ToString();
                txt_Name.Text = dgvReg.SelectedRows[0].Cells["Name"].Value.ToString();
                txt_Surname.Text = dgvReg.SelectedRows[0].Cells["Surname"].Value.ToString();
                cmbTitle.Text = dgvReg.SelectedRows[0].Cells["Title"].Value.ToString();
                cmb_Role.Text = dgvReg.SelectedRows[0].Cells["Role"].Value.ToString();
                txt_Email.Text = dgvReg.SelectedRows[0].Cells["Email"].Value.ToString();
                txt_Password.Text = dgvReg.SelectedRows[0].Cells["Password"].Value.ToString();
                cmb_Status.Text = dgvReg.SelectedRows[0].Cells["UserStatus"].Value.ToString();

            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            classUser user = new classUser(int.Parse(txtID.Text));
            int y = bll.DeleteUser(user);

            if (cmb_Role.Text == "Administrator")
            {
                classAdministrator admin = new classAdministrator(int.Parse(txtID.Text));
                int x = bll.DeleteAdmin(admin);

                if (x > 0)
                {
                    MessageBox.Show(x + " Added." +
                        "\nPlease continue to login.", "***EXECUTION WINDOW***", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtID.ResetText();
                    txt_Email.ResetText();
                    txt_Password.ResetText();
                    txt_Name.ResetText();
                    txt_Surname.ResetText();
                    cmbTitle.ResetText();
                    cmb_Role.ResetText();
                    cmb_Status.ResetText();

                    //pnl_Login_Admin.BringToFront();
                    //pnl_Register_Admin.SendToBack();
                }
                else
                {
                    MessageBox.Show("Something went wrong, \n\nfailed to save data", "***EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            else if (cmb_Role.Text == "Lecture")
            {
                classLecturer lecturer = new classLecturer(int.Parse(txtID.Text));
                int x = bll.DeleteLecturer(lecturer);

                if (x > 0)
                {
                    MessageBox.Show(x + " Added." +
                        "\nPlease continue to login.", "***EXECUTION WINDOW***", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtID.ResetText();
                    txt_Email.ResetText();
                    txt_Password.ResetText();
                    txt_Name.ResetText();
                    txt_Surname.ResetText();
                    cmbTitle.ResetText();
                    cmb_Role.ResetText();
                    cmb_Status.ResetText();

                    //pnl_Login_Admin.BringToFront();
                    //pnl_Register_Admin.SendToBack();
                }
                else
                {
                    MessageBox.Show("Something went wrong, \n\nfailed to save data", "***EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            else if (cmb_Role.Text == "Student")
            {
                classStudent student = new classStudent(int.Parse(txtID.Text));
                int x = bll.DeleteStudent(student);

                if (x > 0)
                {
                    MessageBox.Show(x + " Added." +
                        "\nPlease continue to login.", "***EXECUTION WINDOW***", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtID.ResetText();
                    txt_Email.ResetText();
                    txt_Password.ResetText();
                    txt_Name.ResetText();
                    txt_Surname.ResetText();
                    cmbTitle.ResetText();
                    cmb_Role.ResetText();
                    cmb_Status.ResetText();

                    //pnl_Login_Admin.BringToFront();
                    //pnl_Register_Admin.SendToBack();
                }
                else
                {
                    MessageBox.Show("Something went wrong, \n\nfailed to save data", "***EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }



            classUser user1 = new classUser();
            dgvReg.DataSource = bll.SelectUser(user1);



        }

        private void cmb_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Role.Text == "Administrator")
            {
                classAdministrator user = new classAdministrator();
                DataTable dt = new DataTable();

                dt = bll.SelectHighAdminID(user);

                try
                {
                    int id = int.Parse(dt.Rows[0]["HighestUserID"].ToString());
                    id = id + 1;
                    txtID.Text = id.ToString();

                }
                catch
                {
                    int id = 1;
                    txtID.Text = id.ToString();

                }
            }
            else if (cmb_Role.Text == "Student")
            {
                classStudent user = new classStudent();
                DataTable dt = new DataTable();

                dt = bll.SelectHighStudentID(user);

                try
                {
                    int id = int.Parse(dt.Rows[0]["HighestUserID"].ToString());
                    id = id + 1;
                    txtID.Text = id.ToString();

                }
                catch
                {
                    int id = 22000000;
                    txtID.Text = id.ToString();

                }
            }
            else if(cmb_Role.Text == "Lecture")
            {
                classLecturer user = new classLecturer();
                DataTable dt = new DataTable();

                dt = bll.SelectHighLecturerID(user);
                try
                {
                    int id = int.Parse(dt.Rows[0]["HighestUserID"].ToString());
                    id = id + 1;
                    txtID.Text = id.ToString();
                    
                }
                catch 
                {
                    int id = 33000000;
                    txtID.Text = id.ToString();

                }

            }
        }
    }
}

