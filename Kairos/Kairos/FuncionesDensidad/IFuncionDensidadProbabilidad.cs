using Kairos.Entidades;
using Kairos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.FuncionesDensidad
{
    public interface IFuncionDensidadProbabilidad
    {
        ResultadoAjuste Ajustar(List<Int32> eventos);
    }
}
