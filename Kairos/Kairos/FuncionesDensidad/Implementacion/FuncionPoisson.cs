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
    class FuncionPoisson : FuncionDensidadProbabilidad, IFuncionRepresentable
    {
        public string StringFDP => "No implementado aun";

        public string StringInversa => "No implementado aun";

        public FuncionPoisson(double[] eventos) : base(eventos)
        {
            try
            {
                DistribucionDiscreta = new PoissonDistribution();
                DistribucionDiscreta.Fit(eventos);
                Resultado = new ResultadoAjuste(StringFDP, StringInversa, DistribucionDiscreta.StandardDeviation, DistribucionDiscreta.Mean, DistribucionDiscreta.Variance, this);
            }
            catch (Exception)
            {
                Resultado = null;
            }
        }
    }
}
