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
    public partial class FBuscarClientes : Form
    {
        private MantenimientoClientes _padre;
        private FRegistrarCompra _padreCompra;

        public FBuscarClientes(MantenimientoClientes padre)
        {
            InitializeComponent();
            _padre = padre;
        }

        public FBuscarClientes(FRegistrarCompra padre) // <-- agregar este constructor
        {
            InitializeComponent();
            _padreCompra = padre;
        }

        CNClientes obj = new CNClientes();
        int indice = 0;

        public FBuscarClientes()
        {
            InitializeComponent();
        }

        private void FBuscarClientes_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void MostrarDatos()
        {
            try
            {
                string valor = tbBuscar.Text.Trim();
                if (string.IsNullOrEmpty(valor))
                    valor = "";

                DataTable dt = obj.ObtenerClientes(valor);
                dgvDatos.DataSource = dt;
                dgvDatos.AllowUserToAddRows = false; // Evita la fila vacía extra

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvDatos.Columns[0].HeaderText = "ID";
                    dgvDatos.Columns[1].HeaderText = "Cédula";
                    dgvDatos.Columns[2].HeaderText = "Nombre";
                    dgvDatos.Columns[3].HeaderText = "Correo";
                    dgvDatos.Columns[4].HeaderText = "Teléfono";
                    dgvDatos.Columns[5].HeaderText = "Dirección";
                    dgvDatos.Columns[6].HeaderText = "Fecha";
                    dgvDatos.Columns[7].HeaderText = "Estado";
                    dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void dgvDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
                indice = dgvDatos.CurrentRow.Index;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                Program.vidCliente = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);

                if (_padre != null)
                    _padre.RecuperaDatos();
                else if (_padreCompra != null)
                    _padreCompra.RecuperaDatos();
            }

            if (_padre != null)
                _padre.CerrarFormularioNieto();
            else if (_padreCompra != null)
                _padreCompra.CerrarFormularioNieto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Program.vidCliente = 0;

            if (_padre != null)
                _padre.CerrarFormularioNieto();
            else if (_padreCompra != null)
                _padreCompra.CerrarFormularioNieto();
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btnAceptar_Click(sender, e);
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbBuscar_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count > 0)
            {
                indice = 0;
                dgvDatos.CurrentCell = dgvDatos.Rows[indice].Cells[dgvDatos.CurrentCell.ColumnIndex];
                dgvDatos.Rows[indice].Selected = true;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                dgvDatos.CurrentCell = dgvDatos.Rows[indice].Cells[dgvDatos.CurrentCell.ColumnIndex];
                dgvDatos.Rows[indice].Selected = true;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < dgvDatos.Rows.Count - 1)
            {
                indice++;
                dgvDatos.CurrentCell = dgvDatos.Rows[indice].Cells[dgvDatos.CurrentCell.ColumnIndex];
                dgvDatos.Rows[indice].Selected = true;
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count > 0)
            {
                indice = dgvDatos.Rows.Count - 1;
                dgvDatos.CurrentCell = dgvDatos.Rows[indice].Cells[dgvDatos.CurrentCell.ColumnIndex];
                dgvDatos.Rows[indice].Selected = true;
            }
        }
    }
}