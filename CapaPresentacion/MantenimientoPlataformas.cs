using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Importamos la capa de negocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MantenimientoPlataformas : Form
    {
        // Variables globales para el estado y mensajes
        public string mensaje = "";

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Anti-Flicker
                return cp;
            }
        }
        // 1. Agregar debajo de: public string mensaje = "";

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

        // 2. Reemplazar BBuscar_Click por este:
        private void BBuscar_Click(object sender, EventArgs e)
        {
            Program.vidPlataforma = 0;
            FBuscarPlataformas frm = new FBuscarPlataformas(this);
            AbrirFormularioNieto(frm);
        }

        public MantenimientoPlataformas()
        {
            InitializeComponent();
        }

        // Evento Load: Configuración inicial al abrir el formulario
        private void MantenimientoPlataformas_Load(object sender, EventArgs e)
        {
            // Llenamos el combo de estado
            cbEstado.Items.Clear();
            cbEstado.Items.Add("Activo");
            cbEstado.Items.Add("Inactivo");
            cbEstado.SelectedIndex = 0;

            // Inicializamos las variables de control del Programa
            Program.nuevo = false;
            Program.modificar = false;

            // Bloquea/Desbloquea los botones al abrir el formulario
            HabilitaBotones();
        }

        private void HabilitaBotones()
        {
            if (Program.nuevo || Program.modificar)
            {
                // Estado: Agregando o Editando
                HabilitaControles(true);

                BAgregar.Enabled = false;
                BGuardar.Enabled = true;
                BEditar.Enabled = false;
                BCancelar.Enabled = true;
                BBuscar.Enabled = false;
            }
            else
            {
                // Estado: Reposo
                HabilitaControles(false);

                BAgregar.Enabled = true;
                BGuardar.Enabled = false;
                BEditar.Enabled = true;
                BCancelar.Enabled = false;
                BBuscar.Enabled = true;
            }

            BSalir.Enabled = true;
        }

        #region Metodos Propios (Logica de Interfaz)

        public void LimpiaObjetos()
        {
            // OJO: Verifica si tu TextBox se llama tbIdPlataforma o tbIdPlataformas
            if (tbIdPlataformas != null) tbIdPlataformas.Clear();
            tbNombre.Clear();
            cbEstado.SelectedIndex = 0;
            tbNombre.Focus();
        }

        private void HabilitaControles(bool valor)
        {
            if (tbIdPlataformas != null) tbIdPlataformas.ReadOnly = true;

            tbNombre.Enabled = valor;
            cbEstado.Enabled = valor;

            Color colorFondo = valor ? Color.White : Color.FromArgb(240, 240, 240);
            tbNombre.BackColor = colorFondo;
            cbEstado.BackColor = colorFondo;
        }

        public void RecuperaDatos()
        {
            // Buscamos la plataforma usando el ID guardado en la variable global del buscador
            DataTable dt = CNPlataformas.ObtenerPlataforma(Program.vidPlataforma.ToString());

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                tbIdPlataformas.Text = row["id_plataforma"].ToString(); // Revisa el nombre exacto de la columna en BD
                tbNombre.Text = row["nombre"].ToString();
                cbEstado.Text = row["Estado"].ToString();
            }
        }

        #endregion

        #region Eventos de Botones

        private void BAgregar_Click(object sender, EventArgs e)
        {
            LimpiaObjetos();
            Program.nuevo = true;
            Program.modificar = false;
            HabilitaBotones();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                MessageBox.Show("¡Debe indicar el nombre de la plataforma!", "TreeGames", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNombre.Focus();
                return;
            }

            try
            {
                if (Program.nuevo)
                {
                    // Llama al método Insertar
                    mensaje = CNPlataformas.Insertar(tbNombre.Text.Trim(), cbEstado.Text);
                }
                else if (Program.modificar)
                {
                    // Llama al método Actualizar
                    mensaje = CNPlataformas.Actualizar(Convert.ToInt32(tbIdPlataformas.Text), tbNombre.Text.Trim(), cbEstado.Text);
                }

                MessageBox.Show(mensaje, "Mensaje de TreeGames", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Program.nuevo = false;
                Program.modificar = false;
                HabilitaBotones();
                LimpiaObjetos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNombre.Text))
            {
                Program.modificar = true;
                Program.nuevo = false;
                HabilitaBotones();
                tbNombre.Focus();
            }
            else
            {
                MessageBox.Show("Debe buscar una plataforma para poder modificarla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();
            LimpiaObjetos();
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

        #endregion

        private void MantenimientoPlataformas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar este formulario?", "TreeGames",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}