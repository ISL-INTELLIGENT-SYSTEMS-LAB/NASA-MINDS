namespace Inventory_Tracking_and_Managment
{
    partial class LocationEdit_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationEdit_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_LocationSearch = new System.Windows.Forms.ComboBox();
            this.RTB_Description = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Location = new System.Windows.Forms.TextBox();
            this.L_Location = new System.Windows.Forms.Label();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Btn_Back);
            this.panel1.Controls.Add(this.Btn_Submit);
            this.panel1.Controls.Add(this.L_Location);
            this.panel1.Controls.Add(this.TB_Location);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RTB_Description);
            this.panel1.Controls.Add(this.CB_LocationSearch);
            this.panel1.Location = new System.Drawing.Point(292, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 557);
            this.panel1.TabIndex = 0;
            // 
            // CB_LocationSearch
            // 
            this.CB_LocationSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_LocationSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_LocationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_LocationSearch.FormattingEnabled = true;
            this.CB_LocationSearch.Location = new System.Drawing.Point(267, 38);
            this.CB_LocationSearch.Name = "CB_LocationSearch";
            this.CB_LocationSearch.Size = new System.Drawing.Size(448, 28);
            this.CB_LocationSearch.TabIndex = 22;
            this.CB_LocationSearch.SelectedIndexChanged += new System.EventHandler(this.CB_LocationSearch_SelectedIndexChanged);
            // 
            // RTB_Description
            // 
            this.RTB_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_Description.Location = new System.Drawing.Point(415, 230);
            this.RTB_Description.Name = "RTB_Description";
            this.RTB_Description.Size = new System.Drawing.Size(423, 252);
            this.RTB_Description.TabIndex = 25;
            this.RTB_Description.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(221, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 35);
            this.label1.TabIndex = 26;
            this.label1.Text = "Description:";
            // 
            // TB_Location
            // 
            this.TB_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TB_Location.Location = new System.Drawing.Point(415, 149);
            this.TB_Location.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Location.Name = "TB_Location";
            this.TB_Location.Size = new System.Drawing.Size(225, 44);
            this.TB_Location.TabIndex = 39;
            // 
            // L_Location
            // 
            this.L_Location.AutoSize = true;
            this.L_Location.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Location.ForeColor = System.Drawing.Color.Black;
            this.L_Location.Location = new System.Drawing.Point(221, 151);
            this.L_Location.Name = "L_Location";
            this.L_Location.Size = new System.Drawing.Size(160, 35);
            this.L_Location.TabIndex = 40;
            this.L_Location.Text = "Location: ";
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.BackColor = System.Drawing.Color.Red;
            this.Btn_Submit.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Submit.Location = new System.Drawing.Point(810, 36);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(72, 30);
            this.Btn_Submit.TabIndex = 41;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = false;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackColor = System.Drawing.Color.Red;
            this.Btn_Back.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(54, 36);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(72, 30);
            this.Btn_Back.TabIndex = 42;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // LocationEdit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1445, 699);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LocationEdit_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LocationEdit_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CB_LocationSearch;
        private System.Windows.Forms.RichTextBox RTB_Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Location;
        private System.Windows.Forms.Label L_Location;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Button Btn_Back;
    }
}