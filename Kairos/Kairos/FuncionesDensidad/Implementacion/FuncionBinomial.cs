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
    class FuncionBinomial : FuncionDensidadProbabilidad, IFuncionRepresentable
    {
        public UnivariateDiscreteDistribution DistribucionDiscreta;

        public UnivariateContinuousDistribution DistribucionContinua => null;

        public string StringFDP => string.Format("f(x)=({0} x) {1}^x(1-{1})^({0}-x)", DistribucionDiscreta.ToString(), DistribucionDiscreta.ToString());

        public string StringInversa => "No implementado aun";

        public FuncionBinomial(double[] eventos) : base(eventos)
        {
            try
            {
                DistribucionDiscreta = new BinomialDistribution();
                DistribucionDiscreta.Fit(eventos);
                Resultado = new ResultadoAjuste(StringFDP, StringInversa, DistribucionDiscreta.StandardDeviation, DistribucionDiscreta.Mean, DistribucionDiscreta.Variance, this);
            }
            catch (Exception)
            {
                Resultado = null;
            }
        }

        public override List<double> ObtenerValores(int cantidad)
        {
            List<double> result = new List<double>();
            Parallel.ForEach(DistribucionDiscreta.Generate(cantidad), x => {
                result.Add(DistribucionDiscreta.DistributionFunction(x));
            });
            return result;
        }
    }
}
