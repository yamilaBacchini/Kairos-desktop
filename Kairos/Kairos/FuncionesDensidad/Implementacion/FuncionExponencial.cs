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
    class FuncionExponencial : FuncionDensidadProbabilidad, IFuncionRepresentable
    {
        public UnivariateDiscreteDistribution DistribucionDiscreta => null;

        public UnivariateContinuousDistribution DistribucionContinua;

        public string StringFDP => "No implementado aun";

        public string StringInversa => "No implementado aun";

        public FuncionExponencial(double[] eventos) : base(eventos)
        {
            try
            {
                DistribucionContinua = new ExponentialDistribution();
                DistribucionContinua.Fit(eventos);
                Resultado = new ResultadoAjuste(StringFDP, StringInversa, DistribucionContinua.StandardDeviation, DistribucionContinua.Mean, DistribucionContinua.Variance, this);
            }
            catch (Exception)
            {
                Resultado = null;
            }
        }

        public override List<double> ObtenerValores(int cantidad)
        {
            List<double> result = new List<double>();
            Parallel.ForEach(DistribucionContinua.Generate(cantidad), x => {
                result.Add(DistribucionContinua.ProbabilityDensityFunction(x));
            });
            return result;
        }
    }
}
