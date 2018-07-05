using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Statistics.Distributions.Univariate;
using Kairos.Entidades;
using Kairos.Modelo;

namespace Kairos.FuncionesDensidad.Implementacion
{
    class FuncionPoisson : IFuncionDensidadProbabilidad
    {
        public ResultadoAjuste Ajustar(List<int> eventos)
        {
            try
            {
                var funcion = new PoissonDistribution();
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
