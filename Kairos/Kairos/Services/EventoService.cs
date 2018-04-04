using Kairos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.Services
{
    class EventoService
    {
        public static void nuevo(DateTime fecha, int idOrigen)
        {
            using (var db = new EventoContexto())
            {
                db.Eventos.Add(new Evento { fecha = fecha, idOrigen = idOrigen, activo = true });
                db.SaveChanges();
            }
        }

        public static void modificar(int idEvento, DateTime fecha)
        {
            using (var db = new EventoContexto())
            {
                Evento evento = db.Eventos.Find(idEvento);
                evento.fecha = fecha;
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
    }
}
