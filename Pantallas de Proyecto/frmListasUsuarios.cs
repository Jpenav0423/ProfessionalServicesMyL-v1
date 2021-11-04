using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pantallas_de_Proyecto
{
    public partial class frmListasUsuarios : Form
    {
        public frmListasUsuarios()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMenuBasesExternas frmMBS = new frmMenuBasesExternas();
            frmMBS.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEditarUsuario frmEU = new frmEditarUsuario();
            frmEU.Show();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmEditarUsuario frm18 = new frmEditarUsuario();
            frm18.Show();
            this.Close();
        }
    }
}
