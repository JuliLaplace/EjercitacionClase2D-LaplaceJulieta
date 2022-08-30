using System;

namespace Biblioteca
{
    public class Validador
    {
        //Metodos (que hace? acciones/funcionalidades)


        /// <summary>
        /// Valida si el numero ingresado esta dentro de los parametros minimos y maximos establecidos.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool Validar(int valor, int min, int max)
        {
            bool valorEsValido = true;
            if (valor < min || valor > max)
            {
                valorEsValido = false;
            }
            return valorEsValido;
        }


        /// <summary>
        /// Valida que la respuesta ingresada sea s o S
        /// </summary>
        /// <param name="respuesta"></param>
        /// <returns></returns>
        /// 
        public static bool ValidarRespuesta(string respuesta)
        {
            bool validacion = false;
            if(respuesta == "s" || respuesta == "S")
            {
                validacion = true;
            }
            return validacion;
        }
    }
}
