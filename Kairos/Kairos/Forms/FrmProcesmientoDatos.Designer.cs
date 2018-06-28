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
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnSeleccionarTodos = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnBorrarSeleccionados = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnModificarRegistro = new System.Windows.Forms.Button();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.pnlEventos = new System.Windows.Forms.Panel();
            this.dgwEventos = new System.Windows.Forms.DataGridView();
            this.lblEventos = new System.Windows.Forms.Label();
            this.pnlModificable = new System.Windows.Forms.Panel();
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
            this.chlFiltros = new System.Windows.Forms.CheckedListBox();
            this.pnlAcciones.SuspendLayout();
            this.pnlEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEventos)).BeginInit();
            this.pnlModificable.SuspendLayout();
            this.pnlAccionesFinales.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.BackColor = System.Drawing.Color.Black;
            this.pnlAcciones.Controls.Add(this.btnSeleccionarTodos);
            this.pnlAcciones.Controls.Add(this.btnFiltrar);
            this.pnlAcciones.Controls.Add(this.btnBorrarSeleccionados);
            this.pnlAcciones.Controls.Add(this.btnVolver);
            this.pnlAcciones.Controls.Add(this.btnModificarRegistro);
            this.pnlAcciones.Controls.Add(this.btnAgregarRegistro);
            this.pnlAcciones.Location = new System.Drawing.Point(1, 73);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(200, 431);
            this.pnlAcciones.TabIndex = 0;
            // 
            // btnSeleccionarTodos
            // 
            this.btnSeleccionarTodos.BackColor = System.Drawing.Color.Black;
            this.btnSeleccionarTodos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSeleccionarTodos.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSeleccionarTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSeleccionarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarTodos.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarTodos.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarTodos.Location = new System.Drawing.Point(0, 129);
            this.btnSeleccionarTodos.Name = "btnSeleccionarTodos";
            this.btnSeleccionarTodos.Size = new System.Drawing.Size(200, 63);
            this.btnSeleccionarTodos.TabIndex = 4;
            this.btnSeleccionarTodos.Text = "Seleccionar Todos";
            this.btnSeleccionarTodos.UseVisualStyleBackColor = false;
            this.btnSeleccionarTodos.Click += new System.EventHandler(this.btnSeleccionarTodos_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Black;
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFiltrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(0, 192);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(200, 63);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnBorrarSeleccionados
            // 
            this.btnBorrarSeleccionados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.btnBorrarSeleccionados.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBorrarSeleccionados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnBorrarSeleccionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarSeleccionados.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarSeleccionados.ForeColor = System.Drawing.Color.White;
            this.btnBorrarSeleccionados.Location = new System.Drawing.Point(0, 255);
            this.btnBorrarSeleccionados.Name = "btnBorrarSeleccionados";
            this.btnBorrarSeleccionados.Size = new System.Drawing.Size(200, 63);
            this.btnBorrarSeleccionados.TabIndex = 3;
            this.btnBorrarSeleccionados.Text = "Borrar Seleccionados";
            this.btnBorrarSeleccionados.UseVisualStyleBackColor = false;
            this.btnBorrarSeleccionados.Click += new System.EventHandler(this.btnBorrarSeleccionados_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Black;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnVolver.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(0, 368);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(200, 63);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnModificarRegistro
            // 
            this.btnModificarRegistro.BackColor = System.Drawing.Color.Black;
            this.btnModificarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnModificarRegistro.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnModificarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnModificarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarRegistro.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnModificarRegistro.Location = new System.Drawing.Point(0, 66);
            this.btnModificarRegistro.Name = "btnModificarRegistro";
            this.btnModificarRegistro.Size = new System.Drawing.Size(200, 63);
            this.btnModificarRegistro.TabIndex = 2;
            this.btnModificarRegistro.Text = "Modificar Registro";
            this.btnModificarRegistro.UseVisualStyleBackColor = false;
            this.btnModificarRegistro.Click += new System.EventHandler(this.btnModificarRegistro_Click);
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.BackColor = System.Drawing.Color.Black;
            this.btnAgregarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAgregarRegistro.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAgregarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnAgregarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRegistro.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRegistro.Location = new System.Drawing.Point(0, 3);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(200, 63);
            this.btnAgregarRegistro.TabIndex = 1;
            this.btnAgregarRegistro.Text = "Agregar Registro";
            this.btnAgregarRegistro.UseVisualStyleBackColor = false;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // pnlEventos
            // 
            this.pnlEventos.Controls.Add(this.dgwEventos);
            this.pnlEventos.Controls.Add(this.lblEventos);
            this.pnlEventos.Location = new System.Drawing.Point(208, 104);
            this.pnlEventos.Name = "pnlEventos";
            this.pnlEventos.Size = new System.Drawing.Size(304, 400);
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
            this.dgwEventos.Location = new System.Drawing.Point(12, 30);
            this.dgwEventos.Name = "dgwEventos";
            this.dgwEventos.ReadOnly = true;
            this.dgwEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwEventos.Size = new System.Drawing.Size(280, 380);
            this.dgwEventos.TabIndex = 23;
            this.dgwEventos.SelectionChanged += new System.EventHandler(this.dgwEventos_SelectionChanged);
            // 
            // lblEventos
            // 
            this.lblEventos.AutoSize = true;
            this.lblEventos.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEventos.Location = new System.Drawing.Point(109, 4);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(80, 23);
            this.lblEventos.TabIndex = 24;
            this.lblEventos.Text = "Eventos";
            // 
            // pnlModificable
            // 
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
            this.pnlModificable.Location = new System.Drawing.Point(519, 104);
            this.pnlModificable.Name = "pnlModificable";
            this.pnlModificable.Size = new System.Drawing.Size(282, 269);
            this.pnlModificable.TabIndex = 2;
            this.pnlModificable.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(53, 224);
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
            this.cmbTipoFiltro.Location = new System.Drawing.Point(108, 42);
            this.cmbTipoFiltro.Name = "cmbTipoFiltro";
            this.cmbTipoFiltro.Size = new System.Drawing.Size(133, 21);
            this.cmbTipoFiltro.TabIndex = 51;
            this.cmbTipoFiltro.Text = "Seleccione";
            this.cmbTipoFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbTipoFiltro_SelectedIndexChanged);
            // 
            // lblTipoFiltro
            // 
            this.lblTipoFiltro.AutoSize = true;
            this.lblTipoFiltro.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFiltro.Location = new System.Drawing.Point(7, 40);
            this.lblTipoFiltro.Name = "lblTipoFiltro";
            this.lblTipoFiltro.Size = new System.Drawing.Size(95, 20);
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
            this.btnAceptar.Location = new System.Drawing.Point(165, 224);
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
            this.pnlAccionesFinales.Location = new System.Drawing.Point(519, 380);
            this.pnlAccionesFinales.Name = "pnlAccionesFinales";
            this.pnlAccionesFinales.Size = new System.Drawing.Size(282, 120);
            this.pnlAccionesFinales.TabIndex = 3;
            // 
            // btnGuardarProyecto
            // 
            this.btnGuardarProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGuardarProyecto.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProyecto.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarProyecto.Location = new System.Drawing.Point(53, 21);
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
            this.btnCalcularFDP.Location = new System.Drawing.Point(53, 63);
            this.btnCalcularFDP.Name = "btnCalcularFDP";
            this.btnCalcularFDP.Size = new System.Drawing.Size(176, 36);
            this.btnCalcularFDP.TabIndex = 16;
            this.btnCalcularFDP.Text = "Calcular FDP";
            this.btnCalcularFDP.UseVisualStyleBackColor = false;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlTitulo.Controls.Add(this.pictureBox1);
            this.pnlTitulo.Controls.Add(this.label1);
            this.pnlTitulo.Location = new System.Drawing.Point(1, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(800, 81);
            this.pnlTitulo.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(717, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 76);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kairós";
            // 
            // pnlMensaje
            // 
            this.pnlMensaje.Controls.Add(this.lblMensaje);
            this.pnlMensaje.Location = new System.Drawing.Point(201, 81);
            this.pnlMensaje.Name = "pnlMensaje";
            this.pnlMensaje.Size = new System.Drawing.Size(602, 19);
            this.pnlMensaje.TabIndex = 22;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(0, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(599, 17);
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
            // chlFiltros
            // 
            this.chlFiltros.FormattingEnabled = true;
            this.chlFiltros.Location = new System.Drawing.Point(11, 172);
            this.chlFiltros.Name = "chlFiltros";
            this.chlFiltros.Size = new System.Drawing.Size(230, 49);
            this.chlFiltros.TabIndex = 53;
            this.chlFiltros.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chlFiltros_ItemCheck);
            // 
            // FrmProcesmientoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.pnlMensaje);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlAccionesFinales);
            this.Controls.Add(this.pnlModificable);
            this.Controls.Add(this.pnlEventos);
            this.Controls.Add(this.pnlAcciones);
            this.Name = "FrmProcesmientoDatos";
            this.pnlAcciones.ResumeLayout(false);
            this.pnlEventos.ResumeLayout(false);
            this.pnlEventos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEventos)).EndInit();
            this.pnlModificable.ResumeLayout(false);
            this.pnlModificable.PerformLayout();
            this.pnlAccionesFinales.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMensaje.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnSeleccionarTodos;
        private System.Windows.Forms.Button btnBorrarSeleccionados;
        private System.Windows.Forms.Button btnModificarRegistro;
        private System.Windows.Forms.Button btnAgregarRegistro;
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
    }
}