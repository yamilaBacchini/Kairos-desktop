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

        public UnivariateContinuousDistribution DistribucionContinua { get; protected set; }

        public ResultadoAjuste Resultado { get; protected set; }

        public double Desvio { get; protected set; }

        public FuncionDensidadProbabilidad(double[] eventos)
        {
        }

        public double[] GenerarValores(int cantidad)
        {
            try
            {
                if (DistribucionContinua != null)
                    return DistribucionContinua.Generate(cantidad);
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
            if (DistribucionContinua != null)
                foreach (var item in arr)
                    densidades.Add(item, DistribucionContinua.ProbabilityDensityFunction(item));
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
                if (DistribucionContinua != null)
                    foreach (var item in arr)
                        densidades.Add(item, DistribucionContinua.QuantileDensityFunction(item));
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

        public double CalcularDesvio(Dictionary<string, double> eventos)
        {
            try
            {
                if (DistribucionContinua != null)
                    Desvio = eventos.Sum(x => Math.Pow(DistribucionContinua.ProbabilityDensityFunction(Convert.ToDouble(x.Key)) - x.Value, 2));
                else
                    Desvio = eventos.Sum(x => Math.Pow(DistribucionDiscreta.ProbabilityMassFunction(Convert.ToInt32(x.Key)) - x.Value, 2));
                return Desvio;
            }
            catch (Exception)
            {
                return double.NaN;
            }
        }

    }
}
