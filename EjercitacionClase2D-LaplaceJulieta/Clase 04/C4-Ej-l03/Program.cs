using System;
using Biblioteca;
namespace C4_Ej_l03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Laplace", "11123", "Julieta");
            Estudiante estudiante2 = new Estudiante("Reinoso", "11124", "Matias");
            Estudiante estudiante3 = new Estudiante("Man", "11125", "Morty");

            //Hice de las dos formas (propiedad / metodo) para entender como llamarlos/utilizarlos desde el main
            //estudiante1.SetNotaPrimerParcial(1);
            //estudiante1.SetNotaSegundoParcial(4);

            //estudiante2.SetNotaPrimerParcial(8);
            //estudiante2.SetNotaSegundoParcial(7);

            //estudiante3.SetNotaPrimerParcial(10);
            //estudiante3.SetNotaSegundoParcial(9);

            /*Si usara propiedades se llamaria asi: */
            estudiante1.NotaPrimerParcial = 2;
            estudiante1.NotaSegundoParcial = 3;

            estudiante2.NotaPrimerParcial = 7;
            estudiante2.NotaSegundoParcial = 8;

            estudiante3.NotaPrimerParcial = 10;
            estudiante3.NotaSegundoParcial = 9;

            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}
