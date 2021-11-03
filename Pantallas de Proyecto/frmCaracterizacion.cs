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
    public partial class frmCaracterizacion : Form
    {
        public frmCaracterizacion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmNuevaGestion frm6 = new frmNuevaGestion();
            frm6.Show();
            this.Hide();

        }
    }
}
