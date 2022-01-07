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
            //tiposColecciones.Colecciones(); //Métodos públicos
            //TiposColecciones.Pila(); // Métodos estáticos
            //TiposColecciones.Queue();
            //TiposColecciones.HashTable();

            //Arreglo();
            //Matriz();
            Encapsulamiento(35);
            //Sobrecarga();
            //Herencia();
            //HerenciaSustitucion();
            //Polimorfismo();
            //Interfaces();
            //CapturaDeLosErrores.IngresarNumero();
            //CapturaDeLosErrores.Checar();
            //UsarThrow();
            //ClasesAnonimas();

        }

        public static void ClasesAnonimas()
        {
            /*
             * Las clases anónimas se usan en casos muy particulares donde se puede
             * reducir el código a partir de ellas
             * El tipo de las variables lo denomina el compilador dependiendo
             * del tipo de valor que e este guardando en él
             * La cantidad de datos, el tipo de datos y el orden de los datos
             * determina si 2 o mas objetos son de la misma clase
             */
            int edad = 23;
            var miVariable = new { Nombre = "Juan", Edad = edad };
            Console.WriteLine($"Nombre: {miVariable.Nombre}\nEdad: {miVariable.Edad}");
            var otraVariable = new { Nombre = "Isabel", Edad = 20 };
            miVariable = otraVariable;
            Console.WriteLine($"Nombre: {miVariable.Nombre}\nEdad: {miVariable.Edad}");
            /*
             * Desventajas:
             * Sólo puede tener campos públicos
             * Todos los campos deben ser iniciados
             * Los campos no pueden ser de tipo static
             * No puedo definir métodos
             */
        }

        static public void UsarThrow()
        {
            Console.WriteLine("Digite un número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(CapturaDeLosErrores.NombreDia(a));


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
            // TODO: Matriz
            int[,] matriz = new int[2, 3];
            /* 
             * Es un arreglo de 2 dimensiones [filas, columnas]
             * Al igual que un array, es estatico, toca definir el tamaño
            */
            int cont = 0;
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    matriz[i, j] = cont;
                    cont++;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }
        }

        static public void Encapsulamiento(int vel)
        {
            // TODO: Clase Automovil
            Automovil auto = new Automovil(vel, 2000);
            int v = auto.Velocidad; // Ontener el set de un atributo
            Console.WriteLine("La velocidad es: {0}, y si precio es: {1}", v, auto.Precio);
            auto.Velocidad = vel * 2; // Asignar el get a un atributo
            Console.WriteLine("La nueva velocidad es: {0}", auto.Velocidad);
        }

        static public void Sobrecarga()
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Suma();
            calculadora.Suma(9);
            calculadora.Suma("79");
        }

        static public void Herencia()
        {
            Hombre hombre = new Hombre("Juan");
            Mujer mujer = new Mujer("Isabel");

            // Método de la clase humano
            hombre.Respirar();
            mujer.Respirar();

            // Asigno un nombre particular a cada objeto
            hombre.Edad = 24;
            mujer.Edad = 20;

            // Muestro el nombre de cada objeto gracias al encapsulamiento
            hombre.MostrarNombre();
            mujer.MostrarNombre();

            // Método particular de cada clase
            hombre.Afeitarse();
            mujer.PintarUnas();

            // Reescribiendo el código, adaptando el base de la clase padre
            hombre.ColorDelCabello("Negro");
            mujer.ColorDelCabello("Rojo");

            Console.WriteLine($"Edad de {hombre.Nombre}: {hombre.Edad}\nEdad de {mujer.Nombre}: {mujer.Edad}");            
        }

        static public void HerenciaSustitucion()
        {
            // Principio de sustitución: ... es siempre un...
            Persona alguien = new Hombre("Pedro");
            alguien.MostrarNombre();
            // No me aparecen a los métodos particulares de la clase Hombre
            Persona persona = new Persona("Persona");
            persona.MostrarNombre();
            Mujer mujer = new Mujer("Ella");
            persona = mujer;
            persona.MostrarNombre();
        }

        static public void Polimorfismo()
        {
            Hombre hombre = new Hombre("Pepe");
            Mujer mujer = new Mujer("Rosita");

            hombre.HacerPendejadas();
            mujer.HacerPendejadas();
        }

        static public void Interfaces()
        {
            Mujer mujer = new Mujer("Maria");
            mujer.Tallaje(5);
            /*
             * En la clase Hombre no aparece Tallaje, ya que el no hereda de esta interface
             */
        }

    }    
}
