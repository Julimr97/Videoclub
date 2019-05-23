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
    public partial class VentanaGestionActores : Form
    {
        private DataTable datos = new DataTable();

        public VentanaGestionActores()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new ConexionBDDPelis().conecta();

            MySqlCommand comando = new MySqlCommand("Insert into actors (id, first_name, last_name, gender, film_count)" +
                "values ('" + textBoxID.Text + "', '" + textBoxNombre.Text + "', '" + textBoxApellidos.Text + "', '" + textBoxGenero.Text + "', '" + textBoxProtagonizadas.Text + "');", conexion);

            MySqlDataReader resultado = comando.ExecuteReader();
            MessageBox.Show("Actor con ID " + textBoxID.Text + " registrado correctamente", "Actor registrado");
        }

        public void hazLaConsulta(String query)
        {
            tablaActores.Visible = true;
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

        private void buttonMostrarActores_Click(object sender, EventArgs e)
        {
            {
                String query = "SELECT * FROM actors";

                limpiaListaConsultas();
                hazLaConsulta(query);
                tablaActores.DataSource = datos;
            }
        }

        private void logo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            ventanaPrincipal.Visible = true;
        }
    }
}
