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
    class FuncionLogLogistica : FuncionDensidadProbabilidad, IFuncionRepresentable
    {
        public UnivariateDiscreteDistribution DistribucionDiscreta => null;

        public UnivariateContinuousDistribution DistribucionContinua;

        public string StringFDP => "No implementado aun";

        public string StringInversa => "No implementado aun";

        public FuncionLogLogistica(double[] eventos) : base(eventos)
        {
            try
            {
                DistribucionContinua = new LogLogisticDistribution();
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
