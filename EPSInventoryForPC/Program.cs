using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EPSInventoryForPC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var _frmLogin = new frmLogin();
            _frmLogin.Show();
            Application.Run();

            Console.WriteLine("Exiting");
        }
    }
}
