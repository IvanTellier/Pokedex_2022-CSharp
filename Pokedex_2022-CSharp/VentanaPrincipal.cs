using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex_2022_CSharp
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 0; //Guarda el id del pokemon que se esta viendo.

        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void Izquierda_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual > 0) //ya no da error en el tope izq
            {
                misPokemons = miConexion.getPokemonPorId(idActual);
                nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
                pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
                inicioDesc.Text = misPokemons.Rows[0]["descripcion"].ToString();
            }
        }

        private void nombrePokemon_Click(object sender, EventArgs e)
        {

        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void Derecha_Click(object sender, EventArgs e)
        {
            idActual++;
            if(idActual < 152)//ya no da error en el tope der
            {
                misPokemons = miConexion.getPokemonPorId(idActual);
                nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
                pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
                inicioDesc.Text = misPokemons.Rows[0]["descripcion"].ToString();
            }
            
        }

        private void botonInfo_Click(object sender, EventArgs e)
        {
            //2a ventana donde aparecen diferentes datos
            Ventana2 v = new Ventana2();
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            v.cambiaDescripcionPokemon(misPokemons.Rows[0]["descripcion"].ToString());
            v.sumaMovimientoA(misPokemons.Rows[0]["movimiento1"].ToString());
            v.sumaMovimientoB(misPokemons.Rows[0]["movimiento2"].ToString());
            v.sumaMovimientoC(misPokemons.Rows[0]["movimiento3"].ToString());
            v.sumaMovimientoD(misPokemons.Rows[0]["movimiento4"].ToString());
            v.sumaHabitat(misPokemons.Rows[0]["habitat"].ToString());
            v.sumaTipoA(misPokemons.Rows[0]["tipo1"].ToString());
            v.sumaTipoB(misPokemons.Rows[0]["tipo2"].ToString());
            v.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
