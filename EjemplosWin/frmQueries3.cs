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
    public partial class frmQueries3 : Form
    {
        public frmQueries3()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            using (BdSolicitudes Solicitudes=new BdSolicitudes() )
            {
                var coleccion = from caso in Solicitudes.Casos
                                let Mes = caso.Fecha.Month
                                orderby Mes, caso.Id
                                group caso by new { Mes, caso.Estatus };




                foreach (var agrupador in coleccion)
                {
                    TreeNode Nodo = tvrCasos.Nodes.Add(
                        "Mes " + agrupador.Key.Mes.ToString() +
                        "-Estatus: " + agrupador.Key.Estatus);


                    foreach (Caso _caso in agrupador.ToList())
                    {
                        Nodo.Nodes.Add(_caso.Id.ToString() + ":" +
                            _caso.Fecha.ToString("dd/MM/yyyy") + "-" + _caso.Estatus);
                    }


                }

                

            }
        }

        private void frmQueries3_Load(object sender, EventArgs e)
        {

        }

        private void BtnInto_Click(object sender, EventArgs e)
        {
            using (BdSolicitudes solicitudes=new BdSolicitudes())
            {
                var coleccion = from caso in solicitudes.Casos
                                let Mes = caso.Id
                                orderby Mes, caso.Id
                                group caso by Mes into grupo
                                select new { Mes = grupo.Key, Casos = grupo.Count() };

                GrvResultados.DataSource = coleccion.ToList();

            }
        }

        private void BtnJoin1_Click(object sender, EventArgs e)
        {
            using (BdSolicitudes solicitudes = new BdSolicitudes())
            {
                var coleccion = from cat in solicitudes.Categorias
                                join scat in solicitudes.SubCategorias
                                on cat.Id equals scat.IdCategoria
                                select new
                                {
                                    Categoria = cat.Nombre,
                                    SubCategoria = scat.Nombre
                                };
                GrvResultados.DataSource = coleccion.ToList();
            }
        }

        private void BtnJoin2_Click(object sender, EventArgs e)
        {
            using (BdSolicitudes solicitudes = new BdSolicitudes())
            {
                var coleccion = from caso in solicitudes.Casos
                                join scat in solicitudes.SubCategorias
                                on caso.IdSubCategoria equals scat.Id
                                join cat in solicitudes.Categorias
                                on scat.IdCategoria equals cat.Id
                                where caso.Estatus == "A"
                                orderby caso.Fecha descending
                                select new
                                {
                                    Id = caso.Id,
                                    Fecha = caso.Fecha,
                                    Categoria = cat.Nombre,
                                    SubCategoria = scat.Nombre
                                };
                GrvResultados.DataSource = coleccion.ToList();
            }
        }

        private void BtnSubQuery_Click(object sender, EventArgs e)
        {
            using (BdSolicitudes solicitudes =new BdSolicitudes())
            {
                var coleccion = from scat in solicitudes.SubCategorias
                                select new
                                {
                                    SubCategoria=scat.Nombre,
                                    Categoria=(from cat in solicitudes.Categorias
                                               where cat.Id==scat.IdCategoria select cat.Nombre).FirstOrDefault()

                                };
                GrvResultados.DataSource = coleccion.ToList();
            }
        }
    }
}
