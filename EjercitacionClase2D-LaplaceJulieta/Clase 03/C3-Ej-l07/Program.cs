using System;
using System.Diagnostics;

namespace C3_Ej_l07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseTriangulo;
            double alturaTriangulo;
            double resultadoDeHipotenusa;

            Console.WriteLine("Ingrese la base (en cm) del triangulo: ");
            while(!double.TryParse(Console.ReadLine(), out baseTriangulo))
            {
                Console.WriteLine("Dato invalido. Ingrese la base (en cm) del triangulo: ");
            }
            Console.WriteLine("Ingrese la altura (en cm) del triangulo: ");
            while (!double.TryParse(Console.ReadLine(), out alturaTriangulo))
            {
                Console.WriteLine("Dato invalido. Ingrese la altura (en cm) del triangulo: ");
            }

            resultadoDeHipotenusa = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
            Console.WriteLine($"La hipotenusa del triangulo rectangulo con base {baseTriangulo}cm y altura {alturaTriangulo}cm es de {resultadoDeHipotenusa}cm");
        }
    }
}
