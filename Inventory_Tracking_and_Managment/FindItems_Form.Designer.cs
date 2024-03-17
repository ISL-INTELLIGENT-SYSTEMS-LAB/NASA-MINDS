namespace Inventory_Tracking_and_Managment
{
    partial class FindItems_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindItems_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.L_Location = new System.Windows.Forms.Label();
            this.L_Locationi = new System.Windows.Forms.Label();
            this.L_Condition = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RTB_Description = new System.Windows.Forms.RichTextBox();
            this.L_SerialNum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_ItemSearch = new System.Windows.Forms.ComboBox();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.L_TagId = new System.Windows.Forms.Label();
            this.L_RO = new System.Windows.Forms.Label();
            this.L_Name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Pb_Item = new System.Windows.Forms.PictureBox();
            this.TB_ItemLocation = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1680, 689);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 143);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TB_ItemLocation);
            this.panel1.Controls.Add(this.L_Location);
            this.panel1.Controls.Add(this.L_Locationi);
            this.panel1.Controls.Add(this.L_Condition);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.RTB_Description);
            this.panel1.Controls.Add(this.L_SerialNum);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CB_ItemSearch);
            this.panel1.Controls.Add(this.Btn_Back);
            this.panel1.Controls.Add(this.L_TagId);
            this.panel1.Controls.Add(this.L_RO);
            this.panel1.Controls.Add(this.L_Name);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Pb_Item);
            this.panel1.Location = new System.Drawing.Point(457, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 384);
            this.panel1.TabIndex = 1;
            // 
            // L_Location
            // 
            this.L_Location.AutoSize = true;
            this.L_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Location.Location = new System.Drawing.Point(628, 131);
            this.L_Location.Name = "L_Location";
            this.L_Location.Size = new System.Drawing.Size(0, 37);
            this.L_Location.TabIndex = 29;
            // 
            // L_Locationi
            // 
            this.L_Locationi.AutoSize = true;
            this.L_Locationi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.L_Locationi.ForeColor = System.Drawing.Color.Black;
            this.L_Locationi.Location = new System.Drawing.Point(365, 121);
            this.L_Locationi.Name = "L_Locationi";
            this.L_Locationi.Size = new System.Drawing.Size(83, 20);
            this.L_Locationi.TabIndex = 28;
            this.L_Locationi.Text = "Location:";
            // 
            // L_Condition
            // 
            this.L_Condition.AutoSize = true;
            this.L_Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Condition.Location = new System.Drawing.Point(461, 242);
            this.L_Condition.Name = "L_Condition";
            this.L_Condition.Size = new System.Drawing.Size(0, 13);
            this.L_Condition.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(365, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Condition:";
            // 
            // RTB_Description
            // 
            this.RTB_Description.Enabled = false;
            this.RTB_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_Description.Location = new System.Drawing.Point(476, 149);
            this.RTB_Description.Name = "RTB_Description";
            this.RTB_Description.ReadOnly = true;
            this.RTB_Description.Size = new System.Drawing.Size(272, 86);
            this.RTB_Description.TabIndex = 24;
            this.RTB_Description.Text = "";
            // 
            // L_SerialNum
            // 
            this.L_SerialNum.AutoSize = true;
            this.L_SerialNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_SerialNum.Location = new System.Drawing.Point(446, 264);
            this.L_SerialNum.Name = "L_SerialNum";
            this.L_SerialNum.Size = new System.Drawing.Size(0, 13);
            this.L_SerialNum.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(365, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Serial #:";
            // 
            // CB_ItemSearch
            // 
            this.CB_ItemSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_ItemSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_ItemSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ItemSearch.FormattingEnabled = true;
            this.CB_ItemSearch.Location = new System.Drawing.Point(93, 18);
            this.CB_ItemSearch.Name = "CB_ItemSearch";
            this.CB_ItemSearch.Size = new System.Drawing.Size(655, 28);
            this.CB_ItemSearch.TabIndex = 21;
            this.CB_ItemSearch.SelectedIndexChanged += new System.EventHandler(this.CB_ItemSearch_SelectedIndexChanged);
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(15, 18);
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
            this.L_TagId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_TagId.Location = new System.Drawing.Point(439, 302);
            this.L_TagId.Name = "L_TagId";
            this.L_TagId.Size = new System.Drawing.Size(0, 13);
            this.L_TagId.TabIndex = 18;
            // 
            // L_RO
            // 
            this.L_RO.AutoSize = true;
            this.L_RO.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_RO.Location = new System.Drawing.Point(426, 282);
            this.L_RO.Name = "L_RO";
            this.L_RO.Size = new System.Drawing.Size(0, 13);
            this.L_RO.TabIndex = 17;
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Name.Location = new System.Drawing.Point(431, 106);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(0, 13);
            this.L_Name.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(365, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "RO #:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(365, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tag ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(365, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Description:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(365, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Name:";
            // 
            // Pb_Item
            // 
            this.Pb_Item.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pb_Item.BackgroundImage")));
            this.Pb_Item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pb_Item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pb_Item.Location = new System.Drawing.Point(15, 54);
            this.Pb_Item.Name = "Pb_Item";
            this.Pb_Item.Size = new System.Drawing.Size(345, 312);
            this.Pb_Item.TabIndex = 0;
            this.Pb_Item.TabStop = false;
            // 
            // TB_ItemLocation
            // 
            this.TB_ItemLocation.Location = new System.Drawing.Point(454, 123);
            this.TB_ItemLocation.Name = "TB_ItemLocation";
            this.TB_ItemLocation.Size = new System.Drawing.Size(294, 20);
            this.TB_ItemLocation.TabIndex = 31;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::Inventory_Tracking_and_Managment.Properties.Resources.Background;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1442, 657);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 175);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // FindItems_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1629, 844);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindItems_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindItems_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Pb_Item;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.Label L_TagId;
        private System.Windows.Forms.Label L_RO;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.ComboBox CB_ItemSearch;
        private System.Windows.Forms.Label L_SerialNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox RTB_Description;
        private System.Windows.Forms.Label L_Condition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_Location;
        private System.Windows.Forms.Label L_Locationi;
        private System.Windows.Forms.TextBox TB_ItemLocation;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}