using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kairos.Entidades;

namespace Kairos.Filtros.Fecha
{
    class FiltroFechaMayor : IFiltroFecha
    {
        public List<Evento> aplicarFiltroFecha(int idOrigen, DateTime fecha1, DateTime fecha2)
        {
            List<Evento> resultado = null;
            using (var db = new EventoContexto())
            {
                resultado = (from e in db.Eventos
                                    where e.activo == true && e.idOrigen == idOrigen && e.fecha > fecha1
                                    orderby e.fecha ascending
                                    select e).ToList();
            }
            return resultado;
        }
    }
}
