using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaInventarioColchones.Controlador;

namespace SistemaInventarioColchones.Persistencia
{
    public partial class AdminProductos : UserControl
    {
        public AdminProductos()
        {
            InitializeComponent();
            infoProductos();
        }

        SqlConnection
       con = new SqlConnection(@"Server=DESKTOP-TR972KR;Database=Bedware_;User Id=sa;Password=daniel1234;TrustServerCertificate=True");

        public void infoProductos()
        {
             ProductosInfo infoo = new ProductosInfo();
             List<ProductosInfo> listData = infoo.Productos();

            dataGridView1.DataSource = listData;

           if (ConfirmarCon())
            {
                try
                {
                    con.Open();
                    string query = @"
                SELECT 
                    p.Producto_Id,
                    p.Nombre AS Nombre_Producto,
                    p.Descripcion,
                    m.Nombre AS Marca,
                    p.Tamaño,
                    mat.Nombre AS Material,
                    p.Stock,
                    p.Costo,
                    prov.Nombre AS Proveedor,
                    p.Fecha_Creacion
                FROM 
                    Producto p
                JOIN 
                    Marca m ON p.Marca_Id = m.Marca_Id
                JOIN 
                    Material mat ON p.Material_Id = mat.Material_Id
                JOIN
                    Proveedor prov ON p.Proveedor_Id = prov.Proveedor_ID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table; // Asignar el DataTable al DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
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

            txtProductos_Nombre.Text = "";
            txtProductos_Descripcion.Text = "";
            txtProductos_Marca.Text = "";
            cmbProductos_Tamaño.SelectedIndex = -1;
            txtProductos_Material.Text = "";
            txtProductos_Stock.Text = "";
            txtProductos_Costo.Text = "";
            txtProductos_Proveedor.Text = "";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Agregar_Click(object sender, EventArgs e)
        {
            if (txtProductos_Nombre.Text == "" || txtProductos_Descripcion.Text == "" || txtProductos_Marca.Text == "" || cmbProductos_Tamaño.SelectedIndex == -1 ||
                txtProductos_Material.Text == "" || txtProductos_Stock.Text == "" || txtProductos_Costo.Text == "" || txtProductos_Proveedor.Text == "")
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
                        string query = "Select * from Producto where Nombre = @nom";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@nom", txtProductos_Nombre.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(txtProductos_Nombre.Text + " El usuario ya esta creado", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertar = "Insert into Producto (Nombre,Descripcion,Marca_Id,Tamaño,Material_Id,Stock,Costo,Proveedor_Id,Fecha_Creacion) values " +
                                    "(@nom,@des,@marca,@tamaño,@mat,@stock,@costo,@prov,@fecha)";

                                using (SqlCommand insert = new SqlCommand(insertar, con))
                                {
                                    insert.Parameters.AddWithValue("@nom", txtProductos_Nombre.Text.Trim());
                                    insert.Parameters.AddWithValue("@des", txtProductos_Descripcion.Text.Trim());
                                    insert.Parameters.AddWithValue("@marca", txtProductos_Marca.Text.Trim());
                                    insert.Parameters.AddWithValue("@tamaño", cmbProductos_Tamaño.SelectedItem.ToString());
                                    insert.Parameters.AddWithValue("@mat", txtProductos_Material.Text.Trim());
                                    insert.Parameters.AddWithValue("@stock", txtProductos_Stock.Text.Trim());
                                    insert.Parameters.AddWithValue("@costo", txtProductos_Costo.Text.Trim());
                                    insert.Parameters.AddWithValue("@prov", txtProductos_Proveedor.Text.Trim());
                                    insert.Parameters.AddWithValue("@fecha", DateTime.Now);
                                    insert.ExecuteNonQuery();
                                    LimpiarCampos();
                                    infoProductos();
                                    MessageBox.Show("Usuario registrado Exitosamente", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("No se pudo agregar el nuevo producto"+ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {

                        con.Close();
                    }
                }
            }
        }

        private void btnProductos_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnProductos_Modificar_Click(object sender, EventArgs e)
        {
            if (txtProductos_Nombre.Text == "" || txtProductos_Descripcion.Text == "" || txtProductos_Marca.Text == "" || cmbProductos_Tamaño.SelectedIndex == -1 ||
                txtProductos_Material.Text == "" || txtProductos_Stock.Text == "" || txtProductos_Costo.Text == "" || txtProductos_Proveedor.Text == "")
            {
                MessageBox.Show("Los campos estan vacíos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (MessageBox.Show("Seguro que deseas modificar el Producto " + getId + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ConfirmarCon())
                    {
                        try
                        {
                            con.Open();

                            string update = "Update Producto set Nombre=@nom,Descripcion=@des,Marca_Id=@marca," +
                                "Tamaño=@tamaño,Material_Id=@mat,Stock=@stock,Costo=@costo,Proveedor_Id=@prov where Producto_Id= @id";


                            using (SqlCommand updateD = new SqlCommand(update, con))
                            {
                                updateD.Parameters.AddWithValue("@nom", txtProductos_Nombre.Text.Trim());
                                updateD.Parameters.AddWithValue("@des", txtProductos_Descripcion.Text.Trim());
                                updateD.Parameters.AddWithValue("@marca", txtProductos_Marca.Text.Trim());
                                updateD.Parameters.AddWithValue("@tamaño", cmbProductos_Tamaño.SelectedItem.ToString());
                                updateD.Parameters.AddWithValue("@mat", txtProductos_Material.Text.Trim());
                                updateD.Parameters.AddWithValue("@stock", txtProductos_Stock.Text.Trim());
                                updateD.Parameters.AddWithValue("@costo", txtProductos_Costo.Text.Trim());
                                updateD.Parameters.AddWithValue("@prov", txtProductos_Proveedor.Text.Trim());
                                updateD.Parameters.AddWithValue("@id", getId);
                                updateD.ExecuteNonQuery();
                                LimpiarCampos();
                                infoProductos();
                                MessageBox.Show("El producto ha sido modificado exitosamente", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }



                        catch (Exception ex)
                        {

                            MessageBox.Show("No se ha logro modificar el producto" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                string Descripcion = row.Cells[2].Value.ToString();
                string Marca = row.Cells[3].Value.ToString();
                string Tamaño = row.Cells[4].Value.ToString();
                string Material = row.Cells[5].Value.ToString();
                string Stock = row.Cells[6].Value.ToString();
                string Costo = row.Cells[7].Value.ToString();
                string Proveedor = row.Cells[8].Value.ToString();

                txtProductos_Nombre.Text = Nombre;
                txtProductos_Descripcion.Text = Descripcion;
                txtProductos_Marca.Text = Marca;
                cmbProductos_Tamaño.Text = Tamaño;
                txtProductos_Material.Text = Material;
                txtProductos_Stock.Text = Stock;
                txtProductos_Costo.Text = Costo;
                txtProductos_Proveedor.Text = Proveedor;


            }
        }

        private void btnProductos_Eliminar_Click(object sender, EventArgs e)
        {
            if (txtProductos_Nombre.Text == "" || txtProductos_Descripcion.Text == "" || txtProductos_Marca.Text == "" || cmbProductos_Tamaño.SelectedIndex == -1 ||
                txtProductos_Material.Text == "" || txtProductos_Stock.Text == "" || txtProductos_Costo.Text == "" || txtProductos_Proveedor.Text == "")
            {
                MessageBox.Show("Los campos estan vacíos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (MessageBox.Show("Seguro que deseas eliminar el Producto " + getId + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ConfirmarCon())
                    {
                        try
                        {
                            con.Open();

                            string delete = "Delete from Producto where Producto_Id= @id";


                            using (SqlCommand deleteD = new SqlCommand(delete, con))
                            {

                                deleteD.Parameters.AddWithValue("id", getId);
                                deleteD.ExecuteNonQuery();
                                LimpiarCampos();
                                infoProductos();
                                MessageBox.Show("El producto ha sido eliminado exitosamente", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }



                        catch (Exception ex)
                        {

                            MessageBox.Show("No se ha logrado eliminar el producto" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {

                            con.Close();
                        }
                    }
                }

            }
        }

        private void txtProductos_Marca_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
