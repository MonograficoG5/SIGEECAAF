using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio;

namespace CPresentacion
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarArticulos();
        }

        private void MostrarArticulos()
        {
            CN_Articulo CN = new CN_Articulo();
            TablaArticulos.DataSource = CN.MostrarArticulos();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            CN_Articulo CN = new CN_Articulo();
            CN.GuardarArticulo(esteID.Text, esteNombre.Text);
            MessageBox.Show("Proceso completado correctamente!");
            MostrarArticulos();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            CN_Articulo CN = new CN_Articulo();
            string id = TablaArticulos.CurrentRow.Cells[0].Value.ToString();
            CN.EliminarArticulo(id);
            MessageBox.Show("Proceso completado correctamente!");
            MostrarArticulos();
        }
    }
}
