using System;
using System.Collections;
using System.Collections.Generic;

namespace Colecciones
{
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

}