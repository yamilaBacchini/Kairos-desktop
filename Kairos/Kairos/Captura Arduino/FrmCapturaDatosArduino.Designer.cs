namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.buttonComenzar = new System.Windows.Forms.Button();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.buttonExplorar = new System.Windows.Forms.Button();
            this.textBoxExplorar = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelLectura = new System.Windows.Forms.Label();
            this.errorProviderExplorar = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExplorar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonComenzar
            // 
            this.buttonComenzar.AutoSize = true;
            this.buttonComenzar.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonComenzar.Location = new System.Drawing.Point(0, 0);
            this.buttonComenzar.Name = "buttonComenzar";
            this.buttonComenzar.Size = new System.Drawing.Size(75, 207);
            this.buttonComenzar.TabIndex = 2;
            this.buttonComenzar.Text = "Comenzar";
            this.buttonComenzar.UseVisualStyleBackColor = true;
            this.buttonComenzar.Click += new System.EventHandler(this.buttonComenzar_Click);
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.AutoSize = true;
            this.buttonFinalizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonFinalizar.Location = new System.Drawing.Point(367, 0);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(75, 207);
            this.buttonFinalizar.TabIndex = 3;
            this.buttonFinalizar.Text = "Finalizar";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // buttonExplorar
            // 
            this.buttonExplorar.Location = new System.Drawing.Point(105, 46);
            this.buttonExplorar.Name = "buttonExplorar";
            this.buttonExplorar.Size = new System.Drawing.Size(60, 23);
            this.buttonExplorar.TabIndex = 4;
            this.buttonExplorar.Text = "Buscar";
            this.buttonExplorar.UseVisualStyleBackColor = true;
            this.buttonExplorar.Click += new System.EventHandler(this.buttonExplorar_Click);
            // 
            // textBoxExplorar
            // 
            this.textBoxExplorar.Location = new System.Drawing.Point(171, 48);
            this.textBoxExplorar.Name = "textBoxExplorar";
            this.textBoxExplorar.Size = new System.Drawing.Size(159, 20);
            this.textBoxExplorar.TabIndex = 5;
            this.textBoxExplorar.TextChanged += new System.EventHandler(this.textBoxExplorar_TextChanged);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(102, 132);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEstado.Size = new System.Drawing.Size(244, 16);
            this.labelEstado.TabIndex = 6;
            this.labelEstado.Text = "Presione comenzar para capturar datos";
            this.labelEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLectura
            // 
            this.labelLectura.AutoSize = true;
            this.labelLectura.Location = new System.Drawing.Point(201, 164);
            this.labelLectura.Name = "labelLectura";
            this.labelLectura.Size = new System.Drawing.Size(0, 13);
            this.labelLectura.TabIndex = 7;
            // 
            // errorProviderExplorar
            // 
            this.errorProviderExplorar.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(442, 207);
            this.Controls.Add(this.labelLectura);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.textBoxExplorar);
            this.Controls.Add(this.buttonExplorar);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.buttonComenzar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kairos - Captura de datos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExplorar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonComenzar;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.Button buttonExplorar;
        private System.Windows.Forms.TextBox textBoxExplorar;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelLectura;
        private System.Windows.Forms.ErrorProvider errorProviderExplorar;
    }
}

