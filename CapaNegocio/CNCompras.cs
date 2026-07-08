using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

// Conexión con la capa de datos
using CapaDatos;

namespace CapaNegocio
{
    public class CNCompras
    {
        // MÉTODO INSERTAR
        public int InsertarCompra(int idCliente, int idEmpleado, DateTime fecha, decimal total)
        {
            CDCompras obj = new CDCompras();

            obj.IdCliente = idCliente;
            obj.IdEmpleado = idEmpleado;
            obj.FechaCompra = fecha;
            obj.Total = total;

            return obj.InsertarCompra(obj);
        }

        // MÉTODO ACTUALIZAR
        public static string Actualizar(int pidCompra, int pidCliente, int pidEmpleado, DateTime pFechaCompra, decimal pTotal)
        {
            CDCompras objCompra = new CDCompras();

            objCompra.IdCompra = pidCompra;
            objCompra.IdCliente = pidCliente;
            objCompra.IdEmpleado = pidEmpleado;
            objCompra.FechaCompra = pFechaCompra;
            objCompra.Total = pTotal;

            return objCompra.Actualizar(objCompra);
        }

        // MÉTODO CONSULTAR
        
        public DataTable ObtenerCompras(string valor)
        {
            CDCompras objCompra = new CDCompras();
            DataTable dt = new DataTable();

            dt = objCompra.ComprasConsultar(valor);

            return dt;
        }
    }
}