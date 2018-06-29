using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kairos.Entidades;
using Kairos.Modelo;
using Accord.Statistics.Distributions.DensityKernels;

namespace Kairos.FuncionesDensidad.Implementacion
{
    class FuncionBurr : IFuncionDensidadProbabilidad
    {
        public ResultadoAjuste Ajustar(List<int> eventosEaE)
        {
            //var funcion = new BurrDistribution();
            //funcion.Fit(eventosEaE.ToArray());
            //return new ResultadoAjuste(funcion.ToString(), funcion.StandardDeviation, funcion.Entropy, funcion.Median, funcion.Variance);
            return null;
        }
    }
}
