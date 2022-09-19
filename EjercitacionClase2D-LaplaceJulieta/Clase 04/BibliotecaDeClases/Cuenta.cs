using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Cuenta
    {
        private string razonSocial;
        private decimal cantidad;

        public Cuenta(string razonSocial, decimal cantidad)
        {
            this.razonSocial = razonSocial;
            this.cantidad = cantidad;
        }

        public decimal Cantidad
        {
            get
            {
                return cantidad;
            }

        }
        public string RazoSocial
        {
            get
            {
                return razonSocial;
            }

        }

        public string Mostrar()
        {

            System.Text.StringBuilder mensaje = new System.Text.StringBuilder();//averiguar porque tengo que poner System.Text

            mensaje.AppendLine($"Titular de cuenta: {RazoSocial}");
            mensaje.AppendLine($"Monto actual: {Cantidad}");

            return mensaje.ToString();

        }

        public void Ingresar(decimal monto)
        {

            if (monto > 0)
            {
                cantidad = cantidad + monto;

            }

        }
        public void RetirarDinero(decimal montoDebitar)
        {

            if (montoDebitar > 0)
            {
                cantidad = cantidad - montoDebitar;

            }
        }
    }
}
