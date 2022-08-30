using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Calculadora
    {
        public  int Calcular(int primerOperando, int segundoOperando, char operacionMatematica)
        {
            int resultado=0;
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
                    if (Validar(segundoOperando))
                    {
                        resultado = -1;
                    }
                    else
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    break;

                default:
                    Console.WriteLine("Operador ingresado incorrecto. Resultado de la operacion = 0");
                    
                    break;
            }
            //aca pongo un switch? para poner orciones de + - / *
            return resultado;
        }

        private bool Validar(int segundoOperando)
        {
            bool operandoCero= true;
            if (segundoOperando ==0)
            {
                operandoCero = true;
            }
            return operandoCero;
        }
    }
}
