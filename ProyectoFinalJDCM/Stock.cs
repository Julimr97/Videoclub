﻿using System;
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
                conexion.Close();
                conexion = new ConexionBDDPelis().conecta();
                MySqlCommand comando1 = new MySqlCommand("" +
                    "INSERT INTO `prestamos` (`id_prestamo`, `id_usuario`, `id_pelicula`, `fecha_prestamo`, `fecha_devolucion`) VALUES (NULL, '" + dniTB.Text +"', '" + id_pelicula +"', '2019-05-20', '2019-05-23');",conexion);

                MySqlDataReader resutado = comando1.ExecuteReader();
                MessageBox.Show("Película alquilada", "YEAH BABY");
            }
            else
            {
                MessageBox.Show("Cliente no identificado", "Registre al cliente");
            }

            
            
        }
    }
}
