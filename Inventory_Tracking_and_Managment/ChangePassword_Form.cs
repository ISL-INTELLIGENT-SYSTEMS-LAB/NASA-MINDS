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
                    MessageBox.Show("Current Password is incorrect", "Error");
                }
                else
                {
                    // Check if the new password fits the requirements
                    if (Tb_NewPassword.Text.Length < 8)
                    {
                        Tb_NewPassword.BackColor = Color.MistyRose;

                        // Display a message box that reminds user of password requirementss
                        MessageBox.Show("Password must contain at least 8 characters, 1 number, 1 uppercase letter, 1 lowercase letter, and 1 special character", "Error");
                    }
                    else if (Tb_NewPassword.Text.Length >= 8)
                    {
                        bool hasNumber = false;
                        bool hasUpper = false;
                        bool hasLower = false;
                        bool hasSpecial = false;

                        foreach (char c in Tb_NewPassword.Text)
                        {
                            if (char.IsNumber(c))
                            {
                                hasNumber = true;
                            }
                            else if (char.IsUpper(c))
                            {
                                hasUpper = true;
                            }
                            else if (char.IsLower(c))
                            {
                                hasLower = true;
                            }
                            else if (char.IsSymbol(c) || char.IsPunctuation(c))
                            {
                                hasSpecial = true;
                            }
                        }

                        // Give Error message if password does not meet requirements

                        if (hasNumber == false || hasUpper == false || hasLower == false || hasSpecial == false)
                        {
                            Tb_NewPassword.BackColor = Color.MistyRose;

                            // Display a message box that reminds user of password requirementss
                            MessageBox.Show("Password must contain at least 8 characters, 1 number, 1 uppercase letter, 1 lowercase letter, and 1 special character", "Error");
                        }

                        else if (hasNumber == true && hasUpper == true && hasLower == true && hasSpecial == true)
                        {
                            // Ensure that the new password and reentered password match
                            if (Tb_NewPassword.Text != Tb_Reenter.Text)
                            {
                                Tb_NewPassword.BackColor = Color.MistyRose;
                                Tb_Reenter.BackColor = Color.MistyRose;

                                // Display a message box that reminds user to fill in all fields
                                MessageBox.Show("New Password and Reentered Password do not match", "Error");
                            }
                            else
                            {
                                // Display a message box to the user that the password has been updated
                                MessageBox.Show("Password has been Updated in database", "Update Successful!");
                                // Update the password in the database
                                sqliteDataAccess.UpdatePassword(username, Tb_NewPassword.Text);
                                Hide();
                            }
                        }
                    }
                }
            }   
        }

        // Reset the background color of textboxes when a key is pressed
        private void Tb_CurrentPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Tb_CurrentPassword.BackColor = Color.White;
        }

        // Reset the background color of the textboxes when the user starts typing in them
        private void Tb_NewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Tb_NewPassword.BackColor = Color.White;
        }

        // Reset the background color of the textboxes when the user starts typing in them
        private void Tb_Reenter_KeyDown(object sender, KeyEventArgs e)
        {
            Tb_Reenter.BackColor = Color.White;
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
