using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOODB_Final
{
    static class Program
    {
        static private bool isLoggedIn = false;
        static private String name, username, user_id;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CarRental());
        }

        static void login()
        {
            isLoggedIn = true;
        }
    }
}
