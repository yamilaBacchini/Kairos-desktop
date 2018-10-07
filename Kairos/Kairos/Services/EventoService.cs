using Kairos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kairos.Services
{
    internal class EventoService
    {
        public static void agregarTodos(List<Evento> aAgregar)
        {
            using (var db = new EventoContexto())
            {
                db.Eventos.AddRange(aAgregar.Select(x =>
                {
                    x.fecha = obtenerFechaSinMilisegundos(x.fecha);
                    return x;
                }));
                db.SaveChanges();
            }
        }

        public static void agregarTodos(List<string> aAgregarEnString, int idOrigen)
        {
            using (var db = new EventoContexto())
            {
                foreach (string item in aAgregarEnString)
                {
                    db.Eventos.Add(new Entidades.Evento { fecha = obtenerFechaSinMilisegundos(Convert.ToDateTime(item)), idOrigen = idOrigen, activo = true });
                }
                db.SaveChanges();
            }
        }

        public static void nuevo(DateTime fecha, int idOrigen)
        {
            using (var db = new EventoContexto())
            {
                db.Eventos.Add(new Evento { fecha = obtenerFechaSinMilisegundos(fecha), idOrigen = idOrigen, activo = true });
                db.SaveChanges();
            }
        }

        public static void modificar(int idEvento, DateTime fecha)
        {
            using (var db = new EventoContexto())
            {
                Evento evento = db.Eventos.Find(idEvento);
                evento.fecha = obtenerFechaSinMilisegundos(fecha);
                db.Update(evento);
                db.SaveChanges();
            }
        }

        public static void borrar(int idEvento)
        {
            using (var db = new EventoContexto())
            {
                Evento evento = db.Eventos.Find(idEvento);
                db.Eventos.Remove(evento);
                db.SaveChanges();
            }
        }

        public static void borrar(List<Evento> aBorrar)
        {
            using (var db = new EventoContexto())
            {
                db.Eventos.RemoveRange(aBorrar);
                db.SaveChanges();
            }
        }

        public static List<Evento> cargarEventos(int idOrigen)
        {
            List<Evento> eventos = null;
            using (var db = new EventoContexto())
            {
                eventos = (from e in db.Eventos
                           where e.activo == true && e.idOrigen == idOrigen
                           orderby e.fecha ascending
                           select e).ToList();
            }
            return eventos;
        }

        private static DateTime obtenerFechaSinMilisegundos(DateTime aRemoverMilisegundos)
        {
            DateTime aux = aRemoverMilisegundos.AddTicks(-(aRemoverMilisegundos.Ticks % 10000000));
            return aux;
        }
    }
}
