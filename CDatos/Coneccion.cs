using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace CDatos
{
    public class Coneccion
    {
        public MySqlConnection AbrirConeccion()
        {
            MySqlConnection Conexion = new MySqlConnection("server=127.0.0.1; database=bd_sigecaaf; Uid=root; pwd=;");
            Conexion.Open();

            return Conexion;
        }

        public MySqlConnection CerrarConeccion()
        {
            MySqlConnection Conexion = new MySqlConnection("server=127.0.0.1; database=bd_sigecaaf; Uid=root; pwd=;");
            Conexion.Close();

            return Conexion;
        }
    }
}
