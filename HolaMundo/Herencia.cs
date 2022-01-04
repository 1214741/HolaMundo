using System;

namespace Herencia
{
    class Persona
    {
        protected string nombre;
    }

    class Hombre : Persona
    {
        public void MostrarNombre()
        {
            nombre = "Juan";
            Console.WriteLine("El nombre de este hombre es: {0}", nombre);
        }
    }

    class Mujer : Persona
    {
        public void MostrarNombre()
        {
            nombre = "Isabel";
            Console.WriteLine("El nombre de esta mujer es: {0}", nombre);
        }
    }
}