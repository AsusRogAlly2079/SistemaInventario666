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
using System.Security.Cryptography;


namespace SistemaInventarioColchones.Persistencia
{
    public partial class Usuarios: Form
    {
        SqlConnection
        con = new SqlConnection(@"Server=DESKTOP-TR972KR;Database=Bedware_;User Id=sa;Password=daniel1234;TrustServerCertificate=True");

        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Agregar_Click(object sender, EventArgs e)
        {
   
        }
        //543
        //574
        public bool ConfirmarCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtUsuarios_Usuarios_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Inicio frm = new Inicio();  
            frm.Show();
            this.Hide();


        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios frm = new Usuarios();
            frm.Show();
            this.Hide();
           
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos frm = new Productos();
            frm.Show();
            this.Hide();

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores frm = new Proveedores();
            frm.Show();
            this.Hide();

        }

        private void adminUsuarios1_Load(object sender, EventArgs e)
        {

        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir de la aplicación?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro que deseas cerrar sesión?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Login frm = new Login();
                frm.Show();
                this.Hide();

            }
        }

        private void adminUsuarios1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
