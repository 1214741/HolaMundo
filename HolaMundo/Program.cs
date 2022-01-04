using System;
using CapturaDeErrores;
using Herencia;
using SobreCarga;
using Encapsulamiento;
using Colecciones;

// Juan

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //TiposColecciones tiposColecciones = new TiposColecciones();
            //Arreglo();
            //Matriz();
            //tiposColecciones.Colecciones(); //Métodos públicos
            //TiposColecciones.Pila(); // Métodos estáticos
            //TiposColecciones.Queue();
            //TiposColecciones.HashTable();
            //Automovil(35);
            //Calc();
            //Herencia();
            CapturaDeLosErrores.Ejemplo();
            
            
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
}
