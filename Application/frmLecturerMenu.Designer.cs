namespace ONT_Project_2023
{
    partial class frmLecturerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLecturerMenu));
            this.label6 = new System.Windows.Forms.Label();
            this.btnAssessmentType = new System.Windows.Forms.Button();
            this.btAssessments = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(476, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(390, 42);
            this.label6.TabIndex = 31;
            this.label6.Text = "Lecturer Menu Page";
            // 
            // btnAssessmentType
            // 
            this.btnAssessmentType.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAssessmentType.Location = new System.Drawing.Point(399, 183);
            this.btnAssessmentType.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssessmentType.Name = "btnAssessmentType";
            this.btnAssessmentType.Size = new System.Drawing.Size(572, 75);
            this.btnAssessmentType.TabIndex = 34;
            this.btnAssessmentType.Text = "Manage Assessment Type";
            this.btnAssessmentType.UseVisualStyleBackColor = false;
            this.btnAssessmentType.Click += new System.EventHandler(this.btnAssessmentType_Click);
            // 
            // btAssessments
            // 
            this.btAssessments.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btAssessments.Location = new System.Drawing.Point(399, 286);
            this.btAssessments.Margin = new System.Windows.Forms.Padding(4);
            this.btAssessments.Name = "btAssessments";
            this.btAssessments.Size = new System.Drawing.Size(572, 75);
            this.btAssessments.TabIndex = 33;
            this.btAssessments.Text = "Manage Assessments";
            this.btAssessments.UseVisualStyleBackColor = false;
            this.btAssessments.Click += new System.EventHandler(this.btAssessments_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnHome.Location = new System.Drawing.Point(58, 13);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(144, 46);
            this.btnHome.TabIndex = 35;
            this.btnHome.Text = "Home(Log Out)";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(399, 380);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(572, 75);
            this.button1.TabIndex = 37;
            this.button1.Text = "Assessments Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLecturerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1318, 665);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAssessmentType);
            this.Controls.Add(this.btAssessments);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLecturerMenu";
            this.Text = "frmLecturerMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAssessmentType;
        private System.Windows.Forms.Button btAssessments;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button button1;
    }
}