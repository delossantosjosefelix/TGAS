namespace CapaPresentacion
{
    partial class FReporteCompras
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetCompras = new CapaPresentacion.DataSetCompras();
            this.dataSetComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetComprasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprasTableAdapter = new CapaPresentacion.DataSetComprasTableAdapters.ComprasTableAdapter();
            this.dataSetComprasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.videojuegosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videojuegosTableAdapter = new CapaPresentacion.DataSetComprasTableAdapters.VideojuegosTableAdapter();
            this.dataSetComprasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.detalleCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalle_CompraTableAdapter = new CapaPresentacion.DataSetComprasTableAdapters.Detalle_CompraTableAdapter();
            this.dataSetComprasBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.detalleCompraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.videojuegosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComprasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComprasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videojuegosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComprasBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComprasBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videojuegosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCompras";
            reportDataSource1.Value = this.dataSetComprasBindingSource;
            reportDataSource2.Name = "DataSetCompras2";
            reportDataSource2.Value = this.detalleCompraBindingSource1;
            reportDataSource3.Name = "DataSetCompras3";
            reportDataSource3.Value = this.videojuegosBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteCompras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(933, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetCompras
            // 
            this.dataSetCompras.DataSetName = "DataSetCompras";
            this.dataSetCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetComprasBindingSource
            // 
            this.dataSetComprasBindingSource.DataSource = this.dataSetCompras;
            this.dataSetComprasBindingSource.Position = 0;
            // 
            // dataSetComprasBindingSource1
            // 
            this.dataSetComprasBindingSource1.DataSource = this.dataSetCompras;
            this.dataSetComprasBindingSource1.Position = 0;
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "Compras";
            this.comprasBindingSource.DataSource = this.dataSetComprasBindingSource;
            // 
            // comprasTableAdapter
            // 
            this.comprasTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetComprasBindingSource2
            // 
            this.dataSetComprasBindingSource2.DataSource = this.dataSetCompras;
            this.dataSetComprasBindingSource2.Position = 0;
            // 
            // videojuegosBindingSource
            // 
            this.videojuegosBindingSource.DataMember = "Videojuegos";
            this.videojuegosBindingSource.DataSource = this.dataSetCompras;
            // 
            // videojuegosTableAdapter
            // 
            this.videojuegosTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetComprasBindingSource3
            // 
            this.dataSetComprasBindingSource3.DataSource = this.dataSetCompras;
            this.dataSetComprasBindingSource3.Position = 0;
            // 
            // detalleCompraBindingSource
            // 
            this.detalleCompraBindingSource.DataMember = "Detalle_Compra";
            this.detalleCompraBindingSource.DataSource = this.dataSetComprasBindingSource3;
            // 
            // detalle_CompraTableAdapter
            // 
            this.detalle_CompraTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetComprasBindingSource4
            // 
            this.dataSetComprasBindingSource4.DataSource = this.dataSetCompras;
            this.dataSetComprasBindingSource4.Position = 0;
            // 
            // detalleCompraBindingSource1
            // 
            this.detalleCompraBindingSource1.DataMember = "Detalle_Compra";
            this.detalleCompraBindingSource1.DataSource = this.dataSetCompras;
            // 
            // videojuegosBindingSource1
            // 
            this.videojuegosBindingSource1.DataMember = "Videojuegos";
            this.videojuegosBindingSource1.DataSource = this.dataSetCompras;
            // 
            // FReporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FReporteCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.FReporteCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComprasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComprasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videojuegosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComprasBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComprasBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videojuegosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetComprasBindingSource;
        private DataSetCompras dataSetCompras;
        private System.Windows.Forms.BindingSource dataSetComprasBindingSource1;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private DataSetComprasTableAdapters.ComprasTableAdapter comprasTableAdapter;
        private System.Windows.Forms.BindingSource dataSetComprasBindingSource2;
        private System.Windows.Forms.BindingSource videojuegosBindingSource;
        private DataSetComprasTableAdapters.VideojuegosTableAdapter videojuegosTableAdapter;
        private System.Windows.Forms.BindingSource dataSetComprasBindingSource3;
        private System.Windows.Forms.BindingSource detalleCompraBindingSource;
        private DataSetComprasTableAdapters.Detalle_CompraTableAdapter detalle_CompraTableAdapter;
        private System.Windows.Forms.BindingSource detalleCompraBindingSource1;
        private System.Windows.Forms.BindingSource videojuegosBindingSource1;
        private System.Windows.Forms.BindingSource dataSetComprasBindingSource4;
    }
}