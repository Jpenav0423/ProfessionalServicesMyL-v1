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
    public partial class frmGestiones : Form
    {

        public frmGestiones()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaGestion_Click(object sender, EventArgs e)
        {
            frmNuevaGestion frm6 = new frmNuevaGestion();
            frm6.Show();
            this.Hide();
        }

        private void btnEditarDatos_Click(object sender, EventArgs e)
        {
            frmEditarCliente frm7 = new frmEditarCliente();
            frm7.Show();
            this.Hide();

        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            frmMenu frm2 = new frmMenu();
            frm2.Show();
            this.Hide();

        }

        private void btnSeguroYSeguimientos_Click(object sender, EventArgs e)
        {
            frmSeguroSeguimiento frm4 = new frmSeguroSeguimiento();
            frm4.Show();
            this.Hide();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}