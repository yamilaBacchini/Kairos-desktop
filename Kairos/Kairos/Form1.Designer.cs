namespace Kairos
{
    partial class Form1
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
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dgwEventos = new System.Windows.Forms.DataGridView();
            this.lbOrigenes = new System.Windows.Forms.ListView();
            this.lblOrigenesGuardados = new System.Windows.Forms.Label();
            this.lblEventos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(96, 56);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(312, 132);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar eventos";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(542, 62);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(300, 120);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear eventos";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // dgwEventos
            // 
            this.dgwEventos.AllowUserToAddRows = false;
            this.dgwEventos.AllowUserToDeleteRows = false;
            this.dgwEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEventos.Location = new System.Drawing.Point(542, 319);
            this.dgwEventos.Name = "dgwEventos";
            this.dgwEventos.ReadOnly = true;
            this.dgwEventos.Size = new System.Drawing.Size(871, 408);
            this.dgwEventos.TabIndex = 2;
            // 
            // lbOrigenes
            // 
            this.lbOrigenes.Location = new System.Drawing.Point(96, 319);
            this.lbOrigenes.Name = "lbOrigenes";
            this.lbOrigenes.Size = new System.Drawing.Size(312, 408);
            this.lbOrigenes.TabIndex = 3;
            this.lbOrigenes.UseCompatibleStateImageBehavior = false;
            // 
            // lblOrigenesGuardados
            // 
            this.lblOrigenesGuardados.AutoSize = true;
            this.lblOrigenesGuardados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigenesGuardados.Location = new System.Drawing.Point(90, 260);
            this.lblOrigenesGuardados.Name = "lblOrigenesGuardados";
            this.lblOrigenesGuardados.Size = new System.Drawing.Size(134, 31);
            this.lblOrigenesGuardados.TabIndex = 4;
            this.lblOrigenesGuardados.Text = "Guardado";
            // 
            // lblEventos
            // 
            this.lblEventos.AutoSize = true;
            this.lblEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventos.Location = new System.Drawing.Point(536, 260);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(113, 31);
            this.lblEventos.TabIndex = 5;
            this.lblEventos.Text = "Eventos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2175, 1240);
            this.Controls.Add(this.lblEventos);
            this.Controls.Add(this.lblOrigenesGuardados);
            this.Controls.Add(this.lbOrigenes);
            this.Controls.Add(this.dgwEventos);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnImportar);
            this.Name = "Form1";
            this.Text = "Kairos";
            ((System.ComponentModel.ISupportInitialize)(this.dgwEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridView dgwEventos;
        private System.Windows.Forms.ListView lbOrigenes;
        private System.Windows.Forms.Label lblOrigenesGuardados;
        private System.Windows.Forms.Label lblEventos;
    }
}

