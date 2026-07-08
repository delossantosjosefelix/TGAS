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
    public partial class FReporteEmpleados : Form
    {
        public FReporteEmpleados()
        {
            InitializeComponent();
        }

        private void FReporteEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                CNEmpleados obj = new CNEmpleados();
                DataTable dt = obj.EmpleadosConsultar("");

                ReportDataSource rds = new ReportDataSource("DataSetEmpleados", dt);

                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteEmpleados.rdlc";
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