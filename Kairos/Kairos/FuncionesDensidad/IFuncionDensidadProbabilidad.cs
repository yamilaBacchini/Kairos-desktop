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
    public interface IFuncionDensidadProbabilidad
    {
        UnivariateDiscreteDistribution DistribucionDiscreta { get; }

        UnivariateContinuousDistribution DistribucionContinua { get; }

        ResultadoAjuste Ajustar(double[] eventos);

        List<int> ObtenerValores(int cantidad);
    }
}
