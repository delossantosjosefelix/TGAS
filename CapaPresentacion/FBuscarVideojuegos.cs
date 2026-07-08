using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FBuscarVideojuegos : Form
    {
        private MantenimientoVideojuegos _padre;
        private FRegistrarCompra _padreCompra;

        public FBuscarVideojuegos(MantenimientoVideojuegos padre)
        {
            InitializeComponent();
            _padre = padre;
        }

        public FBuscarVideojuegos(FRegistrarCompra padre)
        {
            InitializeComponent();
            _padreCompra = padre;
        }

        public FBuscarVideojuegos()
        {
            InitializeComponent();
        }

        CNVideojuegos obj = new CNVideojuegos();
        int indice = 0;

        private void FBuscarVideojuegos_Load(object sender, EventArgs e)
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

                DataTable dt = obj.ObtenerVideojuegos(valor);
                dgvDatos.DataSource = dt;
                dgvDatos.AllowUserToAddRows = false;

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvDatos.Columns[0].HeaderText = "ID";
                    dgvDatos.Columns[1].HeaderText = "Nombre";
                    dgvDatos.Columns[2].HeaderText = "Descripción";
                    dgvDatos.Columns[3].HeaderText = "Precio";
                    dgvDatos.Columns[4].HeaderText = "Stock";
                    dgvDatos.Columns[5].HeaderText = "Fecha";
                    dgvDatos.Columns[6].HeaderText = "ID Categoría";
                    dgvDatos.Columns[7].HeaderText = "Categoría";
                    dgvDatos.Columns[8].HeaderText = "ID Plataforma";
                    dgvDatos.Columns[9].HeaderText = "Plataforma";
                    dgvDatos.Columns[10].HeaderText = "Estado";
                    dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar datos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Program.vidVideojuego = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);

                if (_padre != null)
                    _padre.RecuperaDatos();
                else if (_padreCompra != null)
                    _padreCompra.RecuperaDatosVideojuego();
            }

            if (_padre != null)
                _padre.CerrarFormularioNieto();
            else if (_padreCompra != null)
                _padreCompra.CerrarFormularioNieto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Program.vidVideojuego = 0;

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