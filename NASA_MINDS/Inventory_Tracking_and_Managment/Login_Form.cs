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
    public partial class Login_Form : Form
    {
        // Create a new Account object that will be used to store the account information
        public static Account account;

        public Login_Form()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            // Retrieve the account information from the database
            string username = TB_Username.Text;
            account = sqliteDataAccess.RetriveAccount(username);

            if (account == null)
            {                
                TB_Username.BackColor = Color.MistyRose;
            }
            else
            {
                // Open the Menu_Form and close the Login_Form when the Login button is clicked
                Hide();
                var Menu_Form = new Menu_Form();
                Menu_Form.Closed += (s, args) => Close();
                Menu_Form.Show();
            }
        }

        private void Btn_Forgot_Click(object sender, EventArgs e)
        {
            account = sqliteDataAccess.RetriveAccount("taylorjb96");
            
            // Open the Menu_Form and close the Login_Form when the Login button is clicked
            Hide();
            var Menu_Form = new Menu_Form();
            Menu_Form.Closed += (s, args) => Close();
            Menu_Form.Show();
        }
    }
}
