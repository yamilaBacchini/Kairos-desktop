namespace Kairos
{
    partial class frmAgregarRegistro
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
            this.btnTerminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblMinuto = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btmAgregarOtro = new System.Windows.Forms.Button();
            lblProyectosGuardados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProyectosGuardados
            // 
            lblProyectosGuardados.AutoSize = true;
            lblProyectosGuardados.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProyectosGuardados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            lblProyectosGuardados.Location = new System.Drawing.Point(290, 121);
            lblProyectosGuardados.Name = "lblProyectosGuardados";
            lblProyectosGuardados.Size = new System.Drawing.Size(223, 23);
            lblProyectosGuardados.TabIndex = 11;
            lblProyectosGuardados.Text = "Inserte el nuevo registro";
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnTerminar.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTerminar.Location = new System.Drawing.Point(409, 399);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(134, 31);
            this.btnTerminar.TabIndex = 13;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vivaldi", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 57);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kairós";
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.AutoSize = true;
            this.lblNombreProyecto.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombreProyecto.Location = new System.Drawing.Point(362, 22);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(135, 20);
            this.lblNombreProyecto.TabIndex = 18;
            this.lblNombreProyecto.Text = "Nombre Proyecto";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFecha.Location = new System.Drawing.Point(199, 182);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 20);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHorario.Location = new System.Drawing.Point(199, 262);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(65, 20);
            this.lblHorario.TabIndex = 20;
            this.lblHorario.Text = "Horario";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDia.Location = new System.Drawing.Point(221, 219);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(29, 17);
            this.lblDia.TabIndex = 21;
            this.lblDia.Text = "Dia";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMes.Location = new System.Drawing.Point(337, 219);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(32, 17);
            this.lblMes.TabIndex = 22;
            this.lblMes.Text = "Mes";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAnio.Location = new System.Drawing.Point(455, 219);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(33, 17);
            this.lblAnio.TabIndex = 23;
            this.lblAnio.Text = "Año";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHora.Location = new System.Drawing.Point(211, 317);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(38, 17);
            this.lblHora.TabIndex = 24;
            this.lblHora.Text = "Hora";
            // 
            // lblMinuto
            // 
            this.lblMinuto.AutoSize = true;
            this.lblMinuto.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMinuto.Location = new System.Drawing.Point(318, 317);
            this.lblMinuto.Name = "lblMinuto";
            this.lblMinuto.Size = new System.Drawing.Size(51, 17);
            this.lblMinuto.TabIndex = 25;
            this.lblMinuto.Text = "Minuto";
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSegundo.Location = new System.Drawing.Point(429, 316);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(59, 17);
            this.lblSegundo.TabIndex = 26;
            this.lblSegundo.Text = "Segundo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 316);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(374, 316);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 20);
            this.textBox2.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(494, 316);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(49, 20);
            this.textBox3.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "hh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "mm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "ss";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(256, 218);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(49, 20);
            this.textBox4.TabIndex = 33;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(375, 218);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(49, 20);
            this.textBox5.TabIndex = 34;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(494, 218);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(49, 20);
            this.textBox6.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "aaaa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "mm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "dd";
            // 
            // btmAgregarOtro
            // 
            this.btmAgregarOtro.BackColor = System.Drawing.Color.Gray;
            this.btmAgregarOtro.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAgregarOtro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btmAgregarOtro.Location = new System.Drawing.Point(203, 399);
            this.btmAgregarOtro.Name = "btmAgregarOtro";
            this.btmAgregarOtro.Size = new System.Drawing.Size(194, 31);
            this.btmAgregarOtro.TabIndex = 39;
            this.btmAgregarOtro.Text = "Aceptar y Agregar Otro";
            this.btmAgregarOtro.UseVisualStyleBackColor = false;
            // 
            // frmAgregarRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(782, 598);
            this.Controls.Add(this.btmAgregarOtro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.lblMinuto);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombreProyecto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(lblProyectosGuardados);
            this.Name = "frmAgregarRegistro";
            this.Text = "Agregar Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreProyecto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblMinuto;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btmAgregarOtro;
    }
}