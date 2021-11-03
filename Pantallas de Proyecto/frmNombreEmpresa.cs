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
    public partial class frmNombreEmpresa : Form
    {
        public frmNombreEmpresa()
        {
            InitializeComponent();
        }

        private void btnGuardarYSalir_Click(object sender, EventArgs e)
        {
            frmListaEmpresas frm11 = new frmListaEmpresas();
            frm11.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmListaEmpresas frm11 = new frmListaEmpresas();
            frm11.Show();
            this.Hide();
        }
    }
}
