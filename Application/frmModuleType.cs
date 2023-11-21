using BLL;
using DAL;
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
    public partial class frmModuleType : Form
    {
        public frmModuleType()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmLecturerMenu = new frmMain();
            frmLecturerMenu.Show();
            this.Hide();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dgvModules.DataSource = bll.SelectModuleType();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModuleType moduleType = new ModuleType(txtModuleTypeDesc.Text);

            int x = bll.InsertModuleTypes(moduleType);
            if (x > 0)
            {
                MessageBox.Show(x + " Module Type was Added.");
                txtModuleTypeDesc.Clear();
                dgvModules.DataSource = bll.SelectModuleType();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            ModuleType moduleType = new ModuleType(int.Parse(dgvModules.SelectedRows[0].Cells["ModuleTypeID"].Value.ToString()), txtModuleTypeDesc.Text);
            int x = bll.UpdateModuleTypes(moduleType);

            if (x > 0)
            {
                MessageBox.Show(x + " Module Type was Updated.");
                txtModuleTypeDesc.Clear();
                dgvModules.DataSource= bll.SelectModuleType();
            }
        }

        private void dgvModules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvModules.SelectedRows.Count > 0)
            {
                txtModuleTypeDesc.Text = dgvModules.SelectedRows[0].Cells["ModuleTypeDescription"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModuleType moduleType = new ModuleType(int.Parse(dgvModules.SelectedRows[0].Cells["ModuleTypeID"].Value.ToString()));
            int x = bll.DeleteModuleTypes(moduleType);

            if (x > 0)
            {
                MessageBox.Show(x + " Module Type was Deleted.");
                txtModuleTypeDesc.Clear();
                dgvModules.DataSource = bll.SelectModuleType();
            }
        }
    }
}
