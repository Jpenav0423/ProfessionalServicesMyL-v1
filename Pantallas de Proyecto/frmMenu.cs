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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio frm1 = new frmInicio();
            frm1.Show();
        }

        private void btnGestiones_Click(object sender, EventArgs e)
        {
            frmGestionesDia frmGestionDia = new frmGestionesDia();
            frmGestionDia.Show();
            this.Hide();

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes frm9 = new frmReportes();
            frm9.Show();
            this.Hide();

        }

        private void btnBasesExternas_Click(object sender, EventArgs e)
        {
            frmMenuBasesExternas frmMBS = new frmMenuBasesExternas();
            frmMBS.Show();
            this.Hide();
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            frmClienteGenral frm5 = new frmClienteGenral();
            frm5.Show();
            this.Hide();
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            frmListasUsuarios frm17 = new frmListasUsuarios();
            frm17.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
