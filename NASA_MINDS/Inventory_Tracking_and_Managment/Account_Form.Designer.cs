using System.Drawing;
using System.Windows.Forms;

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
            this.TB_Filename = new System.Windows.Forms.TextBox();
            this.TB_Title = new System.Windows.Forms.TextBox();
            this.TB_Phone = new System.Windows.Forms.TextBox();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.Btn_EditPicture = new System.Windows.Forms.Button();
            this.Btn_EditProfile = new System.Windows.Forms.Button();
            this.PB_ProfilePicture = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Inventory_Tracking_and_Managment.Properties.Resources.Background;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1215, 373);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 244);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TB_Filename);
            this.panel1.Controls.Add(this.TB_Title);
            this.panel1.Controls.Add(this.TB_Phone);
            this.panel1.Controls.Add(this.TB_Email);
            this.panel1.Controls.Add(this.TB_Name);
            this.panel1.Controls.Add(this.Btn_EditPicture);
            this.panel1.Controls.Add(this.Btn_EditProfile);
            this.panel1.Controls.Add(this.PB_ProfilePicture);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_Submit);
            this.panel1.Location = new System.Drawing.Point(120, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 516);
            this.panel1.TabIndex = 5;
            // 
            // TB_Filename
            // 
            TB_Filename.Enabled = false;
            TB_Filename.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Filename.Location = new Point(166, 381);
            TB_Filename.Name = "TB_Filename";
            TB_Filename.ReadOnly = true;
            TB_Filename.Size = new Size(10, 23);
            TB_Filename.TabIndex = 12;
            TB_Filename.Visible = false;
            TB_Filename.WordWrap = false;
            // 
            // TB_Title
            // 
            TB_Title.Enabled = false;
            TB_Title.Font = new Font("MS UI Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Title.Location = new Point(498, 148);
            TB_Title.Name = "TB_Title";
            TB_Title.ReadOnly = true;
            TB_Title.Size = new Size(10, 44);
            TB_Title.TabIndex = 6;
            TB_Title.Text = "Private, Philippines";
            TB_Title.WordWrap = false;
            // 
            // TB_Phone
            // 
            TB_Phone.Enabled = false;
            TB_Phone.Font = new Font("MS UI Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Phone.Location = new Point(498, 226);
            TB_Phone.Name = "TB_Phone";
            TB_Phone.ReadOnly = true;
            TB_Phone.Size = new Size(10, 44);
            TB_Phone.TabIndex = 7;
            TB_Phone.Text = "910-922-5904";
            TB_Phone.WordWrap = false;
            // 
            // TB_Email
            // 
            TB_Email.Enabled = false;
            TB_Email.Font = new Font("MS UI Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Email.Location = new Point(498, 311);
            TB_Email.Name = "TB_Email";
            TB_Email.ReadOnly = true;
            TB_Email.Size = new Size(10, 44);
            TB_Email.TabIndex = 8;
            TB_Email.Text = "loowees09@gmail.com";
            TB_Email.WordWrap = false;
            // 
            // TB_Name
            // 
            TB_Name.Enabled = false;
            TB_Name.Font = new Font("MS UI Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Name.Location = new Point(498, 67);
            TB_Name.Name = "TB_Name";
            TB_Name.ReadOnly = true;
            TB_Name.RightToLeft = RightToLeft.No;
            TB_Name.Size = new Size(10, 44);
            TB_Name.TabIndex = 5;
            TB_Name.Text = "Hernandez, Luis E.";
            TB_Name.WordWrap = false;
            // 
            // Btn_EditPicture
            // 
            Btn_EditPicture.BackColor = Color.Red;
            Btn_EditPicture.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_EditPicture.Location = new Point(52, 378);
            Btn_EditPicture.Name = "Btn_EditPicture";
            Btn_EditPicture.Size = new Size(108, 30);
            Btn_EditPicture.TabIndex = 11;
            Btn_EditPicture.Text = "Upload";
            Btn_EditPicture.UseVisualStyleBackColor = false;
            Btn_EditPicture.Click += Btn_EditPicture_Click;
            // 
            // Btn_EditProfile
            // 
            Btn_EditProfile.BackColor = Color.Red;
            Btn_EditProfile.Location = new Point(1029, 14);
            Btn_EditProfile.Name = "Btn_EditProfile";
            Btn_EditProfile.Size = new Size(30, 30);
            Btn_EditProfile.TabIndex = 9;
            Btn_EditProfile.Text = "✐";
            Btn_EditProfile.UseVisualStyleBackColor = false;
            Btn_EditProfile.Click += Btn_EditProfile_Click;
            // 
            // PB_ProfilePicture
            // 
            PB_ProfilePicture.Anchor = AnchorStyles.None;
            PB_ProfilePicture.BackgroundImage = (Image)resources.GetObject("PB_ProfilePicture.BackgroundImage");
            PB_ProfilePicture.BackgroundImageLayout = ImageLayout.Zoom;
            PB_ProfilePicture.Location = new Point(52, 63);
            PB_ProfilePicture.Name = "PB_ProfilePicture";
            PB_ProfilePicture.Size = new Size(278, 292);
            PB_ProfilePicture.TabIndex = 1;
            PB_ProfilePicture.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(336, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 48);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(336, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 48);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(336, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(336, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // Btn_Submit
            // 
            Btn_Submit.BackColor = Color.Red;
            Btn_Submit.Location = new Point(987, 14);
            Btn_Submit.Name = "Btn_Submit";
            Btn_Submit.Size = new Size(72, 30);
            Btn_Submit.TabIndex = 10;
            Btn_Submit.Text = "👍";
            Btn_Submit.UseVisualStyleBackColor = false;
            Btn_Submit.Click += Btn_Submit_Click;
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
            ((System.ComponentModel.ISupportInitialize)(this.PB_ProfilePicture)).EndInit();
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
        private System.Windows.Forms.PictureBox PB_ProfilePicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Btn_EditProfile;
        private System.Windows.Forms.TextBox TB_Title;
        private System.Windows.Forms.TextBox TB_Phone;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Button Btn_EditPicture;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.TextBox TB_Filename;
    }
}