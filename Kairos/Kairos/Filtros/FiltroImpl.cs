using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kairos.Entidades;
using Kairos.Modelo;

namespace Kairos.Filtros
{
    class FiltroImpl : INuevoFiltro
    {
        private readonly EventoContexto contexto = new EventoContexto();

        public List<Evento> Filtrar(int idOrigen, List<Filtro> filtros)
        {
            List<Evento> resultado = null;
            try
            {
                resultado = new List<Evento>();
                IQueryable<Evento> query = contexto.Eventos.AsQueryable();
                resultado = query.Where(x => x.activo == true).Where(x => x.idOrigen == idOrigen).ToList();
                foreach (var item in filtros)
                {
                    if (item.IsChecked)
                    {
                        switch (item.Tipo)
                        {
                            case TipoFiltro.HORA_MENOR:
                                resultado = resultado.Where(x => x.fecha.TimeOfDay < item.Fecha.TimeOfDay).ToList();
                                break;
                            case TipoFiltro.HORA_MAYOR:
                                resultado = resultado.Where(x => x.fecha.TimeOfDay > item.Fecha.TimeOfDay).ToList();
                                break;
                            case TipoFiltro.FECHA_MENOR:
                                resultado = resultado.Where(x => x.fecha.Date < item.Fecha.Date).ToList();
                                break;
                            case TipoFiltro.FECHA_MAYOR:
                                resultado = resultado.Where(x => x.fecha.Date < item.Fecha.Date).ToList();
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                resultado = null;
                Console.Write(e);
            }
            return resultado;
        }
    }
}
