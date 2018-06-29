using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.Modelo
{
    public class ResultadoAjuste
    {
        public string Funcion { get; }
        public double DesvioEstandar { get;}
        public double Entropia { get; }
        public double Media { get; }
        public double Varianza { get; }
        public ResultadoAjuste(string Funcion, double DesvioEstandar, double Media, double Varianza)
        {
            this.Funcion = Funcion;
            this.DesvioEstandar = DesvioEstandar;
            this.Media = Media;
            this.Varianza = Varianza;
        }
    }
}
