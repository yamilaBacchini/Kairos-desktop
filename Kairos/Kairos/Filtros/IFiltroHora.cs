using Kairos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.Filtros
{
    interface IFiltroHora
    {
        List<Evento> aplicarFiltroHora(int idOrigen, TimeSpan hora1, TimeSpan hora2);
    }
}
