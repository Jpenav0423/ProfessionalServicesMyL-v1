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
    public partial class frmSeguroSeguimiento : Form
    {
        clsConexion conexion = new clsConexion();
        SqlCommand cmd;
        public frmSeguroSeguimiento()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmGestiones fmr3 = new frmGestiones();
            fmr3.Show();
            this.Close();
        }

        private void frmSeguroSeguimiento_Load(object sender, EventArgs e)
        {
            conexion.abrir();
            conexion.cargarDatosSeguimientos(dgvSeguimientos);

        }
    }
}
