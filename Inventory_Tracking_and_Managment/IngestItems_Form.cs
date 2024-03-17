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
        List<Location> locations = new List<Location>();

        public IngestItems_Form()
        {
            InitializeComponent();
            populateLocations();
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

            // Save image to images folder
            string currentDir = Environment.CurrentDirectory;
            string sourceFile = openFileDialog1.FileName;
            string destFile = currentDir + "\\images\\" + LIF_Filename.Text;
            System.IO.File.Copy(sourceFile, destFile, true);
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
            // Initiate variables
            string name = TBIF_Name.Text;
            string serial = TBIF_Serial.Text;
            //string location = TBIF_Location.Text;
            string description = TBIF_Description.Text;
            
            // Set item condition
            int conditionint;
            string condition = CBIF_Condition.Text;
            switch (condition){
                case "New":
                    conditionint = 0;
                    break;
                case "Good":
                    conditionint = 1;
                    break;
                case "Needs Repair":
                    conditionint = 2;
                    break;
                case "Broken":
                    conditionint = 3;
                    break;
                default:
                    conditionint = 4;
                    break;

            }

            string tagID = Btn_GenerateTagID.Text.ToString();

            string filename = LIF_Filename.Text;
            string register = TBIF_Ro.Text.ToString();
            // string image = PBIF_Pic.BackgroundImage;

            // Add the item to the database using InsertItem method
            sqliteDataAccess.InsertItem(name, description, serial, conditionint, register, filename, tagID);
            MessageBox.Show("Item has been added to the database");

            // Add item location into the database
            Item item = sqliteDataAccess.GetItem(name);
            int itemID = item.ItemID;
            int locationID = CBIF_Location.SelectedIndex;
            int accountID = Login_Form.account.AccountID;
            
            // Get current date and time
            DateTime date = DateTime.Now;
            string datestring = date.ToString("yyyy-MM-dd");

            sqliteDataAccess.InsertItemLocation(itemID, locationID, accountID, datestring);

            // Clear all fields
            CBIF_Condition.Text = "";
            TBIF_Description.Text = "";
            CBIF_Location.Text = "";
            TBIF_Name.Text = "";
            TBIF_Serial.Text = "";
            Btn_GenerateTagID.Text = "Generate ID #";
            PBIF_Pic.BackgroundImage = null;
            LIF_Filename.Text = "";
            TBIF_Ro.Text = "";
        }

        private void Btn_ClearAllFields_Click(object sender, EventArgs e)
        {
            CBIF_Condition.Text = "";
            TBIF_Description.Text = "";
            CBIF_Location.Text = "";
            TBIF_Name.Text = "";
            TBIF_Serial.Text = "";
            Btn_GenerateTagID.Text = "Generate ID #";
            PBIF_Pic.BackgroundImage = null;
            LIF_Filename.Text = "";
            TBIF_Ro.Text = "";
        }

        private void Btn_GenerateTagID_Click(object sender, EventArgs e)
        {
            // Generate a random tag ID and display it in the button
            Random rnd = new Random();
            int tagID = rnd.Next(100, 1000);
            // Check if the tag ID already exists in the database and generate a new one if it does
            while (sqliteDataAccess.CheckTagID(tagID))
            {
                bool exists = sqliteDataAccess.CheckTagID(tagID);
                if (exists)
                {
                    tagID = rnd.Next(100, 1000);
                }
                else
                {
                    // Add 1 to the tag ID to ensure it is unique
                    tagID += 1;
                }
            }
            Btn_GenerateTagID.Text = tagID.ToString();
        }

        // Set the location of the item
        private void populateLocations()
        {
            // Get all locations from the database and display them in the drop down
            locations = sqliteDataAccess.GetAllLocations();
            foreach (Location location in locations)
            {
                CBIF_Location.Items.Add(location.LocationName);
            }
        }
    }
}