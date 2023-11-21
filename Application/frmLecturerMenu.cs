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
    public partial class frmLecturerMenu : Form
    {
        public frmLecturerMenu()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome form = new frmHome();
            form.Show();
            this.Hide();
        }

        private void btnAssessmentType_Click(object sender, EventArgs e)
        {
            frmAssessmentType form = new frmAssessmentType();
            form.Show(); 
            this.Hide();
        }

        private void btAssessments_Click(object sender, EventArgs e)
        {
            frmAssessment frmAssessment = new frmAssessment();
            frmAssessment.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAssessmentReport frm = new frmAssessmentReport();
            frm.Show();
            this.Hide();
        }
    }
}
