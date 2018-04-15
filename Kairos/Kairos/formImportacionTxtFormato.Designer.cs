namespace Kairos
{
    partial class formImportacionTxtFormato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formImportacionTxtFormato));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtOtro = new System.Windows.Forms.TextBox();
            this.rbComa = new System.Windows.Forms.RadioButton();
            this.rbPipe = new System.Windows.Forms.RadioButton();
            this.rbTab = new System.Windows.Forms.RadioButton();
            this.rbEnter = new System.Windows.Forms.RadioButton();
            this.imgInformacion = new System.Windows.Forms.PictureBox();
            this.toolTipInformacion = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgInformacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Book Antiqua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(49, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(418, 25);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Indique el caracter delimitador de los datos";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btncancelar.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(398, 120);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(84, 30);
            this.btncancelar.TabIndex = 13;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAceptar.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(398, 62);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 30);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtOtro
            // 
            this.txtOtro.BackColor = System.Drawing.Color.LightGray;
            this.txtOtro.Enabled = false;
            this.txtOtro.Location = new System.Drawing.Point(71, 102);
            this.txtOtro.Name = "txtOtro";
            this.txtOtro.Size = new System.Drawing.Size(100, 20);
            this.txtOtro.TabIndex = 14;
            this.txtOtro.TextChanged += new System.EventHandler(this.txtOtro_TextChanged);
            // 
            // rbComa
            // 
            this.rbComa.AutoSize = true;
            this.rbComa.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbComa.Location = new System.Drawing.Point(6, 31);
            this.rbComa.Name = "rbComa";
            this.rbComa.Size = new System.Drawing.Size(91, 22);
            this.rbComa.TabIndex = 15;
            this.rbComa.Text = "Coma ( , )";
            this.rbComa.UseVisualStyleBackColor = true;
            // 
            // rbPipe
            // 
            this.rbPipe.AutoSize = true;
            this.rbPipe.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPipe.Location = new System.Drawing.Point(6, 55);
            this.rbPipe.Name = "rbPipe";
            this.rbPipe.Size = new System.Drawing.Size(87, 22);
            this.rbPipe.TabIndex = 16;
            this.rbPipe.Text = "Pipe ( | )";
            this.rbPipe.UseVisualStyleBackColor = true;
            // 
            // rbTab
            // 
            this.rbTab.AutoSize = true;
            this.rbTab.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTab.Location = new System.Drawing.Point(6, 78);
            this.rbTab.Name = "rbTab";
            this.rbTab.Size = new System.Drawing.Size(51, 22);
            this.rbTab.TabIndex = 17;
            this.rbTab.Text = "Tab";
            this.rbTab.UseVisualStyleBackColor = true;
            // 
            // rbEnter
            // 
            this.rbEnter.AutoSize = true;
            this.rbEnter.Checked = true;
            this.rbEnter.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEnter.Location = new System.Drawing.Point(6, 9);
            this.rbEnter.Name = "rbEnter";
            this.rbEnter.Size = new System.Drawing.Size(62, 22);
            this.rbEnter.TabIndex = 18;
            this.rbEnter.TabStop = true;
            this.rbEnter.Text = "Enter";
            this.rbEnter.UseVisualStyleBackColor = true;
            // 
            // imgInformacion
            // 
            this.imgInformacion.AccessibleDescription = "";
            this.imgInformacion.Image = ((System.Drawing.Image)(resources.GetObject("imgInformacion.Image")));
            this.imgInformacion.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgInformacion.InitialImage")));
            this.imgInformacion.Location = new System.Drawing.Point(177, 100);
            this.imgInformacion.Name = "imgInformacion";
            this.imgInformacion.Size = new System.Drawing.Size(27, 29);
            this.imgInformacion.TabIndex = 19;
            this.imgInformacion.TabStop = false;
            this.imgInformacion.Tag = "";
            this.toolTipInformacion.SetToolTip(this.imgInformacion, "No están permitidos los valores:\r\n\".\"   \"-\"   \":\"    \" \" (espacio)");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOtro);
            this.groupBox1.Controls.Add(this.rbEnter);
            this.groupBox1.Controls.Add(this.imgInformacion);
            this.groupBox1.Controls.Add(this.txtOtro);
            this.groupBox1.Controls.Add(this.rbComa);
            this.groupBox1.Controls.Add(this.rbPipe);
            this.groupBox1.Controls.Add(this.rbTab);
            this.groupBox1.Location = new System.Drawing.Point(69, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 134);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOtro.Location = new System.Drawing.Point(6, 100);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(59, 22);
            this.rbOtro.TabIndex = 21;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            this.rbOtro.CheckedChanged += new System.EventHandler(this.rbOtro_CheckedChanged);
            // 
            // formImportacionTxtFormato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(539, 223);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "formImportacionTxtFormato";
            ((System.ComponentModel.ISupportInitialize)(this.imgInformacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtOtro;
        private System.Windows.Forms.RadioButton rbComa;
        private System.Windows.Forms.RadioButton rbPipe;
        private System.Windows.Forms.RadioButton rbTab;
        private System.Windows.Forms.RadioButton rbEnter;
        private System.Windows.Forms.PictureBox imgInformacion;
        private System.Windows.Forms.ToolTip toolTipInformacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOtro;
    }
}