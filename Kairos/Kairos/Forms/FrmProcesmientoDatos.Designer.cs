namespace Kairos.Forms
{
    partial class FrmProcesmientoDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProcesmientoDatos));
            this.pnlEventos = new System.Windows.Forms.Panel();
            this.dgwEventos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.lblVista = new System.Windows.Forms.Label();
            this.rbIntervalos = new System.Windows.Forms.RadioButton();
            this.lblEventos = new System.Windows.Forms.Label();
            this.pnlModificable = new System.Windows.Forms.Panel();
            this.txtIntervalo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chlFiltros = new System.Windows.Forms.CheckedListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbTipoFiltro = new System.Windows.Forms.ComboBox();
            this.lblTipoFiltro = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblAccion2 = new System.Windows.Forms.Label();
            this.lblAccion1 = new System.Windows.Forms.Label();
            this.lblTituloAccion = new System.Windows.Forms.Label();
            this.pnlAccionesFinales = new System.Windows.Forms.Panel();
            this.btnGuardarProyecto = new System.Windows.Forms.Button();
            this.btnCalcularFDP = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMensaje = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.timerMensaje = new System.Windows.Forms.Timer(this.components);
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.btnModificarRegistro = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBorrarSeleccionados = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnSeleccionarTodos = new System.Windows.Forms.Button();
            this.pnlAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSegmentacion = new System.Windows.Forms.Panel();
            this.rbDia = new System.Windows.Forms.RadioButton();
            this.rbMinuto = new System.Windows.Forms.RadioButton();
            this.rbHora = new System.Windows.Forms.RadioButton();
            this.rbDtConstante = new System.Windows.Forms.RadioButton();
            this.rbEventoAEvento = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEventos)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlModificable.SuspendLayout();
            this.pnlAccionesFinales.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMensaje.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSegmentacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEventos
            // 
            this.pnlEventos.Controls.Add(this.dgwEventos);
            this.pnlEventos.Controls.Add(this.panel2);
            this.pnlEventos.Controls.Add(this.lblEventos);
            this.pnlEventos.Location = new System.Drawing.Point(251, 104);
            this.pnlEventos.Name = "pnlEventos";
            this.pnlEventos.Size = new System.Drawing.Size(375, 480);
            this.pnlEventos.TabIndex = 1;
            // 
            // dgwEventos
            // 
            this.dgwEventos.AllowUserToAddRows = false;
            this.dgwEventos.AllowUserToDeleteRows = false;
            this.dgwEventos.BackgroundColor = System.Drawing.Color.White;
            this.dgwEventos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgwEventos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgwEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEventos.Location = new System.Drawing.Point(16, 31);
            this.dgwEventos.Name = "dgwEventos";
            this.dgwEventos.ReadOnly = true;
            this.dgwEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwEventos.Size = new System.Drawing.Size(344, 438);
            this.dgwEventos.TabIndex = 23;
            this.dgwEventos.SelectionChanged += new System.EventHandler(this.dgwEventos_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbFecha);
            this.panel2.Controls.Add(this.lblVista);
            this.panel2.Controls.Add(this.rbIntervalos);
            this.panel2.Location = new System.Drawing.Point(143, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 33);
            this.panel2.TabIndex = 61;
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.Checked = true;
            this.rbFecha.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.rbFecha.Location = new System.Drawing.Point(56, 8);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(62, 22);
            this.rbFecha.TabIndex = 59;
            this.rbFecha.TabStop = true;
            this.rbFecha.Text = "Fecha";
            this.rbFecha.UseVisualStyleBackColor = true;
            this.rbFecha.CheckedChanged += new System.EventHandler(this.rbFecha_CheckedChanged);
            // 
            // lblVista
            // 
            this.lblVista.AutoSize = true;
            this.lblVista.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.lblVista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVista.Location = new System.Drawing.Point(2, 8);
            this.lblVista.Name = "lblVista";
            this.lblVista.Size = new System.Drawing.Size(46, 20);
            this.lblVista.TabIndex = 55;
            this.lblVista.Text = "Vista";
            // 
            // rbIntervalos
            // 
            this.rbIntervalos.AutoSize = true;
            this.rbIntervalos.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.rbIntervalos.Location = new System.Drawing.Point(125, 8);
            this.rbIntervalos.Name = "rbIntervalos";
            this.rbIntervalos.Size = new System.Drawing.Size(90, 22);
            this.rbIntervalos.TabIndex = 60;
            this.rbIntervalos.Text = "Intervalos";
            this.rbIntervalos.UseVisualStyleBackColor = true;
            this.rbIntervalos.CheckedChanged += new System.EventHandler(this.rbIntervalos_CheckedChanged);
            // 
            // lblEventos
            // 
            this.lblEventos.AutoSize = true;
            this.lblEventos.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEventos.Location = new System.Drawing.Point(12, 6);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(80, 23);
            this.lblEventos.TabIndex = 24;
            this.lblEventos.Text = "Eventos";
            // 
            // pnlModificable
            // 
            this.pnlModificable.Controls.Add(this.txtIntervalo);
            this.pnlModificable.Controls.Add(this.label2);
            this.pnlModificable.Controls.Add(this.chlFiltros);
            this.pnlModificable.Controls.Add(this.btnLimpiar);
            this.pnlModificable.Controls.Add(this.cmbTipoFiltro);
            this.pnlModificable.Controls.Add(this.lblTipoFiltro);
            this.pnlModificable.Controls.Add(this.dtp2);
            this.pnlModificable.Controls.Add(this.dtp1);
            this.pnlModificable.Controls.Add(this.btnAceptar);
            this.pnlModificable.Controls.Add(this.lblAccion2);
            this.pnlModificable.Controls.Add(this.lblAccion1);
            this.pnlModificable.Controls.Add(this.lblTituloAccion);
            this.pnlModificable.Location = new System.Drawing.Point(666, 106);
            this.pnlModificable.Name = "pnlModificable";
            this.pnlModificable.Size = new System.Drawing.Size(282, 303);
            this.pnlModificable.TabIndex = 2;
            this.pnlModificable.Visible = false;
            // 
            // txtIntervalo
            // 
            this.txtIntervalo.Location = new System.Drawing.Point(112, 69);
            this.txtIntervalo.Name = "txtIntervalo";
            this.txtIntervalo.Size = new System.Drawing.Size(39, 20);
            this.txtIntervalo.TabIndex = 55;
            this.txtIntervalo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(7, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Filtros Aplicados";
            // 
            // chlFiltros
            // 
            this.chlFiltros.FormattingEnabled = true;
            this.chlFiltros.Location = new System.Drawing.Point(11, 211);
            this.chlFiltros.Name = "chlFiltros";
            this.chlFiltros.Size = new System.Drawing.Size(230, 49);
            this.chlFiltros.TabIndex = 53;
            this.chlFiltros.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chlFiltros_ItemCheck);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(165, 263);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(76, 31);
            this.btnLimpiar.TabIndex = 52;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbTipoFiltro
            // 
            this.cmbTipoFiltro.FormattingEnabled = true;
            this.cmbTipoFiltro.Location = new System.Drawing.Point(112, 42);
            this.cmbTipoFiltro.Name = "cmbTipoFiltro";
            this.cmbTipoFiltro.Size = new System.Drawing.Size(129, 21);
            this.cmbTipoFiltro.TabIndex = 51;
            this.cmbTipoFiltro.Text = "Seleccione";
            this.cmbTipoFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbTipoFiltro_SelectedIndexChanged);
            // 
            // lblTipoFiltro
            // 
            this.lblTipoFiltro.AutoSize = true;
            this.lblTipoFiltro.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.lblTipoFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTipoFiltro.Location = new System.Drawing.Point(7, 40);
            this.lblTipoFiltro.Name = "lblTipoFiltro";
            this.lblTipoFiltro.Size = new System.Drawing.Size(104, 20);
            this.lblTipoFiltro.TabIndex = 50;
            this.lblTipoFiltro.Text = "Tipo de filtro";
            // 
            // dtp2
            // 
            this.dtp2.CustomFormat = "HH:mm:ss";
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(41, 136);
            this.dtp2.Name = "dtp2";
            this.dtp2.ShowUpDown = true;
            this.dtp2.Size = new System.Drawing.Size(200, 20);
            this.dtp2.TabIndex = 49;
            // 
            // dtp1
            // 
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(41, 90);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 20);
            this.dtp1.TabIndex = 48;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnAceptar.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(165, 165);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(76, 31);
            this.btnAceptar.TabIndex = 47;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblAccion2
            // 
            this.lblAccion2.AutoSize = true;
            this.lblAccion2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAccion2.Location = new System.Drawing.Point(6, 113);
            this.lblAccion2.Name = "lblAccion2";
            this.lblAccion2.Size = new System.Drawing.Size(65, 20);
            this.lblAccion2.TabIndex = 46;
            this.lblAccion2.Text = "Horario";
            // 
            // lblAccion1
            // 
            this.lblAccion1.AutoSize = true;
            this.lblAccion1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAccion1.Location = new System.Drawing.Point(6, 67);
            this.lblAccion1.Name = "lblAccion1";
            this.lblAccion1.Size = new System.Drawing.Size(50, 20);
            this.lblAccion1.TabIndex = 45;
            this.lblAccion1.Text = "Fecha";
            // 
            // lblTituloAccion
            // 
            this.lblTituloAccion.AutoSize = true;
            this.lblTituloAccion.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloAccion.Location = new System.Drawing.Point(6, 4);
            this.lblTituloAccion.Name = "lblTituloAccion";
            this.lblTituloAccion.Size = new System.Drawing.Size(135, 23);
            this.lblTituloAccion.TabIndex = 44;
            this.lblTituloAccion.Text = "Tiltulo Accion";
            // 
            // pnlAccionesFinales
            // 
            this.pnlAccionesFinales.Controls.Add(this.btnGuardarProyecto);
            this.pnlAccionesFinales.Controls.Add(this.btnCalcularFDP);
            this.pnlAccionesFinales.Location = new System.Drawing.Point(666, 502);
            this.pnlAccionesFinales.Name = "pnlAccionesFinales";
            this.pnlAccionesFinales.Size = new System.Drawing.Size(282, 82);
            this.pnlAccionesFinales.TabIndex = 3;
            // 
            // btnGuardarProyecto
            // 
            this.btnGuardarProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGuardarProyecto.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProyecto.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarProyecto.Location = new System.Drawing.Point(53, 6);
            this.btnGuardarProyecto.Name = "btnGuardarProyecto";
            this.btnGuardarProyecto.Size = new System.Drawing.Size(176, 36);
            this.btnGuardarProyecto.TabIndex = 17;
            this.btnGuardarProyecto.Text = "Guardar Proyecto";
            this.btnGuardarProyecto.UseVisualStyleBackColor = false;
            // 
            // btnCalcularFDP
            // 
            this.btnCalcularFDP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.btnCalcularFDP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularFDP.ForeColor = System.Drawing.Color.White;
            this.btnCalcularFDP.Location = new System.Drawing.Point(53, 42);
            this.btnCalcularFDP.Name = "btnCalcularFDP";
            this.btnCalcularFDP.Size = new System.Drawing.Size(176, 36);
            this.btnCalcularFDP.TabIndex = 16;
            this.btnCalcularFDP.Text = "Calcular FDP";
            this.btnCalcularFDP.UseVisualStyleBackColor = false;
            this.btnCalcularFDP.Click += new System.EventHandler(this.btnCalcularFDP_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.pictureBox1);
            this.pnlTitulo.Controls.Add(this.label1);
            this.pnlTitulo.Location = new System.Drawing.Point(1, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(959, 81);
            this.pnlTitulo.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(867, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 83);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 76);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kairós";
            // 
            // pnlMensaje
            // 
            this.pnlMensaje.Controls.Add(this.lblMensaje);
            this.pnlMensaje.Location = new System.Drawing.Point(206, 81);
            this.pnlMensaje.Name = "pnlMensaje";
            this.pnlMensaje.Size = new System.Drawing.Size(754, 19);
            this.pnlMensaje.TabIndex = 22;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(9, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(750, 19);
            this.lblMensaje.TabIndex = 22;
            this.lblMensaje.Text = "Mensaje";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensaje.Visible = false;
            // 
            // timerMensaje
            // 
            this.timerMensaje.Interval = 2000;
            this.timerMensaje.Tick += new System.EventHandler(this.timerMensaje_Tick);
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.BackColor = System.Drawing.Color.Black;
            this.btnAgregarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAgregarRegistro.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAgregarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnAgregarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRegistro.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.btnAgregarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRegistro.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarRegistro.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(210, 82);
            this.btnAgregarRegistro.TabIndex = 14;
            this.btnAgregarRegistro.Text = "Agregar Registro";
            this.btnAgregarRegistro.UseVisualStyleBackColor = false;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // btnModificarRegistro
            // 
            this.btnModificarRegistro.BackColor = System.Drawing.Color.Black;
            this.btnModificarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnModificarRegistro.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnModificarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnModificarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarRegistro.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.btnModificarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnModificarRegistro.Location = new System.Drawing.Point(0, 82);
            this.btnModificarRegistro.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificarRegistro.Name = "btnModificarRegistro";
            this.btnModificarRegistro.Size = new System.Drawing.Size(210, 82);
            this.btnModificarRegistro.TabIndex = 14;
            this.btnModificarRegistro.Text = "Modificar Registro";
            this.btnModificarRegistro.UseVisualStyleBackColor = false;
            this.btnModificarRegistro.Click += new System.EventHandler(this.btnModificarRegistro_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Black;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnVolver.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(0, 528);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(210, 57);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBorrarSeleccionados
            // 
            this.btnBorrarSeleccionados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.btnBorrarSeleccionados.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBorrarSeleccionados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnBorrarSeleccionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarSeleccionados.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.btnBorrarSeleccionados.ForeColor = System.Drawing.Color.White;
            this.btnBorrarSeleccionados.Location = new System.Drawing.Point(0, 328);
            this.btnBorrarSeleccionados.Margin = new System.Windows.Forms.Padding(0);
            this.btnBorrarSeleccionados.Name = "btnBorrarSeleccionados";
            this.btnBorrarSeleccionados.Size = new System.Drawing.Size(210, 82);
            this.btnBorrarSeleccionados.TabIndex = 14;
            this.btnBorrarSeleccionados.Text = "Borrar Seleccionados";
            this.btnBorrarSeleccionados.UseVisualStyleBackColor = false;
            this.btnBorrarSeleccionados.Click += new System.EventHandler(this.btnBorrarSeleccionados_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Black;
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFiltrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(0, 246);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(210, 82);
            this.btnFiltrar.TabIndex = 14;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnSeleccionarTodos
            // 
            this.btnSeleccionarTodos.BackColor = System.Drawing.Color.Black;
            this.btnSeleccionarTodos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSeleccionarTodos.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSeleccionarTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSeleccionarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarTodos.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.btnSeleccionarTodos.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarTodos.Location = new System.Drawing.Point(0, 164);
            this.btnSeleccionarTodos.Margin = new System.Windows.Forms.Padding(0);
            this.btnSeleccionarTodos.Name = "btnSeleccionarTodos";
            this.btnSeleccionarTodos.Size = new System.Drawing.Size(210, 82);
            this.btnSeleccionarTodos.TabIndex = 14;
            this.btnSeleccionarTodos.Text = "Seleccionar Todos";
            this.btnSeleccionarTodos.UseVisualStyleBackColor = false;
            this.btnSeleccionarTodos.Click += new System.EventHandler(this.btnSeleccionarTodos_Click);
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.BackColor = System.Drawing.Color.Black;
            this.pnlAcciones.Controls.Add(this.btnAgregarRegistro);
            this.pnlAcciones.Controls.Add(this.btnModificarRegistro);
            this.pnlAcciones.Controls.Add(this.btnSeleccionarTodos);
            this.pnlAcciones.Controls.Add(this.btnFiltrar);
            this.pnlAcciones.Controls.Add(this.btnBorrarSeleccionados);
            this.pnlAcciones.Location = new System.Drawing.Point(0, 81);
            this.pnlAcciones.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(210, 447);
            this.pnlAcciones.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlSegmentacion);
            this.panel1.Controls.Add(this.rbDtConstante);
            this.panel1.Controls.Add(this.rbEventoAEvento);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(666, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 81);
            this.panel1.TabIndex = 23;
            // 
            // pnlSegmentacion
            // 
            this.pnlSegmentacion.Controls.Add(this.rbDia);
            this.pnlSegmentacion.Controls.Add(this.rbMinuto);
            this.pnlSegmentacion.Controls.Add(this.rbHora);
            this.pnlSegmentacion.Location = new System.Drawing.Point(0, 55);
            this.pnlSegmentacion.Name = "pnlSegmentacion";
            this.pnlSegmentacion.Size = new System.Drawing.Size(282, 26);
            this.pnlSegmentacion.TabIndex = 58;
            this.pnlSegmentacion.Visible = false;
            // 
            // rbDia
            // 
            this.rbDia.AutoSize = true;
            this.rbDia.Checked = true;
            this.rbDia.Location = new System.Drawing.Point(11, 3);
            this.rbDia.Name = "rbDia";
            this.rbDia.Size = new System.Drawing.Size(41, 17);
            this.rbDia.TabIndex = 2;
            this.rbDia.TabStop = true;
            this.rbDia.Text = "Dia";
            this.rbDia.UseVisualStyleBackColor = true;
            // 
            // rbMinuto
            // 
            this.rbMinuto.AutoSize = true;
            this.rbMinuto.Location = new System.Drawing.Point(184, 3);
            this.rbMinuto.Name = "rbMinuto";
            this.rbMinuto.Size = new System.Drawing.Size(57, 17);
            this.rbMinuto.TabIndex = 1;
            this.rbMinuto.Text = "Minuto";
            this.rbMinuto.UseVisualStyleBackColor = true;
            // 
            // rbHora
            // 
            this.rbHora.AutoSize = true;
            this.rbHora.Location = new System.Drawing.Point(103, 3);
            this.rbHora.Name = "rbHora";
            this.rbHora.Size = new System.Drawing.Size(48, 17);
            this.rbHora.TabIndex = 0;
            this.rbHora.Text = "Hora";
            this.rbHora.UseVisualStyleBackColor = true;
            // 
            // rbDtConstante
            // 
            this.rbDtConstante.AutoSize = true;
            this.rbDtConstante.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.rbDtConstante.Location = new System.Drawing.Point(146, 33);
            this.rbDtConstante.Name = "rbDtConstante";
            this.rbDtConstante.Size = new System.Drawing.Size(104, 22);
            this.rbDtConstante.TabIndex = 57;
            this.rbDtConstante.TabStop = true;
            this.rbDtConstante.Text = "Δt constante";
            this.rbDtConstante.UseVisualStyleBackColor = true;
            this.rbDtConstante.CheckedChanged += new System.EventHandler(this.rbDtConstante_CheckedChanged);
            // 
            // rbEventoAEvento
            // 
            this.rbEventoAEvento.AutoSize = true;
            this.rbEventoAEvento.Checked = true;
            this.rbEventoAEvento.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.rbEventoAEvento.Location = new System.Drawing.Point(11, 33);
            this.rbEventoAEvento.Name = "rbEventoAEvento";
            this.rbEventoAEvento.Size = new System.Drawing.Size(129, 22);
            this.rbEventoAEvento.TabIndex = 56;
            this.rbEventoAEvento.TabStop = true;
            this.rbEventoAEvento.Text = "Evento a evento";
            this.rbEventoAEvento.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 55;
            this.label3.Text = "Metodologia";
            // 
            // FrmProcesmientoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.pnlMensaje);
            this.Controls.Add(this.pnlAccionesFinales);
            this.Controls.Add(this.pnlModificable);
            this.Controls.Add(this.pnlEventos);
            this.Controls.Add(this.btnVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmProcesmientoDatos";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlEventos.ResumeLayout(false);
            this.pnlEventos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEventos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlModificable.ResumeLayout(false);
            this.pnlModificable.PerformLayout();
            this.pnlAccionesFinales.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMensaje.ResumeLayout(false);
            this.pnlAcciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSegmentacion.ResumeLayout(false);
            this.pnlSegmentacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlEventos;
        private System.Windows.Forms.Panel pnlModificable;
        private System.Windows.Forms.Panel pnlAccionesFinales;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMensaje;
        private System.Windows.Forms.DataGridView dgwEventos;
        private System.Windows.Forms.Label lblEventos;
        private System.Windows.Forms.Button btnGuardarProyecto;
        private System.Windows.Forms.Button btnCalcularFDP;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblAccion2;
        private System.Windows.Forms.Label lblAccion1;
        private System.Windows.Forms.Label lblTituloAccion;
        private System.Windows.Forms.ComboBox cmbTipoFiltro;
        private System.Windows.Forms.Label lblTipoFiltro;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Timer timerMensaje;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox chlFiltros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.Button btnModificarRegistro;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBorrarSeleccionados;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnSeleccionarTodos;
        private System.Windows.Forms.FlowLayoutPanel pnlAcciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbDtConstante;
        private System.Windows.Forms.RadioButton rbEventoAEvento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlSegmentacion;
        private System.Windows.Forms.RadioButton rbDia;
        private System.Windows.Forms.RadioButton rbMinuto;
        private System.Windows.Forms.RadioButton rbHora;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.Label lblVista;
        private System.Windows.Forms.RadioButton rbIntervalos;
        private System.Windows.Forms.TextBox txtIntervalo;
    }
}