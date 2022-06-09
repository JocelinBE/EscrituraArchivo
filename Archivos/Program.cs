using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;   //  Se hace uso de la librería System.IO

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //CREAR ARCHIVO DE TEXTO EN BIN/DEBUG

                //Leer archivo
                StreamReader sr = new StreamReader("Jocelin.txt");
                string línea;

                //Recorrer el archivo
                while ((línea = sr.ReadLine()) != null) // Revisar si el archivo tiene texto
                {

                    Console.WriteLine(línea); //Se escribe la línea en consola
                }
                //Cerrar el archivo
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No se ha encontrado el archivo.");
            }
            Console.ReadLine();
          
            
        }
        
            
           
    }
}
