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
            this.btnAllUsers = new System.Windows.Forms.Button();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.grbSpecificUsers = new System.Windows.Forms.GroupBox();
            this.cmbUserRoles = new System.Windows.Forms.ComboBox();
            this.btnSearchByRole = new System.Windows.Forms.Button();
            this.grbUser = new System.Windows.Forms.GroupBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnSearchAUser = new System.Windows.Forms.Button();
            this.btnSpecificUsers = new System.Windows.Forms.Button();
            this.btnSingleUser = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.grbSpecificUsers.SuspendLayout();
            this.grbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAllUsers
            // 
            this.btnAllUsers.Location = new System.Drawing.Point(449, 236);
            this.btnAllUsers.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnAllUsers.Name = "btnAllUsers";
            this.btnAllUsers.Size = new System.Drawing.Size(176, 27);
            this.btnAllUsers.TabIndex = 26;
            this.btnAllUsers.Text = "List All Users";
            this.btnAllUsers.UseVisualStyleBackColor = true;
            this.btnAllUsers.Click += new System.EventHandler(this.btnAllUsers_Click);
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(10, 294);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(1176, 328);
            this.dgvDisplay.TabIndex = 29;
            // 
            // grbSpecificUsers
            // 
            this.grbSpecificUsers.Controls.Add(this.cmbUserRoles);
            this.grbSpecificUsers.Controls.Add(this.btnSearchByRole);
            this.grbSpecificUsers.Location = new System.Drawing.Point(10, 35);
            this.grbSpecificUsers.Name = "grbSpecificUsers";
            this.grbSpecificUsers.Size = new System.Drawing.Size(570, 192);
            this.grbSpecificUsers.TabIndex = 30;
            this.grbSpecificUsers.TabStop = false;
            this.grbSpecificUsers.Text = "Search By Role";
            // 
            // cmbUserRoles
            // 
            this.cmbUserRoles.FormattingEnabled = true;
            this.cmbUserRoles.Location = new System.Drawing.Point(44, 47);
            this.cmbUserRoles.Name = "cmbUserRoles";
            this.cmbUserRoles.Size = new System.Drawing.Size(478, 26);
            this.cmbUserRoles.TabIndex = 1;
            this.cmbUserRoles.Text = "Select Role";
            // 
            // btnSearchByRole
            // 
            this.btnSearchByRole.Location = new System.Drawing.Point(225, 113);
            this.btnSearchByRole.Name = "btnSearchByRole";
            this.btnSearchByRole.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByRole.TabIndex = 0;
            this.btnSearchByRole.Text = "Search";
            this.btnSearchByRole.UseVisualStyleBackColor = true;
            this.btnSearchByRole.Click += new System.EventHandler(this.btnSearchByRole_Click);
            // 
            // grbUser
            // 
            this.grbUser.Controls.Add(this.txtUser);
            this.grbUser.Controls.Add(this.btnSearchAUser);
            this.grbUser.Location = new System.Drawing.Point(596, 35);
            this.grbUser.Name = "grbUser";
            this.grbUser.Size = new System.Drawing.Size(590, 192);
            this.grbUser.TabIndex = 31;
            this.grbUser.TabStop = false;
            this.grbUser.Text = "Search A User";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(23, 49);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(512, 24);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "Enter The Name Of User";
            // 
            // btnSearchAUser
            // 
            this.btnSearchAUser.Location = new System.Drawing.Point(259, 103);
            this.btnSearchAUser.Name = "btnSearchAUser";
            this.btnSearchAUser.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAUser.TabIndex = 1;
            this.btnSearchAUser.Text = "Search";
            this.btnSearchAUser.UseVisualStyleBackColor = true;
            // 
            // btnSpecificUsers
            // 
            this.btnSpecificUsers.Location = new System.Drawing.Point(152, 236);
            this.btnSpecificUsers.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnSpecificUsers.Name = "btnSpecificUsers";
            this.btnSpecificUsers.Size = new System.Drawing.Size(176, 27);
            this.btnSpecificUsers.TabIndex = 49;
            this.btnSpecificUsers.Text = "Search Specific Users";
            this.btnSpecificUsers.UseVisualStyleBackColor = true;
            this.btnSpecificUsers.Click += new System.EventHandler(this.btnSpecificUsers_Click_1);
            // 
            // btnSingleUser
            // 
            this.btnSingleUser.Location = new System.Drawing.Point(685, 236);
            this.btnSingleUser.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnSingleUser.Name = "btnSingleUser";
            this.btnSingleUser.Size = new System.Drawing.Size(176, 27);
            this.btnSingleUser.TabIndex = 48;
            this.btnSingleUser.Text = "Search User";
            this.btnSingleUser.UseVisualStyleBackColor = true;
            this.btnSingleUser.Click += new System.EventHandler(this.btnSingleUser_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(930, 236);
            this.btnBack.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 27);
            this.btnBack.TabIndex = 110;
            this.btnBack.Text = "Back To Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSpecificUsers);
            this.Controls.Add(this.btnSingleUser);
            this.Controls.Add(this.grbUser);
            this.Controls.Add(this.grbSpecificUsers);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.btnAllUsers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.grbSpecificUsers.ResumeLayout(false);
            this.grbUser.ResumeLayout(false);
            this.grbUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAllUsers;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.GroupBox grbSpecificUsers;
        private System.Windows.Forms.GroupBox grbUser;
        private System.Windows.Forms.ComboBox cmbUserRoles;
        private System.Windows.Forms.Button btnSearchByRole;
        private System.Windows.Forms.Button btnSearchAUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnSpecificUsers;
        private System.Windows.Forms.Button btnSingleUser;
        private System.Windows.Forms.Button btnBack;
    }
}