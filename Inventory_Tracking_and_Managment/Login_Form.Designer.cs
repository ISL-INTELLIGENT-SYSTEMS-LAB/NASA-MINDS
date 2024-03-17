namespace Inventory_Tracking_and_Managment
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.L_Password = new System.Windows.Forms.Label();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_ShowPass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Forgot = new System.Windows.Forms.Button();
            this.Btn_Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Username
            // 
            this.TB_Username.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Username.Location = new System.Drawing.Point(386, 241);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(400, 49);
            this.TB_Username.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Inventory_Tracking_and_Managment.Properties.Resources.Background;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1717, 854);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // L_Password
            // 
            this.L_Password.AutoSize = true;
            this.L_Password.BackColor = System.Drawing.Color.Transparent;
            this.L_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Password.ForeColor = System.Drawing.Color.Black;
            this.L_Password.Location = new System.Drawing.Point(44, 316);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(322, 73);
            this.L_Password.TabIndex = 4;
            this.L_Password.Text = "Password";
            // 
            // TB_Password
            // 
            this.TB_Password.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(386, 337);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(354, 49);
            this.TB_Password.TabIndex = 3;
            this.TB_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Password_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Btn_ShowPass);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Btn_Forgot);
            this.panel1.Controls.Add(this.Btn_Login);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.L_Password);
            this.panel1.Controls.Add(this.TB_Username);
            this.panel1.Controls.Add(this.TB_Password);
            this.panel1.Location = new System.Drawing.Point(500, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 565);
            this.panel1.TabIndex = 5;
            // 
            // Btn_ShowPass
            // 
            this.Btn_ShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ShowPass.Location = new System.Drawing.Point(746, 337);
            this.Btn_ShowPass.Name = "Btn_ShowPass";
            this.Btn_ShowPass.Size = new System.Drawing.Size(40, 48);
            this.Btn_ShowPass.TabIndex = 10;
            this.Btn_ShowPass.Text = "👁️";
            this.Btn_ShowPass.UseVisualStyleBackColor = true;
            this.Btn_ShowPass.Click += new System.EventHandler(this.Btn_ShowPass_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(769, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "_____________________________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(600, 75);
            this.label4.TabIndex = 8;
            this.label4.Text = "Managment System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(719, 75);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inventory Tracking and";
            // 
            // Btn_Forgot
            // 
            this.Btn_Forgot.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_Forgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Forgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Forgot.Location = new System.Drawing.Point(577, 449);
            this.Btn_Forgot.Name = "Btn_Forgot";
            this.Btn_Forgot.Size = new System.Drawing.Size(209, 87);
            this.Btn_Forgot.TabIndex = 6;
            this.Btn_Forgot.Text = "Forgot";
            this.Btn_Forgot.UseVisualStyleBackColor = false;
            this.Btn_Forgot.Click += new System.EventHandler(this.Btn_Forgot_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.Location = new System.Drawing.Point(57, 449);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(514, 87);
            this.Btn_Login.TabIndex = 5;
            this.Btn_Login.Text = "Log in";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Form";
            this.Text = " ";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_Forgot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_ShowPass;
    }
}

