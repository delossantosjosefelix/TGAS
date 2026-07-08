using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;

namespace CapaDatos
{
    public class CDCompras
    {
        // VARIABLES PRIVADAS
        private int dIdCompra;
        private int dIdCliente;    // Cambiado de dIdUsuario a dIdCliente
        private int dIdEmpleado;   // Agregado el dIdEmpleado
        private DateTime dFechaCompra;
        private decimal dTotal;

        // CONSTRUCTOR VACÍO
        public CDCompras()
        {

        }

        // CONSTRUCTOR CON PARÁMETROS
        public CDCompras(int pIdCompra, int pIdCliente, int pIdEmpleado, DateTime pFechaCompra, decimal pTotal)
        {
            dIdCompra = pIdCompra;
            dIdCliente = pIdCliente;
            dIdEmpleado = pIdEmpleado;
            dFechaCompra = pFechaCompra;
            dTotal = pTotal;
        }

        #region GET Y SET

        public int IdCompra
        {
            get { return dIdCompra; }
            set { dIdCompra = value; }
        }

        public int IdCliente
        {
            get { return dIdCliente; }
            set { dIdCliente = value; }
        }

        public int IdEmpleado
        {
            get { return dIdEmpleado; }
            set { dIdEmpleado = value; }
        }

        public DateTime FechaCompra
        {
            get { return dFechaCompra; }
            set { dFechaCompra = value; }
        }

        public decimal Total
        {
            get { return dTotal; }
            set { dTotal = value; }
        }

        #endregion

        // MÉTODO INSERTAR
        public int InsertarCompra(CDCompras objCompra)
        {
            int idGenerado = 0;

            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDBDConexion.miconexion;

                SqlCommand micomando = new SqlCommand("ComprasInsertar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pid_cliente", objCompra.IdCliente);
                micomando.Parameters.AddWithValue("@pid_empleado", objCompra.IdEmpleado);
                micomando.Parameters.AddWithValue("@pfecha_compra", objCompra.FechaCompra);
                micomando.Parameters.AddWithValue("@ptotal", objCompra.Total);

                SqlParameter outputId = new SqlParameter("@pid_compra", SqlDbType.Int);
                outputId.Direction = ParameterDirection.Output;
                micomando.Parameters.Add(outputId);

                micomando.ExecuteNonQuery();

                idGenerado = Convert.ToInt32(outputId.Value);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return idGenerado;
        }

        // MÉTODO ACTUALIZAR
        public string Actualizar(CDCompras objCompra)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDBDConexion.miconexion;

                SqlCommand micomando = new SqlCommand("ComprasActualizar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pid_compra", objCompra.IdCompra);
                micomando.Parameters.AddWithValue("@pid_cliente", objCompra.IdCliente);
                micomando.Parameters.AddWithValue("@pid_empleado", objCompra.IdEmpleado);
                micomando.Parameters.AddWithValue("@pfecha_compra", objCompra.FechaCompra);
                micomando.Parameters.AddWithValue("@ptotal", objCompra.Total);

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
        public DataTable ComprasConsultar(string miparametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new CDBDConexion().dbconexion;
                sqlCmd.Connection.Open();

                sqlCmd.CommandText = "ComprasConsultar";
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
