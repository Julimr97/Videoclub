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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            rellenaComboAutores();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        public void rellenaComboAutores()
        {
            MySqlConnection conexion = new ConexionBDDPelis().conecta();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM actors ORDER BY first_name", conexion);
            MySqlDataReader resultado = comando.ExecuteReader();
            while (resultado.Read())
            {
                String id = resultado.GetString(0);
                String first_name = resultado.GetString("first_name");
                String last_name = resultado.GetString("last_name");
                String gender = resultado.GetString("gender");
                desplegableCine.Items.Add(id + "|" + first_name + "|" + last_name + "|" + gender);
            }
            conexion.Close();
        }
    }
}
