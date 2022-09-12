using System;
using System.Text;

/*Construir los siguientes métodos para la clase:

Setter y getter para cada uno de los atributos.
CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la 
fecha de nacimiento.
Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
Instanciar 3 objetos de tipo Persona en el método Main.
Mostrar quiénes son mayores de edad y quiénes no.*/

namespace Biblioteca
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
                if(value > 0)
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
