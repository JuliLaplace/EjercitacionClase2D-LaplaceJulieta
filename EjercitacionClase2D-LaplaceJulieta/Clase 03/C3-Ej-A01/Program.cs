using System;

namespace C3_Ej_A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numeroIngresado;
            bool numeroIngresadoValido;
            double resultadoFactorial;

            Console.WriteLine("Ingrese un numero mayor a 0 para saber su factorial:");
            numeroIngresadoValido = double.TryParse(Console.ReadLine(), out numeroIngresado);
            while (!numeroIngresadoValido || numeroIngresado <= 0)
            {
                Console.WriteLine("Dato Invalido. Ingrese un numero mayor a 0 para saber su factorial:");
                numeroIngresadoValido = double.TryParse(Console.ReadLine(), out numeroIngresado);
            } 

            resultadoFactorial = CalcularFactorial(numeroIngresado);
            Console.WriteLine($"El factorial de {numeroIngresado} es {resultadoFactorial} ");
        }
        public static double CalcularFactorial(double numero)
        {
            double factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial= factorial*i;
            }

            return factorial;
        }
    }
}
