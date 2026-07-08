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
    public class CDEmpleados
    {
        private int dIdEmpleado;
        private string dCedula;
        private string dNombre;
        private string dCorreo;
        private string dTelefono;
        private string dCargo;
        private DateTime dFechaContratacion;
        private string dEstado;

        public CDEmpleados()
        {
        }

        public CDEmpleados(int pIdEmpleado, string pCedula, string pNombre, string pCorreo, string pTelefono, string pCargo, DateTime pFechaContratacion, string pEstado)
        {
            dIdEmpleado = pIdEmpleado;
            dCedula = pCedula;
            dNombre = pNombre;
            dCorreo = pCorreo;
            dTelefono = pTelefono;
            dCargo = pCargo;
            dFechaContratacion = pFechaContratacion;
            dEstado = pEstado;
        }

        #region GET Y SET
        public int IdEmpleado
        {
            get { return dIdEmpleado; }
            set { dIdEmpleado = value; }
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

        public string Cargo
        {
            get { return dCargo; }
            set { dCargo = value; }
        }

        public DateTime FechaContratacion
        {
            get { return dFechaContratacion; }
            set { dFechaContratacion = value; }
        }

        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }
        #endregion

        public string Insertar(CDEmpleados objEmpleado)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDBDConexion.miconexion;

                SqlCommand micomando = new SqlCommand("EmpleadoInsertar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pcedula", objEmpleado.Cedula);
                micomando.Parameters.AddWithValue("@pnombre", objEmpleado.Nombre);
                micomando.Parameters.AddWithValue("@pcorreo", objEmpleado.Correo);
                micomando.Parameters.AddWithValue("@ptelefono", objEmpleado.Telefono ?? "");
                micomando.Parameters.AddWithValue("@pcargo", objEmpleado.Cargo);
                micomando.Parameters.AddWithValue("@pestado", objEmpleado.Estado);

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

        public string Actualizar(CDEmpleados objEmpleado)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDBDConexion.miconexion;

                SqlCommand micomando = new SqlCommand("EmpleadoActualizar", sqlCon);
                sqlCon.Open();

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pid_empleado", objEmpleado.IdEmpleado);
                micomando.Parameters.AddWithValue("@pcedula", objEmpleado.Cedula);
                micomando.Parameters.AddWithValue("@pnombre", objEmpleado.Nombre);
                micomando.Parameters.AddWithValue("@pcorreo", objEmpleado.Correo);
                micomando.Parameters.AddWithValue("@ptelefono", objEmpleado.Telefono ?? "");
                micomando.Parameters.AddWithValue("@pcargo", objEmpleado.Cargo);
                micomando.Parameters.AddWithValue("@pestado", objEmpleado.Estado);

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

        public DataTable EmpleadosConsultar(string miparametro)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = CDBDConexion.miconexion;

                SqlCommand comando = new SqlCommand("EmpleadoConsultar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@pvalor", miparametro ?? "");

                sqlCon.Open();

                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar: " + ex.Message);
            }

            return dt;
        }
    }
}