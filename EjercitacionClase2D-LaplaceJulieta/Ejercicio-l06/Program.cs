using System;

namespace Ejercicio_l06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anioInicio;
            int anioFin;

            Console.WriteLine("Ingrese ujn anio de inicio: ");
            anioInicio= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un anio final: ");
            anioFin= int.Parse(Console.ReadLine());

            for(int i = anioInicio; i<=anioFin; i++)
            {
                if ((i % 4== 0 && i % 100 != 0) || (i % 100 == 0 && i % 400 == 0))
                {
                    Console.WriteLine($"El anio {i} es bisiesto");
                } 
            }
           
        }
    }
}
