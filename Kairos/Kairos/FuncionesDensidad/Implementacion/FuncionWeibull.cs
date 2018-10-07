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
        private readonly double shape = 0;
        private readonly double scale = 0;

        public string StringFDP => string.Format("(alfa/beta)*(x/beta)^(alfa-1)*e^(-(x/beta)^alfa)", shape, scale);

        public string StringInversa => string.Format("f(R)= beta*(-ln(-R+1))^(1/alfa)", shape, scale);

        public FuncionWeibull(double[] eventos) : base(eventos)
        {
            try
            {
                eventos = eventos.Where(x => x > 0).OrderBy(x => x).ToArray();
                for (int i = 0; i < eventos.Length - 1; i++)
                {
                    shape += Math.Log(Math.Log(1 / (1 - Estimador(i + 2, eventos.Length)))) - Math.Log(Math.Log(1 / (1 - Estimador(i + 1, eventos.Length))));
                }
                shape /= Math.Log(eventos[eventos.Length - 1]) - Math.Log(eventos[0]);
                for (int i = 0; i < eventos.Length; i++)
                {
                    scale += (Math.Log(1 - Estimador(i + 1, eventos.Length)) / eventos[i]);
                }
                scale *= (-1 / (double)eventos.Length);
                DistribucionContinua = new WeibullDistribution(shape, scale);
                Resultado = new ResultadoAjuste(StringFDP, StringInversa, DistribucionContinua.StandardDeviation, DistribucionContinua.Mean, DistribucionContinua.Variance, this);
            }
            catch (Exception)
            {
                Resultado = null;
            }
        }

        private double Estimador(int i, int n)
        {
            //return i / (n + 1);
            return (i - 0.3) / (n + 0.4);
        }
    }
}
