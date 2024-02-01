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
    public partial class ShoppingList_Form : Form
    {
        public ShoppingList_Form()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Hide();
            var Menu_Form = new Menu_Form();
            Menu_Form.Closed += (s, args) => Close();
            Menu_Form.Show();
        }

        private void Btn_Import_Click(object sender, EventArgs e)
        {
            Hide();
            var ShoppingLisImport_Form = new ShoppingListImport_Form();
            ShoppingLisImport_Form.Closed += (s, args) => Close();
            ShoppingLisImport_Form.Show();
        }
    }
}
