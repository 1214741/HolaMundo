using System;
using System.IO;

namespace Destructores
{
    /*
     * Los destructores se usan para reducir el espacio en memoria
     * Algunas aplicaciones son
     * - Conecciones con BBDD
     * - Cerrar streams cuando manejamos archivos
     * - Eliminar objetos de colecciones
     * Hay que tener cuidado cuando usamos lo destructores, ya que puede eliminar
     * información que se necesita en otra parte del proyecto
     * Es poco recomendable usarlos, pero se pueden implementar cuando el desarrollador
     * está seguro que recurso se desea eliminar inmediatamente y no este asociado
     * a objetos que se usan mas adelante
     */
    class LeerArchivo
    {
        StreamReader Archivo = null;
        string Linea;

        public LeerArchivo()
        {
            Archivo = new StreamReader(@"/Users/juanfernando/Documents/Destructor.txt");

            while((Linea = Archivo.ReadLine()) != null)
            {
                Console.WriteLine(Linea);
            }
        }

        // Método destructor
        ~LeerArchivo() => Archivo.Close();

        /*
         * Lo que hay que tener en cuenta cuando implementamo destructores
         * - Los destructores solo se usan en las clases
         * - Cada clase solo puede tener un destructor
         * - Los destructores no se heredan ni sobrecargan
         * - Los destructores no se llaman, ello se invocan automáticamente
         * - Los destructores no tienen modificadores de acceso ni parámetros
         */

    }
}