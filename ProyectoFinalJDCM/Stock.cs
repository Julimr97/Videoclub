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
        String id_pelicula;
        public Stock()
        {
            InitializeComponent();
            rellenaComboPeliculas();

        }

        private void Stock_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
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

                peliculasCB.Items.Add(name);
            }
            conexion.Close();
        }

        private void AlquilarBoton_Click(object sender, EventArgs e)
        {

            MySqlConnection conexion = new ConexionBDDPelis().conecta();

            MySqlCommand comando = new MySqlCommand("" +
                "SELECT * FROM usuario WHERE" +
                " DNI = '" + dniTB.Text + "';", conexion);

            MySqlDataReader resultado = comando.ExecuteReader();

            if (resultado.Read())
             {

                    MySqlCommand comando1 = new MySqlCommand("" +
                    "INSERT INTO PRESTAMOS (id_usuario, id_pelicula, fecha_prestamo, fecha_devolucion) VALUES(" +
                     dniTB.Text + ","+ int.Parse(id_pelicula) + "," + "17-05-2019," + "20-01-2028" + ");",
                     conexion);
            }


            
            
        }
    }
}
