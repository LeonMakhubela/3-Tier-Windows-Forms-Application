namespace ONT_Project_2023
{
    partial class frmAssessmentType
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
            this.txtAssessmentTypeDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvModules = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAssessmentTypeDesc
            // 
            this.txtAssessmentTypeDesc.Location = new System.Drawing.Point(302, 91);
            this.txtAssessmentTypeDesc.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtAssessmentTypeDesc.Name = "txtAssessmentTypeDesc";
            this.txtAssessmentTypeDesc.Size = new System.Drawing.Size(804, 24);
            this.txtAssessmentTypeDesc.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 18);
            this.label1.TabIndex = 103;
            this.label1.Text = "Assessment Type Description:";
            // 
            // dgvModules
            // 
            this.dgvModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModules.Location = new System.Drawing.Point(78, 241);
            this.dgvModules.Margin = new System.Windows.Forms.Padding(4);
            this.dgvModules.Name = "dgvModules";
            this.dgvModules.Size = new System.Drawing.Size(1040, 241);
            this.dgvModules.TabIndex = 93;
            this.dgvModules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_CellClick);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(629, 175);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(138, 37);
            this.btnSelect.TabIndex = 92;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(385, 175);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 37);
            this.btnUpdate.TabIndex = 91;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(164, 175);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 37);
            this.btnAdd.TabIndex = 90;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(861, 175);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 37);
            this.btnDelete.TabIndex = 105;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(17, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 32);
            this.btnBack.TabIndex = 106;
            this.btnBack.Text = "Back To Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmAssessmentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtAssessmentTypeDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvModules);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAssessmentType";
            this.Text = "frmAssessmentType";
            this.Load += new System.EventHandler(this.frmAssessmentType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAssessmentTypeDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvModules;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ErrorProvider err;
    }
}