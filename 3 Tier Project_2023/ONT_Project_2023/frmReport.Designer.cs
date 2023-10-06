namespace ONT_Project_2023
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.btnModules = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAssess = new System.Windows.Forms.Button();
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
            this.mstAdm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModules
            // 
            this.btnModules.Location = new System.Drawing.Point(391, 209);
            this.btnModules.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(127, 23);
            this.btnModules.TabIndex = 22;
            this.btnModules.Text = "Modules Reports";
            this.btnModules.UseVisualStyleBackColor = true;
            this.btnModules.Click += new System.EventHandler(this.btnModules_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(391, 148);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(127, 23);
            this.btnUsers.TabIndex = 21;
            this.btnUsers.Text = "Users Reports";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(335, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 34);
            this.label7.TabIndex = 46;
            this.label7.Text = "Reports Page";
            // 
            // btnAssess
            // 
            this.btnAssess.Location = new System.Drawing.Point(391, 274);
            this.btnAssess.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAssess.Name = "btnAssess";
            this.btnAssess.Size = new System.Drawing.Size(127, 23);
            this.btnAssess.TabIndex = 47;
            this.btnAssess.Text = "Assessment Reports";
            this.btnAssess.UseVisualStyleBackColor = true;
            this.btnAssess.Click += new System.EventHandler(this.btnAssess_Click);
            // 
            // mstAdm
            // 
            this.mstAdm.BackColor = System.Drawing.Color.Transparent;
            this.mstAdm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.mstAdm.Location = new System.Drawing.Point(0, 0);
            this.mstAdm.Name = "mstAdm";
            this.mstAdm.Size = new System.Drawing.Size(800, 24);
            this.mstAdm.TabIndex = 48;
            this.mstAdm.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.mainMenuToolStripMenuItem,
            this.manageModulesToolStripMenuItem,
            this.manageUsersToolStripMenuItem,
            this.manageLecturerModulesToolStripMenuItem,
            this.manageStudentModulesToolStripMenuItem,
            this.manageAssessmentsToolStripMenuItem,
            this.manageAssessmentTypeToolStripMenuItem});
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
            this.manageModulesToolStripMenuItem.Text = "Manage Modules";
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
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mstAdm);
            this.Controls.Add(this.btnAssess);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnModules);
            this.Controls.Add(this.btnUsers);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.mstAdm.ResumeLayout(false);
            this.mstAdm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModules;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAssess;
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
    }
}