using System;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool numeroIngresado;

            Console.WriteLine("Ingrese un numero:");
            numeroIngresado = int.TryParse(Console.ReadLine(), out numero);
            if (numeroIngresado)
            {
                // HACERLO
            }
        }
    }
}
