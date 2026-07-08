using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MantenimientoClientes : Form
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
            formularioNieto.Dock = DockStyle.None;      // cambiamos a None
            formularioNieto.Location = new Point(0, 0); // desde la esquina absoluta
            formularioNieto.Size = this.Size;           // mismo tamaño del mantenimiento
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

        public MantenimientoClientes()
        {
            InitializeComponent();
        }

        private void MantenimientoClientes_Load(object sender, EventArgs e)
        {
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
            if (tbIdClientes != null) tbIdClientes.Clear();
            tbCedula.Clear();
            tbNombre.Clear();
            tbCorreo.Clear();
            tbTelefono.Clear();
            tbDireccion.Clear();
            cbEstado.SelectedIndex = 0;
            dtpFechaRegistro.Value = DateTime.Now;
            tbCedula.Focus();
        }

        private void tbCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbCedula_TextChanged(object sender, EventArgs e)
        {
            tbCedula.TextChanged -= tbCedula_TextChanged;

            string soloNumeros = new string(tbCedula.Text.Where(c => char.IsDigit(c)).ToArray());

            if (soloNumeros.Length > 11)
                soloNumeros = soloNumeros.Substring(0, 11);

            string resultado = soloNumeros;
            if (soloNumeros.Length > 3)
                resultado = soloNumeros.Substring(0, 3) + "-" + soloNumeros.Substring(3);
            if (soloNumeros.Length > 10)
                resultado = soloNumeros.Substring(0, 3) + "-" + soloNumeros.Substring(3, 7) + "-" + soloNumeros.Substring(10);

            int cursor = tbCedula.SelectionStart + (resultado.Length - tbCedula.Text.Length);
            tbCedula.Text = resultado;
            tbCedula.SelectionStart = Math.Max(0, Math.Min(cursor, tbCedula.Text.Length));

            tbCedula.TextChanged += tbCedula_TextChanged;
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {
            tbTelefono.TextChanged -= tbTelefono_TextChanged;

            string soloNumeros = new string(tbTelefono.Text.Where(c => char.IsDigit(c)).ToArray());

            if (soloNumeros.Length > 10)
                soloNumeros = soloNumeros.Substring(0, 10);

            string resultado = soloNumeros;
            if (soloNumeros.Length > 3)
                resultado = soloNumeros.Substring(0, 3) + "-" + soloNumeros.Substring(3);
            if (soloNumeros.Length > 6)
                resultado = soloNumeros.Substring(0, 3) + "-" + soloNumeros.Substring(3, 3) + "-" + soloNumeros.Substring(6);

            int cursor = tbTelefono.SelectionStart + (resultado.Length - tbTelefono.Text.Length);
            tbTelefono.Text = resultado;
            tbTelefono.SelectionStart = Math.Max(0, Math.Min(cursor, tbTelefono.Text.Length));

            tbTelefono.TextChanged += tbTelefono_TextChanged;
        }

        private void HabilitaControles(bool valor)
        {
            if (tbIdClientes != null) tbIdClientes.ReadOnly = true;
            tbCedula.Enabled = valor;
            tbNombre.Enabled = valor;
            tbCorreo.Enabled = valor;
            tbTelefono.Enabled = valor;
            tbDireccion.Enabled = valor;
            cbEstado.Enabled = valor;

            Color colorFondo = valor ? Color.White : Color.FromArgb(240, 240, 240);
            tbCedula.BackColor = colorFondo;
            tbNombre.BackColor = colorFondo;
            tbCorreo.BackColor = colorFondo;
            tbTelefono.BackColor = colorFondo;
            tbDireccion.BackColor = colorFondo;
            cbEstado.BackColor = colorFondo;
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
            CNClientes obj = new CNClientes();
            DataTable dt = obj.ObtenerClientes(Program.vidCliente.ToString());

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                tbIdClientes.Text = row["id_cliente"].ToString();
                tbCedula.Text = row["cedula"].ToString();
                tbNombre.Text = row["nombre"].ToString();
                tbCorreo.Text = row["correo"].ToString();
                tbTelefono.Text = row["telefono"].ToString();
                tbDireccion.Text = row["direccion"].ToString();
                cbEstado.Text = row["Estado"].ToString();
                dtpFechaRegistro.Value = Convert.ToDateTime(row["fecha_registro"]);
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            LimpiaObjetos();
            Program.nuevo = true;
            Program.modificar = false;
            HabilitaBotones();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCedula.Text))
            {
                MessageBox.Show("Debe indicar la cédula del Cliente!");
                tbCedula.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                MessageBox.Show("Debe indicar el nombre del Cliente!");
                tbNombre.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(tbCorreo.Text))
            {
                MessageBox.Show("Debe indicar el Correo!");
                tbCorreo.Focus();
                return;
            }

            try
            {
                if (Program.nuevo)
                {
                    mensaje = CNClientes.Insertar(tbCedula.Text, tbNombre.Text, tbCorreo.Text, tbTelefono.Text, tbDireccion.Text, cbEstado.Text);
                }
                else if (Program.modificar)
                {
                    mensaje = CNClientes.Actualizar(Convert.ToInt32(tbIdClientes.Text), tbCedula.Text, tbNombre.Text, tbCorreo.Text, tbTelefono.Text, tbDireccion.Text, cbEstado.Text);
                }

                MessageBox.Show(mensaje, "Mensaje de TreeGames", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Program.nuevo = false;
                Program.modificar = false;
                HabilitaBotones();
                LimpiaObjetos();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("cédula ya existe"))
                    MessageBox.Show("No se puede guardar: La cédula ya está registrada en el sistema.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (ex.Message.Contains("correo ya existe"))
                    MessageBox.Show("No se puede guardar: El correo ya está registrado en el sistema.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNombre.Text))
            {
                Program.modificar = true;
                Program.nuevo = false;
                HabilitaBotones();
                tbCedula.Focus();
            }
            else
            {
                MessageBox.Show("Debe buscar un Cliente para poder modificarlo.");
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
            FBuscarClientes frm = new FBuscarClientes();
            frm.ShowDialog();

            if (Program.vidCliente > 0)
            {
                RecuperaDatos();
            }
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

        private void MantenimientoClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar este formulario?", "TreeGames",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void T1MantenimientoEmpleados_Click(object sender, EventArgs e)
        {
        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Contraseña_Click(object sender, EventArgs e)
        {
        }

        private void IdEmpleado_Click(object sender, EventArgs e)
        {
        }

        private void BBuscar_Click_1(object sender, EventArgs e)
        {
            Program.vidCliente = 0;

            FBuscarClientes frm = new FBuscarClientes(this); // pasa referencia del padre
            AbrirFormularioNieto(frm);
        }
    }
    
}