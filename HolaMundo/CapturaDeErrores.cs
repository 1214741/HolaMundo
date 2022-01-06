using System;


namespace CapturaDeErrores
{
    class CapturaDeLosErrores
    {
        static public void IngresarNumero()
        {
            Console.WriteLine("Ingrese un numero");
            int num;
            try
            {
                num = int.Parse(Console.ReadLine());

            }
            // when se usa para filtrar errores de excepciones generales
            catch (Exception e) when (e.GetType() != typeof(FormatException))
            {
                Console.WriteLine("{0}: {1}", e.GetType(), e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Ingresaste una letra. {0}", e.Message);
            }
            finally
            {
                /*
                 * Este código se ejecuta siempre, no importa si se ejecutó el
                 * try o alguno de los catch, o haya saltado un bloque de código
                 */
                num = 0;
            }
            Console.WriteLine("El número digitado es {0}", num);
        }

        static public void Checar()
        {
            /*
             * Se asegura de informar de un error cuando ocurra, y no muestre valores erroneos
             * cuando se esta ejecutando el código
             * Esto se puede cambiar en las configuraciones de compilación del proyecto
             * Solo funciona con int y Long
             * También esta el método unchecked que hace todo lo contrario
            */
            Console.WriteLine("Escriba 1 para usar cheked o 2 para ver el desbordamiento");
            int ent = int.Parse(Console.ReadLine());
            int numero;
            int res;
            switch (ent)
            {
                case 1:
                    checked
                    {
                        numero = int.MaxValue;
                        res = numero + 20;
                        Console.WriteLine(res);
                    }
                    break;
                case 2:
                    numero = int.MaxValue;
                    res = numero + 20;
                    Console.WriteLine(res);
                    break;
                default:
                    Console.WriteLine("Seleccion no válida");
                    break;

            }
            

        }
        static public string NombreDia(int a)
        {   
            switch (a)
            {
                case 1:
                    return "Lunes";
                case 2:
                    return "Martes";
                case 3:
                    return "Miercoles";
                case 4:
                    return "Jueves";
                case 5:
                    return "Viernes";
                case 6:
                    return "Sábado";
                case 7:
                    return "Domingo";
                default:
                    /*
                     * Hacemos que nuestro código lance expeciones cuando el usuario 
                     * hace algo que no debería
                     * Las excepciones se pueden capturar con un try...catch...
                     */
                    throw new ArgumentOutOfRangeException();

            }
            
        }
    }
}
