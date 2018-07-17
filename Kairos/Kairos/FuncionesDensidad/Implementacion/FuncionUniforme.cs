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

        public string StringInversa => string.Format("f(R)=R*({0}-{1})+{1}", B, A);

        public FuncionUniforme(double[] eventos) : base(eventos)
        {
            try
            {
                DistribucionContinua = new UniformContinuousDistribution();
                DistribucionContinua.Fit(eventos);
                A = DistribucionContinua.ToString().Split('=')[1].Split(',')[0].Trim();
                B = DistribucionContinua.ToString().Split('=')[2].Split(')')[0].Trim();
                Resultado = new ResultadoAjuste(StringFDP, StringInversa, DistribucionContinua.StandardDeviation, DistribucionContinua.Mean, DistribucionContinua.Variance, this);
            }
            catch (Exception)
            {
                Resultado = null;
            }
        }
    }
}
