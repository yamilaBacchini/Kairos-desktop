﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp2
{
    class ClassEscrituraTxt
    {
        Boolean isOpen = false;

        StreamWriter sw = null;

        public ClassEscrituraTxt(string Archivo) {
            try
            {              
                sw = new StreamWriter(Archivo);
                isOpen = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            
        }

        public void escribir(string data)
        {
            if (isOpen) { sw.Write(data); }
              
        }

        public void cerrarArchivo()
        {
            if (isOpen==true)
            {
                sw.Close();
                isOpen = false;
            }
            
        }

        public Boolean estaAbierto()
        {
            return isOpen;
        }
       

    }
}
