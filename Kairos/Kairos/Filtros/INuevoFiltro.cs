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
        List<Evento> FiltrarFechas(int idOrigen, List<Filtro> filtros);
        List<int> FiltrarIntervalos(List<int> intervalos, Enum tipoFiltro, int intervalo);
    }
}
