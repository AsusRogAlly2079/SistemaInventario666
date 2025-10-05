using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SistemaInventarioColchones.Controlador;
using MySql.Data.MySqlClient;

namespace SistemaInventarioColchones.Persistencia
{
    public partial class AdminUsuarios : UserControl
    {

        public AdminUsuarios()
        {
            InitializeComponent();
            infoUsers();
        }

        MySqlConnection con = new MySqlConnection("Server=bed32989.mysql.database.azure.com;Database=sistema_comercial;Uid=parradosamuel35;Pwd=RTX2080TIxz$;SslMode=Required;");

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
                MessageBox.Show("Los campos están vacíos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ConfirmarCon())
                {
                    try
                    {
                        con.Open();
                        string query = "SELECT * FROM Usuario WHERE Nombre = @nom";
                        using (var cmd = new MySqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@nom", txtUsuarios_Usuarios.Text.Trim());

                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(txtUsuarios_Usuarios.Text + " ,el usuario ya está creado", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertar = "INSERT INTO Usuario (Nombre,Contraseña,Rol,Fecha_Creacion) VALUES " +
                                    "(@nom,@pas,@rol,@fecha)";

                                using (var insert = new MySqlCommand(insertar, con))
                                {
                                    insert.Parameters.AddWithValue("@nom", txtUsuarios_Usuarios.Text.Trim());
                                    insert.Parameters.AddWithValue("@pas", txtContraseña_Usuarios.Text.Trim());
                                    insert.Parameters.AddWithValue("@rol", cmbUsuarios_Usuarios.SelectedItem.ToString());
                                    insert.Parameters.AddWithValue("@fecha", DateTime.Now);

                                    insert.ExecuteNonQuery();
                                    LimpiarCampos();
                                    infoUsers();
                                    MessageBox.Show("Usuario registrado exitosamente", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnUsuario_Modificar_Click(object sender, EventArgs e)
        {
            if (txtUsuarios_Usuarios.Text == "" || txtContraseña_Usuarios.Text == "" || cmbUsuarios_Usuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Los campos están vacíos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que deseas modificar el Usuario " + getId + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ConfirmarCon())
                    {
                        try
                        {
                            con.Open();
                            string update = "UPDATE Usuario SET Nombre=@nom,Contraseña=@pas,Rol=@rol WHERE Usuario_id=@id";

                            using (var updateD = new MySqlCommand(update, con))
                            {
                                updateD.Parameters.AddWithValue("@nom", txtUsuarios_Usuarios.Text.Trim());
                                updateD.Parameters.AddWithValue("@pas", txtContraseña_Usuarios.Text.Trim());
                                updateD.Parameters.AddWithValue("@rol", cmbUsuarios_Usuarios.SelectedItem.ToString());
                                updateD.Parameters.AddWithValue("@id", getId);
                                updateD.ExecuteNonQuery();
                                LimpiarCampos();
                                infoUsers();
                                MessageBox.Show("Usuario modificado exitosamente", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void btnUsuario_Eliminar_Click(object sender, EventArgs e)
        {
            if (txtUsuarios_Usuarios.Text == "" || txtContraseña_Usuarios.Text == "" || cmbUsuarios_Usuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Los campos están vacíos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que deseas eliminar el Usuario " + getId + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ConfirmarCon())
                    {
                        try
                        {
                            con.Open();
                            string delete = "DELETE FROM Usuario WHERE Usuario_id=@id";

                            using (var deleteD = new MySqlCommand(delete, con))
                            {
                                deleteD.Parameters.AddWithValue("@id", getId);
                                deleteD.ExecuteNonQuery();
                                LimpiarCampos();
                                infoUsers();
                                MessageBox.Show("Usuario eliminado exitosamente", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
