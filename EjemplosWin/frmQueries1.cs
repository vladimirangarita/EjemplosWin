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
                           orderby producto.Nombre
                           select producto;
            grvResultados.DataSource = colecion.ToList();
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            var coleccion = from Producto in Datos.Productos
                            orderby Producto.Nombre descending
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
                            orderby Producto.Precio descending 
                            select new dtoProducto
                            {
                                Nombre = Producto.Nombre,
                                Precio = Producto.Precio
                            };

        }

        private void btnQuery5_Click(object sender, EventArgs e)
        {
            var coleccion = from Control ctl in this.Controls
                            select new
                            {
                                Control = ctl.Name,
                                Texto = ctl.Text
                            };
            grvResultados.DataSource = coleccion.ToList();

        }

        private void btnQuery6_Click(object sender, EventArgs e)
        {
            var colecion = from Producto in Datos.Productos
                           where Producto.Precio > 1 && Producto.Stock < 100
                           select Producto;
            grvResultados.DataSource = colecion.ToList();
        }
    }
}
