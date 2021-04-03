using EjemplosWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace EjemplosWeb
{
    public partial class Consultas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWhere_Click(object sender, EventArgs e)
        {
            using (var solicitudes = new BdSolicitudes())
            {
                var coleccion = solicitudes.Casos.Where(c => c.Estatus == "P")
                    .Select(c => new {Mes=c.Fecha.Month, c.Descripcion,c.Fecha,c.Estatus})
                    
                    .OrderByDescending(c=>c.Mes).ThenBy(c=>c.Descripcion);
                GrvResultados.DataSource = coleccion.ToList();
                GrvResultados.DataBind();
            }
        }

        protected void BtnXML_Click(object sender, EventArgs e)
        {
            XElement root = XElement.Load(Server.MapPath("Estatus.xml"));
            var lista = root.Elements("Estatus").Select(E => new
            {
                Codigo=E.Attribute("Codigo").Value,
                Nombre=E.Attribute("Nombre").Value
            });
            GrvResultados.DataSource = lista.ToList();
            GrvResultados.DataBind();
        }

        protected void BtnDistinct_Click(object sender, EventArgs e)
        {
            using (var solicitudes = new BdSolicitudes())
            {
                var coleccion = solicitudes.Casos
                    .Select(c => new
                    {
                        Mes = c.Fecha.Month

                    }).OrderByDescending(c => c.Mes).Distinct();
                GrvResultados.DataSource = coleccion.ToList();
                GrvResultados.DataBind();
            }
        }

        protected void BtnAgrupar_Click(object sender, EventArgs e)
        {
            using (var solicitudes = new BdSolicitudes())
            {
                var colEstatus = solicitudes.Casos
                    .GroupBy(c => c.Estatus)
                    .Select(g => new
                    {

                        Estatus = g.Key,
                        Casos = g.Count()
                    }

                    );

                GrvResultados.DataSource = colEstatus.ToList();
                GrvResultados.DataBind();
            }
        }
    }
}