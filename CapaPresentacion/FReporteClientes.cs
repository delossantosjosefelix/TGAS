using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FReporteClientes : Form
    {
        public FReporteClientes()
        {
            InitializeComponent();
        }

        private void FReporteClientes_Load(object sender, EventArgs e)
        {
            try
            {
                CNClientes obj = new CNClientes();
                DataTable dt = obj.ObtenerClientes("");

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);

                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteClientes.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message);
            }
        }
    }
}