using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// CAMBIA ESTO: Debe ser igual al namespace de tu Form1.cs
namespace RegistroAlumnos
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Ahora sí encontrará Form1 porque están en el mismo namespace
            Application.Run(new Form1());
        }
    }
}
