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
    class FuncionLogistica : FuncionDensidadProbabilidad, IFuncionRepresentable
    {
        public string StringFDP => "No implementado aun";

        public string StringInversa => "No implementado aun";

        public FuncionLogistica(double[] eventos) : base(eventos)
        {
            try
            {
                DistribucionContinua = new LogisticDistribution();
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
