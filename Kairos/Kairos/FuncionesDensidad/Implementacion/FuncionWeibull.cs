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
    class FuncionWeibull : IFuncionDensidadProbabilidad
    {
        private readonly double shape = 0.5;
        private readonly double scale = 0.5;

        public ResultadoAjuste Ajustar(List<int> eventos)
        {
            try
            {
                var funcion = new WeibullDistribution(shape, scale);
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
