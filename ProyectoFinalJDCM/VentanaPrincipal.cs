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
 * Autor: Daniel Hebrero, Amo y Señor del código
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
            
            limpiaListaConsultas();
            hazLaConsulta(query);
            tablaConsultasDG.DataSource = datos;
        }

        private void botonDirectores_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM directors ORDER BY first_name";
            
            limpiaListaConsultas();
            hazLaConsulta(query);
            tablaConsultasDG.DataSource = datos;
        }

        

        private void botonPeliculas_Click(object sender, EventArgs e)
        {
            String query = "SELECT movies.id, movies.name, movies.year, movies.rank FROM movies ORDER BY name";
     
            limpiaListaConsultas();
            hazLaConsulta(query);
            tablaConsultasDG.DataSource = datos;

        }

        private void butonAñadirPelis_Click(object sender, EventArgs e)
        {
            //Este botón te lleva a un Form (cuando se cree) donde 
            //se gestionan las películas
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Stock ventanaStock = new Stock();
            ventanaStock.Visible = true;
        }



        //El siguiente método, establece la conexión y realiza la consulta sobre la BD
        public void hazLaConsulta(String query)    
        {
            tablaConsultasDG.Visible = true;
            MySqlConnection conexion = new ConexionBDDPelis().conecta();
            MySqlCommand comando = new MySqlCommand(query, conexion);
            MySqlDataReader resultado = comando.ExecuteReader();
            datos.Load(resultado);
            
            

        }
        //Este método limpia el griefview que muestra las consultas, pero no me termina de gustar así que hay que revisarlo
        private void limpiaListaConsultas()
        {
             datos = new DataTable();


    }

      

       
    }
}
