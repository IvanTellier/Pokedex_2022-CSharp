using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex_2022_CSharp
{
    public partial class Ventana2 : Form
    {
        public void cambiaDescripcionPokemon(String descripcion)
        {
            cajaDescripcion.Text = descripcion;
        }
        public void sumaMovimientoA(String movimiento1)
        {
            movimientoA.Text = movimiento1;
        }
        public void sumaMovimientoB(String movimiento2)
        {
            movimientoB.Text = movimiento2;
        }
        public void sumaMovimientoC(String movimiento3)
        {
            movimientoC.Text = movimiento3;
        }
        public void sumaMovimientoD(String movimiento4)
        {
            movimientoD.Text = movimiento4;
        }
        public void sumaTipoA(String tipo1) 
        {
            tipoA.Text = tipo1;
        }
        public void sumaTipoB(String tipo2)
        {
            tipoB.Text = tipo2;
        }
        public Ventana2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cajaDescripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
