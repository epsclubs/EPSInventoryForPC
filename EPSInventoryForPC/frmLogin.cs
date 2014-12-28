using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EPSInventoryForPC
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void comboUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboUserType.SelectedItem.ToString().Equals("Guest"))
            {
                txtPass.Enabled = false;
            }
            else
                txtPass.Enabled = true;
        }





        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Hide();
        }


    }
}
