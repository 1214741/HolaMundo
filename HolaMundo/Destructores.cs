using System;
using System.IO;

namespace Destructores
{
    class LeerArchivo
    {
        StreamReader Archivo = null;
        string linea;

        public LeerArchivo()
        {
            Archivo = new StreamReader(@"/Users/juanfernando/Documents/Destructor.txt");

            while((linea = Archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
            }
        }

        // Método destructor
        ~LeerArchivo()
        {
            Archivo.Close();
        }

    }
}