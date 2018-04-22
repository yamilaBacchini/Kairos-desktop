namespace Kairos
{
    partial class frmPantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantallaPrincipal));
            this.lbProyectosRecientes = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnImportarProyecto = new System.Windows.Forms.Button();
            this.btnProcesarDatos = new System.Windows.Forms.Button();
            this.imgAgregar = new System.Windows.Forms.PictureBox();
            this.imgEditar = new System.Windows.Forms.PictureBox();
            this.imgBorrar = new System.Windows.Forms.PictureBox();
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.btnAceptarModificar = new System.Windows.Forms.Button();
            this.btnCancelarModificacion = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.timerMensaje = new System.Windows.Forms.Timer(this.components);
            this.flowPanelBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProyectos = new System.Windows.Forms.Button();
            this.btnArduino = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelNotificaciones = new System.Windows.Forms.Panel();
            lblProyectosGuardados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorrar)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.flowPanelBotones.SuspendLayout();
            this.panelNotificaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProyectosGuardados
            // 
            lblProyectosGuardados.AutoSize = true;
            lblProyectosGuardados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblProyectosGuardados.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProyectosGuardados.ForeColor = System.Drawing.Color.Black;
            lblProyectosGuardados.Location = new System.Drawing.Point(300, 140);
            lblProyectosGuardados.Margin = new System.Windows.Forms.Padding(0);
            lblProyectosGuardados.Name = "lblProyectosGuardados";
            lblProyectosGuardados.Size = new System.Drawing.Size(245, 28);
            lblProyectosGuardados.TabIndex = 6;
            lblProyectosGuardados.Text = "Proyectos Guardados";
            // 
            // lbProyectosRecientes
            // 
            this.lbProyectosRecientes.BackColor = System.Drawing.Color.MistyRose;
            this.lbProyectosRecientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbProyectosRecientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbProyectosRecientes.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProyectosRecientes.ForeColor = System.Drawing.Color.Black;
            this.lbProyectosRecientes.FormattingEnabled = true;
            this.lbProyectosRecientes.ItemHeight = 24;
            this.lbProyectosRecientes.Location = new System.Drawing.Point(300, 180);
            this.lbProyectosRecientes.Margin = new System.Windows.Forms.Padding(0);
            this.lbProyectosRecientes.Name = "lbProyectosRecientes";
            this.lbProyectosRecientes.Size = new System.Drawing.Size(400, 528);
            this.lbProyectosRecientes.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Vivaldi", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(420, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(267, 100);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Kairós";
            // 
            // btnImportarProyecto
            // 
            this.btnImportarProyecto.BackColor = System.Drawing.Color.Transparent;
            this.btnImportarProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btnImportarProyecto.FlatAppearance.BorderSize = 0;
            this.btnImportarProyecto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btnImportarProyecto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnImportarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarProyecto.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarProyecto.ForeColor = System.Drawing.Color.DeepPink;
            this.btnImportarProyecto.Location = new System.Drawing.Point(0, 248);
            this.btnImportarProyecto.Margin = new System.Windows.Forms.Padding(0);
            this.btnImportarProyecto.Name = "btnImportarProyecto";
            this.btnImportarProyecto.Size = new System.Drawing.Size(280, 124);
            this.btnImportarProyecto.TabIndex = 11;
            this.btnImportarProyecto.Text = "Importar Proyecto";
            this.btnImportarProyecto.UseVisualStyleBackColor = false;
            this.btnImportarProyecto.Click += new System.EventHandler(this.btnImportarProyecto_Click);
            // 
            // btnProcesarDatos
            // 
            this.btnProcesarDatos.BackColor = System.Drawing.Color.Transparent;
            this.btnProcesarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesarDatos.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.btnProcesarDatos.FlatAppearance.BorderSize = 0;
            this.btnProcesarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btnProcesarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnProcesarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesarDatos.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesarDatos.ForeColor = System.Drawing.Color.DeepPink;
            this.btnProcesarDatos.Location = new System.Drawing.Point(0, 124);
            this.btnProcesarDatos.Margin = new System.Windows.Forms.Padding(0);
            this.btnProcesarDatos.Name = "btnProcesarDatos";
            this.btnProcesarDatos.Size = new System.Drawing.Size(280, 124);
            this.btnProcesarDatos.TabIndex = 12;
            this.btnProcesarDatos.Text = "Procesar Datos";
            this.btnProcesarDatos.UseVisualStyleBackColor = false;
            this.btnProcesarDatos.Click += new System.EventHandler(this.btnProcesarDatos_Click);
            // 
            // imgAgregar
            // 
            this.imgAgregar.Image = ((System.Drawing.Image)(resources.GetObject("imgAgregar.Image")));
            this.imgAgregar.Location = new System.Drawing.Point(598, 137);
            this.imgAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.imgAgregar.Name = "imgAgregar";
            this.imgAgregar.Size = new System.Drawing.Size(36, 36);
            this.imgAgregar.TabIndex = 13;
            this.imgAgregar.TabStop = false;
            this.imgAgregar.Click += new System.EventHandler(this.imgAgregar_Click);
            // 
            // imgEditar
            // 
            this.imgEditar.Image = ((System.Drawing.Image)(resources.GetObject("imgEditar.Image")));
            this.imgEditar.Location = new System.Drawing.Point(638, 137);
            this.imgEditar.Margin = new System.Windows.Forms.Padding(4);
            this.imgEditar.Name = "imgEditar";
            this.imgEditar.Size = new System.Drawing.Size(36, 36);
            this.imgEditar.TabIndex = 14;
            this.imgEditar.TabStop = false;
            this.imgEditar.Click += new System.EventHandler(this.imgEditar_Click);
            // 
            // imgBorrar
            // 
            this.imgBorrar.Image = ((System.Drawing.Image)(resources.GetObject("imgBorrar.Image")));
            this.imgBorrar.Location = new System.Drawing.Point(675, 137);
            this.imgBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.imgBorrar.Name = "imgBorrar";
            this.imgBorrar.Size = new System.Drawing.Size(36, 36);
            this.imgBorrar.TabIndex = 15;
            this.imgBorrar.TabStop = false;
            this.imgBorrar.Click += new System.EventHandler(this.imgBorrar_Click);
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.AutoSize = true;
            this.lblNombreProyecto.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProyecto.Location = new System.Drawing.Point(788, 228);
            this.lblNombreProyecto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(145, 22);
            this.lblNombreProyecto.TabIndex = 16;
            this.lblNombreProyecto.Text = "Nombre Proyecto";
            this.lblNombreProyecto.Visible = false;
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.Location = new System.Drawing.Point(789, 255);
            this.txtNombreProyecto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(227, 22);
            this.txtNombreProyecto.TabIndex = 17;
            this.txtNombreProyecto.Visible = false;
            this.txtNombreProyecto.TextChanged += new System.EventHandler(this.txtNombreModificado_TextChanged);
            // 
            // btnAceptarModificar
            // 
            this.btnAceptarModificar.AutoSize = true;
            this.btnAceptarModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptarModificar.BackColor = System.Drawing.Color.Silver;
            this.btnAceptarModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarModificar.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarModificar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptarModificar.Location = new System.Drawing.Point(789, 287);
            this.btnAceptarModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptarModificar.Name = "btnAceptarModificar";
            this.btnAceptarModificar.Size = new System.Drawing.Size(84, 34);
            this.btnAceptarModificar.TabIndex = 18;
            this.btnAceptarModificar.Text = "Aceptar";
            this.btnAceptarModificar.UseVisualStyleBackColor = false;
            this.btnAceptarModificar.Visible = false;
            this.btnAceptarModificar.Click += new System.EventHandler(this.btnAceptarModificacion_Click);
            // 
            // btnCancelarModificacion
            // 
            this.btnCancelarModificacion.BackColor = System.Drawing.Color.Silver;
            this.btnCancelarModificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarModificacion.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarModificacion.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarModificacion.Location = new System.Drawing.Point(921, 287);
            this.btnCancelarModificacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarModificacion.Name = "btnCancelarModificacion";
            this.btnCancelarModificacion.Size = new System.Drawing.Size(95, 37);
            this.btnCancelarModificacion.TabIndex = 19;
            this.btnCancelarModificacion.Text = "Cancelar";
            this.btnCancelarModificacion.UseVisualStyleBackColor = false;
            this.btnCancelarModificacion.Visible = false;
            this.btnCancelarModificacion.Click += new System.EventHandler(this.btnCancelarModificacion_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1280, 100);
            this.panelTitulo.TabIndex = 20;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMensaje.Location = new System.Drawing.Point(0, 0);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(312, 24);
            this.lblMensaje.TabIndex = 21;
            this.lblMensaje.Text = "Este es un mensaje de error de prueba";
            // 
            // timerMensaje
            // 
            this.timerMensaje.Interval = 3000;
            this.timerMensaje.Tick += new System.EventHandler(this.timerMensaje_Tick);
            // 
            // flowPanelBotones
            // 
            this.flowPanelBotones.BackColor = System.Drawing.Color.Pink;
            this.flowPanelBotones.Controls.Add(this.btnProyectos);
            this.flowPanelBotones.Controls.Add(this.btnProcesarDatos);
            this.flowPanelBotones.Controls.Add(this.btnImportarProyecto);
            this.flowPanelBotones.Controls.Add(this.btnArduino);
            this.flowPanelBotones.Controls.Add(this.btnSalir);
            this.flowPanelBotones.Location = new System.Drawing.Point(0, 100);
            this.flowPanelBotones.Margin = new System.Windows.Forms.Padding(0);
            this.flowPanelBotones.Name = "flowPanelBotones";
            this.flowPanelBotones.Size = new System.Drawing.Size(280, 620);
            this.flowPanelBotones.TabIndex = 22;
            // 
            // btnProyectos
            // 
            this.btnProyectos.BackColor = System.Drawing.Color.Transparent;
            this.btnProyectos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProyectos.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.btnProyectos.FlatAppearance.BorderSize = 0;
            this.btnProyectos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btnProyectos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectos.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyectos.ForeColor = System.Drawing.Color.DeepPink;
            this.btnProyectos.Location = new System.Drawing.Point(0, 0);
            this.btnProyectos.Margin = new System.Windows.Forms.Padding(0);
            this.btnProyectos.Name = "btnProyectos";
            this.btnProyectos.Size = new System.Drawing.Size(280, 124);
            this.btnProyectos.TabIndex = 13;
            this.btnProyectos.Text = "Proyectos";
            this.btnProyectos.UseVisualStyleBackColor = false;
            // 
            // btnArduino
            // 
            this.btnArduino.BackColor = System.Drawing.Color.Transparent;
            this.btnArduino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArduino.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btnArduino.FlatAppearance.BorderSize = 0;
            this.btnArduino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btnArduino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnArduino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArduino.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArduino.ForeColor = System.Drawing.Color.DeepPink;
            this.btnArduino.Location = new System.Drawing.Point(0, 372);
            this.btnArduino.Margin = new System.Windows.Forms.Padding(0);
            this.btnArduino.Name = "btnArduino";
            this.btnArduino.Size = new System.Drawing.Size(280, 124);
            this.btnArduino.TabIndex = 14;
            this.btnArduino.Text = "Módulo Arduino";
            this.btnArduino.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightPink;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btnSalir.FlatAppearance.BorderSize = 10;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.DeepPink;
            this.btnSalir.Location = new System.Drawing.Point(0, 496);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(280, 124);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // panelNotificaciones
            // 
            this.panelNotificaciones.BackColor = System.Drawing.Color.GreenYellow;
            this.panelNotificaciones.Controls.Add(this.lblMensaje);
            this.panelNotificaciones.Location = new System.Drawing.Point(280, 100);
            this.panelNotificaciones.Name = "panelNotificaciones";
            this.panelNotificaciones.Size = new System.Drawing.Size(1000, 25);
            this.panelNotificaciones.TabIndex = 23;
            this.panelNotificaciones.Visible = false;
            // 
            // frmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelNotificaciones);
            this.Controls.Add(this.flowPanelBotones);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.btnCancelarModificacion);
            this.Controls.Add(this.btnAceptarModificar);
            this.Controls.Add(this.txtNombreProyecto);
            this.Controls.Add(this.lblNombreProyecto);
            this.Controls.Add(this.imgBorrar);
            this.Controls.Add(this.imgEditar);
            this.Controls.Add(this.imgAgregar);
            this.Controls.Add(this.lbProyectosRecientes);
            this.Controls.Add(lblProyectosGuardados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPantallaPrincipal";
            this.Opacity = 0.985D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kairós";
            ((System.ComponentModel.ISupportInitialize)(this.imgAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorrar)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.flowPanelBotones.ResumeLayout(false);
            this.panelNotificaciones.ResumeLayout(false);
            this.panelNotificaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProyectosRecientes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnImportarProyecto;
        private System.Windows.Forms.Button btnProcesarDatos;
        private System.Windows.Forms.PictureBox imgAgregar;
        private System.Windows.Forms.PictureBox imgEditar;
        private System.Windows.Forms.PictureBox imgBorrar;
        private System.Windows.Forms.Label lblNombreProyecto;
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.Button btnAceptarModificar;
        private System.Windows.Forms.Button btnCancelarModificacion;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Timer timerMensaje;
        private System.Windows.Forms.FlowLayoutPanel flowPanelBotones;
        private System.Windows.Forms.Panel panelNotificaciones;
        private System.Windows.Forms.Button btnProyectos;
        private System.Windows.Forms.Button btnArduino;
        private System.Windows.Forms.Button btnSalir;
    }
}