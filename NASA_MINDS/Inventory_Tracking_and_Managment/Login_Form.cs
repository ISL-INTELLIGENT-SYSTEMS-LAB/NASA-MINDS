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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();

            Menu_Form menu_Form = new Menu_Form();
            menu_Form.ShowDialog();
            this.Hide();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Btn_Forgot_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
