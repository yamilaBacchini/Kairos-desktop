using Kairos.Entidades;
using Kairos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.Filtros
{
    interface INuevoFiltro
    {
        List<Evento> Filtrar(int idOrigen, List<Filtro> filtros);
    }
}
