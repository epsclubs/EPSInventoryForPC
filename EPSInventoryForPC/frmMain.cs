using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EPSInventoryForPC
{
    public partial class frmMain : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();


        [DllImport("kernel32")]
        static extern bool SetConsoleCtrlHandler(HandlerRoutine HandlerRoutine, bool Add);

        delegate bool HandlerRoutine(uint dwControlType);

        public frmMain()
        {
            InitializeComponent();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void menuitemShowConsole_Click(object sender, EventArgs e)
        {
            //AllocConsole();

            AllocConsole();
            SetConsoleCtrlHandler(null, true);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
