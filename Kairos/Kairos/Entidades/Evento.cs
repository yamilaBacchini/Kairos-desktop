using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.Entidades
{
    class Evento
    {
        public int Id { get; set; }
        public DateTime fecha { get; set; }
        public bool activo { get; set; }

        public int idOrigen { get; set; }
        public Origen origen { get; set; }
    }
}
