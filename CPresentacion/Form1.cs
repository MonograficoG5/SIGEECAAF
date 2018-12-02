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
        CN_Articulo CN = new CN_Articulo();

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
            TablaArticulos.DataSource = CN.MostrarArticulos();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            CN.GuardarArticulos(esteID.Text, esteNombre.Text);
            MessageBox.Show("Proceso completado correctamente!");
            MostrarArticulos();
        }
    }
}
