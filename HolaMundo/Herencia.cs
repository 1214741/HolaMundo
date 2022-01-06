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
    }
}