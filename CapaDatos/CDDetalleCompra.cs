using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDDetalleCompra
    {
        // VARIABLES PRIVADAS
        private int dIdDetalle;
        private int dIdCompra;
        private int dIdVideojuego;
        private int dCantidad;      // NUEVA VARIABLE AGREGADA
        private decimal dPrecioUnitario;

        // CONSTRUCTOR VACÍO
        public CDDetalleCompra()
        {

        }

        // CONSTRUCTOR CON PARÁMETROS
        public CDDetalleCompra(int pIdDetalle, int pIdCompra, int pIdVideojuego, int pCantidad, decimal pPrecioUnitario)
        {
            dIdDetalle = pIdDetalle;
            dIdCompra = pIdCompra;
            dIdVideojuego = pIdVideojuego;
            dCantidad = pCantidad;
            dPrecioUnitario = pPrecioUnitario;
        }

        #region Get y Set

        public int IdDetalle
        {
            get { return dIdDetalle; }
            set { dIdDetalle = value; }
        }

        public int IdCompra
        {
            get { return dIdCompra; }
            set { dIdCompra = value; }
        }

        public int IdVideojuego
        {
            get { return dIdVideojuego; }
            set { dIdVideojuego = value; }
        }

        public int Cantidad
        {
            get { return dCantidad; }
            set { dCantidad = value; }
        }

        public decimal PrecioUnitario
        {
            get { return dPrecioUnitario; }
            set { dPrecioUnitario = value; }
        }

        #endregion


        // MÉTODO INSERTAR
        public string Insertar(CDDetalleCompra objDetalle)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDBDConexion.miconexion;

                SqlCommand micomando = new SqlCommand("DetalleCompraInsertar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pid_compra", objDetalle.IdCompra);
                micomando.Parameters.AddWithValue("@pid_videojuego", objDetalle.IdVideojuego);
                micomando.Parameters.AddWithValue("@pcantidad", objDetalle.Cantidad); // Parámetro agregado
                micomando.Parameters.AddWithValue("@pprecio_unitario", objDetalle.PrecioUnitario);

                mensaje = micomando.ExecuteNonQuery() == 1
                    ? "Inserción completada correctamente!"
                    : "No se pudo insertar el detalle de compra.";
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
        public string Actualizar(CDDetalleCompra objDetalle)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDBDConexion.miconexion;

                SqlCommand micomando = new SqlCommand("DetalleCompraActualizar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pid_detalle", objDetalle.IdDetalle);
                micomando.Parameters.AddWithValue("@pid_compra", objDetalle.IdCompra);
                micomando.Parameters.AddWithValue("@pid_videojuego", objDetalle.IdVideojuego);
                micomando.Parameters.AddWithValue("@pcantidad", objDetalle.Cantidad); // Parámetro agregado
                micomando.Parameters.AddWithValue("@pprecio_unitario", objDetalle.PrecioUnitario);

                mensaje = micomando.ExecuteNonQuery() == 1
                    ? "Datos actualizados correctamente!"
                    : "No se pudo actualizar el detalle de compra.";
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
        public DataTable DetalleCompraConsultar(string valor)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new CDBDConexion().dbconexion;
                sqlCmd.Connection.Open();

                sqlCmd.CommandText = "DetalleCompraConsultar";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pvalor", valor);

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