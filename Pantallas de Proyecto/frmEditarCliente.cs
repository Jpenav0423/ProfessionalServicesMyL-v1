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
    public partial class frmEditarCliente : Form
    {
        SqlConnection con3 = new SqlConnection("Data Source=DESKTOP-6PP0TCF;Initial Catalog=Prueba_MyL2;Integrated Security=true;");
        clsConexion conexion = new clsConexion();
        SqlCommand cmd;
        
        public frmEditarCliente()
        {
            InitializeComponent();
        }

    

        private void btnGuardarYSalir_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE Deudores SET nombre = '" + txtNombre.Text + "' , id = '" + txtID.Text + "' " +
                    " ,  telefono_1 = '" + txtTelefono1.Text + "' , telefono_2 = '" + txtTelefono2.Text + "' , correo = '" + txtCorreo.Text + "' " +
                    " WHERE cod_deudor =  " + txtBuscarCodDeudor.Text + " ", conexion.sc);
                cmd.ExecuteNonQuery();


                cmd = new SqlCommand("UPDATE DIrecciones SET combre_colonia = '" + txtColonia.Text + "' WHERE cod_direccion = " + txtCodDireccion.Text + " ", conexion.sc);
                cmd.ExecuteNonQuery();
              
                cmd = new SqlCommand("UPDATE AVAL SET nom_aval = '" + txtNombreAval.Text + "' , telefono = '" + txtTelefonoAval.Text + "' , correo = '" + txtCorreoAval.Text + "' WHERE cod_aval = '" + txtCodigoAval.Text + "' ", conexion.sc);
                
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("Se han actualizado los datos de manera Exitosa", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 conexion.cargarDatosReferecnias(dgvAval);
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmGestiones frm3 = new frmGestiones();
            frm3.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable dt;

            con3.Open();
            try
            {
                if(txtBuscarCodDeudor.Text == " ")
                {
                    MessageBox.Show("PORFAVOR INGRESE EL CODIGO DEL DEUDOR ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand command = new SqlCommand("SELECT de.nombre, de.id, de.correo, di.cod_direccion, di.combre_colonia, de.telefono_1, de.telefono_2, av.cod_aval, av.nom_aval, av.correo , av.telefono  FROM Deudores de INNER JOIN DIrecciones di ON di.cod_direccion = de.direccion INNER JOIN Aval av ON av.cod_aval=de.cod_aval WHERE de.cod_deudor = '" + txtBuscarCodDeudor.Text + "'", con3);
                    SqlDataReader srd = command.ExecuteReader();

                    while (srd.Read())
                    {
                        txtNombre.Text = srd.GetValue(0).ToString();
                        txtID.Text = srd.GetValue(1).ToString();
                        txtCorreo.Text = srd.GetValue(2).ToString();
                        txtCodDireccion.Text = srd.GetValue(3).ToString();
                        txtColonia.Text = srd.GetValue(4).ToString();
                        txtTelefono1.Text = srd.GetValue(5).ToString();
                        txtTelefono2.Text = srd.GetValue(6).ToString();
                        txtCodigoAval.Text = srd.GetValue(7).ToString();
                        txtNombreAval.Text = srd.GetValue(8).ToString();
                        txtCorreoAval.Text = srd.GetValue(9).ToString();
                        txtTelefonoAval.Text = srd.GetValue(10).ToString();
                    }


                    srd.Close();


                    da = new SqlDataAdapter(" SELECT av.cod_aval, av.nom_aval, av.telefono, av.correo, de.cod_deudor, de.nombre " +
                        " FROM Aval av join Deudores de ON av.cod_aval = de.cod_aval WHERE de.cod_deudor = '" + txtBuscarCodDeudor.Text + "'  ", conexion.sc);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgvAval.DataSource = dt;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            con3.Close();
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            conexion.abrir();
        }
    }
}
