namespace Kairos.Forms
{
    partial class FrmImportarDesdeDB
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
            this.btnImportar = new System.Windows.Forms.Button();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.lblNombreBaseDeDatos = new System.Windows.Forms.Label();
            this.lblNombreTabla = new System.Windows.Forms.Label();
            this.lblNombreDeColumna = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.txtNombreDB = new System.Windows.Forms.TextBox();
            this.txtNombreTabla = new System.Windows.Forms.TextBox();
            this.txtNombreColumna = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(370, 314);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Location = new System.Drawing.Point(161, 83);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(97, 13);
            this.lblConnectionString.TabIndex = 1;
            this.lblConnectionString.Text = "Connection String: ";
            // 
            // lblNombreBaseDeDatos
            // 
            this.lblNombreBaseDeDatos.AutoSize = true;
            this.lblNombreBaseDeDatos.Location = new System.Drawing.Point(161, 140);
            this.lblNombreBaseDeDatos.Name = "lblNombreBaseDeDatos";
            this.lblNombreBaseDeDatos.Size = new System.Drawing.Size(138, 13);
            this.lblNombreBaseDeDatos.TabIndex = 2;
            this.lblNombreBaseDeDatos.Text = "Nombre de base de datos:  ";
            // 
            // lblNombreTabla
            // 
            this.lblNombreTabla.AutoSize = true;
            this.lblNombreTabla.Location = new System.Drawing.Point(161, 201);
            this.lblNombreTabla.Name = "lblNombreTabla";
            this.lblNombreTabla.Size = new System.Drawing.Size(91, 13);
            this.lblNombreTabla.TabIndex = 3;
            this.lblNombreTabla.Text = "Nombre de tabla: ";
            // 
            // lblNombreDeColumna
            // 
            this.lblNombreDeColumna.AutoSize = true;
            this.lblNombreDeColumna.Location = new System.Drawing.Point(161, 248);
            this.lblNombreDeColumna.Name = "lblNombreDeColumna";
            this.lblNombreDeColumna.Size = new System.Drawing.Size(108, 13);
            this.lblNombreDeColumna.TabIndex = 4;
            this.lblNombreDeColumna.Text = "Nombre de columna: ";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(307, 73);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(291, 20);
            this.txtConnectionString.TabIndex = 5;
            // 
            // txtNombreDB
            // 
            this.txtNombreDB.Location = new System.Drawing.Point(307, 137);
            this.txtNombreDB.Name = "txtNombreDB";
            this.txtNombreDB.Size = new System.Drawing.Size(291, 20);
            this.txtNombreDB.TabIndex = 6;
            // 
            // txtNombreTabla
            // 
            this.txtNombreTabla.Location = new System.Drawing.Point(307, 198);
            this.txtNombreTabla.Name = "txtNombreTabla";
            this.txtNombreTabla.Size = new System.Drawing.Size(291, 20);
            this.txtNombreTabla.TabIndex = 7;
            // 
            // txtNombreColumna
            // 
            this.txtNombreColumna.Location = new System.Drawing.Point(307, 245);
            this.txtNombreColumna.Name = "txtNombreColumna";
            this.txtNombreColumna.Size = new System.Drawing.Size(291, 20);
            this.txtNombreColumna.TabIndex = 8;
            // 
            // FrmImportarDesdeDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombreColumna);
            this.Controls.Add(this.txtNombreTabla);
            this.Controls.Add(this.txtNombreDB);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.lblNombreDeColumna);
            this.Controls.Add(this.lblNombreTabla);
            this.Controls.Add(this.lblNombreBaseDeDatos);
            this.Controls.Add(this.lblConnectionString);
            this.Controls.Add(this.btnImportar);
            this.Name = "FrmImportarDesdeDB";
            this.Text = "FrmImportarDesdeDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.Label lblNombreBaseDeDatos;
        private System.Windows.Forms.Label lblNombreTabla;
        private System.Windows.Forms.Label lblNombreDeColumna;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.TextBox txtNombreDB;
        private System.Windows.Forms.TextBox txtNombreTabla;
        private System.Windows.Forms.TextBox txtNombreColumna;
    }
}