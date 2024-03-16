namespace Inventory_Tracking_and_Managment
{
    partial class IngestItems_Form
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
            this.PBIF_Pic = new System.Windows.Forms.PictureBox();
            this.TBIF_Name = new System.Windows.Forms.TextBox();
            this.TBIF_Description = new System.Windows.Forms.TextBox();
            this.TBIF_Serial = new System.Windows.Forms.TextBox();
            this.TBIF_Ro = new System.Windows.Forms.TextBox();
            this.BtnIF_Upload = new System.Windows.Forms.Button();
            this.BtnIF_Submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Btn_GenerateTagID = new System.Windows.Forms.Button();
            this.BtnIF_Back = new System.Windows.Forms.Button();
            this.CBIF_Condition = new System.Windows.Forms.ComboBox();
            this.Btn_ClearAllFields = new System.Windows.Forms.Button();
            this.LIF_Filename = new System.Windows.Forms.Label();
            this.LIF_Location = new System.Windows.Forms.Label();
            this.CBIF_Location = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBIF_Pic)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PBIF_Pic
            // 
            this.PBIF_Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBIF_Pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBIF_Pic.Location = new System.Drawing.Point(88, 85);
            this.PBIF_Pic.Name = "PBIF_Pic";
            this.PBIF_Pic.Size = new System.Drawing.Size(470, 412);
            this.PBIF_Pic.TabIndex = 0;
            this.PBIF_Pic.TabStop = false;
            // 
            // TBIF_Name
            // 
            this.TBIF_Name.Location = new System.Drawing.Point(840, 48);
            this.TBIF_Name.Name = "TBIF_Name";
            this.TBIF_Name.Size = new System.Drawing.Size(351, 20);
            this.TBIF_Name.TabIndex = 1;
            // 
            // TBIF_Description
            // 
            this.TBIF_Description.Location = new System.Drawing.Point(840, 116);
            this.TBIF_Description.Multiline = true;
            this.TBIF_Description.Name = "TBIF_Description";
            this.TBIF_Description.Size = new System.Drawing.Size(351, 67);
            this.TBIF_Description.TabIndex = 2;
            // 
            // TBIF_Serial
            // 
            this.TBIF_Serial.Location = new System.Drawing.Point(840, 337);
            this.TBIF_Serial.Name = "TBIF_Serial";
            this.TBIF_Serial.Size = new System.Drawing.Size(351, 20);
            this.TBIF_Serial.TabIndex = 4;
            // 
            // TBIF_Ro
            // 
            this.TBIF_Ro.Location = new System.Drawing.Point(840, 403);
            this.TBIF_Ro.Name = "TBIF_Ro";
            this.TBIF_Ro.Size = new System.Drawing.Size(351, 20);
            this.TBIF_Ro.TabIndex = 5;
            // 
            // BtnIF_Upload
            // 
            this.BtnIF_Upload.Location = new System.Drawing.Point(88, 499);
            this.BtnIF_Upload.Name = "BtnIF_Upload";
            this.BtnIF_Upload.Size = new System.Drawing.Size(140, 42);
            this.BtnIF_Upload.TabIndex = 9;
            this.BtnIF_Upload.Text = "Upload";
            this.BtnIF_Upload.UseVisualStyleBackColor = true;
            this.BtnIF_Upload.Click += new System.EventHandler(this.BtnIF_Upload_Click);
            // 
            // BtnIF_Submit
            // 
            this.BtnIF_Submit.BackColor = System.Drawing.Color.Lime;
            this.BtnIF_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIF_Submit.Location = new System.Drawing.Point(1253, 553);
            this.BtnIF_Submit.Name = "BtnIF_Submit";
            this.BtnIF_Submit.Size = new System.Drawing.Size(122, 41);
            this.BtnIF_Submit.TabIndex = 10;
            this.BtnIF_Submit.Text = "Submit";
            this.BtnIF_Submit.UseVisualStyleBackColor = false;
            this.BtnIF_Submit.Click += new System.EventHandler(this.BtnIF_Submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(722, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(722, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(722, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Condition:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(722, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Serial #:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(722, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "RO#:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(722, 477);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Tag ID:";
            // 
            // Btn_GenerateTagID
            // 
            this.Btn_GenerateTagID.Location = new System.Drawing.Point(920, 477);
            this.Btn_GenerateTagID.Name = "Btn_GenerateTagID";
            this.Btn_GenerateTagID.Size = new System.Drawing.Size(192, 36);
            this.Btn_GenerateTagID.TabIndex = 17;
            this.Btn_GenerateTagID.Text = "Generate ID #";
            this.Btn_GenerateTagID.UseVisualStyleBackColor = true;
            this.Btn_GenerateTagID.Click += new System.EventHandler(this.Btn_GenerateTagID_Click);
            // 
            // BtnIF_Back
            // 
            this.BtnIF_Back.BackColor = System.Drawing.Color.Red;
            this.BtnIF_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIF_Back.Location = new System.Drawing.Point(12, 13);
            this.BtnIF_Back.Name = "BtnIF_Back";
            this.BtnIF_Back.Size = new System.Drawing.Size(122, 41);
            this.BtnIF_Back.TabIndex = 18;
            this.BtnIF_Back.Text = "Back";
            this.BtnIF_Back.UseVisualStyleBackColor = false;
            this.BtnIF_Back.Click += new System.EventHandler(this.BtnIF_Back_Click);
            // 
            // CBIF_Condition
            // 
            this.CBIF_Condition.FormattingEnabled = true;
            this.CBIF_Condition.Items.AddRange(new object[] {
            "New",
            "Good",
            "Needs Repair",
            "Broken"});
            this.CBIF_Condition.Location = new System.Drawing.Point(840, 207);
            this.CBIF_Condition.Name = "CBIF_Condition";
            this.CBIF_Condition.Size = new System.Drawing.Size(351, 21);
            this.CBIF_Condition.TabIndex = 19;
            // 
            // Btn_ClearAllFields
            // 
            this.Btn_ClearAllFields.Location = new System.Drawing.Point(968, 519);
            this.Btn_ClearAllFields.Name = "Btn_ClearAllFields";
            this.Btn_ClearAllFields.Size = new System.Drawing.Size(92, 24);
            this.Btn_ClearAllFields.TabIndex = 20;
            this.Btn_ClearAllFields.Text = "Clear All Fields";
            this.Btn_ClearAllFields.UseVisualStyleBackColor = true;
            this.Btn_ClearAllFields.Click += new System.EventHandler(this.Btn_ClearAllFields_Click);
            // 
            // LIF_Filename
            // 
            this.LIF_Filename.AutoSize = true;
            this.LIF_Filename.Location = new System.Drawing.Point(234, 514);
            this.LIF_Filename.Name = "LIF_Filename";
            this.LIF_Filename.Size = new System.Drawing.Size(49, 13);
            this.LIF_Filename.TabIndex = 21;
            this.LIF_Filename.Text = "Filename";
            // 
            // LIF_Location
            // 
            this.LIF_Location.AutoSize = true;
            this.LIF_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LIF_Location.Location = new System.Drawing.Point(722, 275);
            this.LIF_Location.Name = "LIF_Location";
            this.LIF_Location.Size = new System.Drawing.Size(74, 20);
            this.LIF_Location.TabIndex = 22;
            this.LIF_Location.Text = "Location:";
            // 
            // CBIF_Location
            // 
            this.CBIF_Location.FormattingEnabled = true;
            this.CBIF_Location.Location = new System.Drawing.Point(840, 273);
            this.CBIF_Location.Name = "CBIF_Location";
            this.CBIF_Location.Size = new System.Drawing.Size(351, 21);
            this.CBIF_Location.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.PBIF_Pic);
            this.panel2.Controls.Add(this.CBIF_Location);
            this.panel2.Controls.Add(this.TBIF_Name);
            this.panel2.Controls.Add(this.LIF_Location);
            this.panel2.Controls.Add(this.TBIF_Description);
            this.panel2.Controls.Add(this.LIF_Filename);
            this.panel2.Controls.Add(this.TBIF_Serial);
            this.panel2.Controls.Add(this.Btn_ClearAllFields);
            this.panel2.Controls.Add(this.TBIF_Ro);
            this.panel2.Controls.Add(this.CBIF_Condition);
            this.panel2.Controls.Add(this.BtnIF_Upload);
            this.panel2.Controls.Add(this.BtnIF_Back);
            this.panel2.Controls.Add(this.BtnIF_Submit);
            this.panel2.Controls.Add(this.Btn_GenerateTagID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(221, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1388, 608);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Inventory_Tracking_and_Managment.Properties.Resources.Background;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1625, 802);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 205);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // IngestItems_Form
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1862, 1019);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngestItems_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.PBIF_Pic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CB_Condition;
        private System.Windows.Forms.Button Btn_GenTagID;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Label L_Filename;
        private System.Windows.Forms.Button Btn_Upload;
        private System.Windows.Forms.TextBox TB_Ro;
        private System.Windows.Forms.TextBox TB_Serial;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RTB_Description;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_ItemSearch;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Label L_TagId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox Pb_Item;
        private System.Windows.Forms.PictureBox PBIF_Pic;
        private System.Windows.Forms.TextBox TBIF_Name;
        private System.Windows.Forms.TextBox TBIF_Description;
        private System.Windows.Forms.TextBox TBIF_Serial;
        private System.Windows.Forms.TextBox TBIF_Ro;
        private System.Windows.Forms.Button BtnIF_Upload;
        private System.Windows.Forms.Button BtnIF_Submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Btn_GenerateTagID;
        private System.Windows.Forms.Button BtnIF_Back;
        private System.Windows.Forms.ComboBox CBIF_Condition;
        private System.Windows.Forms.Button Btn_ClearAllFields;
        private System.Windows.Forms.Label LIF_Filename;
        private System.Windows.Forms.Label LIF_Location;
        private System.Windows.Forms.ComboBox CBIF_Location;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}