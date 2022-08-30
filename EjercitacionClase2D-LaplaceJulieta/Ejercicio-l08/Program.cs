using System;

namespace Ejercicio_l08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alturaTriangulo;
            string triangulo="*";


            Console.WriteLine("Ingrese altura  que desee que tenga un triangulo:");

            alturaTriangulo= int.Parse(Console.ReadLine());

            for(int i=0; i< alturaTriangulo; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"{triangulo}");
                }
                else
                {
                    triangulo += "**";
                    Console.WriteLine($"{triangulo}");
                }
                
            }
        }
    }
}
