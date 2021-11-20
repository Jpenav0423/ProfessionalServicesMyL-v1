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
        SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-6PP0TCF;Initial Catalog=Prueba_MyL2;Integrated Security=true;");
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
            con2.Open();

            try
            {
                SqlCommand command = new SqlCommand("SELECT de.id, de.nombre, de.correo, di.cod_direccion, di.combre_colonia, de.estado_civil, de.telefono_1, de.telefono_2 " +
                    " FROM Deudores de JOIN DIrecciones di ON di.cod_direccion = de.cod_deudor", con2);
                SqlDataReader srd = command.ExecuteReader();

                while (srd.Read())
                {
                    txtId.Text = srd.GetValue(0).ToString();
                    txtNombre.Text = srd.GetValue(1).ToString();
                    txtCorreo.Text = srd.GetValue(2).ToString();
                    txtCodDireccion.Text = srd.GetValue(3).ToString();
                    txtColonia.Text = srd.GetValue(4).ToString();
                    txtEstadoCivil.Text = srd.GetValue(5).ToString();
                    TxtTelefono1.Text = srd.GetValue(6).ToString();
                    txtTelefono2.Text = srd.GetValue(7).ToString();


                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            con2.Close();
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            con2.Open();

            try
            {
                SqlCommand command = new SqlCommand("SELECT de.id, de.nombre, de.correo, di.cod_direccion, di.combre_colonia, de.estado_civil, de.telefono_1, de.telefono_2 FROM Deudores de JOIN DIrecciones di ON di.cod_direccion = de.direccion WHERE  de.cod_deudor = '"+txtBuscarCodDeudor.Text+"'" , con2);
                SqlDataReader srd = command.ExecuteReader();

                while (srd.Read())
                {
                    txtId.Text = srd.GetValue(0).ToString();
                    txtNombre.Text = srd.GetValue(1).ToString();
                    txtCorreo.Text = srd.GetValue(2).ToString();
                    txtCodDireccion.Text = srd.GetValue(3).ToString();
                    txtColonia.Text = srd.GetValue(4).ToString();
                    txtEstadoCivil.Text = srd.GetValue(5).ToString();
                    TxtTelefono1.Text = srd.GetValue(6).ToString();
                    txtTelefono2.Text = srd.GetValue(7).ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            con2.Close();
        }
    }
}
