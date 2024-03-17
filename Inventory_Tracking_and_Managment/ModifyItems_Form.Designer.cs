namespace Inventory_Tracking_and_Managment
{
    partial class ModifyItems_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyItems_Form));
            this.P_ = new System.Windows.Forms.Panel();
            this.Btn_EditLocation = new System.Windows.Forms.Button();
            this.L_Location = new System.Windows.Forms.Label();
            this.CB_Condition = new System.Windows.Forms.ComboBox();
            this.Btn_GenTagID = new System.Windows.Forms.Button();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.L_Filename = new System.Windows.Forms.Label();
            this.Btn_Upload = new System.Windows.Forms.Button();
            this.TB_Ro = new System.Windows.Forms.TextBox();
            this.TB_Serial = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RTB_Description = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_ItemSearch = new System.Windows.Forms.ComboBox();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.L_TagId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Pb_Item = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CB_Location = new System.Windows.Forms.ComboBox();
            this.P_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // P_
            // 
            this.P_.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P_.BackColor = System.Drawing.Color.White;
            this.P_.Controls.Add(this.CB_Location);
            this.P_.Controls.Add(this.Btn_EditLocation);
            this.P_.Controls.Add(this.L_Location);
            this.P_.Controls.Add(this.CB_Condition);
            this.P_.Controls.Add(this.Btn_GenTagID);
            this.P_.Controls.Add(this.Btn_Submit);
            this.P_.Controls.Add(this.L_Filename);
            this.P_.Controls.Add(this.Btn_Upload);
            this.P_.Controls.Add(this.TB_Ro);
            this.P_.Controls.Add(this.TB_Serial);
            this.P_.Controls.Add(this.TB_Name);
            this.P_.Controls.Add(this.label3);
            this.P_.Controls.Add(this.RTB_Description);
            this.P_.Controls.Add(this.label7);
            this.P_.Controls.Add(this.CB_ItemSearch);
            this.P_.Controls.Add(this.Btn_Back);
            this.P_.Controls.Add(this.L_TagId);
            this.P_.Controls.Add(this.label6);
            this.P_.Controls.Add(this.label5);
            this.P_.Controls.Add(this.label1);
            this.P_.Controls.Add(this.label9);
            this.P_.Controls.Add(this.Pb_Item);
            this.P_.Location = new System.Drawing.Point(176, 58);
            this.P_.Name = "P_";
            this.P_.Size = new System.Drawing.Size(1192, 583);
            this.P_.TabIndex = 2;
            // 
            // Btn_EditLocation
            // 
            this.Btn_EditLocation.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_EditLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EditLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditLocation.Location = new System.Drawing.Point(931, 14);
            this.Btn_EditLocation.Name = "Btn_EditLocation";
            this.Btn_EditLocation.Size = new System.Drawing.Size(133, 30);
            this.Btn_EditLocation.TabIndex = 40;
            this.Btn_EditLocation.Text = "Edit Location";
            this.Btn_EditLocation.UseVisualStyleBackColor = false;
            this.Btn_EditLocation.Click += new System.EventHandler(this.Btn_EditLocation_Click);
            // 
            // L_Location
            // 
            this.L_Location.AutoSize = true;
            this.L_Location.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Location.ForeColor = System.Drawing.Color.Black;
            this.L_Location.Location = new System.Drawing.Point(504, 145);
            this.L_Location.Name = "L_Location";
            this.L_Location.Size = new System.Drawing.Size(160, 35);
            this.L_Location.TabIndex = 39;
            this.L_Location.Text = "Location: ";
            // 
            // CB_Condition
            // 
            this.CB_Condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.CB_Condition.FormattingEnabled = true;
            this.CB_Condition.Items.AddRange(new object[] {
            "New",
            "Good",
            "Needs Repair",
            "Broken",
            "Unknown"});
            this.CB_Condition.Location = new System.Drawing.Point(697, 327);
            this.CB_Condition.Name = "CB_Condition";
            this.CB_Condition.Size = new System.Drawing.Size(284, 45);
            this.CB_Condition.TabIndex = 37;
            // 
            // Btn_GenTagID
            // 
            this.Btn_GenTagID.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Btn_GenTagID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_GenTagID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GenTagID.Location = new System.Drawing.Point(931, 487);
            this.Btn_GenTagID.Name = "Btn_GenTagID";
            this.Btn_GenTagID.Size = new System.Drawing.Size(152, 30);
            this.Btn_GenTagID.TabIndex = 36;
            this.Btn_GenTagID.Text = "Generate TagID";
            this.Btn_GenTagID.UseVisualStyleBackColor = false;
            this.Btn_GenTagID.Click += new System.EventHandler(this.Btn_GenTagID_Click);
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Submit.Location = new System.Drawing.Point(1091, 14);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(72, 30);
            this.Btn_Submit.TabIndex = 35;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = false;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // L_Filename
            // 
            this.L_Filename.AutoSize = true;
            this.L_Filename.Location = new System.Drawing.Point(116, 510);
            this.L_Filename.Name = "L_Filename";
            this.L_Filename.Size = new System.Drawing.Size(54, 13);
            this.L_Filename.TabIndex = 34;
            this.L_Filename.Text = "File Name";
            // 
            // Btn_Upload
            // 
            this.Btn_Upload.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Btn_Upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Upload.Location = new System.Drawing.Point(38, 500);
            this.Btn_Upload.Name = "Btn_Upload";
            this.Btn_Upload.Size = new System.Drawing.Size(72, 30);
            this.Btn_Upload.TabIndex = 33;
            this.Btn_Upload.Text = "Upload";
            this.Btn_Upload.UseVisualStyleBackColor = false;
            this.Btn_Upload.Click += new System.EventHandler(this.Btn_Upload_Click);
            // 
            // TB_Ro
            // 
            this.TB_Ro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TB_Ro.Location = new System.Drawing.Point(697, 480);
            this.TB_Ro.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Ro.Name = "TB_Ro";
            this.TB_Ro.Size = new System.Drawing.Size(223, 44);
            this.TB_Ro.TabIndex = 31;
            // 
            // TB_Serial
            // 
            this.TB_Serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TB_Serial.Location = new System.Drawing.Point(697, 421);
            this.TB_Serial.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Serial.Name = "TB_Serial";
            this.TB_Serial.Size = new System.Drawing.Size(284, 44);
            this.TB_Serial.TabIndex = 30;
            // 
            // TB_Name
            // 
            this.TB_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TB_Name.Location = new System.Drawing.Point(698, 96);
            this.TB_Name.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(283, 44);
            this.TB_Name.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(504, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 35);
            this.label3.TabIndex = 25;
            this.label3.Text = "Condition:";
            // 
            // RTB_Description
            // 
            this.RTB_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_Description.Location = new System.Drawing.Point(697, 192);
            this.RTB_Description.Name = "RTB_Description";
            this.RTB_Description.Size = new System.Drawing.Size(423, 120);
            this.RTB_Description.TabIndex = 24;
            this.RTB_Description.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(504, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 35);
            this.label7.TabIndex = 22;
            this.label7.Text = "Serial #:";
            // 
            // CB_ItemSearch
            // 
            this.CB_ItemSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_ItemSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_ItemSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ItemSearch.FormattingEnabled = true;
            this.CB_ItemSearch.Location = new System.Drawing.Point(354, 44);
            this.CB_ItemSearch.Name = "CB_ItemSearch";
            this.CB_ItemSearch.Size = new System.Drawing.Size(448, 28);
            this.CB_ItemSearch.TabIndex = 21;
            this.CB_ItemSearch.SelectedIndexChanged += new System.EventHandler(this.CB_ItemSearch_SelectedIndexChanged);
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(19, 14);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(72, 30);
            this.Btn_Back.TabIndex = 20;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // L_TagId
            // 
            this.L_TagId.AutoSize = true;
            this.L_TagId.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_TagId.Location = new System.Drawing.Point(701, 375);
            this.L_TagId.Name = "L_TagId";
            this.L_TagId.Size = new System.Drawing.Size(0, 37);
            this.L_TagId.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(504, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 35);
            this.label6.TabIndex = 12;
            this.label6.Text = "RO #:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(504, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 35);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tag ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(504, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Description:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(504, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 35);
            this.label9.TabIndex = 6;
            this.label9.Text = "Name:";
            // 
            // Pb_Item
            // 
            this.Pb_Item.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pb_Item.BackgroundImage")));
            this.Pb_Item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pb_Item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pb_Item.Location = new System.Drawing.Point(38, 105);
            this.Pb_Item.Name = "Pb_Item";
            this.Pb_Item.Size = new System.Drawing.Size(460, 389);
            this.Pb_Item.TabIndex = 0;
            this.Pb_Item.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Inventory_Tracking_and_Managment.Properties.Resources.Background;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1305, 479);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 205);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // CB_Location
            // 
            this.CB_Location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.CB_Location.FormattingEnabled = true;
            this.CB_Location.Location = new System.Drawing.Point(698, 145);
            this.CB_Location.Name = "CB_Location";
            this.CB_Location.Size = new System.Drawing.Size(283, 45);
            this.CB_Location.TabIndex = 41;
            // 
            // ModifyItems_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1542, 699);
            this.Controls.Add(this.P_);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModifyItems_Form";
            this.Text = "ModifyItems_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.P_.ResumeLayout(false);
            this.P_.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_;
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
        private System.Windows.Forms.TextBox TB_Ro;
        private System.Windows.Forms.TextBox TB_Serial;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Button Btn_Upload;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label L_Filename;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Button Btn_GenTagID;
        private System.Windows.Forms.ComboBox CB_Condition;
        private System.Windows.Forms.Label L_Location;
        private System.Windows.Forms.Button Btn_EditLocation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CB_Location;
    }
}