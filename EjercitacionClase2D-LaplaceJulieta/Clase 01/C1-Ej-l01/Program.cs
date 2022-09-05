using System;

namespace C1_Ej_l01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool numeroAIngresar;
            int numeroIngresado;
            int valorMaximo = int.MaxValue;
            int valorMinimo = int.MinValue;
            int sumaDeNumeros = 0;
            decimal promedioDeNumeros;
            int i = 0;
            do
            {
                
                Console.WriteLine("Ingrese un numero: ");
                numeroAIngresar = int.TryParse(Console.ReadLine(), out numeroIngresado);
                if (numeroAIngresar)
                {
                    if (i == 0 || numeroIngresado > valorMaximo)
                    {
                        valorMaximo = numeroIngresado;
                    }

                    if (i == 0 || numeroIngresado <= valorMinimo)
                    {
                        valorMinimo = numeroIngresado;
                    }

                    sumaDeNumeros += numeroIngresado;
                    i++;
                }
                else
                {
                    Console.Write("Error. No se ingreso un numero valido. ");
                }

            } while (i < 5);

            promedioDeNumeros = (decimal)sumaDeNumeros / i;

            Console.WriteLine($"El promedio es: {promedioDeNumeros}");
            Console.WriteLine($"El numero maximo es: {valorMaximo}");
            Console.WriteLine($"El numero minimo es: {valorMinimo}");
        }
    }
}
