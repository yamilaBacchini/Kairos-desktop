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
        public string StringFDP => "No implementado aun";

        public string StringInversa => "No implementado aun";

        public FuncionExponencial(double[] eventos) : base(eventos)
        {
            try
            {
                DistribucionContinua = new ExponentialDistribution();
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
