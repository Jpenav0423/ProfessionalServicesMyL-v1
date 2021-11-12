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
    class superClase
    {
        clsConexion conexion = new clsConexion();

        public static int administrador = 0;
        public static int gestor = 0;
        public static int supervisor = 0;
        public static int inicioExitoso = 0;

        public int Administrador { get => administrador; set => administrador = value;  }
        public int Gestor { get => gestor; set => gestor = value; }
        public int Supervisor { get => supervisor; set => supervisor = value; }
        public int InicioExitoso { get => inicioExitoso; set => inicioExitoso = value;  }

        public string mostarDatoGestiones()
        {
            conexion.abrir();
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
                return ("NULL");

            }
            conexion.cerrar();
        }

        /*
        public string MostrarDatosSeguroSeguimiento()
        {
            conexion.abrir();
            string query =   
        }
        */
    }


}
