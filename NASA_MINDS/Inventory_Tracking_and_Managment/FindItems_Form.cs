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
            Hide();
            var Menu_Form = new Menu_Form();
            Menu_Form.Closed += (s, args) => Close();
            Menu_Form.Show();
        }

        private void CB_ItemSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            L_Name.Text = items[CB_ItemSearch.SelectedIndex].ItemName;
            RTB_Description.Text = items[CB_ItemSearch.SelectedIndex].ItemDescription;
            L_SerialNum.Text = items[CB_ItemSearch.SelectedIndex].SerialNum;
            L_RO.Text = items[CB_ItemSearch.SelectedIndex].RNNum.ToString();
            L_TagId.Text = items[CB_ItemSearch.SelectedIndex].RFID.ToString();

            if (items[CB_ItemSearch.SelectedIndex].Condition == 0)
            {
                L_Condition.Text = "New";
            }
            else if (items[CB_ItemSearch.SelectedIndex].Condition == 1)
            {
                L_Condition.Text = "Good";
            }
            else if (items[CB_ItemSearch.SelectedIndex].Condition == 2)
            {
                L_Condition.Text = "Needs repair";
            }
            else if (items[CB_ItemSearch.SelectedIndex].Condition == 3)
            {
                L_Condition.Text = "Broken";
            }
            
            string currentDir = Environment.CurrentDirectory;
            string imagePath = currentDir + "\\images\\" + items[CB_ItemSearch.SelectedIndex].Image_loc;
            Pb_Item.BackgroundImage = Image.FromFile(imagePath);
        }
    }
}
