using System;
using BibliotecaDeClases;

namespace C3_Ej_l03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDecimal = 11;
            //int numeroBinario= 1011;

            Console.WriteLine($"El numero binario correspondiente a {numeroDecimal} es {Conversor.ConvertirDecimalABinario(numeroDecimal)} ");
            //Console.WriteLine($"El numero decimal correspondiente a {numeroBinario} es {Conversor.ConvertirBinarioADecimal(numeroBinario)} ");
        }
    }
}
