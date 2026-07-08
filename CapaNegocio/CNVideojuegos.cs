using System;
using System.Data;

// Conexión con la capa de datos
using CapaDatos;

namespace CapaNegocio
{
    public class CNVideojuegos
    {
        // MÉTODO INSERTAR
        public static string Insertar(string pNombre, string pDescripcion,
                                      decimal pPrecio, int pStock,
                                      DateTime pFechaLanzamiento, int pIdCategoria,
                                      int pIdPlataforma, string pEstado)
        {
            CDVideojuegos objVideojuego = new CDVideojuegos();

            objVideojuego.Nombre = pNombre;
            objVideojuego.Descripcion = pDescripcion;
            objVideojuego.Precio = pPrecio;
            objVideojuego.Stock = pStock;
            objVideojuego.FechaLanzamiento = pFechaLanzamiento;
            objVideojuego.IdCategoria = pIdCategoria;
            objVideojuego.IdPlataforma = pIdPlataforma;
            objVideojuego.Estado = pEstado;

            return objVideojuego.Insertar(objVideojuego);
        }


        // MÉTODO ACTUALIZAR
        public static string Actualizar(int pIdVideojuego, string pNombre, string pDescripcion,
                                        decimal pPrecio, int pStock,
                                        DateTime pFechaLanzamiento, int pIdCategoria,
                                        int pIdPlataforma, string pEstado)
        {
            CDVideojuegos objVideojuego = new CDVideojuegos();

            objVideojuego.IdVideojuego = pIdVideojuego;
            objVideojuego.Nombre = pNombre;
            objVideojuego.Descripcion = pDescripcion;
            objVideojuego.Precio = pPrecio;
            objVideojuego.Stock = pStock;
            objVideojuego.FechaLanzamiento = pFechaLanzamiento;
            objVideojuego.IdCategoria = pIdCategoria;
            objVideojuego.IdPlataforma = pIdPlataforma;
            objVideojuego.Estado = pEstado;

            return objVideojuego.Actualizar(objVideojuego);
        }


        // MÉTODO INSERTAR O ACTUALIZAR
        public static string InsertarActualizar(int accion, int pIdVideojuego, string pNombre,
                                                string pDescripcion, decimal pPrecio,
                                                int pStock, DateTime pFechaLanzamiento,
                                                int pIdCategoria, int pIdPlataforma, string pEstado)
        {
            CDVideojuegos objVideojuego = new CDVideojuegos();

            objVideojuego.IdVideojuego = pIdVideojuego;
            objVideojuego.Nombre = pNombre;
            objVideojuego.Descripcion = pDescripcion;
            objVideojuego.Precio = pPrecio;
            objVideojuego.Stock = pStock;
            objVideojuego.FechaLanzamiento = pFechaLanzamiento;
            objVideojuego.IdCategoria = pIdCategoria;
            objVideojuego.IdPlataforma = pIdPlataforma;
            objVideojuego.Estado = pEstado;

            if (accion == 1)
                return objVideojuego.Insertar(objVideojuego);
            else
                return objVideojuego.Actualizar(objVideojuego);
        }


        // MÉTODO CONSULTAR
        public DataTable ObtenerVideojuegos(string miparametro)
        {
            CDVideojuegos objVideojuego = new CDVideojuegos();
            DataTable dt = new DataTable();

            dt = objVideojuego.VideojuegosConsultar(miparametro);

            return dt;
        }
    }
}