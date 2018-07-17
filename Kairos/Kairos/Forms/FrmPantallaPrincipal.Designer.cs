namespace Kairos.Forms
{
    partial class FrmPantallaPrincipal
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
            System.Windows.Forms.Label lblProyectosGuardados;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPantallaPrincipal));
            this.btnImportarProyecto = new System.Windows.Forms.Button();
            this.btnProcesarDatos = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.timerMensaje = new System.Windows.Forms.Timer(this.components);
            this.flowPanelBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProyectos = new System.Windows.Forms.Button();
            this.btnArduino = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelNotificaciones = new System.Windows.Forms.Panel();
            this.pnlProyectos = new System.Windows.Forms.Panel();
            this.panelNombreProyecto = new System.Windows.Forms.Panel();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.btnAceptarModificar = new System.Windows.Forms.Button();
            this.btnCancelarModificacion = new System.Windows.Forms.Button();
            this.imgBorrar = new System.Windows.Forms.PictureBox();
            this.imgEditar = new System.Windows.Forms.PictureBox();
            this.imgAgregar = new System.Windows.Forms.PictureBox();
            this.lbProyectosRecientes = new System.Windows.Forms.ListBox();
            this.pnlImportacion = new System.Windows.Forms.Panel();
            this.lblDestinoImportacion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbxProyectosExistentes = new System.Windows.Forms.ListBox();
            this.txtImportacionNombre = new System.Windows.Forms.TextBox();
            this.rbImportacionExistente = new System.Windows.Forms.RadioButton();
            this.rbImportacionNuevo = new System.Windows.Forms.RadioButton();
            this.pnlImportacionTxt = new System.Windows.Forms.Panel();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.rbEnter = new System.Windows.Forms.RadioButton();
            this.imgInformacion = new System.Windows.Forms.PictureBox();
            this.txtOtro = new System.Windows.Forms.TextBox();
            this.rbComa = new System.Windows.Forms.RadioButton();
            this.rbPipe = new System.Windows.Forms.RadioButton();
            this.rbTab = new System.Windows.Forms.RadioButton();
            this.btncancelarImportacion = new System.Windows.Forms.Button();
            this.pnlImportacionExcel = new System.Windows.Forms.Panel();
            this.nudFilaInicial = new System.Windows.Forms.NumericUpDown();
            this.nudColumna = new System.Windows.Forms.NumericUpDown();
            this.nudHoja = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAceptarImportacion = new System.Windows.Forms.Button();
            this.lblTituloImportacion = new System.Windows.Forms.Label();
            this.toolTipInformacion = new System.Windows.Forms.ToolTip(this.components);
            lblProyectosGuardados = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowPanelBotones.SuspendLayout();
            this.panelNotificaciones.SuspendLayout();
            this.pnlProyectos.SuspendLayout();
            this.panelNombreProyecto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAgregar)).BeginInit();
            this.pnlImportacion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlImportacionTxt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInformacion)).BeginInit();
            this.pnlImportacionExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilaInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoja)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProyectosGuardados
            // 
            lblProyectosGuardados.AutoSize = true;
            lblProyectosGuardados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblProyectosGuardados.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProyectosGuardados.ForeColor = System.Drawing.Color.Black;
            lblProyectosGuardados.Location = new System.Drawing.Point(-2, 8);
            lblProyectosGuardados.Margin = new System.Windows.Forms.Padding(0);
            lblProyectosGuardados.Name = "lblProyectosGuardados";
            lblProyectosGuardados.Size = new System.Drawing.Size(204, 24);
            lblProyectosGuardados.TabIndex = 25;
            lblProyectosGuardados.Text = "Proyectos Guardados";
            // 
            // btnImportarProyecto
            // 
            this.btnImportarProyecto.BackColor = System.Drawing.Color.Transparent;
            this.btnImportarProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnImportarProyecto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImportarProyecto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnImportarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarProyecto.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold);
            this.btnImportarProyecto.ForeColor = System.Drawing.Color.White;
            this.btnImportarProyecto.Location = new System.Drawing.Point(0, 164);
            this.btnImportarProyecto.Margin = new System.Windows.Forms.Padding(0);
            this.btnImportarProyecto.Name = "btnImportarProyecto";
            this.btnImportarProyecto.Size = new System.Drawing.Size(210, 82);
            this.btnImportarProyecto.TabIndex = 11;
            this.btnImportarProyecto.Text = "Importar Proyecto";
            this.btnImportarProyecto.UseVisualStyleBackColor = false;
            this.btnImportarProyecto.Click += new System.EventHandler(this.btnImportarProyecto_Click);
            // 
            // btnProcesarDatos
            // 
            this.btnProcesarDatos.BackColor = System.Drawing.Color.Transparent;
            this.btnProcesarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesarDatos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnProcesarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProcesarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnProcesarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesarDatos.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold);
            this.btnProcesarDatos.ForeColor = System.Drawing.Color.White;
            this.btnProcesarDatos.Location = new System.Drawing.Point(0, 82);
            this.btnProcesarDatos.Margin = new System.Windows.Forms.Padding(0);
            this.btnProcesarDatos.Name = "btnProcesarDatos";
            this.btnProcesarDatos.Size = new System.Drawing.Size(210, 82);
            this.btnProcesarDatos.TabIndex = 12;
            this.btnProcesarDatos.Text = "Procesar Datos";
            this.btnProcesarDatos.UseVisualStyleBackColor = false;
            this.btnProcesarDatos.Click += new System.EventHandler(this.btnProcesarDatos_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.White;
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(960, 81);
            this.panelTitulo.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 76);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kairós";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(871, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 83);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMensaje.Location = new System.Drawing.Point(11, 0);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(259, 21);
            this.lblMensaje.TabIndex = 21;
            this.lblMensaje.Text = "Esta es una notificación de prueba";
            // 
            // timerMensaje
            // 
            this.timerMensaje.Interval = 3000;
            this.timerMensaje.Tick += new System.EventHandler(this.timerMensaje_Tick);
            // 
            // flowPanelBotones
            // 
            this.flowPanelBotones.BackColor = System.Drawing.Color.Black;
            this.flowPanelBotones.Controls.Add(this.btnProyectos);
            this.flowPanelBotones.Controls.Add(this.btnProcesarDatos);
            this.flowPanelBotones.Controls.Add(this.btnImportarProyecto);
            this.flowPanelBotones.Controls.Add(this.btnArduino);
            this.flowPanelBotones.Location = new System.Drawing.Point(0, 81);
            this.flowPanelBotones.Margin = new System.Windows.Forms.Padding(0);
            this.flowPanelBotones.Name = "flowPanelBotones";
            this.flowPanelBotones.Size = new System.Drawing.Size(210, 447);
            this.flowPanelBotones.TabIndex = 22;
            // 
            // btnProyectos
            // 
            this.btnProyectos.BackColor = System.Drawing.Color.Transparent;
            this.btnProyectos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProyectos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnProyectos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProyectos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectos.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold);
            this.btnProyectos.ForeColor = System.Drawing.Color.White;
            this.btnProyectos.Location = new System.Drawing.Point(0, 0);
            this.btnProyectos.Margin = new System.Windows.Forms.Padding(0);
            this.btnProyectos.Name = "btnProyectos";
            this.btnProyectos.Size = new System.Drawing.Size(210, 82);
            this.btnProyectos.TabIndex = 13;
            this.btnProyectos.Text = "Proyectos";
            this.btnProyectos.UseVisualStyleBackColor = false;
            this.btnProyectos.Click += new System.EventHandler(this.btnProyectos_Click);
            // 
            // btnArduino
            // 
            this.btnArduino.BackColor = System.Drawing.Color.Transparent;
            this.btnArduino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArduino.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnArduino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnArduino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnArduino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArduino.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold);
            this.btnArduino.ForeColor = System.Drawing.Color.White;
            this.btnArduino.Location = new System.Drawing.Point(0, 246);
            this.btnArduino.Margin = new System.Windows.Forms.Padding(0);
            this.btnArduino.Name = "btnArduino";
            this.btnArduino.Size = new System.Drawing.Size(210, 82);
            this.btnArduino.TabIndex = 14;
            this.btnArduino.Text = "Módulo Arduino";
            this.btnArduino.UseVisualStyleBackColor = false;
            this.btnArduino.Click += new System.EventHandler(this.btnArduino_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 528);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(210, 57);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelNotificaciones
            // 
            this.panelNotificaciones.BackColor = System.Drawing.Color.Honeydew;
            this.panelNotificaciones.Controls.Add(this.lblMensaje);
            this.panelNotificaciones.Location = new System.Drawing.Point(210, 81);
            this.panelNotificaciones.Margin = new System.Windows.Forms.Padding(2);
            this.panelNotificaciones.Name = "panelNotificaciones";
            this.panelNotificaciones.Size = new System.Drawing.Size(750, 20);
            this.panelNotificaciones.TabIndex = 23;
            this.panelNotificaciones.Visible = false;
            // 
            // pnlProyectos
            // 
            this.pnlProyectos.Controls.Add(this.panelNombreProyecto);
            this.pnlProyectos.Controls.Add(this.imgBorrar);
            this.pnlProyectos.Controls.Add(this.imgEditar);
            this.pnlProyectos.Controls.Add(this.imgAgregar);
            this.pnlProyectos.Controls.Add(this.lbProyectosRecientes);
            this.pnlProyectos.Controls.Add(lblProyectosGuardados);
            this.pnlProyectos.Location = new System.Drawing.Point(229, 106);
            this.pnlProyectos.Name = "pnlProyectos";
            this.pnlProyectos.Size = new System.Drawing.Size(731, 479);
            this.pnlProyectos.TabIndex = 20;
            // 
            // panelNombreProyecto
            // 
            this.panelNombreProyecto.Controls.Add(this.txtNombreProyecto);
            this.panelNombreProyecto.Controls.Add(this.lblNombreProyecto);
            this.panelNombreProyecto.Controls.Add(this.btnAceptarModificar);
            this.panelNombreProyecto.Controls.Add(this.btnCancelarModificacion);
            this.panelNombreProyecto.Location = new System.Drawing.Point(403, 48);
            this.panelNombreProyecto.Margin = new System.Windows.Forms.Padding(2);
            this.panelNombreProyecto.Name = "panelNombreProyecto";
            this.panelNombreProyecto.Size = new System.Drawing.Size(330, 431);
            this.panelNombreProyecto.TabIndex = 30;
            this.panelNombreProyecto.Visible = false;
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtNombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProyecto.ForeColor = System.Drawing.Color.Maroon;
            this.txtNombreProyecto.Location = new System.Drawing.Point(9, 37);
            this.txtNombreProyecto.MaxLength = 32;
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(316, 26);
            this.txtNombreProyecto.TabIndex = 17;
            this.txtNombreProyecto.TextChanged += new System.EventHandler(this.txtNombreModificado_TextChanged);
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.AutoSize = true;
            this.lblNombreProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreProyecto.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProyecto.ForeColor = System.Drawing.Color.Black;
            this.lblNombreProyecto.Location = new System.Drawing.Point(5, 1);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(170, 24);
            this.lblNombreProyecto.TabIndex = 16;
            this.lblNombreProyecto.Text = "Nombre Proyecto";
            // 
            // btnAceptarModificar
            // 
            this.btnAceptarModificar.AutoSize = true;
            this.btnAceptarModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptarModificar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAceptarModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarModificar.FlatAppearance.BorderSize = 0;
            this.btnAceptarModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btnAceptarModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnAceptarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarModificar.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold);
            this.btnAceptarModificar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptarModificar.Location = new System.Drawing.Point(9, 71);
            this.btnAceptarModificar.Name = "btnAceptarModificar";
            this.btnAceptarModificar.Size = new System.Drawing.Size(84, 32);
            this.btnAceptarModificar.TabIndex = 18;
            this.btnAceptarModificar.Text = "Aceptar";
            this.btnAceptarModificar.UseVisualStyleBackColor = false;
            this.btnAceptarModificar.Visible = false;
            this.btnAceptarModificar.Click += new System.EventHandler(this.btnAceptarModificacion_Click);
            // 
            // btnCancelarModificacion
            // 
            this.btnCancelarModificacion.AutoSize = true;
            this.btnCancelarModificacion.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCancelarModificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarModificacion.FlatAppearance.BorderSize = 0;
            this.btnCancelarModificacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btnCancelarModificacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnCancelarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarModificacion.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold);
            this.btnCancelarModificacion.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarModificacion.Location = new System.Drawing.Point(224, 70);
            this.btnCancelarModificacion.Name = "btnCancelarModificacion";
            this.btnCancelarModificacion.Size = new System.Drawing.Size(100, 34);
            this.btnCancelarModificacion.TabIndex = 19;
            this.btnCancelarModificacion.Text = "Cancelar";
            this.btnCancelarModificacion.UseVisualStyleBackColor = false;
            this.btnCancelarModificacion.Click += new System.EventHandler(this.btnCancelarModificacion_Click);
            // 
            // imgBorrar
            // 
            this.imgBorrar.BackColor = System.Drawing.Color.Transparent;
            this.imgBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBorrar.Image = ((System.Drawing.Image)(resources.GetObject("imgBorrar.Image")));
            this.imgBorrar.Location = new System.Drawing.Point(353, 0);
            this.imgBorrar.Margin = new System.Windows.Forms.Padding(0);
            this.imgBorrar.Name = "imgBorrar";
            this.imgBorrar.Size = new System.Drawing.Size(37, 41);
            this.imgBorrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgBorrar.TabIndex = 29;
            this.imgBorrar.TabStop = false;
            this.imgBorrar.Click += new System.EventHandler(this.imgBorrar_Click);
            // 
            // imgEditar
            // 
            this.imgEditar.BackColor = System.Drawing.Color.Transparent;
            this.imgEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgEditar.Image = ((System.Drawing.Image)(resources.GetObject("imgEditar.Image")));
            this.imgEditar.Location = new System.Drawing.Point(316, 0);
            this.imgEditar.Margin = new System.Windows.Forms.Padding(0);
            this.imgEditar.Name = "imgEditar";
            this.imgEditar.Size = new System.Drawing.Size(37, 41);
            this.imgEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgEditar.TabIndex = 28;
            this.imgEditar.TabStop = false;
            this.imgEditar.Click += new System.EventHandler(this.imgEditar_Click);
            // 
            // imgAgregar
            // 
            this.imgAgregar.BackColor = System.Drawing.Color.Transparent;
            this.imgAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAgregar.Image = ((System.Drawing.Image)(resources.GetObject("imgAgregar.Image")));
            this.imgAgregar.Location = new System.Drawing.Point(279, 0);
            this.imgAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.imgAgregar.Name = "imgAgregar";
            this.imgAgregar.Size = new System.Drawing.Size(37, 41);
            this.imgAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgAgregar.TabIndex = 27;
            this.imgAgregar.TabStop = false;
            this.imgAgregar.Click += new System.EventHandler(this.imgAgregar_Click);
            // 
            // lbProyectosRecientes
            // 
            this.lbProyectosRecientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.lbProyectosRecientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbProyectosRecientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbProyectosRecientes.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.lbProyectosRecientes.ForeColor = System.Drawing.Color.Maroon;
            this.lbProyectosRecientes.FormattingEnabled = true;
            this.lbProyectosRecientes.ItemHeight = 20;
            this.lbProyectosRecientes.Location = new System.Drawing.Point(2, 48);
            this.lbProyectosRecientes.Margin = new System.Windows.Forms.Padding(0);
            this.lbProyectosRecientes.Name = "lbProyectosRecientes";
            this.lbProyectosRecientes.Size = new System.Drawing.Size(388, 420);
            this.lbProyectosRecientes.TabIndex = 26;
            // 
            // pnlImportacion
            // 
            this.pnlImportacion.Controls.Add(this.lblDestinoImportacion);
            this.pnlImportacion.Controls.Add(this.panel1);
            this.pnlImportacion.Controls.Add(this.pnlImportacionTxt);
            this.pnlImportacion.Controls.Add(this.btncancelarImportacion);
            this.pnlImportacion.Controls.Add(this.pnlImportacionExcel);
            this.pnlImportacion.Controls.Add(this.btnAceptarImportacion);
            this.pnlImportacion.Controls.Add(this.lblTituloImportacion);
            this.pnlImportacion.Location = new System.Drawing.Point(229, 105);
            this.pnlImportacion.Name = "pnlImportacion";
            this.pnlImportacion.Size = new System.Drawing.Size(733, 480);
            this.pnlImportacion.TabIndex = 24;
            this.pnlImportacion.Visible = false;
            // 
            // lblDestinoImportacion
            // 
            this.lblDestinoImportacion.AutoSize = true;
            this.lblDestinoImportacion.Font = new System.Drawing.Font("Book Antiqua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDestinoImportacion.Location = new System.Drawing.Point(350, 12);
            this.lblDestinoImportacion.Name = "lblDestinoImportacion";
            this.lblDestinoImportacion.Size = new System.Drawing.Size(350, 25);
            this.lblDestinoImportacion.TabIndex = 32;
            this.lblDestinoImportacion.Text = "Indique el destino de la importacion";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbxProyectosExistentes);
            this.panel1.Controls.Add(this.txtImportacionNombre);
            this.panel1.Controls.Add(this.rbImportacionExistente);
            this.panel1.Controls.Add(this.rbImportacionNuevo);
            this.panel1.Location = new System.Drawing.Point(322, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 358);
            this.panel1.TabIndex = 31;
            // 
            // lbxProyectosExistentes
            // 
            this.lbxProyectosExistentes.FormattingEnabled = true;
            this.lbxProyectosExistentes.Location = new System.Drawing.Point(17, 36);
            this.lbxProyectosExistentes.Name = "lbxProyectosExistentes";
            this.lbxProyectosExistentes.Size = new System.Drawing.Size(326, 316);
            this.lbxProyectosExistentes.TabIndex = 3;
            this.lbxProyectosExistentes.Visible = false;
            this.lbxProyectosExistentes.SelectedIndexChanged += new System.EventHandler(this.lbxProyectosExistentes_SelectedIndexChanged);
            // 
            // txtImportacionNombre
            // 
            this.txtImportacionNombre.Location = new System.Drawing.Point(17, 36);
            this.txtImportacionNombre.Name = "txtImportacionNombre";
            this.txtImportacionNombre.Size = new System.Drawing.Size(326, 20);
            this.txtImportacionNombre.TabIndex = 2;
            this.txtImportacionNombre.TextChanged += new System.EventHandler(this.txtImportacionNombre_TextChanged);
            // 
            // rbImportacionExistente
            // 
            this.rbImportacionExistente.AutoSize = true;
            this.rbImportacionExistente.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rbImportacionExistente.Location = new System.Drawing.Point(192, 8);
            this.rbImportacionExistente.Name = "rbImportacionExistente";
            this.rbImportacionExistente.Size = new System.Drawing.Size(151, 22);
            this.rbImportacionExistente.TabIndex = 1;
            this.rbImportacionExistente.Text = "Proyecto existente";
            this.rbImportacionExistente.UseVisualStyleBackColor = true;
            // 
            // rbImportacionNuevo
            // 
            this.rbImportacionNuevo.AutoSize = true;
            this.rbImportacionNuevo.Checked = true;
            this.rbImportacionNuevo.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rbImportacionNuevo.Location = new System.Drawing.Point(17, 8);
            this.rbImportacionNuevo.Name = "rbImportacionNuevo";
            this.rbImportacionNuevo.Size = new System.Drawing.Size(131, 22);
            this.rbImportacionNuevo.TabIndex = 0;
            this.rbImportacionNuevo.TabStop = true;
            this.rbImportacionNuevo.Text = "Nuevo proyecto";
            this.rbImportacionNuevo.UseVisualStyleBackColor = true;
            this.rbImportacionNuevo.CheckedChanged += new System.EventHandler(this.rbImportacionNuevo_CheckedChanged);
            // 
            // pnlImportacionTxt
            // 
            this.pnlImportacionTxt.Controls.Add(this.rbOtro);
            this.pnlImportacionTxt.Controls.Add(this.rbEnter);
            this.pnlImportacionTxt.Controls.Add(this.imgInformacion);
            this.pnlImportacionTxt.Controls.Add(this.txtOtro);
            this.pnlImportacionTxt.Controls.Add(this.rbComa);
            this.pnlImportacionTxt.Controls.Add(this.rbPipe);
            this.pnlImportacionTxt.Controls.Add(this.rbTab);
            this.pnlImportacionTxt.Location = new System.Drawing.Point(40, 45);
            this.pnlImportacionTxt.Name = "pnlImportacionTxt";
            this.pnlImportacionTxt.Size = new System.Drawing.Size(276, 141);
            this.pnlImportacionTxt.TabIndex = 30;
            this.pnlImportacionTxt.Visible = false;
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOtro.Location = new System.Drawing.Point(14, 99);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(59, 22);
            this.rbOtro.TabIndex = 28;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            this.rbOtro.CheckedChanged += new System.EventHandler(this.rbOtro_CheckedChanged);
            // 
            // rbEnter
            // 
            this.rbEnter.AutoSize = true;
            this.rbEnter.Checked = true;
            this.rbEnter.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEnter.Location = new System.Drawing.Point(14, 8);
            this.rbEnter.Name = "rbEnter";
            this.rbEnter.Size = new System.Drawing.Size(62, 22);
            this.rbEnter.TabIndex = 26;
            this.rbEnter.TabStop = true;
            this.rbEnter.Text = "Enter";
            this.rbEnter.UseVisualStyleBackColor = true;
            // 
            // imgInformacion
            // 
            this.imgInformacion.AccessibleDescription = "";
            this.imgInformacion.Image = ((System.Drawing.Image)(resources.GetObject("imgInformacion.Image")));
            this.imgInformacion.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgInformacion.InitialImage")));
            this.imgInformacion.Location = new System.Drawing.Point(185, 99);
            this.imgInformacion.Name = "imgInformacion";
            this.imgInformacion.Size = new System.Drawing.Size(27, 29);
            this.imgInformacion.TabIndex = 27;
            this.imgInformacion.TabStop = false;
            this.imgInformacion.Tag = "";
            this.toolTipInformacion.SetToolTip(this.imgInformacion, "No están permitidos los valores: \".\"   \"-\"   \":\"    \" \" (espacio)");
            // 
            // txtOtro
            // 
            this.txtOtro.BackColor = System.Drawing.Color.LightGray;
            this.txtOtro.Enabled = false;
            this.txtOtro.Location = new System.Drawing.Point(79, 101);
            this.txtOtro.Name = "txtOtro";
            this.txtOtro.Size = new System.Drawing.Size(100, 20);
            this.txtOtro.TabIndex = 22;
            this.txtOtro.TextChanged += new System.EventHandler(this.txtOtro_TextChanged);
            // 
            // rbComa
            // 
            this.rbComa.AutoSize = true;
            this.rbComa.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbComa.Location = new System.Drawing.Point(14, 30);
            this.rbComa.Name = "rbComa";
            this.rbComa.Size = new System.Drawing.Size(91, 22);
            this.rbComa.TabIndex = 23;
            this.rbComa.Text = "Coma ( , )";
            this.rbComa.UseVisualStyleBackColor = true;
            // 
            // rbPipe
            // 
            this.rbPipe.AutoSize = true;
            this.rbPipe.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPipe.Location = new System.Drawing.Point(14, 54);
            this.rbPipe.Name = "rbPipe";
            this.rbPipe.Size = new System.Drawing.Size(87, 22);
            this.rbPipe.TabIndex = 24;
            this.rbPipe.Text = "Pipe ( | )";
            this.rbPipe.UseVisualStyleBackColor = true;
            // 
            // rbTab
            // 
            this.rbTab.AutoSize = true;
            this.rbTab.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTab.Location = new System.Drawing.Point(14, 77);
            this.rbTab.Name = "rbTab";
            this.rbTab.Size = new System.Drawing.Size(51, 22);
            this.rbTab.TabIndex = 25;
            this.rbTab.Text = "Tab";
            this.rbTab.UseVisualStyleBackColor = true;
            // 
            // btncancelarImportacion
            // 
            this.btncancelarImportacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btncancelarImportacion.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelarImportacion.ForeColor = System.Drawing.Color.White;
            this.btncancelarImportacion.Location = new System.Drawing.Point(204, 209);
            this.btncancelarImportacion.Name = "btncancelarImportacion";
            this.btncancelarImportacion.Size = new System.Drawing.Size(84, 30);
            this.btncancelarImportacion.TabIndex = 29;
            this.btncancelarImportacion.Text = "Cancelar";
            this.btncancelarImportacion.UseVisualStyleBackColor = false;
            this.btncancelarImportacion.Click += new System.EventHandler(this.btncancelarImportacion_Click);
            // 
            // pnlImportacionExcel
            // 
            this.pnlImportacionExcel.Controls.Add(this.nudFilaInicial);
            this.pnlImportacionExcel.Controls.Add(this.nudColumna);
            this.pnlImportacionExcel.Controls.Add(this.nudHoja);
            this.pnlImportacionExcel.Controls.Add(this.label3);
            this.pnlImportacionExcel.Controls.Add(this.label2);
            this.pnlImportacionExcel.Controls.Add(this.label4);
            this.pnlImportacionExcel.Location = new System.Drawing.Point(78, 53);
            this.pnlImportacionExcel.Name = "pnlImportacionExcel";
            this.pnlImportacionExcel.Size = new System.Drawing.Size(173, 108);
            this.pnlImportacionExcel.TabIndex = 21;
            this.pnlImportacionExcel.Visible = false;
            // 
            // nudFilaInicial
            // 
            this.nudFilaInicial.BackColor = System.Drawing.Color.White;
            this.nudFilaInicial.Location = new System.Drawing.Point(101, 79);
            this.nudFilaInicial.Name = "nudFilaInicial";
            this.nudFilaInicial.Size = new System.Drawing.Size(41, 20);
            this.nudFilaInicial.TabIndex = 26;
            this.nudFilaInicial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudColumna
            // 
            this.nudColumna.BackColor = System.Drawing.Color.White;
            this.nudColumna.Location = new System.Drawing.Point(101, 46);
            this.nudColumna.Name = "nudColumna";
            this.nudColumna.Size = new System.Drawing.Size(41, 20);
            this.nudColumna.TabIndex = 25;
            this.nudColumna.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudHoja
            // 
            this.nudHoja.BackColor = System.Drawing.Color.White;
            this.nudHoja.Location = new System.Drawing.Point(101, 11);
            this.nudHoja.Name = "nudHoja";
            this.nudHoja.Size = new System.Drawing.Size(41, 20);
            this.nudHoja.TabIndex = 24;
            this.nudHoja.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Hoja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fila Inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Columna";
            // 
            // btnAceptarImportacion
            // 
            this.btnAceptarImportacion.BackColor = System.Drawing.Color.LightGray;
            this.btnAceptarImportacion.Enabled = false;
            this.btnAceptarImportacion.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarImportacion.ForeColor = System.Drawing.Color.White;
            this.btnAceptarImportacion.Location = new System.Drawing.Point(84, 209);
            this.btnAceptarImportacion.Name = "btnAceptarImportacion";
            this.btnAceptarImportacion.Size = new System.Drawing.Size(84, 30);
            this.btnAceptarImportacion.TabIndex = 28;
            this.btnAceptarImportacion.Text = "Aceptar";
            this.btnAceptarImportacion.UseVisualStyleBackColor = false;
            this.btnAceptarImportacion.Click += new System.EventHandler(this.btnAceptarImportacion_Click);
            // 
            // lblTituloImportacion
            // 
            this.lblTituloImportacion.AutoSize = true;
            this.lblTituloImportacion.Font = new System.Drawing.Font("Book Antiqua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloImportacion.Location = new System.Drawing.Point(3, 9);
            this.lblTituloImportacion.Name = "lblTituloImportacion";
            this.lblTituloImportacion.Size = new System.Drawing.Size(320, 25);
            this.lblTituloImportacion.TabIndex = 27;
            this.lblTituloImportacion.Text = "Indique la ubicación de los datos";
            // 
            // FrmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.pnlImportacion);
            this.Controls.Add(this.panelNotificaciones);
            this.Controls.Add(this.flowPanelBotones);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnlProyectos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPantallaPrincipal";
            this.Opacity = 0.985D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kairós";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowPanelBotones.ResumeLayout(false);
            this.panelNotificaciones.ResumeLayout(false);
            this.panelNotificaciones.PerformLayout();
            this.pnlProyectos.ResumeLayout(false);
            this.pnlProyectos.PerformLayout();
            this.panelNombreProyecto.ResumeLayout(false);
            this.panelNombreProyecto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAgregar)).EndInit();
            this.pnlImportacion.ResumeLayout(false);
            this.pnlImportacion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlImportacionTxt.ResumeLayout(false);
            this.pnlImportacionTxt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInformacion)).EndInit();
            this.pnlImportacionExcel.ResumeLayout(false);
            this.pnlImportacionExcel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilaInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnImportarProyecto;
        private System.Windows.Forms.Button btnProcesarDatos;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Timer timerMensaje;
        private System.Windows.Forms.FlowLayoutPanel flowPanelBotones;
        private System.Windows.Forms.Panel panelNotificaciones;
        private System.Windows.Forms.Button btnProyectos;
        private System.Windows.Forms.Button btnArduino;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlProyectos;
        private System.Windows.Forms.Panel panelNombreProyecto;
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.Label lblNombreProyecto;
        private System.Windows.Forms.Button btnAceptarModificar;
        private System.Windows.Forms.Button btnCancelarModificacion;
        private System.Windows.Forms.PictureBox imgBorrar;
        private System.Windows.Forms.PictureBox imgEditar;
        private System.Windows.Forms.PictureBox imgAgregar;
        private System.Windows.Forms.ListBox lbProyectosRecientes;
        private System.Windows.Forms.Panel pnlImportacion;
        private System.Windows.Forms.Panel pnlImportacionExcel;
        private System.Windows.Forms.Button btncancelarImportacion;
        private System.Windows.Forms.Button btnAceptarImportacion;
        private System.Windows.Forms.Label lblTituloImportacion;
        private System.Windows.Forms.NumericUpDown nudFilaInicial;
        private System.Windows.Forms.NumericUpDown nudColumna;
        private System.Windows.Forms.NumericUpDown nudHoja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlImportacionTxt;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbEnter;
        private System.Windows.Forms.PictureBox imgInformacion;
        private System.Windows.Forms.TextBox txtOtro;
        private System.Windows.Forms.RadioButton rbComa;
        private System.Windows.Forms.RadioButton rbPipe;
        private System.Windows.Forms.RadioButton rbTab;
        private System.Windows.Forms.ToolTip toolTipInformacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDestinoImportacion;
        private System.Windows.Forms.RadioButton rbImportacionExistente;
        private System.Windows.Forms.RadioButton rbImportacionNuevo;
        private System.Windows.Forms.ListBox lbxProyectosExistentes;
        private System.Windows.Forms.TextBox txtImportacionNombre;
    }
}