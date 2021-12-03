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

            txtBuscar.Enabled = false;
  
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

            SqlDataAdapter da;
            DataTable dt;

            if (cmbBusqueda.SelectedIndex == 0)
            {
                try
                {
                    if (txtBuscar.Text == "" || txtBuscar.Text == " " || txtBuscar.Text == "   ") 
                    {
                       
                        MessageBox.Show("Por favor ingrese datos para buscar");
                    }
                    else
                    {
                        da = new SqlDataAdapter("SELECT cod_deudor, nombre, id , fecha_atraso, capital, saldo_mora, intereses, deuda_total, Descuento " +
                        "FROM Deudores WHERE cod_deudor = '" + txtBuscar.Text + "' ", conexion.sc);
                        dt = new DataTable();
                        da.Fill(dt);
                        dgvGestionesDia.DataSource = dt;
                    }
                    

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            else if(cmbBusqueda.SelectedIndex == 1)
            {
                if (txtBuscar.Text == "" || txtBuscar.Text == " " || txtBuscar.Text == "   ")
                {
                    MessageBox.Show("Por favor ingrese datos para buscar");
                }
                else
                {
                    da = new SqlDataAdapter("SELECT cod_deudor, nombre, id , fecha_atraso, capital, saldo_mora, intereses, deuda_total, Descuento " +
                    "FROM Deudores WHERE cod_deudor = '" + txtBuscar.Text + "' ", conexion.sc);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgvGestionesDia.DataSource = dt;
                }
            }

           else if(cmbBusqueda.SelectedIndex == 2)
            {
                if (txtBuscar.Text == "" || txtBuscar.Text == " " || txtBuscar.Text == "   ")
                {
                    MessageBox.Show("Por favor ingrese datos para buscar");
                }
                else
                {
                    da = new SqlDataAdapter("SELECT cod_deudor, nombre, id , fecha_atraso, capital, saldo_mora, intereses, deuda_total, Descuento " +
                    "FROM Deudores WHERE cod_deudor = '" + txtBuscar.Text + "' ", conexion.sc);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgvGestionesDia.DataSource = dt;
                }
            }

            else
            {
                if (txtBuscar.Text == "" || txtBuscar.Text == " " || txtBuscar.Text == "   ")
                {
                    MessageBox.Show("Por favor ingrese datos para buscar");
                }
                else
                {
                    da = new SqlDataAdapter("SELECT cod_deudor, nombre, id , fecha_atraso, capital, saldo_mora, intereses, deuda_total, Descuento " +
                    "FROM Deudores WHERE cod_deudor = '" + txtBuscar.Text + "' ", conexion.sc);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgvGestionesDia.DataSource = dt;
                }
            }
        }

        private void cmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbBusqueda.SelectedIndex == -1)
            { 
                txtBuscar.Enabled = false;
                    
            }else
            {
                txtBuscar.Enabled = true;
            }
        }
    }
}
