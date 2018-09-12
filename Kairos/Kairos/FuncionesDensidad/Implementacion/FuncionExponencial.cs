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
        private readonly string L = "";

        public string StringFDP => string.Format("{0}*e^(-{0}*x)", L);

        public string StringInversa => string.Format("f(R) = ln(-R+1)/(-{0})", L);

        public FuncionExponencial(double[] eventos) : base(eventos)
        {
            try
            {
                ExponentialDistribution distribucionContinua = new ExponentialDistribution();
                distribucionContinua.Fit(eventos);
                this.L = distribucionContinua.Rate.ToString("0.0000");
                Resultado = new ResultadoAjuste(StringFDP, StringInversa, distribucionContinua.StandardDeviation, distribucionContinua.Mean, distribucionContinua.Variance, this);
            }
            catch (Exception)
            {
                Resultado = null;
            }
        }
    }
}
