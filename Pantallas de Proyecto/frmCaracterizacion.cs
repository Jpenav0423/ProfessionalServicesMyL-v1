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
    public partial class frmCaracterizacion : Form
    {

        clsConexion conexion = new clsConexion();
        SqlCommand cmd;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Caracterizacion_1", conexion.sc);
                cmd.ExecuteNonQuery();
                conexion.mostrarCaracterizacion1(dgvCarac1);

                cmd = new SqlCommand("SELECT * FROM Caracterizacion_3", conexion.sc);
                cmd.ExecuteNonQuery();
                conexion.mostrarCaracterizacion2(dgvCarac2);

                cmd = new SqlCommand("SELECT * FROM Caracterizacion_3", conexion.sc);
                cmd.ExecuteNonQuery();
                conexion.mostrarCaracterizacion3(dgvCarac3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmCaracterizacion_Load(object sender, EventArgs e)
        {
            conexion.abrir();
        }
    }
}
