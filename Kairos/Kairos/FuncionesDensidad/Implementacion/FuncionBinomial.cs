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
        public UnivariateDiscreteDistribution DistribucionDiscreta => new BinomialDistribution();

        public UnivariateContinuousDistribution DistribucionContinua => null;

        public ResultadoAjuste Ajustar(double[] eventos)
        {
            try
            {
                DistribucionDiscreta.Fit(eventos);
                return new ResultadoAjuste(DistribucionDiscreta.ToString(), DistribucionDiscreta.StandardDeviation, DistribucionDiscreta.Mean, DistribucionDiscreta.Variance);
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
