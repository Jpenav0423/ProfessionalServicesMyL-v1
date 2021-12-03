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
    public partial class frmNuevaGestion : Form
    {
        clsConexion conexion = new clsConexion();
        SqlCommand cmd;

        public string codDeudor;
        public string nombreDeudor;
        public frmNuevaGestion()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCaracterizacion frm15 = new frmCaracterizacion();
            frm15.Show();
            this.Close();

        }

        private void btnGuardarYSalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodGestion.Text == "" || txtCodEmpleado.Text == "" || txtFechaFinal.Text == "" || txtFechaInicial.Text == "" || txtCodDeudor.Text == "")
                {
                    MessageBox.Show("No se pueden dejar datos en blanco nv " , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO Gestiones (cod_gestion, cod_empleado, cod_deudor, Observacion, caracter_1, caracter_2, caracter_3, promesa_pago, fecha_inicial, fecha_final , descuento) " +
                        " VALUES ('"+txtCodGestion.Text+"' , '"+txtCodEmpleado.Text+"' , '"+txtCodDeudor.Text+"', '"+txtDescripcion.Text+"' , '"+cmbCarac1.Text+"' , '"+cmbCarac2.Text+"', '"+cmbCarac3.Text+"', '"+txtValorPromesa.Text+"', '"+txtFechaInicial.Text+"', '"+txtFechaFinal.Text+ "' , '" + txtDescuento.Text + "') ", conexion.sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se han ingresado los datos con exito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cmbCarac1.SelectedIndex = -1;
                    cmbCarac2.SelectedIndex = -1;
                    cmbCarac3.SelectedIndex = -1;
                    txtCodGestion.Clear();
                    txtCodDeudor.Clear();
                    txtFechaInicial.Clear();
                    txtFechaFinal.Clear();
                    txtValorPromesa.Clear();
                    txtDescuento.Clear();
                    txtDescripcion.Clear();
                    txtCodEmpleado.Clear();

                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmGestiones frm3 = new frmGestiones();
            frm3.buscarDeudor(codDeudor, nombreDeudor);
            frm3.Show();
            this.Hide();
        }

        private void frmNuevaGestion_Load(object sender, EventArgs e)
        {
            conexion.abrir();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
