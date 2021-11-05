using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_de_Proyecto
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        clsConexion conexion = new clsConexion();
        superClase inicio = new superClase();
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            conexion.logear(this.txtUsuario.Text, this.txtPassword.Text);

            if(inicio.InicioExitoso == 1)
            {
                this.Hide();
            }
            

           // frmInicio login = new frmInicio();
            //frmMenu menu = new frmMenu();
           // menu.Show();
            //this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
