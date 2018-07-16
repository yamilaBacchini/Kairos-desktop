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
    class FuncionFasesBiExponencial : FuncionDensidadProbabilidad, IFuncionRepresentable
    {
        public UnivariateDiscreteDistribution DistribucionDiscreta => null;

        public UnivariateContinuousDistribution DistribucionContinua => null;

        public string StringFDP => throw new NotImplementedException();

        public string StringInversa => throw new NotImplementedException();

        public FuncionFasesBiExponencial(double[] eventos) : base(eventos)
        {
            Resultado = null;
        }

        public override List<double> ObtenerValores(int cantidad)
        {
            throw new NotImplementedException();
        }
    }
}
