using System;
using System.IO;
using System.Windows.Forms;

namespace SimpleMvpLogin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + @"Database";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
