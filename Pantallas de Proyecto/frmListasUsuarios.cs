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

        clsConexion conexion = new clsConexion();
        SqlCommand cmd;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMenuBasesExternas frmMBS = new frmMenuBasesExternas();
            frmMBS.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCodEmpleado.Text == "" || txtContraseña.Text == "" || txtEstado.Text == "" || txtUsuario.Text == "")
                {
                    MessageBox.Show("ERROR, NO SE PUEDEN DEJAR DATOS EN BLANCO", "INFORMACION", MessageBoxButtons.OK);
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO Usuario (cod_empleado, nivel, usuario, contra, estado) VALUES (" + txtCodEmpleado.Text + " , '" + cmbNivelUser.Text + "' , '" + txtUsuario.Text + "', '" + txtContraseña.Text + "' , '" + txtEstado.Text + "')", conexion.sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se han ingresado los Datos con Exito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.CargarDatosUsuarios(dgvListaUsuarios);
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE Usuario set nivel = '" + cmbNivelUser.Text + "', usuario = '" + txtUsuario.Text + "' , contra = '" + txtContraseña.Text + "' , estado = '" + txtEstado.Text + "' WHERE cod_empleado = "+txtCodEmpleado.Text+" ", conexion.sc);
                cmd.ExecuteNonQuery();
                conexion.CargarDatosUsuarios(dgvListaUsuarios);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void frmListasUsuarios_Load(object sender, EventArgs e)
        {
            conexion.abrir();
            conexion.CargarDatosUsuarios(dgvListaUsuarios);
            //this.reportViewer1.RefreshReport();
        }

        private void dgvListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCodEmpleado.Text == "")
                {
                    MessageBox.Show("NO PUEDE DEJAR DATOS EN BLANCO","INFORMACION", MessageBoxButtons.OK);
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM Usuario WHERE cod_empleado = " + txtCodEmpleado.Text, conexion.sc);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetValue(0).ToString());
                            cmbNivelUser.SelectedIndex = cmbNivelUser.Items.IndexOf(reader.GetValue(1).ToString());
                            txtEstado.Text = reader.GetValue(4).ToString();
                            txtUsuario.Text = reader.GetValue(2).ToString();
                            txtContraseña.Text = reader.GetValue(3).ToString();
                        }

                    }
                    else
                    {
                        MessageBox.Show("El codigo del empelado no existe", "ERROR");
                    }

                    reader.Close();
                }
                

            }catch(Exception ex)
            {
                MessageBox.Show("ERROR NO SE PUEDEN CARGAR LOS DATOS" + ex , "ERROR");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodEmpleado.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtEstado.Clear();

            cmbNivelUser.SelectedIndex = -1;

            txtCodEmpleado.Focus();
        }
    }
}
