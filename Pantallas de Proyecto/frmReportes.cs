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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenu frm2 = new frmMenu();
            frm2.Show();
            this.Hide();
        }

        clsConexion conexion = new clsConexion();
        SqlCommand cmd;
        private void frmReportes_Load(object sender, EventArgs e)
        {
            conexion.abrir();
            conexion.cargarDatosReportes(dgvReportes);
        }
    }
}
