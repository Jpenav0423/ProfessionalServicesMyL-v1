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
    public partial class frmEditarCliente : Form
    {
        public frmEditarCliente()
        {
            InitializeComponent();
        }

    

        private void btnGuardarYSalir_Click(object sender, EventArgs e)
        {
            frmGestiones frm3 = new frmGestiones();
            frm3.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmGestiones frm3 = new frmGestiones();
            frm3.Show();
            this.Hide();
        }
    }
}
