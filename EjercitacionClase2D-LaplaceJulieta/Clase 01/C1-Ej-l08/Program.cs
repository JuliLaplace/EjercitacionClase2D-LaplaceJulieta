using System;

namespace C1_Ej_l08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool alturaValida;
            int alturaTriangulo;
            string triangulo = "*";


            Console.WriteLine("Ingrese altura  que desee que tenga un triangulo:");
            alturaValida = int.TryParse(Console.ReadLine(), out alturaTriangulo);

            if (alturaValida)
            {
                for (int i = 0; i < alturaTriangulo; i++)
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
            else
            {
                Console.WriteLine("Usted ingreso un dato invalido.");
            }
            
        }
    }
}
