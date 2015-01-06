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

        private void disableComponents()
        {
            comboBox_EditAmt.Enabled = false;
            txtBox_EditAmt.Enabled = false;
            radioButtonEdit_Edit.Enabled = false;
            radioButtonEdit_Usage.Enabled = false;
            txtEdit_Edit.Enabled = false;
            txtEdit_AlertAmt.Enabled = false;
            txtEdit_IdealAmt.Enabled = false;
            txtEdit_Usage.Enabled = false;
            txtEdit_Note.Enabled = false;
            comboEdit.Enabled = false;
        }

        private void enableComponents()
        {
            comboBox_EditAmt.Enabled = true;
            txtBox_EditAmt.Enabled = true;
            radioButtonEdit_Edit.Enabled = true;
            radioButtonEdit_Usage.Enabled = true;
            txtEdit_Edit.Enabled = true;
            txtEdit_AlertAmt.Enabled = true;
            txtEdit_IdealAmt.Enabled = true;
            txtEdit_Usage.Enabled = true;
            txtEdit_Note.Enabled = true;
            comboEdit.Enabled = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            listViewMain.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            disableComponents();
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

        private void listViewMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMain.SelectedItems.Count != 0)
            {
                enableComponents();
            }
            else
            {
                disableComponents();
            }
        }

    }
}
