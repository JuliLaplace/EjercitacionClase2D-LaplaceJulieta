using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Persona
    {
        //atributos
        private string nombre;
        private int dni;
        private DateTime fechaDeNacimiento;

        //constructor
        public Persona(string nombre, int dni, DateTime fechaDeNacimiento)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public int Dni
        {
            get
            {
                return dni;

            }
            set
            {
                if (value > 0)
                {
                    this.dni = value;

                }
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;

            }
            set
            {
                this.nombre = value;

            }
        }
        public DateTime FechaDeNacimiento
        {
            get
            {
                return fechaDeNacimiento;

            }
            set
            {
                this.fechaDeNacimiento = value;

            }
        }



        private int CalcularEdad()
        {
            return DateTime.Today.AddTicks(-fechaDeNacimiento.Ticks).Year - 1;

        }

        public string EsMayorDeEdad()
        {
            string esMayor = "Es mayor de edad";

            if (CalcularEdad() < 18) //podria usar el metodo CalcularEdad aca?
            {
                esMayor = "Es menor";
            }
            return esMayor;
        }
        public string Mostrar()
        {

            System.Text.StringBuilder texto = new System.Text.StringBuilder();
            texto.AppendLine("Datos a mostrar:");
            texto.AppendLine($"Nombre:{nombre} ");
            texto.AppendLine($"DNI:{dni} ");
            texto.AppendLine($"Edad:{CalcularEdad()} años.");

            return texto.ToString();
        }
    }
}
