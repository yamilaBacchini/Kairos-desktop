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

        public string StringFDP => "No implementado aun";

        public string StringInversa => "No implementado aun";

        public FuncionWeibull(double[] eventos) : base(eventos)
        {
            try
            {
                DistribucionContinua = new WeibullDistribution(shape, scale);
                DistribucionContinua.Fit(eventos);
                Resultado = new ResultadoAjuste(StringFDP, StringInversa, DistribucionContinua.StandardDeviation, DistribucionContinua.Mean, DistribucionContinua.Variance, this);
            }
            catch (Exception)
            {
                Resultado = null;
            }
        }
    }
}
