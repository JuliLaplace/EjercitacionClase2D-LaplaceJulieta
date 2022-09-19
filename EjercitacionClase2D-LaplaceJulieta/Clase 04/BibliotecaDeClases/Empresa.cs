using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Empresa
    {
        private string nombreEmpresa;
        private Conductor[] conductores;

        //lo pongo en privado asi jamas crean una empresa solo con el nombre, si no que tienen que agregar si o si sus empleados para existir (conductores)
        private Empresa(string nombreEmpresa)
        {
            this.nombreEmpresa = nombreEmpresa;

        }

        public Empresa(string nombreEmpresa, Conductor[] conductores) : this(nombreEmpresa)
        {

            this.conductores = conductores;
        }

        //public Empresa(string nombreEmpresa, Conductor[] conductores)
        //{
        //    this.nombreEmpresa = nombreEmpresa;
        //    this.conductores = conductores;
        //}
        public string NombreEmpresa
        {
            get { return nombreEmpresa; }
            set { nombreEmpresa = value; }
        }
        public Conductor[] Conductores
        {
            get { return conductores; }
            set { conductores = value; }
        }
        //esto seria un metodo que funciona como el getter y setter del nombre de la empresa
        //public void AgreagrNombre(string nombreEmpresa)
        //{
        //    this.nombreEmpresa = nombreEmpresa;
        //}
        //public string MostrarNombre()
        //{
        //    return this.nombreEmpresa;
        //}

        public void AgregarConductor(Conductor conductor, int lugar)
        {
            this.conductores[lugar] = conductor;
        }
        public void AgregarConductores(Conductor[] conductores)
        {
            this.conductores = conductores;
        }

        //public Conductor[] Conductores()
        //{
        //    return this.conductores;
        //}
        public Conductor CalcularConductorConMasKilometros()
        {
            Conductor conductorConMasKm;
            conductorConMasKm = this.conductores[0];
            for (int i = 1; i < this.conductores.Length; i++)
            {

                if (this.conductores[i].CalcularTotalKm() > conductorConMasKm.CalcularTotalKm())
                {
                    conductorConMasKm = this.conductores[i];
                }

            }

            return conductorConMasKm;
        }
    }
}
