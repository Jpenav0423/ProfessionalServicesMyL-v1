using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_de_Proyecto
{
    public partial class frmListaEmpresas : Form
    {
        public frmListaEmpresas()
        {
            InitializeComponent();
        }

        private void btnNuevaEmpresa_Click(object sender, EventArgs e)
        {
            frmNombreEmpresa frm13 = new frmNombreEmpresa();
            frm13.Show();
            this.Close();
        }

        private void btnEditarEmpresa_Click(object sender, EventArgs e)
        {
            frmNombreEmpresa frm13 = new frmNombreEmpresa();
            frm13.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenu frm2 = new frmMenu();
            frm2.Show();
            this.Close();

        }
    }
}
