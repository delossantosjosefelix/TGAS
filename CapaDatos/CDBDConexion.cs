using System;
using System.IO;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDBDConexion
    {
        public static string miconexion
        {
            get
            {
                string directorioActual = AppDomain.CurrentDomain.BaseDirectory;

                // Subir niveles hasta encontrar la carpeta CapaDatos
                while (!Directory.Exists(Path.Combine(directorioActual, "CapaDatos"))
                       && Directory.GetParent(directorioActual) != null)
                {
                    directorioActual = Directory.GetParent(directorioActual).FullName;
                }

                string rutaMdf = Path.Combine(directorioActual, "CapaDatos", "DB_TGAS.mdf");

                if (!File.Exists(rutaMdf))
                    throw new Exception("No se encontró el archivo DB_TGAS.mdf en CapaDatos.");

                return $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={rutaMdf};Integrated Security=True;Connect Timeout=30";
            }
        }

        public SqlConnection dbconexion = new SqlConnection(miconexion);
    }
}