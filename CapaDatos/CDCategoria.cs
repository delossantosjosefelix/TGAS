using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregamos estas librerías
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;

namespace CapaDatos
{
    public class CDCategoria
    {
        // VARIABLES PRIVADAS
        private int dIdCategoria;
        private string dNombre, dEstado;

        // CONSTRUCTOR VACÍO
        public CDCategoria()
        {

        }

        // CONSTRUCTOR CON PARÁMETROS
        public CDCategoria(int pIdCategoria, string pNombre, string pEstado)
        {
            dIdCategoria = pIdCategoria;
            dNombre = pNombre;
            dEstado = pEstado;
        }

        #region Metodos Get y Set

        public int IdCategoria
        {
            get { return dIdCategoria; }
            set { dIdCategoria = value; }
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
        public string Insertar(CDCategoria objCategoria)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDBDConexion.miconexion;

                SqlCommand micomando = new SqlCommand("CategoriaInsertar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pNombre", objCategoria.Nombre);
                micomando.Parameters.AddWithValue("@pEstado", objCategoria.Estado);

                mensaje = micomando.ExecuteNonQuery() == 1
                    ? "Inserción de datos completada correctamente!"
                    : "No se pudo insertar correctamente los nuevos datos!";
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
        public string Actualizar(CDCategoria objCategoria)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDBDConexion.miconexion;

                SqlCommand micomando = new SqlCommand("CategoriaActualizar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pid_categoria", objCategoria.IdCategoria);
                micomando.Parameters.AddWithValue("@pNombre", objCategoria.Nombre);
                micomando.Parameters.AddWithValue("@pEstado", objCategoria.Estado);

                mensaje = micomando.ExecuteNonQuery() == 1
                    ? "Datos actualizados correctamente!"
                    : "No se pudo actualizar correctamente los datos!";
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
        public DataTable CategoriaConsultar(string miparametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new CDBDConexion().dbconexion;
                sqlCmd.Connection.Open();

                sqlCmd.CommandText = "CategoriaConsultar";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro);

                leerDatos = sqlCmd.ExecuteReader();
                dt.Load(leerDatos);

                sqlCmd.Connection.Close();
            }
            catch (Exception)
            {
                dt = null;
            }

            return dt;
        }
    }
}