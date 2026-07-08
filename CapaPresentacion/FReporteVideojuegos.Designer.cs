namespace CapaPresentacion
{
    partial class FReporteVideojuegos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetVideojuegos = new CapaPresentacion.DataSetVideojuegos();
            this.dataSetVideojuegosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVideojuegos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVideojuegosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetVideojuegos";
            reportDataSource1.Value = this.dataSetVideojuegosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteVideojuegos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(933, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetVideojuegos
            // 
            this.dataSetVideojuegos.DataSetName = "DataSetVideojuegos";
            this.dataSetVideojuegos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetVideojuegosBindingSource
            // 
            this.dataSetVideojuegosBindingSource.DataSource = this.dataSetVideojuegos;
            this.dataSetVideojuegosBindingSource.Position = 0;
            // 
            // FReporteVideojuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FReporteVideojuegos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte de Videojuegos";
            this.Load += new System.EventHandler(this.FReporteVideojuegos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVideojuegos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVideojuegosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetVideojuegosBindingSource;
        private DataSetVideojuegos dataSetVideojuegos;
    }
}