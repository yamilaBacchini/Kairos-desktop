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
        public static List<Int32> CalcularIntervalos(List<Evento> eventos)
        {
            if (eventos != null && eventos.Count > 0)
            {
                var eventosOrdenados = eventos.OrderBy(x => x.fecha);
                return eventosOrdenados.Select(x => x.fecha.TimeOfDay)
                    .Zip(eventosOrdenados.Select(x => x.fecha.TimeOfDay)
                    .Skip(1), (x, y) => y - x)
                    .Select(x => Convert.ToInt32(x.TotalMinutes))
                    .ToList();
            }
            else
                return null;
        }

        public static Dictionary<Int32, Int32> Agrupar(Segmentacion segmentacion, List<Evento> eventos)
        {
            switch (segmentacion)
            {
                case Segmentacion.ANIO:
                    return eventos.Select(x => x.fecha.Year)
                        .GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
                case Segmentacion.MES:
                    return eventos.Select(x => x.fecha.Month)
                        .GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
                case Segmentacion.DIA:
                    return eventos.Select(x => x.fecha.Day)
                        .GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
                case Segmentacion.HORA:
                    return eventos.Select(x => x.fecha.Hour)
                        .GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
                case Segmentacion.MINUTO:
                    return eventos.Select(x => x.fecha.Minute)
                        .GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
                case Segmentacion.SEGUNDO:
                    return eventos.Select(x => x.fecha.Second)
                        .GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
                default:
                    return null;
            }
        }
    }
}
