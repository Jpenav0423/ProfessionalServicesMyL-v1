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
        public string codDeudor;
        public string nombreDeudor;

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
            fmr3.buscarDeudor(codDeudor, nombreDeudor);
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
                
                if (txtBuscarCodDeudor.Text == "")
                {
                    MessageBox.Show("ERROR NO SE PUEDEN DEJAR DATOS EN BLANCO", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { 
                
               

                    SqlCommand command = new SqlCommand("SELECT de.id, de.nombre, de.correo, di.cod_direccion, di.combre_colonia, de.estado_civil, de.telefono_1, de.telefono_2 FROM Deudores de JOIN DIrecciones di ON di.cod_direccion = de.direccion WHERE  de.cod_deudor = '" + txtBuscarCodDeudor.Text+ "' " , con2);
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
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            con2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "" || txtNombre.Text == "" || txtCorreo.Text == "" || txtCodDireccion.Text == "" || txtColonia.Text == "" || txtEstadoCivil.Text == "" || TxtTelefono1.Text =="" || txtTelefono2.Text == "")
            {
                MessageBox.Show("ERROR NO HAY DATOS QUE BORRAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtBuscarCodDeudor.Clear();
                txtId.Clear();
                txtNombre.Clear();
                txtCorreo.Clear();
                txtCodDireccion.Clear();
                txtColonia.Clear();
                txtEstadoCivil.Clear();
                TxtTelefono1.Clear();
                txtTelefono2.Clear();
            }
        }
    }
}
