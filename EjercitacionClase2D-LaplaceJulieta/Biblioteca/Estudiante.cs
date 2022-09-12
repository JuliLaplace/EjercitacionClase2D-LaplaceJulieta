using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static  Random numeroRandom;

        static Estudiante()
        {
            numeroRandom = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }
        
        //setter como propiedad
        public int NotaPrimerParcial { 
           
            set { notaPrimerParcial = value; }  
            
        }

        public int NotaSegundoParcial
        {
            set { notaSegundoParcial = value; }
        }

        //Setter en forma de metodos:
        //public void SetNotaPrimerParcial (int value)
        //{
            
        //    {
        //        notaPrimerParcial = value;
        //    }
        //}
        //public void SetNotaSegundoParcial (int value)
        //{
            
        //    {
        //        notaSegundoParcial = value;
        //    }
        //}
        private float CalcularPromedio ()
        {
            
                return (float)(notaPrimerParcial + notaSegundoParcial) / 2;
            
        }
        public int CalcularNotaFinal()
        {
            int notaFinal = -1;
            if (notaPrimerParcial>=4 && notaSegundoParcial >=4)
            {
                notaFinal = numeroRandom.Next(6, 10);
            }
            return notaFinal;
        }
        public string Mostrar()
        {
            System.Text.StringBuilder textoAmostrar = new System.Text.StringBuilder();
            textoAmostrar.AppendLine("Datos Alumno:");
            textoAmostrar.AppendLine($"Nombre alumndo: {this.nombre}");
            textoAmostrar.AppendLine($"Apellido alumno: {this.apellido}");
            textoAmostrar.AppendLine($"Legajo alumno: {this.legajo}");
            textoAmostrar.AppendLine($"Nota primer parcial: {this.notaPrimerParcial}");
            textoAmostrar.AppendLine($"Nota segundo parcial:{this.notaSegundoParcial} ");
            textoAmostrar.AppendLine($"Promedio: {CalcularPromedio()}");

            if (CalcularNotaFinal() != -1)
            {

                textoAmostrar.AppendLine($"Nota final: {CalcularNotaFinal()}");
            }
            else
            {
                textoAmostrar.AppendLine("Alumno Desaprobado");
            }
            return textoAmostrar.ToString();
        }
    }
}
