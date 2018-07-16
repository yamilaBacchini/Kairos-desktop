﻿using Kairos.Entidades;
using Kairos.Filtros;
using Kairos.FuncionesDensidad;
using Kairos.Modelo;
using Kairos.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kairos.Forms
{
    public partial class FrmAjusteFunciones : Form
    {
        private MetodologiaAjuste metodologia;
        private Segmentacion segmentacion;
        private List<Evento> eventos = null;
        private Dictionary<string, double> eventosSimplificados = null;
        private double[] intervalosEventosEaE = null;
        private ResultadoAjuste resultadoFuncionBurr = null;
        private ResultadoAjuste resultadoFuncionBinomial = null;
        private ResultadoAjuste resultadoFuncionExponencial = null;
        private ResultadoAjuste resultadoFuncionLogistica = null;
        private ResultadoAjuste resultadoFuncionLogNormal = null;
        private ResultadoAjuste resultadoFuncionLogLogistica = null;
        private ResultadoAjuste resultadoFuncionNormal = null;
        private ResultadoAjuste resultadoFuncionFasesBiExponencial = null;
        private ResultadoAjuste resultadoFuncionFasesBiWeibull = null;
        private ResultadoAjuste resultadoFuncionPoisson = null;
        private ResultadoAjuste resultadoFuncionUniforme = null;
        private ResultadoAjuste resultadoFuncionWeibull = null;
        private Dictionary<FuncionDensidad, ResultadoAjuste> lResultadosOrdenados = new Dictionary<FuncionDensidad, ResultadoAjuste>();

        public FrmAjusteFunciones(MetodologiaAjuste metodologia, Segmentacion segmentacion, List<Evento> eventos)
        {
            InitializeComponent();
            this.metodologia = metodologia;
            this.segmentacion = segmentacion;
            this.eventos = eventos;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAjusteFunciones_Load(object sender, EventArgs e)
        {
            CalcularEventosSimplificados();
            CalcularYOrdenarFunciones();
            OrdernarFuncionesEnVista();
            SetupGraficoFuncion();
            SetupGraficoInversa();
        }

        private void CalcularEventosSimplificados()
        {
            if (metodologia == MetodologiaAjuste.DT_CONSTANTE)
                eventosSimplificados = FdPUtils.Agrupar(segmentacion, eventos);
            else
            {
                eventosSimplificados = FdPUtils.AgruparIntervalos(eventos);
                intervalosEventosEaE = FdPUtils.CalcularIntervalos(eventos).ToArray();
            }
        }

        private void CalcularYOrdenarFunciones()
        {
            double[] arrEventos = null;
            if (metodologia == MetodologiaAjuste.DT_CONSTANTE)
                arrEventos = eventosSimplificados.Values.ToArray();
            else
                arrEventos = intervalosEventosEaE;
            resultadoFuncionBurr = FactoryFuncionDensidad.Instancia(FuncionDensidad.BURR, arrEventos).Resultado;
            if (resultadoFuncionBurr != null)
                lResultadosOrdenados.Add(FuncionDensidad.BURR, resultadoFuncionBurr);
            resultadoFuncionBinomial = FactoryFuncionDensidad.Instancia(FuncionDensidad.BINOMIAL, arrEventos).Resultado;
            if (resultadoFuncionBinomial != null)
                lResultadosOrdenados.Add(FuncionDensidad.BINOMIAL, resultadoFuncionBinomial);
            resultadoFuncionExponencial = FactoryFuncionDensidad.Instancia(FuncionDensidad.EXPONENCIAL, arrEventos).Resultado;
            if (resultadoFuncionExponencial != null)
                lResultadosOrdenados.Add(FuncionDensidad.EXPONENCIAL, resultadoFuncionExponencial);
            resultadoFuncionLogistica = FactoryFuncionDensidad.Instancia(FuncionDensidad.LOGISTICA, arrEventos).Resultado;
            if (resultadoFuncionLogistica != null)
                lResultadosOrdenados.Add(FuncionDensidad.LOGISTICA, resultadoFuncionLogistica);
            resultadoFuncionLogNormal = FactoryFuncionDensidad.Instancia(FuncionDensidad.LOG_NORMAL, arrEventos).Resultado;
            if (resultadoFuncionLogNormal != null)
                lResultadosOrdenados.Add(FuncionDensidad.LOG_NORMAL, resultadoFuncionLogNormal);
            resultadoFuncionLogLogistica = FactoryFuncionDensidad.Instancia(FuncionDensidad.LOG_LOGISTICA, arrEventos).Resultado;
            if (resultadoFuncionLogLogistica != null)
                lResultadosOrdenados.Add(FuncionDensidad.LOG_LOGISTICA, resultadoFuncionLogLogistica);
            resultadoFuncionNormal = FactoryFuncionDensidad.Instancia(FuncionDensidad.NORMAL, arrEventos).Resultado;
            if (resultadoFuncionNormal != null)
                lResultadosOrdenados.Add(FuncionDensidad.NORMAL, resultadoFuncionNormal);
            resultadoFuncionFasesBiExponencial = FactoryFuncionDensidad.Instancia(FuncionDensidad.FASES_BI_EXPONENCIAL, arrEventos).Resultado;
            if (resultadoFuncionFasesBiExponencial != null)
                lResultadosOrdenados.Add(FuncionDensidad.FASES_BI_EXPONENCIAL, resultadoFuncionFasesBiExponencial);
            resultadoFuncionFasesBiWeibull = FactoryFuncionDensidad.Instancia(FuncionDensidad.FASES_BI_WEIBULL, arrEventos).Resultado;
            if (resultadoFuncionFasesBiWeibull != null)
                lResultadosOrdenados.Add(FuncionDensidad.FASES_BI_WEIBULL, resultadoFuncionFasesBiWeibull);
            resultadoFuncionPoisson = FactoryFuncionDensidad.Instancia(FuncionDensidad.POISSON, arrEventos).Resultado;
            if (resultadoFuncionPoisson != null)
                lResultadosOrdenados.Add(FuncionDensidad.POISSON, resultadoFuncionPoisson);
            resultadoFuncionUniforme = FactoryFuncionDensidad.Instancia(FuncionDensidad.UNIFORME, arrEventos).Resultado;
            if (resultadoFuncionUniforme != null)
                lResultadosOrdenados.Add(FuncionDensidad.UNIFORME, resultadoFuncionUniforme);
            resultadoFuncionWeibull = FactoryFuncionDensidad.Instancia(FuncionDensidad.WEIBULL, arrEventos).Resultado;
            if (resultadoFuncionWeibull != null)
                lResultadosOrdenados.Add(FuncionDensidad.WEIBULL, resultadoFuncionWeibull);
            lResultadosOrdenados = lResultadosOrdenados.OrderBy(x => x.Value.DesvioEstandar).ToDictionary(x => x.Key, y => y.Value);
        }

        private void OrdernarFuncionesEnVista()
        {
            List<Button> controls = new List<Button>();
            foreach (var item in pnlFunciones.Controls)
            {
                controls.Add((Button)item);
            }
            pnlFunciones.Controls.Clear();
            foreach (var item in lResultadosOrdenados)
            {
                foreach (var control in controls)
                {
                    var auxName = control.Name.Replace("btnFuncion", "");
                    if (String.Compare(item.Key.ToString().Replace("_", ""), auxName, true) == 0)
                        pnlFunciones.Controls.Add(control);
                }
            }
        }

        private void SetupGraficoFuncion()
        {
            this.chrtFuncion.Series.Clear();
            this.chrtFuncion.Palette = ChartColorPalette.EarthTones;
            this.chrtFuncion.Titles.Add("Funcion de Densidad de Probabilidad");
            Series series = this.chrtFuncion.Series.Add("Eventos");
            foreach (var item in eventosSimplificados.OrderBy(x => Convert.ToDouble(x.Key)))
            {
                series.Points.AddXY(item.Key, item.Value);
            }
        }

        private void GraficarLineaFDP(FuncionDensidadProbabilidad fdp)
        {
            Series series = this.chrtFuncion.Series.FindByName("FDP");
            if (series == null)
            {
                series = this.chrtFuncion.Series.Add("FDP");
                series.ChartType = SeriesChartType.Line;
            }
            else
                series.Points.Clear();
            List<double> lGenerados = fdp.ObtenerValores(10);
            foreach (var item in lGenerados)
            {
                series.Points.Add(item);
            }
        }

        private void SetupGraficoInversa()
        {
        }

        private void BotonSeleccionado(Control boton)
        {
            boton.BackColor = Color.FromArgb(187, 0, 4);
            foreach (Control control in pnlFunciones.Controls)
            {
                if (control != boton)
                {
                    control.BackColor = Color.Black;
                    control.ForeColor = Color.White;
                }
            }
        }

        private void CambiarLblGraficoFuncion(string nombreFuncion)
        {
            lblGraficoFuncion.Text = "Grafico funcion " + nombreFuncion;
        }

        private void CambiarRepresentacionFuncionEInversa(ResultadoAjuste fdp)
        {
            lblFuncion.Text = fdp.Funcion;
            lblFuncionInversa.Text = fdp.Inversa;
        }

        private void btnFuncionBurr_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
            CambiarLblGraficoFuncion("Burr");
            CambiarRepresentacionFuncionEInversa(resultadoFuncionBurr);
            GraficarLineaFDP(resultadoFuncionBurr.FDP);
        }

        private void btnFuncionBinomial_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
            CambiarLblGraficoFuncion("Binomial");
            CambiarRepresentacionFuncionEInversa(resultadoFuncionBinomial);
            GraficarLineaFDP(resultadoFuncionBinomial.FDP);
        }

        private void btnFuncionExponencial_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
            CambiarLblGraficoFuncion("Exponencial");
            CambiarRepresentacionFuncionEInversa(resultadoFuncionExponencial);
            GraficarLineaFDP(resultadoFuncionExponencial.FDP);
        }

        private void btnFuncionLogistica_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
            CambiarLblGraficoFuncion("Logistica");
            CambiarRepresentacionFuncionEInversa(resultadoFuncionLogistica);
            GraficarLineaFDP(resultadoFuncionLogistica.FDP);
        }

        private void btnFuncionLognormal_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
            CambiarLblGraficoFuncion("Log-Normal");
            CambiarRepresentacionFuncionEInversa(resultadoFuncionLogNormal);
            GraficarLineaFDP(resultadoFuncionLogNormal.FDP);
        }

        private void btnFuncionLogLogistica_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
            CambiarLblGraficoFuncion("Log-Logistica");
            CambiarRepresentacionFuncionEInversa(resultadoFuncionLogLogistica);
            GraficarLineaFDP(resultadoFuncionLogLogistica.FDP);
        }

        private void btnFuncionNormal_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
            CambiarLblGraficoFuncion("Normal");
            CambiarRepresentacionFuncionEInversa(resultadoFuncionNormal);
            GraficarLineaFDP(resultadoFuncionNormal.FDP);
        }

        private void btnFuncionFasesBiExponencial_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
            CambiarLblGraficoFuncion("Fases Bi-Exponencial");
            CambiarRepresentacionFuncionEInversa(resultadoFuncionFasesBiExponencial);
            GraficarLineaFDP(resultadoFuncionFasesBiExponencial.FDP);
        }

        private void btnFuncionFasesBiWeibull_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
            CambiarLblGraficoFuncion("Fases Bi-Weibull");
            CambiarRepresentacionFuncionEInversa(resultadoFuncionFasesBiWeibull);
            GraficarLineaFDP(resultadoFuncionFasesBiWeibull.FDP);
        }

        private void btnFuncionPoisson_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
            CambiarLblGraficoFuncion("Poisson");
            CambiarRepresentacionFuncionEInversa(resultadoFuncionPoisson);
            GraficarLineaFDP(resultadoFuncionPoisson.FDP);
        }

        private void btnFuncionUniforme_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
            CambiarLblGraficoFuncion("Uniforme");
            CambiarRepresentacionFuncionEInversa(resultadoFuncionUniforme);
            GraficarLineaFDP(resultadoFuncionUniforme.FDP);
        }

        private void btnFuncionWeibull_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
            CambiarLblGraficoFuncion("Weibull");
            CambiarRepresentacionFuncionEInversa(resultadoFuncionWeibull);
            GraficarLineaFDP(resultadoFuncionWeibull.FDP);
        }
    }
}
