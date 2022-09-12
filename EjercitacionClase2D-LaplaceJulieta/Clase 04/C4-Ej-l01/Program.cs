using System;
using System.Text;
using Biblioteca;

namespace C4_Ej_l01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cuenta cuentaJuli = new Cuenta("Julieta Laplace", 200000);
            Cuenta cuentaMorty = new Cuenta("Morty Man", 10000);
            Cuenta cuentaMati = new Cuenta("Matias Reinoso", 300000);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Cuentas disponibles:");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine(cuentaJuli.Mostrar());
            Console.WriteLine(cuentaMorty.Mostrar());
            Console.WriteLine(cuentaMati.Mostrar());
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Monto a ingresar en cuenta Juli: 230000");
            cuentaJuli.Ingresar(230000);
            Console.WriteLine(cuentaJuli.Mostrar());
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Monto a debitar de cuenta de Morty: 15000");
            cuentaMorty.RetirarDinero(15000);
            Console.Write(cuentaMorty.Mostrar());
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Monto a debitar de cuenta Matias: 2500,50");
            cuentaMati.RetirarDinero(2500);
            Console.Write(cuentaMati.Mostrar());
            Console.WriteLine("--------------------------------------------------------");
        }
    }
}
