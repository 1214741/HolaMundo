namespace Estructuras
{
    /*
     * Tipo de "clase" en la que sus objetos se guardan siempre en el Stack, como
     * si fuese un valor primitivo, y no en el Heap como si fuera un objeto de la clase
     * Las instancias creadas lo que hacen es crear copias del struct creado
     * cuando defino mi clase
     * Algunas diferencias con las clases son
     * - No declara un constructor por defecto
     * - El compilador no inicia los campos, esto lo hago en un contructor que defino
     * - No se pueden sobrecargar lo contructores
     * - No heredan de clases, pero si de interfaces
     * -Son selladas
     * Algunos casos de usos son
     * - Uso elevado de datos en memoria
     * - Las instancias son inmutables
     * - Las instancias tengan un tamaño menor a 16 bytes
     * - No neceite convertir a objeto
     * - Mayor rendimiento
     */
    //public class Empleado
    public struct Empleado
    {
        public double Salario, Bonificacion;

        public Empleado(double salario, double bonificacion)
        {
            this.Salario = salario;
            this.Bonificacion = bonificacion;
        }

        // Sepuede reescribir el metodo ToString de esta forma
        public override string ToString() =>
            string.Format($"El salario del empleado es {this.Salario} y su bonificacion es {this.Bonificacion}");

        public void AumentarSalario(Empleado empleado, double incremento)
        {
            /*
             * El cambio no se va a ver reflejado, ya que esto los estoy haciendo
             * en la copia creada, y no en la instancia original
             * Tengo que entender mejor en que casos usar las struct
             */
            empleado.Salario += incremento;
            empleado.Bonificacion += incremento * 0.5;
        }
    } 
}