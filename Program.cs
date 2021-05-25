// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

using System;
using System.Threading;
using System.Windows.Forms;

namespace customer
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
            //Application.ThreadException += ThreadException;
            Application.Run(new FrmMain());
        }

        static void ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, @"Error");
        }
    }
}