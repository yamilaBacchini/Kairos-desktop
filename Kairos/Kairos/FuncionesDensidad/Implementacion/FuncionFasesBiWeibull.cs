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
    class FuncionFasesBiWeibull : FuncionDensidadProbabilidad, IFuncionRepresentable
    {
        public string StringFDP => throw new NotImplementedException();

        public string StringInversa => throw new NotImplementedException();

        public FuncionFasesBiWeibull(double[] eventos) : base(eventos)
        {
            Resultado = null;
        }
    }
}
