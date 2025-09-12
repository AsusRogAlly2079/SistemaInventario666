using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaInventarioColchones.Controlador;
using System.Diagnostics.PerformanceData;

namespace SistemaInventarioColchones
{
    public partial class AdminProveedor: UserControl
    {

       

        public AdminProveedor()
        {
            InitializeComponent();
            infoProveedores();
        }

        SqlConnection
       con = new SqlConnection(@"Server=DESKTOP-TR972KR;Database=Bedware_;User Id=sa;Password=daniel1234;TrustServerCertificate=True");


        public void infoProveedores()
        {
            ProveedoresInfo infoo = new ProveedoresInfo();
            List<ProveedoresInfo> listData = infoo.Proveedores();

            dataGridView1.DataSource = listData;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuarios_Usuarios_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Agregar_Click(object sender, EventArgs e)
        {
            if (txtNombre_Proveedor.Text == "" || txtNit_Proveedor.Text == "" || txtTelefono_Proveedor.Text==""|| txtDireccion_Proveedor.Text =="")
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
                        string query = "Select * from Proveedor where Nombre = @nom";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@nom", txtNombre_Proveedor.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(txtNombre_Proveedor.Text + "El usuario ya esta creado", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertar = "Insert into Proveedor (Nombre,NIT,Telefono,Direccion,Fecha_Registro) values " +
                                    "(@nom,@nit,@tel,@dir,@fecha)";

                                using (SqlCommand insert = new SqlCommand(insertar, con))
                                {
                                    insert.Parameters.AddWithValue("@nom", txtNombre_Proveedor.Text.Trim());
                                    insert.Parameters.AddWithValue("@nit", txtNit_Proveedor.Text.Trim());
                                    insert.Parameters.AddWithValue("@tel", txtTelefono_Proveedor.Text.Trim());
                                    insert.Parameters.AddWithValue("dir", txtDireccion_Proveedor.Text.Trim());

                                    insert.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                                    insert.ExecuteNonQuery();
                                    LimpiarCampos();
                                    infoProveedores();
                                    MessageBox.Show("Proveedor registrado Exitosamente", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Conexión Fállida"+ ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

            txtNombre_Proveedor.Text = "";
            txtNit_Proveedor.Text = "";
           txtTelefono_Proveedor.Text="";
            txtDireccion_Proveedor.Text = "";
        }

        private void btnUsuario_Modificar_Click(object sender, EventArgs e)
        {
            if (txtNombre_Proveedor.Text == "" || txtNit_Proveedor.Text == "" || txtTelefono_Proveedor.Text == ""|| txtDireccion_Proveedor.Text == "")
            {
                MessageBox.Show("Los campos estan vacíos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (MessageBox.Show("Seguro que deseas modificar el Proveedor" + getId + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ConfirmarCon())
                    {
                        try
                        {
                            con.Open();

                            string update = "Update Proveedor set Nombre=@nom,NIT=@nit,Telefono=@tel,Direccion=@dir where Proveedor_ID= @id";

                          

                            using (SqlCommand updateD = new SqlCommand(update, con))
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

     

        private void btnUsuario_Eliminar_Click(object sender, EventArgs e)
        {
            if (txtNombre_Proveedor.Text == "" || txtNit_Proveedor.Text == "" || txtTelefono_Proveedor.Text== ""|| txtDireccion_Proveedor.Text=="")
            {
                MessageBox.Show("Los campos estan vacíos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                            string delete = "Delete from Proveedor where Proveedor_ID= @id";


                            using (SqlCommand deleteD = new SqlCommand(delete, con))
                            {

                                deleteD.Parameters.AddWithValue("id", getId);
                                deleteD.ExecuteNonQuery();
                                LimpiarCampos();
                                infoProveedores();
                                MessageBox.Show("Proveedor eliminado exitosamente", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                        // El valor de la primera celda no se pudo convertir a int
                        // Manejar el error adecuadamente, por ejemplo, mostrando un mensaje de error
                        MessageBox.Show("El valor de la primera celda no es un número entero válido.");
                        return;
                    }
                    string Nombre = row.Cells[1].Value.ToString();
                    string NIT = row.Cells[2].Value.ToString();
                    string Telefono = row.Cells[3].Value.ToString();
                    string Direccion= row.Cells[4].Value.ToString();

                    txtNombre_Proveedor.Text = Nombre;
                  txtNit_Proveedor.Text = NIT;
                   txtTelefono_Proveedor.Text = Telefono;
                txtDireccion_Proveedor.Text= Direccion;
                
              } 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
