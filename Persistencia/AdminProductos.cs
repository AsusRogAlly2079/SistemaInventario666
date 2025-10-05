using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SistemaInventarioColchones.Controlador;
using MySql.Data.MySqlClient;

namespace SistemaInventarioColchones.Persistencia
{
    public partial class AdminProductos : UserControl
    {
        public AdminProductos()
        {
            InitializeComponent();
            infoProductos();
        }

        MySqlConnection con = new MySqlConnection("Server=bed32989.mysql.database.azure.com;Database=sistema_comercial;Uid=parradosamuel35;Pwd=RTX2080TIxz$;SslMode=Required;");

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
                    Proveedor prov ON p.Proveedor_Id = prov.Proveedor_Id";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
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
            return con.State == ConnectionState.Closed;
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

        private void label3_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }

        private void btnUsuario_Agregar_Click(object sender, EventArgs e)
        {
            if (txtProductos_Nombre.Text == "" || txtProductos_Descripcion.Text == "" || txtProductos_Marca.Text == "" || cmbProductos_Tamaño.SelectedIndex == -1 ||
                txtProductos_Material.Text == "" || txtProductos_Stock.Text == "" || txtProductos_Costo.Text == "" || txtProductos_Proveedor.Text == "")
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
                        string query = "SELECT * FROM Producto WHERE Nombre = @nom";
                        using (var cmd = new MySqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@nom", txtProductos_Nombre.Text.Trim());

                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(txtProductos_Nombre.Text + " El producto ya está creado", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertar = "INSERT INTO Producto (Nombre, Descripcion, Marca_Id, Tamaño, Material_Id, Stock, Costo, Proveedor_Id, Fecha_Creacion) VALUES " +
                                    "(@nom, @des, @marca, @tamaño, @mat, @stock, @costo, @prov, @fecha)";
                                using (var insert = new MySqlCommand(insertar, con))
                                {
                                    insert.Parameters.AddWithValue("@nom", txtProductos_Nombre.Text.Trim());
                                    insert.Parameters.AddWithValue("@des", txtProductos_Descripcion.Text.Trim());
                                    insert.Parameters.AddWithValue("@marca", txtProductos_Marca.Text.Trim()); // Si tienes combobox, usa SelectedValue
                                    insert.Parameters.AddWithValue("@tamaño", cmbProductos_Tamaño.SelectedItem.ToString());
                                    insert.Parameters.AddWithValue("@mat", txtProductos_Material.Text.Trim());
                                    insert.Parameters.AddWithValue("@stock", txtProductos_Stock.Text.Trim());
                                    insert.Parameters.AddWithValue("@costo", txtProductos_Costo.Text.Trim());
                                    insert.Parameters.AddWithValue("@prov", txtProductos_Proveedor.Text.Trim());
                                    insert.Parameters.AddWithValue("@fecha", DateTime.Now);
                                    insert.ExecuteNonQuery();
                                    LimpiarCampos();
                                    infoProductos();
                                    MessageBox.Show("Producto registrado exitosamente", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo agregar el nuevo producto: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Los campos están vacíos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Seguro que deseas modificar el Producto " + getId + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ConfirmarCon())
                    {
                        try
                        {
                            con.Open();
                            string update = "UPDATE Producto SET Nombre=@nom, Descripcion=@des, Marca_Id=@marca, Tamaño=@tamaño, Material_Id=@mat, Stock=@stock, Costo=@costo, Proveedor_Id=@prov WHERE Producto_Id=@id";
                            using (var updateD = new MySqlCommand(update, con))
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
                            MessageBox.Show("No se logró modificar el producto: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Los campos están vacíos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Seguro que deseas eliminar el Producto " + getId + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ConfirmarCon())
                    {
                        try
                        {
                            con.Open();
                            string delete = "DELETE FROM Producto WHERE Producto_Id=@id";
                            using (var deleteD = new MySqlCommand(delete, con))
                            {
                                deleteD.Parameters.AddWithValue("@id", getId);
                                deleteD.ExecuteNonQuery();
                                LimpiarCampos();
                                infoProductos();
                                MessageBox.Show("El producto ha sido eliminado exitosamente", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se logró eliminar el producto: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }

        private void txtProductos_Marca_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
