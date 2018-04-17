using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kairos.Entidades;

namespace Kairos.Services.Implementaciones
{
    class ImportarTxtFile : IImportarService
    {
        private string delimitador;

        public ImportarTxtFile(string delimitador)
        {
            this.delimitador = delimitador;
        }

        public bool importarArchivo(string pathArchivo)
        {
            try
            {   
                List<string> eventos = new List<string>();

                if (delimitador == "enter")
                    eventos = leerDelimitadorEnter(pathArchivo);
                else
                    eventos = leerDelimitadorCaracter(pathArchivo, this.delimitador);
                
                //creo el proyecto en la tabla origenes
                //checkear que no exista el nombre que se desea ingresar
                using (var db = new EventoContexto())
                {//el origen se debe encargar de esto
                    string nombre = "Importacion automatica_" + DateTime.Now.ToLongDateString();
                    Origen nuevoOrigen = new Origen { fechaCreacion = DateTime.Now, nombreOrigen = nombre, activo = true };
                    db.Origenes.Add(nuevoOrigen);
                    db.SaveChanges();
                    int idOrigenInsertado = nuevoOrigen.Id;

                    foreach (string item in eventos)
                    {
                        db.Eventos.Add(new Entidades.Evento { fecha = Convert.ToDateTime(item), idOrigen = idOrigenInsertado, activo = true });

                    }
                    db.SaveChanges();
                    return true;

                }
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


        public List<string> leerDelimitadorCaracter(string pathArchivo,string caracter)
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
        
    }



}

