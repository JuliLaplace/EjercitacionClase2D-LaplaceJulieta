using System;
using Biblioteca;

namespace C3_Ej_l06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ladoCuadrado;
            double baseTriangulo;
            double alturaTriangulo;
            double radioCirculo;
            int eleccionDeArea;
            bool eleccionNumerica;
            double areaCuadrado;
            double areaTriangulo;
            double areaCirculo;

            Console.WriteLine("Ingrese que calculo desea realizar: 1) Area cuadrado, 2)Area triangulo, 3) Area circulo");
            eleccionNumerica = int.TryParse(Console.ReadLine(), out eleccionDeArea);
            while (!eleccionNumerica)
            {
                Console.WriteLine("Dato invalido. Ingrese que calculo desea realizar: 1) Area cuadrado, 2)Area triangulo, 3) Area circulo");
                eleccionNumerica = int.TryParse(Console.ReadLine(), out eleccionDeArea);
            }



            if(eleccionDeArea == 1)
            {
                Console.WriteLine("Ingrese valor de un lado del cuadrado: ");
                ladoCuadrado = double.Parse(Console.ReadLine()); // deberia validar en una clase validadora, hacer mas adelante
                areaCuadrado = CalculadoraDeArea.CalcularAreaCuadrado(ladoCuadrado);

                Console.WriteLine($"El area de un cuadrado de lado{ladoCuadrado} es {areaCuadrado}");
            }
            else if (eleccionDeArea==2)
            {
                Console.WriteLine("Ingrese valor de la base del triangulo: ");
                baseTriangulo = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese valor de la altura del triangulo: ");
                alturaTriangulo = double.Parse(Console.ReadLine());
                areaTriangulo = CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
                Console.WriteLine($"El area de un triangulo de base {baseTriangulo} y altura {alturaTriangulo} es {areaTriangulo}");
            }
            else
            {
                Console.WriteLine("Ingrese valor del radio del circulo: ");
                radioCirculo = double.Parse(Console.ReadLine());
                areaCirculo = CalculadoraDeArea.CalcularAreaCirculo(radioCirculo);
                Console.WriteLine($"El area de un circulo de radio {radioCirculo} es {areaCirculo}");
            }
        }
    }
}
