using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework;

namespace RotasWF
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
            Login login = new Login();
            if (login.DialogResult == DialogResult.OK)
            {

                // Sim... Então continua a execução da aplicação

                Application.Run(new FormPrincipal());

            }
        }
    }
}
