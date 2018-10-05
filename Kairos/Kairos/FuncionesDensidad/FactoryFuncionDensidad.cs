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
        public static FuncionDensidadProbabilidad Instancia(FuncionDensidad funcion, double[] eventos)
        {
            switch (funcion)
            {
                case FuncionDensidad.WEIBULL0_5:
                    return new FuncionWeibull0_5(eventos);
                case FuncionDensidad.BINOMIAL:
                    return new FuncionBinomial(eventos);
                case FuncionDensidad.EXPONENCIAL:
                    return new FuncionExponencial(eventos);
                case FuncionDensidad.LOGISTICA:
                    return new FuncionLogistica(eventos);
                case FuncionDensidad.LOG_NORMAL:
                    return new FuncionLogNormal(eventos);
                case FuncionDensidad.LOG_LOGISTICA:
                    return new FuncionLogLogistica(eventos);
                case FuncionDensidad.NORMAL:
                    return new FuncionNormal(eventos);
                case FuncionDensidad.WEIBULL1_5:
                    return new FuncionWeibull1_5(eventos);
                case FuncionDensidad.FASES_BI_WEIBULL:
                    return new FuncionFasesBiWeibull(eventos);
                case FuncionDensidad.POISSON:
                    return new FuncionPoisson(eventos);
                case FuncionDensidad.UNIFORME:
                    return new FuncionUniforme(eventos);
                case FuncionDensidad.WEIBULL:
                    return new FuncionWeibull(eventos);
                default:
                    return null;
            }
        }
    }
}
