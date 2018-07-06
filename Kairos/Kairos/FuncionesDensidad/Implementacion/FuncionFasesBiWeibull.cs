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
    class FuncionFasesBiWeibull : IFuncionDensidadProbabilidad
    {
        public UnivariateDiscreteDistribution DistribucionDiscreta => null;

        public UnivariateContinuousDistribution DistribucionContinua => null;

        public ResultadoAjuste Ajustar(double[] eventosEaE)
        {
            return null;
        }

        public List<int> ObtenerValores(int cantidad)
        {
            return null;
        }

        public string StringFDP()
        {
            throw new NotImplementedException();
        }
    }
}
