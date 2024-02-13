using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NASA_MINDS_Library;

namespace Inventory_Tracking_and_Managment
{
    public partial class Account_Form : Form
    {
        public Account_Form()
        {
            InitializeComponent();
            Btn_UpdatePic.Visible = false;
            Btn_Submit.Visible = false;
            L_Filename.Visible = false;
            Btn_ChangePassword.Visible = false;

            // split the contact information that is seperated by a comma 
            string[] contact = Login_Form.account.Contact.Split(',');

            // Load the account information into the textboxes from the database
            string currentDir = Environment.CurrentDirectory;
            string imagePath = currentDir + "\\images\\" + Login_Form.account.Picture;
            PB_ProfilePic.BackgroundImage = Image.FromFile(imagePath);
            TB_Name.Text = Login_Form.account.Username;
            TB_Title.Text = Login_Form.account.Title;
            TB_Phone.Text = contact[0];
            TB_Email.Text = contact[1];

            // Set the size of the textboxes to the account information
            TB_NameResize();
            TB_TitleResize();
            TB_PhoneResize();
            TB_EmailResize();
        }

        private void Btn_UpdatePic_Click(object sender, EventArgs e)
        {
            // Open file dialog to choose image
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Choose Profile Picture",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "png",
                Filter = "Image Files(*.jpg; *.jpeg; *.png;)| *.jpg; *.jpeg; *.png;|All files|*.*",
                FilterIndex = 0,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Display image in picture box and display file name
                PB_ProfilePic.BackgroundImage = new Bitmap(openFileDialog1.FileName);
                L_Filename.Text = System.IO.Path.GetFileName(openFileDialog1.FileName);
            }
        }

        private void Btn_EditProfile_Click(object sender, EventArgs e)
        {
            // Enable input boxes for modification
            Btn_EditProfile.Visible = false;
            Btn_Submit.Visible = true;
            Btn_UpdatePic.Visible = true;
            L_Filename.Visible = true;
            Btn_Submit.Enabled = true;
            Btn_Back.Visible = false;
            Btn_ChangePassword.Visible = true;

            // Enable the textboxes for editing
            TB_Name.Enabled = true;
            TB_Title.Enabled = true;
            TB_Phone.Enabled = true;
            TB_Email.Enabled = true;
            TB_Name.ReadOnly = false;
            TB_Title.ReadOnly = false;
            TB_Phone.ReadOnly = false;
            TB_Email.ReadOnly = false;
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            // Resize text boxes to fit new labels
            TB_NameResize();
            TB_TitleResize();
            TB_PhoneResize();
            TB_EmailResize();

            // Disable the textboxes for submission
            TB_Name.Enabled = false;
            TB_Title.Enabled = false;
            TB_Phone.Enabled = false;
            TB_Email.Enabled = false;

            // Hide the Submit button, Update Picture button, File name label, Change Password button, and show the Edit Profile button and Back button
            Btn_UpdatePic.Visible = false;
            Btn_Submit.Visible = false;
            Btn_EditProfile.Visible = true;
            L_Filename.Visible = false;
            Btn_Back.Visible = true;
            Btn_ChangePassword.Visible = false;

            // Initialize variables
            string name = TB_Name.Text;
            string title = TB_Title.Text;
            string contact = TB_Phone.Text + "," + TB_Email.Text;
            string image;

            // Update the Account information in the database
            if (L_Filename.Text != "File Name")
            {
                image = L_Filename.Text;
            }
            else
            {
                image = Login_Form.account.Picture;
            }

            // Get AccountID based on the username
            int accountID = Login_Form.account.AccountID;

            // Update the account information in the database
            sqliteDataAccess.UpdateAccount(accountID, name, title, contact, image);
        }

        private void TB_NameResize()
        {
            Size namesize = TextRenderer.MeasureText(TB_Name.Text, TB_Name.Font);

            if (namesize.Width > 561) { TB_Name.Width = 561; }
            else { TB_Name.Width = namesize.Width; }

            TB_Name.SelectionStart = 0;
        }

        private void TB_TitleResize()
        {
            Size titlesize = TextRenderer.MeasureText(TB_Title.Text, TB_Title.Font);

            if (titlesize.Width > 561) { TB_Title.Width = 561; }
            else { TB_Title.Width = titlesize.Width; }

            TB_Title.SelectionStart = 0;
        }

        private void TB_PhoneResize()
        {
            Size phonesize = TextRenderer.MeasureText(TB_Phone.Text, TB_Phone.Font);

            if (phonesize.Width > 561) { TB_Phone.Width = 561; }
            else { TB_Phone.Width = phonesize.Width; }

            TB_Phone.SelectionStart = 0;
        }

        private void TB_EmailResize()
        {
            Size emailsize = TextRenderer.MeasureText(TB_Email.Text, TB_Email.Font);

            if (emailsize.Width > 561) { TB_Email.Width = 561; }
            else { TB_Email.Width = emailsize.Width; }

            TB_Email.SelectionStart = 0;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Hide();
            var Menu_Form = new Menu_Form();
            Menu_Form.Closed += (s, args) => Close();
            Menu_Form.Show();
        }

        private void Btn_ChangePassword_Click(object sender, EventArgs e)
        {
            var ChangePassword_Form = new ChangePassword_Form();
            ChangePassword_Form.Closed += (s, args) => Close();
            ChangePassword_Form.Show();
        }
    }
}
