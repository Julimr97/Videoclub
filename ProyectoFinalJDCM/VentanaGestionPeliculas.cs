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


namespace ProyectoFinalJDCM
{
    public partial class VentanaGestionPeliculas : Form
    {
        private DataTable datos = new DataTable();

        public VentanaGestionPeliculas()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();

        }

        private void buttonRegistrarPelis_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new ConexionBDDPelis().conecta();

            MySqlCommand comando = new MySqlCommand("Insert into movies (id, name, year, rank, stock)" +
                "values ('" + textBoxID.Text + "', '" + textBoxNombre.Text + "', '" + textBoxYear.Text + "', '" + textBoxRank.Text + "', '" + textBoxStock.Text + "');", conexion);

            MySqlDataReader resultado = comando.ExecuteReader();
            MessageBox.Show("Pelicula con ID " + textBoxID.Text + " registrado correctamente", "Pelicula registrada");
        }


        //El siguiente método, establece la conexión y realiza la consulta sobre la BD
        public void hazLaConsulta(String query)
        {
            tablaPeliculas.Visible = true;
            MySqlConnection conexion = new ConexionBDDPelis().conecta();
            MySqlCommand comando = new MySqlCommand(query, conexion);
            MySqlDataReader resultado = comando.ExecuteReader();
            datos.Load(resultado);
        }

        //Este método limpia el griefview que muestra las consultas, pero no me termina de gustar así que hay que revisarlo
        public void limpiaListaConsultas()
        {
            datos = new DataTable();
        }

        private void buttonMostrarPelis_Click(object sender, EventArgs e)
        {
                   String query = "SELECT * FROM movies";

            limpiaListaConsultas();
            hazLaConsulta(query);
            tablaPeliculas.DataSource = datos;
        }
    }
}
