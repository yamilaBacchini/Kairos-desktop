﻿using ClosedXML.Excel;
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

        public bool importarArchivoEnNuevoProyecto(string pathArchivo, string nombreProyecto)
        {
            bool resultado = false;
            try
            {
                Origen nuevoOrigen = new Origen { fechaCreacion = DateTime.Now, nombreOrigen = nombreProyecto, activo = true };
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

        public bool importarArchivoEnProyectoExistente(string pathArchivo, int idProyecto)
        {
            bool resultado = false;
            try
            {
                using (var db = new EventoContexto())
                {
                    Origen auxOrigen = db.Origenes.Find(idProyecto);
                    if (auxOrigen != null)
                    {
                        List<Evento> eventos = new List<Evento>();
                        using (var archivo = new XLWorkbook(pathArchivo))
                        {
                            var hoja = archivo.Worksheet(this.hoja);
                            int numeroFila = this.filaInicial;
                            int columna = this.columna;
                            while (!hoja.Cell(numeroFila, columna).IsEmpty())
                            {
                                DateTime auxFecha = hoja.Cell(numeroFila, columna).GetDateTime();
                                eventos.Add(new Evento() { fecha = auxFecha, origen = auxOrigen, activo = true });
                                numeroFila++;
                            }
                        }
                        db.Eventos.AddRange(eventos);
                        db.SaveChanges();
                        resultado = true;
                    }
                    else
                        resultado = false;
                }
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
