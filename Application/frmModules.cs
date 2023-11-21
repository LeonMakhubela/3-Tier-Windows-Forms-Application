using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace ONT_Project_2023
{
    public partial class frmModules : Form
    {
        public frmModules()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
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

        private void dgvModules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dgvModules.DataSource = bll.ListModules();
        }

        private void frmModules_Load(object sender, EventArgs e)
        {
            cmbModuleTypeDesc.DataSource = bll.GetModuleType();
            cmbModuleTypeDesc.DisplayMember = "ModuleTypeDescription";
            cmbModuleTypeDesc.ValueMember = "ModuleTypeID";

            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("In-Active");
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Module module = new Module(txtModuleName.Text, txtDuration.Text, int.Parse(cmbModuleTypeDesc.SelectedValue.ToString()),
                cmbStatus.SelectedItem.ToString());

            int x = bll.InsertModules(module);
            if (x > 0)
            {
                MessageBox.Show(x + " Module was Added.");
                txtModuleName.Clear();
                txtDuration.Clear();
                dgvModules.DataSource = bll.ListModules();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Module module = new Module(int.Parse(dgvModules.SelectedRows[0].Cells["ModuleID"].Value.ToString()), txtModuleName.Text,
                txtDuration.Text, int.Parse(cmbModuleTypeDesc.SelectedValue.ToString()), cmbStatus.SelectedItem.ToString());
            int x = bll.UpdateModules(module);

            if (x > 0)
            {
                MessageBox.Show(x + " Module was Updated.");
                txtModuleName.Clear();
                txtDuration.Clear();
                dgvModules.DataSource = bll.ListModules();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Module module = new Module(int.Parse(dgvModules.SelectedRows[0].Cells["ModuleID"].Value.ToString()));
            int x = bll.DeleteModules(module);

            if (x > 0)
            {
                MessageBox.Show(x + " Module was Deleted.");
                txtModuleName.Clear();
                txtDuration.Clear();
                dgvModules.DataSource = bll.ListModules();
            }
        }

        private void dgvModules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvModules.SelectedRows.Count > 0)
            {
                txtModuleName.Text = dgvModules.SelectedRows[0].Cells["ModuleName"].Value.ToString();
                txtDuration.Text = dgvModules.SelectedRows[0].Cells["ModuleDuration"].Value.ToString();
                
                
            }
        }
    }
}
