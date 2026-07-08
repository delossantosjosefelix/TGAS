using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNEmpleados
    {
        // METODO INSERTAR
        public static string Insertar(string pCedula, string pNombre, string pCorreo, string pTelefono, string pCargo, string pEstado)
        {
            CDEmpleados objEmpleado = new CDEmpleados();
            objEmpleado.Cedula = pCedula;
            objEmpleado.Nombre = pNombre;
            objEmpleado.Correo = pCorreo;
            objEmpleado.Telefono = pTelefono;
            objEmpleado.Cargo = pCargo;
            objEmpleado.Estado = pEstado;
            return objEmpleado.Insertar(objEmpleado);
        }

        // METODO ACTUALIZAR
        public static string Actualizar(int pIdEmpleado, string pCedula, string pNombre, string pCorreo, string pTelefono, string pCargo, string pEstado)
        {
            CDEmpleados objEmpleado = new CDEmpleados();
            objEmpleado.IdEmpleado = pIdEmpleado;
            objEmpleado.Cedula = pCedula;
            objEmpleado.Nombre = pNombre;
            objEmpleado.Correo = pCorreo;
            objEmpleado.Telefono = pTelefono;
            objEmpleado.Cargo = pCargo;
            objEmpleado.Estado = pEstado;
            return objEmpleado.Actualizar(objEmpleado);
        }

        // METODO CONSULTAR
        public DataTable EmpleadosConsultar(string miparametro)
        {
            CDEmpleados objEmpleado = new CDEmpleados();
            DataTable dt = new DataTable();
            dt = objEmpleado.EmpleadosConsultar(miparametro);
            return dt;
        }
    }
}