using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaInventarioColchones.Controlador;

namespace SistemaInventarioColchones.Persistencia
{
    public partial class AdminUsuarios : UserControl
    {

        public AdminUsuarios()
        {
            InitializeComponent();
            infoUsers();
        }


        SqlConnection
        con = new SqlConnection(@"Server=DESKTOP-TR972KR;Database=Bedware_;User Id=sa;Password=daniel1234;TrustServerCertificate=True");

        public void infoUsers()
        {
            UsuariosInfo infoo = new UsuariosInfo();
            List<UsuariosInfo> listData = infoo.Usuarios();

            dataGridView1.DataSource = listData;

        }

        private void AdminUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Agregar_Click(object sender, EventArgs e)
        {
            if (txtUsuarios_Usuarios.Text == "" || txtContraseña_Usuarios.Text == "" || cmbUsuarios_Usuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Los campos estan vacíos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ConfirmarCon())
                {
                    try
                    {
                        con.Open();
                        string query = "Select * from Usuario where Nombre = @nom";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@nom", txtUsuarios_Usuarios.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(txtUsuarios_Usuarios.Text + " ,el usuario ya esta creado", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertar = "Insert into Usuario (Nombre,Contrasena,Rol,Fecha_Creacion) values " +
                                    "(@nom,@pas,@rol,@fecha)";

                                using (SqlCommand insert = new SqlCommand(insertar, con))
                                {
                                    insert.Parameters.AddWithValue("@nom", txtUsuarios_Usuarios.Text.Trim());
                                    insert.Parameters.AddWithValue("@pas", txtContraseña_Usuarios.Text.Trim());
                                    insert.Parameters.AddWithValue("@rol", cmbUsuarios_Usuarios.SelectedItem.ToString());
                                    insert.Parameters.AddWithValue("@fecha",DateTime.Now);
                                    insert.ExecuteNonQuery();
                                    LimpiarCampos();
                                    infoUsers();
                                    MessageBox.Show("Usuario registrado Exitosamente", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Conexión Fállida", "Error Message"+ex, MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            if (con.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LimpiarCampos()
        {

            txtUsuarios_Usuarios.Text = "";
            txtContraseña_Usuarios.Text = "";
            cmbUsuarios_Usuarios.SelectedIndex = -1;
        }
        private void btnUsuario_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnUsuario_Modificar_Click(object sender, EventArgs e)
        {

            if (txtUsuarios_Usuarios.Text == "" || txtContraseña_Usuarios.Text == "" || cmbUsuarios_Usuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Los campos estan vacíos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (MessageBox.Show("Seguro que deseas modificar el Usuario" + getId + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ConfirmarCon())
                    {
                        try
                        {
                            con.Open();

                            string update = "Update Usuario set Nombre=@nom,Contrasena=@pas,Rol=@rol where Usuario_id= @id";


                            using (SqlCommand updateD = new SqlCommand(update, con))
                            {
                                updateD.Parameters.AddWithValue("@nom", txtUsuarios_Usuarios.Text.Trim());
                                updateD.Parameters.AddWithValue("@pas", txtContraseña_Usuarios.Text.Trim());
                                updateD.Parameters.AddWithValue("@rol", cmbUsuarios_Usuarios.SelectedItem);
                                updateD.Parameters.AddWithValue("id", getId);
                                updateD.ExecuteNonQuery();
                                LimpiarCampos();
                                infoUsers();
                                MessageBox.Show("Usuario modificado exitosamente", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }



                        catch (Exception ex)
                        {

                            MessageBox.Show("Conexión Fállida"+ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {

                            con.Close();
                        }
                    }
                }

            }
        }

           private int getId = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Verificar y obtener el valor de la primera celda (Usuario_id)
                if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out getId))
                {
                    // El valor se pudo convertir a int correctamente
                }
                else
                {
                    // El valor de la primera celda no se pudo convertir a int
                    // Manejar el error adecuadamente, por ejemplo, mostrando un mensaje de error
                    MessageBox.Show("El valor de la primera celda no es un número entero válido.");
                    return;
                }

                string Nombre = row.Cells[1].Value.ToString();
                string Contrasena = row.Cells[2].Value.ToString();
                string Rol = row.Cells[3].Value.ToString();

                txtUsuarios_Usuarios.Text = Nombre;
                txtContraseña_Usuarios.Text = Contrasena;
                cmbUsuarios_Usuarios.Text = Rol;
            }
        }

        private void btnUsuario_Eliminar_Click(object sender, EventArgs e)
        {
            if (txtUsuarios_Usuarios.Text == "" || txtContraseña_Usuarios.Text == "" || cmbUsuarios_Usuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Los campos estan vacíos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (MessageBox.Show("Seguro que deseas eliminar el Usuario" + getId + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ConfirmarCon())
                    {
                        try
                        {
                            con.Open();

                            string delete = "Delete from Usuario where Usuario_id= @id";


                            using (SqlCommand deleteD = new SqlCommand(delete, con))
                            {
                                
                                deleteD.Parameters.AddWithValue("id", getId);
                                deleteD.ExecuteNonQuery();
                                LimpiarCampos();
                                infoUsers();
                                MessageBox.Show("Usuario eliminado exitosamente", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }



                        catch (Exception ex)
                        {

                            MessageBox.Show("Conexión Fállida" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {

                            con.Close();
                        }
                    }
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
