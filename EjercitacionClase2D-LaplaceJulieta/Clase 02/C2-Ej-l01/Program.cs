using System;
using Biblioteca;
namespace C2_Ej_l01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            bool numeroAIngresar;
            int valorMinimoIngresado = int.MinValue;
            int valorMaximoIngresado = int.MaxValue;
            double promedioNuemosIngresados;
            int acumuladorNumerosIngresados = 0; //sumo todos los numeros que ingreso
            int contadorNumerosIngresados = 0; // cuento cantidad de numeros validos ingresados

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Escriba un numero entre -100 y 100: ");
                numeroAIngresar = int.TryParse(Console.ReadLine(), out numeroIngresado);

                while (numeroAIngresar is not true)
                {
                    Console.WriteLine("Error. Escriba un numero valido entre -100 y 100: ");
                    numeroAIngresar = int.TryParse(Console.ReadLine(), out numeroIngresado);
                }


                if (Validador.Validar(numeroIngresado, -100, 100))
                {
                    //if (i == 0)
                    //{
                    //    valorMinimoIngresado = numeroIngresado;
                    //    valorMaximoIngresado = numeroIngresado;
                    //    acumuladorNumerosIngresados += numeroIngresado;
                    //    contadorNumerosIngresados++;
                    //}
                    //else
                    //{
                    //    if (valorMaximoIngresado < numeroIngresado)
                    //    {
                    //        valorMaximoIngresado = numeroIngresado;
                    //    }
                    //    if (valorMinimoIngresado > numeroIngresado)
                    //    {
                    //        valorMinimoIngresado = numeroIngresado;
                    //    }
                    //    acumuladorNumerosIngresados += numeroIngresado;
                    //    contadorNumerosIngresados++; //pongo contador porque puede ingresarme numeros no validos, cuento solo los validos para su promedio
                    //}

                    if (i == 0 || numeroIngresado < valorMinimoIngresado)
                    {
                        valorMinimoIngresado = numeroIngresado;
                        acumuladorNumerosIngresados += numeroIngresado;
                        contadorNumerosIngresados++;
                    }
                    if (i == 0 || numeroIngresado > valorMaximoIngresado)
                    {
                        valorMaximoIngresado = numeroIngresado;
                        acumuladorNumerosIngresados += numeroIngresado;
                        contadorNumerosIngresados++; //pongo contador porque puede ingresarme numeros no validos, cuento solo los validos para su promedio
                    }

                }
                else
                {
                    Console.WriteLine("Error, el numero no esta dentro del rango establecido. Reintente:");
                }

            }
            promedioNuemosIngresados = (double)acumuladorNumerosIngresados / contadorNumerosIngresados;
            Console.WriteLine($"El valor mminimo ingresado es {valorMinimoIngresado}, el valor maximo ingresado es {valorMaximoIngresado} y su promedio es {promedioNuemosIngresados}");

        }
    }
}
