using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Tracking_and_Managment
{
    public partial class Menu_Form : Form
    {
        public Menu_Form()
        {
            InitializeComponent();
        }

        private void Btn_FindItems_Click(object sender, EventArgs e)
        {
            // Open the FindItems_Form and close the Menu_Form when the Find Items button is clicked
            // Hide();
            // var FindItems_Form = new FindItems_Form();
            // FindItems_Form.Closed += (s, args) => Close();
            // FindItems_Form.Show();
        }

        private void Btn_ShoppingList_Click(object sender, EventArgs e)
        {
            // Open the ShoppingList_Form and close the Menu_Form when the Shopping List button is clicked
            // Hide();
            // var ShoppingList_Form = new ShoppingList_Form();
            // ShoppingList_Form.Closed += (s, args) => Close();
            // ShoppingList_Form.Show();
        }

        private void Btn_Modify_Items_Click(object sender, EventArgs e)
        {
            // Open the Modify_Items_Form and close the Menu_Form when the Modify Items button is clicked
            // Hide();
            // var Modify_Items_Form = new Modify_Items_Form();
            // Modify_Items_Form.Closed += (s, args) => Close();
            // Modify_Items_Form.Show();
        }

        private void Btn_IngestItems_Click(object sender, EventArgs e)
        {
            // Open the IngestItems_Form and close the Menu_Form when the Ingest Items button is clicked
            // Hide();
            // var IngestItems_Form = new IngestItems_Form();
            // IngestItems_Form.Closed += (s, args) => Close();
            // IngestItems_Form.Show();
        }

        private void Btn_Account_Click(object sender, EventArgs e)
        {
            // Open the Account_Form and close the Menu_Form when the Account button is clicked
            Hide();
            var Account_Form = new Account_Form();
            Account_Form.Closed += (s, args) => Close();
            Account_Form.Show();
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            // Open the Login_Form and close the Menu_Form when the Logout button is clicked
            Hide();
            var Login_Form = new Login_Form();
            Login_Form.Closed += (s, args) => Close();
            Login_Form.Show();
        }
    }
}
