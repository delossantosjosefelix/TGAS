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
    public partial class MantenimientoCategorias : Form
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

        // 1. Agregar estos campos al inicio de la clase, debajo de: public string mensaje = "";

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
            Program.vidCategoria = 0;
            FBuscarCategoria frm = new FBuscarCategoria(this);
            AbrirFormularioNieto(frm);
        }

        public MantenimientoCategorias()
        {
            InitializeComponent();
        }

        // Evento Load: Configuración inicial al abrir el formulario
        private void MantenimientoCategorias_Load(object sender, EventArgs e)
        {
            // Llenamos el combo de estado
            cbEstado.Items.Clear();
            cbEstado.Items.Add("Activo");
            cbEstado.Items.Add("Inactivo");
            cbEstado.SelectedIndex = 0;

            // Inicializamos las variables de control del Programa
            Program.nuevo = false;
            Program.modificar = false;

            // ¡ESTA ES LA LÍNEA QUE FALTABA! 
            // Es la que aplica las reglas de los botones apenas abres la ventana.
            HabilitaBotones();
        }

        private void HabilitaBotones()
        {
            if (Program.nuevo || Program.modificar)
            {
                // Estado: El usuario está escribiendo datos (Agregando o Editando)
                HabilitaControles(true); // Se abren los campos de texto

                BAgregar.Enabled = false;
                BGuardar.Enabled = true;   // Puede guardar
                BEditar.Enabled = false;
                BCancelar.Enabled = true;  // Puede cancelar
                BBuscar.Enabled = false;   // No debe buscar mientras edita o agrega
            }
            else
            {
                // Estado: Reposo (Formulario recién abierto o después de cancelar/guardar)
                HabilitaControles(false); // Se bloquean los campos de texto

                BAgregar.Enabled = true;   // Puede agregar
                BGuardar.Enabled = false;
                BEditar.Enabled = true;    // Puede editar
                BCancelar.Enabled = false;
                BBuscar.Enabled = true;    // Puede buscar
            }

            // El botón salir siempre debe estar habilitado, así que no necesitamos meterlo en el if
            BSalir.Enabled = true;
        }

        #region Metodos Propios (Logica de Interfaz)

        public void LimpiaObjetos()
        {
            if (tbIdCategorias != null) tbIdCategorias.Clear();
            tbNombre.Clear();
            cbEstado.SelectedIndex = 0;
            tbNombre.Focus();
        }

        private void HabilitaControles(bool valor)
        {
            // El ID siempre es ReadOnly para que el usuario no lo cambie manualmente
            if (tbIdCategorias != null) tbIdCategorias.ReadOnly = true;

            tbNombre.Enabled = valor;
            cbEstado.Enabled = valor;

            // Feedback visual: cambia el color si está deshabilitado
            Color colorFondo = valor ? Color.White : Color.FromArgb(240, 240, 240);
            tbNombre.BackColor = colorFondo;
            cbEstado.BackColor = colorFondo;
        }

        public void RecuperaDatos()
        {
            CNCategoria obj = new CNCategoria();
            // Buscamos la categoría usando el ID guardado en la variable global Program
            DataTable dt = obj.ObtenerCategoria(Program.vidCategoria.ToString());

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                tbIdCategorias.Text = row["Id_Categoria"].ToString();
                tbNombre.Text = row["Nombre"].ToString();
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
                MessageBox.Show("¡Debe indicar el nombre de la categoría!", "TreeGames", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNombre.Focus();
                return;
            }

            try
            {
                if (Program.nuevo)
                {
                    // Insertar: El ID va en 0 porque es Identity en la base de datos
                    mensaje = CNCategoria.Insertar(0, tbNombre.Text.Trim(), cbEstado.Text);
                }
                else if (Program.modificar)
                {
                    // Actualizar: Usamos el ID que está en el TextBox
                    mensaje = CNCategoria.Actualizar(Convert.ToInt32(tbIdCategorias.Text), tbNombre.Text.Trim(), cbEstado.Text);
                }

                MessageBox.Show(mensaje, "Mensaje de TreeGames", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Program.nuevo = false;
                Program.modificar = false;
                HabilitaBotones();
                LimpiaObjetos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar los datos: " + ex.Message);
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
                MessageBox.Show("Debe buscar una categoría para poder modificarla.");
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

        private void MantenimientoCategorias_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar este formulario?", "TreeGames",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}