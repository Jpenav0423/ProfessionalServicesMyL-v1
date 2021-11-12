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

           // char deudor;
           
            try
            {
                /*
                string query = ("SELECT cod_deudor, nombre, id, RTN , telefono_1, telefono_2, correo, cod_direccion, prestamo , fecha_pago, deuda_total, fecha_ultimo_pago, fecha_atraso FROM Deudores WHERE nombre = '" + txtBuscarNombreDeudor.Text + "' ");
                
                //cmd = new SqlCommand("SELECT cod_deudor, nombre, id, RTN , telefono_1, telefono_2, correo, cod_direccion, prestamo , fecha_pago, deuda_total, fecha_ultimo_pago, fecha_atraso FROM Deudores WHERE nombre = '" + txtBuscarNombreDeudor.Text + "' ", conexion.sc);
                cmd = new SqlCommand(query, conexion.sc);
                conexion.cargarDatosGestiones();
                SqlDataReader reader = cmd.ExecuteReader();
                

                //cmd.ExecuteReader();

                while (reader.Read())
                {
                    txtCodDeudor.Text = reader.GetString(0);
                    txtNombre.Text = reader.GetString(1);
                    txtId.Text = reader.GetString(2);
                    txtRtn.Text = reader.GetString(3);
                    txtNumTelefono1.Text = reader.GetString(4);
                    txtNumTelefono2.Text =  reader.GetString(5);
                    txtCorreo.Text = reader.GetString(6);
                    txtCodDireccion.Text = reader.GetString(7);
                    txtPrestamo.Text = reader.GetString(8);
                    txtFechaPago.Text = reader.GetString(9);
                    txtSaldoTotal.Text = reader.GetString(10);
                    txtFechaUltimoPago.Text = reader.GetString(11);
                    txtFechaAtraso.Text = reader.GetString(12);
                }


                reader.Close();
            

                /*
                txtNombre.Text = conexion.mostarDatoGestiones();
                txtId.Text = conexion.mostarDatoGestiones();
                txtRtn.Text = conexion.mostarDatoGestiones();
                txtNumTelefono1.Text = conexion.mostarDatoGestiones();
                txtNumTelefono2.Text = conexion.mostarDatoGestiones();
                txtCorreo.Text = conexion.mostarDatoGestiones();
                txtCodDireccion.Text = conexion.mostarDatoGestiones();
                txtPrestamo.Text = conexion.mostarDatoGestiones();
                txtSaldoTotal.Text = conexion.mostarDatoGestiones();
                txtFechaPago.Text = conexion.mostarDatoGestiones();
                txtFechaUltimoPago.Text = conexion.mostarDatoGestiones();
                txtFechaAtraso.Text = conexion.mostarDatoGestiones();
                */

                //txtBuscarNombreDeudor.Text = deudor.ToString(); ;

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
        }
    }
}