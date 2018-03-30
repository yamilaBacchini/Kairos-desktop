using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kairos.Entidades;

namespace Kairos.Filtros.Hora
{
    class FiltroHoraMenor : IFiltroHora
    {
        public List<Evento> aplicarFiltroHora(List<Evento> eventos, TimeSpan hora1, TimeSpan hora2)
        {
            List<Evento> resultado = null;
            resultado = (from e in eventos
                         where e.activo == true && e.fecha.TimeOfDay < hora1
                         orderby e.fecha ascending
                         select e).ToList();
            return resultado;
        }
    }
}
