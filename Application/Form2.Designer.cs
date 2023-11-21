namespace ONT_Project_2023
{
    partial class frmReg
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dgvReg = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mstAdm = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageLecturerModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.err_Name = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_Surname = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_Email = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_Password = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.cmb_Role = new System.Windows.Forms.ComboBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.manageStudentModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.mstAdm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Surname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_Password)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Title:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Role:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 339);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Password";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 456);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 32);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(196, 456);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 32);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(355, 456);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(113, 32);
            this.btnSelect.TabIndex = 21;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(505, 456);
            this.btnDel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(113, 32);
            this.btnDel.TabIndex = 22;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dgvReg
            // 
            this.dgvReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReg.Location = new System.Drawing.Point(628, 100);
            this.dgvReg.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvReg.Name = "dgvReg";
            this.dgvReg.Size = new System.Drawing.Size(742, 403);
            this.dgvReg.TabIndex = 31;
            this.dgvReg.Click += new System.EventHandler(this.dgvReg_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 384);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 33;
            this.label9.Text = "Status:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // mstAdm
            // 
            this.mstAdm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mstAdm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.mstAdm.Location = new System.Drawing.Point(0, 0);
            this.mstAdm.Name = "mstAdm";
            this.mstAdm.Size = new System.Drawing.Size(1384, 24);
            this.mstAdm.TabIndex = 35;
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
            this.manageStudentModulesToolStripMenuItem});
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
            this.manageUsersToolStripMenuItem.Text = "Reports";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // manageLecturerModulesToolStripMenuItem
            // 
            this.manageLecturerModulesToolStripMenuItem.Name = "manageLecturerModulesToolStripMenuItem";
            this.manageLecturerModulesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.manageLecturerModulesToolStripMenuItem.Text = "Manage Lecturer Modules";
            // 
            // err_Name
            // 
            this.err_Name.ContainerControl = this;
            // 
            // err_Surname
            // 
            this.err_Surname.ContainerControl = this;
            // 
            // err_Email
            // 
            this.err_Email.ContainerControl = this;
            // 
            // error_Password
            // 
            this.error_Password.ContainerControl = this;
            // 
            // cmbTitle
            // 
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Location = new System.Drawing.Point(145, 217);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(402, 26);
            this.cmbTitle.TabIndex = 44;
            // 
            // cmb_Status
            // 
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Location = new System.Drawing.Point(145, 379);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(402, 26);
            this.cmb_Status.TabIndex = 43;
            // 
            // cmb_Role
            // 
            this.cmb_Role.FormattingEnabled = true;
            this.cmb_Role.Location = new System.Drawing.Point(145, 257);
            this.cmb_Role.Name = "cmb_Role";
            this.cmb_Role.Size = new System.Drawing.Size(402, 26);
            this.cmb_Role.TabIndex = 42;
            this.cmb_Role.SelectedIndexChanged += new System.EventHandler(this.cmb_Role_SelectedIndexChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(145, 126);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(402, 24);
            this.txt_Name.TabIndex = 41;
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(145, 173);
            this.txt_Surname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(402, 24);
            this.txt_Surname.TabIndex = 40;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(145, 291);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(402, 24);
            this.txt_Email.TabIndex = 39;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(145, 337);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(402, 24);
            this.txt_Password.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(499, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 34);
            this.label6.TabIndex = 11;
            this.label6.Text = "Registration Page";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(145, 78);
            this.txtID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(402, 24);
            this.txtID.TabIndex = 46;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(43, 78);
            this.lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(58, 18);
            this.lbl.TabIndex = 45;
            this.lbl.Text = "UserID:";
            // 
            // manageStudentModulesToolStripMenuItem
            // 
            this.manageStudentModulesToolStripMenuItem.Name = "manageStudentModulesToolStripMenuItem";
            this.manageStudentModulesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.manageStudentModulesToolStripMenuItem.Text = "Manage Student Modules";
            // 
            // frmReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1384, 549);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.cmbTitle);
            this.Controls.Add(this.cmb_Status);
            this.Controls.Add(this.cmb_Role);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Surname);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvReg);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mstAdm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mstAdm;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmReg";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.frmReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.mstAdm.ResumeLayout(false);
            this.mstAdm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Surname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_Password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgvReg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip mstAdm;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageModulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageLecturerModulesToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.ComboBox cmb_Role;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.ErrorProvider err_Name;
        private System.Windows.Forms.ErrorProvider err_Surname;
        private System.Windows.Forms.ErrorProvider err_Email;
        private System.Windows.Forms.ErrorProvider error_Password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ToolStripMenuItem manageStudentModulesToolStripMenuItem;
    }
}