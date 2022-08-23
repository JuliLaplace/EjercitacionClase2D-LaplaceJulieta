using System;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool numeroIngresado;
            int numero;
            double numeroCubo;
            double numeroCuadrado;
            

            Console.WriteLine("Ingrese un numero: ");
            numeroIngresado= int.TryParse(Console.ReadLine(), out numero);
            if (numeroIngresado)
            {
                numeroCuadrado = Math.Pow(numero, 2);
                numeroCubo = Math.Pow(numero, 3);

                Console.WriteLine($"El cuadrado de {numero} es {numeroCuadrado}, y el cubo es {numeroCubo}");


            }
            else
            {
                Console.WriteLine("Usted no ingreso un numero");
            }

        }
    }
}
