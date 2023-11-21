namespace ONT_Project_2023
{
    partial class frmModuleType
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvModules = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtModuleTypeDesc = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 192);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 98;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Module Description:";
            // 
            // dgvModules
            // 
            this.dgvModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModules.Location = new System.Drawing.Point(76, 239);
            this.dgvModules.Name = "dgvModules";
            this.dgvModules.Size = new System.Drawing.Size(890, 308);
            this.dgvModules.TabIndex = 95;
            this.dgvModules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModules_CellClick);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(520, 192);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(92, 27);
            this.btnSelect.TabIndex = 94;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(362, 192);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 27);
            this.btnUpdate.TabIndex = 93;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(226, 192);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 27);
            this.btnAdd.TabIndex = 92;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtModuleTypeDesc
            // 
            this.txtModuleTypeDesc.Location = new System.Drawing.Point(305, 109);
            this.txtModuleTypeDesc.Name = "txtModuleTypeDesc";
            this.txtModuleTypeDesc.Size = new System.Drawing.Size(534, 20);
            this.txtModuleTypeDesc.TabIndex = 99;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(17, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 32);
            this.btnBack.TabIndex = 100;
            this.btnBack.Text = "Back To Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmModuleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1061, 593);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtModuleTypeDesc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvModules);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmModuleType";
            this.Text = "frmModuleType";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvModules;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtModuleTypeDesc;
        private System.Windows.Forms.Button btnBack;
    }
}