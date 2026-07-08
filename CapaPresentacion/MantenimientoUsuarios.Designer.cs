namespace CapaPresentacion
{
    partial class MantenimientoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoUsuarios));
            this.T1RegistroUsuario = new System.Windows.Forms.Label();
            this.PanelTituloEmpleados = new System.Windows.Forms.Panel();
            this.Nombre = new System.Windows.Forms.Label();
            this.NombredeUsuario = new System.Windows.Forms.Label();
            this.Rol = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.BAgregar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BBuscar = new System.Windows.Forms.Button();
            this.IdUsuario = new System.Windows.Forms.Label();
            this.tbIdUsuario = new System.Windows.Forms.TextBox();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.Contrasena = new System.Windows.Forms.Label();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.T1MantenimientoEmpleado = new System.Windows.Forms.Panel();
            this.BEditar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.PanelTituloEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.T1MantenimientoEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // T1RegistroUsuario
            // 
            this.T1RegistroUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.T1RegistroUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.T1RegistroUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1RegistroUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.T1RegistroUsuario.Location = new System.Drawing.Point(0, 0);
            this.T1RegistroUsuario.Name = "T1RegistroUsuario";
            this.T1RegistroUsuario.Size = new System.Drawing.Size(1137, 50);
            this.T1RegistroUsuario.TabIndex = 0;
            this.T1RegistroUsuario.Text = "Registro de Usuarios";
            this.T1RegistroUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelTituloEmpleados
            // 
            this.PanelTituloEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelTituloEmpleados.Controls.Add(this.T1RegistroUsuario);
            this.PanelTituloEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTituloEmpleados.Location = new System.Drawing.Point(0, 0);
            this.PanelTituloEmpleados.Name = "PanelTituloEmpleados";
            this.PanelTituloEmpleados.Size = new System.Drawing.Size(1137, 50);
            this.PanelTituloEmpleados.TabIndex = 25;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(46, 94);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(60, 21);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre:";
            // 
            // NombredeUsuario
            // 
            this.NombredeUsuario.Location = new System.Drawing.Point(46, 166);
            this.NombredeUsuario.Name = "NombredeUsuario";
            this.NombredeUsuario.Size = new System.Drawing.Size(131, 21);
            this.NombredeUsuario.TabIndex = 5;
            this.NombredeUsuario.Text = "Nombre del Usuario:";
            // 
            // Rol
            // 
            this.Rol.Location = new System.Drawing.Point(46, 310);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(131, 21);
            this.Rol.TabIndex = 7;
            this.Rol.Text = "Rol del Usuario:";
            // 
            // Estado
            // 
            this.Estado.Location = new System.Drawing.Point(46, 382);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(86, 21);
            this.Estado.TabIndex = 10;
            this.Estado.Text = "Estado:";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(46, 128);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(350, 25);
            this.tbNombre.TabIndex = 2;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(46, 200);
            this.tbUsuario.MaxLength = 13;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(350, 25);
            this.tbUsuario.TabIndex = 6;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(46, 416);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(350, 25);
            this.cbEstado.TabIndex = 11;
            // 
            // BAgregar
            // 
            this.BAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(135)))), ((int)(((byte)(85)))));
            this.BAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.BAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BAgregar.Image")));
            this.BAgregar.Location = new System.Drawing.Point(48, 492);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BAgregar.Size = new System.Drawing.Size(108, 35);
            this.BAgregar.TabIndex = 12;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BAgregar.UseVisualStyleBackColor = false;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.BCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BCancelar.Image")));
            this.BCancelar.Location = new System.Drawing.Point(390, 492);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BCancelar.Size = new System.Drawing.Size(108, 35);
            this.BCancelar.TabIndex = 16;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.BSalir.Image = ((System.Drawing.Image)(resources.GetObject("BSalir.Image")));
            this.BSalir.Location = new System.Drawing.Point(652, 492);
            this.BSalir.Name = "BSalir";
            this.BSalir.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BSalir.Size = new System.Drawing.Size(100, 35);
            this.BSalir.TabIndex = 17;
            this.BSalir.Text = "Salir";
            this.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "Información del Usuario";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(52, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(700, 2);
            this.label2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(270, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 2);
            this.label3.TabIndex = 20;
            // 
            // BBuscar
            // 
            this.BBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.BBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BBuscar.Image")));
            this.BBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBuscar.Location = new System.Drawing.Point(652, 411);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BBuscar.Size = new System.Drawing.Size(100, 35);
            this.BBuscar.TabIndex = 21;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // IdUsuario
            // 
            this.IdUsuario.Location = new System.Drawing.Point(486, 389);
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Size = new System.Drawing.Size(87, 20);
            this.IdUsuario.TabIndex = 22;
            this.IdUsuario.Text = "IdUsuario:";
            // 
            // tbIdUsuario
            // 
            this.tbIdUsuario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdUsuario.Location = new System.Drawing.Point(489, 416);
            this.tbIdUsuario.Name = "tbIdUsuario";
            this.tbIdUsuario.Size = new System.Drawing.Size(157, 25);
            this.tbIdUsuario.TabIndex = 23;
            // 
            // cbRol
            // 
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Empleado"});
            this.cbRol.Location = new System.Drawing.Point(46, 344);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(350, 25);
            this.cbRol.TabIndex = 28;
            // 
            // Contrasena
            // 
            this.Contrasena.Location = new System.Drawing.Point(46, 238);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Size = new System.Drawing.Size(86, 21);
            this.Contrasena.TabIndex = 29;
            this.Contrasena.Text = "Contraseña:";
            // 
            // tbClave
            // 
            this.tbClave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClave.Location = new System.Drawing.Point(46, 272);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(350, 25);
            this.tbClave.TabIndex = 30;
            this.tbClave.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(552, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // T1MantenimientoEmpleado
            // 
            this.T1MantenimientoEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T1MantenimientoEmpleado.BackColor = System.Drawing.Color.White;
            this.T1MantenimientoEmpleado.Controls.Add(this.pictureBox1);
            this.T1MantenimientoEmpleado.Controls.Add(this.tbClave);
            this.T1MantenimientoEmpleado.Controls.Add(this.Contrasena);
            this.T1MantenimientoEmpleado.Controls.Add(this.cbRol);
            this.T1MantenimientoEmpleado.Controls.Add(this.tbIdUsuario);
            this.T1MantenimientoEmpleado.Controls.Add(this.IdUsuario);
            this.T1MantenimientoEmpleado.Controls.Add(this.BBuscar);
            this.T1MantenimientoEmpleado.Controls.Add(this.label3);
            this.T1MantenimientoEmpleado.Controls.Add(this.label2);
            this.T1MantenimientoEmpleado.Controls.Add(this.label1);
            this.T1MantenimientoEmpleado.Controls.Add(this.BSalir);
            this.T1MantenimientoEmpleado.Controls.Add(this.BCancelar);
            this.T1MantenimientoEmpleado.Controls.Add(this.BEditar);
            this.T1MantenimientoEmpleado.Controls.Add(this.BGuardar);
            this.T1MantenimientoEmpleado.Controls.Add(this.BAgregar);
            this.T1MantenimientoEmpleado.Controls.Add(this.cbEstado);
            this.T1MantenimientoEmpleado.Controls.Add(this.tbUsuario);
            this.T1MantenimientoEmpleado.Controls.Add(this.tbNombre);
            this.T1MantenimientoEmpleado.Controls.Add(this.Estado);
            this.T1MantenimientoEmpleado.Controls.Add(this.Rol);
            this.T1MantenimientoEmpleado.Controls.Add(this.NombredeUsuario);
            this.T1MantenimientoEmpleado.Controls.Add(this.Nombre);
            this.T1MantenimientoEmpleado.Location = new System.Drawing.Point(168, 116);
            this.T1MantenimientoEmpleado.Name = "T1MantenimientoEmpleado";
            this.T1MantenimientoEmpleado.Size = new System.Drawing.Size(800, 550);
            this.T1MantenimientoEmpleado.TabIndex = 26;
            // 
            // BEditar
            // 
            this.BEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(120)))), ((int)(((byte)(55)))));
            this.BEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEditar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.BEditar.Image = ((System.Drawing.Image)(resources.GetObject("BEditar.Image")));
            this.BEditar.Location = new System.Drawing.Point(276, 492);
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
            this.BGuardar.Location = new System.Drawing.Point(162, 492);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BGuardar.Size = new System.Drawing.Size(108, 35);
            this.BGuardar.TabIndex = 13;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // MantenimientoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1137, 783);
            this.Controls.Add(this.PanelTituloEmpleados);
            this.Controls.Add(this.T1MantenimientoEmpleado);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MantenimientoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Usuario";
            this.Load += new System.EventHandler(this.MantenimientoUsuarios_Load);
            this.PanelTituloEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.T1MantenimientoEmpleado.ResumeLayout(false);
            this.T1MantenimientoEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label T1RegistroUsuario;
        private System.Windows.Forms.Panel PanelTituloEmpleados;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label NombredeUsuario;
        private System.Windows.Forms.Label Rol;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.Label IdUsuario;
        private System.Windows.Forms.TextBox tbIdUsuario;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label Contrasena;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel T1MantenimientoEmpleado;
        private System.Windows.Forms.Button BEditar;
        private System.Windows.Forms.Button BGuardar;
    }
}