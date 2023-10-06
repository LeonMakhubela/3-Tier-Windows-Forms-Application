namespace ONT_Project_2023
{
    partial class frmAssessmentReport
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
            this.grbSpecificAssess = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSearchSpecific = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSpecificAssess = new System.Windows.Forms.Button();
            this.btnTypeDate = new System.Windows.Forms.Button();
            this.btnAllAssessments = new System.Windows.Forms.Button();
            this.grbType = new System.Windows.Forms.GroupBox();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.rdbDate = new System.Windows.Forms.RadioButton();
            this.rdbType = new System.Windows.Forms.RadioButton();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
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
            this.grbSpecificAssess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbType.SuspendLayout();
            this.mstAdm.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSpecificAssess
            // 
            this.grbSpecificAssess.Controls.Add(this.comboBox1);
            this.grbSpecificAssess.Controls.Add(this.btnSearchSpecific);
            this.grbSpecificAssess.Location = new System.Drawing.Point(21, 36);
            this.grbSpecificAssess.Name = "grbSpecificAssess";
            this.grbSpecificAssess.Size = new System.Drawing.Size(532, 192);
            this.grbSpecificAssess.TabIndex = 36;
            this.grbSpecificAssess.TabStop = false;
            this.grbSpecificAssess.Text = "Search Specific Assessment";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(508, 26);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Select";
            // 
            // btnSearchSpecific
            // 
            this.btnSearchSpecific.Location = new System.Drawing.Point(197, 106);
            this.btnSearchSpecific.Name = "btnSearchSpecific";
            this.btnSearchSpecific.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSpecific.TabIndex = 0;
            this.btnSearchSpecific.Text = "Search";
            this.btnSearchSpecific.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1176, 328);
            this.dataGridView1.TabIndex = 35;
            // 
            // btnSpecificAssess
            // 
            this.btnSpecificAssess.Location = new System.Drawing.Point(66, 237);
            this.btnSpecificAssess.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnSpecificAssess.Name = "btnSpecificAssess";
            this.btnSpecificAssess.Size = new System.Drawing.Size(227, 27);
            this.btnSpecificAssess.TabIndex = 34;
            this.btnSpecificAssess.Text = "Search Specific Assessment";
            this.btnSpecificAssess.UseVisualStyleBackColor = true;
            this.btnSpecificAssess.Click += new System.EventHandler(this.btnSpecificAssess_Click);
            // 
            // btnTypeDate
            // 
            this.btnTypeDate.Location = new System.Drawing.Point(759, 237);
            this.btnTypeDate.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnTypeDate.Name = "btnTypeDate";
            this.btnTypeDate.Size = new System.Drawing.Size(176, 27);
            this.btnTypeDate.TabIndex = 33;
            this.btnTypeDate.Text = "Search By Type Or Date";
            this.btnTypeDate.UseVisualStyleBackColor = true;
            this.btnTypeDate.Click += new System.EventHandler(this.btnTypeDate_Click);
            // 
            // btnAllAssessments
            // 
            this.btnAllAssessments.Location = new System.Drawing.Point(444, 237);
            this.btnAllAssessments.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnAllAssessments.Name = "btnAllAssessments";
            this.btnAllAssessments.Size = new System.Drawing.Size(227, 27);
            this.btnAllAssessments.TabIndex = 32;
            this.btnAllAssessments.Text = "List All Assessment";
            this.btnAllAssessments.UseVisualStyleBackColor = true;
            // 
            // grbType
            // 
            this.grbType.Controls.Add(this.datePick);
            this.grbType.Controls.Add(this.rdbDate);
            this.grbType.Controls.Add(this.rdbType);
            this.grbType.Controls.Add(this.cmbType);
            this.grbType.Controls.Add(this.button2);
            this.grbType.Location = new System.Drawing.Point(607, 36);
            this.grbType.Name = "grbType";
            this.grbType.Size = new System.Drawing.Size(570, 192);
            this.grbType.TabIndex = 38;
            this.grbType.TabStop = false;
            this.grbType.Text = "Search By Type Or Date ";
            // 
            // datePick
            // 
            this.datePick.Location = new System.Drawing.Point(287, 71);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(264, 24);
            this.datePick.TabIndex = 6;
            // 
            // rdbDate
            // 
            this.rdbDate.AutoSize = true;
            this.rdbDate.Location = new System.Drawing.Point(287, 33);
            this.rdbDate.Name = "rdbDate";
            this.rdbDate.Size = new System.Drawing.Size(129, 22);
            this.rdbDate.TabIndex = 5;
            this.rdbDate.TabStop = true;
            this.rdbDate.Text = "Search By Date";
            this.rdbDate.UseVisualStyleBackColor = true;
            this.rdbDate.CheckedChanged += new System.EventHandler(this.rdbDate_CheckedChanged);
            // 
            // rdbType
            // 
            this.rdbType.AutoSize = true;
            this.rdbType.Location = new System.Drawing.Point(17, 33);
            this.rdbType.Name = "rdbType";
            this.rdbType.Size = new System.Drawing.Size(130, 22);
            this.rdbType.TabIndex = 4;
            this.rdbType.TabStop = true;
            this.rdbType.Text = "Search By Type";
            this.rdbType.UseVisualStyleBackColor = true;
            this.rdbType.CheckedChanged += new System.EventHandler(this.rdbType_CheckedChanged);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(17, 69);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(233, 26);
            this.cmbType.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mstAdm
            // 
            this.mstAdm.BackColor = System.Drawing.Color.Transparent;
            this.mstAdm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.mstAdm.Location = new System.Drawing.Point(0, 0);
            this.mstAdm.Name = "mstAdm";
            this.mstAdm.Size = new System.Drawing.Size(1200, 24);
            this.mstAdm.TabIndex = 49;
            this.mstAdm.Text = "menuStrip1";
            this.mstAdm.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mstAdm_ItemClicked);
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
            // frmAssessmentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.mstAdm);
            this.Controls.Add(this.grbType);
            this.Controls.Add(this.grbSpecificAssess);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSpecificAssess);
            this.Controls.Add(this.btnTypeDate);
            this.Controls.Add(this.btnAllAssessments);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAssessmentReport";
            this.Text = "Assessment Report";
            this.Load += new System.EventHandler(this.frmAssessmentReport_Load);
            this.grbSpecificAssess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbType.ResumeLayout(false);
            this.grbType.PerformLayout();
            this.mstAdm.ResumeLayout(false);
            this.mstAdm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbSpecificAssess;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSearchSpecific;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSpecificAssess;
        private System.Windows.Forms.Button btnTypeDate;
        private System.Windows.Forms.Button btnAllAssessments;
        private System.Windows.Forms.GroupBox grbType;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdbDate;
        private System.Windows.Forms.RadioButton rdbType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.DateTimePicker datePick;
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