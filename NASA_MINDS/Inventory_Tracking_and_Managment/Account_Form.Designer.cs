namespace Inventory_Tracking_and_Managment
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.L_Email = new System.Windows.Forms.Label();
            this.L_Phone = new System.Windows.Forms.Label();
            this.L_Title = new System.Windows.Forms.Label();
            this.L_Name = new System.Windows.Forms.Label();
            this.Btn_EditProfile = new System.Windows.Forms.Button();
            this.PB_ProfilePic = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_Phone = new System.Windows.Forms.TextBox();
            this.TB_Title = new System.Windows.Forms.TextBox();
            this.TB_Filename = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Btn_UpdatePic = new System.Windows.Forms.Button();
            this.PB_Edit = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ProfilePic)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Edit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Inventory_Tracking_and_Managment.Properties.Resources.Background;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1254, 424);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 205);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.L_Email);
            this.panel1.Controls.Add(this.L_Phone);
            this.panel1.Controls.Add(this.L_Title);
            this.panel1.Controls.Add(this.L_Name);
            this.panel1.Controls.Add(this.Btn_EditProfile);
            this.panel1.Controls.Add(this.PB_ProfilePic);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(753, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 412);
            this.panel1.TabIndex = 5;
            // 
            // L_Email
            // 
            this.L_Email.AutoSize = true;
            this.L_Email.Location = new System.Drawing.Point(429, 308);
            this.L_Email.Name = "L_Email";
            this.L_Email.Size = new System.Drawing.Size(27, 13);
            this.L_Email.TabIndex = 15;
            this.L_Email.Text = "wee";
            // 
            // L_Phone
            // 
            this.L_Phone.AutoSize = true;
            this.L_Phone.Location = new System.Drawing.Point(439, 229);
            this.L_Phone.Name = "L_Phone";
            this.L_Phone.Size = new System.Drawing.Size(27, 13);
            this.L_Phone.TabIndex = 14;
            this.L_Phone.Text = "wee";
            // 
            // L_Title
            // 
            this.L_Title.AutoSize = true;
            this.L_Title.Location = new System.Drawing.Point(408, 141);
            this.L_Title.Name = "L_Title";
            this.L_Title.Size = new System.Drawing.Size(27, 13);
            this.L_Title.TabIndex = 13;
            this.L_Title.Text = "wee";
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Location = new System.Drawing.Point(435, 63);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(27, 13);
            this.L_Name.TabIndex = 12;
            this.L_Name.Text = "wee";
            // 
            // Btn_EditProfile
            // 
            this.Btn_EditProfile.Location = new System.Drawing.Point(690, 13);
            this.Btn_EditProfile.Name = "Btn_EditProfile";
            this.Btn_EditProfile.Size = new System.Drawing.Size(23, 23);
            this.Btn_EditProfile.TabIndex = 11;
            this.Btn_EditProfile.Text = "✏️";
            this.Btn_EditProfile.UseVisualStyleBackColor = true;
            this.Btn_EditProfile.Click += new System.EventHandler(this.Btn_EditProfile_Click);
            // 
            // PB_ProfilePic
            // 
            this.PB_ProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_ProfilePic.Location = new System.Drawing.Point(28, 48);
            this.PB_ProfilePic.Name = "PB_ProfilePic";
            this.PB_ProfilePic.Size = new System.Drawing.Size(253, 287);
            this.PB_ProfilePic.TabIndex = 9;
            this.PB_ProfilePic.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(309, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(309, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(309, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(309, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.TB_Email);
            this.panel2.Controls.Add(this.TB_Phone);
            this.panel2.Controls.Add(this.TB_Title);
            this.panel2.Controls.Add(this.TB_Filename);
            this.panel2.Controls.Add(this.TB_Name);
            this.panel2.Controls.Add(this.Btn_Submit);
            this.panel2.Controls.Add(this.Btn_UpdatePic);
            this.panel2.Controls.Add(this.PB_Edit);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 406);
            this.panel2.TabIndex = 13;
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(428, 308);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(100, 20);
            this.TB_Email.TabIndex = 16;
            // 
            // TB_Phone
            // 
            this.TB_Phone.Location = new System.Drawing.Point(438, 228);
            this.TB_Phone.Name = "TB_Phone";
            this.TB_Phone.Size = new System.Drawing.Size(100, 20);
            this.TB_Phone.TabIndex = 15;
            // 
            // TB_Title
            // 
            this.TB_Title.Location = new System.Drawing.Point(404, 140);
            this.TB_Title.Name = "TB_Title";
            this.TB_Title.Size = new System.Drawing.Size(100, 20);
            this.TB_Title.TabIndex = 14;
            // 
            // TB_Filename
            // 
            this.TB_Filename.Location = new System.Drawing.Point(109, 355);
            this.TB_Filename.Name = "TB_Filename";
            this.TB_Filename.Size = new System.Drawing.Size(172, 20);
            this.TB_Filename.TabIndex = 13;
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(438, 61);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 20);
            this.TB_Name.TabIndex = 12;
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Location = new System.Drawing.Point(654, 13);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(59, 23);
            this.Btn_Submit.TabIndex = 11;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Btn_UpdatePic
            // 
            this.Btn_UpdatePic.Location = new System.Drawing.Point(28, 353);
            this.Btn_UpdatePic.Name = "Btn_UpdatePic";
            this.Btn_UpdatePic.Size = new System.Drawing.Size(75, 23);
            this.Btn_UpdatePic.TabIndex = 10;
            this.Btn_UpdatePic.Text = "Update Pic";
            this.Btn_UpdatePic.UseVisualStyleBackColor = true;
            this.Btn_UpdatePic.Click += new System.EventHandler(this.Btn_UpdatePic_Click);
            // 
            // PB_Edit
            // 
            this.PB_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_Edit.Location = new System.Drawing.Point(28, 48);
            this.PB_Edit.Name = "PB_Edit";
            this.PB_Edit.Size = new System.Drawing.Size(253, 287);
            this.PB_Edit.TabIndex = 9;
            this.PB_Edit.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(309, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 39);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(309, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 39);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(309, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 39);
            this.label8.TabIndex = 6;
            this.label8.Text = "Title:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(309, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 39);
            this.label9.TabIndex = 5;
            this.label9.Text = "Name:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Account_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1491, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Account_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ProfilePic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_UpdatePic;
        private System.Windows.Forms.PictureBox PB_ProfilePic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Btn_EditProfile;
        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.PictureBox PB_Edit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label L_Email;
        private System.Windows.Forms.Label L_Phone;
        private System.Windows.Forms.Label L_Title;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_Phone;
        private System.Windows.Forms.TextBox TB_Title;
        private System.Windows.Forms.TextBox TB_Filename;
    }
}