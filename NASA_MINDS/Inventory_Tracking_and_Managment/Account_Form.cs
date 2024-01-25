﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Tracking_and_Managment
{
    public partial class Account_Form : Form
    {
        public Account_Form()
        {
            InitializeComponent();
            Btn_EditPicture.Visible = false;
            Btn_Submit.Visible = false;
            TB_Filename.Visible = false;

            TB_NameResize();

            TB_TitleResize();

            TB_PhoneResize();

            TB_EmailResize();
        }

        private void Btn_EditProfile_Click(object sender, EventArgs e)
        {
            Btn_EditProfile.Visible = false;
            Btn_Submit.Visible = true;
            Btn_EditPicture.Visible = true;
            TB_Filename.Visible = true;
            Btn_Submit.Enabled = true;

            TB_Name.Enabled = true;
            TB_Name.ReadOnly = false;

            TB_Title.Enabled = true;
            TB_Title.ReadOnly = false;

            TB_Phone.Enabled = true;
            TB_Phone.ReadOnly = false;

            TB_Email.Enabled = true;
            TB_Email.ReadOnly = false;
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            TB_Name.Enabled = false;
            TB_Name.ReadOnly = true;
            TB_NameResize();

            TB_Title.Enabled = false;
            TB_Title.ReadOnly = true;
            TB_TitleResize();

            TB_Phone.Enabled = false;
            TB_Phone.ReadOnly = true;
            TB_PhoneResize();

            TB_Email.Enabled = false;
            TB_Email.ReadOnly = true;
            TB_EmailResize();

            Btn_EditPicture.Visible = false;
            Btn_Submit.Visible = false;
            Btn_EditProfile.Visible = true;
            TB_Filename.Visible = false;
        }

        private void Btn_EditPicture_Click(object sender, EventArgs e)
        {
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
                // display image in picture box
                PB_ProfilePicture.BackgroundImage = new Bitmap(openFileDialog1.FileName);
                TB_Filename.Text = openFileDialog1.FileName;
                TB_FileameResize();
            }
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

        private void TB_FileameResize()
        {
            Size filenamesize = TextRenderer.MeasureText(TB_Filename.Text, TB_Filename.Font);

            if (filenamesize.Width > 561) { TB_Filename.Width = 561; }
            else { TB_Filename.Width = filenamesize.Width; }

            TB_Filename.SelectionStart = 0;
        }
    }
}
