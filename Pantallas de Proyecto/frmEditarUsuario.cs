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
                if (txtCodEmpleado.Text == " " || txtUsuario.Text == " " || txtContraseña.Text == " " || txtConfirmarCntrña.Text == " ")
                {
                    MessageBox.Show("No se pueden insertar Datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO Usuario (cod_empleado, nivel, usuario, contra VALUES (" + txtCodEmpleado.Text + " , '" + cmbNivelUser.Text + "' , '" + txtNombreGestor.Text + "' , '" + txtContraseña.Text + "' , '" + txtConfirmarCntrña.Text + "')", conexion.sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se han ingresado los datos con Exito ", "INFROMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.CargarDatosUsuarios(dgvListaUsuarios);
                }
            }
            
        }

        private void btnCancelarYSalir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
