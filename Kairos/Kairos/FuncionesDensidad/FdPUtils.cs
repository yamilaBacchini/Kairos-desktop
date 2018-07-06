using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Statistics.Distributions.Univariate;
using Kairos.Entidades;
using Kairos.Modelo;

namespace Kairos.FuncionesDensidad
{
    public static class FdPUtils
    {
        public static Dictionary<string, double> CalcularIntervalos(List<Evento> eventos)
        {
            if (eventos != null && eventos.Count > 0)
            {
                double cantEventos = (double)eventos.Count;
                var eventosOrdenados = eventos.OrderBy(x => x.fecha);
                return eventosOrdenados.Select(x => x.fecha.TimeOfDay)
                    .Zip(eventosOrdenados.Select(x => x.fecha.TimeOfDay)
                    .Skip(1), (x, y) => y - x)
                    .Select(x => Math.Abs(x.TotalMinutes))
                    .GroupBy(x => x)
                    .ToDictionary(x => x.Key.ToString(), x => x.Count() / (cantEventos > 1 ? cantEventos - 1 : cantEventos));
            }
            else
                return null;
        }

        public static Dictionary<string, double> Agrupar(Segmentacion segmentacion, List<Evento> eventos)
        {
            if (eventos != null && eventos.Count > 0)
            {
                double cantEventos = (double)eventos.Count;
                switch (segmentacion)
                {
                    case Segmentacion.ANIO:
                        return eventos.Select(x => x.fecha.Year)
                            .GroupBy(x => x).ToDictionary(x => x.Key.ToString(), x => x.Count() / cantEventos);
                    case Segmentacion.MES:
                        return eventos.Select(x => new { Mes = x.fecha.Month, Anio = x.fecha.Year })
                            .GroupBy(x => new { x.Mes, x.Anio }).ToDictionary(x => x.Key.Anio + "" + x.Key.Mes, x => x.Count() / cantEventos);
                    case Segmentacion.DIA:
                        return eventos.Select(x => new { Mes = x.fecha.Month, Anio = x.fecha.Year, Dia = x.fecha.Day })
                            .GroupBy(x => new { x.Mes, x.Anio, x.Dia }).ToDictionary(x => x.Key.Anio + "" + x.Key.Mes + "" + x.Key.Dia, x => x.Count() / cantEventos);
                    case Segmentacion.HORA:
                        return eventos.Select(x => new { Mes = x.fecha.Month, Anio = x.fecha.Year, Dia = x.fecha.Day, Hora = x.fecha.Hour })
                            .GroupBy(x => new { x.Anio, x.Mes, x.Dia, x.Hora }).ToDictionary(x => x.Key.Anio + "" + x.Key.Mes + "" + x.Key.Dia + "" + x.Key.Hora, x => x.Count() / cantEventos);
                    case Segmentacion.MINUTO:
                        return eventos.Select(x => new { Mes = x.fecha.Month, Anio = x.fecha.Year, Dia = x.fecha.Day, Hora = x.fecha.Hour, Minuto = x.fecha.Minute })
                            .GroupBy(x => new { x.Anio, x.Mes, x.Dia, x.Hora, x.Minuto }).ToDictionary(x => x.Key.Anio + "" + x.Key.Mes + "" + x.Key.Dia + "" + x.Key.Hora + "" + x.Key.Minuto, x => x.Count() / cantEventos);
                    case Segmentacion.SEGUNDO:
                        return eventos.Select(x => new { Mes = x.fecha.Month, Anio = x.fecha.Year, Dia = x.fecha.Day, Hora = x.fecha.Hour, Minuto = x.fecha.Minute, Segundo = x.fecha.Second })
                            .GroupBy(x => new { x.Anio, x.Mes, x.Dia, x.Hora, x.Minuto, x.Segundo }).ToDictionary(x => x.Key.Anio + "" + x.Key.Mes + "" + x.Key.Dia + "" + x.Key.Hora + "" + x.Key.Minuto + "" + x.Key.Segundo, x => x.Count() / cantEventos);
                    default:
                        return null;
                }
            }
            else
                return null;
        }
    }
}
