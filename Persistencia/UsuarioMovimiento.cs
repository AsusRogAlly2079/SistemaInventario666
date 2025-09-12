using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaInventarioColchones.Controlador;
using System.Xml.Linq;

namespace SistemaInventarioColchones.Persistencia
{
    public partial class UsuarioMovimiento : UserControl
    {
        private List<Movimiento> listaMovimientos = new List<Movimiento>();
        private SqlConnection con = new SqlConnection(@"Server=DESKTOP-TR972KR;Database=Bedware_;User Id=sa;Password=daniel1234;TrustServerCertificate=True");

        private class Movimiento
        {
            public int ProductoId { get; set; }
            public int ClienteId { get; set; }
            public int ProveedorId { get; set; }
            public string Especificacion { get; set; }
            public string Venta { get; set; }
        }

        public UsuarioMovimiento()
        {
            InitializeComponent();
            infoProductos();
        }

        public void infoProductos()
        {
            ProductosInfo infoo = new ProductosInfo();
            List<ProductosInfo> listData = infoo.Productos();

            dataGridView1.DataSource = listData;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private bool ConfirmarAccion()
        {
            return MessageBox.Show("¿Está seguro de que desea agregar este movimiento?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void LimpiarCampos()
        {
            txt_ProductoId.Text = "";
            txt_Nombre.Text = "";
            txt_Apellido.Text = "";
            txt_ProveedorId.Text = "";
            txt_Especificacion.Text = "";
            txt_Venta.Text = "";
        }

        private void ActualizarInformacion()
        {
            // Aquí puedes agregar código para actualizar la información en la interfaz de usuario
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (txt_ProductoId.Text== ""|| txt_Nombre.Text==""|| txt_Apellido.Text==""||txt_ProveedorId.Text==""||txt_Especificacion.Text==""||
                txt_Venta.Text=="")
            {
                MessageBox.Show("Por favor, complete todos los campos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int productoId = int.Parse(txt_ProductoId.Text);
                string nombre = txt_Nombre.Text;
                string apellido = txt_Apellido.Text;
                int proveedorId = int.Parse(txt_ProveedorId.Text);
                string especificacion = txt_Especificacion.Text;
                string venta = txt_Venta.Text;

                int clienteId = ObtenerClienteId(nombre, apellido);

                Movimiento movimiento = new Movimiento
                {
                    ProductoId = productoId,
                    ClienteId = clienteId,
                    ProveedorId = proveedorId,
                    Especificacion = especificacion,
                    Venta = venta
                };

                listaMovimientos.Add(movimiento);
                MessageBox.Show("Producto agregado exitosamente", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            } 
        }
        

        private int ObtenerClienteId(string nombre, string apellido)
        {
            string queryCliente = "SELECT Cliente_Id FROM Cliente WHERE Nombre = @Nombre AND Apellidos = @Apellido";
            using (SqlCommand cmdCliente = new SqlCommand(queryCliente, con))
            {
                cmdCliente.Parameters.AddWithValue("@Nombre", nombre);
                cmdCliente.Parameters.AddWithValue("@Apellido", apellido);
                return (int)cmdCliente.ExecuteScalar();
            }
        }

        private int ObtenerProveedorId(int productoId)
        {
            string queryProveedor = "SELECT Proveedor_Id FROM Producto WHERE Producto_Id = @ProductoId";
            using (SqlCommand cmdProveedor = new SqlCommand(queryProveedor, con))
            {
                cmdProveedor.Parameters.AddWithValue("@ProductoId", productoId);
                return (int)cmdProveedor.ExecuteScalar();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Factura_Click(object sender, EventArgs e)
        {
            GenerarFacturaPDF();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (listaMovimientos.Count > 0)
            {
                if (ConfirmarAccion())
                {
                    try
                    {
                        con.Open();
                        foreach (var movimiento in listaMovimientos)
                        {
                            string insertarMovimiento = "INSERT INTO Movimientos (Producto_Id, Cliente_Id, Proveedor_Id, Especificacion, Venta, Fecha_Registro, Usuario_Id) " +
                                                       "VALUES (@ProductoId, @ClienteId, @ProveedorId, @Especificacion, @Venta, @FechaRegistro, NULL)";
                            using (SqlCommand cmdMovimiento = new SqlCommand(insertarMovimiento, con))
                            {
                                cmdMovimiento.Parameters.AddWithValue("@ProductoId", movimiento.ProductoId);
                                cmdMovimiento.Parameters.AddWithValue("@ClienteId", movimiento.ClienteId);
                                cmdMovimiento.Parameters.AddWithValue("@ProveedorId", movimiento.ProveedorId);
                                cmdMovimiento.Parameters.AddWithValue("@Especificacion", movimiento.Especificacion);
                                cmdMovimiento.Parameters.AddWithValue("@Venta", movimiento.Venta);
                                cmdMovimiento.Parameters.AddWithValue("@FechaRegistro", DateTime.Now);
                                cmdMovimiento.ExecuteNonQuery();
                            }
                        }

                        // Generar la factura en PDF
                        GenerarFacturaPDF();

                        // Limpiar la lista de movimientos
                        listaMovimientos.Clear();
                        MessageBox.Show("Movimientos guardados y factura generada exitosamente", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar los movimientos: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay movimientos para guardar", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GenerarFacturaPDF()
        {
            // Crear un nuevo documento PDF
            Document document = new Document();

            try
            {
                // Crear un escritor PDF y asociarlo al documento
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("factura.pdf", FileMode.Create));

                // Abrir el documento
                document.Open();

                // Agregar el encabezado de la factura
                Paragraph header = new Paragraph("Factura de Venta // Sistema de Inventario Bedware");
                header.Alignment = Element.ALIGN_CENTER;
                document.Add(header);

                // Agregar la información del cajero
                Paragraph cashier = new Paragraph("Cajero: Nombre Cajero");
                document.Add(cashier);

                // Crear la tabla de productos
                PdfPTable table = new PdfPTable(6);
                table.WidthPercentage = 100;

                // Agregar las celdas de encabezado
                AddCell(table, "Producto ID");
                AddCell(table, "Nombre");
                AddCell(table, "Especificación");
                AddCell(table, "Cantidad");
                AddCell(table, "Precio");
                AddCell(table, "Total");

                // Agregar los detalles de los productos
                foreach (var movimiento in listaMovimientos)
                {
                    AddCell(table, movimiento.ProductoId.ToString());
                    AddCell(table, ObtenerNombreCliente(movimiento.ClienteId));
                    AddCell(table, movimiento.Especificacion);
                    AddCell(table, "1"); // Cantidad
                    AddCell(table, movimiento.Venta.ToString());
                    AddCell(table, (movimiento.Venta).ToString());
                }

                // Agregar la tabla al documento
                document.Add(table);

                // Agregar la información del cliente y proveedor
                Paragraph clientInfo = new Paragraph($"Nombre y Apellido del Cliente: {ObtenerNombreCliente(listaMovimientos[0].ClienteId)}");
                Paragraph providerInfo = new Paragraph($"Proveedor ID: {listaMovimientos[0].ProveedorId}");
                document.Add(clientInfo);
                document.Add(providerInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al generar la factura PDF: " + ex.Message);
            }
            finally
            {
                // Cerrar el documento
                document.Close();
            }
        }

        private string ObtenerNombreCliente(int clienteId)
        {
            string queryCliente = "SELECT Nombre, Apellidos FROM Cliente WHERE Cliente_Id = @ClienteId";
            using (SqlCommand cmdCliente = new SqlCommand(queryCliente, con))
            {
                cmdCliente.Parameters.AddWithValue("@ClienteId", clienteId);
                using (SqlDataReader reader = cmdCliente.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return $"{reader["Nombre"]} {reader["Apellidos"]}";
                    }
                }
            }
            return "N/A";
        }

        private static void AddCell(PdfPTable table, string text)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);
        }
    }
}
