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
        private double[] eventosParaAjuste = null;
        private ResultadoAjuste resultadoSeleccionado = null;
        private ResultadoAjuste resultadoFuncionWeibull0_5 = null;
        private ResultadoAjuste resultadoFuncionBinomial = null;
        private ResultadoAjuste resultadoFuncionExponencial = null;
        private ResultadoAjuste resultadoFuncionLogistica = null;
        private ResultadoAjuste resultadoFuncionLogNormal = null;
        private ResultadoAjuste resultadoFuncionLogLogistica = null;
        private ResultadoAjuste resultadoFuncionNormal = null;
        private ResultadoAjuste resultadoFuncionWeibull1_5 = null;
        private ResultadoAjuste resultadoFuncionWeibull3 = null;
        private ResultadoAjuste resultadoFuncionPoisson = null;
        private ResultadoAjuste resultadoFuncionUniforme = null;
        private ResultadoAjuste resultadoFuncionWeibull5 = null;
        private Dictionary<FuncionDensidad, ResultadoAjuste> lResultadosOrdenados = new Dictionary<FuncionDensidad, ResultadoAjuste>();
        private int flagIntervalos=0;
        private List<Double> intervalos;

        public FrmAjusteFunciones(MetodologiaAjuste metodologia, Segmentacion segmentacion, List<Evento> eventos,int flagIntervalos)
        {
            InitializeComponent();
            this.metodologia = metodologia;
            this.segmentacion = segmentacion;
            this.eventos = eventos;
            this.flagIntervalos = flagIntervalos;
        }

        public FrmAjusteFunciones(MetodologiaAjuste metodologia, Segmentacion segmentacion, List<Double> intervalos, int flagIntervalos)
        {
            InitializeComponent();
            this.metodologia = metodologia;
            this.segmentacion = segmentacion;
            this.intervalos = intervalos;
            this.flagIntervalos = flagIntervalos;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAjusteFunciones_Load(object sender, EventArgs e)
        {
            CalcularEventosSimplificados();
            CalcularYOrdenarFunciones();
            OrdenarFuncionesEnVista();
            SetupGraficoFuncion();
        }

        private void CalcularEventosSimplificados()
        {
            if(flagIntervalos==0)
            {
                if (metodologia == MetodologiaAjuste.DT_CONSTANTE)
                {
                   //eventosSimplificados = FdPUtils.AgruparSegmentacionProbabilidad(segmentacion, eventos);
                   eventosParaAjuste = FdPUtils.AgruparSegmentacion(segmentacion,eventos).ToArray();
                }
                else if(metodologia == MetodologiaAjuste.EVENTO_A_EVENTO)
                {
                    eventosSimplificados = FdPUtils.AgruparIntervalos(eventos);
                    eventosParaAjuste = FdPUtils.CalcularIntervalos(eventos).ToArray();
                }
            }
            else
            {
                double cant = intervalos.Count;
                eventosSimplificados= intervalos.GroupBy(x => x).ToDictionary(x => x.Key.ToString(), x => x.Count() /(cant > 1 ? cant - 1 : cant));
                eventosParaAjuste = intervalos.ToArray();
            }
            
        }

        private void CalcularYOrdenarFunciones()
        {
            double[] arrEventos = eventosParaAjuste.ToArray();

           
            resultadoFuncionWeibull0_5 = FactoryFuncionDensidad.Instancia(FuncionDensidad.WEIBULL05, arrEventos).Resultado;
            if (resultadoFuncionWeibull0_5 != null)
                lResultadosOrdenados.Add(FuncionDensidad.WEIBULL05, resultadoFuncionWeibull0_5);
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
            resultadoFuncionWeibull1_5 = FactoryFuncionDensidad.Instancia(FuncionDensidad.WEIBULL15, arrEventos).Resultado;
            if (resultadoFuncionWeibull1_5 != null)
                lResultadosOrdenados.Add(FuncionDensidad.WEIBULL15, resultadoFuncionWeibull1_5);
            resultadoFuncionWeibull3 = FactoryFuncionDensidad.Instancia(FuncionDensidad.WEIBULL3, arrEventos).Resultado;
            if (resultadoFuncionWeibull3 != null)
                lResultadosOrdenados.Add(FuncionDensidad.WEIBULL3, resultadoFuncionWeibull3);
            resultadoFuncionPoisson = FactoryFuncionDensidad.Instancia(FuncionDensidad.POISSON, arrEventos).Resultado;
            if (resultadoFuncionPoisson != null)
                lResultadosOrdenados.Add(FuncionDensidad.POISSON, resultadoFuncionPoisson);
            resultadoFuncionUniforme = FactoryFuncionDensidad.Instancia(FuncionDensidad.UNIFORME, arrEventos).Resultado;
            if (resultadoFuncionUniforme != null)
                lResultadosOrdenados.Add(FuncionDensidad.UNIFORME, resultadoFuncionUniforme);
            resultadoFuncionWeibull5 = FactoryFuncionDensidad.Instancia(FuncionDensidad.WEIBULL5, arrEventos).Resultado;
            if (resultadoFuncionWeibull5 != null)
                lResultadosOrdenados.Add(FuncionDensidad.WEIBULL5, resultadoFuncionWeibull5);
            lResultadosOrdenados = lResultadosOrdenados.OrderBy(x => x.Value.DesvioEstandar).ToDictionary(x => x.Key, y => y.Value);
        }

        private void OrdenarFuncionesEnVista()
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
            this.chrtFuncion.Palette = ChartColorPalette.None;
            this.chrtFuncion.Titles.Add("Funcion de Densidad de Probabilidad");
            Series series = this.chrtFuncion.Series.Add("Eventos");
            series.Color = Color.Red;
            series.BorderColor = Color.Black;
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
                series.BorderWidth = 2;
            }
            else
                series.Points.Clear();
            Dictionary<double, double> lGenerados = fdp.ObtenerDensidad(100);
            foreach (var item in lGenerados)
            {
                series.Points.AddXY(item.Key, item.Value);
            }
        }

        private void GraficarLineaInversa(FuncionDensidadProbabilidad fdp)
        {
            Series series = this.chrtInversa.Series.FindByName("Inversa");
            if (series == null)
            {
                series = this.chrtInversa.Series.Add("Inversa");
                series.ChartType = SeriesChartType.Line;
                series.BorderWidth = 2;
            }
            else
                series.Points.Clear();
            Dictionary<double, double> lGenerados = fdp.ObtenerDensidadInversa(100);
            foreach (var item in lGenerados)
            {
                series.Points.AddXY(item.Key, item.Value);
            }
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

        private void SetupPantallaSegunFDP(object boton, string nombreFuncion, ResultadoAjuste funcion)
        {
            BotonSeleccionado((Control)boton);
            CambiarLblGraficoFuncion(nombreFuncion);
            CambiarRepresentacionFuncionEInversa(funcion);
            GraficarLineaFDP(funcion.FDP);
            GraficarLineaInversa(funcion.FDP);
            resultadoSeleccionado = funcion;
            if (nombreFuncion.Contains("Poisson") || nombreFuncion.Contains("Binomial"))
                lblTituloFuncionInversa.Text = "Función Acumulada";
            else
                lblTituloFuncionInversa.Text = "Función Inversa";
        }

        private void btnFuncionWeibull0_5_Click(object sender, EventArgs e) => SetupPantallaSegunFDP(sender, "Weibull 0.5", resultadoFuncionWeibull0_5);

        private void btnFuncionBinomial_Click(object sender, EventArgs e) => SetupPantallaSegunFDP(sender, "Binomial", resultadoFuncionBinomial);

        private void btnFuncionExponencial_Click(object sender, EventArgs e) => SetupPantallaSegunFDP(sender, "Exponencial", resultadoFuncionExponencial);

        private void btnFuncionLogistica_Click(object sender, EventArgs e) => SetupPantallaSegunFDP(sender, "Logistica", resultadoFuncionLogistica);

        private void btnFuncionLognormal_Click(object sender, EventArgs e) => SetupPantallaSegunFDP(sender, "Log-Normal", resultadoFuncionLogNormal);

        private void btnFuncionLogLogistica_Click(object sender, EventArgs e) => SetupPantallaSegunFDP(sender, "Log-Logistica", resultadoFuncionLogLogistica);

        private void btnFuncionNormal_Click(object sender, EventArgs e) => SetupPantallaSegunFDP(sender, "Normal", resultadoFuncionNormal);

        private void btnFuncionWeibull1_5_Click(object sender, EventArgs e) => SetupPantallaSegunFDP(sender, "Weibull 1.5", resultadoFuncionWeibull1_5);

        private void btnFuncionWeibull3_Click(object sender, EventArgs e) => SetupPantallaSegunFDP(sender, "Weibull 3", resultadoFuncionWeibull3);

        private void btnFuncionPoisson_Click(object sender, EventArgs e) => SetupPantallaSegunFDP(sender, "Poisson", resultadoFuncionPoisson);

        private void btnFuncionUniforme_Click(object sender, EventArgs e) => SetupPantallaSegunFDP(sender, "Uniforme", resultadoFuncionUniforme);

        private void btnFuncionWeibull5_Click(object sender, EventArgs e) => SetupPantallaSegunFDP(sender, "Weibull", resultadoFuncionWeibull5);

        private void btnGenerarValoresAleatorios_Click(object sender, EventArgs e)
        {
            if (resultadoSeleccionado != null)
            {
                lbxGenerados.Items.Clear();
                int cant = Convert.ToInt32(nudCantidadGenerados.Value);
                int[] arrGenerados = resultadoSeleccionado.FDP.GenerarValores(cant).Select(x => Convert.ToInt32(x)).ToArray();
                lbxGenerados.Items.AddRange(arrGenerados.Select(x => (object)x).ToArray());
            }
            else
                MessageBox.Show("Debe seleccionar una FDP", "Seleccione FDP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}
