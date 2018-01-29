namespace Kairos
{
    partial class frmProcesamiento
    {
        /// <summary>
        /// Variable del diseñador necesaria.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwEventos = new System.Windows.Forms.DataGridView();
            this.lblEventos = new System.Windows.Forms.Label();
            this.btnCalcularFDP = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.btnBorrarSeleccion = new System.Windows.Forms.Button();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.btnModificarRegistro = new System.Windows.Forms.Button();
            this.btnBorrarFiltrados = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.btnGuardarProyecto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwEventos
            // 
            this.dgwEventos.AllowUserToAddRows = false;
            this.dgwEventos.AllowUserToDeleteRows = false;
            this.dgwEventos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwEventos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgwEventos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgwEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEventos.Location = new System.Drawing.Point(274, 114);
            this.dgwEventos.Name = "dgwEventos";
            this.dgwEventos.ReadOnly = true;
            this.dgwEventos.Size = new System.Drawing.Size(280, 460);
            this.dgwEventos.TabIndex = 2;
            // 
            // lblEventos
            // 
            this.lblEventos.AutoSize = true;
            this.lblEventos.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEventos.Location = new System.Drawing.Point(371, 88);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(80, 23);
            this.lblEventos.TabIndex = 5;
            this.lblEventos.Text = "Eventos";
            // 
            // btnCalcularFDP
            // 
            this.btnCalcularFDP.BackColor = System.Drawing.Color.DarkRed;
            this.btnCalcularFDP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularFDP.ForeColor = System.Drawing.Color.White;
            this.btnCalcularFDP.Location = new System.Drawing.Point(579, 538);
            this.btnCalcularFDP.Name = "btnCalcularFDP";
            this.btnCalcularFDP.Size = new System.Drawing.Size(176, 36);
            this.btnCalcularFDP.TabIndex = 6;
            this.btnCalcularFDP.Text = "Calcular FDP";
            this.btnCalcularFDP.UseVisualStyleBackColor = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.DarkGray;
            this.btnFiltrar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFiltrar.Location = new System.Drawing.Point(41, 473);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(176, 36);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(41, 399);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(176, 36);
            this.btnLimpiarFiltros.TabIndex = 8;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            // 
            // btnBorrarSeleccion
            // 
            this.btnBorrarSeleccion.BackColor = System.Drawing.Color.DarkGray;
            this.btnBorrarSeleccion.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarSeleccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBorrarSeleccion.Location = new System.Drawing.Point(41, 254);
            this.btnBorrarSeleccion.Name = "btnBorrarSeleccion";
            this.btnBorrarSeleccion.Size = new System.Drawing.Size(176, 36);
            this.btnBorrarSeleccion.TabIndex = 9;
            this.btnBorrarSeleccion.Text = "Borrar Selección";
            this.btnBorrarSeleccion.UseVisualStyleBackColor = false;
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.BackColor = System.Drawing.Color.DarkGray;
            this.btnAgregarRegistro.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarRegistro.Location = new System.Drawing.Point(41, 114);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAgregarRegistro.Size = new System.Drawing.Size(176, 36);
            this.btnAgregarRegistro.TabIndex = 10;
            this.btnAgregarRegistro.Text = "Agregar Registro";
            this.btnAgregarRegistro.UseVisualStyleBackColor = false;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // btnModificarRegistro
            // 
            this.btnModificarRegistro.BackColor = System.Drawing.Color.DarkGray;
            this.btnModificarRegistro.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnModificarRegistro.Location = new System.Drawing.Point(41, 184);
            this.btnModificarRegistro.Name = "btnModificarRegistro";
            this.btnModificarRegistro.Size = new System.Drawing.Size(176, 36);
            this.btnModificarRegistro.TabIndex = 11;
            this.btnModificarRegistro.Text = "Modificar Registro";
            this.btnModificarRegistro.UseVisualStyleBackColor = false;
            // 
            // btnBorrarFiltrados
            // 
            this.btnBorrarFiltrados.BackColor = System.Drawing.Color.DarkGray;
            this.btnBorrarFiltrados.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarFiltrados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBorrarFiltrados.Location = new System.Drawing.Point(41, 327);
            this.btnBorrarFiltrados.Name = "btnBorrarFiltrados";
            this.btnBorrarFiltrados.Size = new System.Drawing.Size(176, 36);
            this.btnBorrarFiltrados.TabIndex = 12;
            this.btnBorrarFiltrados.Text = "Borrar Filtrados";
            this.btnBorrarFiltrados.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkRed;
            this.btnVolver.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(41, 538);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(176, 36);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.AutoSize = true;
            this.lblNombreProyecto.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombreProyecto.Location = new System.Drawing.Point(362, 22);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(135, 20);
            this.lblNombreProyecto.TabIndex = 14;
            this.lblNombreProyecto.Text = "Nombre Proyecto";
            // 
            // btnGuardarProyecto
            // 
            this.btnGuardarProyecto.BackColor = System.Drawing.Color.DarkGray;
            this.btnGuardarProyecto.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuardarProyecto.Location = new System.Drawing.Point(579, 496);
            this.btnGuardarProyecto.Name = "btnGuardarProyecto";
            this.btnGuardarProyecto.Size = new System.Drawing.Size(176, 36);
            this.btnGuardarProyecto.TabIndex = 15;
            this.btnGuardarProyecto.Text = "Guardar Proyecto";
            this.btnGuardarProyecto.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vivaldi", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 57);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kairós";
            // 
            // frmProcesamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(781, 598);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardarProyecto);
            this.Controls.Add(this.lblNombreProyecto);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBorrarFiltrados);
            this.Controls.Add(this.btnModificarRegistro);
            this.Controls.Add(this.btnAgregarRegistro);
            this.Controls.Add(this.btnBorrarSeleccion);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnCalcularFDP);
            this.Controls.Add(this.lblEventos);
            this.Controls.Add(this.dgwEventos);
            this.Name = "frmProcesamiento";
            this.Text = "Procesar Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgwEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwEventos;
        private System.Windows.Forms.Label lblEventos;
        private System.Windows.Forms.Button btnCalcularFDP;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Button btnBorrarSeleccion;
        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.Button btnModificarRegistro;
        private System.Windows.Forms.Button btnBorrarFiltrados;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNombreProyecto;
        private System.Windows.Forms.Button btnGuardarProyecto;
        private System.Windows.Forms.Label label2;
    }
}

