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
        public bool importarArchivo(string pathArchivo)
        {
            try
            {
                StreamReader objReader = new StreamReader(pathArchivo);
                string sLine = "";
                List<string> eventos = new List<string>();

                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                        eventos.Add(sLine);
                }
                objReader.Close();
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

    }



}

