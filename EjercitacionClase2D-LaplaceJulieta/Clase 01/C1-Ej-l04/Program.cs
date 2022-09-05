using System;

namespace C1_Ej_l04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDeInicio = 2;
            int cantidadNumerosPerfectos = 0;
            int sumaDeNumeros = 0;

            do
            {
                for (int i = 1; i < numeroDeInicio; i++)
                {
                    if (numeroDeInicio % i == 0)
                    {
                        sumaDeNumeros += i;
                    }
                }

                if (sumaDeNumeros == numeroDeInicio)
                {
                    Console.WriteLine($"El numero {numeroDeInicio} es un numero perfecto");
                    cantidadNumerosPerfectos++;
                }
                numeroDeInicio++;
                sumaDeNumeros = 0;

            } while (cantidadNumerosPerfectos < 4);

        }
    }
}
