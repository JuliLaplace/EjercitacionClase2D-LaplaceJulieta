using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AlumnoEncapsulado
    {
        private string nombre;
        private string apellido;
        private int legajo;
        private int nota1;
        private int nota2;

        public AlumnoEncapsulado(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public int Nota1
        {
            get { return nota1; }
            set 
            { 
                if(!(value<=0 || value > 10))
                {
                    nota1 = value;

                }
            }

        }
        public int Nota2
        {
            get { return nota2; }
            set
            {
                if (!(value <= 0 && value > 10))
                {
                    nota2 = value;

                }
            }

        }
        public int Legajo
        {
            get { return legajo; }
            
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public string Apellido
        {
            get { return apellido; }
        }

       

        public void TomarExamen( int parcial, int nota)
        {
            if(parcial == 1)
            {
                Nota1 = nota;
            }
            if (parcial == 2)
            {
                Nota2 = nota;
            }
        }

        public int CalcularNotaFinal ()
        {
            if (Nota1 >= 4 && Nota2 >= 4)
            {
                return (Nota1 + Nota2) / 2;
            }else
            {
                return 0;
            }
        }
    }
}
