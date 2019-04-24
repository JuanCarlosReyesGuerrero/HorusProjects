using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorusProjects
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Medicos());

            bool isNew = false;

            //Proceso para evitar que se abra mas de una vez la aplicación
            Mutex mtx = new Mutex(true, "Horus", out isNew);
            if (!isNew)
            {
                MessageBox.Show("La aplicación ya se esta ejecutando");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormularioPrincipal());
            Application.Run(new FrmLogin());
        }
    }
}
