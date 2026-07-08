using CapaNegocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FReportePlataformas : Form
    {
        public FReportePlataformas()
        {
            InitializeComponent();
        }

        private void FReportePlataformas_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = CNPlataformas.ObtenerPlataforma("");
                ReportDataSource rds = new ReportDataSource("DataSetPlataformas", dt);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReportePlataformas.rdlc";
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