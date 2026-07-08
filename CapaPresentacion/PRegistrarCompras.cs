using CapaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FRegistrarCompra : Form
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

        public void RecuperaDatos()
        {
            txtIdCliente.Text = Program.vidCliente.ToString();

            CNClientes obj = new CNClientes();
            DataTable dt = obj.ObtenerClientes(txtIdCliente.Text);

            if (dt != null && dt.Rows.Count > 0)
                txtCliente.Text = dt.Rows[0]["nombre"].ToString();
        }

        public void RecuperaDatosEmpleado()
        {
            txtIdEmpleado.Text = Program.vidEmpleado.ToString();

            CNEmpleados obj = new CNEmpleados();
            DataTable dt = obj.EmpleadosConsultar(txtIdEmpleado.Text);

            if (dt != null && dt.Rows.Count > 0)
                txtEmpleado.Text = dt.Rows[0]["nombre"].ToString();
        }

        public void RecuperaDatosVideojuego()
        {
            txtIdJuego.Text = Program.vidVideojuego.ToString();

            CNVideojuegos obj = new CNVideojuegos();
            DataTable dt = obj.ObtenerVideojuegos(txtIdJuego.Text);

            if (dt != null && dt.Rows.Count > 0)
            {
                txtJuego.Text = dt.Rows[0]["nombre"].ToString();
                txtPrecio.Text = dt.Rows[0]["precio"].ToString();
            }
        }

        public FRegistrarCompra()
        {
            InitializeComponent();
        }

        private void FRegistrarCompra_Load(object sender, EventArgs e)
        {
            ConfigurarDGV();
            dtpFecha.Value = DateTime.Now;
            CalcularTotales();
            txtIdCompra.ReadOnly = true; 
            txtIdCompra.BackColor = SystemColors.Control;
        }

        // =============================
        // CONFIGURAR GRID
        // =============================
        private void ConfigurarDGV()
        {
            dgvDetalle.Columns.Clear();

            dgvDetalle.Columns.Add("id", "ID");
            dgvDetalle.Columns.Add("nombre", "Videojuego");
            dgvDetalle.Columns.Add("cantidad", "Cantidad");
            dgvDetalle.Columns.Add("precio", "Precio");
            dgvDetalle.Columns.Add("subtotal", "Subtotal");

            dgvDetalle.ReadOnly = true;
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // =============================
        // BUSCAR CLIENTE
        // =============================
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Program.vidCliente = 0;
            FBuscarClientes frm = new FBuscarClientes(this);
            AbrirFormularioNieto(frm);
        }

        // =============================
        // BUSCAR EMPLEADO
        // =============================

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            Program.vidEmpleado = 0;
            FBuscarEmpleado frm = new FBuscarEmpleado(this);
            AbrirFormularioNieto(frm);
        }

        // =============================
        // BUSCAR VIDEOJUEGO
        // =============================

        private void btnBuscarJuego_Click(object sender, EventArgs e)
        {
            Program.vidVideojuego = 0;
            FBuscarVideojuegos frm = new FBuscarVideojuegos(this);
            AbrirFormularioNieto(frm);
        }

        // =============================
        // AGREGAR PRODUCTO
        // =============================
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIdJuego.Text);
                string nombre = txtJuego.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                decimal precio = Convert.ToDecimal(txtPrecio.Text);

                decimal subtotal = cantidad * precio;

                dgvDetalle.Rows.Add(id, nombre, cantidad, precio, subtotal);

                CalcularTotales();
                LimpiarProducto();
            }
            catch
            {
                MessageBox.Show("Datos inválidos");
            }
        }

        private void LimpiarProducto()
        {
            txtIdJuego.Clear();
            txtJuego.Clear();
            txtCantidad.Value = 0;
            txtPrecio.Clear();
        }

        // =============================
        // CALCULAR TOTALES
        // =============================
        private void CalcularTotales()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                if (fila.Cells[4].Value != null)
                    subtotal += Convert.ToDecimal(fila.Cells[4].Value);
            }

            decimal itbis = subtotal * 0.18m;
            decimal total = subtotal + itbis;

            lblSubtotal.Text = subtotal.ToString("0.00");
            lblItbis.Text = itbis.ToString("0.00");
            lblTotal.Text = total.ToString("0.00");
        }

        // =============================
        // GUARDAR COMPRA
        // =============================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetalle.Rows.Count == 0)
                {
                    MessageBox.Show("No hay productos en el detalle.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // --- 1. NUEVA VALIDACIÓN DE INVENTARIO ANTES DE GUARDAR ---
                CNVideojuegos objVideojuego = new CNVideojuegos();

                foreach (DataGridViewRow fila in dgvDetalle.Rows)
                {
                    if (fila.Cells[0].Value != null)
                    {
                        int idJuego = Convert.ToInt32(fila.Cells[0].Value);
                        int cantidadPedida = Convert.ToInt32(fila.Cells[2].Value);
                        string nombreJuego = fila.Cells[1].Value.ToString();

                        // Consultamos el stock actual directamente en la base de datos
                        DataTable dtJuego = objVideojuego.ObtenerVideojuegos(idJuego.ToString());

                        if (dtJuego != null && dtJuego.Rows.Count > 0)
                        {
                            // Asegúrate de que "stock" sea el nombre exacto de la columna en tu base de datos
                            int stockDisponible = Convert.ToInt32(dtJuego.Rows[0]["stock"]);

                            if (cantidadPedida > stockDisponible)
                            {
                                MessageBox.Show($"No puedes completar la venta. El juego '{nombreJuego}' solo tiene {stockDisponible} unidades en stock.",
                                                "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // 🛑 DETIENE EL PROCESO AQUÍ. No se guarda la compra ni los detalles fantasmas.
                            }
                        }
                    }
                }
                // --- FIN DE LA VALIDACIÓN ---


                // 2. SI TODO ESTÁ BIEN, PROCEDEMOS A GUARDAR LA COMPRA
                int idCliente = Convert.ToInt32(txtIdCliente.Text);
                int idEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
                DateTime fecha = dtpFecha.Value;
                decimal total = Convert.ToDecimal(lblTotal.Text);

                CNCompras compra = new CNCompras();
                int idCompra = compra.InsertarCompra(idCliente, idEmpleado, fecha, total);

                // 3. GUARDAMOS LOS DETALLES
                foreach (DataGridViewRow fila in dgvDetalle.Rows)
                {
                    if (fila.Cells[0].Value != null)
                    {
                        int idJuego = Convert.ToInt32(fila.Cells[0].Value);
                        int cantidad = Convert.ToInt32(fila.Cells[2].Value);
                        decimal precio = Convert.ToDecimal(fila.Cells[3].Value);

                        CNDetalleCompra.Insertar(idCompra, idJuego, cantidad, precio);
                    }
                }

                MessageBox.Show("Compra guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =============================
        // LIMPIAR TODO
        // =============================
        private void LimpiarTodo()
        {
            txtIdCompra.Clear();
            txtIdCliente.Clear();
            txtCliente.Clear();
            txtIdEmpleado.Clear();
            txtEmpleado.Clear();

            dgvDetalle.Rows.Clear();

            lblSubtotal.Text = "0.00";
            lblItbis.Text = "0.00";
            lblTotal.Text = "0.00";
        }

        // =============================
        // BOTÓN LIMPIAR
        // =============================
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        // =============================
        // CANCELAR
        // =============================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void T1MantenimientoEmpleado_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        // =============================
        // SALIR
        // =============================
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mensaje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada NO es un número y NO es una tecla de control (como borrar)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Bloquea cualquier otra tecla (letras, símbolos, espacios, signos negativos)
                e.Handled = true;
            }
        }
    }
}