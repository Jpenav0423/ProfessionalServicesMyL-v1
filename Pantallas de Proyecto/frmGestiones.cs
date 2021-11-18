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
    public partial class frmGestiones : Form
    {


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6PP0TCF;Initial Catalog=Prueba_MyL;Integrated Security=true;");

        clsConexion conexion = new clsConexion();
        superClase superClase = new superClase();
        SqlCommand cmd;
        public frmGestiones()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaGestion_Click(object sender, EventArgs e)
        {
            frmNuevaGestion frm6 = new frmNuevaGestion();
            frm6.Show();
            this.Hide();
        }

        private void btnEditarDatos_Click(object sender, EventArgs e)
        {
            frmEditarCliente frm7 = new frmEditarCliente();
            frm7.Show();
            this.Hide();

        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            frmMenu frm2 = new frmMenu();
            frm2.Show();
            this.Hide();

        }

        private void btnSeguroYSeguimientos_Click(object sender, EventArgs e)
        {
            frmSeguroSeguimiento frm4 = new frmSeguroSeguimiento();
            frm4.Show();
            this.Hide();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conexion.abrir();
           
            if(conexion.Administrador == 0)
            {
                btnEditarDatos.Visible = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            con.Open();
           
            try
            {

                SqlCommand command = new SqlCommand("SELECT cod_deudor, nombre, id, RTN, telefono_1, telefono_2, correo, cod_direccion, prestamo, fecha_pago, deuda_total, fecha_ultimo_pago, fecha_atraso FROM Deudores WHERE  nombre = '"+txtBuscarNombreDeudor.Text+"'" , con);
                SqlDataReader srd = command.ExecuteReader();

                while (srd.Read())
                {
                    txtCodDeudor.Text = srd.GetValue(0).ToString();
                    txtNombre.Text = srd.GetValue(1).ToString();
                    txtId.Text = srd.GetValue(2).ToString();
                    txtRtn.Text = srd.GetValue(3).ToString();
                    txtNumTelefono1.Text = srd.GetValue(4).ToString();
                    txtNumTelefono2.Text = srd.GetValue(5).ToString();
                    txtCorreo.Text = srd.GetValue(6).ToString();
                    txtCodDireccion.Text = srd.GetValue(7).ToString();
                    txtPrestamo.Text = srd.GetValue(8).ToString();
                    txtFechaPago.Text = srd.GetValue(9).ToString();
                    txtSaldoTotal.Text = srd.GetValue(10).ToString();
                    txtFechaUltimoPago.Text = srd.GetValue(11).ToString();
                    txtFechaAtraso.Text = srd.GetValue(12).ToString();
                }


                cmd = new SqlCommand(" SELECT av.cod_aval, av.nom_aval, av.telefono, av.correo, de.cod_deudor " +
                    " FROM Aval av join Deudores de ON av.cod_aval = de.cod_deudor  ", conexion.sc);
                cmd.ExecuteNonQuery();
                conexion.cargarDatosReferecnias(dgvReferencias);

                //WHERE cod_deudor = " + txtCodDeudor.Text + "
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            con.Close();
        }
    }
}