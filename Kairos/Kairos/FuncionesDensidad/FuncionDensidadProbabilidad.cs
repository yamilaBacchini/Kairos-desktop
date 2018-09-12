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
        public UnivariateDiscreteDistribution DistribucionDiscreta { get; protected set; }

        public UnivariateContinuousDistribution MultivariateDistribucionContinua { get; protected set; }

        public ResultadoAjuste Resultado { get; protected set; }

        public FuncionDensidadProbabilidad(double[] eventos)
        {
        }

        public double[] GenerarValores(int cantidad)
        {
            try
            {
                if (MultivariateDistribucionContinua != null)
                    return MultivariateDistribucionContinua.Generate(cantidad);
                else
                    return DistribucionDiscreta.Generate(cantidad).Select(x => Convert.ToDouble(x)).ToArray();
            }
            catch (Exception)
            {
                return new double[0];
            }
        }

        public Dictionary<double, double> ObtenerDensidad(int cantidad)
        {
            Dictionary<double, double> densidades = new Dictionary<double, double>();
            var arr = GenerarValores(cantidad).Distinct().ToArray();
            if (MultivariateDistribucionContinua != null)
                foreach (var item in arr)
                    densidades.Add(item, MultivariateDistribucionContinua.ProbabilityDensityFunction(item));
            else
                foreach (var item in arr)
                    densidades.Add(item, DistribucionDiscreta.ProbabilityMassFunction(Convert.ToInt32(item)));
            return densidades.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
        }

        public Dictionary<double, double> ObtenerDensidadInversa(int cantidad)
        {
            Dictionary<double, double> densidades = new Dictionary<double, double>();
            try
            {
                var rand = new Random();
                double[] arr = new double[cantidad];
                for (int i = 0; i < cantidad; i++)
                    arr[i] = rand.NextDouble();
                arr = arr.Distinct().ToArray();
                if (MultivariateDistribucionContinua != null)
                    foreach (var item in arr)
                        densidades.Add(item, MultivariateDistribucionContinua.QuantileDensityFunction(item));
                else
                    foreach (var item in arr)
                        densidades.Add(item, DistribucionDiscreta.QuantileDensityFunction(item));
                return densidades.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            }
            catch (Exception)
            {
                return densidades;
            }
        }
    }
}
