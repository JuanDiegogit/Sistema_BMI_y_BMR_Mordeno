namespace Vista
{
    partial class AgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarUsuario));
            this.panelSuperior = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMaximizarRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelPrincipalContenedor = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNivelActividadDescripcion = new System.Windows.Forms.Label();
            this.txtaNivelActividad = new System.Windows.Forms.TextBox();
            this.lblEstadoPeso = new System.Windows.Forms.Label();
            this.nupBMR = new System.Windows.Forms.NumericUpDown();
            this.lblBMR = new System.Windows.Forms.Label();
            this.nupBMI = new System.Windows.Forms.NumericUpDown();
            this.lblBMI = new System.Windows.Forms.Label();
            this.cmbNivelActividad = new System.Windows.Forms.ComboBox();
            this.lblNivelActividad = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.DateFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.nupEstatura = new System.Windows.Forms.NumericUpDown();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.nupPeso = new System.Windows.Forms.NumericUpDown();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineDividir = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineNombre = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineApellido = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizarRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.panelPrincipalContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupBMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBMI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupEstatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.DimGray;
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Controls.Add(this.btnMaximizarRestaurar);
            this.panelSuperior.Controls.Add(this.btnMinimizar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Padding = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.panelSuperior.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelSuperior.Size = new System.Drawing.Size(800, 28);
            this.panelSuperior.TabIndex = 3;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::Vista.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(775, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMaximizarRestaurar
            // 
            this.btnMaximizarRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizarRestaurar.Image")));
            this.btnMaximizarRestaurar.Location = new System.Drawing.Point(749, 5);
            this.btnMaximizarRestaurar.Name = "btnMaximizarRestaurar";
            this.btnMaximizarRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximizarRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizarRestaurar.TabIndex = 2;
            this.btnMaximizarRestaurar.TabStop = false;
            this.btnMaximizarRestaurar.Click += new System.EventHandler(this.btnMaximizarRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(723, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelPrincipalContenedor);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelPrincipal.Location = new System.Drawing.Point(0, 28);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panelPrincipal.Size = new System.Drawing.Size(800, 472);
            this.panelPrincipal.TabIndex = 4;
            // 
            // panelPrincipalContenedor
            // 
            this.panelPrincipalContenedor.Controls.Add(this.btnSalir);
            this.panelPrincipalContenedor.Controls.Add(this.btnGuardar);
            this.panelPrincipalContenedor.Controls.Add(this.lblNivelActividadDescripcion);
            this.panelPrincipalContenedor.Controls.Add(this.txtaNivelActividad);
            this.panelPrincipalContenedor.Controls.Add(this.lblEstadoPeso);
            this.panelPrincipalContenedor.Controls.Add(this.nupBMR);
            this.panelPrincipalContenedor.Controls.Add(this.lblBMR);
            this.panelPrincipalContenedor.Controls.Add(this.nupBMI);
            this.panelPrincipalContenedor.Controls.Add(this.lblBMI);
            this.panelPrincipalContenedor.Controls.Add(this.cmbNivelActividad);
            this.panelPrincipalContenedor.Controls.Add(this.lblNivelActividad);
            this.panelPrincipalContenedor.Controls.Add(this.cmbGenero);
            this.panelPrincipalContenedor.Controls.Add(this.lblGenero);
            this.panelPrincipalContenedor.Controls.Add(this.DateFechaNacimiento);
            this.panelPrincipalContenedor.Controls.Add(this.lblFechaNacimiento);
            this.panelPrincipalContenedor.Controls.Add(this.nupEstatura);
            this.panelPrincipalContenedor.Controls.Add(this.lblEstatura);
            this.panelPrincipalContenedor.Controls.Add(this.nupPeso);
            this.panelPrincipalContenedor.Controls.Add(this.lblPeso);
            this.panelPrincipalContenedor.Controls.Add(this.lblApellido);
            this.panelPrincipalContenedor.Controls.Add(this.txtApellido);
            this.panelPrincipalContenedor.Controls.Add(this.lblNombre);
            this.panelPrincipalContenedor.Controls.Add(this.btnCalcular);
            this.panelPrincipalContenedor.Controls.Add(this.txtNombre);
            this.panelPrincipalContenedor.Controls.Add(this.shapeContainer1);
            this.panelPrincipalContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipalContenedor.ForeColor = System.Drawing.Color.White;
            this.panelPrincipalContenedor.Location = new System.Drawing.Point(20, 10);
            this.panelPrincipalContenedor.MaximumSize = new System.Drawing.Size(900, 0);
            this.panelPrincipalContenedor.Name = "panelPrincipalContenedor";
            this.panelPrincipalContenedor.Size = new System.Drawing.Size(760, 452);
            this.panelPrincipalContenedor.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(179, 403);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(143, 35);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGuardar.Location = new System.Drawing.Point(19, 403);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 35);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNivelActividadDescripcion
            // 
            this.lblNivelActividadDescripcion.AutoSize = true;
            this.lblNivelActividadDescripcion.Location = new System.Drawing.Point(411, 293);
            this.lblNivelActividadDescripcion.Name = "lblNivelActividadDescripcion";
            this.lblNivelActividadDescripcion.Size = new System.Drawing.Size(200, 24);
            this.lblNivelActividadDescripcion.TabIndex = 23;
            this.lblNivelActividadDescripcion.Text = "Nivel De Actividad";
            // 
            // txtaNivelActividad
            // 
            this.txtaNivelActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtaNivelActividad.Enabled = false;
            this.txtaNivelActividad.ForeColor = System.Drawing.Color.White;
            this.txtaNivelActividad.Location = new System.Drawing.Point(408, 323);
            this.txtaNivelActividad.Multiline = true;
            this.txtaNivelActividad.Name = "txtaNivelActividad";
            this.txtaNivelActividad.Size = new System.Drawing.Size(340, 115);
            this.txtaNivelActividad.TabIndex = 22;
            // 
            // lblEstadoPeso
            // 
            this.lblEstadoPeso.AutoSize = true;
            this.lblEstadoPeso.Location = new System.Drawing.Point(249, 293);
            this.lblEstadoPeso.Name = "lblEstadoPeso";
            this.lblEstadoPeso.Size = new System.Drawing.Size(127, 24);
            this.lblEstadoPeso.TabIndex = 21;
            this.lblEstadoPeso.Text = "SobrePeso+";
            // 
            // nupBMR
            // 
            this.nupBMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.nupBMR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupBMR.DecimalPlaces = 2;
            this.nupBMR.Enabled = false;
            this.nupBMR.ForeColor = System.Drawing.Color.White;
            this.nupBMR.Location = new System.Drawing.Point(103, 344);
            this.nupBMR.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nupBMR.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.nupBMR.Name = "nupBMR";
            this.nupBMR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nupBMR.Size = new System.Drawing.Size(122, 33);
            this.nupBMR.TabIndex = 20;
            this.nupBMR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupBMR.ThousandsSeparator = true;
            // 
            // lblBMR
            // 
            this.lblBMR.AutoSize = true;
            this.lblBMR.Location = new System.Drawing.Point(15, 353);
            this.lblBMR.Name = "lblBMR";
            this.lblBMR.Size = new System.Drawing.Size(54, 24);
            this.lblBMR.TabIndex = 19;
            this.lblBMR.Text = "BMR";
            // 
            // nupBMI
            // 
            this.nupBMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.nupBMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupBMI.DecimalPlaces = 2;
            this.nupBMI.Enabled = false;
            this.nupBMI.ForeColor = System.Drawing.Color.White;
            this.nupBMI.Location = new System.Drawing.Point(103, 293);
            this.nupBMI.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nupBMI.Minimum = new decimal(new int[] {
            1215752191,
            23,
            0,
            -2147483648});
            this.nupBMI.Name = "nupBMI";
            this.nupBMI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nupBMI.Size = new System.Drawing.Size(122, 33);
            this.nupBMI.TabIndex = 18;
            this.nupBMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupBMI.ThousandsSeparator = true;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(15, 295);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(46, 24);
            this.lblBMI.TabIndex = 17;
            this.lblBMI.Text = "BMI";
            // 
            // cmbNivelActividad
            // 
            this.cmbNivelActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cmbNivelActividad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbNivelActividad.ForeColor = System.Drawing.Color.White;
            this.cmbNivelActividad.FormattingEnabled = true;
            this.cmbNivelActividad.Location = new System.Drawing.Point(346, 173);
            this.cmbNivelActividad.Name = "cmbNivelActividad";
            this.cmbNivelActividad.Size = new System.Drawing.Size(414, 32);
            this.cmbNivelActividad.TabIndex = 16;
            // 
            // lblNivelActividad
            // 
            this.lblNivelActividad.AutoSize = true;
            this.lblNivelActividad.Location = new System.Drawing.Point(342, 139);
            this.lblNivelActividad.Name = "lblNivelActividad";
            this.lblNivelActividad.Size = new System.Drawing.Size(200, 24);
            this.lblNivelActividad.TabIndex = 15;
            this.lblNivelActividad.Text = "Nivel De Actividad";
            // 
            // cmbGenero
            // 
            this.cmbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cmbGenero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGenero.ForeColor = System.Drawing.Color.White;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(443, 77);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(317, 32);
            this.cmbGenero.TabIndex = 14;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(342, 80);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(89, 24);
            this.lblGenero.TabIndex = 13;
            this.lblGenero.Text = "Genero";
            // 
            // DateFechaNacimiento
            // 
            this.DateFechaNacimiento.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateFechaNacimiento.CalendarForeColor = System.Drawing.Color.White;
            this.DateFechaNacimiento.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.DateFechaNacimiento.CalendarTitleBackColor = System.Drawing.Color.White;
            this.DateFechaNacimiento.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DateFechaNacimiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateFechaNacimiento.Location = new System.Drawing.Point(346, 31);
            this.DateFechaNacimiento.Name = "DateFechaNacimiento";
            this.DateFechaNacimiento.Size = new System.Drawing.Size(414, 33);
            this.DateFechaNacimiento.TabIndex = 12;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(342, 4);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(200, 24);
            this.lblFechaNacimiento.TabIndex = 11;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // nupEstatura
            // 
            this.nupEstatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.nupEstatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupEstatura.DecimalPlaces = 2;
            this.nupEstatura.ForeColor = System.Drawing.Color.White;
            this.nupEstatura.Location = new System.Drawing.Point(179, 226);
            this.nupEstatura.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nupEstatura.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.nupEstatura.Name = "nupEstatura";
            this.nupEstatura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nupEstatura.Size = new System.Drawing.Size(122, 33);
            this.nupEstatura.TabIndex = 10;
            this.nupEstatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupEstatura.ThousandsSeparator = true;
            // 
            // lblEstatura
            // 
            this.lblEstatura.AutoSize = true;
            this.lblEstatura.Location = new System.Drawing.Point(15, 231);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(147, 24);
            this.lblEstatura.TabIndex = 9;
            this.lblEstatura.Text = "Estatura (CM)";
            // 
            // nupPeso
            // 
            this.nupPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.nupPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupPeso.DecimalPlaces = 2;
            this.nupPeso.ForeColor = System.Drawing.Color.White;
            this.nupPeso.Location = new System.Drawing.Point(180, 168);
            this.nupPeso.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nupPeso.Minimum = new decimal(new int[] {
            1215752191,
            23,
            0,
            -2147483648});
            this.nupPeso.Name = "nupPeso";
            this.nupPeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nupPeso.Size = new System.Drawing.Size(122, 33);
            this.nupPeso.TabIndex = 8;
            this.nupPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupPeso.ThousandsSeparator = true;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(15, 173);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(109, 24);
            this.lblPeso.TabIndex = 7;
            this.lblPeso.Text = "Peso (KG)";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(13, 113);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(212, 24);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido Del Usuario";
            this.lblApellido.Visible = false;
            this.lblApellido.Click += new System.EventHandler(this.lblApellido_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.ForeColor = System.Drawing.Color.Gray;
            this.txtApellido.Location = new System.Drawing.Point(17, 113);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(288, 26);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.Text = "Apellido Del Usuario";
            this.txtApellido.Enter += new System.EventHandler(this.txtApellido_Enter);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(213, 24);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre Del Usuario";
            this.lblNombre.Visible = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalcular.Location = new System.Drawing.Point(617, 231);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(132, 35);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(17, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(288, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre Del Usuario";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineDividir,
            this.lineNombre,
            this.lineApellido});
            this.shapeContainer1.Size = new System.Drawing.Size(760, 452);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineDividir
            // 
            this.lineDividir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineDividir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lineDividir.Name = "lineDividir";
            this.lineDividir.X1 = 15;
            this.lineDividir.X2 = 759;
            this.lineDividir.Y1 = 275;
            this.lineDividir.Y2 = 275;
            // 
            // lineNombre
            // 
            this.lineNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lineNombre.Name = "lineNombre";
            this.lineNombre.X1 = 17;
            this.lineNombre.X2 = 304;
            this.lineNombre.Y1 = 60;
            this.lineNombre.Y2 = 60;
            // 
            // lineApellido
            // 
            this.lineApellido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lineApellido.Name = "lineApellido";
            this.lineApellido.X1 = 16;
            this.lineApellido.X2 = 303;
            this.lineApellido.Y1 = 139;
            this.lineApellido.Y2 = 139;
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarUsuario";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarUsuario";
            this.Load += new System.EventHandler(this.AgregarUsuario_Load);
            this.Resize += new System.EventHandler(this.AgregarUsuario_Resize);
            this.panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizarRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipalContenedor.ResumeLayout(false);
            this.panelPrincipalContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupBMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBMI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupEstatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPeso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelSuperior;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizarRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelPrincipalContenedor;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineApellido;
        private System.Windows.Forms.NumericUpDown nupPeso;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineNombre;
        private System.Windows.Forms.NumericUpDown nupEstatura;
        private System.Windows.Forms.Label lblEstatura;
        private System.Windows.Forms.DateTimePicker DateFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cmbNivelActividad;
        private System.Windows.Forms.Label lblNivelActividad;
        private System.Windows.Forms.ComboBox cmbGenero;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineDividir;
        private System.Windows.Forms.NumericUpDown nupBMR;
        private System.Windows.Forms.Label lblBMR;
        private System.Windows.Forms.NumericUpDown nupBMI;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblNivelActividadDescripcion;
        private System.Windows.Forms.TextBox txtaNivelActividad;
        private System.Windows.Forms.Label lblEstadoPeso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
    }
}