using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class StringBuilder
    {
        public static string CrearTablaDeMultiplicacion(int numeroIngresado)
        {
            string tablaCompleta = "";

            Console.WriteLine($"Tabla de multiplicar del numero {numeroIngresado}");
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numeroIngresado * i;
                Console.WriteLine($"{numeroIngresado} x {i} = {resultado}");

            }
            return tablaCompleta;
        }
    }
    
}
