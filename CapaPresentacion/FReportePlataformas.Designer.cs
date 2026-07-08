namespace CapaPresentacion
{
    partial class FReportePlataformas
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
            this.dataSetPlataformasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPlataformas = new CapaPresentacion.DataSetPlataformas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPlataformasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPlataformas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetPlataformasBindingSource
            // 
            this.dataSetPlataformasBindingSource.DataSource = this.dataSetPlataformas;
            this.dataSetPlataformasBindingSource.Position = 0;
            // 
            // dataSetPlataformas
            // 
            this.dataSetPlataformas.DataSetName = "DataSetPlataformas";
            this.dataSetPlataformas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPlataformas";
            reportDataSource1.Value = this.dataSetPlataformasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReportePlataformas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(933, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // FReportePlataformas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FReportePlataformas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte de Plataformas";
            this.Load += new System.EventHandler(this.FReportePlataformas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPlataformasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPlataformas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetPlataformasBindingSource;
        private DataSetPlataformas dataSetPlataformas;
    }
}