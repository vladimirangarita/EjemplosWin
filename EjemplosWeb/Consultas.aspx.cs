using EjemplosWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                    .Select(c => new
                    {
                        c.Descripcion,c.Fecha,c.Estatus
                    });
                GrvResultados.DataSource = coleccion.ToList();
                GrvResultados.DataBind();
            }
        }
    }
}