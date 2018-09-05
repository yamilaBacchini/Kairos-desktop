﻿using System;
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

        public List<Evento> FiltrarFechas(int idOrigen, List<Filtro> filtros)
        {
            List<Evento> resultado = null;
            try
            {
                resultado = new List<Evento>();
                List<Evento> parcial = new List<Evento>();
                IQueryable<Evento> query = contexto.Eventos.AsQueryable();
                parcial = query.Where(x => x.activo == true).Where(x => x.idOrigen == idOrigen).ToList();
                if (filtros.Count == 0 || filtros.All(x => !x.IsChecked))
                    resultado = parcial;
                else
                    foreach (var item in filtros)
                    {
                        if (item.IsChecked)
                        {
                            switch (item.Tipo)
                            {
                                case TipoFiltro.HORA_MENOR:
                                    resultado.AddRange(parcial.Where(x => x.fecha.TimeOfDay < item.Fecha1.TimeOfDay).ToList());
                                    break;
                                case TipoFiltro.HORA_MAYOR:
                                    resultado.AddRange(parcial.Where(x => x.fecha.TimeOfDay > item.Fecha1.TimeOfDay).ToList());
                                    break;
                                case TipoFiltro.HORA_ENTRE:
                                    resultado.AddRange(parcial.Where(x => x.fecha.TimeOfDay > item.Fecha1.TimeOfDay && x.fecha.TimeOfDay < item.Fecha2.TimeOfDay).ToList());
                                    break;
                                case TipoFiltro.FECHA_MENOR:
                                    resultado.AddRange(parcial.Where(x => x.fecha.Date < item.Fecha1.Date).ToList());
                                    break;
                                case TipoFiltro.FECHA_MAYOR:
                                    resultado.AddRange(parcial.Where(x => x.fecha.Date > item.Fecha1.Date).ToList());
                                    break;
                                case TipoFiltro.FECHA_ENTRE:
                                    resultado.AddRange(parcial.Where(x => x.fecha.Date > item.Fecha1.Date && x.fecha.Date < item.Fecha2.Date).ToList());
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                resultado = resultado.Distinct().ToList();
                resultado = resultado.OrderBy(x => x.fecha).ToList();
            }
            catch (Exception e)
            {
                resultado = null;
                Console.Write(e);
            }
            return resultado;
        }

        public List<int> FiltrarIntervalos(List<int> intervalos, Enum tipoFiltro, int intervalo)
        {
            throw new NotImplementedException();
        }

    }
}
