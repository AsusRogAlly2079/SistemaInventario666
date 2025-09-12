using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaInventarioColchones.Persistencia
{
    public partial class Registrar: Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-TR972KR;Database=Bedware_;User Id=sa;Password=daniel1234;TrustServerCertificate=True");
        public Registrar()
        {
            InitializeComponent();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir de la aplicación?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "" || txtContraseña.Text == "" || txtConfirmar.Text == "")
            {
              MessageBox.Show("Por favor llena todos los campos", "Error Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ConfirmarCon())
                {
                    try
                    {
                        con.Open();

                        string consultar = "Select * from Usuario where Nombre=  '@nom'";
                        using (SqlCommand cmd = new SqlCommand(consultar,con))
                        {
                            cmd.Parameters.AddWithValue("@nom", txtUsuario.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable tabla = new DataTable();
                            adapter.Fill(tabla);
                            if (tabla.Rows.Count > 0)
                            {
                                MessageBox.Show(txtUsuario.Text.Trim() + "Ya esta lleno", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else if (txtContraseña.Text.Length < 8)
                            {
                                MessageBox.Show("Contraseña Incorrecta, minimo 8 caracteres", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else if (txtContraseña.Text.Trim() != txtConfirmar.Text.Trim())
                            {
                                MessageBox.Show("La contraseña no coincide", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertar = "Insert into Usuario (Nombre, Contrasena, Rol, Fecha_Creacion) values (@nom, @pas, @rol,@fecha)";
                                using (SqlCommand insert = new SqlCommand(insertar, con))
                                {
                                    insert.Parameters.AddWithValue("@nom", txtUsuario.Text.Trim());
                                    insert.Parameters.AddWithValue("@pas", txtContraseña.Text.Trim());
                                    insert.Parameters.AddWithValue("@rol", "Vendedor");

                                    DateTime today = DateTime.Now;
                                    insert.Parameters.AddWithValue("@fecha", today);
                                    insert.ExecuteNonQuery();

                                    MessageBox.Show("Registrado Exitosamente", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Login frm = new Login();
                                    frm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Conexion Fallida"+ex,"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            if(con.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = checkBox1.Checked ? '\0' : '*';
            txtConfirmar.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login frm = new Login();   
            frm.Show();
            this.Hide();
        }
    }
}
