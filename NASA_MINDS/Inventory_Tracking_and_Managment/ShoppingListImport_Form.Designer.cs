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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingListImport_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Pb_Item = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sqliteDataAccessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqliteDataAccessBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Btn_Back);
            this.panel1.Controls.Add(this.Pb_Item);
            this.panel1.Location = new System.Drawing.Point(35, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 602);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackColor = System.Drawing.Color.Red;
            this.Btn_Back.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(4, 5);
            this.Btn_Back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(108, 46);
            this.Btn_Back.TabIndex = 22;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Pb_Item
            // 
            this.Pb_Item.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pb_Item.BackgroundImage")));
            this.Pb_Item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pb_Item.Location = new System.Drawing.Point(445, 59);
            this.Pb_Item.Name = "Pb_Item";
            this.Pb_Item.Size = new System.Drawing.Size(175, 220);
            this.Pb_Item.TabIndex = 0;
            this.Pb_Item.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item});
            this.dataGridView1.DataSource = this.sqliteDataAccessBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(435, 529);
            this.dataGridView1.TabIndex = 23;
            // 
            // sqliteDataAccessBindingSource
            // 
            this.sqliteDataAccessBindingSource.DataSource = typeof(NASA_MINDS_Library.sqliteDataAccess);
            // 
            // Item
            // 
            this.Item.HeaderText = "Item name";
            this.Item.MinimumWidth = 8;
            this.Item.Name = "Item";
            this.Item.Width = 150;
            // 
            // ShoppingListImport_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1243, 681);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShoppingListImport_Form";
            this.Text = "ShoppingListImport_Form";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqliteDataAccessBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Pb_Item;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.BindingSource sqliteDataAccessBindingSource;
    }
}