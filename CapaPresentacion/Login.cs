using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio; // ← Agregamos esta referencia

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Usuario")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.Transparent;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "Usuario";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void txtcontrasena_Enter(object sender, EventArgs e)
        {
            if (txtcontrasena.Text == "Contraseña")
            {
                txtcontrasena.Text = "";
                txtcontrasena.ForeColor = Color.Transparent;
                txtcontrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtcontrasena_Leave(object sender, EventArgs e)
        {
            if (txtcontrasena.Text == "")
            {
                txtcontrasena.Text = "Contraseña";
                txtcontrasena.ForeColor = Color.DimGray;
                txtcontrasena.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // ↓ LÓGICA DEL BOTÓN LOGIN ↓
        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Validar que no estén vacíos ni con el placeholder
            if (string.IsNullOrWhiteSpace(txtusuario.Text) || txtusuario.Text == "Usuario")
            {
                MessageBox.Show("Por favor ingresa tu usuario.",
                    "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtcontrasena.Text) || txtcontrasena.Text == "Contraseña")
            {
                MessageBox.Show("Por favor ingresa tu contraseña.",
                    "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcontrasena.Focus();
                return;
            }

            // Intentar login
            bool acceso = CNUsuario.Login(txtusuario.Text, txtcontrasena.Text);

            try
            {
                CNUsuario objUsuario = new CNUsuario();
                // Buscar por nombre de usuario exacto (el que se acaba de validar)
                DataTable dt = objUsuario.ObtenerUsuarios(txtusuario.Text.Trim());

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    Program.rolUsuario = row["Rol"].ToString();
                    Program.nombreUsuario = row["Nombre"].ToString();
                }
                else
                {
                    // Esto no debería pasar si el login fue exitoso, pero por seguridad:
                    MessageBox.Show("No se pudo recuperar el perfil del usuario.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del usuario: " + ex.Message);
                return;
            }

            if (acceso)
            {
                try
                {
                    this.Hide();
                    FBienvenida bienvenida = new FBienvenida();
                    bienvenida.ShowDialog();
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}