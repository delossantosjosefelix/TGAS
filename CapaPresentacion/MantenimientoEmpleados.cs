using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MantenimientoEmpleados : Form
    {
        public string valorparametro = "", mensaje = "";
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        // Agregar estos campos al inicio de la clase, junto a las variables existentes:

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

        // Reemplazar el BBuscar_Click existente por este:
        private void BBuscar_Click(object sender, EventArgs e)
        {
            Program.vidEmpleado = 0;
            FBuscarEmpleado frm = new FBuscarEmpleado(this);
            AbrirFormularioNieto(frm);
        }

        public MantenimientoEmpleados()
        {
            InitializeComponent();
        }

        private void MantenimientoEmpleados_Load(object sender, EventArgs e)
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
            if (tbIdEmpleados != null) tbIdEmpleados.Clear();
            tbCedula.Clear();
            tbNombre.Clear();
            tbCorreo.Clear();
            tbTelefono.Clear();
            cbCargo.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
            dtpFechaContratacion.Value = DateTime.Now;
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
            if (tbIdEmpleados != null) tbIdEmpleados.ReadOnly = true;
            tbCedula.Enabled = valor;
            tbNombre.Enabled = valor;
            tbCorreo.Enabled = valor;
            tbTelefono.Enabled = valor;
            cbCargo.Enabled = valor;
            cbEstado.Enabled = valor;
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
            }
            else
            {
                HabilitaControles(false);
                BAgregar.Enabled = true;
                BGuardar.Enabled = false;
                BEditar.Enabled = true;
                BCancelar.Enabled = false;
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            LimpiaObjetos();
            Program.nuevo = true;
            Program.modificar = false;
            HabilitaBotones();
            tbCedula.Focus();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (tbCedula.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar la cédula del Empleado!");
                tbCedula.Focus();
            }
            else if (tbNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del Empleado!");
                tbNombre.Focus();
            }
            else if (tbCorreo.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el Correo!");
                tbCorreo.Focus();
            }
            else
            {
                try
                {
                    if (Program.nuevo)
                        mensaje = CNEmpleados.Insertar(tbCedula.Text, tbNombre.Text, tbCorreo.Text, tbTelefono.Text, cbCargo.Text, cbEstado.Text);
                    else if (Program.modificar)
                        mensaje = CNEmpleados.Actualizar(Convert.ToInt32(tbIdEmpleados.Text), tbCedula.Text, tbNombre.Text, tbCorreo.Text, tbTelefono.Text, cbCargo.Text, cbEstado.Text);

                    MessageBox.Show(mensaje, "Mensaje de TreeGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("cédula ya existe en la tabla Clientes"))
                        MessageBox.Show("No se puede guardar: La cédula ya existe en la tabla Clientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (ex.Message.Contains("correo ya existe en la tabla Clientes"))
                        MessageBox.Show("No se puede guardar: El correo ya existe en la tabla Clientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(mensaje, "Mensaje de TreeGames", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Program.nuevo = false;
                Program.modificar = false;
                HabilitaBotones();
                LimpiaObjetos();
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();
            LimpiaObjetos();
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            if (!tbNombre.Text.Equals(""))
            {
                Program.modificar = true;
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un Empleado para poder Modificar sus datos!");
            }
        }

        public void RecuperaDatos()
        {
            string vparametro = Program.vidEmpleado.ToString();
            CNEmpleados objEmpleados = new CNEmpleados();
            DataTable dt = objEmpleados.EmpleadosConsultar(vparametro);

            foreach (DataRow row in dt.Rows)
            {
                tbIdEmpleados.Text = row["id_empleado"].ToString();
                tbCedula.Text = row["cedula"].ToString();
                tbNombre.Text = row["nombre"].ToString();
                tbCorreo.Text = row["correo"].ToString();
                tbTelefono.Text = row["telefono"].ToString();
                cbCargo.Text = row["cargo"].ToString();
                cbEstado.Text = row["Estado"].ToString();
                dtpFechaContratacion.Value = Convert.ToDateTime(row["fecha_contratacion"]);
            }
        }

        private void MantenimientoEmpleados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
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

        private void PanelTituloEmpleados_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Nombre_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void T1MantenimientoEmpleado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MantenimientoEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hará salir del formulario! \n Seguro que desea hacerlo?",
                "Mensaje de TreeGames",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}