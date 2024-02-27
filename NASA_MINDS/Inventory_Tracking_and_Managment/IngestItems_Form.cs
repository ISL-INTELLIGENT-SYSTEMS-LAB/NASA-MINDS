using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using NASA_MINDS_Library;
using static System.Net.Mime.MediaTypeNames;

namespace Inventory_Tracking_and_Managment
{
    public partial class IngestItems_Form : Form
    {
        List<Item> items = new List<Item>();

        public IngestItems_Form()
        {
            InitializeComponent();
        }
        // Open file dialog to choose image and upload
        private void BtnIF_Upload_Click(object sender, EventArgs e)
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
            // If the user selects an image, display it in the picture box
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Display image in picture box and display file name
                PBIF_Pic.BackgroundImage = new Bitmap(openFileDialog1.FileName);
                LIF_Filename.Text = System.IO.Path.GetFileName(openFileDialog1.FileName);
            }
        }
        // Return to the main menu
        private void BtnIF_Back_Click(object sender, EventArgs e)
        {
            Hide();
            var Menu_Form = new Menu_Form();
            Menu_Form.Closed += (s, args) => Close();
            Menu_Form.Show();
        }

        // Submit the item to the database
        private void BtnIF_Submit_Click(object sender, EventArgs e)
        {
            return;
        }
        // User selects an item from the dropdown
        private void CBIF_Condition_SelectedIndexChanged(object sender, EventArgs e)
        {
            int condition = items[CB_ItemSearch.SelectedIndex].Condition;
            switch (condition)
            {
                case 0:
                    CB_Condition.SelectedIndex = 0;
                    break;
                case 1:
                    CB_Condition.SelectedIndex = 1;
                    break;
                case 2:
                    CB_Condition.SelectedIndex = 2;
                    break;
                case 3:
                    CB_Condition.SelectedIndex = 3;
                    break;
                default:
                    CB_Condition.SelectedIndex = 4;
                    break;
            }
        }
        
        // Generate a random tag ID
        private void Btn_GenerateTagID_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomnumber = random.Next(100, 1000);
            Btn_GenerateTagID.Text = Convert.ToString(randomnumber);    // Update button text to show the random number
        }
    }
}
    
