using System;
using System.Collections.Generic;

namespace Ejemplo_Clase_MaquinaExpendedora
{
    internal class Program
    {
        /*Crear e instanciar el Dictionary<TKey,TValue> llamado maquinaExpendedora.
        2.Cargar por lo menos 10 elementos en formato clave-valor (clave=numero de posición, valor=nombre del producto)
        3.Una vez cargado, desarrollar el flujo del proyecto de consola de modo que:
        •Al iniciarse muestre al usuario todos los productos con sus respectivos códigos.
        •Pida al usuario elegir el número del producto que quiere
        •Al seleccionar número, informar al usuario que recibió ese producto y volver a mostrar todos los 
        productos SIN el producto que ya eligió
        •El programa se repetirá indefinidamente hasta que el usuario elija la opción “S”.
        BONUS: Refactorizar el programa para que en vez de tener un diccionario INT – STRING, tengamos un 
        diccionario INT – PRODUCTO (que contenga nombre y precio del producto)*/
        static void Main(string[] args)
        {
            int codigoProducto;
            bool esCodigoCorrecto;
            string respuestaUsuario;

            Dictionary<int, string> maquinaExpendedora = new Dictionary<int, string>();


            maquinaExpendedora.Add(1, "Agua");
            maquinaExpendedora.Add(2, "Sprite");
            maquinaExpendedora.Add(3, "Coca-Cola");
            maquinaExpendedora.Add(4, "Pepsi");
            maquinaExpendedora.Add(5, "7up");
            maquinaExpendedora.Add(6, "Lays");
            maquinaExpendedora.Add(7, "Cheetos");
            maquinaExpendedora.Add(8, "Rocklets");
            maquinaExpendedora.Add(9, "Saladix");
            maquinaExpendedora.Add(10, "Rex");
            do
            {
                Console.WriteLine("Productos disponibles:");
                foreach (KeyValuePair<int, string> item in maquinaExpendedora) // para recorrer diccionario
                {
                    Console.WriteLine($"Codigo: {item.Key} - Producto: {item.Value}");
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
                    Console.WriteLine($"Usted compro {maquinaExpendedora[codigoProducto]}"); //como un array
                    maquinaExpendedora.Remove(codigoProducto);
                }
                else
                {
                    Console.WriteLine("Dato invalido. Dicho codigo/producto no existe.");
                }
                

                Console.WriteLine("Desea seguir comprando? si/no");
                respuestaUsuario = Console.ReadLine().ToLower();
                if(respuestaUsuario!= "si")
                {
                    Console.WriteLine("Gracias por su compra");
                }
            } while (respuestaUsuario == "si");
        }

     
    }
}
