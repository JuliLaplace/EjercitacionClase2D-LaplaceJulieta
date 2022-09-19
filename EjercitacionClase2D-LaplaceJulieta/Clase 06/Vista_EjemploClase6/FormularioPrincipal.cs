using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_EjemploClase6
{
    //Partial: Clase FormularioPrincipal esta "partida en dos partes". En este proyecto van a estar metodos, 
    //propiedades, constructores. La otra parte es el Designer
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }
         //EVENTO:
        //private void btn_botonInicial_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Hola usuario"); //no se usa console.write
        //} // ppara borrarlo, usar el "rayito" y eliminar el Click 
    }
}
