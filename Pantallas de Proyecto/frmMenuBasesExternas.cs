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
    public partial class frmMenuBasesExternas : Form
    {
        clsConexion conexion = new clsConexion();
        public frmMenuBasesExternas()
        {
            InitializeComponent();
        }

        private void btnBasesExternas_Click(object sender, EventArgs e)
        {
            frmNombreCliente frmNC = new frmNombreCliente();
            frmNC.Show();
            this.Hide(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaEmpresas frmLE = new frmListaEmpresas();
            frmLE.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmListaEmpresasADMIN frmLEA = new frmListaEmpresasADMIN();
            frmLEA.Show();
            this.Hide();
        }

        private void btnCancelarYSalir_Click(object sender, EventArgs e)
        {
            frmMenu frmM = new frmMenu();
            frmM.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmMenuBasesExternas_Load(object sender, EventArgs e)
        {
            conexion.abrir();

            if(conexion.Administrador == 0)
            {
                btnListaEmpresasAdmin.Visible = false;
            }
        }
    }
}
