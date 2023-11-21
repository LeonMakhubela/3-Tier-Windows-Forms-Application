namespace ONT_Project_2023
{
    partial class frmModuleReport
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
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.btnSpecificUsers = new System.Windows.Forms.Button();
            this.btnAllUsers = new System.Windows.Forms.Button();
            this.grbSpecificUsers = new System.Windows.Forms.GroupBox();
            this.cmbModuleTypeDesc = new System.Windows.Forms.ComboBox();
            this.btnSearchSpecific = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.grbSpecificUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(7, 284);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(1176, 328);
            this.dgvDisplay.TabIndex = 32;
            // 
            // btnSpecificUsers
            // 
            this.btnSpecificUsers.Location = new System.Drawing.Point(294, 226);
            this.btnSpecificUsers.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnSpecificUsers.Name = "btnSpecificUsers";
            this.btnSpecificUsers.Size = new System.Drawing.Size(176, 27);
            this.btnSpecificUsers.TabIndex = 31;
            this.btnSpecificUsers.Text = "Search Specific Module";
            this.btnSpecificUsers.UseVisualStyleBackColor = true;
            // 
            // btnAllUsers
            // 
            this.btnAllUsers.Location = new System.Drawing.Point(731, 226);
            this.btnAllUsers.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnAllUsers.Name = "btnAllUsers";
            this.btnAllUsers.Size = new System.Drawing.Size(176, 27);
            this.btnAllUsers.TabIndex = 30;
            this.btnAllUsers.Text = "List All Modules";
            this.btnAllUsers.UseVisualStyleBackColor = true;
            this.btnAllUsers.Click += new System.EventHandler(this.btnAllUsers_Click);
            // 
            // grbSpecificUsers
            // 
            this.grbSpecificUsers.Controls.Add(this.cmbModuleTypeDesc);
            this.grbSpecificUsers.Controls.Add(this.btnSearchSpecific);
            this.grbSpecificUsers.Location = new System.Drawing.Point(294, 25);
            this.grbSpecificUsers.Name = "grbSpecificUsers";
            this.grbSpecificUsers.Size = new System.Drawing.Size(613, 192);
            this.grbSpecificUsers.TabIndex = 33;
            this.grbSpecificUsers.TabStop = false;
            this.grbSpecificUsers.Text = "Search Specific Module";
            // 
            // cmbModuleTypeDesc
            // 
            this.cmbModuleTypeDesc.FormattingEnabled = true;
            this.cmbModuleTypeDesc.Location = new System.Drawing.Point(44, 47);
            this.cmbModuleTypeDesc.Name = "cmbModuleTypeDesc";
            this.cmbModuleTypeDesc.Size = new System.Drawing.Size(478, 26);
            this.cmbModuleTypeDesc.TabIndex = 1;
            this.cmbModuleTypeDesc.Text = "Select";
            // 
            // btnSearchSpecific
            // 
            this.btnSearchSpecific.Location = new System.Drawing.Point(225, 113);
            this.btnSearchSpecific.Name = "btnSearchSpecific";
            this.btnSearchSpecific.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSpecific.TabIndex = 0;
            this.btnSearchSpecific.Text = "Search";
            this.btnSearchSpecific.UseVisualStyleBackColor = true;
            this.btnSearchSpecific.Click += new System.EventHandler(this.btnSearchSpecific_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(7, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 32);
            this.btnBack.TabIndex = 101;
            this.btnBack.Text = "Back To Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmModuleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grbSpecificUsers);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.btnSpecificUsers);
            this.Controls.Add(this.btnAllUsers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmModuleReport";
            this.Text = "Module Reports";
            this.Load += new System.EventHandler(this.frmModuleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.grbSpecificUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Button btnSpecificUsers;
        private System.Windows.Forms.Button btnAllUsers;
        private System.Windows.Forms.GroupBox grbSpecificUsers;
        private System.Windows.Forms.ComboBox cmbModuleTypeDesc;
        private System.Windows.Forms.Button btnSearchSpecific;
        private System.Windows.Forms.Button btnBack;
    }
}