using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.Services
{
    class ProyectoService
    {
        public static void nuevoProyecto(String nombre)
        {
            using (var db = new EventoContexto())
            {
                db.Origenes.Add(new Entidades.Origen { nombreOrigen = nombre, fechaCreacion = DateTime.Now, activo = true });
                db.SaveChanges();
            }
        }
    }
}
