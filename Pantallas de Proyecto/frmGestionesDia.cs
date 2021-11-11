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
    public partial class frmGestionesDia : Form
    {
        public frmGestionesDia()
        {
            InitializeComponent();
        }

        clsConexion conexion = new clsConexion();
        SqlCommand cmd;
        private void Form16_Load(object sender, EventArgs e)
        {
            conexion.abrir();
            conexion.mostrarDatosGestionesDia(dgvGestionesDia);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMenu frmM = new frmMenu();
            frmM.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGestiones frmGestion = new frmGestiones();
            frmGestion.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           if(cmbBusqueda.SelectedIndex == 0)
            {
                try
                {
                    cmd = new SqlCommand("SELECT cod_deudor, nombre, id , fecha_atraso, capital, saldo_mora, intereses, deuda_total, Descuento " +
                        "FROM Deudores WHERE cod_deudor = '"+txtBuscar.Text+"' ", conexion.sc);
                    cmd.ExecuteNonQuery();
                    conexion.mostrarDatosGestionesDia(dgvGestionesDia);

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            else if(cmbBusqueda.SelectedIndex == 1)
            {
                cmd = new SqlCommand("SELECT cod_deudor, nombre, id , fecha_atraso, capital, saldo_mora, intereses, deuda_total, Descuento " +
                        "FROM Deudores WHERE nombre = '" + txtBuscar.Text + "' ", conexion.sc);
                cmd.ExecuteNonQuery();
                conexion.mostrarDatosGestionesDia(dgvGestionesDia);
            }

           else if(cmbBusqueda.SelectedIndex == 2)
            {
                cmd = new SqlCommand("SELECT cod_deudor, nombre, id , fecha_atraso, capital, saldo_mora, intereses, deuda_total, Descuento " +
                    "FROM Deudores WHERE ID = '" + txtBuscar.Text + "' ", conexion.sc);
                cmd.ExecuteNonQuery();
                conexion.mostrarDatosGestionesDia(dgvGestionesDia);
            }

            else
            {
                cmd = new SqlCommand("SELECT cod_deudor, nombre, id , fecha_atraso, capital, saldo_mora, intereses, deuda_total, Descuento " +
                    "FROM Deudores WHERE telefono_1 = '" + txtBuscar.Text + "' OR telefono_2 = '" + txtBuscar.Text + "' OR  telefono_3 = '" + txtBuscar.Text + "' ", conexion.sc);
                cmd.ExecuteNonQuery();
                conexion.mostrarDatosGestionesDia(dgvGestionesDia);
            }
        }
    }
}
