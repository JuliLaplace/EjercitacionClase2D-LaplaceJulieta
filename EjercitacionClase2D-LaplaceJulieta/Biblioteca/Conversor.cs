using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero) { // es static porque no instancio un objeto "Conversor". Solo tengo el metodo para usarlo directamente sin instanciar

            // string numeroBinario= Convert.ToString(numeroEntero, 2); es un atajo del lenguaje
            string numeroBinario="";
            while (numeroEntero>0)
            {
               if(numeroEntero%2 !=0)
                {
                    numeroBinario = "1" + numeroBinario;
                }
                else
                {
                    numeroBinario = "0" + numeroBinario;
                }
                numeroEntero = numeroEntero / 2; // guardo el entero (explicita) porque no me interesan los decimales y tengo que modificar la condicion del while
            }
            

            return numeroBinario;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero) {

            int numeroDecimal = 0;
            return numeroDecimal;
        }
    }
}
