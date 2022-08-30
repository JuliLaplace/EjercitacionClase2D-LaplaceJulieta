using System;
using Biblioteca;

namespace Ejercicio_l02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numeroIngresado;
            int sumadorDeNumeros = 0;
            string respuesta;


            do
            {
                Console.WriteLine("Ingrese un numero: ");
                numeroIngresado = int.Parse(Console.ReadLine());

                sumadorDeNumeros += numeroIngresado;

                Console.WriteLine("Desea continuar? S/N ");
                respuesta = Console.ReadLine();

            } while (Validador.ValidarRespuesta(respuesta));

            Console.WriteLine($"La suma de los numeros que usted ingreso es: {sumadorDeNumeros}");
        }
    }
}
