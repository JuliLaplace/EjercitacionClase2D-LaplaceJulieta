using System;

namespace C1_EJ_l09
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
                    int pad = 8; //seteo el espacio a ocupar (base) de la punta del triangulo
                    if (i == 0)
                    {
                        Console.WriteLine($"{triangulo.PadLeft(pad)}"); //uso de un metodo nuevo :) PadLeft agrega espacios a la izq hasta llegar a ocupar dicha cantidad de caracteres establecida incluyendo el string que previamente este cargado(PadRight a la derecha)
                    }
                    else
                    {
                        
                        triangulo += "**";
                        
                        Console.WriteLine($"{triangulo.PadLeft(pad+i)}");
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
