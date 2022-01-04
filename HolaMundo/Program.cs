using System;
using System.Collections;
using System.Collections.Generic;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //TiposColecciones tiposColecciones = new TiposColecciones();
            //Arreglo();
            //Matriz();
            //tiposColecciones.Colecciones(); Métodos públicos
            //TiposColecciones.Pila(); // Métodos estáticos
            //TiposColecciones.Queue();
            //TiposColecciones.HashTable();
            //Automovil(35);
            //Calc();
            Herencia();
            
        }

        static public void Arreglo()
        {
            int[] arreglo = new int[5];
            for(int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = int.Parse(Console.ReadLine());
            }
            foreach(int var in arreglo)
            {
                Console.WriteLine(var);
            }
        }

        static public void Matriz()
        {
            // Matriz
            int[,] matriz = new int[2, 3];
            // Es un arreglo de 2 dimensiones [filas, columnas]
            // Al igual que un array, es estatico, toca definir el tamaño
        }

        static public void Automovil(int vel)
        {
            // Clase Automovil
            Automovil auto = new Automovil(vel, 2000);
            int v = auto.Velocidad; // Ontener el set de un atributo
            Console.WriteLine("La velocidad es: {0}, y si precio es: {1}", v, auto.Precio);
            auto.Velocidad = vel * 2; // Asignar el get a un atributo
            Console.WriteLine("La nueva velocidad es: {0}", auto.Velocidad);
        }

        static public void Calc()
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Suma();
            calculadora.Suma(9);
        }

        static public void Herencia()
        {
            Hombre hombre = new Hombre();
            Mujer mujer = new Mujer();

            hombre.MostrarNombre();
            mujer.MostrarNombre();
        }

    }

    class TiposColecciones
    {
        public void Colecciones()
        {
            // Colecciones dinamicas
            ArrayList carros = new ArrayList();
            carros.Add("Ferrari");
            carros.Add("Honda");
            carros.Add(17);

            for (int i = 0; i < carros.Count; i++)
            {
                Console.WriteLine(carros[i]);
            }
        }

        static public void Pila()
        {
            // Pila
            Stack miPila = new Stack();
            for (int i = 0; i < 5; i++)
            {
                miPila.Push(i);
            }
            Console.WriteLine(miPila.Peek());
            int num;
            while (miPila.Count != 0)
            {
                num = (int)miPila.Pop();
                Console.WriteLine(num);
            }

            // Pila restringida
            Stack<String> pilaDeString = new Stack<String>();
        }

        static public void Queue()
        {
            // Queue - Cola
            Queue miCola = new Queue();
            miCola.Enqueue("Raul");
            miCola.Enqueue("Pepe");
            miCola.Enqueue("Juan");
            miCola.Enqueue("Isabel");
            Console.WriteLine(miCola.Peek());
            Console.WriteLine(miCola.Count);
            string atender = (string)miCola.Dequeue();
            Console.WriteLine(atender);
            Console.WriteLine(miCola.Count);

            Queue<int> colaRestringida = new Queue<int>();
        }

        static public void HashTable()
        {
            Hashtable tabla = new Hashtable();

            tabla.Add(1, "uno");
            tabla.Add("uno", 1);

            // Hay que hacer el casting de cada llamada al hashtable para que pueda funcionar correctamente
            int valor = (int)tabla["uno"];
            string letras = (string)tabla[1];
            Console.WriteLine("Valor: {0}\nLetras: {1}", valor, letras);


        }
    }

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
         De ser necesario puedo tener métodos públicos y privados
         Los métodos públicos los puedo llamar desde otras clases
         Los métodos privados solo los puedo usar en la clase en la que estan definidos
         */

        // Constructor
        public Automovil(int vel, int pre)
        {
            this.Velocidad = vel;
            this.Precio = pre;
            Console.WriteLine("Objeto automovil creado...");
        }
    }

    class Calculadora
    {
        /* Clase para ver como funciona la sobrecarga de métodos
            También aplica a los contructores en caso de necesitarlo
         */
        public void Suma()
        {
            Console.WriteLine("Método original");
        }

        public void Suma(int a)
        {
            Console.WriteLine("Método sobrecargado con {0}", a);
        }
    }

    class Persona
    {
        protected string nombre;
    }

    class Hombre:Persona
    {
        public void MostrarNombre()
        {
            nombre = "Juan";
            Console.WriteLine("El nombre de este hombre es: {0}", nombre);
        }
    }

    class Mujer:Persona
    {
        public void MostrarNombre()
        {
            nombre = "Isabel";
            Console.WriteLine("El nombre de esta mujer es: {0}", nombre);
        }
    }
}
