using Kairos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.Services
{
    interface IImportarService
    {
        bool importarArchivo(string pathArchivo);
    }
}
