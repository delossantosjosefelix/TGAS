using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace CapaDatos
{
    public class CDUsuario
    {
        public int Id_usuario { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Rol { get; set; }
        public string Estado { get; set; }

        // SHA-256
        public static string ObtenerHash(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto ?? string.Empty));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        // INSERTAR
        public string UsuarioInsertar(CDUsuario obj)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(CDBDConexion.miconexion))
                {
                    sqlCon.Open();
                    using (SqlCommand cmd = new SqlCommand("UsuarioInsertar", sqlCon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@pnombre", obj.Nombre.Trim());
                        cmd.Parameters.AddWithValue("@pusuario", obj.Usuario.Trim());
                        cmd.Parameters.AddWithValue("@pclave", ObtenerHash(obj.Clave));
                        cmd.Parameters.AddWithValue("@prol", obj.Rol ?? "Cajero");
                        cmd.Parameters.AddWithValue("@pestado", obj.Estado ?? "Activo");

                        cmd.ExecuteNonQuery(); // ya no validamos el resultado
                        return "Usuario registrado correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        // ACTUALIZAR
        public string UsuarioActualizar(CDUsuario obj, bool cambiarClave)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(CDBDConexion.miconexion))
                {
                    sqlCon.Open();
                    using (SqlCommand cmd = new SqlCommand("UsuarioActualizar", sqlCon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@pid_usuario", obj.Id_usuario);
                        cmd.Parameters.AddWithValue("@pnombre", obj.Nombre.Trim());
                        cmd.Parameters.AddWithValue("@pusuario", obj.Usuario.Trim());
                        cmd.Parameters.AddWithValue("@prol", obj.Rol);
                        cmd.Parameters.AddWithValue("@pestado", obj.Estado);

                        if (cambiarClave && !string.IsNullOrWhiteSpace(obj.Clave))
                            cmd.Parameters.AddWithValue("@pclave", ObtenerHash(obj.Clave));
                        else
                            cmd.Parameters.AddWithValue("@pclave", DBNull.Value);

                        cmd.ExecuteNonQuery(); // ya no validamos el resultado
                        return "Datos actualizados correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        // CONSULTAR
        public DataTable UsuarioConsultar(string miparametro)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(CDBDConexion.miconexion))
                {
                    SqlCommand cmd = new SqlCommand("UsuarioConsultar", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pvalor", miparametro ?? "");

                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar: " + ex.Message);
            }
            return dt;
        }

        // VALIDAR LOGIN
        public bool ValidarLogin(CDUsuario obj)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(CDBDConexion.miconexion))
                {
                    sqlCon.Open();
                    using (SqlCommand cmd = new SqlCommand(@"
                        SELECT COUNT(*) FROM Usuarios
                        WHERE Usuario = @Usuario
                        AND Clave = @Clave
                        AND Estado = 'Activo'", sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", obj.Usuario.Trim());
                        cmd.Parameters.AddWithValue("@Clave", ObtenerHash(obj.Clave));
                        return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}