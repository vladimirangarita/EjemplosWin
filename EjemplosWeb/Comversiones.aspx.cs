using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemplosWeb
{
    public partial class Comversiones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnInforme_Click(object sender, EventArgs e)
        {
            var ListaEtiquetas = Page.Form.Controls.OfType<Label>()
                .Where(et => et.ID.StartsWith("lblMonto"));
            var ListaTextos = Page.Form.Controls.OfType<TextBox>()
                .Where(tx => tx.ID.StartsWith("txtTM"));

            var Union = from ets in ListaEtiquetas
                        join txs in ListaTextos
                        on ets.ID.Last() equals txs.ID.Last()
                        select ets.Text + txs.Text;

            txtResultado.Text = string.Join(" ", Union);

        }

        protected void TxtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}