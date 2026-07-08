using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDPlataformas
    {
        // VARIABLES PRIVADAS
        private int dIdPlataforma;
        private string dNombre;
        private string dEstado;

        // CONSTRUCTOR VACÍO
        public CDPlataformas()
        {

        }

        // CONSTRUCTOR CON PARÁMETROS
        public CDPlataformas(int pIdPlataforma, string pNombre, string pEstado)
        {
            dIdPlataforma = pIdPlataforma;
            dNombre = pNombre;
            dEstado = pEstado;
        }

        #region Get y Set

        public int IdPlataforma
        {
            get { return dIdPlataforma; }
            set { dIdPlataforma = value; }
        }

        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }

        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }

        #endregion

        // MÉTODO INSERTAR
        public string Insertar(CDPlataformas objPlataforma)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDBDConexion.miconexion;

                SqlCommand micomando = new SqlCommand("PlataformaInsertar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pNombre", objPlataforma.Nombre);
                micomando.Parameters.AddWithValue("@pestado", objPlataforma.Estado);

                mensaje = micomando.ExecuteNonQuery() == 1
                    ? "Inserción completada correctamente!"
                    : "No se pudo insertar correctamente!";
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
        
        public DataTable PlataformaConsultar(string miparametro)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                // Usamos la propiedad estática miconexion que tiene la ruta correcta al .mdf
                sqlCon.ConnectionString = CDBDConexion.miconexion;

                SqlCommand sqlCmd = new SqlCommand("PlataformaConsultar", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                // Limpiamos el parámetro: si es nulo o espacios, enviamos cadena vacía
                string buscar = string.IsNullOrWhiteSpace(miparametro) ? "" : miparametro;
                sqlCmd.Parameters.AddWithValue("@pvalor", buscar);

                sqlCon.Open();

                // Usamos un SqlDataAdapter para llenar el DataTable de forma segura
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                // Si hay error, al menos sabremos qué pasó (puedes quitar el throw luego)
                // throw ex; 
                dt = null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return dt;
        }

        // MÉTODO ACTUALIZAR
        public string Actualizar(CDPlataformas objPlataforma)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDBDConexion.miconexion;

                SqlCommand micomando = new SqlCommand("PlataformaActualizar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                // Pasamos los 3 parámetros que espera tu procedimiento almacenado
                micomando.Parameters.AddWithValue("@pid_plataforma", objPlataforma.IdPlataforma);
                micomando.Parameters.AddWithValue("@pnombre", objPlataforma.Nombre);
                micomando.Parameters.AddWithValue("@pestado", objPlataforma.Estado);

                mensaje = micomando.ExecuteNonQuery() == 1
                    ? "Actualización completada correctamente!"
                    : "No se pudo actualizar correctamente!";
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
    }
}