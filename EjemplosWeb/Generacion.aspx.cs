using EjemplosWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemplosWeb
{
    public partial class Generacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (BdSolicitudes Solicitudes = new BdSolicitudes())
                {
                    int Conteo = Solicitudes.Casos.Count();
                    CmbInicio.DataSource = Enumerable.Range(1,Conteo);
                    CmbInicio.DataBind();
                }
            }
        }

        protected void CmbInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCuantos.Text))
            {
                using (BdSolicitudes Solicitudes = new BdSolicitudes())
                {
                    int Cuantos = Convert.ToInt32(TxtCuantos.Text);
                    int Inicio = Convert.ToInt32(CmbInicio.SelectedItem.Text);
                    GrvDatos.DataSource = Solicitudes.Casos.Skip(Inicio-1).Take(Cuantos);
                    GrvDatos.DataBind();
                }
            }
        }
    }
}