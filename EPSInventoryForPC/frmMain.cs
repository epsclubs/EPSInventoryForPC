﻿using System;
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

        int LastSlctItemIndex;

        private void disableComponentsForEditing()
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
            label20.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
        }

        private void enableComponentsForEditing()
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
            label20.Text = listViewMain.SelectedItems[0].SubItems[0].Text;
            label26.Text = listViewMain.SelectedItems[0].SubItems[1].Text;
            label25.Text = listViewMain.SelectedItems[0].SubItems[2].Text;
            label27.Text = listViewMain.SelectedItems[0].SubItems[3].Text;
            label28.Text = listViewMain.SelectedItems[0].SubItems[0].Text;
            label29.Text = listViewMain.SelectedItems[0].SubItems[1].Text;
            label30.Text = listViewMain.SelectedItems[0].SubItems[2].Text;
            label31.Text = listViewMain.SelectedItems[0].SubItems[3].Text;
            label20.Visible = true;
            label25.Visible = true;
            label26.Visible = true;
            label27.Visible = true;
            label28.Visible = true;
            label29.Visible = true;
            label30.Visible = true;
            label31.Visible = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            listViewMain.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            disableComponentsForEditing();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
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
            if (comboBoxFilter_ViewItems1.SelectedItem.ToString().Equals("Alert Amount") || comboBoxFilter_ViewItems1.SelectedItem.ToString().Equals("Current Amount") ||
                comboBoxFilter_ViewItems1.SelectedItem.ToString().Equals("Ideal Storage") || comboBoxFilter_ViewItems1.SelectedItem.ToString().Equals("Amount to Purchase"))
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
                enableComponentsForEditing();
            }
            else
            {
                disableComponentsForEditing();
            }
        }

        private void button_EditOK_Click(object sender, EventArgs e)
        {
            if (listViewMain.SelectedItems.Count != 0)
            {
                LastSlctItemIndex = listViewMain.SelectedItems[0].Index;
                if (comboBox_EditAmt.SelectedItem.Equals("Consume") && (Convert.ToDouble(listViewMain.Items[LastSlctItemIndex].SubItems[4].ToString()) > Convert.ToDouble(txtBox_EditAmt.Text)))
                {
                    double a = Convert.ToDouble(listViewMain.SelectedItems[LastSlctItemIndex].SubItems[4].ToString());
                    double b = Convert.ToDouble(txtBox_EditAmt.Text);
                    listViewMain.SelectedItems[LastSlctItemIndex].SubItems[4].Text = "" + (a - b);
                }
            }
        }

        private void filterTextChanged(object sender, EventArgs e)
        {
            var items = new ListView.ListViewItemCollection(listViewMain);
            if (cboxFilter_SearchChemID.Checked)
            {
                for (int i = 0; i < listViewMain.Items.Count; i++)
                {
                    if (listViewMain.Items[i].SubItems[0].Text.Contains(txtFilter_Search.Text))
                    {
                        items.Add(listViewMain.Items[i]);
                    }
                }   
            }

            if (cboxFilter_SearchName.Checked)
            {
                for (int i = 0; i < listViewMain.Items.Count; i++)
                {
                    if (listViewMain.Items[i].SubItems[0].Text.Contains(txtFilter_Search.Text))
                    {
                        items.Add(listViewMain.Items[i]);
                    }
                }
            }
            
            if (cboxFilter_SearchFormula.Checked)
            {
                for (int i = 0; i < listViewMain.Items.Count; i++)
                {
                    if (listViewMain.Items[i].SubItems[0].Text.Contains(txtFilter_Search.Text))
                    {
                        items.Add(listViewMain.Items[i]);
                    }
                }
            }

            
        }


    }
}
