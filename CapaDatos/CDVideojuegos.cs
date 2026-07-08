using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDVideojuegos
    {
        // VARIABLES PRIVADAS
        private int dIdVideojuego;
        private string dNombre;
        private string dDescripcion;
        private decimal dPrecio;
        private int dStock;
        private DateTime dFechaLanzamiento;
        private int dIdCategoria;
        private int dIdPlataforma;
        private string dEstado;

        // CONSTRUCTOR VACÍO
        public CDVideojuegos()
        {

        }

        // CONSTRUCTOR CON PARÁMETROS
        public CDVideojuegos(int pIdVideojuego, string pNombre, string pDescripcion,
                             decimal pPrecio, int pStock, DateTime pFechaLanzamiento, int pIdCategoria, int pIdPlataforma, string pEstado)
        {
            dIdVideojuego = pIdVideojuego;
            dNombre = pNombre;
            dDescripcion = pDescripcion;
            dPrecio = pPrecio;
            dStock = pStock;
            dFechaLanzamiento = pFechaLanzamiento;
            dIdCategoria = pIdCategoria;
            dIdPlataforma = pIdPlataforma;
            dEstado = pEstado;
        }

        #region GET Y SET

        public int IdVideojuego
        {
            get { return dIdVideojuego; }
            set { dIdVideojuego = value; }
        }

        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }

        public string Descripcion
        {
            get { return dDescripcion; }
            set { dDescripcion = value; }
        }

        public decimal Precio
        {
            get { return dPrecio; }
            set { dPrecio = value; }
        }

        public int Stock
        {
            get { return dStock; }
            set { dStock = value; }
        }

        public DateTime FechaLanzamiento
        {
            get { return dFechaLanzamiento; }
            set { dFechaLanzamiento = value; }
        }

        public int IdCategoria
        {
            get { return dIdCategoria; }
            set { dIdCategoria = value; }
        }

        public int IdPlataforma
        {
            get { return dIdPlataforma; }
            set { dIdPlataforma = value; }
        }

        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }

        #endregion


        // MÉTODO INSERTAR
        public string Insertar(CDVideojuegos objVideojuego)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDBDConexion.miconexion;

                SqlCommand micomando = new SqlCommand("VideojuegoInsertar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pnombre", objVideojuego.Nombre);
                micomando.Parameters.AddWithValue("@pdescripcion", objVideojuego.Descripcion);
                micomando.Parameters.AddWithValue("@pprecio", objVideojuego.Precio);
                micomando.Parameters.AddWithValue("@pstock", objVideojuego.Stock);
                micomando.Parameters.AddWithValue("@pfecha_lanzamiento", objVideojuego.FechaLanzamiento);
                micomando.Parameters.AddWithValue("@pid_categoria", objVideojuego.IdCategoria);
                micomando.Parameters.AddWithValue("@pid_plataforma", objVideojuego.IdPlataforma);
                micomando.Parameters.AddWithValue("@pestado", objVideojuego.Estado);

                mensaje = micomando.ExecuteNonQuery() == 1
                    ? "Inserción completada correctamente!"
                    : "No se pudo insertar el videojuego.";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return mensaje;
        }


        // MÉTODO ACTUALIZAR
        public string Actualizar(CDVideojuegos objVideojuego)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDBDConexion.miconexion;

                SqlCommand micomando = new SqlCommand("VideoJuegoActualizar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pid_videojuego", objVideojuego.IdVideojuego);
                micomando.Parameters.AddWithValue("@pnombre", objVideojuego.Nombre);
                micomando.Parameters.AddWithValue("@pdescripcion", objVideojuego.Descripcion);
                micomando.Parameters.AddWithValue("@pprecio", objVideojuego.Precio);
                micomando.Parameters.AddWithValue("@pstock", objVideojuego.Stock);
                micomando.Parameters.AddWithValue("@pfecha_lanzamiento", objVideojuego.FechaLanzamiento);
                micomando.Parameters.AddWithValue("@pid_categoria", objVideojuego.IdCategoria);
                micomando.Parameters.AddWithValue("@pid_plataforma", objVideojuego.IdPlataforma);
                micomando.Parameters.AddWithValue("@pestado", objVideojuego.Estado);

                mensaje = micomando.ExecuteNonQuery() == 1
                    ? "Datos actualizados correctamente!"
                    : "No se pudo actualizar el videojuego.";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return mensaje;
        }


        // MÉTODO CONSULTAR
        public DataTable VideojuegosConsultar(string miparametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new CDBDConexion().dbconexion;
                sqlCmd.Connection.Open();

                sqlCmd.CommandText = "VideoJuegoConsultar";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro);

                leerDatos = sqlCmd.ExecuteReader();
                dt.Load(leerDatos);

                sqlCmd.Connection.Close();
            }
            catch
            {
                dt = null;
            }

            return dt;
        }
    }
}