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
    class FuncionBinomial : IFuncionDensidadProbabilidad
    {
        public ResultadoAjuste Ajustar(List<int> eventos)
        {
            var funcion = new BinomialDistribution();
            funcion.Fit(eventos.ToArray());
            return new ResultadoAjuste(funcion.ToString(), funcion.StandardDeviation, funcion.Mean, funcion.Variance);
        }
    }
}
