using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FConsultaMDCompra : Form
    {
        CNCompras obj = new CNCompras();
        int indice = 0;

        public FConsultaMDCompra()
        {
            InitializeComponent();
            MostrarDatos();
        }

        private void FConsultaMDCompra_Load(object sender, EventArgs e)
        {
            dgvDatos.SelectionChanged += dgvDatos_SelectionChanged;
            dgvDatos.CellClick += dgvDatos_CellClick;
        }

        private void MostrarDatos()
        {
            try
            {
                string valor = tbBuscar.Text.Trim();
                if (string.IsNullOrWhiteSpace(valor))
                    valor = "";

                DataTable dt = obj.ObtenerCompras(valor);
                dgvDatos.DataSource = dt;
                dgvDatos.AllowUserToAddRows = false;

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvDatos.Columns[0].HeaderText = "ID";
                    dgvDatos.Columns[1].HeaderText = "ID Cliente";
                    dgvDatos.Columns[2].HeaderText = "Cliente";
                    dgvDatos.Columns[3].HeaderText = "ID Empleado";
                    dgvDatos.Columns[4].HeaderText = "Empleado";
                    dgvDatos.Columns[5].HeaderText = "Fecha";
                    dgvDatos.Columns[6].HeaderText = "Total";
                    dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos.");
                }

                LCantCompras.Text = Convert.ToString(dgvDatos.RowCount);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarDetalle(string idCompra)
        {
            try
            {
                CNDetalleCompra objDetalle = new CNDetalleCompra();
                DataTable dt = objDetalle.ObtenerDetalleCompra(idCompra);

                dgvDatos2.DataSource = null;
                dgvDatos2.DataSource = dt;
                dgvDatos2.AllowUserToAddRows = false;

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvDatos2.Columns[0].HeaderText = "ID Detalle";
                    dgvDatos2.Columns[1].HeaderText = "ID Compra";
                    dgvDatos2.Columns[2].HeaderText = "ID Videojuego";
                    dgvDatos2.Columns[3].HeaderText = "Videojuego";
                    dgvDatos2.Columns[4].HeaderText = "Cantidad";
                    dgvDatos2.Columns[5].HeaderText = "Precio";
                    dgvDatos2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalle: " + ex.Message);
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null && dgvDatos.CurrentRow.Cells[0].Value != null)
            {
                string idCompra = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                CargarDetalle(idCompra);
            }
        }

        private void dgvDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
                indice = dgvDatos.CurrentRow.Index;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count > 0)
            {
                indice = 0;
                dgvDatos.CurrentCell = dgvDatos.Rows[indice].Cells[dgvDatos.CurrentCell.ColumnIndex];
                dgvDatos.Rows[indice].Selected = true;
                CargarDetalle(dgvDatos.Rows[indice].Cells[0].Value.ToString());
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                dgvDatos.CurrentCell = dgvDatos.Rows[indice].Cells[dgvDatos.CurrentCell.ColumnIndex];
                dgvDatos.Rows[indice].Selected = true;
                CargarDetalle(dgvDatos.Rows[indice].Cells[0].Value.ToString());
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < dgvDatos.Rows.Count - 1)
            {
                indice++;
                dgvDatos.CurrentCell = dgvDatos.Rows[indice].Cells[dgvDatos.CurrentCell.ColumnIndex];
                dgvDatos.Rows[indice].Selected = true;
                CargarDetalle(dgvDatos.Rows[indice].Cells[0].Value.ToString());
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count > 0)
            {
                indice = dgvDatos.Rows.Count - 1;
                dgvDatos.CurrentCell = dgvDatos.Rows[indice].Cells[dgvDatos.CurrentCell.ColumnIndex];
                dgvDatos.Rows[indice].Selected = true;
                CargarDetalle(dgvDatos.Rows[indice].Cells[0].Value.ToString());
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //FReporteCompras frm = new FReporteCompras();
            //frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mensaje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDatos.Rows[e.RowIndex].Cells[0].Value != null)
            {
                string idCompra = dgvDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
                CargarDetalle(idCompra);
            }
        }
    }
}