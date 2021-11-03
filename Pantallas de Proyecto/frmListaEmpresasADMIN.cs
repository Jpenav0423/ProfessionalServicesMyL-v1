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
    public partial class frmListaEmpresasADMIN : Form
    {
        public frmListaEmpresasADMIN()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMenuBasesExternas frmMBE = new frmMenuBasesExternas();
            frmMBE.Show();
            this.Hide();
        }
    }
}
