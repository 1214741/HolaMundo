using System;

namespace Herencia
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string ColorCabello { get; set; }

        // El constructor de esta clase se debe referenciar manualmente en las subclases
        public Persona(string nombrePersona) => Nombre = nombrePersona;

        public void MostrarNombre() => Console.WriteLine("El nombre de esta persona es: {0}", Nombre);

        public void Respirar() => Console.WriteLine("Estoy respirando");

        // Voy a editar el método desde el base. de la clase
        public void ColorDelCabello(string color, string gen) =>
            Console.WriteLine($"El color de cabello de est{gen} es: {color}");

        // Virtual quiere decir que todas las subclases deben de heredar, y modificar
        // a conveniencia, según corresponda
        public virtual void HacerPendejadas() => Console.WriteLine("Estoy haciendo una pendejada");

    }

    interface ITallaCopa
    {
        void Tallaje(int tc);
    }
    /*
     * Si quiero que nadie herede de una clase, la declaro tipo sealed (sellada)
     * Ninguna clase puede heredar sus propiedades o métodos
     * Me falta entender como funciona bien lo de los métodos por que aveces no me funciona
     */
    sealed class Hombre : Persona
    {
        // Contructor reconstruido
        public Hombre(string nombre) : base(nombre) => Console.WriteLine("Soy hombre");

        public void Afeitarse() => Console.WriteLine("Me puedo afeitar");

        public void ColorDelCabello(string color) => base.ColorDelCabello(color, "e hombre");

    }

    // Debo heredar primero de la clase, y luego las interfaces que use
    class Mujer : Persona, ITallaCopa
    {
        // Constructor reconstruido
        public Mujer(string nombre) : base(nombre) => Console.WriteLine("Soy mujer");

        public void PintarUnas() => Console.WriteLine("Me pinto las uñas");

        public void ColorDelCabello(string color) => base.ColorDelCabello(color, "a mujer");

        // Polimorfismo: Oculto el método de la clase Persona y ejecuto este
        public override void HacerPendejadas() => Console.WriteLine("Yo no hago pendejadas");


        /* 
         * Para resolver problemas de ambiguedad, elimino el public
         * y el método se llama INombreInterface.NombreMetodo
         */

        // Debo implementar si o si el método de la interface, para no tener errores

        public void Tallaje(int tc) => Console.WriteLine($"Mi talla de copa es: {tc}");
    }
}