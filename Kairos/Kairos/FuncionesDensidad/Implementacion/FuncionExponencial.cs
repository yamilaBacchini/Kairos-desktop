using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kairos.Entidades;
using Kairos.Modelo;
using Accord.Statistics.Distributions.Univariate;

namespace Kairos.FuncionesDensidad.Implementacion
{
    class FuncionExponencial : IFuncionDensidadProbabilidad
    {
        public ResultadoAjuste Ajustar(List<int> eventos)
        {
            try
            {
                var funcion = new ExponentialDistribution();
                funcion.Fit(eventos.Select(x => Convert.ToDouble(x)).ToArray());
                return new ResultadoAjuste(funcion.ToString(), funcion.StandardDeviation, funcion.Mean, funcion.Variance);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
