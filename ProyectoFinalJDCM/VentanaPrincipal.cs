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

            limpiaListaConsultas();
            hazLaConsulta(query);
        }

        private void botonDirectores_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM directors ORDER BY first_name";

            limpiaListaConsultas();
            hazLaConsulta(query);
        }

        

        private void botonPeliculas_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM movies ORDER BY name";

            limpiaListaConsultas();
            hazLaConsulta(query);
            
        }
        //El siguiente método, establece la conexión y realiza la consulta sobre la BD
        private void hazLaConsulta(String query)    
        {
            MySqlConnection conexion = new ConexionBDDPelis().conecta();
            MySqlCommand comando = new MySqlCommand(query, conexion);
            MySqlDataReader resultado = comando.ExecuteReader();
            datos.Load(resultado);
            listaConsultas.DataSource = datos;

        }
        //Este método, EN TEORIA, debería limpiar el griefview que muestra las consultas, pero no lo hace :D
        private void limpiaListaConsultas()
        {
            listaConsultas.DataSource = null;
            listaConsultas.Rows.Clear();
            listaConsultas.Refresh();
        }

    }
}
