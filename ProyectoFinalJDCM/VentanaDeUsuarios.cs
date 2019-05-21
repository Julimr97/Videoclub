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

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new ConexionBDDPelis().conecta();

            MySqlCommand comando = new MySqlCommand("Insert into usuario (dni, nombre, apellido, email, password)" +
                "values ('"+ textBoxDNI.Text +"', '"+ textBoxNombre.Text + "', '" + textBoxApellidos.Text + "', '" + textBoxEmail.Text + "', '" + textBoxPSW.Text + "');", conexion);

            MySqlDataReader resultado = comando.ExecuteReader();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            ventanaPrincipal.Visible = true;
        }
    }

}
