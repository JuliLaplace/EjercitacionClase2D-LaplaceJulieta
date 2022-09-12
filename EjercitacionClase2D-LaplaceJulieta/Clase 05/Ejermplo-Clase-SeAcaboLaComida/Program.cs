using System;
using System.Collections.Generic;
using Biblioteca;
namespace Ejermplo_Clase_SeAcaboLaComida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigoProducto;
            bool esCodigoCorrecto;
            string respuestaUsuario;
         
            Dictionary<int, Stack<Producto>> maquinaExpendedora = new Dictionary<int, Stack<Producto>>();
            Stack<Producto> cocaCola = new Stack<Producto>();
            Stack<Producto> sprite = new Stack<Producto>();
            Stack<Producto> agua = new Stack<Producto>();
            cocaCola.Push(new Producto("Coca cola", 100.5f));
            cocaCola.Push(new Producto("Coca cola", 100.5f));
            cocaCola.Push(new Producto("Coca cola", 100.5f));
            cocaCola.Push(new Producto("Coca cola", 100.5f));
            sprite.Push(new Producto("Sprite", 100.5f));
            sprite.Push(new Producto("Sprite", 100.5f));
            sprite.Push(new Producto("Sprite", 100.5f));
            sprite.Push(new Producto("Sprite", 100.5f));
            agua.Push(new Producto("Agua", 100.5f));
            agua.Push(new Producto("Agua", 100.5f));
            agua.Push(new Producto("Agua", 100.5f));
            agua.Push(new Producto("Agua", 100.5f));

            maquinaExpendedora.Add(1, cocaCola);
            maquinaExpendedora.Add(2, sprite);
            maquinaExpendedora.Add(3, agua);

            do
            {
                Console.WriteLine("Productos disponibles:");
                foreach (KeyValuePair<int, Stack<Producto>> item in maquinaExpendedora) // para recorrer diccionario
                {
                    Console.WriteLine($"Codigo: {item.Key} - Producto: {item.Value.Peek().Nombre} - Precio: {item.Value.Peek().Precio}"); //Solo puedo "chusmear" sus datos con el peek
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
                    Console.WriteLine($"Usted compro {maquinaExpendedora[codigoProducto].Peek().Nombre} que tiene un valor de {maquinaExpendedora[codigoProducto].Peek().Precio} pesos."); //como un array
                    maquinaExpendedora[codigoProducto].Pop(); //lo elimino del stack
                    if (maquinaExpendedora[codigoProducto].Count == 0)//si cuento la cantidad en el stack y es cero, borro el codigo asi no pueden elegirlo
                    {
                        maquinaExpendedora.Remove(codigoProducto);

                    }

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
            } while (respuestaUsuario == "si" || maquinaExpendedora.Count < 0);
        }
    }
/* Stack
 * //NO SE PUEDE ACCEDER A LOS INDICES (Se usa pop y peek)
            Stack<string> pilaHamburguesas = new Stack<string>();
            pilaHamburguesas.Push("NotBurguer");//agrega
            pilaHamburguesas.Push("Cuarto de Libra");
            pilaHamburguesas.Push("Mcnifica");
            pilaHamburguesas.Push("Doble Cuarto de Libra");

            foreach (string item in pilaHamburguesas) //recorre y lo lee pero al reves (lifo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(pilaHamburguesas.Peek()); //chusmea la que esta arriba del todo (la ultima ingresada)
            Console.WriteLine(pilaHamburguesas.Pop());// elimina la ultima ingresada (retorna el elemento, se podria guardar en una variable nueva
            Console.WriteLine(pilaHamburguesas.Contains("NotBurguer"));//devuelve true

    Queue
    Queue<string> filaPersonas = new Queue <string>();
        filaPersonas.Enqueue("Julieta");
        filaPersonas.Enqueue("Matias");
        filaPersonas.Enqueue("Morty");
        foreacho(string items in filaPersona){
            CW(item);
        }
*/
}