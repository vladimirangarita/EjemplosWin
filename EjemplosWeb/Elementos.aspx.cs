using System;
using EjemplosWin;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemplosWeb
{
    public partial class Elementos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            int IdCaso = Convert.ToInt32(TxtCaso.Text);
            using (var Solicitudes = new BdSolicitudes())
            {
                var elCaso = Solicitudes.Casos.Where(c => c.Id == IdCaso)
                    .Select(c => new { c.Fecha, c.Descripcion })
                    .SingleOrDefault();
                if (elCaso !=null)
                {
                    TxtFecha.Text = elCaso.Fecha.ToString("dd/MM/yyyy");
                    TxtDescripcion.Text = elCaso.Descripcion;
                }
                else
                {
                    TxtDescripcion.Text = "El caso no existe";
                }
            }
        }
    }
}