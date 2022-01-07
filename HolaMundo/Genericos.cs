using System;

namespace Genericos
{
    interface IJuguete
    {
        void Comprar();
    }

    class Carrito : IJuguete
    {
        private double Precio { get; }

        public Carrito(double precio) => Precio = precio;

        public void Comprar() => Console.WriteLine($"El precio del carrito es: {Precio}");
        
    }

    class Muneco : IJuguete
    {
        private double Precio { get; }

        public Muneco(double precio) => Precio = precio;

        public void Comprar() => Console.WriteLine($"El precio del muñeco es: {Precio}");

    }

    class Cocinita : IJuguete
    {
        private double Precio { get; }

        public Cocinita(double precio) => Precio = precio;

        public void Comprar() => Console.WriteLine($"El precio de la cocinita es: {Precio}");

    }

    class Arma
    {
        private double Precio { get; }

        public Arma(double precio) => Precio = precio;

        public void Comprar() => Console.WriteLine($"El precio del arma es: {Precio}");

    }

    /*
     * Clase abstracta, la cual puede manejar cualquier objeto
     * Este es un caso particular en la que implemento restrincciones, cualquier
     * objeto de clase que no implemente la interfaz creada no puede ser manejado
     * por esta clase
     * Este tipo de programación nos ahorra código, nos evitamos hacer múltiples
     * casting y podemos identificar errores en tiempo de compilación y no en
     * tiempo de ejecución
     */
    class AlmacenarJuguetes<T> where T : IJuguete
    {
        private T[] Juguetes;
        private int Contador = 0;

        public AlmacenarJuguetes(int z) => Juguetes = new T[z];

        public void AgregarJuguete(T obj)
        {
            Juguetes[Contador] = obj;
            Contador++;
        }

        public T GetJuguete(int i) => Juguetes[i];

        } 

}