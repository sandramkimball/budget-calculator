using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyFolio
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Display LoginForm, then MainForm if Login = True
            Forms.LoginForm loginF = new Forms.LoginForm();

            if(loginF.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Forms.LoginForm());
            } else
            {
                Application.Exit();
            }

            
        }
    }
}
