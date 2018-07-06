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

        public UnivariateDiscreteDistribution DistribucionDiscreta => null;

        public UnivariateContinuousDistribution DistribucionContinua => new WeibullDistribution(shape, scale);

        public ResultadoAjuste Ajustar(double[] eventos)
        {
            try
            {
                DistribucionContinua.Fit(eventos);
                return new ResultadoAjuste(DistribucionContinua.ToString(), DistribucionContinua.StandardDeviation, DistribucionContinua.Mean, DistribucionContinua.Variance);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<int> ObtenerValores(int cantidad)
        {
            return DistribucionContinua.Generate(cantidad).Select(x => Convert.ToInt32(x)).ToList();
        }
    }
}
