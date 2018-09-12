using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Math;
using Accord.Statistics.Distributions.Univariate;
using Kairos.Entidades;
using Kairos.Modelo;

namespace Kairos.FuncionesDensidad.Implementacion
{
    class FuncionUniforme : FuncionDensidadProbabilidad, IFuncionRepresentable
    {
        private readonly string A = "";
        private readonly string B = "";

        public string StringFDP => string.Format("f(x)=1/({0}-{1})", B, A);

        public string StringInversa => string.Format("f(R) = R*({0}-{1})+{1}", B, A);

        public FuncionUniforme(double[] eventos) : base(eventos)
        {
            try
            {
                UniformContinuousDistribution distribucionContinua = new UniformContinuousDistribution();
                distribucionContinua.Fit(eventos);
                A = distribucionContinua.Minimum.ToString();
                B = distribucionContinua.Maximum.ToString();
                Resultado = new ResultadoAjuste(StringFDP, StringInversa, distribucionContinua.StandardDeviation, distribucionContinua.Mean, distribucionContinua.Variance, this);
            }
            catch (Exception)
            {
                Resultado = null;
            }
        }
    }
}
