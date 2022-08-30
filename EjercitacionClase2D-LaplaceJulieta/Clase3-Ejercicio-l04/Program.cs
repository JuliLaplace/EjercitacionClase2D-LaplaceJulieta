using System;

namespace Clase3_Ejercicio_l04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primerOperando;
            int segundoOperando;
            char operacionARealizar;
            string respuesta;

            Console.WriteLine("Ingrese primer operando: ");
            primerOperando = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo operando: ");
            segundoOperando = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese operando a realizar: ");
           operacionARealizar = char.Parse(Console.ReadLine());


        }
    }
}
