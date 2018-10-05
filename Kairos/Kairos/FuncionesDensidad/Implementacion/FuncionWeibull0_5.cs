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
    class FuncionWeibull0_5 : FuncionDensidadProbabilidad, IFuncionRepresentable
    {
        private readonly string shape = "0.5";
        private readonly string scale = "1";

        public string StringFDP => string.Format("({0}/{1})*(x/{1})^({0}-1)*e^(-(x/{1})^{0})", shape, scale);

        public string StringInversa => string.Format("f(R)= {1}*(-ln(-R+1))^(1/{0})", shape, scale);

        public FuncionWeibull0_5(double[] eventos) : base(eventos)
        {
            try
            {
                DistribucionContinua = new WeibullDistribution(Convert.ToDouble(shape),Convert.ToDouble(scale));
                this.shape = ((WeibullDistribution)DistribucionContinua).Shape.ToString("0.0000");
                this.scale = ((WeibullDistribution)DistribucionContinua).Scale.ToString("0.0000");
                Resultado = new ResultadoAjuste(StringFDP, StringInversa, DistribucionContinua.StandardDeviation, DistribucionContinua.Mean, DistribucionContinua.Variance, this);
            }
            catch (Exception)
            {
                Resultado = null;
            }
        }
    }
}
