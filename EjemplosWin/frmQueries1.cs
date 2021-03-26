using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosWin
{
    public partial class frmQueries1 : Form
    {
        public frmQueries1()
        {
            InitializeComponent();
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            grvResultados.DataSource = Datos.Productos;

        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            var colecion = from producto in Datos.Productos
                           select producto;
            grvResultados.DataSource = colecion.ToList();
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            var coleccion = from Producto in Datos.Productos
                            select new
                            {
                                codigo = Producto.Codigo,
                                NombreProducto = Producto.Nombre


                            };

            grvResultados.DataSource = coleccion.ToList();
        }

        private void btnQuery4_Click(object sender, EventArgs e)
        {
            var coleccion = from Producto in Datos.Productos
                            select new dtoProducto
                            {
                                Nombre = Producto.Nombre,
                                Precio = Producto.Precio
                            };

        }
    }
}
