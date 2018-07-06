using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kairos.Entidades;
using Kairos.Modelo;
using Accord.Statistics.Distributions.Univariate;
using MathNet.Symbolics;
using Expr = MathNet.Symbolics.Expression;

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
                return new ResultadoAjuste(StringFDP(), DistribucionDiscreta.StandardDeviation, DistribucionDiscreta.Mean, DistribucionDiscreta.Variance);
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
            return string.Format("f(x)=({0} x) {1}^x(1-{1})^({0}-x)", DistribucionDiscreta.Mean, DistribucionDiscreta.Median);
        }
    }
}
