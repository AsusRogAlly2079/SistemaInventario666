using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventarioColchones.Persistencia
{
    public partial class Productos: Form
    {
        public Productos()
        {
            InitializeComponent();
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

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir de la aplicación?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void adminProductos1_Load(object sender, EventArgs e)
        {

        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
