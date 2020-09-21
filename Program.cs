using System;
using System.Windows.Forms;

namespace npf
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
            MessageBox.Show("DISCLAIMER: I am not responsible if you use this software in a malicious way. Proceed with caution.");
            Application.Run(new Form1());
        }
    }
}
