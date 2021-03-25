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
    public partial class frmExtenciones : Form
    {
        public frmExtenciones()
        {
            InitializeComponent();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtValor.Text.Left(3);

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtValor.Text.Right(3);

        }
    }
}
