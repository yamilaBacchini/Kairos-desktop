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
            System.Windows.Forms.Label lblProyectosGuardados;
            this.lbProyectosRecientes = new System.Windows.Forms.ListBox();
            this.btnAdministrarProyectos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoProyecto = new System.Windows.Forms.Button();
            this.btnImportarProyecto = new System.Windows.Forms.Button();
            this.btnProcesarDatos = new System.Windows.Forms.Button();
            lblProyectosGuardados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProyectosGuardados
            // 
            lblProyectosGuardados.AutoSize = true;
            lblProyectosGuardados.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProyectosGuardados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            lblProyectosGuardados.Location = new System.Drawing.Point(38, 146);
            lblProyectosGuardados.Name = "lblProyectosGuardados";
            lblProyectosGuardados.Size = new System.Drawing.Size(197, 23);
            lblProyectosGuardados.TabIndex = 6;
            lblProyectosGuardados.Text = "Proyectos Guardados";
            // 
            // lbProyectosRecientes
            // 
            this.lbProyectosRecientes.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProyectosRecientes.FormattingEnabled = true;
            this.lbProyectosRecientes.ItemHeight = 15;
            this.lbProyectosRecientes.Location = new System.Drawing.Point(42, 172);
            this.lbProyectosRecientes.Name = "lbProyectosRecientes";
            this.lbProyectosRecientes.Size = new System.Drawing.Size(181, 379);
            this.lbProyectosRecientes.TabIndex = 7;
            // 
            // btnAdministrarProyectos
            // 
            this.btnAdministrarProyectos.BackColor = System.Drawing.Color.DarkRed;
            this.btnAdministrarProyectos.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarProyectos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdministrarProyectos.Location = new System.Drawing.Point(42, 557);
            this.btnAdministrarProyectos.Name = "btnAdministrarProyectos";
            this.btnAdministrarProyectos.Size = new System.Drawing.Size(182, 29);
            this.btnAdministrarProyectos.TabIndex = 8;
            this.btnAdministrarProyectos.Text = "Administrar Proyectos";
            this.btnAdministrarProyectos.UseVisualStyleBackColor = false;
            this.btnAdministrarProyectos.Click += new System.EventHandler(this.btnAdministrarProyectos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 76);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kairós";
            // 
            // btnNuevoProyecto
            // 
            this.btnNuevoProyecto.BackColor = System.Drawing.Color.DarkRed;
            this.btnNuevoProyecto.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProyecto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevoProyecto.Location = new System.Drawing.Point(416, 240);
            this.btnNuevoProyecto.Name = "btnNuevoProyecto";
            this.btnNuevoProyecto.Size = new System.Drawing.Size(215, 31);
            this.btnNuevoProyecto.TabIndex = 10;
            this.btnNuevoProyecto.Text = "Nuevo Proyecto";
            this.btnNuevoProyecto.UseVisualStyleBackColor = false;
            this.btnNuevoProyecto.Click += new System.EventHandler(this.btnNuevoProyecto_Click);
            // 
            // btnImportarProyecto
            // 
            this.btnImportarProyecto.BackColor = System.Drawing.Color.DarkRed;
            this.btnImportarProyecto.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarProyecto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnImportarProyecto.Location = new System.Drawing.Point(416, 292);
            this.btnImportarProyecto.Name = "btnImportarProyecto";
            this.btnImportarProyecto.Size = new System.Drawing.Size(215, 31);
            this.btnImportarProyecto.TabIndex = 11;
            this.btnImportarProyecto.Text = "Importar Proyecto";
            this.btnImportarProyecto.UseVisualStyleBackColor = false;
            this.btnImportarProyecto.Click += new System.EventHandler(this.btnImportarProyecto_Click);
            // 
            // btnProcesarDatos
            // 
            this.btnProcesarDatos.BackColor = System.Drawing.Color.DarkRed;
            this.btnProcesarDatos.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesarDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProcesarDatos.Location = new System.Drawing.Point(416, 346);
            this.btnProcesarDatos.Name = "btnProcesarDatos";
            this.btnProcesarDatos.Size = new System.Drawing.Size(215, 31);
            this.btnProcesarDatos.TabIndex = 12;
            this.btnProcesarDatos.Text = "Procesar Datos";
            this.btnProcesarDatos.UseVisualStyleBackColor = false;
            this.btnProcesarDatos.Click += new System.EventHandler(this.btnProcesarDatos_Click);
            // 
            // frmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(782, 598);
            this.Controls.Add(this.btnProcesarDatos);
            this.Controls.Add(this.btnImportarProyecto);
            this.Controls.Add(this.btnNuevoProyecto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdministrarProyectos);
            this.Controls.Add(this.lbProyectosRecientes);
            this.Controls.Add(lblProyectosGuardados);
            this.Name = "frmPantallaPrincipal";
            this.Text = "Kairós";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProyectosRecientes;
        private System.Windows.Forms.Button btnAdministrarProyectos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoProyecto;
        private System.Windows.Forms.Button btnImportarProyecto;
        private System.Windows.Forms.Button btnProcesarDatos;
    }
}