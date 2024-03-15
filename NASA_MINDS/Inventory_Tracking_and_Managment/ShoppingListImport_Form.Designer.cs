namespace Inventory_Tracking_and_Managment
{
    partial class ShoppingListImport_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingListImport_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Found = new System.Windows.Forms.Button();
            this.Btn_Locate = new System.Windows.Forms.Button();
            this.LB_FoundItems = new System.Windows.Forms.ListBox();
            this.PB_Item = new System.Windows.Forms.PictureBox();
            this.Btn_LoadItems = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.L_LastLocation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.L_LastLocation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_Found);
            this.panel1.Controls.Add(this.Btn_Locate);
            this.panel1.Controls.Add(this.LB_FoundItems);
            this.panel1.Controls.Add(this.PB_Item);
            this.panel1.Controls.Add(this.Btn_LoadItems);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Btn_Back);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1561, 765);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Found
            // 
            this.Btn_Found.Location = new System.Drawing.Point(849, 202);
            this.Btn_Found.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Found.Name = "Btn_Found";
            this.Btn_Found.Size = new System.Drawing.Size(234, 134);
            this.Btn_Found.TabIndex = 28;
            this.Btn_Found.Text = "Item Found";
            this.Btn_Found.UseVisualStyleBackColor = true;
            this.Btn_Found.Click += new System.EventHandler(this.Btn_Found_Click);
            // 
            // Btn_Locate
            // 
            this.Btn_Locate.Location = new System.Drawing.Point(849, 48);
            this.Btn_Locate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Locate.Name = "Btn_Locate";
            this.Btn_Locate.Size = new System.Drawing.Size(234, 131);
            this.Btn_Locate.TabIndex = 27;
            this.Btn_Locate.Text = "Locate Item";
            this.Btn_Locate.UseVisualStyleBackColor = true;
            this.Btn_Locate.Click += new System.EventHandler(this.Btn_Locate_Click);
            // 
            // LB_FoundItems
            // 
            this.LB_FoundItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FoundItems.FormattingEnabled = true;
            this.LB_FoundItems.ItemHeight = 44;
            this.LB_FoundItems.Location = new System.Drawing.Point(836, 357);
            this.LB_FoundItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LB_FoundItems.Name = "LB_FoundItems";
            this.LB_FoundItems.Size = new System.Drawing.Size(711, 400);
            this.LB_FoundItems.TabIndex = 26;
            // 
            // PB_Item
            // 
            this.PB_Item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_Item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Item.Location = new System.Drawing.Point(1099, 63);
            this.PB_Item.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PB_Item.Name = "PB_Item";
            this.PB_Item.Size = new System.Drawing.Size(448, 289);
            this.PB_Item.TabIndex = 25;
            this.PB_Item.TabStop = false;
            // 
            // Btn_LoadItems
            // 
            this.Btn_LoadItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LoadItems.Location = new System.Drawing.Point(80, 3);
            this.Btn_LoadItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_LoadItems.Name = "Btn_LoadItems";
            this.Btn_LoadItems.Size = new System.Drawing.Size(167, 30);
            this.Btn_LoadItems.TabIndex = 24;
            this.Btn_LoadItems.Text = "Import Shopping List";
            this.Btn_LoadItems.UseVisualStyleBackColor = true;
            this.Btn_LoadItems.Click += new System.EventHandler(this.Btn_LoadItems_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemDescription,
            this.SerialNum,
            this.Condition,
            this.RNNum,
            this.RFID});
            this.dataGridView1.Location = new System.Drawing.Point(3, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(829, 712);
            this.dataGridView1.TabIndex = 23;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 125;
            // 
            // ItemDescription
            // 
            this.ItemDescription.HeaderText = "Description";
            this.ItemDescription.MinimumWidth = 6;
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            this.ItemDescription.Width = 125;
            // 
            // SerialNum
            // 
            this.SerialNum.HeaderText = "Searial #";
            this.SerialNum.MinimumWidth = 6;
            this.SerialNum.Name = "SerialNum";
            this.SerialNum.ReadOnly = true;
            this.SerialNum.Width = 125;
            // 
            // Condition
            // 
            this.Condition.HeaderText = "Condition";
            this.Condition.MinimumWidth = 6;
            this.Condition.Name = "Condition";
            this.Condition.ReadOnly = true;
            this.Condition.Width = 125;
            // 
            // RNNum
            // 
            this.RNNum.HeaderText = "RN #";
            this.RNNum.MinimumWidth = 6;
            this.RNNum.Name = "RNNum";
            this.RNNum.ReadOnly = true;
            this.RNNum.Width = 125;
            // 
            // RFID
            // 
            this.RFID.HeaderText = "RFID#";
            this.RFID.MinimumWidth = 6;
            this.RFID.Name = "RFID";
            this.RFID.ReadOnly = true;
            this.RFID.Width = 125;
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackColor = System.Drawing.Color.Red;
            this.Btn_Back.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(3, 3);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(72, 30);
            this.Btn_Back.TabIndex = 22;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1099, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Location:";
            // 
            // L_LastLocation
            // 
            this.L_LastLocation.AutoSize = true;
            this.L_LastLocation.Location = new System.Drawing.Point(1157, 48);
            this.L_LastLocation.Name = "L_LastLocation";
            this.L_LastLocation.Size = new System.Drawing.Size(0, 13);
            this.L_LastLocation.TabIndex = 30;
            // 
            // ShoppingListImport_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1583, 787);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShoppingListImport_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShoppingListImport_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_LoadItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFID;
        private System.Windows.Forms.PictureBox PB_Item;
        private System.Windows.Forms.Button Btn_Locate;
        private System.Windows.Forms.ListBox LB_FoundItems;
        private System.Windows.Forms.Button Btn_Found;
        private System.Windows.Forms.Label L_LastLocation;
        private System.Windows.Forms.Label label1;
    }
}