namespace CapaPresentacion
{
    partial class FReporteEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataSetEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEmpleados = new CapaPresentacion.DataSetEmpleados();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetEmpleadosBindingSource
            // 
            this.dataSetEmpleadosBindingSource.DataSource = this.dataSetEmpleados;
            this.dataSetEmpleadosBindingSource.Position = 0;
            // 
            // dataSetEmpleados
            // 
            this.dataSetEmpleados.DataSetName = "DataSetEmpleados";
            this.dataSetEmpleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetEmpleados";
            reportDataSource1.Value = this.dataSetEmpleadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteEmpleados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(933, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // FReporteEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FReporteEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte de Empleados";
            this.Load += new System.EventHandler(this.FReporteEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetEmpleadosBindingSource;
        private DataSetEmpleados dataSetEmpleados;
    }
}