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
    class FuncionLogLogistica : FuncionDensidadProbabilidad, IFuncionRepresentable
    {
        public string StringFDP => "No implementado aun";

        public string StringInversa => "No implementado aun";

        public FuncionLogLogistica(double[] eventos) : base(eventos)
        {
            try
            {
                double[] eventosOrdenados = eventos.OrderBy(x => x).ToArray();
                double alfa = eventos.Count() % 2 == 0 ? (eventosOrdenados.ElementAt(eventos.Count() / 2) + eventosOrdenados.ElementAt((eventos.Count() / 2) + 1)) / 2 : eventos.OrderBy(x => x).ElementAt((eventos.Count() / 2) + 1);
                double beta = 0;
                DistribucionContinua = new LogLogisticDistribution();
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
