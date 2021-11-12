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

                cmd = new SqlCommand("UPDATE AVAL SET nom_aval = '" + txtNombreAval.Text + "' , telefono = '" + txtTelefonoAval.Text + "' , correo = '" + txtCorreoAval.Text + "' WHERE cod_aval = " + txtCodigoAval.Text + " ", conexion.sc);
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
            try
            {
                string query = ("SELECT de.nombre, de.id, de.correo, di.cod_direccion, di.combre_colonia, de.telefono_1, de.telefono_2 " +
                    " FROM Deudores de JOIN DIrecciones di  ON de.cod_deudor = di.cod_direccion WHERE cod_deudor = "+txtBuscarCodDeudor.Text+" ");
                cmd = new SqlCommand(query, conexion.sc);
                conexion.EditarDatosDeudor();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txtNombre.Text = reader.GetString(1);
                    txtID.Text = reader.GetString(2);
                    txtCorreo.Text = reader.GetString(3);
                    txtCodDireccion.Text = reader.GetString(4);
                    txtColonia.Text = reader.GetString(5);
                    txtTelefono1.Text = reader.GetString(6);
                    txtTelefono2.Text = reader.GetString(7);
                }

                reader.Close();

                cmd = new SqlCommand("SELECT av.cod_aval, av.nom_aval, av.telefono , av.correo, de.cod_deudor " +
                    " FROM Aval av  JOIN Deudores DE on av.cod_aval = de.cod_deudor  WHERE cod_deudor = " + txtBuscarCodDeudor.Text, conexion.sc);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetValue(0).ToString());
                        txtNombreAval.Text = reader.GetValue(1).ToString();
                        txtTelefonoAval.Text = reader.GetValue(2).ToString();
                        txtCorreoAval.Text = reader.GetValue(3).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("El codigo del Aval no es el correcto", "ERROR");
                }

                reader.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
