using System;
using Biblioteca;

namespace C3_Ej_l04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal primerOperando;
            decimal segundoOperando;
            char operacionARealizar;
            decimal resultadoOperacion;
            string respuestaUsuario;
            do
            {
                Console.WriteLine("Ingrese primer operando: ");
                primerOperando =decimal.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese segundo operando: ");
                segundoOperando =decimal.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese operando a realizar: ");
                operacionARealizar = char.Parse(Console.ReadLine());

                resultadoOperacion = Calculadora.Calcular(primerOperando, segundoOperando, operacionARealizar);
                if (resultadoOperacion == 0)
                {
                    Console.WriteLine("Error. Usted ingreso un divisor 0. Reintente.");
                }
                else
                {

                    Console.WriteLine($"El resultado es {resultadoOperacion}");
                }



                Console.WriteLine("Desea realizar otra operacion?: Si/No");
                respuestaUsuario = Console.ReadLine();
            } while (respuestaUsuario == "Si" || respuestaUsuario =="si");
            
        }
    }
}
