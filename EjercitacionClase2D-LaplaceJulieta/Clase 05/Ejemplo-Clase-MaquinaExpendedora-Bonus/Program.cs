using System;
using System.Collections.Generic;
using Biblioteca;

namespace Ejemplo_Clase_MaquinaExpendedora_Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int codigoProducto;
            bool esCodigoCorrecto;
            string respuestaUsuario;

            Dictionary<int, Producto> maquinaExpendedora = new Dictionary<int, Producto>();

            
            maquinaExpendedora.Add(1, new Producto("Agua", 100.5f));
            maquinaExpendedora.Add(2, new Producto("Sprite", 150f));
            maquinaExpendedora.Add(3, new Producto("Coca Cola", 155.5f));
            maquinaExpendedora.Add(4, new Producto("Pepsi", 120f));
            maquinaExpendedora.Add(5, new Producto("7up", 120.5f));
            maquinaExpendedora.Add(6, new Producto("Lays", 200f));
            maquinaExpendedora.Add(7, new Producto("Cheetos", 220.7f));
            maquinaExpendedora.Add(8, new Producto("Rocklets", 50.25f));
            maquinaExpendedora.Add(9, new Producto("Saladix", 176f));
            maquinaExpendedora.Add(10, new Producto("Rex", 180.5f));
            do
            {
                Console.WriteLine("Productos disponibles:");
                foreach (KeyValuePair<int, Producto> item in maquinaExpendedora) // para recorrer diccionario
                {
                    Console.WriteLine($"Codigo: {item.Key} - Producto: {item.Value.Nombre} - Precio: {item.Value.Precio}");
                }

                Console.WriteLine("Ingrese el codigo del producto que desee: ");
                esCodigoCorrecto = int.TryParse(Console.ReadLine(), out codigoProducto);
                while (!esCodigoCorrecto)
                {
                    Console.WriteLine("Dato invalido. Ingrese el codigo del producto que desee: ");
                    esCodigoCorrecto = int.TryParse(Console.ReadLine(), out codigoProducto);
                }
                if (maquinaExpendedora.ContainsKey(codigoProducto))
                {
                    Console.WriteLine($"Usted compro {maquinaExpendedora[codigoProducto].Nombre} que tinee un valor de {maquinaExpendedora[codigoProducto].Precio} pesos."); //como un array
                    maquinaExpendedora.Remove(codigoProducto);
                }
                else
                {
                    Console.WriteLine("Dato invalido. Dicho codigo/producto no existe.");
                }


                Console.WriteLine("Desea seguir comprando? si/no");
                respuestaUsuario = Console.ReadLine().ToLower();
                if (respuestaUsuario != "si")
                {
                    Console.WriteLine("Gracias por su compra");
                }
            } while (respuestaUsuario == "si" || maquinaExpendedora.Count<0); //si compra todo no va a poder seguir haciendolo
        }
    }
}
