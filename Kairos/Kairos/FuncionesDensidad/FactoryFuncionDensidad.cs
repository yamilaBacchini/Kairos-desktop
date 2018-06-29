using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kairos.Modelo;
using Kairos.FuncionesDensidad.Implementacion;

namespace Kairos.FuncionesDensidad
{
    public static class FactoryFuncionDensidad
    {
        public static IFuncionDensidadProbabilidad Instancia(FuncionDensidad funcion)
        {
            switch (funcion)
            {
                case FuncionDensidad.BURR:
                    return new FuncionBurr();
                case FuncionDensidad.BINOMIAL:
                    return new FuncionBinomial();
                case FuncionDensidad.EXPONENCIAL:
                    return new FuncionExponencial();
                case FuncionDensidad.LOGISTICA:
                    return new FuncionLogistica();
                case FuncionDensidad.LOGNORMAL:
                    return new FuncionLognormal();
                case FuncionDensidad.LOG_LOGISTICA:
                    return new FuncionLogLogistica();
                case FuncionDensidad.NORMAL:
                    return new FuncionNormal();
                case FuncionDensidad.FASES_BI_EXPONENCIAL:
                    return new FuncionFasesBiExponencial();
                case FuncionDensidad.FASES_BI_WEIBULL:
                    return new FuncionFasesBiWeibull();
                case FuncionDensidad.POISSON:
                    return new FuncionPoisson();
                case FuncionDensidad.UNIFORME:
                    return new FuncionUniforme();
                case FuncionDensidad.WEIBULL:
                    return new FuncionWeibull();
                default:
                    return null;
            }
        }
    }
}
