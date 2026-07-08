using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FBuscarCompras : Form
    {
        CNCompras obj = new CNCompras();
        int indice = 0;

        public FBuscarCompras()
        {
            InitializeComponent();
        }

        private void FBuscarCompras_Load(object sender, EventArgs e)
        {
            tbBuscar.Text = "";
            MostrarDatos();
            
            tbBuscar.Focus();
            dgvDatos.SelectionChanged += dgvDatos_SelectionChanged;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarDetalle(string valor)
        {
            try
            {
                CNDetalleCompra obj = new CNDetalleCompra();
                DataTable dt = obj.ObtenerDetalleCompra(valor);

                dgvDatos2.DataSource = null; // limpia antes
                dgvDatos2.DataSource = dt;

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
        private void btnBuscar_Click(object sender, EventArgs e)
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
                Program.modificar = true;
                Program.vidCompra = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Program.modificar = false;
            this.Close();
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btnAceptar_Click(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}