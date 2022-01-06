using System;

namespace SobreCarga
{
    class Calculadora
    {
        /* 
         * Clase para ver como funciona la sobrecarga de métodos
         * También aplica a los contructores en caso de necesitarlo
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
}