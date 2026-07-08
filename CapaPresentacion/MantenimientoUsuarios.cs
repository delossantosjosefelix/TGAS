using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MantenimientoUsuarios : Form
    {
        public string mensaje = "";

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private Form formularioActivoHijo = null;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);
        private const int WM_SETREDRAW = 11;

        private void AbrirFormularioNieto(Form formularioNieto)
        {
            if (formularioActivoHijo != null) formularioActivoHijo.Close();
            SendMessage(this.Handle, WM_SETREDRAW, false, 0);
            formularioActivoHijo = formularioNieto;
            formularioNieto.TopLevel = false;
            formularioNieto.FormBorderStyle = FormBorderStyle.None;
            formularioNieto.Dock = DockStyle.None;
            formularioNieto.Location = new Point(0, 0);
            formularioNieto.Size = this.Size;
            formularioNieto.Visible = false;
            this.Controls.Add(formularioNieto);
            formularioNieto.BringToFront();
            formularioNieto.Visible = true;
            SendMessage(this.Handle, WM_SETREDRAW, true, 0);
            this.Refresh();
        }

        public void CerrarFormularioNieto()
        {
            if (formularioActivoHijo != null)
            {
                formularioActivoHijo.Close();
                formularioActivoHijo = null;
            }
        }

        public MantenimientoUsuarios()
        {
            InitializeComponent();
        }

        private void MantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            cbRol.Items.Clear();
            cbRol.Items.Add("Gerente");
            cbRol.Items.Add("Empleado");
            cbRol.SelectedIndex = 0;

            cbEstado.Items.Clear();
            cbEstado.Items.Add("Activo");
            cbEstado.Items.Add("Inactivo");
            cbEstado.SelectedIndex = 0;

            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();
        }

        public void LimpiaObjetos()
        {
            tbIdUsuario.Clear();
            tbNombre.Clear();
            tbUsuario.Clear();
            tbClave.Clear();
            cbRol.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
            tbNombre.Focus();
        }

        private void HabilitaControles(bool valor)
        {
            tbIdUsuario.ReadOnly = true;
            tbNombre.Enabled = valor;
            tbUsuario.Enabled = valor;
            tbClave.Enabled = valor; // habilitado tanto en agregar como en editar
            cbRol.Enabled = valor;
            cbEstado.Enabled = valor;

            Color colorFondo = valor ? Color.White : Color.FromArgb(240, 240, 240);
            tbNombre.BackColor = colorFondo;
            tbUsuario.BackColor = colorFondo;
            tbClave.BackColor = colorFondo;
        }

        private void HabilitaBotones()
        {
            if (Program.nuevo || Program.modificar)
            {
                HabilitaControles(true);
                BAgregar.Enabled = false;
                BGuardar.Enabled = true;
                BEditar.Enabled = false;
                BCancelar.Enabled = true;
                BBuscar.Enabled = false;
            }
            else
            {
                HabilitaControles(false);
                BAgregar.Enabled = true;
                BGuardar.Enabled = false;
                BEditar.Enabled = true;
                BCancelar.Enabled = false;
                BBuscar.Enabled = true;
            }
            BSalir.Enabled = true;
        }

        public void RecuperaDatos()
        {
            CNUsuario obj = new CNUsuario();
            DataTable dt = obj.ObtenerUsuarios(Program.vidUsuario.ToString());

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                tbIdUsuario.Text = row["Id_usuario"].ToString();
                tbNombre.Text = row["Nombre"].ToString();
                tbUsuario.Text = row["Usuario"].ToString();
                tbClave.Text = ""; // nunca mostramos la clave
                cbRol.Text = row["Rol"].ToString();
                cbEstado.Text = row["Estado"].ToString();
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            LimpiaObjetos();
            Program.nuevo = true;
            Program.modificar = false;
            HabilitaBotones();
            tbNombre.Focus();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                MessageBox.Show("Debe indicar el nombre del usuario.", "TreeGames",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNombre.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbUsuario.Text))
            {
                MessageBox.Show("Debe indicar el nombre de usuario.", "TreeGames",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsuario.Focus();
                return;
            }
            if (Program.nuevo && string.IsNullOrWhiteSpace(tbClave.Text))
            {
                MessageBox.Show("Debe indicar una contraseña.", "TreeGames",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbClave.Focus();
                return;
            }

            if (Program.nuevo)
            {
                mensaje = CNUsuario.Insertar(
                    tbNombre.Text.Trim(),
                    tbUsuario.Text.Trim(),
                    tbClave.Text,
                    cbRol.Text,
                    cbEstado.Text);
            }
            else if (Program.modificar)
            {
                // Si dejó la clave vacía = no cambia, si escribió algo = actualiza
                bool cambiarClave = !string.IsNullOrWhiteSpace(tbClave.Text);

                mensaje = CNUsuario.Actualizar(
                    Convert.ToInt32(tbIdUsuario.Text),
                    tbNombre.Text.Trim(),
                    tbUsuario.Text.Trim(),
                    tbClave.Text,
                    cbRol.Text,
                    cbEstado.Text,
                    cambiarClave);
            }

            MessageBox.Show(mensaje, "TreeGames",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mensaje.Contains("correctamente"))
            {
                Program.nuevo = false;
                Program.modificar = false;
                HabilitaBotones();
                LimpiaObjetos();
            }
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNombre.Text))
            {
                Program.modificar = true;
                Program.nuevo = false;
                HabilitaBotones();

                // Advertencia de usabilidad al entrar en modo editar
                MessageBox.Show(
                    "⚠️ Si desea cambiar la contraseña, escríbala en el campo Contraseña.\n\n" +
                    "Si deja el campo vacío, la contraseña actual se mantendrá sin cambios.",
                    "Aviso — Contraseña",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                tbNombre.Focus();
            }
            else
            {
                MessageBox.Show("Debe buscar un usuario para poder modificarlo.", "TreeGames",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();
            LimpiaObjetos();
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            Program.vidUsuario = 0;
            FBuscarUsuarios frm = new FBuscarUsuarios(this);
            AbrirFormularioNieto(frm);
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mensaje",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MantenimientoUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar este formulario?", "TreeGames",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}