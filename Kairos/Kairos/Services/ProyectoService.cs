using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kairos.Entidades;

namespace Kairos.Services
{
    class ProyectoService
    {
        public static void nuevoProyecto(string nombre)
        {
            using (var db = new EventoContexto())
            {
                db.Origenes.Add(new Entidades.Origen { nombreOrigen = nombre, fechaCreacion = DateTime.Now, activo = true });
                db.SaveChanges();
            }
        }

        public static void modificarProyecto(int id, string nombre)
        {
            using (var db = new EventoContexto())
            {
                Origen proyecto = db.Origenes.Find(id);
                proyecto.nombreOrigen = nombre;
                db.SaveChanges();
            }
        }

        public static void borrarProyecto(int id)
        {
            using (var db = new EventoContexto())
            {
                Origen proyecto = db.Origenes.Find(id);
                db.Origenes.Remove(proyecto);
                db.SaveChanges();
            }
        }
    }
}
