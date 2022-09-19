using System;
using BibliotecaDeClases;
namespace C4_Ej_A02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // deberia hacer un metodo que agregue mascotas en Clase Cliente
            Mascota[] mascotasCliente1 = new Mascota[]
            {
                new Mascota(EEspecie.Perro, "Asai"),

            };
            Mascota[] mascotasCliente2 = new Mascota[]
           {
                
                new Mascota(EEspecie.Gato, "Morty", "Tripe Felina")

           };
            Mascota[] mascotasCliente3 = new Mascota[]
           {
                new Mascota(EEspecie.Gato, "Effy"),
                new Mascota(EEspecie.Perro, "India", "AntiRabica")
                

           };

            Cliente cliente1 = new Cliente("Reinoso", "Matias", "Av. Libertador 1234", 2923083, mascotasCliente1);
            Cliente cliente2 = new Cliente("Laplace", "Julieta", "Belgrano 1334", 29341556, mascotasCliente2);
            Cliente cliente3 = new Cliente("Ciano", "Javier", "guemes 23", 29341556,  mascotasCliente3);


            Console.WriteLine(cliente1.MostrarDatosCliente());
            Console.WriteLine(cliente2.MostrarDatosCliente());
            Console.WriteLine(cliente3.MostrarDatosCliente());

            /*FALTA PONER LAS MASCOTAS COMO ARRAY PARA QUE EL CLIENTE # PUEDA TENER DOS*/
        }
    }
}
