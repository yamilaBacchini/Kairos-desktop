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
    class FuncionWeibull : FuncionDensidadProbabilidad, IFuncionRepresentable
    {
        private readonly double shape = 0.5;
        private readonly double scale = 0.5;

        public UnivariateDiscreteDistribution DistribucionDiscreta => null;

        public UnivariateContinuousDistribution DistribucionContinua;

        public string StringFDP => throw new NotImplementedException();

        public string StringInversa => "No implementado aun";

        public FuncionWeibull(double[] eventos) : base(eventos)
        {
            try
            {
                DistribucionContinua = new WeibullDistribution(shape, scale);
                DistribucionContinua.Fit(eventos);
                Resultado = new ResultadoAjuste(DistribucionContinua.ToString(), StringInversa, DistribucionContinua.StandardDeviation, DistribucionContinua.Mean, DistribucionContinua.Variance, this);
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
