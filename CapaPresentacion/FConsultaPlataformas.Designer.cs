namespace CapaPresentacion
{
    partial class FConsultaPlataformas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConsultaPlataformas));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelBotonesInferiores = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CantPlataformas = new System.Windows.Forms.Label();
            this.LCantPlataforma = new System.Windows.Forms.Label();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.PanelBotonesSuperiores = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.T1BuscarEmpleados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.PanelBotonesInferiores.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelBotonesSuperiores.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 100);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(1099, 578);
            this.dgvDatos.TabIndex = 26;
            this.dgvDatos.CurrentCellChanged += new System.EventHandler(this.dgvDatos_CurrentCellChanged);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.Location = new System.Drawing.Point(411, 9);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(431, 32);
            this.tbBuscar.TabIndex = 7;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese el Dato a Consultar:";
            // 
            // PanelBotonesInferiores
            // 
            this.PanelBotonesInferiores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.PanelBotonesInferiores.Controls.Add(this.panel1);
            this.PanelBotonesInferiores.Controls.Add(this.btnUltimo);
            this.PanelBotonesInferiores.Controls.Add(this.btnSiguiente);
            this.PanelBotonesInferiores.Controls.Add(this.btnAnterior);
            this.PanelBotonesInferiores.Controls.Add(this.btnPrimero);
            this.PanelBotonesInferiores.Controls.Add(this.btnImprimir);
            this.PanelBotonesInferiores.Controls.Add(this.btnSalir);
            this.PanelBotonesInferiores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBotonesInferiores.Location = new System.Drawing.Point(0, 678);
            this.PanelBotonesInferiores.Name = "PanelBotonesInferiores";
            this.PanelBotonesInferiores.Size = new System.Drawing.Size(1099, 50);
            this.PanelBotonesInferiores.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CantPlataformas);
            this.panel1.Controls.Add(this.LCantPlataforma);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(520, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 35);
            this.panel1.TabIndex = 24;
            // 
            // CantPlataformas
            // 
            this.CantPlataformas.AutoSize = true;
            this.CantPlataformas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantPlataformas.ForeColor = System.Drawing.Color.White;
            this.CantPlataformas.Location = new System.Drawing.Point(2, 5);
            this.CantPlataformas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CantPlataformas.Name = "CantPlataformas";
            this.CantPlataformas.Size = new System.Drawing.Size(223, 22);
            this.CantPlataformas.TabIndex = 22;
            this.CantPlataformas.Text = "Cantidad de Plataformas:";
            // 
            // LCantPlataforma
            // 
            this.LCantPlataforma.AutoSize = true;
            this.LCantPlataforma.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantPlataforma.ForeColor = System.Drawing.Color.White;
            this.LCantPlataforma.Location = new System.Drawing.Point(225, 5);
            this.LCantPlataforma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCantPlataforma.Name = "LCantPlataforma";
            this.LCantPlataforma.Size = new System.Drawing.Size(0, 22);
            this.LCantPlataforma.TabIndex = 23;
            // 
            // btnUltimo
            // 
            this.btnUltimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUltimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.btnUltimo.FlatAppearance.BorderSize = 0;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.ForeColor = System.Drawing.Color.Transparent;
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.Location = new System.Drawing.Point(354, 6);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnUltimo.Size = new System.Drawing.Size(108, 35);
            this.btnUltimo.TabIndex = 21;
            this.btnUltimo.Text = "Ultimo";
            this.btnUltimo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(240, 6);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSiguiente.Size = new System.Drawing.Size(108, 35);
            this.btnSiguiente.TabIndex = 21;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.Transparent;
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(126, 6);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAnterior.Size = new System.Drawing.Size(108, 35);
            this.btnAnterior.TabIndex = 20;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrimero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.btnPrimero.FlatAppearance.BorderSize = 0;
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimero.Image")));
            this.btnPrimero.Location = new System.Drawing.Point(12, 6);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPrimero.Size = new System.Drawing.Size(108, 35);
            this.btnPrimero.TabIndex = 19;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Transparent;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(857, 6);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnImprimir.Size = new System.Drawing.Size(108, 35);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(979, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(108, 35);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PanelBotonesSuperiores
            // 
            this.PanelBotonesSuperiores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.PanelBotonesSuperiores.Controls.Add(this.btnConsultar);
            this.PanelBotonesSuperiores.Controls.Add(this.tbBuscar);
            this.PanelBotonesSuperiores.Controls.Add(this.label1);
            this.PanelBotonesSuperiores.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBotonesSuperiores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelBotonesSuperiores.Location = new System.Drawing.Point(0, 50);
            this.PanelBotonesSuperiores.Name = "PanelBotonesSuperiores";
            this.PanelBotonesSuperiores.Size = new System.Drawing.Size(1099, 50);
            this.PanelBotonesSuperiores.TabIndex = 28;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.Transparent;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(852, 8);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConsultar.Size = new System.Drawing.Size(108, 35);
            this.btnConsultar.TabIndex = 19;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // T1BuscarEmpleados
            // 
            this.T1BuscarEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.T1BuscarEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.T1BuscarEmpleados.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1BuscarEmpleados.ForeColor = System.Drawing.SystemColors.Control;
            this.T1BuscarEmpleados.Location = new System.Drawing.Point(0, 0);
            this.T1BuscarEmpleados.Name = "T1BuscarEmpleados";
            this.T1BuscarEmpleados.Size = new System.Drawing.Size(1099, 50);
            this.T1BuscarEmpleados.TabIndex = 25;
            this.T1BuscarEmpleados.Text = "Consulta General de Plataformas";
            this.T1BuscarEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FConsultaPlataformas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 728);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.PanelBotonesInferiores);
            this.Controls.Add(this.PanelBotonesSuperiores);
            this.Controls.Add(this.T1BuscarEmpleados);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FConsultaPlataformas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FConsultaPlataformas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.PanelBotonesInferiores.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelBotonesSuperiores.ResumeLayout(false);
            this.PanelBotonesSuperiores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelBotonesInferiores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CantPlataformas;
        private System.Windows.Forms.Label LCantPlataforma;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel PanelBotonesSuperiores;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label T1BuscarEmpleados;
    }
}