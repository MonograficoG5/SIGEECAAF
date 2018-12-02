using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace CDatos
{
    public class CD_Articulo
    {
        private Coneccion coneccion = new Coneccion();
        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable MostrarArticulos()
        {
            comando.Connection = coneccion.AbrirConeccion();
            comando.CommandText = "SELECT * FROM producto";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            coneccion.CerrarConeccion();
            return tabla;
        }

        public void GuardarArticulos(int id, string nombre )
        {
            comando.Connection = coneccion.AbrirConeccion();
            comando.CommandText = "INSERT INTO producto VALUE ("+id+",'"+nombre+"')";
            comando.ExecuteNonQuery();
            coneccion.CerrarConeccion();
        }

    }
}
