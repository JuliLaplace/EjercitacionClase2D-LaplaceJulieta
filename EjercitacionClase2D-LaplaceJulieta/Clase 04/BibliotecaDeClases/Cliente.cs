using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Cliente
    {
        private string apellido;
        private string nombre;
        private string domicilio;
        private int telefono;
        private Mascota [] mascotas;

        public Cliente()
        {
            mascotas = new Mascota[5]; 
        }
        public Cliente(string apellido, string nombre, string domicilio, int telefono, Mascota[] mascota)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.mascotas = mascota;
        }

        public string Apellido
        {
            get { return apellido; }
        }
        public string Nombre
        {
            get { return nombre; }
        }

        public string Domicilio
        {
            get { return domicilio; }
        }

        public int Telefono
        {
            get { return telefono; }
        }

        

        public void AgregarMascotas(Mascota mascota)
        {
            if(mascota is not null)
            {
                for(int i = 0; i<=mascotas.Count(); i++)
                {
                    mascotas[i] = mascota;
                }
            }

        } 
      

        public string MostrarDatosCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cliente:");
            sb.AppendLine($"Nombre: {Apellido}, {Nombre}");
            sb.AppendLine($"Direccion: {Domicilio}");
            sb.AppendLine($"Telefono: {Telefono} ");
            if(mascotas is not null)
            {
                foreach(Mascota mascota in mascotas)
                {
                    sb.Append($"Es dueño de: {mascota.MostrarMascota()}");
                }
            }

            return sb.ToString();
        }
    }
}
