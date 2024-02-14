using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NASA_MINDS_Library;

namespace Inventory_Tracking_and_Managment
{
    public partial class ChangePassword_Form : Form
    {
        // Create a new Account object that will be used to store the account information
        public static Account account;

        public ChangePassword_Form()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            // Use the username entered in the Login_Form to pull the user's password from the database
            string username = Login_Form.account.Username;
            account = sqliteDataAccess.RetriveAccount(username);

            if (account == null)
            {
                Tb_CurrentPassword.BackColor = Color.MistyRose;
            }
            else
            {
                string enteredpassword = Tb_CurrentPassword.Text;

                if (enteredpassword != account.Password)
                {
                    Tb_CurrentPassword.BackColor = Color.MistyRose;
                }
                else
                {
                    // Ensure that the new password and reentered password match
                    if (Tb_NewPassword.Text != Tb_Reenter.Text)
                    {
                        Tb_NewPassword.BackColor = Color.MistyRose;
                        Tb_Reenter.BackColor = Color.MistyRose;
                    }
                    else
                    {
                        // Update the password in the database
                        sqliteDataAccess.UpdatePassword(username, Tb_NewPassword.Text);
                    }
                }

                // CHeck if user is able to submit or not
                if (Tb_CurrentPassword.Text == "" || Tb_NewPassword.Text == "" || Tb_Reenter.Text == "")
                {
                    // Display a message box that remins user to fill in all fields
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                else
                {
                    // Display a message box to the user that the password has been updated
                    MessageBox.Show("Password has been Updated in database", "Update Successful!");
                    Hide();
                }
            }

            
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            // Close the ChangePassword_Form when the Cancel button is clicked and return to the Account_Form
            Hide();
        }

        private void Btn_ShowPass_Click(object sender, EventArgs e)
        {
            // Show or hide the password characters in the textboxes
            if(Tb_CurrentPassword.PasswordChar == '*' && Tb_NewPassword.PasswordChar == '*' && Tb_Reenter.PasswordChar == '*')
            {
                Tb_CurrentPassword.PasswordChar = '\0';
                Tb_NewPassword.PasswordChar = '\0';
                Tb_Reenter.PasswordChar = '\0';
            }
            else
            {
                Tb_CurrentPassword.PasswordChar = '*';
                Tb_NewPassword.PasswordChar = '*';
                Tb_Reenter.PasswordChar = '*';
            }
        }
    }
}
