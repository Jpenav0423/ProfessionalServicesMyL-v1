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
        string conexion = "Data Source=DESKTOP-L6PQCB1;Initial Catalog=Prueba;Integrated Security=true;";

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


    }
}
