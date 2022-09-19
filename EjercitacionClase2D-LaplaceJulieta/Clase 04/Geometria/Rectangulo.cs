using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        private float area;
        private float perimetro;


        public float Area
        {
            get 
            { 
                return area; 
            }
        }
        public float Perimetro
        {
            get { return perimetro; }
        }

    }
}
