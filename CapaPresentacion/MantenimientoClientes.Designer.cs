namespace CapaPresentacion
{
    partial class MantenimientoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoClientes));
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.Label();
            this.tbIdClientes = new System.Windows.Forms.TextBox();
            this.IdCliente = new System.Windows.Forms.Label();
            this.BBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BSalir = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BEditar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BAgregar = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.Label();
            this.Dirección = new System.Windows.Forms.Label();
            this.Cedula = new System.Windows.Forms.Label();
            this.Correo = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.T1MantenimientoEmpleados = new System.Windows.Forms.Label();
            this.PanelTituloEmpleados = new System.Windows.Forms.Panel();
            this.T1MantenimientoEmpleado = new System.Windows.Forms.Panel();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelTituloEmpleados.SuspendLayout();
            this.T1MantenimientoEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(484, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fecha de Registro:";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.CalendarFont = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRegistro.Enabled = false;
            this.dtpFechaRegistro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRegistro.Location = new System.Drawing.Point(487, 422);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(263, 26);
            this.dtpFechaRegistro.TabIndex = 26;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(46, 302);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(350, 25);
            this.tbTelefono.TabIndex = 25;
            this.tbTelefono.TextChanged += new System.EventHandler(this.tbTelefono_TextChanged);
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(46, 274);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(60, 21);
            this.Telefono.TabIndex = 24;
            this.Telefono.Text = "Teléfono:";
            // 
            // tbIdClientes
            // 
            this.tbIdClientes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdClientes.Location = new System.Drawing.Point(487, 362);
            this.tbIdClientes.Name = "tbIdClientes";
            this.tbIdClientes.Size = new System.Drawing.Size(157, 25);
            this.tbIdClientes.TabIndex = 23;
            // 
            // IdCliente
            // 
            this.IdCliente.Location = new System.Drawing.Point(484, 335);
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Size = new System.Drawing.Size(87, 20);
            this.IdCliente.TabIndex = 22;
            this.IdCliente.Text = "IdCliente:";
            // 
            // BBuscar
            // 
            this.BBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.BBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BBuscar.Image")));
            this.BBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBuscar.Location = new System.Drawing.Point(650, 357);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BBuscar.Size = new System.Drawing.Size(100, 35);
            this.BBuscar.TabIndex = 21;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click_1);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(270, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 2);
            this.label3.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(50, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(700, 2);
            this.label2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "Información del Cliente";
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.BSalir.Image = ((System.Drawing.Image)(resources.GetObject("BSalir.Image")));
            this.BSalir.Location = new System.Drawing.Point(650, 495);
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
            this.BCancelar.Location = new System.Drawing.Point(388, 495);
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
            this.BEditar.Location = new System.Drawing.Point(274, 495);
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
            this.BGuardar.Location = new System.Drawing.Point(160, 495);
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
            this.BAgregar.Location = new System.Drawing.Point(46, 495);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BAgregar.Size = new System.Drawing.Size(108, 35);
            this.BAgregar.TabIndex = 12;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BAgregar.UseVisualStyleBackColor = false;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(46, 422);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(350, 25);
            this.cbEstado.TabIndex = 11;
            // 
            // tbCedula
            // 
            this.tbCedula.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCedula.Location = new System.Drawing.Point(46, 182);
            this.tbCedula.MaxLength = 13;
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(350, 25);
            this.tbCedula.TabIndex = 6;
            this.tbCedula.TextChanged += new System.EventHandler(this.tbCedula_TextChanged);
            this.tbCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCedula_KeyPress);
            // 
            // tbCorreo
            // 
            this.tbCorreo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.Location = new System.Drawing.Point(46, 242);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(350, 25);
            this.tbCorreo.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(46, 122);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(350, 25);
            this.tbNombre.TabIndex = 2;
            // 
            // Estado
            // 
            this.Estado.Location = new System.Drawing.Point(46, 394);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(86, 21);
            this.Estado.TabIndex = 10;
            this.Estado.Text = "Estado:";
            // 
            // Dirección
            // 
            this.Dirección.Location = new System.Drawing.Point(46, 334);
            this.Dirección.Name = "Dirección";
            this.Dirección.Size = new System.Drawing.Size(86, 21);
            this.Dirección.TabIndex = 7;
            this.Dirección.Text = "Dirección:";
            // 
            // Cedula
            // 
            this.Cedula.Location = new System.Drawing.Point(46, 154);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(86, 21);
            this.Cedula.TabIndex = 5;
            this.Cedula.Text = "Cédula:";
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(46, 214);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(60, 21);
            this.Correo.TabIndex = 3;
            this.Correo.Text = "Correo:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(46, 94);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(60, 21);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(550, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // T1MantenimientoEmpleados
            // 
            this.T1MantenimientoEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.T1MantenimientoEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.T1MantenimientoEmpleados.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1MantenimientoEmpleados.ForeColor = System.Drawing.SystemColors.Control;
            this.T1MantenimientoEmpleados.Location = new System.Drawing.Point(0, 0);
            this.T1MantenimientoEmpleados.Name = "T1MantenimientoEmpleados";
            this.T1MantenimientoEmpleados.Size = new System.Drawing.Size(1137, 50);
            this.T1MantenimientoEmpleados.TabIndex = 0;
            this.T1MantenimientoEmpleados.Text = "Mantenimiento de Clientes";
            this.T1MantenimientoEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelTituloEmpleados
            // 
            this.PanelTituloEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelTituloEmpleados.Controls.Add(this.T1MantenimientoEmpleados);
            this.PanelTituloEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTituloEmpleados.Location = new System.Drawing.Point(0, 0);
            this.PanelTituloEmpleados.Name = "PanelTituloEmpleados";
            this.PanelTituloEmpleados.Size = new System.Drawing.Size(1137, 50);
            this.PanelTituloEmpleados.TabIndex = 23;
            // 
            // T1MantenimientoEmpleado
            // 
            this.T1MantenimientoEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T1MantenimientoEmpleado.BackColor = System.Drawing.Color.White;
            this.T1MantenimientoEmpleado.Controls.Add(this.tbDireccion);
            this.T1MantenimientoEmpleado.Controls.Add(this.label4);
            this.T1MantenimientoEmpleado.Controls.Add(this.dtpFechaRegistro);
            this.T1MantenimientoEmpleado.Controls.Add(this.tbTelefono);
            this.T1MantenimientoEmpleado.Controls.Add(this.Telefono);
            this.T1MantenimientoEmpleado.Controls.Add(this.tbIdClientes);
            this.T1MantenimientoEmpleado.Controls.Add(this.IdCliente);
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
            this.T1MantenimientoEmpleado.Controls.Add(this.tbCedula);
            this.T1MantenimientoEmpleado.Controls.Add(this.tbCorreo);
            this.T1MantenimientoEmpleado.Controls.Add(this.tbNombre);
            this.T1MantenimientoEmpleado.Controls.Add(this.Estado);
            this.T1MantenimientoEmpleado.Controls.Add(this.Dirección);
            this.T1MantenimientoEmpleado.Controls.Add(this.Cedula);
            this.T1MantenimientoEmpleado.Controls.Add(this.Correo);
            this.T1MantenimientoEmpleado.Controls.Add(this.Nombre);
            this.T1MantenimientoEmpleado.Controls.Add(this.pictureBox1);
            this.T1MantenimientoEmpleado.Location = new System.Drawing.Point(168, 116);
            this.T1MantenimientoEmpleado.Name = "T1MantenimientoEmpleado";
            this.T1MantenimientoEmpleado.Size = new System.Drawing.Size(800, 550);
            this.T1MantenimientoEmpleado.TabIndex = 24;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccion.Location = new System.Drawing.Point(46, 362);
            this.tbDireccion.MaxLength = 225;
            this.tbDireccion.Multiline = true;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDireccion.Size = new System.Drawing.Size(350, 26);
            this.tbDireccion.TabIndex = 28;
            // 
            // MantenimientoClientes
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
            this.Name = "MantenimientoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mantenimiento de Clientes";
            this.Load += new System.EventHandler(this.MantenimientoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelTituloEmpleados.ResumeLayout(false);
            this.T1MantenimientoEmpleado.ResumeLayout(false);
            this.T1MantenimientoEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.TextBox tbIdClientes;
        private System.Windows.Forms.Label IdCliente;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BEditar;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Label Dirección;
        private System.Windows.Forms.Label Cedula;
        private System.Windows.Forms.Label Correo;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label T1MantenimientoEmpleados;
        private System.Windows.Forms.Panel PanelTituloEmpleados;
        private System.Windows.Forms.Panel T1MantenimientoEmpleado;
        private System.Windows.Forms.TextBox tbDireccion;
    }
}