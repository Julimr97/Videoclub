using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

/*
 * Autor: Daniel Hebrero Núñez, Amo y señor del código
 */

namespace ProyectoFinalJDCM
{
    public partial class VentanaPrincipal : Form
    {
        private DataTable datos = new DataTable();  //Declaro el DataTable de datos
        public VentanaPrincipal()
        {
            InitializeComponent();
            
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        

        private void botonActores_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM actors ORDER BY first_name";
            labelTabla.Text = "Actores que opinan que soy el más guapo";
            limpiaListaConsultas();
            hazLaConsulta(query);
        }

        private void botonDirectores_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM directors ORDER BY first_name";
            labelTabla.Text = "Directores de las películas que tengo";
            limpiaListaConsultas();
            hazLaConsulta(query);
        }

        

        private void botonPeliculas_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM movies ORDER BY name";
            labelTabla.Text = "Mira que de pelis tengo";
            limpiaListaConsultas();
            hazLaConsulta(query);
            
        }

        private void butonAñadirPelis_Click(object sender, EventArgs e)
        {
            //Este botón te lleva a un Form (cuando se cree) donde 
            //se gestionan las películas
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            //Este botón te lleva a un Form (cuando se cree) donde 
            //se gestionan el alquiler de películas
        }



        //El siguiente método, establece la conexión y realiza la consulta sobre la BD
        private void hazLaConsulta(String query)    
        {
            dGListaConsultas.Visible = true;
            MySqlConnection conexion = new ConexionBDDPelis().conecta();
            MySqlCommand comando = new MySqlCommand(query, conexion);
            MySqlDataReader resultado = comando.ExecuteReader();
            datos.Load(resultado);
            dGListaConsultas.DataSource = datos;

        }
        //Este método limpia el griefview que muestra las consultas, pero no me termina de gustar así que hay que revisarlo
        private void limpiaListaConsultas()
        {
             datos = new DataTable();


    }

       
    }
}
