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
    public partial class LocationEdit_Form : Form
    {
        List<Location> locations = new List<Location>();

        public LocationEdit_Form()
        {
            InitializeComponent();

            // Populate the datagridview with locations
            locations = sqliteDataAccess.GetAllLocations();
            CB_LocationSearch.DataSource = locations;
            CB_LocationSearch.DisplayMember = "LocationName";
        }

        private void CB_LocationSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Populate the textboxes with the selected location's information
            RTB_Description.Text = locations[CB_LocationSearch.SelectedIndex].LocationDescription;
            TB_Location.Text = locations[CB_LocationSearch.SelectedIndex].LocationName;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Hide();
            var ModifyItems_Form = new ModifyItems_Form();
            ModifyItems_Form.Closed += (s, args) => Close();
            ModifyItems_Form.Show();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            // Get the location id based on CB_LocationSearch's selected index
            int locationID = locations[CB_LocationSearch.SelectedIndex].LocationID;

            // Update location information in the database
            sqliteDataAccess.UpdateLocation(locationID, TB_Location.Text, RTB_Description.Text);

            // Update the location in the list
            locations[CB_LocationSearch.SelectedIndex] = new Location(locationID, TB_Location.Text, RTB_Description.Text);

            // Refresh the combobox with the updated location information and display a message box
            CB_LocationSearch_SelectedIndexChanged(this, new EventArgs());
            MessageBox.Show("Location has been updated in the database", "Update Successful");
        }
    }
}
