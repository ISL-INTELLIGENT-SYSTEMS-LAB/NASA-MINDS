namespace Inventory_Tracking_and_Managment
{
    partial class ChangePassword_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword_Form));
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_CurrentPassword = new System.Windows.Forms.TextBox();
            this.Tb_NewPassword = new System.Windows.Forms.TextBox();
            this.Tb_Reenter = new System.Windows.Forms.TextBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_ShowPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.BackColor = System.Drawing.Color.Red;
            this.Btn_Submit.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Submit.Location = new System.Drawing.Point(377, 453);
            this.Btn_Submit.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(124, 50);
            this.Btn_Submit.TabIndex = 0;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = false;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Current Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 44);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reenter Password:";
            // 
            // Tb_CurrentPassword
            // 
            this.Tb_CurrentPassword.Font = new System.Drawing.Font("MS UI Gothic", 27.75F);
            this.Tb_CurrentPassword.Location = new System.Drawing.Point(589, 96);
            this.Tb_CurrentPassword.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_CurrentPassword.Name = "Tb_CurrentPassword";
            this.Tb_CurrentPassword.PasswordChar = '*';
            this.Tb_CurrentPassword.Size = new System.Drawing.Size(369, 54);
            this.Tb_CurrentPassword.TabIndex = 4;
            this.Tb_CurrentPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_CurrentPassword_KeyDown);
            // 
            // Tb_NewPassword
            // 
            this.Tb_NewPassword.Font = new System.Drawing.Font("MS UI Gothic", 27.75F);
            this.Tb_NewPassword.Location = new System.Drawing.Point(589, 207);
            this.Tb_NewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_NewPassword.Name = "Tb_NewPassword";
            this.Tb_NewPassword.PasswordChar = '*';
            this.Tb_NewPassword.Size = new System.Drawing.Size(369, 54);
            this.Tb_NewPassword.TabIndex = 5;
            this.Tb_NewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_NewPassword_KeyDown);
            // 
            // Tb_Reenter
            // 
            this.Tb_Reenter.Font = new System.Drawing.Font("MS UI Gothic", 27.75F);
            this.Tb_Reenter.Location = new System.Drawing.Point(589, 319);
            this.Tb_Reenter.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Reenter.Name = "Tb_Reenter";
            this.Tb_Reenter.PasswordChar = '*';
            this.Tb_Reenter.Size = new System.Drawing.Size(369, 54);
            this.Tb_Reenter.TabIndex = 6;
            this.Tb_Reenter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_Reenter_KeyDown);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.Color.Red;
            this.Btn_Cancel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Cancel.Location = new System.Drawing.Point(564, 453);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(124, 50);
            this.Btn_Cancel.TabIndex = 7;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_ShowPass
            // 
            this.Btn_ShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ShowPass.Location = new System.Drawing.Point(966, 92);
            this.Btn_ShowPass.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ShowPass.Name = "Btn_ShowPass";
            this.Btn_ShowPass.Size = new System.Drawing.Size(53, 59);
            this.Btn_ShowPass.TabIndex = 11;
            this.Btn_ShowPass.Text = "👁️";
            this.Btn_ShowPass.UseVisualStyleBackColor = true;
            this.Btn_ShowPass.Click += new System.EventHandler(this.Btn_ShowPass_Click);
            // 
            // ChangePassword_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_ShowPass);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Tb_Reenter);
            this.Controls.Add(this.Tb_NewPassword);
            this.Controls.Add(this.Tb_CurrentPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangePassword_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_CurrentPassword;
        private System.Windows.Forms.TextBox Tb_NewPassword;
        private System.Windows.Forms.TextBox Tb_Reenter;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_ShowPass;
    }
}