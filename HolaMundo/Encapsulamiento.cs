using System;

namespace Encapsulamiento
{
    class Automovil
    {
        private int velocidad;
        // Encapsulamiento
        public int Velocidad
        {
            get
            {
                return velocidad;
            }
            set
            {
                velocidad = value;
            }
        }

        // Lo mismo de antes, pero abstraido
        public int Precio { get; set; }

        /*
         * De ser necesario puedo tener métodos públicos y privados
         * Los métodos públicos los puedo llamar desde otras clases
         * Los métodos privados solo los puedo usar en la clase en la que estan definidos
         */

        // Constructor
        public Automovil(int vel, int pre)
        {
            this.Velocidad = vel;
            this.Precio = pre;
            Console.WriteLine("Objeto automovil creado...");

        }
    }
}