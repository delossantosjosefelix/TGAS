namespace CapaPresentacion
{
    partial class FBuscarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBuscarClientes));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelBotonesInferiores = new System.Windows.Forms.Panel();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.PanelBotonesSuperiores = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.T1BuscarEmpleados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.PanelBotonesInferiores.SuspendLayout();
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
            this.dgvDatos.Size = new System.Drawing.Size(1137, 633);
            this.dgvDatos.TabIndex = 12;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.Location = new System.Drawing.Point(411, 9);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(431, 32);
            this.tbBuscar.TabIndex = 7;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese el Dato a Buscar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PanelBotonesInferiores
            // 
            this.PanelBotonesInferiores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.PanelBotonesInferiores.Controls.Add(this.btnUltimo);
            this.PanelBotonesInferiores.Controls.Add(this.btnSiguiente);
            this.PanelBotonesInferiores.Controls.Add(this.btnAnterior);
            this.PanelBotonesInferiores.Controls.Add(this.btnPrimero);
            this.PanelBotonesInferiores.Controls.Add(this.btnAceptar);
            this.PanelBotonesInferiores.Controls.Add(this.btnCancelar);
            this.PanelBotonesInferiores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBotonesInferiores.Location = new System.Drawing.Point(0, 733);
            this.PanelBotonesInferiores.Name = "PanelBotonesInferiores";
            this.PanelBotonesInferiores.Size = new System.Drawing.Size(1137, 50);
            this.PanelBotonesInferiores.TabIndex = 14;
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
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(135)))), ((int)(((byte)(85)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Location = new System.Drawing.Point(895, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAceptar.Size = new System.Drawing.Size(108, 35);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Location = new System.Drawing.Point(1017, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCancelar.Size = new System.Drawing.Size(108, 35);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // PanelBotonesSuperiores
            // 
            this.PanelBotonesSuperiores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.PanelBotonesSuperiores.Controls.Add(this.btnBuscar);
            this.PanelBotonesSuperiores.Controls.Add(this.tbBuscar);
            this.PanelBotonesSuperiores.Controls.Add(this.label1);
            this.PanelBotonesSuperiores.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBotonesSuperiores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelBotonesSuperiores.Location = new System.Drawing.Point(0, 50);
            this.PanelBotonesSuperiores.Name = "PanelBotonesSuperiores";
            this.PanelBotonesSuperiores.Size = new System.Drawing.Size(1137, 50);
            this.PanelBotonesSuperiores.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(852, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBuscar.Size = new System.Drawing.Size(108, 35);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // T1BuscarEmpleados
            // 
            this.T1BuscarEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.T1BuscarEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.T1BuscarEmpleados.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1BuscarEmpleados.ForeColor = System.Drawing.SystemColors.Control;
            this.T1BuscarEmpleados.Location = new System.Drawing.Point(0, 0);
            this.T1BuscarEmpleados.Name = "T1BuscarEmpleados";
            this.T1BuscarEmpleados.Size = new System.Drawing.Size(1137, 50);
            this.T1BuscarEmpleados.TabIndex = 9;
            this.T1BuscarEmpleados.Text = "Búsqueda de Clientes";
            this.T1BuscarEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FBuscarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 783);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.PanelBotonesSuperiores);
            this.Controls.Add(this.T1BuscarEmpleados);
            this.Controls.Add(this.PanelBotonesInferiores);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FBuscarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FBuscarClientes";
            this.Load += new System.EventHandler(this.FBuscarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.PanelBotonesInferiores.ResumeLayout(false);
            this.PanelBotonesSuperiores.ResumeLayout(false);
            this.PanelBotonesSuperiores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelBotonesInferiores;
        private System.Windows.Forms.Panel PanelBotonesSuperiores;
        private System.Windows.Forms.Label T1BuscarEmpleados;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
    }
}