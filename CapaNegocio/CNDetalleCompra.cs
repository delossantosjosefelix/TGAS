using System;
using System.Data;

// Agregamos la capa de datos
using CapaDatos;

namespace CapaNegocio
{
    public class CNDetalleCompra
    {
        // MÉTODO INSERTAR
        public static string Insertar(int pidCompra, int pidVideojuego, int pCantidad, decimal pPrecioUnitario)
        {
            CDDetalleCompra objDetalle = new CDDetalleCompra();

            objDetalle.IdCompra = pidCompra;
            objDetalle.IdVideojuego = pidVideojuego;
            objDetalle.Cantidad = pCantidad; // Agregado
            objDetalle.PrecioUnitario = pPrecioUnitario;

            return objDetalle.Insertar(objDetalle);
        }


        // MÉTODO ACTUALIZAR
        public static string Actualizar(int pidDetalle, int pidCompra, int pidVideojuego, int pCantidad, decimal pPrecioUnitario)
        {
            CDDetalleCompra objDetalle = new CDDetalleCompra();

            objDetalle.IdDetalle = pidDetalle;
            objDetalle.IdCompra = pidCompra;
            objDetalle.IdVideojuego = pidVideojuego;
            objDetalle.Cantidad = pCantidad; // Agregado
            objDetalle.PrecioUnitario = pPrecioUnitario;

            return objDetalle.Actualizar(objDetalle);
        }


        // MÉTODO CONSULTAR
        public DataTable ObtenerDetalleCompra(string miparametro)
        {
            CDDetalleCompra objDetalle = new CDDetalleCompra();
            DataTable dt = new DataTable();

            dt = objDetalle.DetalleCompraConsultar(miparametro);

            return dt;
        }
    }
}