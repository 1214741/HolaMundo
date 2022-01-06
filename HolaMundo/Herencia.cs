using System;

namespace Herencia
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        // El constructor de esta clase se debe referenciar manualmente en las subclases
        public Persona(string nombrePersona)
        {
            Nombre = nombrePersona;
        }

        public void MostrarNombre()
        {
            Console.WriteLine("El nombre de esta persona es: {0}", Nombre);
        }

        public void Respirar()
        {
            Console.WriteLine("Estoy respirando");
        }

        // Virtual quiere decir que todas las subclases deben de heredar, y modificar
        // a conveniencia, según corresponda
        public virtual void HacerPendejadas() => Console.WriteLine("Estoy haciendo una pendejada");

    }

    class Hombre : Persona
    {
        // Contructor reconstruido
        public Hombre(string nombre) : base(nombre) => Console.WriteLine("Soy hombre");

        public void Afeitarse()
        {
            Console.WriteLine("Me puedo afeitar");
        }
    }

    class Mujer : Persona
    {
        // Constructor recontruido
        public Mujer(string nombre) : base(nombre) => Console.WriteLine("Soy mujer");

        public void PintarUnas()
        {
            Console.WriteLine("Me pinto las uñas");
        }

        // Polimorfismo: Oculto el método de la clase Persona y ejecuto este
        public override void HacerPendejadas() => Console.WriteLine("Yo no hago pendejadas");
    }
}