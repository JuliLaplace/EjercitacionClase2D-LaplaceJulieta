using System;
using Biblioteca;

namespace C2_Ej_l02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool esUnNumero;
            int numeroIngresado;
            int sumadorDeNumeros = 0;
            string respuesta;


            do
            {
                Console.WriteLine("Ingrese un numero a sumar: ");
                //numeroIngresado = int.Parse(Console.ReadLine());
                esUnNumero = int.TryParse(Console.ReadLine(), out numeroIngresado);
                while (esUnNumero is not true)
                {
                    Console.WriteLine("Error. Ingrese un numero valido a sumar: ");
                    esUnNumero = int.TryParse(Console.ReadLine(), out numeroIngresado);
                }
                sumadorDeNumeros += numeroIngresado;

                Console.WriteLine("Desea continuar? S/N ");
                respuesta = Console.ReadLine();

            } while (Validador.ValidarRespuesta(respuesta));

            Console.WriteLine($"La suma de los numeros que usted ingreso es: {sumadorDeNumeros}");
        }
    }
}
