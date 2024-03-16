namespace Inventory_Tracking_and_Managment
{
    partial class ShoppingListCreation_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingListCreation_Form));
            this.CB_ItemSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Location = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Condition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_SN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_RN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_Tag = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RTB_Description = new System.Windows.Forms.RichTextBox();
            this.LB_ShoppingList = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Btn_Generate = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.Btn_AddItem = new System.Windows.Forms.Button();
            this.PB_Item = new System.Windows.Forms.PictureBox();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_ItemSelector
            // 
            this.CB_ItemSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_ItemSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_ItemSelector.FormattingEnabled = true;
            this.CB_ItemSelector.Location = new System.Drawing.Point(13, 27);
            this.CB_ItemSelector.Name = "CB_ItemSelector";
            this.CB_ItemSelector.Size = new System.Drawing.Size(380, 21);
            this.CB_ItemSelector.TabIndex = 0;
            this.CB_ItemSelector.SelectedIndexChanged += new System.EventHandler(this.CB_ItemSearch_SelectorIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select an item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // TB_Name
            // 
            this.TB_Name.BackColor = System.Drawing.Color.White;
            this.TB_Name.Enabled = false;
            this.TB_Name.Location = new System.Drawing.Point(78, 249);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.ReadOnly = true;
            this.TB_Name.Size = new System.Drawing.Size(315, 20);
            this.TB_Name.TabIndex = 3;
            // 
            // TB_Location
            // 
            this.TB_Location.BackColor = System.Drawing.Color.White;
            this.TB_Location.Enabled = false;
            this.TB_Location.Location = new System.Drawing.Point(78, 275);
            this.TB_Location.Name = "TB_Location";
            this.TB_Location.ReadOnly = true;
            this.TB_Location.Size = new System.Drawing.Size(315, 20);
            this.TB_Location.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // TB_Condition
            // 
            this.TB_Condition.BackColor = System.Drawing.Color.White;
            this.TB_Condition.Enabled = false;
            this.TB_Condition.Location = new System.Drawing.Point(78, 488);
            this.TB_Condition.Name = "TB_Condition";
            this.TB_Condition.ReadOnly = true;
            this.TB_Condition.Size = new System.Drawing.Size(315, 20);
            this.TB_Condition.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Condition";
            // 
            // TB_SN
            // 
            this.TB_SN.BackColor = System.Drawing.Color.White;
            this.TB_SN.Enabled = false;
            this.TB_SN.Location = new System.Drawing.Point(78, 514);
            this.TB_SN.Name = "TB_SN";
            this.TB_SN.ReadOnly = true;
            this.TB_SN.Size = new System.Drawing.Size(315, 20);
            this.TB_SN.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 517);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Serial #";
            // 
            // TB_RN
            // 
            this.TB_RN.BackColor = System.Drawing.Color.White;
            this.TB_RN.Enabled = false;
            this.TB_RN.Location = new System.Drawing.Point(78, 540);
            this.TB_RN.Name = "TB_RN";
            this.TB_RN.ReadOnly = true;
            this.TB_RN.Size = new System.Drawing.Size(315, 20);
            this.TB_RN.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "RN #";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(139, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Item Description";
            // 
            // TB_Tag
            // 
            this.TB_Tag.BackColor = System.Drawing.Color.White;
            this.TB_Tag.Enabled = false;
            this.TB_Tag.Location = new System.Drawing.Point(78, 566);
            this.TB_Tag.Name = "TB_Tag";
            this.TB_Tag.ReadOnly = true;
            this.TB_Tag.Size = new System.Drawing.Size(315, 20);
            this.TB_Tag.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 569);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tag ID";
            // 
            // RTB_Description
            // 
            this.RTB_Description.BackColor = System.Drawing.Color.White;
            this.RTB_Description.Enabled = false;
            this.RTB_Description.Location = new System.Drawing.Point(78, 304);
            this.RTB_Description.Name = "RTB_Description";
            this.RTB_Description.ReadOnly = true;
            this.RTB_Description.Size = new System.Drawing.Size(315, 178);
            this.RTB_Description.TabIndex = 17;
            this.RTB_Description.Text = "";
            // 
            // LB_ShoppingList
            // 
            this.LB_ShoppingList.FormattingEnabled = true;
            this.LB_ShoppingList.Location = new System.Drawing.Point(466, 27);
            this.LB_ShoppingList.Name = "LB_ShoppingList";
            this.LB_ShoppingList.Size = new System.Drawing.Size(280, 563);
            this.LB_ShoppingList.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(463, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Current List of items";
            // 
            // Btn_Generate
            // 
            this.Btn_Generate.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Generate.Location = new System.Drawing.Point(752, 486);
            this.Btn_Generate.Name = "Btn_Generate";
            this.Btn_Generate.Size = new System.Drawing.Size(75, 74);
            this.Btn_Generate.TabIndex = 20;
            this.Btn_Generate.Text = "Generate Shopping List";
            this.Btn_Generate.UseVisualStyleBackColor = false;
            this.Btn_Generate.Click += new System.EventHandler(this.Btn_Generate_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Location = new System.Drawing.Point(752, 566);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.Btn_Clear.TabIndex = 21;
            this.Btn_Clear.Text = "Clear All";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.Btn_Remove);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.Btn_AddItem);
            this.panel1.Controls.Add(this.PB_Item);
            this.panel1.Controls.Add(this.Btn_Back);
            this.panel1.Controls.Add(this.LB_ShoppingList);
            this.panel1.Controls.Add(this.Btn_Clear);
            this.panel1.Controls.Add(this.CB_ItemSelector);
            this.panel1.Controls.Add(this.Btn_Generate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TB_Name);
            this.panel1.Controls.Add(this.RTB_Description);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TB_Tag);
            this.panel1.Controls.Add(this.TB_Location);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TB_RN);
            this.panel1.Controls.Add(this.TB_Condition);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TB_SN);
            this.panel1.Location = new System.Drawing.Point(375, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 609);
            this.panel1.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(413, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Add";
            // 
            // Btn_AddItem
            // 
            this.Btn_AddItem.Location = new System.Drawing.Point(404, 294);
            this.Btn_AddItem.Name = "Btn_AddItem";
            this.Btn_AddItem.Size = new System.Drawing.Size(46, 23);
            this.Btn_AddItem.TabIndex = 24;
            this.Btn_AddItem.Text = "🡺";
            this.Btn_AddItem.UseVisualStyleBackColor = true;
            this.Btn_AddItem.Click += new System.EventHandler(this.Btn_AddItem_Click);
            // 
            // PB_Item
            // 
            this.PB_Item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_Item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Item.Location = new System.Drawing.Point(13, 74);
            this.PB_Item.Name = "PB_Item";
            this.PB_Item.Size = new System.Drawing.Size(380, 169);
            this.PB_Item.TabIndex = 23;
            this.PB_Item.TabStop = false;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(752, 11);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(75, 23);
            this.Btn_Back.TabIndex = 22;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Inventory_Tracking_and_Managment.Properties.Resources.Background;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1337, 610);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 182);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(404, 320);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Remove";
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Location = new System.Drawing.Point(404, 339);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(46, 23);
            this.Btn_Remove.TabIndex = 26;
            this.Btn_Remove.Text = "🡸";
            this.Btn_Remove.UseVisualStyleBackColor = true;
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // ShoppingListCreation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1569, 804);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShoppingListCreation_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShoppingListCreation_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_ItemSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Location;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Condition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_SN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_RN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Tag;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox RTB_Description;
        private System.Windows.Forms.ListBox LB_ShoppingList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Btn_Generate;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.PictureBox PB_Item;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Btn_AddItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Btn_Remove;
    }
}