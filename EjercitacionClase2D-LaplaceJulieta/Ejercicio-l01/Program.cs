using System;
using Biblioteca;

namespace Ejercicio_l01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int valorMinimoIngresado = 0;
            int valorMaximoIngresado = 0;
            double promedioNuemosIngresados;
            int acumuladorNumerosIngresados = 0; //sumo todos los numeros que ingreso
            int contadorNumerosIngresados = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Escriba un numero: ");
                numeroIngresado = int.Parse(Console.ReadLine());

                if (Validador.Validar(numeroIngresado, -100, 100))
                {
                    if (i == 0)
                    {
                        valorMinimoIngresado = numeroIngresado;
                        valorMaximoIngresado = numeroIngresado;
                        acumuladorNumerosIngresados += numeroIngresado;
                        contadorNumerosIngresados++;
                    }
                    else
                    {
                        if (valorMaximoIngresado < numeroIngresado)
                        {
                            valorMaximoIngresado = numeroIngresado;
                        }
                        if (valorMinimoIngresado > numeroIngresado)
                        {
                            valorMinimoIngresado = numeroIngresado;
                        }
                        acumuladorNumerosIngresados += numeroIngresado;
                        contadorNumerosIngresados++; //pongo contador porque puede ingresarme numeros no validos, cuento solo los validos para su promedio
                    }

                }

            }
            promedioNuemosIngresados = (double)acumuladorNumerosIngresados / contadorNumerosIngresados;
            Console.WriteLine($"El valor mminimo ingresado es {valorMinimoIngresado}, el valor maximo ingresado es {valorMaximoIngresado} y su promedio es {promedioNuemosIngresados}");








        }
    }
}
