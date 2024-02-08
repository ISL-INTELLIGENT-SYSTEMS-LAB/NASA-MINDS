namespace Inventory_Tracking_and_Managment
{
    partial class ShoppingList_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Create = new System.Windows.Forms.Button();
            this.Btn_Import = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Btn_Create);
            this.panel1.Controls.Add(this.Btn_Import);
            this.panel1.Controls.Add(this.Btn_Back);
            this.panel1.Location = new System.Drawing.Point(553, 486);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 201);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Create
            // 
            this.Btn_Create.BackColor = System.Drawing.Color.Red;
            this.Btn_Create.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Create.Location = new System.Drawing.Point(484, 78);
            this.Btn_Create.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(164, 53);
            this.Btn_Create.TabIndex = 23;
            this.Btn_Create.Text = "Create";
            this.Btn_Create.UseVisualStyleBackColor = false;
            // 
            // Btn_Import
            // 
            this.Btn_Import.BackColor = System.Drawing.Color.Red;
            this.Btn_Import.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Import.Location = new System.Drawing.Point(253, 78);
            this.Btn_Import.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Import.Name = "Btn_Import";
            this.Btn_Import.Size = new System.Drawing.Size(164, 53);
            this.Btn_Import.TabIndex = 22;
            this.Btn_Import.Text = "Import";
            this.Btn_Import.UseVisualStyleBackColor = false;
            this.Btn_Import.Click += new System.EventHandler(this.Btn_Import_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackColor = System.Drawing.Color.Red;
            this.Btn_Back.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(15, 14);
            this.Btn_Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(96, 37);
            this.Btn_Back.TabIndex = 21;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // ShoppingList_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1730, 796);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShoppingList_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShoppingList_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Create;
        private System.Windows.Forms.Button Btn_Import;
    }
}