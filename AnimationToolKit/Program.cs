using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AnimationToolkit
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
            frmMain form = new frmMain();
            Application.Run(form);
            //Application.Run(new frmMain());
        }
    }
}
