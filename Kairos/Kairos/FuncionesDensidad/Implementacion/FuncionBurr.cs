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
    class FuncionBurr : FuncionDensidadProbabilidad, IFuncionRepresentable
    {
        private readonly string A = "";
        private readonly string B = "";
        private readonly string G = "";
        private readonly string K = "";
        public string StringFDP => string.Format("({0} * {3} * ((x - {2}) / {1}) ^ ({0} - 1)) / ({1} * (1 + ((x - {2}) / {1}) ^ {0}) ^ ({3} + 1))", A, B, G, K);

        public string StringInversa => string.Format("x = {1} * (((1 - R) ^ (-1 / {3}) - 1) ^ (1 / {0})) + {2}", A, B, G, K);

        public FuncionBurr(double[] eventos) : base(eventos)
        {
            try
            {
                Resultado = null;
                //funcion.Fit(eventos.Select(x => Convert.ToDouble(x)).ToArray());
                //return new ResultadoAjuste(funcion.ToString(), funcion.StandardDeviation, funcion.Median, funcion.Variance);
            }
            catch (Exception)
            {
                Resultado = null;
            }
        }
    }
}
