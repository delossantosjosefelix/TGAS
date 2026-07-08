namespace CapaPresentacion
{
    partial class MantenimientoPlataformas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoPlataformas));
            this.tbIdPlataformas = new System.Windows.Forms.TextBox();
            this.IdPlataforma = new System.Windows.Forms.Label();
            this.BBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BSalir = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BEditar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BAgregar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.T1MantenimientoEmpleado = new System.Windows.Forms.Panel();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.Estado = new System.Windows.Forms.Label();
            this.PanelTituloEmpleados = new System.Windows.Forms.Panel();
            this.T1MantenimientoPlataformas = new System.Windows.Forms.Label();
            this.T1MantenimientoEmpleado.SuspendLayout();
            this.PanelTituloEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbIdPlataformas
            // 
            this.tbIdPlataformas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdPlataformas.Location = new System.Drawing.Point(489, 194);
            this.tbIdPlataformas.Name = "tbIdPlataformas";
            this.tbIdPlataformas.Size = new System.Drawing.Size(157, 25);
            this.tbIdPlataformas.TabIndex = 23;
            // 
            // IdPlataforma
            // 
            this.IdPlataforma.Location = new System.Drawing.Point(489, 164);
            this.IdPlataforma.Name = "IdPlataforma";
            this.IdPlataforma.Size = new System.Drawing.Size(87, 20);
            this.IdPlataforma.TabIndex = 22;
            this.IdPlataforma.Text = "IdPlataforma:";
            // 
            // BBuscar
            // 
            this.BBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.BBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BBuscar.Image")));
            this.BBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBuscar.Location = new System.Drawing.Point(652, 184);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BBuscar.Size = new System.Drawing.Size(100, 35);
            this.BBuscar.TabIndex = 21;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(240, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 2);
            this.label3.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(52, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(700, 2);
            this.label2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "Información de la Plataforma";
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.BSalir.Image = ((System.Drawing.Image)(resources.GetObject("BSalir.Image")));
            this.BSalir.Location = new System.Drawing.Point(652, 266);
            this.BSalir.Name = "BSalir";
            this.BSalir.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BSalir.Size = new System.Drawing.Size(100, 35);
            this.BSalir.TabIndex = 17;
            this.BSalir.Text = "Salir";
            this.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.BCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BCancelar.Image")));
            this.BCancelar.Location = new System.Drawing.Point(390, 266);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BCancelar.Size = new System.Drawing.Size(108, 35);
            this.BCancelar.TabIndex = 16;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BEditar
            // 
            this.BEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(120)))), ((int)(((byte)(55)))));
            this.BEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEditar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.BEditar.Image = ((System.Drawing.Image)(resources.GetObject("BEditar.Image")));
            this.BEditar.Location = new System.Drawing.Point(276, 266);
            this.BEditar.Name = "BEditar";
            this.BEditar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BEditar.Size = new System.Drawing.Size(108, 35);
            this.BEditar.TabIndex = 14;
            this.BEditar.Text = "Editar";
            this.BEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BEditar.UseVisualStyleBackColor = false;
            this.BEditar.Click += new System.EventHandler(this.BEditar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.BGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BGuardar.Image")));
            this.BGuardar.Location = new System.Drawing.Point(162, 266);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BGuardar.Size = new System.Drawing.Size(108, 35);
            this.BGuardar.TabIndex = 13;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BAgregar
            // 
            this.BAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(135)))), ((int)(((byte)(85)))));
            this.BAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.BAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BAgregar.Image")));
            this.BAgregar.Location = new System.Drawing.Point(48, 266);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BAgregar.Size = new System.Drawing.Size(108, 35);
            this.BAgregar.TabIndex = 12;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BAgregar.UseVisualStyleBackColor = false;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(46, 125);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(350, 25);
            this.tbNombre.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(46, 94);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(60, 21);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre:";
            // 
            // T1MantenimientoEmpleado
            // 
            this.T1MantenimientoEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T1MantenimientoEmpleado.BackColor = System.Drawing.Color.White;
            this.T1MantenimientoEmpleado.Controls.Add(this.cbEstado);
            this.T1MantenimientoEmpleado.Controls.Add(this.Estado);
            this.T1MantenimientoEmpleado.Controls.Add(this.tbIdPlataformas);
            this.T1MantenimientoEmpleado.Controls.Add(this.IdPlataforma);
            this.T1MantenimientoEmpleado.Controls.Add(this.BBuscar);
            this.T1MantenimientoEmpleado.Controls.Add(this.label3);
            this.T1MantenimientoEmpleado.Controls.Add(this.label2);
            this.T1MantenimientoEmpleado.Controls.Add(this.label1);
            this.T1MantenimientoEmpleado.Controls.Add(this.BSalir);
            this.T1MantenimientoEmpleado.Controls.Add(this.BCancelar);
            this.T1MantenimientoEmpleado.Controls.Add(this.BEditar);
            this.T1MantenimientoEmpleado.Controls.Add(this.BGuardar);
            this.T1MantenimientoEmpleado.Controls.Add(this.BAgregar);
            this.T1MantenimientoEmpleado.Controls.Add(this.tbNombre);
            this.T1MantenimientoEmpleado.Controls.Add(this.Nombre);
            this.T1MantenimientoEmpleado.Location = new System.Drawing.Point(168, 229);
            this.T1MantenimientoEmpleado.Name = "T1MantenimientoEmpleado";
            this.T1MantenimientoEmpleado.Size = new System.Drawing.Size(800, 324);
            this.T1MantenimientoEmpleado.TabIndex = 24;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(46, 194);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(350, 25);
            this.cbEstado.TabIndex = 27;
            // 
            // Estado
            // 
            this.Estado.Location = new System.Drawing.Point(46, 162);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(86, 21);
            this.Estado.TabIndex = 26;
            this.Estado.Text = "Estado:";
            // 
            // PanelTituloEmpleados
            // 
            this.PanelTituloEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelTituloEmpleados.Controls.Add(this.T1MantenimientoPlataformas);
            this.PanelTituloEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTituloEmpleados.Location = new System.Drawing.Point(0, 0);
            this.PanelTituloEmpleados.Name = "PanelTituloEmpleados";
            this.PanelTituloEmpleados.Size = new System.Drawing.Size(1137, 50);
            this.PanelTituloEmpleados.TabIndex = 23;
            // 
            // T1MantenimientoPlataformas
            // 
            this.T1MantenimientoPlataformas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.T1MantenimientoPlataformas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.T1MantenimientoPlataformas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1MantenimientoPlataformas.ForeColor = System.Drawing.SystemColors.Control;
            this.T1MantenimientoPlataformas.Location = new System.Drawing.Point(0, 0);
            this.T1MantenimientoPlataformas.Name = "T1MantenimientoPlataformas";
            this.T1MantenimientoPlataformas.Size = new System.Drawing.Size(1137, 50);
            this.T1MantenimientoPlataformas.TabIndex = 0;
            this.T1MantenimientoPlataformas.Text = "Mantenimiento de Plataformas";
            this.T1MantenimientoPlataformas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MantenimientoPlataformas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1137, 783);
            this.Controls.Add(this.T1MantenimientoEmpleado);
            this.Controls.Add(this.PanelTituloEmpleados);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MantenimientoPlataformas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mantenimiento de Plataformas";
            this.Load += new System.EventHandler(this.MantenimientoPlataformas_Load);
            this.T1MantenimientoEmpleado.ResumeLayout(false);
            this.T1MantenimientoEmpleado.PerformLayout();
            this.PanelTituloEmpleados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbIdPlataformas;
        private System.Windows.Forms.Label IdPlataforma;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BEditar;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Panel T1MantenimientoEmpleado;
        private System.Windows.Forms.Panel PanelTituloEmpleados;
        private System.Windows.Forms.Label T1MantenimientoPlataformas;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label Estado;
    }
}