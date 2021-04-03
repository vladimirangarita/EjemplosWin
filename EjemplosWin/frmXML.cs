using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EjemplosWin
{
    public partial class frmXML : Form
    {
        public frmXML()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            XDocument documento = XDocument.Load(@"C:\Users\Vladimir\source\repos\EjemplosWin\EjemplosWin\Clientes.xml");
            var Datos =from elem in documento.Root.Elements()
                      select new
                      {
                          Nombre = elem.Attribute("nombre").Value,
                          Apellido = elem.Attribute("Apellido").Value

                      };

            dgvDatos.DataSource = Datos.ToList();

        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            XDocument documento = XDocument.Load(@"C:\Users\Vladimir\source\repos\EjemplosWin\EjemplosWin\Clientes.xml");
            string sexo = RbM.Checked ? "M" : "F";
            string text = TxtBusqueda.Text;
            var Datos = from elem in documento.Root.Elements()
                        where elem.Attribute("sexo").Value == sexo &&
                        (elem.Attribute("nombre").Value.Contains(text) || 
                         elem.Attribute("Apellido").Value.Contains(text))
                        select new
                        {
                            Nombre=elem.Attribute("nombre").Value,
                            Apellido=elem.Attribute("Apellido").Value
                        };
            dgvDatos.DataSource = Datos.ToList();
        }

        private void BtnArchivo2_Click(object sender, EventArgs e)
        {
            XDocument documento = XDocument.Load(@"C:\Users\Vladimir\source\repos\EjemplosWin\EjemplosWin\ventas.xml");
            var Datos = from elem in documento.Root.Elements()
                        orderby elem.Element("nombre").Value
                        select new
                        {
                            Nombre=elem.Element("nombre").Value,
                            Precio = elem.Element("precio").Value,
                            Cantidad = elem.Element("cantidad").Value
                        };
            dgvDatos.DataSource = Datos.ToList();
        }
    }
}
