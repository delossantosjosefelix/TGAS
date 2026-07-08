namespace CapaPresentacion
{
    partial class MantenimientoVideojuegos
    {
        /// <summary>
        /// Variable requerida por el diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// Método necesario para compatibilidad con el Diseñador. 
        /// No modifique el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoVideojuegos));
            this.PanelTituloVideojuegos = new System.Windows.Forms.Panel();
            this.T1MantenimientoVideojuegos = new System.Windows.Forms.Label();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.tbIdVideojuego = new System.Windows.Forms.TextBox();
            this.lblIdVideojuego = new System.Windows.Forms.Label();
            this.BBuscar = new System.Windows.Forms.Button();
            this.lblSeparador1 = new System.Windows.Forms.Label();
            this.lblSeparador2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BSalir = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BEditar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BAgregar = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbPlataforma = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPlataforma = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblFechaLanzamiento = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbStock = new System.Windows.Forms.NumericUpDown();
            this.PanelTituloVideojuegos.SuspendLayout();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStock)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTituloVideojuegos
            // 
            this.PanelTituloVideojuegos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelTituloVideojuegos.Controls.Add(this.T1MantenimientoVideojuegos);
            this.PanelTituloVideojuegos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTituloVideojuegos.Location = new System.Drawing.Point(0, 0);
            this.PanelTituloVideojuegos.Name = "PanelTituloVideojuegos";
            this.PanelTituloVideojuegos.Size = new System.Drawing.Size(1079, 50);
            this.PanelTituloVideojuegos.TabIndex = 21;
            this.PanelTituloVideojuegos.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTituloVideojuegos_Paint);
            // 
            // T1MantenimientoVideojuegos
            // 
            this.T1MantenimientoVideojuegos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.T1MantenimientoVideojuegos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.T1MantenimientoVideojuegos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1MantenimientoVideojuegos.ForeColor = System.Drawing.SystemColors.Control;
            this.T1MantenimientoVideojuegos.Location = new System.Drawing.Point(0, 0);
            this.T1MantenimientoVideojuegos.Name = "T1MantenimientoVideojuegos";
            this.T1MantenimientoVideojuegos.Size = new System.Drawing.Size(1079, 50);
            this.T1MantenimientoVideojuegos.TabIndex = 0;
            this.T1MantenimientoVideojuegos.Text = "Mantenimiento de Videojuegos";
            this.T1MantenimientoVideojuegos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCentral
            // 
            this.panelCentral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCentral.BackColor = System.Drawing.Color.White;
            this.panelCentral.Controls.Add(this.tbStock);
            this.panelCentral.Controls.Add(this.tbIdVideojuego);
            this.panelCentral.Controls.Add(this.lblIdVideojuego);
            this.panelCentral.Controls.Add(this.BBuscar);
            this.panelCentral.Controls.Add(this.lblSeparador1);
            this.panelCentral.Controls.Add(this.lblSeparador2);
            this.panelCentral.Controls.Add(this.lblTitulo);
            this.panelCentral.Controls.Add(this.BSalir);
            this.panelCentral.Controls.Add(this.BCancelar);
            this.panelCentral.Controls.Add(this.BEditar);
            this.panelCentral.Controls.Add(this.BGuardar);
            this.panelCentral.Controls.Add(this.BAgregar);
            this.panelCentral.Controls.Add(this.cbEstado);
            this.panelCentral.Controls.Add(this.cbPlataforma);
            this.panelCentral.Controls.Add(this.cbCategoria);
            this.panelCentral.Controls.Add(this.dtpFechaLanzamiento);
            this.panelCentral.Controls.Add(this.tbPrecio);
            this.panelCentral.Controls.Add(this.tbDescripcion);
            this.panelCentral.Controls.Add(this.tbNombre);
            this.panelCentral.Controls.Add(this.lblEstado);
            this.panelCentral.Controls.Add(this.lblPlataforma);
            this.panelCentral.Controls.Add(this.lblCategoria);
            this.panelCentral.Controls.Add(this.lblFechaLanzamiento);
            this.panelCentral.Controls.Add(this.lblStock);
            this.panelCentral.Controls.Add(this.lblPrecio);
            this.panelCentral.Controls.Add(this.lblDescripcion);
            this.panelCentral.Controls.Add(this.lblNombre);
            this.panelCentral.Controls.Add(this.pictureBox1);
            this.panelCentral.Location = new System.Drawing.Point(89, 100);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(900, 600);
            this.panelCentral.TabIndex = 22;
            // 
            // tbIdVideojuego
            // 
            this.tbIdVideojuego.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdVideojuego.Location = new System.Drawing.Point(580, 447);
            this.tbIdVideojuego.Name = "tbIdVideojuego";
            this.tbIdVideojuego.Size = new System.Drawing.Size(157, 25);
            this.tbIdVideojuego.TabIndex = 23;
            // 
            // lblIdVideojuego
            // 
            this.lblIdVideojuego.Location = new System.Drawing.Point(580, 423);
            this.lblIdVideojuego.Name = "lblIdVideojuego";
            this.lblIdVideojuego.Size = new System.Drawing.Size(100, 20);
            this.lblIdVideojuego.TabIndex = 22;
            this.lblIdVideojuego.Text = "Id Videojuego:";
            this.lblIdVideojuego.Click += new System.EventHandler(this.label4_Click);
            // 
            // BBuscar
            // 
            this.BBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.BBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BBuscar.Image")));
            this.BBuscar.Location = new System.Drawing.Point(748, 444);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BBuscar.Size = new System.Drawing.Size(100, 35);
            this.BBuscar.TabIndex = 21;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // lblSeparador1
            // 
            this.lblSeparador1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparador1.Location = new System.Drawing.Point(240, 63);
            this.lblSeparador1.Name = "lblSeparador1";
            this.lblSeparador1.Size = new System.Drawing.Size(420, 2);
            this.lblSeparador1.TabIndex = 20;
            // 
            // lblSeparador2
            // 
            this.lblSeparador2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparador2.Location = new System.Drawing.Point(50, 522);
            this.lblSeparador2.Name = "lblSeparador2";
            this.lblSeparador2.Size = new System.Drawing.Size(800, 2);
            this.lblSeparador2.TabIndex = 19;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(277, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(304, 27);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Información del Videojuego";
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.BSalir.Image = ((System.Drawing.Image)(resources.GetObject("BSalir.Image")));
            this.BSalir.Location = new System.Drawing.Point(750, 540);
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
            this.BCancelar.Location = new System.Drawing.Point(388, 540);
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
            this.BEditar.Location = new System.Drawing.Point(274, 540);
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
            this.BGuardar.Location = new System.Drawing.Point(160, 540);
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
            this.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregar.Location = new System.Drawing.Point(46, 540);
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
            this.cbEstado.Location = new System.Drawing.Point(580, 388);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(200, 25);
            this.cbEstado.TabIndex = 15;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbPlataforma
            // 
            this.cbPlataforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlataforma.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlataforma.FormattingEnabled = true;
            this.cbPlataforma.Location = new System.Drawing.Point(46, 447);
            this.cbPlataforma.Name = "cbPlataforma";
            this.cbPlataforma.Size = new System.Drawing.Size(350, 25);
            this.cbPlataforma.TabIndex = 13;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(46, 388);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(350, 25);
            this.cbCategoria.TabIndex = 11;
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaLanzamiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(46, 329);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(350, 25);
            this.dtpFechaLanzamiento.TabIndex = 9;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecio.Location = new System.Drawing.Point(46, 270);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(160, 25);
            this.tbPrecio.TabIndex = 5;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.Location = new System.Drawing.Point(46, 176);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(350, 60);
            this.tbDescripcion.TabIndex = 3;
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(46, 118);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(350, 25);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(580, 364);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(80, 21);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado:";
            // 
            // lblPlataforma
            // 
            this.lblPlataforma.Location = new System.Drawing.Point(46, 423);
            this.lblPlataforma.Name = "lblPlataforma";
            this.lblPlataforma.Size = new System.Drawing.Size(90, 21);
            this.lblPlataforma.TabIndex = 12;
            this.lblPlataforma.Text = "Plataforma:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Location = new System.Drawing.Point(46, 364);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(80, 21);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblFechaLanzamiento
            // 
            this.lblFechaLanzamiento.Location = new System.Drawing.Point(46, 305);
            this.lblFechaLanzamiento.Name = "lblFechaLanzamiento";
            this.lblFechaLanzamiento.Size = new System.Drawing.Size(150, 21);
            this.lblFechaLanzamiento.TabIndex = 8;
            this.lblFechaLanzamiento.Text = "Fecha de Lanzamiento:";
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(220, 246);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(80, 21);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(46, 246);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(80, 21);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(46, 152);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(90, 21);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(46, 94);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(648, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tbStock
            // 
            this.tbStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStock.Location = new System.Drawing.Point(223, 269);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(173, 26);
            this.tbStock.TabIndex = 24;
            this.tbStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStock_KeyPress);
            // 
            // MantenimientoVideojuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1079, 790);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.PanelTituloVideojuegos);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MantenimientoVideojuegos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MantenimientoVideojuegos";
            this.Load += new System.EventHandler(this.MantenimientoVideojuegos_Load);
            this.PanelTituloVideojuegos.ResumeLayout(false);
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // ── DECLARACIÓN DE TODOS LOS CONTROLES DEL FORMULARIO ────────────────
        private System.Windows.Forms.Panel PanelTituloVideojuegos;
        private System.Windows.Forms.Label T1MantenimientoVideojuegos;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblFechaLanzamiento;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblPlataforma;
        private System.Windows.Forms.ComboBox cbPlataforma;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblIdVideojuego;
        private System.Windows.Forms.TextBox tbIdVideojuego;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.Label lblSeparador1;
        private System.Windows.Forms.Label lblSeparador2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BEditar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown tbStock;
    }
}