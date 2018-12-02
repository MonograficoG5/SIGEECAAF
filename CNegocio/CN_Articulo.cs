using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using CDatos;

namespace CNegocio
{
    public class CN_Articulo
    {
        private CD_Articulo objeto = new CD_Articulo();

        public DataTable MostrarArticulos()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.MostrarArticulos();
            return tabla;
        }

        public void GuardarArticulo(string id, string nombre)
        {
            objeto.GuardarArticulo(int.Parse(id), nombre);
        }

        public void EliminarArticulo(string id)
        {
            objeto.EliminarArticulo(int.Parse(id));
        }
    }
}