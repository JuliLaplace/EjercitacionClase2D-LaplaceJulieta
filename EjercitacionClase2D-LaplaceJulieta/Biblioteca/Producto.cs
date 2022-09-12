using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        private string nombre;
        private float precio;
        private int codigoProducto;
        public Producto(string nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Nombre { 
            get 
            { 
                return nombre;
            }

            set { nombre = value; }
            
        }
        public float Precio
        {
            get { return precio;}
            set { precio = value; }
        }
    }
}
