using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.Modelo
{
    class Filtro
    {
        public bool IsChecked { get; set; }
        public string Name { get; }

        public TipoFiltro Tipo { get; set; }

        public DateTime Fecha { get; set; }

        public Filtro(TipoFiltro tipo, DateTime fecha)
        {
            this.Tipo = tipo;
            this.Fecha = fecha;
            this.IsChecked = true;
            switch (tipo)
            {
                case TipoFiltro.HORA_MENOR:
                    this.Name = "Hora < a " + fecha.ToShortTimeString();
                    break;
                case TipoFiltro.HORA_MAYOR:
                    this.Name = "Hora > a " + fecha.ToShortTimeString();
                    break;
                case TipoFiltro.FECHA_MENOR:
                    this.Name = "Fecha < a " + fecha.ToShortDateString();
                    break;
                case TipoFiltro.FECHA_MAYOR:
                    this.Name = "Fecha > a " + fecha.ToShortDateString();
                    break;
                default:
                    break;
            }
        }
    }
}
