using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kairos.Entidades;

namespace Kairos.Filtros.Fecha
{
    class FiltroFechaEntre : IFiltroFecha
    {
        public List<Evento> aplicarFiltroFecha(List<Evento> eventos, DateTime fecha1, DateTime fecha2)
        {
            List<Evento> resultado = null;
            resultado = (from e in eventos
                         where e.activo == true && e.fecha >= fecha1 && e.fecha <= fecha2
                         orderby e.fecha ascending
                         select e).ToList();
            return resultado;
        }
    }
}
