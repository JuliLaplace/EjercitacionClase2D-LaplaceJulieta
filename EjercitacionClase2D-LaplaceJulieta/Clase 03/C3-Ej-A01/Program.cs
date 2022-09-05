using System;

namespace C3_Ej_A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            bool numeroIngresadoValido;
            int resultadoFactorial;

            Console.WriteLine("Ingrese un numero mayor a 0 para saber su factorial:");
            numeroIngresadoValido = int.TryParse(Console.ReadLine(), out numeroIngresado);
            while (!numeroIngresadoValido || numeroIngresado <= 0)
            {
                Console.WriteLine("Dato Invalido. Ingrese un numero mayor a 0 para saber su factorial:");
                numeroIngresadoValido = int.TryParse(Console.ReadLine(), out numeroIngresado);
            } 

            resultadoFactorial = CalcularFactorial(numeroIngresado);
            Console.WriteLine($"El factorial de {numeroIngresado} es {resultadoFactorial} ");
        }
        public static int CalcularFactorial(int numero)
        {
            int factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial= factorial*i;
            }

            return factorial;
        }
    }
}
