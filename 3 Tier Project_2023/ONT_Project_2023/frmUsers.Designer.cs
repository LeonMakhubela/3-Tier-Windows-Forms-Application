namespace ONT_Project_2023
{
    partial class frmUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSpecificUsers = new System.Windows.Forms.Button();
            this.btnSingleUser = new System.Windows.Forms.Button();
            this.btnAllUsers = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbSpecificUsers = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSearchSpecific = new System.Windows.Forms.Button();
            this.grbUser = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.mstAdm = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageLecturerModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAssessmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAssessmentTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageModulesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbSpecificUsers.SuspendLayout();
            this.grbUser.SuspendLayout();
            this.mstAdm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpecificUsers
            // 
            this.btnSpecificUsers.Location = new System.Drawing.Point(253, 225);
            this.btnSpecificUsers.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnSpecificUsers.Name = "btnSpecificUsers";
            this.btnSpecificUsers.Size = new System.Drawing.Size(176, 27);
            this.btnSpecificUsers.TabIndex = 28;
            this.btnSpecificUsers.Text = "Search Specific Users";
            this.btnSpecificUsers.UseVisualStyleBackColor = true;
            this.btnSpecificUsers.Click += new System.EventHandler(this.btnSpecificUsers_Click);
            // 
            // btnSingleUser
            // 
            this.btnSingleUser.Location = new System.Drawing.Point(795, 225);
            this.btnSingleUser.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnSingleUser.Name = "btnSingleUser";
            this.btnSingleUser.Size = new System.Drawing.Size(176, 27);
            this.btnSingleUser.TabIndex = 27;
            this.btnSingleUser.Text = "Search User";
            this.btnSingleUser.UseVisualStyleBackColor = true;
            this.btnSingleUser.Click += new System.EventHandler(this.btnSingleUser_Click);
            // 
            // btnAllUsers
            // 
            this.btnAllUsers.Location = new System.Drawing.Point(508, 225);
            this.btnAllUsers.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnAllUsers.Name = "btnAllUsers";
            this.btnAllUsers.Size = new System.Drawing.Size(176, 27);
            this.btnAllUsers.TabIndex = 26;
            this.btnAllUsers.Text = "List All Users";
            this.btnAllUsers.UseVisualStyleBackColor = true;
            this.btnAllUsers.Click += new System.EventHandler(this.btnAllUsers_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1176, 328);
            this.dataGridView1.TabIndex = 29;
            // 
            // grbSpecificUsers
            // 
            this.grbSpecificUsers.Controls.Add(this.comboBox1);
            this.grbSpecificUsers.Controls.Add(this.btnSearchSpecific);
            this.grbSpecificUsers.Location = new System.Drawing.Point(12, 24);
            this.grbSpecificUsers.Name = "grbSpecificUsers";
            this.grbSpecificUsers.Size = new System.Drawing.Size(570, 192);
            this.grbSpecificUsers.TabIndex = 30;
            this.grbSpecificUsers.TabStop = false;
            this.grbSpecificUsers.Text = "Search Specific Users";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(478, 26);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Select";
            // 
            // btnSearchSpecific
            // 
            this.btnSearchSpecific.Location = new System.Drawing.Point(225, 113);
            this.btnSearchSpecific.Name = "btnSearchSpecific";
            this.btnSearchSpecific.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSpecific.TabIndex = 0;
            this.btnSearchSpecific.Text = "Search";
            this.btnSearchSpecific.UseVisualStyleBackColor = true;
            // 
            // grbUser
            // 
            this.grbUser.Controls.Add(this.textBox1);
            this.grbUser.Controls.Add(this.btnSearchUser);
            this.grbUser.Location = new System.Drawing.Point(598, 24);
            this.grbUser.Name = "grbUser";
            this.grbUser.Size = new System.Drawing.Size(590, 192);
            this.grbUser.TabIndex = 31;
            this.grbUser.TabStop = false;
            this.grbUser.Text = "Search A User";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(512, 24);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Enter The Name Or Student Number/Staff Number/Administrator Name";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(259, 103);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(75, 23);
            this.btnSearchUser.TabIndex = 1;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            // 
            // mstAdm
            // 
            this.mstAdm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mstAdm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.mstAdm.Location = new System.Drawing.Point(0, 0);
            this.mstAdm.Name = "mstAdm";
            this.mstAdm.Size = new System.Drawing.Size(1200, 24);
            this.mstAdm.TabIndex = 47;
            this.mstAdm.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.mainMenuToolStripMenuItem,
            this.manageModulesToolStripMenuItem,
            this.manageUsersToolStripMenuItem,
            this.manageLecturerModulesToolStripMenuItem,
            this.manageStudentModulesToolStripMenuItem,
            this.manageAssessmentsToolStripMenuItem,
            this.manageAssessmentTypeToolStripMenuItem,
            this.manageModulesToolStripMenuItem1});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Sienna;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItem1.Text = "SubMenu";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.homeToolStripMenuItem.Text = "Home(Log Out)";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // manageModulesToolStripMenuItem
            // 
            this.manageModulesToolStripMenuItem.Name = "manageModulesToolStripMenuItem";
            this.manageModulesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.manageModulesToolStripMenuItem.Text = "Reports";
            this.manageModulesToolStripMenuItem.Click += new System.EventHandler(this.manageModulesToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // manageLecturerModulesToolStripMenuItem
            // 
            this.manageLecturerModulesToolStripMenuItem.Name = "manageLecturerModulesToolStripMenuItem";
            this.manageLecturerModulesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.manageLecturerModulesToolStripMenuItem.Text = "Manage Lecturer Modules";
            // 
            // manageStudentModulesToolStripMenuItem
            // 
            this.manageStudentModulesToolStripMenuItem.Name = "manageStudentModulesToolStripMenuItem";
            this.manageStudentModulesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.manageStudentModulesToolStripMenuItem.Text = "Manage Student Modules";
            // 
            // manageAssessmentsToolStripMenuItem
            // 
            this.manageAssessmentsToolStripMenuItem.Name = "manageAssessmentsToolStripMenuItem";
            this.manageAssessmentsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.manageAssessmentsToolStripMenuItem.Text = "Manage Assessments";
            // 
            // manageAssessmentTypeToolStripMenuItem
            // 
            this.manageAssessmentTypeToolStripMenuItem.Name = "manageAssessmentTypeToolStripMenuItem";
            this.manageAssessmentTypeToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.manageAssessmentTypeToolStripMenuItem.Text = "Manage Assessment Type";
            // 
            // manageModulesToolStripMenuItem1
            // 
            this.manageModulesToolStripMenuItem1.Name = "manageModulesToolStripMenuItem1";
            this.manageModulesToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.manageModulesToolStripMenuItem1.Text = "Manage Modules";
            this.manageModulesToolStripMenuItem1.Click += new System.EventHandler(this.manageModulesToolStripMenuItem1_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.mstAdm);
            this.Controls.Add(this.grbUser);
            this.Controls.Add(this.grbSpecificUsers);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSpecificUsers);
            this.Controls.Add(this.btnSingleUser);
            this.Controls.Add(this.btnAllUsers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbSpecificUsers.ResumeLayout(false);
            this.grbUser.ResumeLayout(false);
            this.grbUser.PerformLayout();
            this.mstAdm.ResumeLayout(false);
            this.mstAdm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpecificUsers;
        private System.Windows.Forms.Button btnSingleUser;
        private System.Windows.Forms.Button btnAllUsers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbSpecificUsers;
        private System.Windows.Forms.GroupBox grbUser;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSearchSpecific;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip mstAdm;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageModulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageLecturerModulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentModulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAssessmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAssessmentTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageModulesToolStripMenuItem1;
    }
}