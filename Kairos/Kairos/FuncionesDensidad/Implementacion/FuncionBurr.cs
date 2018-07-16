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
    class FuncionBurr : FuncionDensidadProbabilidad, IFuncionRepresentable
    {
        public UnivariateDiscreteDistribution DistribucionDiscreta => null;

        public UnivariateContinuousDistribution DistribucionContinua => null;

        public string StringFDP => throw new NotImplementedException();

        public string StringInversa => throw new NotImplementedException();

        public FuncionBurr(double[] eventos) : base(eventos)
        {
            try
            {
                Resultado = null;
                //funcion.Fit(eventos.Select(x => Convert.ToDouble(x)).ToArray());
                //return new ResultadoAjuste(funcion.ToString(), funcion.StandardDeviation, funcion.Median, funcion.Variance);
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
