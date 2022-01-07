using System;

namespace ClaseAbstracta
{
    /*
     * Esta es una clase abstracta, es la menos funciones tiene en comparacion a
     * las otras, pero me ayuda a no reescribir código, lo cual hace que sea mas
     * legible para otros programadores o cuando lo leo después de mucho tiempo
     */
    abstract class Animales
    {
        public void Respirar() => Console.WriteLine("Estoy respirando");

        public abstract void ObtenerNombre();
    }

    class Mamiferos : Animales
    {
        string NombreMamifero { get; set; }

        public override void ObtenerNombre() => Console.WriteLine($"El nombre del mamifero es {NombreMamifero}");
       
    }

    class Reptiles : Animales
    {
        string NombreReptil { get; set; }

        public override void ObtenerNombre() => Console.WriteLine($"El nombre del reptil es {NombreReptil}");

    }
}