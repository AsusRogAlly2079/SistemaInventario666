using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaInventarioColchones.Controlador;

namespace SistemaInventarioColchones.Persistencia
{
    public partial class ProveedoresUsuario: Form
    {
        private string rolUsuario;
        public ProveedoresUsuario(string rol)
        {
            InitializeComponent();
            rolUsuario = rol;

            // Bloquea el botón de usuarios aquí:
            if (rolUsuario != "administrador")
            {
                btnUsuarios.Enabled = false;
                btnUsuarios.Text = "Bloqueado";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estás seguro que deseas cerrar sesión?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Login frm = new Login();
                frm.Show();
                this.Hide();

            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir de la aplicación?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosUsuarios frm = new UsuariosUsuarios();  
            frm.Show();
            this.Hide();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ProductosUsuario frm = new ProductosUsuario("vendedor");
            frm.Show();
            this.Hide();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ProveedoresUsuario frm = new ProveedoresUsuario("vendedor");
            frm .Show();
            this.Hide ();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            InicioUsuario frm = new InicioUsuario("vendedor");
            frm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
