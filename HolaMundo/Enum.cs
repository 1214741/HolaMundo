namespace Enum
{
    // Se suele declarar en el namespace y no en las clases
    enum Bonus { bajo = 100, medio = 200, alto = 500 };

    class EmpleadoEnum
    {
        private double Salario { get; set; }
        private Bonus Bono { get; set; }

        public EmpleadoEnum(Bonus bonus, double salario)
        {
            Bono = bonus;
            Salario = salario;
        }

        public double NuevoSalario () {
            return Salario + (double)Bono;
        }
    }
}