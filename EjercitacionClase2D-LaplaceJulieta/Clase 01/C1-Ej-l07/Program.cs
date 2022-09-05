using System;

namespace C1_Ej_l07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y 
             * la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.
             * Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de 
             * multiplicar el valor hora por la cantidad de horas trabajadas), hay que sumarle la 
             * cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones 
             * restarle el 13% en concepto de descuentos.
             * Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total 
             * a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.*/

            double valorHorasTrabajadas;
            double cantidadHorasTrabajadas;
            string nombreEmpleado;
            double aniosDeAntiguedad;
            double horasTrabajadasMes;
            string continuarCargandoEmpleados;

            double montoPorHorasTrabajadas;//1
            double montoPorAntiguedad;//2
            double salarioBruto;//3
            double salarioEnNeto;


            do
            {
                //nombre
                Console.WriteLine("Ingrese el nombre del empleado a cargar: ");
                nombreEmpleado = Console.ReadLine();
                // como valido que me ponga letras?

                //horas trabajadas
                Console.WriteLine("Ingrese la cantidad de horas trabajada:");
                while (!double.TryParse(Console.ReadLine(), out cantidadHorasTrabajadas))
                {
                    Console.WriteLine("ERROR! Usted ingreso un dato invalido. Ingrese la cantidad de horas trabajadas ");
                }

                //valor por hora trabajada
                Console.WriteLine("Ingrese el valor por hora trabajada:");
                while (!double.TryParse(Console.ReadLine(), out valorHorasTrabajadas))
                {
                    Console.WriteLine("ERROR! Usted ingreso un monto invalido. Ingrese el valor por hora trabajada ");
                }

                //antiguedad laboral del empleado
                Console.WriteLine("Ingrese la antiguedad laboral del empleado:");
                while (!double.TryParse(Console.ReadLine(), out aniosDeAntiguedad))
                {
                    Console.WriteLine("ERROR! Usted ingreso un dato invalido. Ingrese la antiguedad laboral del empleado: ");
                }

                montoPorHorasTrabajadas = valorHorasTrabajadas * cantidadHorasTrabajadas;
                montoPorAntiguedad = aniosDeAntiguedad * 150;
                salarioBruto = montoPorHorasTrabajadas + montoPorAntiguedad;
                salarioEnNeto = salarioBruto - (salarioBruto * 0.13);


                Console.WriteLine($"El empleado {nombreEmpleado} con antiguedad de {aniosDeAntiguedad} anios, y con un valor por hora trabajada de {valorHorasTrabajadas}pesos recibio el monto bruto de {salarioBruto} pesos y el monto neto de {salarioEnNeto} pesos.");

                Console.WriteLine("Desea seguir cargando datos de empleados? si/no");
                continuarCargandoEmpleados = Console.ReadLine();

            } while (continuarCargandoEmpleados != "no");
        }
    }
}
