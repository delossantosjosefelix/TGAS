using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    internal static class Program
    {
        //Variables globales para todo el proyecto/solución. 
        //Se usan escribiendo: Program.NombreDeLaVariable donde se necesiten.

        public static int vidUsuario = 0;
        public static string rolUsuario = "";      
        public static string nombreUsuario = "";
        public static int vidVideojuego = 0;
        public static int vidCliente = 0;
        public static int vidEmpleado = 0;
        public static int vidCategoria = 0;
        public static int vidPlataforma = 0;
        public static int vidCompra = 0;
        public static int vidDetalleCompra = 0;

        public static bool nuevo = false;     //variable usada para identificar si se trabaja con un nuevo dato o no
        public static bool modificar = false; //variable usada para identificar si se está modificando un dato o no
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
