using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{


    public enum EEspecie
    {
        Gato,
        Perro,
        Ave,
        Pez,
        Reptil
    }

    public class Mascota
    {
        private EEspecie especie;
        private string nombre;
        // private DateTime fechaDeNacimiento;
        private string vacunasDeMascota;

        public Mascota(EEspecie especie, string nombre)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.vacunasDeMascota = "NO CARGADO";

        }

        public Mascota(EEspecie especie, string nombre, string vacunasDeMascota) : this(especie, nombre)
        {

            this.vacunasDeMascota = vacunasDeMascota;
        }

        public string Nombre
        {
            get { return nombre; }
        }
        public EEspecie Especie
        {
            get { return especie; }
        }
         public string VacunasDeMascota
        {
            get { return vacunasDeMascota; }
        }

        public string MostrarMascota()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine ($"{Nombre} de especie {Especie} y con vacunas: {vacunasDeMascota}");
            

            return sb.ToString();
        }
    }
}
