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
    public partial class frmSelecionTipoReportes : Form
    {
        public frmSelecionTipoReportes()
        {
            InitializeComponent();
        }

        private void rbnLegalCliente_CheckedChanged(object sender, EventArgs e)
        {
            frmNotificacion1 frmN1 = new frmNotificacion1();
            frmN1.Show();
            

        }

        private void rbnLegalAval_CheckedChanged(object sender, EventArgs e)
        {
            frmReporteRequerimientoLegalAVAL frmRLA = new frmReporteRequerimientoLegalAVAL();
            frmRLA.Show();
            
        }

        private void rbnEmbargo_CheckedChanged(object sender, EventArgs e)
        {

            frmAvisodeEmbargo frmAE = new frmAvisodeEmbargo();
            frmAE.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmReportes frm9 = new frmReportes();
            frm9.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReportes frm9 = new frmReportes();
            frm9.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmReportes frm9 = new frmReportes();
            frm9.Show();
            this.Hide();
        }

        private void rdbRequerimientolegal2_CheckedChanged(object sender, EventArgs e)
        {
           frmNotificacion2 frmN2 = new frmNotificacion2();
            frmN2.Show();
            
        }
    }
}
