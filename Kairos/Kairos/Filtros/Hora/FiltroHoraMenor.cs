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
        public List<Evento> aplicarFiltroHora(int idOrigen, TimeSpan hora1, TimeSpan hora2)
        {
            List<Evento> resultado = null;
            using (var db = new EventoContexto())
            {
                resultado = (from e in db.Eventos
                             where e.activo == true && e.idOrigen == idOrigen && e.fecha.TimeOfDay < hora1
                             orderby e.fecha ascending
                             select e).ToList();
            }
            return resultado;
        }
    }
}
