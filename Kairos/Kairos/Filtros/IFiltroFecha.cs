using Kairos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.Filtros
{
    interface IFiltroFecha
    {
        List<Evento> aplicarFiltroFecha(List<Evento> eventos, DateTime fecha1, DateTime fecha2);
    }
}
