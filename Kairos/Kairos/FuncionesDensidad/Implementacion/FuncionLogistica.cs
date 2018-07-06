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
    class FuncionLogistica : IFuncionDensidadProbabilidad
    {
        public UnivariateDiscreteDistribution DistribucionDiscreta => null;

        public UnivariateContinuousDistribution DistribucionContinua => new LogisticDistribution();

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

        public string StringFDP()
        {
            throw new NotImplementedException();
        }
    }
}
