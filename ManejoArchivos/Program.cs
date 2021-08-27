using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Permitira trabajar con las clases para manipular archivos

namespace ManejoArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //definir la ruta del archivo
            string path = @"D:\ejemplo\Datos.txt";

            //evaluar si el archivo existe
            if(File.Exists(path))
            {
                Console.WriteLine("El archivo existe!");

                //leer el contenido del archivo de linea por linea
                string[] lines;
                lines = File.ReadAllLines(path);
                Console.WriteLine("CONTENIDO UTILIZANDO ReadAllLines");
                for(int i = 0; i< lines.Length; i++)
                {
                    Console.WriteLine(lines[i]);
                }

                //leer el contenido del archivo
                Console.WriteLine("CONTENIDO UTILIZANDO ReadAllText");
                string content;
                content = File.ReadAllText(path);
                Console.WriteLine(content);
            }
            else
            {
                //crear un archivo y agregar texto
                using (StreamWriter sr = File.AppendText(path))
                {
                    //contenido del archivo
                    sr.WriteLine("Programacion computacional I");
                    sr.WriteLine("Clase teorica Stream I/O");
                    sr.Close();
                }
            }


           

            Console.ReadKey();

        }
    }
}
