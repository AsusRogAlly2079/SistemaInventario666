using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaInventarioColchones.Controlador;
using MySql.Data.MySqlClient;

namespace SistemaInventarioColchones
{
    public partial class AdminProveedor : UserControl
    {
        public AdminProveedor()
        {
            InitializeComponent();
            infoProveedores();
        }

        MySqlConnection con = new MySqlConnection("Server=bed32989.mysql.database.azure.com;Database=sistema_comercial;Uid=parradosamuel35;Pwd=RTX2080TIxz$;SslMode=Required;");

        public void infoProveedores()
        {
            ProveedoresInfo infoo = new ProveedoresInfo();
            List<ProveedoresInfo> listData = infoo.Proveedores();
            dataGridView1.DataSource = listData;
        }

        private void button1_Click(object sender, EventArgs e) { }
        private void txtUsuarios_Usuarios_TextChanged(object sender, EventArgs e) { }

        private void btnUsuario_Agregar_Click(object sender, EventArgs e)
        {
            if (txtNombre_Proveedor.Text == "" || txtNit_Proveedor.Text == "" || txtTelefono_Proveedor.Text == "" || txtDireccion_Proveedor.Text == "")
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
                        string query = "SELECT * FROM Proveedor WHERE Nombre = @nom";
                        using (var cmd = new MySqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@nom", txtNombre_Proveedor.Text.Trim());

                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(txtNombre_Proveedor.Text + " El proveedor ya está creado", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertar = "INSERT INTO Proveedor (Nombre, NIT, Telefono, Direccion, Fecha_Registro) VALUES " +
                                    "(@nom, @nit, @tel, @dir, @fecha)";

                                using (var insert = new MySqlCommand(insertar, con))
                                {
                                    insert.Parameters.AddWithValue("@nom", txtNombre_Proveedor.Text.Trim());
                                    insert.Parameters.AddWithValue("@nit", txtNit_Proveedor.Text.Trim());
                                    insert.Parameters.AddWithValue("@tel", txtTelefono_Proveedor.Text.Trim());
                                    insert.Parameters.AddWithValue("@dir", txtDireccion_Proveedor.Text.Trim());
                                    insert.Parameters.AddWithValue("@fecha", DateTime.Now);

                                    insert.ExecuteNonQuery();
                                    LimpiarCampos();
                                    infoProveedores();
                                    MessageBox.Show("Proveedor registrado exitosamente", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtNombre_Proveedor.Text = "";
            txtNit_Proveedor.Text = "";
            txtTelefono_Proveedor.Text = "";
            txtDireccion_Proveedor.Text = "";
        }

        private void btnUsuario_Modificar_Click(object sender, EventArgs e)
        {
            if (txtNombre_Proveedor.Text == "" || txtNit_Proveedor.Text == "" || txtTelefono_Proveedor.Text == "" || txtDireccion_Proveedor.Text == "")
            {
                MessageBox.Show("Los campos están vacíos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que deseas modificar el Proveedor " + getId + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ConfirmarCon())
                    {
                        try
                        {
                            con.Open();

                            string update = "UPDATE Proveedor SET Nombre=@nom, NIT=@nit, Telefono=@tel, Direccion=@dir WHERE Proveedor_Id=@id";

                            using (var updateD = new MySqlCommand(update, con))
                            {
                                updateD.Parameters.AddWithValue("@nom", txtNombre_Proveedor.Text.Trim());
                                updateD.Parameters.AddWithValue("@nit", txtNit_Proveedor.Text.Trim());
                                updateD.Parameters.AddWithValue("@tel", txtTelefono_Proveedor.Text.Trim());
                                updateD.Parameters.AddWithValue("@dir", txtDireccion_Proveedor.Text.Trim());
                                updateD.Parameters.AddWithValue("@id", getId);
                                updateD.ExecuteNonQuery();
                                LimpiarCampos();
                                infoProveedores();
                                MessageBox.Show("Proveedor modificado exitosamente", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtNombre_Proveedor.Text == "" || txtNit_Proveedor.Text == "" || txtTelefono_Proveedor.Text == "" || txtDireccion_Proveedor.Text == "")
            {
                MessageBox.Show("Los campos están vacíos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que deseas eliminar el Proveedor " + getId + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ConfirmarCon())
                    {
                        try
                        {
                            con.Open();

                            string delete = "DELETE FROM Proveedor WHERE Proveedor_Id=@id";

                            using (var deleteD = new MySqlCommand(delete, con))
                            {
                                deleteD.Parameters.AddWithValue("@id", getId);
                                deleteD.ExecuteNonQuery();
                                LimpiarCampos();
                                infoProveedores();
                                MessageBox.Show("Proveedor eliminado exitosamente", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out getId))
                {
                    // correcto
                }
                else
                {
                    MessageBox.Show("El valor de la primera celda no es un número entero válido.");
                    return;
                }

                string Nombre = row.Cells[1].Value.ToString();
                string NIT = row.Cells[2].Value.ToString();
                string Telefono = row.Cells[3].Value.ToString();
                string Direccion = row.Cells[4].Value.ToString();

                txtNombre_Proveedor.Text = Nombre;
                txtNit_Proveedor.Text = NIT;
                txtTelefono_Proveedor.Text = Telefono;
                txtDireccion_Proveedor.Text = Direccion;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
