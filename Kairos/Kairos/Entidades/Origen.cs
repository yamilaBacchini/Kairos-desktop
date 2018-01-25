﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.Entidades
{
    class Origen
    {
        public int Id { get; set; }
        public DateTime fechaCreacion { get; set; }

        public string nombreOrigen { get; set; }

        public bool activo { get; set; }

        public List<Evento> eventos { get; set; }
    }
}
