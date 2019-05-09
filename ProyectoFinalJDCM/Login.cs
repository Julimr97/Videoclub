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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btAcceder_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new ConexionBDDPelis().conecta();

            MySqlCommand comando = new MySqlCommand("" +
                "SELECT * FROM usuarios WHERE" +
                " usuario ='" + txbUsuario.Text +
                "' AND pass = '" + txbPwd.Text +
                "' ;", conexion);
            MySqlDataReader resultado = comando.ExecuteReader();
            if (resultado.Read())
            {
                MessageBox.Show("Acceso correcto", "Usuario OK");
                this.Visible = false;
                VentanaPrincipal pepe = new VentanaPrincipal();
                pepe.Visible = true;
            }
            else
            {
                MessageBox.Show("Error", "Acceso incorrecto");
            }

        }
    }
}
