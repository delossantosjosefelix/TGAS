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
    public class CDClientes
    {
        private int dIdCliente;
        private string dCedula;
        private string dNombre;
        private string dCorreo;
        private string dTelefono;
        private string dDireccion;
        private DateTime dFechaRegistro;
        private string dEstado;

        public CDClientes()
        {
        }

        public CDClientes(int pIdCliente, string pCedula, string pNombre, string pCorreo, string pTelefono, string pDireccion, DateTime pFechaRegistro, string pEstado)
        {
            dIdCliente = pIdCliente;
            dCedula = pCedula;
            dNombre = pNombre;
            dCorreo = pCorreo;
            dTelefono = pTelefono;
            dDireccion = pDireccion;
            dFechaRegistro = pFechaRegistro;
            dEstado = pEstado;
        }

        #region GET Y SET
        public int IdCliente
        {
            get { return dIdCliente; }
            set { dIdCliente = value; }
        }

        public string Cedula
        {
            get { return dCedula; }
            set { dCedula = value; }
        }

        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }

        public string Correo
        {
            get { return dCorreo; }
            set { dCorreo = value; }
        }

        public string Telefono
        {
            get { return dTelefono; }
            set { dTelefono = value; }
        }

        public string Direccion
        {
            get { return dDireccion; }
            set { dDireccion = value; }
        }

        public DateTime FechaRegistro
        {
            get { return dFechaRegistro; }
            set { dFechaRegistro = value; }
        }

        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }
        #endregion

        public string Insertar(CDClientes objCliente)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDBDConexion.miconexion;

                SqlCommand micomando = new SqlCommand("ClienteInsertar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pcedula", objCliente.Cedula);
                micomando.Parameters.AddWithValue("@pnombre", objCliente.Nombre);
                micomando.Parameters.AddWithValue("@pcorreo", objCliente.Correo);
                micomando.Parameters.AddWithValue("@ptelefono", objCliente.Telefono ?? "");
                micomando.Parameters.AddWithValue("@pdireccion", objCliente.Direccion ?? "");
                micomando.Parameters.AddWithValue("@pestado", objCliente.Estado);

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

        public string Actualizar(CDClientes objCliente)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDBDConexion.miconexion;

                SqlCommand micomando = new SqlCommand("ClienteActualizar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pid_cliente", objCliente.IdCliente);
                micomando.Parameters.AddWithValue("@pcedula", objCliente.Cedula);
                micomando.Parameters.AddWithValue("@pnombre", objCliente.Nombre);
                micomando.Parameters.AddWithValue("@pcorreo", objCliente.Correo);
                micomando.Parameters.AddWithValue("@ptelefono", objCliente.Telefono ?? "");
                micomando.Parameters.AddWithValue("@pdireccion", objCliente.Direccion ?? "");
                micomando.Parameters.AddWithValue("@pestado", objCliente.Estado);

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

        public DataTable ClientesConsultar(string miparametro)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDBDConexion.miconexion;

                SqlCommand sqlCmd = new SqlCommand("ClienteConsultar", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro ?? "");

                sqlCon.Open();

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);

                sqlCon.Close();
            }
            catch (Exception)
            {
                dt = null;
            }

            return dt;
        }
    }
}