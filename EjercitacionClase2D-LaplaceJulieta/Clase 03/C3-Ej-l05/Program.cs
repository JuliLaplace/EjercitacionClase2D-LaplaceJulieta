using System;
using Biblioteca;

namespace C3_Ej_l05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            bool esNumero;

            Console.WriteLine("Ingrese un numero que desee saber su tabla de multiplicacion: ");
            esNumero = int.TryParse(Console.ReadLine(), out numeroIngresado);
            while (!esNumero)
            {
                Console.WriteLine("Dato invalido. Ingrese un numero que desee saber su tabla de multiplicacion: ");
                esNumero = int.TryParse(Console.ReadLine(), out numeroIngresado);
            }
            StringBuilder.CrearTablaDeMultiplicacion(numeroIngresado);
        }
    }
}
