using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Calculadora
    {
        public static decimal Calcular(decimal primerOperando, decimal segundoOperando, char operacionMatematica)
        {
            decimal resultado;
            switch (operacionMatematica)
            {
                case '+':
                    resultado = primerOperando + segundoOperando;
                    break;
                case '-':
                    resultado = primerOperando - segundoOperando;
                    break;
                case '*':
                    resultado = primerOperando * segundoOperando;
                    break;
                case '/':
                    if (!Validar(segundoOperando))
                    {
                        resultado = 0; // si devuelve 0 en program pongo un CW para informar que nio se realizo la division por divisor =0
                        
                    }
                    else
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    break;

                default:
                    Console.WriteLine("Operador ingresado incorrecto.");
                    resultado = 0;
                    break;
            }
            
            return resultado;
        }

        private static bool Validar(decimal segundoOperando)
        {
            bool operandoNoEsCero= false;
            if (segundoOperando !=0)
            {
                operandoNoEsCero = true;
            }
            return operandoNoEsCero;
        }
    }
}
