namespace CapaPresentacion
{
    partial class FReporteCategorias
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataSetCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCategorias = new CapaPresentacion.DataSetCategorias();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetCategoriasBindingSource
            // 
            this.dataSetCategoriasBindingSource.DataSource = this.dataSetCategorias;
            this.dataSetCategoriasBindingSource.Position = 0;
            // 
            // dataSetCategorias
            // 
            this.dataSetCategorias.DataSetName = "DataSetCategorias";
            this.dataSetCategorias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetCategorias";
            reportDataSource2.Value = this.dataSetCategoriasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteCategorias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(933, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // FReporteCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FReporteCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte de  Categorías";
            this.Load += new System.EventHandler(this.FReporteCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetCategoriasBindingSource;
        private DataSetCategorias dataSetCategorias;
    }
}