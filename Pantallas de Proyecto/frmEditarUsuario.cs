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
    public partial class frmEditarUsuario : Form
    {
        public frmEditarUsuario()
        {
            InitializeComponent();
        }

        clsConexion conexion = new clsConexion();
        SqlCommand cmd;
        frmListasUsuarios frmLU = new frmListasUsuarios();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE Usuario SET ( cod_empleado = '" + txtCodEmpleado.Text + "', nivel = '" + cmbNivelUser.Text + "' , usuario = '" + txtUsuario.Text + "' ,  contra = '" + txtContraseña.Text + "' , estado = '" + txtEstado.Text + "' )", conexion.sc);
                cmd.ExecuteNonQuery();
                conexion.CargarDatosUsuarios(dgvListaUsuarios);
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelarYSalir_Click(object sender, EventArgs e)
        {
            frmListasUsuarios frmLU = new frmListasUsuarios();
            frmLU.Show();
            this.Hide();
        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            conexion.abrir();
            conexion.CargarDatosUsuarios(dgvListaUsuarios);
        }
    }
}
