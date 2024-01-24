using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Tracking_and_Managment
{
    public partial class Account_Form : Form
    {
        public Account_Form()
        {
            InitializeComponent();
            panel1.Show();
            panel2.Hide();
        }

        private void Btn_UpdatePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Choose Profile Picture",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "png",
                Filter = "Image Files(*.jpg; *.jpeg; *.png;)| *.jpg; *.jpeg; *.png;|All files|*.*",
                FilterIndex = 0,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                PB_ProfilePic.BackgroundImage = new Bitmap(openFileDialog1.FileName);
                PB_Edit.BackgroundImage = new Bitmap(openFileDialog1.FileName);
                
                L_Filename.Text= openFileDialog1.FileName;
            }
        }

        private void Btn_EditProfile_Click(object sender, EventArgs e)
        {
            L_Name.Text = "Hernandez, Luis E.";
            panel2.Show();
            panel1.Hide();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            L_Name.Text = "Hernandez, Luis E.";
            panel1.Show();
            panel2.Hide();
        }
    }
}
