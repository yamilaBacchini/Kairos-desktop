using Kairos.Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Kairos.Services.Implementaciones
{
    internal class ImportarTxtFile : IImportarService
    {
        private string delimitador;

        public ImportarTxtFile(string delimitador)
        {
            this.delimitador = delimitador;
        }

        public bool importarArchivoEnNuevoProyecto(string pathArchivo, string nombreProyecto)
        {
            try
            {
                List<string> eventos = new List<string>();

                if (delimitador == "enter")
                    eventos = leerDelimitadorEnter(pathArchivo);
                else
                    eventos = leerDelimitadorCaracter(pathArchivo, this.delimitador);

                Origen origen = ProyectoService.nuevoProyecto(nombreProyecto);
                EventoService.agregarTodos(eventos, origen.Id);
                
                return true;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                return false;
            }

        }
        //lL
        public List<string> leerDelimitadorEnter(string pathArchivo)
        {
            StreamReader objReader = new StreamReader(pathArchivo);
            string sLine = "";
            List<string> eventosLeidos = new List<string>();
            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    eventosLeidos.Add(sLine);
            }
            objReader.Close();
            return eventosLeidos;
        }


        public List<string> leerDelimitadorCaracter(string pathArchivo, string caracter)
        {
            StreamReader objReader = new StreamReader(pathArchivo);
            string sLine = "";
            List<string> eventosLeidos = new List<string>();
            string[] eventosTemp = null;
            while ((sLine = objReader.ReadLine()) != null)
            {
                eventosTemp = (sLine.Split(Convert.ToChar(caracter)));
            }
            objReader.Close();
            for (int i = 0; i < eventosTemp.Length; i++)
            {
                eventosLeidos.Add(eventosTemp[i]);
            }
            return eventosLeidos;
        }

        public bool importarArchivoEnProyectoExistente(string pathArchivo, int idProyecto)
        {
            bool resultado = false;
            try
            {
                List<string> eventos = new List<string>();
                if (delimitador == "enter")
                    eventos = leerDelimitadorEnter(pathArchivo);
                else
                    eventos = leerDelimitadorCaracter(pathArchivo, this.delimitador);
                //using (var db = new EventoContexto())
                //{
                //    Origen auxOrigen = db.Origenes.Find(idProyecto);
                //    if (auxOrigen != null)
                //    {
                //        foreach (string item in eventos)
                //            db.Eventos.Add(new Entidades.Evento { fecha = Convert.ToDateTime(item), idOrigen = auxOrigen.Id, activo = true });
                //        db.SaveChanges();
                //        resultado = true;
                //    }
                //    else
                //        resultado = false;
                //}
                Origen auxOrigen = ProyectoService.obtenerProyectoPorId(idProyecto);
                if (auxOrigen != null)
                {
                    EventoService.agregarTodos(eventos, auxOrigen.Id);
                    resultado = true;
                }
                else
                    resultado = false;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                resultado = false;
            }
            return resultado;
        }
    }
}

