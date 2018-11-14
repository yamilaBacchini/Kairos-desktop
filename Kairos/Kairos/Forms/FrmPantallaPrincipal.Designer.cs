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
            this.timerMensaje = new System.Windows.Forms.Timer(this.components);
            this.flowPanelBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnArduino = new System.Windows.Forms.Button();
            this.btnImportarDesdeDB = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelNotificaciones = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pnlProyectos = new System.Windows.Forms.Panel();
            this.pnlImportacionDB = new System.Windows.Forms.Panel();
            this.btnCancelarImportacionDB = new System.Windows.Forms.Button();
            this.btnAceptarImportacionDB = new System.Windows.Forms.Button();
            this.chUsuarioYContrasenia = new System.Windows.Forms.CheckBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreColumna = new System.Windows.Forms.TextBox();
            this.txtNombreTabla = new System.Windows.Forms.TextBox();
            this.txtNombreDB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreServidor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNombreDeColumna = new System.Windows.Forms.Label();
            this.lblNombreTabla = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNombreBaseDeDatos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imgBorrar = new System.Windows.Forms.PictureBox();
            this.imgEditar = new System.Windows.Forms.PictureBox();
            this.imgAgregar = new System.Windows.Forms.PictureBox();
            this.lbProyectosRecientes = new System.Windows.Forms.ListBox();
            this.pnlImportacion = new System.Windows.Forms.Panel();
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
            this.panelNombreProyecto = new System.Windows.Forms.Panel();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.btnAceptarModificar = new System.Windows.Forms.Button();
            this.btnCancelarModificacion = new System.Windows.Forms.Button();
            this.toolTipInformacion = new System.Windows.Forms.ToolTip(this.components);
            lblProyectosGuardados = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowPanelBotones.SuspendLayout();
            this.panelNotificaciones.SuspendLayout();
            this.pnlProyectos.SuspendLayout();
            this.pnlImportacionDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAgregar)).BeginInit();
            this.pnlImportacion.SuspendLayout();
            this.pnlImportacionTxt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInformacion)).BeginInit();
            this.pnlImportacionExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilaInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoja)).BeginInit();
            this.panelNombreProyecto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProyectosGuardados
            // 
            lblProyectosGuardados.AutoSize = true;
            lblProyectosGuardados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblProyectosGuardados.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProyectosGuardados.ForeColor = System.Drawing.Color.Black;
            lblProyectosGuardados.Location = new System.Drawing.Point(61, 10);
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
            this.btnImportarProyecto.Enabled = false;
            this.btnImportarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnImportarProyecto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImportarProyecto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnImportarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarProyecto.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold);
            this.btnImportarProyecto.ForeColor = System.Drawing.Color.White;
            this.btnImportarProyecto.Location = new System.Drawing.Point(0, 82);
            this.btnImportarProyecto.Margin = new System.Windows.Forms.Padding(0);
            this.btnImportarProyecto.Name = "btnImportarProyecto";
            this.btnImportarProyecto.Padding = new System.Windows.Forms.Padding(38, 0, 38, 0);
            this.btnImportarProyecto.Size = new System.Drawing.Size(210, 82);
            this.btnImportarProyecto.TabIndex = 11;
            this.btnImportarProyecto.Text = "Importar Archivo Local";
            this.btnImportarProyecto.UseVisualStyleBackColor = false;
            this.btnImportarProyecto.Click += new System.EventHandler(this.btnImportarProyecto_Click);
            // 
            // btnProcesarDatos
            // 
            this.btnProcesarDatos.BackColor = System.Drawing.Color.Transparent;
            this.btnProcesarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesarDatos.Enabled = false;
            this.btnProcesarDatos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnProcesarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProcesarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnProcesarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesarDatos.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold);
            this.btnProcesarDatos.ForeColor = System.Drawing.Color.White;
            this.btnProcesarDatos.Location = new System.Drawing.Point(0, 0);
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
            this.label1.Location = new System.Drawing.Point(375, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 76);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kairós";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(871, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 73);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // timerMensaje
            // 
            this.timerMensaje.Interval = 3000;
            this.timerMensaje.Tick += new System.EventHandler(this.timerMensaje_Tick);
            // 
            // flowPanelBotones
            // 
            this.flowPanelBotones.BackColor = System.Drawing.Color.Black;
            this.flowPanelBotones.Controls.Add(this.btnProcesarDatos);
            this.flowPanelBotones.Controls.Add(this.btnImportarProyecto);
            this.flowPanelBotones.Controls.Add(this.btnArduino);
            this.flowPanelBotones.Controls.Add(this.btnImportarDesdeDB);
            this.flowPanelBotones.Location = new System.Drawing.Point(0, 81);
            this.flowPanelBotones.Margin = new System.Windows.Forms.Padding(0);
            this.flowPanelBotones.Name = "flowPanelBotones";
            this.flowPanelBotones.Size = new System.Drawing.Size(210, 447);
            this.flowPanelBotones.TabIndex = 22;
            // 
            // btnArduino
            // 
            this.btnArduino.BackColor = System.Drawing.Color.Transparent;
            this.btnArduino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArduino.Enabled = false;
            this.btnArduino.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnArduino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnArduino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnArduino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArduino.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold);
            this.btnArduino.ForeColor = System.Drawing.Color.White;
            this.btnArduino.Location = new System.Drawing.Point(0, 164);
            this.btnArduino.Margin = new System.Windows.Forms.Padding(0);
            this.btnArduino.Name = "btnArduino";
            this.btnArduino.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnArduino.Size = new System.Drawing.Size(210, 82);
            this.btnArduino.TabIndex = 14;
            this.btnArduino.Text = "Captura mediante Sensor Infrarrojo";
            this.btnArduino.UseVisualStyleBackColor = false;
            this.btnArduino.Click += new System.EventHandler(this.btnArduino_Click);
            // 
            // btnImportarDesdeDB
            // 
            this.btnImportarDesdeDB.BackColor = System.Drawing.Color.Transparent;
            this.btnImportarDesdeDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportarDesdeDB.Enabled = false;
            this.btnImportarDesdeDB.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnImportarDesdeDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImportarDesdeDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnImportarDesdeDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarDesdeDB.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold);
            this.btnImportarDesdeDB.ForeColor = System.Drawing.Color.White;
            this.btnImportarDesdeDB.Location = new System.Drawing.Point(0, 246);
            this.btnImportarDesdeDB.Margin = new System.Windows.Forms.Padding(0);
            this.btnImportarDesdeDB.Name = "btnImportarDesdeDB";
            this.btnImportarDesdeDB.Padding = new System.Windows.Forms.Padding(38, 0, 38, 0);
            this.btnImportarDesdeDB.Size = new System.Drawing.Size(210, 82);
            this.btnImportarDesdeDB.TabIndex = 15;
            this.btnImportarDesdeDB.Text = "Importar desde DB";
            this.btnImportarDesdeDB.UseVisualStyleBackColor = false;
            this.btnImportarDesdeDB.Click += new System.EventHandler(this.btnImportarDesdeDB_Click);
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
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(0, 1);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(750, 19);
            this.lblMensaje.TabIndex = 23;
            this.lblMensaje.Text = "Mensaje";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensaje.Visible = false;
            // 
            // pnlProyectos
            // 
            this.pnlProyectos.Controls.Add(this.pnlImportacionDB);
            this.pnlProyectos.Controls.Add(this.imgBorrar);
            this.pnlProyectos.Controls.Add(this.imgEditar);
            this.pnlProyectos.Controls.Add(this.imgAgregar);
            this.pnlProyectos.Controls.Add(this.lbProyectosRecientes);
            this.pnlProyectos.Controls.Add(lblProyectosGuardados);
            this.pnlProyectos.Controls.Add(this.pnlImportacion);
            this.pnlProyectos.Controls.Add(this.panelNombreProyecto);
            this.pnlProyectos.Location = new System.Drawing.Point(210, 100);
            this.pnlProyectos.Name = "pnlProyectos";
            this.pnlProyectos.Size = new System.Drawing.Size(750, 485);
            this.pnlProyectos.TabIndex = 20;
            // 
            // pnlImportacionDB
            // 
            this.pnlImportacionDB.Controls.Add(this.btnCancelarImportacionDB);
            this.pnlImportacionDB.Controls.Add(this.btnAceptarImportacionDB);
            this.pnlImportacionDB.Controls.Add(this.chUsuarioYContrasenia);
            this.pnlImportacionDB.Controls.Add(this.txtContrasenia);
            this.pnlImportacionDB.Controls.Add(this.txtUsuario);
            this.pnlImportacionDB.Controls.Add(this.txtNombreColumna);
            this.pnlImportacionDB.Controls.Add(this.txtNombreTabla);
            this.pnlImportacionDB.Controls.Add(this.txtNombreDB);
            this.pnlImportacionDB.Controls.Add(this.label6);
            this.pnlImportacionDB.Controls.Add(this.txtNombreServidor);
            this.pnlImportacionDB.Controls.Add(this.label7);
            this.pnlImportacionDB.Controls.Add(this.lblNombreDeColumna);
            this.pnlImportacionDB.Controls.Add(this.lblNombreTabla);
            this.pnlImportacionDB.Controls.Add(this.label8);
            this.pnlImportacionDB.Controls.Add(this.lblNombreBaseDeDatos);
            this.pnlImportacionDB.Controls.Add(this.label5);
            this.pnlImportacionDB.Location = new System.Drawing.Point(403, 48);
            this.pnlImportacionDB.Name = "pnlImportacionDB";
            this.pnlImportacionDB.Size = new System.Drawing.Size(327, 344);
            this.pnlImportacionDB.TabIndex = 31;
            this.pnlImportacionDB.Visible = false;
            // 
            // btnCancelarImportacionDB
            // 
            this.btnCancelarImportacionDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCancelarImportacionDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarImportacionDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnCancelarImportacionDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarImportacionDB.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarImportacionDB.ForeColor = System.Drawing.Color.White;
            this.btnCancelarImportacionDB.Location = new System.Drawing.Point(170, 297);
            this.btnCancelarImportacionDB.Name = "btnCancelarImportacionDB";
            this.btnCancelarImportacionDB.Size = new System.Drawing.Size(84, 30);
            this.btnCancelarImportacionDB.TabIndex = 31;
            this.btnCancelarImportacionDB.Text = "Cancelar";
            this.btnCancelarImportacionDB.UseVisualStyleBackColor = false;
            this.btnCancelarImportacionDB.Click += new System.EventHandler(this.btnCancelarImportacionDB_Click);
            // 
            // btnAceptarImportacionDB
            // 
            this.btnAceptarImportacionDB.BackColor = System.Drawing.Color.LightGray;
            this.btnAceptarImportacionDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarImportacionDB.Enabled = false;
            this.btnAceptarImportacionDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnAceptarImportacionDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarImportacionDB.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarImportacionDB.ForeColor = System.Drawing.Color.White;
            this.btnAceptarImportacionDB.Location = new System.Drawing.Point(64, 297);
            this.btnAceptarImportacionDB.Name = "btnAceptarImportacionDB";
            this.btnAceptarImportacionDB.Size = new System.Drawing.Size(84, 30);
            this.btnAceptarImportacionDB.TabIndex = 31;
            this.btnAceptarImportacionDB.Text = "Aceptar";
            this.btnAceptarImportacionDB.UseVisualStyleBackColor = false;
            this.btnAceptarImportacionDB.Click += new System.EventHandler(this.btnAceptarImportacionDB_Click);
            // 
            // chUsuarioYContrasenia
            // 
            this.chUsuarioYContrasenia.AutoSize = true;
            this.chUsuarioYContrasenia.Font = new System.Drawing.Font("Book Antiqua", 9.25F);
            this.chUsuarioYContrasenia.Location = new System.Drawing.Point(18, 158);
            this.chUsuarioYContrasenia.Name = "chUsuarioYContrasenia";
            this.chUsuarioYContrasenia.Size = new System.Drawing.Size(151, 21);
            this.chUsuarioYContrasenia.TabIndex = 45;
            this.chUsuarioYContrasenia.Text = "Usuario y contraseña";
            this.chUsuarioYContrasenia.UseVisualStyleBackColor = true;
            this.chUsuarioYContrasenia.CheckedChanged += new System.EventHandler(this.chUsuarioYContrasenia_CheckedChanged);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.Color.LightGray;
            this.txtContrasenia.Enabled = false;
            this.txtContrasenia.Location = new System.Drawing.Point(139, 218);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(166, 20);
            this.txtContrasenia.TabIndex = 44;
            this.txtContrasenia.TextChanged += new System.EventHandler(this.txtContrasenia_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.LightGray;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(139, 188);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(166, 20);
            this.txtUsuario.TabIndex = 43;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtNombreColumna
            // 
            this.txtNombreColumna.Location = new System.Drawing.Point(139, 129);
            this.txtNombreColumna.Name = "txtNombreColumna";
            this.txtNombreColumna.Size = new System.Drawing.Size(166, 20);
            this.txtNombreColumna.TabIndex = 42;
            this.txtNombreColumna.TextChanged += new System.EventHandler(this.txtNombreColumna_TextChanged);
            // 
            // txtNombreTabla
            // 
            this.txtNombreTabla.Location = new System.Drawing.Point(139, 99);
            this.txtNombreTabla.Name = "txtNombreTabla";
            this.txtNombreTabla.Size = new System.Drawing.Size(166, 20);
            this.txtNombreTabla.TabIndex = 41;
            this.txtNombreTabla.TextChanged += new System.EventHandler(this.txtNombreTabla_TextChanged);
            // 
            // txtNombreDB
            // 
            this.txtNombreDB.Location = new System.Drawing.Point(139, 69);
            this.txtNombreDB.Name = "txtNombreDB";
            this.txtNombreDB.Size = new System.Drawing.Size(166, 20);
            this.txtNombreDB.TabIndex = 40;
            this.txtNombreDB.TextChanged += new System.EventHandler(this.txtNombreDB_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Contraseña";
            // 
            // txtNombreServidor
            // 
            this.txtNombreServidor.Location = new System.Drawing.Point(139, 38);
            this.txtNombreServidor.Name = "txtNombreServidor";
            this.txtNombreServidor.Size = new System.Drawing.Size(166, 20);
            this.txtNombreServidor.TabIndex = 38;
            this.txtNombreServidor.TextChanged += new System.EventHandler(this.txtNombreServidor_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Servidor:";
            // 
            // lblNombreDeColumna
            // 
            this.lblNombreDeColumna.AutoSize = true;
            this.lblNombreDeColumna.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDeColumna.Location = new System.Drawing.Point(14, 129);
            this.lblNombreDeColumna.Name = "lblNombreDeColumna";
            this.lblNombreDeColumna.Size = new System.Drawing.Size(79, 20);
            this.lblNombreDeColumna.TabIndex = 32;
            this.lblNombreDeColumna.Text = "Columna: ";
            // 
            // lblNombreTabla
            // 
            this.lblNombreTabla.AutoSize = true;
            this.lblNombreTabla.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTabla.Location = new System.Drawing.Point(14, 99);
            this.lblNombreTabla.Name = "lblNombreTabla";
            this.lblNombreTabla.Size = new System.Drawing.Size(54, 20);
            this.lblNombreTabla.TabIndex = 31;
            this.lblNombreTabla.Text = "Tabla: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Usuario";
            // 
            // lblNombreBaseDeDatos
            // 
            this.lblNombreBaseDeDatos.AutoSize = true;
            this.lblNombreBaseDeDatos.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreBaseDeDatos.Location = new System.Drawing.Point(14, 69);
            this.lblNombreBaseDeDatos.Name = "lblNombreBaseDeDatos";
            this.lblNombreBaseDeDatos.Size = new System.Drawing.Size(111, 20);
            this.lblNombreBaseDeDatos.TabIndex = 30;
            this.lblNombreBaseDeDatos.Text = "Base de datos:  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Indique la ubicación de los datos";
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
            this.lbProyectosRecientes.Location = new System.Drawing.Point(2, 53);
            this.lbProyectosRecientes.Margin = new System.Windows.Forms.Padding(0);
            this.lbProyectosRecientes.Name = "lbProyectosRecientes";
            this.lbProyectosRecientes.Size = new System.Drawing.Size(388, 420);
            this.lbProyectosRecientes.TabIndex = 26;
            this.lbProyectosRecientes.SelectedIndexChanged += new System.EventHandler(this.lbProyectosRecientes_SelectedIndexChanged);
            // 
            // pnlImportacion
            // 
            this.pnlImportacion.BackColor = System.Drawing.Color.Transparent;
            this.pnlImportacion.Controls.Add(this.pnlImportacionTxt);
            this.pnlImportacion.Controls.Add(this.btncancelarImportacion);
            this.pnlImportacion.Controls.Add(this.pnlImportacionExcel);
            this.pnlImportacion.Controls.Add(this.btnAceptarImportacion);
            this.pnlImportacion.Controls.Add(this.lblTituloImportacion);
            this.pnlImportacion.Location = new System.Drawing.Point(401, 51);
            this.pnlImportacion.Name = "pnlImportacion";
            this.pnlImportacion.Size = new System.Drawing.Size(327, 391);
            this.pnlImportacion.TabIndex = 24;
            this.pnlImportacion.Visible = false;
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
            this.btncancelarImportacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btncancelarImportacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelarImportacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btncancelarImportacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btnAceptarImportacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAceptarImportacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarImportacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnAceptarImportacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.lblTituloImportacion.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloImportacion.Location = new System.Drawing.Point(3, 9);
            this.lblTituloImportacion.Name = "lblTituloImportacion";
            this.lblTituloImportacion.Size = new System.Drawing.Size(301, 23);
            this.lblTituloImportacion.TabIndex = 27;
            this.lblTituloImportacion.Text = "Indique la ubicación de los datos";
            // 
            // panelNombreProyecto
            // 
            this.panelNombreProyecto.BackColor = System.Drawing.Color.Transparent;
            this.panelNombreProyecto.Controls.Add(this.txtNombreProyecto);
            this.panelNombreProyecto.Controls.Add(this.lblNombreProyecto);
            this.panelNombreProyecto.Controls.Add(this.btnAceptarModificar);
            this.panelNombreProyecto.Controls.Add(this.btnCancelarModificacion);
            this.panelNombreProyecto.Location = new System.Drawing.Point(403, 48);
            this.panelNombreProyecto.Margin = new System.Windows.Forms.Padding(2);
            this.panelNombreProyecto.Name = "panelNombreProyecto";
            this.panelNombreProyecto.Size = new System.Drawing.Size(330, 425);
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
            this.lblNombreProyecto.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProyecto.ForeColor = System.Drawing.Color.Black;
            this.lblNombreProyecto.Location = new System.Drawing.Point(5, 1);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(164, 23);
            this.lblNombreProyecto.TabIndex = 16;
            this.lblNombreProyecto.Text = "Nombre Proyecto";
            // 
            // btnAceptarModificar
            // 
            this.btnAceptarModificar.AutoSize = true;
            this.btnAceptarModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptarModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAceptarModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnAceptarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarModificar.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold);
            this.btnAceptarModificar.ForeColor = System.Drawing.Color.White;
            this.btnAceptarModificar.Location = new System.Drawing.Point(9, 71);
            this.btnAceptarModificar.Name = "btnAceptarModificar";
            this.btnAceptarModificar.Size = new System.Drawing.Size(86, 34);
            this.btnAceptarModificar.TabIndex = 18;
            this.btnAceptarModificar.Text = "Aceptar";
            this.btnAceptarModificar.UseVisualStyleBackColor = false;
            this.btnAceptarModificar.Visible = false;
            this.btnAceptarModificar.Click += new System.EventHandler(this.btnAceptarModificacion_Click);
            // 
            // btnCancelarModificacion
            // 
            this.btnCancelarModificacion.AutoSize = true;
            this.btnCancelarModificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCancelarModificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarModificacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnCancelarModificacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnCancelarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarModificacion.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold);
            this.btnCancelarModificacion.ForeColor = System.Drawing.Color.White;
            this.btnCancelarModificacion.Location = new System.Drawing.Point(214, 71);
            this.btnCancelarModificacion.Name = "btnCancelarModificacion";
            this.btnCancelarModificacion.Size = new System.Drawing.Size(110, 37);
            this.btnCancelarModificacion.TabIndex = 19;
            this.btnCancelarModificacion.Text = "Cancelar";
            this.btnCancelarModificacion.UseVisualStyleBackColor = false;
            this.btnCancelarModificacion.Click += new System.EventHandler(this.btnCancelarModificacion_Click);
            // 
            // FrmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(960, 585);
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
            this.pnlProyectos.ResumeLayout(false);
            this.pnlProyectos.PerformLayout();
            this.pnlImportacionDB.ResumeLayout(false);
            this.pnlImportacionDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAgregar)).EndInit();
            this.pnlImportacion.ResumeLayout(false);
            this.pnlImportacion.PerformLayout();
            this.pnlImportacionTxt.ResumeLayout(false);
            this.pnlImportacionTxt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInformacion)).EndInit();
            this.pnlImportacionExcel.ResumeLayout(false);
            this.pnlImportacionExcel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilaInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoja)).EndInit();
            this.panelNombreProyecto.ResumeLayout(false);
            this.panelNombreProyecto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnImportarProyecto;
        private System.Windows.Forms.Button btnProcesarDatos;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Timer timerMensaje;
        private System.Windows.Forms.FlowLayoutPanel flowPanelBotones;
        private System.Windows.Forms.Panel panelNotificaciones;
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
        private System.Windows.Forms.Button btncancelarImportacion;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnImportarDesdeDB;
        private System.Windows.Forms.Panel pnlImportacionDB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreDB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreServidor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNombreDeColumna;
        private System.Windows.Forms.Label lblNombreTabla;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNombreBaseDeDatos;
        private System.Windows.Forms.Button btnCancelarImportacionDB;
        private System.Windows.Forms.Button btnAceptarImportacionDB;
        private System.Windows.Forms.CheckBox chUsuarioYContrasenia;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNombreColumna;
        private System.Windows.Forms.TextBox txtNombreTabla;
    }
}