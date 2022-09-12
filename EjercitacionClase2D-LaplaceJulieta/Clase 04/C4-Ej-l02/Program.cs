using System;
using System.Text;
using Biblioteca;

namespace C4_Ej_l02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************");
            Persona p1 = new Persona("Julieta", 35411575, new DateTime (1991, 04, 09) );
            Persona p2 = new Persona("Morty", 40989134, new DateTime(2018, 11, 01));
            Persona p3 = new Persona("Matias", 37231835, new DateTime(1992, 05, 18));
            Console.WriteLine(p1.Mostrar());
            Console.WriteLine(p1.EsMayorDeEdad());
            Console.WriteLine("************************************");
            Console.WriteLine(p2.Mostrar());
            Console.WriteLine(p2.EsMayorDeEdad());
            Console.WriteLine("************************************");
            Console.WriteLine(p3.Mostrar());
            Console.WriteLine(p3.EsMayorDeEdad());
            Console.WriteLine("************************************");
        }
    }
}
