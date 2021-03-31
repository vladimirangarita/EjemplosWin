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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void lblExtenciones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmExtenciones forma = new frmExtenciones();
            forma.ShowDialog();
        }

        private void llbQueries1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQueries1 forma = new frmQueries1();
            forma.ShowDialog();
        }

        private void llbQueries2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQueries2 forma = new frmQueries2();
            forma.ShowDialog();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQueries3 forma = new frmQueries3();
            forma.ShowDialog();
        }

        private void lblXML_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmXML forma = new frmXML();
            forma.ShowDialog();
        }
    }
}
