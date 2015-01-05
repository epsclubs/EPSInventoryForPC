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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            listViewMain.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            tabControl1.Refresh();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFilter_ViewItems1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilter_ViewItems1.SelectedItem.ToString().Equals("Alert Amount") || comboBoxFilter_ViewItems1.SelectedItem.ToString().Equals("Current Amount") || comboBoxFilter_ViewItems1.SelectedItem.ToString().Equals("Ideal Storage") || comboBoxFilter_ViewItems1.SelectedItem.ToString().Equals("Amount to Purchase"))
            {
                comboBoxFilter_ViewItems2.Enabled = true;
            }
            else
                comboBoxFilter_ViewItems2.Enabled = false;
        } 
    }
}
