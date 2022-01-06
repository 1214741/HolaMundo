using System;

namespace Herencia
{
    class Persona
    {
        protected string nombre;
        public string Nombre { get; set; }

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
        public void Afeitarse()
        {
            Console.WriteLine("Me puedo afeitar");
        }
    }

    class Mujer : Persona
    {
        public void PintarUnas()
        {
            Console.WriteLine("Me pinto las uñas");
        }
    }
}