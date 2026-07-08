using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FBuscarUsuarios : Form
    {
        private MantenimientoUsuarios _padre;

        public FBuscarUsuarios(MantenimientoUsuarios padre)
        {
            InitializeComponent();
            MostrarDatos();
            _padre = padre;
        }

        public FBuscarUsuarios()
        {
            InitializeComponent();
        }

        CNUsuario obj = new CNUsuario();
        int indice = 0;
        bool _cargando = true; // bandera para evitar que TextChanged dispare antes de tiempo

        private void FBuscarUsuarios_Load(object sender, EventArgs e)
        {
            _cargando = true;
            tbBuscar.Text = "";
            MostrarDatos();
            tbBuscar.Focus();
            _cargando = false;
        }

        private void MostrarDatos()
        {
            try
            {
                string valor = tbBuscar.Text.Trim();
                if (string.IsNullOrWhiteSpace(valor))
                    valor = "";

                DataTable dt = obj.ObtenerUsuarios(valor);

                // Eliminar filas con rol Administrador
                for (int i = dt.Rows.Count - 1; i >= 0; i--)
                {
                    if (dt.Rows[i]["Rol"].ToString() == "Administrador")
                        dt.Rows[i].Delete();
                }
                dt.AcceptChanges();

                dgvDatos.DataSource = dt;
                dgvDatos.AllowUserToAddRows = false;

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvDatos.Columns[0].HeaderText = "ID";
                    dgvDatos.Columns[1].HeaderText = "Nombre";
                    dgvDatos.Columns[2].HeaderText = "Usuario";
                    dgvDatos.Columns[3].HeaderText = "Rol";
                    dgvDatos.Columns[4].HeaderText = "Estado";
                    dgvDatos.Columns[5].HeaderText = "Fecha Registro";
                    dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            if (!_cargando)
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
                Program.vidUsuario = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
                _padre.RecuperaDatos();
            }
            _padre.CerrarFormularioNieto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Program.vidUsuario = 0;
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
    }
}