using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

// Agregamos la capa de datos para poder comunicarnos con ella
using CapaDatos;

namespace CapaNegocio
{
    public class CNCategoria
    {
        // MÉTODO INSERTAR
        public static string Insertar(int pidCategoria, string pNombre, string pEstado)
        {
            CDCategoria objCategoria = new CDCategoria();

            objCategoria.IdCategoria = pidCategoria;
            objCategoria.Nombre = pNombre;
            objCategoria.Estado = pEstado;

            return objCategoria.Insertar(objCategoria);
        }

        // MÉTODO ACTUALIZAR
        public static string Actualizar(int pidCategoria, string pNombre, string pEstado)
        {
            CDCategoria objCategoria = new CDCategoria();

            objCategoria.IdCategoria = pidCategoria;
            objCategoria.Nombre = pNombre;
            objCategoria.Estado = pEstado;

            return objCategoria.Actualizar(objCategoria);
        }

        // MÉTODO CONSULTAR / OBTENER
        public DataTable ObtenerCategoria(string miparametro)
        {
            CDCategoria objCategoria = new CDCategoria();
            DataTable dt = new DataTable();

            dt = objCategoria.CategoriaConsultar(miparametro);

            return dt;
        }
    }
}