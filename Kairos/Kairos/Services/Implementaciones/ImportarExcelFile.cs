using ClosedXML.Excel;
using Kairos.Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.Services.Implementaciones
{
    class ImportarExcelFile : IImportarService
    {
        public bool importarArchivo(string pathArchivo)
        {
            bool resultado = false;
            try
            {
                string nombre = "Importacion automatica_" + DateTime.Now.ToLongDateString();
                Origen nuevoOrigen = new Origen { fechaCreacion = DateTime.Now, nombreOrigen = nombre, activo = true };
                List<Evento> eventos = new List<Evento>();
                using (var archivo = new XLWorkbook(pathArchivo))
                {
                    var hoja = archivo.Worksheet(1);
                    int numeroFila = 1;
                    int columna = 1;
                    while (!hoja.Cell(numeroFila, columna).IsEmpty())
                    {
                        DateTime auxFecha = hoja.Cell(numeroFila, columna).GetDateTime();
                        eventos.Add(new Evento() { fecha = auxFecha, origen = nuevoOrigen, activo = true });
                        numeroFila++;
                    }
                }
                using (var db = new EventoContexto())
                {
                    //el origen se debe encargar de esto
                    db.Origenes.Add(nuevoOrigen);
                    db.SaveChanges();
                    int idOrigenInsertado = nuevoOrigen.Id;
                    db.Eventos.AddRange(eventos);
                    db.SaveChanges();
                }
                resultado = true;
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                resultado = false;
            }
            return resultado;
        }
    }
}
