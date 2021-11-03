using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Pantallas_de_Proyecto
{
    class clsConexion
    {
        SqlDataAdapter da;
        DataTable dt;
        

        //Conexion a la base de datos
        string conexion = "Data Source=DESKTOP-6PP0TCF;Initial Catalog=Prueba;Integrated Security=true;";

        public SqlConnection sc = new SqlConnection();

        public clsConexion()
        {
            sc.ConnectionString = conexion;
        }

        public void abrir()
        {
            try
            {
                sc.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al abrir la base de datos " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cerrar()
        {
            sc.Close();
        }

        public void logear(string usuario, string contrasena)
        {
            try
            {
                sc.Open();
                SqlCommand cmd = new SqlCommand("SELECT tipo_usuario FROM Usuarios WHERE usuario = @usuario AND contrasena = @contrasena", sc);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("contrasena", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count == 1)
                {
                    superClase inicio = new superClase();
                    frmInicio login = new frmInicio();
                    frmMenu menu = new frmMenu();
                    inicio.InicioExitoso = 0;

                    if (dt.Rows[0][0].ToString() == "Administrador")
                    {
                        MessageBox.Show("Se ha abierto usuario de administrador");
                        inicio.Administrador = 1;
                        inicio.InicioExitoso = 1;
                        menu.Show();
                    }
                    else
                    {
                        if (dt.Rows[0][0].ToString() == "Gestor")
                        {
                            MessageBox.Show("Se ha abierto usuario de Gestor");
                            inicio.Gestor = 0;
                            inicio.InicioExitoso = 1;
                            menu.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o contrasenas incorrecto");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sc.Close();
            }
        }


        //funcionesCargarOtrosDatos

    }
}
