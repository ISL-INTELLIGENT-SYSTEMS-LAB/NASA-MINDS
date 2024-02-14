using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NASA_MINDS_Library;

namespace Inventory_Tracking_and_Managment
{
    public partial class FindItems_Form : Form
    {
        List<Item> items = new List<Item>();

        public FindItems_Form()
        {
            InitializeComponent();

            // Populate the datagridview with items
            items = sqliteDataAccess.GetAllItems();
            CB_ItemSearch.DataSource = items;
            CB_ItemSearch.DisplayMember = "ItemName";
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            // Open the Menu_Form and close the FindItems_Form when the Back button is clicked
            Hide();
            var Menu_Form = new Menu_Form();
            Menu_Form.Closed += (s, args) => Close();
            Menu_Form.Show();
        }

        private void CB_ItemSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the item information in the labels and picture box based on the item selected in the combo box
            L_Name.Text = items[CB_ItemSearch.SelectedIndex].ItemName;
            RTB_Description.Text = items[CB_ItemSearch.SelectedIndex].ItemDescription;
            L_SerialNum.Text = items[CB_ItemSearch.SelectedIndex].SerialNum;
            L_RO.Text = items[CB_ItemSearch.SelectedIndex].RNNum.ToString();
            L_TagId.Text = items[CB_ItemSearch.SelectedIndex].RFID.ToString();

            // Use a switch statement to display the condition of the item in the label
            int condition = items[CB_ItemSearch.SelectedIndex].Condition;
            switch (condition)
            {
                case 0:
                    L_Condition.Text = "New";
                    break;
                case 1:
                    L_Condition.Text = "Good";
                    break;
                case 2:
                    L_Condition.Text = "Needs repair";
                    break;
                case 3:
                    L_Condition.Text = "Broken";
                    break;
            }
            
            // Display the image of the item in the picture box if there is one in the database or display the default image
            string currentDir = Environment.CurrentDirectory + "\\images\\";
            if (items[CB_ItemSearch.SelectedIndex].Image_loc != null)
            {
                string imagePath = currentDir + items[CB_ItemSearch.SelectedIndex].Image_loc;
                Pb_Item.BackgroundImage = Image.FromFile(imagePath);
            }
            else
            {
                string imagePath = currentDir + "Default.png";
                Pb_Item.BackgroundImage = Image.FromFile(imagePath);
            }
        }
    }
}
