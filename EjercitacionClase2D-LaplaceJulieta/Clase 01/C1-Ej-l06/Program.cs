using System;

namespace C1_Ej_l06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool anioValidoInicio;
            bool anioValidoFinal;
            int anioInicio;
            int anioFin;

            Console.WriteLine("Ingrese ujn anio de inicio: ");
            anioValidoInicio = int.TryParse(Console.ReadLine(), out anioInicio);
            Console.WriteLine("Ingrese un anio final: ");
            anioValidoFinal = int.TryParse(Console.ReadLine(), out anioFin);

            if (anioValidoInicio && anioValidoFinal)
            {
                for (int i = anioInicio; i <= anioFin; i++)
                {
                    if ((i % 4 == 0 && i % 100 != 0) || (i % 100 == 0 && i % 400 == 0))
                    {
                        Console.WriteLine($"El anio {i} es bisiesto");
                    }
                }
            }
            else
            {
                Console.WriteLine("Usted no ingreso un anio/dato valido.");
            }
            
        }
    }
}
