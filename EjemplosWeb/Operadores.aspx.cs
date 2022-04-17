using EjemplosWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemplosWeb
{
    public partial class Operadores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            using (var Solicitudes = new BdSolicitudes())
            {
                TxtCasos.Text = Solicitudes.Casos.Count().ToString();

                TxtDuracion.Text = Solicitudes.Casos.Average(c => c.Duracion).ToString();

                TxtCerrados.Text = Solicitudes.Casos.Count(c => c.Estatus == "C").ToString();
            }
        }

        protected void BtnAgreggate_Click(object sender, EventArgs e)
        {
            List<string> NumerosTexto = TxtNumeros.Text.Split(' ').ToList();
            List<int> Numeros = NumerosTexto.Select(n => Convert.ToInt32(n)).ToList();
            TxtCuadrados.Text = Numeros.Aggregate(0, (acc, i) => acc + i * i).ToString();
        }
    }
}