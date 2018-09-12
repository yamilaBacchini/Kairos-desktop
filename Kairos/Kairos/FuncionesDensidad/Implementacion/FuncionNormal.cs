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
    class FuncionNormal : FuncionDensidadProbabilidad, IFuncionRepresentable
    {
        public string StringFDP => "No implementado aun";

        public string StringInversa => "No implementado aun";

        public FuncionNormal(double[] eventos) : base(eventos)
        {
            try
            {
                MultivariateDistribucionContinua = new NormalDistribution();
                MultivariateDistribucionContinua.Fit(eventos);
                Resultado = new ResultadoAjuste(StringFDP, StringInversa, MultivariateDistribucionContinua.StandardDeviation, MultivariateDistribucionContinua.Mean, MultivariateDistribucionContinua.Variance, this);
            }
            catch (Exception)
            {
                Resultado = null;
            }
        }
    }
}
