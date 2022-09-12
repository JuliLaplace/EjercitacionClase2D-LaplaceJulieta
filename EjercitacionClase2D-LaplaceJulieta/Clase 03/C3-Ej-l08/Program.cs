using System;
using System.Runtime.Intrinsics.Arm;

namespace C3_Ej_l08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaDeNacimiento;
            bool fechaValida;
            //string fechaDeNacimientoString = "00-00-0000";
            //int edadPersona;

            do
            {
            Console.WriteLine("Ingrese su fecha de nacimiento: dd-mm-aaaa");
            fechaValida = DateTime.TryParse(Console.ReadLine(), out fechaDeNacimiento);
            } while (!fechaValida);

            
            Console.WriteLine($"La fecha es: {fechaDeNacimiento.ToString("dd-MM-yyyy")}");// le paso a ToString el formato de los dias, para que no me imprima las horas/min/seg
            if (CalcularCantidadDeDias(fechaDeNacimiento)==0)
            {
                Console.WriteLine("Fecha ingresada es invalida.");
            }
            else
            {
                Console.WriteLine($"Los dias que pasaron entre dichas fechas son: {CalcularCantidadDeDias(fechaDeNacimiento)}");

            }

          

        }

        public static int CalcularCantidadDeDias (DateTime fechaIngresada)
        {
            int dias;
            if(fechaIngresada >= DateTime.Now)
            {
                dias = 0;
            }
            else
            {
                dias = DateTime.Now.Subtract(fechaIngresada).Days; // A la fecha establecida por .Now le resto con el metodo .Substract la fecha de nacimiento de la persona y con la propiedad.Day me centro en los dias
            }
           
            
            return dias;
        }
    }
}
