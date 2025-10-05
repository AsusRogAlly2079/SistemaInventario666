using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaInventarioColchones.Persistencia;
using MySql.Data.MySqlClient;

namespace SistemaInventarioColchones
{
    public partial class Login : Form
    {
        string Usuarioventa;

        MySqlConnection con = new MySqlConnection("Server=bed32989.mysql.database.azure.com;Database=sistema_comercial;Uid=parradosamuel35;Pwd=RTX2080TIxz$;SslMode=Required;");

        public Login()
        {
            InitializeComponent();
        }

        public Login(string usuarioventa)
        {
            Usuarioventa = usuarioventa;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que deseas salir de la aplicación?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        public bool ConfirmarCon()
        {
            return con.State == ConnectionState.Closed;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ConfirmarCon())
            {
                try
                {
                    con.Open();

                    string select = "SELECT * FROM Usuario WHERE Nombre = @nom AND Contraseña = @pas";
                    using (var cmd = new MySqlCommand(select, con))
                    {
                        cmd.Parameters.AddWithValue("@nom", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@pas", txtContraseña.Text.Trim());
                        Usuarioventa = txtUsername.Text;

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable tabla = new DataTable();
                        adapter.Fill(tabla);

                        if (tabla.Rows.Count > 0)
                        {
                            string rol = tabla.Rows[0]["Rol"].ToString(); // Obtenemos el rol del usuario

                            MessageBox.Show("Se inició sesión correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (rol == "administrador")
                            {
                                Inicio frm = new Inicio(); // Formulario para admin
                                frm.Show();
                                this.Hide();
                            }
                            else if (rol == "vendedor")
                            {
                                InicioUsuario frm = new InicioUsuario(); // Formulario para vendedor
                                frm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Rol de usuario no reconocido: " + rol, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña inválida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Conexión Fallida: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar frm = new Registrar();
            frm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
