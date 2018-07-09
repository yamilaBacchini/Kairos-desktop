﻿namespace Kairos.Forms
{
    partial class FrmAjusteFunciones
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjusteFunciones));
            this.pnlEventos = new System.Windows.Forms.Panel();
            this.chrtInversa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtFuncion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGraficoFuncionInversa = new System.Windows.Forms.Label();
            this.lblGraficoFuncion = new System.Windows.Forms.Label();
            this.pnlInfoFunciones = new System.Windows.Forms.Panel();
            this.lblFuncionInversa = new System.Windows.Forms.Label();
            this.lblTituloFuncionInversa = new System.Windows.Forms.Label();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.lblTituloFuncion = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMensaje = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.timerMensaje = new System.Windows.Forms.Timer(this.components);
            this.btnFuncionBurr = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlFunciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFuncionBinomial = new System.Windows.Forms.Button();
            this.btnFuncionExponencial = new System.Windows.Forms.Button();
            this.btnFuncionLogistica = new System.Windows.Forms.Button();
            this.btnFuncionLognormal = new System.Windows.Forms.Button();
            this.btnFuncionLogLogistica = new System.Windows.Forms.Button();
            this.btnFuncionNormal = new System.Windows.Forms.Button();
            this.btnFuncionFasesBiExponencial = new System.Windows.Forms.Button();
            this.btnFuncionFasesBiWeibull = new System.Windows.Forms.Button();
            this.btnFuncionPoisson = new System.Windows.Forms.Button();
            this.btnFuncionUniforme = new System.Windows.Forms.Button();
            this.btnFuncionWeibull = new System.Windows.Forms.Button();
            this.pnlValoresAleatorios = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnGenerarValoresAleatorios = new System.Windows.Forms.Button();
            this.lblTituloCantidadValoresGenerados = new System.Windows.Forms.Label();
            this.nudCantidadGenerados = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTituloFunciones = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportarResultados = new System.Windows.Forms.Button();
            this.pnlEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtInversa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFuncion)).BeginInit();
            this.pnlInfoFunciones.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMensaje.SuspendLayout();
            this.pnlFunciones.SuspendLayout();
            this.pnlValoresAleatorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadGenerados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEventos
            // 
            this.pnlEventos.Controls.Add(this.chrtInversa);
            this.pnlEventos.Controls.Add(this.chrtFuncion);
            this.pnlEventos.Controls.Add(this.lblGraficoFuncionInversa);
            this.pnlEventos.Controls.Add(this.lblGraficoFuncion);
            this.pnlEventos.Location = new System.Drawing.Point(251, 96);
            this.pnlEventos.Name = "pnlEventos";
            this.pnlEventos.Size = new System.Drawing.Size(375, 487);
            this.pnlEventos.TabIndex = 1;
            // 
            // chrtInversa
            // 
            chartArea3.Name = "ChartArea1";
            this.chrtInversa.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chrtInversa.Legends.Add(legend3);
            this.chrtInversa.Location = new System.Drawing.Point(7, 266);
            this.chrtInversa.Name = "chrtInversa";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chrtInversa.Series.Add(series3);
            this.chrtInversa.Size = new System.Drawing.Size(355, 205);
            this.chrtInversa.TabIndex = 27;
            this.chrtInversa.Text = "chart2";
            // 
            // chrtFuncion
            // 
            chartArea4.Name = "ChartArea1";
            this.chrtFuncion.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chrtFuncion.Legends.Add(legend4);
            this.chrtFuncion.Location = new System.Drawing.Point(7, 32);
            this.chrtFuncion.Name = "chrtFuncion";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chrtFuncion.Series.Add(series4);
            this.chrtFuncion.Size = new System.Drawing.Size(355, 205);
            this.chrtFuncion.TabIndex = 26;
            this.chrtFuncion.Text = "chart1";
            // 
            // lblGraficoFuncionInversa
            // 
            this.lblGraficoFuncionInversa.AutoSize = true;
            this.lblGraficoFuncionInversa.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraficoFuncionInversa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGraficoFuncionInversa.Location = new System.Drawing.Point(3, 240);
            this.lblGraficoFuncionInversa.Name = "lblGraficoFuncionInversa";
            this.lblGraficoFuncionInversa.Size = new System.Drawing.Size(217, 23);
            this.lblGraficoFuncionInversa.TabIndex = 25;
            this.lblGraficoFuncionInversa.Text = "Grafico funcion inversa";
            // 
            // lblGraficoFuncion
            // 
            this.lblGraficoFuncion.AutoSize = true;
            this.lblGraficoFuncion.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraficoFuncion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGraficoFuncion.Location = new System.Drawing.Point(3, 5);
            this.lblGraficoFuncion.Name = "lblGraficoFuncion";
            this.lblGraficoFuncion.Size = new System.Drawing.Size(148, 23);
            this.lblGraficoFuncion.TabIndex = 24;
            this.lblGraficoFuncion.Text = "Grafico funcion";
            // 
            // pnlInfoFunciones
            // 
            this.pnlInfoFunciones.Controls.Add(this.lblFuncionInversa);
            this.pnlInfoFunciones.Controls.Add(this.lblTituloFuncionInversa);
            this.pnlInfoFunciones.Controls.Add(this.lblFuncion);
            this.pnlInfoFunciones.Controls.Add(this.lblTituloFuncion);
            this.pnlInfoFunciones.Location = new System.Drawing.Point(666, 110);
            this.pnlInfoFunciones.Name = "pnlInfoFunciones";
            this.pnlInfoFunciones.Size = new System.Drawing.Size(264, 99);
            this.pnlInfoFunciones.TabIndex = 2;
            // 
            // lblFuncionInversa
            // 
            this.lblFuncionInversa.AutoSize = true;
            this.lblFuncionInversa.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionInversa.Location = new System.Drawing.Point(6, 70);
            this.lblFuncionInversa.Name = "lblFuncionInversa";
            this.lblFuncionInversa.Size = new System.Drawing.Size(180, 20);
            this.lblFuncionInversa.TabIndex = 56;
            this.lblFuncionInversa.Text = "funcion inversa a mostrar";
            // 
            // lblTituloFuncionInversa
            // 
            this.lblTituloFuncionInversa.AutoSize = true;
            this.lblTituloFuncionInversa.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFuncionInversa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloFuncionInversa.Location = new System.Drawing.Point(6, 47);
            this.lblTituloFuncionInversa.Name = "lblTituloFuncionInversa";
            this.lblTituloFuncionInversa.Size = new System.Drawing.Size(151, 23);
            this.lblTituloFuncionInversa.TabIndex = 55;
            this.lblTituloFuncionInversa.Text = "Funcion inversa";
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncion.Location = new System.Drawing.Point(7, 26);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(128, 20);
            this.lblFuncion.TabIndex = 50;
            this.lblFuncion.Text = "funcion a mostrar";
            // 
            // lblTituloFuncion
            // 
            this.lblTituloFuncion.AutoSize = true;
            this.lblTituloFuncion.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFuncion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloFuncion.Location = new System.Drawing.Point(6, 4);
            this.lblTituloFuncion.Name = "lblTituloFuncion";
            this.lblTituloFuncion.Size = new System.Drawing.Size(82, 23);
            this.lblTituloFuncion.TabIndex = 44;
            this.lblTituloFuncion.Text = "Funcion";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.pictureBox1);
            this.pnlTitulo.Controls.Add(this.label1);
            this.pnlTitulo.Location = new System.Drawing.Point(1, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(948, 81);
            this.pnlTitulo.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(858, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 83);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 76);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kairós";
            // 
            // pnlMensaje
            // 
            this.pnlMensaje.Controls.Add(this.lblMensaje);
            this.pnlMensaje.Location = new System.Drawing.Point(224, 81);
            this.pnlMensaje.Name = "pnlMensaje";
            this.pnlMensaje.Size = new System.Drawing.Size(724, 19);
            this.pnlMensaje.TabIndex = 22;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(-7, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(731, 19);
            this.lblMensaje.TabIndex = 22;
            this.lblMensaje.Text = "Mensaje";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensaje.Visible = false;
            // 
            // timerMensaje
            // 
            this.timerMensaje.Interval = 2000;
            // 
            // btnFuncionBurr
            // 
            this.btnFuncionBurr.BackColor = System.Drawing.Color.Black;
            this.btnFuncionBurr.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFuncionBurr.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFuncionBurr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnFuncionBurr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionBurr.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.btnFuncionBurr.ForeColor = System.Drawing.Color.White;
            this.btnFuncionBurr.Location = new System.Drawing.Point(0, 0);
            this.btnFuncionBurr.Margin = new System.Windows.Forms.Padding(0);
            this.btnFuncionBurr.Name = "btnFuncionBurr";
            this.btnFuncionBurr.Size = new System.Drawing.Size(210, 33);
            this.btnFuncionBurr.TabIndex = 14;
            this.btnFuncionBurr.Text = "Burr";
            this.btnFuncionBurr.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(1, 537);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(210, 46);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pnlFunciones
            // 
            this.pnlFunciones.BackColor = System.Drawing.Color.Black;
            this.pnlFunciones.Controls.Add(this.btnFuncionBurr);
            this.pnlFunciones.Controls.Add(this.btnFuncionBinomial);
            this.pnlFunciones.Controls.Add(this.btnFuncionExponencial);
            this.pnlFunciones.Controls.Add(this.btnFuncionLogistica);
            this.pnlFunciones.Controls.Add(this.btnFuncionLognormal);
            this.pnlFunciones.Controls.Add(this.btnFuncionLogLogistica);
            this.pnlFunciones.Controls.Add(this.btnFuncionNormal);
            this.pnlFunciones.Controls.Add(this.btnFuncionFasesBiExponencial);
            this.pnlFunciones.Controls.Add(this.btnFuncionFasesBiWeibull);
            this.pnlFunciones.Controls.Add(this.btnFuncionPoisson);
            this.pnlFunciones.Controls.Add(this.btnFuncionUniforme);
            this.pnlFunciones.Controls.Add(this.btnFuncionWeibull);
            this.pnlFunciones.Location = new System.Drawing.Point(1, 110);
            this.pnlFunciones.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFunciones.Name = "pnlFunciones";
            this.pnlFunciones.Size = new System.Drawing.Size(210, 427);
            this.pnlFunciones.TabIndex = 22;
            // 
            // btnFuncionBinomial
            // 
            this.btnFuncionBinomial.BackColor = System.Drawing.Color.Black;
            this.btnFuncionBinomial.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFuncionBinomial.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFuncionBinomial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnFuncionBinomial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionBinomial.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.btnFuncionBinomial.ForeColor = System.Drawing.Color.White;
            this.btnFuncionBinomial.Location = new System.Drawing.Point(0, 33);
            this.btnFuncionBinomial.Margin = new System.Windows.Forms.Padding(0);
            this.btnFuncionBinomial.Name = "btnFuncionBinomial";
            this.btnFuncionBinomial.Size = new System.Drawing.Size(210, 33);
            this.btnFuncionBinomial.TabIndex = 15;
            this.btnFuncionBinomial.Text = "Binomial";
            this.btnFuncionBinomial.UseVisualStyleBackColor = false;
            // 
            // btnFuncionExponencial
            // 
            this.btnFuncionExponencial.BackColor = System.Drawing.Color.Black;
            this.btnFuncionExponencial.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFuncionExponencial.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFuncionExponencial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnFuncionExponencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionExponencial.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.btnFuncionExponencial.ForeColor = System.Drawing.Color.White;
            this.btnFuncionExponencial.Location = new System.Drawing.Point(0, 66);
            this.btnFuncionExponencial.Margin = new System.Windows.Forms.Padding(0);
            this.btnFuncionExponencial.Name = "btnFuncionExponencial";
            this.btnFuncionExponencial.Size = new System.Drawing.Size(210, 33);
            this.btnFuncionExponencial.TabIndex = 16;
            this.btnFuncionExponencial.Text = "Exponencial";
            this.btnFuncionExponencial.UseVisualStyleBackColor = false;
            // 
            // btnFuncionLogistica
            // 
            this.btnFuncionLogistica.BackColor = System.Drawing.Color.Black;
            this.btnFuncionLogistica.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFuncionLogistica.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFuncionLogistica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnFuncionLogistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionLogistica.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.btnFuncionLogistica.ForeColor = System.Drawing.Color.White;
            this.btnFuncionLogistica.Location = new System.Drawing.Point(0, 99);
            this.btnFuncionLogistica.Margin = new System.Windows.Forms.Padding(0);
            this.btnFuncionLogistica.Name = "btnFuncionLogistica";
            this.btnFuncionLogistica.Size = new System.Drawing.Size(210, 33);
            this.btnFuncionLogistica.TabIndex = 17;
            this.btnFuncionLogistica.Text = "Logística";
            this.btnFuncionLogistica.UseVisualStyleBackColor = false;
            // 
            // btnFuncionLognormal
            // 
            this.btnFuncionLognormal.BackColor = System.Drawing.Color.Black;
            this.btnFuncionLognormal.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFuncionLognormal.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFuncionLognormal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnFuncionLognormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionLognormal.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.btnFuncionLognormal.ForeColor = System.Drawing.Color.White;
            this.btnFuncionLognormal.Location = new System.Drawing.Point(0, 132);
            this.btnFuncionLognormal.Margin = new System.Windows.Forms.Padding(0);
            this.btnFuncionLognormal.Name = "btnFuncionLognormal";
            this.btnFuncionLognormal.Size = new System.Drawing.Size(210, 33);
            this.btnFuncionLognormal.TabIndex = 18;
            this.btnFuncionLognormal.Text = "Log-Normal";
            this.btnFuncionLognormal.UseVisualStyleBackColor = false;
            // 
            // btnFuncionLogLogistica
            // 
            this.btnFuncionLogLogistica.BackColor = System.Drawing.Color.Black;
            this.btnFuncionLogLogistica.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFuncionLogLogistica.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFuncionLogLogistica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnFuncionLogLogistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionLogLogistica.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.btnFuncionLogLogistica.ForeColor = System.Drawing.Color.White;
            this.btnFuncionLogLogistica.Location = new System.Drawing.Point(0, 165);
            this.btnFuncionLogLogistica.Margin = new System.Windows.Forms.Padding(0);
            this.btnFuncionLogLogistica.Name = "btnFuncionLogLogistica";
            this.btnFuncionLogLogistica.Size = new System.Drawing.Size(210, 33);
            this.btnFuncionLogLogistica.TabIndex = 19;
            this.btnFuncionLogLogistica.Text = "Log-Logística";
            this.btnFuncionLogLogistica.UseVisualStyleBackColor = false;
            // 
            // btnFuncionNormal
            // 
            this.btnFuncionNormal.BackColor = System.Drawing.Color.Black;
            this.btnFuncionNormal.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFuncionNormal.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFuncionNormal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnFuncionNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionNormal.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.btnFuncionNormal.ForeColor = System.Drawing.Color.White;
            this.btnFuncionNormal.Location = new System.Drawing.Point(0, 198);
            this.btnFuncionNormal.Margin = new System.Windows.Forms.Padding(0);
            this.btnFuncionNormal.Name = "btnFuncionNormal";
            this.btnFuncionNormal.Size = new System.Drawing.Size(210, 33);
            this.btnFuncionNormal.TabIndex = 20;
            this.btnFuncionNormal.Text = "Normal";
            this.btnFuncionNormal.UseVisualStyleBackColor = false;
            // 
            // btnFuncionFasesBiExponencial
            // 
            this.btnFuncionFasesBiExponencial.BackColor = System.Drawing.Color.Black;
            this.btnFuncionFasesBiExponencial.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFuncionFasesBiExponencial.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFuncionFasesBiExponencial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnFuncionFasesBiExponencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionFasesBiExponencial.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.btnFuncionFasesBiExponencial.ForeColor = System.Drawing.Color.White;
            this.btnFuncionFasesBiExponencial.Location = new System.Drawing.Point(0, 231);
            this.btnFuncionFasesBiExponencial.Margin = new System.Windows.Forms.Padding(0);
            this.btnFuncionFasesBiExponencial.Name = "btnFuncionFasesBiExponencial";
            this.btnFuncionFasesBiExponencial.Size = new System.Drawing.Size(210, 33);
            this.btnFuncionFasesBiExponencial.TabIndex = 21;
            this.btnFuncionFasesBiExponencial.Text = "Fases Bi-Exponencial";
            this.btnFuncionFasesBiExponencial.UseVisualStyleBackColor = false;
            // 
            // btnFuncionFasesBiWeibull
            // 
            this.btnFuncionFasesBiWeibull.BackColor = System.Drawing.Color.Black;
            this.btnFuncionFasesBiWeibull.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFuncionFasesBiWeibull.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFuncionFasesBiWeibull.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnFuncionFasesBiWeibull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionFasesBiWeibull.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.btnFuncionFasesBiWeibull.ForeColor = System.Drawing.Color.White;
            this.btnFuncionFasesBiWeibull.Location = new System.Drawing.Point(0, 264);
            this.btnFuncionFasesBiWeibull.Margin = new System.Windows.Forms.Padding(0);
            this.btnFuncionFasesBiWeibull.Name = "btnFuncionFasesBiWeibull";
            this.btnFuncionFasesBiWeibull.Size = new System.Drawing.Size(210, 33);
            this.btnFuncionFasesBiWeibull.TabIndex = 22;
            this.btnFuncionFasesBiWeibull.Text = "Fases Bi-Weibull";
            this.btnFuncionFasesBiWeibull.UseVisualStyleBackColor = false;
            // 
            // btnFuncionPoisson
            // 
            this.btnFuncionPoisson.BackColor = System.Drawing.Color.Black;
            this.btnFuncionPoisson.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFuncionPoisson.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFuncionPoisson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnFuncionPoisson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionPoisson.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.btnFuncionPoisson.ForeColor = System.Drawing.Color.White;
            this.btnFuncionPoisson.Location = new System.Drawing.Point(0, 297);
            this.btnFuncionPoisson.Margin = new System.Windows.Forms.Padding(0);
            this.btnFuncionPoisson.Name = "btnFuncionPoisson";
            this.btnFuncionPoisson.Size = new System.Drawing.Size(210, 33);
            this.btnFuncionPoisson.TabIndex = 23;
            this.btnFuncionPoisson.Text = "Poisson";
            this.btnFuncionPoisson.UseVisualStyleBackColor = false;
            // 
            // btnFuncionUniforme
            // 
            this.btnFuncionUniforme.BackColor = System.Drawing.Color.Black;
            this.btnFuncionUniforme.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFuncionUniforme.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFuncionUniforme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnFuncionUniforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionUniforme.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.btnFuncionUniforme.ForeColor = System.Drawing.Color.White;
            this.btnFuncionUniforme.Location = new System.Drawing.Point(0, 330);
            this.btnFuncionUniforme.Margin = new System.Windows.Forms.Padding(0);
            this.btnFuncionUniforme.Name = "btnFuncionUniforme";
            this.btnFuncionUniforme.Size = new System.Drawing.Size(210, 33);
            this.btnFuncionUniforme.TabIndex = 24;
            this.btnFuncionUniforme.Text = "Uniforme";
            this.btnFuncionUniforme.UseVisualStyleBackColor = false;
            // 
            // btnFuncionWeibull
            // 
            this.btnFuncionWeibull.BackColor = System.Drawing.Color.Black;
            this.btnFuncionWeibull.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFuncionWeibull.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFuncionWeibull.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnFuncionWeibull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionWeibull.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.btnFuncionWeibull.ForeColor = System.Drawing.Color.White;
            this.btnFuncionWeibull.Location = new System.Drawing.Point(0, 363);
            this.btnFuncionWeibull.Margin = new System.Windows.Forms.Padding(0);
            this.btnFuncionWeibull.Name = "btnFuncionWeibull";
            this.btnFuncionWeibull.Size = new System.Drawing.Size(210, 33);
            this.btnFuncionWeibull.TabIndex = 25;
            this.btnFuncionWeibull.Text = "Weibull";
            this.btnFuncionWeibull.UseVisualStyleBackColor = false;
            // 
            // pnlValoresAleatorios
            // 
            this.pnlValoresAleatorios.Controls.Add(this.listBox1);
            this.pnlValoresAleatorios.Controls.Add(this.btnGenerarValoresAleatorios);
            this.pnlValoresAleatorios.Controls.Add(this.lblTituloCantidadValoresGenerados);
            this.pnlValoresAleatorios.Controls.Add(this.nudCantidadGenerados);
            this.pnlValoresAleatorios.Controls.Add(this.label3);
            this.pnlValoresAleatorios.Location = new System.Drawing.Point(666, 215);
            this.pnlValoresAleatorios.Name = "pnlValoresAleatorios";
            this.pnlValoresAleatorios.Size = new System.Drawing.Size(264, 307);
            this.pnlValoresAleatorios.TabIndex = 23;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(237, 212);
            this.listBox1.TabIndex = 59;
            // 
            // btnGenerarValoresAleatorios
            // 
            this.btnGenerarValoresAleatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGenerarValoresAleatorios.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarValoresAleatorios.ForeColor = System.Drawing.Color.Black;
            this.btnGenerarValoresAleatorios.Location = new System.Drawing.Point(126, 43);
            this.btnGenerarValoresAleatorios.Name = "btnGenerarValoresAleatorios";
            this.btnGenerarValoresAleatorios.Size = new System.Drawing.Size(121, 30);
            this.btnGenerarValoresAleatorios.TabIndex = 58;
            this.btnGenerarValoresAleatorios.Text = "Generar";
            this.btnGenerarValoresAleatorios.UseVisualStyleBackColor = false;
            // 
            // lblTituloCantidadValoresGenerados
            // 
            this.lblTituloCantidadValoresGenerados.AutoSize = true;
            this.lblTituloCantidadValoresGenerados.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCantidadValoresGenerados.Location = new System.Drawing.Point(7, 30);
            this.lblTituloCantidadValoresGenerados.Name = "lblTituloCantidadValoresGenerados";
            this.lblTituloCantidadValoresGenerados.Size = new System.Drawing.Size(72, 20);
            this.lblTituloCantidadValoresGenerados.TabIndex = 57;
            this.lblTituloCantidadValoresGenerados.Text = "Cantidad";
            // 
            // nudCantidadGenerados
            // 
            this.nudCantidadGenerados.Location = new System.Drawing.Point(10, 53);
            this.nudCantidadGenerados.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCantidadGenerados.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadGenerados.Name = "nudCantidadGenerados";
            this.nudCantidadGenerados.Size = new System.Drawing.Size(78, 20);
            this.nudCantidadGenerados.TabIndex = 56;
            this.nudCantidadGenerados.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 23);
            this.label3.TabIndex = 55;
            this.label3.Text = "Generar valores aleatorios";
            // 
            // lblTituloFunciones
            // 
            this.lblTituloFunciones.AutoSize = true;
            this.lblTituloFunciones.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFunciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloFunciones.Location = new System.Drawing.Point(4, 83);
            this.lblTituloFunciones.Name = "lblTituloFunciones";
            this.lblTituloFunciones.Size = new System.Drawing.Size(207, 23);
            this.lblTituloFunciones.TabIndex = 25;
            this.lblTituloFunciones.Text = "Ranking Mejor Ajuste";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportarResultados);
            this.panel1.Location = new System.Drawing.Point(666, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 55);
            this.panel1.TabIndex = 26;
            // 
            // btnExportarResultados
            // 
            this.btnExportarResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.btnExportarResultados.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarResultados.ForeColor = System.Drawing.Color.White;
            this.btnExportarResultados.Location = new System.Drawing.Point(44, 9);
            this.btnExportarResultados.Name = "btnExportarResultados";
            this.btnExportarResultados.Size = new System.Drawing.Size(176, 36);
            this.btnExportarResultados.TabIndex = 17;
            this.btnExportarResultados.Text = "Exportar Resultados";
            this.btnExportarResultados.UseVisualStyleBackColor = false;
            // 
            // FrmAjusteFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTituloFunciones);
            this.Controls.Add(this.pnlValoresAleatorios);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlFunciones);
            this.Controls.Add(this.pnlMensaje);
            this.Controls.Add(this.pnlInfoFunciones);
            this.Controls.Add(this.pnlEventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAjusteFunciones";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlEventos.ResumeLayout(false);
            this.pnlEventos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtInversa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFuncion)).EndInit();
            this.pnlInfoFunciones.ResumeLayout(false);
            this.pnlInfoFunciones.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMensaje.ResumeLayout(false);
            this.pnlFunciones.ResumeLayout(false);
            this.pnlValoresAleatorios.ResumeLayout(false);
            this.pnlValoresAleatorios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadGenerados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlEventos;
        private System.Windows.Forms.Panel pnlInfoFunciones;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMensaje;
        private System.Windows.Forms.Label lblGraficoFuncion;
        private System.Windows.Forms.Label lblTituloFuncion;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.Timer timerMensaje;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFuncionBurr;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.FlowLayoutPanel pnlFunciones;
        private System.Windows.Forms.Panel pnlValoresAleatorios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFuncionBinomial;
        private System.Windows.Forms.Button btnFuncionExponencial;
        private System.Windows.Forms.Button btnFuncionLogistica;
        private System.Windows.Forms.Button btnFuncionLognormal;
        private System.Windows.Forms.Button btnFuncionLogLogistica;
        private System.Windows.Forms.Button btnFuncionNormal;
        private System.Windows.Forms.Button btnFuncionFasesBiExponencial;
        private System.Windows.Forms.Button btnFuncionFasesBiWeibull;
        private System.Windows.Forms.Button btnFuncionPoisson;
        private System.Windows.Forms.Button btnFuncionUniforme;
        private System.Windows.Forms.Button btnFuncionWeibull;
        private System.Windows.Forms.Label lblTituloFunciones;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtInversa;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtFuncion;
        private System.Windows.Forms.Label lblGraficoFuncionInversa;
        private System.Windows.Forms.Label lblFuncionInversa;
        private System.Windows.Forms.Label lblTituloFuncionInversa;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnGenerarValoresAleatorios;
        private System.Windows.Forms.Label lblTituloCantidadValoresGenerados;
        private System.Windows.Forms.NumericUpDown nudCantidadGenerados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExportarResultados;
    }
}