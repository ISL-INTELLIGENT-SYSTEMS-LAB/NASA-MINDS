﻿using System;
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
                string enteredpassword = TB_Password.Text;
                
                if (enteredpassword != account.Password)
                {
                    TB_Password.BackColor = Color.MistyRose;
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
        }

        private void Btn_Forgot_Click(object sender, EventArgs e)
        {
            // Show message box with the password of the account that is being retrieved from the database
            if (TB_Username.Text == "")
            {
                TB_Username.BackColor = Color.MistyRose;
                return;
            }
            else
            {
                try
                {
                    account = sqliteDataAccess.RetriveAccount(TB_Username.Text);
                    if (account == null)
                    {
                        throw new Exception();
                    }

                    MessageBox.Show(text: "Your password is: " + account.Password, caption: "Password");
                }
                catch
                {
                    MessageBox.Show("No known account with that username", caption: "Password");
                }
            }
        }

        private void TB_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Login_Click(this, new EventArgs());
            }
        }

        private void Btn_ShowPass_Click(object sender, EventArgs e)
        {
            if (TB_Password.PasswordChar == '*')
            {
                TB_Password.PasswordChar = '\0';
            }
            else
            {
                TB_Password.PasswordChar = '*';
            }
        }
    }
}
