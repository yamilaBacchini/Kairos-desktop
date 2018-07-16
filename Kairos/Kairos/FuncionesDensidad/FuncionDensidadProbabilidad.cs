using Accord.Statistics.Distributions.Univariate;
using Kairos.Entidades;
using Kairos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.FuncionesDensidad
{
    public abstract class FuncionDensidadProbabilidad
    {
        UnivariateDiscreteDistribution DistribucionDiscreta { get; }

        UnivariateContinuousDistribution DistribucionContinua { get; }

        public ResultadoAjuste Resultado { get; protected set; }

        public FuncionDensidadProbabilidad(double[] eventos)
        {
        }

        public abstract List<double> ObtenerValores(int cantidad);
    }
}
