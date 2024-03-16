using NASA_MINDS_Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;


namespace Inventory_Tracking_and_Managment
{
    public partial class ShoppingListImport_Form : Form
    {
        List<Item> dbitems = new List<Item>();
        List<Location> locations = sqliteDataAccess.GetAllLocations();

        public ShoppingListImport_Form()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            // Close the current form and open the ShoppingList_Form
            Hide();
            var ShoppingList_Form = new ShoppingList_Form();
            ShoppingList_Form.Closed += (s, args) => Close();
            ShoppingList_Form.Show();
        }

        private void Btn_LoadItems_Click(object sender, EventArgs e)
        {
            // Open a file dialog to select a XML file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files|*.xml";
            openFileDialog.Title = "Select a XML file";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the file path and load the items from the XML file
                XmlDocument xml = new XmlDocument();
                xml.Load(openFileDialog.FileName);
                XmlNodeList xmlItems = xml.GetElementsByTagName("Item");

                // Create a list of items
                List<int> items = new List<int>();

                // Loop through the XML items and add them to the list
                foreach (XmlNode xmlItem in xmlItems)
                {
                    items.Add(int.Parse(xmlItem["ItemID"].InnerText));
                }


                // Add the items to the datagridview
                foreach (int item in items)
                {
                    // retrieve the item from the database
                    Item dbitem = sqliteDataAccess.GetItem(item);

                    // Add the item to the datagridview
                    AddRows(dbitem);
                    dbitems.Add(dbitem);
                }

            }

            
        }

        private void AddRows(Item item)
        {
            // Check the condition of the item and convert it to a string
            string condition;
            switch (item.Condition)
            {
                case 0:
                    condition = "New";
                    break;
                case 1:
                    condition = "Good";
                    break;
                case 2:
                    condition = "Needs repair";
                    break;
                case 3:
                    condition = "Broken";
                    break;
                default:
                    condition = "Unknown";
                    break;
            }

            // Add the item to the datagridview
            dataGridView1.Rows.Add(item.ItemName, item.ItemDescription, item.SerialNum, condition, item.RNNum, item.RFID);
        }

        private void Btn_Found_Click(object sender, EventArgs e)
        {
            try
            {
                // Get selected row index from datagridview and add the items name to the LB_FoundItems listbox
                int index = dataGridView1.CurrentCell.RowIndex;
                string itemName = dataGridView1.Rows[index].Cells[0].Value.ToString();
                dataGridView1.Rows.RemoveAt(index);
                LB_FoundItems.Items.Add(itemName);

                PB_Item.BackgroundImage = null;
                L_LastLocation.Text = "";
            }
            catch
            {
                return;
            }
        }

        private void Btn_Locate_Click(object sender, EventArgs e)
        {
            // Get current working directory and add the image location to the LB_FoundItems listbox
            string currentDir = Environment.CurrentDirectory;

            try
            {
                // Get selected row index from the datagridview and update image in the PB_Item picturebox
                int index = dataGridView1.CurrentCell.RowIndex;
                string imageLocation = currentDir + "/images/" + dbitems.Find(x => x.ItemName == dataGridView1.Rows[index].Cells[0].Value.ToString()).Image_loc;
                PB_Item.BackgroundImage = new Bitmap(imageLocation);

                // Change the L_LastLocation label to the current location of the item
                string location = locations.Find(x => x.LocationID == sqliteDataAccess.GetItemLocation(dbitems.Find(y => y.ItemName == dataGridView1.Rows[index].Cells[0].Value.ToString()).ItemID).Location).LocationName;
                L_LastLocation.Text = location;
            }
            catch
            {
                return;
            }
        }
    }
}
