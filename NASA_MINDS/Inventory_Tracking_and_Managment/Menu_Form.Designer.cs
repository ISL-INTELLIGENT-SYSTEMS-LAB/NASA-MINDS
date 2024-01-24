namespace Inventory_Tracking_and_Managment
{
    partial class Menu_Form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_FindItems = new System.Windows.Forms.Button();
            this.Btn_ShoppingList = new System.Windows.Forms.Button();
            this.Btn_Modify_Items = new System.Windows.Forms.Button();
            this.Btn_IngestItems = new System.Windows.Forms.Button();
            this.Btn_Account = new System.Windows.Forms.Button();
            this.Btn_Logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Inventory_Tracking_and_Managment.Properties.Resources.Background;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1263, 783);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 205);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_FindItems
            // 
            this.Btn_FindItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FindItems.Location = new System.Drawing.Point(0, 0);
            this.Btn_FindItems.Name = "Btn_FindItems";
            this.Btn_FindItems.Size = new System.Drawing.Size(474, 236);
            this.Btn_FindItems.TabIndex = 4;
            this.Btn_FindItems.Text = "Find Items";
            this.Btn_FindItems.UseVisualStyleBackColor = true;
            this.Btn_FindItems.Click += new System.EventHandler(this.Btn_FindItems_Click);
            // 
            // Btn_ShoppingList
            // 
            this.Btn_ShoppingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ShoppingList.Location = new System.Drawing.Point(514, 3);
            this.Btn_ShoppingList.Name = "Btn_ShoppingList";
            this.Btn_ShoppingList.Size = new System.Drawing.Size(474, 236);
            this.Btn_ShoppingList.TabIndex = 5;
            this.Btn_ShoppingList.Text = "Shopping Lists";
            this.Btn_ShoppingList.UseVisualStyleBackColor = true;
            this.Btn_ShoppingList.Click += new System.EventHandler(this.Btn_ShoppingList_Click);
            // 
            // Btn_Modify_Items
            // 
            this.Btn_Modify_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modify_Items.Location = new System.Drawing.Point(3, 311);
            this.Btn_Modify_Items.Name = "Btn_Modify_Items";
            this.Btn_Modify_Items.Size = new System.Drawing.Size(474, 236);
            this.Btn_Modify_Items.TabIndex = 6;
            this.Btn_Modify_Items.Text = "Modify Items";
            this.Btn_Modify_Items.UseVisualStyleBackColor = true;
            this.Btn_Modify_Items.Click += new System.EventHandler(this.Btn_Modify_Items_Click);
            // 
            // Btn_IngestItems
            // 
            this.Btn_IngestItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_IngestItems.Location = new System.Drawing.Point(517, 311);
            this.Btn_IngestItems.Name = "Btn_IngestItems";
            this.Btn_IngestItems.Size = new System.Drawing.Size(474, 236);
            this.Btn_IngestItems.TabIndex = 7;
            this.Btn_IngestItems.Text = "Ingest Items";
            this.Btn_IngestItems.UseVisualStyleBackColor = true;
            this.Btn_IngestItems.Click += new System.EventHandler(this.Btn_IngestItems_Click);
            // 
            // Btn_Account
            // 
            this.Btn_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Account.Location = new System.Drawing.Point(3, 608);
            this.Btn_Account.Name = "Btn_Account";
            this.Btn_Account.Size = new System.Drawing.Size(474, 236);
            this.Btn_Account.TabIndex = 8;
            this.Btn_Account.Text = "Account";
            this.Btn_Account.UseVisualStyleBackColor = true;
            this.Btn_Account.Click += new System.EventHandler(this.Btn_Account_Click);
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Logout.Location = new System.Drawing.Point(517, 611);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.Size = new System.Drawing.Size(474, 236);
            this.Btn_Logout.TabIndex = 9;
            this.Btn_Logout.Text = "Log Out";
            this.Btn_Logout.UseVisualStyleBackColor = false;
            this.Btn_Logout.Click += new System.EventHandler(this.Btn_Logout_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.Btn_Logout);
            this.panel1.Controls.Add(this.Btn_Modify_Items);
            this.panel1.Controls.Add(this.Btn_IngestItems);
            this.panel1.Controls.Add(this.Btn_FindItems);
            this.panel1.Controls.Add(this.Btn_ShoppingList);
            this.panel1.Controls.Add(this.Btn_Account);
            this.panel1.Location = new System.Drawing.Point(154, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 850);
            this.panel1.TabIndex = 10;
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1500, 1000);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_FindItems;
        private System.Windows.Forms.Button Btn_ShoppingList;
        private System.Windows.Forms.Button Btn_Modify_Items;
        private System.Windows.Forms.Button Btn_IngestItems;
        private System.Windows.Forms.Button Btn_Account;
        private System.Windows.Forms.Button Btn_Logout;
        private System.Windows.Forms.Panel panel1;
    }
}