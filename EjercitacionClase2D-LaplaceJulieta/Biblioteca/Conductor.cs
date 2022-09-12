using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Conductor
    {
        private string nombre;
        private decimal [] kilometrosRealizados; //asi guarda varios km por dia

        public string Nombre
        {
            get
            { return nombre; }
            set
            { nombre = value; }
        }

        public decimal [] KilometrosRealizados
        {
            get { return kilometrosRealizados; }
            set { kilometrosRealizados = value; }
        }

        public Conductor(string nombre) //no es necesario hacerlo privado porque un conductor puede existir sin los km, los puede carcar mas tarde.
        {
            this.nombre = nombre;
            
        }   

        public Conductor(string nombre, decimal[] kilometrosRealizados) : this(nombre)
        {
            this.kilometrosRealizados = kilometrosRealizados;

        }

        public decimal CalcularTotalKm()
        {
            decimal totalKm = 0;
            for (int i = 0; i < this.kilometrosRealizados.Length; i++)
            {
                totalKm += this.kilometrosRealizados[i];
            }
            return totalKm;
        }
    }
}
