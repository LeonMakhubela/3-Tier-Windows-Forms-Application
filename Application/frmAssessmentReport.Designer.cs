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
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnSearchSpecific = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnSpecificAssess = new System.Windows.Forms.Button();
            this.btnAllAssessments = new System.Windows.Forms.Button();
            this.grbType = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpLastDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFirstDate = new System.Windows.Forms.DateTimePicker();
            this.btn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTypeDate = new System.Windows.Forms.Button();
            this.grbSpecificAssess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.grbType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSpecificAssess
            // 
            this.grbSpecificAssess.Controls.Add(this.cmbType);
            this.grbSpecificAssess.Controls.Add(this.btnSearchSpecific);
            this.grbSpecificAssess.Location = new System.Drawing.Point(21, 36);
            this.grbSpecificAssess.Name = "grbSpecificAssess";
            this.grbSpecificAssess.Size = new System.Drawing.Size(532, 192);
            this.grbSpecificAssess.TabIndex = 36;
            this.grbSpecificAssess.TabStop = false;
            this.grbSpecificAssess.Text = "Search Assessment By Type";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(6, 69);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(508, 26);
            this.cmbType.TabIndex = 1;
            this.cmbType.Text = "Select";
            // 
            // btnSearchSpecific
            // 
            this.btnSearchSpecific.Location = new System.Drawing.Point(197, 106);
            this.btnSearchSpecific.Name = "btnSearchSpecific";
            this.btnSearchSpecific.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSpecific.TabIndex = 0;
            this.btnSearchSpecific.Text = "Search";
            this.btnSearchSpecific.UseVisualStyleBackColor = true;
            this.btnSearchSpecific.Click += new System.EventHandler(this.btnSearchSpecific_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(12, 277);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(1176, 328);
            this.dgvReport.TabIndex = 35;
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
            // btnAllAssessments
            // 
            this.btnAllAssessments.Location = new System.Drawing.Point(363, 237);
            this.btnAllAssessments.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnAllAssessments.Name = "btnAllAssessments";
            this.btnAllAssessments.Size = new System.Drawing.Size(227, 27);
            this.btnAllAssessments.TabIndex = 32;
            this.btnAllAssessments.Text = "List All Assessment";
            this.btnAllAssessments.UseVisualStyleBackColor = true;
            this.btnAllAssessments.Click += new System.EventHandler(this.btnAllAssessments_Click);
            // 
            // grbType
            // 
            this.grbType.Controls.Add(this.label2);
            this.grbType.Controls.Add(this.label1);
            this.grbType.Controls.Add(this.dtpLastDate);
            this.grbType.Controls.Add(this.dtpFirstDate);
            this.grbType.Controls.Add(this.btn);
            this.grbType.Location = new System.Drawing.Point(607, 36);
            this.grbType.Name = "grbType";
            this.grbType.Size = new System.Drawing.Size(570, 192);
            this.grbType.TabIndex = 38;
            this.grbType.TabStop = false;
            this.grbType.Text = "Search By Type Or Date ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "End Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Start Date";
            // 
            // dtpLastDate
            // 
            this.dtpLastDate.Location = new System.Drawing.Point(179, 69);
            this.dtpLastDate.Name = "dtpLastDate";
            this.dtpLastDate.Size = new System.Drawing.Size(385, 24);
            this.dtpLastDate.TabIndex = 7;
            // 
            // dtpFirstDate
            // 
            this.dtpFirstDate.Location = new System.Drawing.Point(179, 37);
            this.dtpFirstDate.Name = "dtpFirstDate";
            this.dtpFirstDate.Size = new System.Drawing.Size(385, 24);
            this.dtpFirstDate.TabIndex = 6;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(242, 121);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "Search";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(894, 240);
            this.btnBack.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(161, 28);
            this.btnBack.TabIndex = 93;
            this.btnBack.Text = "Back To Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTypeDate
            // 
            this.btnTypeDate.Location = new System.Drawing.Point(662, 241);
            this.btnTypeDate.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnTypeDate.Name = "btnTypeDate";
            this.btnTypeDate.Size = new System.Drawing.Size(176, 27);
            this.btnTypeDate.TabIndex = 33;
            this.btnTypeDate.Text = "Search By Type Or Date";
            this.btnTypeDate.UseVisualStyleBackColor = true;
            this.btnTypeDate.Click += new System.EventHandler(this.btnTypeDate_Click);
            // 
            // frmAssessmentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grbType);
            this.Controls.Add(this.grbSpecificAssess);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnSpecificAssess);
            this.Controls.Add(this.btnTypeDate);
            this.Controls.Add(this.btnAllAssessments);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAssessmentReport";
            this.Text = "Assessment Report";
            this.Load += new System.EventHandler(this.frmAssessmentReport_Load);
            this.grbSpecificAssess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.grbType.ResumeLayout(false);
            this.grbType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbSpecificAssess;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnSearchSpecific;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnSpecificAssess;
        private System.Windows.Forms.Button btnAllAssessments;
        private System.Windows.Forms.GroupBox grbType;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DateTimePicker dtpFirstDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpLastDate;
        private System.Windows.Forms.Button btnTypeDate;
    }
}