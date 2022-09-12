using System;
using Biblioteca;
namespace C4_Ej_A01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal[] kilometrosRealizadosConductor1 = { 345.5m, 0m, 1000.2m, 509.6m, 678.4m, 0, 4543.1m };
            decimal[] kilometrosRealizadosConductor2 = { 0m, 500.4m, 679.3m, 200m, 1092.4m, 3457.6m, 0m };
            decimal[] kilometrosRealizadosConductor3 = { 1234.5m, 567.8m, 0m, 231.5m, 0m, 454.9m, 1456.7m };

            Conductor[] conductores =
            {
                new Conductor("Julieta", kilometrosRealizadosConductor1),
                new Conductor("Matias", kilometrosRealizadosConductor2),
                new Conductor("Morty", kilometrosRealizadosConductor3)

            };

            Empresa empresa1 = new Empresa("Chevallier", conductores);
            Conductor conductorMasViajero = empresa1.CalcularConductorConMasKilometros();
            Console.WriteLine($"El conductor que mas km realiza es: {conductorMasViajero.Nombre} con la cantidad de {conductorMasViajero.CalcularTotalKm()} de km");
            /*FALTA CALCULAR QUIEN HACE MAS KM EN DIA 3 Y 5*/


            ////prueba si quisiera agregar un conductor nuevo (piso otro existente) y llamar al metodo Agregar conductor.
            //double[] kilometrosRealizadosConductor4 = { 1234.5, 567.8, 0, 231.5, 0, 454.9, 1456.7 };
            //Conductor conductor1 = new Conductor("Seba", kilometrosRealizadosConductor4);
            //empresa1.AgregarConductor(conductor1, 2);
            //double i = conductor1.CalcularTotalKm();
            //Conductor [] j = empresa1.Conductores();
            //double x = j[1].CalcularTotalKm();

        }
    }
}
