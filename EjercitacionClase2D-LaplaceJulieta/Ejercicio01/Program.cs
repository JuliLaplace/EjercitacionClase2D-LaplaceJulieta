using System;

namespace EjercitacionClase2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int valorMaximo=0;
            int valorMinimo = 0;
            int total=0;
            decimal promedio;
            int i=0;
            do
            {
                numeroIngresado = int.Parse(Console.ReadLine());
                

                if (numeroIngresado > valorMaximo)
                {
                    valorMaximo = numeroIngresado;
                }

                if (numeroIngresado <= valorMinimo)
                {
                    valorMinimo = numeroIngresado;
                }
                total += numeroIngresado;
                i++;
            }while (i<5);

            promedio =(decimal) total / i;

            Console.WriteLine($"El promedio es: {promedio}");
            Console.WriteLine($"El numero maximo es: {valorMaximo}");
            Console.WriteLine($"El numero minimo es: {valorMinimo}");
        }
    }
}
