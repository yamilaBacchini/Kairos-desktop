﻿namespace Kairos
{
    partial class frmAgregarProyecto
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
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tboxNombreProyecto = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.AutoSize = true;
            this.lblNombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProyecto.Location = new System.Drawing.Point(12, 64);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(193, 17);
            this.lblNombreProyecto.TabIndex = 0;
            this.lblNombreProyecto.Text = "Ingrese nombre del proyecto:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(150, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(208, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Nuevo Proyecto";
            // 
            // tboxNombreProyecto
            // 
            this.tboxNombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNombreProyecto.Location = new System.Drawing.Point(212, 64);
            this.tboxNombreProyecto.Name = "tboxNombreProyecto";
            this.tboxNombreProyecto.Size = new System.Drawing.Size(219, 23);
            this.tboxNombreProyecto.TabIndex = 2;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(156, 105);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(157, 28);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear Proyecto";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // frmAgregarProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 145);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.tboxNombreProyecto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombreProyecto);
            this.Name = "frmAgregarProyecto";
            this.Text = "frmAgregarProyecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreProyecto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tboxNombreProyecto;
        private System.Windows.Forms.Button btnCrear;
    }
}