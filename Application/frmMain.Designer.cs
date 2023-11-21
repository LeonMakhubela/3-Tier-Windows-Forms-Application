namespace ONT_Project_2023
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label6 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRegPage = new System.Windows.Forms.Button();
            this.btnModuleMan = new System.Windows.Forms.Button();
            this.btnLecturerMod = new System.Windows.Forms.Button();
            this.btnStudentMod = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(471, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 42);
            this.label6.TabIndex = 12;
            this.label6.Text = "Admin Menu";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnHome.Location = new System.Drawing.Point(60, 13);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(144, 46);
            this.btnHome.TabIndex = 13;
            this.btnHome.Text = "Home(Log Out)";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRegPage
            // 
            this.btnRegPage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRegPage.Location = new System.Drawing.Point(75, 198);
            this.btnRegPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegPage.Name = "btnRegPage";
            this.btnRegPage.Size = new System.Drawing.Size(313, 75);
            this.btnRegPage.TabIndex = 14;
            this.btnRegPage.Text = "Manage Users (Registration)";
            this.btnRegPage.UseVisualStyleBackColor = false;
            this.btnRegPage.Click += new System.EventHandler(this.btnRegPage_Click);
            // 
            // btnModuleMan
            // 
            this.btnModuleMan.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnModuleMan.Location = new System.Drawing.Point(791, 198);
            this.btnModuleMan.Margin = new System.Windows.Forms.Padding(4);
            this.btnModuleMan.Name = "btnModuleMan";
            this.btnModuleMan.Size = new System.Drawing.Size(313, 75);
            this.btnModuleMan.TabIndex = 15;
            this.btnModuleMan.Text = "Menage Module";
            this.btnModuleMan.UseVisualStyleBackColor = false;
            this.btnModuleMan.Click += new System.EventHandler(this.btnModuleMan_Click);
            // 
            // btnLecturerMod
            // 
            this.btnLecturerMod.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLecturerMod.Location = new System.Drawing.Point(75, 330);
            this.btnLecturerMod.Margin = new System.Windows.Forms.Padding(4);
            this.btnLecturerMod.Name = "btnLecturerMod";
            this.btnLecturerMod.Size = new System.Drawing.Size(313, 75);
            this.btnLecturerMod.TabIndex = 16;
            this.btnLecturerMod.Text = "Menage Lecturer Modules";
            this.btnLecturerMod.UseVisualStyleBackColor = false;
            this.btnLecturerMod.Click += new System.EventHandler(this.btnLecturerMod_Click);
            // 
            // btnStudentMod
            // 
            this.btnStudentMod.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnStudentMod.Location = new System.Drawing.Point(445, 330);
            this.btnStudentMod.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudentMod.Name = "btnStudentMod";
            this.btnStudentMod.Size = new System.Drawing.Size(313, 75);
            this.btnStudentMod.TabIndex = 17;
            this.btnStudentMod.Text = "Menage Student Modules";
            this.btnStudentMod.UseVisualStyleBackColor = false;
            this.btnStudentMod.Click += new System.EventHandler(this.btnStudentMod_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnReport.Location = new System.Drawing.Point(791, 330);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(313, 75);
            this.btnReport.TabIndex = 21;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(445, 198);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 75);
            this.button1.TabIndex = 23;
            this.button1.Text = "Menage Module Types";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnStudentMod);
            this.Controls.Add(this.btnLecturerMod);
            this.Controls.Add(this.btnModuleMan);
            this.Controls.Add(this.btnRegPage);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "  Home Page";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRegPage;
        private System.Windows.Forms.Button btnModuleMan;
        private System.Windows.Forms.Button btnLecturerMod;
        private System.Windows.Forms.Button btnStudentMod;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}