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

        public String LimpiaString(String textoALimpiar)
        {
            String limpia = textoALimpiar;
            Console.WriteLine(limpia);
            limpia = limpia.Replace("'", "").Replace(";", "").Replace("-", "");
            Console.WriteLine(limpia);

            return limpia;
        }

        private void btAcceder_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new ConexionBDDPelis().conecta();

            MySqlCommand comando = new MySqlCommand("" +
                "SELECT * FROM usuarios WHERE" +
                " usuario = '" + LimpiaString(txbUsuario.Text) + //'OR 1=1 --
                "' AND pass = '" + LimpiaString(txbPwd.Text) +
                "' ;", conexion);
            MySqlDataReader resultado = comando.ExecuteReader();
            if (resultado.Read())
            {
                MessageBox.Show("Acceso correcto", "Usuario OK");
                this.Visible = false;
                VentanaPrincipal ventana1 = new VentanaPrincipal();
                ventana1.Visible = true;
            }
            else
            {
                MessageBox.Show("Error", "Acceso incorrecto");
            }

        }
    }
}
