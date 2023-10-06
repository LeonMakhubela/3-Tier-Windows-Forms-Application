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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSpecificUsers = new System.Windows.Forms.Button();
            this.btnAllUsers = new System.Windows.Forms.Button();
            this.grbSpecificUsers = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSearchSpecific = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbSpecificUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1176, 328);
            this.dataGridView1.TabIndex = 32;
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
            // 
            // grbSpecificUsers
            // 
            this.grbSpecificUsers.Controls.Add(this.comboBox1);
            this.grbSpecificUsers.Controls.Add(this.btnSearchSpecific);
            this.grbSpecificUsers.Location = new System.Drawing.Point(294, 25);
            this.grbSpecificUsers.Name = "grbSpecificUsers";
            this.grbSpecificUsers.Size = new System.Drawing.Size(613, 192);
            this.grbSpecificUsers.TabIndex = 33;
            this.grbSpecificUsers.TabStop = false;
            this.grbSpecificUsers.Text = "Search Specific Module";
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
            // frmModuleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.grbSpecificUsers);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSpecificUsers);
            this.Controls.Add(this.btnAllUsers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmModuleReport";
            this.Text = "Module Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbSpecificUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSpecificUsers;
        private System.Windows.Forms.Button btnAllUsers;
        private System.Windows.Forms.GroupBox grbSpecificUsers;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSearchSpecific;
    }
}