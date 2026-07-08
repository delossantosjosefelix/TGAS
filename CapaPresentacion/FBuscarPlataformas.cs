using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FBuscarPlataformas : Form
    {
        private MantenimientoPlataformas _padre;

        public FBuscarPlataformas(MantenimientoPlataformas padre)
        {
            InitializeComponent();
            _padre = padre;
        }

        public FBuscarPlataformas()
        {
            InitializeComponent();
        }

        int indice = 0;

        private void FBuscarPlataformas_Load(object sender, EventArgs e)
        {
            tbBuscar.Text = "";
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void MostrarDatos()
        {
            try
            {
                string valor = tbBuscar.Text.Trim();
                if (string.IsNullOrWhiteSpace(valor))
                    valor = "";

                DataTable dt = CNPlataformas.ObtenerPlataforma(valor);
                dgvDatos.DataSource = dt;
                dgvDatos.AllowUserToAddRows = false; // Evita la fila vacía extra

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvDatos.Columns[0].HeaderText = "ID";
                    dgvDatos.Columns[1].HeaderText = "Nombre";
                    dgvDatos.Columns[2].HeaderText = "Estado";
                    dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar datos: " + ex.Message);
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
                Program.vidPlataforma = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
                _padre.RecuperaDatos();
            }
            _padre.CerrarFormularioNieto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Program.vidPlataforma = 0;
            _padre.CerrarFormularioNieto();
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btnAceptar_Click(sender, e);
        }

        // ── Botones de navegación ──────────────────────────────────────

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

        private void T1BuscarEmpleados_Click(object sender, EventArgs e)
        {

        }
    }
}