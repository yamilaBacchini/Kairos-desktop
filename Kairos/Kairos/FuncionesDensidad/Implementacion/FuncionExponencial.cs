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
        public UnivariateDiscreteDistribution DistribucionDiscreta => null;

        public UnivariateContinuousDistribution DistribucionContinua => new ExponentialDistribution();

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
            return DistribucionDiscreta.Generate(cantidad).ToList();
        }
    }
}
