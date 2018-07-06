using Kairos.Entidades;
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
                eventosSimplificados = FdPUtils.CalcularIntervalos(eventos);
        }

        private void CalcularYOrdenarFunciones()
        {
            resultadoFuncionBurr = FactoryFuncionDensidad.Instancia(FuncionDensidad.BURR).Ajustar(eventosSimplificados.Values.ToArray());
            if (resultadoFuncionBurr != null)
                lResultadosOrdenados.Add(FuncionDensidad.BURR, resultadoFuncionBurr);
            resultadoFuncionBinomial = FactoryFuncionDensidad.Instancia(FuncionDensidad.BINOMIAL).Ajustar(eventosSimplificados.Values.ToArray());
            if (resultadoFuncionBinomial != null)
                lResultadosOrdenados.Add(FuncionDensidad.BINOMIAL, resultadoFuncionBinomial);
            resultadoFuncionExponencial = FactoryFuncionDensidad.Instancia(FuncionDensidad.EXPONENCIAL).Ajustar(eventosSimplificados.Values.ToArray());
            if (resultadoFuncionExponencial != null)
                lResultadosOrdenados.Add(FuncionDensidad.EXPONENCIAL, resultadoFuncionExponencial);
            resultadoFuncionLogistica = FactoryFuncionDensidad.Instancia(FuncionDensidad.LOGISTICA).Ajustar(eventosSimplificados.Values.ToArray());
            if (resultadoFuncionLogistica != null)
                lResultadosOrdenados.Add(FuncionDensidad.LOGISTICA, resultadoFuncionLogistica);
            resultadoFuncionLogNormal = FactoryFuncionDensidad.Instancia(FuncionDensidad.LOG_NORMAL).Ajustar(eventosSimplificados.Values.ToArray());
            if (resultadoFuncionLogNormal != null)
                lResultadosOrdenados.Add(FuncionDensidad.LOG_NORMAL, resultadoFuncionLogNormal);
            resultadoFuncionLogLogistica = FactoryFuncionDensidad.Instancia(FuncionDensidad.LOG_LOGISTICA).Ajustar(eventosSimplificados.Values.ToArray());
            if (resultadoFuncionLogLogistica != null)
                lResultadosOrdenados.Add(FuncionDensidad.LOG_LOGISTICA, resultadoFuncionLogLogistica);
            resultadoFuncionNormal = FactoryFuncionDensidad.Instancia(FuncionDensidad.NORMAL).Ajustar(eventosSimplificados.Values.ToArray());
            if (resultadoFuncionNormal != null)
                lResultadosOrdenados.Add(FuncionDensidad.NORMAL, resultadoFuncionNormal);
            resultadoFuncionFasesBiExponencial = FactoryFuncionDensidad.Instancia(FuncionDensidad.FASES_BI_EXPONENCIAL).Ajustar(eventosSimplificados.Values.ToArray());
            if (resultadoFuncionFasesBiExponencial != null)
                lResultadosOrdenados.Add(FuncionDensidad.FASES_BI_EXPONENCIAL, resultadoFuncionFasesBiExponencial);
            resultadoFuncionFasesBiWeibull = FactoryFuncionDensidad.Instancia(FuncionDensidad.FASES_BI_WEIBULL).Ajustar(eventosSimplificados.Values.ToArray());
            if (resultadoFuncionFasesBiWeibull != null)
                lResultadosOrdenados.Add(FuncionDensidad.FASES_BI_WEIBULL, resultadoFuncionFasesBiWeibull);
            resultadoFuncionPoisson = FactoryFuncionDensidad.Instancia(FuncionDensidad.POISSON).Ajustar(eventosSimplificados.Values.ToArray());
            if (resultadoFuncionPoisson != null)
                lResultadosOrdenados.Add(FuncionDensidad.POISSON, resultadoFuncionPoisson);
            resultadoFuncionUniforme = FactoryFuncionDensidad.Instancia(FuncionDensidad.UNIFORME).Ajustar(eventosSimplificados.Values.ToArray());
            if (resultadoFuncionUniforme != null)
                lResultadosOrdenados.Add(FuncionDensidad.UNIFORME, resultadoFuncionUniforme);
            resultadoFuncionWeibull = FactoryFuncionDensidad.Instancia(FuncionDensidad.WEIBULL).Ajustar(eventosSimplificados.Values.ToArray());
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
            // Set palette
            this.chrtFuncion.Palette = ChartColorPalette.EarthTones;

            // Set title
            this.chrtFuncion.Titles.Add("Distribucion");

            // Add series.
            foreach (var item in eventosSimplificados)
            {
                Series series = this.chrtFuncion.Series.Add(item.Key);
                series.Points.Add(item.Value);
            }
            //for (int i = 0; i < eventosSimplificados.Count; i++)
            //{
            //    Series series = this.chrtFuncion.Series.Add(i.ToString());
            //    series.Points.Add(eventosSimplificados.ElementAt(i).Value);
            //}
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

        private void btnFuncionBurr_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
        }

        private void btnFuncionBinomial_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
        }

        private void btnFuncionExponencial_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
        }

        private void btnFuncionLogistica_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
        }

        private void btnFuncionLognormal_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
        }

        private void btnFuncionLogLogistica_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
        }

        private void btnFuncionNormal_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
        }

        private void btnFuncionFasesBiExponencial_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
        }

        private void btnFuncionFasesBiWeibull_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
        }

        private void btnFuncionPoisson_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
        }

        private void btnFuncionUniforme_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
        }

        private void btnFuncionWeibull_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Control)sender);
        }
    }
}
