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
    public partial class frmTipoReporte : Form
    {
        public frmTipoReporte()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmSelecionTipoReportes frm8 = new frmSelecionTipoReportes();
            frm8.Show();
            this.Hide();
        }
    }
}
