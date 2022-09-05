using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) {
            double areaCuadrado = longitudLado*longitudLado; // podria usar Math.Pow
            return areaCuadrado;
        }

        public static double CalcularAreaTriangulo(double basee, double altura) {
            double areaTriangulo = (basee*altura)/2;
            return areaTriangulo;
        }

        public static double CalcularAreaCirculo(double radio) {
            double areaCirculo= Math.PI * Math.Pow(radio, 2);
            return areaCirculo;
        }
    }
}
