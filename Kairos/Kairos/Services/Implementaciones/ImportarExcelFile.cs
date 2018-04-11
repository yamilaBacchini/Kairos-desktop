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
        private int hoja = -1;
        private int columna = -1;
        private int filaInicial = -1;

        public ImportarExcelFile(int hoja, int columna, int filaInicial)
        {
            this.hoja = hoja;
            this.columna = columna;
            this.filaInicial = filaInicial;
        }

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
                    var hoja = archivo.Worksheet(this.hoja);
                    int numeroFila = this.filaInicial;
                    int columna = this.columna;
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
