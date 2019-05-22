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
    public partial class VentanaDeUsuarios : Form
    {
        public VentanaDeUsuarios()
        {
            InitializeComponent();
        }

        private DataTable datos = new DataTable();

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new ConexionBDDPelis().conecta();

            MySqlCommand comando = new MySqlCommand("Insert into usuario (dni, nombre, apellido, email, password)" +
                "values ('"+ textBoxDNI.Text +"', '"+ textBoxNombre.Text + "', '" + textBoxApellidos.Text + "', '" + textBoxEmail.Text + "', '" + textBoxPSW.Text + "');", conexion);

            MySqlDataReader resultado = comando.ExecuteReader();
            MessageBox.Show("El cliente ha sido registrado correctamente", "BIENVENIDO");
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();

        }

        private void logo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            ventanaPrincipal.Visible = true;
        }

        //El siguiente método, establece la conexión y realiza la consulta sobre la BD
        public void hazLaConsulta(String query)
        {
            tablaUsuarios.Visible = true;
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

        public void buttonmostrar_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM usuario";

            limpiaListaConsultas();
            hazLaConsulta(query);
            tablaUsuarios.DataSource = datos;
        }
    }

}
