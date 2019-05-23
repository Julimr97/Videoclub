using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoFinalJDCM
{
    public partial class Stock : Form
    {
        String id_pelicula ="";
        public Stock()
        {
            InitializeComponent();

            fechaHoyDTP.Format = DateTimePickerFormat.Custom;
            fechaHoyDTP.CustomFormat = "yyyy-MM-dd";

            fechaDevolucionDTP.Format = DateTimePickerFormat.Custom;
            fechaDevolucionDTP.CustomFormat = "yyyy-MM-dd";

            rellenaComboPeliculas();
           

        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();

        }

        private DataTable datos = new DataTable();


        private void rellenaComboPeliculas()
        {
            MySqlConnection conexion = new ConexionBDDPelis().conecta();
            MySqlCommand comando =
                new MySqlCommand("SELECT * FROM movies ORDER BY name", conexion);
            MySqlDataReader resultado = comando.ExecuteReader();
            while (resultado.Read())
            {

                String name = resultado.GetString("name");
                id_pelicula = resultado.GetString("id");

                peliculasCB.Items.Add(id_pelicula + " | " + name);
            }
            conexion.Close();
        }

        private void AlquilarBoton_Click(object sender, EventArgs e)
        {
            
            MySqlConnection conexion = new ConexionBDDPelis().conecta();

            MySqlCommand comando = new MySqlCommand("" +
                "SELECT * FROM usuario, movies WHERE" +
                " DNI = '" + dniTB.Text + " and stock > 0';", conexion);

            MySqlDataReader resultado = comando.ExecuteReader();



            if (resultado.Read())

             {
                
                conexion.Close();
                conexion = new ConexionBDDPelis().conecta();
                cogeId();
                MySqlCommand insertaPrestamo = new MySqlCommand("" +
                    "INSERT INTO `prestamos` (`id_prestamo`, `id_usuario`, `id_pelicula`, `fecha_prestamo`, `fecha_devolucion`) VALUES (NULL, '" + dniTB.Text +"', '" + id_pelicula +"','" + fechaHoyDTP.Text + "', '"+ fechaDevolucionDTP.Text +"');",conexion);
                MySqlDataReader resutado = insertaPrestamo.ExecuteReader();
                conexion.Close();
                conexion = new ConexionBDDPelis().conecta();
                MySqlCommand modificaStock = new MySqlCommand("UPDATE  movies set stock = stock -1 where " + id_pelicula + "= id", conexion);
                MySqlDataReader resultadoStock = modificaStock.ExecuteReader();
                
                

                

                MessageBox.Show("Película alquilada", "YEAH BABY");
            }
            else
            {
                MessageBox.Show("Cliente no identificado", "Registre al cliente");
            }

            
            
        }

        private void cogeId()
        {
            String index = peliculasCB.Text.ToString();
            String indice = "";

            for (int i = 0; i< index.Length; i++)
            {
                if(index[i] != ' ')
                {
                    indice = index.Substring(0, i + 1);
                }
                else
                {
                    break;
                }
            }
            id_pelicula = indice;
        }

        private void logo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            ventanaPrincipal.Visible = true;
        }

        private void registroBoton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            VentanaDeUsuarios ventanaDeUsuarios = new VentanaDeUsuarios();
            ventanaDeUsuarios.Visible = true;
        }

        private void DevolverBoton_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new ConexionBDDPelis().conecta();

            MySqlCommand comando = new MySqlCommand("" +
                "SELECT * FROM `prestamos` WHERE id_prestamo =" +
                "" + prestamosCB.Text + "", conexion);

            MySqlDataReader resultado = comando.ExecuteReader();



            if (resultado.Read())

            {

                conexion.Close();

                conexion = new ConexionBDDPelis().conecta();
                MySqlCommand modificaStock = new MySqlCommand("UPDATE  movies set stock = stock +1 where " + id_pelicula + "= (SELECT prestamos.id_pelicula FROM prestamos WHERE prestamos.id_prestamo = " + prestamosCB.Text + ")", conexion);
                MySqlDataReader resultadoStock = modificaStock.ExecuteReader();

                conexion = new ConexionBDDPelis().conecta();
                cogeId();
                MySqlCommand devuelvePrestamo = new MySqlCommand("" +
                    "DELETE FROM `prestamos` WHERE id_prestamo = " + prestamosCB.Text + ";", conexion);
                MySqlDataReader resutado = devuelvePrestamo.ExecuteReader();
                conexion.Close();



                MessageBox.Show("Película devuelta", "YEAH BABY");
            }
            else
            {
                MessageBox.Show("Cliente no identificado o codigo de prestamo incorrecto", "Pruebe de nuevo");
            }
        }

        //El siguiente método, establece la conexión y realiza la consulta sobre la BD
        public void hazLaConsulta(String query)
        {
            tablaPelisAlquiladas.Visible = true;
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
            String query = "SELECT * FROM prestamos";

            limpiaListaConsultas();
            hazLaConsulta(query);
            tablaPelisAlquiladas.DataSource = datos;
        }
    }
}
