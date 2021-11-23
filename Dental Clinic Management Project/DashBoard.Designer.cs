
namespace Dental_Clinic_Management_Project
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PendingAppProgress = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Pendinglbl = new System.Windows.Forms.Label();
            this.Patients = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.Patientlbl = new System.Windows.Forms.Label();
            this.UsersProgress = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Userlbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NextApp = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PendingAppProgress.SuspendLayout();
            this.Patients.SuspendLayout();
            this.UsersProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 100);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Azure;
            this.label9.Location = new System.Drawing.Point(271, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "Dashboard";
            // 
            // PendingAppProgress
            // 
            this.PendingAppProgress.AnimationSpeed = 0.6F;
            this.PendingAppProgress.BaseColor = System.Drawing.Color.White;
            this.PendingAppProgress.Controls.Add(this.label1);
            this.PendingAppProgress.Controls.Add(this.Pendinglbl);
            this.PendingAppProgress.IdleColor = System.Drawing.Color.Gainsboro;
            this.PendingAppProgress.IdleOffset = 20;
            this.PendingAppProgress.IdleThickness = 18;
            this.PendingAppProgress.Image = null;
            this.PendingAppProgress.ImageSize = new System.Drawing.Size(52, 52);
            this.PendingAppProgress.Location = new System.Drawing.Point(111, 144);
            this.PendingAppProgress.Name = "PendingAppProgress";
            this.PendingAppProgress.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PendingAppProgress.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PendingAppProgress.ProgressOffset = 20;
            this.PendingAppProgress.ProgressThickness = 18;
            this.PendingAppProgress.Size = new System.Drawing.Size(177, 172);
            this.PendingAppProgress.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(40, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Appointments";
            // 
            // Pendinglbl
            // 
            this.Pendinglbl.AutoSize = true;
            this.Pendinglbl.BackColor = System.Drawing.Color.RoyalBlue;
            this.Pendinglbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pendinglbl.ForeColor = System.Drawing.Color.Azure;
            this.Pendinglbl.Location = new System.Drawing.Point(66, 108);
            this.Pendinglbl.Name = "Pendinglbl";
            this.Pendinglbl.Size = new System.Drawing.Size(39, 17);
            this.Pendinglbl.TabIndex = 9;
            this.Pendinglbl.Text = "Num";
            // 
            // Patients
            // 
            this.Patients.AnimationSpeed = 0.6F;
            this.Patients.BaseColor = System.Drawing.Color.White;
            this.Patients.Controls.Add(this.label2);
            this.Patients.Controls.Add(this.Patientlbl);
            this.Patients.IdleColor = System.Drawing.Color.Gainsboro;
            this.Patients.IdleOffset = 20;
            this.Patients.IdleThickness = 18;
            this.Patients.Image = null;
            this.Patients.ImageSize = new System.Drawing.Size(52, 52);
            this.Patients.Location = new System.Drawing.Point(408, 144);
            this.Patients.Name = "Patients";
            this.Patients.ProgressMaxColor = System.Drawing.Color.OrangeRed;
            this.Patients.ProgressMinColor = System.Drawing.Color.OrangeRed;
            this.Patients.ProgressOffset = 20;
            this.Patients.ProgressThickness = 18;
            this.Patients.Size = new System.Drawing.Size(174, 172);
            this.Patients.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(57, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Patients";
            // 
            // Patientlbl
            // 
            this.Patientlbl.AutoSize = true;
            this.Patientlbl.BackColor = System.Drawing.Color.RoyalBlue;
            this.Patientlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patientlbl.ForeColor = System.Drawing.Color.Azure;
            this.Patientlbl.Location = new System.Drawing.Point(69, 108);
            this.Patientlbl.Name = "Patientlbl";
            this.Patientlbl.Size = new System.Drawing.Size(39, 17);
            this.Patientlbl.TabIndex = 13;
            this.Patientlbl.Text = "Num";
            // 
            // UsersProgress
            // 
            this.UsersProgress.AnimationSpeed = 0.6F;
            this.UsersProgress.BaseColor = System.Drawing.Color.White;
            this.UsersProgress.Controls.Add(this.label3);
            this.UsersProgress.Controls.Add(this.Userlbl);
            this.UsersProgress.IdleColor = System.Drawing.Color.Gainsboro;
            this.UsersProgress.IdleOffset = 20;
            this.UsersProgress.IdleThickness = 18;
            this.UsersProgress.Image = null;
            this.UsersProgress.ImageSize = new System.Drawing.Size(52, 52);
            this.UsersProgress.Location = new System.Drawing.Point(250, 322);
            this.UsersProgress.Name = "UsersProgress";
            this.UsersProgress.ProgressMaxColor = System.Drawing.Color.Yellow;
            this.UsersProgress.ProgressMinColor = System.Drawing.Color.Yellow;
            this.UsersProgress.ProgressOffset = 20;
            this.UsersProgress.ProgressThickness = 18;
            this.UsersProgress.Size = new System.Drawing.Size(181, 177);
            this.UsersProgress.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(66, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Users";
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.BackColor = System.Drawing.Color.RoyalBlue;
            this.Userlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlbl.ForeColor = System.Drawing.Color.Azure;
            this.Userlbl.Location = new System.Drawing.Point(66, 108);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(39, 17);
            this.Userlbl.TabIndex = 10;
            this.Userlbl.Text = "Num";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat Subrayada", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Back";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // NextApp
            // 
            this.NextApp.AnimationSpeed = 0.6F;
            this.NextApp.BaseColor = System.Drawing.Color.White;
            this.NextApp.IdleColor = System.Drawing.Color.White;
            this.NextApp.IdleOffset = 20;
            this.NextApp.IdleThickness = 18;
            this.NextApp.Image = null;
            this.NextApp.ImageSize = new System.Drawing.Size(52, 52);
            this.NextApp.Location = new System.Drawing.Point(494, 415);
            this.NextApp.Name = "NextApp";
            this.NextApp.ProgressMaxColor = System.Drawing.Color.White;
            this.NextApp.ProgressMinColor = System.Drawing.Color.White;
            this.NextApp.ProgressOffset = 20;
            this.NextApp.ProgressThickness = 18;
            this.NextApp.Size = new System.Drawing.Size(59, 58);
            this.NextApp.TabIndex = 12;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 523);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NextApp);
            this.Controls.Add(this.UsersProgress);
            this.Controls.Add(this.Patients);
            this.Controls.Add(this.PendingAppProgress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PendingAppProgress.ResumeLayout(false);
            this.PendingAppProgress.PerformLayout();
            this.Patients.ResumeLayout(false);
            this.Patients.PerformLayout();
            this.UsersProgress.ResumeLayout(false);
            this.UsersProgress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaCircleProgressBar PendingAppProgress;
        private Guna.UI.WinForms.GunaCircleProgressBar Patients;
        private Guna.UI.WinForms.GunaCircleProgressBar UsersProgress;
        private System.Windows.Forms.Label Pendinglbl;
        private System.Windows.Forms.Label Patientlbl;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaCircleProgressBar NextApp;
    }
}