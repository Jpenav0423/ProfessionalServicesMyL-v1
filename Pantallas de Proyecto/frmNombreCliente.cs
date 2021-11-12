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
    public partial class frmNombreCliente : Form
    {
        clsConexion conexion = new clsConexion();
        SqlCommand cmd;
        public frmNombreCliente()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenuBasesExternas frmMBE = new frmMenuBasesExternas();
            frmMBE.Show();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbBuscar.SelectedIndex == 0)
            {
                try
                {
                    cmd = new SqlCommand("SELECT de.nombre, de.id, de.correo, di.cod_direccion, di.combre_colonia, de.telefono_1, de.telefono_2 " +
                        " FROM Deudores de JOIN DIrecciones di  ON de.cod_deudor = di.cod_direccion WHERE nombre = '" + txtBuscar.Text + "' ", conexion.sc);
                    cmd.ExecuteNonQuery();
                    conexion.CargarDatosSeguroSocial(dgvSeguroSocial);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("SELECT de.nombre, de.id, de.correo, di.cod_direccion, di.combre_colonia, de.telefono_1, de.telefono_2 " +
                        " FROM Deudores de JOIN DIrecciones di  ON de.cod_deudor = di.cod_direccion WHERE id = '" + txtBuscar.Text + "' ", conexion.sc);
                    cmd.ExecuteNonQuery();
                    conexion.CargarDatosSeguroSocial(dgvSeguroSocial);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }

        private void frmNombreCliente_Load(object sender, EventArgs e)
        {
            conexion.abrir();
            conexion.CargarDatosSeguroSocial(dgvSeguroSocial);
        }
    }
}
