using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ProyectoFinalJDCM
{
    class ConexionBDDPelis
    {
        public MySqlConnection conecta()
        {
            MySqlConnection conexion = new MySqlConnection("" +
                "Server = 127.0.0.1;" +
                "Database = Videoclub;" +
                "UID = root;" +
                "Pwd = ;" +
                "Port = 3306;");
            conexion.Open();

            return conexion;

        }




    }
}
