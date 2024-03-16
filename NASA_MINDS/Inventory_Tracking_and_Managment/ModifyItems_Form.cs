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

namespace Inventory_Tracking_and_Managment
{
    public partial class ModifyItems_Form : Form
    {
        List<Item> items = new List<Item>();
        Random rnd = new Random();

        public ModifyItems_Form()
        {
            InitializeComponent();

            // Populate the datagridview with items
            items = sqliteDataAccess.GetAllItems();
            CB_ItemSearch.DataSource = items;
            CB_ItemSearch.DisplayMember = "ItemName";
        }

        private void Btn_Upload_Click(object sender, EventArgs e)
        {
            // Open file dialog to choose image
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
                Pb_Item.BackgroundImage = new Bitmap(openFileDialog1.FileName);
                L_Filename.Text = System.IO.Path.GetFileName(openFileDialog1.FileName);
            }
        }

        private void CB_ItemSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable input boxes for modification
            TB_Name.Enabled = true;
            CB_Condition.Enabled = true;
            TB_Serial.Enabled = true;
            TB_Ro.Enabled = true;
            RTB_Description.Enabled = true;
            L_Filename.Text = "File Name";

            // Populate input boxes with item data
            TB_Name.Text = items[CB_ItemSearch.SelectedIndex].ItemName;
            RTB_Description.Text = items[CB_ItemSearch.SelectedIndex].ItemDescription;
            TB_Serial.Text = items[CB_ItemSearch.SelectedIndex].SerialNum;
            TB_Ro.Text = items[CB_ItemSearch.SelectedIndex].RNNum.ToString();
            L_TagId.Text = items[CB_ItemSearch.SelectedIndex].RFID.ToString();
            
            // Populate Tb_Location with the location of the item
            ItemLocation location = sqliteDataAccess.GetItemLocation(items[CB_ItemSearch.SelectedIndex].ItemID);
            if (location == null)
            {
                TB_Location.Text = "Not Assigned";
            }
            else
            {
                Location dblocation = sqliteDataAccess.GetLocation(location.Location);
                TB_Location.Text = dblocation.LocationName;
            }

            // Switch case statement to assign combobox value based on item condition integer
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

            // Display image in picture box
            string currentDir = Environment.CurrentDirectory;
            string imagePath = currentDir + "\\images\\" + items[CB_ItemSearch.SelectedIndex].Image_loc;
            Pb_Item.BackgroundImage = Image.FromFile(imagePath);
        }

        // Return to main menu
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Hide();
            var Menu_Form = new Menu_Form();
            Menu_Form.Closed += (s, args) => Close();
            Menu_Form.Show();
        }

       
        private void TB_NameResize()
        {
            Size namesize = TextRenderer.MeasureText(TB_Name.Text, TB_Name.Font);

            if (namesize.Width > 534) { TB_Name.Width = 534; }
            else { TB_Name.Width = namesize.Width; }

            TB_Name.SelectionStart = 0;
        }


        private void TB_SerialResize()
        {
            Size namesize = TextRenderer.MeasureText(TB_Serial.Text, TB_Serial.Font);

            if (namesize.Width > 561) { TB_Serial.Width = 561; }
            else { TB_Serial.Width = namesize.Width; }

            TB_Serial.SelectionStart = 0;
        }


        private void TB_RoResize()
        {
            Size namesize = TextRenderer.MeasureText(TB_Ro.Text, TB_Ro.Font);

            if (namesize.Width > 561) { TB_Ro.Width = 561; }
            else { TB_Ro.Width = namesize.Width; }

            TB_Ro.SelectionStart = 0;
        }


        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            // Resize boxes to fit new labels
            TB_NameResize();
            TB_SerialResize();
            TB_RoResize();

            // Disable input boxes after modification
            TB_Name.Enabled = false;
            CB_Condition.Enabled = false;
            TB_Serial.Enabled = false;
            TB_Ro.Enabled = false;
            RTB_Description.Enabled = false;

            // Initiate variables
            string name = TB_Name.Text;
            string description = RTB_Description.Text;
            string serial = TB_Serial.Text;
            string ro = TB_Ro.Text;
            string image;

            // If no image is uploaded, use the current image
            if (L_Filename.Text == "File Name")
            {
                image = items[CB_ItemSearch.SelectedIndex].Image_loc;
            }
            else
            {
                image = L_Filename.Text;
            }

            // Get the RFID tag id
            int rfid = Convert.ToInt32(L_TagId.Text);

            // Assigns integer value for item condition based on combobox selection
            int conditionint;
            string condition = CB_Condition.Text;
            switch(condition) {
                case "New":
                    conditionint = 0; break;
                case "Good":
                    conditionint = 1; break;
                case "Needs Repair":
                    conditionint = 2; break;
                case "Broken":
                    conditionint = 3; break;
                default:
                    conditionint = 4; break;
            }

            // Get the item id based on CB_ItemSearch text value
            int id = items[CB_ItemSearch.SelectedIndex].ItemID;

            // Update the item in the database
            sqliteDataAccess.UpdateItem(id, name, description, serial, conditionint, ro, image, rfid);
            
            // Update the item in the list
            items[CB_ItemSearch.SelectedIndex] = new Item(id, name, description, serial, conditionint, ro, image, rfid);

            // Refresh the combo box and display a message box to confirm the update
            CB_ItemSearch_SelectedIndexChanged(this, new EventArgs());
            MessageBox.Show("Item has been Updated in database", "Update Successful!");
        }

        private void Btn_GenTagID_Click(object sender, EventArgs e)
        {
            int number = rnd.Next(100, 1000);
            L_TagId.Text = number.ToString();
        }

        private void Btn_EditLocation_Click(object sender, EventArgs e)
        {
            Hide();
            var LocationEdit_Form = new LocationEdit_Form();
            LocationEdit_Form.Closed += (s, args) => Close();
            LocationEdit_Form.Show();
        }
    }
}
