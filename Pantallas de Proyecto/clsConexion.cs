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
        string conexion = "Data Source=DESKTOP-6PP0TCF;Initial Catalog=Prueba_MyL;Integrated Security=true;";

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

        
        public void logear(string usuario, string contra)
        {
            try
            {
                sc.Open();
                SqlCommand cmd = new SqlCommand("SELECT nivel FROM Usuario WHERE usuario = @usuario AND contra = @contra", sc);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("contra", contra);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count == 1)
                {
                    superClase inicio = new superClase();
                    frmInicio login = new frmInicio();
                    frmMenu menu = new frmMenu();
                    inicio.InicioExitoso = 0;

                    if (dt.Rows[0][0].ToString() == "admin")
                    {
                        MessageBox.Show("Se ha abierto usuario de administrador");
                        inicio.Administrador = 1;
                        inicio.InicioExitoso = 1;
                        menu.Show();
                    }
                    else
                    {
                        if (dt.Rows[0][0].ToString() == "gestor")
                        {
                            MessageBox.Show("Se ha abierto usuario de Gestor");
                            inicio.Gestor = 0;
                            inicio.InicioExitoso = 1;
                            menu.Show();
                        }
                        else
                        {
                            if(dt.Rows[0][0].ToString() == "superv")
                            {
                                MessageBox.Show("Se ha abierto usuario de supervisor");
                                inicio.Supervisor = 0;
                                inicio.InicioExitoso = 1;
                                menu.Show();
                            }
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



        public void CargarDatosUsuarios(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Usuario", sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void CargarDatosGestiones()
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM deudores", sc);
                dt = new DataTable();
                da.Fill(dt);
                IDataReader read;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos " + ex, "ERROR", MessageBoxButtons.OK);

            }
        }

        public void cargarDatosListaEmpresas(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Contactos", sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos " + ex, "ERROR", MessageBoxButtons.OK);
            }
        }
        

        public void cargarDatosSeguimientos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT se.fecha, ge.fecha_final, se.cod_gestion,se.descripcion, ge.cod_empleado, se.cod_empleado_f " +
                    "FROM gestiones ge JOIN Seguimiento se ON se.cod_gestion=ge.cod_gestion  WHERE ge.cod_deudor = 1",sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos " + ex, "ERROR", MessageBoxButtons.OK);
            }
        }

        public void cargarDatosSeguro()
        {
            //Incompleta
        }



        public void mostrarCaracterizaciones(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM clientes", sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos " + ex, "ERROR", MessageBoxButtons.OK);
            }

        }

        public void mostrarDatosGestionesDia(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT cod_deudor, nombre, id, fecha_atraso, capital, saldo_mora, intereses, deuda_total, Descuento " +
                    " FROM Deudores", sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos " + ex, "ERROR", MessageBoxButtons.OK);
            }
        }
        
        public void cargarDatosReportes(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT de.cod_deudor, de.nombre, de.id, se.fecha, se.descripcion " +
                    "FROM Deudores de join Seguimiento se ON de.cod_deudor = se.cod_seguimiento WHERE cod_deudor = 1", sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos " + ex, "ERROR", MessageBoxButtons.OK);
            }
        }
        
        public string mostarDatoGestiones()
        {

                string query = "SELECT cod_deudor, nombre, id, RTN , telefono_1, telefono_2, correo, cod_direccion, prestamo , fecha_pago, " +
                 "deuda_total, fecha_ultimo_pago, fecha_atraso" +
                    " FROM Deudores Order By cod_deudor ";

                SqlCommand cmd = new SqlCommand(query);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return reader["cod_deudor, nombre, id, RTN, telefono_1 , telefono_2, cod_direccion, prestamo," +
                       " fecha_pago, deuda_total, fecha_ultimo_pago, fecha_atraso "].ToString();
                }
                else
                {
                return (nul"");
                }




        }

        public void cargarDatosReferecnias(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT av.cod_aval, av.nom_aval, av.telefono, av.correo, de.cod_deudor " +
                    " FROM Aval av join Deudores de ON av.cod_aval = de.cod_deudor WHERE cod_deudor = 1 ORDER BY cod_deudor ",sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos " + ex, "ERROR", MessageBoxButtons.OK);
            }

        }
        



        
        
    }
}
