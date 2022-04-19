using EjemplosWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemplosWeb
{
    public partial class Verificadores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAll_Click(object sender, EventArgs e)
        {
            using (BdSolicitudes Solicitudes= new BdSolicitudes())
            {
                int Maximo = Convert.ToInt32(TxtValor.Text);

                if (Solicitudes.Casos.All(c=>c.Duracion < Maximo))
                {
                    TxtResultdo.Text = "Todas son menores a " + Maximo.ToString();
                }
                else
                {
                    TxtResultdo.Text = "Hay valores mayores o iguales a" + Maximo.ToString();
                }
            }
        }
    }
}