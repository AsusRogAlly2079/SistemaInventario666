using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventarioColchones.Persistencia
{
    public partial class Registrar : Form
    {
        MySqlConnection con = new MySqlConnection("Server=bed32989.mysql.database.azure.com;Database=sistema_comercial;Uid=parradosamuel35;Pwd=RTX2080TIxz$;SslMode=Required;");

        public Registrar()
        {
            InitializeComponent();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que deseas salir de la aplicación?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtContraseña.Text == "" || txtConfirmar.Text == "")
            {
                MessageBox.Show("Por favor llena todos los campos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ConfirmarCon())
                {
                    try
                    {
                        con.Open();

                        string consultar = "SELECT * FROM Usuario WHERE Nombre = @nom";
                        using (var cmd = new MySqlCommand(consultar, con))
                        {
                            cmd.Parameters.AddWithValue("@nom", txtUsuario.Text.Trim());
                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            DataTable tabla = new DataTable();
                            adapter.Fill(tabla);

                            if (tabla.Rows.Count > 0)
                            {
                                MessageBox.Show(txtUsuario.Text.Trim() + " ya está registrado.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (txtContraseña.Text.Length < 8)
                            {
                                MessageBox.Show("Contraseña incorrecta, mínimo 8 caracteres.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (txtContraseña.Text.Trim() != txtConfirmar.Text.Trim())
                            {
                                MessageBox.Show("La contraseña no coincide.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertar = "INSERT INTO Usuario (Nombre, Contraseña, Rol, Fecha_Creacion) VALUES (@nom, @pas, @rol, @fecha)";
                                using (var insert = new MySqlCommand(insertar, con))
                                {
                                    insert.Parameters.AddWithValue("@nom", txtUsuario.Text.Trim());
                                    insert.Parameters.AddWithValue("@pas", txtContraseña.Text.Trim());
                                    insert.Parameters.AddWithValue("@rol", "Vendedor");
                                    DateTime today = DateTime.Now;
                                    insert.Parameters.AddWithValue("@fecha", today);
                                    insert.ExecuteNonQuery();

                                    MessageBox.Show("Registrado exitosamente.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Login frm = new Login();
                                    frm.Show();
                                    this.Hide();
                                }
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
        }

        public bool ConfirmarCon()
        {
            return con.State == ConnectionState.Closed;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = checkBox1.Checked ? '\0' : '*';
            txtConfirmar.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void label5_Click(object sender, EventArgs e) { }

        private void label6_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }
    }
}
