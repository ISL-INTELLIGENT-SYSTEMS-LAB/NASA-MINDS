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
    public partial class ChangePassword_Form : Form
    {
        public ChangePassword_Form()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
