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
    public partial class frmListaEmpresas : Form
    {
        clsConexion conexion = new clsConexion();
        SqlCommand cmd;
        public frmListaEmpresas()
        {
            InitializeComponent();
        }

        
        private void btnNuevaEmpresa_Click(object sender, EventArgs e)
        {
           
           try
            {
                if(txtCodContacto.Text == "" || txtNombreEmpresa.Text == "" || txtNota.Text == "" || txtTelefono.Text == "")
                {
                    MessageBox.Show("ERROR, LLENE TODOS LOS CAMPOS PARA AGREGAR ", "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO Contactos (cod_contacto, nombre , telefono, nota ) VALUES ('" + txtCodContacto.Text + "' , '" + txtNombreEmpresa.Text + "' , '" + txtTelefono.Text + "' , '" + txtNota.Text + "')", conexion.sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se han ingresado los Datos con Exito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.cargarDatosListaEmpresas(dgvListaEmpresasG);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        

        
        private void btnEditarEmpresa_Click(object sender, EventArgs e)
        {
           try
            {
                if (txtCodContacto.Text == "" || txtNombreEmpresa.Text == "" || txtTelefono.Text == "" || txtNota.Text == "")
                {
                    MessageBox.Show("ERROR, POR FAVOR LLENE TODOS LOS CAMPOS PARA MODIFICAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    cmd = new SqlCommand("UPDATE Contactos SET nombre = '" + txtNombreEmpresa.Text + "' , telefono = '" + txtTelefono.Text + "' ," +
                        " nota = '" + txtNota.Text + "' WHERE cod_contacto = '" + txtCodContacto.Text + "' ", conexion.sc);
                    MessageBox.Show("Se han actualizado los Datos con Exito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.ExecuteNonQuery();
                    conexion.cargarDatosListaEmpresas(dgvListaEmpresasG);
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenuBasesExternas frmMBE= new frmMenuBasesExternas();
            frmMBE.Show();
            this.Close();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCodContacto.Text == "" || txtCodContacto.Text == " " || txtCodContacto.Text == "  " || txtCodContacto.Text == "   ")
                {
                    MessageBox.Show("POR FAVOR INGRESE EL CODIGO DEL CONTACTO PARA BUSSCAR", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM Contactos WHERE cod_contacto = '" + txtCodContacto.Text + "' ", conexion.sc);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetValue(0).ToString());
                            txtNombreEmpresa.Text = reader.GetValue(1).ToString();
                            txtTelefono.Text = reader.GetValue(2).ToString();
                            txtNota.Text = reader.GetValue(3).ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El codigo del empelado no existe", "ERROR");
                    }

                    reader.Close();
                }


            }catch (Exception ex)
            {
                MessageBox.Show("ERROR NO SE PUEDEN CARGAR LOS DATOS" + ex, "ERROR");
            }

        }

        private void frmListaEmpresas_Load(object sender, EventArgs e)
        {
            conexion.abrir();
            conexion.cargarDatosListaEmpresas(dgvListaEmpresasG);
            txtBuscar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable dt;


            if (cmbBuscar.SelectedIndex == 0)
            {
                try
                {
                    if(txtBuscar.Text == "" || txtBuscar.Text == " " || txtBuscar.Text == "  " || txtBuscar.Text == "   ")
                    {
                        MessageBox.Show("No se puede buscar, datos en blanco ", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                    {
                        da = new SqlDataAdapter("SELECT cod_contacto, nombre, telefono, nota" +
                        " FROM Contactos WHERE nombre = '" + txtBuscar.Text + "' ", conexion.sc);
                        dt = new DataTable();
                        da.Fill(dt);
                        dgvListaEmpresasG.DataSource = dt;
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if(cmbBuscar.SelectedIndex == 1)
            {
                try
                {
                    if (txtBuscar.Text == "" || txtBuscar.Text == " " || txtBuscar.Text == "  " || txtBuscar.Text == "   ")
                    {
                        MessageBox.Show("No se puede buscar, datos en blanco ", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                    {
                        da = new SqlDataAdapter("SELECT cod_contacto, nombre, telefono, nota" +
                        " FROM Contactos WHERE nombre = '" + txtBuscar.Text + "' ", conexion.sc);
                        dt = new DataTable();
                        da.Fill(dt);
                        dgvListaEmpresasG.DataSource = dt;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if(txtCodContacto.Text == "" || txtNombreEmpresa.Text == "" || txtTelefono.Text == "" || txtNota.Text == "")
            {
                MessageBox.Show("NO HAY DATOS QUE LIMPIAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodContacto.Clear();
                txtNombreEmpresa.Clear();
                txtTelefono.Clear();
                txtNota.Clear();

                txtCodContacto.Focus();
            }
        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbBuscar.SelectedIndex == -1)
            {
                txtBuscar.Enabled = false;
            }
            else
            {
                txtBuscar.Enabled = true;
            }
        }
    }
}
