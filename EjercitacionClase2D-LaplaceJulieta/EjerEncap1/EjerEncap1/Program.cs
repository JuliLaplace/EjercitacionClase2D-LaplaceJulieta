using Entidades;
using System;

namespace EjerEncap1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlumnoEncapsulado alumno1 = new AlumnoEncapsulado("Perez", "Agustin", 12345);
            AlumnoEncapsulado alumno2 = new AlumnoEncapsulado("Garcia", "Jorge", 12346);
            AlumnoEncapsulado alumno3 = new AlumnoEncapsulado("Lopez", "Pablo", 12347);

            alumno1.TomarExamen(1, 5);
            alumno2.TomarExamen(1, 8);
            alumno3.TomarExamen(1, 2);
            alumno1.TomarExamen(2, 9);
            alumno2.TomarExamen(2, 4);
            alumno3.TomarExamen(2, 5);

            Console.WriteLine("El alumno: " + alumno1.Apellido + ", " + alumno1.Nombre + " tiene como nota final: " + alumno1.CalcularNotaFinal());
            Console.WriteLine("El alumno: " + alumno2.Apellido + ", " + alumno2.Nombre + " tiene como nota final: " + alumno2.CalcularNotaFinal());
            Console.WriteLine("El alumno: " + alumno3.Apellido + ", " + alumno3.Nombre + " tiene como nota final: " + alumno3.CalcularNotaFinal());


            //Alumno alumno1 = new Alumno("Perez", "Agustin", 12345);
            //Alumno alumno2 = new Alumno("Garcia", "Jorge", 12346);
            //Alumno alumno3 = new Alumno("Lopez", "Pablo", 12347);

            //alumno1.nota1 = 8;
            //alumno2.nota1 = 7;
            //alumno3.nota1 = 9;

            //alumno1.nota2 = 7;
            //alumno2.nota2 = 9;
            //alumno3.nota2 = 8;

            //int notaFinal1 = alumno1.CalcularNotaFinal();
            //int notaFinal2 = alumno2.CalcularNotaFinal();
            //int notaFinal3 = alumno3.CalcularNotaFinal();

            //Console.WriteLine("El alumno: " + alumno1.apellido + ", " + alumno1.nombre + " tiene como nota final: " + notaFinal1);
            //Console.WriteLine("El alumno: " + alumno2.apellido + ", " + alumno2.nombre + " tiene como nota final: " + notaFinal2);
            //Console.WriteLine("El alumno: " + alumno3.apellido + ", " + alumno3.nombre + " tiene como nota final: " + notaFinal3);

        }
    }
}
