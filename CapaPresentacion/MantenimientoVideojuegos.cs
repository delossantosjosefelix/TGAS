using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Para poder utilizar las instrucciones de SQL
using System.Data.SqlClient;
// Para acceder a la capa de negocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MantenimientoVideojuegos : Form
    {
        // b) En la declaración de la clase del formulario agregamos las variables globales
        public string valorparametro = "", mensaje = "";

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Activa el estilo para dibujo suave (Anti-Flicker)
                return cp;
            }
        }

        // 1. Agregar debajo de: public string valorparametro = "", mensaje = "";

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
            Program.vidVideojuego = 0;
            FBuscarVideojuegos frm = new FBuscarVideojuegos(this);
            AbrirFormularioNieto(frm);
        }

        public MantenimientoVideojuegos()
        {
            InitializeComponent();
        }

        // j) Hacer doble clic en un lugar vacío del formulario para generar el evento Load
        private void MantenimientoVideojuegos_Load(object sender, EventArgs e)
        {
            // Cargamos los combos desde la base de datos al iniciar el formulario
            CargarCategorias();
            CargarPlataformas();

            cbEstado.Items.Clear(); // Limpiamos por si acaso
            cbEstado.Items.Add("Activo");
            cbEstado.Items.Add("Inactivo");
            cbEstado.SelectedIndex = 0; // Ahora sí funcionará porque ya hay items

            // Establecemos la fecha de hoy como valor por defecto
            dtpFechaLanzamiento.Value = DateTime.Today;

            Program.nuevo = false;     // Valores de las variables globales nuevo y modificar
            Program.modificar = false;
            HabilitaBotones();         // Se habilitarán los objetos y los botones necesarios.
        }

        // Método para cargar el ComboBox de Categorías desde la base de datos
        private void CargarCategorias()
        {
            try
            {
                CNCategoria objCN = new CNCategoria();
                DataTable dt = objCN.ObtenerCategoria("");
                cbCategoria.DataSource = null;
                cbCategoria.DataSource = dt;
                cbCategoria.DisplayMember = "nombre";       // ← verifica que coincida con tu SP
                cbCategoria.ValueMember = "id_categoria"; // ← igual
                if (cbCategoria.Items.Count > 0) cbCategoria.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        // Método para cargar el ComboBox de Plataformas desde la base de datos
        private void CargarPlataformas()
        {
            try
            {
                DataTable dt = CNPlataformas.ObtenerPlataforma("");
                cbPlataforma.DataSource = null;
                cbPlataforma.DataSource = dt;
                cbPlataforma.DisplayMember = "nombre";        // ← verifica que coincida con tu SP
                cbPlataforma.ValueMember = "id_plataforma"; // ← igual
                if (cbPlataforma.Items.Count > 0) cbPlataforma.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar plataformas: " + ex.Message);
            }
        }

        // e) Método propio para limpiar los objetos del formulario.
        public void LimpiaObjetos()
        {
            // Limpiamos el ID para que se limpie al buscar
            if (tbIdVideojuego != null) tbIdVideojuego.Clear();
            tbNombre.Clear();
            tbDescripcion.Clear();
            tbPrecio.Clear();
            tbStock.Value = 0;
            dtpFechaLanzamiento.Value = DateTime.Today; // Restablece la fecha al día de hoy
            if (cbCategoria.Items.Count > 0) cbCategoria.SelectedIndex = 0;
            if (cbPlataforma.Items.Count > 0) cbPlataforma.SelectedIndex = 0;
            if (cbEstado.Items.Count > 0) cbEstado.SelectedIndex = 0; // Establece el valor por defecto del Combobox
        }

        // f) Habilita/inhabilita los objetos del formulario según lo indicado por el parámetro valor
        private void HabilitaControles(bool valor)
        {
            // Protegemos siempre el ID para que el usuario no lo modifique
            if (tbIdVideojuego != null) tbIdVideojuego.ReadOnly = true;
            tbNombre.Enabled = valor;
            tbDescripcion.Enabled = valor;
            tbPrecio.Enabled = valor;
            tbStock.Enabled = valor;
            dtpFechaLanzamiento.Enabled = valor;
            cbCategoria.Enabled = valor;
            cbPlataforma.Enabled = valor;
            cbEstado.Enabled = valor;
        }

        // g) Habilita los botones según el valor que tengan las variables globales nuevo y modificar
        private void HabilitaBotones()
        {
            if (Program.nuevo || Program.modificar)
            {
                HabilitaControles(true); // Llamada al método para habilitar los objetos
                BAgregar.Enabled = false;
                BGuardar.Enabled = true;
                BEditar.Enabled = false;
                BCancelar.Enabled = true;
            }
            else
            {
                HabilitaControles(false); // Llamada al método para inhabilitar los objetos
                BAgregar.Enabled = true;
                BGuardar.Enabled = false;
                BEditar.Enabled = true;
                BCancelar.Enabled = false;
            }
        }

        // h) Programación del botón Agregar (Nuevo).
        private void BAgregar_Click(object sender, EventArgs e)
        {
            LimpiaObjetos();
            // Se especifica que se agregará un nuevo registro
            Program.nuevo = true;
            Program.modificar = false;
            HabilitaBotones(); // Se habilitan solo aquellos botones que sean necesarios
            tbNombre.Focus();  // Coloca el cursor en el TextBox indicado
        }

        // i) Programación del botón Guardar.
        private void BGuardar_Click(object sender, EventArgs e)
        {
            // Validamos los datos requeridos antes de Insertar o Actualizar
            if (tbNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del Videojuego!");
                tbNombre.Focus();
                return;
            }

            decimal precio;
            if (!decimal.TryParse(tbPrecio.Text, out precio))
            {
                MessageBox.Show("El precio debe ser un número válido!");
                tbPrecio.Focus();
                return;
            }

            int stock;
            if (!int.TryParse(tbStock.Text, out stock))
            {
                MessageBox.Show("El stock debe ser un número entero válido!");
                tbStock.Focus();
                return;
            }

            int idCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
            int idPlataforma = Convert.ToInt32(cbPlataforma.SelectedValue);

            if (Program.nuevo) // Si la variable nuevo llega con valor true se van a Insertar nuevos datos
            {
                // Se llama al método Insertar de la clase CNVideojuegos de la capa de negocio
                mensaje = CNVideojuegos.Insertar(
                    tbNombre.Text,
                    tbDescripcion.Text,
                    precio,
                    stock,
                    dtpFechaLanzamiento.Value,
                    idCategoria,
                    idPlataforma,
                    cbEstado.Text);
            }
            else
            {
                // Se llama al método Actualizar de la clase CNVideojuegos de la capa de negocio
                mensaje = CNVideojuegos.Actualizar(
                    Program.vidVideojuego,
                    tbNombre.Text,
                    tbDescripcion.Text,
                    precio,
                    stock,
                    dtpFechaLanzamiento.Value,
                    idCategoria,
                    idPlataforma,
                    cbEstado.Text);
            }

            // Se muestra el mensaje devuelto por la capa de negocio respecto al resultado de la operación
            MessageBox.Show(mensaje, "Mensaje de TreeGames", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Se prepara todo para la próxima operación
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones(); // Habilita los objetos y botones correspondientes
            LimpiaObjetos();   // Llama al método LimpiaObjetos
        }

        // k) Programación del botón Cancelar.
        private void BCancelar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones(); // Habilita los objetos y botones correspondientes
            LimpiaObjetos();   // Llama al método LimpiaObjetos
        }

        // l) Programación del botón Editar.
        private void BEditar_Click(object sender, EventArgs e)
        {
            // Si no ha seleccionado un registro no se puede modificar
            if (!tbNombre.Text.Equals(""))
            {
                Program.modificar = true; // El formulario se prepara para modificar datos
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un Videojuego para poder Modificar sus datos!");
            }
        }

        // Método para recuperar los datos de la base de datos
        public void RecuperaDatos()
        {
            string vparametro = Program.vidVideojuego.ToString();
            CNVideojuegos objVideojuegos = new CNVideojuegos();
            DataTable dt = new DataTable();

            // Solo le mandamos EL VALOR que queremos buscar
            dt = objVideojuegos.ObtenerVideojuegos(vparametro);

            foreach (DataRow row in dt.Rows)
            {
                tbIdVideojuego.Text = row["id_videojuego"].ToString();
                tbNombre.Text = row["nombre"].ToString();
                tbDescripcion.Text = row["descripcion"].ToString();
                tbPrecio.Text = row["precio"].ToString();
                tbStock.Text = row["stock"].ToString();
                cbCategoria.SelectedValue = row["id_categoria"];
                cbPlataforma.SelectedValue = row["id_plataforma"];
                cbEstado.Text = row["Estado"].ToString();
                if (row["fecha_lanzamiento"] != DBNull.Value)
                    dtpFechaLanzamiento.Value = Convert.ToDateTime(row["fecha_lanzamiento"]);
                else
                    dtpFechaLanzamiento.Value = DateTime.Today;
            }
        }

        private void tbStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada NO es un número y NO es una tecla de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni retroceso, "manejamos" el evento para que no se escriba nada
                e.Handled = true;
            }
        }

        // m) Hacer que al presionar la tecla Enter se mueva al siguiente objeto hábil.
        private void MantenimientoVideojuegos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        // d) Programación del botón Salir.
        private void BSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mensaje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // ── EVENTOS VACÍOS (requeridos por el Designer) ───────────────────────
        private void PanelTituloVideojuegos_Paint(object sender, PaintEventArgs e) { }
        private void tbNombre_TextChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}