using NASA_MINDS_Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Inventory_Tracking_and_Managment
{
    public partial class ShoppingListImport_Form : Form
    {
        // Create a list of items from the database
        private List<Item> items = new List<Item>();
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
            // Populate the list of items from the database
            items.Add(sqliteDataAccess.PopulateData("1"));
            items.Add(sqliteDataAccess.PopulateData("2"));
            items.Add(sqliteDataAccess.PopulateData("3"));

            foreach (Item item in items)
            {
                AddRows(item);
            }
        }

        private void AddRows(Item item)
        {
            // Check the condition of the item and convert it to a string
            string condition;
            if (item.Condition == 0)
            {
                condition = "New";
            }
            else if (item.Condition == 1)
            {
                condition = "Good";
            }
            else if (item.Condition == 2)
            {
                condition = "Needs repair";
            }
            else if (item.Condition == 3)
            {
                condition = "Broken";
            }
            else
            {
                condition = "Unknown";
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
                string imageLocation = currentDir + "/images/" + items.Find(x => x.ItemName == dataGridView1.Rows[index].Cells[0].Value.ToString()).Image_loc;
                PB_Item.BackgroundImage = new Bitmap(imageLocation);
            }
            catch
            {
                return;
            }
        }
    }
}
