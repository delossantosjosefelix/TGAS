using CapaNegocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FReporteVideojuegos : Form
    {
        public FReporteVideojuegos()
        {
            InitializeComponent();
        }

        private void FReporteVideojuegos_Load(object sender, EventArgs e)
        {
            try
            {
                CNVideojuegos obj = new CNVideojuegos();
                DataTable dt = obj.ObtenerVideojuegos("");

                ReportDataSource rds = new ReportDataSource("DataSetVideojuegos", dt);

                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteVideojuegos.rdlc";
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
