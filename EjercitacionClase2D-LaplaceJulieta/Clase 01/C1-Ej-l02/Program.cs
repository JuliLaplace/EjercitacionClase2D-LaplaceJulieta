using System;

namespace C1_Ej_l02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool numeroIngresado;
            int numero;


            Console.WriteLine("Ingrese un numero mayor a 0: ");
            numeroIngresado = int.TryParse(Console.ReadLine(), out numero);
            if (numeroIngresado && numero > 0)
            {
                Console.WriteLine($"El cuadrado de {numero} es {Math.Pow(numero, 2)}, y el cubo es {Math.Pow(numero, 3)}");
            }
            else
            {
                do
                {
                    Console.WriteLine("ERROR! Reingresar numero mayor a 0: ");
                    numeroIngresado = int.TryParse(Console.ReadLine(), out numero);
                    if (numeroIngresado && numero>0)
                    {
                        Console.WriteLine($"El cuadrado de {numero} es {Math.Pow(numero, 2)}, y el cubo es {Math.Pow(numero, 3)}");
                    }

                } while (!numeroIngresado || numero <= 0);


            }
        }
    }
}
