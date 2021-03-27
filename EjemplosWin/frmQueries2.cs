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
    public partial class frmQueries2 : Form
    {
        public frmQueries2()
        {
            InitializeComponent();
        }

        private void btnProcesar1_Click(object sender, EventArgs e)
        {
            var resultado = from Numero in Datos.Numeros
                            where Numero > Convert.ToInt32(txtMayores.Text)
                            select Numero;

            txtResultados.Clear();
            foreach (int n in resultado)
            {
                txtResultados.Text += n.ToString() + " ";
                
            }
        }

        private void btnProcesar2_Click(object sender, EventArgs e)
        {
            if (rbEnteros.Checked)
            {
                lstResultados.DataSource = (from object valor in Datos.MiLista
                                            where valor is int
                                            select valor).ToList();

                
            
            }

            else
            {
                lstResultados.DataSource = (from object valor in Datos.MiLista
                                            where valor is string
                                            select valor).ToList();
            }
        }

        private void btnProcesar3_Click(object sender, EventArgs e)
        {
            var resultado = from letra in txtFrase.Text
                            where !"aeiou".Contains(letra)
                            select letra;
            txtConstantes.Text = new string(resultado.ToArray());
        }
    }
}
