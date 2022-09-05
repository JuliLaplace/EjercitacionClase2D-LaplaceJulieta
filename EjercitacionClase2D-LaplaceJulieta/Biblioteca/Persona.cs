using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        DateTime fechaDeNacimiento;

        public Persona()
        {
            this.dni = 0;
            this.nombre = "";
            this.fechaDeNacimiento = DateTime.Today;
        }
        public Persona(string nombre, int dni, DateTime fechaDeNacimiento)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }


        public int GetDni()
        {
            return this.dni;
        }

        public void SetDni(int dni)
        {
            this.dni = dni;
        }

        public string GetNombre()
        {
            return this.dni;
        }

        public void SetNombre(int dni)
        {
            this.dni = dni;
        }
    }
}
