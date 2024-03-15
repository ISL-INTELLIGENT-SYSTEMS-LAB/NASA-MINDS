using NASA_MINDS_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Inventory_Tracking_and_Managment
{
    public partial class ShoppingListCreation_Form : Form
    {
        List<Item> items = sqliteDataAccess.GetAllItems();
        List<Location> locations = sqliteDataAccess.GetAllLocations();

        List<Item> shoppingList = new List<Item>();

        public ShoppingListCreation_Form()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Hide();
            var Menu_Form = new Menu_Form();
            Menu_Form.Closed += (s, args) => Close();
            Menu_Form.Show();
        }

        private void Btn_Generate_Click(object sender, EventArgs e)
        {
            if (shoppingList.Count == 0)
            {
                MessageBox.Show("The shopping list is empty!", "Alert");
                return;
            }

            // Create a new xml file and add the items in the shopping list to it
            XDocument doc = new XDocument();
            XElement root = new XElement("ShoppingList");
            doc.Add(root);

            foreach (Item item in shoppingList)
            {
                XElement itemElement = new XElement("Item");
                // Add the itemsID to the xml file
                itemElement.Add(new XElement("ItemID", item.ItemID));
                root.Add(itemElement);
            }

            // write the author and date to the xml file
            doc.Root.Add(new XComment("Author: " + Login_Form.account.Username));
            doc.Root.Add(new XComment("Date: " + DateTime.Now.ToString("MM/dd/yyyy")));

            // Open the file dialog and save the file to the selected location
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files|*.xml";
            saveFileDialog.Title = "Save the shopping list";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                doc.Save(saveFileDialog.FileName);
            }

            MessageBox.Show("The shopping list has been saved!", "Alert");

            // Clear the list of items and all the textboxes in the form and rest the combobox to the first empty item
            shoppingList.Clear();
            LB_ShoppingList.Items.Clear();
            TB_Name.Text = "";
            TB_Location.Text = "";
            RTB_Description.Text = "";
            TB_Condition.Text = "";
            TB_SN.Text = "";
            TB_RN.Text = "";
            TB_Tag.Text = "";

            CB_ItemSelector.SelectedIndex = 0;
        }

        private void Btn_AddItem_Click(object sender, EventArgs e)
        {
            // Add the selected item to the shopping list and display it in the list box
            LB_ShoppingList.Items.Add(CB_ItemSelector.Text);
            shoppingList.Add(items[CB_ItemSelector.SelectedIndex]);
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            // Clear the list of items and all the textboxes in the form and rest the combobox to the first empty item
            shoppingList.Clear();
            PB_Item.BackgroundImage = null;
            LB_ShoppingList.Items.Clear();
            TB_Name.Text = "";
            TB_Location.Text = "";
            RTB_Description.Text = "";
            TB_Condition.Text = "";
            TB_SN.Text = "";
            TB_RN.Text = "";
            TB_Tag.Text = "";

            CB_ItemSelector.SelectedIndex = 0;

            MessageBox.Show("The shopping list has been cleared!", "Alert");
        }

        private void LoadComboBox()
        {
            // Pull items from database and display in combo box. Set the first item to be empty
            CB_ItemSelector.DataSource = items;
            CB_ItemSelector.DisplayMember = "ItemName";
        }


        private void CB_ItemSearch_SelectorIndexChanged(object sender, EventArgs e)
        {
            // Display the item information in the labels and picture box based on the item selected in the combo box
            TB_Name.Text = items[CB_ItemSelector.SelectedIndex].ItemName;
            RTB_Description.Text = items[CB_ItemSelector.SelectedIndex].ItemDescription;
            TB_SN.Text = items[CB_ItemSelector.SelectedIndex].SerialNum;
            TB_RN.Text = items[CB_ItemSelector.SelectedIndex].RNNum.ToString();
            TB_Tag.Text = items[CB_ItemSelector.SelectedIndex].RFID.ToString();

            // Pull items location from database and display in RTB_Location
            ItemLocation itemLocation = sqliteDataAccess.GetItemLocation(items[CB_ItemSelector.SelectedIndex].ItemID);
            string location = locations.Find(x => x.LocationID == itemLocation.Location).LocationName;

            // Display the location of the item in the rich text box by sercing for the itemid in the locations list
            TB_Location.Text = location;

            // Use a switch statement to display the condition of the item in the label
            int condition = items[CB_ItemSelector.SelectedIndex].Condition;
            switch (condition)
            {
                case 0:
                    TB_Condition.Text = "New";
                    break;
                case 1:
                    TB_Condition.Text = "Good";
                    break;
                case 2:
                    TB_Condition.Text = "Needs repair";
                    break;
                case 3:
                    TB_Condition.Text = "Broken";
                    break;
                default:
                    TB_Condition.Text = "Unknown";
                    break;
            }

            // Display the image of the item in the picture box if there is one in the database or display the default image
            string currentDir = Environment.CurrentDirectory + "\\images\\";
            if (items[CB_ItemSelector.SelectedIndex].Image_loc != null)
            {
                string imagePath = currentDir + items[CB_ItemSelector.SelectedIndex].Image_loc;
                PB_Item.BackgroundImage = Image.FromFile(imagePath);
            }
            else
            {
                string imagePath = currentDir + "Default.png";
                PB_Item.BackgroundImage = Image.FromFile(imagePath);
            }
        }
    }
}
