using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNClientes
    {
        // METODO INSERTAR
        public static string Insertar(string pCedula, string pNombre, string pCorreo, string pTelefono, string pDireccion, string pEstado)
        {
            CDClientes objCliente = new CDClientes();
            objCliente.Cedula = pCedula;
            objCliente.Nombre = pNombre;
            objCliente.Correo = pCorreo;
            objCliente.Telefono = pTelefono;
            objCliente.Direccion = pDireccion;
            objCliente.Estado = pEstado;
            return objCliente.Insertar(objCliente);
        }

        // METODO ACTUALIZAR
        public static string Actualizar(int pIdCliente, string pCedula, string pNombre, string pCorreo, string pTelefono, string pDireccion, string pEstado)
        {
            CDClientes objCliente = new CDClientes();
            objCliente.IdCliente = pIdCliente;
            objCliente.Cedula = pCedula;
            objCliente.Nombre = pNombre;
            objCliente.Correo = pCorreo;
            objCliente.Telefono = pTelefono;
            objCliente.Direccion = pDireccion;
            objCliente.Estado = pEstado;
            return objCliente.Actualizar(objCliente);
        }

        // METODO CONSULTAR
        public DataTable ObtenerClientes(string miparametro)
        {
            CDClientes objCliente = new CDClientes();
            DataTable dt = new DataTable();
            dt = objCliente.ClientesConsultar(miparametro);
            return dt;
        }
    }
}