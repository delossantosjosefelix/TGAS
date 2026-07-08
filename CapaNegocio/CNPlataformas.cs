using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNPlataformas
    {
        // MÉTODO INSERTAR
        public static string Insertar(string pNombre, string pEstado)
        {
            CDPlataformas objPlataforma = new CDPlataformas();

            objPlataforma.Nombre = pNombre;
            objPlataforma.Estado = pEstado;

            return objPlataforma.Insertar(objPlataforma);
        }

        // MÉTODO CONSULTAR
        public static DataTable ObtenerPlataforma(string miparametro)
        {
            CDPlataformas objPlataforma = new CDPlataformas();

            return objPlataforma.PlataformaConsultar(miparametro);
        }

        // MÉTODO ACTUALIZAR
        public static string Actualizar(int pIdPlataforma, string pNombre, string pEstado)
        {
            CDPlataformas objPlataforma = new CDPlataformas();

            // Llenamos el objeto con los datos que vienen del formulario
            objPlataforma.IdPlataforma = pIdPlataforma;
            objPlataforma.Nombre = pNombre;
            objPlataforma.Estado = pEstado;

            // Llamamos al método Actualizar de la capa de datos
            return objPlataforma.Actualizar(objPlataforma);
        }
    }
}