using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNUsuario
    {
        // INSERTAR
        public static string Insertar(string nombre, string usuario, string clave,
                                      string rol = "Cajero", string estado = "Activo")
        {
            CDUsuario obj = new CDUsuario();
            obj.Nombre = nombre;
            obj.Usuario = usuario;
            obj.Clave = clave;
            obj.Rol = rol;
            obj.Estado = estado;
            return obj.UsuarioInsertar(obj);
        }

        // ACTUALIZAR
        public static string Actualizar(int idUsuario, string nombre, string usuario,
                                        string clave, string rol, string estado, bool cambiarClave)
        {
            CDUsuario obj = new CDUsuario();
            obj.Id_usuario = idUsuario;
            obj.Nombre = nombre;
            obj.Usuario = usuario;
            obj.Clave = clave;
            obj.Rol = rol;
            obj.Estado = estado;
            return obj.UsuarioActualizar(obj, cambiarClave);
        }

        // CONSULTAR
        public DataTable ObtenerUsuarios(string miparametro)
        {
            CDUsuario obj = new CDUsuario();
            return obj.UsuarioConsultar(miparametro);
        }

        // LOGIN
        public static bool Login(string usuario, string clave)
        {
            CDUsuario obj = new CDUsuario();
            obj.Usuario = usuario;
            obj.Clave = clave;
            return obj.ValidarLogin(obj);
        }
    }
}