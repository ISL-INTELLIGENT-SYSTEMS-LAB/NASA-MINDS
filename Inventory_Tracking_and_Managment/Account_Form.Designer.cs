﻿namespace Inventory_Tracking_and_Managment
{
    partial class Account_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_Form));
            this.Btn_EditProfile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_ChangePassword = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.L_Filename = new System.Windows.Forms.Label();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_Phone = new System.Windows.Forms.TextBox();
            this.TB_Title = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Btn_UpdatePic = new System.Windows.Forms.Button();
            this.PB_ProfilePic = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_EditProfile
            // 
            this.Btn_EditProfile.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_EditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_EditProfile.Location = new System.Drawing.Point(993, 16);
            this.Btn_EditProfile.Name = "Btn_EditProfile";
            this.Btn_EditProfile.Size = new System.Drawing.Size(30, 30);
            this.Btn_EditProfile.TabIndex = 11;
            this.Btn_EditProfile.Text = "✏️";
            this.Btn_EditProfile.UseVisualStyleBackColor = false;
            this.Btn_EditProfile.Click += new System.EventHandler(this.Btn_EditProfile_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Btn_ChangePassword);
            this.panel2.Controls.Add(this.Btn_Back);
            this.panel2.Controls.Add(this.L_Filename);
            this.panel2.Controls.Add(this.TB_Email);
            this.panel2.Controls.Add(this.TB_Phone);
            this.panel2.Controls.Add(this.TB_Title);
            this.panel2.Controls.Add(this.Btn_EditProfile);
            this.panel2.Controls.Add(this.TB_Name);
            this.panel2.Controls.Add(this.Btn_Submit);
            this.panel2.Controls.Add(this.Btn_UpdatePic);
            this.panel2.Controls.Add(this.PB_ProfilePic);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(219, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 427);
            this.panel2.TabIndex = 13;
            // 
            // Btn_ChangePassword
            // 
            this.Btn_ChangePassword.BackColor = System.Drawing.Color.Moccasin;
            this.Btn_ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_ChangePassword.Location = new System.Drawing.Point(866, 380);
            this.Btn_ChangePassword.Name = "Btn_ChangePassword";
            this.Btn_ChangePassword.Size = new System.Drawing.Size(157, 30);
            this.Btn_ChangePassword.TabIndex = 19;
            this.Btn_ChangePassword.Text = "Change Password";
            this.Btn_ChangePassword.UseVisualStyleBackColor = false;
            this.Btn_ChangePassword.Click += new System.EventHandler(this.Btn_ChangePassword_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Back.Location = new System.Drawing.Point(16, 15);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(72, 30);
            this.Btn_Back.TabIndex = 18;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // L_Filename
            // 
            this.L_Filename.AutoSize = true;
            this.L_Filename.Enabled = false;
            this.L_Filename.Location = new System.Drawing.Point(130, 390);
            this.L_Filename.Name = "L_Filename";
            this.L_Filename.Size = new System.Drawing.Size(54, 13);
            this.L_Filename.TabIndex = 17;
            this.L_Filename.Text = "File Name";
            // 
            // TB_Email
            // 
            this.TB_Email.Enabled = false;
            this.TB_Email.Font = new System.Drawing.Font("MS UI Gothic", 27.75F);
            this.TB_Email.Location = new System.Drawing.Point(462, 313);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.ReadOnly = true;
            this.TB_Email.Size = new System.Drawing.Size(10, 44);
            this.TB_Email.TabIndex = 16;
            // 
            // TB_Phone
            // 
            this.TB_Phone.Enabled = false;
            this.TB_Phone.Font = new System.Drawing.Font("MS UI Gothic", 27.75F);
            this.TB_Phone.Location = new System.Drawing.Point(462, 228);
            this.TB_Phone.Name = "TB_Phone";
            this.TB_Phone.ReadOnly = true;
            this.TB_Phone.Size = new System.Drawing.Size(10, 44);
            this.TB_Phone.TabIndex = 15;
            // 
            // TB_Title
            // 
            this.TB_Title.Enabled = false;
            this.TB_Title.Font = new System.Drawing.Font("MS UI Gothic", 27.75F);
            this.TB_Title.Location = new System.Drawing.Point(462, 150);
            this.TB_Title.Name = "TB_Title";
            this.TB_Title.ReadOnly = true;
            this.TB_Title.Size = new System.Drawing.Size(10, 44);
            this.TB_Title.TabIndex = 14;
            // 
            // TB_Name
            // 
            this.TB_Name.Enabled = false;
            this.TB_Name.Font = new System.Drawing.Font("MS UI Gothic", 27.75F);
            this.TB_Name.Location = new System.Drawing.Point(462, 69);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.ReadOnly = true;
            this.TB_Name.Size = new System.Drawing.Size(10, 44);
            this.TB_Name.TabIndex = 12;
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Submit.Location = new System.Drawing.Point(951, 16);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(72, 30);
            this.Btn_Submit.TabIndex = 11;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = false;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Btn_UpdatePic
            // 
            this.Btn_UpdatePic.BackColor = System.Drawing.Color.Moccasin;
            this.Btn_UpdatePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UpdatePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_UpdatePic.Location = new System.Drawing.Point(16, 380);
            this.Btn_UpdatePic.Name = "Btn_UpdatePic";
            this.Btn_UpdatePic.Size = new System.Drawing.Size(108, 30);
            this.Btn_UpdatePic.TabIndex = 10;
            this.Btn_UpdatePic.Text = "Update Pic";
            this.Btn_UpdatePic.UseVisualStyleBackColor = false;
            this.Btn_UpdatePic.Click += new System.EventHandler(this.Btn_UpdatePic_Click);
            // 
            // PB_ProfilePic
            // 
            this.PB_ProfilePic.BackgroundImage = global::Inventory_Tracking_and_Managment.Properties.Resources.Background1;
            this.PB_ProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_ProfilePic.Location = new System.Drawing.Point(16, 65);
            this.PB_ProfilePic.Name = "PB_ProfilePic";
            this.PB_ProfilePic.Size = new System.Drawing.Size(278, 292);
            this.PB_ProfilePic.TabIndex = 9;
            this.PB_ProfilePic.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 36F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(308, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 48);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 36F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(300, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 48);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 36F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(300, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 48);
            this.label8.TabIndex = 6;
            this.label8.Text = "Title:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 36F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(300, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 48);
            this.label9.TabIndex = 5;
            this.label9.Text = "Name:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Inventory_Tracking_and_Managment.Properties.Resources.Background;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1304, 454);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Account_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1491, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Account_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_UpdatePic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Btn_EditProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.PictureBox PB_ProfilePic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_Phone;
        private System.Windows.Forms.TextBox TB_Title;
        private System.Windows.Forms.Label L_Filename;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_ChangePassword;
    }
}