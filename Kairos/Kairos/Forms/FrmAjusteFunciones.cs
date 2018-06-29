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

namespace Kairos.Forms
{
    public partial class FrmAjusteFunciones : Form
    {
        private MetodologiaAjuste metodologia;
        private Segmentacion segmentacion;
        private List<Evento> eventos = null;
        private List<int> eventosSimplificados = null;
        private ResultadoAjuste resultadoFuncionBurr = null;
        private ResultadoAjuste resultadoFuncionBinomial = null;
        private ResultadoAjuste resultadoFuncionExponencial = null;
        private ResultadoAjuste resultadoFuncionLogistica = null;
        private ResultadoAjuste resultadoFuncionLognormal = null;
        private ResultadoAjuste resultadoFuncionLogLogistica = null;
        private ResultadoAjuste resultadoFuncionNormal = null;
        private ResultadoAjuste resultadoFuncionFasesBiExponencial = null;
        private ResultadoAjuste resultadoFuncionFasesBiWeibull = null;
        private ResultadoAjuste resultadoFuncionPoisson = null;
        private ResultadoAjuste resultadoFuncionUniforme = null;
        private ResultadoAjuste resultadoFuncionWeibull = null;

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
            CalcularFunciones();
        }

        private void CalcularEventosSimplificados()
        {
            if (metodologia == MetodologiaAjuste.DT_CONSTANTE)
            {
                Dictionary<int, int> grupos = FdPUtils.Agrupar(segmentacion, eventos);
                eventosSimplificados = grupos.Values.ToList();
            }
            else
                eventosSimplificados = FdPUtils.CalcularIntervalos(eventos);
        }

        private void CalcularFunciones()
        {
            resultadoFuncionBurr = FactoryFuncionDensidad.Instancia(FuncionDensidad.BURR).Ajustar(eventosSimplificados);
            resultadoFuncionBinomial = FactoryFuncionDensidad.Instancia(FuncionDensidad.BINOMIAL).Ajustar(eventosSimplificados);
            resultadoFuncionExponencial = FactoryFuncionDensidad.Instancia(FuncionDensidad.EXPONENCIAL).Ajustar(eventosSimplificados);
            resultadoFuncionLogistica = FactoryFuncionDensidad.Instancia(FuncionDensidad.LOGISTICA).Ajustar(eventosSimplificados);
            resultadoFuncionLognormal = FactoryFuncionDensidad.Instancia(FuncionDensidad.LOGNORMAL).Ajustar(eventosSimplificados);
            resultadoFuncionLogLogistica = FactoryFuncionDensidad.Instancia(FuncionDensidad.LOG_LOGISTICA).Ajustar(eventosSimplificados);
            resultadoFuncionNormal = FactoryFuncionDensidad.Instancia(FuncionDensidad.NORMAL).Ajustar(eventosSimplificados);
            resultadoFuncionFasesBiExponencial = FactoryFuncionDensidad.Instancia(FuncionDensidad.FASES_BI_EXPONENCIAL).Ajustar(eventosSimplificados);
            resultadoFuncionFasesBiWeibull = FactoryFuncionDensidad.Instancia(FuncionDensidad.FASES_BI_WEIBULL).Ajustar(eventosSimplificados);
            resultadoFuncionPoisson = FactoryFuncionDensidad.Instancia(FuncionDensidad.POISSON).Ajustar(eventosSimplificados);
            resultadoFuncionUniforme = FactoryFuncionDensidad.Instancia(FuncionDensidad.UNIFORME).Ajustar(eventosSimplificados);
            resultadoFuncionWeibull = FactoryFuncionDensidad.Instancia(FuncionDensidad.WEIBULL).Ajustar(eventosSimplificados);
        }
    }
}
